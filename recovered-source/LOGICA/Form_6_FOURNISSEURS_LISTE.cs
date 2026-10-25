using System;
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
using CustomControls.RJControls;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_6_FOURNISSEURS_LISTE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Panel_FICHE")]
	private Panel _Panel_FICHE;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Text_CODE_FOURNISSEUR")]
	private TextBox _Text_CODE_FOURNISSEUR;

	[AccessedThroughProperty("Text_ADRESSE")]
	private TextBox _Text_ADRESSE;

	[AccessedThroughProperty("Text_FOURNISSEUR")]
	private TextBox _Text_FOURNISSEUR;

	[AccessedThroughProperty("Text_TEL")]
	private TextBox _Text_TEL;

	[AccessedThroughProperty("Text_ID_FOURNISSEUR")]
	private TextBox _Text_ID_FOURNISSEUR;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("ID_FOURNISSEUR")]
	private DataGridViewTextBoxColumn _ID_FOURNISSEUR;

	[AccessedThroughProperty("CODE_FOURNISSEUR")]
	private DataGridViewTextBoxColumn _CODE_FOURNISSEUR;

	[AccessedThroughProperty("FOURNISSEUR")]
	private DataGridViewTextBoxColumn _FOURNISSEUR;

	[AccessedThroughProperty("TELEPHONE")]
	private DataGridViewTextBoxColumn _TELEPHONE;

	[AccessedThroughProperty("ADRESSE")]
	private DataGridViewTextBoxColumn _ADRESSE;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Button_CLAVIERR")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIERR;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private Button_RJ _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private Button_RJ _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private RJTextBox _Text_FIND;

	private DataTable _dt;

	private MySqlDataAdapter _da;

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
			EventHandler eventHandler = DataGridView1_DoubleClick;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
			}
		}
	}

	internal virtual Button Button15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button15_Click;
			if (_Button15 != null)
			{
				((Control)_Button15).Click -= eventHandler;
			}
			_Button15 = value;
			if (_Button15 != null)
			{
				((Control)_Button15).Click += eventHandler;
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
			_Text_ADRESSE = value;
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
			_Text_FOURNISSEUR = value;
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

	internal virtual DataGridViewTextBoxColumn CODE_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_FOURNISSEUR = value;
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

	internal virtual DataGridViewTextBoxColumn ADRESSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ADRESSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ADRESSE = value;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIERR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIERR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIERR_Click;
			if (_Button_CLAVIERR != null)
			{
				((Control)_Button_CLAVIERR).Click -= eventHandler;
			}
			_Button_CLAVIERR = value;
			if (_Button_CLAVIERR != null)
			{
				((Control)_Button_CLAVIERR).Click += eventHandler;
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

	public Form_6_FOURNISSEURS_LISTE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_LISTE_CLIENTS_Load;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Shown += Form_6_FOURNISSEURS_LISTE_Shown;
		__ENCAddToList(this);
		_dt = new DataTable();
		_da = new MySqlDataAdapter();
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
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Obj, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected Obj, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected Obj, but got Unknown
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e35: Expected Obj, but got Unknown
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected Obj, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected Obj, but got Unknown
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Expected Obj, but got Unknown
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected Obj, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected Obj, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected Obj, but got Unknown
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected Obj, but got Unknown
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_156b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Expected Obj, but got Unknown
		//IL_1648: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Expected Obj, but got Unknown
		//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ff: Expected Obj, but got Unknown
		//IL_1788: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Expected Obj, but got Unknown
		//IL_181b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1825: Expected Obj, but got Unknown
		//IL_18ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b8: Expected Obj, but got Unknown
		//IL_1923: Unknown result type (might be due to invalid IL or missing references)
		//IL_192d: Expected Obj, but got Unknown
		//IL_1b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b38: Expected Obj, but got Unknown
		//IL_1c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Expected Obj, but got Unknown
		//IL_1d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d54: Expected Obj, but got Unknown
		//IL_1d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_FOURNISSEURS_LISTE));
		DataGridView1 = new DataGridView();
		ID_FOURNISSEUR = new DataGridViewTextBoxColumn();
		CODE_FOURNISSEUR = new DataGridViewTextBoxColumn();
		FOURNISSEUR = new DataGridViewTextBoxColumn();
		TELEPHONE = new DataGridViewTextBoxColumn();
		ADRESSE = new DataGridViewTextBoxColumn();
		Button15 = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Button1 = new Button();
		Button6 = new Button();
		Label1 = new Label();
		Label_TABLE = new Label();
		Panel_FICHE = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Text_ID_FOURNISSEUR = new TextBox();
		Label11 = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Label10 = new Label();
		Label2 = new Label();
		Label24 = new Label();
		Label8 = new Label();
		Label_TOP = new Label();
		Text_ID = new TextBox();
		Text_CODE_FOURNISSEUR = new TextBox();
		Text_ADRESSE = new TextBox();
		Text_FOURNISSEUR = new TextBox();
		Text_TEL = new TextBox();
		Button_CLAVIERR = new Button_CLAVIER_NOSELECT();
		Panel_FIND = new Panel();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FICHE).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)13;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)ID_FOURNISSEUR,
			(DataGridViewColumn)CODE_FOURNISSEUR,
			(DataGridViewColumn)FOURNISSEUR,
			(DataGridViewColumn)TELEPHONE,
			(DataGridViewColumn)ADRESSE
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(3, 44);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(826, 506);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 4;
		((DataGridViewColumn)ID_FOURNISSEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_FOURNISSEUR).DataPropertyName = "ID_FOURNISSEUR";
		((DataGridViewColumn)ID_FOURNISSEUR).HeaderText = "ID_FOURNISSEUR";
		((DataGridViewColumn)ID_FOURNISSEUR).Name = "ID_FOURNISSEUR";
		ID_FOURNISSEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID_FOURNISSEUR).Width = 160;
		((DataGridViewColumn)CODE_FOURNISSEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_FOURNISSEUR).DataPropertyName = "CODE_FOURNISSEUR";
		((DataGridViewColumn)CODE_FOURNISSEUR).HeaderText = "CODE_FOURNISSEUR";
		((DataGridViewColumn)CODE_FOURNISSEUR).MinimumWidth = 2;
		((DataGridViewColumn)CODE_FOURNISSEUR).Name = "CODE_FOURNISSEUR";
		((DataGridViewColumn)CODE_FOURNISSEUR).Width = 2;
		((DataGridViewColumn)FOURNISSEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)FOURNISSEUR).DataPropertyName = "FOURNISSEUR";
		((DataGridViewColumn)FOURNISSEUR).FillWeight = 12.98701f;
		((DataGridViewColumn)FOURNISSEUR).HeaderText = "FOURNISSEUR";
		((DataGridViewColumn)FOURNISSEUR).Name = "FOURNISSEUR";
		FOURNISSEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)FOURNISSEUR).Width = 200;
		((DataGridViewColumn)TELEPHONE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TELEPHONE).DataPropertyName = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).FillWeight = 187.013f;
		((DataGridViewColumn)TELEPHONE).HeaderText = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).Name = "TELEPHONE";
		TELEPHONE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TELEPHONE).Width = 120;
		((DataGridViewColumn)ADRESSE).DataPropertyName = "ADRESSE";
		((DataGridViewColumn)ADRESSE).HeaderText = "ADRESSE";
		((DataGridViewColumn)ADRESSE).Name = "ADRESSE";
		((ButtonBase)Button15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button15).Cursor = Cursors.Hand;
		((ButtonBase)Button15).FlatStyle = (FlatStyle)0;
		((Control)Button15).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button15).ForeColor = Color.White;
		Button button = Button15;
		location = new Point(671, 553);
		((Control)button).Location = location;
		Button button2 = Button15;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button15).Name = "Button15";
		Button button3 = Button15;
		size = new Size(155, 54);
		((Control)button3).Size = size;
		((Control)Button15).TabIndex = 1036;
		((ButtonBase)Button15).Text = "Valider Fournisseur";
		((ButtonBase)Button15).UseVisualStyleBackColor = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 666);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(825, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1040;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 0);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 670);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1039;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(829, 0);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 670);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1038;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button1).BackColor = Color.Red;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button1).ForeColor = Color.White;
		Button button4 = Button1;
		location = new Point(671, 607);
		((Control)button4).Location = location;
		Button button5 = Button1;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(155, 54);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 1042;
		((ButtonBase)Button1).Text = "Annuler Fournisseur";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((ButtonBase)Button6).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatStyle = (FlatStyle)0;
		((Control)Button6).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button6).ForeColor = Color.White;
		Button button7 = Button6;
		location = new Point(7, 553);
		((Control)button7).Location = location;
		Button button8 = Button6;
		margin = new Padding(0);
		((Control)button8).Margin = margin;
		((Control)Button6).Name = "Button6";
		Button button9 = Button6;
		size = new Size(155, 54);
		((Control)button9).Size = size;
		((Control)Button6).TabIndex = 1045;
		((ButtonBase)Button6).Text = "Nouveau";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(735, 9);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(38, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1051;
		Label1.Text = "Label1";
		((Control)Label1).Visible = false;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Cursor = Cursors.Hand;
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(4, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(825, 44);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1052;
		Label_TABLE.Text = "FOURNISSEURS";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_FICHE).BackColor = Color.White;
		Panel_FICHE.BorderStyle = (BorderStyle)1;
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ID_FOURNISSEUR);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label11);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label10);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label24);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label8);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ID);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_CODE_FOURNISSEUR);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ADRESSE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_FOURNISSEUR);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_TEL);
		Panel panel_FICHE = Panel_FICHE;
		location = new Point(156, 234);
		((Control)panel_FICHE).Location = location;
		((Control)Panel_FICHE).Name = "Panel_FICHE";
		Panel panel_FICHE2 = Panel_FICHE;
		size = new Size(521, 202);
		((Control)panel_FICHE2).Size = size;
		((Control)Panel_FICHE).TabIndex = 1054;
		((Control)Panel_FICHE).Visible = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(241, 163);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 986;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_ID_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_ID_FOURNISSEUR).Enabled = false;
		((Control)Text_ID_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID_FOURNISSEUR = Text_ID_FOURNISSEUR;
		location = new Point(369, 29);
		((Control)text_ID_FOURNISSEUR).Location = location;
		((Control)Text_ID_FOURNISSEUR).Name = "Text_ID_FOURNISSEUR";
		TextBox text_ID_FOURNISSEUR2 = Text_ID_FOURNISSEUR;
		size = new Size(142, 29);
		((Control)text_ID_FOURNISSEUR2).Size = size;
		((Control)Text_ID_FOURNISSEUR).TabIndex = 983;
		((Control)Label11).BackColor = SystemColors.Control;
		((Control)Label11).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.Black;
		Label11.ImeMode = (ImeMode)0;
		Label label3 = Label11;
		location = new Point(259, 29);
		((Control)label3).Location = location;
		((Control)Label11).Name = "Label11";
		Label label4 = Label11;
		size = new Size(104, 26);
		((Control)label4).Size = size;
		((Control)Label11).TabIndex = 984;
		Label11.Text = "ID Fournisseur";
		Label11.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(3, 163);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 30);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 869;
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
		location = new Point(355, 163);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(156, 30);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 868;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label5 = Label10;
		location = new Point(8, 125);
		((Control)label5).Location = location;
		((Control)Label10).Name = "Label10";
		Label label6 = Label10;
		size = new Size(108, 26);
		((Control)label6).Size = size;
		((Control)Label10).TabIndex = 866;
		Label10.Text = "Adresse";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label7 = Label2;
		location = new Point(8, 93);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(108, 26);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 867;
		Label2.Text = "Tel";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.Black;
		Label label9 = Label24;
		location = new Point(8, 29);
		((Control)label9).Location = location;
		((Control)Label24).Name = "Label24";
		Label label10 = Label24;
		size = new Size(108, 26);
		((Control)label10).Size = size;
		((Control)Label24).TabIndex = 864;
		Label24.Text = "Code Fournisseur";
		Label24.TextAlign = (ContentAlignment)16;
		Label24.UseCompatibleTextRendering = true;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label11 = Label8;
		location = new Point(8, 61);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		Label label12 = Label8;
		size = new Size(108, 26);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 865;
		Label8.Text = "Fournisseur";
		Label8.TextAlign = (ContentAlignment)16;
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
		size = new Size(519, 24);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 863;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(196, 27);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(32, 29);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 700;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((TextBoxBase)Text_CODE_FOURNISSEUR).BackColor = Color.White;
		((TextBoxBase)Text_CODE_FOURNISSEUR).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_FOURNISSEUR = Text_CODE_FOURNISSEUR;
		location = new Point(122, 29);
		((Control)text_CODE_FOURNISSEUR).Location = location;
		((Control)Text_CODE_FOURNISSEUR).Name = "Text_CODE_FOURNISSEUR";
		TextBox text_CODE_FOURNISSEUR2 = Text_CODE_FOURNISSEUR;
		size = new Size(131, 29);
		((Control)text_CODE_FOURNISSEUR2).Size = size;
		((Control)Text_CODE_FOURNISSEUR).TabIndex = 696;
		((TextBoxBase)Text_ADRESSE).BackColor = Color.White;
		((TextBoxBase)Text_ADRESSE).BorderStyle = (BorderStyle)1;
		((Control)Text_ADRESSE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ADRESSE = Text_ADRESSE;
		location = new Point(122, 125);
		((Control)text_ADRESSE).Location = location;
		((Control)Text_ADRESSE).Name = "Text_ADRESSE";
		TextBox text_ADRESSE2 = Text_ADRESSE;
		size = new Size(389, 29);
		((Control)text_ADRESSE2).Size = size;
		((Control)Text_ADRESSE).TabIndex = 694;
		((TextBoxBase)Text_FOURNISSEUR).BackColor = Color.White;
		((TextBoxBase)Text_FOURNISSEUR).BorderStyle = (BorderStyle)1;
		((Control)Text_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_FOURNISSEUR = Text_FOURNISSEUR;
		location = new Point(122, 61);
		((Control)text_FOURNISSEUR).Location = location;
		((Control)Text_FOURNISSEUR).Name = "Text_FOURNISSEUR";
		TextBox text_FOURNISSEUR2 = Text_FOURNISSEUR;
		size = new Size(389, 29);
		((Control)text_FOURNISSEUR2).Size = size;
		((Control)Text_FOURNISSEUR).TabIndex = 689;
		((TextBoxBase)Text_TEL).BackColor = Color.White;
		((TextBoxBase)Text_TEL).BorderStyle = (BorderStyle)1;
		((Control)Text_TEL).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TEL = Text_TEL;
		location = new Point(122, 93);
		((Control)text_TEL).Location = location;
		((Control)Text_TEL).Name = "Text_TEL";
		TextBox text_TEL2 = Text_TEL;
		size = new Size(389, 29);
		((Control)text_TEL2).Size = size;
		((Control)Text_TEL).TabIndex = 693;
		((Control)Button_CLAVIERR).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIERR.BackgroundImage");
		((Control)Button_CLAVIERR).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIERR).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIERR = Button_CLAVIERR;
		location = new Point(398, 630);
		((Control)button_CLAVIERR).Location = location;
		((Control)Button_CLAVIERR).Name = "Button_CLAVIERR";
		Button_CLAVIER_NOSELECT button_CLAVIERR2 = Button_CLAVIERR;
		size = new Size(36, 31);
		((Control)button_CLAVIERR2).Size = size;
		((Control)Button_CLAVIERR).TabIndex = 1055;
		((ButtonBase)Button_CLAVIERR).UseVisualStyleBackColor = true;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		Panel panel_FIND = Panel_FIND;
		location = new Point(109, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(534, 44);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1058;
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
		Text_FIND.Font = new Font("Comic Sans MS", 9.75f);
		Text_FIND.ForeColor = Color.White;
		RJTextBox text_FIND = Text_FIND;
		location = new Point(4, 6);
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
		size = new Size(334, 33);
		((Control)text_FIND4).Size = size;
		((Control)Text_FIND).TabIndex = 986;
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(833, 670);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Button_CLAVIERR);
		((Control)this).Controls.Add((Control)(object)Panel_FICHE);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Button6);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Button15);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_6_FOURNISSEURS_LISTE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FICHE).ResumeLayout(false);
		((Control)Panel_FICHE).PerformLayout();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
	}

	private void FormDialog_LISTE_CLIENTS_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		_dt.Clear();
		_da = new MySqlDataAdapter("select         ID, ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,DATES,TELEPHONE,ADRESSE ,ETAT,CREDIT_INITIAL              from TABLE_FOURNISSEURS    order by FOURNISSEUR", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.RowTemplate.Height = 30;
		DataGridView1.DataSource = _dt;
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
		checked
		{
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
		}
	}

	private void Panel9_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from TABLE_FOURNISSEURS      ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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

	private void Panel9_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				Form val = Application.OpenForms[Label1.Text];
				if (val != null)
				{
					((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0])._ID_Button = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_FOURNISSEUR"].Value);
					((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0])._CODE_Button = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE_FOURNISSEUR"].Value);
					((ButtonBase)(Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0]).Text = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["FOURNISSEUR"].Value);
				}
				else
				{
					MessageBox.Show("Le formulaire spécifié n'est pas ouvert.");
				}
				((Form)this).Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Form val = Application.OpenForms[Label1.Text];
		if (val != null)
		{
			((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0])._ID_Button = "";
			((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0])._CODE_Button = "";
			((ButtonBase)(Button_ID_CODE)(object)((Control)val).Controls.Find("Button_FOURNISSEUR", true)[0]).Text = "";
		}
		else
		{
			MessageBox.Show("Le formulaire spécifié n'est pas ouvert.");
		}
		((Form)this).Close();
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		try
		{
			((Control)Text_FOURNISSEUR).Focus();
			((Control)Panel_FICHE).Visible = true;
			((Control)Panel_FICHE).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			Text_ID.Text = "";
			Text_ID_FOURNISSEUR.Text = "";
			Text_CODE_FOURNISSEUR.Text = "";
			Text_FOURNISSEUR.Text = "";
			Text_ADRESSE.Text = "";
			Text_TEL.Text = "";
			Label_TOP.Text = "NOUVEAU";
			((Control)Text_FOURNISSEUR).Focus();
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

	private void Panel_REFRESH_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Panel_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		try
		{
			((UserControl)Text_FIND).Text = "";
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from TABLE_FOURNISSEURS      ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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

	private void Form_6_FOURNISSEURS_LISTE_Shown(object sender, EventArgs e)
	{
		((UserControl)Text_FIND).Text = "";
		((Control)Text_FIND).Focus();
	}

	private void DataGridView1_DoubleClick(object sender, EventArgs e)
	{
		Button15.PerformClick();
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_FICHE).Hide();
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_FOURNISSEUR.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -FOURNISSEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
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
					_dt.Rows.Add();
					int index = _dt.Rows.Count - 1;
					_dt.Rows[index]["ID"] = num;
					_dt.Rows[index]["ID_FOURNISSEUR"] = value;
					_dt.Rows[index]["CODE_FOURNISSEUR"] = Strings.Trim(Text_CODE_FOURNISSEUR.Text);
					_dt.Rows[index]["FOURNISSEUR"] = Strings.Trim(Text_FOURNISSEUR.Text);
					_dt.Rows[index]["DATES"] = DateTime.Now.Date;
					_dt.Rows[index]["ADRESSE"] = Text_ADRESSE.Text;
					_dt.Rows[index]["TELEPHONE"] = Text_TEL.Text;
					_dt.Rows[index]["ETAT"] = "VALIDER";
					_dt.Rows[index]["CREDIT_INITIAL"] = 0;
					MySqlCommandBuilder val3 = new MySqlCommandBuilder(_da);
					((DbDataAdapter)(object)_da).Update(_dt);
					_dt.AcceptChanges();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val2.CommandText = "UPDATE     TABLE_NUM    SET FOURNISSEUR =  FOURNISSEUR + 1   ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					((UserControl)Text_FIND).Text = Text_CODE_FOURNISSEUR.Text;
				}
				((Control)Panel_FICHE).Hide();
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
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
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

	private void Button_CLAVIERR_Click(object sender, EventArgs e)
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

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		try
		{
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "         WHERE   FOURNISSEUR   like  '%" + Text_FIND.Texts + "%'      or      CODE_FOURNISSEUR  =  '" + Text_FIND.Texts + "'                              order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		try
		{
			Text_FIND.Texts = "";
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from      TABLE_" + Label_TABLE.Text + "                  order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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
}
