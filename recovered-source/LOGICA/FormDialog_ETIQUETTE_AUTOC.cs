using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using CustomControls.RJControls;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using ThoughtWorks.QRCode.Codec;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ETIQUETTE_AUTOC : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Picture_CODE")]
	private PictureBox _Picture_CODE;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("Numeric_qte")]
	private NumericUpDown _Numeric_qte;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Text_code")]
	private TextBox _Text_code;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel_ETIQUETTE")]
	private Panel _Panel_ETIQUETTE;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Text_article")]
	private TextBox _Text_article;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Text_prix_v")]
	private TextBox _Text_prix_v;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("Button_GO")]
	private Button _Button_GO;

	[AccessedThroughProperty("Label_ARTICLE")]
	private Label _Label_ARTICLE;

	[AccessedThroughProperty("Label_PRIX_V")]
	private Label _Label_PRIX_V;

	[AccessedThroughProperty("Label_CODE")]
	private Label _Label_CODE;

	[AccessedThroughProperty("Panel_CONFIG")]
	private Panel _Panel_CONFIG;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Combo_TYPE")]
	private ComboBox _Combo_TYPE;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Combo_PRINT")]
	private ComboBox _Combo_PRINT;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Numeric_TICKET_HEIGHT")]
	private NumericUpDown _Numeric_TICKET_HEIGHT;

	[AccessedThroughProperty("Numeric_TICKET_WIDTH")]
	private NumericUpDown _Numeric_TICKET_WIDTH;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Picture_FLECHE")]
	private PictureBox _Picture_FLECHE;

	[AccessedThroughProperty("Picture_DOWN")]
	private PictureBox _Picture_DOWN;

	[AccessedThroughProperty("Picture_UP")]
	private PictureBox _Picture_UP;

	[AccessedThroughProperty("Label_RED_BOTTOM")]
	private Label _Label_RED_BOTTOM;

	[AccessedThroughProperty("Label_RED_LEFT")]
	private Label _Label_RED_LEFT;

	[AccessedThroughProperty("Label_RED_RIGHT")]
	private Label _Label_RED_RIGHT;

	[AccessedThroughProperty("Label_RED_TOP")]
	private Label _Label_RED_TOP;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Panel_FICHE")]
	private Panel _Panel_FICHE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("NumericUpDown_SIZE")]
	private NumericUpDown _NumericUpDown_SIZE;

	[AccessedThroughProperty("NumericUpDown_X")]
	private NumericUpDown _NumericUpDown_X;

	[AccessedThroughProperty("NumericUpDown_Y")]
	private NumericUpDown _NumericUpDown_Y;

	[AccessedThroughProperty("Label_NAME")]
	private Label _Label_NAME;

	[AccessedThroughProperty("DataGridView_CONTROLS")]
	private DataGridView _DataGridView_CONTROLS;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	[AccessedThroughProperty("Label_PRIX_V_MINI")]
	private Label _Label_PRIX_V_MINI;

	[AccessedThroughProperty("Label_PRIX_V_DECIMAL")]
	private Label _Label_PRIX_V_DECIMAL;

	[AccessedThroughProperty("Text_promotion")]
	private TextBox _Text_promotion;

	[AccessedThroughProperty("Label_PROMOTION")]
	private Label _Label_PROMOTION;

	[AccessedThroughProperty("Label_TEXT_LIBRE_")]
	private Label _Label_TEXT_LIBRE_;

	[AccessedThroughProperty("Text_LIBRE")]
	private TextBox _Text_LIBRE;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("CODE_LISTE")]
	private DataGridViewTextBoxColumn _CODE_LISTE;

	[AccessedThroughProperty("ARTICLE_LISTE")]
	private DataGridViewTextBoxColumn _ARTICLE_LISTE;

	[AccessedThroughProperty("PRIX_V_LISTE")]
	private DataGridViewTextBoxColumn _PRIX_V_LISTE;

	[AccessedThroughProperty("PROMOTION_LISTE")]
	private DataGridViewTextBoxColumn _PROMOTION_LISTE;

	[AccessedThroughProperty("LIBRE_LISTE")]
	private DataGridViewTextBoxColumn _LIBRE_LISTE;

	[AccessedThroughProperty("QTE_LISTE")]
	private DataGridViewTextBoxColumn _QTE_LISTE;

	[AccessedThroughProperty("supp")]
	private DataGridViewButtonColumn _supp;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("CODE")]
	private DataGridViewTextBoxColumn _CODE;

	[AccessedThroughProperty("REFERENCE")]
	private DataGridViewTextBoxColumn _REFERENCE;

	[AccessedThroughProperty("ARTICLE")]
	private DataGridViewTextBoxColumn _ARTICLE;

	[AccessedThroughProperty("PRIX_V_1")]
	private DataGridViewTextBoxColumn _PRIX_V_1;

	[AccessedThroughProperty("STOCK")]
	private DataGridViewTextBoxColumn _STOCK;

	[AccessedThroughProperty("PROMOTION")]
	private DataGridViewTextBoxColumn _PROMOTION;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Combo_FIND")]
	private BunifuDropdown _Combo_FIND;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private BunifuCheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Picture_FIND")]
	private Button_RJ _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private RJTextBox _Text_FIND;

	[AccessedThroughProperty("Button_MODELE_1")]
	private Button _Button_MODELE_1;

	[AccessedThroughProperty("Button_MODELE_2")]
	private Button _Button_MODELE_2;

	private QRCodeEncoder QREncoder;

	private Image QRimg;

	private Bitmap QRbitmap;

	public Bitmap barcodeImage;

	private string _sName;

	private float _fMinimumAllowableScale;

	private float _fMaximumAllowableScale;

	private float _fWidth;

	private float _fHeight;

	private float _fFontSize;

	private float _fScale;

	private string[] _aLeft;

	private string[] _aRight;

	private string _sQuiteZone;

	private string _sLeadTail;

	private string _sSeparator;

	private string _sProductType;

	private string _sManufacturerCode;

	private string _sProductCode;

	private string _sChecksumDigit;

	internal virtual PictureBox Picture_CODE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_CODE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_CODE = value;
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = PrintDocument1_PrintPage;
			if (_PrintDocument1 != null)
			{
				_PrintDocument1.PrintPage -= val;
			}
			_PrintDocument1 = value;
			if (_PrintDocument1 != null)
			{
				_PrintDocument1.PrintPage += val;
			}
		}
	}

	internal virtual NumericUpDown Numeric_qte
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_qte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_qte = value;
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

	internal virtual TextBox Text_code
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TYPE_SelectedIndexChanged;
			if (_Text_code != null)
			{
				((Control)_Text_code).TextChanged -= eventHandler;
			}
			_Text_code = value;
			if (_Text_code != null)
			{
				((Control)_Text_code).TextChanged += eventHandler;
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

	internal virtual Panel Panel_ETIQUETTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_ETIQUETTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_ETIQUETTE = value;
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

	internal virtual TextBox Text_article
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_article;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TYPE_SelectedIndexChanged;
			if (_Text_article != null)
			{
				((Control)_Text_article).TextChanged -= eventHandler;
			}
			_Text_article = value;
			if (_Text_article != null)
			{
				((Control)_Text_article).TextChanged += eventHandler;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView2_CellContentClick;
			DataGridViewCellPaintingEventHandler val2 = DataGridView2_CellPainting;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellContentClick -= val;
				_DataGridView2.CellPainting -= val2;
			}
			_DataGridView2 = value;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellContentClick += val;
				_DataGridView2.CellPainting += val2;
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

	internal virtual TextBox Text_prix_v
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_prix_v;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TYPE_SelectedIndexChanged;
			if (_Text_prix_v != null)
			{
				((Control)_Text_prix_v).TextChanged -= eventHandler;
			}
			_Text_prix_v = value;
			if (_Text_prix_v != null)
			{
				((Control)_Text_prix_v).TextChanged += eventHandler;
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
			EventHandler eventHandler = DataGridView1_DoubleClick;
			DataGridViewCellEventHandler val = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
				_DataGridView1.CellContentClick -= val;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
				_DataGridView1.CellContentClick += val;
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

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NumericUpDown1 = value;
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

	internal virtual Label Label_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ARTICLE = value;
		}
	}

	internal virtual Label Label_PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_PRIX_V = value;
		}
	}

	internal virtual Label Label_CODE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CODE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CODE = value;
		}
	}

	internal virtual Panel Panel_CONFIG
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CONFIG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CONFIG = value;
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

	internal virtual ComboBox Combo_TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TYPE_SelectedIndexChanged;
			if (_Combo_TYPE != null)
			{
				_Combo_TYPE.SelectedIndexChanged -= eventHandler;
			}
			_Combo_TYPE = value;
			if (_Combo_TYPE != null)
			{
				_Combo_TYPE.SelectedIndexChanged += eventHandler;
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

	internal virtual ComboBox Combo_PRINT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINT = value;
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

	internal virtual NumericUpDown Numeric_TICKET_HEIGHT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_TICKET_HEIGHT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Numeric_TICKET_HEIGHT_ValueChanged;
			if (_Numeric_TICKET_HEIGHT != null)
			{
				_Numeric_TICKET_HEIGHT.ValueChanged -= eventHandler;
			}
			_Numeric_TICKET_HEIGHT = value;
			if (_Numeric_TICKET_HEIGHT != null)
			{
				_Numeric_TICKET_HEIGHT.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual NumericUpDown Numeric_TICKET_WIDTH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_TICKET_WIDTH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Numeric_TICKET_WIDTH_ValueChanged;
			if (_Numeric_TICKET_WIDTH != null)
			{
				_Numeric_TICKET_WIDTH.ValueChanged -= eventHandler;
			}
			_Numeric_TICKET_WIDTH = value;
			if (_Numeric_TICKET_WIDTH != null)
			{
				_Numeric_TICKET_WIDTH.ValueChanged += eventHandler;
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

	internal virtual PictureBox Picture_FLECHE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FLECHE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_FLECHE_Click;
			if (_Picture_FLECHE != null)
			{
				((Control)_Picture_FLECHE).Click -= eventHandler;
			}
			_Picture_FLECHE = value;
			if (_Picture_FLECHE != null)
			{
				((Control)_Picture_FLECHE).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_DOWN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_DOWN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_DOWN = value;
		}
	}

	internal virtual PictureBox Picture_UP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_UP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_UP = value;
		}
	}

	internal virtual Label Label_RED_BOTTOM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RED_BOTTOM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RED_BOTTOM = value;
		}
	}

	internal virtual Label Label_RED_LEFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RED_LEFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RED_LEFT = value;
		}
	}

	internal virtual Label Label_RED_RIGHT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RED_RIGHT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RED_RIGHT = value;
		}
	}

	internal virtual Label Label_RED_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RED_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RED_TOP = value;
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

	internal virtual Panel Panel_FICHE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FICHE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_FICHE = value;
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

	internal virtual NumericUpDown NumericUpDown_SIZE
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown_SIZE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_SIZE_ValueChanged;
			if (_NumericUpDown_SIZE != null)
			{
				_NumericUpDown_SIZE.ValueChanged -= eventHandler;
			}
			_NumericUpDown_SIZE = value;
			if (_NumericUpDown_SIZE != null)
			{
				_NumericUpDown_SIZE.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual NumericUpDown NumericUpDown_X
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown_X;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_X_ValueChanged;
			if (_NumericUpDown_X != null)
			{
				_NumericUpDown_X.ValueChanged -= eventHandler;
			}
			_NumericUpDown_X = value;
			if (_NumericUpDown_X != null)
			{
				_NumericUpDown_X.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual NumericUpDown NumericUpDown_Y
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown_Y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_Y_ValueChanged;
			if (_NumericUpDown_Y != null)
			{
				_NumericUpDown_Y.ValueChanged -= eventHandler;
			}
			_NumericUpDown_Y = value;
			if (_NumericUpDown_Y != null)
			{
				_NumericUpDown_Y.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label_NAME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_NAME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_NAME = value;
		}
	}

	internal virtual DataGridView DataGridView_CONTROLS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_CONTROLS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_CONTROLS_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView_CONTROLS_CellContentClick;
			if (_DataGridView_CONTROLS != null)
			{
				_DataGridView_CONTROLS.CellClick -= val;
				_DataGridView_CONTROLS.CellContentClick -= val2;
			}
			_DataGridView_CONTROLS = value;
			if (_DataGridView_CONTROLS != null)
			{
				_DataGridView_CONTROLS.CellClick += val;
				_DataGridView_CONTROLS.CellContentClick += val2;
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

	internal virtual Label Label_PRIX_V_MINI
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PRIX_V_MINI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_PRIX_V_MINI = value;
		}
	}

	internal virtual Label Label_PRIX_V_DECIMAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PRIX_V_DECIMAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_PRIX_V_DECIMAL = value;
		}
	}

	internal virtual TextBox Text_promotion
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_promotion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_promotion = value;
		}
	}

	internal virtual Label Label_PROMOTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_PROMOTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_PROMOTION = value;
		}
	}

	internal virtual Label Label_TEXT_LIBRE_
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TEXT_LIBRE_;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TEXT_LIBRE_ = value;
		}
	}

	internal virtual TextBox Text_LIBRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LIBRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_TYPE_SelectedIndexChanged;
			if (_Text_LIBRE != null)
			{
				((Control)_Text_LIBRE).TextChanged -= eventHandler;
			}
			_Text_LIBRE = value;
			if (_Text_LIBRE != null)
			{
				((Control)_Text_LIBRE).TextChanged += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn CODE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_LISTE = value;
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

	internal virtual DataGridViewTextBoxColumn PRIX_V_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PROMOTION_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _PROMOTION_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PROMOTION_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn LIBRE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _LIBRE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LIBRE_LISTE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn QTE_LISTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _QTE_LISTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_QTE_LISTE = value;
		}
	}

	internal virtual DataGridViewButtonColumn supp
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

	internal virtual DataGridViewTextBoxColumn CODE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn REFERENCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _REFERENCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_REFERENCE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ARTICLE = value;
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

	internal virtual DataGridViewTextBoxColumn PROMOTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _PROMOTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PROMOTION = value;
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
			_Combo_FIND = value;
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

	internal virtual Button Button_MODELE_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MODELE_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MODELE_1_Click;
			if (_Button_MODELE_1 != null)
			{
				((Control)_Button_MODELE_1).Click -= eventHandler;
			}
			_Button_MODELE_1 = value;
			if (_Button_MODELE_1 != null)
			{
				((Control)_Button_MODELE_1).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_MODELE_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MODELE_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MODELE_2_Click;
			if (_Button_MODELE_2 != null)
			{
				((Control)_Button_MODELE_2).Click -= eventHandler;
			}
			_Button_MODELE_2 = value;
			if (_Button_MODELE_2 != null)
			{
				((Control)_Button_MODELE_2).Click += eventHandler;
			}
		}
	}

	public string Namee => _sName;

	public float MinimumAllowableScale => _fMinimumAllowableScale;

	public float MaximumAllowableScale => _fMaximumAllowableScale;

	public float Width => _fWidth;

	public float Height => _fHeight;

	public float FontSize => _fFontSize;

	public float Scale
	{
		get
		{
			return _fScale;
		}
		set
		{
			if (value < _fMinimumAllowableScale || ((value > _fMaximumAllowableScale) ? true : false))
			{
				throw new Exception("Scale value out of allowable range.  Value must be between " + _fMinimumAllowableScale + " and " + _fMaximumAllowableScale);
			}
			_fScale = value;
		}
	}

	public string ProductType
	{
		get
		{
			return _sProductType;
		}
		set
		{
			_sProductType = value;
		}
	}

	public string ManufacturerCode
	{
		get
		{
			return _sManufacturerCode;
		}
		set
		{
			if (value.Length != 5)
			{
				throw new Exception("The manufacturer number must be 5 digits.");
			}
			_sManufacturerCode = value;
		}
	}

	public string ProductCode
	{
		get
		{
			return _sProductCode;
		}
		set
		{
			if (value.Length != 5)
			{
				throw new Exception("The product identification number must be 5 digits.");
			}
			_sProductCode = value;
		}
	}

	public string ChecksumDigit
	{
		get
		{
			return _sChecksumDigit;
		}
		set
		{
			int num = Convert.ToInt32(value);
			if (num < 0 || num > 9)
			{
				throw new Exception("The Check Digit must be between 0 and 9.");
			}
			_sChecksumDigit = value;
		}
	}

	public FormDialog_ETIQUETTE_AUTOC()
	{
		((Form)this).Shown += FormDialog_ETIQUETTE_AUTOC_Shown;
		((Form)this).Load += FormDialog_ETIQUETTE_AUTOC_Load;
		__ENCAddToList(this);
		_sName = "UPC-A";
		_fMinimumAllowableScale = 0.8f;
		_fMaximumAllowableScale = 2f;
		_fWidth = 1.469f;
		_fHeight = 0.5f;
		_fFontSize = 8f;
		_fScale = 1f;
		_aLeft = new string[10] { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" };
		_aRight = new string[10] { "1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100" };
		_sQuiteZone = "0000000000";
		_sLeadTail = "101";
		_sSeparator = "01010";
		_sProductType = "0";
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
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected Obj, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected Obj, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Expected Obj, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Obj, but got Unknown
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected Obj, but got Unknown
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected Obj, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected Obj, but got Unknown
		//IL_102b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Expected Obj, but got Unknown
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d2: Expected Obj, but got Unknown
		//IL_1191: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Expected Obj, but got Unknown
		//IL_142f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1439: Expected Obj, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected Obj, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e0: Expected Obj, but got Unknown
		//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17aa: Expected Obj, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Expected Obj, but got Unknown
		//IL_1926: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected Obj, but got Unknown
		//IL_1a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a47: Expected Obj, but got Unknown
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b02: Expected Obj, but got Unknown
		//IL_1bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb6: Expected Obj, but got Unknown
		//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c87: Expected Obj, but got Unknown
		//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d19: Expected Obj, but got Unknown
		//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de6: Expected Obj, but got Unknown
		//IL_1e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Expected Obj, but got Unknown
		//IL_1f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f44: Expected Obj, but got Unknown
		//IL_218e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2198: Expected Obj, but got Unknown
		//IL_21cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2274: Expected Obj, but got Unknown
		//IL_22a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2348: Unknown result type (might be due to invalid IL or missing references)
		//IL_2352: Expected Obj, but got Unknown
		//IL_23fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2406: Expected Obj, but got Unknown
		//IL_243d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2443: Unknown result type (might be due to invalid IL or missing references)
		//IL_24da: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e4: Expected Obj, but got Unknown
		//IL_2599: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a3: Expected Obj, but got Unknown
		//IL_25da: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_267a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2684: Expected Obj, but got Unknown
		//IL_273f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2749: Expected Obj, but got Unknown
		//IL_27cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d9: Expected Obj, but got Unknown
		//IL_28b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28bc: Expected Obj, but got Unknown
		//IL_296e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2978: Expected Obj, but got Unknown
		//IL_29af: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4b: Expected Obj, but got Unknown
		//IL_2ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ada: Expected Obj, but got Unknown
		//IL_2b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b92: Expected Obj, but got Unknown
		//IL_2c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6a: Expected Obj, but got Unknown
		//IL_2c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c86: Expected Obj, but got Unknown
		//IL_2d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d59: Expected Obj, but got Unknown
		//IL_2d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d75: Expected Obj, but got Unknown
		//IL_3156: Unknown result type (might be due to invalid IL or missing references)
		//IL_3160: Expected Obj, but got Unknown
		//IL_3172: Unknown result type (might be due to invalid IL or missing references)
		//IL_317c: Expected Obj, but got Unknown
		//IL_356f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3579: Expected Obj, but got Unknown
		//IL_3610: Unknown result type (might be due to invalid IL or missing references)
		//IL_361a: Expected Obj, but got Unknown
		//IL_36c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d3: Expected Obj, but got Unknown
		//IL_37a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ab: Expected Obj, but got Unknown
		//IL_3966: Unknown result type (might be due to invalid IL or missing references)
		//IL_396c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b59: Expected Obj, but got Unknown
		//IL_3be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bef: Expected Obj, but got Unknown
		//IL_3cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc0: Expected Obj, but got Unknown
		//IL_3e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_40eb: Expected Obj, but got Unknown
		//IL_428c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4296: Expected Obj, but got Unknown
		//IL_439b: Unknown result type (might be due to invalid IL or missing references)
		//IL_43a5: Expected Obj, but got Unknown
		//IL_4788: Unknown result type (might be due to invalid IL or missing references)
		//IL_4792: Expected Obj, but got Unknown
		//IL_486e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4878: Expected Obj, but got Unknown
		//IL_48ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_48b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_48e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_48ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_4993: Unknown result type (might be due to invalid IL or missing references)
		//IL_499d: Expected Obj, but got Unknown
		//IL_4a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a5b: Expected Obj, but got Unknown
		//IL_4b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b29: Expected Obj, but got Unknown
		//IL_4be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bf3: Expected Obj, but got Unknown
		//IL_4cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cc1: Expected Obj, but got Unknown
		//IL_4df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e01: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETIQUETTE_AUTOC));
		Picture_CODE = new PictureBox();
		PrintDocument1 = new PrintDocument();
		Button6 = new Button();
		Panel_CONFIG = new Panel();
		DataGridView_CONTROLS = new DataGridView();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		NumericUpDown_SIZE = new NumericUpDown();
		Label4 = new Label();
		Button_SAVE = new Button();
		NumericUpDown_X = new NumericUpDown();
		Combo_TYPE = new ComboBox();
		NumericUpDown_Y = new NumericUpDown();
		Combo_PRINT = new ComboBox();
		Label_NAME = new Label();
		Label22 = new Label();
		Label3 = new Label();
		Numeric_TICKET_WIDTH = new NumericUpDown();
		Label18 = new Label();
		Numeric_TICKET_HEIGHT = new NumericUpDown();
		Label14 = new Label();
		Label15 = new Label();
		Label17 = new Label();
		Button_MODELE_2 = new Button();
		Button_MODELE_1 = new Button();
		Button_GO = new Button();
		Label7 = new Label();
		Label5 = new Label();
		Numeric_qte = new NumericUpDown();
		Text_prix_v = new TextBox();
		Label2 = new Label();
		Text_article = new TextBox();
		Label1 = new Label();
		Text_code = new TextBox();
		Panel_ETIQUETTE = new Panel();
		Label_TEXT_LIBRE_ = new Label();
		Label_PRIX_V_DECIMAL = new Label();
		Label_RED_BOTTOM = new Label();
		Label_PROMOTION = new Label();
		Label_RED_LEFT = new Label();
		Label_PRIX_V_MINI = new Label();
		Label_RED_RIGHT = new Label();
		Label_RED_TOP = new Label();
		Picture_FLECHE = new PictureBox();
		Label_CODE = new Label();
		Label_PRIX_V = new Label();
		Label_ARTICLE = new Label();
		Picture_UP = new PictureBox();
		Picture_DOWN = new PictureBox();
		Button2 = new Button();
		Button1 = new Button();
		DataGridView2 = new DataGridView();
		CODE_LISTE = new DataGridViewTextBoxColumn();
		ARTICLE_LISTE = new DataGridViewTextBoxColumn();
		PRIX_V_LISTE = new DataGridViewTextBoxColumn();
		PROMOTION_LISTE = new DataGridViewTextBoxColumn();
		LIBRE_LISTE = new DataGridViewTextBoxColumn();
		QTE_LISTE = new DataGridViewTextBoxColumn();
		supp = new DataGridViewButtonColumn();
		Button3 = new Button();
		DataGridView1 = new DataGridView();
		CODE = new DataGridViewTextBoxColumn();
		REFERENCE = new DataGridViewTextBoxColumn();
		ARTICLE = new DataGridViewTextBoxColumn();
		PRIX_V_1 = new DataGridViewTextBoxColumn();
		STOCK = new DataGridViewTextBoxColumn();
		PROMOTION = new DataGridViewTextBoxColumn();
		Button4 = new Button();
		Label9 = new Label();
		NumericUpDown1 = new NumericUpDown();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Panel_FICHE = new Panel();
		Text_LIBRE = new TextBox();
		Label6 = new Label();
		Text_promotion = new TextBox();
		TabPage2 = new TabPage();
		Panel_FIND = new Panel();
		Combo_FIND = new BunifuDropdown();
		Label11 = new Label();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Button5 = new Button();
		Label8 = new Label();
		Label20 = new Label();
		Label21 = new Label();
		Label23 = new Label();
		((ISupportInitialize)Picture_CODE).BeginInit();
		((Control)Panel_CONFIG).SuspendLayout();
		((ISupportInitialize)DataGridView_CONTROLS).BeginInit();
		((ISupportInitialize)NumericUpDown_SIZE).BeginInit();
		((ISupportInitialize)NumericUpDown_X).BeginInit();
		((ISupportInitialize)NumericUpDown_Y).BeginInit();
		((ISupportInitialize)Numeric_TICKET_WIDTH).BeginInit();
		((ISupportInitialize)Numeric_TICKET_HEIGHT).BeginInit();
		((ISupportInitialize)Numeric_qte).BeginInit();
		((Control)Panel_ETIQUETTE).SuspendLayout();
		((ISupportInitialize)Picture_FLECHE).BeginInit();
		((ISupportInitialize)Picture_UP).BeginInit();
		((ISupportInitialize)Picture_DOWN).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel_FICHE).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Picture_CODE).BackColor = Color.White;
		((Control)Picture_CODE).BackgroundImageLayout = (ImageLayout)2;
		Picture_CODE.BorderStyle = (BorderStyle)1;
		PictureBox picture_CODE = Picture_CODE;
		Point location = new Point(8, 31);
		((Control)picture_CODE).Location = location;
		((Control)Picture_CODE).Name = "Picture_CODE";
		PictureBox picture_CODE2 = Picture_CODE;
		Size size = new Size(87, 47);
		((Control)picture_CODE2).Size = size;
		Picture_CODE.TabIndex = 108;
		Picture_CODE.TabStop = false;
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).Image = (Image)componentResourceManager.GetObject("Button6.Image");
		((ButtonBase)Button6).ImageAlign = (ContentAlignment)16;
		Button button = Button6;
		location = new Point(13, 327);
		((Control)button).Location = location;
		((Control)Button6).Name = "Button6";
		Button button2 = Button6;
		size = new Size(116, 30);
		((Control)button2).Size = size;
		((Control)Button6).TabIndex = 995;
		((ButtonBase)Button6).Text = "Paramètres";
		((ButtonBase)Button6).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button6).UseVisualStyleBackColor = true;
		((Control)Panel_CONFIG).BackColor = Color.FromArgb(220, 232, 250);
		Panel_CONFIG.BorderStyle = (BorderStyle)1;
		((Control)Panel_CONFIG).Controls.Add((Control)(object)DataGridView_CONTROLS);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)NumericUpDown_SIZE);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label4);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)NumericUpDown_X);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Combo_TYPE);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)NumericUpDown_Y);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Combo_PRINT);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label_NAME);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label22);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label3);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_TICKET_WIDTH);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label18);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_TICKET_HEIGHT);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label14);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label15);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label17);
		Panel panel_CONFIG = Panel_CONFIG;
		location = new Point(10, 54);
		((Control)panel_CONFIG).Location = location;
		((Control)Panel_CONFIG).Name = "Panel_CONFIG";
		Panel panel_CONFIG2 = Panel_CONFIG;
		size = new Size(551, 267);
		((Control)panel_CONFIG2).Size = size;
		((Control)Panel_CONFIG).TabIndex = 994;
		((Control)Panel_CONFIG).Visible = false;
		DataGridView_CONTROLS.AllowUserToAddRows = false;
		DataGridView_CONTROLS.AllowUserToDeleteRows = false;
		DataGridView_CONTROLS.AllowUserToResizeRows = false;
		((Control)DataGridView_CONTROLS).Anchor = (AnchorStyles)13;
		DataGridView_CONTROLS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_CONTROLS.BackgroundColor = Color.White;
		DataGridView_CONTROLS.BorderStyle = (BorderStyle)2;
		DataGridView_CONTROLS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_CONTROLS.ColumnHeadersVisible = false;
		DataGridView_CONTROLS.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn5
		});
		DataGridView_CONTROLS.EditMode = (DataGridViewEditMode)4;
		DataGridView_CONTROLS.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_CONTROLS = DataGridView_CONTROLS;
		location = new Point(8, 41);
		((Control)dataGridView_CONTROLS).Location = location;
		((Control)DataGridView_CONTROLS).Name = "DataGridView_CONTROLS";
		DataGridView_CONTROLS.RowHeadersVisible = false;
		DataGridView_CONTROLS.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_CONTROLS2 = DataGridView_CONTROLS;
		size = new Size(168, 171);
		((Control)dataGridView_CONTROLS2).Size = size;
		((Control)DataGridView_CONTROLS).TabIndex = 1049;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).MinimumWidth = 2;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Width = 2;
		((UpDownBase)NumericUpDown_SIZE).BackColor = Color.White;
		((Control)NumericUpDown_SIZE).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		NumericUpDown numericUpDown_SIZE = NumericUpDown_SIZE;
		location = new Point(241, 113);
		((Control)numericUpDown_SIZE).Location = location;
		NumericUpDown numericUpDown_SIZE2 = NumericUpDown_SIZE;
		decimal maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		numericUpDown_SIZE2.Maximum = maximum;
		maximum = (NumericUpDown_SIZE.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)NumericUpDown_SIZE).Name = "NumericUpDown_SIZE";
		NumericUpDown numericUpDown_SIZE3 = NumericUpDown_SIZE;
		size = new Size(109, 24);
		((Control)numericUpDown_SIZE3).Size = size;
		((Control)NumericUpDown_SIZE).TabIndex = 1046;
		maximum = (NumericUpDown_SIZE.Value = new decimal(new int[4] { 9, 0, 0, 0 }));
		((Control)Label4).BackColor = Color.Transparent;
		Label4.BorderStyle = (BorderStyle)2;
		((Control)Label4).Font = new Font("Cambria", 9f);
		((Control)Label4).ForeColor = Color.FromArgb(2, 45, 162);
		Label label = Label4;
		location = new Point(8, 5);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(42, 23);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 1006;
		Label4.Text = "Width";
		Label4.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(7, 215);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		Padding margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(535, 42);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1042;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((UpDownBase)NumericUpDown_X).BackColor = Color.White;
		((Control)NumericUpDown_X).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		NumericUpDown numericUpDown_X = NumericUpDown_X;
		location = new Point(241, 50);
		((Control)numericUpDown_X).Location = location;
		maximum = (NumericUpDown_X.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (NumericUpDown_X.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)NumericUpDown_X).Name = "NumericUpDown_X";
		NumericUpDown numericUpDown_X2 = NumericUpDown_X;
		size = new Size(109, 24);
		((Control)numericUpDown_X2).Size = size;
		((Control)NumericUpDown_X).TabIndex = 1043;
		Combo_TYPE.DropDownStyle = (ComboBoxStyle)2;
		((Control)Combo_TYPE).Font = new Font("Tahoma", 8f);
		((ListControl)Combo_TYPE).FormattingEnabled = true;
		Combo_TYPE.Items.AddRange(new object[4] { "CODE128", "EAN13", "UPC", "QR" });
		ComboBox combo_TYPE = Combo_TYPE;
		location = new Point(465, 5);
		((Control)combo_TYPE).Location = location;
		((Control)Combo_TYPE).Name = "Combo_TYPE";
		ComboBox combo_TYPE2 = Combo_TYPE;
		size = new Size(78, 21);
		((Control)combo_TYPE2).Size = size;
		((Control)Combo_TYPE).TabIndex = 988;
		((UpDownBase)NumericUpDown_Y).BackColor = Color.White;
		((Control)NumericUpDown_Y).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		NumericUpDown numericUpDown_Y = NumericUpDown_Y;
		location = new Point(241, 81);
		((Control)numericUpDown_Y).Location = location;
		maximum = (NumericUpDown_Y.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (NumericUpDown_Y.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)NumericUpDown_Y).Name = "NumericUpDown_Y";
		NumericUpDown numericUpDown_Y2 = NumericUpDown_Y;
		size = new Size(109, 24);
		((Control)numericUpDown_Y2).Size = size;
		((Control)NumericUpDown_Y).TabIndex = 1044;
		Combo_PRINT.DropDownStyle = (ComboBoxStyle)2;
		((Control)Combo_PRINT).Font = new Font("Tahoma", 8f);
		((ListControl)Combo_PRINT).FormattingEnabled = true;
		ComboBox combo_PRINT = Combo_PRINT;
		location = new Point(296, 5);
		((Control)combo_PRINT).Location = location;
		((Control)Combo_PRINT).Name = "Combo_PRINT";
		ComboBox combo_PRINT2 = Combo_PRINT;
		size = new Size(115, 21);
		((Control)combo_PRINT2).Size = size;
		((Control)Combo_PRINT).TabIndex = 1023;
		((Control)Label_NAME).BackColor = Color.White;
		Label_NAME.BorderStyle = (BorderStyle)2;
		((Control)Label_NAME).Font = new Font("Cambria", 9f);
		((Control)Label_NAME).ForeColor = Color.FromArgb(2, 45, 162);
		Label label_NAME = Label_NAME;
		location = new Point(356, 87);
		((Control)label_NAME).Location = location;
		((Control)Label_NAME).Name = "Label_NAME";
		Label label_NAME2 = Label_NAME;
		size = new Size(109, 14);
		((Control)label_NAME2).Size = size;
		((Control)Label_NAME).TabIndex = 1045;
		Label_NAME.Text = "-";
		Label_NAME.TextAlign = (ContentAlignment)32;
		((Control)Label22).BackColor = Color.Transparent;
		Label22.BorderStyle = (BorderStyle)2;
		((Control)Label22).Font = new Font("Cambria", 9f);
		((Control)Label22).ForeColor = Color.FromArgb(2, 45, 162);
		Label label3 = Label22;
		location = new Point(125, 5);
		((Control)label3).Location = location;
		((Control)Label22).Name = "Label22";
		Label label4 = Label22;
		size = new Size(43, 23);
		((Control)label4).Size = size;
		((Control)Label22).TabIndex = 1007;
		Label22.Text = "Height";
		Label22.TextAlign = (ContentAlignment)16;
		((Control)Label3).BackColor = Color.Transparent;
		Label3.BorderStyle = (BorderStyle)2;
		((Control)Label3).Font = new Font("Cambria", 9f);
		((Control)Label3).ForeColor = Color.FromArgb(2, 45, 162);
		Label label5 = Label3;
		location = new Point(417, 5);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(42, 23);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 1025;
		Label3.Text = "TYPE";
		Label3.TextAlign = (ContentAlignment)16;
		((UpDownBase)Numeric_TICKET_WIDTH).BackColor = Color.Red;
		NumericUpDown numeric_TICKET_WIDTH = Numeric_TICKET_WIDTH;
		location = new Point(55, 5);
		((Control)numeric_TICKET_WIDTH).Location = location;
		maximum = (Numeric_TICKET_WIDTH.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (Numeric_TICKET_WIDTH.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)Numeric_TICKET_WIDTH).Name = "Numeric_TICKET_WIDTH";
		NumericUpDown numeric_TICKET_WIDTH2 = Numeric_TICKET_WIDTH;
		size = new Size(64, 23);
		((Control)numeric_TICKET_WIDTH2).Size = size;
		((Control)Numeric_TICKET_WIDTH).TabIndex = 1005;
		maximum = (Numeric_TICKET_WIDTH.Value = new decimal(new int[4] { 259, 0, 0, 0 }));
		((Control)Label18).BackColor = Color.Transparent;
		Label18.BorderStyle = (BorderStyle)2;
		((Control)Label18).Font = new Font("Cambria", 9f);
		((Control)Label18).ForeColor = Color.FromArgb(2, 45, 162);
		Label label7 = Label18;
		location = new Point(248, 5);
		((Control)label7).Location = location;
		((Control)Label18).Name = "Label18";
		Label label8 = Label18;
		size = new Size(42, 23);
		((Control)label8).Size = size;
		((Control)Label18).TabIndex = 1024;
		Label18.Text = "PRINT";
		Label18.TextAlign = (ContentAlignment)16;
		((UpDownBase)Numeric_TICKET_HEIGHT).BackColor = Color.Red;
		NumericUpDown numeric_TICKET_HEIGHT = Numeric_TICKET_HEIGHT;
		location = new Point(172, 5);
		((Control)numeric_TICKET_HEIGHT).Location = location;
		maximum = (Numeric_TICKET_HEIGHT.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (Numeric_TICKET_HEIGHT.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)Numeric_TICKET_HEIGHT).Name = "Numeric_TICKET_HEIGHT";
		NumericUpDown numeric_TICKET_HEIGHT2 = Numeric_TICKET_HEIGHT;
		size = new Size(64, 23);
		((Control)numeric_TICKET_HEIGHT2).Size = size;
		((Control)Numeric_TICKET_HEIGHT).TabIndex = 1004;
		maximum = (Numeric_TICKET_HEIGHT.Value = new decimal(new int[4] { 158, 0, 0, 0 }));
		((Control)Label14).BackColor = Color.Transparent;
		Label14.BorderStyle = (BorderStyle)2;
		((Control)Label14).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((Control)Label14).ForeColor = Color.FromArgb(2, 45, 162);
		Label label9 = Label14;
		location = new Point(182, 49);
		((Control)label9).Location = location;
		((Control)Label14).Name = "Label14";
		Label label10 = Label14;
		size = new Size(53, 24);
		((Control)label10).Size = size;
		((Control)Label14).TabIndex = 1002;
		Label14.Text = "X";
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = Color.Transparent;
		Label15.BorderStyle = (BorderStyle)2;
		((Control)Label15).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((Control)Label15).ForeColor = Color.FromArgb(2, 45, 162);
		Label label11 = Label15;
		location = new Point(182, 81);
		((Control)label11).Location = location;
		((Control)Label15).Name = "Label15";
		Label label12 = Label15;
		size = new Size(53, 24);
		((Control)label12).Size = size;
		((Control)Label15).TabIndex = 1003;
		Label15.Text = "Y";
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = Color.Transparent;
		Label17.BorderStyle = (BorderStyle)2;
		((Control)Label17).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((Control)Label17).ForeColor = Color.FromArgb(2, 45, 162);
		Label label13 = Label17;
		location = new Point(182, 113);
		((Control)label13).Location = location;
		((Control)Label17).Name = "Label17";
		Label label14 = Label17;
		size = new Size(53, 24);
		((Control)label14).Size = size;
		((Control)Label17).TabIndex = 1021;
		Label17.Text = "Taille";
		Label17.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_MODELE_2).FlatAppearance.BorderColor = Color.Gray;
		((ButtonBase)Button_MODELE_2).FlatStyle = (FlatStyle)0;
		((Control)Button_MODELE_2).Font = new Font("Tahoma", 13f, (FontStyle)1);
		Button button_MODELE_ = Button_MODELE_2;
		location = new Point(289, 3);
		((Control)button_MODELE_).Location = location;
		((Control)Button_MODELE_2).Name = "Button_MODELE_2";
		Button button_MODELE_2 = Button_MODELE_2;
		size = new Size(272, 46);
		((Control)button_MODELE_2).Size = size;
		((Control)Button_MODELE_2).TabIndex = 1051;
		((ButtonBase)Button_MODELE_2).Text = "Modèle 2";
		((ButtonBase)Button_MODELE_2).UseVisualStyleBackColor = true;
		((ButtonBase)Button_MODELE_1).FlatAppearance.BorderColor = Color.Gray;
		((ButtonBase)Button_MODELE_1).FlatStyle = (FlatStyle)0;
		((Control)Button_MODELE_1).Font = new Font("Tahoma", 13f, (FontStyle)1);
		Button button_MODELE_3 = Button_MODELE_1;
		location = new Point(10, 3);
		((Control)button_MODELE_3).Location = location;
		((Control)Button_MODELE_1).Name = "Button_MODELE_1";
		Button button_MODELE_4 = Button_MODELE_1;
		size = new Size(272, 46);
		((Control)button_MODELE_4).Size = size;
		((Control)Button_MODELE_1).TabIndex = 1050;
		((ButtonBase)Button_MODELE_1).Text = "Modèle 1";
		((ButtonBase)Button_MODELE_1).UseVisualStyleBackColor = true;
		Button button_GO = Button_GO;
		location = new Point(531, 4);
		((Control)button_GO).Location = location;
		((Control)Button_GO).Name = "Button_GO";
		Button button_GO2 = Button_GO;
		size = new Size(10, 10);
		((Control)button_GO2).Size = size;
		((Control)Button_GO).TabIndex = 848;
		((ButtonBase)Button_GO).Text = "GO";
		((ButtonBase)Button_GO).UseVisualStyleBackColor = true;
		((Control)Label7).BackColor = Color.WhiteSmoke;
		((Control)Label7).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.FromArgb(64, 64, 64);
		Label label15 = Label7;
		location = new Point(10, 153);
		((Control)label15).Location = location;
		((Control)Label7).Name = "Label7";
		Label label16 = Label7;
		size = new Size(102, 39);
		((Control)label16).Size = size;
		((Control)Label7).TabIndex = 847;
		Label7.Text = "QTE";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Label5).BackColor = Color.WhiteSmoke;
		((Control)Label5).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.FromArgb(64, 64, 64);
		Label label17 = Label5;
		location = new Point(10, 66);
		((Control)label17).Location = location;
		((Control)Label5).Name = "Label5";
		Label label18 = Label5;
		size = new Size(102, 24);
		((Control)label18).Size = size;
		((Control)Label5).TabIndex = 845;
		Label5.Text = "PRIX_V";
		Label5.TextAlign = (ContentAlignment)16;
		((UpDownBase)Numeric_qte).BorderStyle = (BorderStyle)1;
		((Control)Numeric_qte).Font = new Font("Cambria", 20.25f, (FontStyle)1);
		NumericUpDown numeric_qte = Numeric_qte;
		location = new Point(118, 153);
		((Control)numeric_qte).Location = location;
		((Control)Numeric_qte).Name = "Numeric_qte";
		NumericUpDown numeric_qte2 = Numeric_qte;
		size = new Size(106, 39);
		((Control)numeric_qte2).Size = size;
		((Control)Numeric_qte).TabIndex = 131;
		maximum = (Numeric_qte.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		((TextBoxBase)Text_prix_v).BackColor = Color.FromArgb(54, 198, 236);
		((TextBoxBase)Text_prix_v).BorderStyle = (BorderStyle)1;
		((Control)Text_prix_v).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_prix_v).ForeColor = Color.White;
		TextBox text_prix_v = Text_prix_v;
		location = new Point(118, 66);
		((Control)text_prix_v).Location = location;
		((Control)Text_prix_v).Name = "Text_prix_v";
		TextBox text_prix_v2 = Text_prix_v;
		size = new Size(347, 24);
		((Control)text_prix_v2).Size = size;
		((Control)Text_prix_v).TabIndex = 2;
		((Control)Label2).BackColor = Color.WhiteSmoke;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label19 = Label2;
		location = new Point(10, 35);
		((Control)label19).Location = location;
		((Control)Label2).Name = "Label2";
		Label label20 = Label2;
		size = new Size(102, 24);
		((Control)label20).Size = size;
		((Control)Label2).TabIndex = 839;
		Label2.Text = "ARTICLE";
		Label2.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_article).BackColor = Color.FromArgb(46, 204, 113);
		((TextBoxBase)Text_article).BorderStyle = (BorderStyle)1;
		((Control)Text_article).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_article).ForeColor = Color.White;
		TextBox text_article = Text_article;
		location = new Point(118, 35);
		((Control)text_article).Location = location;
		((Control)Text_article).Name = "Text_article";
		TextBox text_article2 = Text_article;
		size = new Size(423, 24);
		((Control)text_article2).Size = size;
		((Control)Text_article).TabIndex = 1;
		((Control)Label1).BackColor = Color.WhiteSmoke;
		((Control)Label1).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.FromArgb(64, 64, 64);
		Label label21 = Label1;
		location = new Point(10, 5);
		((Control)label21).Location = location;
		((Control)Label1).Name = "Label1";
		Label label22 = Label1;
		size = new Size(102, 24);
		((Control)label22).Size = size;
		((Control)Label1).TabIndex = 710;
		Label1.Text = "CODE";
		Label1.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_code).BackColor = Color.FromArgb(255, 99, 124);
		((TextBoxBase)Text_code).BorderStyle = (BorderStyle)1;
		((Control)Text_code).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_code).ForeColor = Color.White;
		TextBox text_code = Text_code;
		location = new Point(118, 5);
		((Control)text_code).Location = location;
		((Control)Text_code).Name = "Text_code";
		TextBox text_code2 = Text_code;
		size = new Size(423, 24);
		((Control)text_code2).Size = size;
		((Control)Text_code).TabIndex = 0;
		((Control)Panel_ETIQUETTE).BackColor = Color.White;
		Panel_ETIQUETTE.BorderStyle = (BorderStyle)1;
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_TEXT_LIBRE_);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_PRIX_V_DECIMAL);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_RED_BOTTOM);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_PROMOTION);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_RED_LEFT);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_PRIX_V_MINI);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_RED_RIGHT);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_RED_TOP);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Picture_FLECHE);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_CODE);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_PRIX_V);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Label_ARTICLE);
		((Control)Panel_ETIQUETTE).Controls.Add((Control)(object)Picture_CODE);
		((Control)Panel_ETIQUETTE).Enabled = false;
		Panel panel_ETIQUETTE = Panel_ETIQUETTE;
		location = new Point(13, 363);
		((Control)panel_ETIQUETTE).Location = location;
		((Control)Panel_ETIQUETTE).Name = "Panel_ETIQUETTE";
		Panel panel_ETIQUETTE2 = Panel_ETIQUETTE;
		size = new Size(323, 211);
		((Control)panel_ETIQUETTE2).Size = size;
		((Control)Panel_ETIQUETTE).TabIndex = 715;
		Label_TEXT_LIBRE_.AutoSize = true;
		((Control)Label_TEXT_LIBRE_).BackColor = Color.DimGray;
		((Control)Label_TEXT_LIBRE_).Font = new Font("Inconsolata Condensed", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_TEXT_LIBRE_).ForeColor = Color.White;
		Label label_TEXT_LIBRE_ = Label_TEXT_LIBRE_;
		location = new Point(168, 14);
		((Control)label_TEXT_LIBRE_).Location = location;
		Label label_TEXT_LIBRE_2 = Label_TEXT_LIBRE_;
		margin = new Padding(0);
		((Control)label_TEXT_LIBRE_2).Margin = margin;
		((Control)Label_TEXT_LIBRE_).Name = "Label_TEXT_LIBRE_";
		Label label_TEXT_LIBRE_3 = Label_TEXT_LIBRE_;
		size = new Size(106, 23);
		((Control)label_TEXT_LIBRE_3).Size = size;
		((Control)Label_TEXT_LIBRE_).TabIndex = 1040;
		Label_TEXT_LIBRE_.Text = "Label_TEXT_LIBRE";
		Label_PRIX_V_DECIMAL.AutoSize = true;
		((Control)Label_PRIX_V_DECIMAL).BackColor = Color.FromArgb(128, 128, 255);
		((Control)Label_PRIX_V_DECIMAL).Font = new Font("Inconsolata Condensed", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_PRIX_V_DECIMAL).ForeColor = Color.White;
		Label label_PRIX_V_DECIMAL = Label_PRIX_V_DECIMAL;
		location = new Point(125, 123);
		((Control)label_PRIX_V_DECIMAL).Location = location;
		Label label_PRIX_V_DECIMAL2 = Label_PRIX_V_DECIMAL;
		margin = new Padding(0);
		((Control)label_PRIX_V_DECIMAL2).Margin = margin;
		((Control)Label_PRIX_V_DECIMAL).Name = "Label_PRIX_V_DECIMAL";
		Label label_PRIX_V_DECIMAL3 = Label_PRIX_V_DECIMAL;
		size = new Size(130, 23);
		((Control)label_PRIX_V_DECIMAL3).Size = size;
		((Control)Label_PRIX_V_DECIMAL).TabIndex = 1038;
		Label_PRIX_V_DECIMAL.Text = "Label_PRIX_V_DECIMAL";
		((Control)Label_RED_BOTTOM).BackColor = Color.Red;
		((Control)Label_RED_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_RED_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_RED_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RED_BOTTOM).ForeColor = Color.White;
		Label label_RED_BOTTOM = Label_RED_BOTTOM;
		location = new Point(2, 207);
		((Control)label_RED_BOTTOM).Location = location;
		((Control)Label_RED_BOTTOM).Name = "Label_RED_BOTTOM";
		Label label_RED_BOTTOM2 = Label_RED_BOTTOM;
		size = new Size(317, 2);
		((Control)label_RED_BOTTOM2).Size = size;
		((Control)Label_RED_BOTTOM).TabIndex = 1036;
		Label_RED_BOTTOM.TextAlign = (ContentAlignment)16;
		Label_PROMOTION.AutoSize = true;
		((Control)Label_PROMOTION).BackColor = Color.Magenta;
		((Control)Label_PROMOTION).Font = new Font("Inconsolata Condensed", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_PROMOTION).ForeColor = Color.White;
		Label label_PROMOTION = Label_PROMOTION;
		location = new Point(82, 179);
		((Control)label_PROMOTION).Location = location;
		Label label_PROMOTION2 = Label_PROMOTION;
		margin = new Padding(0);
		((Control)label_PROMOTION2).Margin = margin;
		((Control)Label_PROMOTION).Name = "Label_PROMOTION";
		Label label_PROMOTION3 = Label_PROMOTION;
		size = new Size(100, 23);
		((Control)label_PROMOTION3).Size = size;
		((Control)Label_PROMOTION).TabIndex = 1039;
		Label_PROMOTION.Text = "Label_PROMOTION";
		((Control)Label_RED_LEFT).BackColor = Color.Red;
		((Control)Label_RED_LEFT).Cursor = Cursors.Hand;
		((Control)Label_RED_LEFT).Dock = (DockStyle)3;
		((Control)Label_RED_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RED_LEFT).ForeColor = Color.White;
		Label label_RED_LEFT = Label_RED_LEFT;
		location = new Point(0, 2);
		((Control)label_RED_LEFT).Location = location;
		((Control)Label_RED_LEFT).Name = "Label_RED_LEFT";
		Label label_RED_LEFT2 = Label_RED_LEFT;
		size = new Size(2, 207);
		((Control)label_RED_LEFT2).Size = size;
		((Control)Label_RED_LEFT).TabIndex = 1035;
		Label_RED_LEFT.TextAlign = (ContentAlignment)16;
		Label_PRIX_V_MINI.AutoSize = true;
		((Control)Label_PRIX_V_MINI).BackColor = Color.FromArgb(128, 128, 255);
		((Control)Label_PRIX_V_MINI).Font = new Font("Inconsolata ExtraBold", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_PRIX_V_MINI).ForeColor = Color.White;
		Label label_PRIX_V_MINI = Label_PRIX_V_MINI;
		location = new Point(29, 137);
		((Control)label_PRIX_V_MINI).Location = location;
		Label label_PRIX_V_MINI2 = Label_PRIX_V_MINI;
		margin = new Padding(0);
		((Control)label_PRIX_V_MINI2).Margin = margin;
		((Control)Label_PRIX_V_MINI).Name = "Label_PRIX_V_MINI";
		Label label_PRIX_V_MINI3 = Label_PRIX_V_MINI;
		size = new Size(146, 23);
		((Control)label_PRIX_V_MINI3).Size = size;
		((Control)Label_PRIX_V_MINI).TabIndex = 1037;
		Label_PRIX_V_MINI.Text = "Label_PRIX_V_MINI";
		((Control)Label_RED_RIGHT).BackColor = Color.Red;
		((Control)Label_RED_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RED_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RED_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RED_RIGHT).ForeColor = Color.White;
		Label label_RED_RIGHT = Label_RED_RIGHT;
		location = new Point(319, 2);
		((Control)label_RED_RIGHT).Location = location;
		((Control)Label_RED_RIGHT).Name = "Label_RED_RIGHT";
		Label label_RED_RIGHT2 = Label_RED_RIGHT;
		size = new Size(2, 207);
		((Control)label_RED_RIGHT2).Size = size;
		((Control)Label_RED_RIGHT).TabIndex = 1034;
		Label_RED_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_RED_TOP).BackColor = Color.Red;
		((Control)Label_RED_TOP).Cursor = Cursors.Hand;
		((Control)Label_RED_TOP).Dock = (DockStyle)1;
		((Control)Label_RED_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RED_TOP).ForeColor = Color.White;
		Label label_RED_TOP = Label_RED_TOP;
		location = new Point(0, 0);
		((Control)label_RED_TOP).Location = location;
		((Control)Label_RED_TOP).Name = "Label_RED_TOP";
		Label label_RED_TOP2 = Label_RED_TOP;
		size = new Size(321, 2);
		((Control)label_RED_TOP2).Size = size;
		((Control)Label_RED_TOP).TabIndex = 1033;
		Label_RED_TOP.TextAlign = (ContentAlignment)16;
		((Control)Picture_FLECHE).BackgroundImage = (Image)componentResourceManager.GetObject("Picture_FLECHE.BackgroundImage");
		((Control)Picture_FLECHE).BackgroundImageLayout = (ImageLayout)3;
		Picture_FLECHE.BorderStyle = (BorderStyle)1;
		PictureBox picture_FLECHE = Picture_FLECHE;
		location = new Point(278, 5);
		((Control)picture_FLECHE).Location = location;
		((Control)Picture_FLECHE).Name = "Picture_FLECHE";
		PictureBox picture_FLECHE2 = Picture_FLECHE;
		size = new Size(35, 79);
		((Control)picture_FLECHE2).Size = size;
		Picture_FLECHE.SizeMode = (PictureBoxSizeMode)4;
		Picture_FLECHE.TabIndex = 1000;
		Picture_FLECHE.TabStop = false;
		((Control)Picture_FLECHE).Tag = "1";
		Label_CODE.AutoSize = true;
		((Control)Label_CODE).BackColor = Color.FromArgb(192, 192, 0);
		((Control)Label_CODE).Font = new Font("Inconsolata Condensed", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_CODE).ForeColor = Color.White;
		Label label_CODE = Label_CODE;
		location = new Point(98, 14);
		((Control)label_CODE).Location = location;
		((Control)Label_CODE).Name = "Label_CODE";
		Label label_CODE2 = Label_CODE;
		size = new Size(70, 23);
		((Control)label_CODE2).Size = size;
		((Control)Label_CODE).TabIndex = 111;
		Label_CODE.Text = "Label_CODE";
		Label_PRIX_V.AutoSize = true;
		((Control)Label_PRIX_V).BackColor = Color.FromArgb(54, 198, 236);
		((Control)Label_PRIX_V).Font = new Font("Inconsolata ExtraBold", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_PRIX_V).ForeColor = Color.White;
		Label label_PRIX_V = Label_PRIX_V;
		location = new Point(131, 64);
		((Control)label_PRIX_V).Location = location;
		Label label_PRIX_V2 = Label_PRIX_V;
		margin = new Padding(0);
		((Control)label_PRIX_V2).Margin = margin;
		((Control)Label_PRIX_V).Name = "Label_PRIX_V";
		Label label_PRIX_V3 = Label_PRIX_V;
		size = new Size(106, 23);
		((Control)label_PRIX_V3).Size = size;
		((Control)Label_PRIX_V).TabIndex = 110;
		Label_PRIX_V.Text = "Label_PRIX_V";
		Label_ARTICLE.AutoSize = true;
		((Control)Label_ARTICLE).BackColor = Color.FromArgb(46, 204, 113);
		((Control)Label_ARTICLE).Font = new Font("Inconsolata Condensed", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_ARTICLE).ForeColor = Color.White;
		Label label_ARTICLE = Label_ARTICLE;
		location = new Point(8, 14);
		((Control)label_ARTICLE).Location = location;
		((Control)Label_ARTICLE).Name = "Label_ARTICLE";
		Label label_ARTICLE2 = Label_ARTICLE;
		size = new Size(88, 23);
		((Control)label_ARTICLE2).Size = size;
		((Control)Label_ARTICLE).TabIndex = 109;
		Label_ARTICLE.Text = "Label_ARTICLE";
		((Control)Picture_UP).BackgroundImage = (Image)componentResourceManager.GetObject("Picture_UP.BackgroundImage");
		((Control)Picture_UP).BackgroundImageLayout = (ImageLayout)3;
		Picture_UP.BorderStyle = (BorderStyle)1;
		PictureBox picture_UP = Picture_UP;
		location = new Point(381, 416);
		((Control)picture_UP).Location = location;
		((Control)Picture_UP).Name = "Picture_UP";
		PictureBox picture_UP2 = Picture_UP;
		size = new Size(35, 79);
		((Control)picture_UP2).Size = size;
		Picture_UP.SizeMode = (PictureBoxSizeMode)4;
		Picture_UP.TabIndex = 1032;
		Picture_UP.TabStop = false;
		((Control)Picture_UP).Visible = false;
		((Control)Picture_DOWN).BackgroundImage = (Image)componentResourceManager.GetObject("Picture_DOWN.BackgroundImage");
		((Control)Picture_DOWN).BackgroundImageLayout = (ImageLayout)3;
		Picture_DOWN.BorderStyle = (BorderStyle)1;
		PictureBox picture_DOWN = Picture_DOWN;
		location = new Point(381, 404);
		((Control)picture_DOWN).Location = location;
		((Control)Picture_DOWN).Name = "Picture_DOWN";
		PictureBox picture_DOWN2 = Picture_DOWN;
		size = new Size(35, 79);
		((Control)picture_DOWN2).Size = size;
		Picture_DOWN.SizeMode = (PictureBoxSizeMode)4;
		Picture_DOWN.TabIndex = 1031;
		Picture_DOWN.TabStop = false;
		((Control)Picture_DOWN).Visible = false;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button3 = Button2;
		location = new Point(428, 585);
		((Control)button3).Location = location;
		((Control)Button2).Name = "Button2";
		Button button4 = Button2;
		size = new Size(136, 39);
		((Control)button4).Size = size;
		((Control)Button2).TabIndex = 129;
		((ButtonBase)Button2).Text = "   Imprimer";
		((ButtonBase)Button2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button5 = Button1;
		location = new Point(6, 585);
		((Control)button5).Location = location;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(136, 39);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 128;
		((ButtonBase)Button1).Text = "    Aperçu";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToResizeColumns = false;
		DataGridView2.AllowUserToResizeRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)CODE_LISTE,
			(DataGridViewColumn)ARTICLE_LISTE,
			(DataGridViewColumn)PRIX_V_LISTE,
			(DataGridViewColumn)PROMOTION_LISTE,
			(DataGridViewColumn)LIBRE_LISTE,
			(DataGridViewColumn)QTE_LISTE,
			(DataGridViewColumn)supp
		});
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView2;
		location = new Point(13, 351);
		((Control)dataGridView).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersVisible = false;
		DataGridView2.RowHeadersWidth = 11;
		DataGridView2.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView2;
		size = new Size(544, 216);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView2).TabIndex = 132;
		((DataGridViewColumn)CODE_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_LISTE).FillWeight = 102.0408f;
		((DataGridViewColumn)CODE_LISTE).HeaderText = "CODE";
		((DataGridViewColumn)CODE_LISTE).Name = "CODE_LISTE";
		((DataGridViewColumn)CODE_LISTE).Width = 50;
		((DataGridViewColumn)ARTICLE_LISTE).FillWeight = 98.97959f;
		((DataGridViewColumn)ARTICLE_LISTE).HeaderText = "ARTICLE";
		((DataGridViewColumn)ARTICLE_LISTE).Name = "ARTICLE_LISTE";
		((DataGridViewColumn)PRIX_V_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V_LISTE).FillWeight = 98.97959f;
		((DataGridViewColumn)PRIX_V_LISTE).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V_LISTE).Name = "PRIX_V_LISTE";
		((DataGridViewColumn)PRIX_V_LISTE).Width = 60;
		((DataGridViewColumn)PROMOTION_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PROMOTION_LISTE).HeaderText = "PROMOTION";
		((DataGridViewColumn)PROMOTION_LISTE).MinimumWidth = 2;
		((DataGridViewColumn)PROMOTION_LISTE).Name = "PROMOTION_LISTE";
		((DataGridViewColumn)PROMOTION_LISTE).Width = 2;
		((DataGridViewColumn)LIBRE_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)LIBRE_LISTE).HeaderText = "LIBRE_LISTE";
		((DataGridViewColumn)LIBRE_LISTE).MinimumWidth = 2;
		((DataGridViewColumn)LIBRE_LISTE).Name = "LIBRE_LISTE";
		((DataGridViewColumn)LIBRE_LISTE).Width = 2;
		((DataGridViewColumn)QTE_LISTE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)QTE_LISTE).HeaderText = "QTE";
		((DataGridViewColumn)QTE_LISTE).Name = "QTE_LISTE";
		((DataGridViewColumn)QTE_LISTE).Width = 50;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).HeaderText = "supp";
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Width = 40;
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Segoe UI", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button7 = Button3;
		location = new Point(212, 573);
		((Control)button7).Location = location;
		((Control)Button3).Name = "Button3";
		Button button8 = Button3;
		size = new Size(142, 53);
		((Control)button8).Size = size;
		((Control)Button3).TabIndex = 133;
		((ButtonBase)Button3).Text = "  Lancer";
		((ButtonBase)Button3).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[6]
		{
			(DataGridViewColumn)CODE,
			(DataGridViewColumn)REFERENCE,
			(DataGridViewColumn)ARTICLE,
			(DataGridViewColumn)PRIX_V_1,
			(DataGridViewColumn)STOCK,
			(DataGridViewColumn)PROMOTION
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView1;
		location = new Point(13, 56);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView1;
		size = new Size(544, 247);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView1).TabIndex = 850;
		((DataGridViewColumn)CODE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE).DataPropertyName = "CODE";
		((DataGridViewColumn)CODE).FillWeight = 102.0408f;
		((DataGridViewColumn)CODE).HeaderText = "CODE";
		((DataGridViewColumn)CODE).Name = "CODE";
		((DataGridViewColumn)CODE).Width = 50;
		((DataGridViewColumn)REFERENCE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)REFERENCE).DataPropertyName = "REFERENCE";
		((DataGridViewColumn)REFERENCE).HeaderText = "REFERENCE";
		((DataGridViewColumn)REFERENCE).Name = "REFERENCE";
		((DataGridViewColumn)REFERENCE).Width = 88;
		((DataGridViewColumn)ARTICLE).DataPropertyName = "ARTICLE";
		((DataGridViewColumn)ARTICLE).FillWeight = 98.97959f;
		((DataGridViewColumn)ARTICLE).HeaderText = "ARTICLE";
		((DataGridViewColumn)ARTICLE).Name = "ARTICLE";
		((DataGridViewColumn)PRIX_V_1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V_1).DataPropertyName = "PRIX_V_1";
		((DataGridViewColumn)PRIX_V_1).FillWeight = 98.97959f;
		((DataGridViewColumn)PRIX_V_1).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V_1).Name = "PRIX_V_1";
		((DataGridViewColumn)PRIX_V_1).Width = 60;
		((DataGridViewColumn)STOCK).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK).DataPropertyName = "STOCK";
		((DataGridViewColumn)STOCK).HeaderText = "STOCK";
		((DataGridViewColumn)STOCK).Name = "STOCK";
		((DataGridViewColumn)STOCK).Width = 66;
		((DataGridViewColumn)PROMOTION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PROMOTION).DataPropertyName = "PROMOTION";
		((DataGridViewColumn)PROMOTION).HeaderText = "PROMOTION";
		((DataGridViewColumn)PROMOTION).Name = "PROMOTION";
		((DataGridViewColumn)PROMOTION).Width = 20;
		((Control)Button4).Cursor = Cursors.Hand;
		((ButtonBase)Button4).Image = (Image)componentResourceManager.GetObject("Button4.Image");
		Button button9 = Button4;
		location = new Point(209, 306);
		((Control)button9).Location = location;
		((Control)Button4).Name = "Button4";
		Button button10 = Button4;
		size = new Size(65, 39);
		((Control)button10).Size = size;
		((Control)Button4).TabIndex = 985;
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Label9).BackColor = Color.Transparent;
		Label9.BorderStyle = (BorderStyle)2;
		((Control)Label9).Font = new Font("Cambria", 12f);
		((Control)Label9).ForeColor = Color.FromArgb(2, 45, 162);
		Label label23 = Label9;
		location = new Point(13, 306);
		((Control)label23).Location = location;
		((Control)Label9).Name = "Label9";
		Label label24 = Label9;
		size = new Size(65, 39);
		((Control)label24).Size = size;
		((Control)Label9).TabIndex = 987;
		Label9.Text = "QTE";
		Label9.TextAlign = (ContentAlignment)16;
		((UpDownBase)NumericUpDown1).BorderStyle = (BorderStyle)1;
		((Control)NumericUpDown1).Font = new Font("Cambria", 20.25f, (FontStyle)1);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(78, 306);
		((Control)numericUpDown).Location = location;
		((Control)NumericUpDown1).Name = "NumericUpDown1";
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(65, 39);
		((Control)numericUpDown2).Size = size;
		((Control)NumericUpDown1).TabIndex = 986;
		maximum = (NumericUpDown1.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl1).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl = TabControl1;
		size = new Size(60, 28);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl1;
		location = new Point(12, 12);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(578, 668);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 994;
		TabPage1.BackColor = Color.FromArgb(249, 249, 249);
		((Control)TabPage1).Controls.Add((Control)(object)Button_MODELE_2);
		((Control)TabPage1).Controls.Add((Control)(object)Button6);
		((Control)TabPage1).Controls.Add((Control)(object)Button_MODELE_1);
		((Control)TabPage1).Controls.Add((Control)(object)Button2);
		((Control)TabPage1).Controls.Add((Control)(object)Button1);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_ETIQUETTE);
		((Control)TabPage1).Controls.Add((Control)(object)Picture_UP);
		((Control)TabPage1).Controls.Add((Control)(object)Picture_DOWN);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_CONFIG);
		((Control)TabPage1).Controls.Add((Control)(object)Panel_FICHE);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(570, 632);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "Imprimer";
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_LIBRE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label6);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_promotion);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label1);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_GO);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_code);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label7);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_article);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label5);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Numeric_qte);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_prix_v);
		Panel panel_FICHE = Panel_FICHE;
		location = new Point(10, 54);
		((Control)panel_FICHE).Location = location;
		((Control)Panel_FICHE).Name = "Panel_FICHE";
		Panel panel_FICHE2 = Panel_FICHE;
		size = new Size(551, 267);
		((Control)panel_FICHE2).Size = size;
		((Control)Panel_FICHE).TabIndex = 996;
		((TextBoxBase)Text_LIBRE).BackColor = Color.DimGray;
		((TextBoxBase)Text_LIBRE).BorderStyle = (BorderStyle)1;
		((Control)Text_LIBRE).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_LIBRE).ForeColor = Color.White;
		TextBox text_LIBRE = Text_LIBRE;
		location = new Point(118, 96);
		((Control)text_LIBRE).Location = location;
		((Control)Text_LIBRE).Name = "Text_LIBRE";
		TextBox text_LIBRE2 = Text_LIBRE;
		size = new Size(423, 24);
		((Control)text_LIBRE2).Size = size;
		((Control)Text_LIBRE).TabIndex = 850;
		((Control)Label6).BackColor = Color.WhiteSmoke;
		((Control)Label6).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.FromArgb(64, 64, 64);
		Label label25 = Label6;
		location = new Point(10, 96);
		((Control)label25).Location = location;
		((Control)Label6).Name = "Label6";
		Label label26 = Label6;
		size = new Size(102, 24);
		((Control)label26).Size = size;
		((Control)Label6).TabIndex = 851;
		Label6.Text = "TEXT LIBRE";
		Label6.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_promotion).BackColor = Color.Fuchsia;
		((TextBoxBase)Text_promotion).BorderStyle = (BorderStyle)1;
		((Control)Text_promotion).Enabled = false;
		((Control)Text_promotion).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_promotion).ForeColor = Color.White;
		TextBox text_promotion = Text_promotion;
		location = new Point(471, 66);
		((Control)text_promotion).Location = location;
		((Control)Text_promotion).Name = "Text_promotion";
		TextBox text_promotion2 = Text_promotion;
		size = new Size(70, 24);
		((Control)text_promotion2).Size = size;
		((Control)Text_promotion).TabIndex = 849;
		TabPage2.BackColor = Color.FromArgb(249, 249, 249);
		((Control)TabPage2).Controls.Add((Control)(object)Panel_FIND);
		((Control)TabPage2).Controls.Add((Control)(object)Button5);
		((Control)TabPage2).Controls.Add((Control)(object)Button3);
		((Control)TabPage2).Controls.Add((Control)(object)Button4);
		((Control)TabPage2).Controls.Add((Control)(object)NumericUpDown1);
		((Control)TabPage2).Controls.Add((Control)(object)Label9);
		((Control)TabPage2).Controls.Add((Control)(object)DataGridView1);
		((Control)TabPage2).Controls.Add((Control)(object)DataGridView2);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 32);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		margin = new Padding(3);
		((Control)tabPage5).Padding = margin;
		TabPage tabPage6 = TabPage2;
		size = new Size(570, 632);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Imprimer Liste";
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label11);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		Panel panel_FIND = Panel_FIND;
		location = new Point(13, 6);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(544, 44);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1056;
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
		((ComboBox)Combo_FIND).Items.AddRange(new object[4] { "Code", "Article", "Famille", "REFERENCE" });
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
		Label11.AutoSize = true;
		((Control)Label11).Font = new Font("Segoe UI", 9.75f);
		((Control)Label11).ForeColor = Color.White;
		Label11.ImeMode = (ImeMode)0;
		Label label27 = Label11;
		location = new Point(492, 13);
		((Control)label27).Location = location;
		((Control)Label11).Name = "Label11";
		Label label28 = Label11;
		size = new Size(50, 18);
		((Control)label28).Size = size;
		((Control)Label11).TabIndex = 1054;
		Label11.Text = "Exacte";
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
		location = new Point(465, 9);
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
		location = new Point(386, 6);
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
		location = new Point(128, 6);
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
		size = new Size(291, 33);
		((Control)text_FIND4).Size = size;
		((Control)Text_FIND).TabIndex = 986;
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		Button button11 = Button5;
		location = new Point(280, 306);
		((Control)button11).Location = location;
		((Control)Button5).Name = "Button5";
		Button button12 = Button5;
		size = new Size(81, 39);
		((Control)button12).Size = size;
		((Control)Button5).TabIndex = 997;
		((ButtonBase)Button5).UseVisualStyleBackColor = true;
		((Control)Label8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label8).Cursor = Cursors.Hand;
		((Control)Label8).Dock = (DockStyle)2;
		((Control)Label8).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label29 = Label8;
		location = new Point(4, 688);
		((Control)label29).Location = location;
		((Control)Label8).Name = "Label8";
		Label label30 = Label8;
		size = new Size(592, 4);
		((Control)label30).Size = size;
		((Control)Label8).TabIndex = 998;
		Label8.TextAlign = (ContentAlignment)16;
		((Control)Label20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label20).Cursor = Cursors.Hand;
		((Control)Label20).Dock = (DockStyle)3;
		((Control)Label20).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.White;
		Label label31 = Label20;
		location = new Point(0, 4);
		((Control)label31).Location = location;
		((Control)Label20).Name = "Label20";
		Label label32 = Label20;
		size = new Size(4, 688);
		((Control)label32).Size = size;
		((Control)Label20).TabIndex = 997;
		Label20.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Dock = (DockStyle)4;
		((Control)Label21).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label33 = Label21;
		location = new Point(596, 4);
		((Control)label33).Location = location;
		((Control)Label21).Name = "Label21";
		Label label34 = Label21;
		size = new Size(4, 688);
		((Control)label34).Size = size;
		((Control)Label21).TabIndex = 996;
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Label23).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label23).Cursor = Cursors.Hand;
		((Control)Label23).Dock = (DockStyle)1;
		((Control)Label23).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label35 = Label23;
		location = new Point(0, 0);
		((Control)label35).Location = location;
		((Control)Label23).Name = "Label23";
		Label label36 = Label23;
		size = new Size(600, 4);
		((Control)label36).Size = size;
		((Control)Label23).TabIndex = 995;
		Label23.Text = "-";
		Label23.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(600, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label20);
		((Control)this).Controls.Add((Control)(object)Label21);
		((Control)this).Controls.Add((Control)(object)Label23);
		((Control)this).Controls.Add((Control)(object)TabControl1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_ETIQUETTE_AUTOC";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "AUTOCOLLANT";
		((ISupportInitialize)Picture_CODE).EndInit();
		((Control)Panel_CONFIG).ResumeLayout(false);
		((ISupportInitialize)DataGridView_CONTROLS).EndInit();
		((ISupportInitialize)NumericUpDown_SIZE).EndInit();
		((ISupportInitialize)NumericUpDown_X).EndInit();
		((ISupportInitialize)NumericUpDown_Y).EndInit();
		((ISupportInitialize)Numeric_TICKET_WIDTH).EndInit();
		((ISupportInitialize)Numeric_TICKET_HEIGHT).EndInit();
		((ISupportInitialize)Numeric_qte).EndInit();
		((Control)Panel_ETIQUETTE).ResumeLayout(false);
		((Control)Panel_ETIQUETTE).PerformLayout();
		((ISupportInitialize)Picture_FLECHE).EndInit();
		((ISupportInitialize)Picture_UP).EndInit();
		((ISupportInitialize)Picture_DOWN).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel_FICHE).ResumeLayout(false);
		((Control)Panel_FICHE).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public void GenerateBarcode(string inputData)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		QREncoder = new QRCodeEncoder();
		QREncoder.QRCodeForegroundColor = Color.Black;
		QREncoder.QRCodeBackgroundColor = Color.White;
		QREncoder.QRCodeScale = 2;
		QREncoder.QRCodeVersion = 2;
		QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)0;
		QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
		try
		{
			QRimg = (Image)(object)QREncoder.Encode(inputData);
			QRbitmap = new Bitmap(QRimg);
			barcodeImage = QRbitmap;
			Picture_CODE.Image = (Image)(object)barcodeImage;
			((Control)Picture_CODE).Width = ((Image)barcodeImage).Width;
			((Control)Picture_CODE).Height = ((Image)barcodeImage).Height;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception e = ex;
			StackTrace stackTrace = new StackTrace(e, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			ProjectData.ClearProjectError();
		}
	}

	private void CreateUPC()
	{
		ProductType = Text_code.Text.Substring(0, 1);
		ManufacturerCode = Text_code.Text.Substring(1, 5);
		ProductCode = Text_code.Text.Substring(6, 5);
		if (Text_code.Text.Substring(11, 1).Length > 0)
		{
			ChecksumDigit = Text_code.Text.Substring(11, 1);
		}
	}

	public Bitmap CreateBitmap()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		float num = Width * Scale * 100f;
		float num2 = Height * Scale * 100f;
		checked
		{
			Bitmap val = new Bitmap((int)Math.Round(num), (int)Math.Round(num2));
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			float num3 = Width * Scale;
			float num4 = Height * Scale;
			float num5 = num3 / 113f;
			GraphicsState val3 = val2.Save();
			val2.PageUnit = (GraphicsUnit)4;
			val2.PageScale = 1f;
			SolidBrush val4 = new SolidBrush(Color.Black);
			float num6 = 0f;
			StringBuilder stringBuilder = new StringBuilder();
			float num7 = 0f;
			float num8 = 0f;
			float num9 = 0f;
			Font val5 = new Font("Segoe UI", _fFontSize * Scale);
			CalculateChecksumDigit();
			stringBuilder.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{1}{0}", new object[7]
			{
				_sQuiteZone,
				_sLeadTail,
				ConvertToDigitPatterns(ProductType, _aLeft),
				ConvertToDigitPatterns(ManufacturerCode, _aLeft),
				_sSeparator,
				ConvertToDigitPatterns(ProductCode, _aRight),
				ConvertToDigitPatterns(ChecksumDigit, _aRight)
			});
			string text = stringBuilder.ToString();
			float height = val2.MeasureString(text, val5).Height;
			int num10 = stringBuilder.Length - 1;
			int num11 = 0;
			while (true)
			{
				int num12 = num11;
				int num13 = num10;
				if (num12 > num13)
				{
					break;
				}
				if (Operators.CompareString(text.Substring(num11, 1), "1", TextCompare: false) == 0)
				{
					if (num7 == 0f)
					{
						num7 = num6;
					}
					if (((num11 > 19 && num11 < 56) || (num11 > 59 && num11 < 95)) ? true : false)
					{
						val2.FillRectangle((Brush)(object)val4, num6, num8, num5, num4 - height);
					}
					else
					{
						val2.FillRectangle((Brush)(object)val4, num6, num8, num5, num4);
					}
				}
				num6 += num5;
				num9 = num6;
				num11++;
			}
			num6 = num7 - val2.MeasureString(ProductType, val5).Width;
			float y = num8 + (num4 - height);
			string productType = ProductType;
			PointF pointF = new PointF(num6, y);
			val2.DrawString(productType, val5, (Brush)(object)val4, pointF);
			num6 += val2.MeasureString(ProductType, val5).Width + 45f * num5 - val2.MeasureString(ManufacturerCode, val5).Width;
			string manufacturerCode = ManufacturerCode;
			pointF = new PointF(num6, y);
			val2.DrawString(manufacturerCode, val5, (Brush)(object)val4, pointF);
			num6 += val2.MeasureString(ManufacturerCode, val5).Width + 5f * num5;
			string productCode = ProductCode;
			pointF = new PointF(num6, y);
			val2.DrawString(productCode, val5, (Brush)(object)val4, pointF);
			num6 += 46f * num5;
			string checksumDigit = ChecksumDigit;
			pointF = new PointF(num6, y);
			val2.DrawString(checksumDigit, val5, (Brush)(object)val4, pointF);
			val2.Restore(val3);
			val2.Dispose();
			return val;
		}
	}

	public void DrawUpcaBarcode(Graphics g, Point pt)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		float num = Width * Scale;
		float num2 = Height * Scale;
		float num3 = num / 113f;
		GraphicsState val = g.Save();
		g.PageUnit = (GraphicsUnit)4;
		g.PageScale = 1f;
		SolidBrush val2 = new SolidBrush(Color.Black);
		float num4 = Convert.ToSingle((double)((Control)Picture_CODE).Left / 100.0);
		StringBuilder stringBuilder = new StringBuilder();
		float num5 = 0f;
		float num6 = Convert.ToSingle((double)((Control)Picture_CODE).Top / 100.0);
		float num7 = 0f;
		Font val3 = new Font("Segoe UI", _fFontSize * Scale);
		CalculateChecksumDigit();
		stringBuilder.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{1}{0}", new object[7]
		{
			_sQuiteZone,
			_sLeadTail,
			ConvertToDigitPatterns(ProductType, _aLeft),
			ConvertToDigitPatterns(ManufacturerCode, _aLeft),
			_sSeparator,
			ConvertToDigitPatterns(ProductCode, _aRight),
			ConvertToDigitPatterns(ChecksumDigit, _aRight)
		});
		string text = stringBuilder.ToString();
		float height = g.MeasureString(text, val3).Height;
		checked
		{
			int num8 = stringBuilder.Length - 1;
			int num9 = 0;
			while (true)
			{
				int num10 = num9;
				int num11 = num8;
				if (num10 > num11)
				{
					break;
				}
				if (Operators.CompareString(text.Substring(num9, 1), "1", TextCompare: false) == 0)
				{
					if (num5 == 0f)
					{
						num5 = num4;
					}
					if (((num9 > 19 && num9 < 56) || (num9 > 59 && num9 < 95)) ? true : false)
					{
						g.FillRectangle((Brush)(object)val2, num4, num6, num3, num2 - height);
					}
					else
					{
						g.FillRectangle((Brush)(object)val2, num4, num6, num3, num2);
					}
				}
				num4 += num3;
				num7 = num4;
				num9++;
			}
			num4 = num5 - g.MeasureString(ProductType, val3).Width;
			float y = num6 + (num2 - height);
			string productType = ProductType;
			PointF pointF = new PointF(num4, y);
			g.DrawString(productType, val3, (Brush)(object)val2, pointF);
			num4 += g.MeasureString(ProductType, val3).Width + 45f * num3 - g.MeasureString(ManufacturerCode, val3).Width;
			string manufacturerCode = ManufacturerCode;
			pointF = new PointF(num4, y);
			g.DrawString(manufacturerCode, val3, (Brush)(object)val2, pointF);
			num4 += g.MeasureString(ManufacturerCode, val3).Width + 5f * num3;
			string productCode = ProductCode;
			pointF = new PointF(num4, y);
			g.DrawString(productCode, val3, (Brush)(object)val2, pointF);
			num4 += 46f * num3;
			string checksumDigit = ChecksumDigit;
			pointF = new PointF(num4, y);
			g.DrawString(checksumDigit, val3, (Brush)(object)val2, pointF);
			g.Restore(val);
		}
	}

	public string ConvertToDigitPatterns(string inputNumber, string[] patterns)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		checked
		{
			int num2 = inputNumber.Length - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				num = Convert.ToInt32(inputNumber.Substring(num3, 1));
				stringBuilder.Append(patterns[num]);
				num3++;
			}
			return stringBuilder.ToString();
		}
	}

	public void CalculateChecksumDigit()
	{
		string text = ProductType + ManufacturerCode + ProductCode;
		int num = 0;
		int num2 = 0;
		int length = text.Length;
		int num3 = 1;
		checked
		{
			while (true)
			{
				int num4 = num3;
				int num5 = length;
				if (num4 > num5)
				{
					break;
				}
				num2 = Convert.ToInt32(text.Substring(num3 - 1, 1));
				num = ((unchecked(num3 % 2) != 0) ? (num + num2 * 3) : (num + num2 * 1));
				num3++;
			}
		}
		ChecksumDigit = (checked(10 - unchecked(num % 10)) % 10).ToString();
	}

	public void a()
	{
	}

	public void b(string mfgNumber, string productId)
	{
		ProductType = "0";
		ManufacturerCode = mfgNumber;
		ProductCode = productId;
		CalculateChecksumDigit();
	}

	public void c(string productType, string mfgNumber, string productId)
	{
		ProductType = productType;
		ManufacturerCode = mfgNumber;
		ProductCode = productId;
		CalculateChecksumDigit();
	}

	public void d(string productType, string mfgNumber, string productId, string checkDigit)
	{
		ProductType = productType;
		ManufacturerCode = mfgNumber;
		ProductCode = productId;
		ChecksumDigit = checkDigit;
	}

	private void FormDialog_ETIQUETTE_AUTOC_Shown(object sender, EventArgs e)
	{
		Button_GO.PerformClick();
	}

	private void FormDialog_ETIQUETTE_AUTOC_Load(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 2;
				Combo_PRINT.Items.Add((object)"");
				foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
				{
					string text = Conversions.ToString(installedPrinter);
					Combo_PRINT.Items.Add((object)text);
				}
				Button_MODELE_1.PerformClick();
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
				tabControl.ItemSize = itemSize;
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

	private void _CONTROL_Click(object sender, EventArgs e)
	{
	}

	private void _CONTROL_MouseClick(object sender, MouseEventArgs e)
	{
		checked
		{
			try
			{
				Label_NAME.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
				int num = DataGridView_CONTROLS.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						if (Operators.ConditionalCompareObjectEqual(DataGridView_CONTROLS.Rows[num2].Cells[0].Value, NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), TextCompare: false))
						{
							DataGridView_CONTROLS.CurrentCell = DataGridView_CONTROLS.Rows[num2].Cells[0];
							DataGridView_CONTROLS.Rows[num2].Selected = true;
						}
						num2++;
						continue;
					}
					break;
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
	}

	private void _CONTROL_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Label_NAME.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
				int num = DataGridView_CONTROLS.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView_CONTROLS.Rows[num2].Cells[0].Value, NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), TextCompare: false))
					{
						DataGridView_CONTROLS.CurrentCell = DataGridView_CONTROLS.Rows[num2].Cells[0];
						DataGridView_CONTROLS.Rows[num2].Selected = true;
					}
					num2++;
				}
				if (sender is Label)
				{
					Label val = (Label)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
					NumericUpDown_X.Value = new decimal(((Control)val).Left);
					NumericUpDown_Y.Value = new decimal(((Control)val).Top);
					NumericUpDown_SIZE.Value = new decimal(((Control)val).Font.Size);
				}
				else if (sender is PictureBox)
				{
					PictureBox val2 = (PictureBox)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
					NumericUpDown_X.Value = new decimal(((Control)val2).Left);
					NumericUpDown_Y.Value = new decimal(((Control)val2).Top);
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
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		try
		{
			PrintDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", Convert.ToInt32(Numeric_TICKET_WIDTH.Value), Convert.ToInt32(Numeric_TICKET_HEIGHT.Value));
			PrintPreviewDialog val = new PrintPreviewDialog();
			val.Document = PrintDocument1;
			val.PrintPreviewControl.Zoom = 2.0;
			((Form)val).WindowState = (FormWindowState)2;
			((Form)val).ShowDialog();
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		try
		{
			decimal value = Numeric_qte.Value;
			decimal num = 1m;
			while (ObjectFlowControl.ForLoopControl.ForNextCheckDec(num, value, 1m))
			{
				if (Operators.CompareString(Combo_PRINT.Text, "", TextCompare: false) != 0)
				{
					PrintDocument1.PrinterSettings.PrinterName = Combo_PRINT.Text;
				}
				PrintDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", Convert.ToInt32(Numeric_TICKET_WIDTH.Value), Convert.ToInt32(Numeric_TICKET_HEIGHT.Value));
				PrintDocument1.PrintController = (PrintController)new StandardPrintController();
				PrintDocument1.Print();
				num = decimal.Add(num, 1m);
			}
			Numeric_qte.Value = 1m;
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

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected Obj, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Expected Obj, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected Obj, but got Unknown
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected Obj, but got Unknown
		//IL_0ad1: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected Obj, but got Unknown
		//IL_09fd: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		checked
		{
			if (Operators.CompareString(Combo_TYPE.Text, "CODE128", TextCompare: false) == 0)
			{
				Module1.Code128(Text_code.Text, "A");
				string binaryz = Module1.Binaryz;
				Bitmap val = new Bitmap(Strings.Len(Module1.Binaryz), 60, (PixelFormat)137224);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				Rectangle rectangle = new Rectangle(0, 0, ((Image)val).Width, ((Image)val).Height);
				Brush val3 = (Brush)new LinearGradientBrush(rectangle, Color.White, Color.White, (LinearGradientMode)2);
				val2.FillRectangle(val3, rectangle);
				int left = ((Control)Picture_CODE).Left;
				int top = ((Control)Picture_CODE).Top;
				int num = Strings.Len(Module1.Binaryz);
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string left2 = Strings.Mid(Module1.Binaryz, num2, 1);
					if (Operators.CompareString(left2, "0", TextCompare: false) == 0)
					{
						Pen val4 = new Pen(Color.Black, 1f);
						Point point = new Point(num2 + left, 0 + top);
						Point point2 = new Point(num2 + left, 20 + top);
						e.Graphics.DrawLine(val4, point, point2);
					}
					else
					{
						Pen val4 = new Pen(Color.White, 1f);
						Point point = new Point(num2 + left, 0 + top);
						Point point2 = new Point(num2 + left, 20 + top);
						e.Graphics.DrawLine(val4, point, point2);
					}
					num2++;
				}
			}
			if (Operators.CompareString(Combo_TYPE.Text, "EAN13", TextCompare: false) == 0)
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(new string[4] { "0001101", "0100111", "1110010", "000000" });
				arrayList.Add(new string[4] { "0011001", "0110011", "1100110", "001011" });
				arrayList.Add(new string[4] { "0010011", "0011011", "1101100", "001101" });
				arrayList.Add(new string[4] { "0111101", "0100001", "1000010", "001110" });
				arrayList.Add(new string[4] { "0100011", "0011101", "1011100", "010011" });
				arrayList.Add(new string[4] { "0110001", "0111001", "1001110", "011001" });
				arrayList.Add(new string[4] { "0101111", "0000101", "1010000", "011100" });
				arrayList.Add(new string[4] { "0111011", "0010001", "1000100", "010101" });
				arrayList.Add(new string[4] { "0110111", "0001001", "1001000", "010110" });
				arrayList.Add(new string[4] { "0001011", "0010111", "1110100", "011010" });
				string text = "000000000000";
				if (Text_code.Text.Length > 0)
				{
					text = Text_code.Text.ToString().PadRight(12, '0');
				}
				((Control)Picture_CODE).BackgroundImage = Module1.Generate(text);
				((Control)Picture_CODE).Width = Conversions.ToInteger(Module1.Generate(text).Width.ToString());
				((Control)Picture_CODE).Height = Conversions.ToInteger(Module1.Generate(text).Height.ToString());
				int num5 = 0;
				int num6 = 0;
				int left3 = ((Control)Picture_CODE).Left;
				int top2 = ((Control)Picture_CODE).Top;
				byte[] array = new byte[13];
				int num7 = 0;
				int num8;
				int num4;
				do
				{
					array[num7] = (byte)Conversions.ToInteger(text.Substring(num7, 1));
					if (unchecked(num7 % 2) == 1)
					{
						num6 += array[num7];
					}
					else
					{
						num5 += array[num7];
					}
					num7++;
					num8 = num7;
					num4 = 11;
				}
				while (num8 <= num4);
				unchecked
				{
					num7 = checked(num5 + num6 * 3) % 10;
				}
				if (num7 == 0)
				{
					array[12] = 0;
				}
				else
				{
					array[12] = (byte)(10 - num7);
				}
				byte[] bits = Module1.getBits(array);
				Font val5 = new Font("Calibri", 14f, (FontStyle)0, (GraphicsUnit)2);
				Image val6 = (Image)new Bitmap(110, 50);
				Graphics val7 = Graphics.FromImage(val6);
				e.Graphics.Clear(Color.White);
				e.Graphics.DrawString(text.Substring(0, 1), val5, Brushes.Black, (float)(2 + left3), (float)(30 + top2));
				num5 = (int)Math.Round(e.Graphics.MeasureString(text.Substring(0, 1), val5).Width);
				int num9 = bits.Length - 1;
				num7 = 0;
				while (true)
				{
					int num10 = num7;
					num4 = num9;
					if (num10 > num4)
					{
						break;
					}
					switch (num7)
					{
					case 2:
						e.Graphics.DrawString(text.Substring(1, 6), val5, Brushes.Black, (float)(num5 + left3), (float)(30 + top2));
						break;
					case 48:
						e.Graphics.DrawString(text.Substring(7, 5) + array[12], val5, Brushes.Black, (float)(num5 + left3), (float)(30 + top2));
						break;
					}
					if ((num7 == 0) | (num7 == 2) | (num7 == 46) | (num7 == 48) | (num7 == 92) | (num7 == 94))
					{
						if (bits[num7] == 1)
						{
							Pen val8 = new Pen(Color.Black, 1f);
							e.Graphics.DrawLine(val8, num5 + left3, 0 + top2, num5 + left3, 40 + top2);
							num5++;
						}
					}
					else if (bits[num7] == 1)
					{
						Pen val9 = new Pen(Color.Black, 1f);
						e.Graphics.DrawLine(val9, num5 + left3, 0 + top2, num5 + left3, 30 + top2);
						num5++;
					}
					else
					{
						num5++;
					}
					num7++;
				}
				val7.Flush();
				string text2 = "101";
				string text3 = Conversions.ToString(NewLateBinding.LateIndexGet(arrayList[array[0]], new object[1] { 3 }, null));
				int num11 = 1;
				int num12;
				do
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, NewLateBinding.LateIndexGet(arrayList[array[num11]], new object[1] { Conversions.ToInteger(text3.Substring(num11 - 1, 1)) }, null)));
					num11++;
					num12 = num11;
					num4 = 6;
				}
				while (num12 <= num4);
				text2 += "01010";
				num11 = 7;
				int num13;
				do
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, NewLateBinding.LateIndexGet(arrayList[array[num11]], new object[1] { 2 }, null)));
					num11++;
					num13 = num11;
					num4 = 12;
				}
				while (num13 <= num4);
				text2 += "101";
				byte[] array2 = new byte[text2.Length - 1 + 1];
				int num14 = text2.Length - 1;
				num11 = 0;
				while (true)
				{
					int num15 = num11;
					num4 = num14;
					if (num15 > num4)
					{
						break;
					}
					array2[num11] = (byte)(Strings.Asc(text2[num11]) - 48);
					num11++;
				}
			}
			if (Operators.CompareString(Combo_TYPE.Text, "UPC", TextCompare: false) == 0)
			{
				CreateUPC();
				Scale = Convert.ToSingle(Convert.ToDecimal("1.4"));
				Graphics graphics = e.Graphics;
				Point pt = new Point(0, 0);
				DrawUpcaBarcode(graphics, pt);
			}
			if (Operators.CompareString(Combo_TYPE.Text, "QR", TextCompare: false) == 0)
			{
				GenerateBarcode(Text_code.Text);
				PictureBox picture_CODE = Picture_CODE;
				Graphics graphics2 = e.Graphics;
				Image image = picture_CODE.Image;
				Rectangle rectangle2 = new Rectangle(((Control)picture_CODE).Left, ((Control)picture_CODE).Top, ((Control)picture_CODE).Width, ((Control)picture_CODE).Height);
				graphics2.DrawImage(image, rectangle2);
			}
			foreach (Control control in ((Control)Panel_ETIQUETTE).Controls)
			{
				Control val10 = control;
				if (val10 is Label)
				{
					Label val11 = (Label)((Control)Panel_ETIQUETTE).Controls[val10.Name];
					if (!((Control)val11).Name.EndsWith("_"))
					{
						e.Graphics.DrawString(val11.Text, new Font(((Control)val11).Font.FontFamily, ((Control)val11).Font.Size, ((Control)val11).Font.Style), Brushes.Black, (float)((Control)val11).Left, (float)((Control)val11).Top, new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						Size size = e.Graphics.MeasureString(val11.Text, new Font(((Control)val11).Font.FontFamily, ((Control)val11).Font.Size, ((Control)val11).Font.Style)).ToSize();
						e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), ((Control)val11).Left, ((Control)val11).Top, size.Width, size.Height);
						e.Graphics.DrawString(val11.Text, new Font(((Control)val11).Font.FontFamily, ((Control)val11).Font.Size, ((Control)val11).Font.Style), (Brush)new SolidBrush(Color.White), (float)((Control)val11).Left, (float)((Control)val11).Top);
					}
				}
				if (val10 is PictureBox)
				{
					PictureBox val12 = (PictureBox)((Control)Panel_ETIQUETTE).Controls[val10.Name];
					if (Operators.CompareString(((Control)val12).Name, "Picture_FLECHE", TextCompare: false) == 0)
					{
						Graphics graphics3 = e.Graphics;
						Image backgroundImage = ((Control)val12).BackgroundImage;
						Rectangle rectangle2 = new Rectangle(((Control)val12).Left, ((Control)val12).Top, ((Control)val12).Width, ((Control)val12).Height);
						graphics3.DrawImage(backgroundImage, rectangle2);
					}
				}
			}
		}
	}

	private void Combo_TYPE_SelectedIndexChanged(object sender, EventArgs e)
	{
		Button_GO.PerformClick();
	}

	private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		MySqlDataAdapter val = new MySqlDataAdapter();
		DataTable dataTable = new DataTable();
		val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select    Code,Article,PRIX_V_1,PROMOTION    from TABLE_ARTICLES WHERE Article like  '%", NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)), "%'     order by         Article      asc")), Module1.cn_SQL);
		dataTable = new DataTable();
		dataTable.Clear();
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.DataSource = dataTable;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Combo_FIND.Text, "REFERENCE", TextCompare: false) == 0)
		{
			DataGridView2.Rows.Add(new object[6]
			{
				RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE"].Value),
				RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ARTICLE"].Value),
				Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["PRIX_V_1"].Value)),
				Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["PROMOTION"].Value)),
				"",
				Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["STOCK"].Value))
			});
			NumericUpDown1.Value = 1m;
		}
		else
		{
			DataGridView2.Rows.Add(new object[6]
			{
				RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE"].Value),
				RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ARTICLE"].Value),
				Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["PRIX_V_1"].Value)),
				Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["PROMOTION"].Value)),
				"",
				NumericUpDown1.Value
			});
			NumericUpDown1.Value = 1m;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(Combo_FIND.Text, "REFERENCE", TextCompare: false) == 0)
			{
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
					DataGridView2.Rows.Add(new object[6]
					{
						RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["CODE"].Value),
						RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["ARTICLE"].Value),
						Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PRIX_V_1"].Value)),
						Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PROMOTION"].Value)),
						"",
						Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["STOCK"].Value))
					});
					num2++;
				}
				NumericUpDown1.Value = 1m;
				return;
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
				DataGridView2.Rows.Add(new object[6]
				{
					RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["CODE"].Value),
					RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["ARTICLE"].Value),
					Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PRIX_V_1"].Value)),
					Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PROMOTION"].Value)),
					"",
					NumericUpDown1.Value
				});
				num6++;
			}
			NumericUpDown1.Value = 1m;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		checked
		{
			try
			{
				TabControl1.SelectedIndex = 0;
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
					Text_code.Text = Conversions.ToString(DataGridView2.Rows[num2].Cells["CODE_LISTE"].Value);
					Text_article.Text = Conversions.ToString(DataGridView2.Rows[num2].Cells["ARTICLE_LISTE"].Value);
					Text_prix_v.Text = Conversions.ToString(DataGridView2.Rows[num2].Cells["PRIX_V_LISTE"].Value);
					Text_promotion.Text = Conversions.ToString(DataGridView2.Rows[num2].Cells["PROMOTION_LISTE"].Value);
					Numeric_qte.Value = Conversions.ToDecimal(DataGridView2.Rows[num2].Cells["QTE_LISTE"].Value);
					Button2.PerformClick();
					num2++;
				}
				DataGridView2.Rows.Clear();
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

	private void DataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if ((e.ColumnIndex == 6 && e.RowIndex >= 0) ? true : false)
				{
					e.Paint(e.CellBounds, (DataGridViewPaintParts)127);
					Image image = MyProject.Forms.Form_0_TEMPLATE.Picture_SUPP.Image;
					e.Graphics.DrawImage(image, e.CellBounds.Left + 11, e.CellBounds.Top + 5, 16, 16);
					((HandledEventArgs)(object)e).Handled = true;
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

	private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		try
		{
			if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				DataGridView2.Rows.RemoveAt(DataGridView2.CurrentCell.RowIndex);
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

	private void Button_GO_Click(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		checked
		{
			if (Operators.CompareString(Combo_TYPE.Text, "CODE128", TextCompare: false) == 0)
			{
				Module1.Code128(Text_code.Text, "A");
				string binaryz = Module1.Binaryz;
				Bitmap val = new Bitmap(Strings.Len(Module1.Binaryz), 60, (PixelFormat)137224);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				Rectangle rectangle = new Rectangle(0, 0, ((Image)val).Width, ((Image)val).Height);
				Brush val3 = (Brush)new LinearGradientBrush(rectangle, Color.White, Color.White, (LinearGradientMode)2);
				val2.FillRectangle(val3, rectangle);
				int left = ((Control)Picture_CODE).Left;
				int top = ((Control)Picture_CODE).Top;
				int num = Strings.Len(Module1.Binaryz);
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string left2 = Strings.Mid(Module1.Binaryz, num2, 1);
					if (Operators.CompareString(left2, "0", TextCompare: false) == 0)
					{
						Pen val4 = new Pen(Color.Black, 1f);
						Point point = new Point(num2, 0);
						Point point2 = new Point(num2, 20);
						val2.DrawLine(val4, point, point2);
					}
					else
					{
						Pen val4 = new Pen(Color.White, 1f);
						Point point = new Point(num2, 0);
						Point point2 = new Point(num2, 20);
						val2.DrawLine(val4, point, point2);
					}
					num2++;
				}
				((Control)Picture_CODE).BackgroundImage = (Image)(object)val;
				((Control)Picture_CODE).BackgroundImageLayout = (ImageLayout)2;
				((Control)Picture_CODE).Width = Strings.Len(Module1.Binaryz);
				((Control)Picture_CODE).Height = 30;
			}
			if (Operators.CompareString(Combo_TYPE.Text, "EAN13", TextCompare: false) == 0)
			{
				if (Text_code.Text.Length == 13)
				{
					string text = Text_code.Text;
					((Control)Picture_CODE).BackgroundImage = Module1.Generate(text);
					((Control)Picture_CODE).Width = Conversions.ToInteger(Module1.Generate(text).Width.ToString());
					((Control)Picture_CODE).Height = Conversions.ToInteger(Module1.Generate(text).Height.ToString());
				}
				else
				{
					((Control)Picture_CODE).BackgroundImage = ((Control)this).BackgroundImage;
				}
			}
			if (Operators.CompareString(Combo_TYPE.Text, "UPC", TextCompare: false) == 0)
			{
				if (Text_code.Text.Length == 12)
				{
					CreateUPC();
					Scale = Convert.ToSingle(Convert.ToDecimal("1.4"));
					Bitmap val5 = CreateBitmap();
					((Control)Picture_CODE).BackgroundImage = (Image)(object)val5;
					((Control)Picture_CODE).BackgroundImageLayout = (ImageLayout)2;
					((Control)Picture_CODE).Width = ((Image)val5).Width;
					((Control)Picture_CODE).Height = ((Image)val5).Height;
				}
				else
				{
					((Control)Picture_CODE).BackgroundImage = ((Control)this).BackgroundImage;
				}
			}
			if (Operators.CompareString(Combo_TYPE.Text, "QR", TextCompare: false) == 0)
			{
				GenerateBarcode(Text_code.Text);
			}
			Label_CODE.Text = Text_code.Text;
			Label_ARTICLE.Text = Text_article.Text;
			Label_PRIX_V.Text = Text_prix_v.Text;
			Label_TEXT_LIBRE_.Text = Text_LIBRE.Text;
			try
			{
				string[] array = Conversions.ToDecimal(Label_PRIX_V.Text).ToString().Split(new char[1] { '.' });
				Label_PRIX_V_MINI.Text = array[0] + ".";
				Label_PRIX_V_DECIMAL.Text = array[1];
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
			if (Conversion.Val(Text_promotion.Text) == 0.0)
			{
				Label_PROMOTION.Text = "";
				Label_PRIX_V.Text = Text_prix_v.Text;
				((Control)Label_PRIX_V).Font = new Font(((Control)Label_PRIX_V).Font.FontFamily, Convert.ToSingle(NumericUpDown_SIZE.Value), (FontStyle)0);
			}
			else
			{
				string text2 = Strings.FormatNumber(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(Text_prix_v.Text), 1m)) - Conversions.ToDouble(Text_prix_v.Text) * 1.0 * Conversions.ToDouble(Text_promotion.Text) / 100.0);
				Label_PROMOTION.Text = text2;
				((Control)Label_PRIX_V).Font = new Font(((Control)Label_PRIX_V).Font.FontFamily, Convert.ToSingle(NumericUpDown_SIZE.Value), (FontStyle)8);
			}
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		if (!((Control)Panel_CONFIG).Visible)
		{
			((Control)Panel_CONFIG).Visible = true;
			((Control)Panel_CONFIG).BringToFront();
			((Control)Panel_ETIQUETTE).Enabled = true;
			{
				foreach (Control control in ((Control)Panel_ETIQUETTE).Controls)
				{
					Control val = control;
					ClsCapture.CaptureMe(val);
					val.MouseClick += _CONTROL_MouseClick;
					val.MouseUp += _CONTROL_MouseUp;
					if (!val.Name.Contains("RED"))
					{
						DataGridView_CONTROLS.Rows.Add(new object[2]
						{
							val.Name,
							((object)val).GetType().Name
						});
					}
				}
				return;
			}
		}
		if (((Control)Panel_CONFIG).Visible)
		{
			((Control)Panel_CONFIG).Visible = false;
			((Control)Panel_CONFIG).BringToFront();
			((Control)Panel_ETIQUETTE).Enabled = false;
		}
	}

	private void Numeric_TICKET_WIDTH_ValueChanged(object sender, EventArgs e)
	{
		((Control)Panel_ETIQUETTE).Width = Convert.ToInt32(Numeric_TICKET_WIDTH.Value);
	}

	private void Numeric_TICKET_HEIGHT_ValueChanged(object sender, EventArgs e)
	{
		((Control)Panel_ETIQUETTE).Height = Convert.ToInt32(Numeric_TICKET_HEIGHT.Value);
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton2_Click(object sender, EventArgs e)
	{
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected I4, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		if (((ButtonBase)Button_MODELE_1).BackColor == Color.Yellow)
		{
			StreamWriter streamWriter = new StreamWriter(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_1.sni", append: false, Encoding.UTF8);
			foreach (Control control in ((Control)Panel_ETIQUETTE).Controls)
			{
				Control val = control;
				streamWriter.WriteLine(val.Name + "|" + Conversions.ToString(val.Left) + "|" + Conversions.ToString(val.Top) + "|" + Conversions.ToString(val.Width) + "|" + Conversions.ToString(val.Height) + "|" + val.Font.Name + "|" + Conversions.ToString(val.Font.Size) + "|" + Conversions.ToString((int)val.Font.Style));
			}
			streamWriter.Close();
			StreamWriter streamWriter2 = new StreamWriter(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_1_WH.sni", append: false, Encoding.UTF8);
			foreach (Control control2 in ((Control)Panel_CONFIG).Controls)
			{
				Control val2 = control2;
				if (val2 is NumericUpDown)
				{
					streamWriter2.WriteLine(val2.Name + "|" + val2.Text);
				}
				if (val2 is ComboBox)
				{
					streamWriter2.WriteLine(val2.Name + "|" + val2.Text);
				}
			}
			streamWriter2.Close();
			MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			Label_NAME.Text = "-";
		}
		else
		{
			if (!(((ButtonBase)Button_MODELE_2).BackColor == Color.Yellow))
			{
				return;
			}
			StreamWriter streamWriter3 = new StreamWriter(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_2.sni", append: false, Encoding.UTF8);
			foreach (Control control3 in ((Control)Panel_ETIQUETTE).Controls)
			{
				Control val3 = control3;
				streamWriter3.WriteLine(val3.Name + "|" + Conversions.ToString(val3.Left) + "|" + Conversions.ToString(val3.Top) + "|" + Conversions.ToString(val3.Width) + "|" + Conversions.ToString(val3.Height) + "|" + val3.Font.Name + "|" + Conversions.ToString(val3.Font.Size) + "|" + Conversions.ToString((int)val3.Font.Style));
			}
			streamWriter3.Close();
			StreamWriter streamWriter4 = new StreamWriter(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_2_WH.sni", append: false, Encoding.UTF8);
			foreach (Control control4 in ((Control)Panel_CONFIG).Controls)
			{
				Control val4 = control4;
				if (val4 is NumericUpDown)
				{
					streamWriter4.WriteLine(val4.Name + "|" + val4.Text);
				}
				if (val4 is ComboBox)
				{
					streamWriter4.WriteLine(val4.Name + "|" + val4.Text);
				}
			}
			streamWriter4.Close();
			MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			Label_NAME.Text = "-";
		}
	}

	private void NumericUpDown_X_ValueChanged(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString().ToString().Contains("Label"))
			{
				Label val = (Label)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
				((Control)val).Left = Convert.ToInt32(NumericUpDown_X.Value);
			}
			else if (DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString().ToString().Contains("Picture"))
			{
				PictureBox val2 = (PictureBox)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
				((Control)val2).Left = Convert.ToInt32(NumericUpDown_X.Value);
			}
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

	private void NumericUpDown_Y_ValueChanged(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString().ToString().Contains("Label"))
			{
				Label val = (Label)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
				((Control)val).Top = Convert.ToInt32(NumericUpDown_Y.Value);
			}
			else if (DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString().ToString().Contains("Picture"))
			{
				PictureBox val2 = (PictureBox)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
				((Control)val2).Top = Convert.ToInt32(NumericUpDown_Y.Value);
			}
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

	private void NumericUpDown_SIZE_ValueChanged(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		try
		{
			Label val = (Label)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, Convert.ToSingle(NumericUpDown_SIZE.Value), ((Control)val).Font.Style);
			if (DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString().ToString().Contains("Label"))
			{
				Label val2 = (Label)((Control)Panel_ETIQUETTE).Controls[Label_NAME.Text];
				((Control)val2).Font = new Font(((Control)val).Font.FontFamily, Convert.ToSingle(NumericUpDown_SIZE.Value), ((Control)val).Font.Style);
			}
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

	private void DataGridView_CONTROLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_CONTROLS_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		string text = DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[0].Value.ToString();
		string text2 = DataGridView_CONTROLS.Rows[((DataGridViewBand)DataGridView_CONTROLS.CurrentRow).Index].Cells[1].Value.ToString();
		Label_NAME.Text = text;
		if (text2.ToString().Contains("Label"))
		{
			Label val = (Label)((Control)Panel_ETIQUETTE).Controls[text];
			NumericUpDown_X.Value = new decimal(((Control)val).Left);
			NumericUpDown_Y.Value = new decimal(((Control)val).Top);
			NumericUpDown_SIZE.Value = new decimal(((Control)val).Font.Size);
		}
		else if (text2.ToString().Contains("Picture"))
		{
			PictureBox val2 = (PictureBox)((Control)Panel_ETIQUETTE).Controls[text];
			NumericUpDown_X.Value = new decimal(((Control)val2).Left);
			NumericUpDown_Y.Value = new decimal(((Control)val2).Top);
		}
	}

	private void Picture_FLECHE_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(((Control)Picture_FLECHE).Tag, 1, TextCompare: false))
		{
			((Control)Picture_FLECHE).BackgroundImage = ((Control)Picture_DOWN).BackgroundImage;
			((Control)Picture_FLECHE).Tag = 2;
		}
		else
		{
			((Control)Picture_FLECHE).BackgroundImage = ((Control)Picture_UP).BackgroundImage;
			((Control)Picture_FLECHE).Tag = 1;
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataTable dataTable = new DataTable();
				val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select    Code,Article,PRIX_V_1,PROMOTION    from TABLE_ARTICLES WHERE Code like  '%", NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)), "%'     order by         Article      asc")), Module1.cn_SQL);
				dataTable = new DataTable();
				dataTable.Clear();
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.DataSource = dataTable;
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_DoubleClick(object sender, EventArgs e)
	{
		Button3.PerformClick();
	}

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Combo_FIND.Text, "Code", TextCompare: false) != 0)
		{
			Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		MySqlDataAdapter val = new MySqlDataAdapter();
		DataTable dataTable = new DataTable();
		if (!Check_FIND_EXACTE.Checked)
		{
			dataTable.Clear();
			val = new MySqlDataAdapter("select Code,Article,PRIX_V_1,STOCK,PROMOTION from     TABLE_ARTICLES      Where                        (" + Combo_FIND.Text + "  like  '%" + Text_FIND.Texts + "%'   )                                order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Check_FIND_EXACTE.Checked)
		{
			dataTable.Clear();
			val = new MySqlDataAdapter("select Code,Article,PRIX_V_1,STOCK,PROMOTION from     TABLE_ARTICLES      Where                        (" + Combo_FIND.Text + "  like  '" + Text_FIND.Texts + "'     )                                order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.DataSource = dataTable;
	}

	private void Button_MODELE_1_Click(object sender, EventArgs e)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		try
		{
			((ButtonBase)Button_MODELE_1).BackColor = Color.Yellow;
			((ButtonBase)Button_MODELE_2).BackColor = Color.Transparent;
			StreamReader streamReader = new StreamReader(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_1.sni", Encoding.UTF8);
			while (streamReader.Peek() > -1)
			{
				string[] array = streamReader.ReadLine().Split(new char[1] { '|' });
				Control val = ((Control)Panel_ETIQUETTE).Controls[array[0]];
				val.Left = Conversions.ToInteger(array[1].ToString());
				val.Top = Conversions.ToInteger(array[2].ToString());
				val.Width = Conversions.ToInteger(array[3].ToString());
				val.Height = Conversions.ToInteger(array[4].ToString());
				string text = array[5].ToString();
				int num = Conversions.ToInteger(array[6].ToString());
				string text2 = array[7].ToString();
				val.Font = new Font(text, (float)num, val.Font.Style);
			}
			streamReader.Close();
			StreamReader streamReader2 = new StreamReader(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_1_WH.sni", Encoding.UTF8);
			while (streamReader2.Peek() > -1)
			{
				string[] array2 = streamReader2.ReadLine().Split(new char[1] { '|' });
				Control val2 = ((Control)Panel_CONFIG).Controls[array2[0]];
				if (val2 is NumericUpDown)
				{
					val2.Text = array2[1].ToString();
				}
				else if (val2 is ComboBox)
				{
					val2.Text = array2[1].ToString();
				}
			}
			streamReader2.Close();
			((Control)Panel_ETIQUETTE).Width = Convert.ToInt32(Numeric_TICKET_WIDTH.Value);
			((Control)Panel_ETIQUETTE).Height = Convert.ToInt32(Numeric_TICKET_HEIGHT.Value);
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

	private void Button_MODELE_2_Click(object sender, EventArgs e)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		try
		{
			((ButtonBase)Button_MODELE_1).BackColor = Color.Transparent;
			((ButtonBase)Button_MODELE_2).BackColor = Color.Yellow;
			StreamReader streamReader = new StreamReader(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_2.sni", Encoding.UTF8);
			while (streamReader.Peek() > -1)
			{
				string[] array = streamReader.ReadLine().Split(new char[1] { '|' });
				Control val = ((Control)Panel_ETIQUETTE).Controls[array[0]];
				val.Left = Conversions.ToInteger(array[1].ToString());
				val.Top = Conversions.ToInteger(array[2].ToString());
				val.Width = Conversions.ToInteger(array[3].ToString());
				val.Height = Conversions.ToInteger(array[4].ToString());
				string text = array[5].ToString();
				int num = Conversions.ToInteger(array[6].ToString());
				string text2 = array[7].ToString();
				val.Font = new Font(text, (float)num, val.Font.Style);
			}
			streamReader.Close();
			StreamReader streamReader2 = new StreamReader(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_2_WH.sni", Encoding.UTF8);
			while (streamReader2.Peek() > -1)
			{
				string[] array2 = streamReader2.ReadLine().Split(new char[1] { '|' });
				Control val2 = ((Control)Panel_CONFIG).Controls[array2[0]];
				if (val2 is NumericUpDown)
				{
					val2.Text = array2[1].ToString();
				}
				else if (val2 is ComboBox)
				{
					val2.Text = array2[1].ToString();
				}
			}
			streamReader2.Close();
			((Control)Panel_ETIQUETTE).Width = Convert.ToInt32(Numeric_TICKET_WIDTH.Value);
			((Control)Panel_ETIQUETTE).Height = Convert.ToInt32(Numeric_TICKET_HEIGHT.Value);
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
