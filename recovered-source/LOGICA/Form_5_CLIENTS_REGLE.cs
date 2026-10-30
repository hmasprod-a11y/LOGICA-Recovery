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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClosedXML.Excel;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_5_CLIENTS_REGLE : Form
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

	[AccessedThroughProperty("TextBox_NOTES")]
	private TextBox _TextBox_NOTES;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox_MONTANT")]
	private TextBox _TextBox_MONTANT;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Print_Recette_Bon")]
	private PrintDocument _Print_Recette_Bon;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Text_ETAT")]
	private TextBox _Text_ETAT;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_CLIENT")]
	private Button_ID_CODE _Button_CLIENT;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Text_CREDIT")]
	private TextBox _Text_CREDIT;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Combo_MODE_P")]
	private ComboBox _Combo_MODE_P;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Text_UTILISATEUR")]
	private TextBox _Text_UTILISATEUR;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Picture_EXPORT")]
	private PictureBox _Picture_EXPORT;

	[AccessedThroughProperty("Panel_DATES")]
	private Panel _Panel_DATES;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("Picture_FIND_DATES")]
	private PictureBox _Picture_FIND_DATES;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Check_FIND_DATE")]
	private CheckBox _Check_FIND_DATE;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private CheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Combo_FIND")]
	private ComboBox _Combo_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private PictureBox _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private PictureBox _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private TextBox _Text_FIND;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label_RETOUR_CREDIT")]
	private Label _Label_RETOUR_CREDIT;

	[AccessedThroughProperty("Label_CREDIT")]
	private Label _Label_CREDIT;

	[AccessedThroughProperty("Label_REGLE_CLIENT")]
	private Label _Label_REGLE_CLIENT;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label_CREDIT_INITIAL")]
	private Label _Label_CREDIT_INITIAL;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("MONTANT")]
	private DataGridViewTextBoxColumn _MONTANT;

	[AccessedThroughProperty("Mode_P")]
	private DataGridViewTextBoxColumn _Mode_P;

	[AccessedThroughProperty("NOTES")]
	private DataGridViewTextBoxColumn _NOTES;

	[AccessedThroughProperty("ETAT")]
	private DataGridViewTextBoxColumn _ETAT;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("imp")]
	private DataGridViewImageColumn _imp;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Print_Recette_Bon_ARABE")]
	private PrintDocument _Print_Recette_Bon_ARABE;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private int x;

	private int y;

	private Point newpoint;

	private decimal _total_credit;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView1_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
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

	internal virtual TextBox TextBox_NOTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_NOTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_NOTES = value;
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

	internal virtual TextBox TextBox_MONTANT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_MONTANT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			KeyPressEventHandler val = TextBox3_KeyPress;
			KeyEventHandler val2 = TextBox3_KeyDown;
			if (_TextBox_MONTANT != null)
			{
				((Control)_TextBox_MONTANT).KeyPress -= val;
				((Control)_TextBox_MONTANT).KeyDown -= val2;
			}
			_TextBox_MONTANT = value;
			if (_TextBox_MONTANT != null)
			{
				((Control)_TextBox_MONTANT).KeyPress += val;
				((Control)_TextBox_MONTANT).KeyDown += val2;
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

	internal virtual PrintDocument Print_Recette_Bon
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Bon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Bon_PrintPage;
			if (_Print_Recette_Bon != null)
			{
				_Print_Recette_Bon.PrintPage -= val;
			}
			_Print_Recette_Bon = value;
			if (_Print_Recette_Bon != null)
			{
				_Print_Recette_Bon.PrintPage += val;
			}
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

	internal virtual TextBox Text_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CREDIT = value;
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

	internal virtual ComboBox Combo_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_MODE_P = value;
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

	internal virtual PictureBox Picture_EXPORT
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

	internal virtual CheckBox Check_FIND_DATE
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
			EventHandler eventHandler = Check_FIND_DATE_CheckedChanged;
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

	internal virtual CheckBox Check_FIND_EXACTE
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

	internal virtual ComboBox Combo_FIND
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
				_Combo_FIND.SelectedIndexChanged -= eventHandler;
			}
			_Combo_FIND = value;
			if (_Combo_FIND != null)
			{
				_Combo_FIND.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_REFRESH
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

	internal virtual PictureBox Picture_FIND
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
			EventHandler eventHandler = Text_FIND_TextChanged;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).TextChanged -= eventHandler;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).TextChanged += eventHandler;
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

	internal virtual DataGridViewTextBoxColumn ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_CLIENT = value;
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

	internal virtual DataGridViewTextBoxColumn Mode_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mode_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mode_P = value;
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

	internal virtual DataGridViewImageColumn imp
	{
		[DebuggerNonUserCode]
		get
		{
			return _imp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imp = value;
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

	internal virtual PrintDocument Print_Recette_Bon_ARABE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Bon_ARABE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Bon_ARABE_PrintPage;
			if (_Print_Recette_Bon_ARABE != null)
			{
				_Print_Recette_Bon_ARABE.PrintPage -= val;
			}
			_Print_Recette_Bon_ARABE = value;
			if (_Print_Recette_Bon_ARABE != null)
			{
				_Print_Recette_Bon_ARABE.PrintPage += val;
			}
		}
	}

	public Form_5_CLIENTS_REGLE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		((Form)this).FormClosed += Form_5_CLIENTS_FormClosed;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Form)this).Load += FormDialog_famille_Load;
		((Control)this).KeyDown += me_KeyDown;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
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
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected Obj, but got Unknown
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected Obj, but got Unknown
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df2: Expected Obj, but got Unknown
		//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected Obj, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1127: Expected Obj, but got Unknown
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected Obj, but got Unknown
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Expected Obj, but got Unknown
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Expected Obj, but got Unknown
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c9: Expected Obj, but got Unknown
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected Obj, but got Unknown
		//IL_15ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1645: Expected Obj, but got Unknown
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1683: Unknown result type (might be due to invalid IL or missing references)
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Expected Obj, but got Unknown
		//IL_17f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ff: Expected Obj, but got Unknown
		//IL_18a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Expected Obj, but got Unknown
		//IL_1949: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Expected Obj, but got Unknown
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2f: Expected Obj, but got Unknown
		//IL_1af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afe: Expected Obj, but got Unknown
		//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb1: Expected Obj, but got Unknown
		//IL_1c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c70: Expected Obj, but got Unknown
		//IL_1cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf9: Expected Obj, but got Unknown
		//IL_1dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd7: Expected Obj, but got Unknown
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e82: Expected Obj, but got Unknown
		//IL_1f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f35: Expected Obj, but got Unknown
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd9: Expected Obj, but got Unknown
		//IL_2058: Unknown result type (might be due to invalid IL or missing references)
		//IL_2062: Expected Obj, but got Unknown
		//IL_20f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2103: Expected Obj, but got Unknown
		//IL_218b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2195: Expected Obj, but got Unknown
		//IL_2240: Unknown result type (might be due to invalid IL or missing references)
		//IL_224a: Expected Obj, but got Unknown
		//IL_22f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fb: Expected Obj, but got Unknown
		//IL_231e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2328: Expected Obj, but got Unknown
		//IL_235c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2362: Unknown result type (might be due to invalid IL or missing references)
		//IL_241b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2425: Expected Obj, but got Unknown
		//IL_2448: Unknown result type (might be due to invalid IL or missing references)
		//IL_2452: Expected Obj, but got Unknown
		//IL_2537: Unknown result type (might be due to invalid IL or missing references)
		//IL_2541: Expected Obj, but got Unknown
		//IL_2627: Unknown result type (might be due to invalid IL or missing references)
		//IL_2631: Expected Obj, but got Unknown
		//IL_2a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a14: Expected Obj, but got Unknown
		//IL_2bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcc: Expected Obj, but got Unknown
		//IL_2d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d21: Expected Obj, but got Unknown
		//IL_2db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc1: Expected Obj, but got Unknown
		//IL_2e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5f: Expected Obj, but got Unknown
		//IL_2ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee0: Expected Obj, but got Unknown
		//IL_2f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f77: Expected Obj, but got Unknown
		//IL_301c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3026: Expected Obj, but got Unknown
		//IL_3236: Unknown result type (might be due to invalid IL or missing references)
		//IL_3240: Expected Obj, but got Unknown
		//IL_3311: Unknown result type (might be due to invalid IL or missing references)
		//IL_331b: Expected Obj, but got Unknown
		//IL_339f: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a9: Expected Obj, but got Unknown
		//IL_3456: Unknown result type (might be due to invalid IL or missing references)
		//IL_3460: Expected Obj, but got Unknown
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_3522: Expected Obj, but got Unknown
		//IL_35ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f4: Expected Obj, but got Unknown
		//IL_36b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c2: Expected Obj, but got Unknown
		//IL_378a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3794: Expected Obj, but got Unknown
		//IL_382c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3836: Expected Obj, but got Unknown
		//IL_3921: Unknown result type (might be due to invalid IL or missing references)
		//IL_392b: Expected Obj, but got Unknown
		//IL_3a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a78: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS_REGLE));
		Panel_INFO = new Panel();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button_SAVE = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Text_UTILISATEUR = new TextBox();
		Label6 = new Label();
		Label2 = new Label();
		Combo_MODE_P = new ComboBox();
		Panel6 = new Panel();
		Label_CREDIT_INITIAL = new Label();
		Label16 = new Label();
		Label_REGLE_CLIENT = new Label();
		Label15 = new Label();
		Label_RETOUR_CREDIT = new Label();
		Label_CREDIT = new Label();
		Label12 = new Label();
		Label10 = new Label();
		Label35 = new Label();
		Text_CREDIT = new TextBox();
		Label36 = new Label();
		Label21 = new Label();
		Label37 = new Label();
		Label39 = new Label();
		Label8 = new Label();
		Text_ETAT = new TextBox();
		Label19 = new Label();
		Text_ID = new TextBox();
		Label9 = new Label();
		Label1 = new Label();
		TextBox_MONTANT = new TextBox();
		Label3 = new Label();
		TextBox_NOTES = new TextBox();
		Label4 = new Label();
		DateTimePicker_DATE = new DateTimePicker();
		Button_CLOSE = new Button();
		Button_ADD = new Button();
		DataGridView1 = new DataGridView();
		DATES = new DataGridViewTextBoxColumn();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		MONTANT = new DataGridViewTextBoxColumn();
		Mode_P = new DataGridViewTextBoxColumn();
		NOTES = new DataGridViewTextBoxColumn();
		ETAT = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		imp = new DataGridViewImageColumn();
		Print_Recette_Bon = new PrintDocument();
		Label_TABLE = new Label();
		Panel_FIND = new Panel();
		Picture_EXPORT = new PictureBox();
		Panel_DATES = new Panel();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		DateTime2_FIND = new DateTimePicker();
		PictureBox1 = new PictureBox();
		Check_FIND_DATE = new CheckBox();
		Check_FIND_EXACTE = new CheckBox();
		Panel8 = new Panel();
		Combo_FIND = new ComboBox();
		Picture_REFRESH = new PictureBox();
		Picture_FIND = new PictureBox();
		Text_FIND = new TextBox();
		Label5 = new Label();
		Label7 = new Label();
		Label11 = new Label();
		Label13 = new Label();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Button_CLIENT = new Button_ID_CODE();
		Print_Recette_Bon_ARABE = new PrintDocument();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FIND).SuspendLayout();
		((ISupportInitialize)Picture_EXPORT).BeginInit();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel8).SuspendLayout();
		((ISupportInitialize)Picture_REFRESH).BeginInit();
		((ISupportInitialize)Picture_FIND).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_INFO).Anchor = (AnchorStyles)1;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		Panel panel_INFO = Panel_INFO;
		Point location = new Point(237, 65);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		Size size = new Size(550, 508);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 808;
		((Control)Panel_INFO).Visible = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 502);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(540, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 870;
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
		size = new Size(4, 482);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 869;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(544, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 482);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 868;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
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
		size = new Size(548, 24);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 867;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(383, 468);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		Padding margin = new Padding(0);
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
		location = new Point(7, 26);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(534, 434);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Text_UTILISATEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label6);
		((Control)TabPage1).Controls.Add((Control)(object)Label2);
		((Control)TabPage1).Controls.Add((Control)(object)Combo_MODE_P);
		((Control)TabPage1).Controls.Add((Control)(object)Panel6);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ETAT);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage1).Controls.Add((Control)(object)Label9);
		((Control)TabPage1).Controls.Add((Control)(object)Label1);
		((Control)TabPage1).Controls.Add((Control)(object)TextBox_MONTANT);
		((Control)TabPage1).Controls.Add((Control)(object)Label3);
		((Control)TabPage1).Controls.Add((Control)(object)TextBox_NOTES);
		((Control)TabPage1).Controls.Add((Control)(object)Label4);
		((Control)TabPage1).Controls.Add((Control)(object)DateTimePicker_DATE);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(526, 398);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		((TextBoxBase)Text_UTILISATEUR).BackColor = Color.White;
		((Control)Text_UTILISATEUR).Enabled = false;
		((Control)Text_UTILISATEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_UTILISATEUR = Text_UTILISATEUR;
		location = new Point(371, 14);
		((Control)text_UTILISATEUR).Location = location;
		((Control)Text_UTILISATEUR).Name = "Text_UTILISATEUR";
		TextBox text_UTILISATEUR2 = Text_UTILISATEUR;
		size = new Size(146, 26);
		((Control)text_UTILISATEUR2).Size = size;
		((Control)Text_UTILISATEUR).TabIndex = 1041;
		Text_UTILISATEUR.TextAlign = (HorizontalAlignment)2;
		((Control)Label6).BackColor = SystemColors.Control;
		((Control)Label6).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.Black;
		Label label = Label6;
		location = new Point(269, 15);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(96, 23);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 1042;
		Label6.Text = "UTILISATEUR";
		Label6.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label3 = Label2;
		location = new Point(5, 248);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(112, 26);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1040;
		Label2.Text = "MODE P";
		Label2.TextAlign = (ContentAlignment)16;
		Combo_MODE_P.DropDownStyle = (ComboBoxStyle)2;
		((Control)Combo_MODE_P).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_MODE_P).FormattingEnabled = true;
		ComboBox combo_MODE_P = Combo_MODE_P;
		location = new Point(120, 248);
		((Control)combo_MODE_P).Location = location;
		((Control)Combo_MODE_P).Name = "Combo_MODE_P";
		ComboBox combo_MODE_P2 = Combo_MODE_P;
		size = new Size(399, 27);
		((Control)combo_MODE_P2).Size = size;
		((Control)Combo_MODE_P).TabIndex = 1039;
		((Control)Panel6).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel6).Controls.Add((Control)(object)Label_CREDIT_INITIAL);
		((Control)Panel6).Controls.Add((Control)(object)Label16);
		((Control)Panel6).Controls.Add((Control)(object)Label_REGLE_CLIENT);
		((Control)Panel6).Controls.Add((Control)(object)Label15);
		((Control)Panel6).Controls.Add((Control)(object)Label_RETOUR_CREDIT);
		((Control)Panel6).Controls.Add((Control)(object)Label_CREDIT);
		((Control)Panel6).Controls.Add((Control)(object)Label12);
		((Control)Panel6).Controls.Add((Control)(object)Label10);
		((Control)Panel6).Controls.Add((Control)(object)Label35);
		((Control)Panel6).Controls.Add((Control)(object)Button_CLIENT);
		((Control)Panel6).Controls.Add((Control)(object)Text_CREDIT);
		((Control)Panel6).Controls.Add((Control)(object)Label36);
		((Control)Panel6).Controls.Add((Control)(object)Label21);
		((Control)Panel6).Controls.Add((Control)(object)Label37);
		((Control)Panel6).Controls.Add((Control)(object)Label39);
		((Control)Panel6).Controls.Add((Control)(object)Label8);
		Panel panel = Panel6;
		location = new Point(9, 50);
		((Control)panel).Location = location;
		((Control)Panel6).Name = "Panel6";
		Panel panel2 = Panel6;
		size = new Size(511, 156);
		((Control)panel2).Size = size;
		((Control)Panel6).TabIndex = 1038;
		((Control)Label_CREDIT_INITIAL).BackColor = SystemColors.Control;
		((Control)Label_CREDIT_INITIAL).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_CREDIT_INITIAL).ForeColor = Color.Black;
		Label label_CREDIT_INITIAL = Label_CREDIT_INITIAL;
		location = new Point(351, 78);
		((Control)label_CREDIT_INITIAL).Location = location;
		((Control)Label_CREDIT_INITIAL).Name = "Label_CREDIT_INITIAL";
		Label label_CREDIT_INITIAL2 = Label_CREDIT_INITIAL;
		size = new Size(157, 14);
		((Control)label_CREDIT_INITIAL2).Size = size;
		((Control)Label_CREDIT_INITIAL).TabIndex = 1042;
		Label_CREDIT_INITIAL.TextAlign = (ContentAlignment)16;
		((Control)Label16).BackColor = SystemColors.Control;
		((Control)Label16).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.Black;
		Label label5 = Label16;
		location = new Point(199, 78);
		((Control)label5).Location = location;
		Label label6 = Label16;
		margin = new Padding(3);
		((Control)label6).Margin = margin;
		((Control)Label16).Name = "Label16";
		Label label7 = Label16;
		size = new Size(146, 14);
		((Control)label7).Size = size;
		((Control)Label16).TabIndex = 1041;
		Label16.Text = "CREDIT INITIAL";
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Label_REGLE_CLIENT).BackColor = SystemColors.Control;
		((Control)Label_REGLE_CLIENT).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_REGLE_CLIENT).ForeColor = Color.Black;
		Label label_REGLE_CLIENT = Label_REGLE_CLIENT;
		location = new Point(351, 98);
		((Control)label_REGLE_CLIENT).Location = location;
		((Control)Label_REGLE_CLIENT).Name = "Label_REGLE_CLIENT";
		Label label_REGLE_CLIENT2 = Label_REGLE_CLIENT;
		size = new Size(157, 14);
		((Control)label_REGLE_CLIENT2).Size = size;
		((Control)Label_REGLE_CLIENT).TabIndex = 1040;
		Label_REGLE_CLIENT.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = SystemColors.Control;
		((Control)Label15).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.Black;
		Label label8 = Label15;
		location = new Point(199, 98);
		((Control)label8).Location = location;
		Label label9 = Label15;
		margin = new Padding(3);
		((Control)label9).Margin = margin;
		((Control)Label15).Name = "Label15";
		Label label10 = Label15;
		size = new Size(146, 14);
		((Control)label10).Size = size;
		((Control)Label15).TabIndex = 1039;
		Label15.Text = "REGLE CLIENT";
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label_RETOUR_CREDIT).BackColor = SystemColors.Control;
		((Control)Label_RETOUR_CREDIT).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_RETOUR_CREDIT).ForeColor = Color.Black;
		Label label_RETOUR_CREDIT = Label_RETOUR_CREDIT;
		location = new Point(351, 58);
		((Control)label_RETOUR_CREDIT).Location = location;
		((Control)Label_RETOUR_CREDIT).Name = "Label_RETOUR_CREDIT";
		Label label_RETOUR_CREDIT2 = Label_RETOUR_CREDIT;
		size = new Size(157, 14);
		((Control)label_RETOUR_CREDIT2).Size = size;
		((Control)Label_RETOUR_CREDIT).TabIndex = 1038;
		Label_RETOUR_CREDIT.TextAlign = (ContentAlignment)16;
		((Control)Label_CREDIT).BackColor = SystemColors.Control;
		((Control)Label_CREDIT).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_CREDIT).ForeColor = Color.Black;
		Label label_CREDIT = Label_CREDIT;
		location = new Point(351, 38);
		((Control)label_CREDIT).Location = location;
		((Control)Label_CREDIT).Name = "Label_CREDIT";
		Label label_CREDIT2 = Label_CREDIT;
		size = new Size(157, 14);
		((Control)label_CREDIT2).Size = size;
		((Control)Label_CREDIT).TabIndex = 1037;
		Label_CREDIT.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.Black;
		Label label11 = Label12;
		location = new Point(199, 58);
		((Control)label11).Location = location;
		Label label12 = Label12;
		margin = new Padding(3);
		((Control)label12).Margin = margin;
		((Control)Label12).Name = "Label12";
		Label label13 = Label12;
		size = new Size(146, 14);
		((Control)label13).Size = size;
		((Control)Label12).TabIndex = 1036;
		Label12.Text = "RETOUR CREDIT";
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.Black;
		Label label14 = Label10;
		location = new Point(199, 38);
		((Control)label14).Location = location;
		Label label15 = Label10;
		margin = new Padding(3);
		((Control)label15).Margin = margin;
		((Control)Label10).Name = "Label10";
		Label label16 = Label10;
		size = new Size(146, 14);
		((Control)label16).Size = size;
		((Control)Label10).TabIndex = 1035;
		Label10.Text = "CREDIT";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label35).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label35).Cursor = Cursors.Hand;
		((Control)Label35).Dock = (DockStyle)2;
		((Control)Label35).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label35).ForeColor = Color.White;
		Label label17 = Label35;
		location = new Point(1, 155);
		((Control)label17).Location = location;
		((Control)Label35).Name = "Label35";
		Label label18 = Label35;
		size = new Size(509, 1);
		((Control)label18).Size = size;
		((Control)Label35).TabIndex = 1000;
		Label35.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CREDIT).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_CREDIT).Enabled = false;
		((Control)Text_CREDIT).Font = new Font("Cambria", 9.75f);
		TextBox text_CREDIT = Text_CREDIT;
		location = new Point(201, 118);
		((Control)text_CREDIT).Location = location;
		((Control)Text_CREDIT).Name = "Text_CREDIT";
		TextBox text_CREDIT2 = Text_CREDIT;
		size = new Size(307, 23);
		((Control)text_CREDIT2).Size = size;
		((Control)Text_CREDIT).TabIndex = 1007;
		((Control)Label36).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label36).Cursor = Cursors.Hand;
		((Control)Label36).Dock = (DockStyle)3;
		((Control)Label36).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label36).ForeColor = Color.White;
		Label label19 = Label36;
		location = new Point(0, 1);
		((Control)label19).Location = location;
		((Control)Label36).Name = "Label36";
		Label label20 = Label36;
		size = new Size(1, 155);
		((Control)label20).Size = size;
		((Control)Label36).TabIndex = 994;
		Label36.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = SystemColors.Control;
		((Control)Label21).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label21).ForeColor = Color.Black;
		Label label21 = Label21;
		location = new Point(111, 118);
		((Control)label21).Location = location;
		((Control)Label21).Name = "Label21";
		Label label22 = Label21;
		size = new Size(87, 23);
		((Control)label22).Size = size;
		((Control)Label21).TabIndex = 1006;
		Label21.Text = "CREDIT";
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Label37).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label37).Cursor = Cursors.Hand;
		((Control)Label37).Dock = (DockStyle)4;
		((Control)Label37).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label37).ForeColor = Color.White;
		Label label23 = Label37;
		location = new Point(510, 1);
		((Control)label23).Location = location;
		((Control)Label37).Name = "Label37";
		Label label24 = Label37;
		size = new Size(1, 155);
		((Control)label24).Size = size;
		((Control)Label37).TabIndex = 993;
		Label37.TextAlign = (ContentAlignment)16;
		((Control)Label39).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label39).Cursor = Cursors.Hand;
		((Control)Label39).Dock = (DockStyle)1;
		((Control)Label39).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label39).ForeColor = Color.White;
		Label label25 = Label39;
		location = new Point(0, 0);
		((Control)label25).Location = location;
		((Control)Label39).Name = "Label39";
		Label label26 = Label39;
		size = new Size(511, 1);
		((Control)label26).Size = size;
		((Control)Label39).TabIndex = 992;
		Label39.Text = "-";
		Label39.TextAlign = (ContentAlignment)16;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label27 = Label8;
		location = new Point(8, 9);
		((Control)label27).Location = location;
		((Control)Label8).Name = "Label8";
		Label label28 = Label8;
		size = new Size(101, 26);
		((Control)label28).Size = size;
		((Control)Label8).TabIndex = 399;
		Label8.Text = "CLIENT";
		Label8.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ETAT).BackColor = Color.White;
		((Control)Text_ETAT).Enabled = false;
		((Control)Text_ETAT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ETAT = Text_ETAT;
		location = new Point(120, 357);
		((Control)text_ETAT).Location = location;
		((Control)Text_ETAT).Name = "Text_ETAT";
		TextBox text_ETAT2 = Text_ETAT;
		size = new Size(142, 26);
		((Control)text_ETAT2).Size = size;
		((Control)Text_ETAT).TabIndex = 973;
		((Control)Label19).BackColor = SystemColors.Control;
		((Control)Label19).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label19).ForeColor = Color.Black;
		Label label29 = Label19;
		location = new Point(5, 357);
		((Control)label29).Location = location;
		((Control)Label19).Name = "Label19";
		Label label30 = Label19;
		size = new Size(112, 26);
		((Control)label30).Size = size;
		((Control)Label19).TabIndex = 972;
		Label19.Text = "ETAT";
		Label19.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(138, 15);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(32, 26);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 2;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Font = new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.FromArgb(2, 45, 162);
		Label label31 = Label9;
		location = new Point(485, 216);
		((Control)label31).Location = location;
		((Control)Label9).Name = "Label9";
		Label label32 = Label9;
		size = new Size(31, 19);
		((Control)label32).Size = size;
		((Control)Label9).TabIndex = 821;
		Label9.Text = "DH";
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label33 = Label1;
		location = new Point(5, 212);
		((Control)label33).Location = location;
		((Control)Label1).Name = "Label1";
		Label label34 = Label1;
		size = new Size(112, 26);
		((Control)label34).Size = size;
		((Control)Label1).TabIndex = 749;
		Label1.Text = "MONTANT";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)TextBox_MONTANT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox textBox_MONTANT = TextBox_MONTANT;
		location = new Point(120, 212);
		((Control)textBox_MONTANT).Location = location;
		((Control)TextBox_MONTANT).Name = "TextBox_MONTANT";
		TextBox textBox_MONTANT2 = TextBox_MONTANT;
		size = new Size(399, 26);
		((Control)textBox_MONTANT2).Size = size;
		((Control)TextBox_MONTANT).TabIndex = 748;
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label label35 = Label3;
		location = new Point(6, 15);
		((Control)label35).Location = location;
		((Control)Label3).Name = "Label3";
		Label label36 = Label3;
		size = new Size(112, 26);
		((Control)label36).Size = size;
		((Control)Label3).TabIndex = 396;
		Label3.Text = "DATES";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)TextBox_NOTES).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox textBox_NOTES = TextBox_NOTES;
		location = new Point(120, 284);
		((Control)textBox_NOTES).Location = location;
		TextBox_NOTES.Multiline = true;
		((Control)TextBox_NOTES).Name = "TextBox_NOTES";
		TextBox textBox_NOTES2 = TextBox_NOTES;
		size = new Size(399, 67);
		((Control)textBox_NOTES2).Size = size;
		((Control)TextBox_NOTES).TabIndex = 7;
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label label37 = Label4;
		location = new Point(5, 284);
		((Control)label37).Location = location;
		((Control)Label4).Name = "Label4";
		Label label38 = Label4;
		size = new Size(112, 26);
		((Control)label38).Size = size;
		((Control)Label4).TabIndex = 404;
		Label4.Text = "NOTES";
		Label4.TextAlign = (ContentAlignment)16;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(120, 15);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(143, 26);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 971;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(7, 468);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 30);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 682;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
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
		DataGridView1.AllowUserToAddRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)DATES,
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)MONTANT,
			(DataGridViewColumn)Mode_P,
			(DataGridViewColumn)NOTES,
			(DataGridViewColumn)ETAT,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)imp
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 30);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 610);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 3;
		((DataGridViewColumn)DATES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES).DataPropertyName = "DATES";
		((DataGridViewColumn)DATES).HeaderText = "DATES";
		((DataGridViewColumn)DATES).Name = "DATES";
		DATES.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DATES).Width = 120;
		((DataGridViewColumn)ID_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_CLIENT).DataPropertyName = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		ID_CLIENT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID_CLIENT).Width = 140;
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		CLIENT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)MONTANT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)MONTANT).DataPropertyName = "MONTANT";
		((DataGridViewColumn)MONTANT).HeaderText = "MONTANT";
		((DataGridViewColumn)MONTANT).Name = "MONTANT";
		((DataGridViewColumn)MONTANT).Width = 150;
		((DataGridViewColumn)Mode_P).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Mode_P).DataPropertyName = "Mode_P";
		((DataGridViewColumn)Mode_P).HeaderText = "Mode_P";
		((DataGridViewColumn)Mode_P).Name = "Mode_P";
		Mode_P.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)NOTES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)NOTES).DataPropertyName = "NOTES";
		((DataGridViewColumn)NOTES).HeaderText = "NOTES";
		((DataGridViewColumn)NOTES).Name = "NOTES";
		((DataGridViewColumn)NOTES).Width = 120;
		((DataGridViewColumn)ETAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETAT).DataPropertyName = "ETAT";
		((DataGridViewColumn)ETAT).HeaderText = "ETAT";
		((DataGridViewColumn)ETAT).Name = "ETAT";
		ETAT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ETAT).Width = 60;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).HeaderText = "";
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)supp).Width = 40;
		((DataGridViewColumn)imp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)imp).HeaderText = "";
		imp.Image = (Image)(object)Resources.Picture_PRINT_Image;
		((DataGridViewColumn)imp).Name = "imp";
		((DataGridViewColumn)imp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)imp).Width = 40;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(1025, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1038;
		Label_TABLE.Text = "CLIENTS_REGLE";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel8);
		Panel panel_FIND = Panel_FIND;
		location = new Point(143, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(882, 30);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1039;
		((Control)Picture_EXPORT).Anchor = (AnchorStyles)9;
		((Control)Picture_EXPORT).Cursor = Cursors.Hand;
		Picture_EXPORT.Image = (Image)componentResourceManager.GetObject("Picture_EXPORT.Image");
		PictureBox picture_EXPORT = Picture_EXPORT;
		location = new Point(852, 3);
		((Control)picture_EXPORT).Location = location;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		PictureBox picture_EXPORT2 = Picture_EXPORT;
		size = new Size(27, 24);
		((Control)picture_EXPORT2).Size = size;
		Picture_EXPORT.SizeMode = (PictureBoxSizeMode)4;
		Picture_EXPORT.TabIndex = 1039;
		Picture_EXPORT.TabStop = false;
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox1);
		Panel panel_DATES = Panel_DATES;
		location = new Point(417, 3);
		((Control)panel_DATES).Location = location;
		((Control)Panel_DATES).Name = "Panel_DATES";
		Panel panel_DATES2 = Panel_DATES;
		size = new Size(334, 24);
		((Control)panel_DATES2).Size = size;
		((Control)Panel_DATES).TabIndex = 1043;
		DateTime1_FIND.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTime1_FIND).Font = new Font("Tahoma", 9f);
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime1_FIND = DateTime1_FIND;
		location = new Point(1, 1);
		((Control)dateTime1_FIND).Location = location;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		DateTimePicker dateTime1_FIND2 = DateTime1_FIND;
		size = new Size(92, 22);
		((Control)dateTime1_FIND2).Size = size;
		((Control)DateTime1_FIND).TabIndex = 1038;
		DateTimePicker dateTime1_FIND3 = DateTime1_FIND;
		DateTime value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTime1_FIND3.Value = value;
		Picture_FIND_DATES.Image = (Image)componentResourceManager.GetObject("Picture_FIND_DATES.Image");
		PictureBox picture_FIND_DATES = Picture_FIND_DATES;
		location = new Point(226, 3);
		((Control)picture_FIND_DATES).Location = location;
		((Control)Picture_FIND_DATES).Name = "Picture_FIND_DATES";
		PictureBox picture_FIND_DATES2 = Picture_FIND_DATES;
		size = new Size(27, 19);
		((Control)picture_FIND_DATES2).Size = size;
		Picture_FIND_DATES.SizeMode = (PictureBoxSizeMode)4;
		Picture_FIND_DATES.TabIndex = 1042;
		Picture_FIND_DATES.TabStop = false;
		DateTime2_FIND.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTime2_FIND).Font = new Font("Tahoma", 9f);
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime2_FIND = DateTime2_FIND;
		location = new Point(128, 1);
		((Control)dateTime2_FIND).Location = location;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		DateTimePicker dateTime2_FIND2 = DateTime2_FIND;
		size = new Size(92, 22);
		((Control)dateTime2_FIND2).Size = size;
		((Control)DateTime2_FIND).TabIndex = 1039;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		location = new Point(93, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(35, 22);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 1040;
		PictureBox1.TabStop = false;
		((ButtonBase)Check_FIND_DATE).AutoSize = true;
		((Control)Check_FIND_DATE).Font = new Font("Tahoma", 9f);
		((Control)Check_FIND_DATE).ForeColor = Color.White;
		CheckBox check_FIND_DATE = Check_FIND_DATE;
		location = new Point(332, 6);
		((Control)check_FIND_DATE).Location = location;
		((Control)Check_FIND_DATE).Name = "Check_FIND_DATE";
		CheckBox check_FIND_DATE2 = Check_FIND_DATE;
		size = new Size(80, 18);
		((Control)check_FIND_DATE2).Size = size;
		((Control)Check_FIND_DATE).TabIndex = 1041;
		((ButtonBase)Check_FIND_DATE).Text = "avec date";
		((ButtonBase)Check_FIND_DATE).UseVisualStyleBackColor = true;
		((ButtonBase)Check_FIND_EXACTE).AutoSize = true;
		((Control)Check_FIND_EXACTE).Font = new Font("Tahoma", 9f);
		((Control)Check_FIND_EXACTE).ForeColor = Color.White;
		CheckBox check_FIND_EXACTE = Check_FIND_EXACTE;
		location = new Point(263, 6);
		((Control)check_FIND_EXACTE).Location = location;
		((Control)Check_FIND_EXACTE).Name = "Check_FIND_EXACTE";
		CheckBox check_FIND_EXACTE2 = Check_FIND_EXACTE;
		size = new Size(63, 18);
		((Control)check_FIND_EXACTE2).Size = size;
		((Control)Check_FIND_EXACTE).TabIndex = 1038;
		((ButtonBase)Check_FIND_EXACTE).Text = "exacte";
		((ButtonBase)Check_FIND_EXACTE).UseVisualStyleBackColor = true;
		((Control)Panel8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel8).BackgroundImageLayout = (ImageLayout)4;
		((Control)Panel8).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel8).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Label5);
		((Control)Panel8).Controls.Add((Control)(object)Label7);
		((Control)Panel8).Controls.Add((Control)(object)Label11);
		((Control)Panel8).Controls.Add((Control)(object)Label13);
		Panel panel3 = Panel8;
		location = new Point(3, 3);
		((Control)panel3).Location = location;
		((Control)Panel8).Name = "Panel8";
		Panel panel4 = Panel8;
		size = new Size(254, 24);
		((Control)panel4).Size = size;
		((Control)Panel8).TabIndex = 1035;
		Combo_FIND.BackColor = Color.FromArgb(22, 106, 238);
		Combo_FIND.DropDownStyle = (ComboBoxStyle)2;
		Combo_FIND.DropDownWidth = 100;
		Combo_FIND.FlatStyle = (FlatStyle)0;
		((Control)Combo_FIND).Font = new Font("Tahoma", 9f);
		Combo_FIND.ForeColor = Color.White;
		((ListControl)Combo_FIND).FormattingEnabled = true;
		Combo_FIND.Items.AddRange(new object[5] { "ID_REGLE", "ID_CLIENT", "CODE_CLIENT", "CLIENT", "DATES" });
		ComboBox combo_FIND = Combo_FIND;
		location = new Point(0, 1);
		((Control)combo_FIND).Location = location;
		((Control)Combo_FIND).Name = "Combo_FIND";
		ComboBox combo_FIND2 = Combo_FIND;
		size = new Size(75, 22);
		((Control)combo_FIND2).Size = size;
		((Control)Combo_FIND).TabIndex = 1038;
		Picture_REFRESH.Image = (Image)componentResourceManager.GetObject("Picture_REFRESH.Image");
		PictureBox picture_REFRESH = Picture_REFRESH;
		location = new Point(220, 3);
		((Control)picture_REFRESH).Location = location;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		PictureBox picture_REFRESH2 = Picture_REFRESH;
		size = new Size(27, 19);
		((Control)picture_REFRESH2).Size = size;
		Picture_REFRESH.SizeMode = (PictureBoxSizeMode)4;
		Picture_REFRESH.TabIndex = 1037;
		Picture_REFRESH.TabStop = false;
		Picture_FIND.Image = (Image)componentResourceManager.GetObject("Picture_FIND.Image");
		PictureBox picture_FIND = Picture_FIND;
		location = new Point(187, 3);
		((Control)picture_FIND).Location = location;
		((Control)Picture_FIND).Name = "Picture_FIND";
		PictureBox picture_FIND2 = Picture_FIND;
		size = new Size(27, 19);
		((Control)picture_FIND2).Size = size;
		Picture_FIND.SizeMode = (PictureBoxSizeMode)4;
		Picture_FIND.TabIndex = 1038;
		Picture_FIND.TabStop = false;
		((TextBoxBase)Text_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)Text_FIND).BorderStyle = (BorderStyle)0;
		((Control)Text_FIND).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)Text_FIND).ForeColor = Color.White;
		TextBox text_FIND = Text_FIND;
		location = new Point(81, 5);
		((Control)text_FIND).Location = location;
		((Control)Text_FIND).Name = "Text_FIND";
		TextBox text_FIND2 = Text_FIND;
		size = new Size(100, 15);
		((Control)text_FIND2).Size = size;
		((Control)Text_FIND).TabIndex = 708;
		((Control)Label5).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label5).Cursor = Cursors.Hand;
		((Control)Label5).Dock = (DockStyle)2;
		((Control)Label5).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label39 = Label5;
		location = new Point(1, 23);
		((Control)label39).Location = location;
		((Control)Label5).Name = "Label5";
		Label label40 = Label5;
		size = new Size(252, 1);
		((Control)label40).Size = size;
		((Control)Label5).TabIndex = 1000;
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label7).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label7).Cursor = Cursors.Hand;
		((Control)Label7).Dock = (DockStyle)3;
		((Control)Label7).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label41 = Label7;
		location = new Point(0, 1);
		((Control)label41).Location = location;
		((Control)Label7).Name = "Label7";
		Label label42 = Label7;
		size = new Size(1, 23);
		((Control)label42).Size = size;
		((Control)Label7).TabIndex = 999;
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Label11).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).Dock = (DockStyle)4;
		((Control)Label11).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label43 = Label11;
		location = new Point(253, 1);
		((Control)label43).Location = location;
		((Control)Label11).Name = "Label11";
		Label label44 = Label11;
		size = new Size(1, 23);
		((Control)label44).Size = size;
		((Control)Label11).TabIndex = 998;
		Label11.TextAlign = (ContentAlignment)16;
		((Control)Label13).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label13).Cursor = Cursors.Hand;
		((Control)Label13).Dock = (DockStyle)1;
		((Control)Label13).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label45 = Label13;
		location = new Point(0, 0);
		((Control)label45).Location = location;
		((Control)Label13).Name = "Label13";
		Label label46 = Label13;
		size = new Size(254, 1);
		((Control)label46).Size = size;
		((Control)Label13).TabIndex = 997;
		Label13.Text = "-";
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(256, 468);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 871;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		Button_CLIENT._CODE_Button = null;
		Button_CLIENT._ID_Button = "";
		((ButtonBase)Button_CLIENT).BackColor = Color.Transparent;
		((Control)Button_CLIENT).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENT).FlatAppearance.BorderColor = Color.Black;
		((Control)Button_CLIENT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Button_CLIENT).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button_CLIENT).ImageAlign = (ContentAlignment)16;
		Button_ID_CODE button_CLIENT = Button_CLIENT;
		location = new Point(111, 9);
		((Control)button_CLIENT).Location = location;
		((Control)Button_CLIENT).Name = "Button_CLIENT";
		Button_ID_CODE button_CLIENT2 = Button_CLIENT;
		size = new Size(397, 26);
		((Control)button_CLIENT2).Size = size;
		((Control)Button_CLIENT).TabIndex = 1034;
		((ButtonBase)Button_CLIENT).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CLIENT).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_5_CLIENTS_REGLE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((ISupportInitialize)Picture_EXPORT).EndInit();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel8).PerformLayout();
		((ISupportInitialize)Picture_REFRESH).EndInit();
		((ISupportInitialize)Picture_FIND).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void FUN_CAT_ACCES()
	{
		if (Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = false;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = false;
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
			DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
			DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		}
	}

	private void FormDialog_famille_Load(object sender, EventArgs e)
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 0;
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				Combo_FIND.SelectedIndex = 0;
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
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
				DA = new MySqlDataAdapter("select * from        TABLE_CLIENTS_REGLE        order by       DATES     desc", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select   MODE_P   from TABLE_MODE_P ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_MODE_P.Items.Clear();
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
					Combo_MODE_P.Items.Add((object)dataTable.Rows[num6]["MODE_P"].ToString());
					num6++;
				}
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 28);
				tabControl.ItemSize = itemSize;
				FUN_CAT_ACCES();
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
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			Text_ID.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			Text_UTILISATEUR.Text = Module1._USERNAME;
			Button_CLIENT._ID_Button = "";
			Button_CLIENT._CODE_Button = "";
			((ButtonBase)Button_CLIENT).Text = "";
			Label_CREDIT.Text = "";
			Label_RETOUR_CREDIT.Text = "";
			Label_CREDIT_INITIAL.Text = "";
			Label_REGLE_CLIENT.Text = "";
			Text_CREDIT.Text = "";
			TextBox_MONTANT.Text = "";
			Combo_MODE_P.Text = null;
			TextBox_NOTES.Text = "";
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		try
		{
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 2), TextCompare: false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
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
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false))
			{
				int num = 320;
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
				{
					Print_Recette_Bon_ARABE.PrintController = (PrintController)new StandardPrintController();
					Print_Recette_Bon_ARABE.Print();
				}
				else
				{
					Print_Recette_Bon.PrintController = (PrintController)new StandardPrintController();
					Print_Recette_Bon.Print();
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

	public void _credit()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		string text = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value);
		string text2 = "SELECT SUM(TOTAL_NET)  AS N   FROM TABLE_VENTES_JOURNAL WHERE        ID_CLIENT = '" + text + "'      AND OPERATION = 'CREDIT'   ";
		string text3 = "SELECT SUM(TOTAL_NET)  AS N   FROM TABLE_VENTES_JOURNAL WHERE        ID_CLIENT = '" + text + "'      AND OPERATION = 'RETOUR CREDIT'    ";
		string text4 = "SELECT CREDIT_INITIAL  AS N   FROM TABLE_CLIENTS        WHERE        ID_CLIENT = '" + text + "'         ";
		string text5 = "SELECT SUM(MONTANT)    AS N   FROM TABLE_CLIENTS_REGLE  WHERE        ID_CLIENT = '" + text + "'           ";
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlCommand val = new MySqlCommand();
			val.Connection = Module1.cn_SQL;
			MySqlCommand val2 = val;
			try
			{
				val2.CommandText = " ( " + text2 + " )       UNION ALL         ( " + text3 + " )        UNION ALL     ( " + text4 + " )      UNION ALL     ( " + text5 + " )         ";
				MySqlDataReader val3 = val2.ExecuteReader();
				try
				{
					List<string> list = new List<string>();
					while (val3.Read())
					{
						list.Add(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val3[0])) ? "0" : val3[0].ToString());
					}
					if (list.Count >= 4)
					{
						decimal d = Conversions.ToDecimal(list[0]);
						decimal d2 = Conversions.ToDecimal(list[1]);
						decimal d3 = Conversions.ToDecimal(list[2]);
						decimal d4 = Conversions.ToDecimal(list[3]);
						_total_credit = LOGICA.Domain.ClientCreditBalance.Calculate(d, d2, d3, d4);
					}
					else
					{
						_total_credit = 0m;
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				val2.Parameters.Clear();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Erreur : " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Module1.cn_SQL.Close();
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		try
		{
			((Form)this).Close();
			((Control)MyProject.Forms.Form_1_LOGIN).Show();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).BringToFront();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).Show();
			if ((Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0) | (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0))
			{
				((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).BringToFront();
				((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).Show();
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
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Button_CLIENT._ID_Button, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -ID_CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(((ButtonBase)Button_CLIENT).Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(TextBox_MONTANT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -MONTANT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (LOGICA.Domain.ClientSettlementAmountRule.IsRejected(TextBox_MONTANT.Text))
				{
					MessageBox.Show("Veuillez remplir le champ -MONTANT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Combo_MODE_P.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -MODE_P- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					MySqlCommand val = new MySqlCommand();
					val.CommandText = "SELECT MAX(ID) From TABLE_CLIENTS_REGLE ";
					val.Connection = Module1.cn_SQL;
					val.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = LOGICA.Domain.ClientSettlementSequence.NextId(() => val.ExecuteScalar());
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[index]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[index]["ID_REGLE"] = Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text;
					DT.Rows[index]["ID_CLIENT"] = Button_CLIENT._ID_Button;
					DT.Rows[index]["CODE_CLIENT"] = Button_CLIENT._CODE_Button;
					DT.Rows[index]["CLIENT"] = ((ButtonBase)Button_CLIENT).Text;
					DT.Rows[index]["MONTANT"] = TextBox_MONTANT.Text;
					DT.Rows[index]["MODE_P"] = Combo_MODE_P.Text;
					DT.Rows[index]["NOTES"] = TextBox_NOTES.Text;
					DT.Rows[index]["ETAT"] = "VALIDER";
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void Button11_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		checked
		{
			try
			{
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				((Control)MyProject.Forms.FormDialog_PATIENTER).Show();
				Application.DoEvents();
				((Form)MyProject.Forms.FormDialog_PATIENTER).Close();
				int num = 90;
				int num2 = 300;
				int num3 = num + num2 + 50;
				Print_Recette_Bon.DefaultPageSettings.PaperSize = new PaperSize("Custom", 264, num3);
				PrintPreviewDialog val = new PrintPreviewDialog();
				val.Document = Print_Recette_Bon;
				val.PrintPreviewControl.Zoom = 2.0;
				((Form)val).WindowState = (FormWindowState)2;
				((Form)val).ShowDialog();
				Print_Recette_Bon.Print();
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
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
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
		}
	}

	private void Print_Recette_Bon_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0395: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		try
		{
			e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
			string text = "REÇU REGLEMENT CLIENT";
			e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 14f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 12f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
			int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
			e.Graphics.DrawString("Date d'opération  : " + Conversions.ToDate(DT.Rows[position]["DATES"].ToString()).ToString("yyyy-MM-dd"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 40f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("Date d'impression : " + Conversions.ToString(DateTime.Now), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 60f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("ID_CLIENT         : " + DT.Rows[position]["ID_CLIENT"].ToString(), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("Client            : " + DT.Rows[position]["Client"].ToString(), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("Mode_P            : " + DT.Rows[position]["MODE_P"].ToString(), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 140f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("MONTANT           : " + DT.Rows[position]["MONTANT"].ToString() + " DH", new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 180f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawString("NOTES             : " + DT.Rows[position]["NOTES"].ToString(), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 200f, new StringFormat((StringFormatFlags)8192));
			_credit();
			e.Graphics.DrawString("Total Crédit      : " + Conversions.ToString(_total_credit) + " DH", new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, 0f, 240f, new StringFormat((StringFormatFlags)8192));
			e.Graphics.DrawRectangle(new Pen(Color.Black), 80, 260, 100, 40);
			e.Graphics.DrawString("VISA", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Gray, 110f, 265f, new StringFormat((StringFormatFlags)8192));
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
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
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

	private void TextBox3_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Button_CLIENT_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
		((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
		if (Operators.CompareString(Button_CLIENT._ID_Button, "", TextCompare: false) != 0)
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE          ID_CLIENT  =  '" + Button_CLIENT._ID_Button + "'        AND      OPERATION  =  'CREDIT'          ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			decimal num = 0m;
			num = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_CREDIT.Text = Conversions.ToString(num);
			dataTable.Clear();
			val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE          ID_CLIENT  =  '" + Button_CLIENT._ID_Button + "'       AND    OPERATION  =  'RETOUR CREDIT'        ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			decimal num2 = 0m;
			num2 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_RETOUR_CREDIT.Text = Conversions.ToString(num2);
			dataTable.Clear();
			val = new MySqlDataAdapter("SELECT    CREDIT_INITIAL     as N          FROM   TABLE_CLIENTS     WHERE          ID_CLIENT  =  '" + Button_CLIENT._ID_Button + "'             ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			decimal num3 = 0m;
			num3 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_CREDIT_INITIAL.Text = Conversions.ToString(num3);
			dataTable.Clear();
			val = new MySqlDataAdapter("select    SUM(MONTANT)      as N           from   TABLE_CLIENTS_REGLE       WHERE         ID_CLIENT  =  '" + Button_CLIENT._ID_Button + "'                 ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			decimal num4 = 0m;
			num4 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_REGLE_CLIENT.Text = Conversions.ToString(num4);
			Text_CREDIT.Text = Conversions.ToString(LOGICA.Domain.ClientCreditBalance.Calculate(num, num2, num3, num4)) + " DH";
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
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(Combo_FIND.Text, "DATES", TextCompare: false) == 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "      Where       Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '               order by   ID    desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
			}
			else
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
					DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where            "), _sql), "            ("), Combo_FIND.Text), "  like  '%"), Text_FIND.Text), "%'   )                                order by   ID    desc ")), Module1.cn_SQL);
					((DbDataAdapter)(object)DA).Fill(DT);
				}
				else if (Check_FIND_EXACTE.Checked)
				{
					DT.Clear();
					DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where            "), _sql), "            ("), Combo_FIND.Text), "  like  '"), Text_FIND.Text), "'     )                                order by   ID    desc ")), Module1.cn_SQL);
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

	private void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		try
		{
			Text_FIND.Text = "";
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
			((Control)Panel_DATES).Left = 78;
			Text_FIND.Text = "*";
		}
		else
		{
			((Control)Panel_DATES).Visible = false;
			((Control)Panel_DATES).Left = 417;
			Text_FIND.Text = "";
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

	private void Print_Recette_Bon_ARABE_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		try
		{
			e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
			string text = "إيصال الدفع للزبون";
			e.Graphics.DrawString(text, new Font("Kawkab Mono", 8f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Kawkab Mono", 8f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
			int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
			e.Graphics.DrawString("تاريخ العملية   : " + Conversions.ToDate(DT.Rows[position]["DATES"].ToString()).ToString("yyyy-MM-dd"), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 40f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("تاريخ الطباعة   : " + Conversions.ToString(DateTime.Now), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 60f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("رقم الزبون      : " + DT.Rows[position]["ID_CLIENT"].ToString(), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 100f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("الزبون          : " + DT.Rows[position]["Client"].ToString(), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 120f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("طريقة الدفع     : " + DT.Rows[position]["MODE_P"].ToString(), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 140f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("المبلغ          : " + DT.Rows[position]["MONTANT"].ToString() + " درهم", new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 180f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawString("ملاحظة            : " + DT.Rows[position]["NOTES"].ToString(), new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 200f, new StringFormat((StringFormatFlags)1));
			_credit();
			e.Graphics.DrawString("مجموع الكريدي   : " + Conversions.ToString(_total_credit) + " درهم", new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, 240f, new StringFormat((StringFormatFlags)1));
			e.Graphics.DrawRectangle(new Pen(Color.Black), 80, 260, 100, 40);
			e.Graphics.DrawString("إمضاء", new Font("Kawkab Mono", 11f, (FontStyle)1), Brushes.Gray, 110f, 265f, new StringFormat((StringFormatFlags)8192));
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
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
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
}
