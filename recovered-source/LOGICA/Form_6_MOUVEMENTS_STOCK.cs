using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using CustomControls.RJControls;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_6_MOUVEMENTS_STOCK : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("ID")]
	private DataGridViewTextBoxColumn _ID;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("HEURE")]
	private DataGridViewTextBoxColumn _HEURE;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("LIBELLE")]
	private DataGridViewTextBoxColumn _LIBELLE;

	[AccessedThroughProperty("CODE_ARTICLE")]
	private DataGridViewTextBoxColumn _CODE_ARTICLE;

	[AccessedThroughProperty("ARTICLE")]
	private DataGridViewTextBoxColumn _ARTICLE;

	[AccessedThroughProperty("QUANTITE")]
	private DataGridViewTextBoxColumn _QUANTITE;

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

	[AccessedThroughProperty("Panel243544")]
	private Panel _Panel243544;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private DataSet DS;

	private int _SCROLLVAL;

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
			_DataGridView1 = value;
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

	internal virtual DataGridViewTextBoxColumn ID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID = value;
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

	internal virtual DataGridViewTextBoxColumn HEURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _HEURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HEURE = value;
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

	internal virtual DataGridViewTextBoxColumn LIBELLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _LIBELLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LIBELLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_ARTICLE = value;
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

	internal virtual DataGridViewTextBoxColumn QUANTITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _QUANTITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_QUANTITE = value;
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
			_Button_CALC_BD = value;
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
			_Button1 = value;
		}
	}

	public Form_6_MOUVEMENTS_STOCK()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		((Form)this).FormClosed += Form_6_MOUVEMENTS_STOCK_FormClosed;
		((Form)this).Load += Form_Load;
		((Control)this).KeyDown += me_KeyDown;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		DS = new DataSet();
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
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
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
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
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected Obj, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected Obj, but got Unknown
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected Obj, but got Unknown
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Expected Obj, but got Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Expected Obj, but got Unknown
		//IL_1154: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Expected Obj, but got Unknown
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Expected Obj, but got Unknown
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_1623: Expected Obj, but got Unknown
		//IL_1a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a12: Expected Obj, but got Unknown
		//IL_1b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b48: Expected Obj, but got Unknown
		//IL_1c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2f: Expected Obj, but got Unknown
		//IL_1c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Expected Obj, but got Unknown
		//IL_1f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f25: Expected Obj, but got Unknown
		//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb4: Expected Obj, but got Unknown
		//IL_208a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2094: Expected Obj, but got Unknown
		//IL_2156: Unknown result type (might be due to invalid IL or missing references)
		//IL_2160: Expected Obj, but got Unknown
		//IL_2309: Unknown result type (might be due to invalid IL or missing references)
		//IL_2313: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_MOUVEMENTS_STOCK));
		DataGridView1 = new DataGridView();
		ID = new DataGridViewTextBoxColumn();
		DATES = new DataGridViewTextBoxColumn();
		HEURE = new DataGridViewTextBoxColumn();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		LIBELLE = new DataGridViewTextBoxColumn();
		CODE_ARTICLE = new DataGridViewTextBoxColumn();
		ARTICLE = new DataGridViewTextBoxColumn();
		QUANTITE = new DataGridViewTextBoxColumn();
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
		Panel243544 = new Panel();
		Button2 = new Button();
		Button1 = new Button();
		Label_TOTAL_LIGNES_BD = new Label();
		Label31 = new Label();
		Label27 = new Label();
		Button_CALC_BD = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)Panel243544).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		val.BackColor = Color.FromArgb(255, 128, 128);
		DataGridView1.AlternatingRowsDefaultCellStyle = val;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Calibri", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val2;
		DataGridView1.ColumnHeadersHeight = 24;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)DATES,
			(DataGridViewColumn)HEURE,
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)LIBELLE,
			(DataGridViewColumn)CODE_ARTICLE,
			(DataGridViewColumn)ARTICLE,
			(DataGridViewColumn)QUANTITE
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(0, 42);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 25;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(1025, 566);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 0;
		((DataGridViewColumn)ID).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID).DataPropertyName = "ID";
		val3.Format = "d";
		val3.NullValue = null;
		((DataGridViewColumn)ID).DefaultCellStyle = val3;
		((DataGridViewColumn)ID).HeaderText = "ID";
		((DataGridViewColumn)ID).Name = "ID";
		ID.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID).Width = 50;
		((DataGridViewColumn)DATES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES).DataPropertyName = "DATES";
		((DataGridViewColumn)DATES).HeaderText = "DATES";
		((DataGridViewColumn)DATES).MinimumWidth = 2;
		((DataGridViewColumn)DATES).Name = "DATES";
		((DataGridViewColumn)DATES).Width = 80;
		((DataGridViewColumn)HEURE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)HEURE).DataPropertyName = "HEURE";
		((DataGridViewColumn)HEURE).HeaderText = "HEURE";
		((DataGridViewColumn)HEURE).Name = "HEURE";
		((DataGridViewColumn)HEURE).Width = 80;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)LIBELLE).DataPropertyName = "LIBELLE";
		((DataGridViewColumn)LIBELLE).HeaderText = "LIBELLE";
		((DataGridViewColumn)LIBELLE).Name = "LIBELLE";
		LIBELLE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)CODE_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_ARTICLE).DataPropertyName = "CODE_ARTICLE";
		((DataGridViewColumn)CODE_ARTICLE).HeaderText = "CODE_ARTICLE";
		((DataGridViewColumn)CODE_ARTICLE).Name = "CODE_ARTICLE";
		CODE_ARTICLE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ARTICLE).DataPropertyName = "ARTICLE";
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.Format = "N2";
		((DataGridViewColumn)ARTICLE).DefaultCellStyle = val4;
		((DataGridViewColumn)ARTICLE).HeaderText = "ARTICLE";
		((DataGridViewColumn)ARTICLE).Name = "ARTICLE";
		ARTICLE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ARTICLE).Width = 200;
		((DataGridViewColumn)QUANTITE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)QUANTITE).DataPropertyName = "QUANTITE";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		((DataGridViewColumn)QUANTITE).DefaultCellStyle = val5;
		((DataGridViewColumn)QUANTITE).HeaderText = "QUANTITE";
		((DataGridViewColumn)QUANTITE).Name = "QUANTITE";
		QUANTITE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)QUANTITE).Width = 80;
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
		((Control)Label_TABLE).TabIndex = 852;
		Label_TABLE.Text = "MOUVEMENTS_STOCK";
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
		((Control)Panel_FIND).TabIndex = 1074;
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
		PictureBox pictureBox = PictureBox13;
		location = new Point(108, 6);
		((Control)pictureBox).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox2 = PictureBox13;
		size = new Size(35, 26);
		((Control)pictureBox2).Size = size;
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
		((ComboBox)Combo_FIND).Items.AddRange(new object[5] { "ID_ARTICLE", "CODE_ARTICLE", "ARTICLE", "LIBELLE", "DATES" });
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
		Label label = Label19;
		location = new Point(492, 13);
		((Control)label).Location = location;
		((Control)Label19).Name = "Label19";
		Label label2 = Label19;
		size = new Size(65, 17);
		((Control)label2).Size = size;
		((Control)Label19).TabIndex = 1055;
		Label19.Text = "Avec date";
		Label25.AutoSize = true;
		((Control)Label25).Font = new Font("Segoe UI", 9.75f);
		((Control)Label25).ForeColor = Color.White;
		Label25.ImeMode = (ImeMode)0;
		Label label3 = Label25;
		location = new Point(411, 13);
		((Control)label3).Location = location;
		((Control)Label25).Name = "Label25";
		Label label4 = Label25;
		size = new Size(45, 17);
		((Control)label4).Size = size;
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
		Padding margin = new Padding(4);
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
		((Control)Panel243544).Anchor = (AnchorStyles)14;
		((Control)Panel243544).BackColor = Color.Transparent;
		((Control)Panel243544).Controls.Add((Control)(object)Button2);
		((Control)Panel243544).Controls.Add((Control)(object)Button1);
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label31);
		((Control)Panel243544).Controls.Add((Control)(object)Label27);
		((Control)Panel243544).Controls.Add((Control)(object)Button_CALC_BD);
		Panel panel = Panel243544;
		location = new Point(0, 609);
		((Control)panel).Location = location;
		((Control)Panel243544).Name = "Panel243544";
		Panel panel2 = Panel243544;
		size = new Size(1025, 31);
		((Control)panel2).Size = size;
		((Control)Panel243544).TabIndex = 1075;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		Button button = Button2;
		location = new Point(114, 1);
		((Control)button).Location = location;
		((Control)Button2).Name = "Button2";
		Button button2 = Button2;
		size = new Size(45, 29);
		((Control)button2).Size = size;
		((Control)Button2).TabIndex = 1077;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		Button button3 = Button1;
		location = new Point(69, 1);
		((Control)button3).Location = location;
		((Control)Button1).Name = "Button1";
		Button button4 = Button1;
		size = new Size(45, 29);
		((Control)button4).Size = size;
		((Control)Button1).TabIndex = 1076;
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
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
		Label label5 = Label31;
		location = new Point(0, 30);
		((Control)label5).Location = location;
		((Control)Label31).Name = "Label31";
		Label label6 = Label31;
		size = new Size(1025, 1);
		((Control)label6).Size = size;
		((Control)Label31).TabIndex = 1067;
		Label31.TextAlign = (ContentAlignment)16;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)1;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label7 = Label27;
		location = new Point(0, 0);
		((Control)label7).Location = location;
		((Control)Label27).Name = "Label27";
		Label label8 = Label27;
		size = new Size(1025, 1);
		((Control)label8).Size = size;
		((Control)Label27).TabIndex = 1066;
		Label27.TextAlign = (ContentAlignment)16;
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		Button button_CALC_BD = Button_CALC_BD;
		location = new Point(265, 1);
		((Control)button_CALC_BD).Location = location;
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		Button button_CALC_BD2 = Button_CALC_BD;
		size = new Size(48, 29);
		((Control)button_CALC_BD2).Size = size;
		((Control)Button_CALC_BD).TabIndex = 1063;
		((ButtonBase)Button_CALC_BD).Text = "CALC";
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		((Control)Button_CALC_BD).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel243544);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_6_MOUVEMENTS_STOCK";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)Panel243544).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
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

	private void Form_Load(object sender, EventArgs e)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		checked
		{
			try
			{
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
				DataGridView1.ClearSelection();
				DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "              order by       ID      DESC", Module1.cn_SQL);
				DS = new DataSet();
				((DbDataAdapter)(object)DA).Fill(DS, _SCROLLVAL, 100, "x");
				DataGridView1.DataSource = DS;
				DataGridView1.DataMember = "x";
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

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_DATES_Click(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private sealed class MovementSearchContext : LOGICA.ApplicationLayer.Inventory.IStockMovementSearchContext
    {
        private readonly Form_6_MOUVEMENTS_STOCK form;
        public MovementSearchContext(Form_6_MOUVEMENTS_STOCK form) { this.form = form; }
        public string Column { get { return form.Combo_FIND.Text; } }
        public string Text { get { return form.Text_FIND.Texts; } }
        public bool UseDates { get { return form.Check_FIND_DATE.Checked; } }
        public bool Exact { get { return form.Check_FIND_EXACTE.Checked; } }
        public void LoadDateRange()
        {
            form.DT.Clear();
            form.DA = LOGICA.Infrastructure.Inventory.StockMovementQuery.DateRange(form.Label_TABLE.Text, form.DateTime1_FIND.Value, form.DateTime2_FIND.Value, Module1.cn_SQL);
            ((DbDataAdapter)(object)form.DA).Fill(form.DT);
        }
        public void SetDatePrefix()
        {
            form._sql = LOGICA.Infrastructure.Inventory.StockMovementQuery.DatePrefix(form.DateTime1_FIND.Value, form.DateTime2_FIND.Value);
        }
        public void ClearDatePrefix() { form._sql = ""; }
        public void LoadContains()
        {
            form.DT.Clear();
            form.DA = LOGICA.Infrastructure.Inventory.StockMovementQuery.Contains(form.Label_TABLE.Text, form._sql, form.Combo_FIND.Text, form.Text_FIND.Texts, Module1.cn_SQL);
            ((DbDataAdapter)(object)form.DA).Fill(form.DT);
        }
        public void LoadExactLike()
        {
            form.DT.Clear();
            form.DA = LOGICA.Infrastructure.Inventory.StockMovementQuery.ExactLike(form.Label_TABLE.Text, form._sql, form.Combo_FIND.Text, form.Text_FIND.Texts, Module1.cn_SQL);
            ((DbDataAdapter)(object)form.DA).Fill(form.DT);
        }
        public void BindResults() { form.DataGridView1.DataSource = form.DT; }
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
			LOGICA.ApplicationLayer.Inventory.StockMovementSearchService.Search(new MovementSearchContext(this), LOGICA.Infrastructure.Compatibility.VisualBasicStockMovementSemantics.Instance);
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

	private sealed class MovementRefreshContext : LOGICA.ApplicationLayer.Inventory.IStockMovementRefreshContext
    {
        private readonly Form_6_MOUVEMENTS_STOCK form;
        private readonly object sender;
        public MovementRefreshContext(Form_6_MOUVEMENTS_STOCK form, object sender) { this.form = form; this.sender = sender; }
        public void FocusSender()
        {
            NewLateBinding.LateCall(sender, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
        }
        public void ClearSearch() { form.Text_FIND.Texts = ""; }
        public void FocusSearch() { ((Control)form.Text_FIND).Focus(); }
        public void ReloadAll()
        {
            form.DT.Clear();
            form.DA = LOGICA.Infrastructure.Inventory.StockMovementQuery.Refresh(form.Label_TABLE.Text, Module1.cn_SQL);
            ((DbDataAdapter)(object)form.DA).Fill(form.DT);
        }
        public void BindResults() { form.DataGridView1.DataSource = form.DT; }
    }

    public void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		try
		{
			LOGICA.ApplicationLayer.Inventory.StockMovementRefreshService.Refresh(new MovementRefreshContext(this, sender));
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
}
