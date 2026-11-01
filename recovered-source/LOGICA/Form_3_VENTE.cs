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
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using ThoughtWorks.QRCode.Codec;

namespace LOGICA;

[DesignerGenerated]
public class Form_3_VENTE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_SOLDER_PRINTER")]
	private Button_CLAVIER_NOSELECT _Button_SOLDER_PRINTER;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Panel33")]
	private Panel _Panel33;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Text_CODE")]
	private TextBox _Text_CODE;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private TextBox _Text_TOTAL_NET;

	[AccessedThroughProperty("Button_ANNULATION_ALL")]
	private Button_CLAVIER_NOSELECT _Button_ANNULATION_ALL;

	[AccessedThroughProperty("Button_ANNULATION")]
	private Button_CLAVIER_NOSELECT _Button_ANNULATION;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Button_GO")]
	private Button _Button_GO;

	[AccessedThroughProperty("CL_FR_3C")]
	private PrintDocument _CL_FR_3C;

	[AccessedThroughProperty("Text_FIND")]
	private TextBox _Text_FIND;

	[AccessedThroughProperty("Button_FIND")]
	private Button _Button_FIND;

	[AccessedThroughProperty("Text_HEURE_RETARD")]
	private TextBox _Text_HEURE_RETARD;

	[AccessedThroughProperty("List_COLOR")]
	private ListBox _List_COLOR;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("Text_ID_TICKET")]
	private TextBox _Text_ID_TICKET;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Check_ACCES_RFID")]
	private CheckBox _Check_ACCES_RFID;

	[AccessedThroughProperty("Check_ACCES_MODEP")]
	private CheckBox _Check_ACCES_MODEP;

	[AccessedThroughProperty("Button_SOLDER_NOT_PRINTER")]
	private Button_CLAVIER_NOSELECT _Button_SOLDER_NOT_PRINTER;

	[AccessedThroughProperty("Picture_SMILE")]
	private PictureBox _Picture_SMILE;

	[AccessedThroughProperty("Picture_TRISTE")]
	private PictureBox _Picture_TRISTE;

	[AccessedThroughProperty("BON_RETOUR")]
	private PrintDocument _BON_RETOUR;

	[AccessedThroughProperty("Combo_BAUDRATE")]
	private ComboBox _Combo_BAUDRATE;

	[AccessedThroughProperty("Combo_PORT")]
	private ComboBox _Combo_PORT;

	[AccessedThroughProperty("Check_STOCK")]
	private CheckBox _Check_STOCK;

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button_CLAVIER_NOSELECT _Button_FONCTIONS;

	[AccessedThroughProperty("Button_LOCK")]
	private Button_CLAVIER_NOSELECT _Button_LOCK;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Button_OPERATION")]
	private Button_CLAVIER_NOSELECT _Button_OPERATION;

	[AccessedThroughProperty("Button_PRIX")]
	private Button_CLAVIER_NOSELECT _Button_PRIX;

	[AccessedThroughProperty("Button_MODIF_QTE")]
	private Button_CLAVIER_NOSELECT _Button_MODIF_QTE;

	[AccessedThroughProperty("Button_DIVERS")]
	private Button_CLAVIER_NOSELECT _Button_DIVERS;

	[AccessedThroughProperty("Button_TIROIR")]
	private Button_CLAVIER_NOSELECT _Button_TIROIR;

	[AccessedThroughProperty("Button_MODIF_PRIX")]
	private Button_CLAVIER_NOSELECT _Button_MODIF_PRIX;

	[AccessedThroughProperty("Button_REMISE")]
	private Button_CLAVIER_NOSELECT _Button_REMISE;

	[AccessedThroughProperty("Button_DUPLICATA")]
	private Button_CLAVIER_NOSELECT _Button_DUPLICATA;

	[AccessedThroughProperty("Button_FLASH")]
	private Button_CLAVIER_NOSELECT _Button_FLASH;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Button_RAPPORT")]
	private Button_CLAVIER_NOSELECT _Button_RAPPORT;

	[AccessedThroughProperty("Button_DEPENSES")]
	private Button_CLAVIER_NOSELECT _Button_DEPENSES;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_CAISSIER")]
	private Button _Button_CAISSIER;

	[AccessedThroughProperty("Button_VENDEUR")]
	private Button _Button_VENDEUR;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Button_THEME")]
	private Button_CLAVIER_NOSELECT _Button_THEME;

	[AccessedThroughProperty("Text_THEME")]
	private TextBox _Text_THEME;

	[AccessedThroughProperty("Check_CHOIX_VENDEUR")]
	private CheckBox _Check_CHOIX_VENDEUR;

	[AccessedThroughProperty("Check_CHOIX_CLIENT")]
	private CheckBox _Check_CHOIX_CLIENT;

	[AccessedThroughProperty("Button_CLIENT")]
	private Button_ID_CODE _Button_CLIENT;

	[AccessedThroughProperty("Panel0")]
	private Panel _Panel0;

	[AccessedThroughProperty("Panel00")]
	private Panel _Panel00;

	[AccessedThroughProperty("ListBox_VENDEURS")]
	private ListBox _ListBox_VENDEURS;

	[AccessedThroughProperty("Text_PRIX_A")]
	private TextBox _Text_PRIX_A;

	[AccessedThroughProperty("Text_ARTICLE")]
	private TextBox _Text_ARTICLE;

	[AccessedThroughProperty("Text_PRIX_MP")]
	private TextBox _Text_PRIX_MP;

	[AccessedThroughProperty("Text_FAMILLE")]
	private TextBox _Text_FAMILLE;

	[AccessedThroughProperty("Text_PRIXV")]
	private TextBox _Text_PRIXV;

	[AccessedThroughProperty("Text_TAUX_TVA")]
	private TextBox _Text_TAUX_TVA;

	[AccessedThroughProperty("Check_GESTION_CREDIT")]
	private CheckBox _Check_GESTION_CREDIT;

	[AccessedThroughProperty("Text_pied")]
	private TextBox _Text_pied;

	[AccessedThroughProperty("CheckBox_AFFICHER_MODEP")]
	private CheckBox _CheckBox_AFFICHER_MODEP;

	[AccessedThroughProperty("Text_PRINTER_C2")]
	private TextBox _Text_PRINTER_C2;

	[AccessedThroughProperty("Text_PRINTER_C1")]
	private TextBox _Text_PRINTER_C1;

	[AccessedThroughProperty("Text_PRINTER_ADDITION")]
	private TextBox _Text_PRINTER_ADDITION;

	[AccessedThroughProperty("Text_PRINTER_SOLDER")]
	private TextBox _Text_PRINTER_SOLDER;

	[AccessedThroughProperty("Text_PRINTER_C4")]
	private TextBox _Text_PRINTER_C4;

	[AccessedThroughProperty("Text_PRINTER_C3")]
	private TextBox _Text_PRINTER_C3;

	[AccessedThroughProperty("Button_CLOTURE")]
	private Button_CLAVIER_NOSELECT _Button_CLOTURE;

	[AccessedThroughProperty("CL_FR_2L")]
	private PrintDocument _CL_FR_2L;

	[AccessedThroughProperty("Text_MODELE_TICKET")]
	private TextBox _Text_MODELE_TICKET;

	[AccessedThroughProperty("Label_QTE")]
	private Label _Label_QTE;

	[AccessedThroughProperty("Button_qteBACK")]
	private Button_CLAVIER_NOSELECT _Button_qteBACK;

	[AccessedThroughProperty("Button_qte0")]
	private Button_CLAVIER_NOSELECT _Button_qte0;

	[AccessedThroughProperty("Button_qte9")]
	private Button_CLAVIER_NOSELECT _Button_qte9;

	[AccessedThroughProperty("Button_qte8")]
	private Button_CLAVIER_NOSELECT _Button_qte8;

	[AccessedThroughProperty("Button_qte7")]
	private Button_CLAVIER_NOSELECT _Button_qte7;

	[AccessedThroughProperty("Button_qte6")]
	private Button_CLAVIER_NOSELECT _Button_qte6;

	[AccessedThroughProperty("Button_qte5")]
	private Button_CLAVIER_NOSELECT _Button_qte5;

	[AccessedThroughProperty("Button_qte4")]
	private Button_CLAVIER_NOSELECT _Button_qte4;

	[AccessedThroughProperty("Button_qte3")]
	private Button_CLAVIER_NOSELECT _Button_qte3;

	[AccessedThroughProperty("Button_qte2")]
	private Button_CLAVIER_NOSELECT _Button_qte2;

	[AccessedThroughProperty("Button_qte1")]
	private Button_CLAVIER_NOSELECT _Button_qte1;

	[AccessedThroughProperty("Button_qteDRAFT")]
	private Button_CLAVIER_NOSELECT _Button_qteDRAFT;

	[AccessedThroughProperty("Button_qteDOT")]
	private Button_CLAVIER_NOSELECT _Button_qteDOT;

	[AccessedThroughProperty("Button_qtewhite")]
	private Button_CLAVIER_NOSELECT _Button_qtewhite;

	[AccessedThroughProperty("CL_FR_4C")]
	private PrintDocument _CL_FR_4C;

	[AccessedThroughProperty("Label_NBR_ARTICLES")]
	private Label _Label_NBR_ARTICLES;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Picture_FLECH_HAUT")]
	private PictureBox _Picture_FLECH_HAUT;

	[AccessedThroughProperty("Picture_FLECH_BAS")]
	private PictureBox _Picture_FLECH_BAS;

	[AccessedThroughProperty("CL_AR_4C")]
	private PrintDocument _CL_AR_4C;

	[AccessedThroughProperty("Button_CALCULATRICE")]
	private Button_CLAVIER_NOSELECT _Button_CALCULATRICE;

	[AccessedThroughProperty("Button_COMPTER_CAISSE")]
	private Button_CLAVIER_NOSELECT _Button_COMPTER_CAISSE;

	[AccessedThroughProperty("CheckBox_AFFICHER_CODEBARRE")]
	private CheckBox _CheckBox_AFFICHER_CODEBARRE;

	[AccessedThroughProperty("CheckBox_AFFICHER_N_TICKET")]
	private CheckBox _CheckBox_AFFICHER_N_TICKET;

	[AccessedThroughProperty("CheckBox_AFFICHER_MODEV")]
	private CheckBox _CheckBox_AFFICHER_MODEV;

	[AccessedThroughProperty("Check_SOLDER_SANS_TICKET")]
	private CheckBox _Check_SOLDER_SANS_TICKET;

	[AccessedThroughProperty("Button_SOLDER_CREDIT")]
	private Button_CLAVIER_NOSELECT _Button_SOLDER_CREDIT;

	[AccessedThroughProperty("Button_FERMER")]
	private Button_CLAVIER_NOSELECT _Button_FERMER;

	[AccessedThroughProperty("Button_FERMER2")]
	private Button_CLAVIER_NOSELECT _Button_FERMER2;

	[AccessedThroughProperty("Button2626")]
	private Button _Button2626;

	[AccessedThroughProperty("Button2121")]
	private Button _Button2121;

	[AccessedThroughProperty("Button1717")]
	private Button _Button1717;

	[AccessedThroughProperty("Text_PROMOTION")]
	private TextBox _Text_PROMOTION;

	[AccessedThroughProperty("Text_ID_ARTICLE")]
	private TextBox _Text_ID_ARTICLE;

	[AccessedThroughProperty("ERREUR")]
	private PrintDocument _ERREUR;

	[AccessedThroughProperty("DataGridView_MODE_P")]
	private DataGridView _DataGridView_MODE_P;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("Button_LISTE_ATTENTE")]
	private Button_CLAVIER_NOSELECT _Button_LISTE_ATTENTE;

	[AccessedThroughProperty("Button_ATTENTE")]
	private Button_CLAVIER_NOSELECT _Button_ATTENTE;

	[AccessedThroughProperty("Button3")]
	private Button_CLAVIER_NOSELECT _Button3;

	[AccessedThroughProperty("Button_876")]
	private Button _Button_876;

	[AccessedThroughProperty("Panel9")]
	private Panel _Panel9;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("DataGridView100")]
	private DataGridView _DataGridView100;

	[AccessedThroughProperty("Codeee")]
	private DataGridViewTextBoxColumn _Codeee;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("Prix_VV")]
	private DataGridViewTextBoxColumn _Prix_VV;

	[AccessedThroughProperty("Stock")]
	private DataGridViewTextBoxColumn _Stock;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("FlowLayout_ARTICLES")]
	private FlowLayoutPanel _FlowLayout_ARTICLES;

	[AccessedThroughProperty("FlowLayoutPanel2")]
	private FlowLayoutPanel _FlowLayoutPanel2;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT2")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT2;

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

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT3")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT3;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT4")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT4;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT5")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT5;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT6")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT6;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT7")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT7;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT8")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT8;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT9")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT9;

	[AccessedThroughProperty("TableLayoutPanel3")]
	private TableLayoutPanel _TableLayoutPanel3;

	[AccessedThroughProperty("Butt_AR")]
	private Button_CLAVIER_NOSELECT _Butt_AR;

	[AccessedThroughProperty("Butt_SPACE")]
	private Button_CLAVIER_NOSELECT _Butt_SPACE;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT10")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT10;

	[AccessedThroughProperty("Panel_CLAVIER_AR")]
	private Panel _Panel_CLAVIER_AR;

	[AccessedThroughProperty("TableLayoutPanel4")]
	private TableLayoutPanel _TableLayoutPanel4;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT19")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT19;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT11")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT11;

	[AccessedThroughProperty("Butt_1_AR")]
	private Button_CLAVIER_NOSELECT _Butt_1_AR;

	[AccessedThroughProperty("Butt_2_AR")]
	private Button_CLAVIER_NOSELECT _Butt_2_AR;

	[AccessedThroughProperty("Butt_3_AR")]
	private Button_CLAVIER_NOSELECT _Butt_3_AR;

	[AccessedThroughProperty("Butt_4_AR")]
	private Button_CLAVIER_NOSELECT _Butt_4_AR;

	[AccessedThroughProperty("Butt_5_AR")]
	private Button_CLAVIER_NOSELECT _Butt_5_AR;

	[AccessedThroughProperty("Butt_6_AR")]
	private Button_CLAVIER_NOSELECT _Butt_6_AR;

	[AccessedThroughProperty("Butt_7_AR")]
	private Button_CLAVIER_NOSELECT _Butt_7_AR;

	[AccessedThroughProperty("Butt_8_AR")]
	private Button_CLAVIER_NOSELECT _Butt_8_AR;

	[AccessedThroughProperty("Butt_9_AR")]
	private Button_CLAVIER_NOSELECT _Butt_9_AR;

	[AccessedThroughProperty("Butt_0_AR")]
	private Button_CLAVIER_NOSELECT _Butt_0_AR;

	[AccessedThroughProperty("Butt_ك")]
	private Button_CLAVIER_NOSELECT _Butt_ك;

	[AccessedThroughProperty("Butt_ض")]
	private Button_CLAVIER_NOSELECT _Butt_ض;

	[AccessedThroughProperty("Butt_م")]
	private Button_CLAVIER_NOSELECT _Butt_م;

	[AccessedThroughProperty("Butt_ص")]
	private Button_CLAVIER_NOSELECT _Butt_ص;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT14")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT14;

	[AccessedThroughProperty("Butt_ن")]
	private Button_CLAVIER_NOSELECT _Butt_ن;

	[AccessedThroughProperty("Butt_ث")]
	private Button_CLAVIER_NOSELECT _Butt_ث;

	[AccessedThroughProperty("Butt_ت")]
	private Button_CLAVIER_NOSELECT _Butt_ت;

	[AccessedThroughProperty("Butt_ق")]
	private Button_CLAVIER_NOSELECT _Butt_ق;

	[AccessedThroughProperty("Butt_ا")]
	private Button_CLAVIER_NOSELECT _Butt_ا;

	[AccessedThroughProperty("Butt_ف")]
	private Button_CLAVIER_NOSELECT _Butt_ف;

	[AccessedThroughProperty("Butt_ل")]
	private Button_CLAVIER_NOSELECT _Butt_ل;

	[AccessedThroughProperty("Butt_غ")]
	private Button_CLAVIER_NOSELECT _Butt_غ;

	[AccessedThroughProperty("Butt_ب")]
	private Button_CLAVIER_NOSELECT _Butt_ب;

	[AccessedThroughProperty("Butt_ع")]
	private Button_CLAVIER_NOSELECT _Butt_ع;

	[AccessedThroughProperty("Butt_ي")]
	private Button_CLAVIER_NOSELECT _Butt_ي;

	[AccessedThroughProperty("Butt_ه")]
	private Button_CLAVIER_NOSELECT _Butt_ه;

	[AccessedThroughProperty("Butt_س")]
	private Button_CLAVIER_NOSELECT _Butt_س;

	[AccessedThroughProperty("Butt_خ")]
	private Button_CLAVIER_NOSELECT _Butt_خ;

	[AccessedThroughProperty("Butt_ش")]
	private Button_CLAVIER_NOSELECT _Butt_ش;

	[AccessedThroughProperty("Butt_ح")]
	private Button_CLAVIER_NOSELECT _Butt_ح;

	[AccessedThroughProperty("Butt_ج")]
	private Button_CLAVIER_NOSELECT _Butt_ج;

	[AccessedThroughProperty("Butt_DRAFT_AR")]
	private Button_CLAVIER_NOSELECT _Butt_DRAFT_AR;

	[AccessedThroughProperty("Butt_BACK_AR")]
	private Button_CLAVIER_NOSELECT _Butt_BACK_AR;

	[AccessedThroughProperty("Butt_د")]
	private Button_CLAVIER_NOSELECT _Butt_د;

	[AccessedThroughProperty("Butt_ط")]
	private Button_CLAVIER_NOSELECT _Butt_ط;

	[AccessedThroughProperty("Butt_ظ")]
	private Button_CLAVIER_NOSELECT _Butt_ظ;

	[AccessedThroughProperty("Butt_ز")]
	private Button_CLAVIER_NOSELECT _Butt_ز;

	[AccessedThroughProperty("Butt_و")]
	private Button_CLAVIER_NOSELECT _Butt_و;

	[AccessedThroughProperty("Butt_ة")]
	private Button_CLAVIER_NOSELECT _Butt_ة;

	[AccessedThroughProperty("Butt_ى")]
	private Button_CLAVIER_NOSELECT _Butt_ى;

	[AccessedThroughProperty("Butt_لا")]
	private Button_CLAVIER_NOSELECT _Butt_لا;

	[AccessedThroughProperty("Butt_ر")]
	private Button_CLAVIER_NOSELECT _Butt_ر;

	[AccessedThroughProperty("Butt_ؤ")]
	private Button_CLAVIER_NOSELECT _Butt_ؤ;

	[AccessedThroughProperty("Butt_ء")]
	private Button_CLAVIER_NOSELECT _Butt_ء;

	[AccessedThroughProperty("Butt_ئ")]
	private Button_CLAVIER_NOSELECT _Butt_ئ;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT12")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT12;

	[AccessedThroughProperty("Butt_DOT_AR")]
	private Button_CLAVIER_NOSELECT _Butt_DOT_AR;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT13")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT13;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT15")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT15;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT16")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT16;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT17")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT17;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT18")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT18;

	[AccessedThroughProperty("Butt_ذ")]
	private Button_CLAVIER_NOSELECT _Butt_ذ;

	[AccessedThroughProperty("TableLayoutPanel5")]
	private TableLayoutPanel _TableLayoutPanel5;

	[AccessedThroughProperty("Butt_FR")]
	private Button_CLAVIER_NOSELECT _Butt_FR;

	[AccessedThroughProperty("Butt_SPACE_AR")]
	private Button_CLAVIER_NOSELECT _Butt_SPACE_AR;

	[AccessedThroughProperty("Text_PRINTER_DUPLICATA")]
	private TextBox _Text_PRINTER_DUPLICATA;

	[AccessedThroughProperty("Text_PRINTER")]
	private TextBox _Text_PRINTER;

	[AccessedThroughProperty("C1")]
	private PrintDocument _C1;

	[AccessedThroughProperty("DataGridView_ACCES")]
	private DataGridView _DataGridView_ACCES;

	[AccessedThroughProperty("Panel10")]
	private Panel _Panel10;

	[AccessedThroughProperty("Panel_RACCOURCIES")]
	private Panel _Panel_RACCOURCIES;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("FlowLayout_RACCOURCIES")]
	private FlowLayoutPanel _FlowLayout_RACCOURCIES;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT24")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT24;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT23")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT23;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT22")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT22;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT21")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT21;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT20")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT20;

	[AccessedThroughProperty("Button_RACCOURCIES")]
	private Button_CLAVIER_NOSELECT _Button_RACCOURCIES;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT25")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT25;

	[AccessedThroughProperty("Text_GROUPE")]
	private TextBox _Text_GROUPE;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("SplitContainer2")]
	private SplitContainer _SplitContainer2;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT26")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT26;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT27")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT27;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT28")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT28;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT29")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT29;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT30")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT30;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT31")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT31;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT32")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT32;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT33")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT33;

	[AccessedThroughProperty("Button_ALERTS_STOCK")]
	private Button_CLAVIER_NOSELECT _Button_ALERTS_STOCK;

	[AccessedThroughProperty("Button_FONDS_CAISSE")]
	private Button_CLAVIER_NOSELECT _Button_FONDS_CAISSE;

	[AccessedThroughProperty("Button_CLIENTS")]
	private Button_CLAVIER_NOSELECT _Button_CLIENTS;

	[AccessedThroughProperty("Button_INVENTAIRE")]
	private Button_CLAVIER_NOSELECT _Button_INVENTAIRE;

	[AccessedThroughProperty("Button_ARTICLES")]
	private Button_CLAVIER_NOSELECT _Button_ARTICLES;

	[AccessedThroughProperty("Button_CLIENTS_REGLEMENTS")]
	private Button_CLAVIER_NOSELECT _Button_CLIENTS_REGLEMENTS;

	[AccessedThroughProperty("Button_SORTIES")]
	private Button_CLAVIER_NOSELECT _Button_SORTIES;

	[AccessedThroughProperty("Button_RECEPTIONS")]
	private Button_CLAVIER_NOSELECT _Button_RECEPTIONS;

	[AccessedThroughProperty("Text_PRINTER_C5")]
	private TextBox _Text_PRINTER_C5;

	[AccessedThroughProperty("Text_PRINTER_C7")]
	private TextBox _Text_PRINTER_C7;

	[AccessedThroughProperty("Text_PRINTER_C6")]
	private TextBox _Text_PRINTER_C6;

	[AccessedThroughProperty("CL_AR_3C")]
	private PrintDocument _CL_AR_3C;

	[AccessedThroughProperty("Panel_RAPPEL")]
	private Panel _Panel_RAPPEL;

	[AccessedThroughProperty("Button_RAPPEL_TOTAL")]
	private Button _Button_RAPPEL_TOTAL;

	[AccessedThroughProperty("Button_RAPPEL_MODE_P")]
	private Button _Button_RAPPEL_MODE_P;

	[AccessedThroughProperty("Button_RAPPEL_RENDU")]
	private Button _Button_RAPPEL_RENDU;

	[AccessedThroughProperty("Button_RAPPEL_PAYER")]
	private Button _Button_RAPPEL_PAYER;

	[AccessedThroughProperty("Text_PRIX_QTE_MIN")]
	private TextBox _Text_PRIX_QTE_MIN;

	[AccessedThroughProperty("Text_PRIX_QTE")]
	private TextBox _Text_PRIX_QTE;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_V")]
	private DataGridViewTextBoxColumn _Prix_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("TOTAL_NET")]
	private DataGridViewTextBoxColumn _TOTAL_NET;

	[AccessedThroughProperty("REMISE")]
	private DataGridViewTextBoxColumn _REMISE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("PRINTER")]
	private DataGridViewTextBoxColumn _PRINTER;

	[AccessedThroughProperty("PRINTER_DUPLICATA")]
	private DataGridViewTextBoxColumn _PRINTER_DUPLICATA;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT34")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT34;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT35")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT35;

	[AccessedThroughProperty("Picture_LOGO")]
	private PictureBox _Picture_LOGO;

	[AccessedThroughProperty("PictureBox100")]
	private PictureBox _PictureBox100;

	[AccessedThroughProperty("Panel_LOGO")]
	private Panel _Panel_LOGO;

	[AccessedThroughProperty("vScrollBar1")]
	private VScrollBar _vScrollBar1;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private QRCodeEncoder QREncoder;

	private Image QRimg;

	private Bitmap QRbitmap;

	private Bitmap barcodeImage;

	private string _N_TICKET_SOLDER;

	public const string eClear = "\u001b@";

	public const string eCentre = "\u001ba1";

	public const string eLeft = "\u001ba0";

	public const string eRight = "\u001ba2";

	public const string _eSmlText = "\u001b!\u0001";

	public const string _eNmlText = "\u001b!\0";

	public const string _eActive_GRAS = "\u001bE\u0001";

	public const string _eBigCharOnX1 = "\u001d!\u0011";

	public const string _eBigCharOnX2 = "\u001d!\"";

	public const string _eBigCharOnX3 = "\u001d!3";

	public const string normalText = "\u001d!\0";

	public const string eInit = "\u001b!\0\r\u001bc6\u0001\u001bR3\r\n";

	public const string eBigCharOn = "\u001b!8";

	public const string eBigCharOn_Moy = "\u001b!(";

	public const string eBigCharOn_Pet = "\u001b!\u0001";

	public const string eDrawer = "\u001b@\u001bp\0.}";

	public const string eCut = "\u001bi\r\n";

	private RawPrinterHelper prn;

	private string PrintBuffer;

	private DataTable dt_LA;

	private MySqlDataAdapter da_LA;

	private DataTable dt_PIC;

	private MySqlDataAdapter da_PIC;

	private string _string;

	internal virtual Button_CLAVIER_NOSELECT Button_SOLDER_PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SOLDER_PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			EventHandler eventHandler2 = Button_SOLDER_PRINTER_GotFocus;
			if (_Button_SOLDER_PRINTER != null)
			{
				((Control)_Button_SOLDER_PRINTER).Click -= eventHandler;
				((Control)_Button_SOLDER_PRINTER).GotFocus -= eventHandler2;
			}
			_Button_SOLDER_PRINTER = value;
			if (_Button_SOLDER_PRINTER != null)
			{
				((Control)_Button_SOLDER_PRINTER).Click += eventHandler;
				((Control)_Button_SOLDER_PRINTER).GotFocus += eventHandler2;
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
			EventHandler eventHandler = DataGridView1_Click;
			DataGridViewCellEventHandler val = DataGridView1_CellDoubleClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellClick;
			DataGridViewCellEventHandler val3 = DataGridView1_CellContentClick;
			DataGridViewBindingCompleteEventHandler val4 = DataGridView1_DataBindingComplete;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).Click -= eventHandler;
				_DataGridView1.CellDoubleClick -= val;
				_DataGridView1.CellClick -= val2;
				_DataGridView1.CellContentClick -= val3;
				_DataGridView1.DataBindingComplete -= val4;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).Click += eventHandler;
				_DataGridView1.CellDoubleClick += val;
				_DataGridView1.CellClick += val2;
				_DataGridView1.CellContentClick += val3;
				_DataGridView1.DataBindingComplete += val4;
			}
		}
	}

	internal virtual Panel Panel33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel33 = value;
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
			EventHandler eventHandler = Panel5_Click;
			if (_Panel5 != null)
			{
				((Control)_Panel5).Paint -= val;
				((Control)_Panel5).Click -= eventHandler;
			}
			_Panel5 = value;
			if (_Panel5 != null)
			{
				((Control)_Panel5).Paint += val;
				((Control)_Panel5).Click += eventHandler;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_CODE_TextChanged;
			KeyEventHandler val = Text_CODE_KeyDown;
			EventHandler eventHandler2 = Text_CODE_LostFocus;
			EventHandler eventHandler3 = Text_CODE_GotFocus;
			EventHandler eventHandler4 = Text_CODE_Click;
			if (_Text_CODE != null)
			{
				((Control)_Text_CODE).TextChanged -= eventHandler;
				((Control)_Text_CODE).KeyDown -= val;
				((Control)_Text_CODE).LostFocus -= eventHandler2;
				((Control)_Text_CODE).GotFocus -= eventHandler3;
				((TextBoxBase)_Text_CODE).Click -= eventHandler4;
			}
			_Text_CODE = value;
			if (_Text_CODE != null)
			{
				((Control)_Text_CODE).TextChanged += eventHandler;
				((Control)_Text_CODE).KeyDown += val;
				((Control)_Text_CODE).LostFocus += eventHandler2;
				((Control)_Text_CODE).GotFocus += eventHandler3;
				((TextBoxBase)_Text_CODE).Click += eventHandler4;
			}
		}
	}

	internal virtual TextBox Text_TOTAL_NET
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
			EventHandler eventHandler = Text_TTC_GotFocus;
			EventHandler eventHandler2 = Text_TTC_TextChanged;
			EventHandler eventHandler3 = Text_TOTAL_NET_Click;
			if (_Text_TOTAL_NET != null)
			{
				((Control)_Text_TOTAL_NET).GotFocus -= eventHandler;
				((Control)_Text_TOTAL_NET).TextChanged -= eventHandler2;
				((TextBoxBase)_Text_TOTAL_NET).Click -= eventHandler3;
			}
			_Text_TOTAL_NET = value;
			if (_Text_TOTAL_NET != null)
			{
				((Control)_Text_TOTAL_NET).GotFocus += eventHandler;
				((Control)_Text_TOTAL_NET).TextChanged += eventHandler2;
				((TextBoxBase)_Text_TOTAL_NET).Click += eventHandler3;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_ANNULATION_ALL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ANNULATION_ALL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ANNULATION_ALL_Click;
			EventHandler eventHandler2 = Button_SUPPRESSION_ALL_GotFocus;
			if (_Button_ANNULATION_ALL != null)
			{
				((Control)_Button_ANNULATION_ALL).Click -= eventHandler;
				((Control)_Button_ANNULATION_ALL).GotFocus -= eventHandler2;
			}
			_Button_ANNULATION_ALL = value;
			if (_Button_ANNULATION_ALL != null)
			{
				((Control)_Button_ANNULATION_ALL).Click += eventHandler;
				((Control)_Button_ANNULATION_ALL).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_ANNULATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ANNULATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ANNULATION_Click;
			EventHandler eventHandler2 = Button_SUPPRESSION_GotFocus;
			if (_Button_ANNULATION != null)
			{
				((Control)_Button_ANNULATION).Click -= eventHandler;
				((Control)_Button_ANNULATION).GotFocus -= eventHandler2;
			}
			_Button_ANNULATION = value;
			if (_Button_ANNULATION != null)
			{
				((Control)_Button_ANNULATION).Click += eventHandler;
				((Control)_Button_ANNULATION).GotFocus += eventHandler2;
			}
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

	internal virtual TextBox Text_FIND
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
			EventHandler eventHandler = Text_FIND_LostFocus;
			EventHandler eventHandler2 = Text_FIND_GotFocus;
			EventHandler eventHandler3 = Text_FIND_TextChanged;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).LostFocus -= eventHandler;
				((Control)_Text_FIND).GotFocus -= eventHandler2;
				((Control)_Text_FIND).TextChanged -= eventHandler3;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).LostFocus += eventHandler;
				((Control)_Text_FIND).GotFocus += eventHandler2;
				((Control)_Text_FIND).TextChanged += eventHandler3;
			}
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
			EventHandler eventHandler = Button_FIND_Click;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click -= eventHandler;
			}
			_Button_FIND = value;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_HEURE_RETARD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_HEURE_RETARD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_HEURE_RETARD = value;
		}
	}

	internal virtual ListBox List_COLOR
	{
		[DebuggerNonUserCode]
		get
		{
			return _List_COLOR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_List_COLOR = value;
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
			_Button16 = value;
		}
	}

	internal virtual TextBox Text_ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_TICKET = value;
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

	internal virtual CheckBox Check_ACCES_RFID
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_ACCES_RFID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_ACCES_RFID = value;
		}
	}

	internal virtual CheckBox Check_ACCES_MODEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_ACCES_MODEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_ACCES_MODEP = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_SOLDER_NOT_PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SOLDER_NOT_PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			EventHandler eventHandler2 = Button_SOLDER_NOT_PRINTER_GotFocus;
			if (_Button_SOLDER_NOT_PRINTER != null)
			{
				((Control)_Button_SOLDER_NOT_PRINTER).Click -= eventHandler;
				((Control)_Button_SOLDER_NOT_PRINTER).GotFocus -= eventHandler2;
			}
			_Button_SOLDER_NOT_PRINTER = value;
			if (_Button_SOLDER_NOT_PRINTER != null)
			{
				((Control)_Button_SOLDER_NOT_PRINTER).Click += eventHandler;
				((Control)_Button_SOLDER_NOT_PRINTER).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual PictureBox Picture_SMILE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_SMILE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_SMILE = value;
		}
	}

	internal virtual PictureBox Picture_TRISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_TRISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_TRISTE = value;
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

	internal virtual ComboBox Combo_BAUDRATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_BAUDRATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_BAUDRATE = value;
		}
	}

	internal virtual ComboBox Combo_PORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PORT = value;
		}
	}

	internal virtual CheckBox Check_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_STOCK = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_FONCTIONS
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

	internal virtual Button_CLAVIER_NOSELECT Button_LOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_LOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_LOCK_Click;
			if (_Button_LOCK != null)
			{
				((Control)_Button_LOCK).Click -= eventHandler;
			}
			_Button_LOCK = value;
			if (_Button_LOCK != null)
			{
				((Control)_Button_LOCK).Click += eventHandler;
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
			EventHandler eventHandler = Panel_FONCTIONS_VisibleChanged;
			if (_Panel_FONCTIONS != null)
			{
				((Control)_Panel_FONCTIONS).VisibleChanged -= eventHandler;
			}
			_Panel_FONCTIONS = value;
			if (_Panel_FONCTIONS != null)
			{
				((Control)_Panel_FONCTIONS).VisibleChanged += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Button_OPERATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_OPERATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_OPERATION_Click;
			EventHandler eventHandler2 = Button_OPERATION_GotFocus;
			if (_Button_OPERATION != null)
			{
				((Control)_Button_OPERATION).Click -= eventHandler;
				((Control)_Button_OPERATION).GotFocus -= eventHandler2;
			}
			_Button_OPERATION = value;
			if (_Button_OPERATION != null)
			{
				((Control)_Button_OPERATION).Click += eventHandler;
				((Control)_Button_OPERATION).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_PRIX
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRIX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRIX_Click;
			if (_Button_PRIX != null)
			{
				((Control)_Button_PRIX).Click -= eventHandler;
			}
			_Button_PRIX = value;
			if (_Button_PRIX != null)
			{
				((Control)_Button_PRIX).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_MODIF_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MODIF_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MODIF_QTE_Click;
			if (_Button_MODIF_QTE != null)
			{
				((Control)_Button_MODIF_QTE).Click -= eventHandler;
			}
			_Button_MODIF_QTE = value;
			if (_Button_MODIF_QTE != null)
			{
				((Control)_Button_MODIF_QTE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_DIVERS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DIVERS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DIVERS_Click;
			if (_Button_DIVERS != null)
			{
				((Control)_Button_DIVERS).Click -= eventHandler;
			}
			_Button_DIVERS = value;
			if (_Button_DIVERS != null)
			{
				((Control)_Button_DIVERS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_TIROIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TIROIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TIROIR_Click;
			if (_Button_TIROIR != null)
			{
				((Control)_Button_TIROIR).Click -= eventHandler;
			}
			_Button_TIROIR = value;
			if (_Button_TIROIR != null)
			{
				((Control)_Button_TIROIR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_MODIF_PRIX
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MODIF_PRIX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MODIF_PRIX_Click;
			if (_Button_MODIF_PRIX != null)
			{
				((Control)_Button_MODIF_PRIX).Click -= eventHandler;
			}
			_Button_MODIF_PRIX = value;
			if (_Button_MODIF_PRIX != null)
			{
				((Control)_Button_MODIF_PRIX).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_REMISE_Click;
			if (_Button_REMISE != null)
			{
				((Control)_Button_REMISE).Click -= eventHandler;
			}
			_Button_REMISE = value;
			if (_Button_REMISE != null)
			{
				((Control)_Button_REMISE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DUPLICARA_Click;
			if (_Button_DUPLICATA != null)
			{
				((Control)_Button_DUPLICATA).Click -= eventHandler;
			}
			_Button_DUPLICATA = value;
			if (_Button_DUPLICATA != null)
			{
				((Control)_Button_DUPLICATA).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_FLASH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FLASH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FLASH_Click;
			if (_Button_FLASH != null)
			{
				((Control)_Button_FLASH).Click -= eventHandler;
			}
			_Button_FLASH = value;
			if (_Button_FLASH != null)
			{
				((Control)_Button_FLASH).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Button_RAPPORT
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

	internal virtual Button_CLAVIER_NOSELECT Button_DEPENSES
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

	internal virtual Button Button_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CAISSIER_Click;
			if (_Button_CAISSIER != null)
			{
				((Control)_Button_CAISSIER).Click -= eventHandler;
			}
			_Button_CAISSIER = value;
			if (_Button_CAISSIER != null)
			{
				((Control)_Button_CAISSIER).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_VENDEUR_Click;
			if (_Button_VENDEUR != null)
			{
				((Control)_Button_VENDEUR).Click -= eventHandler;
			}
			_Button_VENDEUR = value;
			if (_Button_VENDEUR != null)
			{
				((Control)_Button_VENDEUR).Click += eventHandler;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel4_Paint;
			EventHandler eventHandler = Panel4_Click;
			if (_Panel4 != null)
			{
				((Control)_Panel4).Paint -= val;
				((Control)_Panel4).Click -= eventHandler;
			}
			_Panel4 = value;
			if (_Panel4 != null)
			{
				((Control)_Panel4).Paint += val;
				((Control)_Panel4).Click += eventHandler;
			}
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

	internal virtual Button_CLAVIER_NOSELECT Button_THEME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_THEME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_THEME_Click;
			if (_Button_THEME != null)
			{
				((Control)_Button_THEME).Click -= eventHandler;
			}
			_Button_THEME = value;
			if (_Button_THEME != null)
			{
				((Control)_Button_THEME).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_THEME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_THEME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_THEME = value;
		}
	}

	internal virtual CheckBox Check_CHOIX_VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_CHOIX_VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_CHOIX_VENDEUR = value;
		}
	}

	internal virtual CheckBox Check_CHOIX_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_CHOIX_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_CHOIX_CLIENT = value;
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
			_Text_PRIX_MP = value;
		}
	}

	internal virtual TextBox Text_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_FAMILLE = value;
		}
	}

	internal virtual TextBox Text_PRIXV
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIXV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRIXV = value;
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
			_Text_TAUX_TVA = value;
		}
	}

	internal virtual CheckBox Check_GESTION_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_GESTION_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_GESTION_CREDIT = value;
		}
	}

	internal virtual TextBox Text_pied
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_pied;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_pied = value;
		}
	}

	internal virtual CheckBox CheckBox_AFFICHER_MODEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_AFFICHER_MODEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_AFFICHER_MODEP = value;
		}
	}

	internal virtual TextBox Text_PRINTER_C2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C2 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_C1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C1 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_ADDITION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_ADDITION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_ADDITION = value;
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

	internal virtual TextBox Text_PRINTER_C4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C4 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_C3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C3 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLOTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLOTURE_Click;
			if (_Button_CLOTURE != null)
			{
				((Control)_Button_CLOTURE).Click -= eventHandler;
			}
			_Button_CLOTURE = value;
			if (_Button_CLOTURE != null)
			{
				((Control)_Button_CLOTURE).Click += eventHandler;
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

	internal virtual TextBox Text_MODELE_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MODELE_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_MODELE_TICKET = value;
		}
	}

	internal virtual Label Label_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_QTE_Click;
			EventHandler eventHandler2 = Label_QTE_TextChanged;
			if (_Label_QTE != null)
			{
				((Control)_Label_QTE).Click -= eventHandler;
				((Control)_Label_QTE).TextChanged -= eventHandler2;
			}
			_Label_QTE = value;
			if (_Label_QTE != null)
			{
				((Control)_Label_QTE).Click += eventHandler;
				((Control)_Label_QTE).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qteBACK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qteBACK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qteBACK_Click;
			if (_Button_qteBACK != null)
			{
				((Control)_Button_qteBACK).Click -= eventHandler;
			}
			_Button_qteBACK = value;
			if (_Button_qteBACK != null)
			{
				((Control)_Button_qteBACK).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte0
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte0 != null)
			{
				((Control)_Button_qte0).Click -= eventHandler;
			}
			_Button_qte0 = value;
			if (_Button_qte0 != null)
			{
				((Control)_Button_qte0).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte9 != null)
			{
				((Control)_Button_qte9).Click -= eventHandler;
			}
			_Button_qte9 = value;
			if (_Button_qte9 != null)
			{
				((Control)_Button_qte9).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte8 != null)
			{
				((Control)_Button_qte8).Click -= eventHandler;
			}
			_Button_qte8 = value;
			if (_Button_qte8 != null)
			{
				((Control)_Button_qte8).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte7 != null)
			{
				((Control)_Button_qte7).Click -= eventHandler;
			}
			_Button_qte7 = value;
			if (_Button_qte7 != null)
			{
				((Control)_Button_qte7).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte6 != null)
			{
				((Control)_Button_qte6).Click -= eventHandler;
			}
			_Button_qte6 = value;
			if (_Button_qte6 != null)
			{
				((Control)_Button_qte6).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte5 != null)
			{
				((Control)_Button_qte5).Click -= eventHandler;
			}
			_Button_qte5 = value;
			if (_Button_qte5 != null)
			{
				((Control)_Button_qte5).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte4 != null)
			{
				((Control)_Button_qte4).Click -= eventHandler;
			}
			_Button_qte4 = value;
			if (_Button_qte4 != null)
			{
				((Control)_Button_qte4).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte3 != null)
			{
				((Control)_Button_qte3).Click -= eventHandler;
			}
			_Button_qte3 = value;
			if (_Button_qte3 != null)
			{
				((Control)_Button_qte3).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte2 != null)
			{
				((Control)_Button_qte2).Click -= eventHandler;
			}
			_Button_qte2 = value;
			if (_Button_qte2 != null)
			{
				((Control)_Button_qte2).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qte1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qte1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qte1 != null)
			{
				((Control)_Button_qte1).Click -= eventHandler;
			}
			_Button_qte1 = value;
			if (_Button_qte1 != null)
			{
				((Control)_Button_qte1).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qteDRAFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qteDRAFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qteDRAFT_Click;
			if (_Button_qteDRAFT != null)
			{
				((Control)_Button_qteDRAFT).Click -= eventHandler;
			}
			_Button_qteDRAFT = value;
			if (_Button_qteDRAFT != null)
			{
				((Control)_Button_qteDRAFT).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qteDOT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qteDOT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_qte1_Click;
			if (_Button_qteDOT != null)
			{
				((Control)_Button_qteDOT).Click -= eventHandler;
			}
			_Button_qteDOT = value;
			if (_Button_qteDOT != null)
			{
				((Control)_Button_qteDOT).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_qtewhite
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_qtewhite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_qtewhite = value;
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

	internal virtual PictureBox Picture_FLECH_HAUT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FLECH_HAUT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_FLECH_HAUT = value;
		}
	}

	internal virtual PictureBox Picture_FLECH_BAS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FLECH_BAS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_FLECH_BAS = value;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CALCULATRICE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALCULATRICE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALCULATRICE_Click;
			if (_Button_CALCULATRICE != null)
			{
				((Control)_Button_CALCULATRICE).Click -= eventHandler;
			}
			_Button_CALCULATRICE = value;
			if (_Button_CALCULATRICE != null)
			{
				((Control)_Button_CALCULATRICE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_COMPTER_CAISSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_COMPTER_CAISSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_COMPTER_CAISSE_Click;
			if (_Button_COMPTER_CAISSE != null)
			{
				((Control)_Button_COMPTER_CAISSE).Click -= eventHandler;
			}
			_Button_COMPTER_CAISSE = value;
			if (_Button_COMPTER_CAISSE != null)
			{
				((Control)_Button_COMPTER_CAISSE).Click += eventHandler;
			}
		}
	}

	internal virtual CheckBox CheckBox_AFFICHER_CODEBARRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_AFFICHER_CODEBARRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_AFFICHER_CODEBARRE = value;
		}
	}

	internal virtual CheckBox CheckBox_AFFICHER_N_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_AFFICHER_N_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_AFFICHER_N_TICKET = value;
		}
	}

	internal virtual CheckBox CheckBox_AFFICHER_MODEV
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_AFFICHER_MODEV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_AFFICHER_MODEV = value;
		}
	}

	internal virtual CheckBox Check_SOLDER_SANS_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_SOLDER_SANS_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_SOLDER_SANS_TICKET = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_SOLDER_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SOLDER_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			EventHandler eventHandler2 = Button_SOLDER_CREDIT_GotFocus;
			if (_Button_SOLDER_CREDIT != null)
			{
				((Control)_Button_SOLDER_CREDIT).Click -= eventHandler;
				((Control)_Button_SOLDER_CREDIT).GotFocus -= eventHandler2;
			}
			_Button_SOLDER_CREDIT = value;
			if (_Button_SOLDER_CREDIT != null)
			{
				((Control)_Button_SOLDER_CREDIT).Click += eventHandler;
				((Control)_Button_SOLDER_CREDIT).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_FERMER
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

	internal virtual Button_CLAVIER_NOSELECT Button_FERMER2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FERMER2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FERMER2_Click;
			if (_Button_FERMER2 != null)
			{
				((Control)_Button_FERMER2).Click -= eventHandler;
			}
			_Button_FERMER2 = value;
			if (_Button_FERMER2 != null)
			{
				((Control)_Button_FERMER2).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button2626
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2626;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button26_Click;
			if (_Button2626 != null)
			{
				((Control)_Button2626).Click -= eventHandler;
			}
			_Button2626 = value;
			if (_Button2626 != null)
			{
				((Control)_Button2626).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button2121
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2121;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button21_Click;
			if (_Button2121 != null)
			{
				((Control)_Button2121).Click -= eventHandler;
			}
			_Button2121 = value;
			if (_Button2121 != null)
			{
				((Control)_Button2121).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button1717
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1717;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button17_Click;
			if (_Button1717 != null)
			{
				((Control)_Button1717).Click -= eventHandler;
			}
			_Button1717 = value;
			if (_Button1717 != null)
			{
				((Control)_Button1717).Click += eventHandler;
			}
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
			EventHandler eventHandler = Text_PROMOTION_TextChanged;
			if (_Text_PROMOTION != null)
			{
				((Control)_Text_PROMOTION).TextChanged -= eventHandler;
			}
			_Text_PROMOTION = value;
			if (_Text_PROMOTION != null)
			{
				((Control)_Text_PROMOTION).TextChanged += eventHandler;
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

	internal virtual PrintDocument ERREUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _ERREUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = ERREUR_PrintPage;
			if (_ERREUR != null)
			{
				_ERREUR.PrintPage -= val;
			}
			_ERREUR = value;
			if (_ERREUR != null)
			{
				_ERREUR.PrintPage += val;
			}
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

	internal virtual Button_CLAVIER_NOSELECT Button_LISTE_ATTENTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_LISTE_ATTENTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button23_Click;
			if (_Button_LISTE_ATTENTE != null)
			{
				((Control)_Button_LISTE_ATTENTE).Click -= eventHandler;
			}
			_Button_LISTE_ATTENTE = value;
			if (_Button_LISTE_ATTENTE != null)
			{
				((Control)_Button_LISTE_ATTENTE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_ATTENTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ATTENTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button25_Click;
			if (_Button_ATTENTE != null)
			{
				((Control)_Button_ATTENTE).Click -= eventHandler;
			}
			_Button_ATTENTE = value;
			if (_Button_ATTENTE != null)
			{
				((Control)_Button_ATTENTE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button3
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

	internal virtual Button Button_876
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_876;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_876_Click;
			if (_Button_876 != null)
			{
				((Control)_Button_876).Click -= eventHandler;
			}
			_Button_876 = value;
			if (_Button_876 != null)
			{
				((Control)_Button_876).Click += eventHandler;
			}
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
			EventHandler eventHandler = TabControl2_Click;
			if (_TabControl2 != null)
			{
				((Control)_TabControl2).Click -= eventHandler;
			}
			_TabControl2 = value;
			if (_TabControl2 != null)
			{
				((Control)_TabControl2).Click += eventHandler;
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

	internal virtual DataGridView DataGridView100
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView100_Click;
			EventHandler eventHandler2 = DataGridView100_DoubleClick;
			DataGridViewCellEventHandler val = DataGridView100_CellContentClick;
			if (_DataGridView100 != null)
			{
				((Control)_DataGridView100).Click -= eventHandler;
				((Control)_DataGridView100).DoubleClick -= eventHandler2;
				_DataGridView100.CellContentClick -= val;
			}
			_DataGridView100 = value;
			if (_DataGridView100 != null)
			{
				((Control)_DataGridView100).Click += eventHandler;
				((Control)_DataGridView100).DoubleClick += eventHandler2;
				_DataGridView100.CellContentClick += val;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn Codeee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Codeee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Codeee = value;
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

	internal virtual DataGridViewTextBoxColumn Prix_VV
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_VV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_VV = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Stock
	{
		[DebuggerNonUserCode]
		get
		{
			return _Stock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Stock = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel1 = value;
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

	internal virtual FlowLayoutPanel FlowLayout_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayout_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayout_ARTICLES = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel2 = value;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT2 = value;
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
			_Button_CLAVIER_NOSELECT1 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT3 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT4 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT5 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT6 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT7 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT8 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT9 = value;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_AR_Click;
			if (_Butt_AR != null)
			{
				((Control)_Butt_AR).Click -= eventHandler;
			}
			_Butt_AR = value;
			if (_Butt_AR != null)
			{
				((Control)_Butt_AR).Click += eventHandler;
			}
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT10 = value;
		}
	}

	internal virtual Panel Panel_CLAVIER_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLAVIER_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLAVIER_AR = value;
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel4 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT19 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT11 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_1_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_1_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_1_AR != null)
			{
				((Control)_Butt_1_AR).Click -= eventHandler;
			}
			_Butt_1_AR = value;
			if (_Butt_1_AR != null)
			{
				((Control)_Butt_1_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_2_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_2_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_2_AR != null)
			{
				((Control)_Butt_2_AR).Click -= eventHandler;
			}
			_Butt_2_AR = value;
			if (_Butt_2_AR != null)
			{
				((Control)_Butt_2_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_3_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_3_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_3_AR != null)
			{
				((Control)_Butt_3_AR).Click -= eventHandler;
			}
			_Butt_3_AR = value;
			if (_Butt_3_AR != null)
			{
				((Control)_Butt_3_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_4_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_4_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_4_AR != null)
			{
				((Control)_Butt_4_AR).Click -= eventHandler;
			}
			_Butt_4_AR = value;
			if (_Butt_4_AR != null)
			{
				((Control)_Butt_4_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_5_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_5_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_5_AR != null)
			{
				((Control)_Butt_5_AR).Click -= eventHandler;
			}
			_Butt_5_AR = value;
			if (_Butt_5_AR != null)
			{
				((Control)_Butt_5_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_6_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_6_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_6_AR != null)
			{
				((Control)_Butt_6_AR).Click -= eventHandler;
			}
			_Butt_6_AR = value;
			if (_Butt_6_AR != null)
			{
				((Control)_Butt_6_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_7_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_7_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_7_AR != null)
			{
				((Control)_Butt_7_AR).Click -= eventHandler;
			}
			_Butt_7_AR = value;
			if (_Butt_7_AR != null)
			{
				((Control)_Butt_7_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_8_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_8_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_8_AR != null)
			{
				((Control)_Butt_8_AR).Click -= eventHandler;
			}
			_Butt_8_AR = value;
			if (_Butt_8_AR != null)
			{
				((Control)_Butt_8_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_9_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_9_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_9_AR != null)
			{
				((Control)_Butt_9_AR).Click -= eventHandler;
			}
			_Butt_9_AR = value;
			if (_Butt_9_AR != null)
			{
				((Control)_Butt_9_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_0_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_0_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_0_AR != null)
			{
				((Control)_Butt_0_AR).Click -= eventHandler;
			}
			_Butt_0_AR = value;
			if (_Butt_0_AR != null)
			{
				((Control)_Butt_0_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ك
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ك;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ك != null)
			{
				((Control)_Butt_ك).Click -= eventHandler;
			}
			_Butt_ك = value;
			if (_Butt_ك != null)
			{
				((Control)_Butt_ك).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ض
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ض;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ض != null)
			{
				((Control)_Butt_ض).Click -= eventHandler;
			}
			_Butt_ض = value;
			if (_Butt_ض != null)
			{
				((Control)_Butt_ض).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_م
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_م;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_م != null)
			{
				((Control)_Butt_م).Click -= eventHandler;
			}
			_Butt_م = value;
			if (_Butt_م != null)
			{
				((Control)_Butt_م).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ص
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ص;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ص != null)
			{
				((Control)_Butt_ص).Click -= eventHandler;
			}
			_Butt_ص = value;
			if (_Butt_ص != null)
			{
				((Control)_Butt_ص).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT14 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ن
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ن;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ن != null)
			{
				((Control)_Butt_ن).Click -= eventHandler;
			}
			_Butt_ن = value;
			if (_Butt_ن != null)
			{
				((Control)_Butt_ن).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ث
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ث;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ث != null)
			{
				((Control)_Butt_ث).Click -= eventHandler;
			}
			_Butt_ث = value;
			if (_Butt_ث != null)
			{
				((Control)_Butt_ث).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ت
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ت;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ت != null)
			{
				((Control)_Butt_ت).Click -= eventHandler;
			}
			_Butt_ت = value;
			if (_Butt_ت != null)
			{
				((Control)_Butt_ت).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ق
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ق;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ق != null)
			{
				((Control)_Butt_ق).Click -= eventHandler;
			}
			_Butt_ق = value;
			if (_Butt_ق != null)
			{
				((Control)_Butt_ق).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ا
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ا;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ا != null)
			{
				((Control)_Butt_ا).Click -= eventHandler;
			}
			_Butt_ا = value;
			if (_Butt_ا != null)
			{
				((Control)_Butt_ا).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ف
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ف;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ف != null)
			{
				((Control)_Butt_ف).Click -= eventHandler;
			}
			_Butt_ف = value;
			if (_Butt_ف != null)
			{
				((Control)_Butt_ف).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ل
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ل;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ل != null)
			{
				((Control)_Butt_ل).Click -= eventHandler;
			}
			_Butt_ل = value;
			if (_Butt_ل != null)
			{
				((Control)_Butt_ل).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_غ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_غ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_غ != null)
			{
				((Control)_Butt_غ).Click -= eventHandler;
			}
			_Butt_غ = value;
			if (_Butt_غ != null)
			{
				((Control)_Butt_غ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ب
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ب;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ب != null)
			{
				((Control)_Butt_ب).Click -= eventHandler;
			}
			_Butt_ب = value;
			if (_Butt_ب != null)
			{
				((Control)_Butt_ب).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ع
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ع;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ع != null)
			{
				((Control)_Butt_ع).Click -= eventHandler;
			}
			_Butt_ع = value;
			if (_Butt_ع != null)
			{
				((Control)_Butt_ع).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ي
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ي;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ي != null)
			{
				((Control)_Butt_ي).Click -= eventHandler;
			}
			_Butt_ي = value;
			if (_Butt_ي != null)
			{
				((Control)_Butt_ي).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ه
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ه;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ه != null)
			{
				((Control)_Butt_ه).Click -= eventHandler;
			}
			_Butt_ه = value;
			if (_Butt_ه != null)
			{
				((Control)_Butt_ه).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_س
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_س;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_س != null)
			{
				((Control)_Butt_س).Click -= eventHandler;
			}
			_Butt_س = value;
			if (_Butt_س != null)
			{
				((Control)_Butt_س).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_خ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_خ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_خ != null)
			{
				((Control)_Butt_خ).Click -= eventHandler;
			}
			_Butt_خ = value;
			if (_Butt_خ != null)
			{
				((Control)_Butt_خ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ش
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ش;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ش != null)
			{
				((Control)_Butt_ش).Click -= eventHandler;
			}
			_Butt_ش = value;
			if (_Butt_ش != null)
			{
				((Control)_Butt_ش).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ح
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ح;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ح != null)
			{
				((Control)_Butt_ح).Click -= eventHandler;
			}
			_Butt_ح = value;
			if (_Butt_ح != null)
			{
				((Control)_Butt_ح).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ج
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ج;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ج != null)
			{
				((Control)_Butt_ج).Click -= eventHandler;
			}
			_Butt_ج = value;
			if (_Butt_ج != null)
			{
				((Control)_Butt_ج).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_DRAFT_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_DRAFT_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_DRAFT_AR_Click;
			if (_Butt_DRAFT_AR != null)
			{
				((Control)_Butt_DRAFT_AR).Click -= eventHandler;
			}
			_Butt_DRAFT_AR = value;
			if (_Butt_DRAFT_AR != null)
			{
				((Control)_Butt_DRAFT_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_BACK_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_BACK_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_BACK_AR_Click;
			if (_Butt_BACK_AR != null)
			{
				((Control)_Butt_BACK_AR).Click -= eventHandler;
			}
			_Butt_BACK_AR = value;
			if (_Butt_BACK_AR != null)
			{
				((Control)_Butt_BACK_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_د
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_د;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_د != null)
			{
				((Control)_Butt_د).Click -= eventHandler;
			}
			_Butt_د = value;
			if (_Butt_د != null)
			{
				((Control)_Butt_د).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ط
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ط;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ط != null)
			{
				((Control)_Butt_ط).Click -= eventHandler;
			}
			_Butt_ط = value;
			if (_Butt_ط != null)
			{
				((Control)_Butt_ط).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ظ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ظ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ظ != null)
			{
				((Control)_Butt_ظ).Click -= eventHandler;
			}
			_Butt_ظ = value;
			if (_Butt_ظ != null)
			{
				((Control)_Butt_ظ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ز
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ز;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ز != null)
			{
				((Control)_Butt_ز).Click -= eventHandler;
			}
			_Butt_ز = value;
			if (_Butt_ز != null)
			{
				((Control)_Butt_ز).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_و
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_و;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_و != null)
			{
				((Control)_Butt_و).Click -= eventHandler;
			}
			_Butt_و = value;
			if (_Butt_و != null)
			{
				((Control)_Butt_و).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ة
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ة;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ة != null)
			{
				((Control)_Butt_ة).Click -= eventHandler;
			}
			_Butt_ة = value;
			if (_Butt_ة != null)
			{
				((Control)_Butt_ة).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ى
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ى;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ى != null)
			{
				((Control)_Butt_ى).Click -= eventHandler;
			}
			_Butt_ى = value;
			if (_Butt_ى != null)
			{
				((Control)_Butt_ى).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_لا
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_لا;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_لا != null)
			{
				((Control)_Butt_لا).Click -= eventHandler;
			}
			_Butt_لا = value;
			if (_Butt_لا != null)
			{
				((Control)_Butt_لا).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ر
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ر;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ر != null)
			{
				((Control)_Butt_ر).Click -= eventHandler;
			}
			_Butt_ر = value;
			if (_Butt_ر != null)
			{
				((Control)_Butt_ر).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ؤ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ؤ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ؤ != null)
			{
				((Control)_Butt_ؤ).Click -= eventHandler;
			}
			_Butt_ؤ = value;
			if (_Butt_ؤ != null)
			{
				((Control)_Butt_ؤ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ء
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ء;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ء != null)
			{
				((Control)_Butt_ء).Click -= eventHandler;
			}
			_Butt_ء = value;
			if (_Butt_ء != null)
			{
				((Control)_Butt_ء).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ئ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ئ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ئ != null)
			{
				((Control)_Butt_ئ).Click -= eventHandler;
			}
			_Butt_ئ = value;
			if (_Butt_ئ != null)
			{
				((Control)_Butt_ئ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT12 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_DOT_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_DOT_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_DOT_AR != null)
			{
				((Control)_Butt_DOT_AR).Click -= eventHandler;
			}
			_Butt_DOT_AR = value;
			if (_Butt_DOT_AR != null)
			{
				((Control)_Butt_DOT_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT13 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT15 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT16 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT17 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT18 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ذ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ذ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Butt_ذ = value;
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel5 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_FR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_FR_Click;
			if (_Butt_FR != null)
			{
				((Control)_Butt_FR).Click -= eventHandler;
			}
			_Butt_FR = value;
			if (_Butt_FR != null)
			{
				((Control)_Butt_FR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_SPACE_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_SPACE_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_SPACE_AR_Click;
			if (_Butt_SPACE_AR != null)
			{
				((Control)_Butt_SPACE_AR).Click -= eventHandler;
			}
			_Butt_SPACE_AR = value;
			if (_Butt_SPACE_AR != null)
			{
				((Control)_Butt_SPACE_AR).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_PRINTER_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_DUPLICATA = value;
		}
	}

	internal virtual TextBox Text_PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER = value;
		}
	}

	internal virtual PrintDocument C1
	{
		[DebuggerNonUserCode]
		get
		{
			return _C1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = C1_PrintPage;
			if (_C1 != null)
			{
				_C1.PrintPage -= val;
			}
			_C1 = value;
			if (_C1 != null)
			{
				_C1.PrintPage += val;
			}
		}
	}

	internal virtual DataGridView DataGridView_ACCES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_ACCES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_ACCES = value;
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

	internal virtual Panel Panel_RACCOURCIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_RACCOURCIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_RACCOURCIES = value;
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

	internal virtual FlowLayoutPanel FlowLayout_RACCOURCIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayout_RACCOURCIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayout_RACCOURCIES = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT24 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT23 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT22 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT21 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT20 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_RACCOURCIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RACCOURCIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RACCOURCIES_Click;
			if (_Button_RACCOURCIES != null)
			{
				((Control)_Button_RACCOURCIES).Click -= eventHandler;
			}
			_Button_RACCOURCIES = value;
			if (_Button_RACCOURCIES != null)
			{
				((Control)_Button_RACCOURCIES).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT25 = value;
		}
	}

	internal virtual TextBox Text_GROUPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_GROUPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_GROUPE = value;
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

	internal virtual SplitContainer SplitContainer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer2 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT26 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT27 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT28 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT29 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT30 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT31 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT32 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CLAVIER_NOSELECT33 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_ALERTS_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ALERTS_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ALERTS_STOCK_Click;
			if (_Button_ALERTS_STOCK != null)
			{
				((Control)_Button_ALERTS_STOCK).Click -= eventHandler;
			}
			_Button_ALERTS_STOCK = value;
			if (_Button_ALERTS_STOCK != null)
			{
				((Control)_Button_ALERTS_STOCK).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_FONDS_CAISSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FONDS_CAISSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FONDS_CAISSE_Click;
			if (_Button_FONDS_CAISSE != null)
			{
				((Control)_Button_FONDS_CAISSE).Click -= eventHandler;
			}
			_Button_FONDS_CAISSE = value;
			if (_Button_FONDS_CAISSE != null)
			{
				((Control)_Button_FONDS_CAISSE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLIENTS
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

	internal virtual Button_CLAVIER_NOSELECT Button_INVENTAIRE
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

	internal virtual Button_CLAVIER_NOSELECT Button_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ARTICLES_Click;
			if (_Button_ARTICLES != null)
			{
				((Control)_Button_ARTICLES).Click -= eventHandler;
			}
			_Button_ARTICLES = value;
			if (_Button_ARTICLES != null)
			{
				((Control)_Button_ARTICLES).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLIENTS_REGLEMENTS
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

	internal virtual Button_CLAVIER_NOSELECT Button_SORTIES
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

	internal virtual Button_CLAVIER_NOSELECT Button_RECEPTIONS
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

	internal virtual TextBox Text_PRINTER_C5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C5 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_C7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C7 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_C6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_C6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_C6 = value;
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

	internal virtual Panel Panel_RAPPEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_RAPPEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_RAPPEL = value;
		}
	}

	internal virtual Button Button_RAPPEL_TOTAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPEL_TOTAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_RAPPEL_TOTAL = value;
		}
	}

	internal virtual Button Button_RAPPEL_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPEL_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_RAPPEL_MODE_P = value;
		}
	}

	internal virtual Button Button_RAPPEL_RENDU
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPEL_RENDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_RAPPEL_RENDU = value;
		}
	}

	internal virtual Button Button_RAPPEL_PAYER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPEL_PAYER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_RAPPEL_PAYER = value;
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
			_Text_PRIX_QTE_MIN = value;
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
			_Text_PRIX_QTE = value;
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

	internal virtual DataGridViewTextBoxColumn Prix_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_V = value;
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

	internal virtual DataGridViewTextBoxColumn PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRINTER = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRINTER_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRINTER_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRINTER_DUPLICATA = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT34_Click;
			if (_Button_CLAVIER_NOSELECT34 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT34).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT34 = value;
			if (_Button_CLAVIER_NOSELECT34 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT34).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT35_Click;
			if (_Button_CLAVIER_NOSELECT35 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT35).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT35 = value;
			if (_Button_CLAVIER_NOSELECT35 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT35).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_LOGO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_LOGO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_LOGO = value;
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

	internal virtual Panel Panel_LOGO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_LOGO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_LOGO = value;
		}
	}

	protected virtual VScrollBar vScrollBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _vScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			ScrollEventHandler val = vScrollBar1_Scroll;
			if (_vScrollBar1 != null)
			{
				((ScrollBar)_vScrollBar1).Scroll -= val;
			}
			_vScrollBar1 = value;
			if (_vScrollBar1 != null)
			{
				((ScrollBar)_vScrollBar1).Scroll += val;
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
			_Button2 = value;
		}
	}

	public Form_3_VENTE()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		((Form)this).Activated += Form_vente_Activated;
		((Form)this).Load += Form_vente_Load;
		((Form)this).Shown += Form_3_VENTE_Shown;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		__ENCAddToList(this);
		prn = new RawPrinterHelper();
		dt_LA = new DataTable();
		da_LA = new MySqlDataAdapter();
		dt_PIC = new DataTable();
		da_PIC = new MySqlDataAdapter();
		_string = "";
		InitializeComponent();
		ApplyBasketSelectionContrast();
		ApplyProductListSelectionContrast();
	}

	// Ctrl+F jumps to product search without opening/closing the on-screen keyboard.
	// The original search button remains unchanged, including its layout toggle.
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData == (Keys.Control | Keys.F) && Text_FIND != null && !Text_FIND.IsDisposed && Text_FIND.Enabled && !Text_FIND.ReadOnly && Text_FIND.Visible && !Text_FIND.Focused && !Text_FIND.Disposing)
		{
			Text_FIND.Focus();
			return true;
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}

	// Family colors come from shop configuration and can be very light or dark.
	// Choose the higher-contrast text color without changing the configured background.
	private static Color ReadableFamilyCaptionColor(Color background)
	{
		double luminance = 0.2126 * LinearFamilyColorChannel(background.R)
			+ 0.7152 * LinearFamilyColorChannel(background.G)
			+ 0.0722 * LinearFamilyColorChannel(background.B);
		// WCAG relative-luminance midpoint for black versus white foreground.
		return luminance > 0.179128784747792 ? Color.Black : Color.White;
	}

	private static double LinearFamilyColorChannel(byte channel)
	{
		double value = channel / 255.0;
		return value <= 0.04045 ? value / 12.92 : Math.Pow((value + 0.055) / 1.055, 2.4);
	}

	// Keep the original light-blue product selection readable regardless of inherited theme colors.
	// Reapply after legacy Load, which resets product-list styles on data binding.
	private void ApplyProductListSelectionContrast()
	{
		DataGridView100.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(171, 185, 211);
		DataGridView100.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
	}

	// Keep selected basket quantities and prices readable on the original yellow highlight.
	// Apply at construction for previews and again after the legacy Load styling.
	private void ApplyBasketSelectionContrast()
	{
		DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
		DataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected Obj, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Obj, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected Obj, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected Obj, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected Obj, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected Obj, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected Obj, but got Unknown
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected Obj, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Expected Obj, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected Obj, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got Unknown
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected Obj, but got Unknown
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected Obj, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected Obj, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected Obj, but got Unknown
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected Obj, but got Unknown
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected Obj, but got Unknown
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected Obj, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected Obj, but got Unknown
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected Obj, but got Unknown
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected Obj, but got Unknown
		//IL_0d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got Unknown
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected Obj, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected Obj, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected Obj, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected Obj, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected Obj, but got Unknown
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected Obj, but got Unknown
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected Obj, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Expected Obj, but got Unknown
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Expected Obj, but got Unknown
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Obj, but got Unknown
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got Unknown
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Expected Obj, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected Obj, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected Obj, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected Obj, but got Unknown
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Expected Obj, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected Obj, but got Unknown
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected Obj, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got Unknown
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected Obj, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected Obj, but got Unknown
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Expected Obj, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected Obj, but got Unknown
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected Obj, but got Unknown
		//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected Obj, but got Unknown
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected Obj, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Expected Obj, but got Unknown
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected Obj, but got Unknown
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected Obj, but got Unknown
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eea: Expected Obj, but got Unknown
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Expected Obj, but got Unknown
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected Obj, but got Unknown
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1a: Expected Obj, but got Unknown
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected Obj, but got Unknown
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected Obj, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4a: Expected Obj, but got Unknown
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected Obj, but got Unknown
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected Obj, but got Unknown
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Expected Obj, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Expected Obj, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f86: Expected Obj, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got Unknown
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected Obj, but got Unknown
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected Obj, but got Unknown
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected Obj, but got Unknown
		//IL_1a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected Obj, but got Unknown
		//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b53: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_3_VENTE));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		SplitContainer2 = new SplitContainer();
		Panel0 = new Panel();
		Panel_LOGO = new Panel();
		Picture_LOGO = new PictureBox();
		PictureBox100 = new PictureBox();
		Panel_RAPPEL = new Panel();
		Button_RAPPEL_TOTAL = new Button();
		Button_RAPPEL_MODE_P = new Button();
		Button_RAPPEL_RENDU = new Button();
		Button_RAPPEL_PAYER = new Button();
		Button_SOLDER_CREDIT = new Button_CLAVIER_NOSELECT();
		Label_NBR_ARTICLES = new Label();
		Label3 = new Label();
		Panel2 = new Panel();
		Text_TOTAL_NET = new TextBox();
		Label18 = new Label();
		Button_ANNULATION_ALL = new Button_CLAVIER_NOSELECT();
		Button_ANNULATION = new Button_CLAVIER_NOSELECT();
		DataGridView1 = new DataGridView();
		Article = new DataGridViewTextBoxColumn();
		Prix_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		TOTAL_NET = new DataGridViewTextBoxColumn();
		REMISE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		PRINTER = new DataGridViewTextBoxColumn();
		PRINTER_DUPLICATA = new DataGridViewTextBoxColumn();
		Button_OPERATION = new Button_CLAVIER_NOSELECT();
		Button_FONCTIONS = new Button_CLAVIER_NOSELECT();
		Button_SOLDER_NOT_PRINTER = new Button_CLAVIER_NOSELECT();
		Button_SOLDER_PRINTER = new Button_CLAVIER_NOSELECT();
		Panel00 = new Panel();
		Panel9 = new Panel();
		Label6 = new Label();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		TabControl2 = new TabControl();
		TabPage3 = new TabPage();
		DataGridView100 = new DataGridView();
		Codeee = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		Prix_VV = new DataGridViewTextBoxColumn();
		Stock = new DataGridViewTextBoxColumn();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button1 = new Button();
		TabPage4 = new TabPage();
		FlowLayout_ARTICLES = new FlowLayoutPanel();
		vScrollBar1 = new VScrollBar();
		TableLayoutPanel1 = new TableLayoutPanel();
		Button4 = new Button();
		Button2 = new Button();
		FlowLayoutPanel2 = new FlowLayoutPanel();
		Button5 = new Button();
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		Button_CLAVIER_NOSELECT2 = new Button_CLAVIER_NOSELECT();
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
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT3 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT4 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT5 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT6 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT7 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT8 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT9 = new Button_CLAVIER_NOSELECT();
		TableLayoutPanel3 = new TableLayoutPanel();
		Butt_AR = new Button_CLAVIER_NOSELECT();
		Butt_SPACE = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT10 = new Button_CLAVIER_NOSELECT();
		Panel_CLAVIER_AR = new Panel();
		TableLayoutPanel4 = new TableLayoutPanel();
		Button_CLAVIER_NOSELECT19 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT11 = new Button_CLAVIER_NOSELECT();
		Butt_1_AR = new Button_CLAVIER_NOSELECT();
		Butt_2_AR = new Button_CLAVIER_NOSELECT();
		Butt_3_AR = new Button_CLAVIER_NOSELECT();
		Butt_4_AR = new Button_CLAVIER_NOSELECT();
		Butt_5_AR = new Button_CLAVIER_NOSELECT();
		Butt_6_AR = new Button_CLAVIER_NOSELECT();
		Butt_7_AR = new Button_CLAVIER_NOSELECT();
		Butt_8_AR = new Button_CLAVIER_NOSELECT();
		Butt_9_AR = new Button_CLAVIER_NOSELECT();
		Butt_0_AR = new Button_CLAVIER_NOSELECT();
		Butt_ك = new Button_CLAVIER_NOSELECT();
		Butt_ض = new Button_CLAVIER_NOSELECT();
		Butt_م = new Button_CLAVIER_NOSELECT();
		Butt_ص = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT14 = new Button_CLAVIER_NOSELECT();
		Butt_ن = new Button_CLAVIER_NOSELECT();
		Butt_ث = new Button_CLAVIER_NOSELECT();
		Butt_ت = new Button_CLAVIER_NOSELECT();
		Butt_ق = new Button_CLAVIER_NOSELECT();
		Butt_ا = new Button_CLAVIER_NOSELECT();
		Butt_ف = new Button_CLAVIER_NOSELECT();
		Butt_ل = new Button_CLAVIER_NOSELECT();
		Butt_غ = new Button_CLAVIER_NOSELECT();
		Butt_ب = new Button_CLAVIER_NOSELECT();
		Butt_ع = new Button_CLAVIER_NOSELECT();
		Butt_ي = new Button_CLAVIER_NOSELECT();
		Butt_ه = new Button_CLAVIER_NOSELECT();
		Butt_س = new Button_CLAVIER_NOSELECT();
		Butt_خ = new Button_CLAVIER_NOSELECT();
		Butt_ش = new Button_CLAVIER_NOSELECT();
		Butt_ح = new Button_CLAVIER_NOSELECT();
		Butt_ج = new Button_CLAVIER_NOSELECT();
		Butt_DRAFT_AR = new Button_CLAVIER_NOSELECT();
		Butt_BACK_AR = new Button_CLAVIER_NOSELECT();
		Butt_د = new Button_CLAVIER_NOSELECT();
		Butt_ط = new Button_CLAVIER_NOSELECT();
		Butt_ظ = new Button_CLAVIER_NOSELECT();
		Butt_ز = new Button_CLAVIER_NOSELECT();
		Butt_و = new Button_CLAVIER_NOSELECT();
		Butt_ة = new Button_CLAVIER_NOSELECT();
		Butt_ى = new Button_CLAVIER_NOSELECT();
		Butt_لا = new Button_CLAVIER_NOSELECT();
		Butt_ر = new Button_CLAVIER_NOSELECT();
		Butt_ؤ = new Button_CLAVIER_NOSELECT();
		Butt_ء = new Button_CLAVIER_NOSELECT();
		Butt_ئ = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT12 = new Button_CLAVIER_NOSELECT();
		Butt_DOT_AR = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT13 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT15 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT16 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT17 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT18 = new Button_CLAVIER_NOSELECT();
		Butt_ذ = new Button_CLAVIER_NOSELECT();
		TableLayoutPanel5 = new TableLayoutPanel();
		Butt_FR = new Button_CLAVIER_NOSELECT();
		Butt_SPACE_AR = new Button_CLAVIER_NOSELECT();
		Panel6 = new Panel();
		Label_QTE = new Label();
		Label16 = new Label();
		Label17 = new Label();
		Label19 = new Label();
		Label20 = new Label();
		Button_qteBACK = new Button_CLAVIER_NOSELECT();
		Button_qte7 = new Button_CLAVIER_NOSELECT();
		Button_qteDOT = new Button_CLAVIER_NOSELECT();
		Button_qtewhite = new Button_CLAVIER_NOSELECT();
		Button_qte0 = new Button_CLAVIER_NOSELECT();
		Button_qte3 = new Button_CLAVIER_NOSELECT();
		Button_qte6 = new Button_CLAVIER_NOSELECT();
		Button_qte2 = new Button_CLAVIER_NOSELECT();
		Button_qte9 = new Button_CLAVIER_NOSELECT();
		Button_qte1 = new Button_CLAVIER_NOSELECT();
		Button_qte5 = new Button_CLAVIER_NOSELECT();
		Button_qte4 = new Button_CLAVIER_NOSELECT();
		Button_qte8 = new Button_CLAVIER_NOSELECT();
		Button_qteDRAFT = new Button_CLAVIER_NOSELECT();
		Panel4 = new Panel();
		Label2 = new Label();
		Label9 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Button_876 = new Button();
		Text_FIND = new TextBox();
		Panel33 = new Panel();
		Button2626 = new Button();
		Button2121 = new Button();
		Button1717 = new Button();
		Button_CAISSIER = new Button();
		Button244 = new Button();
		Button_VENDEUR = new Button();
		Button_CLIENT = new Button_ID_CODE();
		Panel5 = new Panel();
		Label4 = new Label();
		Label5 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Button_FIND = new Button();
		Text_CODE = new TextBox();
		Button_GO = new Button();
		Text_PRIX_QTE_MIN = new TextBox();
		Text_PRIX_QTE = new TextBox();
		Text_ID_TICKET = new TextBox();
		CL_FR_3C = new PrintDocument();
		Text_HEURE_RETARD = new TextBox();
		List_COLOR = new ListBox();
		Button16 = new Button();
		Check_ACCES_RFID = new CheckBox();
		Check_ACCES_MODEP = new CheckBox();
		BON_RETOUR = new PrintDocument();
		Combo_BAUDRATE = new ComboBox();
		Combo_PORT = new ComboBox();
		Check_STOCK = new CheckBox();
		Panel_FONCTIONS = new Panel();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Button_CLAVIER_NOSELECT35 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT34 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT25 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT24 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT23 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT22 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT21 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT20 = new Button_CLAVIER_NOSELECT();
		Button_RACCOURCIES = new Button_CLAVIER_NOSELECT();
		Button_FERMER = new Button_CLAVIER_NOSELECT();
		Button_COMPTER_CAISSE = new Button_CLAVIER_NOSELECT();
		Button_CALCULATRICE = new Button_CLAVIER_NOSELECT();
		Button3 = new Button_CLAVIER_NOSELECT();
		Button_LISTE_ATTENTE = new Button_CLAVIER_NOSELECT();
		Button_LOCK = new Button_CLAVIER_NOSELECT();
		Button_RAPPORT = new Button_CLAVIER_NOSELECT();
		Button_DEPENSES = new Button_CLAVIER_NOSELECT();
		Button_THEME = new Button_CLAVIER_NOSELECT();
		Button_ATTENTE = new Button_CLAVIER_NOSELECT();
		Button_PRIX = new Button_CLAVIER_NOSELECT();
		Button_MODIF_QTE = new Button_CLAVIER_NOSELECT();
		Button_DIVERS = new Button_CLAVIER_NOSELECT();
		Button_TIROIR = new Button_CLAVIER_NOSELECT();
		Button_MODIF_PRIX = new Button_CLAVIER_NOSELECT();
		Button_REMISE = new Button_CLAVIER_NOSELECT();
		Button_DUPLICATA = new Button_CLAVIER_NOSELECT();
		Button_FLASH = new Button_CLAVIER_NOSELECT();
		Button_CLOTURE = new Button_CLAVIER_NOSELECT();
		TabPage2 = new TabPage();
		Button_CLAVIER_NOSELECT26 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT27 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT28 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT29 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT30 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT31 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT32 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT33 = new Button_CLAVIER_NOSELECT();
		Button_ALERTS_STOCK = new Button_CLAVIER_NOSELECT();
		Button_FONDS_CAISSE = new Button_CLAVIER_NOSELECT();
		Button_CLIENTS = new Button_CLAVIER_NOSELECT();
		Button_INVENTAIRE = new Button_CLAVIER_NOSELECT();
		Button_ARTICLES = new Button_CLAVIER_NOSELECT();
		Button_CLIENTS_REGLEMENTS = new Button_CLAVIER_NOSELECT();
		Button_SORTIES = new Button_CLAVIER_NOSELECT();
		Button_RECEPTIONS = new Button_CLAVIER_NOSELECT();
		Button_FERMER2 = new Button_CLAVIER_NOSELECT();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Text_THEME = new TextBox();
		Check_CHOIX_VENDEUR = new CheckBox();
		Check_CHOIX_CLIENT = new CheckBox();
		ListBox_VENDEURS = new ListBox();
		Panel1 = new Panel();
		Text_GROUPE = new TextBox();
		Panel10 = new Panel();
		Panel_RACCOURCIES = new Panel();
		Label10 = new Label();
		FlowLayout_RACCOURCIES = new FlowLayoutPanel();
		DataGridView_ACCES = new DataGridView();
		Text_PRINTER_DUPLICATA = new TextBox();
		Text_PRINTER = new TextBox();
		CheckBox_AFFICHER_CODEBARRE = new CheckBox();
		DataGridView_MODE_P = new DataGridView();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		CheckBox_AFFICHER_N_TICKET = new CheckBox();
		Text_ID_ARTICLE = new TextBox();
		CheckBox_AFFICHER_MODEV = new CheckBox();
		Text_PROMOTION = new TextBox();
		CheckBox_AFFICHER_MODEP = new CheckBox();
		Check_SOLDER_SANS_TICKET = new CheckBox();
		Text_pied = new TextBox();
		Picture_FLECH_HAUT = new PictureBox();
		Picture_FLECH_BAS = new PictureBox();
		Text_MODELE_TICKET = new TextBox();
		Text_PRINTER_C2 = new TextBox();
		Text_PRINTER_C1 = new TextBox();
		Text_PRINTER_ADDITION = new TextBox();
		Text_PRINTER_SOLDER = new TextBox();
		Text_PRINTER_C4 = new TextBox();
		Text_PRINTER_C3 = new TextBox();
		Check_GESTION_CREDIT = new CheckBox();
		Text_PRIX_A = new TextBox();
		Text_ARTICLE = new TextBox();
		Text_PRIX_MP = new TextBox();
		Text_FAMILLE = new TextBox();
		Text_PRIXV = new TextBox();
		Text_TAUX_TVA = new TextBox();
		Picture_TRISTE = new PictureBox();
		Picture_SMILE = new PictureBox();
		Text_PRINTER_C5 = new TextBox();
		Text_PRINTER_C7 = new TextBox();
		Text_PRINTER_C6 = new TextBox();
		CL_FR_2L = new PrintDocument();
		CL_FR_4C = new PrintDocument();
		CL_AR_4C = new PrintDocument();
		ERREUR = new PrintDocument();
		C1 = new PrintDocument();
		CL_AR_3C = new PrintDocument();
		((ISupportInitialize)SplitContainer2).BeginInit();
		((Control)SplitContainer2.Panel1).SuspendLayout();
		((Control)SplitContainer2.Panel2).SuspendLayout();
		((Control)SplitContainer2).SuspendLayout();
		((Control)Panel0).SuspendLayout();
		((Control)Panel_LOGO).SuspendLayout();
		((ISupportInitialize)Picture_LOGO).BeginInit();
		((ISupportInitialize)PictureBox100).BeginInit();
		((Control)Panel_RAPPEL).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel00).SuspendLayout();
		((Control)Panel9).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((ISupportInitialize)DataGridView100).BeginInit();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)FlowLayoutPanel2).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel3).SuspendLayout();
		((Control)Panel_CLAVIER_AR).SuspendLayout();
		((Control)TableLayoutPanel4).SuspendLayout();
		((Control)TableLayoutPanel5).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel33).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel10).SuspendLayout();
		((Control)Panel_RACCOURCIES).SuspendLayout();
		((ISupportInitialize)DataGridView_ACCES).BeginInit();
		((ISupportInitialize)DataGridView_MODE_P).BeginInit();
		((ISupportInitialize)Picture_FLECH_HAUT).BeginInit();
		((ISupportInitialize)Picture_FLECH_BAS).BeginInit();
		((ISupportInitialize)Picture_TRISTE).BeginInit();
		((ISupportInitialize)Picture_SMILE).BeginInit();
		((Control)this).SuspendLayout();
		((Control)SplitContainer2).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(SplitContainer2, "SplitContainer2");
		((Control)SplitContainer2).Name = "SplitContainer2";
		((Control)SplitContainer2.Panel1).BackColor = Color.White;
		((Control)SplitContainer2.Panel1).Controls.Add((Control)(object)Panel0);
		((Control)SplitContainer2.Panel2).BackColor = Color.White;
		((Control)SplitContainer2.Panel2).Controls.Add((Control)(object)Panel00);
		((Control)Panel0).Controls.Add((Control)(object)Panel_LOGO);
		((Control)Panel0).Controls.Add((Control)(object)PictureBox100);
		((Control)Panel0).Controls.Add((Control)(object)Panel_RAPPEL);
		((Control)Panel0).Controls.Add((Control)(object)Button_SOLDER_CREDIT);
		((Control)Panel0).Controls.Add((Control)(object)Label_NBR_ARTICLES);
		((Control)Panel0).Controls.Add((Control)(object)Label3);
		((Control)Panel0).Controls.Add((Control)(object)Panel2);
		((Control)Panel0).Controls.Add((Control)(object)Button_ANNULATION_ALL);
		((Control)Panel0).Controls.Add((Control)(object)Button_ANNULATION);
		((Control)Panel0).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel0).Controls.Add((Control)(object)Button_OPERATION);
		((Control)Panel0).Controls.Add((Control)(object)Button_FONCTIONS);
		((Control)Panel0).Controls.Add((Control)(object)Button_SOLDER_NOT_PRINTER);
		((Control)Panel0).Controls.Add((Control)(object)Button_SOLDER_PRINTER);
		componentResourceManager.ApplyResources(Panel0, "Panel0");
		((Control)Panel0).Name = "Panel0";
		((Control)Panel_LOGO).BackColor = Color.FromArgb(220, 232, 250);
		((Control)Panel_LOGO).Controls.Add((Control)(object)Picture_LOGO);
		componentResourceManager.ApplyResources(Panel_LOGO, "Panel_LOGO");
		((Control)Panel_LOGO).Name = "Panel_LOGO";
		componentResourceManager.ApplyResources(Picture_LOGO, "Picture_LOGO");
		((Control)Picture_LOGO).Name = "Picture_LOGO";
		Picture_LOGO.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox100, "PictureBox100");
		((Control)PictureBox100).BackColor = Color.White;
		((Control)PictureBox100).Name = "PictureBox100";
		PictureBox100.TabStop = false;
		componentResourceManager.ApplyResources(Panel_RAPPEL, "Panel_RAPPEL");
		((Control)Panel_RAPPEL).BackColor = Color.Blue;
		((Control)Panel_RAPPEL).Controls.Add((Control)(object)Button_RAPPEL_TOTAL);
		((Control)Panel_RAPPEL).Controls.Add((Control)(object)Button_RAPPEL_MODE_P);
		((Control)Panel_RAPPEL).Controls.Add((Control)(object)Button_RAPPEL_RENDU);
		((Control)Panel_RAPPEL).Controls.Add((Control)(object)Button_RAPPEL_PAYER);
		((Control)Panel_RAPPEL).Name = "Panel_RAPPEL";
		componentResourceManager.ApplyResources(Button_RAPPEL_TOTAL, "Button_RAPPEL_TOTAL");
		((ButtonBase)Button_RAPPEL_TOTAL).BackColor = Color.Blue;
		((ButtonBase)Button_RAPPEL_TOTAL).FlatAppearance.BorderColor = Color.White;
		((ButtonBase)Button_RAPPEL_TOTAL).FlatAppearance.BorderSize = 5;
		((Control)Button_RAPPEL_TOTAL).ForeColor = Color.White;
		((Control)Button_RAPPEL_TOTAL).Name = "Button_RAPPEL_TOTAL";
		((ButtonBase)Button_RAPPEL_TOTAL).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_RAPPEL_MODE_P, "Button_RAPPEL_MODE_P");
		((ButtonBase)Button_RAPPEL_MODE_P).BackColor = Color.Blue;
		((ButtonBase)Button_RAPPEL_MODE_P).FlatAppearance.BorderColor = Color.White;
		((ButtonBase)Button_RAPPEL_MODE_P).FlatAppearance.BorderSize = 2;
		((Control)Button_RAPPEL_MODE_P).ForeColor = Color.White;
		((Control)Button_RAPPEL_MODE_P).Name = "Button_RAPPEL_MODE_P";
		((ButtonBase)Button_RAPPEL_MODE_P).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_RAPPEL_RENDU, "Button_RAPPEL_RENDU");
		((ButtonBase)Button_RAPPEL_RENDU).BackColor = Color.Blue;
		((ButtonBase)Button_RAPPEL_RENDU).FlatAppearance.BorderColor = Color.White;
		((ButtonBase)Button_RAPPEL_RENDU).FlatAppearance.BorderSize = 2;
		((Control)Button_RAPPEL_RENDU).ForeColor = Color.White;
		((Control)Button_RAPPEL_RENDU).Name = "Button_RAPPEL_RENDU";
		((ButtonBase)Button_RAPPEL_RENDU).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_RAPPEL_PAYER, "Button_RAPPEL_PAYER");
		((ButtonBase)Button_RAPPEL_PAYER).BackColor = Color.Blue;
		((ButtonBase)Button_RAPPEL_PAYER).FlatAppearance.BorderColor = Color.White;
		((ButtonBase)Button_RAPPEL_PAYER).FlatAppearance.BorderSize = 2;
		((Control)Button_RAPPEL_PAYER).ForeColor = Color.White;
		((Control)Button_RAPPEL_PAYER).Name = "Button_RAPPEL_PAYER";
		((ButtonBase)Button_RAPPEL_PAYER).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_SOLDER_CREDIT, "Button_SOLDER_CREDIT");
		((ButtonBase)Button_SOLDER_CREDIT).BackColor = Color.ForestGreen;
		((Control)Button_SOLDER_CREDIT).Cursor = Cursors.Hand;
		((Control)Button_SOLDER_CREDIT).ForeColor = Color.White;
		((Control)Button_SOLDER_CREDIT).Name = "Button_SOLDER_CREDIT";
		((ButtonBase)Button_SOLDER_CREDIT).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Label_NBR_ARTICLES, "Label_NBR_ARTICLES");
		((Control)Label_NBR_ARTICLES).BackColor = Color.Transparent;
		((Control)Label_NBR_ARTICLES).ForeColor = Color.Black;
		((Control)Label_NBR_ARTICLES).Name = "Label_NBR_ARTICLES";
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).ForeColor = Color.Black;
		((Control)Label3).Name = "Label3";
		componentResourceManager.ApplyResources(Panel2, "Panel2");
		((Control)Panel2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel2).Controls.Add((Control)(object)Text_TOTAL_NET);
		((Control)Panel2).Controls.Add((Control)(object)Label18);
		((Control)Panel2).Name = "Panel2";
		componentResourceManager.ApplyResources(Text_TOTAL_NET, "Text_TOTAL_NET");
		((TextBoxBase)Text_TOTAL_NET).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)Text_TOTAL_NET).BorderStyle = (BorderStyle)0;
		((TextBoxBase)Text_TOTAL_NET).ForeColor = Color.White;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		((TextBoxBase)Text_TOTAL_NET).ReadOnly = true;
		((Control)Label18).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).ForeColor = Color.White;
		((Control)Label18).Name = "Label18";
		componentResourceManager.ApplyResources(Button_ANNULATION_ALL, "Button_ANNULATION_ALL");
		((Control)Button_ANNULATION_ALL).Cursor = Cursors.Hand;
		((Control)Button_ANNULATION_ALL).ForeColor = Color.Red;
		((Control)Button_ANNULATION_ALL).Name = "Button_ANNULATION_ALL";
		((ButtonBase)Button_ANNULATION_ALL).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_ANNULATION, "Button_ANNULATION");
		((Control)Button_ANNULATION).Cursor = Cursors.Hand;
		((Control)Button_ANNULATION).ForeColor = Color.Red;
		((Control)Button_ANNULATION).Name = "Button_ANNULATION";
		((ButtonBase)Button_ANNULATION).UseVisualStyleBackColor = true;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		componentResourceManager.ApplyResources(DataGridView1, "DataGridView1");
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		// Keep wrapped basket headers readable when Windows font scaling or DPI changes.
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)TOTAL_NET,
			(DataGridViewColumn)REMISE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)PRINTER,
			(DataGridViewColumn)PRINTER_DUPLICATA
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(Article, "Article");
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Article).Resizable = (DataGridViewTriState)1;
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_V).DataPropertyName = "PRIX_V";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)Prix_V).DefaultCellStyle = val3;
		componentResourceManager.ApplyResources(Prix_V, "Prix_V");
		((DataGridViewColumn)Prix_V).Name = "Prix_V";
		Prix_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.NullValue = null;
		((DataGridViewColumn)Qté).DefaultCellStyle = val4;
		componentResourceManager.ApplyResources(Qté, "Qté");
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TOTAL_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NET).DataPropertyName = "TOTAL_NET";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		val5.NullValue = null;
		((DataGridViewColumn)TOTAL_NET).DefaultCellStyle = val5;
		componentResourceManager.ApplyResources(TOTAL_NET, "TOTAL_NET");
		((DataGridViewColumn)TOTAL_NET).Name = "TOTAL_NET";
		TOTAL_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)REMISE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)REMISE).DataPropertyName = "REMISE";
		val6.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)REMISE).DefaultCellStyle = val6;
		componentResourceManager.ApplyResources(REMISE, "REMISE");
		((DataGridViewColumn)REMISE).Name = "REMISE";
		REMISE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		componentResourceManager.ApplyResources(Code, "Code");
		((DataGridViewColumn)Code).Name = "Code";
		Code.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		componentResourceManager.ApplyResources(ID_ARTICLE, "ID_ARTICLE");
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)PRINTER).DataPropertyName = "PRINTER";
		componentResourceManager.ApplyResources(PRINTER, "PRINTER");
		((DataGridViewColumn)PRINTER).Name = "PRINTER";
		((DataGridViewColumn)PRINTER_DUPLICATA).DataPropertyName = "PRINTER_DUPLICATA";
		componentResourceManager.ApplyResources(PRINTER_DUPLICATA, "PRINTER_DUPLICATA");
		((DataGridViewColumn)PRINTER_DUPLICATA).Name = "PRINTER_DUPLICATA";
		componentResourceManager.ApplyResources(Button_OPERATION, "Button_OPERATION");
		((Control)Button_OPERATION).Cursor = Cursors.Hand;
		((ButtonBase)Button_OPERATION).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_OPERATION).Name = "Button_OPERATION";
		((ButtonBase)Button_OPERATION).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_FONCTIONS, "Button_FONCTIONS");
		((Control)Button_FONCTIONS).Cursor = Cursors.Hand;
		((ButtonBase)Button_FONCTIONS).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_FONCTIONS).ForeColor = SystemColors.ControlText;
		((Control)Button_FONCTIONS).Name = "Button_FONCTIONS";
		((Control)Button_FONCTIONS).Tag = "";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_SOLDER_NOT_PRINTER, "Button_SOLDER_NOT_PRINTER");
		((ButtonBase)Button_SOLDER_NOT_PRINTER).BackColor = Color.FromArgb(190, 45, 45);
		((Control)Button_SOLDER_NOT_PRINTER).Cursor = Cursors.Hand;
		((Control)Button_SOLDER_NOT_PRINTER).ForeColor = Color.White;
		((Control)Button_SOLDER_NOT_PRINTER).Name = "Button_SOLDER_NOT_PRINTER";
		((ButtonBase)Button_SOLDER_NOT_PRINTER).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_SOLDER_PRINTER, "Button_SOLDER_PRINTER");
		((ButtonBase)Button_SOLDER_PRINTER).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SOLDER_PRINTER).Cursor = Cursors.Hand;
		((Control)Button_SOLDER_PRINTER).ForeColor = Color.White;
		((Control)Button_SOLDER_PRINTER).Name = "Button_SOLDER_PRINTER";
		((ButtonBase)Button_SOLDER_PRINTER).UseVisualStyleBackColor = false;
		((Control)Panel00).Controls.Add((Control)(object)Panel9);
		((Control)Panel00).Controls.Add((Control)(object)Panel6);
		((Control)Panel00).Controls.Add((Control)(object)Panel4);
		((Control)Panel00).Controls.Add((Control)(object)Panel33);
		((Control)Panel00).Controls.Add((Control)(object)Panel5);
		componentResourceManager.ApplyResources(Panel00, "Panel00");
		((Control)Panel00).Name = "Panel00";
		componentResourceManager.ApplyResources(Panel9, "Panel9");
		((Control)Panel9).BackColor = Color.White;
		Panel9.BorderStyle = (BorderStyle)1;
		((Control)Panel9).Controls.Add((Control)(object)Label6);
		((Control)Panel9).Controls.Add((Control)(object)Label27);
		((Control)Panel9).Controls.Add((Control)(object)Label28);
		((Control)Panel9).Controls.Add((Control)(object)Label29);
		((Control)Panel9).Controls.Add((Control)(object)TabControl2);
		((Control)Panel9).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel9).Controls.Add((Control)(object)Panel_CLAVIER_AR);
		((Control)Panel9).Name = "Panel9";
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label6).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
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
		componentResourceManager.ApplyResources(TabControl2, "TabControl2");
		((Control)TabControl2).Controls.Add((Control)(object)TabPage3);
		((Control)TabControl2).Controls.Add((Control)(object)TabPage4);
		((Control)TabControl2).Name = "TabControl2";
		TabControl2.SelectedIndex = 0;
		TabPage3.BackColor = Color.White;
		((Control)TabPage3).Controls.Add((Control)(object)DataGridView100);
		((Control)TabPage3).Controls.Add((Control)(object)FlowLayoutPanel1);
		componentResourceManager.ApplyResources(TabPage3, "TabPage3");
		((Control)TabPage3).Name = "TabPage3";
		DataGridView100.AllowUserToAddRows = false;
		DataGridView100.AllowUserToResizeRows = false;
		// Size only visible product rows so long article names stay readable without scanning the entire catalogue.
		DataGridView100.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
		DataGridView100.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView100.BackgroundColor = Color.White;
		DataGridView100.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView100.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		// Product-list captions must remain legible after Windows font/DPI changes.
		DataGridView100.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
		DataGridView100.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DataGridView100.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Codeee,
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)Prix_VV,
			(DataGridViewColumn)Stock
		});
		componentResourceManager.ApplyResources(DataGridView100, "DataGridView100");
		DataGridView100.EditMode = (DataGridViewEditMode)4;
		DataGridView100.EnableHeadersVisualStyles = false;
		((Control)DataGridView100).Name = "DataGridView100";
		DataGridView100.RowHeadersVisible = false;
		((DataGridViewColumn)Codeee).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Codeee).DataPropertyName = "Code";
		((DataGridViewColumn)Codeee).FillWeight = 189.6907f;
		componentResourceManager.ApplyResources(Codeee, "Codeee");
		((DataGridViewColumn)Codeee).Name = "Codeee";
		Codeee.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "Article";
		// Wrap long product names; barcode, price and stock columns keep their original display formats.
		DataGridViewTextBoxColumn1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).FillWeight = 10.30928f;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1");
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Resizable = (DataGridViewTriState)1;
		DataGridViewTextBoxColumn1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_VV).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_VV).DataPropertyName = "PRIX_V_1";
		val7.Format = "N2";
		val7.NullValue = null;
		((DataGridViewColumn)Prix_VV).DefaultCellStyle = val7;
		componentResourceManager.ApplyResources(Prix_VV, "Prix_VV");
		((DataGridViewColumn)Prix_VV).Name = "Prix_VV";
		Prix_VV.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Stock).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Stock).DataPropertyName = "Stock";
		componentResourceManager.ApplyResources(Stock, "Stock");
		((DataGridViewColumn)Stock).Name = "Stock";
		Stock.SortMode = (DataGridViewColumnSortMode)0;
		componentResourceManager.ApplyResources(FlowLayoutPanel1, "FlowLayoutPanel1");
		((Panel)FlowLayoutPanel1).BorderStyle = (BorderStyle)1;
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)Button1);
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		((ButtonBase)Button1).BackColor = Color.FromArgb(52, 152, 219);
		componentResourceManager.ApplyResources(Button1, "Button1");
		((Control)Button1).ForeColor = Color.White;
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseCompatibleTextRendering = true;
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		TabPage4.BackColor = Color.White;
		((Control)TabPage4).Controls.Add((Control)(object)FlowLayout_ARTICLES);
		((Control)TabPage4).Controls.Add((Control)(object)vScrollBar1);
		((Control)TabPage4).Controls.Add((Control)(object)FlowLayoutPanel2);
		componentResourceManager.ApplyResources(TabPage4, "TabPage4");
		((Control)TabPage4).Name = "TabPage4";
		componentResourceManager.ApplyResources(FlowLayout_ARTICLES, "FlowLayout_ARTICLES");
		((Panel)FlowLayout_ARTICLES).BorderStyle = (BorderStyle)1;
		((Control)FlowLayout_ARTICLES).Name = "FlowLayout_ARTICLES";
		componentResourceManager.ApplyResources(vScrollBar1, "vScrollBar1");
		((ScrollBar)vScrollBar1).LargeChange = 15;
		((ScrollBar)vScrollBar1).Maximum = 250;
		((Control)vScrollBar1).Name = "vScrollBar1";
		componentResourceManager.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1");
		TableLayoutPanel1.Controls.Add((Control)(object)Button4, 0, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Button2, 0, 0);
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(Button4, "Button4");
		((Control)Button4).Name = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(FlowLayoutPanel2, "FlowLayoutPanel2");
		((Panel)FlowLayoutPanel2).BorderStyle = (BorderStyle)1;
		((Control)FlowLayoutPanel2).Controls.Add((Control)(object)Button5);
		((Control)FlowLayoutPanel2).Name = "FlowLayoutPanel2";
		((ButtonBase)Button5).BackColor = Color.FromArgb(52, 152, 219);
		componentResourceManager.ApplyResources(Button5, "Button5");
		((Control)Button5).ForeColor = Color.White;
		((Control)Button5).Name = "Button5";
		((ButtonBase)Button5).UseCompatibleTextRendering = true;
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel_CLAVIER, "Panel_CLAVIER");
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel3);
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		((Control)TableLayoutPanel2).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel2, "TableLayoutPanel2");
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT2, 0, 3);
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
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1, 0, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT3, 9, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT4, 10, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT5, 11, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT6, 11, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT7, 10, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT8, 10, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT9, 1, 3);
		((Control)TableLayoutPanel2).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		((ButtonBase)Button_CLAVIER_NOSELECT2).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT2, "Button_CLAVIER_NOSELECT2");
		((Control)Button_CLAVIER_NOSELECT2).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT2).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT2).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT2).Name = "Button_CLAVIER_NOSELECT2";
		((ButtonBase)Button_CLAVIER_NOSELECT2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_DOT, "Butt_DOT");
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_DOT).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_DOT).Name = "Butt_DOT";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_1, "Butt_1");
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_1).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_1).Name = "Butt_1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_2, "Butt_2");
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_2).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_2).Name = "Butt_2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_N).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_N, "Butt_N");
		((Control)Butt_N).Cursor = Cursors.Hand;
		((ButtonBase)Butt_N).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_N).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_N).Name = "Butt_N";
		((ButtonBase)Butt_N).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_3, "Butt_3");
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_3).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_3).Name = "Butt_3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_B).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_B, "Butt_B");
		((Control)Butt_B).Cursor = Cursors.Hand;
		((ButtonBase)Butt_B).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_B).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_B).Name = "Butt_B";
		((ButtonBase)Butt_B).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_4, "Butt_4");
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_4).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_4).Name = "Butt_4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_V).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_V, "Butt_V");
		((Control)Butt_V).Cursor = Cursors.Hand;
		((ButtonBase)Butt_V).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_V).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_V).Name = "Butt_V";
		((ButtonBase)Butt_V).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_5, "Butt_5");
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_5).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_5).Name = "Butt_5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_C).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_C, "Butt_C");
		((Control)Butt_C).Cursor = Cursors.Hand;
		((ButtonBase)Butt_C).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_C).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_C).Name = "Butt_C";
		((ButtonBase)Butt_C).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_6, "Butt_6");
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_6).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_6).Name = "Butt_6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_X).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_X, "Butt_X");
		((Control)Butt_X).Cursor = Cursors.Hand;
		((ButtonBase)Butt_X).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_X).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_X).Name = "Butt_X";
		((ButtonBase)Butt_X).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_7, "Butt_7");
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_7).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_7).Name = "Butt_7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_W).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_W, "Butt_W");
		((Control)Butt_W).Cursor = Cursors.Hand;
		((ButtonBase)Butt_W).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_W).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_W).Name = "Butt_W";
		((ButtonBase)Butt_W).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_8, "Butt_8");
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_8).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_8).Name = "Butt_8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_9, "Butt_9");
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_9).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_9).Name = "Butt_9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_0, "Butt_0");
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_0).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_0).Name = "Butt_0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_M).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_M, "Butt_M");
		((Control)Butt_M).Cursor = Cursors.Hand;
		((ButtonBase)Butt_M).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_M).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_M).Name = "Butt_M";
		((ButtonBase)Butt_M).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_A).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_A, "Butt_A");
		((Control)Butt_A).CausesValidation = false;
		((Control)Butt_A).Cursor = Cursors.Hand;
		((ButtonBase)Butt_A).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_A).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_A).Name = "Butt_A";
		((ButtonBase)Butt_A).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_L).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_L, "Butt_L");
		((Control)Butt_L).Cursor = Cursors.Hand;
		((ButtonBase)Butt_L).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_L).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_L).Name = "Butt_L";
		((ButtonBase)Butt_L).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Z).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_Z, "Butt_Z");
		((Control)Butt_Z).Cursor = Cursors.Hand;
		((ButtonBase)Butt_Z).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_Z).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_Z).Name = "Butt_Z";
		((ButtonBase)Butt_Z).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_K).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_K, "Butt_K");
		((Control)Butt_K).Cursor = Cursors.Hand;
		((ButtonBase)Butt_K).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_K).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_K).Name = "Butt_K";
		((ButtonBase)Butt_K).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_E).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_E, "Butt_E");
		((Control)Butt_E).Cursor = Cursors.Hand;
		((ButtonBase)Butt_E).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_E).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_E).Name = "Butt_E";
		((ButtonBase)Butt_E).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_J).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_J, "Butt_J");
		((Control)Butt_J).Cursor = Cursors.Hand;
		((ButtonBase)Butt_J).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_J).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_J).Name = "Butt_J";
		((ButtonBase)Butt_J).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_R).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_R, "Butt_R");
		((Control)Butt_R).Cursor = Cursors.Hand;
		((ButtonBase)Butt_R).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_R).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_R).Name = "Butt_R";
		((ButtonBase)Butt_R).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_H).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_H, "Butt_H");
		((Control)Butt_H).Cursor = Cursors.Hand;
		((ButtonBase)Butt_H).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_H).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_H).Name = "Butt_H";
		((ButtonBase)Butt_H).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_T).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_T, "Butt_T");
		((Control)Butt_T).Cursor = Cursors.Hand;
		((ButtonBase)Butt_T).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_T).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_T).Name = "Butt_T";
		((ButtonBase)Butt_T).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_G).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_G, "Butt_G");
		((Control)Butt_G).Cursor = Cursors.Hand;
		((ButtonBase)Butt_G).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_G).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_G).Name = "Butt_G";
		((ButtonBase)Butt_G).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Y).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_Y, "Butt_Y");
		((Control)Butt_Y).Cursor = Cursors.Hand;
		((ButtonBase)Butt_Y).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_Y).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_Y).Name = "Butt_Y";
		((ButtonBase)Butt_Y).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_F).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_F, "Butt_F");
		((Control)Butt_F).Cursor = Cursors.Hand;
		((ButtonBase)Butt_F).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_F).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_F).Name = "Butt_F";
		((ButtonBase)Butt_F).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_U).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_U, "Butt_U");
		((Control)Butt_U).Cursor = Cursors.Hand;
		((ButtonBase)Butt_U).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_U).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_U).Name = "Butt_U";
		((ButtonBase)Butt_U).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_D).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_D, "Butt_D");
		((Control)Butt_D).Cursor = Cursors.Hand;
		((ButtonBase)Butt_D).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_D).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_D).Name = "Butt_D";
		((ButtonBase)Butt_D).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_I).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_I, "Butt_I");
		((Control)Butt_I).Cursor = Cursors.Hand;
		((ButtonBase)Butt_I).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_I).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_I).Name = "Butt_I";
		((ButtonBase)Butt_I).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_S).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_S, "Butt_S");
		((Control)Butt_S).Cursor = Cursors.Hand;
		((ButtonBase)Butt_S).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_S).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_S).Name = "Butt_S";
		((ButtonBase)Butt_S).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_O).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_O, "Butt_O");
		((Control)Butt_O).Cursor = Cursors.Hand;
		((ButtonBase)Butt_O).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_O).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_O).Name = "Butt_O";
		((ButtonBase)Butt_O).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Q).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_Q, "Butt_Q");
		((Control)Butt_Q).Cursor = Cursors.Hand;
		((ButtonBase)Butt_Q).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_Q).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_Q).Name = "Butt_Q";
		((ButtonBase)Butt_Q).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_P).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_P, "Butt_P");
		((Control)Butt_P).Cursor = Cursors.Hand;
		((ButtonBase)Butt_P).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_P).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_P).Name = "Butt_P";
		((ButtonBase)Butt_P).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.FromArgb(255, 192, 192);
		componentResourceManager.ApplyResources(Butt_BACK, "Butt_BACK");
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_BACK).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_BACK).Name = "Butt_BACK";
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DRAFT).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_DRAFT, "Butt_DRAFT");
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_DRAFT).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT1, "Button_CLAVIER_NOSELECT1");
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT3).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT3, "Button_CLAVIER_NOSELECT3");
		((Control)Button_CLAVIER_NOSELECT3).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT3).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT3).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT3).Name = "Button_CLAVIER_NOSELECT3";
		((ButtonBase)Button_CLAVIER_NOSELECT3).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT4).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT4, "Button_CLAVIER_NOSELECT4");
		((Control)Button_CLAVIER_NOSELECT4).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT4).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT4).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT4).Name = "Button_CLAVIER_NOSELECT4";
		((ButtonBase)Button_CLAVIER_NOSELECT4).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT5).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT5, "Button_CLAVIER_NOSELECT5");
		((Control)Button_CLAVIER_NOSELECT5).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT5).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT5).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT5).Name = "Button_CLAVIER_NOSELECT5";
		((ButtonBase)Button_CLAVIER_NOSELECT5).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT6).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT6, "Button_CLAVIER_NOSELECT6");
		((Control)Button_CLAVIER_NOSELECT6).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT6).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT6).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT6).Name = "Button_CLAVIER_NOSELECT6";
		((ButtonBase)Button_CLAVIER_NOSELECT6).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT7).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT7, "Button_CLAVIER_NOSELECT7");
		((Control)Button_CLAVIER_NOSELECT7).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT7).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT7).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT7).Name = "Button_CLAVIER_NOSELECT7";
		((ButtonBase)Button_CLAVIER_NOSELECT7).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT8).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT8, "Button_CLAVIER_NOSELECT8");
		((Control)Button_CLAVIER_NOSELECT8).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT8).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT8).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT8).Name = "Button_CLAVIER_NOSELECT8";
		((ButtonBase)Button_CLAVIER_NOSELECT8).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT9).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT9, "Button_CLAVIER_NOSELECT9");
		((Control)Button_CLAVIER_NOSELECT9).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT9).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT9).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT9).Name = "Button_CLAVIER_NOSELECT9";
		((ButtonBase)Button_CLAVIER_NOSELECT9).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel3).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel3, "TableLayoutPanel3");
		TableLayoutPanel3.Controls.Add((Control)(object)Butt_AR, 0, 0);
		TableLayoutPanel3.Controls.Add((Control)(object)Butt_SPACE, 1, 0);
		TableLayoutPanel3.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT10, 2, 0);
		((Control)TableLayoutPanel3).Name = "TableLayoutPanel3";
		((ButtonBase)Butt_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_AR, "Butt_AR");
		((Control)Butt_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_AR).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Butt_AR).Name = "Butt_AR";
		((ButtonBase)Butt_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_SPACE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_SPACE, "Butt_SPACE");
		((Control)Butt_SPACE).Cursor = Cursors.Hand;
		((ButtonBase)Butt_SPACE).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_SPACE).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_SPACE).Name = "Butt_SPACE";
		((ButtonBase)Butt_SPACE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT10).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT10, "Button_CLAVIER_NOSELECT10");
		((Control)Button_CLAVIER_NOSELECT10).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT10).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT10).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT10).Name = "Button_CLAVIER_NOSELECT10";
		((ButtonBase)Button_CLAVIER_NOSELECT10).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel_CLAVIER_AR, "Panel_CLAVIER_AR");
		((Control)Panel_CLAVIER_AR).Controls.Add((Control)(object)TableLayoutPanel4);
		((Control)Panel_CLAVIER_AR).Controls.Add((Control)(object)TableLayoutPanel5);
		((Control)Panel_CLAVIER_AR).Name = "Panel_CLAVIER_AR";
		((Control)TableLayoutPanel4).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel4, "TableLayoutPanel4");
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT19, 13, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT11, 0, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_1_AR, 0, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_2_AR, 1, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_3_AR, 2, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_4_AR, 3, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_5_AR, 4, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_6_AR, 5, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_7_AR, 6, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_8_AR, 7, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_9_AR, 8, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_0_AR, 9, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ك, 10, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ض, 0, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_م, 9, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ص, 1, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT14, 12, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ن, 8, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ث, 2, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ت, 7, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ق, 3, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ا, 6, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ف, 4, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ل, 5, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_غ, 5, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ب, 4, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ع, 6, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ي, 3, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ه, 7, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_س, 2, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_خ, 8, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ش, 1, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ح, 9, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ج, 10, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_DRAFT_AR, 13, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_BACK_AR, 13, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_د, 11, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ط, 11, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ظ, 10, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ز, 9, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_و, 8, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ة, 7, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ى, 6, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_لا, 5, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ر, 4, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ؤ, 3, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ء, 2, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ئ, 1, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT12, 0, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_DOT_AR, 0, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT13, 12, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT15, 13, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT16, 11, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT17, 12, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Button_CLAVIER_NOSELECT18, 10, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ذ, 12, 2);
		((Control)TableLayoutPanel4).Name = "TableLayoutPanel4";
		((ButtonBase)Button_CLAVIER_NOSELECT19).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT19, "Button_CLAVIER_NOSELECT19");
		((Control)Button_CLAVIER_NOSELECT19).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT19).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT19).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT19).Name = "Button_CLAVIER_NOSELECT19";
		((ButtonBase)Button_CLAVIER_NOSELECT19).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT11).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT11, "Button_CLAVIER_NOSELECT11");
		((Control)Button_CLAVIER_NOSELECT11).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT11).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT11).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT11).Name = "Button_CLAVIER_NOSELECT11";
		((ButtonBase)Button_CLAVIER_NOSELECT11).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_1_AR, "Butt_1_AR");
		((Control)Butt_1_AR).CausesValidation = false;
		((Control)Butt_1_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_1_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_1_AR).Name = "Butt_1_AR";
		((ButtonBase)Butt_1_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_2_AR, "Butt_2_AR");
		((Control)Butt_2_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_2_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_2_AR).Name = "Butt_2_AR";
		((ButtonBase)Butt_2_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_3_AR, "Butt_3_AR");
		((Control)Butt_3_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_3_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_3_AR).Name = "Butt_3_AR";
		((ButtonBase)Butt_3_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_4_AR, "Butt_4_AR");
		((Control)Butt_4_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_4_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_4_AR).Name = "Butt_4_AR";
		((ButtonBase)Butt_4_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_5_AR, "Butt_5_AR");
		((Control)Butt_5_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_5_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_5_AR).Name = "Butt_5_AR";
		((ButtonBase)Butt_5_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_6_AR, "Butt_6_AR");
		((Control)Butt_6_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_6_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_6_AR).Name = "Butt_6_AR";
		((ButtonBase)Butt_6_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_7_AR, "Butt_7_AR");
		((Control)Butt_7_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_7_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_7_AR).Name = "Butt_7_AR";
		((ButtonBase)Butt_7_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_8_AR, "Butt_8_AR");
		((Control)Butt_8_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_8_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_8_AR).Name = "Butt_8_AR";
		((ButtonBase)Butt_8_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_9_AR, "Butt_9_AR");
		((Control)Butt_9_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_9_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_9_AR).Name = "Butt_9_AR";
		((ButtonBase)Butt_9_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_0_AR, "Butt_0_AR");
		((Control)Butt_0_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_0_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_0_AR).Name = "Butt_0_AR";
		((ButtonBase)Butt_0_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ك).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ك, "Butt_ك");
		((Control)Butt_ك).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ك).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ك).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ك).Name = "Butt_ك";
		((ButtonBase)Butt_ك).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ض).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ض, "Butt_ض");
		((Control)Butt_ض).CausesValidation = false;
		((Control)Butt_ض).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ض).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ض).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ض).Name = "Butt_ض";
		((ButtonBase)Butt_ض).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_م).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_م, "Butt_م");
		((Control)Butt_م).Cursor = Cursors.Hand;
		((ButtonBase)Butt_م).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_م).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_م).Name = "Butt_م";
		((ButtonBase)Butt_م).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ص).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ص, "Butt_ص");
		((Control)Butt_ص).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ص).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ص).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ص).Name = "Butt_ص";
		((ButtonBase)Butt_ص).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT14).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT14, "Button_CLAVIER_NOSELECT14");
		((Control)Button_CLAVIER_NOSELECT14).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT14).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT14).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT14).Name = "Button_CLAVIER_NOSELECT14";
		((ButtonBase)Button_CLAVIER_NOSELECT14).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ن).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ن, "Butt_ن");
		((Control)Butt_ن).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ن).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ن).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ن).Name = "Butt_ن";
		((ButtonBase)Butt_ن).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ث).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ث, "Butt_ث");
		((Control)Butt_ث).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ث).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ث).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ث).Name = "Butt_ث";
		((ButtonBase)Butt_ث).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ت).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ت, "Butt_ت");
		((Control)Butt_ت).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ت).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ت).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ت).Name = "Butt_ت";
		((ButtonBase)Butt_ت).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ق).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ق, "Butt_ق");
		((Control)Butt_ق).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ق).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ق).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ق).Name = "Butt_ق";
		((ButtonBase)Butt_ق).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ا).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ا, "Butt_ا");
		((Control)Butt_ا).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ا).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ا).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ا).Name = "Butt_ا";
		((ButtonBase)Butt_ا).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ف).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ف, "Butt_ف");
		((Control)Butt_ف).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ف).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ف).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ف).Name = "Butt_ف";
		((ButtonBase)Butt_ف).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ل).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ل, "Butt_ل");
		((Control)Butt_ل).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ل).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ل).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ل).Name = "Butt_ل";
		((ButtonBase)Butt_ل).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_غ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_غ, "Butt_غ");
		((Control)Butt_غ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_غ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_غ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_غ).Name = "Butt_غ";
		((ButtonBase)Butt_غ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ب).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ب, "Butt_ب");
		((Control)Butt_ب).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ب).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ب).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ب).Name = "Butt_ب";
		((ButtonBase)Butt_ب).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ع).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ع, "Butt_ع");
		((Control)Butt_ع).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ع).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ع).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ع).Name = "Butt_ع";
		((ButtonBase)Butt_ع).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ي).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ي, "Butt_ي");
		((Control)Butt_ي).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ي).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ي).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ي).Name = "Butt_ي";
		((ButtonBase)Butt_ي).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ه).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ه, "Butt_ه");
		((Control)Butt_ه).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ه).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ه).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ه).Name = "Butt_ه";
		((ButtonBase)Butt_ه).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_س).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_س, "Butt_س");
		((Control)Butt_س).Cursor = Cursors.Hand;
		((ButtonBase)Butt_س).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_س).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_س).Name = "Butt_س";
		((ButtonBase)Butt_س).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_خ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_خ, "Butt_خ");
		((Control)Butt_خ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_خ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_خ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_خ).Name = "Butt_خ";
		((ButtonBase)Butt_خ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ش).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ش, "Butt_ش");
		((Control)Butt_ش).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ش).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ش).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ش).Name = "Butt_ش";
		((ButtonBase)Butt_ش).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ح).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ح, "Butt_ح");
		((Control)Butt_ح).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ح).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ح).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ح).Name = "Butt_ح";
		((ButtonBase)Butt_ح).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ج).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ج, "Butt_ج");
		((Control)Butt_ج).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ج).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ج).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ج).Name = "Butt_ج";
		((ButtonBase)Butt_ج).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DRAFT_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_DRAFT_AR, "Butt_DRAFT_AR");
		((Control)Butt_DRAFT_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DRAFT_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_DRAFT_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_DRAFT_AR).Name = "Butt_DRAFT_AR";
		((ButtonBase)Butt_DRAFT_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK_AR).BackColor = Color.FromArgb(255, 192, 192);
		componentResourceManager.ApplyResources(Butt_BACK_AR, "Butt_BACK_AR");
		((Control)Butt_BACK_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_BACK_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_BACK_AR).Name = "Butt_BACK_AR";
		((ButtonBase)Butt_BACK_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_د).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_د, "Butt_د");
		((Control)Butt_د).Cursor = Cursors.Hand;
		((ButtonBase)Butt_د).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_د).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_د).Name = "Butt_د";
		((ButtonBase)Butt_د).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ط).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ط, "Butt_ط");
		((Control)Butt_ط).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ط).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ط).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ط).Name = "Butt_ط";
		((ButtonBase)Butt_ط).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ظ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ظ, "Butt_ظ");
		((Control)Butt_ظ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ظ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ظ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ظ).Name = "Butt_ظ";
		((ButtonBase)Butt_ظ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ز).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ز, "Butt_ز");
		((Control)Butt_ز).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ز).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ز).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ز).Name = "Butt_ز";
		((ButtonBase)Butt_ز).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_و).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_و, "Butt_و");
		((Control)Butt_و).Cursor = Cursors.Hand;
		((ButtonBase)Butt_و).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_و).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_و).Name = "Butt_و";
		((ButtonBase)Butt_و).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ة).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ة, "Butt_ة");
		((Control)Butt_ة).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ة).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ة).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ة).Name = "Butt_ة";
		((ButtonBase)Butt_ة).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ى).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ى, "Butt_ى");
		((Control)Butt_ى).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ى).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ى).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ى).Name = "Butt_ى";
		((ButtonBase)Butt_ى).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_لا).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_لا, "Butt_لا");
		((Control)Butt_لا).Cursor = Cursors.Hand;
		((ButtonBase)Butt_لا).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_لا).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_لا).Name = "Butt_لا";
		((ButtonBase)Butt_لا).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ر).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ر, "Butt_ر");
		((Control)Butt_ر).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ر).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ر).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ر).Name = "Butt_ر";
		((ButtonBase)Butt_ر).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ؤ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ؤ, "Butt_ؤ");
		((Control)Butt_ؤ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ؤ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ؤ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ؤ).Name = "Butt_ؤ";
		((ButtonBase)Butt_ؤ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ء).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ء, "Butt_ء");
		((Control)Butt_ء).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ء).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ء).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ء).Name = "Butt_ء";
		((ButtonBase)Butt_ء).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ئ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ئ, "Butt_ئ");
		((Control)Butt_ئ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ئ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ئ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ئ).Name = "Butt_ئ";
		((ButtonBase)Butt_ئ).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT12).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT12, "Button_CLAVIER_NOSELECT12");
		((Control)Button_CLAVIER_NOSELECT12).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT12).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT12).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT12).Name = "Button_CLAVIER_NOSELECT12";
		((ButtonBase)Button_CLAVIER_NOSELECT12).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT_AR).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_DOT_AR, "Butt_DOT_AR");
		((Control)Butt_DOT_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_DOT_AR).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Butt_DOT_AR).Name = "Butt_DOT_AR";
		((ButtonBase)Butt_DOT_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT13).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT13, "Button_CLAVIER_NOSELECT13");
		((Control)Button_CLAVIER_NOSELECT13).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT13).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT13).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT13).Name = "Button_CLAVIER_NOSELECT13";
		((ButtonBase)Button_CLAVIER_NOSELECT13).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT15).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT15, "Button_CLAVIER_NOSELECT15");
		((Control)Button_CLAVIER_NOSELECT15).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT15).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT15).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT15).Name = "Button_CLAVIER_NOSELECT15";
		((ButtonBase)Button_CLAVIER_NOSELECT15).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT16).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT16, "Button_CLAVIER_NOSELECT16");
		((Control)Button_CLAVIER_NOSELECT16).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT16).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT16).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT16).Name = "Button_CLAVIER_NOSELECT16";
		((ButtonBase)Button_CLAVIER_NOSELECT16).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT17).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT17, "Button_CLAVIER_NOSELECT17");
		((Control)Button_CLAVIER_NOSELECT17).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT17).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT17).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT17).Name = "Button_CLAVIER_NOSELECT17";
		((ButtonBase)Button_CLAVIER_NOSELECT17).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT18).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT18, "Button_CLAVIER_NOSELECT18");
		((Control)Button_CLAVIER_NOSELECT18).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT18).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_CLAVIER_NOSELECT18).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Button_CLAVIER_NOSELECT18).Name = "Button_CLAVIER_NOSELECT18";
		((ButtonBase)Button_CLAVIER_NOSELECT18).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ذ).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Butt_ذ, "Butt_ذ");
		((Control)Butt_ذ).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ذ).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_ذ).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_ذ).Name = "Butt_ذ";
		((ButtonBase)Butt_ذ).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel5).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel5, "TableLayoutPanel5");
		TableLayoutPanel5.Controls.Add((Control)(object)Butt_FR, 0, 0);
		TableLayoutPanel5.Controls.Add((Control)(object)Butt_SPACE_AR, 1, 0);
		((Control)TableLayoutPanel5).Name = "TableLayoutPanel5";
		((ButtonBase)Butt_FR).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_FR, "Butt_FR");
		((Control)Butt_FR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_FR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_FR).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Butt_FR).Name = "Butt_FR";
		((ButtonBase)Butt_FR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_SPACE_AR).BackColor = Color.White;
		componentResourceManager.ApplyResources(Butt_SPACE_AR, "Butt_SPACE_AR");
		((Control)Butt_SPACE_AR).Cursor = Cursors.Hand;
		((ButtonBase)Butt_SPACE_AR).FlatAppearance.BorderColor = Color.Silver;
		((Control)Butt_SPACE_AR).ForeColor = Color.FromArgb(51, 51, 51);
		((Control)Butt_SPACE_AR).Name = "Butt_SPACE_AR";
		((ButtonBase)Butt_SPACE_AR).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel6, "Panel6");
		((Control)Panel6).BackColor = Color.White;
		Panel6.BorderStyle = (BorderStyle)1;
		((Control)Panel6).Controls.Add((Control)(object)Label_QTE);
		((Control)Panel6).Controls.Add((Control)(object)Label16);
		((Control)Panel6).Controls.Add((Control)(object)Label17);
		((Control)Panel6).Controls.Add((Control)(object)Label19);
		((Control)Panel6).Controls.Add((Control)(object)Label20);
		((Control)Panel6).Controls.Add((Control)(object)Button_qteBACK);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte7);
		((Control)Panel6).Controls.Add((Control)(object)Button_qteDOT);
		((Control)Panel6).Controls.Add((Control)(object)Button_qtewhite);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte0);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte3);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte6);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte2);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte9);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte1);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte5);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte4);
		((Control)Panel6).Controls.Add((Control)(object)Button_qte8);
		((Control)Panel6).Controls.Add((Control)(object)Button_qteDRAFT);
		((Control)Panel6).Name = "Panel6";
		Label_QTE.BorderStyle = (BorderStyle)1;
		((Control)Label_QTE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_QTE, "Label_QTE");
		((Control)Label_QTE).Name = "Label_QTE";
		Label_QTE.UseCompatibleTextRendering = true;
		((Control)Label16).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label16).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label16, "Label16");
		((Control)Label16).ForeColor = Color.White;
		((Control)Label16).Name = "Label16";
		((Control)Label17).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label17).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label17, "Label17");
		((Control)Label17).ForeColor = Color.White;
		((Control)Label17).Name = "Label17";
		((Control)Label19).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label19).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label19, "Label19");
		((Control)Label19).ForeColor = Color.White;
		((Control)Label19).Name = "Label19";
		((Control)Label20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label20).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label20, "Label20");
		((Control)Label20).ForeColor = Color.White;
		((Control)Label20).Name = "Label20";
		((ButtonBase)Button_qteBACK).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qteBACK, "Button_qteBACK");
		((Control)Button_qteBACK).Cursor = Cursors.Hand;
		((ButtonBase)Button_qteBACK).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qteBACK).ForeColor = Color.Black;
		((Control)Button_qteBACK).Name = "Button_qteBACK";
		((ButtonBase)Button_qteBACK).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte7).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte7, "Button_qte7");
		((Control)Button_qte7).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte7).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte7).ForeColor = Color.Black;
		((Control)Button_qte7).Name = "Button_qte7";
		((ButtonBase)Button_qte7).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qteDOT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qteDOT, "Button_qteDOT");
		((Control)Button_qteDOT).Cursor = Cursors.Hand;
		((ButtonBase)Button_qteDOT).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qteDOT).ForeColor = Color.Black;
		((Control)Button_qteDOT).Name = "Button_qteDOT";
		((ButtonBase)Button_qteDOT).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qtewhite).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qtewhite, "Button_qtewhite");
		((Control)Button_qtewhite).Cursor = Cursors.Hand;
		((ButtonBase)Button_qtewhite).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qtewhite).ForeColor = Color.Black;
		((Control)Button_qtewhite).Name = "Button_qtewhite";
		((ButtonBase)Button_qtewhite).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte0).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte0, "Button_qte0");
		((Control)Button_qte0).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte0).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte0).ForeColor = Color.Black;
		((Control)Button_qte0).Name = "Button_qte0";
		((ButtonBase)Button_qte0).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte3).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte3, "Button_qte3");
		((Control)Button_qte3).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte3).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte3).ForeColor = Color.Black;
		((Control)Button_qte3).Name = "Button_qte3";
		((ButtonBase)Button_qte3).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte6).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte6, "Button_qte6");
		((Control)Button_qte6).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte6).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte6).ForeColor = Color.Black;
		((Control)Button_qte6).Name = "Button_qte6";
		((ButtonBase)Button_qte6).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte2).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte2, "Button_qte2");
		((Control)Button_qte2).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte2).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte2).ForeColor = Color.Black;
		((Control)Button_qte2).Name = "Button_qte2";
		((ButtonBase)Button_qte2).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte9).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte9, "Button_qte9");
		((Control)Button_qte9).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte9).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte9).ForeColor = Color.Black;
		((Control)Button_qte9).Name = "Button_qte9";
		((ButtonBase)Button_qte9).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte1).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte1, "Button_qte1");
		((Control)Button_qte1).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte1).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte1).ForeColor = Color.Black;
		((Control)Button_qte1).Name = "Button_qte1";
		((ButtonBase)Button_qte1).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte5).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte5, "Button_qte5");
		((Control)Button_qte5).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte5).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte5).ForeColor = Color.Black;
		((Control)Button_qte5).Name = "Button_qte5";
		((ButtonBase)Button_qte5).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte4).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte4, "Button_qte4");
		((Control)Button_qte4).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte4).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte4).ForeColor = Color.Black;
		((Control)Button_qte4).Name = "Button_qte4";
		((ButtonBase)Button_qte4).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qte8).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qte8, "Button_qte8");
		((Control)Button_qte8).Cursor = Cursors.Hand;
		((ButtonBase)Button_qte8).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qte8).ForeColor = Color.Black;
		((Control)Button_qte8).Name = "Button_qte8";
		((ButtonBase)Button_qte8).UseVisualStyleBackColor = false;
		((ButtonBase)Button_qteDRAFT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button_qteDRAFT, "Button_qteDRAFT");
		((Control)Button_qteDRAFT).Cursor = Cursors.Hand;
		((ButtonBase)Button_qteDRAFT).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button_qteDRAFT).ForeColor = Color.Black;
		((Control)Button_qteDRAFT).Name = "Button_qteDRAFT";
		((ButtonBase)Button_qteDRAFT).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel4, "Panel4");
		((Control)Panel4).BackColor = Color.White;
		Panel4.BorderStyle = (BorderStyle)1;
		((Control)Panel4).Controls.Add((Control)(object)Label2);
		((Control)Panel4).Controls.Add((Control)(object)Label9);
		((Control)Panel4).Controls.Add((Control)(object)Label11);
		((Control)Panel4).Controls.Add((Control)(object)Label12);
		((Control)Panel4).Controls.Add((Control)(object)Button_876);
		((Control)Panel4).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel4).Name = "Panel4";
		((Control)Label2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).ForeColor = Color.White;
		((Control)Label2).Name = "Label2";
		((Control)Label9).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label9).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.White;
		((Control)Label9).Name = "Label9";
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
		componentResourceManager.ApplyResources(Button_876, "Button_876");
		((ButtonBase)Button_876).BackColor = Color.White;
		((Control)Button_876).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_876).Cursor = Cursors.Hand;
		((ButtonBase)Button_876).FlatAppearance.BorderSize = 0;
		((Control)Button_876).Name = "Button_876";
		((ButtonBase)Button_876).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_FIND, "Text_FIND");
		((TextBoxBase)Text_FIND).BorderStyle = (BorderStyle)0;
		((TextBoxBase)Text_FIND).ForeColor = Color.Black;
		((Control)Text_FIND).Name = "Text_FIND";
		componentResourceManager.ApplyResources(Panel33, "Panel33");
		((Control)Panel33).BackColor = Color.FromArgb(22, 106, 238);
		Panel33.BorderStyle = (BorderStyle)1;
		((Control)Panel33).Controls.Add((Control)(object)Button2626);
		((Control)Panel33).Controls.Add((Control)(object)Button2121);
		((Control)Panel33).Controls.Add((Control)(object)Button1717);
		((Control)Panel33).Controls.Add((Control)(object)Button_CAISSIER);
		((Control)Panel33).Controls.Add((Control)(object)Button244);
		((Control)Panel33).Controls.Add((Control)(object)Button_VENDEUR);
		((Control)Panel33).Controls.Add((Control)(object)Button_CLIENT);
		((Control)Panel33).Name = "Panel33";
		((ButtonBase)Button2626).BackColor = Color.White;
		((ButtonBase)Button2626).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button2626, "Button2626");
		((Control)Button2626).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button2626).Name = "Button2626";
		((ButtonBase)Button2626).UseVisualStyleBackColor = false;
		((ButtonBase)Button2121).BackColor = Color.White;
		((ButtonBase)Button2121).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button2121, "Button2121");
		((Control)Button2121).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button2121).Name = "Button2121";
		((ButtonBase)Button2121).UseVisualStyleBackColor = false;
		((ButtonBase)Button1717).BackColor = Color.White;
		((ButtonBase)Button1717).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button1717, "Button1717");
		((Control)Button1717).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button1717).Name = "Button1717";
		((ButtonBase)Button1717).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CAISSIER).BackColor = Color.Transparent;
		((Control)Button_CAISSIER).Cursor = Cursors.Hand;
		((ButtonBase)Button_CAISSIER).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button_CAISSIER, "Button_CAISSIER");
		((Control)Button_CAISSIER).ForeColor = Color.White;
		((Control)Button_CAISSIER).Name = "Button_CAISSIER";
		((ButtonBase)Button_CAISSIER).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CAISSIER).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button244, "Button244");
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((Control)Button244).ForeColor = Color.White;
		((Control)Button244).Name = "Button244";
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		((ButtonBase)Button_VENDEUR).BackColor = Color.Transparent;
		((Control)Button_VENDEUR).Cursor = Cursors.Hand;
		((ButtonBase)Button_VENDEUR).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button_VENDEUR, "Button_VENDEUR");
		((Control)Button_VENDEUR).ForeColor = Color.White;
		((Control)Button_VENDEUR).Name = "Button_VENDEUR";
		((ButtonBase)Button_VENDEUR).UseCompatibleTextRendering = true;
		((ButtonBase)Button_VENDEUR).UseVisualStyleBackColor = false;
		Button_CLIENT._CODE_Button = null;
		Button_CLIENT._ID_Button = null;
		((ButtonBase)Button_CLIENT).BackColor = Color.Transparent;
		((Control)Button_CLIENT).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENT).FlatAppearance.BorderColor = Color.White;
		componentResourceManager.ApplyResources(Button_CLIENT, "Button_CLIENT");
		((Control)Button_CLIENT).ForeColor = Color.White;
		((Control)Button_CLIENT).Name = "Button_CLIENT";
		((ButtonBase)Button_CLIENT).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CLIENT).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel5, "Panel5");
		((Control)Panel5).BackColor = Color.White;
		Panel5.BorderStyle = (BorderStyle)1;
		((Control)Panel5).Controls.Add((Control)(object)Label4);
		((Control)Panel5).Controls.Add((Control)(object)Label5);
		((Control)Panel5).Controls.Add((Control)(object)Label7);
		((Control)Panel5).Controls.Add((Control)(object)Label8);
		((Control)Panel5).Controls.Add((Control)(object)Button_FIND);
		((Control)Panel5).Controls.Add((Control)(object)Text_CODE);
		((Control)Panel5).Controls.Add((Control)(object)Button_GO);
		((Control)Panel5).Name = "Panel5";
		((Control)Label4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label4).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.White;
		((Control)Label4).Name = "Label4";
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.White;
		((Control)Label5).Name = "Label5";
		((Control)Label7).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label7).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.White;
		((Control)Label7).Name = "Label7";
		((Control)Label8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label8).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.White;
		((Control)Label8).Name = "Label8";
		componentResourceManager.ApplyResources(Button_FIND, "Button_FIND");
		((ButtonBase)Button_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_FIND).Cursor = Cursors.Hand;
		((Control)Button_FIND).Name = "Button_FIND";
		((ButtonBase)Button_FIND).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_CODE, "Text_CODE");
		((TextBoxBase)Text_CODE).BorderStyle = (BorderStyle)0;
		((Control)Text_CODE).Name = "Text_CODE";
		componentResourceManager.ApplyResources(Button_GO, "Button_GO");
		((ButtonBase)Button_GO).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_GO).Cursor = Cursors.Hand;
		((Control)Button_GO).Name = "Button_GO";
		((ButtonBase)Button_GO).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_PRIX_QTE_MIN).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_PRIX_QTE_MIN, "Text_PRIX_QTE_MIN");
		((Control)Text_PRIX_QTE_MIN).Name = "Text_PRIX_QTE_MIN";
		((TextBoxBase)Text_PRIX_QTE).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_PRIX_QTE, "Text_PRIX_QTE");
		((Control)Text_PRIX_QTE).Name = "Text_PRIX_QTE";
		componentResourceManager.ApplyResources(Text_ID_TICKET, "Text_ID_TICKET");
		((Control)Text_ID_TICKET).Name = "Text_ID_TICKET";
		((TextBoxBase)Text_HEURE_RETARD).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_HEURE_RETARD, "Text_HEURE_RETARD");
		((Control)Text_HEURE_RETARD).Name = "Text_HEURE_RETARD";
		((ListControl)List_COLOR).FormattingEnabled = true;
		List_COLOR.Items.AddRange(new object[323]
		{
			componentResourceManager.GetString("List_COLOR.Items"),
			componentResourceManager.GetString("List_COLOR.Items1"),
			componentResourceManager.GetString("List_COLOR.Items2"),
			componentResourceManager.GetString("List_COLOR.Items3"),
			componentResourceManager.GetString("List_COLOR.Items4"),
			componentResourceManager.GetString("List_COLOR.Items5"),
			componentResourceManager.GetString("List_COLOR.Items6"),
			componentResourceManager.GetString("List_COLOR.Items7"),
			componentResourceManager.GetString("List_COLOR.Items8"),
			componentResourceManager.GetString("List_COLOR.Items9"),
			componentResourceManager.GetString("List_COLOR.Items10"),
			componentResourceManager.GetString("List_COLOR.Items11"),
			componentResourceManager.GetString("List_COLOR.Items12"),
			componentResourceManager.GetString("List_COLOR.Items13"),
			componentResourceManager.GetString("List_COLOR.Items14"),
			componentResourceManager.GetString("List_COLOR.Items15"),
			componentResourceManager.GetString("List_COLOR.Items16"),
			componentResourceManager.GetString("List_COLOR.Items17"),
			componentResourceManager.GetString("List_COLOR.Items18"),
			componentResourceManager.GetString("List_COLOR.Items19"),
			componentResourceManager.GetString("List_COLOR.Items20"),
			componentResourceManager.GetString("List_COLOR.Items21"),
			componentResourceManager.GetString("List_COLOR.Items22"),
			componentResourceManager.GetString("List_COLOR.Items23"),
			componentResourceManager.GetString("List_COLOR.Items24"),
			componentResourceManager.GetString("List_COLOR.Items25"),
			componentResourceManager.GetString("List_COLOR.Items26"),
			componentResourceManager.GetString("List_COLOR.Items27"),
			componentResourceManager.GetString("List_COLOR.Items28"),
			componentResourceManager.GetString("List_COLOR.Items29"),
			componentResourceManager.GetString("List_COLOR.Items30"),
			componentResourceManager.GetString("List_COLOR.Items31"),
			componentResourceManager.GetString("List_COLOR.Items32"),
			componentResourceManager.GetString("List_COLOR.Items33"),
			componentResourceManager.GetString("List_COLOR.Items34"),
			componentResourceManager.GetString("List_COLOR.Items35"),
			componentResourceManager.GetString("List_COLOR.Items36"),
			componentResourceManager.GetString("List_COLOR.Items37"),
			componentResourceManager.GetString("List_COLOR.Items38"),
			componentResourceManager.GetString("List_COLOR.Items39"),
			componentResourceManager.GetString("List_COLOR.Items40"),
			componentResourceManager.GetString("List_COLOR.Items41"),
			componentResourceManager.GetString("List_COLOR.Items42"),
			componentResourceManager.GetString("List_COLOR.Items43"),
			componentResourceManager.GetString("List_COLOR.Items44"),
			componentResourceManager.GetString("List_COLOR.Items45"),
			componentResourceManager.GetString("List_COLOR.Items46"),
			componentResourceManager.GetString("List_COLOR.Items47"),
			componentResourceManager.GetString("List_COLOR.Items48"),
			componentResourceManager.GetString("List_COLOR.Items49"),
			componentResourceManager.GetString("List_COLOR.Items50"),
			componentResourceManager.GetString("List_COLOR.Items51"),
			componentResourceManager.GetString("List_COLOR.Items52"),
			componentResourceManager.GetString("List_COLOR.Items53"),
			componentResourceManager.GetString("List_COLOR.Items54"),
			componentResourceManager.GetString("List_COLOR.Items55"),
			componentResourceManager.GetString("List_COLOR.Items56"),
			componentResourceManager.GetString("List_COLOR.Items57"),
			componentResourceManager.GetString("List_COLOR.Items58"),
			componentResourceManager.GetString("List_COLOR.Items59"),
			componentResourceManager.GetString("List_COLOR.Items60"),
			componentResourceManager.GetString("List_COLOR.Items61"),
			componentResourceManager.GetString("List_COLOR.Items62"),
			componentResourceManager.GetString("List_COLOR.Items63"),
			componentResourceManager.GetString("List_COLOR.Items64"),
			componentResourceManager.GetString("List_COLOR.Items65"),
			componentResourceManager.GetString("List_COLOR.Items66"),
			componentResourceManager.GetString("List_COLOR.Items67"),
			componentResourceManager.GetString("List_COLOR.Items68"),
			componentResourceManager.GetString("List_COLOR.Items69"),
			componentResourceManager.GetString("List_COLOR.Items70"),
			componentResourceManager.GetString("List_COLOR.Items71"),
			componentResourceManager.GetString("List_COLOR.Items72"),
			componentResourceManager.GetString("List_COLOR.Items73"),
			componentResourceManager.GetString("List_COLOR.Items74"),
			componentResourceManager.GetString("List_COLOR.Items75"),
			componentResourceManager.GetString("List_COLOR.Items76"),
			componentResourceManager.GetString("List_COLOR.Items77"),
			componentResourceManager.GetString("List_COLOR.Items78"),
			componentResourceManager.GetString("List_COLOR.Items79"),
			componentResourceManager.GetString("List_COLOR.Items80"),
			componentResourceManager.GetString("List_COLOR.Items81"),
			componentResourceManager.GetString("List_COLOR.Items82"),
			componentResourceManager.GetString("List_COLOR.Items83"),
			componentResourceManager.GetString("List_COLOR.Items84"),
			componentResourceManager.GetString("List_COLOR.Items85"),
			componentResourceManager.GetString("List_COLOR.Items86"),
			componentResourceManager.GetString("List_COLOR.Items87"),
			componentResourceManager.GetString("List_COLOR.Items88"),
			componentResourceManager.GetString("List_COLOR.Items89"),
			componentResourceManager.GetString("List_COLOR.Items90"),
			componentResourceManager.GetString("List_COLOR.Items91"),
			componentResourceManager.GetString("List_COLOR.Items92"),
			componentResourceManager.GetString("List_COLOR.Items93"),
			componentResourceManager.GetString("List_COLOR.Items94"),
			componentResourceManager.GetString("List_COLOR.Items95"),
			componentResourceManager.GetString("List_COLOR.Items96"),
			componentResourceManager.GetString("List_COLOR.Items97"),
			componentResourceManager.GetString("List_COLOR.Items98"),
			componentResourceManager.GetString("List_COLOR.Items99"),
			componentResourceManager.GetString("List_COLOR.Items100"),
			componentResourceManager.GetString("List_COLOR.Items101"),
			componentResourceManager.GetString("List_COLOR.Items102"),
			componentResourceManager.GetString("List_COLOR.Items103"),
			componentResourceManager.GetString("List_COLOR.Items104"),
			componentResourceManager.GetString("List_COLOR.Items105"),
			componentResourceManager.GetString("List_COLOR.Items106"),
			componentResourceManager.GetString("List_COLOR.Items107"),
			componentResourceManager.GetString("List_COLOR.Items108"),
			componentResourceManager.GetString("List_COLOR.Items109"),
			componentResourceManager.GetString("List_COLOR.Items110"),
			componentResourceManager.GetString("List_COLOR.Items111"),
			componentResourceManager.GetString("List_COLOR.Items112"),
			componentResourceManager.GetString("List_COLOR.Items113"),
			componentResourceManager.GetString("List_COLOR.Items114"),
			componentResourceManager.GetString("List_COLOR.Items115"),
			componentResourceManager.GetString("List_COLOR.Items116"),
			componentResourceManager.GetString("List_COLOR.Items117"),
			componentResourceManager.GetString("List_COLOR.Items118"),
			componentResourceManager.GetString("List_COLOR.Items119"),
			componentResourceManager.GetString("List_COLOR.Items120"),
			componentResourceManager.GetString("List_COLOR.Items121"),
			componentResourceManager.GetString("List_COLOR.Items122"),
			componentResourceManager.GetString("List_COLOR.Items123"),
			componentResourceManager.GetString("List_COLOR.Items124"),
			componentResourceManager.GetString("List_COLOR.Items125"),
			componentResourceManager.GetString("List_COLOR.Items126"),
			componentResourceManager.GetString("List_COLOR.Items127"),
			componentResourceManager.GetString("List_COLOR.Items128"),
			componentResourceManager.GetString("List_COLOR.Items129"),
			componentResourceManager.GetString("List_COLOR.Items130"),
			componentResourceManager.GetString("List_COLOR.Items131"),
			componentResourceManager.GetString("List_COLOR.Items132"),
			componentResourceManager.GetString("List_COLOR.Items133"),
			componentResourceManager.GetString("List_COLOR.Items134"),
			componentResourceManager.GetString("List_COLOR.Items135"),
			componentResourceManager.GetString("List_COLOR.Items136"),
			componentResourceManager.GetString("List_COLOR.Items137"),
			componentResourceManager.GetString("List_COLOR.Items138"),
			componentResourceManager.GetString("List_COLOR.Items139"),
			componentResourceManager.GetString("List_COLOR.Items140"),
			componentResourceManager.GetString("List_COLOR.Items141"),
			componentResourceManager.GetString("List_COLOR.Items142"),
			componentResourceManager.GetString("List_COLOR.Items143"),
			componentResourceManager.GetString("List_COLOR.Items144"),
			componentResourceManager.GetString("List_COLOR.Items145"),
			componentResourceManager.GetString("List_COLOR.Items146"),
			componentResourceManager.GetString("List_COLOR.Items147"),
			componentResourceManager.GetString("List_COLOR.Items148"),
			componentResourceManager.GetString("List_COLOR.Items149"),
			componentResourceManager.GetString("List_COLOR.Items150"),
			componentResourceManager.GetString("List_COLOR.Items151"),
			componentResourceManager.GetString("List_COLOR.Items152"),
			componentResourceManager.GetString("List_COLOR.Items153"),
			componentResourceManager.GetString("List_COLOR.Items154"),
			componentResourceManager.GetString("List_COLOR.Items155"),
			componentResourceManager.GetString("List_COLOR.Items156"),
			componentResourceManager.GetString("List_COLOR.Items157"),
			componentResourceManager.GetString("List_COLOR.Items158"),
			componentResourceManager.GetString("List_COLOR.Items159"),
			componentResourceManager.GetString("List_COLOR.Items160"),
			componentResourceManager.GetString("List_COLOR.Items161"),
			componentResourceManager.GetString("List_COLOR.Items162"),
			componentResourceManager.GetString("List_COLOR.Items163"),
			componentResourceManager.GetString("List_COLOR.Items164"),
			componentResourceManager.GetString("List_COLOR.Items165"),
			componentResourceManager.GetString("List_COLOR.Items166"),
			componentResourceManager.GetString("List_COLOR.Items167"),
			componentResourceManager.GetString("List_COLOR.Items168"),
			componentResourceManager.GetString("List_COLOR.Items169"),
			componentResourceManager.GetString("List_COLOR.Items170"),
			componentResourceManager.GetString("List_COLOR.Items171"),
			componentResourceManager.GetString("List_COLOR.Items172"),
			componentResourceManager.GetString("List_COLOR.Items173"),
			componentResourceManager.GetString("List_COLOR.Items174"),
			componentResourceManager.GetString("List_COLOR.Items175"),
			componentResourceManager.GetString("List_COLOR.Items176"),
			componentResourceManager.GetString("List_COLOR.Items177"),
			componentResourceManager.GetString("List_COLOR.Items178"),
			componentResourceManager.GetString("List_COLOR.Items179"),
			componentResourceManager.GetString("List_COLOR.Items180"),
			componentResourceManager.GetString("List_COLOR.Items181"),
			componentResourceManager.GetString("List_COLOR.Items182"),
			componentResourceManager.GetString("List_COLOR.Items183"),
			componentResourceManager.GetString("List_COLOR.Items184"),
			componentResourceManager.GetString("List_COLOR.Items185"),
			componentResourceManager.GetString("List_COLOR.Items186"),
			componentResourceManager.GetString("List_COLOR.Items187"),
			componentResourceManager.GetString("List_COLOR.Items188"),
			componentResourceManager.GetString("List_COLOR.Items189"),
			componentResourceManager.GetString("List_COLOR.Items190"),
			componentResourceManager.GetString("List_COLOR.Items191"),
			componentResourceManager.GetString("List_COLOR.Items192"),
			componentResourceManager.GetString("List_COLOR.Items193"),
			componentResourceManager.GetString("List_COLOR.Items194"),
			componentResourceManager.GetString("List_COLOR.Items195"),
			componentResourceManager.GetString("List_COLOR.Items196"),
			componentResourceManager.GetString("List_COLOR.Items197"),
			componentResourceManager.GetString("List_COLOR.Items198"),
			componentResourceManager.GetString("List_COLOR.Items199"),
			componentResourceManager.GetString("List_COLOR.Items200"),
			componentResourceManager.GetString("List_COLOR.Items201"),
			componentResourceManager.GetString("List_COLOR.Items202"),
			componentResourceManager.GetString("List_COLOR.Items203"),
			componentResourceManager.GetString("List_COLOR.Items204"),
			componentResourceManager.GetString("List_COLOR.Items205"),
			componentResourceManager.GetString("List_COLOR.Items206"),
			componentResourceManager.GetString("List_COLOR.Items207"),
			componentResourceManager.GetString("List_COLOR.Items208"),
			componentResourceManager.GetString("List_COLOR.Items209"),
			componentResourceManager.GetString("List_COLOR.Items210"),
			componentResourceManager.GetString("List_COLOR.Items211"),
			componentResourceManager.GetString("List_COLOR.Items212"),
			componentResourceManager.GetString("List_COLOR.Items213"),
			componentResourceManager.GetString("List_COLOR.Items214"),
			componentResourceManager.GetString("List_COLOR.Items215"),
			componentResourceManager.GetString("List_COLOR.Items216"),
			componentResourceManager.GetString("List_COLOR.Items217"),
			componentResourceManager.GetString("List_COLOR.Items218"),
			componentResourceManager.GetString("List_COLOR.Items219"),
			componentResourceManager.GetString("List_COLOR.Items220"),
			componentResourceManager.GetString("List_COLOR.Items221"),
			componentResourceManager.GetString("List_COLOR.Items222"),
			componentResourceManager.GetString("List_COLOR.Items223"),
			componentResourceManager.GetString("List_COLOR.Items224"),
			componentResourceManager.GetString("List_COLOR.Items225"),
			componentResourceManager.GetString("List_COLOR.Items226"),
			componentResourceManager.GetString("List_COLOR.Items227"),
			componentResourceManager.GetString("List_COLOR.Items228"),
			componentResourceManager.GetString("List_COLOR.Items229"),
			componentResourceManager.GetString("List_COLOR.Items230"),
			componentResourceManager.GetString("List_COLOR.Items231"),
			componentResourceManager.GetString("List_COLOR.Items232"),
			componentResourceManager.GetString("List_COLOR.Items233"),
			componentResourceManager.GetString("List_COLOR.Items234"),
			componentResourceManager.GetString("List_COLOR.Items235"),
			componentResourceManager.GetString("List_COLOR.Items236"),
			componentResourceManager.GetString("List_COLOR.Items237"),
			componentResourceManager.GetString("List_COLOR.Items238"),
			componentResourceManager.GetString("List_COLOR.Items239"),
			componentResourceManager.GetString("List_COLOR.Items240"),
			componentResourceManager.GetString("List_COLOR.Items241"),
			componentResourceManager.GetString("List_COLOR.Items242"),
			componentResourceManager.GetString("List_COLOR.Items243"),
			componentResourceManager.GetString("List_COLOR.Items244"),
			componentResourceManager.GetString("List_COLOR.Items245"),
			componentResourceManager.GetString("List_COLOR.Items246"),
			componentResourceManager.GetString("List_COLOR.Items247"),
			componentResourceManager.GetString("List_COLOR.Items248"),
			componentResourceManager.GetString("List_COLOR.Items249"),
			componentResourceManager.GetString("List_COLOR.Items250"),
			componentResourceManager.GetString("List_COLOR.Items251"),
			componentResourceManager.GetString("List_COLOR.Items252"),
			componentResourceManager.GetString("List_COLOR.Items253"),
			componentResourceManager.GetString("List_COLOR.Items254"),
			componentResourceManager.GetString("List_COLOR.Items255"),
			componentResourceManager.GetString("List_COLOR.Items256"),
			componentResourceManager.GetString("List_COLOR.Items257"),
			componentResourceManager.GetString("List_COLOR.Items258"),
			componentResourceManager.GetString("List_COLOR.Items259"),
			componentResourceManager.GetString("List_COLOR.Items260"),
			componentResourceManager.GetString("List_COLOR.Items261"),
			componentResourceManager.GetString("List_COLOR.Items262"),
			componentResourceManager.GetString("List_COLOR.Items263"),
			componentResourceManager.GetString("List_COLOR.Items264"),
			componentResourceManager.GetString("List_COLOR.Items265"),
			componentResourceManager.GetString("List_COLOR.Items266"),
			componentResourceManager.GetString("List_COLOR.Items267"),
			componentResourceManager.GetString("List_COLOR.Items268"),
			componentResourceManager.GetString("List_COLOR.Items269"),
			componentResourceManager.GetString("List_COLOR.Items270"),
			componentResourceManager.GetString("List_COLOR.Items271"),
			componentResourceManager.GetString("List_COLOR.Items272"),
			componentResourceManager.GetString("List_COLOR.Items273"),
			componentResourceManager.GetString("List_COLOR.Items274"),
			componentResourceManager.GetString("List_COLOR.Items275"),
			componentResourceManager.GetString("List_COLOR.Items276"),
			componentResourceManager.GetString("List_COLOR.Items277"),
			componentResourceManager.GetString("List_COLOR.Items278"),
			componentResourceManager.GetString("List_COLOR.Items279"),
			componentResourceManager.GetString("List_COLOR.Items280"),
			componentResourceManager.GetString("List_COLOR.Items281"),
			componentResourceManager.GetString("List_COLOR.Items282"),
			componentResourceManager.GetString("List_COLOR.Items283"),
			componentResourceManager.GetString("List_COLOR.Items284"),
			componentResourceManager.GetString("List_COLOR.Items285"),
			componentResourceManager.GetString("List_COLOR.Items286"),
			componentResourceManager.GetString("List_COLOR.Items287"),
			componentResourceManager.GetString("List_COLOR.Items288"),
			componentResourceManager.GetString("List_COLOR.Items289"),
			componentResourceManager.GetString("List_COLOR.Items290"),
			componentResourceManager.GetString("List_COLOR.Items291"),
			componentResourceManager.GetString("List_COLOR.Items292"),
			componentResourceManager.GetString("List_COLOR.Items293"),
			componentResourceManager.GetString("List_COLOR.Items294"),
			componentResourceManager.GetString("List_COLOR.Items295"),
			componentResourceManager.GetString("List_COLOR.Items296"),
			componentResourceManager.GetString("List_COLOR.Items297"),
			componentResourceManager.GetString("List_COLOR.Items298"),
			componentResourceManager.GetString("List_COLOR.Items299"),
			componentResourceManager.GetString("List_COLOR.Items300"),
			componentResourceManager.GetString("List_COLOR.Items301"),
			componentResourceManager.GetString("List_COLOR.Items302"),
			componentResourceManager.GetString("List_COLOR.Items303"),
			componentResourceManager.GetString("List_COLOR.Items304"),
			componentResourceManager.GetString("List_COLOR.Items305"),
			componentResourceManager.GetString("List_COLOR.Items306"),
			componentResourceManager.GetString("List_COLOR.Items307"),
			componentResourceManager.GetString("List_COLOR.Items308"),
			componentResourceManager.GetString("List_COLOR.Items309"),
			componentResourceManager.GetString("List_COLOR.Items310"),
			componentResourceManager.GetString("List_COLOR.Items311"),
			componentResourceManager.GetString("List_COLOR.Items312"),
			componentResourceManager.GetString("List_COLOR.Items313"),
			componentResourceManager.GetString("List_COLOR.Items314"),
			componentResourceManager.GetString("List_COLOR.Items315"),
			componentResourceManager.GetString("List_COLOR.Items316"),
			componentResourceManager.GetString("List_COLOR.Items317"),
			componentResourceManager.GetString("List_COLOR.Items318"),
			componentResourceManager.GetString("List_COLOR.Items319"),
			componentResourceManager.GetString("List_COLOR.Items320"),
			componentResourceManager.GetString("List_COLOR.Items321"),
			componentResourceManager.GetString("List_COLOR.Items322")
		});
		componentResourceManager.ApplyResources(List_COLOR, "List_COLOR");
		((Control)List_COLOR).Name = "List_COLOR";
		((ButtonBase)Button16).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button16, "Button16");
		((Control)Button16).CausesValidation = false;
		((Control)Button16).Cursor = Cursors.Hand;
		((ButtonBase)Button16).FlatAppearance.BorderColor = Color.Silver;
		((Control)Button16).ForeColor = Color.Black;
		((Control)Button16).Name = "Button16";
		((ButtonBase)Button16).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Check_ACCES_RFID, "Check_ACCES_RFID");
		((Control)Check_ACCES_RFID).ForeColor = Color.Black;
		((Control)Check_ACCES_RFID).Name = "Check_ACCES_RFID";
		((ButtonBase)Check_ACCES_RFID).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Check_ACCES_MODEP, "Check_ACCES_MODEP");
		((Control)Check_ACCES_MODEP).ForeColor = Color.Black;
		((Control)Check_ACCES_MODEP).Name = "Check_ACCES_MODEP";
		((ButtonBase)Check_ACCES_MODEP).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Combo_BAUDRATE, "Combo_BAUDRATE");
		((ListControl)Combo_BAUDRATE).FormattingEnabled = true;
		Combo_BAUDRATE.Items.AddRange(new object[5]
		{
			componentResourceManager.GetString("Combo_BAUDRATE.Items"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items1"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items2"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items3"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items4")
		});
		((Control)Combo_BAUDRATE).Name = "Combo_BAUDRATE";
		componentResourceManager.ApplyResources(Combo_PORT, "Combo_PORT");
		((ListControl)Combo_PORT).FormattingEnabled = true;
		Combo_PORT.Items.AddRange(new object[13]
		{
			componentResourceManager.GetString("Combo_PORT.Items"),
			componentResourceManager.GetString("Combo_PORT.Items1"),
			componentResourceManager.GetString("Combo_PORT.Items2"),
			componentResourceManager.GetString("Combo_PORT.Items3"),
			componentResourceManager.GetString("Combo_PORT.Items4"),
			componentResourceManager.GetString("Combo_PORT.Items5"),
			componentResourceManager.GetString("Combo_PORT.Items6"),
			componentResourceManager.GetString("Combo_PORT.Items7"),
			componentResourceManager.GetString("Combo_PORT.Items8"),
			componentResourceManager.GetString("Combo_PORT.Items9"),
			componentResourceManager.GetString("Combo_PORT.Items10"),
			componentResourceManager.GetString("Combo_PORT.Items11"),
			componentResourceManager.GetString("Combo_PORT.Items12")
		});
		((Control)Combo_PORT).Name = "Combo_PORT";
		componentResourceManager.ApplyResources(Check_STOCK, "Check_STOCK");
		((Control)Check_STOCK).ForeColor = Color.Black;
		((Control)Check_STOCK).Name = "Check_STOCK";
		((ButtonBase)Check_STOCK).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Panel_FONCTIONS, "Panel_FONCTIONS");
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		componentResourceManager.ApplyResources(TabControl1, "TabControl1");
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT35);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT34);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT25);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT24);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT23);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT22);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT21);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT20);
		((Control)TabPage1).Controls.Add((Control)(object)Button_RACCOURCIES);
		((Control)TabPage1).Controls.Add((Control)(object)Button_FERMER);
		((Control)TabPage1).Controls.Add((Control)(object)Button_COMPTER_CAISSE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CALCULATRICE);
		((Control)TabPage1).Controls.Add((Control)(object)Button3);
		((Control)TabPage1).Controls.Add((Control)(object)Button_LISTE_ATTENTE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_LOCK);
		((Control)TabPage1).Controls.Add((Control)(object)Button_RAPPORT);
		((Control)TabPage1).Controls.Add((Control)(object)Button_DEPENSES);
		((Control)TabPage1).Controls.Add((Control)(object)Button_THEME);
		((Control)TabPage1).Controls.Add((Control)(object)Button_ATTENTE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_PRIX);
		((Control)TabPage1).Controls.Add((Control)(object)Button_MODIF_QTE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_DIVERS);
		((Control)TabPage1).Controls.Add((Control)(object)Button_TIROIR);
		((Control)TabPage1).Controls.Add((Control)(object)Button_MODIF_PRIX);
		((Control)TabPage1).Controls.Add((Control)(object)Button_REMISE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_DUPLICATA);
		((Control)TabPage1).Controls.Add((Control)(object)Button_FLASH);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CLOTURE);
		componentResourceManager.ApplyResources(TabPage1, "TabPage1");
		((Control)TabPage1).Name = "TabPage1";
		((ButtonBase)Button_CLAVIER_NOSELECT35).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT35).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT35).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT35).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT35, "Button_CLAVIER_NOSELECT35");
		((Control)Button_CLAVIER_NOSELECT35).Name = "Button_CLAVIER_NOSELECT35";
		((ButtonBase)Button_CLAVIER_NOSELECT35).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT34).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT34).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT34).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT34).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT34, "Button_CLAVIER_NOSELECT34");
		((Control)Button_CLAVIER_NOSELECT34).Name = "Button_CLAVIER_NOSELECT34";
		((ButtonBase)Button_CLAVIER_NOSELECT34).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT25).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT25).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT25).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT25).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT25, "Button_CLAVIER_NOSELECT25");
		((Control)Button_CLAVIER_NOSELECT25).Name = "Button_CLAVIER_NOSELECT25";
		((ButtonBase)Button_CLAVIER_NOSELECT25).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT24).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT24).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT24).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT24).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT24, "Button_CLAVIER_NOSELECT24");
		((Control)Button_CLAVIER_NOSELECT24).Name = "Button_CLAVIER_NOSELECT24";
		((ButtonBase)Button_CLAVIER_NOSELECT24).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT23).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT23).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT23).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT23).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT23, "Button_CLAVIER_NOSELECT23");
		((Control)Button_CLAVIER_NOSELECT23).Name = "Button_CLAVIER_NOSELECT23";
		((ButtonBase)Button_CLAVIER_NOSELECT23).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT22).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT22).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT22).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT22).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT22, "Button_CLAVIER_NOSELECT22");
		((Control)Button_CLAVIER_NOSELECT22).Name = "Button_CLAVIER_NOSELECT22";
		((ButtonBase)Button_CLAVIER_NOSELECT22).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT21).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT21).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT21).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT21).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT21, "Button_CLAVIER_NOSELECT21");
		((Control)Button_CLAVIER_NOSELECT21).Name = "Button_CLAVIER_NOSELECT21";
		((ButtonBase)Button_CLAVIER_NOSELECT21).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT20).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT20).ForeColor = Color.FromArgb(31, 41, 55);
		((Control)Button_CLAVIER_NOSELECT20).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT20).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT20, "Button_CLAVIER_NOSELECT20");
		((Control)Button_CLAVIER_NOSELECT20).Name = "Button_CLAVIER_NOSELECT20";
		((ButtonBase)Button_CLAVIER_NOSELECT20).UseVisualStyleBackColor = false;
		((ButtonBase)Button_RACCOURCIES).BackColor = Color.White;
		((Control)Button_RACCOURCIES).Cursor = Cursors.Hand;
		((ButtonBase)Button_RACCOURCIES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_RACCOURCIES, "Button_RACCOURCIES");
		((Control)Button_RACCOURCIES).Name = "Button_RACCOURCIES";
		((ButtonBase)Button_RACCOURCIES).UseVisualStyleBackColor = false;
		((ButtonBase)Button_FERMER).BackColor = Color.Red;
		((Control)Button_FERMER).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_FERMER, "Button_FERMER");
		((Control)Button_FERMER).ForeColor = Color.White;
		((Control)Button_FERMER).Name = "Button_FERMER";
		((ButtonBase)Button_FERMER).UseVisualStyleBackColor = false;
		((ButtonBase)Button_COMPTER_CAISSE).BackColor = Color.White;
		((Control)Button_COMPTER_CAISSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_COMPTER_CAISSE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_COMPTER_CAISSE, "Button_COMPTER_CAISSE");
		((Control)Button_COMPTER_CAISSE).Name = "Button_COMPTER_CAISSE";
		((ButtonBase)Button_COMPTER_CAISSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CALCULATRICE).BackColor = Color.White;
		((Control)Button_CALCULATRICE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CALCULATRICE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CALCULATRICE, "Button_CALCULATRICE");
		((Control)Button_CALCULATRICE).Name = "Button_CALCULATRICE";
		((ButtonBase)Button_CALCULATRICE).UseVisualStyleBackColor = false;
		((ButtonBase)Button3).BackColor = Color.White;
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button3, "Button3");
		((Control)Button3).Name = "Button3";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((ButtonBase)Button_LISTE_ATTENTE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_LISTE_ATTENTE, "Button_LISTE_ATTENTE");
		((Control)Button_LISTE_ATTENTE).Cursor = Cursors.Hand;
		((ButtonBase)Button_LISTE_ATTENTE).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_LISTE_ATTENTE).ForeColor = SystemColors.ControlText;
		((Control)Button_LISTE_ATTENTE).Name = "Button_LISTE_ATTENTE";
		((ButtonBase)Button_LISTE_ATTENTE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_LOCK).BackColor = Color.White;
		((Control)Button_LOCK).Cursor = Cursors.Hand;
		((ButtonBase)Button_LOCK).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_LOCK, "Button_LOCK");
		((Control)Button_LOCK).Name = "Button_LOCK";
		((ButtonBase)Button_LOCK).UseVisualStyleBackColor = false;
		((ButtonBase)Button_RAPPORT).BackColor = Color.White;
		((Control)Button_RAPPORT).Cursor = Cursors.Hand;
		((ButtonBase)Button_RAPPORT).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_RAPPORT, "Button_RAPPORT");
		((Control)Button_RAPPORT).Name = "Button_RAPPORT";
		((ButtonBase)Button_RAPPORT).UseVisualStyleBackColor = false;
		((ButtonBase)Button_DEPENSES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_DEPENSES, "Button_DEPENSES");
		((Control)Button_DEPENSES).Name = "Button_DEPENSES";
		((ButtonBase)Button_DEPENSES).UseVisualStyleBackColor = true;
		((ButtonBase)Button_THEME).BackColor = Color.White;
		((Control)Button_THEME).Cursor = Cursors.Hand;
		((ButtonBase)Button_THEME).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_THEME, "Button_THEME");
		((Control)Button_THEME).Name = "Button_THEME";
		((ButtonBase)Button_THEME).UseVisualStyleBackColor = false;
		((ButtonBase)Button_ATTENTE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_ATTENTE, "Button_ATTENTE");
		((Control)Button_ATTENTE).Cursor = Cursors.Hand;
		((ButtonBase)Button_ATTENTE).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_ATTENTE).ForeColor = SystemColors.ControlText;
		((Control)Button_ATTENTE).Name = "Button_ATTENTE";
		((ButtonBase)Button_ATTENTE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_PRIX).BackColor = Color.White;
		((Control)Button_PRIX).Cursor = Cursors.Hand;
		((ButtonBase)Button_PRIX).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_PRIX, "Button_PRIX");
		((Control)Button_PRIX).Name = "Button_PRIX";
		((ButtonBase)Button_PRIX).UseVisualStyleBackColor = false;
		((ButtonBase)Button_MODIF_QTE).BackColor = Color.White;
		((Control)Button_MODIF_QTE).Cursor = Cursors.Hand;
		((ButtonBase)Button_MODIF_QTE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_MODIF_QTE, "Button_MODIF_QTE");
		((Control)Button_MODIF_QTE).Name = "Button_MODIF_QTE";
		((ButtonBase)Button_MODIF_QTE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_DIVERS).BackColor = Color.White;
		((Control)Button_DIVERS).Cursor = Cursors.Hand;
		((ButtonBase)Button_DIVERS).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_DIVERS, "Button_DIVERS");
		((Control)Button_DIVERS).Name = "Button_DIVERS";
		((ButtonBase)Button_DIVERS).UseVisualStyleBackColor = false;
		((ButtonBase)Button_TIROIR).BackColor = Color.White;
		((Control)Button_TIROIR).Cursor = Cursors.Hand;
		((ButtonBase)Button_TIROIR).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_TIROIR, "Button_TIROIR");
		((Control)Button_TIROIR).Name = "Button_TIROIR";
		((ButtonBase)Button_TIROIR).UseVisualStyleBackColor = false;
		((ButtonBase)Button_MODIF_PRIX).BackColor = Color.White;
		((Control)Button_MODIF_PRIX).Cursor = Cursors.Hand;
		((ButtonBase)Button_MODIF_PRIX).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_MODIF_PRIX, "Button_MODIF_PRIX");
		((Control)Button_MODIF_PRIX).Name = "Button_MODIF_PRIX";
		((ButtonBase)Button_MODIF_PRIX).UseVisualStyleBackColor = false;
		((ButtonBase)Button_REMISE).BackColor = Color.White;
		((Control)Button_REMISE).Cursor = Cursors.Hand;
		((ButtonBase)Button_REMISE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_REMISE, "Button_REMISE");
		((Control)Button_REMISE).Name = "Button_REMISE";
		((ButtonBase)Button_REMISE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_DUPLICATA).BackColor = Color.White;
		((Control)Button_DUPLICATA).Cursor = Cursors.Hand;
		((ButtonBase)Button_DUPLICATA).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_DUPLICATA, "Button_DUPLICATA");
		((Control)Button_DUPLICATA).Name = "Button_DUPLICATA";
		((ButtonBase)Button_DUPLICATA).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_FLASH, "Button_FLASH");
		((Control)Button_FLASH).Cursor = Cursors.Hand;
		((ButtonBase)Button_FLASH).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button_FLASH).Name = "Button_FLASH";
		((ButtonBase)Button_FLASH).UseVisualStyleBackColor = true;
		((ButtonBase)Button_CLOTURE).BackColor = Color.White;
		((Control)Button_CLOTURE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOTURE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLOTURE, "Button_CLOTURE");
		((Control)Button_CLOTURE).Name = "Button_CLOTURE";
		((ButtonBase)Button_CLOTURE).UseVisualStyleBackColor = false;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT26);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT27);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT28);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT29);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT30);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT31);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT32);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT33);
		((Control)TabPage2).Controls.Add((Control)(object)Button_ALERTS_STOCK);
		((Control)TabPage2).Controls.Add((Control)(object)Button_FONDS_CAISSE);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLIENTS);
		((Control)TabPage2).Controls.Add((Control)(object)Button_INVENTAIRE);
		((Control)TabPage2).Controls.Add((Control)(object)Button_ARTICLES);
		((Control)TabPage2).Controls.Add((Control)(object)Button_CLIENTS_REGLEMENTS);
		((Control)TabPage2).Controls.Add((Control)(object)Button_SORTIES);
		((Control)TabPage2).Controls.Add((Control)(object)Button_RECEPTIONS);
		((Control)TabPage2).Controls.Add((Control)(object)Button_FERMER2);
		componentResourceManager.ApplyResources(TabPage2, "TabPage2");
		((Control)TabPage2).Name = "TabPage2";
		((Control)Button_CLAVIER_NOSELECT26).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT26).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT26, "Button_CLAVIER_NOSELECT26");
		((Control)Button_CLAVIER_NOSELECT26).Name = "Button_CLAVIER_NOSELECT26";
		((ButtonBase)Button_CLAVIER_NOSELECT26).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT27).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT27).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT27, "Button_CLAVIER_NOSELECT27");
		((Control)Button_CLAVIER_NOSELECT27).Name = "Button_CLAVIER_NOSELECT27";
		((ButtonBase)Button_CLAVIER_NOSELECT27).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT28).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT28).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT28, "Button_CLAVIER_NOSELECT28");
		((Control)Button_CLAVIER_NOSELECT28).Name = "Button_CLAVIER_NOSELECT28";
		((ButtonBase)Button_CLAVIER_NOSELECT28).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT29).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT29).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT29, "Button_CLAVIER_NOSELECT29");
		((Control)Button_CLAVIER_NOSELECT29).Name = "Button_CLAVIER_NOSELECT29";
		((ButtonBase)Button_CLAVIER_NOSELECT29).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT30).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT30).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT30, "Button_CLAVIER_NOSELECT30");
		((Control)Button_CLAVIER_NOSELECT30).Name = "Button_CLAVIER_NOSELECT30";
		((ButtonBase)Button_CLAVIER_NOSELECT30).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT31).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT31).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT31, "Button_CLAVIER_NOSELECT31");
		((Control)Button_CLAVIER_NOSELECT31).Name = "Button_CLAVIER_NOSELECT31";
		((ButtonBase)Button_CLAVIER_NOSELECT31).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT32).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT32).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT32, "Button_CLAVIER_NOSELECT32");
		((Control)Button_CLAVIER_NOSELECT32).Name = "Button_CLAVIER_NOSELECT32";
		((ButtonBase)Button_CLAVIER_NOSELECT32).UseVisualStyleBackColor = true;
		((Control)Button_CLAVIER_NOSELECT33).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT33).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLAVIER_NOSELECT33, "Button_CLAVIER_NOSELECT33");
		((Control)Button_CLAVIER_NOSELECT33).Name = "Button_CLAVIER_NOSELECT33";
		((ButtonBase)Button_CLAVIER_NOSELECT33).UseVisualStyleBackColor = true;
		((ButtonBase)Button_ALERTS_STOCK).BackColor = Color.White;
		((Control)Button_ALERTS_STOCK).Cursor = Cursors.Hand;
		((ButtonBase)Button_ALERTS_STOCK).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_ALERTS_STOCK, "Button_ALERTS_STOCK");
		((Control)Button_ALERTS_STOCK).Name = "Button_ALERTS_STOCK";
		((ButtonBase)Button_ALERTS_STOCK).UseVisualStyleBackColor = false;
		((ButtonBase)Button_FONDS_CAISSE).BackColor = Color.White;
		((Control)Button_FONDS_CAISSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_FONDS_CAISSE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_FONDS_CAISSE, "Button_FONDS_CAISSE");
		((Control)Button_FONDS_CAISSE).Name = "Button_FONDS_CAISSE";
		((ButtonBase)Button_FONDS_CAISSE).UseVisualStyleBackColor = false;
		((Control)Button_CLIENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENTS).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLIENTS, "Button_CLIENTS");
		((Control)Button_CLIENTS).Name = "Button_CLIENTS";
		((ButtonBase)Button_CLIENTS).UseVisualStyleBackColor = true;
		((Control)Button_INVENTAIRE).Cursor = Cursors.Hand;
		((ButtonBase)Button_INVENTAIRE).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_INVENTAIRE, "Button_INVENTAIRE");
		((Control)Button_INVENTAIRE).Name = "Button_INVENTAIRE";
		((ButtonBase)Button_INVENTAIRE).UseVisualStyleBackColor = true;
		((Control)Button_ARTICLES).Cursor = Cursors.Hand;
		((ButtonBase)Button_ARTICLES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_ARTICLES, "Button_ARTICLES");
		((Control)Button_ARTICLES).Name = "Button_ARTICLES";
		((ButtonBase)Button_ARTICLES).UseVisualStyleBackColor = true;
		((Control)Button_CLIENTS_REGLEMENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENTS_REGLEMENTS).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_CLIENTS_REGLEMENTS, "Button_CLIENTS_REGLEMENTS");
		((Control)Button_CLIENTS_REGLEMENTS).Name = "Button_CLIENTS_REGLEMENTS";
		((ButtonBase)Button_CLIENTS_REGLEMENTS).UseVisualStyleBackColor = true;
		((Control)Button_SORTIES).Cursor = Cursors.Hand;
		((ButtonBase)Button_SORTIES).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_SORTIES, "Button_SORTIES");
		((Control)Button_SORTIES).Name = "Button_SORTIES";
		((ButtonBase)Button_SORTIES).UseVisualStyleBackColor = true;
		((Control)Button_RECEPTIONS).Cursor = Cursors.Hand;
		((ButtonBase)Button_RECEPTIONS).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button_RECEPTIONS, "Button_RECEPTIONS");
		((Control)Button_RECEPTIONS).Name = "Button_RECEPTIONS";
		((ButtonBase)Button_RECEPTIONS).UseVisualStyleBackColor = true;
		((ButtonBase)Button_FERMER2).BackColor = Color.Red;
		((Control)Button_FERMER2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_FERMER2, "Button_FERMER2");
		((Control)Button_FERMER2).ForeColor = Color.White;
		((Control)Button_FERMER2).Name = "Button_FERMER2";
		((ButtonBase)Button_FERMER2).UseVisualStyleBackColor = false;
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
		((TextBoxBase)Text_THEME).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_THEME, "Text_THEME");
		((Control)Text_THEME).Name = "Text_THEME";
		componentResourceManager.ApplyResources(Check_CHOIX_VENDEUR, "Check_CHOIX_VENDEUR");
		((Control)Check_CHOIX_VENDEUR).ForeColor = Color.Black;
		((Control)Check_CHOIX_VENDEUR).Name = "Check_CHOIX_VENDEUR";
		((ButtonBase)Check_CHOIX_VENDEUR).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Check_CHOIX_CLIENT, "Check_CHOIX_CLIENT");
		((Control)Check_CHOIX_CLIENT).ForeColor = Color.Black;
		((Control)Check_CHOIX_CLIENT).Name = "Check_CHOIX_CLIENT";
		((ButtonBase)Check_CHOIX_CLIENT).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_VENDEURS, "ListBox_VENDEURS");
		((ListControl)ListBox_VENDEURS).FormattingEnabled = true;
		((Control)ListBox_VENDEURS).Name = "ListBox_VENDEURS";
		((Control)Panel1).Controls.Add((Control)(object)Text_PRIX_QTE_MIN);
		((Control)Panel1).Controls.Add((Control)(object)TableLayoutPanel1);
		((Control)Panel1).Controls.Add((Control)(object)Text_GROUPE);
		((Control)Panel1).Controls.Add((Control)(object)Panel10);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRIX_QTE);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_ACCES);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_DUPLICATA);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER);
		((Control)Panel1).Controls.Add((Control)(object)CheckBox_AFFICHER_CODEBARRE);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_MODE_P);
		((Control)Panel1).Controls.Add((Control)(object)CheckBox_AFFICHER_N_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Text_ID_ARTICLE);
		((Control)Panel1).Controls.Add((Control)(object)CheckBox_AFFICHER_MODEV);
		((Control)Panel1).Controls.Add((Control)(object)Text_PROMOTION);
		((Control)Panel1).Controls.Add((Control)(object)CheckBox_AFFICHER_MODEP);
		((Control)Panel1).Controls.Add((Control)(object)Check_SOLDER_SANS_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Text_pied);
		((Control)Panel1).Controls.Add((Control)(object)Picture_FLECH_HAUT);
		((Control)Panel1).Controls.Add((Control)(object)Picture_FLECH_BAS);
		((Control)Panel1).Controls.Add((Control)(object)Text_MODELE_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C2);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C1);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_ADDITION);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_SOLDER);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C4);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C3);
		((Control)Panel1).Controls.Add((Control)(object)Check_GESTION_CREDIT);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRIX_A);
		((Control)Panel1).Controls.Add((Control)(object)ListBox_VENDEURS);
		((Control)Panel1).Controls.Add((Control)(object)Text_ARTICLE);
		((Control)Panel1).Controls.Add((Control)(object)Text_THEME);
		((Control)Panel1).Controls.Add((Control)(object)Check_CHOIX_CLIENT);
		((Control)Panel1).Controls.Add((Control)(object)Text_ID_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Check_CHOIX_VENDEUR);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRIX_MP);
		((Control)Panel1).Controls.Add((Control)(object)Check_STOCK);
		((Control)Panel1).Controls.Add((Control)(object)Check_ACCES_RFID);
		((Control)Panel1).Controls.Add((Control)(object)Text_FAMILLE);
		((Control)Panel1).Controls.Add((Control)(object)Check_ACCES_MODEP);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRIXV);
		((Control)Panel1).Controls.Add((Control)(object)Text_TAUX_TVA);
		((Control)Panel1).Controls.Add((Control)(object)Combo_BAUDRATE);
		((Control)Panel1).Controls.Add((Control)(object)Picture_TRISTE);
		((Control)Panel1).Controls.Add((Control)(object)Combo_PORT);
		((Control)Panel1).Controls.Add((Control)(object)Picture_SMILE);
		((Control)Panel1).Controls.Add((Control)(object)List_COLOR);
		((Control)Panel1).Controls.Add((Control)(object)Text_HEURE_RETARD);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C5);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C7);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_C6);
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).Name = "Panel1";
		((TextBoxBase)Text_GROUPE).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_GROUPE, "Text_GROUPE");
		((Control)Text_GROUPE).Name = "Text_GROUPE";
		((Control)Panel10).Controls.Add((Control)(object)Panel_RACCOURCIES);
		componentResourceManager.ApplyResources(Panel10, "Panel10");
		((Control)Panel10).Name = "Panel10";
		((Control)Panel_RACCOURCIES).BackColor = Color.White;
		((Control)Panel_RACCOURCIES).Controls.Add((Control)(object)Label10);
		((Control)Panel_RACCOURCIES).Controls.Add((Control)(object)FlowLayout_RACCOURCIES);
		componentResourceManager.ApplyResources(Panel_RACCOURCIES, "Panel_RACCOURCIES");
		((Control)Panel_RACCOURCIES).Name = "Panel_RACCOURCIES";
		((Control)Label10).BackColor = Color.Black;
		((Control)Label10).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.White;
		((Control)Label10).Name = "Label10";
		componentResourceManager.ApplyResources(FlowLayout_RACCOURCIES, "FlowLayout_RACCOURCIES");
		((Control)FlowLayout_RACCOURCIES).BackColor = Color.White;
		((Control)FlowLayout_RACCOURCIES).Name = "FlowLayout_RACCOURCIES";
		DataGridView_ACCES.AllowUserToAddRows = false;
		DataGridView_ACCES.AllowUserToDeleteRows = false;
		DataGridView_ACCES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		componentResourceManager.ApplyResources(DataGridView_ACCES, "DataGridView_ACCES");
		((Control)DataGridView_ACCES).Name = "DataGridView_ACCES";
		DataGridView_ACCES.ReadOnly = true;
		componentResourceManager.ApplyResources(Text_PRINTER_DUPLICATA, "Text_PRINTER_DUPLICATA");
		((Control)Text_PRINTER_DUPLICATA).Name = "Text_PRINTER_DUPLICATA";
		componentResourceManager.ApplyResources(Text_PRINTER, "Text_PRINTER");
		((Control)Text_PRINTER).Name = "Text_PRINTER";
		componentResourceManager.ApplyResources(CheckBox_AFFICHER_CODEBARRE, "CheckBox_AFFICHER_CODEBARRE");
		CheckBox_AFFICHER_CODEBARRE.Checked = true;
		CheckBox_AFFICHER_CODEBARRE.CheckState = (CheckState)1;
		((Control)CheckBox_AFFICHER_CODEBARRE).ForeColor = Color.Black;
		((Control)CheckBox_AFFICHER_CODEBARRE).Name = "CheckBox_AFFICHER_CODEBARRE";
		((ButtonBase)CheckBox_AFFICHER_CODEBARRE).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox_AFFICHER_CODEBARRE).UseVisualStyleBackColor = true;
		DataGridView_MODE_P.AllowUserToAddRows = false;
		DataGridView_MODE_P.AllowUserToDeleteRows = false;
		DataGridView_MODE_P.AllowUserToResizeColumns = false;
		DataGridView_MODE_P.AllowUserToResizeRows = false;
		componentResourceManager.ApplyResources(DataGridView_MODE_P, "DataGridView_MODE_P");
		DataGridView_MODE_P.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_MODE_P.BackgroundColor = Color.White;
		DataGridView_MODE_P.BorderStyle = (BorderStyle)2;
		DataGridView_MODE_P.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_MODE_P.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn3
		});
		DataGridView_MODE_P.EditMode = (DataGridViewEditMode)4;
		DataGridView_MODE_P.EnableHeadersVisualStyles = false;
		((Control)DataGridView_MODE_P).Name = "DataGridView_MODE_P";
		DataGridView_MODE_P.RowHeadersVisible = false;
		DataGridView_MODE_P.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2");
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3");
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		componentResourceManager.ApplyResources(CheckBox_AFFICHER_N_TICKET, "CheckBox_AFFICHER_N_TICKET");
		CheckBox_AFFICHER_N_TICKET.Checked = true;
		CheckBox_AFFICHER_N_TICKET.CheckState = (CheckState)1;
		((Control)CheckBox_AFFICHER_N_TICKET).ForeColor = Color.Black;
		((Control)CheckBox_AFFICHER_N_TICKET).Name = "CheckBox_AFFICHER_N_TICKET";
		((ButtonBase)CheckBox_AFFICHER_N_TICKET).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox_AFFICHER_N_TICKET).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_ID_ARTICLE).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_ID_ARTICLE, "Text_ID_ARTICLE");
		((Control)Text_ID_ARTICLE).Name = "Text_ID_ARTICLE";
		componentResourceManager.ApplyResources(CheckBox_AFFICHER_MODEV, "CheckBox_AFFICHER_MODEV");
		CheckBox_AFFICHER_MODEV.Checked = true;
		CheckBox_AFFICHER_MODEV.CheckState = (CheckState)1;
		((Control)CheckBox_AFFICHER_MODEV).ForeColor = Color.Black;
		((Control)CheckBox_AFFICHER_MODEV).Name = "CheckBox_AFFICHER_MODEV";
		((ButtonBase)CheckBox_AFFICHER_MODEV).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox_AFFICHER_MODEV).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Text_PROMOTION, "Text_PROMOTION");
		((Control)Text_PROMOTION).Name = "Text_PROMOTION";
		componentResourceManager.ApplyResources(CheckBox_AFFICHER_MODEP, "CheckBox_AFFICHER_MODEP");
		CheckBox_AFFICHER_MODEP.Checked = true;
		CheckBox_AFFICHER_MODEP.CheckState = (CheckState)1;
		((Control)CheckBox_AFFICHER_MODEP).ForeColor = Color.Black;
		((Control)CheckBox_AFFICHER_MODEP).Name = "CheckBox_AFFICHER_MODEP";
		((ButtonBase)CheckBox_AFFICHER_MODEP).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox_AFFICHER_MODEP).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Check_SOLDER_SANS_TICKET, "Check_SOLDER_SANS_TICKET");
		((Control)Check_SOLDER_SANS_TICKET).Name = "Check_SOLDER_SANS_TICKET";
		((ButtonBase)Check_SOLDER_SANS_TICKET).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_pied).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_pied, "Text_pied");
		((Control)Text_pied).Name = "Text_pied";
		componentResourceManager.ApplyResources(Picture_FLECH_HAUT, "Picture_FLECH_HAUT");
		((Control)Picture_FLECH_HAUT).Name = "Picture_FLECH_HAUT";
		Picture_FLECH_HAUT.TabStop = false;
		componentResourceManager.ApplyResources(Picture_FLECH_BAS, "Picture_FLECH_BAS");
		((Control)Picture_FLECH_BAS).Name = "Picture_FLECH_BAS";
		Picture_FLECH_BAS.TabStop = false;
		componentResourceManager.ApplyResources(Text_MODELE_TICKET, "Text_MODELE_TICKET");
		((Control)Text_MODELE_TICKET).Name = "Text_MODELE_TICKET";
		componentResourceManager.ApplyResources(Text_PRINTER_C2, "Text_PRINTER_C2");
		((Control)Text_PRINTER_C2).Name = "Text_PRINTER_C2";
		componentResourceManager.ApplyResources(Text_PRINTER_C1, "Text_PRINTER_C1");
		((Control)Text_PRINTER_C1).Name = "Text_PRINTER_C1";
		componentResourceManager.ApplyResources(Text_PRINTER_ADDITION, "Text_PRINTER_ADDITION");
		((Control)Text_PRINTER_ADDITION).Name = "Text_PRINTER_ADDITION";
		componentResourceManager.ApplyResources(Text_PRINTER_SOLDER, "Text_PRINTER_SOLDER");
		((Control)Text_PRINTER_SOLDER).Name = "Text_PRINTER_SOLDER";
		componentResourceManager.ApplyResources(Text_PRINTER_C4, "Text_PRINTER_C4");
		((Control)Text_PRINTER_C4).Name = "Text_PRINTER_C4";
		componentResourceManager.ApplyResources(Text_PRINTER_C3, "Text_PRINTER_C3");
		((Control)Text_PRINTER_C3).Name = "Text_PRINTER_C3";
		componentResourceManager.ApplyResources(Check_GESTION_CREDIT, "Check_GESTION_CREDIT");
		Check_GESTION_CREDIT.Checked = true;
		Check_GESTION_CREDIT.CheckState = (CheckState)1;
		((Control)Check_GESTION_CREDIT).ForeColor = Color.Black;
		((Control)Check_GESTION_CREDIT).Name = "Check_GESTION_CREDIT";
		((ButtonBase)Check_GESTION_CREDIT).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_PRIX_A).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_PRIX_A, "Text_PRIX_A");
		((Control)Text_PRIX_A).Name = "Text_PRIX_A";
		((TextBoxBase)Text_ARTICLE).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_ARTICLE, "Text_ARTICLE");
		((Control)Text_ARTICLE).Name = "Text_ARTICLE";
		((TextBoxBase)Text_PRIX_MP).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_PRIX_MP, "Text_PRIX_MP");
		((Control)Text_PRIX_MP).Name = "Text_PRIX_MP";
		((TextBoxBase)Text_FAMILLE).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_FAMILLE, "Text_FAMILLE");
		((Control)Text_FAMILLE).Name = "Text_FAMILLE";
		((TextBoxBase)Text_PRIXV).BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(Text_PRIXV, "Text_PRIXV");
		((Control)Text_PRIXV).Name = "Text_PRIXV";
		componentResourceManager.ApplyResources(Text_TAUX_TVA, "Text_TAUX_TVA");
		((Control)Text_TAUX_TVA).Name = "Text_TAUX_TVA";
		componentResourceManager.ApplyResources(Picture_TRISTE, "Picture_TRISTE");
		((Control)Picture_TRISTE).Name = "Picture_TRISTE";
		Picture_TRISTE.TabStop = false;
		componentResourceManager.ApplyResources(Picture_SMILE, "Picture_SMILE");
		((Control)Picture_SMILE).Name = "Picture_SMILE";
		Picture_SMILE.TabStop = false;
		componentResourceManager.ApplyResources(Text_PRINTER_C5, "Text_PRINTER_C5");
		((Control)Text_PRINTER_C5).Name = "Text_PRINTER_C5";
		componentResourceManager.ApplyResources(Text_PRINTER_C7, "Text_PRINTER_C7");
		((Control)Text_PRINTER_C7).Name = "Text_PRINTER_C7";
		componentResourceManager.ApplyResources(Text_PRINTER_C6, "Text_PRINTER_C6");
		((Control)Text_PRINTER_C6).Name = "Text_PRINTER_C6";
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).Controls.Add((Control)(object)SplitContainer2);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_3_VENTE";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)SplitContainer2.Panel1).ResumeLayout(false);
		((Control)SplitContainer2.Panel2).ResumeLayout(false);
		((ISupportInitialize)SplitContainer2).EndInit();
		((Control)SplitContainer2).ResumeLayout(false);
		((Control)Panel0).ResumeLayout(false);
		((Control)Panel_LOGO).ResumeLayout(false);
		((ISupportInitialize)Picture_LOGO).EndInit();
		((ISupportInitialize)PictureBox100).EndInit();
		((Control)Panel_RAPPEL).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel00).ResumeLayout(false);
		((Control)Panel9).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((ISupportInitialize)DataGridView100).EndInit();
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)FlowLayoutPanel2).ResumeLayout(false);
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel3).ResumeLayout(false);
		((Control)Panel_CLAVIER_AR).ResumeLayout(false);
		((Control)TableLayoutPanel4).ResumeLayout(false);
		((Control)TableLayoutPanel5).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel33).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel10).ResumeLayout(false);
		((Control)Panel_RACCOURCIES).ResumeLayout(false);
		((ISupportInitialize)DataGridView_ACCES).EndInit();
		((ISupportInitialize)DataGridView_MODE_P).EndInit();
		((ISupportInitialize)Picture_FLECH_HAUT).EndInit();
		((ISupportInitialize)Picture_FLECH_BAS).EndInit();
		((ISupportInitialize)Picture_TRISTE).EndInit();
		((ISupportInitialize)Picture_SMILE).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void Start_Print_COM_CL()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_SOLDER.Text);
	}

	public void Start_Print_COM_C1()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C1.Text);
	}

	public void Start_Print_COM_C2()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C2.Text);
	}

	public void Start_Print_COM_C3()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C3.Text);
	}

	public void Start_Print_COM_C4()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C4.Text);
	}

	public void Start_Print_COM_C5()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C5.Text);
	}

	public void Start_Print_COM_C6()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C6.Text);
	}

	public void Start_Print_COM_C7()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_C7.Text);
	}

	public void Print_COM_CL(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_SOLDER.Text, Line + "\n");
	}

	public void Print_COM_C1(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C1.Text, Line + "\n");
	}

	public void Print_COM_C2(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C2.Text, Line + "\n");
	}

	public void Print_COM_C3(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C3.Text, Line + "\n");
	}

	public void Print_COM_C4(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C4.Text, Line + "\n");
	}

	public void Print_COM_C5(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C5.Text, Line + "\n");
	}

	public void Print_COM_C6(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C6.Text, Line + "\n");
	}

	public void Print_COM_C7(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_C7.Text, Line + "\n");
	}

	public void EndPrint()
	{
		prn.ClosePrint();
	}

	public void CL_COM()
	{
		Start_Print_COM_CL();
		Print_COM_CL("\u001d!\u0011\u001bE\u0001\u001ba1" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text);
		Print_COM_CL("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
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
				text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 30) + "  " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6)), 2));
				Print_COM_CL("\u001b!\0" + text);
				num2++;
			}
			Print_COM_CL("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_CL("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			_string = "";
			_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
			_string += "\r\n";
			decimal num5 = 0m;
			decimal num6 = 0m;
			int num7 = Module1.dt1.Rows.Count - 1;
			int num8 = 0;
			while (true)
			{
				int num9 = num8;
				int num4 = num7;
				if (num9 > num4)
				{
					break;
				}
				num5 = Conversions.ToDecimal(Operators.AddObject(num5, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num8]["PRIX_V"], Module1.dt1.Rows[num8]["Qté"]), Module1.dt1.Rows[num8]["TOTAL_NET"])));
				num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.MultiplyObject(Module1.dt1.Rows[num8]["PRIX_V"], Module1.dt1.Rows[num8]["Qté"])));
				num8++;
			}
			if (decimal.Compare(num5, 0m) > 0)
			{
				_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num5), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num5, num6), 100m)) + " %\r\n";
				_string += "\r\n\r\n";
			}
			if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
			{
				if (CheckBox_AFFICHER_MODEP.Checked)
				{
					string text2 = "";
					if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count == 1)
					{
						_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value), 6)))) + " DH\r\n";
						_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value), 6)))) + " DH\r\n";
					}
					else
					{
						int num10 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
						int num11 = 0;
						while (true)
						{
							int num12 = num11;
							int num4 = num10;
							if (num12 <= num4)
							{
								if (Operators.ConditionalCompareObjectLess(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["RENDU"].Value, 0, TextCompare: false))
								{
									_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["PAYER"].Value), 6)))) + " DH\r\n";
								}
								else
								{
									_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["PAYER"].Value), 6)))) + " DH\r\n";
									_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num11].Cells["RENDU"].Value), 6)))) + " DH\r\n";
								}
								num11++;
								continue;
							}
							break;
						}
					}
				}
			}
			else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
			{
				_string += "\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "-------------------CREDIT------------------\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "\r\n";
			}
			_string += "\r\n";
			if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
			{
				_string = _string + "* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
				_string = _string + "* ID        : " + Button_CLIENT._ID_Button + "\r\n";
			}
			_string = _string + "* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
			if (CheckBox_AFFICHER_N_TICKET.Checked)
			{
				_string = _string + "* N° TICKET : " + _N_TICKET_SOLDER + "\r\n";
			}
			_string += Text_pied.Text;
			_string += "\r\n";
			_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
			Print_COM_CL("\u001b!\0\u001ba0" + _string);
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
		}
	}

	public void C1_COM()
	{
		Start_Print_COM_C1();
		Print_COM_C1("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C1("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C1("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C1", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C1", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C1("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C1("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C1("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C1("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C1)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C1("\u001ba1\u001b!\0" + text2);
			Print_COM_C1("\n");
			Print_COM_C1("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C2_COM()
	{
		Start_Print_COM_C2();
		Print_COM_C2("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C2("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C2("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C2", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C2", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C2("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C2("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C2("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C2("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C2)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C2("\u001ba1\u001b!\0" + text2);
			Print_COM_C2("\n");
			Print_COM_C2("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C3_COM()
	{
		Start_Print_COM_C3();
		Print_COM_C3("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C3("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C3("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C3", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C3", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C3("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C3("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C3("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C3("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C3)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C3("\u001ba1\u001b!\0" + text2);
			Print_COM_C3("\n");
			Print_COM_C3("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C4_COM()
	{
		Start_Print_COM_C4();
		Print_COM_C4("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C4("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C4("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C4", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C4", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C4("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C4("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C4("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C4("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C4)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C4("\u001ba1\u001b!\0" + text2);
			Print_COM_C4("\n");
			Print_COM_C4("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C5_COM()
	{
		Start_Print_COM_C5();
		Print_COM_C5("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C5("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C5("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C5", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C5", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C5("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C5("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C5("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C5("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C5)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C5("\u001ba1\u001b!\0" + text2);
			Print_COM_C5("\n");
			Print_COM_C5("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C6_COM()
	{
		Start_Print_COM_C6();
		Print_COM_C6("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C6("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C6("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C6", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C6", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C6("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C6("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C6("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C6("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C6)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C6("\u001ba1\u001b!\0" + text2);
			Print_COM_C6("\n");
			Print_COM_C6("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void C7_COM()
	{
		Start_Print_COM_C7();
		Print_COM_C7("\u001d!\u0011\u001bE\u0001\u001ba1" + _N_TICKET_SOLDER);
		Print_COM_C7("\u001b!\0\u001ba0" + Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15));
		Print_COM_C7("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
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
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C7", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C7", TextCompare: false))))
				{
					text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 28) + "  " + Strings.LSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6);
					Print_COM_C7("\u001b!\0" + text);
				}
				num2++;
			}
			Print_COM_C7("\u001b!\0\u001ba0" + "-".PadRight(42, '-'));
			Print_COM_C7("\u001d!\u0011\u001bE\u0001\u001ba0TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_C7("\n");
			string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C7)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
			Print_COM_C7("\u001ba1\u001b!\0" + text2);
			Print_COM_C7("\n");
			Print_COM_C7("\n\n\u001bi\r\n");
			EndPrint();
		}
	}

	public void BON_RETOUR_COM()
	{
		Start_Print_COM_CL();
		Print_COM_CL("\u001b!8\u001ba1" + ((ButtonBase)Button_OPERATION).Text);
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
				text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString(), 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 30) + "  " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6)), 2));
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\u001ba0\u001b!8TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0* N TICKET  : " + _N_TICKET_SOLDER);
			Print_COM_CL("\u001ba0\u001b!\0* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "/" + ((ButtonBase)Button_VENDEUR).Text);
			Print_COM_CL("\u001ba0\u001b!\0* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text);
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\u001b!8\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1MERCI DE VOTRE VISITE");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
		}
	}

	public void CREATION_ACCES()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select  * from TABLE_PASS     Where    ListUser = '" + Strings.Trim(Module1._USERNAME) + "'        ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count > 0)
		{
			DataGridView_ACCES.DataSource = dataTable;
		}
		checked
		{
			int num = ((BaseCollection)DataGridView_ACCES.Columns).Count - 1;
			int num2 = 5;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true).Count() == 1)
				{
					if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 1;
					}
					else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = false;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 1;
					}
					else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 3;
					}
					else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)this).Controls.Find("Button_" + DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 5;
					}
					if (Operators.CompareString(DataGridView_ACCES.Columns[num2].Name.ToString(), "FLASH", TextCompare: false) == 0)
					{
						if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)Button_COMPTER_CAISSE).Visible = false;
							((ButtonBase)Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
						{
							((Control)Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 5;
						}
					}
					else if (Operators.CompareString(DataGridView_ACCES.Columns[num2].Name.ToString(), "ANNULATION", TextCompare: false) == 0)
					{
						if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)Button_ANNULATION_ALL).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)Button_ANNULATION_ALL).Visible = false;
							((ButtonBase)Button_ANNULATION_ALL).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)Button_ANNULATION_ALL).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
						{
							((Control)Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)Button_ANNULATION_ALL).FlatAppearance.BorderSize = 5;
						}
					}
				}
				num2++;
			}
		}
	}

	public void CREATION_RACCOURCIES()
	{
		checked
		{
			try
			{
				string[] array = File.ReadAllLines(Application.StartupPath + "/raccourcies.sni");
				if (array.Count() == 0)
				{
					((Control)Panel_RACCOURCIES).Height = 0;
					return;
				}
				((Control)Panel_RACCOURCIES).Height = 60;
				((Control)FlowLayout_RACCOURCIES).Controls.Clear();
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (Operators.CompareString(text, "", TextCompare: false) == 0)
					{
						continue;
					}
					Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = (Button_CLAVIER_NOSELECT)(object)((Control)TabPage1).Controls["Button_" + text];
					Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = new Button_CLAVIER_NOSELECT();
					((Control)button_CLAVIER_NOSELECT2).Name = "Button_RACCOURCIE_" + text;
					((ButtonBase)button_CLAVIER_NOSELECT2).Text = ((ButtonBase)button_CLAVIER_NOSELECT).Text;
					((ButtonBase)button_CLAVIER_NOSELECT2).BackColor = ((ButtonBase)button_CLAVIER_NOSELECT).BackColor;
					((Control)button_CLAVIER_NOSELECT2).Cursor = ((Control)button_CLAVIER_NOSELECT).Cursor;
					((ButtonBase)button_CLAVIER_NOSELECT2).FlatStyle = (FlatStyle)0;
					((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderColor = ((ButtonBase)button_CLAVIER_NOSELECT).FlatAppearance.BorderColor;
					((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = ((ButtonBase)button_CLAVIER_NOSELECT).FlatAppearance.BorderSize;
					((Control)button_CLAVIER_NOSELECT2).Visible = ((Control)button_CLAVIER_NOSELECT).Visible;
					((Control)button_CLAVIER_NOSELECT2).Width = 140;
					((Control)button_CLAVIER_NOSELECT2).Height = 54;
					((ButtonBase)button_CLAVIER_NOSELECT2).UseVisualStyleBackColor = false;
					((ButtonBase)button_CLAVIER_NOSELECT2).Image = ((ButtonBase)button_CLAVIER_NOSELECT).Image;
					((ButtonBase)button_CLAVIER_NOSELECT2).ImageAlign = (ContentAlignment)16;
					((ButtonBase)button_CLAVIER_NOSELECT2).TextAlign = (ContentAlignment)32;
					((ButtonBase)button_CLAVIER_NOSELECT2).TextImageRelation = (TextImageRelation)4;
					((Control)button_CLAVIER_NOSELECT2).Font = ((Control)button_CLAVIER_NOSELECT).Font;
					((Control)FlowLayout_RACCOURCIES).Controls.Add((Control)(object)button_CLAVIER_NOSELECT2);
					FieldInfo field = typeof(Component).GetField("events", BindingFlags.Instance | BindingFlags.NonPublic);
					object objectValue = RuntimeHelpers.GetObjectValue(field.GetValue(((Control)TabPage1).Controls["Button_" + text]));
					field.SetValue(((Control)FlowLayout_RACCOURCIES).Controls[((Control)button_CLAVIER_NOSELECT2).Name], RuntimeHelpers.GetObjectValue(objectValue));
					try
					{
						if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = true;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = false;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = true;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = true;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 5;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception e = ex;
						StackTrace stackTrace = new StackTrace(e, fNeedFileInfo: true);
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						int fileLineNumber = frame.GetFileLineNumber();
						((Control)button_CLAVIER_NOSELECT2).Visible = true;
						((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 1;
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception e2 = ex2;
				StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				((Control)Panel_RACCOURCIES).Height = 0;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void CREATION_IMPRESSION(object _sender)
	{
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "0", TextCompare: false) != 0)
				{
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(_sender, null, "name", new object[0], null, null, null), "Button_SOLDER_PRINTER", TextCompare: false), Operators.CompareObjectEqual(NewLateBinding.LateGet(_sender, null, "name", new object[0], null, null, null), "Button_SOLDER_CREDIT", TextCompare: false))))
					{
						if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
						{
							if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
							{
								if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_3C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_3C.PrintController = (PrintController)new StandardPrintController();
									CL_FR_3C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_4C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_4C.PrintController = (PrintController)new StandardPrintController();
									CL_FR_4C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_2L", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_2L.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_2L.PrintController = (PrintController)new StandardPrintController();
									CL_FR_2L.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "AR_3C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_AR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_AR_3C.PrintController = (PrintController)new StandardPrintController();
									CL_AR_3C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "AR_4C", TextCompare: false) == 0)
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
						else if (((ButtonBase)Button_OPERATION).Text.Contains("RETOUR"))
						{
							if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
							{
								if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
								{
									BON_RETOUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
								}
								BON_RETOUR.PrintController = (PrintController)new StandardPrintController();
								BON_RETOUR.Print();
								BON_RETOUR.Print();
							}
							else
							{
								BON_RETOUR_COM();
								BON_RETOUR_COM();
							}
						}
						else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
						{
							if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
							{
								if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_3C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_3C.PrintController = (PrintController)new StandardPrintController();
									CL_FR_3C.Print();
									CL_FR_3C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_4C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_4C.PrintController = (PrintController)new StandardPrintController();
									CL_FR_4C.Print();
									CL_FR_4C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "FR_2L", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_FR_2L.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_FR_2L.PrintController = (PrintController)new StandardPrintController();
									CL_FR_2L.Print();
									CL_FR_2L.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "AR_3C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_AR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_AR_3C.PrintController = (PrintController)new StandardPrintController();
									CL_AR_3C.Print();
									CL_AR_3C.Print();
								}
								else if (Operators.CompareString(Text_MODELE_TICKET.Text, "AR_4C", TextCompare: false) == 0)
								{
									if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
									{
										CL_AR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
									}
									CL_AR_4C.PrintController = (PrintController)new StandardPrintController();
									CL_AR_4C.Print();
									CL_AR_4C.Print();
								}
							}
							else
							{
								CL_COM();
								CL_COM();
							}
						}
					}
					else
					{
						string command = "\u001bp\0<" + Conversions.ToString(Strings.Chr(255));
						string text = Text_PRINTER_SOLDER.Text;
						RawPrinterHelperr.SendStringToPrinter(text, command);
					}
				}
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(_sender, null, "name", new object[0], null, null, null), "Button_SOLDER_PRINTER", TextCompare: false) || Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) != 0 || Operators.CompareString(Text_PRINTER_C1.Text, "0", TextCompare: false) == 0)
				{
					return;
				}
				bool flag = false;
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
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER"].Value, "C1", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num2].Cells["PRINTER_DUPLICATA"].Value, "C1", TextCompare: false))))
					{
						flag = true;
						break;
					}
					num2++;
				}
				if (flag)
				{
					if (Operators.CompareString(Text_PRINTER_C1.Text, "", TextCompare: false) != 0)
					{
						C1.PrinterSettings.PrinterName = Text_PRINTER_C1.Text;
					}
					C1.PrintController = (PrintController)new StandardPrintController();
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						C1.Print();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				NewLateBinding.LateSet(_sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox("ERREUR IMPRESSION SOLDER : " + ex2.Message);
				try
				{
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERREUR IMPRESSION SOLDER  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(_sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	public void Form_vente_Activated(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
			DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
			DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
			DataGridView100.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
			DataGridView100.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
			PictureBox100.Image = (Image)(object)MyProject.Forms.Form_0_TEMPLATE.logo_ar_vente;
			Picture_LOGO.Image = (Image)(object)MyProject.Forms.Form_0_TEMPLATE.logo_ar_vente_logo;
			Butt_AR_Click(RuntimeHelpers.GetObjectValue(sender), e);
			((Control)TabControl2).BringToFront();
		}
	}

	private void Form_vente_Load(object sender, EventArgs e)
	{
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected Obj, but got Unknown
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected Obj, but got Unknown
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected Obj, but got Unknown
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Expected Obj, but got Unknown
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected Obj, but got Unknown
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected Obj, but got Unknown
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		checked
		{
			try
			{
				SplitContainer2.Dock = (DockStyle)5;
				((Control)Panel_FONCTIONS).Left = (int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_FONCTIONS).Width / 2.0);
				((Control)Panel_FONCTIONS).Top = (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel_FONCTIONS).Height / 2.0);
				((ButtonBase)Button_CAISSIER).Text = Module1._USERNAME;
				((Control)Button_FIND).BringToFront();
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
				{
					((ButtonBase)Button244).Image = MyProject.Forms.Form_0_TEMPLATE.PictureBox_SORTIE.Image;
				}
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select    ListUser    from TABLE_PASS  where  Catégorie = 'UTILISATEUR'   order by ID asc", Module1.cn_SQL);
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
					ListBox_VENDEURS.Items.Add((object)dataTable.Rows[num2]["ListUser"].ToString());
					num2++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select    MODE_P,Images    from TABLE_MODE_P   order by ID asc", Module1.cn_SQL);
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
					DataGridView_MODE_P.Rows.Add(new object[2]
					{
						dataTable.Rows[num6]["MODE_P"].ToString(),
						dataTable.Rows[num6]["Images"].ToString()
					});
					num6++;
				}
				dataTable.Clear();
				dataTable = null;
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
				DataGridView1.DataSource = Module1.dt1;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				ApplyBasketSelectionContrast();
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				// One-time AutoResizeColumnHeadersHeight clips text after DPI/font changes.
				DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.MultiSelect = true;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num8 = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView1.Columns[num9].SortMode = (DataGridViewColumnSortMode)2;
					num9++;
				}
				DataGridView1.ClearSelection();
				DataGridView1.Columns["Article"].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DataGridView1.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
				DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 106, 238);
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dt_LA.Rows.Clear();
				Check_SOLDER_SANS_TICKET.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("SOLDER_SANS_TICKET", false, 0).Index].SubItems[1].Text);
				CheckBox_AFFICHER_MODEP.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHER_MODE_P", false, 0).Index].SubItems[1].Text);
				CheckBox_AFFICHER_N_TICKET.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHER_N_TICKET", false, 0).Index].SubItems[1].Text);
				CheckBox_AFFICHER_MODEV.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHER_MODE_V", false, 0).Index].SubItems[1].Text);
				Text_pied.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("PIED_TICKET", false, 0).Index].SubItems[1].Text;
				CheckBox_AFFICHER_CODEBARRE.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHER_CODE_BARRE", false, 0).Index].SubItems[1].Text);
				Check_ACCES_MODEP.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("FENETRE_MODE_P", false, 0).Index].SubItems[1].Text);
				Check_STOCK.Checked = Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_STOCK", false, 0).Index].SubItems[1].Text);
				Text_HEURE_RETARD.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("HEURE_RETARD", false, 0).Index].SubItems[1].Text));
				Combo_PORT.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHEUR_PORT", false, 0).Index].SubItems[1].Text;
				Combo_BAUDRATE.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("AFFICHEUR_BAUDRATE", false, 0).Index].SubItems[1].Text;
				Text_THEME.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("THEME", false, 0).Index].SubItems[1].Text;
				Text_MODELE_TICKET.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MODELE_TICKET", false, 0).Index].SubItems[1].Text;
				SplitContainer2.SplitterDistance = Conversions.ToInteger(File.ReadAllText(Application.StartupPath + "/splitterdistance_v.sni"));
				Check_ACCES_RFID.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/acces_rfid.sni"));
				Check_CHOIX_VENDEUR.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/choix_vendeur.sni"));
				Check_CHOIX_CLIENT.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/choix_client.sni"));
				Check_GESTION_CREDIT.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/gestion_credit.sni"));
				Text_PRINTER_SOLDER.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_CL.sni");
				Text_PRINTER_C1.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C1.sni");
				Text_PRINTER_C2.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C2.sni");
				Text_PRINTER_C3.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C3.sni");
				Text_PRINTER_C4.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C4.sni");
				Text_PRINTER_C5.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C5.sni");
				Text_PRINTER_C6.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C6.sni");
				Text_PRINTER_C7.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C7.sni");
				if (Check_CHOIX_VENDEUR.Checked)
				{
					((Control)Button_VENDEUR).Visible = true;
					((Control)Button1717).Visible = true;
				}
				if (Check_CHOIX_CLIENT.Checked)
				{
					((Control)Button_CLIENT).Visible = true;
					((Control)Button2121).Visible = true;
				}
				if (Check_SOLDER_SANS_TICKET.Checked)
				{
					((Control)Button_SOLDER_PRINTER).Width = 186;
					((Control)Button_SOLDER_NOT_PRINTER).Visible = true;
				}
				if (Check_GESTION_CREDIT.Checked)
				{
					((Control)Button_CLIENT).Visible = true;
					((Control)Button2121).Visible = true;
					((Control)Button_SOLDER_CREDIT).Visible = true;
					((Control)Button_SOLDER_PRINTER).Width = 186;
					((Control)Button_SOLDER_NOT_PRINTER).Width = 90;
				}
				try
				{
					string text = Text_THEME.Text;
					string[] source = text.Split(new char[1] { ';' });
					if (source.Count() == 3)
					{
						ColorConverter colorConverter = new ColorConverter();
						Color backColor = (Color)colorConverter.ConvertFromString(Text_THEME.Text);
						((TextBoxBase)Text_THEME).BackColor = backColor;
						((Control)Panel33).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label4).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label5).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label7).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label8).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label2).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label9).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label11).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label12).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label16).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label17).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label19).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label20).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label6).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label27).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label28).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label29).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label_TOP).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label_LEFT).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label_BOTTOM).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Label_RIGHT).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((ButtonBase)Button_SOLDER_PRINTER).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((Control)Panel2).BackColor = ((TextBoxBase)Text_THEME).BackColor;
						((TextBoxBase)Text_TOTAL_NET).BackColor = ((TextBoxBase)Text_THEME).BackColor;
					}
					else
					{
						Text_THEME.Text = "22; 106; 238";
						ColorConverter colorConverter2 = new ColorConverter();
						Color backColor2 = (Color)colorConverter2.ConvertFromString(Text_THEME.Text);
						((TextBoxBase)Text_THEME).BackColor = backColor2;
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
				Module1.da1 = new MySqlDataAdapter("select * from TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + " order by ID asc", Module1.cn_SQL);
				Module1.dt1 = new DataTable();
				Module1.dt1.Clear();
				((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
				DataGridView1.DataSource = Module1.dt1;
				CREATION_ACCES();
				CREATION_RACCOURCIES();
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				if (Conversion.Val(Text_TOTAL_NET.Text) >= 0.0)
				{
					((ButtonBase)Button_OPERATION).Text = "VENTE";
					((ButtonBase)Button_OPERATION).Image = Picture_SMILE.Image;
				}
				else if (Conversion.Val(Text_TOTAL_NET.Text) < 0.0)
				{
					((ButtonBase)Button_OPERATION).Text = "RETOUR";
					((ButtonBase)Button_OPERATION).Image = Picture_TRISTE.Image;
				}
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
				tabControl.ItemSize = itemSize;
				TabControl2.SizeMode = (TabSizeMode)2;
				TabControl tabControl2 = TabControl2;
				itemSize = new Size((int)Math.Round((double)((Control)TabControl2).Width / (double)TabControl2.TabCount - 4.0), 30);
				tabControl2.ItemSize = itemSize;
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable2.Clear();
				val2 = new MySqlDataAdapter("select  FAMILLE from TABLE_FAMILLES   order by Ordre,Famille asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				((Control)FlowLayoutPanel1).Controls.Clear();
				int num11 = dataTable2.Rows.Count - 1;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num4 = num11;
					if (num13 > num4)
					{
						break;
					}
					Button val3 = new Button();
					((ButtonBase)val3).Text = dataTable2.Rows[num12]["Famille"].ToString();
					Padding margin = new Padding(0, 0, 0, 0);
					((Control)val3).Margin = margin;
					((ButtonBase)val3).FlatStyle = (FlatStyle)0;
					((Control)val3).Width = 116;
					((Control)val3).Height = 40;
					((ButtonBase)val3).UseCompatibleTextRendering = true;
					((Control)val3).Cursor = Cursors.Hand;
					((Control)val3).Font = new Font("Segoe UI", 10f, (FontStyle)1);
					try
					{
						string htmlColor = List_COLOR.Items[num12].ToString();
						((ButtonBase)val3).BackColor = ColorTranslator.FromHtml(htmlColor);
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
					((Control)val3).ForeColor = ReadableFamilyCaptionColor(((Control)val3).BackColor);
					((Control)val3).Click += FAM_click;
					((Control)FlowLayoutPanel1).Controls.Add((Control)(object)val3);
					num12++;
				}
				dataTable2.Clear();
				val2 = new MySqlDataAdapter("select  Famille   from TABLE_FAMILLES     Where     TYPE = 'IMAGE'          order by Ordre,Famille asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				((Control)FlowLayoutPanel2).Controls.Clear();
				int num14 = dataTable2.Rows.Count - 1;
				int num15 = 0;
				while (true)
				{
					int num16 = num15;
					int num4 = num14;
					if (num16 > num4)
					{
						break;
					}
					Button val4 = new Button();
					((ButtonBase)val4).Text = dataTable2.Rows[num15]["Famille"].ToString();
					Padding margin = new Padding(0, 0, 0, 0);
					((Control)val4).Margin = margin;
					((ButtonBase)val4).FlatStyle = (FlatStyle)0;
					((Control)val4).Width = 116;
					((Control)val4).Height = 40;
					((ButtonBase)val4).UseCompatibleTextRendering = true;
					((Control)val4).Cursor = Cursors.Hand;
					((Control)val4).Font = new Font("Segoe UI", 9f, (FontStyle)1);
					string htmlColor2 = List_COLOR.Items[num15].ToString();
					((ButtonBase)val4).BackColor = ColorTranslator.FromHtml(htmlColor2);
					((Control)val4).ForeColor = ReadableFamilyCaptionColor(((Control)val4).BackColor);
					((Control)val4).Click += FAM2_click;
					((Control)FlowLayoutPanel2).Controls.Add((Control)(object)val4);
					num15++;
				}
				dataTable2.Clear();
				dataTable2 = null;
				DataGridView100.AutoGenerateColumns = false;
				DataGridView100.RowTemplate.Height = 30;
				DataGridView100.DataSource = dt_LA;
				DataGridView100.BackgroundColor = Color.White;
				DataGridView100.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView100.EditMode = (DataGridViewEditMode)4;
				DataGridView100.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView100.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				// Do not freeze product-list captions at 30px after binding.
				DataGridView100.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
				DataGridView100.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				DataGridView100.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView100.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				ApplyProductListSelectionContrast();
				DataGridView100.RowHeadersWidth = 22;
				_effacer_article_attributions();
				((Control)Label_QTE).BackColor = Color.White;
				Label_QTE.Text = Conversions.ToString(1);
				if (Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/afficher_ecran_pub.sni")))
				{
					((Component)(object)MyProject.Forms.FormDialog_AFFICHEUR_2).Dispose();
					((Control)MyProject.Forms.FormDialog_AFFICHEUR_2).Show();
					((Control)MyProject.Forms.FormDialog_AFFICHEUR_2).Left = Screen.PrimaryScreen.WorkingArea.Width;
					((Control)MyProject.Forms.FormDialog_AFFICHEUR_2).Top = 0;
					((Control)MyProject.Forms.FormDialog_AFFICHEUR_2).Height = 600;
					((Control)MyProject.Forms.FormDialog_AFFICHEUR_2).Width = 810;
					((Form)MyProject.Forms.FormDialog_AFFICHEUR_2).WindowState = (FormWindowState)2;
				}
				((Control)Text_CODE).Focus();
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
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val5 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex4.ToString()), "\r\n"), "Ligne : "), fileLineNumber3), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	public void FAM_click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		try
		{
			dt_LA.Clear();
			da_LA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select      *     from      TABLE_ARTICLES        WHERE      Famille =  '", NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)), "'        order by Article asc")), Module1.cn_SQL);
			((DbDataAdapter)(object)da_LA).Fill(dt_LA);
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

	private void Button5_Click(object sender, EventArgs e)
	{
	}

	public void FAM2_click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Family(), Module1.cn_SQL);
				val.SelectCommand.Parameters.AddWithValue("@family", Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)));
				((DbDataAdapter)(object)val).Fill(dataTable);
				((Control)FlowLayout_ARTICLES).Controls.Clear();
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
					Bitmap articleImage = LOGICA.Infrastructure.Checkout.CheckoutArticleImageLoader.Load(
						Module1._CHEMIN_FOLDER + "\\bd\\images", dataTable.Rows[num2]["Images"].ToString());
					if (articleImage == null)
					{
						num2++;
						continue;
					}
					Button_RJ_ARTICLE button_RJ_ARTICLE = new Button_RJ_ARTICLE();
					button_RJ_ARTICLE._COLOR_PRIX = ((TextBoxBase)Text_THEME).BackColor;
					((Control)button_RJ_ARTICLE).Name = "Button_ARTICLE_" + Conversions.ToString(num2);
					((ButtonBase)button_RJ_ARTICLE).Text = dataTable.Rows[num2]["Article"].ToString();
					((Control)button_RJ_ARTICLE).Tag = LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileSelectionService.TagFor(dataTable.Rows[num2]);
					button_RJ_ARTICLE._PRIX = Strings.FormatNumber(dataTable.Rows[num2]["PRIX_V_1"].ToString());
					button_RJ_ARTICLE._BackgroundColor = Color.White;
					button_RJ_ARTICLE._BorderColor = ((TextBoxBase)Text_THEME).BackColor;
					button_RJ_ARTICLE._BorderRadius = 8;
					button_RJ_ARTICLE._BorderSize = 2m;
					button_RJ_ARTICLE._TextColor = Color.Black;
					((Control)button_RJ_ARTICLE).Cursor = Cursors.Hand;
					((ButtonBase)button_RJ_ARTICLE).FlatStyle = (FlatStyle)2;
					((Control)button_RJ_ARTICLE).Font = new Font("Segoe UI", 9f, (FontStyle)1);
					((Control)button_RJ_ARTICLE).ForeColor = Color.Black;
					((ButtonBase)button_RJ_ARTICLE).Image = (Image)articleImage;
					((ButtonBase)button_RJ_ARTICLE).ImageAlign = (ContentAlignment)2;
					Padding margin = new Padding(2, 2, 0, 0);
					((Control)button_RJ_ARTICLE).Margin = margin;
					((Control)button_RJ_ARTICLE).Width = 127;
					((Control)button_RJ_ARTICLE).Height = 117;
					((ButtonBase)button_RJ_ARTICLE).TextAlign = (ContentAlignment)512;
					((ButtonBase)button_RJ_ARTICLE).TextImageRelation = (TextImageRelation)1;
					((ButtonBase)button_RJ_ARTICLE).UseVisualStyleBackColor = false;
					((Control)button_RJ_ARTICLE).Click += B_article2_click;
					((Control)FlowLayout_ARTICLES).Controls.Add((Control)(object)button_RJ_ARTICLE);
					num2++;
				}
				((Control)Text_CODE).Focus();
				((ScrollBar)vScrollBar1).Minimum = 0;
				((ScrollBar)vScrollBar1).Maximum = ((ScrollableControl)FlowLayout_ARTICLES).DisplayRectangle.Height;
				((ScrollBar)vScrollBar1).LargeChange = (int)Math.Round((double)((ScrollBar)vScrollBar1).Maximum / (double)((Control)vScrollBar1).Height + (double)((Control)FlowLayout_ARTICLES).Height);
				((ScrollBar)vScrollBar1).SmallChange = 15;
				((ScrollBar)vScrollBar1).Value = Math.Abs(((ScrollableControl)FlowLayout_ARTICLES).AutoScrollPosition.Y);
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

	private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
		FlowLayoutPanel flowLayout_ARTICLES = FlowLayout_ARTICLES;
		Point autoScrollPosition = new Point(0, ((ScrollBar)vScrollBar1).Value);
		((ScrollableControl)flowLayout_ARTICLES).AutoScrollPosition = autoScrollPosition;
		Application.DoEvents();
	}

	public void B_article2_click(object sender, EventArgs e)
	{
		try
		{
			object imageTag = NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null);
			LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference imageArticle = imageTag as LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference;
			Text_CODE.Text = imageArticle == null ? Conversions.ToString(imageTag) : imageArticle.Code;
			Button_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	public void Button244_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		try
		{
			MyProject.Forms.FormDialog_MSGBOX_YES_NO.Label1.Text = "Voulez-vous vraiment quitter ?";
			((Form)MyProject.Forms.FormDialog_MSGBOX_YES_NO).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)MyProject.Forms.FormDialog_MSGBOX_YES_NO).Tag, "oui", TextCompare: false))
			{
				File.WriteAllText(Application.StartupPath + "/splitterdistance_v.sni", Conversions.ToString(SplitContainer2.SplitterDistance));
				Module1.dt1.Clear();
				Module1.dt_find.Clear();
				dt_LA.Clear();
				((Form)MyProject.Forms.Form_1_LOGIN).Close();
				((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
				((Control)MyProject.Forms.Form_1_LOGIN).Show();
				if ((Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0) | (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0))
				{
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).BringToFront();
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).Show();
				}
				else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
				{
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).BringToFront();
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).Show();
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




	private System.Collections.Generic.IEnumerable<LOGICA.ApplicationLayer.Checkout.StockValidationRow> ReadStockValidationRows()
	{
		checked
		{
			int lastRow = Module1.dt1.Rows.Count - 1;
			int rowIndex = 0;
			while (true)
			{
				if (rowIndex > lastRow)
				{
					break;
				}
				yield return new LOGICA.ApplicationLayer.Checkout.StockValidationRow
				{
					ArticleCode = Module1.dt1.Rows[rowIndex]["Code"],
					ReadQuantity = () => Module1.dt1.Rows[rowIndex]["Qté"]
				};
				rowIndex++;
			}
		}
	}

	private System.Collections.Generic.IEnumerable<LOGICA.ApplicationLayer.Checkout.CheckoutStockLine> ReadCheckoutStock()
	{
		checked
		{
			if (Check_STOCK.Checked)
			{
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
					yield return new LOGICA.ApplicationLayer.Checkout.CheckoutStockLine
					{
						TicketNumber = _N_TICKET_SOLDER,
						ArticleId = DataGridView1.Rows[num6].Cells["ID_ARTICLE"].Value,
						ArticleCode = DataGridView1.Rows[num6].Cells["Code"].Value,
						ArticleName = DataGridView1.Rows[num6].Cells["Article"].Value,
						BasketQuantity = DataGridView1.Rows[num6].Cells["Qté"].Value
					};
					num6++;
				}
			}
		}
	}


	private string ReadCheckoutPaymentModes()
	{
		return LOGICA.ApplicationLayer.Checkout.CheckoutPaymentModeService.Read(
			() => ((ButtonBase)Button_OPERATION).Text,
			() => Check_ACCES_MODEP.Checked,
			() => MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count,
			index => MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[index].Cells["MODE_P"].Value,
			LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutPaymentModeSemantics.Instance);
	}

	private System.Collections.Generic.IEnumerable<LOGICA.ApplicationLayer.Checkout.TicketPaymentWrite> ReadCheckoutPayments(DateTime dateTime)
	{
		return LOGICA.ApplicationLayer.Checkout.CheckoutPaymentReadService.Read(
			() => ((ButtonBase)Button_OPERATION).Text,
			() => new LOGICA.ApplicationLayer.Checkout.TicketPaymentContext
			{
				TicketId = Text_ID_TICKET.Text,
				TicketNumber = _N_TICKET_SOLDER,
				SaleDate = dateTime,
				Cashier = ((ButtonBase)Button_CAISSIER).Text,
				ClientId = Button_CLIENT._ID_Button,
				ClientCode = Button_CLIENT._CODE_Button,
				ClientName = ((ButtonBase)Button_CLIENT).Text,
				Workstation = MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text,
				Operation = ((ButtonBase)Button_OPERATION).Text,
				Remark = MyProject.Forms.FormDialog_calc.Text_REMARQUE.Text
			},
			() => Check_ACCES_MODEP.Checked,
			() => MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count,
			index => MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[index].Cells["PAYER"].Value,
			index => MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[index].Cells["MODE_P"].Value,
			() => Text_TOTAL_NET.Text,
			() => ((ButtonBase)MyProject.Forms.FormDialog_calc.Button_RESTE).Text,
			LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutPaymentReadSemantics.Instance);
	}

	private void Button_Click(object sender, EventArgs e)
	{
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_1931: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Expected Obj, but got Unknown
		//IL_208f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2096: Expected Obj, but got Unknown
		//IL_1b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa7: Invalid comparison between Unknown and I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Invalid comparison between Unknown and I4
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (LOGICA.Domain.CheckoutAmountGuards.IsNegativeSale(((ButtonBase)Button_OPERATION).Text, Text_TOTAL_NET.Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					MessageBox.Show("Si le Type d'opération (VENTE), le total doit étre Positif", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (LOGICA.Domain.CheckoutAmountGuards.IsPositiveReturn(((ButtonBase)Button_OPERATION).Text, Text_TOTAL_NET.Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					MessageBox.Show("Si le Type d'opération (RETOUR), le total doit étre Négatif", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (Check_CHOIX_VENDEUR.Checked && LOGICA.Domain.CheckoutSelectionRules.IsMissing(((ButtonBase)Button_VENDEUR).Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					((Form)MyProject.Forms.Form_5_VENDEURS_LISTE).ShowDialog();
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (Check_CHOIX_CLIENT.Checked && LOGICA.Domain.CheckoutSelectionRules.IsMissing(((ButtonBase)Button_CLIENT).Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
					((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_SOLDER_CREDIT", TextCompare: false) && LOGICA.Domain.CheckoutSelectionRules.IsMissing(((ButtonBase)Button_CLIENT).Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
					((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				try
				{
					Module1.cn_SQL.Open();
					Module1.cn_SQL.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					Interaction.MsgBox("ERROR CONNEXION AVEC LA BD ." + ex2.Message);
					try
					{
						string text = Strings.Format(DateTime.Now, "ddMMyyHHmmssfff");
						Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val).Save(Application.StartupPath + "\\tchak\\" + text, ImageFormat.Jpeg);
						val = null;
						string right = "ERROR CONNEXION AVEC LA BD | ";
						File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
					ProjectData.ClearProjectError();
					return;
				}
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				if (LOGICA.Domain.BasketTotalConsistency.AreDifferent(((IEnumerable)DataGridView1.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow t) => Convert.ToDecimal(RuntimeHelpers.GetObjectValue(t.Cells["TOTAL_NET"].Value))), Text_TOTAL_NET.Text, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance))
				{
					MessageBox.Show("il y a une erreur critique\r\nLe Total Net est différent avec le total des lignes de commande\r\nmerci d'Actualiser le panier ou redémarrer l'application", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0 && Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("BLOCAGE_STOCK_INSUFFISANT", false, 0).Index].SubItems[1].Text, "True", TextCompare: false) == 0)
				{
					var shortage = LOGICA.ApplicationLayer.Checkout.StockValidationService.FindFirstShortage(
						new LOGICA.Infrastructure.Checkout.MySqlStockAvailabilityLookup(Module1.cn_SQL), ReadStockValidationRows(), LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance);
					if (shortage != null)
					{
						MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("stock insuffisant de l'article -", shortage.ArticleName), "-")), "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
						return;
					}
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_SOLDER_CREDIT", TextCompare: false))
				{
					if (unchecked((int)MessageBox.Show("Voulez-vous Vraiment Valider le Crédit pour (" + ((ButtonBase)Button_CLIENT).Text + ")", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) != 1)
					{
						NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
						return;
					}
					if (Conversions.ToDouble(Text_TOTAL_NET.Text) >= 0.0)
					{
						((ButtonBase)Button_OPERATION).Text = "CREDIT";
					}
					else if (Conversions.ToDouble(Text_TOTAL_NET.Text) < 0.0)
					{
						((ButtonBase)Button_OPERATION).Text = "RETOUR CREDIT";
					}
				}
				else
				{
					if (Check_ACCES_MODEP.Checked)
					{
						((Form)MyProject.Forms.FormDialog_calc).ShowDialog();
					}
					if (Module1._quittersolder)
					{
						NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
						return;
					}
					if ((Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0) & !Check_ACCES_MODEP.Checked)
					{
						((ButtonBase)Button_OPERATION).Text = "RETOUR REMBOURSEMENT";
					}
				}
				MySqlCommand val4 = new MySqlCommand();
				var checkoutBoundary = new LOGICA.Infrastructure.Checkout.MySqlCheckoutTransactionBoundary(Module1.cn_SQL, val4);
				LOGICA.ApplicationLayer.Checkout.CheckoutTransactionBoundaryService.Begin(checkoutBoundary);
				_N_TICKET_SOLDER = LOGICA.ApplicationLayer.Checkout.CheckoutTicketSequenceService.ReadCurrent(
					new LOGICA.Infrastructure.Checkout.MySqlCheckoutTicketSequenceReader(val4, Module1.cn_SQL),
					LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutTicketSequenceSemantics.Instance);
				Text_ID_TICKET.Text = Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text;
				try
				{
					string text2 = "";
					DateTime dateTime = default(DateTime);
					LOGICA.ApplicationLayer.Checkout.CheckoutTransactionFinalizationService.PostAndFinalize(
						new LOGICA.Infrastructure.Checkout.MySqlCheckoutPostingStore(val4, Module1.cn_SQL),
						new LOGICA.ApplicationLayer.Checkout.CheckoutPostingInput
						{
							ReadStock = () => ReadCheckoutStock(),
							ReadHeader = () =>
							{
								text2 = ReadCheckoutPaymentModes();
								dateTime = Conversions.ToDate(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).AddHours(Conversions.ToDouble("-" + Text_HEURE_RETARD.Text));
								return new LOGICA.ApplicationLayer.Checkout.TicketHeaderRecord
								{
									TicketId = Text_ID_TICKET.Text,
									TicketNumber = _N_TICKET_SOLDER,
									SaleDate = dateTime,
									Cashier = ((ButtonBase)Button_CAISSIER).Text,
									ClientId = Button_CLIENT._ID_Button,
									ClientCode = Button_CLIENT._CODE_Button,
									ClientName = ((ButtonBase)Button_CLIENT).Text,
									Workstation = MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text,
									TotalText = Text_TOTAL_NET.Text,
									Operation = ((ButtonBase)Button_OPERATION).Text
								};
							},
							ReadJournal = () => new LOGICA.ApplicationLayer.Checkout.TicketJournalRecord
							{
								TicketId = Text_ID_TICKET.Text,
								TicketNumber = _N_TICKET_SOLDER,
								SaleDate = dateTime,
								Workstation = MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text,
								Cashier = ((ButtonBase)Button_CAISSIER).Text,
								Seller = ((ButtonBase)Button_VENDEUR).Text,
								ClientId = Button_CLIENT._ID_Button,
								ClientCode = Button_CLIENT._CODE_Button,
								ClientName = ((ButtonBase)Button_CLIENT).Text,
								Operation = ((ButtonBase)Button_OPERATION).Text,
								PriceType = ((ButtonBase)Button_PRIX).Text,
								PaymentModes = text2
							},
							ReadPayments = () => ReadCheckoutPayments(dateTime),
							Print = () => CREATION_IMPRESSION(RuntimeHelpers.GetObjectValue(sender)),
							ReadCompletion = () => new LOGICA.ApplicationLayer.Checkout.CheckoutCompletionRecord
							{
								Workstation = MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text,
								TicketNumber = _N_TICKET_SOLDER
							}
						}, checkoutBoundary);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
					StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
					int fileLineNumber2 = frame2.GetFileLineNumber();
					LOGICA.ApplicationLayer.Checkout.CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);
					Interaction.MsgBox(ex6.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
					try
					{
						string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
						Bitmap val7 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val8 = Graphics.FromImage((Image)(object)val7);
						val8.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val7).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val7 = null;
						string right2 = "ERROR | ";
						File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text3 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
				Module1.dt1.Clear();
				Module1.da1 = new MySqlDataAdapter("select * from TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + " order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
				DataGridView1.DataSource = Module1.dt1;
				((ButtonBase)Button_VENDEUR).Text = "";
				if (((Control)Button_CLIENT).Visible)
				{
					((ButtonBase)Button_CLIENT).Text = "";
					Button_CLIENT._CODE_Button = "";
					Button_CLIENT._ID_Button = "";
				}
				if (Check_ACCES_RFID.Checked)
				{
					Button_LOCK_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				((ButtonBase)Button_PRIX).Text = "PRIX_1";
				((ButtonBase)Button_PRIX).Image = Picture_FLECH_BAS.Image;
				((ButtonBase)Button_PRIX).BackColor = Color.Transparent;
				if (Check_ACCES_MODEP.Checked && Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					((Control)Panel_RAPPEL).Visible = true;
					((ButtonBase)Button_RAPPEL_TOTAL).Text = "";
					((ButtonBase)Button_RAPPEL_MODE_P).Text = "";
					((ButtonBase)Button_RAPPEL_PAYER).Text = "";
					((ButtonBase)Button_RAPPEL_RENDU).Text = "";
					((ButtonBase)Button_RAPPEL_TOTAL).Text = "TOTAL : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(MyProject.Forms.FormDialog_calc.Text_TOTAL_NET.Text))) + " DH";
					((ButtonBase)Button_RAPPEL_MODE_P).Text = Conversions.ToString(Operators.ConcatenateObject("MODE P:", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value));
					((ButtonBase)Button_RAPPEL_PAYER).Text = "PAYER :" + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value))) + " DH";
					((ButtonBase)Button_RAPPEL_RENDU).Text = "RENDU :" + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value))) + " DH";
					if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.RowCount == 2)
					{
						Button button_RAPPEL_MODE_P = Button_RAPPEL_MODE_P;
						((ButtonBase)button_RAPPEL_MODE_P).Text = Conversions.ToString(Operators.AddObject(((ButtonBase)button_RAPPEL_MODE_P).Text, Operators.ConcatenateObject(" | ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[1].Cells["MODE_P"].Value)));
						button_RAPPEL_MODE_P = Button_RAPPEL_PAYER;
						((ButtonBase)button_RAPPEL_MODE_P).Text = ((ButtonBase)button_RAPPEL_MODE_P).Text + " | " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[1].Cells["PAYER"].Value))) + " DH";
						button_RAPPEL_MODE_P = Button_RAPPEL_RENDU;
						((ButtonBase)button_RAPPEL_MODE_P).Text = ((ButtonBase)button_RAPPEL_MODE_P).Text + " | " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[1].Cells["RENDU"].Value))) + " DH";
					}
				}
				((ButtonBase)Button_OPERATION).Text = "VENTE";
				((ButtonBase)Button_OPERATION).Image = Picture_SMILE.Image;
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				_effacer_article_attributions();
				((Control)Label_QTE).BackColor = Color.White;
				Label_QTE.Text = Conversions.ToString(1);
				((Control)Text_CODE).Focus();
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_SOLDER_CREDIT", TextCompare: false) && unchecked((int)MessageBox.Show("Voulez-vous effectuer un Réglement ??", "", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) == 1)
				{
					((Component)(object)MyProject.Forms.Form_5_CLIENTS_REGLE).Dispose();
					((Form)MyProject.Forms.Form_5_CLIENTS_REGLE).ShowDialog();
				}
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				StackTrace stackTrace3 = new StackTrace(ex10, fNeedFileInfo: true);
				StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
				int fileLineNumber3 = frame3.GetFileLineNumber();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex10.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber3) + "\r\n");
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val9 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val10 = Graphics.FromImage((Image)(object)val9);
					val10.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val9).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val9 = null;
					string right3 = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right3), " | "), ex10.ToString()), "\r\n"), "Ligne : "), fileLineNumber3), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CL_FR_3C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got Unknown
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Expected Obj, but got Unknown
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0271: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)Picture_LOGO).Left, ((Control)Picture_LOGO).Top, ((Control)Picture_LOGO).Width, ((Control)Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
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
					text = Strings.LSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = Module1.dt1.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"]), Module1.dt1.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					if (CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count == 1)
						{
							_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value), 6)))) + " DH\r\n";
							_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value), 6)))) + " DH\r\n";
						}
						else
						{
							int num11 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								int num5 = num11;
								if (num13 <= num5)
								{
									if (Operators.ConditionalCompareObjectLess(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value, 0, TextCompare: false))
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
									}
									else
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
										_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value), 6)))) + " DH\r\n";
									}
									num12++;
									continue;
								}
								break;
							}
						}
					}
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					_string = _string + "* ID        : " + Button_CLIENT._ID_Button + "\r\n";
				}
				_string = _string + "* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				if (CheckBox_AFFICHER_N_TICKET.Checked)
				{
					_string = _string + "* N° TICKET : " + _N_TICKET_SOLDER + "\r\n";
				}
				_string += Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
				SizeF sizeF = e.Graphics.MeasureString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				if (!CheckBox_AFFICHER_CODEBARRE.Checked)
				{
					return;
				}
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics2 = e.Graphics;
					Bitmap val = barcodeImage;
					rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics2.DrawImage((Image)(object)val, rectangle);
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
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR CL : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR CL  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CL_FR_4C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got Unknown
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected Obj, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected Obj, but got Unknown
		//IL_10e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected Obj, but got Unknown
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)Picture_LOGO).Left, ((Control)Picture_LOGO).Top, ((Control)Picture_LOGO).Width, ((Control)Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Désignation           Qté     Prix    Total  ", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + 7), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + 15), new StringFormat((StringFormatFlags)8192));
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
					e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = Module1.dt1.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"]), Module1.dt1.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					if (CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count == 1)
						{
							_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value), 6)))) + " DH\r\n";
							_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value), 6)))) + " DH\r\n";
						}
						else
						{
							int num11 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								int num5 = num11;
								if (num13 <= num5)
								{
									if (Operators.ConditionalCompareObjectLess(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value, 0, TextCompare: false))
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
									}
									else
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
										_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value), 6)))) + " DH\r\n";
									}
									num12++;
									continue;
								}
								break;
							}
						}
					}
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					_string = _string + "* ID        : " + Button_CLIENT._ID_Button + "\r\n";
				}
				_string = _string + "* N° TICKET : " + _N_TICKET_SOLDER + "\r\n";
				_string = _string + "* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				_string += "\r\n";
				_string += Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)8192));
				SizeF sizeF = e.Graphics.MeasureString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				if (!CheckBox_AFFICHER_CODEBARRE.Checked)
				{
					return;
				}
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics2 = e.Graphics;
					Bitmap val = barcodeImage;
					rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics2.DrawImage((Image)(object)val, rectangle);
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
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR CL : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR CL  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CL_FR_2L_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got Unknown
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected Obj, but got Unknown
		//IL_129c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Expected Obj, but got Unknown
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05ac: Expected Obj, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Expected Obj, but got Unknown
		//IL_0eb8: Expected Obj, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected Obj, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected Obj, but got Unknown
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)Picture_LOGO).Left, ((Control)Picture_LOGO).Top, ((Control)Picture_LOGO).Width, ((Control)Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
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
						e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
						num += 3;
					}
					else
					{
						text = Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 33) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8) + "\r\n" + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["CODE"].Value), 29) + Strings.RSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 4) + "x" + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Prix_V"].Value))), 8);
						e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
						num += 2;
					}
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = Module1.dt1.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"]), Module1.dt1.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					if (CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count == 1)
						{
							_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value), 6)))) + " DH\r\n";
							_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value), 6)))) + " DH\r\n";
						}
						else
						{
							int num11 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								int num5 = num11;
								if (num13 <= num5)
								{
									if (Operators.ConditionalCompareObjectLess(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value, 0, TextCompare: false))
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
									}
									else
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
										_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value), 6)))) + " DH\r\n";
									}
									num12++;
									continue;
								}
								break;
							}
						}
					}
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					_string = _string + "* ID        : " + Button_CLIENT._ID_Button + "\r\n";
				}
				_string = _string + "* N° TICKET : " + _N_TICKET_SOLDER + "\r\n";
				_string = _string + "* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				_string += "\r\n";
				_string += Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
				SizeF sizeF = e.Graphics.MeasureString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				if (!CheckBox_AFFICHER_CODEBARRE.Checked)
				{
					return;
				}
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics2 = e.Graphics;
					Bitmap val = barcodeImage;
					rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics2.DrawImage((Image)(object)val, rectangle);
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
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR CL : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR CL  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CL_AR_4C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got Unknown
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected Obj, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected Obj, but got Unknown
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected Obj, but got Unknown
		//IL_0cab: Expected Obj, but got Unknown
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected Obj, but got Unknown
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected Obj, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)Picture_LOGO).Left, ((Control)Picture_LOGO).Top, ((Control)Picture_LOGO).Width, ((Control)Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("كمية |البضاعة              |الثمن  |المجموع              ", new Font("Kawkab Mono", 6f, (FontStyle)0), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + 10), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + 18), new StringFormat((StringFormatFlags)8192));
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
					e.Graphics.DrawString(text, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)1));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("المجموع : " + Strings.LSet(Text_TOTAL_NET.Text + " درهم", 15), new Font("Kawkab Mono", 11f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* مجموع الكمية : " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = Module1.dt1.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"]), Module1.dt1.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* تخفيض    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					if (CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						if (MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count == 1)
						{
							_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["PAYER"].Value), 6)))) + " DH\r\n";
							_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[0].Cells["RENDU"].Value), 6)))) + " DH\r\n";
						}
						else
						{
							int num11 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								int num5 = num11;
								if (num13 <= num5)
								{
									if (Operators.ConditionalCompareObjectLess(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value, 0, TextCompare: false))
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
									}
									else
									{
										_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6)))) + " DH\r\n";
										_string = _string + Strings.LSet("* RENDU", 11) + " : " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value), 6)))) + " DH\r\n";
									}
									num12++;
									continue;
								}
								break;
							}
						}
					}
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* الزبون    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					_string = _string + "* الرقم     : " + Button_CLIENT._ID_Button + "\r\n";
				}
				_string = _string + "* رقم الفاتورة : " + _N_TICKET_SOLDER + "\r\n";
				_string = _string + "* البائع       : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				_string += "\r\n";
				_string += Text_pied.Text;
				_string += "\r\n";
				_string = _string + "         " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)1));
				SizeF sizeF = e.Graphics.MeasureString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				if (!CheckBox_AFFICHER_CODEBARRE.Checked)
				{
					return;
				}
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics2 = e.Graphics;
					Bitmap val = barcodeImage;
					rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics2.DrawImage((Image)(object)val, rectangle);
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
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR CL : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR CL  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CL_AR_3C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Expected Obj, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected Obj, but got Unknown
		//IL_0990: Expected Obj, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected Obj, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)Picture_LOGO).Left, ((Control)Picture_LOGO).Top, ((Control)Picture_LOGO).Width, ((Control)Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("كمية |البضاعة                      |المجموع              ", new Font("Kawkab Mono", 6f, (FontStyle)0), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + 10), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + 18), new StringFormat((StringFormatFlags)8192));
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
					e.Graphics.DrawString(text, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)1));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("المجموع : " + Strings.LSet(Text_TOTAL_NET.Text + " درهم", 15), new Font("Kawkab Mono", 11f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("-------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* مجموع الكمية : " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = Module1.dt1.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"]), Module1.dt1.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(Module1.dt1.Rows[num9]["PRIX_V"], Module1.dt1.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* تخفيض    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					if (CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["PAYER"].Value), 6) + " DH\r\n";
								_string = _string + Strings.LSet("* RENDU", 11) + " : " + Strings.RSet(Conversions.ToString(MyProject.Forms.FormDialog_calc.DataGridView_CALC.Rows[num12].Cells["RENDU"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* الزبون    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					_string = _string + "* الرقم     : " + Button_CLIENT._ID_Button + "\r\n";
				}
				_string = _string + "* رقم الفاتورة : " + _N_TICKET_SOLDER + "\r\n";
				_string = _string + "* البائع       : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				_string += "\r\n";
				_string += Text_pied.Text;
				_string += "\r\n";
				_string = _string + "         " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)1));
				SizeF sizeF = e.Graphics.MeasureString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				if (!CheckBox_AFFICHER_CODEBARRE.Checked)
				{
					return;
				}
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics2 = e.Graphics;
					Bitmap val = barcodeImage;
					rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics2.DrawImage((Image)(object)val, rectangle);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message);
					try
					{
						string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
						string right = "ERROR | ";
						File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text3 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR CL : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR CL  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
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
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = ((ButtonBase)Button_OPERATION).Text;
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
					text2 = Strings.LSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				text = "";
				text += "\r\n";
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) != 0)
				{
					text = text + "* CLIENT    : " + ((ButtonBase)Button_CLIENT).Text + "\r\n";
					text = text + "* ID        : " + Button_CLIENT._ID_Button + "\r\n";
				}
				text = text + "* N° TICKET : " + _N_TICKET_SOLDER + "\r\n";
				text = text + "* CAISSIER  : " + ((ButtonBase)Button_CAISSIER).Text + "." + ((ButtonBase)Button_VENDEUR).Text + "\r\n";
				text += "\r\n";
				text += Text_pied.Text;
				text += "\r\n";
				text = text + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "\r\n";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
				SizeF sizeF = e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1));
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				try
				{
					QRimg = (Image)(object)QREncoder.Encode(Text_ID_TICKET.Text);
					QRbitmap = new Bitmap(QRimg);
					barcodeImage = QRbitmap;
					int x = 115;
					int y = (int)Math.Round((float)(((Control)Panel_LOGO).Height + num * 16 + 50) + sizeF.Height);
					Graphics graphics = e.Graphics;
					Bitmap val = barcodeImage;
					Rectangle rectangle = new Rectangle(x, y, ((Image)barcodeImage).Width, ((Image)barcodeImage).Height);
					graphics.DrawImage((Image)(object)val, rectangle);
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
						Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
						((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
						val2 = null;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace2 = new StackTrace(ex6, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR BON_RETOUR : " + ex6.Message);
				try
				{
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERREUR BON_RETOUR  | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex6.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Text_TTC_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Text_TTC_TextChanged(object sender, EventArgs e)
	{
	}

	public void Text_TOTAL_NET_Click(object sender, EventArgs e)
	{
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		checked
		{
			try
			{
				double num = 0.0;
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlCommand val = new MySqlCommand("select sum(TOTAL_NET) as n     from      TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "   ", Module1.cn_SQL);
				num = ((val.ExecuteScalar() != DBNull.Value) ? Conversions.ToDouble(val.ExecuteScalar()) : 0.0);
				Module1.cn_SQL.Close();
				Text_TOTAL_NET.Text = Strings.FormatNumber(num);
				decimal num2 = (from DataGridViewRow row in (IEnumerable)DataGridView1.Rows
					where decimal.Compare(Conversions.ToDecimal(row.Cells["Qté"].Value), 0m) != 0
					select row).Sum([SpecialName] (DataGridViewRow row) => Conversions.ToDecimal(row.Cells["Qté"].Value));
				Label_NBR_ARTICLES.Text = Conversions.ToString(num2);
				if (Operators.CompareString(Combo_PORT.Text, "", TextCompare: false) == 0)
				{
					return;
				}
				try
				{
					SerialPort val2 = ((Computer)MyProject.Computer).Ports.OpenSerialPort(Combo_PORT.Text);
					try
					{
						val2.StopBits = (StopBits)1;
						val2.BaudRate = Conversions.ToInteger(Combo_BAUDRATE.Text);
						val2.DataBits = 8;
						val2.Parity = (Parity)0;
						val2.Handshake = (Handshake)0;
						val2.WriteLine("\r\n\r\n\r\nTOTAL: " + Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 0).ToString().PadRight(11) + "DH   ***BIENVENUE***  ");
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
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
					Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val3 = null;
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

	public void Text_CODE_Click(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE).HideSelection = false;
		((TextBoxBase)Text_CODE).SelectAll();
		NewLateBinding.LateCall(sender, null, "focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void Text_CODE_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE).BackColor = Color.Yellow;
	}

	private void Text_CODE_LostFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE).BackColor = Color.White;
		((TextBoxBase)Text_CODE).HideSelection = false;
		((TextBoxBase)Text_CODE).SelectAll();
	}

	private void Text_CODE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		try
		{
			if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
			{
				// Barcode scanners commonly terminate scans with Enter. Consume that
				// terminator once; do not forward it to a focused button or dialog.
				e.SuppressKeyPress = true;
				Button_FIND_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				((TextBoxBase)Text_CODE).HideSelection = false;
				((TextBoxBase)Text_CODE).SelectAll();
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

	private void TextTicket_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	public void _effacer_article_attributions()
	{
		Text_ID_ARTICLE.Text = "";
		Text_CODE.Text = "";
		Text_ARTICLE.Text = "";
		Text_FAMILLE.Text = "";
		Text_PRIX_A.Text = "";
		Text_PRIX_MP.Text = "";
		Text_PRIXV.Text = "";
		Text_TAUX_TVA.Text = "";
		Text_PROMOTION.Text = "";
		Text_PRINTER.Text = "";
		Text_PRINTER_DUPLICATA.Text = "";
		Text_GROUPE.Text = "";
		Text_PRIX_QTE.Text = "";
		Text_PRIX_QTE_MIN.Text = "";
	}

	private void Button_FIND_Click(object sender, EventArgs e)
	{
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Text_CODE.Text.Trim(), "", TextCompare: false) == 0)
			{
				((Control)Text_CODE).Focus();
				return;
			}
			Module1.dt_find.Clear();
			Module1.da_find = new MySqlDataAdapter(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.ExactBarcode(), Module1.cn_SQL);
			Module1.da_find.SelectCommand.Parameters.AddWithValue("@code", Text_CODE.Text);
			((DbDataAdapter)(object)Module1.da_find).Fill(Module1.dt_find);
			if (Module1.dt_find.Rows.Count != 0)
			{
				Control clickedControl = sender as Control;
				LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference clickedImage = clickedControl == null
					? null : clickedControl.Tag as LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference;
				DataRow selectedArticle = clickedImage != null
					? LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileSelectionService.FindExact(Module1.dt_find, clickedImage)
					: LOGICA.ApplicationLayer.Checkout.CheckoutBarcodeSelectionService.Select(
						Module1.dt_find, delegate(DataTable matches) {
							return LOGICA.Presentation.Checkout.CheckoutBarcodeChoiceDialog.Choose(
								matches, "Prix_V_" + ((ButtonBase)Button_PRIX).Text.Remove(0, 5));
						});
				if (selectedArticle == null)
				{
					((Control)Text_CODE).Focus();
					return;
				}
				Text_ID_ARTICLE.Text = selectedArticle["ID_ARTICLE"].ToString();
				Text_CODE.Text = selectedArticle["Code"].ToString();
				Text_ARTICLE.Text = selectedArticle["Article"].ToString();
				Text_FAMILLE.Text = selectedArticle["Famille"].ToString();
				Text_PRIX_A.Text = selectedArticle["PRIX_A"].ToString();
				Text_PRIX_MP.Text = selectedArticle["PRIX_MP"].ToString();
				Text_PRIXV.Text = selectedArticle["Prix_V_" + ((ButtonBase)Button_PRIX).Text.Remove(0, 5)].ToString();
				Text_TAUX_TVA.Text = selectedArticle["TAUX_TVA"].ToString();
				Text_PROMOTION.Text = selectedArticle["PROMOTION"].ToString();
				Text_PRINTER.Text = selectedArticle["PRINTER"].ToString();
				Text_PRINTER_DUPLICATA.Text = selectedArticle["PRINTER_DUPLICATA"].ToString();
				Text_GROUPE.Text = selectedArticle["GROUPE"].ToString();
				Text_PRIX_QTE.Text = selectedArticle["PRIX_QTE"].ToString();
				Text_PRIX_QTE_MIN.Text = selectedArticle["PRIX_QTE_MIN"].ToString();
				if (Operators.CompareString(selectedArticle["FENETRE_PESAGE"].ToString(), "OUI", TextCompare: false) == 0)
				{
					MyProject.Forms.FormDialog_PESEE_BALANCE.Text_PRIX_V.Text = selectedArticle["Prix_V_" + ((ButtonBase)Button_PRIX).Text.Remove(0, 5)].ToString();
					((Form)MyProject.Forms.FormDialog_PESEE_BALANCE).ShowDialog();
					if (Module1._quitter_pesee)
					{
						return;
					}
					Module1._quitter_pesee = false;
				}
				if (Conversion.Val(selectedArticle["Prix_V_" + ((ButtonBase)Button_PRIX).Text.Remove(0, 5)].ToString()) == 0.0)
				{
					((Form)MyProject.Forms.FormDialog_PRIX_LIBRE).ShowDialog();
					Text_PRIXV.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.FormDialog_PRIX_LIBRE.Text_NUM.Text));
				}
				Button_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else
			{
				((Form)MyProject.Forms.FormDialog_ARTICLE_INCONNU).ShowDialog();
				_effacer_article_attributions();
				((Control)Label_QTE).BackColor = Color.White;
				Label_QTE.Text = Conversions.ToString(1);
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
			Module1.dt1.Clear();
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

	private void Button_GO_Click(object sender, EventArgs e)
	{
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1817: Expected Obj, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_1649: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected Obj, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a1: Expected Obj, but got Unknown
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Text_ID_ARTICLE.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -ID_ARTICLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_CODE.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CODE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Conversion.Val(Label_QTE.Text) == 0.0)
				{
					MessageBox.Show("Veuillez remplir le champ -QUANTITE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_ARTICLE.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -ARTICLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PRIX_A.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PRIX_MP.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX MP- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PRIXV.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PRIX V- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PROMOTION.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -PROMOTION- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PRIX_QTE.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ - PRIX_QTE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (Operators.CompareString(Text_PRIX_QTE_MIN.Text.Trim(), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ - QTE_MIN- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					((Control)Text_CODE).Focus();
					return;
				}
				if (((Control)Panel_RAPPEL).Visible)
				{
					((Control)Panel_RAPPEL).Visible = false;
				}
				if (Conversion.Val(Label_QTE.Text) == 0.0)
				{
					Label_QTE.Text = Conversions.ToString(1);
				}
				int num = Module1.dt1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (LOGICA.ApplicationLayer.Checkout.CheckoutBarcodeSelectionService.IsSameBasketArticle(
						Module1.dt1.Rows[num2], Text_CODE.Text, Text_ID_ARTICLE.Text,
						delegate(object left, object right) { return Operators.ConditionalCompareObjectEqual(left, right, TextCompare: false); }))
					{
						DataGridView1.CurrentCell = DataGridView1.Rows[num2].Cells[0];
						DataGridView1.Rows[num2].Selected = true;
						if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[num2]["Qté"] = Operators.AddObject(Module1.dt1.Rows[num2]["Qté"], Label_QTE.Text);
						}
						else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[num2]["Qté"] = Operators.AddObject(Module1.dt1.Rows[num2]["Qté"], Conversions.ToDouble(Label_QTE.Text) * -1.0);
						}
						if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[num2]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]), Module1.dt1.Rows[num2]["REMISE"]), 100)));
						}
						else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[num2]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]), Module1.dt1.Rows[num2]["REMISE"]), 100)));
						}
						MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
						int index = num2;
						if (Conversion.Val(Text_PRIX_QTE.Text) > 0.0)
						{
							Type? typeFromHandle = typeof(Math);
							object[] array = new object[1];
							object[] array2 = array;
							DataRow dataRow = Module1.dt1.Rows[index];
							DataRow dataRow2 = dataRow;
							string columnName = "Qté";
							array2[0] = RuntimeHelpers.GetObjectValue(dataRow2[columnName]);
							object[] array3 = array;
							object[] arguments = array3;
							bool[] array4 = new bool[1] { true };
							object value = NewLateBinding.LateGet(null, typeFromHandle, "Abs", arguments, null, null, array4);
							if (array4[0])
							{
								dataRow[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
							}
							decimal num5 = Conversions.ToDecimal(value);
							if (Convert.ToDouble(num5) >= Conversion.Val(Text_PRIX_QTE_MIN.Text))
							{
								Module1.dt1.Rows[index]["Prix_V"] = Strings.FormatNumber(Text_PRIX_QTE.Text);
								if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
								{
									Module1.dt1.Rows[index]["TOTAL_NET"] = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIX_QTE.Text), num5)) - Conversions.ToDouble(Text_PRIX_QTE.Text) * Convert.ToDouble(num5) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0);
								}
								else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
								{
									Module1.dt1.Rows[index]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIX_QTE.Text), num5)) - Conversions.ToDouble(Text_PRIX_QTE.Text) * Convert.ToDouble(num5) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0)) * -1.0;
								}
								MySqlCommandBuilder val2 = new MySqlCommandBuilder(Module1.da1);
								((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
								Module1.dt1.AcceptChanges();
							}
							else
							{
								Module1.dt1.Rows[index]["Prix_V"] = Strings.FormatNumber(Text_PRIXV.Text);
								if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
								{
									Module1.dt1.Rows[index]["TOTAL_NET"] = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), num5)) - Conversions.ToDouble(Text_PRIXV.Text) * Convert.ToDouble(num5) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0);
								}
								else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
								{
									Module1.dt1.Rows[index]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), num5)) - Conversions.ToDouble(Text_PRIXV.Text) * Convert.ToDouble(num5) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0)) * -1.0;
								}
								MySqlCommandBuilder val3 = new MySqlCommandBuilder(Module1.da1);
								((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
								Module1.dt1.AcceptChanges();
							}
						}
						_effacer_article_attributions();
						((Control)Label_QTE).BackColor = Color.White;
						Label_QTE.Text = Conversions.ToString(1);
						Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
						((Control)Text_CODE).Focus();
						return;
					}
					num2++;
				}
				int num6 = default;
				if (Module1.dt1.Rows.Count > 0)
				{
					num6 = Conversions.ToInteger(Operators.AddObject(Module1.dt1.Rows[Module1.dt1.Rows.Count - 1]["ID"], 1));
				}
				else if (Module1.dt1.Rows.Count == 0)
				{
					num6 = 1;
				}
				Module1.dt1.Rows.Add();
				int index2 = Module1.dt1.Rows.Count - 1;
				Module1.dt1.Rows[index2]["ID"] = num6;
				Module1.dt1.Rows[index2]["Dates"] = DateTime.Now.ToString("yyyy-MM-dd");
				Module1.dt1.Rows[index2]["Heure"] = DateTime.Now.ToString("HH:mm:ss");
				Module1.dt1.Rows[index2]["ID_ARTICLE"] = Text_ID_ARTICLE.Text;
				Module1.dt1.Rows[index2]["Code"] = Text_CODE.Text;
				Module1.dt1.Rows[index2]["Article"] = Text_ARTICLE.Text;
				Module1.dt1.Rows[index2]["Famille"] = Text_FAMILLE.Text;
				Module1.dt1.Rows[index2]["PRIX_A"] = Strings.FormatNumber(Text_PRIX_A.Text);
				Module1.dt1.Rows[index2]["PRIX_MP"] = Strings.FormatNumber(Text_PRIX_MP.Text);
				Module1.dt1.Rows[index2]["Prix_V"] = Strings.FormatNumber(Text_PRIXV.Text);
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[index2]["Qté"] = Label_QTE.Text;
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[index2]["Qté"] = Conversions.ToDouble(Label_QTE.Text) * -1.0;
				}
				Module1.dt1.Rows[index2]["Remise"] = Conversions.ToDecimal(Text_PROMOTION.Text);
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[index2]["TOTAL_NET"] = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), Conversions.ToDecimal(Label_QTE.Text))) - Conversions.ToDouble(Text_PRIXV.Text) * Conversions.ToDouble(Label_QTE.Text) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0);
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[index2]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), Conversions.ToDecimal(Label_QTE.Text))) - Conversions.ToDouble(Text_PRIXV.Text) * Conversions.ToDouble(Label_QTE.Text) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0)) * -1.0;
				}
				Module1.dt1.Rows[index2]["TAUX_TVA"] = Text_TAUX_TVA.Text;
				Module1.dt1.Rows[index2]["PRINTER"] = Text_PRINTER.Text;
				Module1.dt1.Rows[index2]["PRINTER_DUPLICATA"] = Text_PRINTER_DUPLICATA.Text;
				Module1.dt1.Rows[index2]["GROUPE"] = Text_GROUPE.Text;
				MySqlCommandBuilder val4 = new MySqlCommandBuilder(Module1.da1);
				((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
				Module1.dt1.AcceptChanges();
				if (Conversion.Val(Text_PRIX_QTE.Text) > 0.0)
				{
					Type? typeFromHandle2 = typeof(Math);
					object[] array3 = new object[1];
					object[] array5 = array3;
					DataRow dataRow = Module1.dt1.Rows[index2];
					DataRow dataRow3 = dataRow;
					string columnName = "Qté";
					array5[0] = RuntimeHelpers.GetObjectValue(dataRow3[columnName]);
					object[] array = array3;
					object[] arguments2 = array;
					bool[] array4 = new bool[1] { true };
					object value2 = NewLateBinding.LateGet(null, typeFromHandle2, "Abs", arguments2, null, null, array4);
					if (array4[0])
					{
						dataRow[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
					}
					decimal num7 = Conversions.ToDecimal(value2);
					if (Convert.ToDouble(num7) >= Conversion.Val(Text_PRIX_QTE_MIN.Text))
					{
						Module1.dt1.Rows[index2]["Prix_V"] = Strings.FormatNumber(Text_PRIX_QTE.Text);
						if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[index2]["TOTAL_NET"] = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIX_QTE.Text), num7)) - Conversions.ToDouble(Text_PRIX_QTE.Text) * Convert.ToDouble(num7) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0);
						}
						else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[index2]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIX_QTE.Text), num7)) - Conversions.ToDouble(Text_PRIX_QTE.Text) * Convert.ToDouble(num7) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0)) * -1.0;
						}
						MySqlCommandBuilder val5 = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
					}
					else
					{
						Module1.dt1.Rows[index2]["Prix_V"] = Strings.FormatNumber(Text_PRIXV.Text);
						if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[index2]["TOTAL_NET"] = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), num7)) - Conversions.ToDouble(Text_PRIXV.Text) * Convert.ToDouble(num7) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0);
						}
						else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
						{
							Module1.dt1.Rows[index2]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_PRIXV.Text), num7)) - Conversions.ToDouble(Text_PRIXV.Text) * Convert.ToDouble(num7) * Conversions.ToDouble(Text_PROMOTION.Text) / 100.0)) * -1.0;
						}
						MySqlCommandBuilder val6 = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
					}
				}
				_effacer_article_attributions();
				((Control)Label_QTE).BackColor = Color.White;
				Label_QTE.Text = Conversions.ToString(1);
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)Text_CODE).Focus();
				try
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells[0];
					DataGridView1.Rows[DataGridView1.Rows.Count - 1].Selected = true;
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
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Module1.dt1.Clear();
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val7 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val8 = Graphics.FromImage((Image)(object)val7);
					val8.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val7).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val7 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ProjectData.ClearProjectError();
				}
				Module1.dt1.Clear();
				Module1.da1 = new MySqlDataAdapter("select * from TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + " order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
				DataGridView1.DataSource = Module1.dt1;
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextTicket_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar))
		{
			e.Handled = true;
		}
		if (!char.IsLetter(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Label_QTE_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Label_QTE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		try
		{
			if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
			{
				// Quantity Enter returns to barcode scanning, without triggering
				// a second implicit Enter on the focused sales control.
				e.SuppressKeyPress = true;
				((Control)Text_CODE).Focus();
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

	private void Label_QTE_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Keep the original numeric/backspace/minus input, but reject a second
		// decimal separator before it can reach the checkout quantity parser.
		if ((e.KeyChar == '.' && Label_QTE.Text.IndexOf('.') >= 0)
			|| (e.KeyChar == '-' && (Label_QTE.Text.Length != 0 || Label_QTE.Text.IndexOf('-') >= 0)))
		{
			// A second decimal point or a misplaced minus sign is not a valid quantity.
			e.Handled = true;
			return;
		}
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Button_qte_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void DataGridView1_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_SOLDER_PRINTER_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_SOLDER_NOT_PRINTER_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_SOLDER_CREDIT_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_SUPPRESSION_ALL_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_SUPPRESSION_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Text_FIND_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_FIND).BackColor = Color.Yellow;
	}

	private void Text_FIND_LostFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_FIND).BackColor = Color.White;
	}

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				LOGICA.ApplicationLayer.Checkout.CheckoutArticleSearchService.Search(
					delegate { return Text_FIND.Text.Length; },
					delegate { return TabControl2.SelectedIndex; },
					delegate
					{
					dt_LA.Clear();
					da_LA = new MySqlDataAdapter(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.List(), Module1.cn_SQL);
					da_LA.SelectCommand.Parameters.AddWithValue("@search", LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Pattern(Text_FIND.Text));
					((DbDataAdapter)(object)da_LA).Fill(dt_LA);
					DataGridView100.DataSource = dt_LA;
					},
					delegate
					{
					dt_PIC.Clear();
					da_PIC = new MySqlDataAdapter(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Images(), Module1.cn_SQL);
					da_PIC.SelectCommand.Parameters.AddWithValue("@search", LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Pattern(Text_FIND.Text));
					((DbDataAdapter)(object)da_PIC).Fill(dt_PIC);
					((Control)FlowLayout_ARTICLES).Controls.Clear();
					int num = dt_PIC.Rows.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							Bitmap articleImage = LOGICA.Infrastructure.Checkout.CheckoutArticleImageLoader.Load(
								Module1._CHEMIN_FOLDER + "\\bd\\images", dt_PIC.Rows[num2]["Images"].ToString());
							if (articleImage == null)
							{
								num2++;
								continue;
							}
							Button_RJ_ARTICLE button_RJ_ARTICLE = new Button_RJ_ARTICLE();
							button_RJ_ARTICLE._COLOR_PRIX = ((TextBoxBase)Text_THEME).BackColor;
							((Control)button_RJ_ARTICLE).Name = "Button_ARTICLE_" + Conversions.ToString(num2);
							((ButtonBase)button_RJ_ARTICLE).Text = dt_PIC.Rows[num2]["Article"].ToString();
							((Control)button_RJ_ARTICLE).Tag = LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileSelectionService.TagFor(dt_PIC.Rows[num2]);
							button_RJ_ARTICLE._PRIX = Strings.FormatNumber(dt_PIC.Rows[num2]["PRIX_V_1"].ToString());
							button_RJ_ARTICLE._BackgroundColor = Color.White;
							button_RJ_ARTICLE._BorderColor = ((TextBoxBase)Text_THEME).BackColor;
							button_RJ_ARTICLE._BorderRadius = 8;
							button_RJ_ARTICLE._BorderSize = 2m;
							button_RJ_ARTICLE._TextColor = Color.Black;
							((Control)button_RJ_ARTICLE).Cursor = Cursors.Hand;
							((ButtonBase)button_RJ_ARTICLE).FlatStyle = (FlatStyle)2;
							((Control)button_RJ_ARTICLE).Font = new Font("Segoe UI", 9f, (FontStyle)1);
							((Control)button_RJ_ARTICLE).ForeColor = Color.Black;
							((ButtonBase)button_RJ_ARTICLE).Image = (Image)articleImage;
							((ButtonBase)button_RJ_ARTICLE).ImageAlign = (ContentAlignment)2;
							Padding margin = new Padding(2, 2, 0, 0);
							((Control)button_RJ_ARTICLE).Margin = margin;
							((Control)button_RJ_ARTICLE).Width = 127;
							((Control)button_RJ_ARTICLE).Height = 117;
							((ButtonBase)button_RJ_ARTICLE).TextAlign = (ContentAlignment)512;
							((ButtonBase)button_RJ_ARTICLE).TextImageRelation = (TextImageRelation)1;
							((ButtonBase)button_RJ_ARTICLE).UseVisualStyleBackColor = false;
							((Control)button_RJ_ARTICLE).Click += B_article2_click;
							((Control)FlowLayout_ARTICLES).Controls.Add((Control)(object)button_RJ_ARTICLE);
							num2++;
							continue;
						}
						break;
					}
					});
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

	private void Label_QTE_LostFocus(object sender, EventArgs e)
	{
		((Control)Label_QTE).BackColor = Color.White;
	}

	private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		if (e.Index < 0)
		{
			return;
		}
		e.DrawBackground();
		StringFormat val = new StringFormat();
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "RightToLeft", new object[0], null, null, null)))
		{
			val.FormatFlags = (StringFormatFlags)1;
		}
		if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
		{
			e.Graphics.FillRectangle(Brushes.Brown, e.Bounds);
			Graphics graphics = e.Graphics;
			object[] array = new object[1];
			object[] array2 = array;
			object obj = sender;
			object instance = obj;
			object[] array3 = new object[1];
			object[] array4 = array3;
			DrawItemEventArgs e2 = e;
			array4[0] = e2.Index;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, "Items", array3, null, null, null));
			object[] array5 = array;
			object[] arguments = array5;
			bool[] array6 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(sender, null, "GetItemText", arguments, null, null, array6);
			if (array6[0])
			{
				NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
				{
					e2.Index,
					RuntimeHelpers.GetObjectValue(array5[0])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			graphics.DrawString(Conversions.ToString(obj2), e.Font, (Brush)new SolidBrush(e.ForeColor), (RectangleF)e.Bounds, val);
		}
		else if (e.Index % 2 != 0)
		{
			e.Graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(10, 0, 0, 0)), e.Bounds);
			Graphics graphics2 = e.Graphics;
			object[] array5 = new object[1];
			object[] array7 = array5;
			object obj = sender;
			object instance2 = obj;
			object[] array8 = new object[1];
			object[] array9 = array8;
			DrawItemEventArgs e2 = e;
			array9[0] = e2.Index;
			array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Items", array8, null, null, null));
			object[] array = array5;
			object[] arguments2 = array;
			bool[] array6 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(sender, null, "GetItemText", arguments2, null, null, array6);
			if (array6[0])
			{
				NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
				{
					e2.Index,
					RuntimeHelpers.GetObjectValue(array[0])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			graphics2.DrawString(Conversions.ToString(obj3), e.Font, Brushes.Red, (RectangleF)e.Bounds, val);
		}
		else
		{
			e.Graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, 0, 0, 0)), e.Bounds);
			Graphics graphics3 = e.Graphics;
			object[] array5 = new object[1];
			object[] array10 = array5;
			object obj = sender;
			object instance3 = obj;
			object[] array8 = new object[1];
			object[] array11 = array8;
			DrawItemEventArgs e2 = e;
			array11[0] = e2.Index;
			array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance3, null, "Items", array8, null, null, null));
			object[] array = array5;
			object[] arguments3 = array;
			bool[] array6 = new bool[1] { true };
			object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", arguments3, null, null, array6);
			if (array6[0])
			{
				NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
				{
					e2.Index,
					RuntimeHelpers.GetObjectValue(array[0])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			graphics3.DrawString(Conversions.ToString(obj4), e.Font, Brushes.Blue, (RectangleF)e.Bounds, val);
		}
		e.DrawFocusRectangle();
	}

	private void RadioButton1_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void RadioButton2_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button10_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void Button3_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button14_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button15_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button11_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Label_QTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label_QTE_Click(object sender, EventArgs e)
	{
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
	}

	private void Button_987_Click(object sender, EventArgs e)
	{
		Text_FIND.Text = " ";
		Text_FIND.Text = "";
		((Control)Text_FIND).Focus();
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		checked
		{
			int num = ((ArrangedElementCollection)((Control)FlowLayout_ARTICLES).Controls).Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Control val = ((Control)FlowLayout_ARTICLES).Controls[num2];
					val.Width += 10;
					val = ((Control)FlowLayout_ARTICLES).Controls[num2];
					val.Height += 10;
					((Control)FlowLayout_ARTICLES).Controls[num2].Font = new Font("Segoe UI", ((Control)FlowLayout_ARTICLES).Controls[num2].Font.Size + 2f);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		checked
		{
			int num = ((ArrangedElementCollection)((Control)FlowLayout_ARTICLES).Controls).Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Control val = ((Control)FlowLayout_ARTICLES).Controls[num2];
					val.Width -= 10;
					val = ((Control)FlowLayout_ARTICLES).Controls[num2];
					val.Height -= 10;
					((Control)FlowLayout_ARTICLES).Controls[num2].Font = new Font("Segoe UI", ((Control)FlowLayout_ARTICLES).Controls[num2].Font.Size - 2f);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton3_Click(object sender, EventArgs e)
	{
	}

	private void DataGridView100_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView100_DoubleClick(object sender, EventArgs e)
	{
		Button_FIND.PerformClick();
	}

	private void DataGridView100_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataGridView100.Rows.Count == 0)
			{
				((Control)Text_CODE).Focus();
				return;
			}
			int position = ((ContainerControl)this).BindingContext[(object)dt_LA].Position;
			Text_CODE.Text = dt_LA.Rows[position]["Code"].ToString();
			((Control)Text_CODE).Focus();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			((Control)Text_CODE).Focus();
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
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
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception e3 = ex4;
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
				((Control)Panel_FONCTIONS).Hide();
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				MySqlCommand val = new MySqlCommand();
				var waitingBoundary = new LOGICA.Infrastructure.Checkout.MySqlCheckoutTransactionBoundary(Module1.cn_SQL, val);
				LOGICA.ApplicationLayer.Checkout.CheckoutTransactionBoundaryService.Begin(waitingBoundary);
				try
				{
					val.CommandText = "INSERT INTO TABLE_ATTENTE      (Dates, Heure,ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, Prix_V, Qté,Remise, TOTAL_NET ,Caissier ,TAUX_TVA ,PRINTER,PRINTER_DUPLICATA ,  GROUPE ,        V      ,  POSTE , ID_CLIENT , CODE_CLIENT , CLIENT   )        SELECT         TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Dates,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Heure,     TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".ID_ARTICLE,  TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Code,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Article,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Famille,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".PRIX_A,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".PRIX_MP,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Prix_V,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Qté, TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".Remise,    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".TOTAL_NET  ,    '" + ((ButtonBase)Button_CAISSIER).Text + "' ,   TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".TAUX_TVA ,   TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".PRINTER,   TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".PRINTER_DUPLICATA  ,   TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + ".GROUPE  ,         " + DateTime.Now.ToString("HHmmssfffffff") + "     ,       " + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "  ,       '" + Button_CLIENT._ID_Button + "' ,'" + Button_CLIENT._CODE_Button + "' ,'" + ((ButtonBase)Button_CLIENT).Text + "'         FROM    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "  ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "Delete  from    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "  ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					LOGICA.ApplicationLayer.Checkout.CheckoutTransactionBoundaryService.CommitAndClose(waitingBoundary);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					LOGICA.ApplicationLayer.Checkout.CheckoutTransactionBoundaryService.Rollback(waitingBoundary);
					Module1.dt1.Clear();
					Module1._QUITTER_PATIENTER = true;
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				Module1.dt1.Clear();
				Module1.da1 = new MySqlDataAdapter("select * from    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "  ", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
				DataGridView1.DataSource = Module1.dt1;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				((ButtonBase)Button_VENDEUR).Text = "";
				((ButtonBase)Button_CLIENT).Text = "";
				Button_CLIENT._CODE_Button = "";
				Button_CLIENT._ID_Button = "";
				((ButtonBase)Button_PRIX).Text = "PRIX_1";
				Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				Module1._QUITTER_PATIENTER = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Module1.dt1.Clear();
				Interaction.MsgBox(ex3.ToString());
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_ATTENTES).ShowDialog();
	}

	private void Text_CODE_TextChanged(object sender, EventArgs e)
	{
	}

	private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Button_FONCTIONS_Click(object sender, EventArgs e)
	{
		if (((Control)Panel_FONCTIONS).Visible)
		{
			((Control)Panel_FONCTIONS).Hide();
		}
		else
		{
			((Control)Panel_FONCTIONS).Show();
			((Control)Panel_FONCTIONS).BringToFront();
		}
		((Control)Text_CODE).Focus();
	}

	private void Button_ANNULATION_Click(object sender, EventArgs e)
	{
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView1.Rows.Count == 0)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			int position = ((ContainerControl)this).BindingContext[(object)Module1.dt1].Position;
			Module1.dt1.Rows[position].Delete();
			MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
			((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
			Module1.dt1.AcceptChanges();
			((ContainerControl)this).BindingContext[(object)Module1.dt1].Position = position;
			Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Module1.dt1.Clear();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR ANNULATION_- | ";
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

	private void Button_ANNULATION_ALL_Click(object sender, EventArgs e)
	{
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView1.Rows.Count == 0)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("Delete  from TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			Module1.dt1.Clear();
			Module1.da1 = new MySqlDataAdapter("select * from TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "   order by ID asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
			DataGridView1.DataSource = Module1.dt1;
			Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Module1.dt1.Clear();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR ANNULATION_ALL | ";
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

	private void Button_OPERATION_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
		{
			if (DataGridView1.Rows.Count > 0)
			{
				MessageBox.Show("Merci de Vider la Table des Ventes, Avant la Déclaration des Retours", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			((ButtonBase)Button_OPERATION).Text = "RETOUR";
			((ButtonBase)Button_OPERATION).Image = Picture_TRISTE.Image;
			((Form)MyProject.Forms.FormDialog_RETOUR).ShowDialog();
		}
		else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
		{
			if (DataGridView1.Rows.Count > 0)
			{
				MessageBox.Show("Merci de Vider la Table des Ventes, Avant la Déclaration des Ventes", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			((ButtonBase)Button_OPERATION).Text = "VENTE";
			((ButtonBase)Button_OPERATION).Image = Picture_SMILE.Image;
		}
	}

	private void Button_REMISE_Click(object sender, EventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		if (DataGridView1.Rows.Count == 0)
		{
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
			return;
		}
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.FormDialog_REMISE).ShowDialog();
	}

	private void Button_MODIF_PRIX_Click(object sender, EventArgs e)
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView1.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			((Control)Panel_FONCTIONS).Hide();
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			int position = ((ContainerControl)this).BindingContext[(object)Module1.dt1].Position;
			MyProject.Forms.FormDialog_MODIFICATION_PRIX.Label2.Text = Module1.dt1.Rows[position]["Article"].ToString();
			MyProject.Forms.FormDialog_MODIFICATION_PRIX.Label_POSITION.Text = Conversions.ToString(position);
			((Form)MyProject.Forms.FormDialog_MODIFICATION_PRIX).ShowDialog();
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

	private void Button_MODIF_QTE_Click(object sender, EventArgs e)
	{
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		try
		{
			if (DataGridView1.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			((Control)Panel_FONCTIONS).Hide();
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
			{
				((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
				if (!Module1._acces)
				{
					return;
				}
				if (Module1._acces)
				{
					Module1._acces = false;
				}
			}
			int position = ((ContainerControl)this).BindingContext[(object)Module1.dt1].Position;
			MyProject.Forms.FormDialog_MODIFICATION_QTE.Label2.Text = Module1.dt1.Rows[position]["Article"].ToString();
			MyProject.Forms.FormDialog_MODIFICATION_QTE.Label_POSITION.Text = Conversions.ToString(position);
			((Form)MyProject.Forms.FormDialog_MODIFICATION_QTE).ShowDialog();
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[1];
			object[] array2 = array;
			DataRow dataRow = Module1.dt1.Rows[position];
			string columnName = "Qté";
			array2[0] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
			object[] array3 = array;
			bool[] array4 = new bool[1] { true };
			object value = NewLateBinding.LateGet(null, typeFromHandle, "Abs", array3, null, null, array4);
			if (array4[0])
			{
				dataRow[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
			}
			decimal num = Conversions.ToDecimal(value);
			decimal num2 = 0m;
			decimal num3 = 0m;
			decimal d = 0m;
			decimal num4 = 0m;
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "Select    PRIX_V_1,PROMOTION ,PRIX_QTE_MIN,PRIX_QTE     from TABLE_ARTICLES  where ID_ARTICLE =  '" + Module1.dt1.Rows[position]["ID_ARTICLE"].ToString() + "' ";
			val.Connection = Module1.cn_SQL;
			MySqlDataReader val2 = val.ExecuteReader();
			try
			{
				if (val2.Read())
				{
					num2 = Conversions.ToDecimal(val2["PRIX_QTE_MIN"].ToString());
					num3 = Conversions.ToDecimal(val2["PRIX_QTE"].ToString());
					d = Conversions.ToDecimal(val2["PROMOTION"].ToString());
					num4 = Conversions.ToDecimal(val2["PRIX_V_1"].ToString());
				}
				else
				{
					num2 = 0m;
					num3 = 0m;
					d = 0m;
					num4 = 0m;
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			Module1.cn_SQL.Close();
			decimal? quantityPrice = LOGICA.Domain.SalesLinePricing.SelectQuantityPrice(num, num2, num3, num4, LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance);
			if (quantityPrice.HasValue)
			{
				decimal selectedUnitPrice = quantityPrice.Value;
				Module1.dt1.Rows[position]["Prix_V"] = Strings.FormatNumber(selectedUnitPrice);
				if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[position]["TOTAL_NET"] = Strings.FormatNumber(LOGICA.Domain.SalesLinePricing.CalculateNetAmount(selectedUnitPrice, num, d));
				}
				else if (Operators.CompareString(((ButtonBase)Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
				{
					Module1.dt1.Rows[position]["TOTAL_NET"] = Conversions.ToDouble(Strings.FormatNumber(LOGICA.Domain.SalesLinePricing.CalculateNetAmount(selectedUnitPrice, num, d))) * -1.0;
				}
				MySqlCommandBuilder val3 = new MySqlCommandBuilder(Module1.da1);
				((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
				Module1.dt1.AcceptChanges();
			}
			Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val6 = Graphics.FromImage((Image)(object)val5);
				val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val5 = null;
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

	private void Button_PRIX_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		if (DataGridView1.Rows.Count > 0)
		{
			MessageBox.Show("Merci de Vider la Table des Ventes", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "PRIX_1", TextCompare: false))
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { "PRIX_2" }, null, null);
			NewLateBinding.LateSet(sender, null, "Image", new object[1] { Picture_FLECH_HAUT.Image }, null, null);
			NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
			((ButtonBase)Button_PRIX).Text = "PRIX_2";
			((ButtonBase)Button_PRIX).Image = Picture_FLECH_HAUT.Image;
			((ButtonBase)Button_PRIX).BackColor = Color.Yellow;
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "PRIX_2", TextCompare: false))
		{
			NewLateBinding.LateSet(sender, null, "Text", new object[1] { "PRIX_1" }, null, null);
			NewLateBinding.LateSet(sender, null, "Image", new object[1] { Picture_FLECH_BAS.Image }, null, null);
			NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Transparent }, null, null);
			((ButtonBase)Button_PRIX).Text = "PRIX_1";
			((ButtonBase)Button_PRIX).Image = Picture_FLECH_BAS.Image;
			((ButtonBase)Button_PRIX).BackColor = Color.Transparent;
		}
	}

	private void Button_DIVERS_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.FormDialog_DIVERS).ShowDialog();
	}

	private void Button_DUPLICARA_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.FormDialog_DUPLICATA).ShowDialog();
	}

	private void Button_FLASH_Click(object sender, EventArgs e)
	{
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		checked
		{
			try
			{
				((Control)Panel_FONCTIONS).Hide();
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
				{
					((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
					if (!Module1._acces)
					{
						return;
					}
					if (Module1._acces)
					{
						Module1._acces = false;
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
				{
					((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
					if (!Module1._acces)
					{
						return;
					}
					if (Module1._acces)
					{
						Module1._acces = false;
					}
				}
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text, "True", TextCompare: false) == 0)
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select sum(TOTAL_NET) as n  from   TABLE_VENTES_JOURNAL     Where CLOTURE_CAISSIER IS  NULL      And      Caissier    like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  CLOTURE_CAISSIER IS  NULL             And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'                ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					MySqlDataAdapter val3 = new MySqlDataAdapter();
					DataTable dataTable3 = new DataTable();
					string text = "";
					int num = dataTable2.Rows.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						val3 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    CLOTURE_CAISSIER IS  NULL              And     MODE_P  = '" + Strings.Trim(dataTable2.Rows[num2]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'             ", Module1.cn_SQL);
						dataTable3 = new DataTable();
						dataTable3.Clear();
						((DbDataAdapter)(object)val3).Fill(dataTable3);
						double num5 = Conversion.Val(dataTable3.Rows[0]["n"].ToString());
						text = text + "                    " + Strings.LSet(dataTable2.Rows[num2]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num5), 8) + " DH\r\n";
						num2++;
					}
					Interaction.MsgBox(Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + " : \r\n" + Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())) + "  Dhs\r\n" + text);
					return;
				}
				DataTable dataTable4 = new DataTable();
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				dataTable4.Clear();
				val4 = new MySqlDataAdapter("select  sum(TOTAL_NET) as n from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '       And      Caissier    like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'   and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val4).Fill(dataTable4);
				DataTable dataTable5 = new DataTable();
				MySqlDataAdapter val5 = new MySqlDataAdapter();
				dataTable5.Clear();
				val5 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '              And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'                ", Module1.cn_SQL);
				((DbDataAdapter)(object)val5).Fill(dataTable5);
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataTable dataTable6 = new DataTable();
				string text2 = "";
				int num6 = dataTable5.Rows.Count - 1;
				int num7 = 0;
				while (true)
				{
					int num8 = num7;
					int num4 = num6;
					if (num8 > num4)
					{
						break;
					}
					val6 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable5.Rows[num7]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'             ", Module1.cn_SQL);
					dataTable6 = new DataTable();
					dataTable6.Clear();
					((DbDataAdapter)(object)val6).Fill(dataTable6);
					double num9 = Conversion.Val(dataTable6.Rows[0]["n"].ToString());
					text2 = text2 + "                    " + Strings.LSet(dataTable5.Rows[num7]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num9), 8) + " DH\r\n";
					num7++;
				}
				Interaction.MsgBox(Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + " : \r\n" + Strings.FormatNumber(Conversion.Val(dataTable4.Rows[0]["n"].ToString())) + "  Dhs\r\n" + text2);
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
					Bitmap val7 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val8 = Graphics.FromImage((Image)(object)val7);
					val8.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val7).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
					val7 = null;
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

	private void Button_TIROIR_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		string command = "\u001bp\0<" + Conversions.ToString(Strings.Chr(255));
		string text = Text_PRINTER_SOLDER.Text;
		RawPrinterHelperr.SendStringToPrinter(text, command);
	}

	private void Button_RAPPORT_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.FormDialog_RAPPORT).ShowDialog();
	}

	private void Button_DEPENSES_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.Form_6_DEPENSES).ShowDialog();
	}

	private void Button_ARTICLES_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Control)MyProject.Forms.Form_2_ARTICLES).Show();
		((Control)MyProject.Forms.Form_2_ARTICLES).BringToFront();
		((Form)MyProject.Forms.Form_2_ARTICLES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_2_ARTICLES).WindowState = (FormWindowState)2;
		((Control)MyProject.Forms.Form_2_ARTICLES.Button244).Visible = false;
		checked
		{
			MyProject.Forms.Form_2_ARTICLES.DataGridView1.Columns[((BaseCollection)MyProject.Forms.Form_2_ARTICLES.DataGridView1.Columns).Count - 1].Visible = false;
			MyProject.Forms.Form_2_ARTICLES.DataGridView1.Columns[((BaseCollection)MyProject.Forms.Form_2_ARTICLES.DataGridView1.Columns).Count - 2].Visible = false;
			((Form)MyProject.Forms.Form_2_ARTICLES).FormBorderStyle = (FormBorderStyle)4;
		}
	}

	private void Button_RECEPTIONS_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Control)MyProject.Forms.Form_6_RECEPTIONS).Show();
		((Control)MyProject.Forms.Form_6_RECEPTIONS).BringToFront();
		((Form)MyProject.Forms.Form_6_RECEPTIONS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_RECEPTIONS).WindowState = (FormWindowState)2;
	}

	private void Button_SORTIES_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Control)MyProject.Forms.Form_6_SORTIES).Show();
		((Control)MyProject.Forms.Form_6_SORTIES).BringToFront();
		((Form)MyProject.Forms.Form_6_SORTIES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_SORTIES).WindowState = (FormWindowState)2;
	}

	private void Button_INVENTAIRE_Click(object sender, EventArgs e)
	{
	}

	private void Button_CLIENTS_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Control)MyProject.Forms.Form_5_CLIENTS).Show();
		((Control)MyProject.Forms.Form_5_CLIENTS).BringToFront();
		((Form)MyProject.Forms.Form_5_CLIENTS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_5_CLIENTS).WindowState = (FormWindowState)2;
	}

	private void Button_CLIENTS_REGLEMENTS_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Control)MyProject.Forms.Form_5_CLIENTS_REGLE).Show();
		((Control)MyProject.Forms.Form_5_CLIENTS_REGLE).BringToFront();
		((Form)MyProject.Forms.Form_5_CLIENTS_REGLE).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_5_CLIENTS_REGLE).WindowState = (FormWindowState)2;
	}

	private void Button_FONDS_CAISSE_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_FONDS_CAISSE).ShowDialog();
	}

	private void Button_ALERTS_STOCK_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_ETAT_ALERTES_STOCK).ShowDialog();
	}

	private void Button_FERMER_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Hide();
	}

	private void Button_FERMER2_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Hide();
	}

	private void Button_LOCK_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Hide();
		((Control)MyProject.Forms.FormDialog_RFID).Show();
		((Form)MyProject.Forms.FormDialog_RFID).TopMost = true;
	}

	private void Button_CLOTURE_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 3, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_MANAGER).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "FlatAppearance", new object[0], null, null, null), null, "BorderSize", new object[0], null, null, null), 5, TextCompare: false))
		{
			((Form)MyProject.Forms.FormDialog_acces_ADMIN).ShowDialog();
			if (!Module1._acces)
			{
				return;
			}
			if (Module1._acces)
			{
				Module1._acces = false;
			}
		}
		((Form)MyProject.Forms.FormDialog_CLOTURE).Close();
		((Control)MyProject.Forms.FormDialog_CLOTURE.ListBox_CAISSIERS).Enabled = false;
		((Form)MyProject.Forms.FormDialog_CLOTURE).ShowDialog();
	}

	private void Button_THEME_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_THEME).ShowDialog();
	}

	private void Button_CALCULATRICE_Click(object sender, EventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		try
		{
			Process.Start("calc.exe");
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

	private void Button_COMPTER_CAISSE_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_COMPTER_CAISSE).ShowDialog();
	}

	private void Button_RACCOURCIES_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_RACCOURCIES).ShowDialog();
		CREATION_RACCOURCIES();
	}

	private void Button_CAISSIER_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_VENDEUR_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form_5_VENDEURS_LISTE).ShowDialog();
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_CLIENT_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
		((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
		((Control)Text_CODE).Focus();
	}

	private void Class_BUTTON_ART1_Click(object sender, EventArgs e)
	{
	}

	private void Panel_FONCTIONS_VisibleChanged(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Button_OPERATION_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Text_FONDS_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_FOND_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Panel4_Click(object sender, EventArgs e)
	{
		((Control)Text_FIND).Focus();
	}

	private void Panel4_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Panel5_Click(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void Panel5_Paint(object sender, PaintEventArgs e)
	{
	}

	private void TabControl2_Click(object sender, EventArgs e)
	{
		((Control)Text_FIND).Focus();
	}

	private void Button_qte1_Click(object sender, EventArgs e)
	{
		string key = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
		// Ignore unexpected button captions rather than producing an invalid checkout quantity.
		if (string.IsNullOrEmpty(key) || (key != "." && (key.Length != 1 || key[0] < '0' || key[0] > '9')))
		{
			return;
		}
		string current = ((Control)Label_QTE).BackColor == Color.White ? "" : Label_QTE.Text;
		// A second decimal point creates a quantity that cannot be converted at checkout.
		// Preserve the existing numeric keypad and reset semantics for valid input.
		if (key == "." && current.IndexOf('.') >= 0)
		{
			return;
		}
		if (key == "." && current.Length == 0)
		{
			current = "0";
		}
		((Control)Label_QTE).BackColor = Color.Yellow;
		Label_QTE.Text = current + key;
	}

	private void Button_qteBACK_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_QUANTITE).ShowDialog();
		((Control)Text_CODE).Focus();
	}

	private void Button_qteDRAFT_Click(object sender, EventArgs e)
	{
		((Control)Label_QTE).BackColor = Color.White;
		Label_QTE.Text = Conversions.ToString(1);
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
		if (((Control)Text_FIND).Focused)
		{
			Text_FIND.Text = "";
		}
		else if (((Control)Text_CODE).Focused)
		{
			Text_CODE.Text = "";
		}
	}

	private void Butt_AR_Click(object sender, EventArgs e)
	{
		((Control)Panel_CLAVIER_AR).BringToFront();
	}

	private void Butt_Click_AR(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("{", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "}")));
	}

	private void Butt_SPACE_AR_Click(object sender, EventArgs e)
	{
		SendKeys.Send(" ");
	}

	private void Butt_BACK_AR_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{BACKSPACE}");
	}

	private void Butt_DRAFT_AR_Click(object sender, EventArgs e)
	{
		if (((Control)Text_FIND).Focused)
		{
			Text_FIND.Text = "";
		}
		else if (((Control)Text_CODE).Focused)
		{
			Text_CODE.Text = "";
		}
	}

	private void Butt_FR_Click(object sender, EventArgs e)
	{
		((Control)Panel_CLAVIER).BringToFront();
	}

	private void Form_3_VENTE_Shown(object sender, EventArgs e)
	{
		((Control)Text_CODE).Focus();
	}

	private void ERREUR_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 300, 40);
		string text = "ERREUR";
		e.Graphics.DrawString(text, new Font("Inconsolata Black", 20f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 14f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
		e.Graphics.DrawString(" - ", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 40f, new StringFormat((StringFormatFlags)8192));
	}

	private int _productListHeightBeforeKeyboard;

	private void Button_876_Click(object sender, EventArgs e)
	{
		((Control)Text_FIND).Focus();
		if (Operators.ConditionalCompareObjectEqual(((Control)TabControl2).Tag, "", TextCompare: false))
		{
			// On compact displays, never collapse the product list to zero/negative height.
			// Keep the original layout and keyboard state as a safe legacy fallback.
			if (((Control)TabControl2).Height <= ((Control)Panel_CLAVIER).Height + 10)
			{
				return;
			}
			_productListHeightBeforeKeyboard = ((Control)TabControl2).Height;
			((Control)TabControl2).Height = checked(((Control)TabControl2).Height - ((Control)Panel_CLAVIER).Height - 10);
			((Control)TabControl2).Tag = "1";
		}
		else
		{
			((Control)TabControl2).Tag = "";
			// Preserve the exact pre-keyboard list height under DPI scaling.
			// Keep the original Panel9 fallback if this form had no saved height.
			((Control)TabControl2).Height = _productListHeightBeforeKeyboard > 0
				? _productListHeightBeforeKeyboard : ((Control)Panel9).Height;
			_productListHeightBeforeKeyboard = 0;
		}
	}

	private void Text_PROMOTION_TextChanged(object sender, EventArgs e)
	{
	}

	private void C1_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got Unknown
		checked
		{
			try
			{
				int num = 40;
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0 + num, 300, 30);
				e.Graphics.DrawString(_N_TICKET_SOLDER, new Font("Inconsolata Black", 18f, (FontStyle)1), Brushes.White, 190f, (float)(2 + num), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Strings.LSet(((ButtonBase)Button_CAISSIER).Text + " . " + ((ButtonBase)Button_VENDEUR).Text, 15), new Font("Inconsolata Condensed", 14f, (FontStyle)1), Brushes.Black, 0f, (float)(47 + num), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(80 + num), new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num2 = 0;
				int num3 = DataGridView1.RowCount - 1;
				int num4 = 0;
				while (true)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(DataGridView1.Rows[num4].Cells["PRINTER"].Value, "C1", TextCompare: false), Operators.CompareObjectEqual(DataGridView1.Rows[num4].Cells["PRINTER_DUPLICATA"].Value, "C1", TextCompare: false))))
					{
						if (DataGridView1.Rows[num4].Cells["Article"].Value.ToString().Contains("-->"))
						{
							text = Strings.LSet("", 4) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num4].Cells["Article"].Value), 26);
							e.Graphics.FillRectangle(Brushes.Black, 40, 90 + num + num2 * 25, 220, 25);
							e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 16f, (FontStyle)1), Brushes.White, 0f, (float)(90 + num + num2 * 25), new StringFormat((StringFormatFlags)8192));
						}
						else
						{
							text = Strings.LSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num4].Cells["Qté"].Value))), 4) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num4].Cells["Article"].Value), 26);
							e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(90 + num + num2 * 25), new StringFormat((StringFormatFlags)8192));
						}
						num2++;
					}
					num4++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(90 + num + num2 * 25), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(90 + num + num2 * 25 + 30), new StringFormat((StringFormatFlags)8192));
				string text2 = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(C1)(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")";
				e.Graphics.DrawString(text2, new Font("Lucida Console", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(text2, new Font("Lucida Console", 8f, (FontStyle)0)).Width / 2f), (float)(90 + num + num2 * 25 + 50), new StringFormat((StringFormatFlags)8192));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				if (Operators.CompareString(Text_PRINTER_C1.Text, "", TextCompare: false) != 0)
				{
					ERREUR.PrinterSettings.PrinterName = Text_PRINTER_C1.Text;
				}
				ERREUR.PrintController = (PrintController)new StandardPrintController();
				ERREUR.Print();
				Interaction.MsgBox("ERREUR C1 : " + ex2.Message);
				try
				{
					string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERREUR C1  | ";
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

	private void Button_CLAVIER_NOSELECT34_Click(object sender, EventArgs e)
	{
		prn.SendStringToPrinter(Text_PRINTER_SOLDER.Text, "\u001bp\0<" + Conversions.ToString(Strings.Chr(255)));
	}

	private void Button_CLAVIER_NOSELECT35_Click(object sender, EventArgs e)
	{
		string command = "\u001bp\0<" + Conversions.ToString(Strings.Chr(255));
		string text = Text_PRINTER_SOLDER.Text;
		RawPrinterHelperr.SendStringToPrinter(text, command);
	}
}
