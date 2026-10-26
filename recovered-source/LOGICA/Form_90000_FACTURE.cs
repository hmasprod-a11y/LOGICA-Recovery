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
public class Form_90000_FACTURE : Form
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

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Text_CODE_FIND")]
	private TextBox _Text_CODE_FIND;

	[AccessedThroughProperty("Text_PU_TTC")]
	private TextBox _Text_PU_TTC;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Button_FIND")]
	private Button _Button_FIND;

	[AccessedThroughProperty("DataGrid_BODY")]
	private DataGridView _DataGrid_BODY;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Text_UTILISATEUR")]
	private TextBox _Text_UTILISATEUR;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Text_ID_FACTURE")]
	private TextBox _Text_ID_FACTURE;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_NOTES")]
	private TextBox _Text_NOTES;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Text_ETAT")]
	private TextBox _Text_ETAT;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Button_CALC_DOC")]
	private Button _Button_CALC_DOC;

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

	[AccessedThroughProperty("Button_CLIENT")]
	private Button_ID_CODE _Button_CLIENT;

	[AccessedThroughProperty("Text_PU_HT")]
	private TextBox _Text_PU_HT;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Text_TAUX_TVA")]
	private TextBox _Text_TAUX_TVA;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Panel243544")]
	private Panel _Panel243544;

	[AccessedThroughProperty("Button_VALIDER")]
	private Button _Button_VALIDER;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Text_ARTICLE_FIND")]
	private TextBox _Text_ARTICLE_FIND;

	[AccessedThroughProperty("DataGridView_ARTICLES")]
	private DataGridView _DataGridView_ARTICLES;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Text_CODE")]
	private TextBox _Text_CODE;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Text_ARTICLE")]
	private TextBox _Text_ARTICLE;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("DataGridView_FAMILLES")]
	private DataGridView _DataGridView_FAMILLES;

	[AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

	[AccessedThroughProperty("Panel7727")]
	private Panel _Panel7727;

	[AccessedThroughProperty("Button_CALC_ENREGISTRER")]
	private Button _Button_CALC_ENREGISTRER;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("TextBox33398")]
	private TextBox _TextBox33398;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("RadioButton_TICKET")]
	private RadioButton _RadioButton_TICKET;

	[AccessedThroughProperty("RadioButton_DEVIS")]
	private RadioButton _RadioButton_DEVIS;

	[AccessedThroughProperty("RadioButton_BL")]
	private RadioButton _RadioButton_BL;

	[AccessedThroughProperty("Button_GO")]
	private Button _Button_GO;

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button _Button_FONCTIONS;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("Button_PDF")]
	private Button _Button_PDF;

	[AccessedThroughProperty("Button_EXCEL")]
	private Button _Button_EXCEL;

	[AccessedThroughProperty("Button_WORD")]
	private Button _Button_WORD;

	[AccessedThroughProperty("Button_SPLITE")]
	private Button _Button_SPLITE;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Text_pied_doc")]
	private TextBox _Text_pied_doc;

	[AccessedThroughProperty("PictureBox2323")]
	private PictureBox _PictureBox2323;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("Text_ID_ARTICLE")]
	private TextBox _Text_ID_ARTICLE;

	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[AccessedThroughProperty("DataGridViewTextBoxColumn14")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;

	[AccessedThroughProperty("DataGridViewTextBoxColumn15")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("PU_TTC")]
	private DataGridViewTextBoxColumn _PU_TTC;

	[AccessedThroughProperty("TAUX_TVA")]
	private DataGridViewTextBoxColumn _TAUX_TVA;

	[AccessedThroughProperty("PU_HT")]
	private DataGridViewTextBoxColumn _PU_HT;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("TOTAL_TTC")]
	private DataGridViewTextBoxColumn _TOTAL_TTC;

	[AccessedThroughProperty("TOTAL_TVA")]
	private DataGridViewTextBoxColumn _TOTAL_TVA;

	[AccessedThroughProperty("TOTAL_HT")]
	private DataGridViewTextBoxColumn _TOTAL_HT;

	[AccessedThroughProperty("TAUX_REMISE")]
	private DataGridViewTextBoxColumn _TAUX_REMISE;

	[AccessedThroughProperty("sup")]
	private DataGridViewImageColumn _sup;

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

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

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

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Label_TOTAL_TTC_BD")]
	private Label _Label_TOTAL_TTC_BD;

	[AccessedThroughProperty("Label54")]
	private Label _Label54;

	[AccessedThroughProperty("Label_TOTAL_TVA_BD")]
	private Label _Label_TOTAL_TVA_BD;

	[AccessedThroughProperty("Label_TOTAL_HT_BD")]
	private Label _Label_TOTAL_HT_BD;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("Label52")]
	private Label _Label52;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label_TOTAL_LIGNES")]
	private Label _Label_TOTAL_LIGNES;

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

	[AccessedThroughProperty("ID_ARTICLEE")]
	private DataGridViewTextBoxColumn _ID_ARTICLEE;

	[AccessedThroughProperty("Codee")]
	private DataGridViewTextBoxColumn _Codee;

	[AccessedThroughProperty("Articlee")]
	private DataGridViewTextBoxColumn _Articlee;

	[AccessedThroughProperty("PU_TTCC")]
	private DataGridViewTextBoxColumn _PU_TTCC;

	[AccessedThroughProperty("TAUX_TVAA")]
	private DataGridViewTextBoxColumn _TAUX_TVAA;

	[AccessedThroughProperty("PU_HTT")]
	private DataGridViewTextBoxColumn _PU_HTT;

	[AccessedThroughProperty("QTEE")]
	private DataGridViewTextBoxColumn _QTEE;

	[AccessedThroughProperty("TOTAL_TTCC")]
	private DataGridViewTextBoxColumn _TOTAL_TTCC;

	[AccessedThroughProperty("TOTAL_TVAA")]
	private DataGridViewTextBoxColumn _TOTAL_TVAA;

	[AccessedThroughProperty("TOTAL_HTT")]
	private DataGridViewTextBoxColumn _TOTAL_HTT;

	[AccessedThroughProperty("TAUX_REMISEE")]
	private DataGridViewTextBoxColumn _TAUX_REMISEE;

	[AccessedThroughProperty("Button_MOINS")]
	private Button _Button_MOINS;

	[AccessedThroughProperty("Button_PLUS")]
	private Button _Button_PLUS;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("ID_FACTURE")]
	private DataGridViewTextBoxColumn _ID_FACTURE;

	[AccessedThroughProperty("UTILISATEUR")]
	private DataGridViewTextBoxColumn _UTILISATEUR;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("TOTAL_HT_DOC")]
	private DataGridViewTextBoxColumn _TOTAL_HT_DOC;

	[AccessedThroughProperty("TOTAL_TVA_DOC")]
	private DataGridViewTextBoxColumn _TOTAL_TVA_DOC;

	[AccessedThroughProperty("TOTAL_TTC_DOC")]
	private DataGridViewTextBoxColumn _TOTAL_TTC_DOC;

	[AccessedThroughProperty("ETAT")]
	private DataGridViewTextBoxColumn _ETAT;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

	[AccessedThroughProperty("cons")]
	private DataGridViewImageColumn _cons;

	[AccessedThroughProperty("Label_TOTAL_REMISE_DOC")]
	private Label _Label_TOTAL_REMISE_DOC;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("Label_TOTAL_HT_DOC")]
	private Label _Label_TOTAL_HT_DOC;

	[AccessedThroughProperty("Label56")]
	private Label _Label56;

	[AccessedThroughProperty("Label_TOTAL_TVA_DOC")]
	private Label _Label_TOTAL_TVA_DOC;

	[AccessedThroughProperty("Label_TOTAL_TTC_DOC")]
	private Label _Label_TOTAL_TTC_DOC;

	[AccessedThroughProperty("Label53")]
	private Label _Label53;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private string _HTTTC;

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
			EventHandler eventHandler = Button_ADD_Click;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel_INFO_Paint;
			if (_Panel_INFO != null)
			{
				((Control)_Panel_INFO).Paint -= val;
			}
			_Panel_INFO = value;
			if (_Panel_INFO != null)
			{
				((Control)_Panel_INFO).Paint += val;
			}
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_CODE_TextChanged;
			EventHandler eventHandler2 = TextBox_LostFocus;
			EventHandler eventHandler3 = TextBox_GotFocus;
			KeyEventHandler val = Text_CODE_KeyDown;
			if (_Text_CODE_FIND != null)
			{
				((Control)_Text_CODE_FIND).TextChanged -= eventHandler;
				((Control)_Text_CODE_FIND).LostFocus -= eventHandler2;
				((Control)_Text_CODE_FIND).GotFocus -= eventHandler3;
				((Control)_Text_CODE_FIND).KeyDown -= val;
			}
			_Text_CODE_FIND = value;
			if (_Text_CODE_FIND != null)
			{
				((Control)_Text_CODE_FIND).TextChanged += eventHandler;
				((Control)_Text_CODE_FIND).LostFocus += eventHandler2;
				((Control)_Text_CODE_FIND).GotFocus += eventHandler3;
				((Control)_Text_CODE_FIND).KeyDown += val;
			}
		}
	}

	internal virtual TextBox Text_PU_TTC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PU_TTC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_PU_TTC_LostFocus;
			KeyEventHandler val = Text_PU_TTC_KeyDown;
			KeyPressEventHandler val2 = Text_PU_TTC_KeyPress;
			EventHandler eventHandler2 = Text_PU_TTC_TextChanged;
			if (_Text_PU_TTC != null)
			{
				((Control)_Text_PU_TTC).LostFocus -= eventHandler;
				((Control)_Text_PU_TTC).KeyDown -= val;
				((Control)_Text_PU_TTC).KeyPress -= val2;
				((Control)_Text_PU_TTC).TextChanged -= eventHandler2;
			}
			_Text_PU_TTC = value;
			if (_Text_PU_TTC != null)
			{
				((Control)_Text_PU_TTC).LostFocus += eventHandler;
				((Control)_Text_PU_TTC).KeyDown += val;
				((Control)_Text_PU_TTC).KeyPress += val2;
				((Control)_Text_PU_TTC).TextChanged += eventHandler2;
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
			DataGridViewCellEventHandler val = DataGrid_BODY_CellValidated;
			DataGridViewCellEventHandler val2 = DataGrid_BODY_CellContentClick;
			DataGridViewCellEventHandler val3 = DataGrid_BODY_CellEnter;
			DataGridViewEditingControlShowingEventHandler val4 = DataGrid_BODY_EditingControlShowing;
			if (_DataGrid_BODY != null)
			{
				_DataGrid_BODY.CellValidated -= val;
				_DataGrid_BODY.CellContentClick -= val2;
				_DataGrid_BODY.CellEnter -= val3;
				_DataGrid_BODY.EditingControlShowing -= val4;
			}
			_DataGrid_BODY = value;
			if (_DataGrid_BODY != null)
			{
				_DataGrid_BODY.CellValidated += val;
				_DataGrid_BODY.CellContentClick += val2;
				_DataGrid_BODY.CellEnter += val3;
				_DataGrid_BODY.EditingControlShowing += val4;
			}
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

	internal virtual TextBox Text_ID_FACTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_FACTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_FACTURE = value;
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

	internal virtual Button_ID_CODE Button_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLIENT_Click;
			if (_Button_CLIENT != null)
			{
				((Control)_Button_CLIENT).Click -= eventHandler;
			}
			_Button_CLIENT = value;
			if (_Button_CLIENT != null)
			{
				((Control)_Button_CLIENT).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_PU_HT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PU_HT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_PU_HT_LostFocus;
			KeyEventHandler val = Text_PU_HT_KeyDown;
			KeyPressEventHandler val2 = Text_PU_HT_KeyPress;
			EventHandler eventHandler2 = Text_PU_HT_TextChanged;
			if (_Text_PU_HT != null)
			{
				((Control)_Text_PU_HT).LostFocus -= eventHandler;
				((Control)_Text_PU_HT).KeyDown -= val;
				((Control)_Text_PU_HT).KeyPress -= val2;
				((Control)_Text_PU_HT).TextChanged -= eventHandler2;
			}
			_Text_PU_HT = value;
			if (_Text_PU_HT != null)
			{
				((Control)_Text_PU_HT).LostFocus += eventHandler;
				((Control)_Text_PU_HT).KeyDown += val;
				((Control)_Text_PU_HT).KeyPress += val2;
				((Control)_Text_PU_HT).TextChanged += eventHandler2;
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

	internal virtual TextBox Text_TAUX_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TAUX_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_TAUX_TVA_LostFocus;
			KeyEventHandler val = Text_TAUX_TVA_KeyDown;
			KeyPressEventHandler val2 = Text_TAUX_TVA_KeyPress;
			EventHandler eventHandler2 = Text_TAUX_TVA_TextChanged;
			if (_Text_TAUX_TVA != null)
			{
				((Control)_Text_TAUX_TVA).LostFocus -= eventHandler;
				((Control)_Text_TAUX_TVA).KeyDown -= val;
				((Control)_Text_TAUX_TVA).KeyPress -= val2;
				((Control)_Text_TAUX_TVA).TextChanged -= eventHandler2;
			}
			_Text_TAUX_TVA = value;
			if (_Text_TAUX_TVA != null)
			{
				((Control)_Text_TAUX_TVA).LostFocus += eventHandler;
				((Control)_Text_TAUX_TVA).KeyDown += val;
				((Control)_Text_TAUX_TVA).KeyPress += val2;
				((Control)_Text_TAUX_TVA).TextChanged += eventHandler2;
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
			_Button3 = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyEventHandler val = Text_ARTICLE_FIND_KeyDown;
			EventHandler eventHandler = Text_ARTICLE_FIND_TextChanged;
			if (_Text_ARTICLE_FIND != null)
			{
				((Control)_Text_ARTICLE_FIND).KeyDown -= val;
				((Control)_Text_ARTICLE_FIND).TextChanged -= eventHandler;
			}
			_Text_ARTICLE_FIND = value;
			if (_Text_ARTICLE_FIND != null)
			{
				((Control)_Text_ARTICLE_FIND).KeyDown += val;
				((Control)_Text_ARTICLE_FIND).TextChanged += eventHandler;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView3_Click;
			DataGridViewCellEventHandler val = DataGridView3_CellContentClick;
			if (_DataGridView3 != null)
			{
				((Control)_DataGridView3).Click -= eventHandler;
				_DataGridView3.CellContentClick -= val;
			}
			_DataGridView3 = value;
			if (_DataGridView3 != null)
			{
				((Control)_DataGridView3).Click += eventHandler;
				_DataGridView3.CellContentClick += val;
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

	internal virtual RadioButton RadioButton_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton_TICKET = value;
		}
	}

	internal virtual RadioButton RadioButton_DEVIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_DEVIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton_DEVIS = value;
		}
	}

	internal virtual RadioButton RadioButton_BL
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_BL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton_BL = value;
		}
	}

	internal virtual Button Button_GO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_GO_Click;
			if (_Button_GO != null)
			{
				((Control)_Button_GO).Click -= eventHandler;
			}
			_Button_GO = value;
			if (_Button_GO != null)
			{
				((Control)_Button_GO).Click += eventHandler;
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

	internal virtual DataGridViewTextBoxColumn PU_TTC
	{
		[DebuggerNonUserCode]
		get
		{
			return _PU_TTC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PU_TTC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAUX_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAUX_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAUX_TVA = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PU_HT
	{
		[DebuggerNonUserCode]
		get
		{
			return _PU_HT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PU_HT = value;
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

	internal virtual DataGridViewTextBoxColumn TOTAL_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TVA = value;
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

	internal virtual DataGridViewTextBoxColumn TAUX_REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAUX_REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAUX_REMISE = value;
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

	internal virtual Label Label_TOTAL_TTC_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_TTC_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_TTC_BD = value;
		}
	}

	internal virtual Label Label54
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label54 = value;
		}
	}

	internal virtual Label Label_TOTAL_TVA_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_TVA_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_TVA_BD = value;
		}
	}

	internal virtual Label Label_TOTAL_HT_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_HT_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_HT_BD = value;
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

	internal virtual DataGridViewTextBoxColumn ID_ARTICLEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_ARTICLEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_ARTICLEE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Codee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Codee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Codee = value;
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

	internal virtual DataGridViewTextBoxColumn PU_TTCC
	{
		[DebuggerNonUserCode]
		get
		{
			return _PU_TTCC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PU_TTCC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAUX_TVAA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAUX_TVAA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAUX_TVAA = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PU_HTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _PU_HTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PU_HTT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn QTEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _QTEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_QTEE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_TTCC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TTCC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TTCC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_TVAA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TVAA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TVAA = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_HTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_HTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_HTT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAUX_REMISEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAUX_REMISEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAUX_REMISEE = value;
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

	internal virtual DataGridViewTextBoxColumn ID_FACTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_FACTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_FACTURE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UTILISATEUR = value;
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

	internal virtual DataGridViewTextBoxColumn TOTAL_HT_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_HT_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_HT_DOC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_TVA_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TVA_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TVA_DOC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_TTC_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TTC_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TTC_DOC = value;
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

	internal virtual Label Label_TOTAL_REMISE_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_REMISE_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_REMISE_DOC = value;
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

	internal virtual Label Label_TOTAL_HT_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_HT_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_HT_DOC = value;
		}
	}

	internal virtual Label Label56
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label56 = value;
		}
	}

	internal virtual Label Label_TOTAL_TVA_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_TVA_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_TVA_DOC = value;
		}
	}

	internal virtual Label Label_TOTAL_TTC_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_TTC_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_TTC_DOC = value;
		}
	}

	internal virtual Label Label53
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label53 = value;
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

	public Form_90000_FACTURE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).FormClosed += Form_6_RECEPTIONS_FormClosed;
		((Form)this).Load += Form_Load;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		_HTTTC = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("HT_TTC", false, 0).Index].SubItems[1].Text;
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
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
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Obj, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected Obj, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected Obj, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected Obj, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected Obj, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected Obj, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected Obj, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected Obj, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected Obj, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected Obj, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected Obj, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected Obj, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected Obj, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected Obj, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected Obj, but got Unknown
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected Obj, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected Obj, but got Unknown
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got Unknown
		//IL_117b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Expected Obj, but got Unknown
		//IL_1277: Unknown result type (might be due to invalid IL or missing references)
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Expected Obj, but got Unknown
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected Obj, but got Unknown
		//IL_1498: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1563: Unknown result type (might be due to invalid IL or missing references)
		//IL_156d: Expected Obj, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Expected Obj, but got Unknown
		//IL_16af: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Expected Obj, but got Unknown
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1884: Unknown result type (might be due to invalid IL or missing references)
		//IL_188e: Expected Obj, but got Unknown
		//IL_18c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_198d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1997: Expected Obj, but got Unknown
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa0: Expected Obj, but got Unknown
		//IL_1ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ace: Expected Obj, but got Unknown
		//IL_1af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb8: Expected Obj, but got Unknown
		//IL_1bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc5: Expected Obj, but got Unknown
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd1: Expected Obj, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed8: Expected Obj, but got Unknown
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2019: Unknown result type (might be due to invalid IL or missing references)
		//IL_2023: Expected Obj, but got Unknown
		//IL_2230: Unknown result type (might be due to invalid IL or missing references)
		//IL_223a: Expected Obj, but got Unknown
		//IL_2310: Unknown result type (might be due to invalid IL or missing references)
		//IL_231a: Expected Obj, but got Unknown
		//IL_23dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e6: Expected Obj, but got Unknown
		//IL_2545: Unknown result type (might be due to invalid IL or missing references)
		//IL_254f: Expected Obj, but got Unknown
		//IL_2645: Unknown result type (might be due to invalid IL or missing references)
		//IL_264b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2856: Unknown result type (might be due to invalid IL or missing references)
		//IL_2860: Expected Obj, but got Unknown
		//IL_2915: Unknown result type (might be due to invalid IL or missing references)
		//IL_291f: Expected Obj, but got Unknown
		//IL_29bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c5: Expected Obj, but got Unknown
		//IL_2a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7b: Expected Obj, but got Unknown
		//IL_2b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5a: Expected Obj, but got Unknown
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c25: Expected Obj, but got Unknown
		//IL_2ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd7: Expected Obj, but got Unknown
		//IL_2d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d96: Expected Obj, but got Unknown
		//IL_2e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e49: Expected Obj, but got Unknown
		//IL_2f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f18: Expected Obj, but got Unknown
		//IL_2faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb4: Expected Obj, but got Unknown
		//IL_306c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3076: Expected Obj, but got Unknown
		//IL_3101: Unknown result type (might be due to invalid IL or missing references)
		//IL_310b: Expected Obj, but got Unknown
		//IL_3303: Unknown result type (might be due to invalid IL or missing references)
		//IL_330d: Expected Obj, but got Unknown
		//IL_33ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f8: Expected Obj, but got Unknown
		//IL_3482: Unknown result type (might be due to invalid IL or missing references)
		//IL_348c: Expected Obj, but got Unknown
		//IL_3541: Unknown result type (might be due to invalid IL or missing references)
		//IL_354b: Expected Obj, but got Unknown
		//IL_35e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ed: Expected Obj, but got Unknown
		//IL_36c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_36cc: Expected Obj, but got Unknown
		//IL_3768: Unknown result type (might be due to invalid IL or missing references)
		//IL_3772: Expected Obj, but got Unknown
		//IL_3847: Unknown result type (might be due to invalid IL or missing references)
		//IL_3851: Expected Obj, but got Unknown
		//IL_394a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3950: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca1: Expected Obj, but got Unknown
		//IL_3fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff2: Expected Obj, but got Unknown
		//IL_40b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c1: Expected Obj, but got Unknown
		//IL_4182: Unknown result type (might be due to invalid IL or missing references)
		//IL_418c: Expected Obj, but got Unknown
		//IL_4251: Unknown result type (might be due to invalid IL or missing references)
		//IL_425b: Expected Obj, but got Unknown
		//IL_4304: Unknown result type (might be due to invalid IL or missing references)
		//IL_430e: Expected Obj, but got Unknown
		//IL_43bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c5: Expected Obj, but got Unknown
		//IL_4479: Unknown result type (might be due to invalid IL or missing references)
		//IL_4483: Expected Obj, but got Unknown
		//IL_44f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_44fa: Expected Obj, but got Unknown
		//IL_47d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_47de: Expected Obj, but got Unknown
		//IL_47f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_47fb: Expected Obj, but got Unknown
		//IL_489e: Unknown result type (might be due to invalid IL or missing references)
		//IL_48a8: Expected Obj, but got Unknown
		//IL_48bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_48c5: Expected Obj, but got Unknown
		//IL_494f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4959: Expected Obj, but got Unknown
		//IL_4a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a0a: Expected Obj, but got Unknown
		//IL_4a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a90: Expected Obj, but got Unknown
		//IL_4b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b6f: Expected Obj, but got Unknown
		//IL_4c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c30: Expected Obj, but got Unknown
		//IL_4ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cb3: Expected Obj, but got Unknown
		//IL_4d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d80: Expected Obj, but got Unknown
		//IL_4dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e06: Expected Obj, but got Unknown
		//IL_4ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ee1: Expected Obj, but got Unknown
		//IL_4f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f87: Expected Obj, but got Unknown
		//IL_5058: Unknown result type (might be due to invalid IL or missing references)
		//IL_5062: Expected Obj, but got Unknown
		//IL_50fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5104: Expected Obj, but got Unknown
		//IL_51d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_51df: Expected Obj, but got Unknown
		//IL_529e: Unknown result type (might be due to invalid IL or missing references)
		//IL_52a8: Expected Obj, but got Unknown
		//IL_52cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d6: Expected Obj, but got Unknown
		//IL_539c: Unknown result type (might be due to invalid IL or missing references)
		//IL_53a6: Expected Obj, but got Unknown
		//IL_5430: Unknown result type (might be due to invalid IL or missing references)
		//IL_543a: Expected Obj, but got Unknown
		//IL_54b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_54c0: Expected Obj, but got Unknown
		//IL_5576: Unknown result type (might be due to invalid IL or missing references)
		//IL_5580: Expected Obj, but got Unknown
		//IL_55f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5603: Expected Obj, but got Unknown
		//IL_5798: Unknown result type (might be due to invalid IL or missing references)
		//IL_579e: Unknown result type (might be due to invalid IL or missing references)
		//IL_57f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5800: Expected Obj, but got Unknown
		//IL_5895: Unknown result type (might be due to invalid IL or missing references)
		//IL_589f: Expected Obj, but got Unknown
		//IL_592a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5934: Expected Obj, but got Unknown
		//IL_59da: Unknown result type (might be due to invalid IL or missing references)
		//IL_59e4: Expected Obj, but got Unknown
		//IL_5a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a12: Expected Obj, but got Unknown
		//IL_5a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c29: Expected Obj, but got Unknown
		//IL_5ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cf5: Expected Obj, but got Unknown
		//IL_5db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dbd: Expected Obj, but got Unknown
		//IL_5e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e89: Expected Obj, but got Unknown
		//IL_5f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f43: Expected Obj, but got Unknown
		//IL_5fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ff8: Expected Obj, but got Unknown
		//IL_60a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_60aa: Expected Obj, but got Unknown
		//IL_67f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6801: Expected Obj, but got Unknown
		//IL_6825: Unknown result type (might be due to invalid IL or missing references)
		//IL_682f: Expected Obj, but got Unknown
		//IL_6906: Unknown result type (might be due to invalid IL or missing references)
		//IL_6910: Expected Obj, but got Unknown
		//IL_69d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_69df: Expected Obj, but got Unknown
		//IL_6aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6aab: Expected Obj, but got Unknown
		//IL_6b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b7c: Expected Obj, but got Unknown
		//IL_6c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c5a: Expected Obj, but got Unknown
		//IL_6d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d2c: Expected Obj, but got Unknown
		//IL_6d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d5a: Expected Obj, but got Unknown
		//IL_6d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e4d: Expected Obj, but got Unknown
		//IL_6e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e7b: Expected Obj, but got Unknown
		//IL_6eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f47: Expected Obj, but got Unknown
		//IL_703e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7048: Expected Obj, but got Unknown
		//IL_7649: Unknown result type (might be due to invalid IL or missing references)
		//IL_7653: Expected Obj, but got Unknown
		//IL_7db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dc3: Expected Obj, but got Unknown
		//IL_7e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e92: Expected Obj, but got Unknown
		//IL_7f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f5b: Expected Obj, but got Unknown
		//IL_8020: Unknown result type (might be due to invalid IL or missing references)
		//IL_802a: Expected Obj, but got Unknown
		//IL_80ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_80f9: Expected Obj, but got Unknown
		//IL_81b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_81c2: Expected Obj, but got Unknown
		//IL_8273: Unknown result type (might be due to invalid IL or missing references)
		//IL_827d: Expected Obj, but got Unknown
		//IL_8353: Unknown result type (might be due to invalid IL or missing references)
		//IL_835d: Expected Obj, but got Unknown
		//IL_841f: Unknown result type (might be due to invalid IL or missing references)
		//IL_8429: Expected Obj, but got Unknown
		//IL_8571: Unknown result type (might be due to invalid IL or missing references)
		//IL_857b: Expected Obj, but got Unknown
		//IL_859f: Unknown result type (might be due to invalid IL or missing references)
		//IL_85a9: Expected Obj, but got Unknown
		//IL_85e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_85e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_867c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8686: Expected Obj, but got Unknown
		//IL_8889: Unknown result type (might be due to invalid IL or missing references)
		//IL_8893: Expected Obj, but got Unknown
		//IL_8937: Unknown result type (might be due to invalid IL or missing references)
		//IL_8941: Expected Obj, but got Unknown
		//IL_8a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a82: Expected Obj, but got Unknown
		//IL_8aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ab0: Expected Obj, but got Unknown
		//IL_8b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b85: Expected Obj, but got Unknown
		//IL_8ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bb3: Expected Obj, but got Unknown
		//IL_8beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_8de7: Expected Obj, but got Unknown
		//IL_8ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8eb3: Expected Obj, but got Unknown
		//IL_8f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f7e: Expected Obj, but got Unknown
		//IL_9043: Unknown result type (might be due to invalid IL or missing references)
		//IL_904d: Expected Obj, but got Unknown
		//IL_910e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9118: Expected Obj, but got Unknown
		//IL_91ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_91f9: Expected Obj, but got Unknown
		//IL_921d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9227: Expected Obj, but got Unknown
		//IL_9308: Unknown result type (might be due to invalid IL or missing references)
		//IL_9312: Expected Obj, but got Unknown
		//IL_9336: Unknown result type (might be due to invalid IL or missing references)
		//IL_9340: Expected Obj, but got Unknown
		//IL_941d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9427: Expected Obj, but got Unknown
		//IL_944b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9455: Expected Obj, but got Unknown
		//IL_951f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9529: Expected Obj, but got Unknown
		//IL_953c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9546: Expected Obj, but got Unknown
		//IL_9606: Unknown result type (might be due to invalid IL or missing references)
		//IL_9610: Expected Obj, but got Unknown
		//IL_98d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_98df: Expected Obj, but got Unknown
		//IL_9901: Unknown result type (might be due to invalid IL or missing references)
		//IL_990b: Expected Obj, but got Unknown
		//IL_9981: Unknown result type (might be due to invalid IL or missing references)
		//IL_998b: Expected Obj, but got Unknown
		//IL_99ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_99b7: Expected Obj, but got Unknown
		//IL_9a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a35: Expected Obj, but got Unknown
		//IL_9ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ad1: Expected Obj, but got Unknown
		//IL_9cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cc7: Expected Obj, but got Unknown
		//IL_9f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f3b: Expected Obj, but got Unknown
		//IL_9fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fd5: Expected Obj, but got Unknown
		//IL_a07b: Unknown result type (might be due to invalid IL or missing references)
		//IL_a085: Expected Obj, but got Unknown
		//IL_a18c: Unknown result type (might be due to invalid IL or missing references)
		//IL_a196: Expected Obj, but got Unknown
		//IL_a540: Unknown result type (might be due to invalid IL or missing references)
		//IL_a54a: Expected Obj, but got Unknown
		//IL_a92f: Unknown result type (might be due to invalid IL or missing references)
		//IL_a939: Expected Obj, but got Unknown
		//IL_aa65: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa6f: Expected Obj, but got Unknown
		//IL_ab4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab56: Expected Obj, but got Unknown
		//IL_ab8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab90: Unknown result type (might be due to invalid IL or missing references)
		//IL_abc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_abca: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac87: Expected Obj, but got Unknown
		//IL_ad49: Unknown result type (might be due to invalid IL or missing references)
		//IL_ad53: Expected Obj, but got Unknown
		//IL_ae12: Unknown result type (might be due to invalid IL or missing references)
		//IL_ae1c: Expected Obj, but got Unknown
		//IL_aede: Unknown result type (might be due to invalid IL or missing references)
		//IL_aee8: Expected Obj, but got Unknown
		//IL_afa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_afb1: Expected Obj, but got Unknown
		//IL_b073: Unknown result type (might be due to invalid IL or missing references)
		//IL_b07d: Expected Obj, but got Unknown
		//IL_b13f: Unknown result type (might be due to invalid IL or missing references)
		//IL_b149: Expected Obj, but got Unknown
		//IL_b205: Unknown result type (might be due to invalid IL or missing references)
		//IL_b20f: Expected Obj, but got Unknown
		//IL_b3bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_b3c5: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_90000_FACTURE));
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
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		DataGridViewCellStyle val15 = new DataGridViewCellStyle();
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
		Label23 = new Label();
		Label47 = new Label();
		Button_CALC_DOC = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Panel3 = new Panel();
		Text_ETAT = new TextBox();
		Label27 = new Label();
		Label1 = new Label();
		Label12 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Text_UTILISATEUR = new TextBox();
		Label30 = new Label();
		Label6 = new Label();
		Text_ID = new TextBox();
		Label4 = new Label();
		Text_ID_FACTURE = new TextBox();
		DateTimePicker_DATE = new DateTimePicker();
		Panel4 = new Panel();
		Button_CLIENT = new Button_ID_CODE();
		Label31 = new Label();
		Text_NOTES = new TextBox();
		Label32 = new Label();
		Label10 = new Label();
		Label33 = new Label();
		Label7 = new Label();
		Label34 = new Label();
		TabPage2 = new TabPage();
		Panel1 = new Panel();
		DataGridView_FAMILLES = new DataGridView();
		DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
		Button3 = new Button();
		DataGridView_ARTICLES = new DataGridView();
		Column2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		Label16 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		Label20 = new Label();
		Label24 = new Label();
		Button_FIND = new Button();
		Text_ARTICLE_FIND = new TextBox();
		Text_CODE_FIND = new TextBox();
		Panel7 = new Panel();
		Button_MOINS = new Button();
		Button_PLUS = new Button();
		Text_QTE = new TextBox();
		Text_ID_ARTICLE = new TextBox();
		Label50 = new Label();
		Label38 = new Label();
		Text_CODE = new TextBox();
		Label25 = new Label();
		Text_ARTICLE = new TextBox();
		Label37 = new Label();
		Label35 = new Label();
		Label3 = new Label();
		Label36 = new Label();
		Label26 = new Label();
		Label46 = new Label();
		Button1 = new Button();
		Text_PU_HT = new TextBox();
		Text_TAUX_TVA = new TextBox();
		Label8 = new Label();
		Text_PU_TTC = new TextBox();
		Label15 = new Label();
		TabPage3 = new TabPage();
		PictureBox5 = new PictureBox();
		DateTimePicker2 = new DateTimePicker();
		DateTimePicker1 = new DateTimePicker();
		Button_GO = new Button();
		Panel6 = new Panel();
		Label19 = new Label();
		Label39 = new Label();
		Label40 = new Label();
		Label41 = new Label();
		RadioButton_TICKET = new RadioButton();
		RadioButton_DEVIS = new RadioButton();
		RadioButton_BL = new RadioButton();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		DataGridView2 = new DataGridView();
		ID_ARTICLEE = new DataGridViewTextBoxColumn();
		Codee = new DataGridViewTextBoxColumn();
		Articlee = new DataGridViewTextBoxColumn();
		PU_TTCC = new DataGridViewTextBoxColumn();
		TAUX_TVAA = new DataGridViewTextBoxColumn();
		PU_HTT = new DataGridViewTextBoxColumn();
		QTEE = new DataGridViewTextBoxColumn();
		TOTAL_TTCC = new DataGridViewTextBoxColumn();
		TOTAL_TVAA = new DataGridViewTextBoxColumn();
		TOTAL_HTT = new DataGridViewTextBoxColumn();
		TAUX_REMISEE = new DataGridViewTextBoxColumn();
		Button6 = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		PictureBox2323 = new PictureBox();
		DataGrid_BODY = new DataGridView();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		PU_TTC = new DataGridViewTextBoxColumn();
		TAUX_TVA = new DataGridViewTextBoxColumn();
		PU_HT = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		TOTAL_TTC = new DataGridViewTextBoxColumn();
		TOTAL_TVA = new DataGridViewTextBoxColumn();
		TOTAL_HT = new DataGridViewTextBoxColumn();
		TAUX_REMISE = new DataGridViewTextBoxColumn();
		sup = new DataGridViewImageColumn();
		DataGridView1 = new DataGridView();
		Dates = new DataGridViewTextBoxColumn();
		ID_FACTURE = new DataGridViewTextBoxColumn();
		UTILISATEUR = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		TOTAL_HT_DOC = new DataGridViewTextBoxColumn();
		TOTAL_TVA_DOC = new DataGridViewTextBoxColumn();
		TOTAL_TTC_DOC = new DataGridViewTextBoxColumn();
		ETAT = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		cons = new DataGridViewImageColumn();
		Panel243544 = new Panel();
		Label_TOTAL_TTC_BD = new Label();
		Label54 = new Label();
		Label_TOTAL_TVA_BD = new Label();
		Label_TOTAL_HT_BD = new Label();
		Label51 = new Label();
		Label52 = new Label();
		Label_TOTAL_LIGNES_BD = new Label();
		Label22 = new Label();
		Label21 = new Label();
		Button_CALC_BD = new Button();
		Button_VALIDER = new Button();
		Label4141 = new Label();
		Panel7727 = new Panel();
		Button_CALC_ENREGISTRER = new Button();
		PictureBox3 = new PictureBox();
		TextBox33398 = new TextBox();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		Button_ADD = new Button();
		Button_FONCTIONS = new Button();
		Panel_FONCTIONS = new Panel();
		Text_pied_doc = new TextBox();
		Label44 = new Label();
		Label43 = new Label();
		Label42 = new Label();
		Label45 = new Label();
		Button_PDF = new Button();
		Button_EXCEL = new Button();
		Button_WORD = new Button();
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
		Label5 = new Label();
		Label14 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Label_TOTAL_REMISE_DOC = new Label();
		Label58 = new Label();
		Label_TOTAL_HT_DOC = new Label();
		Label56 = new Label();
		Label_TOTAL_TVA_DOC = new Label();
		Label_TOTAL_TTC_DOC = new Label();
		Label53 = new Label();
		Label49 = new Label();
		((Control)Panel_INFO).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView_FAMILLES).BeginInit();
		((ISupportInitialize)DataGridView_ARTICLES).BeginInit();
		((Control)Panel7).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)Panel6).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((ISupportInitialize)PictureBox2323).BeginInit();
		((ISupportInitialize)DataGrid_BODY).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel243544).SuspendLayout();
		((Control)Panel7727).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_INFO).Anchor = (AnchorStyles)1;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Text_FIND_BODY);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SPLITE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel5);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_INFO).Controls.Add((Control)(object)PictureBox2323);
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
		location = new Point(834, 524);
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
		((Control)Button_SPLITE).TabIndex = 998;
		((ButtonBase)Button_SPLITE).UseVisualStyleBackColor = true;
		((Control)Panel5).BackColor = Color.Transparent;
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_REMISE_DOC);
		((Control)Panel5).Controls.Add((Control)(object)Label58);
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_HT_DOC);
		((Control)Panel5).Controls.Add((Control)(object)Label56);
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_TVA_DOC);
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_TTC_DOC);
		((Control)Panel5).Controls.Add((Control)(object)Label53);
		((Control)Panel5).Controls.Add((Control)(object)Label49);
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_LIGNES);
		((Control)Panel5).Controls.Add((Control)(object)Label23);
		((Control)Panel5).Controls.Add((Control)(object)Label47);
		((Control)Panel5).Controls.Add((Control)(object)Button_CALC_DOC);
		Panel panel = Panel5;
		location = new Point(10, 476);
		((Control)panel).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel2 = Panel5;
		size = new Size(877, 31);
		((Control)panel2).Size = size;
		((Control)Panel5).TabIndex = 997;
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
		((Control)Label23).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label23).Cursor = Cursors.Hand;
		((Control)Label23).Dock = (DockStyle)2;
		((Control)Label23).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label = Label23;
		location = new Point(0, 30);
		((Control)label).Location = location;
		((Control)Label23).Name = "Label23";
		Label label2 = Label23;
		size = new Size(877, 1);
		((Control)label2).Size = size;
		((Control)Label23).TabIndex = 1067;
		Label23.TextAlign = (ContentAlignment)16;
		((Control)Label47).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label47).Cursor = Cursors.Hand;
		((Control)Label47).Dock = (DockStyle)1;
		((Control)Label47).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label47).ForeColor = Color.White;
		Label label3 = Label47;
		location = new Point(0, 0);
		((Control)label3).Location = location;
		((Control)Label47).Name = "Label47";
		Label label4 = Label47;
		size = new Size(877, 1);
		((Control)label4).Size = size;
		((Control)Label47).TabIndex = 1066;
		Label47.TextAlign = (ContentAlignment)16;
		((Control)Button_CALC_DOC).ForeColor = Color.Red;
		Button button_CALC_DOC = Button_CALC_DOC;
		location = new Point(38, 3);
		((Control)button_CALC_DOC).Location = location;
		((Control)Button_CALC_DOC).Name = "Button_CALC_DOC";
		Button button_CALC_DOC2 = Button_CALC_DOC;
		size = new Size(48, 29);
		((Control)button_CALC_DOC2).Size = size;
		((Control)Button_CALC_DOC).TabIndex = 984;
		((ButtonBase)Button_CALC_DOC).Text = "CALC";
		((ButtonBase)Button_CALC_DOC).UseVisualStyleBackColor = true;
		((Control)Button_CALC_DOC).Visible = false;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage3);
		((Control)TabControl1).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl = TabControl1;
		size = new Size(60, 30);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl1;
		location = new Point(10, 27);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(877, 274);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 989;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Panel3);
		((Control)TabPage1).Controls.Add((Control)(object)Panel4);
		TabPage tabPage = TabPage1;
		location = new Point(4, 34);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(869, 236);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "Informations";
		((Control)Panel3).BackColor = Color.White;
		((Control)Panel3).Controls.Add((Control)(object)Text_ETAT);
		((Control)Panel3).Controls.Add((Control)(object)Label27);
		((Control)Panel3).Controls.Add((Control)(object)Label1);
		((Control)Panel3).Controls.Add((Control)(object)Label12);
		((Control)Panel3).Controls.Add((Control)(object)Label28);
		((Control)Panel3).Controls.Add((Control)(object)Label29);
		((Control)Panel3).Controls.Add((Control)(object)Text_UTILISATEUR);
		((Control)Panel3).Controls.Add((Control)(object)Label30);
		((Control)Panel3).Controls.Add((Control)(object)Label6);
		((Control)Panel3).Controls.Add((Control)(object)Text_ID);
		((Control)Panel3).Controls.Add((Control)(object)Label4);
		((Control)Panel3).Controls.Add((Control)(object)Text_ID_FACTURE);
		((Control)Panel3).Controls.Add((Control)(object)DateTimePicker_DATE);
		Panel panel3 = Panel3;
		location = new Point(10, 8);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(417, 158);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 986;
		((TextBoxBase)Text_ETAT).BackColor = Color.White;
		((Control)Text_ETAT).Enabled = false;
		((Control)Text_ETAT).Font = new Font("Cambria", 9.75f);
		TextBox text_ETAT = Text_ETAT;
		location = new Point(159, 123);
		((Control)text_ETAT).Location = location;
		((Control)Text_ETAT).Name = "Text_ETAT";
		TextBox text_ETAT2 = Text_ETAT;
		size = new Size(249, 23);
		((Control)text_ETAT2).Size = size;
		((Control)Text_ETAT).TabIndex = 967;
		Text_ETAT.TextAlign = (HorizontalAlignment)2;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)2;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label5 = Label27;
		location = new Point(1, 157);
		((Control)label5).Location = location;
		((Control)Label27).Name = "Label27";
		Label label6 = Label27;
		size = new Size(415, 1);
		((Control)label6).Size = size;
		((Control)Label27).TabIndex = 995;
		Label27.TextAlign = (ContentAlignment)16;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label7 = Label1;
		location = new Point(20, 10);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(134, 23);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 961;
		Label1.Text = "DATES";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.Black;
		Label label9 = Label12;
		location = new Point(20, 123);
		((Control)label9).Location = location;
		((Control)Label12).Name = "Label12";
		Label label10 = Label12;
		size = new Size(133, 23);
		((Control)label10).Size = size;
		((Control)Label12).TabIndex = 966;
		Label12.Text = "ETAT";
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)3;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label11 = Label28;
		location = new Point(0, 1);
		((Control)label11).Location = location;
		((Control)Label28).Name = "Label28";
		Label label12 = Label28;
		size = new Size(1, 157);
		((Control)label12).Size = size;
		((Control)Label28).TabIndex = 994;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label29).Cursor = Cursors.Hand;
		((Control)Label29).Dock = (DockStyle)4;
		((Control)Label29).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label29).ForeColor = Color.White;
		Label label13 = Label29;
		location = new Point(416, 1);
		((Control)label13).Location = location;
		((Control)Label29).Name = "Label29";
		Label label14 = Label29;
		size = new Size(1, 157);
		((Control)label14).Size = size;
		((Control)Label29).TabIndex = 993;
		Label29.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_UTILISATEUR).BackColor = Color.White;
		((Control)Text_UTILISATEUR).Enabled = false;
		((Control)Text_UTILISATEUR).Font = new Font("Cambria", 9.75f);
		TextBox text_UTILISATEUR = Text_UTILISATEUR;
		location = new Point(159, 95);
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
		Label label15 = Label30;
		location = new Point(0, 0);
		((Control)label15).Location = location;
		((Control)Label30).Name = "Label30";
		Label label16 = Label30;
		size = new Size(417, 1);
		((Control)label16).Size = size;
		((Control)Label30).TabIndex = 992;
		Label30.Text = "-";
		Label30.TextAlign = (ContentAlignment)16;
		((Control)Label6).BackColor = SystemColors.Control;
		((Control)Label6).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.Black;
		Label label17 = Label6;
		location = new Point(20, 95);
		((Control)label17).Location = location;
		((Control)Label6).Name = "Label6";
		Label label18 = Label6;
		size = new Size(134, 23);
		((Control)label18).Size = size;
		((Control)Label6).TabIndex = 965;
		Label6.Text = "UTILISATEUR";
		Label6.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID).BackColor = Color.White;
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Cambria", 9.75f);
		TextBox text_ID = Text_ID;
		location = new Point(159, 10);
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
		Label label19 = Label4;
		location = new Point(20, 39);
		((Control)label19).Location = location;
		((Control)Label4).Name = "Label4";
		Label label20 = Label4;
		size = new Size(134, 23);
		((Control)label20).Size = size;
		((Control)Label4).TabIndex = 963;
		Label4.Text = "ID_FACTURE";
		Label4.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID_FACTURE).BackColor = Color.White;
		((Control)Text_ID_FACTURE).Enabled = false;
		((Control)Text_ID_FACTURE).Font = new Font("Cambria", 9.75f);
		TextBox text_ID_FACTURE = Text_ID_FACTURE;
		location = new Point(159, 39);
		((Control)text_ID_FACTURE).Location = location;
		((Control)Text_ID_FACTURE).Name = "Text_ID_FACTURE";
		TextBox text_ID_FACTURE2 = Text_ID_FACTURE;
		size = new Size(249, 23);
		((Control)text_ID_FACTURE2).Size = size;
		((Control)Text_ID_FACTURE).TabIndex = 962;
		Text_ID_FACTURE.TextAlign = (HorizontalAlignment)2;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Cambria", 9.75f);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(159, 10);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(249, 23);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 960;
		((Control)Panel4).BackColor = Color.White;
		((Control)Panel4).Controls.Add((Control)(object)Button_CLIENT);
		((Control)Panel4).Controls.Add((Control)(object)Label31);
		((Control)Panel4).Controls.Add((Control)(object)Text_NOTES);
		((Control)Panel4).Controls.Add((Control)(object)Label32);
		((Control)Panel4).Controls.Add((Control)(object)Label10);
		((Control)Panel4).Controls.Add((Control)(object)Label33);
		((Control)Panel4).Controls.Add((Control)(object)Label7);
		((Control)Panel4).Controls.Add((Control)(object)Label34);
		Panel panel5 = Panel4;
		location = new Point(442, 8);
		((Control)panel5).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel6 = Panel4;
		size = new Size(417, 158);
		((Control)panel6).Size = size;
		((Control)Panel4).TabIndex = 987;
		Button_CLIENT._CODE_Button = null;
		Button_CLIENT._ID_Button = "";
		((ButtonBase)Button_CLIENT).BackColor = Color.Transparent;
		((Control)Button_CLIENT).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENT).FlatAppearance.BorderColor = Color.Black;
		((Control)Button_CLIENT).Font = new Font("Segoe UI", 10.5f, (FontStyle)1);
		((Control)Button_CLIENT).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button_CLIENT).ImageAlign = (ContentAlignment)16;
		Button_ID_CODE button_CLIENT = Button_CLIENT;
		location = new Point(164, 11);
		((Control)button_CLIENT).Location = location;
		((Control)Button_CLIENT).Name = "Button_CLIENT";
		Button_ID_CODE button_CLIENT2 = Button_CLIENT;
		size = new Size(243, 23);
		((Control)button_CLIENT2).Size = size;
		((Control)Button_CLIENT).TabIndex = 1033;
		((ButtonBase)Button_CLIENT).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CLIENT).UseVisualStyleBackColor = false;
		((Control)Label31).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label31).Cursor = Cursors.Hand;
		((Control)Label31).Dock = (DockStyle)2;
		((Control)Label31).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label31).ForeColor = Color.White;
		Label label21 = Label31;
		location = new Point(1, 157);
		((Control)label21).Location = location;
		((Control)Label31).Name = "Label31";
		Label label22 = Label31;
		size = new Size(415, 1);
		((Control)label22).Size = size;
		((Control)Label31).TabIndex = 995;
		Label31.TextAlign = (ContentAlignment)16;
		((Control)Text_NOTES).Font = new Font("Cambria", 9.75f);
		TextBox text_NOTES = Text_NOTES;
		location = new Point(164, 42);
		((Control)text_NOTES).Location = location;
		Text_NOTES.Multiline = true;
		((Control)Text_NOTES).Name = "Text_NOTES";
		TextBox text_NOTES2 = Text_NOTES;
		size = new Size(243, 55);
		((Control)text_NOTES2).Size = size;
		((Control)Text_NOTES).TabIndex = 972;
		((Control)Label32).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label32).Cursor = Cursors.Hand;
		((Control)Label32).Dock = (DockStyle)3;
		((Control)Label32).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label32).ForeColor = Color.White;
		Label label23 = Label32;
		location = new Point(0, 1);
		((Control)label23).Location = location;
		((Control)Label32).Name = "Label32";
		Label label24 = Label32;
		size = new Size(1, 157);
		((Control)label24).Size = size;
		((Control)Label32).TabIndex = 994;
		Label32.TextAlign = (ContentAlignment)16;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label25 = Label10;
		location = new Point(18, 42);
		((Control)label25).Location = location;
		((Control)Label10).Name = "Label10";
		Label label26 = Label10;
		size = new Size(142, 23);
		((Control)label26).Size = size;
		((Control)Label10).TabIndex = 973;
		Label10.Text = "NOTES";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label33).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label33).Cursor = Cursors.Hand;
		((Control)Label33).Dock = (DockStyle)4;
		((Control)Label33).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label33).ForeColor = Color.White;
		Label label27 = Label33;
		location = new Point(416, 1);
		((Control)label27).Location = location;
		((Control)Label33).Name = "Label33";
		Label label28 = Label33;
		size = new Size(1, 157);
		((Control)label28).Size = size;
		((Control)Label33).TabIndex = 993;
		Label33.TextAlign = (ContentAlignment)16;
		((Control)Label7).BackColor = SystemColors.Control;
		((Control)Label7).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.Black;
		Label label29 = Label7;
		location = new Point(18, 11);
		((Control)label29).Location = location;
		((Control)Label7).Name = "Label7";
		Label label30 = Label7;
		size = new Size(142, 23);
		((Control)label30).Size = size;
		((Control)Label7).TabIndex = 967;
		Label7.Text = "CLIENT";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Label34).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label34).Cursor = Cursors.Hand;
		((Control)Label34).Dock = (DockStyle)1;
		((Control)Label34).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label34).ForeColor = Color.White;
		Label label31 = Label34;
		location = new Point(0, 0);
		((Control)label31).Location = location;
		((Control)Label34).Name = "Label34";
		Label label32 = Label34;
		size = new Size(417, 1);
		((Control)label32).Size = size;
		((Control)Label34).TabIndex = 992;
		Label34.Text = "-";
		Label34.TextAlign = (ContentAlignment)16;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Panel1);
		((Control)TabPage2).Controls.Add((Control)(object)Panel7);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 34);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		margin = new Padding(3);
		((Control)tabPage5).Padding = margin;
		TabPage tabPage6 = TabPage2;
		size = new Size(869, 236);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Désignations";
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_FAMILLES);
		((Control)Panel1).Controls.Add((Control)(object)Button3);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_ARTICLES);
		((Control)Panel1).Controls.Add((Control)(object)Label16);
		((Control)Panel1).Controls.Add((Control)(object)Label17);
		((Control)Panel1).Controls.Add((Control)(object)Label18);
		((Control)Panel1).Controls.Add((Control)(object)Label20);
		((Control)Panel1).Controls.Add((Control)(object)Label24);
		((Control)Panel1).Controls.Add((Control)(object)Button_FIND);
		((Control)Panel1).Controls.Add((Control)(object)Text_ARTICLE_FIND);
		((Control)Panel1).Controls.Add((Control)(object)Text_CODE_FIND);
		Panel panel7 = Panel1;
		location = new Point(9, 4);
		((Control)panel7).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel8 = Panel1;
		size = new Size(417, 228);
		((Control)panel8).Size = size;
		((Control)Panel1).TabIndex = 985;
		DataGridView_FAMILLES.AllowUserToAddRows = false;
		DataGridView_FAMILLES.AllowUserToResizeRows = false;
		DataGridView_FAMILLES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_FAMILLES.BackgroundColor = Color.White;
		DataGridView_FAMILLES.BorderStyle = (BorderStyle)2;
		DataGridView_FAMILLES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_FAMILLES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_FAMILLES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_FAMILLES.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn13 });
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
		((Control)DataGridView_FAMILLES).TabIndex = 1012;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).HeaderText = "Famille";
		((DataGridViewColumn)DataGridViewTextBoxColumn13).Name = "DataGridViewTextBoxColumn13";
		((ButtonBase)Button3).BackColor = Color.White;
		((Control)Button3).BackgroundImage = (Image)componentResourceManager.GetObject("Button3.BackgroundImage");
		((Control)Button3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		Button button = Button3;
		location = new Point(378, 42);
		((Control)button).Location = location;
		((Control)Button3).Name = "Button3";
		Button button2 = Button3;
		size = new Size(28, 20);
		((Control)button2).Size = size;
		((Control)Button3).TabIndex = 1009;
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
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
			(DataGridViewColumn)Column2,
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
		((Control)DataGridView_ARTICLES).TabIndex = 1007;
		((DataGridViewColumn)Column2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column2).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)Column2).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)Column2).MinimumWidth = 2;
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).Width = 2;
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
		((Control)Label16).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label16).Cursor = Cursors.Hand;
		((Control)Label16).Dock = (DockStyle)2;
		((Control)Label16).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.White;
		Label label33 = Label16;
		location = new Point(1, 227);
		((Control)label33).Location = location;
		((Control)Label16).Name = "Label16";
		Label label34 = Label16;
		size = new Size(415, 1);
		((Control)label34).Size = size;
		((Control)Label16).TabIndex = 995;
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label17).Cursor = Cursors.Hand;
		((Control)Label17).Dock = (DockStyle)3;
		((Control)Label17).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label35 = Label17;
		location = new Point(0, 1);
		((Control)label35).Location = location;
		((Control)Label17).Name = "Label17";
		Label label36 = Label17;
		size = new Size(1, 227);
		((Control)label36).Size = size;
		((Control)Label17).TabIndex = 994;
		Label17.TextAlign = (ContentAlignment)16;
		((Control)Label18).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label18).Cursor = Cursors.Hand;
		((Control)Label18).Dock = (DockStyle)4;
		((Control)Label18).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.White;
		Label label37 = Label18;
		location = new Point(416, 1);
		((Control)label37).Location = location;
		((Control)Label18).Name = "Label18";
		Label label38 = Label18;
		size = new Size(1, 227);
		((Control)label38).Size = size;
		((Control)Label18).TabIndex = 993;
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Label20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label20).Cursor = Cursors.Hand;
		((Control)Label20).Dock = (DockStyle)1;
		((Control)Label20).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.White;
		Label label39 = Label20;
		location = new Point(0, 0);
		((Control)label39).Location = location;
		((Control)Label20).Name = "Label20";
		Label label40 = Label20;
		size = new Size(417, 1);
		((Control)label40).Size = size;
		((Control)Label20).TabIndex = 992;
		Label20.Text = "-";
		Label20.TextAlign = (ContentAlignment)16;
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.Black;
		Label label41 = Label24;
		location = new Point(11, 11);
		((Control)label41).Location = location;
		((Control)Label24).Name = "Label24";
		Label label42 = Label24;
		size = new Size(134, 23);
		((Control)label42).Size = size;
		((Control)Label24).TabIndex = 404;
		Label24.Text = "CODE";
		Label24.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_FIND).BackColor = Color.White;
		((Control)Button_FIND).BackgroundImage = (Image)componentResourceManager.GetObject("Button_FIND.BackgroundImage");
		((Control)Button_FIND).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button_FIND).Cursor = Cursors.Hand;
		((ButtonBase)Button_FIND).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_FIND).FlatStyle = (FlatStyle)0;
		Button button_FIND = Button_FIND;
		location = new Point(378, 12);
		((Control)button_FIND).Location = location;
		((Control)Button_FIND).Name = "Button_FIND";
		Button button_FIND2 = Button_FIND;
		size = new Size(28, 20);
		((Control)button_FIND2).Size = size;
		((Control)Button_FIND).TabIndex = 726;
		((ButtonBase)Button_FIND).UseVisualStyleBackColor = false;
		((Control)Text_ARTICLE_FIND).Font = new Font("Cambria", 9.75f);
		TextBox text_ARTICLE_FIND = Text_ARTICLE_FIND;
		location = new Point(151, 40);
		((Control)text_ARTICLE_FIND).Location = location;
		((Control)Text_ARTICLE_FIND).Name = "Text_ARTICLE_FIND";
		TextBox text_ARTICLE_FIND2 = Text_ARTICLE_FIND;
		size = new Size(257, 23);
		((Control)text_ARTICLE_FIND2).Size = size;
		((Control)Text_ARTICLE_FIND).TabIndex = 1008;
		((Control)Text_CODE_FIND).Font = new Font("Cambria", 9.75f);
		TextBox text_CODE_FIND = Text_CODE_FIND;
		location = new Point(151, 11);
		((Control)text_CODE_FIND).Location = location;
		((Control)Text_CODE_FIND).Name = "Text_CODE_FIND";
		TextBox text_CODE_FIND2 = Text_CODE_FIND;
		size = new Size(257, 23);
		((Control)text_CODE_FIND2).Size = size;
		((Control)Text_CODE_FIND).TabIndex = 0;
		((Control)Panel7).BackColor = Color.White;
		((Control)Panel7).Controls.Add((Control)(object)Button_MOINS);
		((Control)Panel7).Controls.Add((Control)(object)Button_PLUS);
		((Control)Panel7).Controls.Add((Control)(object)Text_QTE);
		((Control)Panel7).Controls.Add((Control)(object)Text_ID_ARTICLE);
		((Control)Panel7).Controls.Add((Control)(object)Label50);
		((Control)Panel7).Controls.Add((Control)(object)Label38);
		((Control)Panel7).Controls.Add((Control)(object)Text_CODE);
		((Control)Panel7).Controls.Add((Control)(object)Label25);
		((Control)Panel7).Controls.Add((Control)(object)Text_ARTICLE);
		((Control)Panel7).Controls.Add((Control)(object)Label37);
		((Control)Panel7).Controls.Add((Control)(object)Label35);
		((Control)Panel7).Controls.Add((Control)(object)Label3);
		((Control)Panel7).Controls.Add((Control)(object)Label36);
		((Control)Panel7).Controls.Add((Control)(object)Label26);
		((Control)Panel7).Controls.Add((Control)(object)Label46);
		((Control)Panel7).Controls.Add((Control)(object)Button1);
		((Control)Panel7).Controls.Add((Control)(object)Text_PU_HT);
		((Control)Panel7).Controls.Add((Control)(object)Text_TAUX_TVA);
		((Control)Panel7).Controls.Add((Control)(object)Label8);
		((Control)Panel7).Controls.Add((Control)(object)Text_PU_TTC);
		((Control)Panel7).Controls.Add((Control)(object)Label15);
		Panel panel9 = Panel7;
		location = new Point(442, 4);
		((Control)panel9).Location = location;
		((Control)Panel7).Name = "Panel7";
		Panel panel10 = Panel7;
		size = new Size(417, 228);
		((Control)panel10).Size = size;
		((Control)Panel7).TabIndex = 1003;
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
		((Control)Button_MOINS).TabIndex = 1068;
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
		((Control)Button_PLUS).TabIndex = 1067;
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
		((Control)Text_ID_ARTICLE).TabIndex = 1014;
		((Control)Label50).BackColor = SystemColors.Control;
		((Control)Label50).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Label50).ForeColor = Color.Black;
		Label label43 = Label50;
		location = new Point(228, 10);
		((Control)label43).Location = location;
		((Control)Label50).Name = "Label50";
		Label label44 = Label50;
		size = new Size(62, 23);
		((Control)label44).Size = size;
		((Control)Label50).TabIndex = 1013;
		Label50.Text = "ID Article";
		Label50.TextAlign = (ContentAlignment)16;
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
		size = new Size(1, 226);
		((Control)label46).Size = size;
		((Control)Label38).TabIndex = 1012;
		Label38.TextAlign = (ContentAlignment)16;
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
		((Control)Label25).BackColor = SystemColors.Control;
		((Control)Label25).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label25).ForeColor = Color.Black;
		Label label47 = Label25;
		location = new Point(6, 10);
		((Control)label47).Location = location;
		((Control)Label25).Name = "Label25";
		Label label48 = Label25;
		size = new Size(87, 23);
		((Control)label48).Size = size;
		((Control)Label25).TabIndex = 1010;
		Label25.Text = "Code";
		Label25.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ARTICLE).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_ARTICLE).Enabled = false;
		((Control)Text_ARTICLE).Font = new Font("Cambria", 9.75f);
		TextBox text_ARTICLE = Text_ARTICLE;
		location = new Point(98, 40);
		((Control)text_ARTICLE).Location = location;
		((Control)Text_ARTICLE).Name = "Text_ARTICLE";
		TextBox text_ARTICLE2 = Text_ARTICLE;
		size = new Size(312, 23);
		((Control)text_ARTICLE2).Size = size;
		((Control)Text_ARTICLE).TabIndex = 1009;
		((Control)Label37).BackColor = SystemColors.Control;
		((Control)Label37).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label37).ForeColor = Color.Black;
		Label label49 = Label37;
		location = new Point(6, 40);
		((Control)label49).Location = location;
		((Control)Label37).Name = "Label37";
		Label label50 = Label37;
		size = new Size(87, 23);
		((Control)label50).Size = size;
		((Control)Label37).TabIndex = 1008;
		Label37.Text = "Article";
		Label37.TextAlign = (ContentAlignment)16;
		((Control)Label35).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label35).Cursor = Cursors.Hand;
		((Control)Label35).Dock = (DockStyle)2;
		((Control)Label35).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label35).ForeColor = Color.White;
		Label label51 = Label35;
		location = new Point(1, 227);
		((Control)label51).Location = location;
		((Control)Label35).Name = "Label35";
		Label label52 = Label35;
		size = new Size(416, 1);
		((Control)label52).Size = size;
		((Control)Label35).TabIndex = 1000;
		Label35.TextAlign = (ContentAlignment)16;
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label label53 = Label3;
		location = new Point(6, 127);
		((Control)label53).Location = location;
		((Control)Label3).Name = "Label3";
		Label label54 = Label3;
		size = new Size(87, 39);
		((Control)label54).Size = size;
		((Control)Label3).TabIndex = 378;
		Label3.Text = "QUANTITE";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Label36).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label36).Cursor = Cursors.Hand;
		((Control)Label36).Dock = (DockStyle)3;
		((Control)Label36).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label36).ForeColor = Color.White;
		Label label55 = Label36;
		location = new Point(0, 1);
		((Control)label55).Location = location;
		((Control)Label36).Name = "Label36";
		Label label56 = Label36;
		size = new Size(1, 227);
		((Control)label56).Size = size;
		((Control)Label36).TabIndex = 994;
		Label36.TextAlign = (ContentAlignment)16;
		((Control)Label26).BackColor = SystemColors.Control;
		((Control)Label26).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label26).ForeColor = Color.Black;
		Label label57 = Label26;
		location = new Point(6, 69);
		((Control)label57).Location = location;
		((Control)Label26).Name = "Label26";
		Label label58 = Label26;
		size = new Size(87, 23);
		((Control)label58).Size = size;
		((Control)Label26).TabIndex = 395;
		Label26.Text = "PU_TTC";
		Label26.TextAlign = (ContentAlignment)16;
		((Control)Label46).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label46).Cursor = Cursors.Hand;
		((Control)Label46).Dock = (DockStyle)1;
		((Control)Label46).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label46).ForeColor = Color.White;
		Label label59 = Label46;
		location = new Point(0, 0);
		((Control)label59).Location = location;
		((Control)Label46).Name = "Label46";
		Label label60 = Label46;
		size = new Size(417, 1);
		((Control)label60).Size = size;
		((Control)Label46).TabIndex = 992;
		Label46.Text = "-";
		Label46.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button1).BackgroundImageLayout = (ImageLayout)4;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.White;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button3 = Button1;
		location = new Point(98, 175);
		((Control)button3).Location = location;
		((Control)Button1).Name = "Button1";
		Button button4 = Button1;
		size = new Size(312, 39);
		((Control)button4).Size = size;
		((Control)Button1).TabIndex = 729;
		((ButtonBase)Button1).Text = "Insérer";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_PU_HT).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_PU_HT).Enabled = false;
		((Control)Text_PU_HT).Font = new Font("Cambria", 9.75f);
		TextBox text_PU_HT = Text_PU_HT;
		location = new Point(98, 98);
		((Control)text_PU_HT).Location = location;
		((Control)Text_PU_HT).Name = "Text_PU_HT";
		TextBox text_PU_HT2 = Text_PU_HT;
		size = new Size(312, 23);
		((Control)text_PU_HT2).Size = size;
		((Control)Text_PU_HT).TabIndex = 989;
		((TextBoxBase)Text_TAUX_TVA).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_TAUX_TVA).Font = new Font("Cambria", 9.75f);
		TextBox text_TAUX_TVA = Text_TAUX_TVA;
		location = new Point(321, 68);
		((Control)text_TAUX_TVA).Location = location;
		((Control)Text_TAUX_TVA).Name = "Text_TAUX_TVA";
		TextBox text_TAUX_TVA2 = Text_TAUX_TVA;
		size = new Size(89, 23);
		((Control)text_TAUX_TVA2).Size = size;
		((Control)Text_TAUX_TVA).TabIndex = 991;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label61 = Label8;
		location = new Point(6, 98);
		((Control)label61).Location = location;
		((Control)Label8).Name = "Label8";
		Label label62 = Label8;
		size = new Size(87, 23);
		((Control)label62).Size = size;
		((Control)Label8).TabIndex = 988;
		Label8.Text = "PU_HT";
		Label8.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_PU_TTC).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_PU_TTC).Font = new Font("Cambria", 9.75f);
		TextBox text_PU_TTC = Text_PU_TTC;
		location = new Point(98, 69);
		((Control)text_PU_TTC).Location = location;
		((Control)Text_PU_TTC).Name = "Text_PU_TTC";
		TextBox text_PU_TTC2 = Text_PU_TTC;
		size = new Size(124, 23);
		((Control)text_PU_TTC2).Size = size;
		((Control)Text_PU_TTC).TabIndex = 398;
		((Control)Label15).BackColor = SystemColors.Control;
		((Control)Label15).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label15).ForeColor = Color.Black;
		Label label63 = Label15;
		location = new Point(228, 69);
		((Control)label63).Location = location;
		((Control)Label15).Name = "Label15";
		Label label64 = Label15;
		size = new Size(87, 23);
		((Control)label64).Size = size;
		((Control)Label15).TabIndex = 990;
		Label15.Text = "TAUX TVA";
		Label15.TextAlign = (ContentAlignment)16;
		TabPage3.BackColor = Color.FromArgb(250, 250, 250);
		((Control)TabPage3).Controls.Add((Control)(object)PictureBox5);
		((Control)TabPage3).Controls.Add((Control)(object)DateTimePicker2);
		((Control)TabPage3).Controls.Add((Control)(object)DateTimePicker1);
		((Control)TabPage3).Controls.Add((Control)(object)Button_GO);
		((Control)TabPage3).Controls.Add((Control)(object)Panel6);
		((Control)TabPage3).Controls.Add((Control)(object)DataGridView3);
		((Control)TabPage3).Controls.Add((Control)(object)DataGridView2);
		((Control)TabPage3).Controls.Add((Control)(object)Button6);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 34);
		tabPage7.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage8 = TabPage3;
		margin = new Padding(3);
		((Control)tabPage8).Padding = margin;
		TabPage tabPage9 = TabPage3;
		size = new Size(869, 236);
		((Control)tabPage9).Size = size;
		TabPage3.TabIndex = 3;
		TabPage3.Text = "Import";
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox = PictureBox5;
		location = new Point(99, 42);
		((Control)pictureBox).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox2 = PictureBox5;
		size = new Size(35, 25);
		((Control)pictureBox2).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)4;
		PictureBox5.TabIndex = 1054;
		PictureBox5.TabStop = false;
		DateTimePicker2.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker2).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker2;
		location = new Point(134, 42);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DateTimePicker dateTimePicker2 = DateTimePicker2;
		size = new Size(93, 27);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker2).TabIndex = 1053;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker3 = DateTimePicker1;
		location = new Point(6, 42);
		((Control)dateTimePicker3).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker4 = DateTimePicker1;
		size = new Size(93, 27);
		((Control)dateTimePicker4).Size = size;
		((Control)DateTimePicker1).TabIndex = 1052;
		((Control)Button_GO).Anchor = (AnchorStyles)9;
		((ButtonBase)Button_GO).BackColor = Color.Transparent;
		((Control)Button_GO).Cursor = Cursors.Hand;
		((Control)Button_GO).Font = new Font("Calibri", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button_GO).ForeColor = Color.Black;
		((ButtonBase)Button_GO).Image = (Image)componentResourceManager.GetObject("Button_GO.Image");
		((ButtonBase)Button_GO).ImageAlign = (ContentAlignment)16;
		Button button_GO = Button_GO;
		location = new Point(321, 35);
		((Control)button_GO).Location = location;
		Button button_GO2 = Button_GO;
		margin = new Padding(0);
		((Control)button_GO2).Margin = margin;
		((Control)Button_GO).Name = "Button_GO";
		Button button_GO3 = Button_GO;
		size = new Size(102, 32);
		((Control)button_GO3).Size = size;
		((Control)Button_GO).TabIndex = 1038;
		((ButtonBase)Button_GO).Text = "CHARGER";
		((ButtonBase)Button_GO).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_GO).UseVisualStyleBackColor = false;
		((Control)Panel6).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel6).Controls.Add((Control)(object)Label19);
		((Control)Panel6).Controls.Add((Control)(object)Label39);
		((Control)Panel6).Controls.Add((Control)(object)Label40);
		((Control)Panel6).Controls.Add((Control)(object)Label41);
		((Control)Panel6).Controls.Add((Control)(object)RadioButton_TICKET);
		((Control)Panel6).Controls.Add((Control)(object)RadioButton_DEVIS);
		((Control)Panel6).Controls.Add((Control)(object)RadioButton_BL);
		Panel panel11 = Panel6;
		location = new Point(6, 6);
		((Control)panel11).Location = location;
		((Control)Panel6).Name = "Panel6";
		Panel panel12 = Panel6;
		size = new Size(417, 26);
		((Control)panel12).Size = size;
		((Control)Panel6).TabIndex = 1037;
		((Control)Label19).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label19).Cursor = Cursors.Hand;
		((Control)Label19).Dock = (DockStyle)2;
		((Control)Label19).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.White;
		Label label65 = Label19;
		location = new Point(1, 25);
		((Control)label65).Location = location;
		((Control)Label19).Name = "Label19";
		Label label66 = Label19;
		size = new Size(415, 1);
		((Control)label66).Size = size;
		((Control)Label19).TabIndex = 995;
		Label19.TextAlign = (ContentAlignment)16;
		((Control)Label39).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label39).Cursor = Cursors.Hand;
		((Control)Label39).Dock = (DockStyle)3;
		((Control)Label39).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label39).ForeColor = Color.White;
		Label label67 = Label39;
		location = new Point(0, 1);
		((Control)label67).Location = location;
		((Control)Label39).Name = "Label39";
		Label label68 = Label39;
		size = new Size(1, 25);
		((Control)label68).Size = size;
		((Control)Label39).TabIndex = 994;
		Label39.TextAlign = (ContentAlignment)16;
		((Control)Label40).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label40).Cursor = Cursors.Hand;
		((Control)Label40).Dock = (DockStyle)4;
		((Control)Label40).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label40).ForeColor = Color.White;
		Label label69 = Label40;
		location = new Point(416, 1);
		((Control)label69).Location = location;
		((Control)Label40).Name = "Label40";
		Label label70 = Label40;
		size = new Size(1, 25);
		((Control)label70).Size = size;
		((Control)Label40).TabIndex = 993;
		Label40.TextAlign = (ContentAlignment)16;
		((Control)Label41).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label41).Cursor = Cursors.Hand;
		((Control)Label41).Dock = (DockStyle)1;
		((Control)Label41).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label41).ForeColor = Color.White;
		Label label71 = Label41;
		location = new Point(0, 0);
		((Control)label71).Location = location;
		((Control)Label41).Name = "Label41";
		Label label72 = Label41;
		size = new Size(417, 1);
		((Control)label72).Size = size;
		((Control)Label41).TabIndex = 992;
		Label41.Text = "-";
		Label41.TextAlign = (ContentAlignment)16;
		((ButtonBase)RadioButton_TICKET).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)RadioButton_TICKET).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		RadioButton radioButton_TICKET = RadioButton_TICKET;
		location = new Point(192, 2);
		((Control)radioButton_TICKET).Location = location;
		((Control)RadioButton_TICKET).Name = "RadioButton_TICKET";
		RadioButton radioButton_TICKET2 = RadioButton_TICKET;
		size = new Size(75, 24);
		((Control)radioButton_TICKET2).Size = size;
		((Control)RadioButton_TICKET).TabIndex = 1033;
		RadioButton_TICKET.TabStop = true;
		((ButtonBase)RadioButton_TICKET).Text = "Ticket";
		((ButtonBase)RadioButton_TICKET).UseVisualStyleBackColor = true;
		((ButtonBase)RadioButton_DEVIS).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)RadioButton_DEVIS).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		RadioButton radioButton_DEVIS = RadioButton_DEVIS;
		location = new Point(11, 2);
		((Control)radioButton_DEVIS).Location = location;
		((Control)RadioButton_DEVIS).Name = "RadioButton_DEVIS";
		RadioButton radioButton_DEVIS2 = RadioButton_DEVIS;
		size = new Size(77, 24);
		((Control)radioButton_DEVIS2).Size = size;
		((Control)RadioButton_DEVIS).TabIndex = 1032;
		RadioButton_DEVIS.TabStop = true;
		((ButtonBase)RadioButton_DEVIS).Text = "Devis";
		((ButtonBase)RadioButton_DEVIS).UseVisualStyleBackColor = true;
		((ButtonBase)RadioButton_BL).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)RadioButton_BL).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		RadioButton radioButton_BL = RadioButton_BL;
		location = new Point(105, 2);
		((Control)radioButton_BL).Location = location;
		((Control)RadioButton_BL).Name = "RadioButton_BL";
		RadioButton radioButton_BL2 = RadioButton_BL;
		size = new Size(56, 24);
		((Control)radioButton_BL2).Size = size;
		((Control)RadioButton_BL).TabIndex = 1034;
		RadioButton_BL.TabStop = true;
		((ButtonBase)RadioButton_BL).Text = "BL";
		((ButtonBase)RadioButton_BL).UseVisualStyleBackColor = true;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AllowUserToResizeRows = false;
		DataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView3.BackgroundColor = Color.White;
		DataGridView3.BorderStyle = (BorderStyle)2;
		DataGridView3.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView3.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn14,
			(DataGridViewColumn)DataGridViewTextBoxColumn15,
			(DataGridViewColumn)Column1
		});
		((Control)DataGridView3).Cursor = Cursors.Default;
		DataGridView3.EditMode = (DataGridViewEditMode)4;
		DataGridView3.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView3;
		location = new Point(6, 73);
		((Control)dataGridView).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.RowHeadersVisible = false;
		DataGridView3.RowHeadersWidth = 25;
		DataGridView3.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView3;
		size = new Size(417, 160);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView3).TabIndex = 1034;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)DataGridViewTextBoxColumn14).Name = "DataGridViewTextBoxColumn14";
		((DataGridViewColumn)DataGridViewTextBoxColumn14).Width = 85;
		((DataGridViewColumn)DataGridViewTextBoxColumn15).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn15).HeaderText = "CLIENT";
		((DataGridViewColumn)DataGridViewTextBoxColumn15).Name = "DataGridViewTextBoxColumn15";
		((DataGridViewColumn)Column1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column1).HeaderText = "ID";
		((DataGridViewColumn)Column1).Name = "Column1";
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToResizeRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		DataGridView2.BorderStyle = (BorderStyle)2;
		DataGridView2.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView2.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[11]
		{
			(DataGridViewColumn)ID_ARTICLEE,
			(DataGridViewColumn)Codee,
			(DataGridViewColumn)Articlee,
			(DataGridViewColumn)PU_TTCC,
			(DataGridViewColumn)TAUX_TVAA,
			(DataGridViewColumn)PU_HTT,
			(DataGridViewColumn)QTEE,
			(DataGridViewColumn)TOTAL_TTCC,
			(DataGridViewColumn)TOTAL_TVAA,
			(DataGridViewColumn)TOTAL_HTT,
			(DataGridViewColumn)TAUX_REMISEE
		});
		DataGridView2.EditMode = (DataGridViewEditMode)4;
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(448, 6);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersWidth = 25;
		DataGridView2.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(415, 182);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 1032;
		((DataGridViewColumn)ID_ARTICLEE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLEE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLEE).Name = "ID_ARTICLEE";
		((DataGridViewColumn)Codee).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Codee).FillWeight = 91.08049f;
		((DataGridViewColumn)Codee).HeaderText = "Code";
		((DataGridViewColumn)Codee).Name = "Codee";
		((DataGridViewColumn)Codee).Width = 70;
		((DataGridViewColumn)Articlee).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Articlee).FillWeight = 91.08049f;
		((DataGridViewColumn)Articlee).HeaderText = "Article";
		((DataGridViewColumn)Articlee).Name = "Articlee";
		((DataGridViewColumn)Articlee).Width = 150;
		((DataGridViewColumn)PU_TTCC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PU_TTCC).HeaderText = "PU_TTC";
		((DataGridViewColumn)PU_TTCC).Name = "PU_TTCC";
		((DataGridViewColumn)PU_TTCC).Width = 60;
		((DataGridViewColumn)TAUX_TVAA).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TAUX_TVAA).FillWeight = 91.08049f;
		((DataGridViewColumn)TAUX_TVAA).HeaderText = "TAUX_TVA";
		((DataGridViewColumn)TAUX_TVAA).Name = "TAUX_TVAA";
		((DataGridViewColumn)TAUX_TVAA).Width = 60;
		((DataGridViewColumn)PU_HTT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PU_HTT).FillWeight = 91.08049f;
		((DataGridViewColumn)PU_HTT).HeaderText = "PU_HT";
		((DataGridViewColumn)PU_HTT).Name = "PU_HTT";
		((DataGridViewColumn)PU_HTT).Width = 60;
		((DataGridViewColumn)QTEE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)QTEE).FillWeight = 91.08049f;
		((DataGridViewColumn)QTEE).HeaderText = "Qté";
		((DataGridViewColumn)QTEE).Name = "QTEE";
		((DataGridViewColumn)QTEE).Width = 60;
		((DataGridViewColumn)TOTAL_TTCC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_TTCC).HeaderText = "TOTAL_TTC";
		((DataGridViewColumn)TOTAL_TTCC).Name = "TOTAL_TTCC";
		((DataGridViewColumn)TOTAL_TTCC).Width = 70;
		((DataGridViewColumn)TOTAL_TVAA).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_TVAA).HeaderText = "TOTAL_TVA";
		((DataGridViewColumn)TOTAL_TVAA).Name = "TOTAL_TVAA";
		((DataGridViewColumn)TOTAL_TVAA).Width = 70;
		((DataGridViewColumn)TOTAL_HTT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_HTT).HeaderText = "TOTAL_HT";
		((DataGridViewColumn)TOTAL_HTT).Name = "TOTAL_HTT";
		((DataGridViewColumn)TOTAL_HTT).Width = 70;
		((DataGridViewColumn)TAUX_REMISEE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TAUX_REMISEE).HeaderText = "TAUX_REMISE";
		((DataGridViewColumn)TAUX_REMISEE).MinimumWidth = 2;
		((DataGridViewColumn)TAUX_REMISEE).Name = "TAUX_REMISEE";
		((DataGridViewColumn)TAUX_REMISEE).Width = 82;
		((ButtonBase)Button6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button6).BackgroundImageLayout = (ImageLayout)4;
		((Control)Button6).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button6).ForeColor = Color.White;
		((ButtonBase)Button6).Image = (Image)componentResourceManager.GetObject("Button6.Image");
		((ButtonBase)Button6).ImageAlign = (ContentAlignment)16;
		Button button5 = Button6;
		location = new Point(448, 194);
		((Control)button5).Location = location;
		((Control)Button6).Name = "Button6";
		Button button6 = Button6;
		size = new Size(415, 39);
		((Control)button6).Size = size;
		((Control)Button6).TabIndex = 1033;
		((ButtonBase)Button6).Text = "Insérer";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
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
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(733, 510);
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
		((Control)PictureBox2323).Cursor = Cursors.Hand;
		PictureBox2323.Image = (Image)componentResourceManager.GetObject("PictureBox2323.Image");
		PictureBox pictureBox3 = PictureBox2323;
		location = new Point(202, 302);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2323).Name = "PictureBox2323";
		PictureBox pictureBox4 = PictureBox2323;
		size = new Size(24, 26);
		((Control)pictureBox4).Size = size;
		PictureBox2323.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2323.TabIndex = 998;
		PictureBox2323.TabStop = false;
		DataGrid_BODY.AllowUserToAddRows = false;
		DataGrid_BODY.AllowUserToResizeRows = false;
		DataGrid_BODY.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_BODY.BackgroundColor = Color.White;
		DataGrid_BODY.BorderStyle = (BorderStyle)2;
		DataGrid_BODY.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGrid_BODY.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Tahoma", 8f);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGrid_BODY.ColumnHeadersDefaultCellStyle = val;
		DataGrid_BODY.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_BODY.Columns.AddRange(new DataGridViewColumn[12]
		{
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)PU_TTC,
			(DataGridViewColumn)TAUX_TVA,
			(DataGridViewColumn)PU_HT,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)TOTAL_TTC,
			(DataGridViewColumn)TOTAL_TVA,
			(DataGridViewColumn)TOTAL_HT,
			(DataGridViewColumn)TAUX_REMISE,
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
		((DataGridViewColumn)PU_TTC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val2.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)PU_TTC).DefaultCellStyle = val2;
		((DataGridViewColumn)PU_TTC).HeaderText = "PU_TTC";
		((DataGridViewColumn)PU_TTC).Name = "PU_TTC";
		((DataGridViewColumn)PU_TTC).Width = 60;
		((DataGridViewColumn)TAUX_TVA).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val3.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)TAUX_TVA).DefaultCellStyle = val3;
		((DataGridViewColumn)TAUX_TVA).FillWeight = 91.08049f;
		((DataGridViewColumn)TAUX_TVA).HeaderText = "TAUX_TVA";
		((DataGridViewColumn)TAUX_TVA).Name = "TAUX_TVA";
		((DataGridViewColumn)TAUX_TVA).Width = 60;
		((DataGridViewColumn)PU_HT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val4.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)PU_HT).DefaultCellStyle = val4;
		((DataGridViewColumn)PU_HT).FillWeight = 91.08049f;
		((DataGridViewColumn)PU_HT).HeaderText = "PU_HT";
		((DataGridViewColumn)PU_HT).Name = "PU_HT";
		((DataGridViewColumn)PU_HT).Width = 60;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val5.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)Qté).DefaultCellStyle = val5;
		((DataGridViewColumn)Qté).FillWeight = 91.08049f;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		((DataGridViewColumn)Qté).Width = 60;
		((DataGridViewColumn)TOTAL_TTC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val6.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)TOTAL_TTC).DefaultCellStyle = val6;
		((DataGridViewColumn)TOTAL_TTC).HeaderText = "TOTAL_TTC";
		((DataGridViewColumn)TOTAL_TTC).Name = "TOTAL_TTC";
		((DataGridViewColumn)TOTAL_TTC).Width = 70;
		((DataGridViewColumn)TOTAL_TVA).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val7.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)TOTAL_TVA).DefaultCellStyle = val7;
		((DataGridViewColumn)TOTAL_TVA).HeaderText = "TOTAL_TVA";
		((DataGridViewColumn)TOTAL_TVA).Name = "TOTAL_TVA";
		((DataGridViewColumn)TOTAL_TVA).Width = 70;
		((DataGridViewColumn)TOTAL_HT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val8.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)TOTAL_HT).DefaultCellStyle = val8;
		((DataGridViewColumn)TOTAL_HT).HeaderText = "TOTAL_HT";
		((DataGridViewColumn)TOTAL_HT).Name = "TOTAL_HT";
		((DataGridViewColumn)TOTAL_HT).Width = 70;
		((DataGridViewColumn)TAUX_REMISE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val9.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)TAUX_REMISE).DefaultCellStyle = val9;
		((DataGridViewColumn)TAUX_REMISE).HeaderText = "TAUX_REMISE";
		((DataGridViewColumn)TAUX_REMISE).MinimumWidth = 2;
		((DataGridViewColumn)TAUX_REMISE).Name = "TAUX_REMISE";
		((DataGridViewColumn)TAUX_REMISE).Width = 2;
		((DataGridViewColumn)sup).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)sup).HeaderText = "";
		sup.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)sup).Name = "sup";
		((DataGridViewColumn)sup).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)sup).Width = 40;
		DataGridView1.AllowUserToAddRows = false;
		val10.BackColor = Color.FromArgb(255, 128, 128);
		DataGridView1.AlternatingRowsDefaultCellStyle = val10;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val11.Alignment = (DataGridViewContentAlignment)16;
		val11.BackColor = SystemColors.Control;
		val11.Font = new Font("Calibri", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val11.ForeColor = SystemColors.WindowText;
		val11.SelectionBackColor = SystemColors.Highlight;
		val11.SelectionForeColor = SystemColors.HighlightText;
		val11.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val11;
		DataGridView1.ColumnHeadersHeight = 24;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[11]
		{
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)ID_FACTURE,
			(DataGridViewColumn)UTILISATEUR,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)TOTAL_HT_DOC,
			(DataGridViewColumn)TOTAL_TVA_DOC,
			(DataGridViewColumn)TOTAL_TTC_DOC,
			(DataGridViewColumn)ETAT,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi,
			(DataGridViewColumn)cons
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView5 = DataGridView1;
		location = new Point(0, 42);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 25;
		DataGridView dataGridView6 = DataGridView1;
		size = new Size(1025, 566);
		((Control)dataGridView6).Size = size;
		((Control)DataGridView1).TabIndex = 0;
		((DataGridViewColumn)Dates).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Dates).DataPropertyName = "Dates";
		val12.Format = "d";
		val12.NullValue = null;
		((DataGridViewColumn)Dates).DefaultCellStyle = val12;
		((DataGridViewColumn)Dates).HeaderText = "DATES";
		((DataGridViewColumn)Dates).Name = "Dates";
		Dates.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Dates).Width = 90;
		((DataGridViewColumn)ID_FACTURE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_FACTURE).DataPropertyName = "ID_FACTURE";
		((DataGridViewColumn)ID_FACTURE).HeaderText = "ID_FACTURE";
		((DataGridViewColumn)ID_FACTURE).MinimumWidth = 2;
		((DataGridViewColumn)ID_FACTURE).Name = "ID_FACTURE";
		((DataGridViewColumn)ID_FACTURE).Width = 110;
		((DataGridViewColumn)UTILISATEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)UTILISATEUR).DataPropertyName = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).HeaderText = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).Name = "UTILISATEUR";
		UTILISATEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)UTILISATEUR).Width = 110;
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).FillWeight = 184.9711f;
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		CLIENT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TOTAL_HT_DOC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_HT_DOC).DataPropertyName = "TOTAL_HT_DOC";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "N2";
		((DataGridViewColumn)TOTAL_HT_DOC).DefaultCellStyle = val13;
		((DataGridViewColumn)TOTAL_HT_DOC).HeaderText = "TOTAL_HT";
		((DataGridViewColumn)TOTAL_HT_DOC).Name = "TOTAL_HT_DOC";
		((DataGridViewColumn)TOTAL_TVA_DOC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_TVA_DOC).DataPropertyName = "TOTAL_TVA_DOC";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "N2";
		((DataGridViewColumn)TOTAL_TVA_DOC).DefaultCellStyle = val14;
		((DataGridViewColumn)TOTAL_TVA_DOC).HeaderText = "TOTAL_TVA";
		((DataGridViewColumn)TOTAL_TVA_DOC).Name = "TOTAL_TVA_DOC";
		((DataGridViewColumn)TOTAL_TTC_DOC).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_TTC_DOC).DataPropertyName = "TOTAL_TTC_DOC";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "N2";
		val15.NullValue = null;
		((DataGridViewColumn)TOTAL_TTC_DOC).DefaultCellStyle = val15;
		((DataGridViewColumn)TOTAL_TTC_DOC).HeaderText = "TOTAL_TTC";
		((DataGridViewColumn)TOTAL_TTC_DOC).Name = "TOTAL_TTC_DOC";
		((DataGridViewColumn)ETAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETAT).DataPropertyName = "ETAT";
		((DataGridViewColumn)ETAT).HeaderText = "ETAT";
		((DataGridViewColumn)ETAT).MinimumWidth = 2;
		((DataGridViewColumn)ETAT).Name = "ETAT";
		((DataGridViewColumn)ETAT).Width = 110;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).FillWeight = 51.65462f;
		((DataGridViewColumn)supp).HeaderText = "";
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)supp).SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)supp).Width = 40;
		((DataGridViewColumn)modi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)modi).FillWeight = 72.47877f;
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
		((DataGridViewColumn)cons).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)cons).Width = 40;
		((Control)Panel243544).Anchor = (AnchorStyles)14;
		((Control)Panel243544).BackColor = Color.Transparent;
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_TTC_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label54);
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_TVA_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_HT_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label51);
		((Control)Panel243544).Controls.Add((Control)(object)Label52);
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label22);
		((Control)Panel243544).Controls.Add((Control)(object)Label21);
		((Control)Panel243544).Controls.Add((Control)(object)Button_CALC_BD);
		Panel panel13 = Panel243544;
		location = new Point(0, 609);
		((Control)panel13).Location = location;
		((Control)Panel243544).Name = "Panel243544";
		Panel panel14 = Panel243544;
		size = new Size(1025, 31);
		((Control)panel14).Size = size;
		((Control)Panel243544).TabIndex = 1061;
		((Control)Label_TOTAL_TTC_BD).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_TTC_BD).BackColor = Color.White;
		((Control)Label_TOTAL_TTC_BD).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label_TOTAL_TTC_BD).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_TTC_BD = Label_TOTAL_TTC_BD;
		location = new Point(892, 1);
		((Control)label_TOTAL_TTC_BD).Location = location;
		((Control)Label_TOTAL_TTC_BD).Name = "Label_TOTAL_TTC_BD";
		Label label_TOTAL_TTC_BD2 = Label_TOTAL_TTC_BD;
		size = new Size(132, 29);
		((Control)label_TOTAL_TTC_BD2).Size = size;
		((Control)Label_TOTAL_TTC_BD).TabIndex = 1088;
		Label_TOTAL_TTC_BD.Text = "-";
		Label_TOTAL_TTC_BD.TextAlign = (ContentAlignment)16;
		((Control)Label54).Anchor = (AnchorStyles)9;
		((Control)Label54).BackColor = Color.White;
		((Control)Label54).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label54).ForeColor = Color.FromArgb(64, 64, 64);
		Label label73 = Label54;
		location = new Point(792, 1);
		((Control)label73).Location = location;
		((Control)Label54).Name = "Label54";
		Label label74 = Label54;
		size = new Size(100, 29);
		((Control)label74).Size = size;
		((Control)Label54).TabIndex = 1087;
		Label54.Text = "TOTAL TTC :";
		Label54.TextAlign = (ContentAlignment)16;
		((Control)Label_TOTAL_TVA_BD).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_TVA_BD).BackColor = Color.White;
		((Control)Label_TOTAL_TVA_BD).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label_TOTAL_TVA_BD).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_TVA_BD = Label_TOTAL_TVA_BD;
		location = new Point(660, 1);
		((Control)label_TOTAL_TVA_BD).Location = location;
		((Control)Label_TOTAL_TVA_BD).Name = "Label_TOTAL_TVA_BD";
		Label label_TOTAL_TVA_BD2 = Label_TOTAL_TVA_BD;
		size = new Size(132, 29);
		((Control)label_TOTAL_TVA_BD2).Size = size;
		((Control)Label_TOTAL_TVA_BD).TabIndex = 1086;
		Label_TOTAL_TVA_BD.Text = "-";
		Label_TOTAL_TVA_BD.TextAlign = (ContentAlignment)16;
		((Control)Label_TOTAL_HT_BD).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_HT_BD).BackColor = Color.White;
		((Control)Label_TOTAL_HT_BD).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label_TOTAL_HT_BD).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_HT_BD = Label_TOTAL_HT_BD;
		location = new Point(426, 1);
		((Control)label_TOTAL_HT_BD).Location = location;
		((Control)Label_TOTAL_HT_BD).Name = "Label_TOTAL_HT_BD";
		Label label_TOTAL_HT_BD2 = Label_TOTAL_HT_BD;
		size = new Size(132, 29);
		((Control)label_TOTAL_HT_BD2).Size = size;
		((Control)Label_TOTAL_HT_BD).TabIndex = 1085;
		Label_TOTAL_HT_BD.Text = "-";
		Label_TOTAL_HT_BD.TextAlign = (ContentAlignment)16;
		((Control)Label51).Anchor = (AnchorStyles)9;
		((Control)Label51).BackColor = Color.White;
		((Control)Label51).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label51).ForeColor = Color.FromArgb(64, 64, 64);
		Label label75 = Label51;
		location = new Point(558, 1);
		((Control)label75).Location = location;
		((Control)Label51).Name = "Label51";
		Label label76 = Label51;
		size = new Size(102, 29);
		((Control)label76).Size = size;
		((Control)Label51).TabIndex = 1083;
		Label51.Text = "TOTAL TVA :";
		Label51.TextAlign = (ContentAlignment)16;
		((Control)Label52).Anchor = (AnchorStyles)9;
		((Control)Label52).BackColor = Color.White;
		((Control)Label52).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label52).ForeColor = Color.FromArgb(64, 64, 64);
		Label label77 = Label52;
		location = new Point(335, 1);
		((Control)label77).Location = location;
		((Control)Label52).Name = "Label52";
		Label label78 = Label52;
		size = new Size(91, 29);
		((Control)label78).Size = size;
		((Control)Label52).TabIndex = 1084;
		Label52.Text = "TOTAL HT :";
		Label52.TextAlign = (ContentAlignment)16;
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
		((Control)Label_TOTAL_LIGNES_BD).TabIndex = 1082;
		Label_TOTAL_LIGNES_BD.Text = "-/-";
		Label_TOTAL_LIGNES_BD.TextAlign = (ContentAlignment)16;
		((Control)Label22).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label22).Cursor = Cursors.Hand;
		((Control)Label22).Dock = (DockStyle)2;
		((Control)Label22).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label79 = Label22;
		location = new Point(0, 30);
		((Control)label79).Location = location;
		((Control)Label22).Name = "Label22";
		Label label80 = Label22;
		size = new Size(1025, 1);
		((Control)label80).Size = size;
		((Control)Label22).TabIndex = 1081;
		Label22.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Dock = (DockStyle)1;
		((Control)Label21).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label81 = Label21;
		location = new Point(0, 0);
		((Control)label81).Location = location;
		((Control)Label21).Name = "Label21";
		Label label82 = Label21;
		size = new Size(1025, 1);
		((Control)label82).Size = size;
		((Control)Label21).TabIndex = 1080;
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		Button button_CALC_BD = Button_CALC_BD;
		location = new Point(71, 2);
		((Control)button_CALC_BD).Location = location;
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		Button button_CALC_BD2 = Button_CALC_BD;
		size = new Size(48, 29);
		((Control)button_CALC_BD2).Size = size;
		((Control)Button_CALC_BD).TabIndex = 1066;
		((ButtonBase)Button_CALC_BD).Text = "CALC";
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		((Control)Button_CALC_BD).Visible = false;
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
		((Control)Button_VALIDER).TabIndex = 1065;
		((ButtonBase)Button_VALIDER).Text = "Valider";
		((ButtonBase)Button_VALIDER).UseVisualStyleBackColor = false;
		((Control)Label4141).Anchor = (AnchorStyles)10;
		((Control)Label4141).BackColor = Color.Red;
		((Control)Label4141).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Label4141).ForeColor = Color.White;
		Label label83 = Label4141;
		location = new Point(694, 580);
		((Control)label83).Location = location;
		((Control)Label4141).Name = "Label4141";
		Label label84 = Label4141;
		size = new Size(330, 26);
		((Control)label84).Size = size;
		((Control)Label4141).TabIndex = 1067;
		Label4141.TextAlign = (ContentAlignment)64;
		((Control)Label4141).Visible = false;
		((Control)Panel7727).Anchor = (AnchorStyles)6;
		((Control)Panel7727).BackColor = Color.FromArgb(64, 64, 64);
		((Control)Panel7727).Controls.Add((Control)(object)Button_CALC_ENREGISTRER);
		((Control)Panel7727).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel7727).Controls.Add((Control)(object)TextBox33398);
		Panel panel15 = Panel7727;
		location = new Point(0, 577);
		((Control)panel15).Location = location;
		((Control)Panel7727).Name = "Panel7727";
		Panel panel16 = Panel7727;
		size = new Size(360, 31);
		((Control)panel16).Size = size;
		((Control)Panel7727).TabIndex = 1068;
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
		((DataGridViewColumn)DataGridViewImageColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn1).HeaderText = "";
		DataGridViewImageColumn1.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)DataGridViewImageColumn1).Name = "DataGridViewImageColumn1";
		((DataGridViewColumn)DataGridViewImageColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewImageColumn1).Width = 40;
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
		((Control)Button_FONCTIONS).TabIndex = 1069;
		((ButtonBase)Button_FONCTIONS).Text = "   Fonctions";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = false;
		((Control)Panel_FONCTIONS).Anchor = (AnchorStyles)10;
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Text_pied_doc);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label44);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label43);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label42);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label45);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PDF);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_EXCEL);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_WORD);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PrintRapport);
		Panel panel_FONCTIONS = Panel_FONCTIONS;
		location = new Point(854, 320);
		((Control)panel_FONCTIONS).Location = location;
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		Panel panel_FONCTIONS2 = Panel_FONCTIONS;
		size = new Size(166, 326);
		((Control)panel_FONCTIONS2).Size = size;
		((Control)Panel_FONCTIONS).TabIndex = 1070;
		((Control)Panel_FONCTIONS).Visible = false;
		((TextBoxBase)Text_pied_doc).BorderStyle = (BorderStyle)1;
		((Control)Text_pied_doc).Font = new Font("Microsoft Sans Serif", 10f);
		TextBox text_pied_doc = Text_pied_doc;
		location = new Point(58, 170);
		((Control)text_pied_doc).Location = location;
		Text_pied_doc.Multiline = true;
		((Control)Text_pied_doc).Name = "Text_pied_doc";
		TextBox text_pied_doc2 = Text_pied_doc;
		size = new Size(371, 111);
		((Control)text_pied_doc2).Size = size;
		((Control)Text_pied_doc).TabIndex = 1064;
		((Control)Text_pied_doc).Visible = false;
		((Control)Label44).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label44).Cursor = Cursors.Hand;
		((Control)Label44).Dock = (DockStyle)1;
		((Control)Label44).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label44).ForeColor = Color.White;
		Label label85 = Label44;
		location = new Point(2, 0);
		((Control)label85).Location = location;
		((Control)Label44).Name = "Label44";
		Label label86 = Label44;
		size = new Size(160, 2);
		((Control)label86).Size = size;
		((Control)Label44).TabIndex = 1062;
		Label44.TextAlign = (ContentAlignment)16;
		((Control)Label43).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label43).Cursor = Cursors.Hand;
		((Control)Label43).Dock = (DockStyle)4;
		((Control)Label43).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label43).ForeColor = Color.White;
		Label label87 = Label43;
		location = new Point(162, 0);
		((Control)label87).Location = location;
		((Control)Label43).Name = "Label43";
		Label label88 = Label43;
		size = new Size(2, 322);
		((Control)label88).Size = size;
		((Control)Label43).TabIndex = 1061;
		Label43.TextAlign = (ContentAlignment)16;
		((Control)Label42).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label42).Cursor = Cursors.Hand;
		((Control)Label42).Dock = (DockStyle)3;
		((Control)Label42).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label42).ForeColor = Color.White;
		Label label89 = Label42;
		location = new Point(0, 0);
		((Control)label89).Location = location;
		((Control)Label42).Name = "Label42";
		Label label90 = Label42;
		size = new Size(2, 322);
		((Control)label90).Size = size;
		((Control)Label42).TabIndex = 1060;
		Label42.TextAlign = (ContentAlignment)16;
		((Control)Label45).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label45).Cursor = Cursors.Hand;
		((Control)Label45).Dock = (DockStyle)2;
		((Control)Label45).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label45).ForeColor = Color.White;
		Label label91 = Label45;
		location = new Point(0, 322);
		((Control)label91).Location = location;
		((Control)Label45).Name = "Label45";
		Label label92 = Label45;
		size = new Size(164, 2);
		((Control)label92).Size = size;
		((Control)Label45).TabIndex = 1059;
		Label45.TextAlign = (ContentAlignment)16;
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
		((Control)Label_TABLE).TabIndex = 1071;
		Label_TABLE.Text = "FACTURE_ENTETE";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label5);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label14);
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
		((Control)Panel_FIND).TabIndex = 1072;
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
		((ComboBox)Combo_FIND).Items.AddRange(new object[7] { "ID_FACTURE", "UTILISATEUR", "ID_CLIENT", "CODE_CLIENT", "CLIENT", "ETAT", "DATES" });
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
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Segoe UI", 9.75f);
		((Control)Label5).ForeColor = Color.White;
		Label5.ImeMode = (ImeMode)0;
		Label label93 = Label5;
		location = new Point(492, 13);
		((Control)label93).Location = location;
		((Control)Label5).Name = "Label5";
		Label label94 = Label5;
		size = new Size(65, 17);
		((Control)label94).Size = size;
		((Control)Label5).TabIndex = 1055;
		Label5.Text = "Avec date";
		Label14.AutoSize = true;
		((Control)Label14).Font = new Font("Segoe UI", 9.75f);
		((Control)Label14).ForeColor = Color.White;
		Label14.ImeMode = (ImeMode)0;
		Label label95 = Label14;
		location = new Point(411, 13);
		((Control)label95).Location = location;
		((Control)Label14).Name = "Label14";
		Label label96 = Label14;
		size = new Size(45, 17);
		((Control)label96).Size = size;
		((Control)Label14).TabIndex = 1054;
		Label14.Text = "Exacte";
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
		((Control)Label_TOTAL_REMISE_DOC).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_REMISE_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_REMISE_DOC).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label_TOTAL_REMISE_DOC).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_REMISE_DOC = Label_TOTAL_REMISE_DOC;
		location = new Point(781, 1);
		((Control)label_TOTAL_REMISE_DOC).Location = location;
		((Control)Label_TOTAL_REMISE_DOC).Name = "Label_TOTAL_REMISE_DOC";
		Label label_TOTAL_REMISE_DOC2 = Label_TOTAL_REMISE_DOC;
		size = new Size(94, 29);
		((Control)label_TOTAL_REMISE_DOC2).Size = size;
		((Control)Label_TOTAL_REMISE_DOC).TabIndex = 1098;
		Label_TOTAL_REMISE_DOC.Text = "-";
		Label_TOTAL_REMISE_DOC.TextAlign = (ContentAlignment)16;
		((Control)Label58).Anchor = (AnchorStyles)9;
		((Control)Label58).BackColor = Color.White;
		((Control)Label58).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label58).ForeColor = Color.FromArgb(64, 64, 64);
		Label label97 = Label58;
		location = new Point(662, 1);
		((Control)label97).Location = location;
		((Control)Label58).Name = "Label58";
		Label label98 = Label58;
		size = new Size(119, 29);
		((Control)label98).Size = size;
		((Control)Label58).TabIndex = 1097;
		Label58.Text = "TOTAL REMISE :";
		Label58.TextAlign = (ContentAlignment)16;
		((Control)Label_TOTAL_HT_DOC).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_HT_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_HT_DOC).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label_TOTAL_HT_DOC).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_HT_DOC = Label_TOTAL_HT_DOC;
		location = new Point(568, 1);
		((Control)label_TOTAL_HT_DOC).Location = location;
		((Control)Label_TOTAL_HT_DOC).Name = "Label_TOTAL_HT_DOC";
		Label label_TOTAL_HT_DOC2 = Label_TOTAL_HT_DOC;
		size = new Size(94, 29);
		((Control)label_TOTAL_HT_DOC2).Size = size;
		((Control)Label_TOTAL_HT_DOC).TabIndex = 1096;
		Label_TOTAL_HT_DOC.Text = "-";
		Label_TOTAL_HT_DOC.TextAlign = (ContentAlignment)16;
		((Control)Label56).Anchor = (AnchorStyles)9;
		((Control)Label56).BackColor = Color.White;
		((Control)Label56).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label56).ForeColor = Color.FromArgb(64, 64, 64);
		Label label99 = Label56;
		location = new Point(480, 1);
		((Control)label99).Location = location;
		((Control)Label56).Name = "Label56";
		Label label100 = Label56;
		size = new Size(88, 29);
		((Control)label100).Size = size;
		((Control)Label56).TabIndex = 1095;
		Label56.Text = "TOTAL HT :";
		Label56.TextAlign = (ContentAlignment)16;
		((Control)Label_TOTAL_TVA_DOC).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_TVA_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_TVA_DOC).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label_TOTAL_TVA_DOC).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_TVA_DOC = Label_TOTAL_TVA_DOC;
		location = new Point(386, 1);
		((Control)label_TOTAL_TVA_DOC).Location = location;
		((Control)Label_TOTAL_TVA_DOC).Name = "Label_TOTAL_TVA_DOC";
		Label label_TOTAL_TVA_DOC2 = Label_TOTAL_TVA_DOC;
		size = new Size(94, 29);
		((Control)label_TOTAL_TVA_DOC2).Size = size;
		((Control)Label_TOTAL_TVA_DOC).TabIndex = 1094;
		Label_TOTAL_TVA_DOC.Text = "-";
		Label_TOTAL_TVA_DOC.TextAlign = (ContentAlignment)16;
		((Control)Label_TOTAL_TTC_DOC).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_TTC_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_TTC_DOC).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label_TOTAL_TTC_DOC).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_TTC_DOC = Label_TOTAL_TTC_DOC;
		location = new Point(193, 1);
		((Control)label_TOTAL_TTC_DOC).Location = location;
		((Control)Label_TOTAL_TTC_DOC).Name = "Label_TOTAL_TTC_DOC";
		Label label_TOTAL_TTC_DOC2 = Label_TOTAL_TTC_DOC;
		size = new Size(94, 29);
		((Control)label_TOTAL_TTC_DOC2).Size = size;
		((Control)Label_TOTAL_TTC_DOC).TabIndex = 1093;
		Label_TOTAL_TTC_DOC.Text = "-";
		Label_TOTAL_TTC_DOC.TextAlign = (ContentAlignment)16;
		((Control)Label53).Anchor = (AnchorStyles)9;
		((Control)Label53).BackColor = Color.White;
		((Control)Label53).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label53).ForeColor = Color.FromArgb(64, 64, 64);
		Label label101 = Label53;
		location = new Point(96, 1);
		((Control)label101).Location = location;
		((Control)Label53).Name = "Label53";
		Label label102 = Label53;
		size = new Size(97, 29);
		((Control)label102).Size = size;
		((Control)Label53).TabIndex = 1092;
		Label53.Text = "TOTAL TTC :";
		Label53.TextAlign = (ContentAlignment)16;
		((Control)Label49).Anchor = (AnchorStyles)9;
		((Control)Label49).BackColor = Color.White;
		((Control)Label49).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label49).ForeColor = Color.FromArgb(64, 64, 64);
		Label label103 = Label49;
		location = new Point(287, 1);
		((Control)label103).Location = location;
		((Control)Label49).Name = "Label49";
		Label label104 = Label49;
		size = new Size(99, 29);
		((Control)label104).Size = size;
		((Control)Label49).TabIndex = 1091;
		Label49.Text = "TOTAL TVA :";
		Label49.TextAlign = (ContentAlignment)16;
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
		((Control)this).Controls.Add((Control)(object)Button_VALIDER);
		((Control)this).Controls.Add((Control)(object)Panel243544);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Label4141);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_90000_FACTURE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView_FAMILLES).EndInit();
		((ISupportInitialize)DataGridView_ARTICLES).EndInit();
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel7).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)Panel6).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((ISupportInitialize)PictureBox2323).EndInit();
		((ISupportInitialize)DataGrid_BODY).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel243544).ResumeLayout(false);
		((Control)Panel7727).ResumeLayout(false);
		((Control)Panel7727).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)Panel_FONCTIONS).PerformLayout();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
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
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
			DataGridView1.Columns["cons"].Visible = true;
			((Control)Button_VALIDER).Enabled = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
			DataGridView1.Columns["cons"].Visible = true;
			((Control)Button_VALIDER).Enabled = false;
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

	public string ImageToBase64(Image image, ImageFormat format)
	{
		using MemoryStream memoryStream = new MemoryStream();
		image.Save((Stream)memoryStream, format);
		byte[] inArray = memoryStream.ToArray();
		return Convert.ToBase64String(inArray);
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
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
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
				TabPage3.ImageIndex = 0;
				if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
				{
					((Control)Text_PU_TTC).Enabled = true;
					((Control)Text_PU_HT).Enabled = false;
				}
				else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
				{
					((Control)Text_PU_TTC).Enabled = false;
					((Control)Text_PU_HT).Enabled = true;
				}
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
				if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
				{
					DataGrid_BODY.EditMode = (DataGridViewEditMode)0;
					DataGrid_BODY.Columns["PU_TTC"].ReadOnly = false;
					DataGrid_BODY.Columns["TAUX_TVA"].ReadOnly = false;
					DataGrid_BODY.Columns["Qté"].ReadOnly = false;
					DataGrid_BODY.Columns["PU_TTC"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
					DataGrid_BODY.Columns["TAUX_TVA"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
					DataGrid_BODY.Columns["Qté"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
				}
				else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
				{
					DataGrid_BODY.EditMode = (DataGridViewEditMode)0;
					DataGrid_BODY.Columns["TAUX_TVA"].ReadOnly = false;
					DataGrid_BODY.Columns["PU_HT"].ReadOnly = false;
					DataGrid_BODY.Columns["Qté"].ReadOnly = false;
					DataGrid_BODY.Columns["PU_HT"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
					DataGrid_BODY.Columns["TAUX_TVA"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
					DataGrid_BODY.Columns["Qté"].DefaultCellStyle.Font = new Font("Tahoma", 10f, (FontStyle)1);
				}
				DataGrid_BODY.EnableHeadersVisualStyles = false;
				((DataGridViewCell)DataGrid_BODY.Columns["PU_TTC"].HeaderCell).Style.BackColor = Color.Orange;
				((DataGridViewCell)DataGrid_BODY.Columns["TAUX_TVA"].HeaderCell).Style.BackColor = Color.Orange;
				((DataGridViewCell)DataGrid_BODY.Columns["PU_HT"].HeaderCell).Style.BackColor = Color.Orange;
				((DataGridViewCell)DataGrid_BODY.Columns["Qté"].HeaderCell).Style.BackColor = Color.Transparent;
				((DataGridViewCell)DataGrid_BODY.Columns["TOTAL_TTC"].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGrid_BODY.Columns["TOTAL_TVA"].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGrid_BODY.Columns["TOTAL_HT"].HeaderCell).Style.BackColor = Color.Yellow;
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
					num9++;
				}
				Text_pied_doc.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("PIED_DOC", false, 0).Index].SubItems[1].Text;
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
		//IL_13fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_131b: Expected Obj, but got Unknown
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected Obj, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(Button_CLIENT._ID_Button, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CODE_CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (DataGrid_BODY.Rows.Count == 0)
				{
					MessageBox.Show("Veuillez remplir la Table ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOTAL_TTC_DOC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TOTAL_TTC- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOTAL_TVA_DOC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TOTAL_TVA- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOTAL_HT_DOC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TOTAL_HT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOTAL_REMISE_DOC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TOTAL_REMISE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
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
					val.CommandText = "Select FACTURE from TABLE_NUM  where ID = 0 ";
					val.Connection = Module1.cn_SQL;
					val.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string text = ((val.ExecuteScalar() != DBNull.Value) ? ("FA-" + Conversions.ToString(DateAndTime.Year(DateAndTime.Now)) + Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(val.ExecuteScalar())), "0000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["ID_FACTURE"] = text;
					DT.Rows[index]["Dates"] = DateTimePicker_DATE.Text;
					DT.Rows[index]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[index]["ID_CLIENT"] = Button_CLIENT._ID_Button;
					DT.Rows[index]["CODE_CLIENT"] = Button_CLIENT._CODE_Button;
					DT.Rows[index]["CLIENT"] = ((ButtonBase)Button_CLIENT).Text;
					DT.Rows[index]["TOTAL_TTC_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TTC_DOC.Text));
					DT.Rows[index]["TOTAL_TVA_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TVA_DOC.Text));
					DT.Rows[index]["TOTAL_HT_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_HT_DOC.Text));
					DT.Rows[index]["TOTAL_REMISE_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_REMISE_DOC.Text));
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
						val3.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_FACTURE_DETAILS              ( Dates,ID_FACTURE, ID_CLIENT,CODE_CLIENT,CLIENT, ID_ARTICLE,  Code, Article , PU_TTC, TAUX_TVA, PU_HT, Qté,TOTAL_TTC,TOTAL_TVA,TOTAL_HT, TAUX_REMISE  , ETAT )      values           ('" + DateTimePicker_DATE.Text, "' ,'"), text), "'   ,'"), Button_CLIENT._ID_Button), "'  ,'"), Button_CLIENT._CODE_Button), "' ,'"), ((ButtonBase)Button_CLIENT).Text), "' ,'"), DataGrid_BODY.Rows[num3].Cells["ID_ARTICLE"].Value), "'  ,'"), DataGrid_BODY.Rows[num3].Cells["Code"].Value), "' ,'"), DataGrid_BODY.Rows[num3].Cells["Article"].Value), "'  ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["PU_TTC"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["TAUX_TVA"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["PU_HT"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["Qté"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["TOTAL_TTC"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["TOTAL_TVA"].Value))), "'      ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["TOTAL_HT"].Value))), "'   ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["TAUX_REMISE"].Value))), "'   , 'ENREGISTRER'   )   "));
						val3.Connection = Module1.cn_SQL;
						val3.ExecuteNonQuery();
						num3++;
					}
					Module1.cn_SQL.Close();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val.CommandText = "UPDATE     TABLE_NUM    SET FACTURE =  FACTURE + 1   ";
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
					val4 = new MySqlDataAdapter("select ID,ID_FACTURE    from TABLE_" + Label_TABLE.Text + " WHERE   ID_FACTURE = '" + Text_ID_FACTURE.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val4).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						MessageBox.Show("Cet ID est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position]["ID"] = Text_ID.Text;
					DT.Rows[position]["ID_FACTURE"] = Text_ID_FACTURE.Text;
					DT.Rows[position]["Dates"] = DateTimePicker_DATE.Text;
					DT.Rows[position]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[position]["ID_CLIENT"] = Button_CLIENT._ID_Button;
					DT.Rows[position]["CODE_CLIENT"] = Button_CLIENT._CODE_Button;
					DT.Rows[position]["CLIENT"] = ((ButtonBase)Button_CLIENT).Text;
					DT.Rows[position]["TOTAL_TTC_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TTC_DOC.Text));
					DT.Rows[position]["TOTAL_TVA_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TVA_DOC.Text));
					DT.Rows[position]["TOTAL_HT_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_HT_DOC.Text));
					DT.Rows[position]["TOTAL_REMISE_DOC"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_REMISE_DOC.Text));
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
					val6.CommandText = "Delete   from TABLE_FACTURE_DETAILS    Where   ID_FACTURE = '" + Text_ID_FACTURE.Text + "' ";
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
						val6.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_FACTURE_DETAILS              ( Dates,ID_FACTURE, ID_CLIENT,CODE_CLIENT,CLIENT, ID_ARTICLE,  Code, Article , PU_TTC, TAUX_TVA, PU_HT, Qté,TOTAL_TTC,TOTAL_TVA,TOTAL_HT, TAUX_REMISE  , ETAT )      values           ('" + DateTimePicker_DATE.Text, "' ,'"), Text_ID_FACTURE.Text), "'   ,'"), Button_CLIENT._ID_Button), "'  ,'"), Button_CLIENT._CODE_Button), "' ,'"), ((ButtonBase)Button_CLIENT).Text), "' ,'"), DataGrid_BODY.Rows[num7].Cells["ID_ARTICLE"].Value), "'  ,'"), DataGrid_BODY.Rows[num7].Cells["Code"].Value), "' ,'"), DataGrid_BODY.Rows[num7].Cells["Article"].Value), "'  ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["PU_TTC"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["TAUX_TVA"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["PU_HT"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["Qté"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["TOTAL_TTC"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["TOTAL_TVA"].Value))), "'      ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["TOTAL_HT"].Value))), "'   ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["TAUX_REMISE"].Value))), "'   , 'ENREGISTRER'   )   "));
						val6.Connection = Module1.cn_SQL;
						val6.ExecuteNonQuery();
						num7++;
					}
					Module1.cn_SQL.Close();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					string right = Conversions.ToString(Operators.ConcatenateObject("MODIFICATION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[2].Value));
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

	private void Button_ADD_Click(object sender, EventArgs e)
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
			Text_ID_FACTURE.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			Text_UTILISATEUR.Text = Module1._USERNAME;
			Button_CLIENT._ID_Button = "";
			Button_CLIENT._CODE_Button = "";
			((ButtonBase)Button_CLIENT).Text = "";
			Text_NOTES.Text = "";
			Text_CODE_FIND.Text = "";
			Text_ARTICLE_FIND.Text = "";
			Text_CODE.Text = "";
			Text_ARTICLE.Text = "";
			Text_TAUX_TVA.Text = "";
			Text_PU_TTC.Text = "";
			Text_PU_HT.Text = "";
			Text_QTE.Text = "0";
			DataGrid_BODY.Rows.Clear();
			Text_ETAT.Text = "EN COURS";
			Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
			((Control)Text_CODE_FIND).Focus();
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
		//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected Obj, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
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
					val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete   from     TABLE_FACTURE_DETAILS      WHERE    ID_FACTURE =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_FACTURE"].Value), "'         "));
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
				Text_ID_FACTURE.Text = DT.Rows[position2]["ID_FACTURE"].ToString();
				DateTimePicker_DATE.Text = DT.Rows[position2]["DATES"].ToString();
				Text_UTILISATEUR.Text = DT.Rows[position2]["UTILISATEUR"].ToString();
				Button_CLIENT._ID_Button = DT.Rows[position2]["ID_CLIENT"].ToString();
				Button_CLIENT._CODE_Button = DT.Rows[position2]["CODE_CLIENT"].ToString();
				((ButtonBase)Button_CLIENT).Text = DT.Rows[position2]["CLIENT"].ToString();
				Label_TOTAL_TVA_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position2]["TOTAL_TVA_DOC"].ToString())));
				Label_TOTAL_TTC_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position2]["TOTAL_TTC_DOC"].ToString())));
				Label_TOTAL_HT_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position2]["TOTAL_HT_DOC"].ToString())));
				Label_TOTAL_REMISE_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position2]["TOTAL_REMISE_DOC"].ToString())));
				Text_NOTES.Text = DT.Rows[position2]["NOTES"].ToString();
				Text_ETAT.Text = DT.Rows[position2]["ETAT"].ToString();
				MySqlCommand val3 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val3.CommandText = "select     *      from    TABLE_FACTURE_DETAILS      WHERE     ID_FACTURE  = '" + Text_ID_FACTURE.Text + "' ";
				val3.Connection = Module1.cn_SQL;
				MySqlDataReader val4 = val3.ExecuteReader();
				DataGrid_BODY.DataSource = null;
				DataGrid_BODY.Rows.Clear();
				if (val4.HasRows)
				{
					while (val4.Read())
					{
						DataGrid_BODY.Rows.Add(new object[11]
						{
							val4["ID_ARTICLE"].ToString(),
							val4["Code"].ToString(),
							val4["Article"].ToString(),
							Module1.FLOUSS(Conversions.ToDecimal(val4["PU_TTC"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["TAUX_TVA"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["PU_HT"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["Qté"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["TOTAL_TTC"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["TOTAL_TVA"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["TOTAL_HT"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["TAUX_REMISE"].ToString()))
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
			Text_ID_FACTURE.Text = DT.Rows[position3]["ID_FACTURE"].ToString();
			DateTimePicker_DATE.Text = DT.Rows[position3]["DATES"].ToString();
			Text_UTILISATEUR.Text = DT.Rows[position3]["UTILISATEUR"].ToString();
			Button_CLIENT._ID_Button = DT.Rows[position3]["ID_CLIENT"].ToString();
			Button_CLIENT._CODE_Button = DT.Rows[position3]["CODE_CLIENT"].ToString();
			((ButtonBase)Button_CLIENT).Text = DT.Rows[position3]["CLIENT"].ToString();
			Label_TOTAL_TVA_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position3]["TOTAL_TVA_DOC"].ToString())));
			Label_TOTAL_TTC_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position3]["TOTAL_TTC_DOC"].ToString())));
			Label_TOTAL_HT_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position3]["TOTAL_HT_DOC"].ToString())));
			Label_TOTAL_REMISE_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position3]["TOTAL_REMISE_DOC"].ToString())));
			Text_NOTES.Text = DT.Rows[position3]["NOTES"].ToString();
			Text_ETAT.Text = DT.Rows[position3]["ETAT"].ToString();
			MySqlCommand val5 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val5.CommandText = "select     *      from    TABLE_FACTURE_DETAILS      WHERE     ID_FACTURE  = '" + Text_ID_FACTURE.Text + "' ";
			val5.Connection = Module1.cn_SQL;
			MySqlDataReader val6 = val5.ExecuteReader();
			DataGrid_BODY.DataSource = null;
			DataGrid_BODY.Rows.Clear();
			if (val6.HasRows)
			{
				while (val6.Read())
				{
					DataGrid_BODY.Rows.Add(new object[11]
					{
						val6["ID_ARTICLE"].ToString(),
						val6["Code"].ToString(),
						val6["Article"].ToString(),
						Module1.FLOUSS(Conversions.ToDecimal(val6["PU_TTC"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["TAUX_TVA"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["PU_HT"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["Qté"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["TOTAL_TTC"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["TOTAL_TVA"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["TOTAL_HT"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["TAUX_REMISE"].ToString()))
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

	private void Text_CODE_FIND_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
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

	private void Button16_Click(object sender, EventArgs e)
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

	private void Button_FIND_Click(object sender, EventArgs e)
	{
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Text_CODE_FIND.Text.Trim(), "", TextCompare: false) == 0)
			{
				return;
			}
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = ProductBarcodeDialog.Resolve(this, Text_CODE_FIND.Text);
                if (dataTable == null) return;
			if (dataTable.Rows.Count != 0)
			{
				Text_ID_ARTICLE.Text = dataTable.Rows[0]["ID_ARTICLE"].ToString();
				Text_CODE.Text = dataTable.Rows[0]["Code"].ToString();
				Text_ARTICLE.Text = dataTable.Rows[0]["Article"].ToString();
				if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
				{
					Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[0]["Prix_V_1"].ToString())));
					Text_TAUX_TVA.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[0]["TAUX_TVA"].ToString())));
					Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
				}
				else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
				{
					Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[0]["Prix_V_1"].ToString())));
					Text_TAUX_TVA.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[0]["TAUX_TVA"].ToString())));
					Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_HT.Text) * (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
				}
				Text_QTE.Text = "";
				((Control)Text_QTE).Focus();
			}
			else
			{
				MessageBox.Show("Article inconnu", "Erreur", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				Text_ID_ARTICLE.Text = "";
				Text_CODE.Text = "";
				Text_ARTICLE.Text = "";
				Text_PU_TTC.Text = "";
				Text_TAUX_TVA.Text = "";
				Text_PU_HT.Text = "";
				Text_QTE.Text = "";
				Text_CODE_FIND.Text = "";
				Text_ARTICLE_FIND.Text = "";
				((Control)Text_CODE_FIND).Focus();
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

	private void TextBox_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
	}

	private void TextBox_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.White }, null, null);
	}

	private void Button_FIND_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE_FIND).Focus();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(Text_PU_TTC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Prix_V_TTC- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_TAUX_TVA.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TAUX_TVA- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PU_HT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Prix_V_HT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Conversion.Val(Text_QTE.Text) <= 0.0)
				{
					MessageBox.Show("Veuillez remplir le champ -Quantité- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
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
					if (Operators.CompareString(DataGrid_BODY.Rows[num2].Cells["Code"].Value.ToString(), Text_CODE.Text, TextCompare: false) == 0)
					{
						MessageBox.Show("Cette Article est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					num2++;
				}
				string text = Text_ID_ARTICLE.Text;
				string text2 = Text_CODE.Text;
				string text3 = Text_ARTICLE.Text;
				decimal num5 = Module1.FLOUSS(Conversions.ToDecimal(Text_PU_TTC.Text));
				decimal num6 = Module1.FLOUSS(Conversions.ToDecimal(Text_TAUX_TVA.Text));
				decimal num7 = Module1.FLOUSS(Conversions.ToDecimal(Text_PU_HT.Text));
				decimal num8 = Module1.FLOUSS(Conversions.ToDecimal(Text_QTE.Text));
				decimal num9 = Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) * Convert.ToDouble(num8)));
				decimal num10 = Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0) * Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0 * Convert.ToDouble(num8)));
				decimal num11 = Module1.FLOUSS(decimal.Subtract(num9, num10));
				decimal num12 = 0m;
				if (!Versioned.IsNumeric(num5))
				{
					MessageBox.Show("Vérifier le champ -PU_TTC- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!Versioned.IsNumeric(num6))
				{
					MessageBox.Show("Vérifier le champ -TAUX_TVA- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!Versioned.IsNumeric(num7))
				{
					MessageBox.Show("Vérifier le champ -PU_HT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!Versioned.IsNumeric(Text_QTE.Text))
				{
					MessageBox.Show("Vérifier le champ -QUANTITE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				DataGrid_BODY.Rows.Add(new object[11]
				{
					text, text2, text3, num5, num6, num7, num8, num9, num10, num11,
					num12
				});
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				DataGrid_BODY_CellValidated(null, null);
				Text_ID_ARTICLE.Text = "";
				Text_CODE.Text = "";
				Text_ARTICLE.Text = "";
				Text_PU_TTC.Text = "";
				Text_TAUX_TVA.Text = "";
				Text_PU_HT.Text = "";
				Text_QTE.Text = "0";
				Text_CODE_FIND.Text = "";
				Text_ARTICLE_FIND.Text = "";
				((Control)Text_CODE_FIND).Focus();
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
		}
	}

	private void Button_CALC_DOC_Click(object sender, EventArgs e)
	{
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		try
		{
			decimal num = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TTC"].Value)) ? Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TTC"].Value)) : 0m);
			Label_TOTAL_TTC_DOC.Text = Conversions.ToString(Module1.FLOUSS(num));
			decimal num2 = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TVA"].Value)) ? Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TVA"].Value)) : 0m);
			Label_TOTAL_TVA_DOC.Text = Conversions.ToString(Module1.FLOUSS(num2));
			decimal num3 = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_HT"].Value)) ? Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_HT"].Value)) : 0m);
			Label_TOTAL_HT_DOC.Text = Conversions.ToString(Module1.FLOUSS(num3));
			decimal num4 = 0m;
			if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
			{
				num4 = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["PU_TTC"].Value)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["Qté"].Value)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TTC"].Value))) ? decimal.Subtract(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["PU_TTC"].Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["Qté"].Value))), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_TTC"].Value))) : 0m);
			}
			else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
			{
				num4 = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["PU_HT"].Value)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["Qté"].Value)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_HT"].Value))) ? decimal.Subtract(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["PU_HT"].Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["Qté"].Value))), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["TOTAL_HT"].Value))) : 0m);
			}
			Label_TOTAL_REMISE_DOC.Text = Conversions.ToString(Module1.FLOUSS(num4));
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

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void DataGrid_BODY_CellValidated(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
			{
				DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_HT"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.DivideObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_TTC"].Value, Operators.AddObject(1, Operators.DivideObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_TVA"].Value, 100)))));
			}
			else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
			{
				DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_TTC"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.MultiplyObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_HT"].Value, Operators.AddObject(1, Operators.DivideObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_TVA"].Value, 100)))));
			}
			DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TTC"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.MultiplyObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_TTC"].Value, DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["Qté"].Value)));
			DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TVA"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["PU_TTC"].Value, Operators.AddObject(1, Operators.DivideObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_TVA"].Value, 100))), DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_TVA"].Value), 100), DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["Qté"].Value)));
			DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_HT"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.SubtractObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TTC"].Value, DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TVA"].Value)));
			if (Operators.ConditionalCompareObjectGreater(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_REMISE"].Value, 0, TextCompare: false))
			{
				DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TTC"].Value = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TTC"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TTC"].Value), Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_REMISE"].Value)), 100m)));
				DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TVA"].Value = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TVA"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_TVA"].Value), Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_REMISE"].Value)), 100m)));
				DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_HT"].Value = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_HT"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TOTAL_HT"].Value), Conversions.ToDecimal(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["TAUX_REMISE"].Value)), 100m)));
			}
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		if ((DataGrid_BODY.CurrentCell.ColumnIndex == 3) | (DataGrid_BODY.CurrentCell.ColumnIndex == 4) | (DataGrid_BODY.CurrentCell.ColumnIndex == 5) | (DataGrid_BODY.CurrentCell.ColumnIndex == 6))
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

	private void Button_CLIENT_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
		((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
		((Control)Text_CODE_FIND).Focus();
	}

	private void Panel_INFO_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Text_PU_TTC_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PU_TTC_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_PU_TTC_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			((Control)Text_QTE).Focus();
		}
	}

	private void Text_TAUX_TVA_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_TAUX_TVA_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_TAUX_TVA_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			((Control)Text_QTE).Focus();
		}
	}

	private void Text_PU_HT_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PU_HT_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_PU_HT_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			((Control)Text_QTE).Focus();
		}
	}

	private void Text_PU_TTC_LostFocus(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", TextCompare: false))
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val("0"))) }, null, null);
			Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
		}
		else
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))))) }, null, null);
			Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
		}
	}

	private void Text_PU_HT_LostFocus(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", TextCompare: false))
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val("0"))) }, null, null);
			Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_HT.Text) * (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
		}
		else
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))))) }, null, null);
			Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_HT.Text) * (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
		}
	}

	private void Text_TAUX_TVA_LostFocus(object sender, EventArgs e)
	{
		if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", TextCompare: false))
			{
				NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val("0"))) }, null, null);
				Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
			}
			else
			{
				NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))))) }, null, null);
				Text_PU_HT.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_TTC.Text) / (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
			}
		}
		else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", TextCompare: false))
			{
				NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val("0"))) }, null, null);
				Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_HT.Text) * (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
			}
			else
			{
				NewLateBinding.LateSet(sender, null, "Text", new object[1] { Module1.FLOUSS(new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))))) }, null, null);
				Text_PU_TTC.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PU_HT.Text) * (1.0 + Conversions.ToDouble(Text_TAUX_TVA.Text) / 100.0))));
			}
		}
	}

	private void Text_CODE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_CODE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			Button_FIND.PerformClick();
		}
	}

	private void Button_VALIDER_Click(object sender, EventArgs e)
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
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
			if ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Voulez-vous vraiment Valider la FACTURE N° ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_FACTURE"].Value)), "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
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
					val.CommandText = "UPDATE    TABLE_FACTURE_ENTETE     SET  ETAT = 'VALIDER'        WHERE  ID_FACTURE = '" + Text_ID_FACTURE.Text + "'           ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_FACTURE_DETAILS     SET  ETAT = 'VALIDER'        WHERE  ID_FACTURE = '" + Text_ID_FACTURE.Text + "'           ";
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
					StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
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
			StackFrame frame2 = stackTrace2.GetFrame(checked(stackTrace2.FrameCount - 1));
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		decimal num = 0m;
		decimal num2 = 0m;
		decimal num3 = 0m;
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		MySqlCommand val = new MySqlCommand("select sum(TOTAL_HT_DOC) as n     from      TABLE_" + Label_TABLE.Text + "     ", Module1.cn_SQL);
		num = ((val.ExecuteScalar() != DBNull.Value) ? Conversions.ToDecimal(val.ExecuteScalar()) : 0m);
		MySqlCommand val2 = new MySqlCommand("select sum(TOTAL_TVA_DOC) as n     from      TABLE_" + Label_TABLE.Text + "  ", Module1.cn_SQL);
		num2 = ((val2.ExecuteScalar() != DBNull.Value) ? Conversions.ToDecimal(val2.ExecuteScalar()) : 0m);
		MySqlCommand val3 = new MySqlCommand("select sum(TOTAL_TTC_DOC) as n     from      TABLE_" + Label_TABLE.Text + "  ", Module1.cn_SQL);
		num3 = ((val3.ExecuteScalar() != DBNull.Value) ? Conversions.ToDecimal(val3.ExecuteScalar()) : 0m);
		Module1.cn_SQL.Close();
		Label_TOTAL_HT_BD.Text = Conversions.ToString(Module1.FLOUSS(num));
		Label_TOTAL_TVA_BD.Text = Conversions.ToString(Module1.FLOUSS(num2));
		Label_TOTAL_TTC_BD.Text = Conversions.ToString(Module1.FLOUSS(num3));
		Button_CALC_ENREGISTRER_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView3_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		if (DataGridView3.Rows.Count == 0)
		{
			return;
		}
		if (RadioButton_DEVIS.Checked)
		{
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select     *      from    TABLE_DEVIS_DETAILS      WHERE     ID_DEVIS  = '", DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[2].Value), "' "));
			val.Connection = Module1.cn_SQL;
			MySqlDataReader val2 = val.ExecuteReader();
			DataGridView2.DataSource = null;
			DataGridView2.Rows.Clear();
			if (val2.HasRows)
			{
				while (val2.Read())
				{
					DataGridView2.Rows.Add(new object[11]
					{
						val2["ID_ARTICLE"].ToString(),
						val2["Code"].ToString(),
						val2["Article"].ToString(),
						val2["PU_TTC"].ToString(),
						val2["TAUX_TVA"].ToString(),
						val2["PU_HT"].ToString(),
						val2["Qté"].ToString(),
						val2["TOTAL_TTC"].ToString(),
						val2["TOTAL_TVA"].ToString(),
						val2["TOTAL_HT"].ToString(),
						val2["TAUX_REMISE"].ToString()
					});
				}
			}
			Module1.cn_SQL.Close();
			Button_CLIENT._ID_Button = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value);
			((ButtonBase)Button_CLIENT).Text = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[1].Value);
		}
		if (RadioButton_BL.Checked)
		{
			MySqlCommand val3 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val3.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select     *      from    TABLE_BL_DETAILS      WHERE     ID_BL  = '", DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[2].Value), "' "));
			val3.Connection = Module1.cn_SQL;
			MySqlDataReader val4 = val3.ExecuteReader();
			DataGridView2.DataSource = null;
			DataGridView2.Rows.Clear();
			if (val4.HasRows)
			{
				while (val4.Read())
				{
					DataGridView2.Rows.Add(new object[11]
					{
						val4["ID_ARTICLE"].ToString(),
						val4["Code"].ToString(),
						val4["Article"].ToString(),
						val4["PU_TTC"].ToString(),
						val4["TAUX_TVA"].ToString(),
						val4["PU_HT"].ToString(),
						val4["Qté"].ToString(),
						val4["TOTAL_TTC"].ToString(),
						val4["TOTAL_TVA"].ToString(),
						val4["TOTAL_HT"].ToString(),
						val4["TAUX_REMISE"].ToString()
					});
				}
			}
			Module1.cn_SQL.Close();
			Button_CLIENT._ID_Button = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value);
			((ButtonBase)Button_CLIENT).Text = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[1].Value);
		}
		if (!RadioButton_TICKET.Checked)
		{
			return;
		}
		MySqlCommand val5 = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		val5.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select     *      from    TABLE_VENTES_JOURNAL      WHERE     Ticket  = '", DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[2].Value), "' "));
		val5.Connection = Module1.cn_SQL;
		MySqlDataReader val6 = val5.ExecuteReader();
		DataGridView2.DataSource = null;
		DataGridView2.Rows.Clear();
		if (val6.HasRows)
		{
			while (val6.Read())
			{
				if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
				{
					DataGridView2.Rows.Add(new object[11]
					{
						val6["ID_ARTICLE"].ToString(),
						val6["Code"].ToString(),
						val6["Article"].ToString(),
						val6["Prix_V"].ToString(),
						val6["TAUX_TVA"].ToString(),
						"",
						val6["Qté"].ToString(),
						val6["TOTAL_NET"].ToString(),
						"",
						"",
						val6["Remise"].ToString()
					});
				}
				else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
				{
					DataGridView2.Rows.Add(new object[11]
					{
						val6["ID_ARTICLE"].ToString(),
						val6["Code"].ToString(),
						val6["Article"].ToString(),
						"",
						val6["TAUX_TVA"].ToString(),
						val6["Prix_V"].ToString(),
						val6["Qté"].ToString(),
						val6["TOTAL_NET"].ToString(),
						"",
						"",
						val6["Remise"].ToString()
					});
				}
			}
		}
		Module1.cn_SQL.Close();
		checked
		{
			int num = DataGridView2.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(_HTTTC, "TTC", TextCompare: false) == 0)
				{
					DataGridView2.Rows[num2].Cells[5].Value = Conversions.ToDecimal(Operators.DivideObject(DataGridView2.Rows[num2].Cells[3].Value, Operators.AddObject(1, Operators.DivideObject(DataGridView2.Rows[num2].Cells[4].Value, 100))));
				}
				else if (Operators.CompareString(_HTTTC, "HT", TextCompare: false) == 0)
				{
					DataGridView2.Rows[num2].Cells[3].Value = Conversions.ToDecimal(Operators.MultiplyObject(DataGridView2.Rows[num2].Cells[5].Value, Operators.AddObject(1, Operators.DivideObject(DataGridView2.Rows[num2].Cells[4].Value, 100))));
				}
				DataGridView2.Rows[num2].Cells[7].Value = Conversions.ToDecimal(Operators.MultiplyObject(DataGridView2.Rows[num2].Cells[3].Value, DataGridView2.Rows[num2].Cells[6].Value));
				DataGridView2.Rows[num2].Cells[8].Value = Conversions.ToDecimal(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(DataGridView2.Rows[num2].Cells[3].Value, Operators.AddObject(1, Operators.DivideObject(DataGridView2.Rows[num2].Cells[4].Value, 100))), DataGridView2.Rows[num2].Cells[4].Value), 100), DataGridView2.Rows[num2].Cells[6].Value));
				DataGridView2.Rows[num2].Cells[9].Value = Conversions.ToDecimal(Operators.SubtractObject(DataGridView2.Rows[num2].Cells[7].Value, DataGridView2.Rows[num2].Cells[8].Value));
				num2++;
			}
			Button_CLIENT._ID_Button = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value);
			((ButtonBase)Button_CLIENT).Text = Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[1].Value);
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				int num = DataGridView2.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[0].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[1].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[2].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[3].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[4].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[5].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[6].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[7].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[8].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[9].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (Operators.CompareString(DataGridView2.Rows[num2].Cells[10].Value.ToString(), "", TextCompare: false) == 0)
					{
						MessageBox.Show("Veuillez remplir le champ -Vide- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					num2++;
				}
				int num5 = DataGrid_BODY.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					if (Operators.CompareString(DataGrid_BODY.Rows[num6].Cells["Code"].Value.ToString(), Text_CODE.Text, TextCompare: false) == 0)
					{
						MessageBox.Show("Cette Article est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					num6++;
				}
				int num8 = DataGridView2.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 <= num4)
					{
						string text = Conversions.ToString(DataGridView2.Rows[num9].Cells["ID_ARTICLEE"].Value);
						string text2 = Conversions.ToString(DataGridView2.Rows[num9].Cells["CODEE"].Value);
						string text3 = Conversions.ToString(DataGridView2.Rows[num9].Cells["ARTICLEE"].Value);
						decimal num11 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["PU_TTCC"].Value));
						decimal num12 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TAUX_TVAA"].Value));
						decimal num13 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["PU_HTT"].Value));
						decimal num14 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["QTEE"].Value));
						decimal num15 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TTCC"].Value));
						decimal num16 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TVAA"].Value));
						decimal num17 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_HTT"].Value));
						decimal num18 = Module1.FLOUSS(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TAUX_REMISEE"].Value));
						if (decimal.Compare(num18, 0m) > 0)
						{
							num15 = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TTCC"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TTCC"].Value), Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TAUX_REMISEE"].Value)), 100m)));
							num16 = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TVAA"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_TVAA"].Value), Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TAUX_REMISEE"].Value)), 100m)));
							num17 = Module1.FLOUSS(decimal.Subtract(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_HTT"].Value), decimal.Divide(decimal.Multiply(Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TOTAL_HTT"].Value), Conversions.ToDecimal(DataGridView2.Rows[num9].Cells["TAUX_REMISEE"].Value)), 100m)));
						}
						if (!Versioned.IsNumeric(num11))
						{
							MessageBox.Show("Vérifier le champ -PU_TTC- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							break;
						}
						if (!Versioned.IsNumeric(num12))
						{
							MessageBox.Show("Vérifier le champ -TAUX_TVA- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							break;
						}
						if (!Versioned.IsNumeric(num13))
						{
							MessageBox.Show("Vérifier le champ -PU_HT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							break;
						}
						if (!Versioned.IsNumeric(Text_QTE.Text))
						{
							MessageBox.Show("Vérifier le champ -QUANTITE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							break;
						}
						DataGrid_BODY.Rows.Add(new object[11]
						{
							text, text2, text3, num11, num12, num13, num14, num15, num16, num17,
							num18
						});
						Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
						DataGrid_BODY_CellValidated(null, null);
						DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Cells[0];
						DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Selected = true;
						num9++;
						continue;
					}
					break;
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

	private void Button_PRINT_80MM_Click(object sender, EventArgs e)
	{
	}

	private void Button_GO_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		string text = "";
		if (Operators.CompareString(Button_CLIENT._ID_Button, "", TextCompare: false) != 0)
		{
			text = "  AND          ID_CLIENT  =  '" + Button_CLIENT._ID_Button + "'  ";
		}
		if (RadioButton_DEVIS.Checked)
		{
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "select     ID_DEVIS,ID_CLIENT,CLIENT      from    TABLE_DEVIS_ENTETE       Where       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         " + text + "         order by ID desc ";
			val.Connection = Module1.cn_SQL;
			MySqlDataReader val2 = val.ExecuteReader();
			DataGridView3.Rows.Clear();
			if (val2.HasRows)
			{
				while (val2.Read())
				{
					DataGridView3.Rows.Add(new object[3]
					{
						val2["ID_CLIENT"].ToString(),
						val2["CLIENT"].ToString(),
						val2["ID_DEVIS"].ToString()
					});
				}
			}
			Module1.cn_SQL.Close();
		}
		if (RadioButton_BL.Checked)
		{
			MySqlCommand val3 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val3.CommandText = "select     ID_BL,ID_CLIENT,CLIENT      from    TABLE_BL_ENTETE       Where       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          " + text + "        order by ID desc ";
			val3.Connection = Module1.cn_SQL;
			MySqlDataReader val4 = val3.ExecuteReader();
			DataGridView3.Rows.Clear();
			if (val4.HasRows)
			{
				while (val4.Read())
				{
					DataGridView3.Rows.Add(new object[3]
					{
						val4["ID_CLIENT"].ToString(),
						val4["CLIENT"].ToString(),
						val4["ID_BL"].ToString()
					});
				}
			}
			Module1.cn_SQL.Close();
		}
		if (!RadioButton_TICKET.Checked)
		{
			return;
		}
		MySqlCommand val5 = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		val5.CommandText = "select     TICKET,ID_CLIENT,CLIENT      from    TABLE_VENTES_ENTETE   Where       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         " + text + "         order by ID desc ";
		val5.Connection = Module1.cn_SQL;
		MySqlDataReader val6 = val5.ExecuteReader();
		DataGridView3.Rows.Clear();
		if (val6.HasRows)
		{
			while (val6.Read())
			{
				DataGridView3.Rows.Add(new object[3]
				{
					val6["ID_CLIENT"].ToString(),
					val6["CLIENT"].ToString(),
					val6["TICKET"].ToString()
				});
			}
		}
		Module1.cn_SQL.Close();
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
				Button_PrintRapport_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_FACTURE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).Render("PDF");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*PDF files (*.pdf)|*.pdf";
				((FileDialog)val).FileName = "FACTURE_" + Text_ID_FACTURE.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_FACTURE).Close();
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
				Button_PrintRapport_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_FACTURE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).Render("EXCEL");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*EXCEL files (*.xls)|*.xls";
				((FileDialog)val).FileName = "FACTURE_" + Text_ID_FACTURE.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_FACTURE).Close();
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
				Button_PrintRapport_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_FACTURE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).Render("WORD");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*WORD files (*.doc)|*.doc";
				((FileDialog)val).FileName = "FACTURE_" + Text_ID_FACTURE.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_FACTURE).Close();
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
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		if (DataGridView1.Rows.Count == 0)
		{
			return;
		}
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
				string text = ImageToBase64(MyProject.Forms.Form_3_VENTE.PictureBox100.Image, ImageFormat.Jpeg);
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo", text, true));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType", "image/jpeg", true));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Text_ID_FACTURE.Text));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", "Le " + DateTimePicker_DATE.Text));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ETAT", Text_ETAT.Text));
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select    CLIENT,ICE,ADRESSE   from TABLE_CLIENTS     Where    ID_CLIENT = '" + Button_CLIENT._ID_Button + "'        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", dataTable.Rows[0]["CLIENT"].ToString()));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ICE", "ICE : " + dataTable.Rows[0]["ICE"].ToString()));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ADRESSE", dataTable.Rows[0]["ADRESSE"].ToString()));
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
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select    Description   from TABLE_ARTICLES     Where    ID_ARTICLE = '" + DataGrid_BODY.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["Description"].ToString().Length > 0)
					{
						DataGrid_BODY.Rows[num2].Cells["ARTICLE"].Value = DataGrid_BODY.Rows[num2].Cells["ARTICLE"].Value.ToString() + ".\r\n" + dataTable2.Rows[0]["Description"].ToString().ToLower();
					}
					num2++;
				}
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_HT_DOC", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_HT_DOC.Text))) + " DH"));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_TVA_DOC", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TVA_DOC.Text))) + " DH"));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_TTC_DOC", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TTC_DOC.Text))) + " DH"));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_REMISE_DOC", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_REMISE_DOC.Text))) + " DH"));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("LETTRE", Module1.ConvNumberLetter(Convert.ToDouble(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_TTC_DOC.Text))), 0)));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NOTES", Text_NOTES.Text));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("PIED_DOC", Text_pied_doc.Text));
				((Report)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ID_DOCUMENT", Text_ID_FACTURE.Text));
				DataTable dataTable3 = new DataTable();
				int num5 = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable3.Columns.Add(DataGrid_BODY.Columns[num6].Name.ToString());
					dataTable3.Columns[DataGrid_BODY.Columns[num6].Name.ToString()].Caption = DataGrid_BODY.Columns[num6].HeaderText.ToString();
					num6++;
				}
				int num8 = DataGrid_BODY.Rows.Count - 1;
				y = 0;
				while (true)
				{
					int num9 = y;
					int num4 = num8;
					if (num9 > num4)
					{
						break;
					}
					dataTable3.Rows.Add();
					int num10 = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
					int num11 = 0;
					while (true)
					{
						int num12 = num11;
						num4 = num10;
						if (num12 > num4)
						{
							break;
						}
						dataTable3.Rows[y][num11] = DataGrid_BODY.Rows[y].Cells[num11].Value.ToString();
						num11++;
					}
					y++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable3);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_FACTURE.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_FACTURE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_FACTURE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_FACTURE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_FACTURE.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_FACTURE).Show();
				Module1._QUITTER_PATIENTER = true;
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
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		checked
		{
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
				decimal num = 0m;
				decimal num2 = 0m;
				int num3 = DataGridView1.Rows.Count - 1;
				int num4 = 0;
				while (true)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					num = Conversions.ToDecimal(Operators.AddObject(num, DataGridView1.Rows[num4].Cells["TOTAL_HT_DOC"].Value));
					num2 = Conversions.ToDecimal(Operators.AddObject(num2, DataGridView1.Rows[num4].Cells["TOTAL_HT_TTC"].Value));
					num4++;
				}
				Label4141.Text = "TOTAL_HT_DOC : " + Strings.FormatNumber(num) + " DH  -  TOTAL_HT_TTC : " + Strings.FormatNumber(num2) + " DH";
				if (Operators.CompareString(Text_FIND.Texts, "", TextCompare: false) == 0)
				{
					((Control)Label4141).Visible = false;
				}
				else
				{
					((Control)Label4141).BringToFront();
					((Control)Label4141).Visible = true;
				}
				if (Operators.CompareString(Combo_FIND.Text, "DATES", TextCompare: false) == 0)
				{
					((Control)Label4141).BringToFront();
					((Control)Label4141).Visible = true;
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
