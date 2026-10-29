using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_2_ARTICLES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Text_STOCK")]
	private TextBox _Text_STOCK;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Text_ALERT")]
	private TextBox _Text_ALERT;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Text_ARTICLE")]
	private TextBox _Text_ARTICLE;

	[AccessedThroughProperty("Text_CODE")]
	private TextBox _Text_CODE;

	[AccessedThroughProperty("Text_PRIX_V")]
	private TextBox _Text_PRIX_V;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Text_PRIX_A")]
	private TextBox _Text_PRIX_A;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Button_GENERER")]
	private Button _Button_GENERER;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel10")]
	private Panel _Panel10;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("Label_VALEURSTOCK_MP")]
	private Label _Label_VALEURSTOCK_MP;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label_ARTICLES")]
	private Label _Label_ARTICLES;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Button_CALC")]
	private Button _Button_CALC;

	[AccessedThroughProperty("Combo_FAMILLE")]
	private ComboBox _Combo_FAMILLE;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Text_PRIX_MP")]
	private TextBox _Text_PRIX_MP;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("DataGrid_RECEPTIONS")]
	private DataGridView _DataGrid_RECEPTIONS;

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

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Text_PRIX_V_2")]
	private TextBox _Text_PRIX_V_2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Text_EMPLACEMENT")]
	private TextBox _Text_EMPLACEMENT;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Combo_TAUX_TVA")]
	private ComboBox _Combo_TAUX_TVA;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_DESCRIPTION")]
	private TextBox _Text_DESCRIPTION;

	[AccessedThroughProperty("Combo_COULEURS")]
	private ComboBox _Combo_COULEURS;

	[AccessedThroughProperty("Text_SOUS_FAMILLE")]
	private TextBox _Text_SOUS_FAMILLE;

	[AccessedThroughProperty("Combo_TAILLES")]
	private ComboBox _Combo_TAILLES;

	[AccessedThroughProperty("Panel_Picture_IMAGE_TOOLS")]
	private Panel _Panel_Picture_IMAGE_TOOLS;

	[AccessedThroughProperty("Button26")]
	private Button _Button26;

	[AccessedThroughProperty("Button27")]
	private Button _Button27;

	[AccessedThroughProperty("Button29")]
	private Button _Button29;

	[AccessedThroughProperty("Button30")]
	private Button _Button30;

	[AccessedThroughProperty("Button31")]
	private Button _Button31;

	[AccessedThroughProperty("Button35")]
	private Button _Button35;

	[AccessedThroughProperty("Picture_IMAGE")]
	private PictureBox _Picture_IMAGE;

	[AccessedThroughProperty("Text_LIEN_PICTURE")]
	private TextBox _Text_LIEN_PICTURE;

	[AccessedThroughProperty("Combo_UNITE")]
	private ComboBox _Combo_UNITE;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Combo_MODE_STOCK")]
	private ComboBox _Combo_MODE_STOCK;

	[AccessedThroughProperty("Text_STOCK_INITIAL")]
	private TextBox _Text_STOCK_INITIAL;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Text_DATE_INVENTAIRE")]
	private TextBox _Text_DATE_INVENTAIRE;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Text_DATE_CREATION")]
	private TextBox _Text_DATE_CREATION;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("DataGrid_SORTIES")]
	private DataGridView _DataGrid_SORTIES;

	[AccessedThroughProperty("DataGrid_VENTES")]
	private DataGridView _DataGrid_VENTES;

	[AccessedThroughProperty("Button_SORTIES")]
	private Button _Button_SORTIES;

	[AccessedThroughProperty("Button_VENTES")]
	private Button _Button_VENTES;

	[AccessedThroughProperty("Button_RECEPTIONS")]
	private Button _Button_RECEPTIONS;

	[AccessedThroughProperty("Label30303")]
	private Label _Label30303;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Text_REFERENCE")]
	private TextBox _Text_REFERENCE;

	[AccessedThroughProperty("Combo_FOURNISSEUR")]
	private ComboBox _Combo_FOURNISSEUR;

	[AccessedThroughProperty("Button24")]
	private Button _Button24;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("Combo_PRINTER_DUPLICATA")]
	private ComboBox _Combo_PRINTER_DUPLICATA;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Combo_PRINTER")]
	private ComboBox _Combo_PRINTER;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button_ETAT_STOCK")]
	private Button _Button_ETAT_STOCK;

	[AccessedThroughProperty("Button_FERMER")]
	private Button _Button_FERMER;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button _Button_FONCTIONS;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel0")]
	private Panel _Panel0;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Label_VALEURSTOCK_A")]
	private Label _Label_VALEURSTOCK_A;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("Button_MOUVEMENTS")]
	private Button _Button_MOUVEMENTS;

	[AccessedThroughProperty("DataGrid_MOUVEMENTS")]
	private DataGridView _DataGrid_MOUVEMENTS;

	[AccessedThroughProperty("Panel9")]
	private Panel _Panel9;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("Label_VALEURSTOCK_V")]
	private Label _Label_VALEURSTOCK_V;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Label_VALEURSTOCK_A_NON")]
	private Label _Label_VALEURSTOCK_A_NON;

	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[AccessedThroughProperty("Label_VALEURSTOCK_MP_NON")]
	private Label _Label_VALEURSTOCK_MP_NON;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label_VALEURSTOCK_V_NON")]
	private Label _Label_VALEURSTOCK_V_NON;

	[AccessedThroughProperty("Label52")]
	private Label _Label52;

	[AccessedThroughProperty("Button_BALANCE")]
	private Button _Button_BALANCE;

	[AccessedThroughProperty("Text_BALANCE")]
	private TextBox _Text_BALANCE;

	[AccessedThroughProperty("Button_FAMILLES")]
	private Button _Button_FAMILLES;

	[AccessedThroughProperty("Button_RAPPORT")]
	private Button _Button_RAPPORT;

	[AccessedThroughProperty("Button85454")]
	private Button _Button85454;

	[AccessedThroughProperty("Button73434")]
	private Button _Button73434;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("Panel_Picture_IMAGE")]
	private Panel _Panel_Picture_IMAGE;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("PictureBox30")]
	private PictureBox _PictureBox30;

	[AccessedThroughProperty("PictureBox31")]
	private PictureBox _PictureBox31;

	[AccessedThroughProperty("PictureBox32")]
	private PictureBox _PictureBox32;

	[AccessedThroughProperty("PictureBox33")]
	private PictureBox _PictureBox33;

	[AccessedThroughProperty("PictureBox26")]
	private PictureBox _PictureBox26;

	[AccessedThroughProperty("PictureBox27")]
	private PictureBox _PictureBox27;

	[AccessedThroughProperty("PictureBox28")]
	private PictureBox _PictureBox28;

	[AccessedThroughProperty("PictureBox29")]
	private PictureBox _PictureBox29;

	[AccessedThroughProperty("PictureBox22")]
	private PictureBox _PictureBox22;

	[AccessedThroughProperty("PictureBox23")]
	private PictureBox _PictureBox23;

	[AccessedThroughProperty("PictureBox24")]
	private PictureBox _PictureBox24;

	[AccessedThroughProperty("PictureBox25")]
	private PictureBox _PictureBox25;

	[AccessedThroughProperty("PictureBox34")]
	private PictureBox _PictureBox34;

	[AccessedThroughProperty("PictureBox35")]
	private PictureBox _PictureBox35;

	[AccessedThroughProperty("PictureBox36")]
	private PictureBox _PictureBox36;

	[AccessedThroughProperty("PictureBox37")]
	private PictureBox _PictureBox37;

	[AccessedThroughProperty("Panel13243")]
	private Panel _Panel13243;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("DataGridView_TRIAGE")]
	private DataGridView _DataGridView_TRIAGE;

	[AccessedThroughProperty("DataGridViewButtonColumn1")]
	private DataGridViewButtonColumn _DataGridViewButtonColumn1;

	[AccessedThroughProperty("Button10767")]
	private Button _Button10767;

	[AccessedThroughProperty("Label61")]
	private Label _Label61;

	[AccessedThroughProperty("Label60")]
	private Label _Label60;

	[AccessedThroughProperty("Label59")]
	private Label _Label59;

	[AccessedThroughProperty("Label62")]
	private Label _Label62;

	[AccessedThroughProperty("Label_PROMOTIONS")]
	private Label _Label_PROMOTIONS;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Text_PROMOTION")]
	private TextBox _Text_PROMOTION;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn15")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;

	[AccessedThroughProperty("DataGridViewTextBoxColumn16")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;

	[AccessedThroughProperty("DataGridViewTextBoxColumn17")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn17;

	[AccessedThroughProperty("DataGridViewTextBoxColumn18")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn18;

	[AccessedThroughProperty("DataGridViewTextBoxColumn19")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn19;

	[AccessedThroughProperty("DataGridViewTextBoxColumn20")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn20;

	[AccessedThroughProperty("unité")]
	private DataGridViewTextBoxColumn _unité;

	[AccessedThroughProperty("departement")]
	private DataGridViewTextBoxColumn _departement;

	[AccessedThroughProperty("Label69")]
	private Label _Label69;

	[AccessedThroughProperty("Button_PROMOTION")]
	private Button _Button_PROMOTION;

	[AccessedThroughProperty("Panel1233")]
	private Panel _Panel1233;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Label63")]
	private Label _Label63;

	[AccessedThroughProperty("TextBox154545")]
	private TextBox _TextBox154545;

	[AccessedThroughProperty("Label68")]
	private Label _Label68;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Label64")]
	private Label _Label64;

	[AccessedThroughProperty("Label65")]
	private Label _Label65;

	[AccessedThroughProperty("Label66")]
	private Label _Label66;

	[AccessedThroughProperty("Label67")]
	private Label _Label67;

	[AccessedThroughProperty("Button_M_SHIFTS")]
	private Button _Button_M_SHIFTS;

	[AccessedThroughProperty("Text_ID_ARTICLE")]
	private TextBox _Text_ID_ARTICLE;

	[AccessedThroughProperty("Label70")]
	private Label _Label70;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("Column4")]
	private DataGridViewTextBoxColumn _Column4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	[AccessedThroughProperty("Client")]
	private DataGridViewTextBoxColumn _Client;

	[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

	[AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

	[AccessedThroughProperty("DataGridViewTextBoxColumn12")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;

	[AccessedThroughProperty("DataGridViewTextBoxColumn14")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("ID_BR")]
	private DataGridViewTextBoxColumn _ID_BR;

	[AccessedThroughProperty("Column5")]
	private DataGridViewTextBoxColumn _Column5;

	[AccessedThroughProperty("Articles")]
	private DataGridViewTextBoxColumn _Articles;

	[AccessedThroughProperty("Prix_AA")]
	private DataGridViewTextBoxColumn _Prix_AA;

	[AccessedThroughProperty("Qtéé")]
	private DataGridViewTextBoxColumn _Qtéé;

	[AccessedThroughProperty("Fournisseur")]
	private DataGridViewTextBoxColumn _Fournisseur;

	[AccessedThroughProperty("Column1")]
	private DataGridViewImageColumn _Column1;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("PRIX_A")]
	private DataGridViewTextBoxColumn _PRIX_A;

	[AccessedThroughProperty("PRIX_V_1")]
	private DataGridViewTextBoxColumn _PRIX_V_1;

	[AccessedThroughProperty("STOCK")]
	private DataGridViewTextBoxColumn _STOCK;

	[AccessedThroughProperty("Alert")]
	private DataGridViewTextBoxColumn _Alert;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Combo_FENETRE_PESEE")]
	private ComboBox _Combo_FENETRE_PESEE;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel119898")]
	private Panel _Panel119898;

	[AccessedThroughProperty("DataGridView_FILTRAGE")]
	private DataGridView _DataGridView_FILTRAGE;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button_RJ38787")]
	private Button_RJ _Button_RJ38787;

	[AccessedThroughProperty("Button_RJ16576")]
	private Button_RJ _Button_RJ16576;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("TextBox14343")]
	private TextBox _TextBox14343;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Label71")]
	private Label _Label71;

	[AccessedThroughProperty("Label72")]
	private Label _Label72;

	[AccessedThroughProperty("Label73")]
	private Label _Label73;

	[AccessedThroughProperty("Combo_BALANCE")]
	private ComboBox _Combo_BALANCE;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

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

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

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

	[AccessedThroughProperty("Button_INVENTAIRES")]
	private Button _Button_INVENTAIRES;

	[AccessedThroughProperty("DataGrid_INVENTAIRES")]
	private DataGridView _DataGrid_INVENTAIRES;

	[AccessedThroughProperty("DataGridViewTextBoxColumn21")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn21;

	[AccessedThroughProperty("DataGridViewTextBoxColumn22")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn22;

	[AccessedThroughProperty("DataGridViewTextBoxColumn23")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn23;

	[AccessedThroughProperty("DataGridViewTextBoxColumn24")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn24;

	[AccessedThroughProperty("DataGridViewTextBoxColumn25")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn25;

	[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

	[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

	[AccessedThroughProperty("Column3")]
	private DataGridViewTextBoxColumn _Column3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

	[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

	[AccessedThroughProperty("DataGridViewButtonColumn2")]
	private DataGridViewButtonColumn _DataGridViewButtonColumn2;

	[AccessedThroughProperty("Panel_COLUMNS")]
	private Panel _Panel_COLUMNS;

	[AccessedThroughProperty("Button94545")]
	private Button _Button94545;

	[AccessedThroughProperty("Button187878")]
	private Button _Button187878;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("ListBox_COLUMNS")]
	private ListBox _ListBox_COLUMNS;

	[AccessedThroughProperty("PictureBox_ROBOT")]
	private PictureBox _PictureBox_ROBOT;

	[AccessedThroughProperty("Panel_COULEUR")]
	private Panel _Panel_COULEUR;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Picture_COLOR_23")]
	private PictureBox _Picture_COLOR_23;

	[AccessedThroughProperty("Picture_COLOR_22")]
	private PictureBox _Picture_COLOR_22;

	[AccessedThroughProperty("Picture_COLOR_21")]
	private PictureBox _Picture_COLOR_21;

	[AccessedThroughProperty("Picture_COLOR_20")]
	private PictureBox _Picture_COLOR_20;

	[AccessedThroughProperty("Picture_COLOR_19")]
	private PictureBox _Picture_COLOR_19;

	[AccessedThroughProperty("Picture_COLOR_18")]
	private PictureBox _Picture_COLOR_18;

	[AccessedThroughProperty("Picture_COLOR_16")]
	private PictureBox _Picture_COLOR_16;

	[AccessedThroughProperty("Picture_COLOR_15")]
	private PictureBox _Picture_COLOR_15;

	[AccessedThroughProperty("Picture_COLOR_14")]
	private PictureBox _Picture_COLOR_14;

	[AccessedThroughProperty("Picture_COLOR_13")]
	private PictureBox _Picture_COLOR_13;

	[AccessedThroughProperty("Picture_COLOR_12")]
	private PictureBox _Picture_COLOR_12;

	[AccessedThroughProperty("Picture_COLOR_11")]
	private PictureBox _Picture_COLOR_11;

	[AccessedThroughProperty("Picture_COLOR_6")]
	private PictureBox _Picture_COLOR_6;

	[AccessedThroughProperty("Picture_COLOR_10")]
	private PictureBox _Picture_COLOR_10;

	[AccessedThroughProperty("Picture_COLOR_5")]
	private PictureBox _Picture_COLOR_5;

	[AccessedThroughProperty("Picture_COLOR_1")]
	private PictureBox _Picture_COLOR_1;

	[AccessedThroughProperty("Picture_COLOR_8")]
	private PictureBox _Picture_COLOR_8;

	[AccessedThroughProperty("Picture_COLOR_9")]
	private PictureBox _Picture_COLOR_9;

	[AccessedThroughProperty("Picture_COLOR_4")]
	private PictureBox _Picture_COLOR_4;

	[AccessedThroughProperty("Picture_COLOR_3")]
	private PictureBox _Picture_COLOR_3;

	[AccessedThroughProperty("Picture_COLOR_2")]
	private PictureBox _Picture_COLOR_2;

	[AccessedThroughProperty("TextBox_AJOUT_STOCK_MANUEL")]
	private TextBox _TextBox_AJOUT_STOCK_MANUEL;

	[AccessedThroughProperty("TextBox_MODIF_STOCK_MANUEL")]
	private TextBox _TextBox_MODIF_STOCK_MANUEL;

	[AccessedThroughProperty("TextBox_NBR_CODE_BALANCE")]
	private TextBox _TextBox_NBR_CODE_BALANCE;

	[AccessedThroughProperty("TextBox_NBR_CODE_ARTICLE")]
	private TextBox _TextBox_NBR_CODE_ARTICLE;

	[AccessedThroughProperty("Picture_GREEN")]
	private PictureBox _Picture_GREEN;

	[AccessedThroughProperty("Picture_BLUE")]
	private PictureBox _Picture_BLUE;

	[AccessedThroughProperty("Picture_RED")]
	private PictureBox _Picture_RED;

	[AccessedThroughProperty("Button_ETAT_LISTE_ARTICLES")]
	private Button _Button_ETAT_LISTE_ARTICLES;

	[AccessedThroughProperty("Panel_INFO_COLLECTION")]
	private Panel _Panel_INFO_COLLECTION;

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

	[AccessedThroughProperty("Button_MOINS")]
	private Button _Button_MOINS;

	[AccessedThroughProperty("Button_PLUS")]
	private Button _Button_PLUS;

	[AccessedThroughProperty("Label81")]
	private Label _Label81;

	[AccessedThroughProperty("Text_QTE_COLLECTION")]
	private TextBox _Text_QTE_COLLECTION;

	[AccessedThroughProperty("Button23233")]
	private Button _Button23233;

	[AccessedThroughProperty("Button23232")]
	private Button _Button23232;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label_TOTAL_QUANTITE_DOC")]
	private Label _Label_TOTAL_QUANTITE_DOC;

	[AccessedThroughProperty("Button_CALC_DOC")]
	private Button _Button_CALC_DOC;

	[AccessedThroughProperty("Label_NBR_ARTICLES_DOC")]
	private Label _Label_NBR_ARTICLES_DOC;

	[AccessedThroughProperty("Label75")]
	private Label _Label75;

	[AccessedThroughProperty("Label76")]
	private Label _Label76;

	[AccessedThroughProperty("Label79")]
	private Label _Label79;

	[AccessedThroughProperty("Label80")]
	private Label _Label80;

	[AccessedThroughProperty("Label53")]
	private Label _Label53;

	[AccessedThroughProperty("Label54")]
	private Label _Label54;

	[AccessedThroughProperty("Button_INSERER")]
	private Button _Button_INSERER;

	[AccessedThroughProperty("DataGridView_COULEURS")]
	private DataGridView _DataGridView_COULEURS;

	[AccessedThroughProperty("CODE_COULEUR")]
	private DataGridViewTextBoxColumn _CODE_COULEUR;

	[AccessedThroughProperty("COULEUR")]
	private DataGridViewTextBoxColumn _COULEUR;

	[AccessedThroughProperty("DataGridView_TAILLES")]
	private DataGridView _DataGridView_TAILLES;

	[AccessedThroughProperty("CODE_TAILLE")]
	private DataGridViewTextBoxColumn _CODE_TAILLE;

	[AccessedThroughProperty("TAILLE")]
	private DataGridViewTextBoxColumn _TAILLE;

	[AccessedThroughProperty("DataGrid_COLLECTION")]
	private DataGridView _DataGrid_COLLECTION;

	[AccessedThroughProperty("CODE_BARRE_LISTE")]
	private DataGridViewTextBoxColumn _CODE_BARRE_LISTE;

	[AccessedThroughProperty("ARTICLE_LISTE")]
	private DataGridViewTextBoxColumn _ARTICLE_LISTE;

	[AccessedThroughProperty("TAILLE_LISTE")]
	private DataGridViewTextBoxColumn _TAILLE_LISTE;

	[AccessedThroughProperty("COULEUR_LISTE")]
	private DataGridViewTextBoxColumn _COULEUR_LISTE;

	[AccessedThroughProperty("Qté_LISTE")]
	private DataGridViewTextBoxColumn _Qté_LISTE;

	[AccessedThroughProperty("sup")]
	private DataGridViewImageColumn _sup;

	[AccessedThroughProperty("Label55")]
	private Label _Label55;

	[AccessedThroughProperty("Label56")]
	private Label _Label56;

	[AccessedThroughProperty("Label57")]
	private Label _Label57;

	[AccessedThroughProperty("Label78")]
	private Label _Label78;

	[AccessedThroughProperty("Label_TOP_COLLECTION")]
	private Label _Label_TOP_COLLECTION;

	[AccessedThroughProperty("Label82")]
	private Label _Label82;

	[AccessedThroughProperty("Label83")]
	private Label _Label83;

	[AccessedThroughProperty("Button_CLOSE_COLLECTION")]
	private Button _Button_CLOSE_COLLECTION;

	[AccessedThroughProperty("Combo_FAMILLE_COLLECTION")]
	private ComboBox _Combo_FAMILLE_COLLECTION;

	[AccessedThroughProperty("Button_SAVE_COLLECTION")]
	private Button _Button_SAVE_COLLECTION;

	[AccessedThroughProperty("Text_ARTICLE_COLLECTION")]
	private TextBox _Text_ARTICLE_COLLECTION;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT212")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT212;

	[AccessedThroughProperty("Label84")]
	private Label _Label84;

	[AccessedThroughProperty("Label85")]
	private Label _Label85;

	[AccessedThroughProperty("Text_PRIX_V_COLLECTION")]
	private TextBox _Text_PRIX_V_COLLECTION;

	[AccessedThroughProperty("Text_CODE_COLLECTION")]
	private TextBox _Text_CODE_COLLECTION;

	[AccessedThroughProperty("Button_GENERER_COLLECTION")]
	private Button _Button_GENERER_COLLECTION;

	[AccessedThroughProperty("Text_PRIX_A_COLLECTION")]
	private TextBox _Text_PRIX_A_COLLECTION;

	[AccessedThroughProperty("Button_ADD_COLLECTION")]
	private Button _Button_ADD_COLLECTION;

	[AccessedThroughProperty("Label74")]
	private Label _Label74;

	[AccessedThroughProperty("Text_CODE_RICHE")]
	private RichTextBox _Text_CODE_RICHE;

	[AccessedThroughProperty("Button_CANVA")]
	private Button _Button_CANVA;

	[AccessedThroughProperty("Button_IMPORTER")]
	private Button _Button_IMPORTER;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Combo_FOURNISSEUR_COLLECTION")]
	private ComboBox _Combo_FOURNISSEUR_COLLECTION;

	[AccessedThroughProperty("Label86")]
	private Label _Label86;

	[AccessedThroughProperty("Text_REFERENCE_COLLECTION")]
	private TextBox _Text_REFERENCE_COLLECTION;

	[AccessedThroughProperty("Label77")]
	private Label _Label77;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label_ALERTS_STOCK")]
	private Label _Label_ALERTS_STOCK;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("Label_STOCK_NEGATIF")]
	private Label _Label_STOCK_NEGATIF;

	[AccessedThroughProperty("Panel_GROUPE")]
	private Panel _Panel_GROUPE;

	[AccessedThroughProperty("Label87")]
	private Label _Label87;

	[AccessedThroughProperty("Combo_GROUPES")]
	private ComboBox _Combo_GROUPES;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn26")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn26;

	[AccessedThroughProperty("DataGridViewTextBoxColumn27")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn27;

	[AccessedThroughProperty("DataGridViewTextBoxColumn28")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn28;

	[AccessedThroughProperty("DataGridViewTextBoxColumn29")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn29;

	[AccessedThroughProperty("DataGridViewTextBoxColumn30")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn30;

	[AccessedThroughProperty("Column6")]
	private DataGridViewTextBoxColumn _Column6;

	[AccessedThroughProperty("Column7")]
	private DataGridViewTextBoxColumn _Column7;

	[AccessedThroughProperty("Column8")]
	private DataGridViewTextBoxColumn _Column8;

	[AccessedThroughProperty("Column9")]
	private DataGridViewTextBoxColumn _Column9;

	[AccessedThroughProperty("Column10")]
	private DataGridViewTextBoxColumn _Column10;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Text_LIEN_PICTURE_ANC")]
	private TextBox _Text_LIEN_PICTURE_ANC;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Label89")]
	private Label _Label89;

	[AccessedThroughProperty("Label88")]
	private Label _Label88;

	[AccessedThroughProperty("Text_PRIX_QTE_MIN")]
	private TextBox _Text_PRIX_QTE_MIN;

	[AccessedThroughProperty("Text_PRIX_QTE")]
	private TextBox _Text_PRIX_QTE;

	[AccessedThroughProperty("Label_PRIX_QTE")]
	private Label _Label_PRIX_QTE;

	[AccessedThroughProperty("Label91")]
	private Label _Label91;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private DataTable _DT_FAMILLE_FILTRAGE;

	private MySqlDataAdapter _DA_FAMILLE_FILTRAGE;

	private int x;

	private int y;

	private Point newpoint;

	private string _FAMILLE_FILTRE;

	private object _sql;

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
			_Panel_INFO = value;
		}
	}

	internal virtual TextBox Text_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = TextBox8_KeyPress;
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			if (_Text_STOCK != null)
			{
				((Control)_Text_STOCK).KeyPress -= val;
				((Control)_Text_STOCK).LostFocus -= eventHandler;
				((Control)_Text_STOCK).GotFocus -= eventHandler2;
			}
			_Text_STOCK = value;
			if (_Text_STOCK != null)
			{
				((Control)_Text_STOCK).KeyPress += val;
				((Control)_Text_STOCK).LostFocus += eventHandler;
				((Control)_Text_STOCK).GotFocus += eventHandler2;
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
			DataGridViewCellMouseEventHandler val4 = DataGridView1_ColumnHeaderMouseDoubleClick;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
				_DataGridView1.DataBindingComplete -= val3;
				_DataGridView1.ColumnHeaderMouseDoubleClick -= val4;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
				_DataGridView1.DataBindingComplete += val3;
				_DataGridView1.ColumnHeaderMouseDoubleClick += val4;
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

	internal virtual TextBox Text_ALERT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ALERT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			EventHandler eventHandler3 = TextBox13_TextChanged;
			KeyPressEventHandler val = TextBox13_KeyPress;
			KeyEventHandler val2 = Text_ALERT_KeyDown;
			if (_Text_ALERT != null)
			{
				((Control)_Text_ALERT).LostFocus -= eventHandler;
				((Control)_Text_ALERT).GotFocus -= eventHandler2;
				((Control)_Text_ALERT).TextChanged -= eventHandler3;
				((Control)_Text_ALERT).KeyPress -= val;
				((Control)_Text_ALERT).KeyDown -= val2;
			}
			_Text_ALERT = value;
			if (_Text_ALERT != null)
			{
				((Control)_Text_ALERT).LostFocus += eventHandler;
				((Control)_Text_ALERT).GotFocus += eventHandler2;
				((Control)_Text_ALERT).TextChanged += eventHandler3;
				((Control)_Text_ALERT).KeyPress += val;
				((Control)_Text_ALERT).KeyDown += val2;
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			EventHandler eventHandler3 = TextBox15_TextChanged;
			KeyPressEventHandler val = TextBox15_KeyPress;
			if (_Text_ARTICLE != null)
			{
				((Control)_Text_ARTICLE).LostFocus -= eventHandler;
				((Control)_Text_ARTICLE).GotFocus -= eventHandler2;
				((Control)_Text_ARTICLE).TextChanged -= eventHandler3;
				((Control)_Text_ARTICLE).KeyPress -= val;
			}
			_Text_ARTICLE = value;
			if (_Text_ARTICLE != null)
			{
				((Control)_Text_ARTICLE).LostFocus += eventHandler;
				((Control)_Text_ARTICLE).GotFocus += eventHandler2;
				((Control)_Text_ARTICLE).TextChanged += eventHandler3;
				((Control)_Text_ARTICLE).KeyPress += val;
			}
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			KeyPressEventHandler val = Text_CODE_KeyPress;
			if (_Text_CODE != null)
			{
				((Control)_Text_CODE).LostFocus -= eventHandler;
				((Control)_Text_CODE).GotFocus -= eventHandler2;
				((Control)_Text_CODE).KeyPress -= val;
			}
			_Text_CODE = value;
			if (_Text_CODE != null)
			{
				((Control)_Text_CODE).LostFocus += eventHandler;
				((Control)_Text_CODE).GotFocus += eventHandler2;
				((Control)_Text_CODE).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			KeyPressEventHandler val = TextBox16_KeyPress;
			EventHandler eventHandler3 = TextBox16_TextChanged;
			if (_Text_PRIX_V != null)
			{
				((Control)_Text_PRIX_V).LostFocus -= eventHandler;
				((Control)_Text_PRIX_V).GotFocus -= eventHandler2;
				((Control)_Text_PRIX_V).KeyPress -= val;
				((Control)_Text_PRIX_V).TextChanged -= eventHandler3;
			}
			_Text_PRIX_V = value;
			if (_Text_PRIX_V != null)
			{
				((Control)_Text_PRIX_V).LostFocus += eventHandler;
				((Control)_Text_PRIX_V).GotFocus += eventHandler2;
				((Control)_Text_PRIX_V).KeyPress += val;
				((Control)_Text_PRIX_V).TextChanged += eventHandler3;
			}
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
			EventHandler eventHandler = Label25_Click;
			if (_Label25 != null)
			{
				((Control)_Label25).Click -= eventHandler;
			}
			_Label25 = value;
			if (_Label25 != null)
			{
				((Control)_Label25).Click += eventHandler;
			}
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			KeyPressEventHandler val = TextBox17_KeyPress;
			KeyEventHandler val2 = Text_PRIX_A_KeyUp;
			EventHandler eventHandler3 = TextBox17_TextChanged;
			if (_Text_PRIX_A != null)
			{
				((Control)_Text_PRIX_A).LostFocus -= eventHandler;
				((Control)_Text_PRIX_A).GotFocus -= eventHandler2;
				((Control)_Text_PRIX_A).KeyPress -= val;
				((Control)_Text_PRIX_A).KeyUp -= val2;
				((Control)_Text_PRIX_A).TextChanged -= eventHandler3;
			}
			_Text_PRIX_A = value;
			if (_Text_PRIX_A != null)
			{
				((Control)_Text_PRIX_A).LostFocus += eventHandler;
				((Control)_Text_PRIX_A).GotFocus += eventHandler2;
				((Control)_Text_PRIX_A).KeyPress += val;
				((Control)_Text_PRIX_A).KeyUp += val2;
				((Control)_Text_PRIX_A).TextChanged += eventHandler3;
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

	internal virtual Button Button_GENERER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GENERER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_GENERER_Click;
			if (_Button_GENERER != null)
			{
				((Control)_Button_GENERER).Click -= eventHandler;
			}
			_Button_GENERER = value;
			if (_Button_GENERER != null)
			{
				((Control)_Button_GENERER).Click += eventHandler;
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

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
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

	internal virtual Panel Panel10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel10 = value;
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

	internal virtual Label Label_VALEURSTOCK_MP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_MP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_MP_Click;
			if (_Label_VALEURSTOCK_MP != null)
			{
				((Control)_Label_VALEURSTOCK_MP).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_MP = value;
			if (_Label_VALEURSTOCK_MP != null)
			{
				((Control)_Label_VALEURSTOCK_MP).Click += eventHandler;
			}
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

	internal virtual Label Label_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ARTICLES = value;
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

	internal virtual Button Button_CALC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_Click;
			if (_Button_CALC != null)
			{
				((Control)_Button_CALC).Click -= eventHandler;
			}
			_Button_CALC = value;
			if (_Button_CALC != null)
			{
				((Control)_Button_CALC).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FAMILLE = value;
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

	internal virtual TextBox Text_PRIX_MP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_MP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_PRIX_MP_KeyPress;
			EventHandler eventHandler = TextBox3_TextChanged;
			if (_Text_PRIX_MP != null)
			{
				((Control)_Text_PRIX_MP).KeyPress -= val;
				((Control)_Text_PRIX_MP).TextChanged -= eventHandler;
			}
			_Text_PRIX_MP = value;
			if (_Text_PRIX_MP != null)
			{
				((Control)_Text_PRIX_MP).KeyPress += val;
				((Control)_Text_PRIX_MP).TextChanged += eventHandler;
			}
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

	internal virtual DataGridView DataGrid_RECEPTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_RECEPTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_RECEPTIONS = value;
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

	internal virtual TextBox Text_PRIX_V_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_V_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_PRIX_V_2_TextChanged;
			KeyPressEventHandler val = Text_PRIX_V_2_KeyPress;
			if (_Text_PRIX_V_2 != null)
			{
				((Control)_Text_PRIX_V_2).TextChanged -= eventHandler;
				((Control)_Text_PRIX_V_2).KeyPress -= val;
			}
			_Text_PRIX_V_2 = value;
			if (_Text_PRIX_V_2 != null)
			{
				((Control)_Text_PRIX_V_2).TextChanged += eventHandler;
				((Control)_Text_PRIX_V_2).KeyPress += val;
			}
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

	internal virtual TextBox Text_EMPLACEMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_EMPLACEMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_EMPLACEMENT = value;
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

	internal virtual ComboBox Combo_TAUX_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TAUX_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_TAUX_TVA = value;
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

	internal virtual TextBox Text_DESCRIPTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_DESCRIPTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			if (_Text_DESCRIPTION != null)
			{
				((Control)_Text_DESCRIPTION).LostFocus -= eventHandler;
				((Control)_Text_DESCRIPTION).GotFocus -= eventHandler2;
			}
			_Text_DESCRIPTION = value;
			if (_Text_DESCRIPTION != null)
			{
				((Control)_Text_DESCRIPTION).LostFocus += eventHandler;
				((Control)_Text_DESCRIPTION).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual ComboBox Combo_COULEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_COULEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_COULEURS_SelectionChangeCommitted;
			EventHandler eventHandler2 = Combo_COULEURS_SelectedIndexChanged;
			if (_Combo_COULEURS != null)
			{
				_Combo_COULEURS.SelectionChangeCommitted -= eventHandler;
				_Combo_COULEURS.SelectedIndexChanged -= eventHandler2;
			}
			_Combo_COULEURS = value;
			if (_Combo_COULEURS != null)
			{
				_Combo_COULEURS.SelectionChangeCommitted += eventHandler;
				_Combo_COULEURS.SelectedIndexChanged += eventHandler2;
			}
		}
	}

	internal virtual TextBox Text_SOUS_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_SOUS_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			if (_Text_SOUS_FAMILLE != null)
			{
				((Control)_Text_SOUS_FAMILLE).LostFocus -= eventHandler;
				((Control)_Text_SOUS_FAMILLE).GotFocus -= eventHandler2;
			}
			_Text_SOUS_FAMILLE = value;
			if (_Text_SOUS_FAMILLE != null)
			{
				((Control)_Text_SOUS_FAMILLE).LostFocus += eventHandler;
				((Control)_Text_SOUS_FAMILLE).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual ComboBox Combo_TAILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TAILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TAILLES_SelectionChangeCommitted;
			EventHandler eventHandler2 = Combo_TAILLES_SelectedIndexChanged;
			if (_Combo_TAILLES != null)
			{
				_Combo_TAILLES.SelectionChangeCommitted -= eventHandler;
				_Combo_TAILLES.SelectedIndexChanged -= eventHandler2;
			}
			_Combo_TAILLES = value;
			if (_Combo_TAILLES != null)
			{
				_Combo_TAILLES.SelectionChangeCommitted += eventHandler;
				_Combo_TAILLES.SelectedIndexChanged += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel_Picture_IMAGE_TOOLS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_Picture_IMAGE_TOOLS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_Picture_IMAGE_TOOLS = value;
		}
	}

	internal virtual Button Button26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button26_Click;
			if (_Button26 != null)
			{
				((Control)_Button26).Click -= eventHandler;
			}
			_Button26 = value;
			if (_Button26 != null)
			{
				((Control)_Button26).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button27_Click;
			if (_Button27 != null)
			{
				((Control)_Button27).Click -= eventHandler;
			}
			_Button27 = value;
			if (_Button27 != null)
			{
				((Control)_Button27).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button29_Click;
			if (_Button29 != null)
			{
				((Control)_Button29).Click -= eventHandler;
			}
			_Button29 = value;
			if (_Button29 != null)
			{
				((Control)_Button29).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button30_Click;
			if (_Button30 != null)
			{
				((Control)_Button30).Click -= eventHandler;
			}
			_Button30 = value;
			if (_Button30 != null)
			{
				((Control)_Button30).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button31_Click;
			if (_Button31 != null)
			{
				((Control)_Button31).Click -= eventHandler;
			}
			_Button31 = value;
			if (_Button31 != null)
			{
				((Control)_Button31).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button35_Click;
			if (_Button35 != null)
			{
				((Control)_Button35).Click -= eventHandler;
			}
			_Button35 = value;
			if (_Button35 != null)
			{
				((Control)_Button35).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_IMAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_IMAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_IMAGE_DoubleClick;
			EventHandler eventHandler2 = Picture_IMAGE_Click;
			if (_Picture_IMAGE != null)
			{
				((Control)_Picture_IMAGE).DoubleClick -= eventHandler;
				((Control)_Picture_IMAGE).Click -= eventHandler2;
			}
			_Picture_IMAGE = value;
			if (_Picture_IMAGE != null)
			{
				((Control)_Picture_IMAGE).DoubleClick += eventHandler;
				((Control)_Picture_IMAGE).Click += eventHandler2;
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
			EventHandler eventHandler = Text_LIEN_PICTURE_DoubleClick;
			EventHandler eventHandler2 = Text_LIEN_PICTURE_TextChanged;
			if (_Text_LIEN_PICTURE != null)
			{
				((Control)_Text_LIEN_PICTURE).DoubleClick -= eventHandler;
				((Control)_Text_LIEN_PICTURE).TextChanged -= eventHandler2;
			}
			_Text_LIEN_PICTURE = value;
			if (_Text_LIEN_PICTURE != null)
			{
				((Control)_Text_LIEN_PICTURE).DoubleClick += eventHandler;
				((Control)_Text_LIEN_PICTURE).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual ComboBox Combo_UNITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_UNITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_UNITE = value;
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

	internal virtual ComboBox Combo_MODE_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_MODE_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_MODE_STOCK = value;
		}
	}

	internal virtual TextBox Text_STOCK_INITIAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_STOCK_INITIAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_STOCK_INITIAL = value;
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

	internal virtual TextBox Text_DATE_INVENTAIRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_DATE_INVENTAIRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_DATE_INVENTAIRE = value;
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

	internal virtual TextBox Text_DATE_CREATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_DATE_CREATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_DATE_CREATION = value;
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

	internal virtual DataGridView DataGrid_SORTIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_SORTIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_SORTIES = value;
		}
	}

	internal virtual DataGridView DataGrid_VENTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_VENTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_VENTES = value;
		}
	}

	internal virtual Button Button_SORTIES
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

	internal virtual Button Button_VENTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VENTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_VENTES_Click;
			if (_Button_VENTES != null)
			{
				((Control)_Button_VENTES).Click -= eventHandler;
			}
			_Button_VENTES = value;
			if (_Button_VENTES != null)
			{
				((Control)_Button_VENTES).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_RECEPTIONS
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

	internal virtual Label Label30303
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30303;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30303 = value;
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

	internal virtual TextBox Text_REFERENCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_REFERENCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_REFERENCE = value;
		}
	}

	internal virtual ComboBox Combo_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FOURNISSEUR = value;
		}
	}

	internal virtual Button Button24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button24_Click;
			if (_Button24 != null)
			{
				((Control)_Button24).Click -= eventHandler;
			}
			_Button24 = value;
			if (_Button24 != null)
			{
				((Control)_Button24).Click += eventHandler;
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

	internal virtual ComboBox Combo_PRINTER_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_DUPLICATA = value;
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

	internal virtual ComboBox Combo_PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER = value;
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

	internal virtual PictureBox PictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox12 = value;
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

	internal virtual Button Button_ETAT_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ETAT_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ETAT_STOCK_Click;
			if (_Button_ETAT_STOCK != null)
			{
				((Control)_Button_ETAT_STOCK).Click -= eventHandler;
			}
			_Button_ETAT_STOCK = value;
			if (_Button_ETAT_STOCK != null)
			{
				((Control)_Button_ETAT_STOCK).Click += eventHandler;
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

	internal virtual Button Button12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button12_Click;
			if (_Button12 != null)
			{
				((Control)_Button12).Click -= eventHandler;
			}
			_Button12 = value;
			if (_Button12 != null)
			{
				((Control)_Button12).Click += eventHandler;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel0_Paint;
			if (_Panel0 != null)
			{
				((Control)_Panel0).Paint -= val;
			}
			_Panel0 = value;
			if (_Panel0 != null)
			{
				((Control)_Panel0).Paint += val;
			}
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

	internal virtual Label Label_VALEURSTOCK_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_A_Click;
			if (_Label_VALEURSTOCK_A != null)
			{
				((Control)_Label_VALEURSTOCK_A).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_A = value;
			if (_Label_VALEURSTOCK_A != null)
			{
				((Control)_Label_VALEURSTOCK_A).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox14 = value;
		}
	}

	internal virtual Button Button_MOUVEMENTS
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

	internal virtual DataGridView DataGrid_MOUVEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_MOUVEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_MOUVEMENTS = value;
		}
	}

	internal virtual Panel Panel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel9 = value;
		}
	}

	internal virtual PictureBox PictureBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox15 = value;
		}
	}

	internal virtual PictureBox PictureBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox16 = value;
		}
	}

	internal virtual PictureBox PictureBox17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox17 = value;
		}
	}

	internal virtual Label Label_VALEURSTOCK_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_V_Click;
			if (_Label_VALEURSTOCK_V != null)
			{
				((Control)_Label_VALEURSTOCK_V).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_V = value;
			if (_Label_VALEURSTOCK_V != null)
			{
				((Control)_Label_VALEURSTOCK_V).Click += eventHandler;
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

	internal virtual Label Label_VALEURSTOCK_A_NON
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_A_NON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_A_NON_Click;
			if (_Label_VALEURSTOCK_A_NON != null)
			{
				((Control)_Label_VALEURSTOCK_A_NON).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_A_NON = value;
			if (_Label_VALEURSTOCK_A_NON != null)
			{
				((Control)_Label_VALEURSTOCK_A_NON).Click += eventHandler;
			}
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

	internal virtual Label Label_VALEURSTOCK_MP_NON
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_MP_NON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_MP_NON_Click;
			if (_Label_VALEURSTOCK_MP_NON != null)
			{
				((Control)_Label_VALEURSTOCK_MP_NON).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_MP_NON = value;
			if (_Label_VALEURSTOCK_MP_NON != null)
			{
				((Control)_Label_VALEURSTOCK_MP_NON).Click += eventHandler;
			}
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

	internal virtual Label Label_VALEURSTOCK_V_NON
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VALEURSTOCK_V_NON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_VALEURSTOCK_V_NON_Click;
			if (_Label_VALEURSTOCK_V_NON != null)
			{
				((Control)_Label_VALEURSTOCK_V_NON).Click -= eventHandler;
			}
			_Label_VALEURSTOCK_V_NON = value;
			if (_Label_VALEURSTOCK_V_NON != null)
			{
				((Control)_Label_VALEURSTOCK_V_NON).Click += eventHandler;
			}
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

	internal virtual Button Button_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BALANCE_Click;
			if (_Button_BALANCE != null)
			{
				((Control)_Button_BALANCE).Click -= eventHandler;
			}
			_Button_BALANCE = value;
			if (_Button_BALANCE != null)
			{
				((Control)_Button_BALANCE).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_BALANCE = value;
		}
	}

	internal virtual Button Button_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FAMILLES_Click;
			if (_Button_FAMILLES != null)
			{
				((Control)_Button_FAMILLES).Click -= eventHandler;
			}
			_Button_FAMILLES = value;
			if (_Button_FAMILLES != null)
			{
				((Control)_Button_FAMILLES).Click += eventHandler;
			}
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

	internal virtual Button Button85454
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button85454;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button85454_Click;
			if (_Button85454 != null)
			{
				((Control)_Button85454).Click -= eventHandler;
			}
			_Button85454 = value;
			if (_Button85454 != null)
			{
				((Control)_Button85454).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button73434
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button73434;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button73434_Click;
			if (_Button73434 != null)
			{
				((Control)_Button73434).Click -= eventHandler;
			}
			_Button73434 = value;
			if (_Button73434 != null)
			{
				((Control)_Button73434).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button9_Click;
			if (_Button9 != null)
			{
				((Control)_Button9).Click -= eventHandler;
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				((Control)_Button9).Click += eventHandler;
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

	internal virtual Panel Panel_Picture_IMAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_Picture_IMAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_Picture_IMAGE = value;
		}
	}

	internal virtual PictureBox PictureBox20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox20 = value;
		}
	}

	internal virtual PictureBox PictureBox21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox21 = value;
		}
	}

	internal virtual PictureBox PictureBox18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox18 = value;
		}
	}

	internal virtual PictureBox PictureBox19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox19 = value;
		}
	}

	internal virtual PictureBox PictureBox30
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox30 = value;
		}
	}

	internal virtual PictureBox PictureBox31
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox31 = value;
		}
	}

	internal virtual PictureBox PictureBox32
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox32 = value;
		}
	}

	internal virtual PictureBox PictureBox33
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox33 = value;
		}
	}

	internal virtual PictureBox PictureBox26
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox26 = value;
		}
	}

	internal virtual PictureBox PictureBox27
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox27 = value;
		}
	}

	internal virtual PictureBox PictureBox28
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox28 = value;
		}
	}

	internal virtual PictureBox PictureBox29
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox29 = value;
		}
	}

	internal virtual PictureBox PictureBox22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox22 = value;
		}
	}

	internal virtual PictureBox PictureBox23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox23 = value;
		}
	}

	internal virtual PictureBox PictureBox24
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox24 = value;
		}
	}

	internal virtual PictureBox PictureBox25
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox25 = value;
		}
	}

	internal virtual PictureBox PictureBox34
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox34 = value;
		}
	}

	internal virtual PictureBox PictureBox35
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox35 = value;
		}
	}

	internal virtual PictureBox PictureBox36
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox36 = value;
		}
	}

	internal virtual PictureBox PictureBox37
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox37 = value;
		}
	}

	internal virtual Panel Panel13243
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel13243;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel13243 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual DataGridView DataGridView_TRIAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_TRIAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_TRIAGE_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView_TRIAGE_CellContentClick;
			if (_DataGridView_TRIAGE != null)
			{
				_DataGridView_TRIAGE.CellClick -= val;
				_DataGridView_TRIAGE.CellContentClick -= val2;
			}
			_DataGridView_TRIAGE = value;
			if (_DataGridView_TRIAGE != null)
			{
				_DataGridView_TRIAGE.CellClick += val;
				_DataGridView_TRIAGE.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewButtonColumn DataGridViewButtonColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewButtonColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewButtonColumn1 = value;
		}
	}

	internal virtual Button Button10767
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button10767;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button10767_Click;
			if (_Button10767 != null)
			{
				((Control)_Button10767).Click -= eventHandler;
			}
			_Button10767 = value;
			if (_Button10767 != null)
			{
				((Control)_Button10767).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label61
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label61 = value;
		}
	}

	internal virtual Label Label60
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label60 = value;
		}
	}

	internal virtual Label Label59
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label59 = value;
		}
	}

	internal virtual Label Label62
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label62 = value;
		}
	}

	internal virtual Label Label_PROMOTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PROMOTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_PROMOTIONS_Click;
			if (_Label_PROMOTIONS != null)
			{
				((Control)_Label_PROMOTIONS).Click -= eventHandler;
			}
			_Label_PROMOTIONS = value;
			if (_Label_PROMOTIONS != null)
			{
				((Control)_Label_PROMOTIONS).Click += eventHandler;
			}
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

	internal virtual TextBox Text_PROMOTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PROMOTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_PROMOTION_KeyPress;
			if (_Text_PROMOTION != null)
			{
				((Control)_Text_PROMOTION).KeyPress -= val;
			}
			_Text_PROMOTION = value;
			if (_Text_PROMOTION != null)
			{
				((Control)_Text_PROMOTION).KeyPress += val;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn17 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn18 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn19 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn20 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn unité
	{
		[DebuggerNonUserCode]
		get
		{
			return _unité;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_unité = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn departement
	{
		[DebuggerNonUserCode]
		get
		{
			return _departement;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_departement = value;
		}
	}

	internal virtual Label Label69
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label69 = value;
		}
	}

	internal virtual Button Button_PROMOTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PROMOTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PROMOTION_Click;
			if (_Button_PROMOTION != null)
			{
				((Control)_Button_PROMOTION).Click -= eventHandler;
			}
			_Button_PROMOTION = value;
			if (_Button_PROMOTION != null)
			{
				((Control)_Button_PROMOTION).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel1233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1233 = value;
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

	internal virtual Label Label63
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label63 = value;
		}
	}

	internal virtual TextBox TextBox154545
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox154545;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox154545 = value;
		}
	}

	internal virtual Label Label68
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label68 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox7 = value;
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

	internal virtual Label Label64
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label64 = value;
		}
	}

	internal virtual Label Label65
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label65 = value;
		}
	}

	internal virtual Label Label66
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label66 = value;
		}
	}

	internal virtual Label Label67
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label67 = value;
		}
	}

	internal virtual Button Button_M_SHIFTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_M_SHIFTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_M_SHIFTS_Click;
			if (_Button_M_SHIFTS != null)
			{
				((Control)_Button_M_SHIFTS).Click -= eventHandler;
			}
			_Button_M_SHIFTS = value;
			if (_Button_M_SHIFTS != null)
			{
				((Control)_Button_M_SHIFTS).Click += eventHandler;
			}
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

	internal virtual Label Label70
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label70 = value;
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

	internal virtual DataGridViewTextBoxColumn Column4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column4 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn5 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn10 = value;
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

	internal virtual DataGridViewTextBoxColumn ID_BR
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_BR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_BR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Articles
	{
		[DebuggerNonUserCode]
		get
		{
			return _Articles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Articles = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Prix_AA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_AA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_AA = value;
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

	internal virtual DataGridViewTextBoxColumn Fournisseur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Fournisseur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Fournisseur = value;
		}
	}

	internal virtual DataGridViewImageColumn Column1
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

	internal virtual DataGridViewTextBoxColumn Famille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Famille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Famille = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_A = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_V_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V_1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Alert
	{
		[DebuggerNonUserCode]
		get
		{
			return _Alert;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Alert = value;
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

	internal virtual ComboBox Combo_FENETRE_PESEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FENETRE_PESEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FENETRE_PESEE = value;
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

	internal virtual Panel Panel119898
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel119898;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel119898 = value;
		}
	}

	internal virtual DataGridView DataGridView_FILTRAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_FILTRAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_FILTRAGE_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView_FILTRAGE_CellContentClick;
			if (_DataGridView_FILTRAGE != null)
			{
				_DataGridView_FILTRAGE.CellClick -= val;
				_DataGridView_FILTRAGE.CellContentClick -= val2;
			}
			_DataGridView_FILTRAGE = value;
			if (_DataGridView_FILTRAGE != null)
			{
				_DataGridView_FILTRAGE.CellClick += val;
				_DataGridView_FILTRAGE.CellContentClick += val2;
			}
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

	internal virtual Button_RJ Button_RJ38787
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ38787;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ38787_Click;
			if (_Button_RJ38787 != null)
			{
				((Control)_Button_RJ38787).Click -= eventHandler;
			}
			_Button_RJ38787 = value;
			if (_Button_RJ38787 != null)
			{
				((Control)_Button_RJ38787).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RJ16576
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ16576;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ16576_Click;
			if (_Button_RJ16576 != null)
			{
				((Control)_Button_RJ16576).Click -= eventHandler;
			}
			_Button_RJ16576 = value;
			if (_Button_RJ16576 != null)
			{
				((Control)_Button_RJ16576).Click += eventHandler;
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

	internal virtual TextBox TextBox14343
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox14343;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox14343_TextChanged;
			if (_TextBox14343 != null)
			{
				((Control)_TextBox14343).TextChanged -= eventHandler;
			}
			_TextBox14343 = value;
			if (_TextBox14343 != null)
			{
				((Control)_TextBox14343).TextChanged += eventHandler;
			}
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

	internal virtual Label Label71
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label71 = value;
		}
	}

	internal virtual Label Label72
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label72 = value;
		}
	}

	internal virtual Label Label73
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label73 = value;
		}
	}

	internal virtual ComboBox Combo_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_BALANCE = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_FIND_TextChanged;
			KeyEventHandler val = Text_FIND_KeyDown;
			if (_Text_FIND != null)
			{
				_Text_FIND._TextChanged -= eventHandler;
				((Control)_Text_FIND).KeyDown -= val;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				_Text_FIND._TextChanged += eventHandler;
				((Control)_Text_FIND).KeyDown += val;
			}
		}
	}

	internal virtual Button Button_INVENTAIRES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_INVENTAIRES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_INVENTAIRES_Click;
			if (_Button_INVENTAIRES != null)
			{
				((Control)_Button_INVENTAIRES).Click -= eventHandler;
			}
			_Button_INVENTAIRES = value;
			if (_Button_INVENTAIRES != null)
			{
				((Control)_Button_INVENTAIRES).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGrid_INVENTAIRES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_INVENTAIRES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_INVENTAIRES = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn21 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn22 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn23 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn24 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn25 = value;
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

	internal virtual DataGridViewTextBoxColumn Column3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column3 = value;
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

	internal virtual DataGridViewButtonColumn DataGridViewButtonColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewButtonColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewButtonColumn2 = value;
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

	internal virtual PictureBox PictureBox_ROBOT
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_ROBOT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			MouseEventHandler val = PictureBox24556_MouseMove;
			MouseEventHandler val2 = PictureBox24556_MouseDown;
			EventHandler eventHandler = PictureBox_ROBOT_DoubleClick;
			EventHandler eventHandler2 = PictureBox_ROBOT_Click;
			if (_PictureBox_ROBOT != null)
			{
				((Control)_PictureBox_ROBOT).MouseMove -= val;
				((Control)_PictureBox_ROBOT).MouseDown -= val2;
				((Control)_PictureBox_ROBOT).DoubleClick -= eventHandler;
				((Control)_PictureBox_ROBOT).Click -= eventHandler2;
			}
			_PictureBox_ROBOT = value;
			if (_PictureBox_ROBOT != null)
			{
				((Control)_PictureBox_ROBOT).MouseMove += val;
				((Control)_PictureBox_ROBOT).MouseDown += val2;
				((Control)_PictureBox_ROBOT).DoubleClick += eventHandler;
				((Control)_PictureBox_ROBOT).Click += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel_COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_COULEUR = value;
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

	internal virtual PictureBox Picture_COLOR_23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_23 != null)
			{
				((Control)_Picture_COLOR_23).Click -= eventHandler;
			}
			_Picture_COLOR_23 = value;
			if (_Picture_COLOR_23 != null)
			{
				((Control)_Picture_COLOR_23).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_22 != null)
			{
				((Control)_Picture_COLOR_22).Click -= eventHandler;
			}
			_Picture_COLOR_22 = value;
			if (_Picture_COLOR_22 != null)
			{
				((Control)_Picture_COLOR_22).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_21 != null)
			{
				((Control)_Picture_COLOR_21).Click -= eventHandler;
			}
			_Picture_COLOR_21 = value;
			if (_Picture_COLOR_21 != null)
			{
				((Control)_Picture_COLOR_21).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_20 != null)
			{
				((Control)_Picture_COLOR_20).Click -= eventHandler;
			}
			_Picture_COLOR_20 = value;
			if (_Picture_COLOR_20 != null)
			{
				((Control)_Picture_COLOR_20).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_19 != null)
			{
				((Control)_Picture_COLOR_19).Click -= eventHandler;
			}
			_Picture_COLOR_19 = value;
			if (_Picture_COLOR_19 != null)
			{
				((Control)_Picture_COLOR_19).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_18 != null)
			{
				((Control)_Picture_COLOR_18).Click -= eventHandler;
			}
			_Picture_COLOR_18 = value;
			if (_Picture_COLOR_18 != null)
			{
				((Control)_Picture_COLOR_18).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_16 != null)
			{
				((Control)_Picture_COLOR_16).Click -= eventHandler;
			}
			_Picture_COLOR_16 = value;
			if (_Picture_COLOR_16 != null)
			{
				((Control)_Picture_COLOR_16).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_15 != null)
			{
				((Control)_Picture_COLOR_15).Click -= eventHandler;
			}
			_Picture_COLOR_15 = value;
			if (_Picture_COLOR_15 != null)
			{
				((Control)_Picture_COLOR_15).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_14 != null)
			{
				((Control)_Picture_COLOR_14).Click -= eventHandler;
			}
			_Picture_COLOR_14 = value;
			if (_Picture_COLOR_14 != null)
			{
				((Control)_Picture_COLOR_14).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_13 != null)
			{
				((Control)_Picture_COLOR_13).Click -= eventHandler;
			}
			_Picture_COLOR_13 = value;
			if (_Picture_COLOR_13 != null)
			{
				((Control)_Picture_COLOR_13).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_12 != null)
			{
				((Control)_Picture_COLOR_12).Click -= eventHandler;
			}
			_Picture_COLOR_12 = value;
			if (_Picture_COLOR_12 != null)
			{
				((Control)_Picture_COLOR_12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_11 != null)
			{
				((Control)_Picture_COLOR_11).Click -= eventHandler;
			}
			_Picture_COLOR_11 = value;
			if (_Picture_COLOR_11 != null)
			{
				((Control)_Picture_COLOR_11).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_6 != null)
			{
				((Control)_Picture_COLOR_6).Click -= eventHandler;
			}
			_Picture_COLOR_6 = value;
			if (_Picture_COLOR_6 != null)
			{
				((Control)_Picture_COLOR_6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_10 != null)
			{
				((Control)_Picture_COLOR_10).Click -= eventHandler;
			}
			_Picture_COLOR_10 = value;
			if (_Picture_COLOR_10 != null)
			{
				((Control)_Picture_COLOR_10).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_5 != null)
			{
				((Control)_Picture_COLOR_5).Click -= eventHandler;
			}
			_Picture_COLOR_5 = value;
			if (_Picture_COLOR_5 != null)
			{
				((Control)_Picture_COLOR_5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_1 != null)
			{
				((Control)_Picture_COLOR_1).Click -= eventHandler;
			}
			_Picture_COLOR_1 = value;
			if (_Picture_COLOR_1 != null)
			{
				((Control)_Picture_COLOR_1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_8 != null)
			{
				((Control)_Picture_COLOR_8).Click -= eventHandler;
			}
			_Picture_COLOR_8 = value;
			if (_Picture_COLOR_8 != null)
			{
				((Control)_Picture_COLOR_8).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_9 != null)
			{
				((Control)_Picture_COLOR_9).Click -= eventHandler;
			}
			_Picture_COLOR_9 = value;
			if (_Picture_COLOR_9 != null)
			{
				((Control)_Picture_COLOR_9).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_4 != null)
			{
				((Control)_Picture_COLOR_4).Click -= eventHandler;
			}
			_Picture_COLOR_4 = value;
			if (_Picture_COLOR_4 != null)
			{
				((Control)_Picture_COLOR_4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_3 != null)
			{
				((Control)_Picture_COLOR_3).Click -= eventHandler;
			}
			_Picture_COLOR_3 = value;
			if (_Picture_COLOR_3 != null)
			{
				((Control)_Picture_COLOR_3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_2 != null)
			{
				((Control)_Picture_COLOR_2).Click -= eventHandler;
			}
			_Picture_COLOR_2 = value;
			if (_Picture_COLOR_2 != null)
			{
				((Control)_Picture_COLOR_2).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox TextBox_AJOUT_STOCK_MANUEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_AJOUT_STOCK_MANUEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_AJOUT_STOCK_MANUEL = value;
		}
	}

	internal virtual TextBox TextBox_MODIF_STOCK_MANUEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_MODIF_STOCK_MANUEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_MODIF_STOCK_MANUEL = value;
		}
	}

	internal virtual TextBox TextBox_NBR_CODE_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_NBR_CODE_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_NBR_CODE_BALANCE = value;
		}
	}

	internal virtual TextBox TextBox_NBR_CODE_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_NBR_CODE_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_NBR_CODE_ARTICLE = value;
		}
	}

	internal virtual PictureBox Picture_GREEN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GREEN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_GREEN = value;
		}
	}

	internal virtual PictureBox Picture_BLUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_BLUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_BLUE = value;
		}
	}

	internal virtual PictureBox Picture_RED
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_RED;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_RED = value;
		}
	}

	internal virtual Button Button_ETAT_LISTE_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ETAT_LISTE_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ETAT_LISTE_ARTICLES_Click;
			if (_Button_ETAT_LISTE_ARTICLES != null)
			{
				((Control)_Button_ETAT_LISTE_ARTICLES).Click -= eventHandler;
			}
			_Button_ETAT_LISTE_ARTICLES = value;
			if (_Button_ETAT_LISTE_ARTICLES != null)
			{
				((Control)_Button_ETAT_LISTE_ARTICLES).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_INFO_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_INFO_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_INFO_COLLECTION = value;
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

	internal virtual Label Label81
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label81 = value;
		}
	}

	internal virtual TextBox Text_QTE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_QTE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_QTE_KeyPress;
			EventHandler eventHandler = Text_QTE_TextChanged;
			EventHandler eventHandler2 = Text_QTE_LISTE_Click;
			if (_Text_QTE_COLLECTION != null)
			{
				((Control)_Text_QTE_COLLECTION).KeyPress -= val;
				((Control)_Text_QTE_COLLECTION).TextChanged -= eventHandler;
				((TextBoxBase)_Text_QTE_COLLECTION).Click -= eventHandler2;
			}
			_Text_QTE_COLLECTION = value;
			if (_Text_QTE_COLLECTION != null)
			{
				((Control)_Text_QTE_COLLECTION).KeyPress += val;
				((Control)_Text_QTE_COLLECTION).TextChanged += eventHandler;
				((TextBoxBase)_Text_QTE_COLLECTION).Click += eventHandler2;
			}
		}
	}

	internal virtual Button Button23233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button23233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button23233_Click;
			if (_Button23233 != null)
			{
				((Control)_Button23233).Click -= eventHandler;
			}
			_Button23233 = value;
			if (_Button23233 != null)
			{
				((Control)_Button23233).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button23232
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button23232;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button23232_Click;
			if (_Button23232 != null)
			{
				((Control)_Button23232).Click -= eventHandler;
			}
			_Button23232 = value;
			if (_Button23232 != null)
			{
				((Control)_Button23232).Click += eventHandler;
			}
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

	internal virtual Label Label_TOTAL_QUANTITE_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_QUANTITE_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_QUANTITE_DOC = value;
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

	internal virtual Label Label_NBR_ARTICLES_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_NBR_ARTICLES_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_NBR_ARTICLES_DOC = value;
		}
	}

	internal virtual Label Label75
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label75 = value;
		}
	}

	internal virtual Label Label76
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label76 = value;
		}
	}

	internal virtual Label Label79
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label79 = value;
		}
	}

	internal virtual Label Label80
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label80 = value;
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

	internal virtual Button Button_INSERER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_INSERER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_INSERER_Click;
			if (_Button_INSERER != null)
			{
				((Control)_Button_INSERER).Click -= eventHandler;
			}
			_Button_INSERER = value;
			if (_Button_INSERER != null)
			{
				((Control)_Button_INSERER).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView_COULEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_COULEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_COULEURS = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_COULEUR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_COULEUR = value;
		}
	}

	internal virtual DataGridView DataGridView_TAILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_TAILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_TAILLES = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_TAILLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAILLE = value;
		}
	}

	internal virtual DataGridView DataGrid_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGrid_COLLECTION_CellContentClick;
			if (_DataGrid_COLLECTION != null)
			{
				_DataGrid_COLLECTION.CellContentClick -= val;
			}
			_DataGrid_COLLECTION = value;
			if (_DataGrid_COLLECTION != null)
			{
				_DataGrid_COLLECTION.CellContentClick += val;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_BARRE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_BARRE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_BARRE_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ARTICLE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ARTICLE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ARTICLE_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAILLE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAILLE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAILLE_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn COULEUR_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _COULEUR_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_COULEUR_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Qté_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Qté_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Qté_LISTE = value;
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

	internal virtual Label Label78
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label78 = value;
		}
	}

	internal virtual Label Label_TOP_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP_COLLECTION = value;
		}
	}

	internal virtual Label Label82
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label82 = value;
		}
	}

	internal virtual Label Label83
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label83 = value;
		}
	}

	internal virtual Button Button_CLOSE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOSE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLOSE_COLLECTION_Click;
			if (_Button_CLOSE_COLLECTION != null)
			{
				((Control)_Button_CLOSE_COLLECTION).Click -= eventHandler;
			}
			_Button_CLOSE_COLLECTION = value;
			if (_Button_CLOSE_COLLECTION != null)
			{
				((Control)_Button_CLOSE_COLLECTION).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_FAMILLE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FAMILLE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FAMILLE_COLLECTION = value;
		}
	}

	internal virtual Button Button_SAVE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SAVE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SAVE_COLLECTION_Click;
			if (_Button_SAVE_COLLECTION != null)
			{
				((Control)_Button_SAVE_COLLECTION).Click -= eventHandler;
			}
			_Button_SAVE_COLLECTION = value;
			if (_Button_SAVE_COLLECTION != null)
			{
				((Control)_Button_SAVE_COLLECTION).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_ARTICLE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ARTICLE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ARTICLE_COLLECTION = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT212
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT212;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT212_Click;
			if (_Button_CLAVIER_NOSELECT212 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT212).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT212 = value;
			if (_Button_CLAVIER_NOSELECT212 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT212).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label84
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label84 = value;
		}
	}

	internal virtual Label Label85
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label85 = value;
		}
	}

	internal virtual TextBox Text_PRIX_V_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_V_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_PRIX_V_COLLECTION_KeyPress;
			EventHandler eventHandler = Text_PRIX_V_COLLECTION_TextChanged;
			if (_Text_PRIX_V_COLLECTION != null)
			{
				((Control)_Text_PRIX_V_COLLECTION).KeyPress -= val;
				((Control)_Text_PRIX_V_COLLECTION).TextChanged -= eventHandler;
			}
			_Text_PRIX_V_COLLECTION = value;
			if (_Text_PRIX_V_COLLECTION != null)
			{
				((Control)_Text_PRIX_V_COLLECTION).KeyPress += val;
				((Control)_Text_PRIX_V_COLLECTION).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_CODE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_CODE_COLLECTION_KeyPress;
			EventHandler eventHandler = Text_CODE_LISTE_TextChanged;
			if (_Text_CODE_COLLECTION != null)
			{
				((Control)_Text_CODE_COLLECTION).KeyPress -= val;
				((Control)_Text_CODE_COLLECTION).TextChanged -= eventHandler;
			}
			_Text_CODE_COLLECTION = value;
			if (_Text_CODE_COLLECTION != null)
			{
				((Control)_Text_CODE_COLLECTION).KeyPress += val;
				((Control)_Text_CODE_COLLECTION).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_GENERER_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GENERER_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_GENERER_COLLECTION_Click;
			if (_Button_GENERER_COLLECTION != null)
			{
				((Control)_Button_GENERER_COLLECTION).Click -= eventHandler;
			}
			_Button_GENERER_COLLECTION = value;
			if (_Button_GENERER_COLLECTION != null)
			{
				((Control)_Button_GENERER_COLLECTION).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_PRIX_A_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_A_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_PRIX_A_COLLECTION_KeyPress;
			EventHandler eventHandler = Text_PRIX_A_COLLECTION_TextChanged;
			if (_Text_PRIX_A_COLLECTION != null)
			{
				((Control)_Text_PRIX_A_COLLECTION).KeyPress -= val;
				((Control)_Text_PRIX_A_COLLECTION).TextChanged -= eventHandler;
			}
			_Text_PRIX_A_COLLECTION = value;
			if (_Text_PRIX_A_COLLECTION != null)
			{
				((Control)_Text_PRIX_A_COLLECTION).KeyPress += val;
				((Control)_Text_PRIX_A_COLLECTION).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_ADD_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ADD_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ADD_COLLECTION_Click;
			if (_Button_ADD_COLLECTION != null)
			{
				((Control)_Button_ADD_COLLECTION).Click -= eventHandler;
			}
			_Button_ADD_COLLECTION = value;
			if (_Button_ADD_COLLECTION != null)
			{
				((Control)_Button_ADD_COLLECTION).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label74
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label74 = value;
		}
	}

	internal virtual RichTextBox Text_CODE_RICHE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_RICHE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_CODE_RICHE_TextChanged;
			if (_Text_CODE_RICHE != null)
			{
				((Control)_Text_CODE_RICHE).TextChanged -= eventHandler;
			}
			_Text_CODE_RICHE = value;
			if (_Text_CODE_RICHE != null)
			{
				((Control)_Text_CODE_RICHE).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_CANVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CANVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CANVA_Click;
			if (_Button_CANVA != null)
			{
				((Control)_Button_CANVA).Click -= eventHandler;
			}
			_Button_CANVA = value;
			if (_Button_CANVA != null)
			{
				((Control)_Button_CANVA).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_IMPORTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_IMPORTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_IMPORTER_Click;
			if (_Button_IMPORTER != null)
			{
				((Control)_Button_IMPORTER).Click -= eventHandler;
			}
			_Button_IMPORTER = value;
			if (_Button_IMPORTER != null)
			{
				((Control)_Button_IMPORTER).Click += eventHandler;
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

	internal virtual ComboBox Combo_FOURNISSEUR_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FOURNISSEUR_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FOURNISSEUR_COLLECTION = value;
		}
	}

	internal virtual Label Label86
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label86 = value;
		}
	}

	internal virtual TextBox Text_REFERENCE_COLLECTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_REFERENCE_COLLECTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_REFERENCE_COLLECTION = value;
		}
	}

	internal virtual Label Label77
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label77 = value;
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

	internal virtual Label Label_ALERTS_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ALERTS_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_ALERTS_Click;
			if (_Label_ALERTS_STOCK != null)
			{
				((Control)_Label_ALERTS_STOCK).Click -= eventHandler;
			}
			_Label_ALERTS_STOCK = value;
			if (_Label_ALERTS_STOCK != null)
			{
				((Control)_Label_ALERTS_STOCK).Click += eventHandler;
			}
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

	internal virtual Label Label_STOCK_NEGATIF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_STOCK_NEGATIF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_STOCK_NEGATIF_Click;
			if (_Label_STOCK_NEGATIF != null)
			{
				((Control)_Label_STOCK_NEGATIF).Click -= eventHandler;
			}
			_Label_STOCK_NEGATIF = value;
			if (_Label_STOCK_NEGATIF != null)
			{
				((Control)_Label_STOCK_NEGATIF).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_GROUPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_GROUPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_GROUPE = value;
		}
	}

	internal virtual Label Label87
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label87 = value;
		}
	}

	internal virtual ComboBox Combo_GROUPES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_GROUPES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_GROUPES = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn26
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn26 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn27
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn27 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn28
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn28 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn29
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn29 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn30
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn30 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column10 = value;
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

	internal virtual TextBox Text_LIEN_PICTURE_ANC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LIEN_PICTURE_ANC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LIEN_PICTURE_ANC = value;
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

	internal virtual Label Label89
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label89 = value;
		}
	}

	internal virtual Label Label88
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label88 = value;
		}
	}

	internal virtual TextBox Text_PRIX_QTE_MIN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_QTE_MIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_PRIX_QTE_MIN_TextChanged;
			KeyPressEventHandler val = Text_PRIX_QTE_MIN_KeyPress;
			if (_Text_PRIX_QTE_MIN != null)
			{
				((Control)_Text_PRIX_QTE_MIN).TextChanged -= eventHandler;
				((Control)_Text_PRIX_QTE_MIN).KeyPress -= val;
			}
			_Text_PRIX_QTE_MIN = value;
			if (_Text_PRIX_QTE_MIN != null)
			{
				((Control)_Text_PRIX_QTE_MIN).TextChanged += eventHandler;
				((Control)_Text_PRIX_QTE_MIN).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_PRIX_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_PRIX_QTE_TextChanged;
			KeyPressEventHandler val = Text_PRIX_QTE_KeyPress;
			if (_Text_PRIX_QTE != null)
			{
				((Control)_Text_PRIX_QTE).TextChanged -= eventHandler;
				((Control)_Text_PRIX_QTE).KeyPress -= val;
			}
			_Text_PRIX_QTE = value;
			if (_Text_PRIX_QTE != null)
			{
				((Control)_Text_PRIX_QTE).TextChanged += eventHandler;
				((Control)_Text_PRIX_QTE).KeyPress += val;
			}
		}
	}

	internal virtual Label Label_PRIX_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PRIX_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_PRIX_QTE_Click;
			if (_Label_PRIX_QTE != null)
			{
				((Control)_Label_PRIX_QTE).Click -= eventHandler;
			}
			_Label_PRIX_QTE = value;
			if (_Label_PRIX_QTE != null)
			{
				((Control)_Label_PRIX_QTE).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label91
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label91 = value;
		}
	}

	public Form_2_ARTICLES()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Form)this).Load += Form_Me_Load;
		__ENCAddToList(this);
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		_DT_FAMILLE_FILTRAGE = new DataTable();
		_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter();
		newpoint = default;
		_FAMILLE_FILTRE = "";
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
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected Obj, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected Obj, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected Obj, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected Obj, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected Obj, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected Obj, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected Obj, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected Obj, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected Obj, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected Obj, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected Obj, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected Obj, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected Obj, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected Obj, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected Obj, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected Obj, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected Obj, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected Obj, but got Unknown
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected Obj, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected Obj, but got Unknown
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected Obj, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected Obj, but got Unknown
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected Obj, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected Obj, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected Obj, but got Unknown
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected Obj, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected Obj, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected Obj, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected Obj, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected Obj, but got Unknown
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected Obj, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected Obj, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected Obj, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected Obj, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected Obj, but got Unknown
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected Obj, but got Unknown
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected Obj, but got Unknown
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected Obj, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected Obj, but got Unknown
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Expected Obj, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected Obj, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Expected Obj, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected Obj, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected Obj, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected Obj, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected Obj, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected Obj, but got Unknown
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Obj, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected Obj, but got Unknown
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected Obj, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected Obj, but got Unknown
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected Obj, but got Unknown
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected Obj, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected Obj, but got Unknown
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected Obj, but got Unknown
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Obj, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected Obj, but got Unknown
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected Obj, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected Obj, but got Unknown
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected Obj, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected Obj, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected Obj, but got Unknown
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Expected Obj, but got Unknown
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected Obj, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected Obj, but got Unknown
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected Obj, but got Unknown
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected Obj, but got Unknown
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected Obj, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected Obj, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected Obj, but got Unknown
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Expected Obj, but got Unknown
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected Obj, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected Obj, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected Obj, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected Obj, but got Unknown
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected Obj, but got Unknown
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Expected Obj, but got Unknown
		//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected Obj, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected Obj, but got Unknown
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected Obj, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected Obj, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected Obj, but got Unknown
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected Obj, but got Unknown
		//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected Obj, but got Unknown
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected Obj, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected Obj, but got Unknown
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected Obj, but got Unknown
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected Obj, but got Unknown
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected Obj, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected Obj, but got Unknown
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected Obj, but got Unknown
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Expected Obj, but got Unknown
		//IL_0ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb2: Expected Obj, but got Unknown
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eca: Expected Obj, but got Unknown
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee2: Expected Obj, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected Obj, but got Unknown
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f06: Expected Obj, but got Unknown
		//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected Obj, but got Unknown
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected Obj, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Expected Obj, but got Unknown
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Expected Obj, but got Unknown
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f42: Expected Obj, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected Obj, but got Unknown
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected Obj, but got Unknown
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected Obj, but got Unknown
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected Obj, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected Obj, but got Unknown
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected Obj, but got Unknown
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fba: Expected Obj, but got Unknown
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected Obj, but got Unknown
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected Obj, but got Unknown
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Expected Obj, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected Obj, but got Unknown
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected Obj, but got Unknown
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected Obj, but got Unknown
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected Obj, but got Unknown
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected Obj, but got Unknown
		//IL_1028: Unknown result type (might be due to invalid IL or missing references)
		//IL_1032: Expected Obj, but got Unknown
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected Obj, but got Unknown
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Expected Obj, but got Unknown
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1056: Expected Obj, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected Obj, but got Unknown
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Expected Obj, but got Unknown
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected Obj, but got Unknown
		//IL_1094: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Expected Obj, but got Unknown
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Expected Obj, but got Unknown
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected Obj, but got Unknown
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Expected Obj, but got Unknown
		//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected Obj, but got Unknown
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10da: Expected Obj, but got Unknown
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Expected Obj, but got Unknown
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f2: Expected Obj, but got Unknown
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fe: Expected Obj, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected Obj, but got Unknown
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_1124: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Expected Obj, but got Unknown
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected Obj, but got Unknown
		//IL_11f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Expected Obj, but got Unknown
		//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Expected Obj, but got Unknown
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_1212: Expected Obj, but got Unknown
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Expected Obj, but got Unknown
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Expected Obj, but got Unknown
		//IL_122c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected Obj, but got Unknown
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_124e: Expected Obj, but got Unknown
		//IL_1250: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected Obj, but got Unknown
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1266: Expected Obj, but got Unknown
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Expected Obj, but got Unknown
		//IL_1274: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected Obj, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected Obj, but got Unknown
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a2: Expected Obj, but got Unknown
		//IL_12a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Expected Obj, but got Unknown
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ba: Expected Obj, but got Unknown
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c6: Expected Obj, but got Unknown
		//IL_12c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected Obj, but got Unknown
		//IL_12d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12de: Expected Obj, but got Unknown
		//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected Obj, but got Unknown
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f6: Expected Obj, but got Unknown
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected Obj, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected Obj, but got Unknown
		//IL_1310: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Expected Obj, but got Unknown
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326: Expected Obj, but got Unknown
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Expected Obj, but got Unknown
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e: Expected Obj, but got Unknown
		//IL_1340: Unknown result type (might be due to invalid IL or missing references)
		//IL_134a: Expected Obj, but got Unknown
		//IL_134c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected Obj, but got Unknown
		//IL_1358: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Expected Obj, but got Unknown
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_136e: Expected Obj, but got Unknown
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_137a: Expected Obj, but got Unknown
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected Obj, but got Unknown
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected Obj, but got Unknown
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected Obj, but got Unknown
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Expected Obj, but got Unknown
		//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Expected Obj, but got Unknown
		//IL_13c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected Obj, but got Unknown
		//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e6: Expected Obj, but got Unknown
		//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f2: Expected Obj, but got Unknown
		//IL_13f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fe: Expected Obj, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected Obj, but got Unknown
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected Obj, but got Unknown
		//IL_1418: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected Obj, but got Unknown
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_142e: Expected Obj, but got Unknown
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_143a: Expected Obj, but got Unknown
		//IL_143c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1446: Expected Obj, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_1452: Expected Obj, but got Unknown
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Expected Obj, but got Unknown
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Expected Obj, but got Unknown
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Expected Obj, but got Unknown
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected Obj, but got Unknown
		//IL_1484: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Expected Obj, but got Unknown
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_6969: Unknown result type (might be due to invalid IL or missing references)
		//IL_6973: Expected Obj, but got Unknown
		//IL_6a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a84: Expected Obj, but got Unknown
		//IL_9488: Unknown result type (might be due to invalid IL or missing references)
		//IL_9492: Expected Obj, but got Unknown
		//IL_94d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_94d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_a6fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_a704: Expected Obj, but got Unknown
		//IL_a757: Unknown result type (might be due to invalid IL or missing references)
		//IL_a761: Expected Obj, but got Unknown
		//IL_c4c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_c4cb: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_2_ARTICLES));
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
		Panel10 = new Panel();
		PictureBox30 = new PictureBox();
		PictureBox31 = new PictureBox();
		PictureBox32 = new PictureBox();
		PictureBox33 = new PictureBox();
		Label50 = new Label();
		PictureBox11 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox8 = new PictureBox();
		Label_VALEURSTOCK_A = new Label();
		Label41 = new Label();
		Label_VALEURSTOCK_A_NON = new Label();
		Panel7 = new Panel();
		PictureBox26 = new PictureBox();
		PictureBox27 = new PictureBox();
		PictureBox28 = new PictureBox();
		PictureBox29 = new PictureBox();
		Label48 = new Label();
		PictureBox7 = new PictureBox();
		PictureBox10 = new PictureBox();
		Label_VALEURSTOCK_MP = new Label();
		PictureBox6 = new PictureBox();
		Label16 = new Label();
		Label_VALEURSTOCK_MP_NON = new Label();
		Panel6 = new Panel();
		Label_PRIX_QTE = new Label();
		Label91 = new Label();
		Label_PROMOTIONS = new Label();
		Label13 = new Label();
		PictureBox22 = new PictureBox();
		PictureBox23 = new PictureBox();
		PictureBox24 = new PictureBox();
		PictureBox25 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox2 = new PictureBox();
		Label_ARTICLES = new Label();
		Label10 = new Label();
		Panel5 = new Panel();
		Button_CALC = new Button();
		PictureBox20 = new PictureBox();
		PictureBox21 = new PictureBox();
		PictureBox18 = new PictureBox();
		PictureBox19 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label18 = new Label();
		Label_ALERTS_STOCK = new Label();
		Label58 = new Label();
		Label_STOCK_NEGATIF = new Label();
		Label_TABLE = new Label();
		Panel_INFO = new Panel();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Panel8 = new Panel();
		Label89 = new Label();
		Label88 = new Label();
		Text_PRIX_QTE_MIN = new TextBox();
		Text_PRIX_QTE = new TextBox();
		Panel_GROUPE = new Panel();
		Label87 = new Label();
		Combo_GROUPES = new ComboBox();
		Text_CODE_RICHE = new RichTextBox();
		Panel_COULEUR = new Panel();
		Label47 = new Label();
		Label49 = new Label();
		Label51 = new Label();
		Label2 = new Label();
		Picture_COLOR_23 = new PictureBox();
		Picture_COLOR_22 = new PictureBox();
		Picture_COLOR_21 = new PictureBox();
		Picture_COLOR_20 = new PictureBox();
		Picture_COLOR_19 = new PictureBox();
		Picture_COLOR_18 = new PictureBox();
		Picture_COLOR_16 = new PictureBox();
		Picture_COLOR_15 = new PictureBox();
		Picture_COLOR_14 = new PictureBox();
		Picture_COLOR_13 = new PictureBox();
		Picture_COLOR_12 = new PictureBox();
		Picture_COLOR_11 = new PictureBox();
		Picture_COLOR_6 = new PictureBox();
		Picture_COLOR_10 = new PictureBox();
		Picture_COLOR_5 = new PictureBox();
		Picture_COLOR_1 = new PictureBox();
		Picture_COLOR_8 = new PictureBox();
		Picture_COLOR_9 = new PictureBox();
		Picture_COLOR_4 = new PictureBox();
		Picture_COLOR_3 = new PictureBox();
		Picture_COLOR_2 = new PictureBox();
		Label21 = new Label();
		Button9 = new Button();
		Panel_Picture_IMAGE_TOOLS = new Panel();
		Text_LIEN_PICTURE_ANC = new TextBox();
		Button35 = new Button();
		Button26 = new Button();
		Button27 = new Button();
		Text_LIEN_PICTURE = new TextBox();
		Button29 = new Button();
		Button30 = new Button();
		Button31 = new Button();
		Button24 = new Button();
		Panel_Picture_IMAGE = new Panel();
		Picture_IMAGE = new PictureBox();
		Label15 = new Label();
		Label25 = new Label();
		Text_ID = new TextBox();
		Text_PRIX_MP = new TextBox();
		Label23 = new Label();
		Label20 = new Label();
		Label24 = new Label();
		Label26 = new Label();
		Combo_FAMILLE = new ComboBox();
		Text_ALERT = new TextBox();
		Text_ARTICLE = new TextBox();
		Label19 = new Label();
		Text_STOCK = new TextBox();
		Text_PRIX_V = new TextBox();
		Button_GENERER = new Button();
		Text_PRIX_A = new TextBox();
		Text_CODE = new TextBox();
		Label27 = new Label();
		TabPage2 = new TabPage();
		Combo_BALANCE = new ComboBox();
		Label4 = new Label();
		Combo_FENETRE_PESEE = new ComboBox();
		Label29 = new Label();
		Text_ID_ARTICLE = new TextBox();
		Label70 = new Label();
		Label69 = new Label();
		Label11 = new Label();
		Text_PROMOTION = new TextBox();
		Label34 = new Label();
		Combo_PRINTER_DUPLICATA = new ComboBox();
		Label38 = new Label();
		Combo_PRINTER = new ComboBox();
		Combo_FOURNISSEUR = new ComboBox();
		Label32 = new Label();
		Label31 = new Label();
		Text_REFERENCE = new TextBox();
		Text_STOCK_INITIAL = new TextBox();
		Label42 = new Label();
		Text_DATE_INVENTAIRE = new TextBox();
		Label43 = new Label();
		Text_DATE_CREATION = new TextBox();
		Label44 = new Label();
		Combo_MODE_STOCK = new ComboBox();
		Label40 = new Label();
		Combo_UNITE = new ComboBox();
		Label37 = new Label();
		Label28 = new Label();
		Text_PRIX_V_2 = new TextBox();
		Label1 = new Label();
		Text_EMPLACEMENT = new TextBox();
		Label22 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		Label3 = new Label();
		Combo_TAUX_TVA = new ComboBox();
		Label7 = new Label();
		Text_DESCRIPTION = new TextBox();
		Combo_COULEURS = new ComboBox();
		Text_SOUS_FAMILLE = new TextBox();
		Combo_TAILLES = new ComboBox();
		Button85454 = new Button();
		Button73434 = new Button();
		Button1 = new Button();
		TabPage3 = new TabPage();
		Button_INVENTAIRES = new Button();
		Button_MOUVEMENTS = new Button();
		PictureBox14 = new PictureBox();
		Label30303 = new Label();
		Button_SORTIES = new Button();
		Button_VENTES = new Button();
		Button_RECEPTIONS = new Button();
		DateTimePicker1 = new DateTimePicker();
		DateTimePicker2 = new DateTimePicker();
		DataGrid_SORTIES = new DataGridView();
		DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
		DataGrid_VENTES = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		Client = new DataGridViewTextBoxColumn();
		DataGrid_MOUVEMENTS = new DataGridView();
		DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
		DataGrid_RECEPTIONS = new DataGridView();
		Dates = new DataGridViewTextBoxColumn();
		ID_BR = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Articles = new DataGridViewTextBoxColumn();
		Prix_AA = new DataGridViewTextBoxColumn();
		Qtéé = new DataGridViewTextBoxColumn();
		Fournisseur = new DataGridViewTextBoxColumn();
		DataGrid_INVENTAIRES = new DataGridView();
		DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewImageColumn();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		PRIX_A = new DataGridViewTextBoxColumn();
		PRIX_V_1 = new DataGridViewTextBoxColumn();
		STOCK = new DataGridViewTextBoxColumn();
		Alert = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		Panel_FONCTIONS = new Panel();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		Column10 = new DataGridViewTextBoxColumn();
		Button2 = new Button();
		Button_CANVA = new Button();
		Button_IMPORTER = new Button();
		Button_ETAT_LISTE_ARTICLES = new Button();
		PictureBox_ROBOT = new PictureBox();
		Button14 = new Button();
		Button_M_SHIFTS = new Button();
		Button_PROMOTION = new Button();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
		unité = new DataGridViewTextBoxColumn();
		departement = new DataGridViewTextBoxColumn();
		Button_FAMILLES = new Button();
		Text_BALANCE = new TextBox();
		Button3 = new Button();
		Button_ETAT_STOCK = new Button();
		Button_FERMER = new Button();
		Label17 = new Label();
		Button6 = new Button();
		Label33 = new Label();
		Label36 = new Label();
		Label39 = new Label();
		Button12 = new Button();
		Button_RAPPORT = new Button();
		Button_BALANCE = new Button();
		TextBox4 = new TextBox();
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel0 = new Panel();
		Button_ADD_COLLECTION = new Button();
		Panel_FIND = new Panel();
		Panel_DATES = new Panel();
		DateTime2_FIND = new DateTimePicker();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		PictureBox13 = new PictureBox();
		Combo_FIND = new BunifuDropdown();
		Picture_EXPORT = new Button_RJ();
		Label5 = new Label();
		Label9 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Button4 = new Button();
		Button_FONCTIONS = new Button();
		Button244 = new Button();
		Button_ADD = new Button();
		Panel13243 = new Panel();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		DataGridView_TRIAGE = new DataGridView();
		DataGridViewButtonColumn1 = new DataGridViewButtonColumn();
		Button10767 = new Button();
		Label61 = new Label();
		Label60 = new Label();
		Label59 = new Label();
		Label62 = new Label();
		Panel1233 = new Panel();
		Button11 = new Button();
		Label63 = new Label();
		TextBox154545 = new TextBox();
		Label68 = new Label();
		CheckedListBox1 = new CheckedListBox();
		CheckBox7 = new CheckBox();
		Button10 = new Button();
		Label64 = new Label();
		Label65 = new Label();
		Label66 = new Label();
		Label67 = new Label();
		TableLayoutPanel2 = new TableLayoutPanel();
		Panel9 = new Panel();
		PictureBox34 = new PictureBox();
		PictureBox35 = new PictureBox();
		PictureBox36 = new PictureBox();
		PictureBox37 = new PictureBox();
		Label52 = new Label();
		Label_VALEURSTOCK_V = new Label();
		PictureBox15 = new PictureBox();
		PictureBox16 = new PictureBox();
		PictureBox17 = new PictureBox();
		Label46 = new Label();
		Label_VALEURSTOCK_V_NON = new Label();
		Panel1 = new Panel();
		Panel_COLUMNS = new Panel();
		Button94545 = new Button();
		Button187878 = new Button();
		Label12 = new Label();
		Label14 = new Label();
		Label30 = new Label();
		Label45 = new Label();
		ListBox_COLUMNS = new ListBox();
		Panel119898 = new Panel();
		DataGridView_FILTRAGE = new DataGridView();
		DataGridViewButtonColumn2 = new DataGridViewButtonColumn();
		Panel2 = new Panel();
		Button_RJ38787 = new Button_RJ();
		Button_RJ16576 = new Button_RJ();
		Panel4 = new Panel();
		TextBox14343 = new TextBox();
		Label35 = new Label();
		Label71 = new Label();
		Label72 = new Label();
		Label73 = new Label();
		Panel_INFO_COLLECTION = new Panel();
		Button5 = new Button();
		Combo_FOURNISSEUR_COLLECTION = new ComboBox();
		Label86 = new Label();
		Text_REFERENCE_COLLECTION = new TextBox();
		Label77 = new Label();
		Label74 = new Label();
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
		Button_MOINS = new Button();
		Button_PLUS = new Button();
		Label81 = new Label();
		Text_QTE_COLLECTION = new TextBox();
		Button23233 = new Button();
		Button23232 = new Button();
		Panel3 = new Panel();
		Label_TOTAL_QUANTITE_DOC = new Label();
		Button_CALC_DOC = new Button();
		Label_NBR_ARTICLES_DOC = new Label();
		Label75 = new Label();
		Label76 = new Label();
		Label79 = new Label();
		Label80 = new Label();
		Label53 = new Label();
		Label54 = new Label();
		Button_INSERER = new Button();
		DataGridView_COULEURS = new DataGridView();
		CODE_COULEUR = new DataGridViewTextBoxColumn();
		COULEUR = new DataGridViewTextBoxColumn();
		DataGridView_TAILLES = new DataGridView();
		CODE_TAILLE = new DataGridViewTextBoxColumn();
		TAILLE = new DataGridViewTextBoxColumn();
		DataGrid_COLLECTION = new DataGridView();
		CODE_BARRE_LISTE = new DataGridViewTextBoxColumn();
		ARTICLE_LISTE = new DataGridViewTextBoxColumn();
		TAILLE_LISTE = new DataGridViewTextBoxColumn();
		COULEUR_LISTE = new DataGridViewTextBoxColumn();
		Qté_LISTE = new DataGridViewTextBoxColumn();
		sup = new DataGridViewImageColumn();
		Label55 = new Label();
		Label56 = new Label();
		Label57 = new Label();
		Label78 = new Label();
		Label_TOP_COLLECTION = new Label();
		Label82 = new Label();
		Label83 = new Label();
		Button_CLOSE_COLLECTION = new Button();
		Combo_FAMILLE_COLLECTION = new ComboBox();
		Button_SAVE_COLLECTION = new Button();
		Text_ARTICLE_COLLECTION = new TextBox();
		Button_CLAVIER_NOSELECT212 = new Button_CLAVIER_NOSELECT();
		Label84 = new Label();
		Label85 = new Label();
		Text_PRIX_V_COLLECTION = new TextBox();
		Text_CODE_COLLECTION = new TextBox();
		Button_GENERER_COLLECTION = new Button();
		Text_PRIX_A_COLLECTION = new TextBox();
		TextBox_AJOUT_STOCK_MANUEL = new TextBox();
		TextBox_MODIF_STOCK_MANUEL = new TextBox();
		TextBox_NBR_CODE_BALANCE = new TextBox();
		TextBox_NBR_CODE_ARTICLE = new TextBox();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Button20 = new Button();
		Picture_GREEN = new PictureBox();
		Picture_BLUE = new PictureBox();
		Picture_RED = new PictureBox();
		((Control)Panel10).SuspendLayout();
		((ISupportInitialize)PictureBox30).BeginInit();
		((ISupportInitialize)PictureBox31).BeginInit();
		((ISupportInitialize)PictureBox32).BeginInit();
		((ISupportInitialize)PictureBox33).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((Control)Panel7).SuspendLayout();
		((ISupportInitialize)PictureBox26).BeginInit();
		((ISupportInitialize)PictureBox27).BeginInit();
		((ISupportInitialize)PictureBox28).BeginInit();
		((ISupportInitialize)PictureBox29).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)Panel6).SuspendLayout();
		((ISupportInitialize)PictureBox22).BeginInit();
		((ISupportInitialize)PictureBox23).BeginInit();
		((ISupportInitialize)PictureBox24).BeginInit();
		((ISupportInitialize)PictureBox25).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((ISupportInitialize)PictureBox18).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((Control)Panel_GROUPE).SuspendLayout();
		((Control)Panel_COULEUR).SuspendLayout();
		((ISupportInitialize)Picture_COLOR_23).BeginInit();
		((ISupportInitialize)Picture_COLOR_22).BeginInit();
		((ISupportInitialize)Picture_COLOR_21).BeginInit();
		((ISupportInitialize)Picture_COLOR_20).BeginInit();
		((ISupportInitialize)Picture_COLOR_19).BeginInit();
		((ISupportInitialize)Picture_COLOR_18).BeginInit();
		((ISupportInitialize)Picture_COLOR_16).BeginInit();
		((ISupportInitialize)Picture_COLOR_15).BeginInit();
		((ISupportInitialize)Picture_COLOR_14).BeginInit();
		((ISupportInitialize)Picture_COLOR_13).BeginInit();
		((ISupportInitialize)Picture_COLOR_12).BeginInit();
		((ISupportInitialize)Picture_COLOR_11).BeginInit();
		((ISupportInitialize)Picture_COLOR_6).BeginInit();
		((ISupportInitialize)Picture_COLOR_10).BeginInit();
		((ISupportInitialize)Picture_COLOR_5).BeginInit();
		((ISupportInitialize)Picture_COLOR_1).BeginInit();
		((ISupportInitialize)Picture_COLOR_8).BeginInit();
		((ISupportInitialize)Picture_COLOR_9).BeginInit();
		((ISupportInitialize)Picture_COLOR_4).BeginInit();
		((ISupportInitialize)Picture_COLOR_3).BeginInit();
		((ISupportInitialize)Picture_COLOR_2).BeginInit();
		((Control)Panel_Picture_IMAGE_TOOLS).SuspendLayout();
		((Control)Panel_Picture_IMAGE).SuspendLayout();
		((ISupportInitialize)Picture_IMAGE).BeginInit();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)DataGrid_SORTIES).BeginInit();
		((ISupportInitialize)DataGrid_VENTES).BeginInit();
		((ISupportInitialize)DataGrid_MOUVEMENTS).BeginInit();
		((ISupportInitialize)DataGrid_RECEPTIONS).BeginInit();
		((ISupportInitialize)DataGrid_INVENTAIRES).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)PictureBox_ROBOT).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel0).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)Panel13243).SuspendLayout();
		((ISupportInitialize)DataGridView_TRIAGE).BeginInit();
		((Control)Panel1233).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)Panel9).SuspendLayout();
		((ISupportInitialize)PictureBox34).BeginInit();
		((ISupportInitialize)PictureBox35).BeginInit();
		((ISupportInitialize)PictureBox36).BeginInit();
		((ISupportInitialize)PictureBox37).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox16).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)Panel_COLUMNS).SuspendLayout();
		((Control)Panel119898).SuspendLayout();
		((ISupportInitialize)DataGridView_FILTRAGE).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel_INFO_COLLECTION).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)DataGridView_COULEURS).BeginInit();
		((ISupportInitialize)DataGridView_TAILLES).BeginInit();
		((ISupportInitialize)DataGrid_COLLECTION).BeginInit();
		((ISupportInitialize)Picture_GREEN).BeginInit();
		((ISupportInitialize)Picture_BLUE).BeginInit();
		((ISupportInitialize)Picture_RED).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel10).BackColor = Color.FromArgb(42, 187, 167);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox30);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox31);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox32);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox33);
		((Control)Panel10).Controls.Add((Control)(object)Label50);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel10).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel10).Controls.Add((Control)(object)Label_VALEURSTOCK_A);
		((Control)Panel10).Controls.Add((Control)(object)Label41);
		((Control)Panel10).Controls.Add((Control)(object)Label_VALEURSTOCK_A_NON);
		componentResourceManager.ApplyResources(Panel10, "Panel10");
		((Control)Panel10).ForeColor = Color.FromArgb(214, 214, 214);
		((Control)Panel10).Name = "Panel10";
		componentResourceManager.ApplyResources(PictureBox30, "PictureBox30");
		((Control)PictureBox30).Name = "PictureBox30";
		PictureBox30.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox31, "PictureBox31");
		((Control)PictureBox31).Name = "PictureBox31";
		PictureBox31.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox32, "PictureBox32");
		((Control)PictureBox32).Name = "PictureBox32";
		PictureBox32.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox33, "PictureBox33");
		((Control)PictureBox33).Name = "PictureBox33";
		PictureBox33.TabStop = false;
		((Control)Label50).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label50, "Label50");
		((Control)Label50).ForeColor = Color.WhiteSmoke;
		((Control)Label50).Name = "Label50";
		componentResourceManager.ApplyResources(PictureBox11, "PictureBox11");
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox11.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox12, "PictureBox12");
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox12.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox8, "PictureBox8");
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox8.TabStop = false;
		((Control)Label_VALEURSTOCK_A).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_A).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_A, "Label_VALEURSTOCK_A");
		((Control)Label_VALEURSTOCK_A).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_A).Name = "Label_VALEURSTOCK_A";
		((Control)Label41).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label41, "Label41");
		((Control)Label41).ForeColor = Color.WhiteSmoke;
		((Control)Label41).Name = "Label41";
		((Control)Label_VALEURSTOCK_A_NON).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_A_NON).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_A_NON, "Label_VALEURSTOCK_A_NON");
		((Control)Label_VALEURSTOCK_A_NON).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_A_NON).Name = "Label_VALEURSTOCK_A_NON";
		((Control)Panel7).BackColor = Color.FromArgb(24, 119, 242);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox26);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox27);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox28);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox29);
		((Control)Panel7).Controls.Add((Control)(object)Label48);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel7).Controls.Add((Control)(object)Label_VALEURSTOCK_MP);
		((Control)Panel7).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel7).Controls.Add((Control)(object)Label16);
		((Control)Panel7).Controls.Add((Control)(object)Label_VALEURSTOCK_MP_NON);
		componentResourceManager.ApplyResources(Panel7, "Panel7");
		((Control)Panel7).ForeColor = Color.FromArgb(214, 214, 214);
		((Control)Panel7).Name = "Panel7";
		componentResourceManager.ApplyResources(PictureBox26, "PictureBox26");
		((Control)PictureBox26).Name = "PictureBox26";
		PictureBox26.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox27, "PictureBox27");
		((Control)PictureBox27).Name = "PictureBox27";
		PictureBox27.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox28, "PictureBox28");
		((Control)PictureBox28).Name = "PictureBox28";
		PictureBox28.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox29, "PictureBox29");
		((Control)PictureBox29).Name = "PictureBox29";
		PictureBox29.TabStop = false;
		((Control)Label48).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label48, "Label48");
		((Control)Label48).ForeColor = Color.WhiteSmoke;
		((Control)Label48).Name = "Label48";
		componentResourceManager.ApplyResources(PictureBox7, "PictureBox7");
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox7.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox10, "PictureBox10");
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox10.TabStop = false;
		((Control)Label_VALEURSTOCK_MP).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_MP).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_MP, "Label_VALEURSTOCK_MP");
		((Control)Label_VALEURSTOCK_MP).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_MP).Name = "Label_VALEURSTOCK_MP";
		componentResourceManager.ApplyResources(PictureBox6, "PictureBox6");
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox6.TabStop = false;
		((Control)Label16).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label16, "Label16");
		((Control)Label16).ForeColor = Color.WhiteSmoke;
		((Control)Label16).Name = "Label16";
		((Control)Label_VALEURSTOCK_MP_NON).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_MP_NON).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_MP_NON, "Label_VALEURSTOCK_MP_NON");
		((Control)Label_VALEURSTOCK_MP_NON).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_MP_NON).Name = "Label_VALEURSTOCK_MP_NON";
		((Control)Panel6).BackColor = Color.FromArgb(255, 152, 1);
		((Control)Panel6).Controls.Add((Control)(object)Label_PRIX_QTE);
		((Control)Panel6).Controls.Add((Control)(object)Label91);
		((Control)Panel6).Controls.Add((Control)(object)Label_PROMOTIONS);
		((Control)Panel6).Controls.Add((Control)(object)Label13);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox22);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox23);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox24);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox25);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox2);
		componentResourceManager.ApplyResources(Panel6, "Panel6");
		((Control)Panel6).ForeColor = Color.FromArgb(214, 214, 214);
		((Control)Panel6).Name = "Panel6";
		((Control)Label_PRIX_QTE).BackColor = Color.Transparent;
		((Control)Label_PRIX_QTE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_PRIX_QTE, "Label_PRIX_QTE");
		((Control)Label_PRIX_QTE).ForeColor = Color.WhiteSmoke;
		((Control)Label_PRIX_QTE).Name = "Label_PRIX_QTE";
		((Control)Label91).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label91, "Label91");
		((Control)Label91).ForeColor = Color.WhiteSmoke;
		((Control)Label91).Name = "Label91";
		((Control)Label_PROMOTIONS).BackColor = Color.Transparent;
		((Control)Label_PROMOTIONS).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_PROMOTIONS, "Label_PROMOTIONS");
		((Control)Label_PROMOTIONS).ForeColor = Color.WhiteSmoke;
		((Control)Label_PROMOTIONS).Name = "Label_PROMOTIONS";
		((Control)Label13).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label13, "Label13");
		((Control)Label13).ForeColor = Color.WhiteSmoke;
		((Control)Label13).Name = "Label13";
		componentResourceManager.ApplyResources(PictureBox22, "PictureBox22");
		((Control)PictureBox22).Name = "PictureBox22";
		PictureBox22.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox23, "PictureBox23");
		((Control)PictureBox23).Name = "PictureBox23";
		PictureBox23.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox24, "PictureBox24");
		((Control)PictureBox24).Name = "PictureBox24";
		PictureBox24.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox25, "PictureBox25");
		((Control)PictureBox25).Name = "PictureBox25";
		PictureBox25.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox5, "PictureBox5");
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox5.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox4, "PictureBox4");
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox4.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		((Control)Label_ARTICLES).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_ARTICLES, "Label_ARTICLES");
		((Control)Label_ARTICLES).ForeColor = Color.WhiteSmoke;
		((Control)Label_ARTICLES).Name = "Label_ARTICLES";
		((Control)Label10).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.WhiteSmoke;
		((Control)Label10).Name = "Label10";
		((Control)Panel5).BackColor = Color.FromArgb(240, 40, 74);
		((Control)Panel5).Controls.Add((Control)(object)Button_CALC);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox20);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox21);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox18);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel5).Controls.Add((Control)(object)Label_ARTICLES);
		((Control)Panel5).Controls.Add((Control)(object)Label10);
		((Control)Panel5).Controls.Add((Control)(object)Label18);
		((Control)Panel5).Controls.Add((Control)(object)Label_ALERTS_STOCK);
		((Control)Panel5).Controls.Add((Control)(object)Label58);
		((Control)Panel5).Controls.Add((Control)(object)Label_STOCK_NEGATIF);
		componentResourceManager.ApplyResources(Panel5, "Panel5");
		((Control)Panel5).ForeColor = Color.FromArgb(214, 214, 214);
		((Control)Panel5).Name = "Panel5";
		((Control)Button_CALC).ForeColor = Color.Red;
		componentResourceManager.ApplyResources(Button_CALC, "Button_CALC");
		((Control)Button_CALC).Name = "Button_CALC";
		((ButtonBase)Button_CALC).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(PictureBox20, "PictureBox20");
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox20.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox21, "PictureBox21");
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox21.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox18, "PictureBox18");
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox18.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox19, "PictureBox19");
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox19.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox9, "PictureBox9");
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox9.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox1, "PictureBox1");
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox1.TabStop = false;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Cursor = Cursors.Default;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).ForeColor = Color.WhiteSmoke;
		((Control)Label18).Name = "Label18";
		((Control)Label_ALERTS_STOCK).BackColor = Color.Transparent;
		((Control)Label_ALERTS_STOCK).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_ALERTS_STOCK, "Label_ALERTS_STOCK");
		((Control)Label_ALERTS_STOCK).ForeColor = Color.WhiteSmoke;
		((Control)Label_ALERTS_STOCK).Name = "Label_ALERTS_STOCK";
		((Control)Label58).BackColor = Color.Transparent;
		((Control)Label58).Cursor = Cursors.Default;
		componentResourceManager.ApplyResources(Label58, "Label58");
		((Control)Label58).ForeColor = Color.WhiteSmoke;
		((Control)Label58).Name = "Label58";
		((Control)Label_STOCK_NEGATIF).BackColor = Color.Transparent;
		((Control)Label_STOCK_NEGATIF).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_STOCK_NEGATIF, "Label_STOCK_NEGATIF");
		((Control)Label_STOCK_NEGATIF).ForeColor = Color.WhiteSmoke;
		((Control)Label_STOCK_NEGATIF).Name = "Label_STOCK_NEGATIF";
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_TABLE, "Label_TABLE");
		((Control)Label_TABLE).ForeColor = Color.White;
		((Control)Label_TABLE).Name = "Label_TABLE";
		componentResourceManager.ApplyResources(Panel_INFO, "Panel_INFO");
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_INFO).Name = "Panel_INFO";
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
		componentResourceManager.ApplyResources(Button_CLAVIER, "Button_CLAVIER");
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage3);
		componentResourceManager.ApplyResources(TabControl1, "TabControl1");
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Panel8);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_GROUPE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CODE_RICHE);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_COULEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label21);
		((Control)TabPage1).Controls.Add((Control)(object)Button9);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_Picture_IMAGE_TOOLS);
		((Control)TabPage1).Controls.Add((Control)(object)Button24);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_Picture_IMAGE);
		((Control)TabPage1).Controls.Add((Control)(object)Label15);
		((Control)TabPage1).Controls.Add((Control)(object)Label25);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage1).Controls.Add((Control)(object)Text_PRIX_MP);
		((Control)TabPage1).Controls.Add((Control)(object)Label23);
		((Control)TabPage1).Controls.Add((Control)(object)Label20);
		((Control)TabPage1).Controls.Add((Control)(object)Label24);
		((Control)TabPage1).Controls.Add((Control)(object)Label26);
		((Control)TabPage1).Controls.Add((Control)(object)Combo_FAMILLE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ALERT);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ARTICLE);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)Text_STOCK);
		((Control)TabPage1).Controls.Add((Control)(object)Text_PRIX_V);
		((Control)TabPage1).Controls.Add((Control)(object)Button_GENERER);
		((Control)TabPage1).Controls.Add((Control)(object)Text_PRIX_A);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CODE);
		((Control)TabPage1).Controls.Add((Control)(object)Label27);
		componentResourceManager.ApplyResources(TabPage1, "TabPage1");
		((Control)TabPage1).Name = "TabPage1";
		((Control)Panel8).BackColor = Color.SpringGreen;
		((Control)Panel8).Controls.Add((Control)(object)Label89);
		((Control)Panel8).Controls.Add((Control)(object)Label88);
		((Control)Panel8).Controls.Add((Control)(object)Text_PRIX_QTE_MIN);
		((Control)Panel8).Controls.Add((Control)(object)Text_PRIX_QTE);
		componentResourceManager.ApplyResources(Panel8, "Panel8");
		((Control)Panel8).Name = "Panel8";
		((Control)Label89).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label89, "Label89");
		((Control)Label89).ForeColor = Color.Black;
		((Control)Label89).Name = "Label89";
		((Control)Label88).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label88, "Label88");
		((Control)Label88).ForeColor = Color.Black;
		((Control)Label88).Name = "Label88";
		componentResourceManager.ApplyResources(Text_PRIX_QTE_MIN, "Text_PRIX_QTE_MIN");
		((Control)Text_PRIX_QTE_MIN).Name = "Text_PRIX_QTE_MIN";
		componentResourceManager.ApplyResources(Text_PRIX_QTE, "Text_PRIX_QTE");
		((Control)Text_PRIX_QTE).Name = "Text_PRIX_QTE";
		((Control)Panel_GROUPE).Controls.Add((Control)(object)Label87);
		((Control)Panel_GROUPE).Controls.Add((Control)(object)Combo_GROUPES);
		componentResourceManager.ApplyResources(Panel_GROUPE, "Panel_GROUPE");
		((Control)Panel_GROUPE).Name = "Panel_GROUPE";
		((Control)Label87).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label87, "Label87");
		((Control)Label87).ForeColor = Color.Black;
		((Control)Label87).Name = "Label87";
		Combo_GROUPES.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_GROUPES, "Combo_GROUPES");
		((ListControl)Combo_GROUPES).FormattingEnabled = true;
		((Control)Combo_GROUPES).Name = "Combo_GROUPES";
		((TextBoxBase)Text_CODE_RICHE).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_CODE_RICHE).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_CODE_RICHE, "Text_CODE_RICHE");
		((Control)Text_CODE_RICHE).Name = "Text_CODE_RICHE";
		componentResourceManager.ApplyResources(Panel_COULEUR, "Panel_COULEUR");
		Panel_COULEUR.BorderStyle = (BorderStyle)1;
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label47);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label49);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label51);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label2);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_23);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_22);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_21);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_20);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_19);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_18);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_16);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_15);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_14);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_13);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_12);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_11);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_6);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_10);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_5);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_1);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_8);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_9);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_4);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_3);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_2);
		((Control)Panel_COULEUR).Name = "Panel_COULEUR";
		((Control)Label47).BackColor = Color.Black;
		((Control)Label47).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label47, "Label47");
		((Control)Label47).ForeColor = Color.White;
		((Control)Label47).Name = "Label47";
		((Control)Label49).BackColor = Color.Black;
		((Control)Label49).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label49, "Label49");
		((Control)Label49).ForeColor = Color.White;
		((Control)Label49).Name = "Label49";
		((Control)Label51).BackColor = Color.Black;
		((Control)Label51).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label51, "Label51");
		((Control)Label51).ForeColor = Color.White;
		((Control)Label51).Name = "Label51";
		((Control)Label2).BackColor = Color.Black;
		((Control)Label2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).ForeColor = Color.White;
		((Control)Label2).Name = "Label2";
		((Control)Picture_COLOR_23).BackColor = Color.Black;
		componentResourceManager.ApplyResources(Picture_COLOR_23, "Picture_COLOR_23");
		((Control)Picture_COLOR_23).Name = "Picture_COLOR_23";
		Picture_COLOR_23.TabStop = false;
		((Control)Picture_COLOR_22).BackColor = Color.LightGray;
		componentResourceManager.ApplyResources(Picture_COLOR_22, "Picture_COLOR_22");
		((Control)Picture_COLOR_22).Name = "Picture_COLOR_22";
		Picture_COLOR_22.TabStop = false;
		((Control)Picture_COLOR_21).BackColor = Color.Crimson;
		componentResourceManager.ApplyResources(Picture_COLOR_21, "Picture_COLOR_21");
		((Control)Picture_COLOR_21).Name = "Picture_COLOR_21";
		Picture_COLOR_21.TabStop = false;
		((Control)Picture_COLOR_20).BackColor = Color.MediumVioletRed;
		componentResourceManager.ApplyResources(Picture_COLOR_20, "Picture_COLOR_20");
		((Control)Picture_COLOR_20).Name = "Picture_COLOR_20";
		Picture_COLOR_20.TabStop = false;
		((Control)Picture_COLOR_19).BackColor = Color.DarkTurquoise;
		componentResourceManager.ApplyResources(Picture_COLOR_19, "Picture_COLOR_19");
		((Control)Picture_COLOR_19).Name = "Picture_COLOR_19";
		Picture_COLOR_19.TabStop = false;
		((Control)Picture_COLOR_18).BackColor = Color.Aquamarine;
		componentResourceManager.ApplyResources(Picture_COLOR_18, "Picture_COLOR_18");
		((Control)Picture_COLOR_18).Name = "Picture_COLOR_18";
		Picture_COLOR_18.TabStop = false;
		((Control)Picture_COLOR_16).BackColor = Color.MediumOrchid;
		componentResourceManager.ApplyResources(Picture_COLOR_16, "Picture_COLOR_16");
		((Control)Picture_COLOR_16).Name = "Picture_COLOR_16";
		Picture_COLOR_16.TabStop = false;
		((Control)Picture_COLOR_15).BackColor = Color.Chartreuse;
		componentResourceManager.ApplyResources(Picture_COLOR_15, "Picture_COLOR_15");
		((Control)Picture_COLOR_15).Name = "Picture_COLOR_15";
		Picture_COLOR_15.TabStop = false;
		((Control)Picture_COLOR_14).BackColor = Color.Olive;
		componentResourceManager.ApplyResources(Picture_COLOR_14, "Picture_COLOR_14");
		((Control)Picture_COLOR_14).Name = "Picture_COLOR_14";
		Picture_COLOR_14.TabStop = false;
		((Control)Picture_COLOR_13).BackColor = Color.Yellow;
		componentResourceManager.ApplyResources(Picture_COLOR_13, "Picture_COLOR_13");
		((Control)Picture_COLOR_13).Name = "Picture_COLOR_13";
		Picture_COLOR_13.TabStop = false;
		((Control)Picture_COLOR_12).BackColor = Color.Orange;
		componentResourceManager.ApplyResources(Picture_COLOR_12, "Picture_COLOR_12");
		((Control)Picture_COLOR_12).Name = "Picture_COLOR_12";
		Picture_COLOR_12.TabStop = false;
		((Control)Picture_COLOR_11).BackColor = Color.Fuchsia;
		componentResourceManager.ApplyResources(Picture_COLOR_11, "Picture_COLOR_11");
		((Control)Picture_COLOR_11).Name = "Picture_COLOR_11";
		Picture_COLOR_11.TabStop = false;
		((Control)Picture_COLOR_6).BackColor = Color.DeepPink;
		componentResourceManager.ApplyResources(Picture_COLOR_6, "Picture_COLOR_6");
		((Control)Picture_COLOR_6).Name = "Picture_COLOR_6";
		Picture_COLOR_6.TabStop = false;
		((Control)Picture_COLOR_10).BackColor = Color.FromArgb(52, 73, 94);
		componentResourceManager.ApplyResources(Picture_COLOR_10, "Picture_COLOR_10");
		((Control)Picture_COLOR_10).Name = "Picture_COLOR_10";
		Picture_COLOR_10.TabStop = false;
		((Control)Picture_COLOR_5).BackColor = Color.FromArgb(149, 165, 166);
		componentResourceManager.ApplyResources(Picture_COLOR_5, "Picture_COLOR_5");
		((Control)Picture_COLOR_5).Name = "Picture_COLOR_5";
		Picture_COLOR_5.TabStop = false;
		((Control)Picture_COLOR_1).BackColor = Color.White;
		componentResourceManager.ApplyResources(Picture_COLOR_1, "Picture_COLOR_1");
		((Control)Picture_COLOR_1).Name = "Picture_COLOR_1";
		Picture_COLOR_1.TabStop = false;
		((Control)Picture_COLOR_8).BackColor = Color.Red;
		componentResourceManager.ApplyResources(Picture_COLOR_8, "Picture_COLOR_8");
		((Control)Picture_COLOR_8).Name = "Picture_COLOR_8";
		Picture_COLOR_8.TabStop = false;
		((Control)Picture_COLOR_9).BackColor = Color.Tomato;
		componentResourceManager.ApplyResources(Picture_COLOR_9, "Picture_COLOR_9");
		((Control)Picture_COLOR_9).Name = "Picture_COLOR_9";
		Picture_COLOR_9.TabStop = false;
		((Control)Picture_COLOR_4).BackColor = Color.DodgerBlue;
		componentResourceManager.ApplyResources(Picture_COLOR_4, "Picture_COLOR_4");
		((Control)Picture_COLOR_4).Name = "Picture_COLOR_4";
		Picture_COLOR_4.TabStop = false;
		((Control)Picture_COLOR_3).BackColor = Color.FromArgb(230, 126, 34);
		componentResourceManager.ApplyResources(Picture_COLOR_3, "Picture_COLOR_3");
		((Control)Picture_COLOR_3).Name = "Picture_COLOR_3";
		Picture_COLOR_3.TabStop = false;
		((Control)Picture_COLOR_2).BackColor = Color.FromArgb(46, 204, 113);
		componentResourceManager.ApplyResources(Picture_COLOR_2, "Picture_COLOR_2");
		((Control)Picture_COLOR_2).Name = "Picture_COLOR_2";
		Picture_COLOR_2.TabStop = false;
		((Control)Label21).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label21, "Label21");
		((Control)Label21).ForeColor = Color.Black;
		((Control)Label21).Name = "Label21";
		((ButtonBase)Button9).BackColor = Color.Transparent;
		((Control)Button9).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button9, "Button9");
		((Control)Button9).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button9).Name = "Button9";
		((ButtonBase)Button9).UseVisualStyleBackColor = false;
		Panel_Picture_IMAGE_TOOLS.BorderStyle = (BorderStyle)1;
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Text_LIEN_PICTURE_ANC);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button35);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button26);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button27);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Text_LIEN_PICTURE);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button29);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button30);
		((Control)Panel_Picture_IMAGE_TOOLS).Controls.Add((Control)(object)Button31);
		componentResourceManager.ApplyResources(Panel_Picture_IMAGE_TOOLS, "Panel_Picture_IMAGE_TOOLS");
		((Control)Panel_Picture_IMAGE_TOOLS).Name = "Panel_Picture_IMAGE_TOOLS";
		((TextBoxBase)Text_LIEN_PICTURE_ANC).BackColor = Color.FromArgb(249, 249, 249);
		((TextBoxBase)Text_LIEN_PICTURE_ANC).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_LIEN_PICTURE_ANC, "Text_LIEN_PICTURE_ANC");
		((Control)Text_LIEN_PICTURE_ANC).Name = "Text_LIEN_PICTURE_ANC";
		componentResourceManager.ApplyResources(Button35, "Button35");
		((Control)Button35).Name = "Button35";
		((ButtonBase)Button35).UseVisualStyleBackColor = true;
		((Control)Button26).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button26, "Button26");
		((Control)Button26).Name = "Button26";
		((ButtonBase)Button26).UseVisualStyleBackColor = true;
		((Control)Button27).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button27, "Button27");
		((Control)Button27).Name = "Button27";
		((ButtonBase)Button27).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_LIEN_PICTURE).BackColor = Color.FromArgb(249, 249, 249);
		((TextBoxBase)Text_LIEN_PICTURE).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_LIEN_PICTURE, "Text_LIEN_PICTURE");
		((Control)Text_LIEN_PICTURE).Name = "Text_LIEN_PICTURE";
		((Control)Button29).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button29, "Button29");
		((Control)Button29).Name = "Button29";
		((ButtonBase)Button29).UseVisualStyleBackColor = true;
		((Control)Button30).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button30, "Button30");
		((Control)Button30).Name = "Button30";
		((ButtonBase)Button30).UseVisualStyleBackColor = true;
		((Control)Button31).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button31, "Button31");
		((Control)Button31).Name = "Button31";
		((ButtonBase)Button31).UseVisualStyleBackColor = true;
		((ButtonBase)Button24).BackColor = Color.Transparent;
		((Control)Button24).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button24, "Button24");
		((Control)Button24).ForeColor = Color.Green;
		((Control)Button24).Name = "Button24";
		((ButtonBase)Button24).UseVisualStyleBackColor = false;
		Panel_Picture_IMAGE.BorderStyle = (BorderStyle)1;
		((Control)Panel_Picture_IMAGE).Controls.Add((Control)(object)Picture_IMAGE);
		componentResourceManager.ApplyResources(Panel_Picture_IMAGE, "Panel_Picture_IMAGE");
		((Control)Panel_Picture_IMAGE).Name = "Panel_Picture_IMAGE";
		((Control)Picture_IMAGE).BackColor = Color.White;
		componentResourceManager.ApplyResources(Picture_IMAGE, "Picture_IMAGE");
		((Control)Picture_IMAGE).Name = "Picture_IMAGE";
		Picture_IMAGE.TabStop = false;
		((Control)Label15).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label15, "Label15");
		((Control)Label15).ForeColor = Color.Black;
		((Control)Label15).Name = "Label15";
		((Control)Label25).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label25, "Label25");
		((Control)Label25).ForeColor = Color.Black;
		((Control)Label25).Name = "Label25";
		((TextBoxBase)Text_ID).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_ID, "Text_ID");
		((Control)Text_ID).Name = "Text_ID";
		componentResourceManager.ApplyResources(Text_PRIX_MP, "Text_PRIX_MP");
		((Control)Text_PRIX_MP).Name = "Text_PRIX_MP";
		((Control)Label23).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label23, "Label23");
		((Control)Label23).ForeColor = Color.Black;
		((Control)Label23).Name = "Label23";
		((Control)Label20).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label20, "Label20");
		((Control)Label20).ForeColor = Color.Black;
		((Control)Label20).Name = "Label20";
		((Control)Label24).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label24, "Label24");
		((Control)Label24).ForeColor = Color.Black;
		((Control)Label24).Name = "Label24";
		((Control)Label26).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label26, "Label26");
		((Control)Label26).ForeColor = Color.Black;
		((Control)Label26).Name = "Label26";
		Combo_FAMILLE.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_FAMILLE.AutoCompleteSource = (AutoCompleteSource)256;
		Combo_FAMILLE.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_FAMILLE, "Combo_FAMILLE");
		((ListControl)Combo_FAMILLE).FormattingEnabled = true;
		((Control)Combo_FAMILLE).Name = "Combo_FAMILLE";
		componentResourceManager.ApplyResources(Text_ALERT, "Text_ALERT");
		((Control)Text_ALERT).Name = "Text_ALERT";
		componentResourceManager.ApplyResources(Text_ARTICLE, "Text_ARTICLE");
		((Control)Text_ARTICLE).Name = "Text_ARTICLE";
		((Control)Label19).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label19, "Label19");
		((Control)Label19).ForeColor = Color.Black;
		((Control)Label19).Name = "Label19";
		componentResourceManager.ApplyResources(Text_STOCK, "Text_STOCK");
		((Control)Text_STOCK).Name = "Text_STOCK";
		componentResourceManager.ApplyResources(Text_PRIX_V, "Text_PRIX_V");
		((Control)Text_PRIX_V).Name = "Text_PRIX_V";
		((ButtonBase)Button_GENERER).BackColor = Color.Transparent;
		((Control)Button_GENERER).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_GENERER, "Button_GENERER");
		((Control)Button_GENERER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_GENERER).Name = "Button_GENERER";
		((ButtonBase)Button_GENERER).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_PRIX_A, "Text_PRIX_A");
		((Control)Text_PRIX_A).Name = "Text_PRIX_A";
		componentResourceManager.ApplyResources(Text_CODE, "Text_CODE");
		((Control)Text_CODE).Name = "Text_CODE";
		((Control)Label27).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).ForeColor = Color.Black;
		((Control)Label27).Name = "Label27";
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Combo_BALANCE);
		((Control)TabPage2).Controls.Add((Control)(object)Label4);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_FENETRE_PESEE);
		((Control)TabPage2).Controls.Add((Control)(object)Label29);
		((Control)TabPage2).Controls.Add((Control)(object)Text_ID_ARTICLE);
		((Control)TabPage2).Controls.Add((Control)(object)Label70);
		((Control)TabPage2).Controls.Add((Control)(object)Label69);
		((Control)TabPage2).Controls.Add((Control)(object)Label11);
		((Control)TabPage2).Controls.Add((Control)(object)Text_PROMOTION);
		((Control)TabPage2).Controls.Add((Control)(object)Label34);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_PRINTER_DUPLICATA);
		((Control)TabPage2).Controls.Add((Control)(object)Label38);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_PRINTER);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_FOURNISSEUR);
		((Control)TabPage2).Controls.Add((Control)(object)Label32);
		((Control)TabPage2).Controls.Add((Control)(object)Label31);
		((Control)TabPage2).Controls.Add((Control)(object)Text_REFERENCE);
		((Control)TabPage2).Controls.Add((Control)(object)Text_STOCK_INITIAL);
		((Control)TabPage2).Controls.Add((Control)(object)Label42);
		((Control)TabPage2).Controls.Add((Control)(object)Text_DATE_INVENTAIRE);
		((Control)TabPage2).Controls.Add((Control)(object)Label43);
		((Control)TabPage2).Controls.Add((Control)(object)Text_DATE_CREATION);
		((Control)TabPage2).Controls.Add((Control)(object)Label44);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_MODE_STOCK);
		((Control)TabPage2).Controls.Add((Control)(object)Label40);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_UNITE);
		((Control)TabPage2).Controls.Add((Control)(object)Label37);
		((Control)TabPage2).Controls.Add((Control)(object)Label28);
		((Control)TabPage2).Controls.Add((Control)(object)Text_PRIX_V_2);
		((Control)TabPage2).Controls.Add((Control)(object)Label1);
		((Control)TabPage2).Controls.Add((Control)(object)Text_EMPLACEMENT);
		((Control)TabPage2).Controls.Add((Control)(object)Label22);
		((Control)TabPage2).Controls.Add((Control)(object)Label6);
		((Control)TabPage2).Controls.Add((Control)(object)Label8);
		((Control)TabPage2).Controls.Add((Control)(object)Label3);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_TAUX_TVA);
		((Control)TabPage2).Controls.Add((Control)(object)Label7);
		((Control)TabPage2).Controls.Add((Control)(object)Text_DESCRIPTION);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_COULEURS);
		((Control)TabPage2).Controls.Add((Control)(object)Text_SOUS_FAMILLE);
		((Control)TabPage2).Controls.Add((Control)(object)Combo_TAILLES);
		((Control)TabPage2).Controls.Add((Control)(object)Button85454);
		((Control)TabPage2).Controls.Add((Control)(object)Button73434);
		((Control)TabPage2).Controls.Add((Control)(object)Button1);
		componentResourceManager.ApplyResources(TabPage2, "TabPage2");
		((Control)TabPage2).Name = "TabPage2";
		componentResourceManager.ApplyResources(Combo_BALANCE, "Combo_BALANCE");
		((ListControl)Combo_BALANCE).FormattingEnabled = true;
		Combo_BALANCE.Items.AddRange(new object[2]
		{
			componentResourceManager.GetString("Combo_BALANCE.Items"),
			componentResourceManager.GetString("Combo_BALANCE.Items1")
		});
		((Control)Combo_BALANCE).Name = "Combo_BALANCE";
		((Control)Label4).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.Black;
		((Control)Label4).Name = "Label4";
		componentResourceManager.ApplyResources(Combo_FENETRE_PESEE, "Combo_FENETRE_PESEE");
		((ListControl)Combo_FENETRE_PESEE).FormattingEnabled = true;
		Combo_FENETRE_PESEE.Items.AddRange(new object[2]
		{
			componentResourceManager.GetString("Combo_FENETRE_PESEE.Items"),
			componentResourceManager.GetString("Combo_FENETRE_PESEE.Items1")
		});
		((Control)Combo_FENETRE_PESEE).Name = "Combo_FENETRE_PESEE";
		((Control)Label29).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label29, "Label29");
		((Control)Label29).ForeColor = Color.Black;
		((Control)Label29).Name = "Label29";
		((TextBoxBase)Text_ID_ARTICLE).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_ID_ARTICLE, "Text_ID_ARTICLE");
		((Control)Text_ID_ARTICLE).Name = "Text_ID_ARTICLE";
		((Control)Label70).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label70, "Label70");
		((Control)Label70).ForeColor = Color.Black;
		((Control)Label70).Name = "Label70";
		((Control)Label69).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label69, "Label69");
		((Control)Label69).ForeColor = Color.Black;
		((Control)Label69).Name = "Label69";
		((Control)Label11).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label11, "Label11");
		((Control)Label11).ForeColor = Color.Black;
		((Control)Label11).Name = "Label11";
		((TextBoxBase)Text_PROMOTION).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_PROMOTION, "Text_PROMOTION");
		((Control)Text_PROMOTION).Name = "Text_PROMOTION";
		((Control)Label34).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label34, "Label34");
		((Control)Label34).ForeColor = Color.Black;
		((Control)Label34).Name = "Label34";
		Combo_PRINTER_DUPLICATA.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_DUPLICATA, "Combo_PRINTER_DUPLICATA");
		((ListControl)Combo_PRINTER_DUPLICATA).FormattingEnabled = true;
		Combo_PRINTER_DUPLICATA.Items.AddRange(new object[5]
		{
			componentResourceManager.GetString("Combo_PRINTER_DUPLICATA.Items"),
			componentResourceManager.GetString("Combo_PRINTER_DUPLICATA.Items1"),
			componentResourceManager.GetString("Combo_PRINTER_DUPLICATA.Items2"),
			componentResourceManager.GetString("Combo_PRINTER_DUPLICATA.Items3"),
			componentResourceManager.GetString("Combo_PRINTER_DUPLICATA.Items4")
		});
		((Control)Combo_PRINTER_DUPLICATA).Name = "Combo_PRINTER_DUPLICATA";
		((Control)Label38).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label38, "Label38");
		((Control)Label38).ForeColor = Color.Black;
		((Control)Label38).Name = "Label38";
		Combo_PRINTER.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER, "Combo_PRINTER");
		((ListControl)Combo_PRINTER).FormattingEnabled = true;
		Combo_PRINTER.Items.AddRange(new object[5]
		{
			componentResourceManager.GetString("Combo_PRINTER.Items"),
			componentResourceManager.GetString("Combo_PRINTER.Items1"),
			componentResourceManager.GetString("Combo_PRINTER.Items2"),
			componentResourceManager.GetString("Combo_PRINTER.Items3"),
			componentResourceManager.GetString("Combo_PRINTER.Items4")
		});
		((Control)Combo_PRINTER).Name = "Combo_PRINTER";
		Combo_FOURNISSEUR.DropDownWidth = 200;
		componentResourceManager.ApplyResources(Combo_FOURNISSEUR, "Combo_FOURNISSEUR");
		((ListControl)Combo_FOURNISSEUR).FormattingEnabled = true;
		Combo_FOURNISSEUR.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_FOURNISSEUR.Items"),
			componentResourceManager.GetString("Combo_FOURNISSEUR.Items1"),
			componentResourceManager.GetString("Combo_FOURNISSEUR.Items2"),
			componentResourceManager.GetString("Combo_FOURNISSEUR.Items3")
		});
		((Control)Combo_FOURNISSEUR).Name = "Combo_FOURNISSEUR";
		((Control)Label32).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label32, "Label32");
		((Control)Label32).ForeColor = Color.Black;
		((Control)Label32).Name = "Label32";
		((Control)Label31).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label31, "Label31");
		((Control)Label31).ForeColor = Color.Black;
		((Control)Label31).Name = "Label31";
		componentResourceManager.ApplyResources(Text_REFERENCE, "Text_REFERENCE");
		((Control)Text_REFERENCE).Name = "Text_REFERENCE";
		((TextBoxBase)Text_STOCK_INITIAL).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_STOCK_INITIAL, "Text_STOCK_INITIAL");
		((Control)Text_STOCK_INITIAL).Name = "Text_STOCK_INITIAL";
		((Control)Label42).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label42, "Label42");
		((Control)Label42).ForeColor = Color.Black;
		((Control)Label42).Name = "Label42";
		((TextBoxBase)Text_DATE_INVENTAIRE).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_DATE_INVENTAIRE, "Text_DATE_INVENTAIRE");
		((Control)Text_DATE_INVENTAIRE).Name = "Text_DATE_INVENTAIRE";
		((Control)Label43).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label43, "Label43");
		((Control)Label43).ForeColor = Color.Black;
		((Control)Label43).Name = "Label43";
		((TextBoxBase)Text_DATE_CREATION).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_DATE_CREATION, "Text_DATE_CREATION");
		((Control)Text_DATE_CREATION).Name = "Text_DATE_CREATION";
		((Control)Label44).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label44, "Label44");
		((Control)Label44).ForeColor = Color.Black;
		((Control)Label44).Name = "Label44";
		Combo_MODE_STOCK.DropDownStyle = (ComboBoxStyle)2;
		Combo_MODE_STOCK.DropDownWidth = 200;
		componentResourceManager.ApplyResources(Combo_MODE_STOCK, "Combo_MODE_STOCK");
		((ListControl)Combo_MODE_STOCK).FormattingEnabled = true;
		Combo_MODE_STOCK.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_MODE_STOCK.Items"),
			componentResourceManager.GetString("Combo_MODE_STOCK.Items1"),
			componentResourceManager.GetString("Combo_MODE_STOCK.Items2"),
			componentResourceManager.GetString("Combo_MODE_STOCK.Items3")
		});
		((Control)Combo_MODE_STOCK).Name = "Combo_MODE_STOCK";
		((Control)Label40).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label40, "Label40");
		((Control)Label40).ForeColor = Color.Black;
		((Control)Label40).Name = "Label40";
		componentResourceManager.ApplyResources(Combo_UNITE, "Combo_UNITE");
		((ListControl)Combo_UNITE).FormattingEnabled = true;
		Combo_UNITE.Items.AddRange(new object[6]
		{
			componentResourceManager.GetString("Combo_UNITE.Items"),
			componentResourceManager.GetString("Combo_UNITE.Items1"),
			componentResourceManager.GetString("Combo_UNITE.Items2"),
			componentResourceManager.GetString("Combo_UNITE.Items3"),
			componentResourceManager.GetString("Combo_UNITE.Items4"),
			componentResourceManager.GetString("Combo_UNITE.Items5")
		});
		((Control)Combo_UNITE).Name = "Combo_UNITE";
		((Control)Label37).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label37, "Label37");
		((Control)Label37).ForeColor = Color.Black;
		((Control)Label37).Name = "Label37";
		((Control)Label28).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label28, "Label28");
		((Control)Label28).ForeColor = Color.Black;
		((Control)Label28).Name = "Label28";
		((TextBoxBase)Text_PRIX_V_2).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_PRIX_V_2, "Text_PRIX_V_2");
		((Control)Text_PRIX_V_2).Name = "Text_PRIX_V_2";
		((Control)Label1).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.Black;
		((Control)Label1).Name = "Label1";
		componentResourceManager.ApplyResources(Text_EMPLACEMENT, "Text_EMPLACEMENT");
		((TextBoxBase)Text_EMPLACEMENT).ForeColor = Color.Black;
		((Control)Text_EMPLACEMENT).Name = "Text_EMPLACEMENT";
		((Control)Label22).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label22, "Label22");
		((Control)Label22).ForeColor = Color.Black;
		((Control)Label22).Name = "Label22";
		((Control)Label6).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.Black;
		((Control)Label6).Name = "Label6";
		((Control)Label8).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.Black;
		((Control)Label8).Name = "Label8";
		((Control)Label3).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.Black;
		((Control)Label3).Name = "Label3";
		Combo_TAUX_TVA.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_TAUX_TVA.AutoCompleteSource = (AutoCompleteSource)256;
		componentResourceManager.ApplyResources(Combo_TAUX_TVA, "Combo_TAUX_TVA");
		((ListControl)Combo_TAUX_TVA).FormattingEnabled = true;
		Combo_TAUX_TVA.Items.AddRange(new object[5]
		{
			componentResourceManager.GetString("Combo_TAUX_TVA.Items"),
			componentResourceManager.GetString("Combo_TAUX_TVA.Items1"),
			componentResourceManager.GetString("Combo_TAUX_TVA.Items2"),
			componentResourceManager.GetString("Combo_TAUX_TVA.Items3"),
			componentResourceManager.GetString("Combo_TAUX_TVA.Items4")
		});
		((Control)Combo_TAUX_TVA).Name = "Combo_TAUX_TVA";
		((Control)Label7).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.Black;
		((Control)Label7).Name = "Label7";
		componentResourceManager.ApplyResources(Text_DESCRIPTION, "Text_DESCRIPTION");
		((TextBoxBase)Text_DESCRIPTION).ForeColor = Color.Black;
		((Control)Text_DESCRIPTION).Name = "Text_DESCRIPTION";
		Combo_COULEURS.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_COULEURS.AutoCompleteSource = (AutoCompleteSource)256;
		Combo_COULEURS.DropDownHeight = 200;
		Combo_COULEURS.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_COULEURS, "Combo_COULEURS");
		((ListControl)Combo_COULEURS).FormattingEnabled = true;
		((Control)Combo_COULEURS).Name = "Combo_COULEURS";
		componentResourceManager.ApplyResources(Text_SOUS_FAMILLE, "Text_SOUS_FAMILLE");
		((Control)Text_SOUS_FAMILLE).Name = "Text_SOUS_FAMILLE";
		Combo_TAILLES.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_TAILLES.AutoCompleteSource = (AutoCompleteSource)256;
		Combo_TAILLES.DropDownHeight = 200;
		Combo_TAILLES.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_TAILLES, "Combo_TAILLES");
		((ListControl)Combo_TAILLES).FormattingEnabled = true;
		((Control)Combo_TAILLES).Name = "Combo_TAILLES";
		((ButtonBase)Button85454).BackColor = Color.Transparent;
		((Control)Button85454).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button85454, "Button85454");
		((Control)Button85454).ForeColor = Color.Green;
		((Control)Button85454).Name = "Button85454";
		((ButtonBase)Button85454).UseVisualStyleBackColor = false;
		((ButtonBase)Button73434).BackColor = Color.Transparent;
		((Control)Button73434).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button73434, "Button73434");
		((Control)Button73434).ForeColor = Color.Green;
		((Control)Button73434).Name = "Button73434";
		((ButtonBase)Button73434).UseVisualStyleBackColor = false;
		((ButtonBase)Button1).BackColor = Color.Transparent;
		((Control)Button1).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button1, "Button1");
		((Control)Button1).ForeColor = Color.Green;
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		TabPage3.BackColor = Color.White;
		((Control)TabPage3).Controls.Add((Control)(object)Button_INVENTAIRES);
		((Control)TabPage3).Controls.Add((Control)(object)Button_MOUVEMENTS);
		((Control)TabPage3).Controls.Add((Control)(object)PictureBox14);
		((Control)TabPage3).Controls.Add((Control)(object)Label30303);
		((Control)TabPage3).Controls.Add((Control)(object)Button_SORTIES);
		((Control)TabPage3).Controls.Add((Control)(object)Button_VENTES);
		((Control)TabPage3).Controls.Add((Control)(object)Button_RECEPTIONS);
		((Control)TabPage3).Controls.Add((Control)(object)DateTimePicker1);
		((Control)TabPage3).Controls.Add((Control)(object)DateTimePicker2);
		((Control)TabPage3).Controls.Add((Control)(object)DataGrid_SORTIES);
		((Control)TabPage3).Controls.Add((Control)(object)DataGrid_VENTES);
		((Control)TabPage3).Controls.Add((Control)(object)DataGrid_MOUVEMENTS);
		((Control)TabPage3).Controls.Add((Control)(object)DataGrid_RECEPTIONS);
		((Control)TabPage3).Controls.Add((Control)(object)DataGrid_INVENTAIRES);
		componentResourceManager.ApplyResources(TabPage3, "TabPage3");
		((Control)TabPage3).Name = "TabPage3";
		((ButtonBase)Button_INVENTAIRES).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Button_INVENTAIRES, "Button_INVENTAIRES");
		((Control)Button_INVENTAIRES).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button_INVENTAIRES).Name = "Button_INVENTAIRES";
		((ButtonBase)Button_INVENTAIRES).UseCompatibleTextRendering = true;
		((ButtonBase)Button_INVENTAIRES).UseVisualStyleBackColor = false;
		((ButtonBase)Button_MOUVEMENTS).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Button_MOUVEMENTS, "Button_MOUVEMENTS");
		((Control)Button_MOUVEMENTS).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button_MOUVEMENTS).Name = "Button_MOUVEMENTS";
		((ButtonBase)Button_MOUVEMENTS).UseCompatibleTextRendering = true;
		((ButtonBase)Button_MOUVEMENTS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox14, "PictureBox14");
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox14.TabStop = false;
		((Control)Label30303).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label30303, "Label30303");
		((Control)Label30303).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label30303).Name = "Label30303";
		((ButtonBase)Button_SORTIES).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Button_SORTIES, "Button_SORTIES");
		((Control)Button_SORTIES).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button_SORTIES).Name = "Button_SORTIES";
		((ButtonBase)Button_SORTIES).UseCompatibleTextRendering = true;
		((ButtonBase)Button_SORTIES).UseVisualStyleBackColor = false;
		((ButtonBase)Button_VENTES).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Button_VENTES, "Button_VENTES");
		((Control)Button_VENTES).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button_VENTES).Name = "Button_VENTES";
		((ButtonBase)Button_VENTES).UseCompatibleTextRendering = true;
		((ButtonBase)Button_VENTES).UseVisualStyleBackColor = false;
		((ButtonBase)Button_RECEPTIONS).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Button_RECEPTIONS, "Button_RECEPTIONS");
		((Control)Button_RECEPTIONS).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button_RECEPTIONS).Name = "Button_RECEPTIONS";
		((ButtonBase)Button_RECEPTIONS).UseCompatibleTextRendering = true;
		((ButtonBase)Button_RECEPTIONS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(DateTimePicker1, "DateTimePicker1");
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		componentResourceManager.ApplyResources(DateTimePicker2, "DateTimePicker2");
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DataGrid_SORTIES.AllowUserToAddRows = false;
		DataGrid_SORTIES.AllowUserToResizeRows = false;
		DataGrid_SORTIES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_SORTIES.BackgroundColor = Color.White;
		DataGrid_SORTIES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_SORTIES.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn7,
			(DataGridViewColumn)DataGridViewTextBoxColumn8,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)DataGridViewTextBoxColumn9,
			(DataGridViewColumn)DataGridViewTextBoxColumn11
		});
		DataGrid_SORTIES.EditMode = (DataGridViewEditMode)4;
		DataGrid_SORTIES.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_SORTIES, "DataGrid_SORTIES");
		((Control)DataGrid_SORTIES).Name = "DataGrid_SORTIES";
		DataGrid_SORTIES.RowHeadersVisible = false;
		DataGrid_SORTIES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn7).DataPropertyName = "Dates";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn7, "DataGridViewTextBoxColumn7");
		((DataGridViewColumn)DataGridViewTextBoxColumn7).Name = "DataGridViewTextBoxColumn7";
		((DataGridViewColumn)DataGridViewTextBoxColumn8).DataPropertyName = "ID_BS";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn8, "DataGridViewTextBoxColumn8");
		((DataGridViewColumn)DataGridViewTextBoxColumn8).Name = "DataGridViewTextBoxColumn8";
		((DataGridViewColumn)Column3).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column3).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(Column3, "Column3");
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewColumn)DataGridViewTextBoxColumn9).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn9, "DataGridViewTextBoxColumn9");
		((DataGridViewColumn)DataGridViewTextBoxColumn9).Name = "DataGridViewTextBoxColumn9";
		((DataGridViewColumn)DataGridViewTextBoxColumn11).DataPropertyName = "Qté";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn11, "DataGridViewTextBoxColumn11");
		((DataGridViewColumn)DataGridViewTextBoxColumn11).Name = "DataGridViewTextBoxColumn11";
		DataGrid_VENTES.AllowUserToAddRows = false;
		DataGrid_VENTES.AllowUserToResizeRows = false;
		DataGrid_VENTES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_VENTES.BackgroundColor = Color.White;
		DataGrid_VENTES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_VENTES.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)DataGridViewTextBoxColumn3,
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn5,
			(DataGridViewColumn)Client
		});
		DataGrid_VENTES.EditMode = (DataGridViewEditMode)4;
		DataGrid_VENTES.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_VENTES, "DataGrid_VENTES");
		((Control)DataGrid_VENTES).Name = "DataGrid_VENTES";
		DataGrid_VENTES.RowHeadersVisible = false;
		DataGrid_VENTES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "Dates";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1");
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "Ticket";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2");
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)Column4).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column4).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(Column4, "Column4");
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3");
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).DataPropertyName = "Prix_V";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4");
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).DataPropertyName = "Qté";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5");
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		((DataGridViewColumn)Client).DataPropertyName = "Client";
		componentResourceManager.ApplyResources(Client, "Client");
		((DataGridViewColumn)Client).Name = "Client";
		DataGrid_MOUVEMENTS.AllowUserToAddRows = false;
		DataGrid_MOUVEMENTS.AllowUserToResizeRows = false;
		DataGrid_MOUVEMENTS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_MOUVEMENTS.BackgroundColor = Color.White;
		DataGrid_MOUVEMENTS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_MOUVEMENTS.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn6,
			(DataGridViewColumn)DataGridViewTextBoxColumn10,
			(DataGridViewColumn)DataGridViewTextBoxColumn13,
			(DataGridViewColumn)DataGridViewTextBoxColumn12,
			(DataGridViewColumn)DataGridViewTextBoxColumn14
		});
		DataGrid_MOUVEMENTS.EditMode = (DataGridViewEditMode)4;
		DataGrid_MOUVEMENTS.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_MOUVEMENTS, "DataGrid_MOUVEMENTS");
		((Control)DataGrid_MOUVEMENTS).Name = "DataGrid_MOUVEMENTS";
		DataGrid_MOUVEMENTS.RowHeadersVisible = false;
		DataGrid_MOUVEMENTS.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).DataPropertyName = "Dates";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6");
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Name = "DataGridViewTextBoxColumn6";
		((DataGridViewColumn)DataGridViewTextBoxColumn10).DataPropertyName = "LIBELLE";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn10, "DataGridViewTextBoxColumn10");
		((DataGridViewColumn)DataGridViewTextBoxColumn10).Name = "DataGridViewTextBoxColumn10";
		((DataGridViewColumn)DataGridViewTextBoxColumn13).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn13, "DataGridViewTextBoxColumn13");
		((DataGridViewColumn)DataGridViewTextBoxColumn13).Name = "DataGridViewTextBoxColumn13";
		((DataGridViewColumn)DataGridViewTextBoxColumn12).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn12, "DataGridViewTextBoxColumn12");
		((DataGridViewColumn)DataGridViewTextBoxColumn12).Name = "DataGridViewTextBoxColumn12";
		((DataGridViewColumn)DataGridViewTextBoxColumn14).DataPropertyName = "QUANTITE";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn14, "DataGridViewTextBoxColumn14");
		((DataGridViewColumn)DataGridViewTextBoxColumn14).Name = "DataGridViewTextBoxColumn14";
		DataGrid_RECEPTIONS.AllowUserToAddRows = false;
		DataGrid_RECEPTIONS.AllowUserToResizeRows = false;
		DataGrid_RECEPTIONS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_RECEPTIONS.BackgroundColor = Color.White;
		DataGrid_RECEPTIONS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_RECEPTIONS.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)ID_BR,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Articles,
			(DataGridViewColumn)Prix_AA,
			(DataGridViewColumn)Qtéé,
			(DataGridViewColumn)Fournisseur
		});
		DataGrid_RECEPTIONS.EditMode = (DataGridViewEditMode)4;
		DataGrid_RECEPTIONS.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_RECEPTIONS, "DataGrid_RECEPTIONS");
		((Control)DataGrid_RECEPTIONS).Name = "DataGrid_RECEPTIONS";
		DataGrid_RECEPTIONS.RowHeadersVisible = false;
		DataGrid_RECEPTIONS.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)Dates).DataPropertyName = "Dates";
		componentResourceManager.ApplyResources(Dates, "Dates");
		((DataGridViewColumn)Dates).Name = "Dates";
		((DataGridViewColumn)ID_BR).DataPropertyName = "ID_BR";
		componentResourceManager.ApplyResources(ID_BR, "ID_BR");
		((DataGridViewColumn)ID_BR).Name = "ID_BR";
		((DataGridViewColumn)Column5).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column5).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(Column5, "Column5");
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewColumn)Articles).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(Articles, "Articles");
		((DataGridViewColumn)Articles).Name = "Articles";
		((DataGridViewColumn)Prix_AA).DataPropertyName = "Prix_A";
		componentResourceManager.ApplyResources(Prix_AA, "Prix_AA");
		((DataGridViewColumn)Prix_AA).Name = "Prix_AA";
		((DataGridViewColumn)Qtéé).DataPropertyName = "Qté";
		componentResourceManager.ApplyResources(Qtéé, "Qtéé");
		((DataGridViewColumn)Qtéé).Name = "Qtéé";
		((DataGridViewColumn)Fournisseur).DataPropertyName = "FOURNISSEUR";
		componentResourceManager.ApplyResources(Fournisseur, "Fournisseur");
		((DataGridViewColumn)Fournisseur).Name = "Fournisseur";
		DataGrid_INVENTAIRES.AllowUserToAddRows = false;
		DataGrid_INVENTAIRES.AllowUserToResizeRows = false;
		DataGrid_INVENTAIRES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_INVENTAIRES.BackgroundColor = Color.White;
		DataGrid_INVENTAIRES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_INVENTAIRES.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn21,
			(DataGridViewColumn)DataGridViewTextBoxColumn22,
			(DataGridViewColumn)DataGridViewTextBoxColumn23,
			(DataGridViewColumn)DataGridViewTextBoxColumn24,
			(DataGridViewColumn)DataGridViewTextBoxColumn25
		});
		DataGrid_INVENTAIRES.EditMode = (DataGridViewEditMode)4;
		DataGrid_INVENTAIRES.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_INVENTAIRES, "DataGrid_INVENTAIRES");
		((Control)DataGrid_INVENTAIRES).Name = "DataGrid_INVENTAIRES";
		DataGrid_INVENTAIRES.RowHeadersVisible = false;
		DataGrid_INVENTAIRES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn21).DataPropertyName = "Dates";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn21, "DataGridViewTextBoxColumn21");
		((DataGridViewColumn)DataGridViewTextBoxColumn21).Name = "DataGridViewTextBoxColumn21";
		((DataGridViewColumn)DataGridViewTextBoxColumn22).DataPropertyName = "ID_INV";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn22, "DataGridViewTextBoxColumn22");
		((DataGridViewColumn)DataGridViewTextBoxColumn22).Name = "DataGridViewTextBoxColumn22";
		((DataGridViewColumn)DataGridViewTextBoxColumn23).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn23).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn23, "DataGridViewTextBoxColumn23");
		((DataGridViewColumn)DataGridViewTextBoxColumn23).Name = "DataGridViewTextBoxColumn23";
		((DataGridViewColumn)DataGridViewTextBoxColumn24).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn24, "DataGridViewTextBoxColumn24");
		((DataGridViewColumn)DataGridViewTextBoxColumn24).Name = "DataGridViewTextBoxColumn24";
		((DataGridViewColumn)DataGridViewTextBoxColumn25).DataPropertyName = "Stock_Physique";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn25, "DataGridViewTextBoxColumn25");
		((DataGridViewColumn)DataGridViewTextBoxColumn25).Name = "DataGridViewTextBoxColumn25";
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		componentResourceManager.ApplyResources(DataGridView1, "DataGridView1");
		DataGridView1.Columns.AddRange(new DataGridViewColumn[11]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Famille,
			(DataGridViewColumn)PRIX_A,
			(DataGridViewColumn)PRIX_V_1,
			(DataGridViewColumn)STOCK,
			(DataGridViewColumn)Alert,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Segoe UI", 11f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		((DataGridViewColumn)Column1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(Column1, "Column1");
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(ID_ARTICLE, "ID_ARTICLE");
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		componentResourceManager.ApplyResources(Code, "Code");
		((DataGridViewColumn)Code).Name = "Code";
		Code.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(Article, "Article");
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Famille).DataPropertyName = "Famille";
		componentResourceManager.ApplyResources(Famille, "Famille");
		((DataGridViewColumn)Famille).Name = "Famille";
		Famille.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_A).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_A).DataPropertyName = "PRIX_A";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)PRIX_A).DefaultCellStyle = val3;
		componentResourceManager.ApplyResources(PRIX_A, "PRIX_A");
		((DataGridViewColumn)PRIX_A).Name = "PRIX_A";
		PRIX_A.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V_1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V_1).DataPropertyName = "PRIX_V_1";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)PRIX_V_1).DefaultCellStyle = val4;
		componentResourceManager.ApplyResources(PRIX_V_1, "PRIX_V_1");
		((DataGridViewColumn)PRIX_V_1).Name = "PRIX_V_1";
		PRIX_V_1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)STOCK).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK).DataPropertyName = "STOCK";
		val5.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)STOCK).DefaultCellStyle = val5;
		componentResourceManager.ApplyResources(STOCK, "STOCK");
		((DataGridViewColumn)STOCK).Name = "STOCK";
		STOCK.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Alert).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Alert).DataPropertyName = "Alert";
		val6.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)Alert).DefaultCellStyle = val6;
		componentResourceManager.ApplyResources(Alert, "Alert");
		((DataGridViewColumn)Alert).Name = "Alert";
		Alert.SortMode = (DataGridViewColumnSortMode)0;
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
		componentResourceManager.ApplyResources(Panel_FONCTIONS, "Panel_FONCTIONS");
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button2);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_CANVA);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_IMPORTER);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_ETAT_LISTE_ARTICLES);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)PictureBox_ROBOT);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button14);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_M_SHIFTS);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PROMOTION);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)DataGridView2);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_FAMILLES);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Text_BALANCE);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button3);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_ETAT_STOCK);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_FERMER);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label17);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button6);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label33);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label36);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label39);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button12);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_RAPPORT);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_BALANCE);
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AllowUserToDeleteRows = false;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[10]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn26,
			(DataGridViewColumn)DataGridViewTextBoxColumn27,
			(DataGridViewColumn)DataGridViewTextBoxColumn28,
			(DataGridViewColumn)DataGridViewTextBoxColumn29,
			(DataGridViewColumn)DataGridViewTextBoxColumn30,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column10
		});
		componentResourceManager.ApplyResources(DataGridView3, "DataGridView3");
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.ReadOnly = true;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn26, "DataGridViewTextBoxColumn26");
		((DataGridViewColumn)DataGridViewTextBoxColumn26).Name = "DataGridViewTextBoxColumn26";
		((DataGridViewColumn)DataGridViewTextBoxColumn26).ReadOnly = true;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn27, "DataGridViewTextBoxColumn27");
		((DataGridViewColumn)DataGridViewTextBoxColumn27).Name = "DataGridViewTextBoxColumn27";
		((DataGridViewColumn)DataGridViewTextBoxColumn27).ReadOnly = true;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn28, "DataGridViewTextBoxColumn28");
		((DataGridViewColumn)DataGridViewTextBoxColumn28).Name = "DataGridViewTextBoxColumn28";
		((DataGridViewColumn)DataGridViewTextBoxColumn28).ReadOnly = true;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn29, "DataGridViewTextBoxColumn29");
		((DataGridViewColumn)DataGridViewTextBoxColumn29).Name = "DataGridViewTextBoxColumn29";
		((DataGridViewColumn)DataGridViewTextBoxColumn29).ReadOnly = true;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn30, "DataGridViewTextBoxColumn30");
		((DataGridViewColumn)DataGridViewTextBoxColumn30).Name = "DataGridViewTextBoxColumn30";
		((DataGridViewColumn)DataGridViewTextBoxColumn30).ReadOnly = true;
		componentResourceManager.ApplyResources(Column6, "Column6");
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewColumn)Column6).ReadOnly = true;
		componentResourceManager.ApplyResources(Column7, "Column7");
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewColumn)Column7).ReadOnly = true;
		componentResourceManager.ApplyResources(Column8, "Column8");
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewColumn)Column8).ReadOnly = true;
		componentResourceManager.ApplyResources(Column9, "Column9");
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewColumn)Column9).ReadOnly = true;
		componentResourceManager.ApplyResources(Column10, "Column10");
		((DataGridViewColumn)Column10).Name = "Column10";
		((DataGridViewColumn)Column10).ReadOnly = true;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button2).ForeColor = Color.Black;
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button_CANVA).Cursor = Cursors.Hand;
		((ButtonBase)Button_CANVA).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CANVA, "Button_CANVA");
		((Control)Button_CANVA).ForeColor = Color.Black;
		((Control)Button_CANVA).Name = "Button_CANVA";
		((ButtonBase)Button_CANVA).UseVisualStyleBackColor = true;
		((Control)Button_IMPORTER).Cursor = Cursors.Hand;
		((ButtonBase)Button_IMPORTER).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_IMPORTER, "Button_IMPORTER");
		((Control)Button_IMPORTER).ForeColor = Color.Black;
		((Control)Button_IMPORTER).Name = "Button_IMPORTER";
		((ButtonBase)Button_IMPORTER).UseVisualStyleBackColor = true;
		((Control)Button_ETAT_LISTE_ARTICLES).Cursor = Cursors.Hand;
		((ButtonBase)Button_ETAT_LISTE_ARTICLES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_ETAT_LISTE_ARTICLES, "Button_ETAT_LISTE_ARTICLES");
		((Control)Button_ETAT_LISTE_ARTICLES).ForeColor = Color.Black;
		((Control)Button_ETAT_LISTE_ARTICLES).Name = "Button_ETAT_LISTE_ARTICLES";
		((ButtonBase)Button_ETAT_LISTE_ARTICLES).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(PictureBox_ROBOT, "PictureBox_ROBOT");
		((Control)PictureBox_ROBOT).BackColor = Color.White;
		((Control)PictureBox_ROBOT).Cursor = Cursors.Hand;
		((Control)PictureBox_ROBOT).Name = "PictureBox_ROBOT";
		PictureBox_ROBOT.TabStop = false;
		((Control)Button14).Cursor = Cursors.Hand;
		((ButtonBase)Button14).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button14, "Button14");
		((Control)Button14).ForeColor = Color.Black;
		((Control)Button14).Name = "Button14";
		((ButtonBase)Button14).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_M_SHIFTS, "Button_M_SHIFTS");
		((ButtonBase)Button_M_SHIFTS).BackColor = Color.Black;
		((Control)Button_M_SHIFTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.MouseOverBackColor = Color.DimGray;
		((Control)Button_M_SHIFTS).ForeColor = Color.White;
		((Control)Button_M_SHIFTS).Name = "Button_M_SHIFTS";
		((ButtonBase)Button_M_SHIFTS).UseVisualStyleBackColor = false;
		((ButtonBase)Button_PROMOTION).BackColor = Color.Transparent;
		((Control)Button_PROMOTION).Cursor = Cursors.Hand;
		((ButtonBase)Button_PROMOTION).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_PROMOTION, "Button_PROMOTION");
		((Control)Button_PROMOTION).ForeColor = Color.Black;
		((Control)Button_PROMOTION).Name = "Button_PROMOTION";
		((ButtonBase)Button_PROMOTION).UseVisualStyleBackColor = false;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn15,
			(DataGridViewColumn)DataGridViewTextBoxColumn16,
			(DataGridViewColumn)DataGridViewTextBoxColumn17,
			(DataGridViewColumn)DataGridViewTextBoxColumn18,
			(DataGridViewColumn)DataGridViewTextBoxColumn19,
			(DataGridViewColumn)DataGridViewTextBoxColumn20,
			(DataGridViewColumn)unité,
			(DataGridViewColumn)departement
		});
		componentResourceManager.ApplyResources(DataGridView2, "DataGridView2");
		((Control)DataGridView2).Name = "DataGridView2";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn15, "DataGridViewTextBoxColumn15");
		((DataGridViewColumn)DataGridViewTextBoxColumn15).Name = "DataGridViewTextBoxColumn15";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn16, "DataGridViewTextBoxColumn16");
		((DataGridViewColumn)DataGridViewTextBoxColumn16).Name = "DataGridViewTextBoxColumn16";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn17, "DataGridViewTextBoxColumn17");
		((DataGridViewColumn)DataGridViewTextBoxColumn17).Name = "DataGridViewTextBoxColumn17";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn18, "DataGridViewTextBoxColumn18");
		((DataGridViewColumn)DataGridViewTextBoxColumn18).Name = "DataGridViewTextBoxColumn18";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn19, "DataGridViewTextBoxColumn19");
		((DataGridViewColumn)DataGridViewTextBoxColumn19).Name = "DataGridViewTextBoxColumn19";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn20, "DataGridViewTextBoxColumn20");
		((DataGridViewColumn)DataGridViewTextBoxColumn20).Name = "DataGridViewTextBoxColumn20";
		componentResourceManager.ApplyResources(unité, "unité");
		((DataGridViewColumn)unité).Name = "unité";
		componentResourceManager.ApplyResources(departement, "departement");
		((DataGridViewColumn)departement).Name = "departement";
		((ButtonBase)Button_FAMILLES).BackColor = Color.Transparent;
		((Control)Button_FAMILLES).Cursor = Cursors.Hand;
		((ButtonBase)Button_FAMILLES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_FAMILLES, "Button_FAMILLES");
		((Control)Button_FAMILLES).ForeColor = Color.Black;
		((Control)Button_FAMILLES).Name = "Button_FAMILLES";
		((ButtonBase)Button_FAMILLES).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_BALANCE, "Text_BALANCE");
		((Control)Text_BALANCE).Name = "Text_BALANCE";
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button3, "Button3");
		((Control)Button3).ForeColor = Color.Black;
		((Control)Button3).Name = "Button3";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)Button_ETAT_STOCK).Cursor = Cursors.Hand;
		((ButtonBase)Button_ETAT_STOCK).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_ETAT_STOCK, "Button_ETAT_STOCK");
		((Control)Button_ETAT_STOCK).ForeColor = Color.Black;
		((Control)Button_ETAT_STOCK).Name = "Button_ETAT_STOCK";
		((ButtonBase)Button_ETAT_STOCK).UseVisualStyleBackColor = true;
		((Control)Button_FERMER).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_FERMER, "Button_FERMER");
		((Control)Button_FERMER).ForeColor = Color.Red;
		((Control)Button_FERMER).Name = "Button_FERMER";
		((ButtonBase)Button_FERMER).UseVisualStyleBackColor = true;
		((Control)Label17).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label17).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label17, "Label17");
		((Control)Label17).ForeColor = Color.White;
		((Control)Label17).Name = "Label17";
		((ButtonBase)Button6).BackColor = Color.Transparent;
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button6, "Button6");
		((Control)Button6).ForeColor = Color.Black;
		((Control)Button6).Name = "Button6";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		((Control)Label33).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label33).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label33, "Label33");
		((Control)Label33).ForeColor = Color.White;
		((Control)Label33).Name = "Label33";
		((Control)Label36).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label36).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label36, "Label36");
		((Control)Label36).ForeColor = Color.White;
		((Control)Label36).Name = "Label36";
		((Control)Label39).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label39).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label39, "Label39");
		((Control)Label39).ForeColor = Color.White;
		((Control)Label39).Name = "Label39";
		((Control)Button12).Cursor = Cursors.Hand;
		((ButtonBase)Button12).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button12, "Button12");
		((Control)Button12).ForeColor = Color.Black;
		((Control)Button12).Name = "Button12";
		((ButtonBase)Button12).UseVisualStyleBackColor = true;
		((ButtonBase)Button_RAPPORT).BackColor = Color.White;
		((Control)Button_RAPPORT).Cursor = Cursors.Hand;
		((ButtonBase)Button_RAPPORT).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_RAPPORT, "Button_RAPPORT");
		((Control)Button_RAPPORT).Name = "Button_RAPPORT";
		((ButtonBase)Button_RAPPORT).UseVisualStyleBackColor = false;
		((Control)Button_BALANCE).Cursor = Cursors.Hand;
		((ButtonBase)Button_BALANCE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_BALANCE, "Button_BALANCE");
		((Control)Button_BALANCE).ForeColor = Color.Black;
		((Control)Button_BALANCE).Name = "Button_BALANCE";
		((ButtonBase)Button_BALANCE).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(TextBox4, "TextBox4");
		((Control)TextBox4).Name = "TextBox4";
		((Control)TableLayoutPanel1).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1");
		TableLayoutPanel1.Controls.Add((Control)(object)Panel0, 0, 0);
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		((Control)Panel0).Controls.Add((Control)(object)Button_ADD_COLLECTION);
		((Control)Panel0).Controls.Add((Control)(object)Panel_FIND);
		((Control)Panel0).Controls.Add((Control)(object)Button4);
		((Control)Panel0).Controls.Add((Control)(object)Button_FONCTIONS);
		((Control)Panel0).Controls.Add((Control)(object)Button244);
		((Control)Panel0).Controls.Add((Control)(object)Button_ADD);
		((Control)Panel0).Controls.Add((Control)(object)Label_TABLE);
		((Control)Panel0).Controls.Add((Control)(object)Panel13243);
		((Control)Panel0).Controls.Add((Control)(object)Panel1233);
		((Control)Panel0).Controls.Add((Control)(object)Panel_INFO);
		((Control)Panel0).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel0).Controls.Add((Control)(object)Panel1);
		((Control)Panel0).Controls.Add((Control)(object)Panel_INFO_COLLECTION);
		((Control)Panel0).Controls.Add((Control)(object)Panel_FONCTIONS);
		componentResourceManager.ApplyResources(Panel0, "Panel0");
		((Control)Panel0).Name = "Panel0";
		componentResourceManager.ApplyResources(Button_ADD_COLLECTION, "Button_ADD_COLLECTION");
		((ButtonBase)Button_ADD_COLLECTION).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD_COLLECTION).Cursor = Cursors.Hand;
		((Control)Button_ADD_COLLECTION).ForeColor = Color.White;
		((Control)Button_ADD_COLLECTION).Name = "Button_ADD_COLLECTION";
		((ButtonBase)Button_ADD_COLLECTION).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel_FIND, "Panel_FIND");
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label5);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label9);
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
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.White;
		((Control)Label5).Name = "Label5";
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.White;
		((Control)Label9).Name = "Label9";
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
		componentResourceManager.ApplyResources(Button4, "Button4");
		((Control)Button4).Cursor = Cursors.Hand;
		((ButtonBase)Button4).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button4).ForeColor = Color.Black;
		((Control)Button4).Name = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_FONCTIONS, "Button_FONCTIONS");
		((Control)Button_FONCTIONS).Cursor = Cursors.Hand;
		((ButtonBase)Button_FONCTIONS).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_FONCTIONS).ForeColor = SystemColors.ControlText;
		((Control)Button_FONCTIONS).Name = "Button_FONCTIONS";
		((Control)Button_FONCTIONS).Tag = "";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button244, "Button244");
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((Control)Button244).ForeColor = Color.White;
		((Control)Button244).Name = "Button244";
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_ADD, "Button_ADD");
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((Control)Button_ADD).ForeColor = Color.White;
		((Control)Button_ADD).Name = "Button_ADD";
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel13243, "Panel13243");
		((Control)Panel13243).BackColor = Color.White;
		Panel13243.BorderStyle = (BorderStyle)1;
		((Control)Panel13243).Controls.Add((Control)(object)RadioButton2);
		((Control)Panel13243).Controls.Add((Control)(object)RadioButton1);
		((Control)Panel13243).Controls.Add((Control)(object)DataGridView_TRIAGE);
		((Control)Panel13243).Controls.Add((Control)(object)Button10767);
		((Control)Panel13243).Controls.Add((Control)(object)Label61);
		((Control)Panel13243).Controls.Add((Control)(object)Label60);
		((Control)Panel13243).Controls.Add((Control)(object)Label59);
		((Control)Panel13243).Controls.Add((Control)(object)Label62);
		((Control)Panel13243).Name = "Panel13243";
		componentResourceManager.ApplyResources(RadioButton2, "RadioButton2");
		((ButtonBase)RadioButton2).BackColor = Color.LightGray;
		((ButtonBase)RadioButton2).FlatAppearance.CheckedBackColor = Color.MediumOrchid;
		((Control)RadioButton2).Name = "RadioButton2";
		((ButtonBase)RadioButton2).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(RadioButton1, "RadioButton1");
		((ButtonBase)RadioButton1).BackColor = Color.LightGray;
		RadioButton1.Checked = true;
		((ButtonBase)RadioButton1).FlatAppearance.CheckedBackColor = Color.MediumOrchid;
		((Control)RadioButton1).Name = "RadioButton1";
		RadioButton1.TabStop = true;
		((ButtonBase)RadioButton1).UseVisualStyleBackColor = false;
		DataGridView_TRIAGE.AllowUserToAddRows = false;
		DataGridView_TRIAGE.AllowUserToDeleteRows = false;
		DataGridView_TRIAGE.AllowUserToResizeColumns = false;
		DataGridView_TRIAGE.AllowUserToResizeRows = false;
		DataGridView_TRIAGE.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_TRIAGE.BackgroundColor = Color.White;
		DataGridView_TRIAGE.BorderStyle = (BorderStyle)2;
		DataGridView_TRIAGE.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_TRIAGE.ColumnHeadersVisible = false;
		DataGridView_TRIAGE.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewButtonColumn1 });
		DataGridView_TRIAGE.EditMode = (DataGridViewEditMode)4;
		DataGridView_TRIAGE.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView_TRIAGE, "DataGridView_TRIAGE");
		((Control)DataGridView_TRIAGE).Name = "DataGridView_TRIAGE";
		DataGridView_TRIAGE.RowHeadersVisible = false;
		val7.Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DataGridView_TRIAGE.RowsDefaultCellStyle = val7;
		DataGridView_TRIAGE.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).DataPropertyName = "FAMILLE";
		val8.Alignment = (DataGridViewContentAlignment)32;
		Padding padding = new Padding(0, 3, 0, 3);
		val8.Padding = padding;
		DataGridViewButtonColumn1.DefaultCellStyle = val8;
		DataGridViewButtonColumn1.FlatStyle = (FlatStyle)0;
		componentResourceManager.ApplyResources(DataGridViewButtonColumn1, "DataGridViewButtonColumn1");
		((DataGridViewColumn)DataGridViewButtonColumn1).Name = "DataGridViewButtonColumn1";
		((DataGridViewColumn)DataGridViewButtonColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).SortMode = (DataGridViewColumnSortMode)1;
		((ButtonBase)Button10767).BackColor = Color.Red;
		((Control)Button10767).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button10767, "Button10767");
		((Control)Button10767).ForeColor = Color.White;
		((Control)Button10767).Name = "Button10767";
		((ButtonBase)Button10767).UseVisualStyleBackColor = false;
		((Control)Label61).BackColor = Color.MediumOrchid;
		((Control)Label61).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label61, "Label61");
		((Control)Label61).ForeColor = Color.White;
		((Control)Label61).Name = "Label61";
		((Control)Label60).BackColor = Color.MediumOrchid;
		((Control)Label60).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label60, "Label60");
		((Control)Label60).ForeColor = Color.White;
		((Control)Label60).Name = "Label60";
		((Control)Label59).BackColor = Color.MediumOrchid;
		((Control)Label59).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label59, "Label59");
		((Control)Label59).ForeColor = Color.White;
		((Control)Label59).Name = "Label59";
		((Control)Label62).BackColor = Color.MediumOrchid;
		((Control)Label62).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label62, "Label62");
		((Control)Label62).ForeColor = Color.White;
		((Control)Label62).Name = "Label62";
		componentResourceManager.ApplyResources(Panel1233, "Panel1233");
		((Control)Panel1233).BackColor = Color.White;
		Panel1233.BorderStyle = (BorderStyle)1;
		((Control)Panel1233).Controls.Add((Control)(object)Button11);
		((Control)Panel1233).Controls.Add((Control)(object)Label63);
		((Control)Panel1233).Controls.Add((Control)(object)TextBox154545);
		((Control)Panel1233).Controls.Add((Control)(object)Label68);
		((Control)Panel1233).Controls.Add((Control)(object)CheckedListBox1);
		((Control)Panel1233).Controls.Add((Control)(object)CheckBox7);
		((Control)Panel1233).Controls.Add((Control)(object)Button10);
		((Control)Panel1233).Controls.Add((Control)(object)Label64);
		((Control)Panel1233).Controls.Add((Control)(object)Label65);
		((Control)Panel1233).Controls.Add((Control)(object)Label66);
		((Control)Panel1233).Controls.Add((Control)(object)Label67);
		((Control)Panel1233).Name = "Panel1233";
		((ButtonBase)Button11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button11).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button11, "Button11");
		((Control)Button11).ForeColor = Color.White;
		((Control)Button11).Name = "Button11";
		((ButtonBase)Button11).UseVisualStyleBackColor = false;
		((Control)Label63).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label63, "Label63");
		((Control)Label63).ForeColor = Color.Black;
		((Control)Label63).Name = "Label63";
		((TextBoxBase)TextBox154545).BackColor = Color.White;
		componentResourceManager.ApplyResources(TextBox154545, "TextBox154545");
		((Control)TextBox154545).Name = "TextBox154545";
		((Control)Label68).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label68, "Label68");
		((Control)Label68).ForeColor = Color.Black;
		((Control)Label68).Name = "Label68";
		((ListControl)CheckedListBox1).FormattingEnabled = true;
		componentResourceManager.ApplyResources(CheckedListBox1, "CheckedListBox1");
		((Control)CheckedListBox1).Name = "CheckedListBox1";
		CheckedListBox1.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(CheckBox7, "CheckBox7");
		((ButtonBase)CheckBox7).BackColor = Color.White;
		((Control)CheckBox7).ForeColor = Color.Black;
		((Control)CheckBox7).Name = "CheckBox7";
		((ButtonBase)CheckBox7).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox7).UseVisualStyleBackColor = false;
		((ButtonBase)Button10).BackColor = Color.Red;
		((Control)Button10).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button10, "Button10");
		((Control)Button10).ForeColor = Color.White;
		((Control)Button10).Name = "Button10";
		((ButtonBase)Button10).UseVisualStyleBackColor = false;
		((Control)Label64).BackColor = Color.MediumOrchid;
		((Control)Label64).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label64, "Label64");
		((Control)Label64).ForeColor = Color.White;
		((Control)Label64).Name = "Label64";
		((Control)Label65).BackColor = Color.MediumOrchid;
		((Control)Label65).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label65, "Label65");
		((Control)Label65).ForeColor = Color.White;
		((Control)Label65).Name = "Label65";
		((Control)Label66).BackColor = Color.MediumOrchid;
		((Control)Label66).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label66, "Label66");
		((Control)Label66).ForeColor = Color.White;
		((Control)Label66).Name = "Label66";
		((Control)Label67).BackColor = Color.MediumOrchid;
		((Control)Label67).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label67, "Label67");
		((Control)Label67).ForeColor = Color.White;
		((Control)Label67).Name = "Label67";
		componentResourceManager.ApplyResources(TableLayoutPanel2, "TableLayoutPanel2");
		TableLayoutPanel2.Controls.Add((Control)(object)Panel5, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Panel9, 4, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Panel6, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Panel7, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Panel10, 3, 0);
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		((Control)Panel9).BackColor = Color.MediumOrchid;
		((Control)Panel9).Controls.Add((Control)(object)PictureBox34);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox35);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox36);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox37);
		((Control)Panel9).Controls.Add((Control)(object)Label52);
		((Control)Panel9).Controls.Add((Control)(object)Label_VALEURSTOCK_V);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox15);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox16);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox17);
		((Control)Panel9).Controls.Add((Control)(object)Label46);
		((Control)Panel9).Controls.Add((Control)(object)Label_VALEURSTOCK_V_NON);
		componentResourceManager.ApplyResources(Panel9, "Panel9");
		((Control)Panel9).ForeColor = Color.FromArgb(214, 214, 214);
		((Control)Panel9).Name = "Panel9";
		componentResourceManager.ApplyResources(PictureBox34, "PictureBox34");
		((Control)PictureBox34).Name = "PictureBox34";
		PictureBox34.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox35, "PictureBox35");
		((Control)PictureBox35).Name = "PictureBox35";
		PictureBox35.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox36, "PictureBox36");
		((Control)PictureBox36).Name = "PictureBox36";
		PictureBox36.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox37, "PictureBox37");
		((Control)PictureBox37).Name = "PictureBox37";
		PictureBox37.TabStop = false;
		((Control)Label52).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label52, "Label52");
		((Control)Label52).ForeColor = Color.WhiteSmoke;
		((Control)Label52).Name = "Label52";
		((Control)Label_VALEURSTOCK_V).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_V).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_V, "Label_VALEURSTOCK_V");
		((Control)Label_VALEURSTOCK_V).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_V).Name = "Label_VALEURSTOCK_V";
		componentResourceManager.ApplyResources(PictureBox15, "PictureBox15");
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox15.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox16, "PictureBox16");
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox16.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox17, "PictureBox17");
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox17.TabStop = false;
		((Control)Label46).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label46, "Label46");
		((Control)Label46).ForeColor = Color.WhiteSmoke;
		((Control)Label46).Name = "Label46";
		((Control)Label_VALEURSTOCK_V_NON).BackColor = Color.Transparent;
		((Control)Label_VALEURSTOCK_V_NON).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_VALEURSTOCK_V_NON, "Label_VALEURSTOCK_V_NON");
		((Control)Label_VALEURSTOCK_V_NON).ForeColor = Color.WhiteSmoke;
		((Control)Label_VALEURSTOCK_V_NON).Name = "Label_VALEURSTOCK_V_NON";
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).BackColor = Color.White;
		Panel1.BorderStyle = (BorderStyle)2;
		((Control)Panel1).Controls.Add((Control)(object)Panel_COLUMNS);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel1).Controls.Add((Control)(object)Panel119898);
		((Control)Panel1).Name = "Panel1";
		componentResourceManager.ApplyResources(Panel_COLUMNS, "Panel_COLUMNS");
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Button94545);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Button187878);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label12);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label14);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label30);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label45);
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
		((Control)Label12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label12).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label12, "Label12");
		((Control)Label12).ForeColor = Color.White;
		((Control)Label12).Name = "Label12";
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label14, "Label14");
		((Control)Label14).ForeColor = Color.White;
		((Control)Label14).Name = "Label14";
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label30).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label30, "Label30");
		((Control)Label30).ForeColor = Color.White;
		((Control)Label30).Name = "Label30";
		((Control)Label45).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label45).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label45, "Label45");
		((Control)Label45).ForeColor = Color.White;
		((Control)Label45).Name = "Label45";
		((ListControl)ListBox_COLUMNS).FormattingEnabled = true;
		ListBox_COLUMNS.Items.AddRange(new object[20]
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
			componentResourceManager.GetString("ListBox_COLUMNS.Items14"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items15"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items16"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items17"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items18"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items19")
		});
		componentResourceManager.ApplyResources(ListBox_COLUMNS, "ListBox_COLUMNS");
		((Control)ListBox_COLUMNS).Name = "ListBox_COLUMNS";
		((Control)Panel119898).BackColor = Color.White;
		((Control)Panel119898).Controls.Add((Control)(object)DataGridView_FILTRAGE);
		((Control)Panel119898).Controls.Add((Control)(object)Panel2);
		componentResourceManager.ApplyResources(Panel119898, "Panel119898");
		((Control)Panel119898).Name = "Panel119898";
		DataGridView_FILTRAGE.AllowUserToAddRows = false;
		DataGridView_FILTRAGE.AllowUserToDeleteRows = false;
		DataGridView_FILTRAGE.AllowUserToResizeColumns = false;
		DataGridView_FILTRAGE.AllowUserToResizeRows = false;
		DataGridView_FILTRAGE.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_FILTRAGE.BackgroundColor = Color.White;
		DataGridView_FILTRAGE.BorderStyle = (BorderStyle)2;
		DataGridView_FILTRAGE.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_FILTRAGE.ColumnHeadersVisible = false;
		DataGridView_FILTRAGE.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewButtonColumn2 });
		componentResourceManager.ApplyResources(DataGridView_FILTRAGE, "DataGridView_FILTRAGE");
		DataGridView_FILTRAGE.EditMode = (DataGridViewEditMode)4;
		DataGridView_FILTRAGE.EnableHeadersVisualStyles = false;
		((Control)DataGridView_FILTRAGE).Name = "DataGridView_FILTRAGE";
		DataGridView_FILTRAGE.ReadOnly = true;
		DataGridView_FILTRAGE.RowHeadersVisible = false;
		val9.Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DataGridView_FILTRAGE.RowsDefaultCellStyle = val9;
		DataGridView_FILTRAGE.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn2).DataPropertyName = "FAMILLE";
		val10.Alignment = (DataGridViewContentAlignment)16;
		val10.BackColor = Color.White;
		val10.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.SelectionBackColor = Color.Yellow;
		val10.SelectionForeColor = Color.Black;
		val10.WrapMode = (DataGridViewTriState)1;
		DataGridViewButtonColumn2.DefaultCellStyle = val10;
		DataGridViewButtonColumn2.FlatStyle = (FlatStyle)0;
		componentResourceManager.ApplyResources(DataGridViewButtonColumn2, "DataGridViewButtonColumn2");
		((DataGridViewColumn)DataGridViewButtonColumn2).Name = "DataGridViewButtonColumn2";
		((DataGridViewColumn)DataGridViewButtonColumn2).ReadOnly = true;
		((DataGridViewColumn)DataGridViewButtonColumn2).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewButtonColumn2).SortMode = (DataGridViewColumnSortMode)1;
		((Control)Panel2).Controls.Add((Control)(object)Button_RJ38787);
		((Control)Panel2).Controls.Add((Control)(object)Button_RJ16576);
		((Control)Panel2).Controls.Add((Control)(object)Panel4);
		componentResourceManager.ApplyResources(Panel2, "Panel2");
		((Control)Panel2).Name = "Panel2";
		Button_RJ38787._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ38787._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ38787._BorderRadius = 16;
		Button_RJ38787._BorderSize = 1;
		Button_RJ38787._TextColor = Color.White;
		((ButtonBase)Button_RJ38787).BackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ38787).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_RJ38787, "Button_RJ38787");
		((Control)Button_RJ38787).ForeColor = Color.White;
		((Control)Button_RJ38787).Name = "Button_RJ38787";
		((ButtonBase)Button_RJ38787).UseVisualStyleBackColor = false;
		Button_RJ16576._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ16576._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ16576._BorderRadius = 16;
		Button_RJ16576._BorderSize = 1;
		Button_RJ16576._TextColor = Color.White;
		((ButtonBase)Button_RJ16576).BackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ16576).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_RJ16576, "Button_RJ16576");
		((Control)Button_RJ16576).ForeColor = Color.White;
		((Control)Button_RJ16576).Name = "Button_RJ16576";
		((ButtonBase)Button_RJ16576).UseVisualStyleBackColor = false;
		((Control)Panel4).BackColor = Color.White;
		componentResourceManager.ApplyResources(Panel4, "Panel4");
		((Control)Panel4).Controls.Add((Control)(object)TextBox14343);
		((Control)Panel4).Controls.Add((Control)(object)Label35);
		((Control)Panel4).Controls.Add((Control)(object)Label71);
		((Control)Panel4).Controls.Add((Control)(object)Label72);
		((Control)Panel4).Controls.Add((Control)(object)Label73);
		((Control)Panel4).Name = "Panel4";
		((TextBoxBase)TextBox14343).BackColor = Color.White;
		((TextBoxBase)TextBox14343).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(TextBox14343, "TextBox14343");
		((TextBoxBase)TextBox14343).ForeColor = Color.Black;
		((Control)TextBox14343).Name = "TextBox14343";
		((Control)Label35).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label35).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label35, "Label35");
		((Control)Label35).ForeColor = Color.White;
		((Control)Label35).Name = "Label35";
		((Control)Label71).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label71).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label71, "Label71");
		((Control)Label71).ForeColor = Color.White;
		((Control)Label71).Name = "Label71";
		((Control)Label72).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label72).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label72, "Label72");
		((Control)Label72).ForeColor = Color.White;
		((Control)Label72).Name = "Label72";
		((Control)Label73).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label73).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label73, "Label73");
		((Control)Label73).ForeColor = Color.White;
		((Control)Label73).Name = "Label73";
		componentResourceManager.ApplyResources(Panel_INFO_COLLECTION, "Panel_INFO_COLLECTION");
		((Control)Panel_INFO_COLLECTION).BackColor = Color.White;
		Panel_INFO_COLLECTION.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button5);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Combo_FOURNISSEUR_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label86);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_REFERENCE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label77);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label74);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_MOINS);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_PLUS);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label81);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_QTE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button23233);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button23232);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Panel3);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label53);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label54);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_INSERER);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)DataGridView_COULEURS);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)DataGridView_TAILLES);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)DataGrid_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label55);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label56);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label57);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label78);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label_TOP_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label82);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label83);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_CLOSE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Combo_FAMILLE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_SAVE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_ARTICLE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT212);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label84);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Label85);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_PRIX_V_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_CODE_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Button_GENERER_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Controls.Add((Control)(object)Text_PRIX_A_COLLECTION);
		((Control)Panel_INFO_COLLECTION).Name = "Panel_INFO_COLLECTION";
		((ButtonBase)Button5).BackColor = Color.Transparent;
		((Control)Button5).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button5, "Button5");
		((Control)Button5).ForeColor = Color.Green;
		((Control)Button5).Name = "Button5";
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		Combo_FOURNISSEUR_COLLECTION.DropDownWidth = 200;
		componentResourceManager.ApplyResources(Combo_FOURNISSEUR_COLLECTION, "Combo_FOURNISSEUR_COLLECTION");
		((ListControl)Combo_FOURNISSEUR_COLLECTION).FormattingEnabled = true;
		((Control)Combo_FOURNISSEUR_COLLECTION).Name = "Combo_FOURNISSEUR_COLLECTION";
		((Control)Label86).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label86, "Label86");
		((Control)Label86).ForeColor = Color.Black;
		((Control)Label86).Name = "Label86";
		componentResourceManager.ApplyResources(Text_REFERENCE_COLLECTION, "Text_REFERENCE_COLLECTION");
		((Control)Text_REFERENCE_COLLECTION).Name = "Text_REFERENCE_COLLECTION";
		((Control)Label77).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label77, "Label77");
		((Control)Label77).ForeColor = Color.Black;
		((Control)Label77).Name = "Label77";
		componentResourceManager.ApplyResources(Label74, "Label74");
		((Control)Label74).Name = "Label74";
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
		componentResourceManager.ApplyResources(Panel_CLAVIER, "Panel_CLAVIER");
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT1, "Button_CLAVIER_NOSELECT1");
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.Black;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_, "Butt_");
		((Control)Butt_).Cursor = Cursors.Hand;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_).ForeColor = Color.Black;
		((Control)Butt_).Name = "Butt_";
		((ButtonBase)Butt_).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_DOT, "Butt_DOT");
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_DOT).ForeColor = Color.Black;
		((Control)Butt_DOT).Name = "Butt_DOT";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_1, "Butt_1");
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_1).ForeColor = Color.Black;
		((Control)Butt_1).Name = "Butt_1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_2, "Butt_2");
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_2).ForeColor = Color.Black;
		((Control)Butt_2).Name = "Butt_2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_4, "Butt_4");
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_4).ForeColor = Color.Black;
		((Control)Butt_4).Name = "Butt_4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_3, "Butt_3");
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_3).ForeColor = Color.Black;
		((Control)Butt_3).Name = "Butt_3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_5, "Butt_5");
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_5).ForeColor = Color.Black;
		((Control)Butt_5).Name = "Butt_5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_7, "Butt_7");
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_7).ForeColor = Color.Black;
		((Control)Butt_7).Name = "Butt_7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_8, "Butt_8");
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_8).ForeColor = Color.Black;
		((Control)Butt_8).Name = "Butt_8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_BACK, "Butt_BACK");
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_BACK).ForeColor = Color.Black;
		((Control)Butt_BACK).Name = "Butt_BACK";
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_6, "Butt_6");
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_6).ForeColor = Color.Black;
		((Control)Butt_6).Name = "Butt_6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_9, "Butt_9");
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_9).ForeColor = Color.Black;
		((Control)Butt_9).Name = "Butt_9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_0, "Butt_0");
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_0).ForeColor = Color.Black;
		((Control)Butt_0).Name = "Butt_0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((Control)Button_MOINS).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_MOINS, "Button_MOINS");
		((Control)Button_MOINS).Name = "Button_MOINS";
		((ButtonBase)Button_MOINS).UseVisualStyleBackColor = true;
		((Control)Button_PLUS).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PLUS, "Button_PLUS");
		((Control)Button_PLUS).Name = "Button_PLUS";
		((ButtonBase)Button_PLUS).UseVisualStyleBackColor = true;
		((Control)Label81).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label81, "Label81");
		((Control)Label81).ForeColor = Color.Black;
		((Control)Label81).Name = "Label81";
		componentResourceManager.ApplyResources(Text_QTE_COLLECTION, "Text_QTE_COLLECTION");
		((Control)Text_QTE_COLLECTION).Name = "Text_QTE_COLLECTION";
		((ButtonBase)Button23233).BackColor = Color.Transparent;
		((Control)Button23233).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button23233, "Button23233");
		((Control)Button23233).ForeColor = Color.Green;
		((Control)Button23233).Name = "Button23233";
		((ButtonBase)Button23233).UseVisualStyleBackColor = false;
		((ButtonBase)Button23232).BackColor = Color.Transparent;
		((Control)Button23232).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button23232, "Button23232");
		((Control)Button23232).ForeColor = Color.Green;
		((Control)Button23232).Name = "Button23232";
		((ButtonBase)Button23232).UseVisualStyleBackColor = false;
		((Control)Panel3).BackColor = Color.Transparent;
		((Control)Panel3).Controls.Add((Control)(object)Label_TOTAL_QUANTITE_DOC);
		((Control)Panel3).Controls.Add((Control)(object)Button_CALC_DOC);
		((Control)Panel3).Controls.Add((Control)(object)Label_NBR_ARTICLES_DOC);
		((Control)Panel3).Controls.Add((Control)(object)Label75);
		((Control)Panel3).Controls.Add((Control)(object)Label76);
		((Control)Panel3).Controls.Add((Control)(object)Label79);
		((Control)Panel3).Controls.Add((Control)(object)Label80);
		componentResourceManager.ApplyResources(Panel3, "Panel3");
		((Control)Panel3).Name = "Panel3";
		componentResourceManager.ApplyResources(Label_TOTAL_QUANTITE_DOC, "Label_TOTAL_QUANTITE_DOC");
		((Control)Label_TOTAL_QUANTITE_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_QUANTITE_DOC).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label_TOTAL_QUANTITE_DOC).Name = "Label_TOTAL_QUANTITE_DOC";
		((Control)Button_CALC_DOC).ForeColor = Color.Red;
		componentResourceManager.ApplyResources(Button_CALC_DOC, "Button_CALC_DOC");
		((Control)Button_CALC_DOC).Name = "Button_CALC_DOC";
		((ButtonBase)Button_CALC_DOC).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label_NBR_ARTICLES_DOC, "Label_NBR_ARTICLES_DOC");
		((Control)Label_NBR_ARTICLES_DOC).BackColor = Color.White;
		((Control)Label_NBR_ARTICLES_DOC).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label_NBR_ARTICLES_DOC).Name = "Label_NBR_ARTICLES_DOC";
		((Control)Label75).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label75).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label75, "Label75");
		((Control)Label75).ForeColor = Color.White;
		((Control)Label75).Name = "Label75";
		((Control)Label76).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label76).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label76, "Label76");
		((Control)Label76).ForeColor = Color.White;
		((Control)Label76).Name = "Label76";
		componentResourceManager.ApplyResources(Label79, "Label79");
		((Control)Label79).BackColor = Color.White;
		((Control)Label79).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label79).Name = "Label79";
		componentResourceManager.ApplyResources(Label80, "Label80");
		((Control)Label80).BackColor = Color.White;
		((Control)Label80).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label80).Name = "Label80";
		componentResourceManager.ApplyResources(Label53, "Label53");
		((Control)Label53).ForeColor = Color.Red;
		((Control)Label53).Name = "Label53";
		((Control)Label54).BackColor = SystemColors.ActiveBorder;
		componentResourceManager.ApplyResources(Label54, "Label54");
		((Control)Label54).ForeColor = Color.Black;
		((Control)Label54).Name = "Label54";
		((ButtonBase)Button_INSERER).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Button_INSERER, "Button_INSERER");
		((Control)Button_INSERER).ForeColor = Color.White;
		((Control)Button_INSERER).Name = "Button_INSERER";
		((ButtonBase)Button_INSERER).UseVisualStyleBackColor = false;
		DataGridView_COULEURS.AllowUserToAddRows = false;
		DataGridView_COULEURS.AllowUserToResizeRows = false;
		DataGridView_COULEURS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_COULEURS.BackgroundColor = Color.White;
		DataGridView_COULEURS.BorderStyle = (BorderStyle)2;
		DataGridView_COULEURS.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_COULEURS.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_COULEURS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_COULEURS.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)CODE_COULEUR,
			(DataGridViewColumn)COULEUR
		});
		DataGridView_COULEURS.EditMode = (DataGridViewEditMode)4;
		componentResourceManager.ApplyResources(DataGridView_COULEURS, "DataGridView_COULEURS");
		((Control)DataGridView_COULEURS).Name = "DataGridView_COULEURS";
		DataGridView_COULEURS.RowHeadersVisible = false;
		DataGridView_COULEURS.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)CODE_COULEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_COULEUR).DataPropertyName = "CODE_COULEUR";
		((DataGridViewColumn)CODE_COULEUR).FillWeight = 99.61929f;
		componentResourceManager.ApplyResources(CODE_COULEUR, "CODE_COULEUR");
		((DataGridViewColumn)CODE_COULEUR).Name = "CODE_COULEUR";
		((DataGridViewColumn)COULEUR).DataPropertyName = "COULEUR";
		((DataGridViewColumn)COULEUR).FillWeight = 99.61929f;
		componentResourceManager.ApplyResources(COULEUR, "COULEUR");
		((DataGridViewColumn)COULEUR).Name = "COULEUR";
		((DataGridViewColumn)COULEUR).Resizable = (DataGridViewTriState)1;
		COULEUR.SortMode = (DataGridViewColumnSortMode)0;
		DataGridView_TAILLES.AllowUserToAddRows = false;
		DataGridView_TAILLES.AllowUserToResizeRows = false;
		DataGridView_TAILLES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_TAILLES.BackgroundColor = Color.White;
		DataGridView_TAILLES.BorderStyle = (BorderStyle)2;
		DataGridView_TAILLES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_TAILLES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_TAILLES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_TAILLES.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)CODE_TAILLE,
			(DataGridViewColumn)TAILLE
		});
		DataGridView_TAILLES.EditMode = (DataGridViewEditMode)4;
		componentResourceManager.ApplyResources(DataGridView_TAILLES, "DataGridView_TAILLES");
		((Control)DataGridView_TAILLES).Name = "DataGridView_TAILLES";
		DataGridView_TAILLES.RowHeadersVisible = false;
		DataGridView_TAILLES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)CODE_TAILLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_TAILLE).DataPropertyName = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).FillWeight = 99.61929f;
		componentResourceManager.ApplyResources(CODE_TAILLE, "CODE_TAILLE");
		((DataGridViewColumn)CODE_TAILLE).Name = "CODE_TAILLE";
		((DataGridViewColumn)TAILLE).DataPropertyName = "TAILLE";
		((DataGridViewColumn)TAILLE).FillWeight = 99.61929f;
		componentResourceManager.ApplyResources(TAILLE, "TAILLE");
		((DataGridViewColumn)TAILLE).Name = "TAILLE";
		TAILLE.SortMode = (DataGridViewColumnSortMode)0;
		DataGrid_COLLECTION.AllowUserToAddRows = false;
		DataGrid_COLLECTION.AllowUserToResizeRows = false;
		DataGrid_COLLECTION.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_COLLECTION.BackgroundColor = Color.White;
		DataGrid_COLLECTION.BorderStyle = (BorderStyle)2;
		DataGrid_COLLECTION.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGrid_COLLECTION.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGrid_COLLECTION.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_COLLECTION.Columns.AddRange(new DataGridViewColumn[6]
		{
			(DataGridViewColumn)CODE_BARRE_LISTE,
			(DataGridViewColumn)ARTICLE_LISTE,
			(DataGridViewColumn)TAILLE_LISTE,
			(DataGridViewColumn)COULEUR_LISTE,
			(DataGridViewColumn)Qté_LISTE,
			(DataGridViewColumn)sup
		});
		((Control)DataGrid_COLLECTION).Cursor = Cursors.Default;
		DataGrid_COLLECTION.EditMode = (DataGridViewEditMode)4;
		componentResourceManager.ApplyResources(DataGrid_COLLECTION, "DataGrid_COLLECTION");
		((Control)DataGrid_COLLECTION).Name = "DataGrid_COLLECTION";
		DataGrid_COLLECTION.RowHeadersVisible = false;
		DataGrid_COLLECTION.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)CODE_BARRE_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_BARRE_LISTE).FillWeight = 91.08049f;
		componentResourceManager.ApplyResources(CODE_BARRE_LISTE, "CODE_BARRE_LISTE");
		((DataGridViewColumn)CODE_BARRE_LISTE).Name = "CODE_BARRE_LISTE";
		((DataGridViewColumn)ARTICLE_LISTE).FillWeight = 91.08049f;
		componentResourceManager.ApplyResources(ARTICLE_LISTE, "ARTICLE_LISTE");
		((DataGridViewColumn)ARTICLE_LISTE).Name = "ARTICLE_LISTE";
		((DataGridViewColumn)TAILLE_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(TAILLE_LISTE, "TAILLE_LISTE");
		((DataGridViewColumn)TAILLE_LISTE).Name = "TAILLE_LISTE";
		((DataGridViewColumn)COULEUR_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(COULEUR_LISTE, "COULEUR_LISTE");
		((DataGridViewColumn)COULEUR_LISTE).Name = "COULEUR_LISTE";
		((DataGridViewColumn)Qté_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val11.Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((DataGridViewColumn)Qté_LISTE).DefaultCellStyle = val11;
		((DataGridViewColumn)Qté_LISTE).FillWeight = 91.08049f;
		componentResourceManager.ApplyResources(Qté_LISTE, "Qté_LISTE");
		((DataGridViewColumn)Qté_LISTE).Name = "Qté_LISTE";
		((DataGridViewColumn)sup).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(sup, "sup");
		sup.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)sup).Name = "sup";
		((DataGridViewColumn)sup).Resizable = (DataGridViewTriState)1;
		((Control)Label55).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label55).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label55, "Label55");
		((Control)Label55).ForeColor = Color.White;
		((Control)Label55).Name = "Label55";
		((Control)Label56).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label56).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label56, "Label56");
		((Control)Label56).ForeColor = Color.White;
		((Control)Label56).Name = "Label56";
		((Control)Label57).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label57).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label57, "Label57");
		((Control)Label57).ForeColor = Color.White;
		((Control)Label57).Name = "Label57";
		((Control)Label78).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label78, "Label78");
		((Control)Label78).ForeColor = Color.Black;
		((Control)Label78).Name = "Label78";
		((Control)Label_TOP_COLLECTION).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP_COLLECTION).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_TOP_COLLECTION, "Label_TOP_COLLECTION");
		((Control)Label_TOP_COLLECTION).ForeColor = Color.White;
		((Control)Label_TOP_COLLECTION).Name = "Label_TOP_COLLECTION";
		((Control)Label82).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label82, "Label82");
		((Control)Label82).ForeColor = Color.Black;
		((Control)Label82).Name = "Label82";
		((Control)Label83).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label83, "Label83");
		((Control)Label83).ForeColor = Color.Black;
		((Control)Label83).Name = "Label83";
		((ButtonBase)Button_CLOSE_COLLECTION).BackColor = Color.Red;
		((Control)Button_CLOSE_COLLECTION).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_CLOSE_COLLECTION, "Button_CLOSE_COLLECTION");
		((Control)Button_CLOSE_COLLECTION).ForeColor = Color.White;
		((Control)Button_CLOSE_COLLECTION).Name = "Button_CLOSE_COLLECTION";
		((ButtonBase)Button_CLOSE_COLLECTION).UseVisualStyleBackColor = false;
		Combo_FAMILLE_COLLECTION.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_FAMILLE_COLLECTION.AutoCompleteSource = (AutoCompleteSource)256;
		Combo_FAMILLE_COLLECTION.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_FAMILLE_COLLECTION, "Combo_FAMILLE_COLLECTION");
		((ListControl)Combo_FAMILLE_COLLECTION).FormattingEnabled = true;
		((Control)Combo_FAMILLE_COLLECTION).Name = "Combo_FAMILLE_COLLECTION";
		((ButtonBase)Button_SAVE_COLLECTION).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE_COLLECTION).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_SAVE_COLLECTION, "Button_SAVE_COLLECTION");
		((Control)Button_SAVE_COLLECTION).ForeColor = Color.White;
		((Control)Button_SAVE_COLLECTION).Name = "Button_SAVE_COLLECTION";
		((ButtonBase)Button_SAVE_COLLECTION).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_ARTICLE_COLLECTION, "Text_ARTICLE_COLLECTION");
		((Control)Text_ARTICLE_COLLECTION).Name = "Text_ARTICLE_COLLECTION";
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT212, "Button_CLAVIER_NOSELECT212");
		((Control)Button_CLAVIER_NOSELECT212).Name = "Button_CLAVIER_NOSELECT212";
		((ButtonBase)Button_CLAVIER_NOSELECT212).UseVisualStyleBackColor = true;
		((Control)Label84).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label84, "Label84");
		((Control)Label84).ForeColor = Color.Black;
		((Control)Label84).Name = "Label84";
		((Control)Label85).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label85, "Label85");
		((Control)Label85).ForeColor = Color.Black;
		((Control)Label85).Name = "Label85";
		componentResourceManager.ApplyResources(Text_PRIX_V_COLLECTION, "Text_PRIX_V_COLLECTION");
		((Control)Text_PRIX_V_COLLECTION).Name = "Text_PRIX_V_COLLECTION";
		componentResourceManager.ApplyResources(Text_CODE_COLLECTION, "Text_CODE_COLLECTION");
		((Control)Text_CODE_COLLECTION).Name = "Text_CODE_COLLECTION";
		((ButtonBase)Button_GENERER_COLLECTION).BackColor = Color.Transparent;
		((Control)Button_GENERER_COLLECTION).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_GENERER_COLLECTION, "Button_GENERER_COLLECTION");
		((Control)Button_GENERER_COLLECTION).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_GENERER_COLLECTION).Name = "Button_GENERER_COLLECTION";
		((ButtonBase)Button_GENERER_COLLECTION).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_PRIX_A_COLLECTION, "Text_PRIX_A_COLLECTION");
		((Control)Text_PRIX_A_COLLECTION).Name = "Text_PRIX_A_COLLECTION";
		componentResourceManager.ApplyResources(TextBox_AJOUT_STOCK_MANUEL, "TextBox_AJOUT_STOCK_MANUEL");
		((Control)TextBox_AJOUT_STOCK_MANUEL).Name = "TextBox_AJOUT_STOCK_MANUEL";
		componentResourceManager.ApplyResources(TextBox_MODIF_STOCK_MANUEL, "TextBox_MODIF_STOCK_MANUEL");
		((Control)TextBox_MODIF_STOCK_MANUEL).Name = "TextBox_MODIF_STOCK_MANUEL";
		componentResourceManager.ApplyResources(TextBox_NBR_CODE_BALANCE, "TextBox_NBR_CODE_BALANCE");
		((Control)TextBox_NBR_CODE_BALANCE).Name = "TextBox_NBR_CODE_BALANCE";
		componentResourceManager.ApplyResources(TextBox_NBR_CODE_ARTICLE, "TextBox_NBR_CODE_ARTICLE");
		((Control)TextBox_NBR_CODE_ARTICLE).Name = "TextBox_NBR_CODE_ARTICLE";
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
		((Control)Button20).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button20, "Button20");
		((Control)Button20).ForeColor = Color.Black;
		((Control)Button20).Name = "Button20";
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		((Control)Picture_GREEN).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Picture_GREEN, "Picture_GREEN");
		((Control)Picture_GREEN).Name = "Picture_GREEN";
		Picture_GREEN.TabStop = false;
		((Control)Picture_BLUE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Picture_BLUE, "Picture_BLUE");
		((Control)Picture_BLUE).Name = "Picture_BLUE";
		Picture_BLUE.TabStop = false;
		((Control)Picture_RED).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Picture_RED, "Picture_RED");
		((Control)Picture_RED).Name = "Picture_RED";
		Picture_RED.TabStop = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Control)this).Controls.Add((Control)(object)TextBox4);
		((Control)this).Controls.Add((Control)(object)Button20);
		((Control)this).Controls.Add((Control)(object)TextBox_AJOUT_STOCK_MANUEL);
		((Control)this).Controls.Add((Control)(object)TextBox_MODIF_STOCK_MANUEL);
		((Control)this).Controls.Add((Control)(object)TextBox_NBR_CODE_BALANCE);
		((Control)this).Controls.Add((Control)(object)TextBox_NBR_CODE_ARTICLE);
		((Control)this).Controls.Add((Control)(object)Picture_GREEN);
		((Control)this).Controls.Add((Control)(object)Picture_BLUE);
		((Control)this).Controls.Add((Control)(object)Picture_RED);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_2_ARTICLES";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel10).ResumeLayout(false);
		((Control)Panel10).PerformLayout();
		((ISupportInitialize)PictureBox30).EndInit();
		((ISupportInitialize)PictureBox31).EndInit();
		((ISupportInitialize)PictureBox32).EndInit();
		((ISupportInitialize)PictureBox33).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel7).PerformLayout();
		((ISupportInitialize)PictureBox26).EndInit();
		((ISupportInitialize)PictureBox27).EndInit();
		((ISupportInitialize)PictureBox28).EndInit();
		((ISupportInitialize)PictureBox29).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((ISupportInitialize)PictureBox22).EndInit();
		((ISupportInitialize)PictureBox23).EndInit();
		((ISupportInitialize)PictureBox24).EndInit();
		((ISupportInitialize)PictureBox25).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((ISupportInitialize)PictureBox18).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel8).PerformLayout();
		((Control)Panel_GROUPE).ResumeLayout(false);
		((Control)Panel_COULEUR).ResumeLayout(false);
		((ISupportInitialize)Picture_COLOR_23).EndInit();
		((ISupportInitialize)Picture_COLOR_22).EndInit();
		((ISupportInitialize)Picture_COLOR_21).EndInit();
		((ISupportInitialize)Picture_COLOR_20).EndInit();
		((ISupportInitialize)Picture_COLOR_19).EndInit();
		((ISupportInitialize)Picture_COLOR_18).EndInit();
		((ISupportInitialize)Picture_COLOR_16).EndInit();
		((ISupportInitialize)Picture_COLOR_15).EndInit();
		((ISupportInitialize)Picture_COLOR_14).EndInit();
		((ISupportInitialize)Picture_COLOR_13).EndInit();
		((ISupportInitialize)Picture_COLOR_12).EndInit();
		((ISupportInitialize)Picture_COLOR_11).EndInit();
		((ISupportInitialize)Picture_COLOR_6).EndInit();
		((ISupportInitialize)Picture_COLOR_10).EndInit();
		((ISupportInitialize)Picture_COLOR_5).EndInit();
		((ISupportInitialize)Picture_COLOR_1).EndInit();
		((ISupportInitialize)Picture_COLOR_8).EndInit();
		((ISupportInitialize)Picture_COLOR_9).EndInit();
		((ISupportInitialize)Picture_COLOR_4).EndInit();
		((ISupportInitialize)Picture_COLOR_3).EndInit();
		((ISupportInitialize)Picture_COLOR_2).EndInit();
		((Control)Panel_Picture_IMAGE_TOOLS).ResumeLayout(false);
		((Control)Panel_Picture_IMAGE_TOOLS).PerformLayout();
		((Control)Panel_Picture_IMAGE).ResumeLayout(false);
		((ISupportInitialize)Picture_IMAGE).EndInit();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)DataGrid_SORTIES).EndInit();
		((ISupportInitialize)DataGrid_VENTES).EndInit();
		((ISupportInitialize)DataGrid_MOUVEMENTS).EndInit();
		((ISupportInitialize)DataGrid_RECEPTIONS).EndInit();
		((ISupportInitialize)DataGrid_INVENTAIRES).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)Panel_FONCTIONS).PerformLayout();
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)PictureBox_ROBOT).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel0).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)Panel13243).ResumeLayout(false);
		((ISupportInitialize)DataGridView_TRIAGE).EndInit();
		((Control)Panel1233).ResumeLayout(false);
		((Control)Panel1233).PerformLayout();
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)Panel9).ResumeLayout(false);
		((Control)Panel9).PerformLayout();
		((ISupportInitialize)PictureBox34).EndInit();
		((ISupportInitialize)PictureBox35).EndInit();
		((ISupportInitialize)PictureBox36).EndInit();
		((ISupportInitialize)PictureBox37).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox16).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel_COLUMNS).ResumeLayout(false);
		((Control)Panel119898).ResumeLayout(false);
		((ISupportInitialize)DataGridView_FILTRAGE).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel_INFO_COLLECTION).ResumeLayout(false);
		((Control)Panel_INFO_COLLECTION).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)DataGridView_COULEURS).EndInit();
		((ISupportInitialize)DataGridView_TAILLES).EndInit();
		((ISupportInitialize)DataGrid_COLLECTION).EndInit();
		((ISupportInitialize)Picture_GREEN).EndInit();
		((ISupportInitialize)Picture_BLUE).EndInit();
		((ISupportInitialize)Picture_RED).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
				case 314:
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
							goto IL_007f;
						case 6:
							goto IL_00b1;
						case 7:
							goto IL_00b5;
						case 5:
						case 8:
						case 9:
							goto IL_00e6;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00b1:
					num2 = 6;
					goto IL_00b5;
					IL_00b5:
					num2 = 7;
					DataGridView1.Rows[num5].Cells[0].Value = Picture_BLUE.Image;
					goto IL_00e6;
					IL_007f:
					num2 = 4;
					DataGridView1.Rows[num5].Cells[0].Value = Picture_RED.Image;
					goto IL_00e6;
					IL_00e6:
					num2 = 9;
					num5 = checked(num5 + 1);
					goto IL_00ef;
					IL_0009:
					num2 = 2;
					num6 = checked(DataGridView1.Rows.Count - 1);
					num5 = 0;
					goto IL_00ef;
					IL_00ef:
					num7 = num5;
					num8 = num6;
					if (num7 > num8)
					{
						goto end_IL_0001_2;
					}
					goto IL_0026;
					IL_0026:
					num2 = 3;
					if (Operators.ConditionalCompareObjectLessEqual(DataGridView1.Rows[num5].Cells["STOCK"].Value, DataGridView1.Rows[num5].Cells["Alert"].Value, TextCompare: false))
					{
						goto IL_007f;
					}
					goto IL_00b1;
					end_IL_0001:
					break;
				}
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 314;
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

	private void DataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		((Control)Panel_COLUMNS).Visible = true;
		((Control)Panel_COLUMNS).BringToFront();
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		try
		{
			if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 2), TextCompare: false) && e.RowIndex >= 0) ? true : false)
			{
				((Control)Panel_INFO).Hide();
				if ((int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
				{
					string right = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SUPPRESION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_ARTICLE"].Value), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ARTICLE"].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
					MySqlCommand val = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE,ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("yyyy-MM-dd"), "' ,  '"), DateTime.Now.ToString("HH:mm:ss")), "'  ,'Suppression d''article'   ,'"), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_ARTICLE"].Value), "'    ,'"), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["Code"].Value), "' ,'"), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["Article"].Value), "'  ,    CONCAT('-','"), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["STOCK"].Value), "')         )        "));
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position].Delete();
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					((ContainerControl)this).BindingContext[(object)DT].Position = position;
					Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				}
			}
			if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
			{
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
				Label_TOP.Text = "MODIFICATION";
				((Control)Button_SAVE).Visible = true;
				int position2 = ((ContainerControl)this).BindingContext[(object)DT].Position;
				Text_ID.Text = DT.Rows[position2]["ID"].ToString();
				Text_ID_ARTICLE.Text = DT.Rows[position2]["ID_ARTICLE"].ToString();
				Text_CODE.Text = DT.Rows[position2]["Code"].ToString();
				Text_ARTICLE.Text = DT.Rows[position2]["Article"].ToString();
				Combo_FAMILLE.Text = DT.Rows[position2]["Famille"].ToString();
				Text_SOUS_FAMILLE.Text = DT.Rows[position2]["Sous_Famille"].ToString();
				Combo_GROUPES.Text = DT.Rows[position2]["GROUPE"].ToString();
				Text_DESCRIPTION.Text = DT.Rows[position2]["Description"].ToString();
				Text_PRIX_A.Text = DT.Rows[position2]["Prix_A"].ToString();
				Text_PRIX_MP.Text = DT.Rows[position2]["PRIX_MP"].ToString();
				Text_PRIX_V.Text = DT.Rows[position2]["PRIX_V_1"].ToString();
				Text_PRIX_V_2.Text = DT.Rows[position2]["PRIX_V_2"].ToString();
				Text_PRIX_QTE.Text = DT.Rows[position2]["PRIX_QTE"].ToString();
				Text_PRIX_QTE_MIN.Text = DT.Rows[position2]["PRIX_QTE_MIN"].ToString();
				Text_STOCK.Text = DT.Rows[position2]["STOCK"].ToString();
				Text_ALERT.Text = DT.Rows[position2]["Alert"].ToString();
				Text_DATE_CREATION.Text = DT.Rows[position2]["DATES"].ToString();
				Text_DATE_INVENTAIRE.Text = DT.Rows[position2]["DATE_INVENTAIRE"].ToString();
				Text_STOCK_INITIAL.Text = DT.Rows[position2]["STOCK_INITIAL"].ToString();
				Combo_TAUX_TVA.Text = DT.Rows[position2]["TAUX_TVA"].ToString();
				Combo_UNITE.Text = DT.Rows[position2]["UNITE"].ToString();
				Text_REFERENCE.Text = DT.Rows[position2]["REFERENCE"].ToString();
				Combo_FOURNISSEUR.Text = DT.Rows[position2]["FOURNISSEUR"].ToString();
				Combo_MODE_STOCK.Text = DT.Rows[position2]["MODE_STOCK"].ToString();
				Combo_PRINTER.Text = DT.Rows[position2]["PRINTER"].ToString();
				Combo_PRINTER_DUPLICATA.Text = DT.Rows[position2]["PRINTER_DUPLICATA"].ToString();
				Text_LIEN_PICTURE.Text = DT.Rows[position2]["Images"].ToString();
				Image val3 = Image.FromFile(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text);
				Picture_IMAGE.Image = (Image)new Bitmap(val3);
				Text_LIEN_PICTURE_ANC.Text = DT.Rows[position2]["Images"].ToString();
				val3.Dispose();
				Combo_TAILLES.Text = DT.Rows[position2]["Taille"].ToString();
				Combo_COULEURS.Text = DT.Rows[position2]["Couleur"].ToString();
				Text_EMPLACEMENT.Text = DT.Rows[position2]["Emplacement"].ToString();
				Text_PROMOTION.Text = DT.Rows[position2]["PROMOTION"].ToString();
				Combo_BALANCE.Text = DT.Rows[position2]["BALANCE"].ToString();
				Combo_FENETRE_PESEE.Text = DT.Rows[position2]["FENETRE_PESAGE"].ToString();
				if (!Conversions.ToBoolean(TextBox_MODIF_STOCK_MANUEL.Text))
				{
					((Control)Text_STOCK).Enabled = false;
				}
				DataGrid_RECEPTIONS.DataSource = null;
				DataGrid_VENTES.DataSource = null;
				DataGrid_SORTIES.DataSource = null;
				if (((Control)MyProject.Forms.FormDialog_google).Visible & ((Control)MyProject.Forms.FormDialog_google.Panel_google).Visible)
				{
					MyProject.Forms.FormDialog_google.Button_google.PerformClick();
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
				Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val5 = Graphics.FromImage((Image)(object)val4);
				val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val4 = null;
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

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
			DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13f, (FontStyle)1);
			DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13f, (FontStyle)1);
		}
	}

	private void Form_Me_Load(object sender, EventArgs e)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 1;
				Text_FIND.PlaceholderText = "Recherche";
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				DateTimePicker1.Text = "01/01/2000";
				DateTimePicker2.Text = Conversions.ToString(DateTime.Now.Date);
				((Control)TableLayoutPanel1).Dock = (DockStyle)5;
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
				{
					((ButtonBase)Button244).Image = MyProject.Forms.Form_0_TEMPLATE.PictureBox_SORTIE.Image;
				}
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GROUPES", false, 0).Index].SubItems[1].Text))
				{
					((Control)Panel_GROUPE).Visible = true;
					StringReader stringReader = new StringReader(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GROUPES_LISTE", false, 0).Index].SubItems[1].Text);
					Combo_GROUPES.Items.Clear();
					while (stringReader.Peek() != -1)
					{
						Combo_GROUPES.Items.Add((object)stringReader.ReadLine());
					}
					stringReader.Close();
				}
				((Control)Panel119898).Width = 0;
				Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				DA = new MySqlDataAdapter("select       *    from TABLE_ARTICLES order by       Famille,Article      asc    LIMIT 30", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 35;
				DataGridView1.DataSource = DT;
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
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT FAMILLE from TABLE_FAMILLES ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_FAMILLE.Items.Clear();
				Combo_FAMILLE_COLLECTION.Items.Clear();
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
					Combo_FAMILLE.Items.Add((object)dataTable.Rows[num6]["FAMILLE"].ToString());
					Combo_FAMILLE_COLLECTION.Items.Add((object)dataTable.Rows[num6]["FAMILLE"].ToString());
					num6++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT FOURNISSEUR from TABLE_FOURNISSEURS ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_FOURNISSEUR.Items.Clear();
				Combo_FOURNISSEUR_COLLECTION.Items.Clear();
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
					Combo_FOURNISSEUR.Items.Add((object)dataTable.Rows[num9]["FOURNISSEUR"].ToString());
					Combo_FOURNISSEUR_COLLECTION.Items.Add((object)dataTable.Rows[num9]["FOURNISSEUR"].ToString());
					num9++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select   *    from TABLE_LISTE_TAILLES ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_TAILLES.Items.Clear();
				DataGridView_TAILLES.Rows.Clear();
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
					System.Windows.Forms.ComboBox.ObjectCollection items = Combo_TAILLES.Items;
					KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num12]["CODE_TAILLE"].ToString(), dataTable.Rows[num12]["TAILLE"].ToString());
					items.Add((object)keyValuePair);
					DataGridView_TAILLES.Rows.Add(new object[2]
					{
						dataTable.Rows[num12]["CODE_TAILLE"].ToString(),
						dataTable.Rows[num12]["TAILLE"].ToString()
					});
					num12++;
				}
				((ListControl)Combo_TAILLES).ValueMember = "Key";
				((ListControl)Combo_TAILLES).DisplayMember = "Value";
				dataTable.Clear();
				val = new MySqlDataAdapter("select   *    from TABLE_LISTE_COULEURS ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_COULEURS.Items.Clear();
				DataGridView_COULEURS.Rows.Clear();
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
					System.Windows.Forms.ComboBox.ObjectCollection items2 = Combo_COULEURS.Items;
					KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num15]["CODE_COULEUR"].ToString(), dataTable.Rows[num15]["COULEUR"].ToString());
					items2.Add((object)keyValuePair);
					DataGridView_COULEURS.Rows.Add(new object[2]
					{
						dataTable.Rows[num15]["CODE_COULEUR"].ToString(),
						dataTable.Rows[num15]["COULEUR"].ToString()
					});
					num15++;
				}
				((ListControl)Combo_COULEURS).ValueMember = "Key";
				((ListControl)Combo_COULEURS).DisplayMember = "Value";
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
				tabControl.ItemSize = itemSize;
				TextBox_MODIF_STOCK_MANUEL.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MODIF_STOCK_MANUEL", false, 0).Index].SubItems[1].Text;
				TextBox_AJOUT_STOCK_MANUEL.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AJOUT_STOCK_MANUEL", false, 0).Index].SubItems[1].Text;
				TextBox_NBR_CODE_ARTICLE.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("NBR_CODE_ARTICLE", false, 0).Index].SubItems[1].Text;
				TextBox_NBR_CODE_BALANCE.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("NBR_CODE_BALANCE", false, 0).Index].SubItems[1].Text;
				FUN_CAT_ACCES();
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

	private void Button244_Click(object sender, EventArgs e)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
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

	public void Button_ADD_Click(object sender, EventArgs e)
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		try
		{
			TabControl1.SelectedIndex = 0;
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			((Control)Button_SAVE).Visible = true;
			Text_ID.Text = "";
			Text_ID_ARTICLE.Text = "";
			Text_CODE.Text = "";
			Text_ARTICLE.Text = "";
			Combo_FAMILLE.Text = null;
			Text_SOUS_FAMILLE.Text = "";
			Text_DESCRIPTION.Text = "";
			Text_PRIX_A.Text = "0";
			Text_PRIX_MP.Text = "0";
			Text_PRIX_V.Text = "0";
			Text_PRIX_QTE.Text = "0";
			Text_PRIX_QTE_MIN.Text = "0";
			Text_PRIX_V_2.Text = "0";
			Text_STOCK.Text = "0";
			Text_ALERT.Text = "0";
			Text_DATE_CREATION.Text = DateTime.Now.ToString("yyyy-MM-dd");
			Text_DATE_INVENTAIRE.Text = DateTime.Now.ToString("yyyy-MM-dd");
			Text_STOCK_INITIAL.Text = "0";
			Combo_TAUX_TVA.Text = "20";
			Combo_UNITE.Text = "";
			Text_REFERENCE.Text = "";
			Combo_FOURNISSEUR.Text = "";
			Combo_MODE_STOCK.Text = "FINI";
			Combo_PRINTER.Text = "0";
			Combo_PRINTER_DUPLICATA.Text = "0";
			Combo_GROUPES.Text = null;
			Text_LIEN_PICTURE.Text = "0";
			Text_LIEN_PICTURE_ANC.Text = "0";
			Image val = Image.FromFile(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text);
			Picture_IMAGE.Image = (Image)new Bitmap(val);
			val.Dispose();
			Combo_TAILLES.Text = null;
			Combo_COULEURS.Text = null;
			Text_EMPLACEMENT.Text = "";
			Text_PROMOTION.Text = "0";
			Combo_FENETRE_PESEE.Text = "";
			Combo_BALANCE.Text = "";
			((Control)Text_STOCK).Enabled = true;
			if (!Conversions.ToBoolean(TextBox_AJOUT_STOCK_MANUEL.Text))
			{
				((Control)Text_STOCK).Enabled = false;
			}
			((Control)Text_CODE).Focus();
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

	private void Button23_Click(object sender, EventArgs e)
	{
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_1864: Unknown result type (might be due to invalid IL or missing references)
		//IL_186b: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected Obj, but got Unknown
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected Obj, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1644: Unknown result type (might be due to invalid IL or missing references)
		//IL_164b: Expected Obj, but got Unknown
		//IL_1677: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (LOGICA.Domain.CatalogueRequiredFields.IsMissingIdentifier(Text_CODE.Text))
				{
					MessageBox.Show("Veuillez remplir le champ -Code- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (LOGICA.Domain.CatalogueRequiredFields.IsMissingIdentifier(Text_ARTICLE.Text))
				{
					MessageBox.Show("Veuillez remplir le champ -Article- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_FAMILLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Famille- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_A.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_MP.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_MP- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_V.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_V_1- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_V_2.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_V_2- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_QTE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_QTE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_QTE_MIN.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_QTE_MIN- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_STOCK.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -STOCK- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_ALERT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -ALERT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_DATE_CREATION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -DATE_CREATION- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_PRINTER.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRINTER- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_TAUX_TVA.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TAUX_TVA- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PROMOTION.Text, "", TextCompare: false) == 0 || decimal.Compare(Conversions.ToDecimal(Text_PROMOTION.Text), 100m) > 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PROMOTION- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_LIEN_PICTURE.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -IMAGE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GROUPES", false, 0).Index].SubItems[1].Text) && Operators.CompareString(Combo_GROUPES.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -GROUPE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Text_ARTICLE.Text = Text_ARTICLE.Text.ToString().Replace("'", " ");
				if (Operators.CompareString(Combo_BALANCE.Text, "OUI", TextCompare: false) == 0)
				{
					if (!Versioned.IsNumeric(Text_CODE.Text))
					{
						Interaction.MsgBox("Erreur Code Article");
						return;
					}
					int number = (int)Math.Round(Conversion.Val(TextBox_NBR_CODE_BALANCE.Text));
					Text_CODE.Text = Conversion.Val(Text_CODE.Text).ToString(Strings.StrDup(number, "0"));
				}
				try
				{
					if (Operators.CompareString(Text_LIEN_PICTURE.Text, Text_LIEN_PICTURE_ANC.Text, TextCompare: false) != 0)
					{
						Bitmap val = new Bitmap(Picture_IMAGE.Image);
						((Image)val).Save(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text, ImageFormat.Png);
						((Image)val).Dispose();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox("Erreur image : " + ex2.Message);
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					dataTable.Clear();
					val2 = new MySqlDataAdapter("select ID,Code,Article     from TABLE_ARTICLES WHERE   Code = '" + Text_CODE.Text + "'", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable.Rows[0]["Article"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					MySqlCommand val3 = new MySqlCommand();
					val3.CommandText = "SELECT MAX(ID) From TABLE_ARTICLES ";
					val3.Connection = Module1.cn_SQL;
					val3.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val3.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val3.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					val3.CommandText = "Select ARTICLE from TABLE_NUM  where ID = 0 ";
					val3.Connection = Module1.cn_SQL;
					val3.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string text = ((val3.ExecuteScalar() != DBNull.Value) ? ("ART" + Strings.Format(Conversions.ToDouble(val3.ExecuteScalar()), "000000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["ID_ARTICLE"] = text;
					DT.Rows[index]["Code"] = Strings.Trim(Text_CODE.Text);
					DT.Rows[index]["Article"] = Strings.Trim(Text_ARTICLE.Text);
					DT.Rows[index]["Famille"] = Combo_FAMILLE.Text;
					DT.Rows[index]["Sous_Famille"] = Text_SOUS_FAMILLE.Text;
					DT.Rows[index]["GROUPE"] = Combo_GROUPES.Text;
					DT.Rows[index]["Description"] = Text_DESCRIPTION.Text;
					DT.Rows[index]["Prix_A"] = Strings.FormatNumber(Text_PRIX_A.Text);
					DT.Rows[index]["PRIX_MP"] = Strings.FormatNumber(Text_PRIX_A.Text);
					DT.Rows[index]["PRIX_V_1"] = Strings.FormatNumber(Text_PRIX_V.Text);
					DT.Rows[index]["PRIX_V_2"] = Strings.FormatNumber(Text_PRIX_V_2.Text);
					DT.Rows[index]["PRIX_QTE"] = Strings.FormatNumber(Text_PRIX_QTE.Text);
					DT.Rows[index]["PRIX_QTE_MIN"] = Conversion.Val(Text_PRIX_QTE_MIN.Text);
					DT.Rows[index]["STOCK"] = Text_STOCK.Text;
					DT.Rows[index]["Alert"] = Text_ALERT.Text;
					DT.Rows[index]["DATES"] = Text_DATE_CREATION.Text;
					DT.Rows[index]["DATE_INVENTAIRE"] = Text_DATE_CREATION.Text;
					DT.Rows[index]["STOCK_INITIAL"] = Text_STOCK.Text;
					DT.Rows[index]["TAUX_TVA"] = Combo_TAUX_TVA.Text;
					DT.Rows[index]["UNITE"] = Combo_UNITE.Text;
					DT.Rows[index]["REFERENCE"] = Text_REFERENCE.Text;
					DT.Rows[index]["FOURNISSEUR"] = Combo_FOURNISSEUR.Text;
					DT.Rows[index]["MODE_STOCK"] = Combo_MODE_STOCK.Text;
					DT.Rows[index]["PRINTER"] = Combo_PRINTER.Text;
					DT.Rows[index]["PRINTER_DUPLICATA"] = Combo_PRINTER_DUPLICATA.Text;
					DT.Rows[index]["Images"] = Text_LIEN_PICTURE.Text;
					DT.Rows[index]["Taille"] = Combo_TAILLES.Text;
					DT.Rows[index]["Couleur"] = Combo_COULEURS.Text;
					DT.Rows[index]["Emplacement"] = Text_EMPLACEMENT.Text;
					DT.Rows[index]["PROMOTION"] = Strings.FormatNumber(Text_PROMOTION.Text);
					DT.Rows[index]["FENETRE_PESAGE"] = Combo_FENETRE_PESEE.Text;
					DT.Rows[index]["BALANCE"] = Combo_BALANCE.Text;
					MySqlCommandBuilder val4 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MySqlCommand val5 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val5.CommandText = "INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ,  '" + DateTime.Now.ToString("HH:mm:ss") + "'  ,'Création d''article'    ,'" + text + "' ,'" + Text_CODE.Text + "' ,'" + Text_ARTICLE.Text + "'  ,'" + Text_STOCK.Text + "'       )        ";
					val5.Connection = Module1.cn_SQL;
					val5.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val3.CommandText = "UPDATE     TABLE_NUM    SET ARTICLE =  ARTICLE + 1   ";
					val3.Connection = Module1.cn_SQL;
					val3.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val6 = new MySqlDataAdapter();
					dataTable2.Clear();
					val6 = new MySqlDataAdapter("select ID,Code,Article     from TABLE_ARTICLES WHERE   Code = '" + Text_CODE.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val6).Fill(dataTable2);
					if (dataTable2.Rows.Count != 0)
					{
						MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable2.Rows[0]["Article"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					dataTable2.Clear();
					val6 = new MySqlDataAdapter("select ID,ID_ARTICLE     from TABLE_ARTICLES WHERE   ID_ARTICLE = '" + Text_ID_ARTICLE.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val6).Fill(dataTable2);
					if (dataTable2.Rows.Count != 0)
					{
						MessageBox.Show("Cet ID est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position]["ID"] = Text_ID.Text;
					DT.Rows[position]["ID_ARTICLE"] = Text_ID_ARTICLE.Text;
					DT.Rows[position]["Code"] = Strings.Trim(Text_CODE.Text);
					DT.Rows[position]["Article"] = Strings.Trim(Text_ARTICLE.Text);
					DT.Rows[position]["Famille"] = Combo_FAMILLE.Text;
					DT.Rows[position]["Sous_Famille"] = Text_SOUS_FAMILLE.Text;
					DT.Rows[position]["GROUPE"] = Combo_GROUPES.Text;
					DT.Rows[position]["Description"] = Text_DESCRIPTION.Text;
					DT.Rows[position]["Prix_A"] = Strings.FormatNumber(Text_PRIX_A.Text);
					DT.Rows[position]["PRIX_MP"] = Strings.FormatNumber(Text_PRIX_MP.Text);
					DT.Rows[position]["PRIX_V_1"] = Strings.FormatNumber(Text_PRIX_V.Text);
					DT.Rows[position]["PRIX_V_2"] = Strings.FormatNumber(Text_PRIX_V_2.Text);
					DT.Rows[position]["PRIX_QTE"] = Strings.FormatNumber(Text_PRIX_QTE.Text);
					DT.Rows[position]["PRIX_QTE_MIN"] = Conversion.Val(Text_PRIX_QTE_MIN.Text);
					DT.Rows[position]["STOCK"] = Text_STOCK.Text;
					DT.Rows[position]["Alert"] = Text_ALERT.Text;
					DT.Rows[position]["DATES"] = Text_DATE_CREATION.Text;
					DT.Rows[position]["DATE_INVENTAIRE"] = Text_DATE_INVENTAIRE.Text;
					DT.Rows[position]["STOCK_INITIAL"] = Text_STOCK_INITIAL.Text;
					DT.Rows[position]["TAUX_TVA"] = Combo_TAUX_TVA.Text;
					DT.Rows[position]["UNITE"] = Combo_UNITE.Text;
					DT.Rows[position]["REFERENCE"] = Text_REFERENCE.Text;
					DT.Rows[position]["FOURNISSEUR"] = Combo_FOURNISSEUR.Text;
					DT.Rows[position]["MODE_STOCK"] = Combo_MODE_STOCK.Text;
					DT.Rows[position]["PRINTER"] = Combo_PRINTER.Text;
					DT.Rows[position]["PRINTER_DUPLICATA"] = Combo_PRINTER_DUPLICATA.Text;
					DT.Rows[position]["Images"] = Text_LIEN_PICTURE.Text;
					DT.Rows[position]["Taille"] = Combo_TAILLES.Text;
					DT.Rows[position]["Couleur"] = Combo_COULEURS.Text;
					DT.Rows[position]["Emplacement"] = Text_EMPLACEMENT.Text;
					DT.Rows[position]["PROMOTION"] = Strings.FormatNumber(Text_PROMOTION.Text);
					DT.Rows[position]["FENETRE_PESAGE"] = Combo_FENETRE_PESEE.Text;
					DT.Rows[position]["BALANCE"] = Combo_BALANCE.Text;
					MySqlCommandBuilder val7 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					string right = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MODIFICATION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_ARTICLE"].Value), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ARTICLE"].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				}
				((Control)Panel_INFO).Hide();
				Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
					Bitmap val8 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val9 = Graphics.FromImage((Image)(object)val8);
					val9.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val8).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val8 = null;
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

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void Button_GENERER_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = (int)Math.Round(Conversion.Val(TextBox_NBR_CODE_ARTICLE.Text));
			if (num > 6)
			{
				Random random = new Random();
				string text = random.Next(1, Conversions.ToInteger(Strings.StrDup(9, "9"))).ToString(Strings.StrDup(9, "0")) + random.Next(1, Conversions.ToInteger(Strings.StrDup(6, "9"))).ToString(Strings.StrDup(6, "0"));
				Text_CODE.Text = ("11" + text).Substring(0, num);
			}
			else
			{
				Random random2 = new Random();
				string text2 = random2.Next(1, Conversions.ToInteger(Strings.StrDup(num, "9"))).ToString(Strings.StrDup(num, "0"));
				Text_CODE.Text = text2;
			}
			if ((Text_CODE.Text.Length == 12) & (num == 12))
			{
				int num2 = 0;
				int num3 = 0;
				byte[] array = new byte[13];
				int num4 = 0;
				int num5;
				int num6;
				do
				{
					array[num4] = (byte)Conversions.ToInteger(Text_CODE.Text.Substring(num4, 1));
					if (unchecked(num4 % 2) == 1)
					{
						num3 += array[num4];
					}
					else
					{
						num2 += array[num4];
					}
					num4++;
					num5 = num4;
					num6 = 11;
				}
				while (num5 <= num6);
				unchecked
				{
					num4 = checked(num2 + num3 * 3) % 10;
				}
				if (num4 == 0)
				{
					array[12] = 0;
				}
				else
				{
					array[12] = (byte)(10 - num4);
				}
				byte[] bits = Module1.getBits(array);
				Text_CODE.Text += Conversions.ToString(array[12]);
			}
			if ((Text_CODE.Text.Length == 11) & (num == 11))
			{
				string text3 = Text_CODE.Text.Substring(0, 1);
				string text4 = Text_CODE.Text.Substring(1, 5);
				string text5 = Text_CODE.Text.Substring(6, 5);
				string text6 = text3 + text4 + text5;
				int num7 = 0;
				int num8 = 0;
				int length = text6.Length;
				int num9 = 1;
				while (true)
				{
					int num10 = num9;
					int num6 = length;
					if (num10 > num6)
					{
						break;
					}
					num8 = Convert.ToInt32(text6.Substring(num9 - 1, 1));
					num7 = ((unchecked(num9 % 2) != 0) ? (num7 + num8 * 3) : (num7 + num8 * 1));
					num9++;
				}
				unchecked
				{
					string text7 = (checked(10 - unchecked(num7 % 10)) % 10).ToString();
					Text_CODE.Text += text7;
				}
			}
			((Control)Text_CODE).Focus();
		}
	}

	private void TextBox15_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Text_ALERT_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void TextBox16_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void TextBox17_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (unchecked((int)MessageBox.Show("Voulez-vous vraiment Exporter les données vers les balances  ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0)) != 1)
				{
					return;
				}
				((TextBoxBase)TextBox4).Clear();
				DT.Clear();
				DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by Article asc", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				string text = "";
				string text2 = "2";
				string text3 = "HHHHH";
				string text4 = "10";
				string text5 = "W";
				string text6 = "0";
				int num = DataGridView1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string inputStr = Conversions.ToString(DataGridView1.Rows[num2].Cells[0].Value);
					string inputStr2 = Conversions.ToString(Operators.MultiplyObject(DataGridView1.Rows[num2].Cells[4].Value, 100));
					string source = Conversions.ToString(DataGridView1.Rows[num2].Cells[1].Value);
					text = text + text2 + Strings.LSet(Conversion.Val(inputStr).ToString("000000"), 6) + text3 + "|" + text4 + "|" + Strings.LSet(Conversion.Val(inputStr).ToString("000"), 3) + " |   |    |" + Strings.RSet(Conversions.ToString(Conversion.Val(inputStr2)), 7) + "|" + text5 + "|   |" + text6 + "|" + Strings.LSet(source, 25) + "|     |" + Environment.NewLine;
					num2++;
				}
				TextBox4.Text = text;
				File.WriteAllText("C:\\balance2\\Import500\\orden.dat", TextBox4.Text);
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
					string text7 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text7 + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text7 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void RadioButton9_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by Code asc", Module1.cn_SQL);
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

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by Article asc", Module1.cn_SQL);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by Famille asc", Module1.cn_SQL);
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

	private void TextBox_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
	}

	private void TextBox_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.White }, null, null);
	}

	private void Button_CALC_Click(object sender, EventArgs e)
	{
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		try
		{
			string text = default;
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			string text3 = "select    count(ID)  as N  from  TABLE_ARTICLES     " + text + "  ";
			string text4 = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    <=  Alert   and   STOCK <> 0  " + text2 + " ";
			string text5 = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    < 0  " + text2 + " ";
			string text6 = "select    count(ID)   as N    from  TABLE_ARTICLES    WHERE       PROMOTION <> 0     " + text2 + "  ";
			string text7 = "select    sum(STOCK * PRIX_MP)   as N   from  TABLE_ARTICLES  where  STOCK > 0     and    PRIX_MP > 0       " + text2 + "  ";
			string text8 = "select    count(ID)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "  ";
			string text9 = "select    sum(STOCK * PRIX_A)   as N   from  TABLE_ARTICLES  where  STOCK > 0     and    PRIX_A > 0       " + text2 + " ";
			string text10 = "select    count(ID)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "  ";
			string text11 = "select    sum(STOCK * PRIX_V_1)   as N   from  TABLE_ARTICLES  where  STOCK > 0     AND    PRIX_V_1 > 0      " + text2 + "   ";
			string text12 = "select    count(id)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_V_1 <= 0)       " + text2 + "  ";
			string text13 = "select    count(ID)   as N    from  TABLE_ARTICLES    WHERE        PRIX_QTE <> 0     " + text2 + "  ";
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = new DataTable();
			val = new MySqlDataAdapter(" ( " + text3 + " )       UNION ALL         ( " + text4 + " )        UNION ALL     ( " + text5 + " )      UNION ALL     ( " + text6 + " )      UNION ALL      ( " + text7 + " )      UNION ALL     ( " + text8 + " )     UNION ALL     ( " + text9 + " )      UNION ALL     ( " + text10 + " )     UNION ALL      ( " + text11 + " )       UNION ALL      ( " + text12 + " )      UNION ALL      ( " + text13 + " )       ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows[0]["N"] == DBNull.Value)
			{
				Label_ARTICLES.Text = Conversions.ToString(0);
			}
			else
			{
				Label_ARTICLES.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"])));
			}
			if (dataTable.Rows[1]["N"] == DBNull.Value)
			{
				Label_ALERTS_STOCK.Text = Conversions.ToString(0);
			}
			else
			{
				Label_ALERTS_STOCK.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[1]["N"])));
			}
			if (dataTable.Rows[2]["N"] == DBNull.Value)
			{
				Label_STOCK_NEGATIF.Text = Conversions.ToString(0);
			}
			else
			{
				Label_STOCK_NEGATIF.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[2]["N"])));
			}
			if (dataTable.Rows[3]["N"] == DBNull.Value)
			{
				Label_PROMOTIONS.Text = Conversions.ToString(0);
			}
			else
			{
				Label_PROMOTIONS.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[3]["N"])));
			}
			if (dataTable.Rows[4]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_MP.Text = (Conversions.ToString(0) + " DH").PadLeft(20, '#');
			}
			else
			{
				Label_VALEURSTOCK_MP.Text = (Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[4]["N"]))) + " DH").PadLeft(20, '#');
			}
			if (dataTable.Rows[5]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_MP_NON.Text = Conversions.ToString(0);
			}
			else
			{
				Label_VALEURSTOCK_MP_NON.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[5]["N"])));
			}
			if (dataTable.Rows[6]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_A.Text = (Conversions.ToString(0) + " DH").PadLeft(20, '#');
			}
			else
			{
				Label_VALEURSTOCK_A.Text = (Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[6]["N"]))) + " DH").PadLeft(20, '#');
			}
			if (dataTable.Rows[7]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_A_NON.Text = Conversions.ToString(0);
			}
			else
			{
				Label_VALEURSTOCK_A_NON.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[7]["N"])));
			}
			if (dataTable.Rows[8]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_V.Text = (Conversions.ToString(0) + " DH").PadLeft(20, '#');
			}
			else
			{
				Label_VALEURSTOCK_V.Text = (Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[8]["N"]))) + " DH").PadLeft(20, '#');
			}
			if (dataTable.Rows[9]["N"] == DBNull.Value)
			{
				Label_VALEURSTOCK_V_NON.Text = Conversions.ToString(0);
			}
			else
			{
				Label_VALEURSTOCK_V_NON.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[9]["N"])));
			}
			if (dataTable.Rows[10]["N"] == DBNull.Value)
			{
				Label_PRIX_QTE.Text = Conversions.ToString(0);
			}
			else
			{
				Label_PRIX_QTE.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[10]["N"])));
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
				string text14 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text14 + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text14 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Label_ALERTS_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select   *  from  TABLE_ARTICLES    WHERE       STOCK    <=  Alert   and   STOCK <> 0  " + text2 + " ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_STOCK_NEGATIF_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select   *   from  TABLE_ARTICLES    WHERE       STOCK    < 0  " + text2 + " ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_PROMOTIONS_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select   *   from  TABLE_ARTICLES    WHERE       PROMOTION <> 0     " + text2 + "  ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_PRIX_QTE_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select   *   from  TABLE_ARTICLES    WHERE       PRIX_QTE <> 0     " + text2 + "  ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_VALEURSTOCK_MP_NON_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select   *  from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "  ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_VALEURSTOCK_A_NON_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select    *  from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "   ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_VALEURSTOCK_V_NON_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		try
		{
			string text2 = default;
			if (Operators.CompareString(_FAMILLE_FILTRE, "", TextCompare: false) == 0)
			{
				_sql = "";
			}
			else
			{
				string text = "  WHERE  Famille =   '" + _FAMILLE_FILTRE + "'        ";
				text2 = "  AND      Famille =   '" + _FAMILLE_FILTRE + "'        ";
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select    *  from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_V_1 <= 0)       " + text2 + "   ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Label_VALEURSTOCK_MP_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Label_VALEURSTOCK_MP.Text.First()), "#", TextCompare: false) == 0)
		{
			Label_VALEURSTOCK_MP.Text = Label_VALEURSTOCK_MP.Text.Replace("#", "");
		}
		else
		{
			Label_VALEURSTOCK_MP.Text = Label_VALEURSTOCK_MP.Text.PadLeft(20, '#');
		}
	}

	private void Label_VALEURSTOCK_A_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Label_VALEURSTOCK_A.Text.First()), "#", TextCompare: false) == 0)
		{
			Label_VALEURSTOCK_A.Text = Label_VALEURSTOCK_A.Text.Replace("#", "");
		}
		else
		{
			Label_VALEURSTOCK_A.Text = Label_VALEURSTOCK_A.Text.PadLeft(20, '#');
		}
	}

	private void Label_VALEURSTOCK_V_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Label_VALEURSTOCK_V.Text.First()), "#", TextCompare: false) == 0)
		{
			Label_VALEURSTOCK_V.Text = Label_VALEURSTOCK_V.Text.Replace("#", "");
		}
		else
		{
			Label_VALEURSTOCK_V.Text = Label_VALEURSTOCK_V.Text.PadLeft(20, '#');
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

	private void TextBox13_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox16_TextChanged(object sender, EventArgs e)
	{
		Text_PRIX_V_2.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
	}

	private void TextBox15_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_CODE_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void TextBox17_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PRIX_MP_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void TextBox3_TextChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_Click(object sender, EventArgs e)
	{
	}

	private void RadioButton10_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton10_Click(object sender, EventArgs e)
	{
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton3_Click(object sender, EventArgs e)
	{
	}

	private void Button31_Click_1(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_ETIQUETTE_AUTOC_A4).ShowDialog();
	}

	private void Text_PRIX_V_2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Text_PRIX_V_2_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label25_Click(object sender, EventArgs e)
	{
	}

	private void Text_PRIX_A_KeyUp(object sender, KeyEventArgs e)
	{
	}

	private void Picture_IMAGE_Click(object sender, EventArgs e)
	{
		if (((Control)Panel_Picture_IMAGE_TOOLS).Height == 1)
		{
			Panel panel_Picture_IMAGE_TOOLS = Panel_Picture_IMAGE_TOOLS;
			Point point = new Point(127, 141);
			((Control)panel_Picture_IMAGE_TOOLS).Size = (Size)point;
		}
		else
		{
			Panel panel_Picture_IMAGE_TOOLS2 = Panel_Picture_IMAGE_TOOLS;
			Point point = new Point(127, 1);
			((Control)panel_Picture_IMAGE_TOOLS2).Size = (Size)point;
		}
	}

	private void Picture_IMAGE_DoubleClick(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		Bitmap val = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				PictureBox picture_IMAGE;
				Bitmap val2;
				Rectangle rectangle;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 290:
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
							goto IL_0025;
						case 4:
							goto IL_0043;
						case 5:
							goto IL_0074;
						case 6:
							goto IL_00a6;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 8:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0043:
					num2 = 4;
					val = new Bitmap(((Control)Picture_IMAGE).Size.Width, ((Control)Picture_IMAGE).Size.Height);
					goto IL_0074;
					IL_0074:
					num2 = 5;
					picture_IMAGE = Picture_IMAGE;
					val2 = val;
					rectangle = new Rectangle(0, 0, ((Control)Picture_IMAGE).Width, ((Control)Picture_IMAGE).Height);
					((Control)picture_IMAGE).DrawToBitmap(val2, rectangle);
					goto IL_00a6;
					IL_0025:
					num2 = 3;
					Picture_IMAGE.Image = ((Computer)MyProject.Computer).Clipboard.GetImage();
					goto IL_0043;
					IL_00a6:
					num2 = 6;
					Picture_IMAGE.Image = (Image)(object)val;
					break;
					IL_000a:
					num2 = 2;
					if (!((Computer)MyProject.Computer).Clipboard.ContainsImage())
					{
						goto end_IL_0001_3;
					}
					goto IL_0025;
					end_IL_0001_2:
					break;
				}
				num2 = 7;
				Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 290;
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

	private void Text_LIEN_PICTURE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_LIEN_PICTURE_DoubleClick(object sender, EventArgs e)
	{
		Picture_IMAGE.ImageLocation = Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text.ToString();
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		try
		{
			Text_LIEN_PICTURE.Text = "0.png";
			Picture_IMAGE.ImageLocation = Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text;
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

	private void Button26_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).InitialDirectory = Module1._CHEMIN_FOLDER + "\\bd\\Galerie";
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				Picture_IMAGE.Image = Image.FromFile(((FileDialog)val).FileName);
				Bitmap val2 = new Bitmap(((Control)Picture_IMAGE).Size.Width, ((Control)Picture_IMAGE).Size.Height);
				PictureBox picture_IMAGE = Picture_IMAGE;
				Rectangle rectangle = new Rectangle(0, 0, ((Control)Picture_IMAGE).Width, ((Control)Picture_IMAGE).Height);
				((Control)picture_IMAGE).DrawToBitmap(val2, rectangle);
				Picture_IMAGE.Image = (Image)(object)val2;
				Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
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

	private void Button29_Click(object sender, EventArgs e)
	{
		if (((Control)Panel_COULEUR).Visible)
		{
			((Control)Panel_COULEUR).Visible = false;
			return;
		}
		Panel panel_COULEUR = Panel_COULEUR;
		Point location = checked(new Point((int)Math.Round((double)((Control)Panel_INFO).Width / 2.0 - (double)((Control)Panel_COULEUR).Width / 2.0), (int)Math.Round((double)((Control)Panel_INFO).Height / 2.0 - (double)((Control)Panel_COULEUR).Height / 2.0)));
		((Control)panel_COULEUR).Location = location;
		((Control)Panel_COULEUR).Visible = true;
		((Control)Panel_COULEUR).BringToFront();
	}

	private void Button31_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_google).Show();
		((Form)MyProject.Forms.FormDialog_google).Text = "ARTICLE";
		((Control)MyProject.Forms.FormDialog_google.Button_TEXT).BringToFront();
		MyProject.Forms.FormDialog_google.Button_TEXT.PerformClick();
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_google).Show();
		((Form)MyProject.Forms.FormDialog_google).Text = "ARTICLE";
		((Control)MyProject.Forms.FormDialog_google.Button_bd).BringToFront();
		MyProject.Forms.FormDialog_google.Button_bd.PerformClick();
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_google).Show();
		((Form)MyProject.Forms.FormDialog_google).Text = "ARTICLE";
		((Control)MyProject.Forms.FormDialog_google.Button_google).BringToFront();
		MyProject.Forms.FormDialog_google.Button_google.PerformClick();
	}

	private void Panel_FIND_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button_VENTES_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		((Control)DataGrid_VENTES).BringToFront();
		string text = "AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '";
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select      DATES,TICKET,ID_ARTICLE,ARTICLE,PRIX_V,QTé,CLIENT            from   TABLE_VENTES_JOURNAL     Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'          " + text + "          order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGrid_VENTES.AutoGenerateColumns = false;
		DataGrid_VENTES.DataSource = dataTable;
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
		dataTable2.Clear();
		dataTable2 = new DataTable();
		val2 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n from TABLE_VENTES_JOURNAL WHERE         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'      AND    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ')       UNION ALL        (select sum(Qté) as n from TABLE_VENTES_JOURNAL  WHERE         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'      AND    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        )    ", Module1.cn_SQL);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		Label30303.Text = "TOTAL MONTANT : " + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["n"].ToString())) + " DH  -  TOTAL QTE : " + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[1]["n"].ToString()));
	}

	private void Button_RECEPTIONS_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		((Control)DataGrid_RECEPTIONS).BringToFront();
		string text = "AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '";
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select    DATES,ID_BR,ID_ARTICLE,ARTICLE,PRIX_A,QTé,FOURNISSEUR          from   TABLE_RECEPTIONS_DETAILS    Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'         AND    ETAT = 'VALIDER'          " + text + "          order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGrid_RECEPTIONS.AutoGenerateColumns = false;
		DataGrid_RECEPTIONS.DataSource = dataTable;
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
		dataTable2.Clear();
		dataTable2 = new DataTable();
		val2 = new MySqlDataAdapter("(select sum(TOTAL_NET_ACHATS) as n from TABLE_RECEPTIONS_DETAILS           Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'            AND    ETAT = 'VALIDER'             AND    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ')       UNION ALL        (select sum(Qté) as n from TABLE_RECEPTIONS_DETAILS      Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'            AND    ETAT = 'VALIDER'           AND    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        )    ", Module1.cn_SQL);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		Label30303.Text = "TOTAL MONTANT : " + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["n"].ToString())) + " DH  -  TOTAL QTE : " + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[1]["n"].ToString()));
	}

	private void Button_SORTIES_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		((Control)DataGrid_SORTIES).BringToFront();
		string text = "AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '";
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select       DATES,ID_BS,ID_ARTICLE,Article,Qté            from   TABLE_SORTIES_DETAILS     Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'              AND    ETAT = 'VALIDER'              " + text + "          order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGrid_SORTIES.AutoGenerateColumns = false;
		DataGrid_SORTIES.DataSource = dataTable;
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
		dataTable2.Clear();
		dataTable2 = new DataTable();
		val2 = new MySqlDataAdapter(" (select sum(Qté) as n from TABLE_SORTIES_DETAILS  WHERE         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'            AND    ETAT = 'VALIDER'            AND    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        )    ", Module1.cn_SQL);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		Label30303.Text = "TOTAL QTE : " + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["n"].ToString()));
	}

	private void Button_INVENTAIRES_Click(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		((Control)DataGrid_INVENTAIRES).BringToFront();
		string text = "AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '";
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select        DATES,ID_INV,ID_ARTICLE,ARTICLE,STOCK_PHYSIQUE              from   TABLE_INVENTAIRES_DETAILS    Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'         AND    ETAT = 'VALIDER'          " + text + "          order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGrid_INVENTAIRES.AutoGenerateColumns = false;
		DataGrid_INVENTAIRES.DataSource = dataTable;
		Label30303.Text = "-";
	}

	private void Button_MOUVEMENTS_Click(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		((Control)DataGrid_MOUVEMENTS).BringToFront();
		string text = "AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '";
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select        DATES,LIBELLE,ID_ARTICLE,ARTICLE,QUANTITE             from   TABLE_MOUVEMENTS_STOCK     Where         ID_ARTICLE  =  '" + Text_ID_ARTICLE.Text + "'          " + text + "          order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGrid_MOUVEMENTS.AutoGenerateColumns = false;
		DataGrid_MOUVEMENTS.DataSource = dataTable;
		Label30303.Text = "";
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form_2_Familles).ShowDialog();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		((Form)MyProject.Forms.Form_6_FOURNISSEURS).ShowDialog();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select DISTINCT FOURNISSEUR from TABLE_FOURNISSEURS ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_FOURNISSEUR.Items.Clear();
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
					Combo_FOURNISSEUR.Items.Add((object)dataTable.Rows[num2]["FOURNISSEUR"].ToString());
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Panel11_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				((Control)Panel_FONCTIONS).Hide();
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "Text Files (*.csv)|*.csv";
				((FileDialog)val).FileName = "Articles_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
				if (unchecked((int)((CommonDialog)val).ShowDialog()) != 1)
				{
					return;
				}
				string separator = ";";
				StringBuilder stringBuilder = new StringBuilder();
				int num = DataGridView1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string[] array = new string[((BaseCollection)DataGridView1.Columns).Count - 3 + 1];
					if (num2.Equals(0))
					{
						int num5 = ((BaseCollection)DataGridView1.Columns).Count - 3;
						int num6 = 1;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							array[num6] = DataGridView1.Columns[num6].HeaderText;
							num6++;
						}
						stringBuilder.AppendLine(string.Join(separator, array));
					}
					int num8 = ((BaseCollection)DataGridView1.Columns).Count - 3;
					int num9 = 1;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						if (!DataGridView1.Rows[num2].IsNewRow)
						{
							if (DataGridView1[num9, num2].Value == DBNull.Value)
							{
								array[num9] = "";
							}
							else
							{
								array[num9] = Conversions.ToString(DataGridView1[num9, num2].Value);
							}
						}
						num9++;
					}
					if (!DataGridView1.Rows[num2].IsNewRow)
					{
						stringBuilder.AppendLine(string.Join(separator, array));
					}
					num2++;
				}
				File.WriteAllText(((FileDialog)val).FileName, stringBuilder.ToString(), Encoding.Default);
				MessageBox.Show("exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void Button6_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Hide();
		((Control)Panel13243).Show();
		((Control)Panel13243).BringToFront();
		DataGridView_TRIAGE.RowTemplate.Height = 35;
		DataGridView_TRIAGE.Rows.Add(new object[1] { "ID" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Code" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Article" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Famille" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Stock" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Prix_V_1" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Prix_A" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "Prix_MP" });
		DataGridView_TRIAGE.Rows.Add(new object[1] { "PROMOTION" });
	}

	private void Button_FONCTIONS_Click(object sender, EventArgs e)
	{
		if (((Control)Panel_FONCTIONS).Visible)
		{
			((Control)Panel_FONCTIONS).Hide();
			return;
		}
		((Control)Panel_FONCTIONS).Show();
		((Control)Panel_FONCTIONS).BringToFront();
		checked
		{
			((Control)Panel_FONCTIONS).Left = (int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_FONCTIONS).Width / 2.0);
			((Control)Panel_FONCTIONS).Top = (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel_FONCTIONS).Height / 2.0);
		}
	}

	private void Button_FERMER_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Visible = false;
	}

	private void Button_ETAT_STOCK_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		((Control)Panel_FONCTIONS).Hide();
		((Form)this).AddOwnedForm((Form)(object)MyProject.Forms.FormDialog_ETAT_STOCK);
		((Control)MyProject.Forms.FormDialog_ETAT_STOCK).Show();
		if ((int)((Form)MyProject.Forms.FormDialog_ETAT_STOCK).WindowState == 1)
		{
			((Form)MyProject.Forms.FormDialog_ETAT_STOCK).WindowState = (FormWindowState)0;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Component)(object)MyProject.Forms.FormDialog_ETAT_ALERTS_PEREMPTION).Dispose();
		((Form)MyProject.Forms.FormDialog_ETAT_ALERTS_PEREMPTION).ShowDialog();
	}

	private void Button_PRIXEGALE_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
		if (Module1._acces)
		{
			if (Module1._acces)
			{
				Module1._acces = false;
			}
			string right = Conversions.ToString(Operators.ConcatenateObject("OPERATION | ", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
			File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = new DataTable();
			val = new MySqlDataAdapter("UPDATE     TABLE_ARTICLES    SET PRIX_MP =  PRIX_A      ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DT.Clear();
			DA = new MySqlDataAdapter("select * from      TABLE_" + Label_TABLE.Text + "                  order by   Famille,Article    Asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by STOCK asc", Module1.cn_SQL);
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

	private void RadioButton4_CheckedChanged_1(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by PRIX_V_1 asc", Module1.cn_SQL);
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

	private void RadioButton8_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by PRIX_A asc", Module1.cn_SQL);
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

	private void RadioButton10_CheckedChanged_1(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from TABLE_ARTICLES order by PRIX_MP asc", Module1.cn_SQL);
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

	private void Button_BALANCE_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (unchecked((int)MessageBox.Show("Voulez-vous vraiment Exporter les données vers les balances  ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0)) != 1)
				{
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER_BALANCE formDialog_PATIENTER_BALANCE = new FormDialog_PATIENTER_BALANCE();
						((Form)formDialog_PATIENTER_BALANCE).ShowDialog();
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
				((TextBoxBase)Text_BALANCE).Clear();
				DT.Clear();
				DA = new MySqlDataAdapter("select * from TABLE_ARTICLES    where  BALANCE = 'OUI'     order by Code,Article asc", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				string text = "";
				string text2 = "";
				string text3 = "A";
				int num = (int)Math.Round(Conversion.Val(TextBox_NBR_CODE_ARTICLE.Text));
				int num2 = DataGridView1.Rows.Count - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					string inputStr = Conversions.ToString(DataGridView1.Rows[num3].Cells["CODE"].Value);
					string inputStr2 = Conversions.ToString(Operators.MultiplyObject(DataGridView1.Rows[num3].Cells["PRIX_V_1"].Value, 100));
					string source = Conversions.ToString(DataGridView1.Rows[num3].Cells["ARTICLE"].Value);
					if (Operators.CompareString(DataGridView1.Rows[num3].Cells["UNITE"].Value.ToString(), "KG", TextCompare: false) == 0)
					{
						text2 = "W";
					}
					else if (Operators.CompareString(DataGridView1.Rows[num3].Cells["UNITE"].Value.ToString(), "PCS", TextCompare: false) == 0)
					{
						text2 = "U";
					}
					else if ((Operators.CompareString(DataGridView1.Rows[num3].Cells["UNITE"].Value.ToString(), "", TextCompare: false) == 0) | ((object)DataGridView1.Rows[num3].Cells["UNITE"].Value.ToString() == DBNull.Value))
					{
						text2 = "W";
					}
					text = text + Strings.LSet(Conversion.Val(inputStr).ToString(Strings.StrDup(num, "0")), num) + "|" + Strings.LSet(Conversion.Val(inputStr).ToString("000"), 3) + "|" + Strings.LSet(source, 20) + "|" + Strings.RSet(Conversions.ToString(Conversion.Val(inputStr2)), 7) + "|" + text2 + "|" + text3 + "|" + Environment.NewLine;
					num3++;
				}
				Text_BALANCE.Text = text;
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\logica.dat", Text_BALANCE.Text);
				Module1._QUITTER_PATIENTER = true;
				MessageBox.Show("Exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_FAMILLES_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.Form_2_Familles).ShowDialog();
	}

	private void Button_RAPPORT_Click(object sender, EventArgs e)
	{
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		try
		{
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_code.Text = "";
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_article.Text = "";
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_prix_v.Text = "";
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_promotion.Text = "";
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_LIBRE.Text = "";
			int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_code.Text = DT.Rows[position]["Code"].ToString();
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_article.Text = DT.Rows[position]["Article"].ToString();
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_prix_v.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position]["Prix_V_1"].ToString())));
			MyProject.Forms.FormDialog_ETIQUETTE_AUTOC.Text_promotion.Text = DT.Rows[position]["Promotion"].ToString();
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
		((Form)MyProject.Forms.FormDialog_ETIQUETTE_AUTOC).ShowDialog();
		((Component)(object)MyProject.Forms.FormDialog_ETIQUETTE_AUTOC).Dispose();
	}

	private void Panel0_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button73434_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		((Form)MyProject.Forms.FormDialog_LISTE_TAILLES).ShowDialog();
		string text = Combo_TAILLES.Text;
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select   *    from TABLE_LISTE_TAILLES ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_TAILLES.Items.Clear();
		DataGridView_TAILLES.Rows.Clear();
		checked
		{
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
				System.Windows.Forms.ComboBox.ObjectCollection items = Combo_TAILLES.Items;
				KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num2]["CODE_TAILLE"].ToString(), dataTable.Rows[num2]["TAILLE"].ToString());
				items.Add((object)keyValuePair);
				DataGridView_TAILLES.Rows.Add(new object[2]
				{
					dataTable.Rows[num2]["CODE_TAILLE"].ToString(),
					dataTable.Rows[num2]["TAILLE"].ToString()
				});
				num2++;
			}
			((ListControl)Combo_TAILLES).ValueMember = "Key";
			((ListControl)Combo_TAILLES).DisplayMember = "Value";
			Combo_TAILLES.Text = text;
		}
	}

	private void Button85454_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		((Form)MyProject.Forms.FormDialog_LISTE_COULEURS).ShowDialog();
		string text = Combo_COULEURS.Text;
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select   *    from TABLE_LISTE_COULEURS ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_COULEURS.Items.Clear();
		DataGridView_COULEURS.Rows.Clear();
		checked
		{
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
				System.Windows.Forms.ComboBox.ObjectCollection items = Combo_COULEURS.Items;
				KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num2]["CODE_COULEUR"].ToString(), dataTable.Rows[num2]["COULEUR"].ToString());
				items.Add((object)keyValuePair);
				DataGridView_COULEURS.Rows.Add(new object[2]
				{
					dataTable.Rows[num2]["CODE_COULEUR"].ToString(),
					dataTable.Rows[num2]["COULEUR"].ToString()
				});
				num2++;
			}
			((ListControl)Combo_COULEURS).ValueMember = "Key";
			((ListControl)Combo_COULEURS).DisplayMember = "Value";
			Combo_COULEURS.Text = text;
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_ATTRIBUTIONS).Show();
		((Form)MyProject.Forms.FormDialog_ATTRIBUTIONS).TopMost = true;
		((Control)MyProject.Forms.FormDialog_ATTRIBUTIONS).Top = 0;
		((Control)MyProject.Forms.FormDialog_ATTRIBUTIONS).Left = checked(((Control)MyProject.Forms.Form_0_TEMPLATE).Width - ((Control)MyProject.Forms.FormDialog_ATTRIBUTIONS).Width);
	}

	private void Button10767_Click(object sender, EventArgs e)
	{
		((Control)Panel13243).Hide();
	}

	private void DataGridView_TRIAGE_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_TRIAGE_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		try
		{
			string right = "";
			if (RadioButton1.Checked)
			{
				right = "ASC";
			}
			else if (RadioButton2.Checked)
			{
				right = "DESC";
			}
			DT.Clear();
			DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from TABLE_ARTICLES       order by     ", DataGridView_TRIAGE.Rows[((DataGridViewBand)DataGridView_TRIAGE.CurrentRow).Index].Cells[0].Value), "     "), right), "     ")), Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
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

	private void Text_PROMOTION_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Button_PROMOTION_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		checked
		{
			try
			{
				((Control)Panel_FONCTIONS).Hide();
				((Control)Panel1233).Show();
				((Control)Panel1233).BringToFront();
				Module1._DT_TEMP.Clear();
				Module1._DA_TEMP = new MySqlDataAdapter("select FAMILLE from     TABLE_FAMILLES          order by  FAMILLE    asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
				int num = Module1._DT_TEMP.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).Add((object)Module1._DT_TEMP.Rows[num2]["Famille"].ToString());
						num2++;
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

	private void Button10_Click(object sender, EventArgs e)
	{
		((Control)Panel1233).Hide();
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox154545.Text, "", TextCompare: false) == 0 || decimal.Compare(Conversions.ToDecimal(TextBox154545.Text), 100m) > 0)
		{
			MessageBox.Show("Veuillez remplir le champ -PROMOTION- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) != 1)
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
					string right = "PROMOTION | ";
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
					foreach (object checkedItem in CheckedListBox1.CheckedItems)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter(" Update TABLE_ARTICLES      SET     promotion =  " + Conversions.ToString(Conversions.ToDecimal(TextBox154545.Text)) + "      WHERE  Famille   =  '" + objectValue.ToString() + "'  ", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
					}
					Module1._QUITTER_PATIENTER = true;
					MessageBox.Show("Exécutée avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
	}

	private void Button_M_SHIFTS_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_IMPORTER_ARTICLES).ShowDialog();
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)Panel_FONCTIONS).Hide();
			((Form)MyProject.Forms.FormDialog_ETAT_ALERTES_STOCK).ShowDialog();
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

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		try
		{
			if (((Control)Panel119898).Width == 0)
			{
				((Control)Panel119898).Width = 200;
				_DT_FAMILLE_FILTRAGE.Clear();
				_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select FAMILLE from     TABLE_FAMILLES          order by  FAMILLE    asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
				DataGridView_FILTRAGE.RowTemplate.Height = 40;
				DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
			}
			else
			{
				((Control)Panel119898).Width = 0;
				_FAMILLE_FILTRE = "";
				Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void TextBox14343_TextChanged(object sender, EventArgs e)
	{
		Button_RJ16576_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button_RJ16576_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		try
		{
			_DT_FAMILLE_FILTRAGE.Clear();
			_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select FAMILLE from     TABLE_FAMILLES      Where          (FAMILLE  like  '%" + TextBox14343.Text + "%'   )                                order by  FAMILLE    asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
			DataGridView_FILTRAGE.RowTemplate.Height = 40;
			DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
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

	private void Button_RJ38787_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		try
		{
			TextBox14343.Text = "";
			_DT_FAMILLE_FILTRAGE.Clear();
			_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select   FAMILLE    from      TABLE_FAMILLES                  order by   FAMILLE    asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
			DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
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

	private void DataGridView_FILTRAGE_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_FILTRAGE_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from TABLE_ARTICLES WHERE Famille =  '", DataGridView_FILTRAGE.Rows[((DataGridViewBand)DataGridView_FILTRAGE.CurrentRow).Index].Cells[0].Value), "'     order by        Famille,Article      asc")), Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			_FAMILLE_FILTRE = Conversions.ToString(DataGridView_FILTRAGE.Rows[((DataGridViewBand)DataGridView_FILTRAGE.CurrentRow).Index].Cells[0].Value);
			Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void Text_FIND_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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
			ProjectData.ClearProjectError();
		}
	}

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Combo_FIND.Text, "Code", TextCompare: false) != 0 && Text_FIND.Texts.Length > 2)
		{
			Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void Picture_FIND_DATES_Click(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Invalid comparison between Unknown and I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
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
				if (((((Control)Button_ADD_COLLECTION).Visible && Operators.CompareString(Combo_FIND.Text, "Code", TextCompare: false) == 0) ? true : false) && (int)MessageBox.Show("Voulez-vous Afficher toute la collection ??", "", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
				{
					string right = Text_FIND.Texts.ToString().Substring(0, 6);
					if (Check_FIND_DATE.Checked)
					{
						_sql = "        Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '         AND     ";
					}
					else
					{
						_sql = "";
					}
					DT.Clear();
					DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where            "), _sql), "            ( SUBSTRING(CODE,0,6)         =  '"), right), "'   )                                order by   ID    desc ")), Module1.cn_SQL);
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
			Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
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
						checked(dataTable.Rows[dataTable.Rows.Count - 1][val4.ColumnIndex - 1]) = val4.Value.ToString();
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

	private void PictureBox_ROBOT_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox_ROBOT_DoubleClick(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		DT.Clear();
		((Component)(object)MyProject.Forms.FormDialog_ROBOT).Dispose();
		((Form)MyProject.Forms.FormDialog_ROBOT).ShowDialog();
	}

	private void PictureBox24556_MouseDown(object sender, MouseEventArgs e)
	{
		checked
		{
			x = Control.MousePosition.X - ((Control)PictureBox_ROBOT).Location.X;
			y = Control.MousePosition.Y - ((Control)PictureBox_ROBOT).Location.Y;
		}
	}

	private void PictureBox24556_MouseMove(object sender, MouseEventArgs e)
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
				((Control)PictureBox_ROBOT).Location = newpoint;
				Application.DoEvents();
			}
		}
	}

	private void Button_ETAT_LISTE_ARTICLES_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		((Control)Panel_FONCTIONS).Hide();
		((Form)this).AddOwnedForm((Form)(object)MyProject.Forms.FormDialog_ETAT_LISTE_ARTICLES);
		((Control)MyProject.Forms.FormDialog_ETAT_LISTE_ARTICLES).Show();
		if ((int)((Form)MyProject.Forms.FormDialog_ETAT_LISTE_ARTICLES).WindowState == 1)
		{
			((Form)MyProject.Forms.FormDialog_ETAT_LISTE_ARTICLES).WindowState = (FormWindowState)0;
		}
	}

	private void Check_FIND_DATE_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
	{
	}

	private void Picture_COLOR_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Picture_IMAGE.Image = null;
		((Control)Picture_IMAGE).BackColor = Color.White;
		PictureBox picture_IMAGE = Picture_IMAGE;
		object obj = NewLateBinding.LateGet(sender, null, "BackColor", new object[0], null, null, null);
		Color color = default;
		((Control)picture_IMAGE).BackColor = ((obj != null) ? ((Color)obj) : color);
		Bitmap val = new Bitmap(((Control)Picture_IMAGE).Size.Width, ((Control)Picture_IMAGE).Size.Height);
		PictureBox picture_IMAGE2 = Picture_IMAGE;
		Rectangle rectangle = new Rectangle(0, 0, ((Control)Picture_IMAGE).Width, ((Control)Picture_IMAGE).Height);
		((Control)picture_IMAGE2).DrawToBitmap(val, rectangle);
		Picture_IMAGE.Image = (Image)(object)val;
		Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
		((Control)Panel_COULEUR).Visible = false;
	}

	private void Button_ADD_COLLECTION_Click(object sender, EventArgs e)
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_INFO_COLLECTION).Visible = true;
			((Control)Panel_INFO_COLLECTION).BringToFront();
			Label_TOP_COLLECTION.Text = "NOUVEAU";
			Text_CODE_COLLECTION.Text = "";
			Text_ARTICLE_COLLECTION.Text = "";
			Combo_FAMILLE_COLLECTION.Text = "";
			Text_PRIX_A_COLLECTION.Text = "0";
			Text_PRIX_V_COLLECTION.Text = "0";
			Text_QTE_COLLECTION.Text = "0";
			DataGrid_COLLECTION.Rows.Clear();
			((Control)Text_QTE_COLLECTION).Enabled = true;
			if (!Conversions.ToBoolean(TextBox_AJOUT_STOCK_MANUEL.Text))
			{
				((Control)Text_QTE_COLLECTION).Enabled = false;
				((Control)Button_MOINS).Enabled = false;
				((Control)Button_PLUS).Enabled = false;
			}
			((Control)Text_CODE_COLLECTION).Focus();
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

	private void Button_GENERER_COLLECTION_Click(object sender, EventArgs e)
	{
		Random random = new Random();
		int num = random.Next(1000, 9999);
		Text_CODE_COLLECTION.Text = "22" + num.ToString("0000");
	}

	private void Text_PRIX_A_COLLECTION_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PRIX_A_COLLECTION_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Text_PRIX_V_COLLECTION_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PRIX_V_COLLECTION_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Button_INSERER_Click(object sender, EventArgs e)
	{
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_CODE_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Code- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Text_CODE_COLLECTION.Text.Length != 6)
				{
					MessageBox.Show("Erreur sur le champ -Code- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_ARTICLE_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Article- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_A_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Prix_A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_V_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Prix_V- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Text_CODE_COLLECTION.Text + "99", DataGridView_TAILLES.Rows[((DataGridViewBand)DataGridView_TAILLES.CurrentRow).Index].Cells["CODE_TAILLE"].Value), DataGridView_COULEURS.Rows[((DataGridViewBand)DataGridView_COULEURS.CurrentRow).Index].Cells["CODE_COULEUR"].Value));
				string text2 = Text_ARTICLE_COLLECTION.Text;
				string text3 = Conversions.ToString(DataGridView_TAILLES.Rows[((DataGridViewBand)DataGridView_TAILLES.CurrentRow).Index].Cells["TAILLE"].Value);
				string text4 = Conversions.ToString(DataGridView_COULEURS.Rows[((DataGridViewBand)DataGridView_COULEURS.CurrentRow).Index].Cells["COULEUR"].Value);
				decimal num = Conversions.ToDecimal(Text_QTE_COLLECTION.Text);
				int num2 = 0;
				int num3 = 0;
				byte[] array = new byte[13];
				int num4 = 0;
				int num5;
				int num6;
				do
				{
					array[num4] = (byte)Conversions.ToInteger(text.Substring(num4, 1));
					if (unchecked(num4 % 2) == 1)
					{
						num3 += array[num4];
					}
					else
					{
						num2 += array[num4];
					}
					num4++;
					num5 = num4;
					num6 = 11;
				}
				while (num5 <= num6);
				unchecked
				{
					num4 = checked(num2 + num3 * 3) % 10;
				}
				if (num4 == 0)
				{
					array[12] = 0;
				}
				else
				{
					array[12] = (byte)(10 - num4);
				}
				byte[] bits = Module1.getBits(array);
				text += Conversions.ToString(array[12]);
				int num7 = DataGrid_COLLECTION.Rows.Count - 1;
				num4 = 0;
				while (true)
				{
					int num8 = num4;
					num6 = num7;
					if (num8 > num6)
					{
						break;
					}
					if (Operators.CompareString(DataGrid_COLLECTION.Rows[num4].Cells["CODE_BARRE_LISTE"].Value.ToString(), text, TextCompare: false) == 0)
					{
						MessageBox.Show("Le CODE_BARRE est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					num4++;
				}
				if (!Versioned.IsNumeric(Text_QTE_COLLECTION.Text))
				{
					MessageBox.Show("Vérifier le champ -QUANTITE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				DataGrid_COLLECTION.Rows.Add(new object[5] { text, text2, text3, text4, num });
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				Text_QTE_COLLECTION.Text = "0";
				DataGrid_COLLECTION.CurrentCell = DataGrid_COLLECTION.Rows[DataGrid_COLLECTION.Rows.Count - 1].Cells[0];
				DataGrid_COLLECTION.Rows[DataGrid_COLLECTION.Rows.Count - 1].Selected = true;
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
		}
	}

	private void Button_CALC_DOC_Click(object sender, EventArgs e)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		checked
		{
			try
			{
				decimal num = 0m;
				int num2 = DataGrid_COLLECTION.Rows.Count - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					num = Conversions.ToDecimal(Operators.AddObject(num, DataGrid_COLLECTION.Rows[num3].Cells["Qté_LISTE"].Value));
					num3++;
				}
				Label_TOTAL_QUANTITE_DOC.Text = Conversions.ToString(Module1.FLOUSS(num));
				Label_NBR_ARTICLES_DOC.Text = Conversions.ToString(DataGrid_COLLECTION.Rows.Count);
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

	private void DataGrid_COLLECTION_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		try
		{
			if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				DataGrid_COLLECTION.Rows.RemoveAt(DataGrid_COLLECTION.CurrentCell.RowIndex);
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

	private void Button23232_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		((Form)MyProject.Forms.FormDialog_LISTE_TAILLES).ShowDialog();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select   *    from TABLE_LISTE_TAILLES ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_TAILLES.Items.Clear();
		DataGridView_TAILLES.Rows.Clear();
		checked
		{
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
				System.Windows.Forms.ComboBox.ObjectCollection items = Combo_TAILLES.Items;
				KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num2]["CODE_TAILLE"].ToString(), dataTable.Rows[num2]["TAILLE"].ToString());
				items.Add((object)keyValuePair);
				DataGridView_TAILLES.Rows.Add(new object[2]
				{
					dataTable.Rows[num2]["CODE_TAILLE"].ToString(),
					dataTable.Rows[num2]["TAILLE"].ToString()
				});
				num2++;
			}
			((ListControl)Combo_TAILLES).ValueMember = "Key";
			((ListControl)Combo_TAILLES).DisplayMember = "Value";
		}
	}

	private void Button23233_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		((Form)MyProject.Forms.FormDialog_LISTE_COULEURS).ShowDialog();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select   *    from TABLE_LISTE_COULEURS ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_COULEURS.Items.Clear();
		DataGridView_COULEURS.Rows.Clear();
		checked
		{
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
				System.Windows.Forms.ComboBox.ObjectCollection items = Combo_COULEURS.Items;
				KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(dataTable.Rows[num2]["CODE_COULEUR"].ToString(), dataTable.Rows[num2]["COULEUR"].ToString());
				items.Add((object)keyValuePair);
				DataGridView_COULEURS.Rows.Add(new object[2]
				{
					dataTable.Rows[num2]["CODE_COULEUR"].ToString(),
					dataTable.Rows[num2]["COULEUR"].ToString()
				});
				num2++;
			}
			((ListControl)Combo_COULEURS).ValueMember = "Key";
			((ListControl)Combo_COULEURS).DisplayMember = "Value";
		}
	}

	private void Button_CLOSE_COLLECTION_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO_COLLECTION).Hide();
	}

	private void Button_SAVE_COLLECTION_Click(object sender, EventArgs e)
	{
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Strings.Trim(Text_CODE_COLLECTION.Text), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Code- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Strings.Trim(Text_ARTICLE_COLLECTION.Text), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Article- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_FAMILLE_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Famille- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_A_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_V_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX_V_1- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_REFERENCE_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -REFERENCE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_FOURNISSEUR_COLLECTION.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -FOURNISSEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Text_ARTICLE_COLLECTION.Text = Text_ARTICLE_COLLECTION.Text.ToString().Replace("'", " ");
				if (Operators.CompareString(Label_TOP_COLLECTION.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					int num = 0;
					int num2 = DataGrid_COLLECTION.Rows.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select ID,Code,Article     from TABLE_ARTICLES WHERE   Code = '", DataGrid_COLLECTION.Rows[num3].Cells[0].Value), "'      ")), Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable.Rows[0]["Article"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
						DataGrid_COLLECTION.CurrentCell = DataGrid_COLLECTION.Rows[DataGrid_COLLECTION.Rows.Count - 1].Cells[0];
						DataGrid_COLLECTION.Rows[DataGrid_COLLECTION.Rows.Count - 1].Selected = true;
						num3++;
					}
					MySqlCommand val2 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					MySqlTransaction val3 = (val2.Transaction = Module1.cn_SQL.BeginTransaction());
					try
					{
						int num6 = DataGrid_COLLECTION.Rows.Count - 1;
						int num7 = 0;
						while (true)
						{
							int num8 = num7;
							int num5 = num6;
							if (num8 > num5)
							{
								break;
							}
							val2.CommandText = "SELECT MAX(ID) From TABLE_ARTICLES ";
							val2.Connection = Module1.cn_SQL;
							val2.CommandType = CommandType.Text;
							if (Module1.cn_SQL.State != ConnectionState.Open)
							{
								Module1.cn_SQL.Open();
							}
							int num9 = ((val2.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val2.ExecuteScalar()) + 1.0)));
							val2.CommandText = "Select ARTICLE from TABLE_NUM  where ID = 0 ";
							val2.Connection = Module1.cn_SQL;
							val2.CommandType = CommandType.Text;
							if (Module1.cn_SQL.State != ConnectionState.Open)
							{
								Module1.cn_SQL.Open();
							}
							string text = ((val2.ExecuteScalar() != DBNull.Value) ? ("ART" + Strings.Format(Conversions.ToDouble(val2.ExecuteScalar()), "000000")) : Conversions.ToString(0));
							val2.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_ARTICLES              ( ID,ID_ARTICLE,Code,Article,Famille,Sous_Famille,Description,Prix_A,PRIX_MP,PRIX_V_1,PRIX_V_2,STOCK,Alert,DATES,DATE_INVENTAIRE,STOCK_INITIAL,TAUX_TVA,UNITE,REFERENCE,FOURNISSEUR,MODE_STOCK,PRINTER,PRINTER_DUPLICATA,Images,Taille,Couleur,Emplacement,PROMOTION,FENETRE_PESAGE,BALANCE )      values           ('" + Conversions.ToString(num9), "' ,'"), text), "' ,   '"), DataGrid_COLLECTION.Rows[num7].Cells["CODE_BARRE_LISTE"].Value), "','"), Strings.Trim(Conversions.ToString(DataGrid_COLLECTION.Rows[num7].Cells["ARTICLE_LISTE"].Value))), "' ,'"), Strings.Trim(Combo_FAMILLE_COLLECTION.Text)), "' , '' , ''       , "), Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_A_COLLECTION.Text))), " ,"), Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_A_COLLECTION.Text))), " ,"), Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_V_COLLECTION.Text))), " ,"), Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_V_COLLECTION.Text))), " ,"), DataGrid_COLLECTION.Rows[num7].Cells["Qté_LISTE"].Value), ", 0  , '"), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), "'    , '"), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), "'    ,"), DataGrid_COLLECTION.Rows[num7].Cells["Qté_LISTE"].Value), "   ,   0   ,  '',  '"), Text_REFERENCE_COLLECTION.Text), "' , '"), Combo_FOURNISSEUR_COLLECTION.Text), "' , 'FINI' ,   '0',   '0',   '0'  ,'"), DataGrid_COLLECTION.Rows[num7].Cells["TAILLE_LISTE"].Value), "' ,'"), DataGrid_COLLECTION.Rows[num7].Cells["COULEUR_LISTE"].Value), "'  , '' , '0'  ,    ''  ,   ''  )   "));
							val2.Connection = Module1.cn_SQL;
							val2.ExecuteNonQuery();
							val2.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("yyyy-MM-dd"), "' ,  '"), DateTime.Now.ToString("HH:mm:ss")), "'  ,'Création d''article'    ,'"), text), "' ,'"), DataGrid_COLLECTION.Rows[num7].Cells["CODE_BARRE_LISTE"].Value), "' ,'"), DataGrid_COLLECTION.Rows[num7].Cells["ARTICLE_LISTE"].Value), "'  ,'"), DataGrid_COLLECTION.Rows[num7].Cells["Qté_LISTE"].Value), "'       )        "));
							val2.Connection = Module1.cn_SQL;
							val2.ExecuteNonQuery();
							val2.CommandText = "UPDATE     TABLE_NUM    SET ARTICLE =  ARTICLE + 1   ";
							val2.Connection = Module1.cn_SQL;
							val2.ExecuteNonQuery();
							Application.DoEvents();
							Thread.Sleep(1);
							DataGrid_COLLECTION.CurrentCell = DataGrid_COLLECTION.Rows[num7].Cells[0];
							num7++;
						}
						val3.Commit();
						Module1.cn_SQL.Close();
						MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception e2 = ex;
						StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						int fileLineNumber = frame.GetFileLineNumber();
						val3.Rollback();
						Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
						ProjectData.ClearProjectError();
					}
				}
				((Control)Panel_INFO_COLLECTION).Hide();
				Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				Combo_FIND.Text = "REFERENCE";
				((Control)Text_FIND).Focus();
				((Computer)MyProject.Computer).Keyboard.SendKeys(Text_REFERENCE_COLLECTION.Text + "{ENTER}");
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
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val5 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Text_QTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_QTE_LISTE_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = true;
			((Control)Panel_CLAVIER).BringToFront();
			((Control)Panel_CLAVIER).Top = 188;
			((Control)Panel_CLAVIER).Left = 406;
		}
		else
		{
			((Control)Panel_CLAVIER).Visible = false;
		}
	}

	private void Text_QTE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		((Form)MyProject.Forms.Form_6_FOURNISSEURS).ShowDialog();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select DISTINCT FOURNISSEUR from TABLE_FOURNISSEURS ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Combo_FOURNISSEUR.Items.Clear();
		Combo_FOURNISSEUR_COLLECTION.Items.Clear();
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
					Combo_FOURNISSEUR.Items.Add((object)dataTable.Rows[num2]["FOURNISSEUR"].ToString());
					Combo_FOURNISSEUR_COLLECTION.Items.Add((object)dataTable.Rows[num2]["FOURNISSEUR"].ToString());
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_QTE_COLLECTION.Text = Conversions.ToString(Operators.AddObject(Text_QTE_COLLECTION.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
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
				Text_QTE_COLLECTION.Text = Text_QTE_COLLECTION.Text.Remove(checked(Text_QTE_COLLECTION.Text.Length - 1));
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

	private void Button_PLUS_Click(object sender, EventArgs e)
	{
		Text_QTE_COLLECTION.Text = Conversions.ToString(Conversion.Val(Text_QTE_COLLECTION.Text) + 1.0);
		if (Conversions.ToDouble(Text_QTE_COLLECTION.Text) < 1.0)
		{
			Text_QTE_COLLECTION.Text = Conversions.ToString(1);
		}
	}

	private void Button_MOINS_Click(object sender, EventArgs e)
	{
		Text_QTE_COLLECTION.Text = Conversions.ToString(Conversion.Val(Text_QTE_COLLECTION.Text) - 1.0);
		if (Conversions.ToDouble(Text_QTE_COLLECTION.Text) < 1.0)
		{
			Text_QTE_COLLECTION.Text = Conversions.ToString(1);
		}
	}

	private void Text_CODE_LISTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_CODE_COLLECTION_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Button_CLAVIER_NOSELECT212_Click(object sender, EventArgs e)
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

	private void Text_CODE_RICHE_TextChanged(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = 0;
		Text_CODE_RICHE.SelectionLength = 6;
		Text_CODE_RICHE.SelectionColor = Color.Black;
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = 6;
		Text_CODE_RICHE.SelectionLength = 2;
		Text_CODE_RICHE.SelectionColor = Color.Chocolate;
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = 8;
		Text_CODE_RICHE.SelectionLength = 2;
		Text_CODE_RICHE.SelectionColor = Color.Blue;
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = 10;
		Text_CODE_RICHE.SelectionLength = 2;
		Text_CODE_RICHE.SelectionColor = Color.SpringGreen;
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = 12;
		Text_CODE_RICHE.SelectionLength = Text_CODE_RICHE.TextLength;
		Text_CODE_RICHE.SelectionColor = Color.Black;
		((TextBoxBase)Text_CODE_RICHE).SelectionStart = Text_CODE_RICHE.TextLength;
	}

	private void Combo_TAILLES_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Combo_TAILLES_SelectionChangeCommitted(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Button_ADD_COLLECTION).Visible)
		{
			MessageBox.Show("le code-barres serra changer automatiquement, merci de rectifier la désignation de l'article", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)32, (MessageBoxDefaultButton)0);
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)Combo_TAILLES.SelectedItem;
			string key = keyValuePair.Key;
			Text_CODE.Text = Text_CODE.Text.Remove(8, 2);
			Text_CODE.Text = Text_CODE.Text.Insert(8, key);
		}
	}

	private void Combo_COULEURS_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Combo_COULEURS_SelectionChangeCommitted(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Button_ADD_COLLECTION).Visible)
		{
			MessageBox.Show("le code-barres serra changer automatiquement, merci de rectifier la désignation de l'article", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)32, (MessageBoxDefaultButton)0);
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)Combo_COULEURS.SelectedItem;
			string key = keyValuePair.Key;
			Text_CODE.Text = Text_CODE.Text.Remove(10, 2);
			Text_CODE.Text = Text_CODE.Text.Insert(10, key);
		}
	}

	private void Button_CANVA_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "Excel (*.xlsx)|*.xlsx";
		((FileDialog)val).FileName = "CANVA_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			((ServerComputer)MyProject.Computer).FileSystem.CopyFile(Application.StartupPath + "\\CANVA.sni", ((FileDialog)val).FileName, true);
			MessageBox.Show("exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void Button_IMPORTER_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_IMPORTER_ARTICLES).ShowDialog();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between Unknown and I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		checked
		{
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
						DT.Clear();
						DA = new MySqlDataAdapter("select * from TABLE_ARTICLES     where  BALANCE = 'OUI'        order by    Famille,Article   asc", Module1.cn_SQL);
						((DbDataAdapter)(object)DA).Fill(DT);
						string text = "";
						double num3 = 0.0;
						int num4 = DataGridView1.Rows.Count - 1;
						int num5 = 0;
						while (true)
						{
							int num6 = num5;
							int num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							num3 = Conversions.ToDouble(DataGridView1.Rows[num5].Cells["PRIX_V_1"].Value.ToString()) * 100.0;
							if (Operators.CompareString(DataGridView1.Rows[num5].Cells["UNITE"].Value.ToString(), "KG", TextCompare: false) != 0)
							{
								text = ((Operators.CompareString(DataGridView1.Rows[num5].Cells["UNITE"].Value.ToString(), "PCS", TextCompare: false) != 0) ? "4" : "10");
							}
							else
							{
								text = "4";
							}
							DataGridView3.Rows.Add(new object[10]
							{
								DataGridView1.Rows[num5].Cells["CODE"].Value.ToString(),
								DataGridView1.Rows[num5].Cells["ARTICLE"].Value.ToString(),
								DataGridView1.Rows[num5].Cells["CODE"].Value.ToString(),
								DataGridView1.Rows[num5].Cells["CODE"].Value.ToString(),
								"4",
								num3,
								text,
								"21",
								"0",
								"0"
							});
							num5++;
						}
						((Control)Panel_FONCTIONS).Hide();
						SaveFileDialog val = new SaveFileDialog();
						((FileDialog)val).Filter = "Text Files (*.txt)|*.txt";
						((FileDialog)val).FileName = "Articles_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
						if (unchecked((int)((CommonDialog)val).ShowDialog()) != 1)
						{
							goto end_IL_0001;
						}
						string separator = ",";
						StringBuilder stringBuilder = new StringBuilder();
						int num8 = DataGridView3.Rows.Count - 1;
						int num9 = 0;
						while (true)
						{
							int num10 = num9;
							int num7 = num8;
							if (num10 > num7)
							{
								break;
							}
							string[] array = new string[((BaseCollection)DataGridView3.Columns).Count - 1 + 1];
							if (num9.Equals(0))
							{
							}
							int num11 = ((BaseCollection)DataGridView3.Columns).Count - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								num7 = num11;
								if (num13 > num7)
								{
									break;
								}
								if (!DataGridView3.Rows[num9].IsNewRow)
								{
									if (Operators.ConditionalCompareObjectEqual(DataGridView3[num12, num9].Value, null, TextCompare: false))
									{
										array[num12] = "";
									}
									else
									{
										array[num12] = DataGridView3[num12, num9].Value.ToString();
									}
								}
								num12++;
							}
							if (!DataGridView3.Rows[num9].IsNewRow)
							{
								stringBuilder.AppendLine(string.Join(separator, array));
							}
							num9++;
						}
						File.WriteAllText(((FileDialog)val).FileName, stringBuilder.ToString(), Encoding.Default);
						MessageBox.Show("exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
						goto end_IL_0001;
					}
					case 1065:
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
					try0001_dispatch = 1065;
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
	}

	private void Text_PRIX_QTE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Text_PRIX_QTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_PRIX_QTE_MIN_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (LOGICA.Presentation.Input.NumericEntryFilter.ShouldBlock(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Text_PRIX_QTE_MIN_TextChanged(object sender, EventArgs e)
	{
	}
}
