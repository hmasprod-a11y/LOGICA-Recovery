using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ATTRIBUTIONS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Text_COULEUR")]
	private TextBox _Text_COULEUR;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Text_CODE_COULEUR")]
	private TextBox _Text_CODE_COULEUR;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Text_TAILLE")]
	private TextBox _Text_TAILLE;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Text_CODE_TAILLE")]
	private TextBox _Text_CODE_TAILLE;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Text_TYPE")]
	private TextBox _Text_TYPE;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Text_CODE_TYPE")]
	private TextBox _Text_CODE_TYPE;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("CODE_TAILLE")]
	private DataGridViewTextBoxColumn _CODE_TAILLE;

	[AccessedThroughProperty("TAILLE")]
	private DataGridViewTextBoxColumn _TAILLE;

	[AccessedThroughProperty("DataGridViewButtonColumn1")]
	private DataGridViewButtonColumn _DataGridViewButtonColumn1;

	[AccessedThroughProperty("CODE_TYPE")]
	private DataGridViewTextBoxColumn _CODE_TYPE;

	[AccessedThroughProperty("TYPE")]
	private DataGridViewTextBoxColumn _TYPE;

	[AccessedThroughProperty("DataGridViewButtonColumn2")]
	private DataGridViewButtonColumn _DataGridViewButtonColumn2;

	[AccessedThroughProperty("CODE_COULEUR")]
	private DataGridViewTextBoxColumn _CODE_COULEUR;

	[AccessedThroughProperty("COULEUR")]
	private DataGridViewTextBoxColumn _COULEUR;

	[AccessedThroughProperty("suppp")]
	private DataGridViewButtonColumn _suppp;

	private DataTable _DT_TEMP_1;

	private MySqlDataAdapter _DA_TEMP_1;

	private DataTable _DT_TEMP_2;

	private MySqlDataAdapter _DA_TEMP_2;

	private DataTable _DT_TEMP_3;

	private MySqlDataAdapter _DA_TEMP_3;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellPaintingEventHandler val = DataGridView1_CellPainting;
			DataGridViewCellEventHandler val2 = DataGridView1_CellClick;
			DataGridViewCellEventHandler val3 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellPainting -= val;
				_DataGridView1.CellClick -= val2;
				_DataGridView1.CellContentClick -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellPainting += val;
				_DataGridView1.CellClick += val2;
				_DataGridView1.CellContentClick += val3;
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

	internal virtual TextBox Text_COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_COULEUR = value;
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

	internal virtual TextBox Text_CODE_COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_COULEUR = value;
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

	internal virtual TextBox Text_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TAILLE = value;
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

	internal virtual TextBox Text_CODE_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_TAILLE = value;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView2_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView2_CellContentClick;
			DataGridViewCellPaintingEventHandler val3 = DataGridView2_CellPainting;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellClick -= val;
				_DataGridView2.CellContentClick -= val2;
				_DataGridView2.CellPainting -= val3;
			}
			_DataGridView2 = value;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellClick += val;
				_DataGridView2.CellContentClick += val2;
				_DataGridView2.CellPainting += val3;
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

	internal virtual TextBox Text_TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TYPE = value;
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

	internal virtual TextBox Text_CODE_TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_TYPE = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView3_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGridView3_CellClick;
			DataGridViewCellPaintingEventHandler val3 = DataGridView3_CellPainting;
			if (_DataGridView3 != null)
			{
				_DataGridView3.CellContentClick -= val;
				_DataGridView3.CellClick -= val2;
				_DataGridView3.CellPainting -= val3;
			}
			_DataGridView3 = value;
			if (_DataGridView3 != null)
			{
				_DataGridView3.CellContentClick += val;
				_DataGridView3.CellClick += val2;
				_DataGridView3.CellPainting += val3;
			}
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

	internal virtual DataGridViewTextBoxColumn CODE_TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_TYPE = value;
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

	internal virtual DataGridViewButtonColumn suppp
	{
		[DebuggerNonUserCode]
		get
		{
			return _suppp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_suppp = value;
		}
	}

	public FormDialog_ATTRIBUTIONS()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		((Form)this).Load += Form_ATTRIBUTIONS_Load;
		__ENCAddToList(this);
		_DT_TEMP_1 = new DataTable();
		_DA_TEMP_1 = new MySqlDataAdapter();
		_DT_TEMP_2 = new DataTable();
		_DA_TEMP_2 = new MySqlDataAdapter();
		_DT_TEMP_3 = new DataTable();
		_DA_TEMP_3 = new MySqlDataAdapter();
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
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected Obj, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected Obj, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected Obj, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected Obj, but got Unknown
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected Obj, but got Unknown
		//IL_1061: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Expected Obj, but got Unknown
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected Obj, but got Unknown
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1196: Expected Obj, but got Unknown
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Expected Obj, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected Obj, but got Unknown
		//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e6: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ATTRIBUTIONS));
		DataGridView1 = new DataGridView();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Button_ADD = new Button();
		Text_COULEUR = new TextBox();
		Label1 = new Label();
		Text_CODE_COULEUR = new TextBox();
		Label19 = new Label();
		TabPage2 = new TabPage();
		Button1 = new Button();
		Text_TAILLE = new TextBox();
		Label2 = new Label();
		Text_CODE_TAILLE = new TextBox();
		Label3 = new Label();
		DataGridView2 = new DataGridView();
		CODE_TAILLE = new DataGridViewTextBoxColumn();
		TAILLE = new DataGridViewTextBoxColumn();
		DataGridViewButtonColumn1 = new DataGridViewButtonColumn();
		TabPage3 = new TabPage();
		Button2 = new Button();
		Text_TYPE = new TextBox();
		Label4 = new Label();
		Text_CODE_TYPE = new TextBox();
		Label5 = new Label();
		DataGridView3 = new DataGridView();
		CODE_TYPE = new DataGridViewTextBoxColumn();
		TYPE = new DataGridViewTextBoxColumn();
		DataGridViewButtonColumn2 = new DataGridViewButtonColumn();
		CODE_COULEUR = new DataGridViewTextBoxColumn();
		COULEUR = new DataGridViewTextBoxColumn();
		suppp = new DataGridViewButtonColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)TabPage3).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)CODE_COULEUR,
			(DataGridViewColumn)COULEUR,
			(DataGridViewColumn)suppp
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(5, 6);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(312, 347);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 695;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage3);
		((Control)TabControl1).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl = TabControl1;
		size = new Size(60, 28);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl1;
		location = new Point(4, 1);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(330, 476);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 995;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Button_ADD);
		((Control)TabPage1).Controls.Add((Control)(object)Text_COULEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label1);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CODE_COULEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)DataGridView1);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		Padding padding = new Padding(3);
		((Control)tabPage2).Padding = padding;
		TabPage tabPage3 = TabPage1;
		size = new Size(322, 440);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "COULEUR";
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((ButtonBase)Button_ADD).FlatStyle = (FlatStyle)0;
		((Control)Button_ADD).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_ADD).ForeColor = Color.White;
		((ButtonBase)Button_ADD).Image = (Image)componentResourceManager.GetObject("Button_ADD.Image");
		((ButtonBase)Button_ADD).ImageAlign = (ContentAlignment)16;
		Button button_ADD = Button_ADD;
		location = new Point(274, 359);
		((Control)button_ADD).Location = location;
		((Control)Button_ADD).Name = "Button_ADD";
		Button button_ADD2 = Button_ADD;
		size = new Size(43, 58);
		((Control)button_ADD2).Size = size;
		((Control)Button_ADD).TabIndex = 700;
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_COULEUR).BorderStyle = (BorderStyle)1;
		((Control)Text_COULEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_COULEUR = Text_COULEUR;
		location = new Point(124, 391);
		((Control)text_COULEUR).Location = location;
		((Control)Text_COULEUR).Name = "Text_COULEUR";
		TextBox text_COULEUR2 = Text_COULEUR;
		size = new Size(144, 26);
		((Control)text_COULEUR2).Size = size;
		((Control)Text_COULEUR).TabIndex = 699;
		((Control)Label1).BackColor = Color.WhiteSmoke;
		((Control)Label1).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label1;
		location = new Point(5, 391);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(113, 26);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 698;
		Label1.Text = "COULEUR";
		Label1.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CODE_COULEUR).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_COULEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_COULEUR = Text_CODE_COULEUR;
		location = new Point(124, 359);
		((Control)text_CODE_COULEUR).Location = location;
		((Control)Text_CODE_COULEUR).Name = "Text_CODE_COULEUR";
		TextBox text_CODE_COULEUR2 = Text_CODE_COULEUR;
		size = new Size(144, 26);
		((Control)text_CODE_COULEUR2).Size = size;
		((Control)Text_CODE_COULEUR).TabIndex = 697;
		((Control)Label19).BackColor = Color.WhiteSmoke;
		((Control)Label19).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label19;
		location = new Point(5, 359);
		((Control)label3).Location = location;
		((Control)Label19).Name = "Label19";
		Label label4 = Label19;
		size = new Size(113, 26);
		((Control)label4).Size = size;
		((Control)Label19).TabIndex = 696;
		Label19.Text = "CODE_COULEUR";
		Label19.TextAlign = (ContentAlignment)16;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Button1);
		((Control)TabPage2).Controls.Add((Control)(object)Text_TAILLE);
		((Control)TabPage2).Controls.Add((Control)(object)Label2);
		((Control)TabPage2).Controls.Add((Control)(object)Text_CODE_TAILLE);
		((Control)TabPage2).Controls.Add((Control)(object)Label3);
		((Control)TabPage2).Controls.Add((Control)(object)DataGridView2);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 32);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		padding = new Padding(3);
		((Control)tabPage5).Padding = padding;
		TabPage tabPage6 = TabPage2;
		size = new Size(322, 440);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "TAILLE";
		((ButtonBase)Button1).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.White;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button = Button1;
		location = new Point(274, 359);
		((Control)button).Location = location;
		((Control)Button1).Name = "Button1";
		Button button2 = Button1;
		size = new Size(43, 58);
		((Control)button2).Size = size;
		((Control)Button1).TabIndex = 706;
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_TAILLE).BorderStyle = (BorderStyle)1;
		((Control)Text_TAILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TAILLE = Text_TAILLE;
		location = new Point(124, 391);
		((Control)text_TAILLE).Location = location;
		((Control)Text_TAILLE).Name = "Text_TAILLE";
		TextBox text_TAILLE2 = Text_TAILLE;
		size = new Size(144, 26);
		((Control)text_TAILLE2).Size = size;
		((Control)Text_TAILLE).TabIndex = 705;
		((Control)Label2).BackColor = Color.WhiteSmoke;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label5 = Label2;
		location = new Point(5, 391);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(113, 26);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 704;
		Label2.Text = "TAILLE";
		Label2.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CODE_TAILLE).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_TAILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_TAILLE = Text_CODE_TAILLE;
		location = new Point(124, 359);
		((Control)text_CODE_TAILLE).Location = location;
		((Control)Text_CODE_TAILLE).Name = "Text_CODE_TAILLE";
		TextBox text_CODE_TAILLE2 = Text_CODE_TAILLE;
		size = new Size(144, 26);
		((Control)text_CODE_TAILLE2).Size = size;
		((Control)Text_CODE_TAILLE).TabIndex = 703;
		((Control)Label3).BackColor = Color.WhiteSmoke;
		((Control)Label3).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.FromArgb(64, 64, 64);
		Label label7 = Label3;
		location = new Point(5, 359);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(113, 26);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 702;
		Label3.Text = "CODE_TAILLE";
		Label3.TextAlign = (ContentAlignment)16;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)CODE_TAILLE,
			(DataGridViewColumn)TAILLE,
			(DataGridViewColumn)DataGridViewButtonColumn1
		});
		DataGridView2.EditMode = (DataGridViewEditMode)4;
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(5, 6);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersWidth = 20;
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(312, 347);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 701;
		((DataGridViewColumn)CODE_TAILLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_TAILLE).DataPropertyName = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).FillWeight = 99.61929f;
		((DataGridViewColumn)CODE_TAILLE).HeaderText = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).Name = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).Width = 110;
		((DataGridViewColumn)TAILLE).DataPropertyName = "TAILLE";
		((DataGridViewColumn)TAILLE).FillWeight = 99.61929f;
		((DataGridViewColumn)TAILLE).HeaderText = "TAILLE";
		((DataGridViewColumn)TAILLE).Name = "TAILLE";
		TAILLE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewButtonColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).HeaderText = "";
		((DataGridViewColumn)DataGridViewButtonColumn1).Name = "DataGridViewButtonColumn1";
		((DataGridViewColumn)DataGridViewButtonColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).Width = 50;
		((Control)TabPage3).Controls.Add((Control)(object)Button2);
		((Control)TabPage3).Controls.Add((Control)(object)Text_TYPE);
		((Control)TabPage3).Controls.Add((Control)(object)Label4);
		((Control)TabPage3).Controls.Add((Control)(object)Text_CODE_TYPE);
		((Control)TabPage3).Controls.Add((Control)(object)Label5);
		((Control)TabPage3).Controls.Add((Control)(object)DataGridView3);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 32);
		tabPage7.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage8 = TabPage3;
		padding = new Padding(3);
		((Control)tabPage8).Padding = padding;
		TabPage tabPage9 = TabPage3;
		size = new Size(322, 440);
		((Control)tabPage9).Size = size;
		TabPage3.TabIndex = 2;
		TabPage3.Text = "TYPE";
		TabPage3.UseVisualStyleBackColor = true;
		((ButtonBase)Button2).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button2).ForeColor = Color.White;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button3 = Button2;
		location = new Point(274, 359);
		((Control)button3).Location = location;
		((Control)Button2).Name = "Button2";
		Button button4 = Button2;
		size = new Size(43, 58);
		((Control)button4).Size = size;
		((Control)Button2).TabIndex = 706;
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_TYPE).BorderStyle = (BorderStyle)1;
		((Control)Text_TYPE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TYPE = Text_TYPE;
		location = new Point(124, 391);
		((Control)text_TYPE).Location = location;
		((Control)Text_TYPE).Name = "Text_TYPE";
		TextBox text_TYPE2 = Text_TYPE;
		size = new Size(144, 26);
		((Control)text_TYPE2).Size = size;
		((Control)Text_TYPE).TabIndex = 705;
		((Control)Label4).BackColor = Color.WhiteSmoke;
		((Control)Label4).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.FromArgb(64, 64, 64);
		Label label9 = Label4;
		location = new Point(5, 391);
		((Control)label9).Location = location;
		((Control)Label4).Name = "Label4";
		Label label10 = Label4;
		size = new Size(113, 26);
		((Control)label10).Size = size;
		((Control)Label4).TabIndex = 704;
		Label4.Text = "TYPE";
		Label4.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CODE_TYPE).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_TYPE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_TYPE = Text_CODE_TYPE;
		location = new Point(124, 359);
		((Control)text_CODE_TYPE).Location = location;
		((Control)Text_CODE_TYPE).Name = "Text_CODE_TYPE";
		TextBox text_CODE_TYPE2 = Text_CODE_TYPE;
		size = new Size(144, 26);
		((Control)text_CODE_TYPE2).Size = size;
		((Control)Text_CODE_TYPE).TabIndex = 703;
		((Control)Label5).BackColor = Color.WhiteSmoke;
		((Control)Label5).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.FromArgb(64, 64, 64);
		Label label11 = Label5;
		location = new Point(5, 359);
		((Control)label11).Location = location;
		((Control)Label5).Name = "Label5";
		Label label12 = Label5;
		size = new Size(113, 26);
		((Control)label12).Size = size;
		((Control)Label5).TabIndex = 702;
		Label5.Text = "CODE_TYPE";
		Label5.TextAlign = (ContentAlignment)16;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView3.BackgroundColor = Color.White;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)CODE_TYPE,
			(DataGridViewColumn)TYPE,
			(DataGridViewColumn)DataGridViewButtonColumn2
		});
		DataGridView3.EditMode = (DataGridViewEditMode)4;
		DataGridView3.EnableHeadersVisualStyles = false;
		DataGridView dataGridView5 = DataGridView3;
		location = new Point(5, 6);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.RowHeadersWidth = 20;
		DataGridView dataGridView6 = DataGridView3;
		size = new Size(312, 347);
		((Control)dataGridView6).Size = size;
		((Control)DataGridView3).TabIndex = 701;
		((DataGridViewColumn)CODE_TYPE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_TYPE).DataPropertyName = "CODE_TYPE";
		((DataGridViewColumn)CODE_TYPE).FillWeight = 99.61929f;
		((DataGridViewColumn)CODE_TYPE).HeaderText = "CODE_TYPE";
		((DataGridViewColumn)CODE_TYPE).Name = "CODE_TYPE";
		((DataGridViewColumn)CODE_TYPE).Width = 110;
		((DataGridViewColumn)TYPE).DataPropertyName = "TYPE";
		((DataGridViewColumn)TYPE).FillWeight = 99.61929f;
		((DataGridViewColumn)TYPE).HeaderText = "TYPE";
		((DataGridViewColumn)TYPE).Name = "TYPE";
		TYPE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewButtonColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn2).HeaderText = "";
		((DataGridViewColumn)DataGridViewButtonColumn2).Name = "DataGridViewButtonColumn2";
		((DataGridViewColumn)DataGridViewButtonColumn2).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewButtonColumn2).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn2).Width = 50;
		((DataGridViewColumn)CODE_COULEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_COULEUR).DataPropertyName = "CODE_COULEUR";
		((DataGridViewColumn)CODE_COULEUR).FillWeight = 99.61929f;
		((DataGridViewColumn)CODE_COULEUR).HeaderText = "CODE_COULEUR";
		((DataGridViewColumn)CODE_COULEUR).Name = "CODE_COULEUR";
		((DataGridViewColumn)CODE_COULEUR).Width = 110;
		((DataGridViewColumn)COULEUR).DataPropertyName = "COULEUR";
		((DataGridViewColumn)COULEUR).FillWeight = 99.61929f;
		((DataGridViewColumn)COULEUR).HeaderText = "COULEUR";
		((DataGridViewColumn)COULEUR).Name = "COULEUR";
		((DataGridViewColumn)COULEUR).Resizable = (DataGridViewTriState)1;
		COULEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)suppp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)suppp).HeaderText = "";
		((DataGridViewColumn)suppp).Name = "suppp";
		((DataGridViewColumn)suppp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)suppp).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)suppp).Width = 50;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(336, 482);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)TabControl1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_ATTRIBUTIONS";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((ISupportInitialize)DataGridView3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form_ATTRIBUTIONS_Load(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
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
						_DA_TEMP_1 = new MySqlDataAdapter("select * from TABLE_LISTE_COULEURS  order by      CODE_COULEUR  asc", Module1.cn_SQL);
						_DT_TEMP_1 = new DataTable();
						_DT_TEMP_1.Clear();
						((DbDataAdapter)(object)_DA_TEMP_1).Fill(_DT_TEMP_1);
						_DA_TEMP_2 = new MySqlDataAdapter("select * from TABLE_LISTE_TAILLES  order by      CODE_TAILLE  asc", Module1.cn_SQL);
						_DT_TEMP_2 = new DataTable();
						_DT_TEMP_2.Clear();
						((DbDataAdapter)(object)_DA_TEMP_2).Fill(_DT_TEMP_2);
						_DA_TEMP_3 = new MySqlDataAdapter("select * from TABLE_LISTE_TYPES  order by      CODE_TYPE  asc", Module1.cn_SQL);
						_DT_TEMP_3 = new DataTable();
						_DT_TEMP_3.Clear();
						((DbDataAdapter)(object)_DA_TEMP_3).Fill(_DT_TEMP_3);
						DataGridView1.AutoGenerateColumns = false;
						DataGridView1.RowTemplate.Height = 35;
						DataGridView1.BackgroundColor = Color.White;
						DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
						DataGridView1.MultiSelect = false;
						DataGridView1.EditMode = (DataGridViewEditMode)4;
						DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
						DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
						DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
						DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
						DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
						DataGridView1.ColumnHeadersHeight = 30;
						DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
						DataGridView1.DefaultCellStyle.Font = new Font("Arial", 11f, (FontStyle)0);
						DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);
						DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(171, 185, 211);
						DataGridView1.RowHeadersWidth = 22;
						DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
						int num3 = ((BaseCollection)DataGridView1.Columns).Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							DataGridView1.Columns[num4].SortMode = (DataGridViewColumnSortMode)2;
							num4++;
						}
						DataGridView1.EnableHeadersVisualStyles = false;
						DataGridView2.AutoGenerateColumns = false;
						DataGridView2.RowTemplate.Height = 35;
						DataGridView2.BackgroundColor = Color.White;
						DataGridView2.SelectionMode = (DataGridViewSelectionMode)1;
						DataGridView2.MultiSelect = false;
						DataGridView2.EditMode = (DataGridViewEditMode)4;
						DataGridView2.GridColor = Color.FromArgb(231, 231, 231);
						DataGridView2.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
						DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
						DataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
						DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
						DataGridView2.ColumnHeadersHeight = 30;
						DataGridView2.CellBorderStyle = (DataGridViewCellBorderStyle)5;
						DataGridView2.DefaultCellStyle.Font = new Font("Arial", 11f, (FontStyle)0);
						DataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);
						DataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(171, 185, 211);
						DataGridView2.RowHeadersWidth = 22;
						DataGridView2.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
						int num7 = ((BaseCollection)DataGridView2.Columns).Count - 1;
						int num8 = 0;
						while (true)
						{
							int num9 = num8;
							int num6 = num7;
							if (num9 > num6)
							{
								break;
							}
							DataGridView2.Columns[num8].SortMode = (DataGridViewColumnSortMode)2;
							num8++;
						}
						DataGridView2.EnableHeadersVisualStyles = false;
						DataGridView3.AutoGenerateColumns = false;
						DataGridView3.RowTemplate.Height = 35;
						DataGridView3.BackgroundColor = Color.White;
						DataGridView3.SelectionMode = (DataGridViewSelectionMode)1;
						DataGridView3.MultiSelect = false;
						DataGridView3.EditMode = (DataGridViewEditMode)4;
						DataGridView3.GridColor = Color.FromArgb(231, 231, 231);
						DataGridView3.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
						DataGridView3.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
						DataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
						DataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
						DataGridView3.ColumnHeadersHeight = 30;
						DataGridView3.CellBorderStyle = (DataGridViewCellBorderStyle)5;
						DataGridView3.DefaultCellStyle.Font = new Font("Arial", 11f, (FontStyle)0);
						DataGridView3.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);
						DataGridView3.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(171, 185, 211);
						DataGridView3.RowHeadersWidth = 22;
						DataGridView3.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
						int num10 = ((BaseCollection)DataGridView3.Columns).Count - 1;
						int num11 = 0;
						while (true)
						{
							int num12 = num11;
							int num6 = num10;
							if (num12 > num6)
							{
								break;
							}
							DataGridView3.Columns[num11].SortMode = (DataGridViewColumnSortMode)2;
							num11++;
						}
						DataGridView3.EnableHeadersVisualStyles = false;
						DataGridView1.DataSource = _DT_TEMP_1;
						DataGridView2.DataSource = _DT_TEMP_2;
						DataGridView3.DataSource = _DT_TEMP_3;
						TabControl1.SizeMode = (TabSizeMode)2;
						TabControl tabControl = TabControl1;
						Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
						tabControl.ItemSize = itemSize;
						goto end_IL_0001;
					}
					case 1822:
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
					try0001_dispatch = 1822;
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

	private void Button_ADD_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num7 = default;
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
						if (Operators.CompareString(Text_CODE_COULEUR.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -CODE_COULEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						if (Operators.CompareString(Text_COULEUR.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -COULEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select *     from TABLE_COULEUR WHERE   CODE_COULEUR = '" + Text_CODE_COULEUR.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show("Ce Code est déja utilisé ", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							goto end_IL_0001;
						}
						int num3 = _DT_TEMP_1.Rows.Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectGreater(_DT_TEMP_1.Rows[num4]["ID"], num7, TextCompare: false))
							{
								num7 = Conversions.ToInteger(_DT_TEMP_1.Rows[num4]["ID"]);
							}
							num4++;
						}
						_DT_TEMP_1.Rows.Add();
						int index = _DT_TEMP_1.Rows.Count - 1;
						_DT_TEMP_1.Rows[index]["ID"] = num7 + 1;
						_DT_TEMP_1.Rows[index]["CODE_COULEUR"] = Text_CODE_COULEUR.Text;
						_DT_TEMP_1.Rows[index]["COULEUR"] = Text_COULEUR.Text;
						MySqlCommandBuilder val2 = new MySqlCommandBuilder(_DA_TEMP_1);
						((DbDataAdapter)(object)_DA_TEMP_1).Update(_DT_TEMP_1);
						_DT_TEMP_1.AcceptChanges();
						MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
						Text_CODE_COULEUR.Text = "";
						Text_COULEUR.Text = "";
						goto end_IL_0001;
					}
					case 636:
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
					try0001_dispatch = 636;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num7 = default;
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
						if (Operators.CompareString(Text_CODE_TAILLE.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -CODE_TAILLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						if (Operators.CompareString(Text_TAILLE.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -TAILLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select *     from TABLE_TAILLE WHERE   CODE_TAILLE = '" + Text_CODE_TAILLE.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show("Ce Code est déja utilisé ", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							goto end_IL_0001;
						}
						int num3 = _DT_TEMP_2.Rows.Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectGreater(_DT_TEMP_2.Rows[num4]["ID"], num7, TextCompare: false))
							{
								num7 = Conversions.ToInteger(_DT_TEMP_2.Rows[num4]["ID"]);
							}
							num4++;
						}
						_DT_TEMP_2.Rows.Add();
						int index = _DT_TEMP_2.Rows.Count - 1;
						_DT_TEMP_2.Rows[index]["ID"] = num7 + 1;
						_DT_TEMP_2.Rows[index]["CODE_TAILLE"] = Text_CODE_TAILLE.Text;
						_DT_TEMP_2.Rows[index]["TAILLE"] = Text_TAILLE.Text;
						MySqlCommandBuilder val2 = new MySqlCommandBuilder(_DA_TEMP_2);
						((DbDataAdapter)(object)_DA_TEMP_2).Update(_DT_TEMP_2);
						_DT_TEMP_2.AcceptChanges();
						MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
						Text_CODE_TAILLE.Text = "";
						Text_TAILLE.Text = "";
						goto end_IL_0001;
					}
					case 636:
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
					try0001_dispatch = 636;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num7 = default;
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
						if (Operators.CompareString(Text_CODE_TYPE.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -CODE_TYPE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						if (Operators.CompareString(Text_TYPE.Text, "", TextCompare: false) == 0)
						{
							MessageBox.Show("Veuillez remplir le champ -TYPE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select *     from TABLE_TYPE WHERE   CODE_TYPE = '" + Text_CODE_TYPE.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show("Ce Code est déja utilisé ", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							goto end_IL_0001;
						}
						int num3 = _DT_TEMP_3.Rows.Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectGreater(_DT_TEMP_3.Rows[num4]["ID"], num7, TextCompare: false))
							{
								num7 = Conversions.ToInteger(_DT_TEMP_3.Rows[num4]["ID"]);
							}
							num4++;
						}
						_DT_TEMP_3.Rows.Add();
						int index = _DT_TEMP_3.Rows.Count - 1;
						_DT_TEMP_3.Rows[index]["ID"] = num7 + 1;
						_DT_TEMP_3.Rows[index]["CODE_TYPE"] = Text_CODE_TYPE.Text;
						_DT_TEMP_3.Rows[index]["TYPE"] = Text_TYPE.Text;
						MySqlCommandBuilder val2 = new MySqlCommandBuilder(_DA_TEMP_3);
						((DbDataAdapter)(object)_DA_TEMP_3).Update(_DT_TEMP_3);
						_DT_TEMP_3.AcceptChanges();
						MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
						Text_CODE_TYPE.Text = "";
						Text_TYPE.Text = "";
						goto end_IL_0001;
					}
					case 636:
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
					try0001_dispatch = 636;
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

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
						{
							e.Paint(e.CellBounds, (DataGridViewPaintParts)127);
							Image image = MyProject.Forms.Form_0_TEMPLATE.Picture_SUPP.Image;
							int width = image.Width;
							int height = image.Height;
							double a = (double)e.CellBounds.Left + (double)(e.CellBounds.Width - width) / 2.0;
							double a2 = (double)e.CellBounds.Top + (double)(e.CellBounds.Height - width) / 2.0;
							Graphics graphics = e.Graphics;
							Rectangle rectangle = new Rectangle((int)Math.Round(a), (int)Math.Round(a2), width, height);
							graphics.DrawImage(image, rectangle);
							((HandledEventArgs)(object)e).Handled = true;
						}
						goto end_IL_0001;
					case 299:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0165;
					end_IL_0001:;
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 299;
					continue;
				}
				break;
				IL_0165:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
					{
						int position = ((ContainerControl)this).BindingContext[(object)_DT_TEMP_1].Position;
						_DT_TEMP_1.Rows[position].Delete();
						MySqlCommandBuilder val = new MySqlCommandBuilder(_DA_TEMP_1);
						((DbDataAdapter)(object)_DA_TEMP_1).Update(_DT_TEMP_1);
						_DT_TEMP_1.AcceptChanges();
						((ContainerControl)this).BindingContext[(object)_DT_TEMP_1].Position = position;
					}
					goto end_IL_0001;
				case 248:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_012e;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 248;
				continue;
			}
			break;
			IL_012e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
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
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(6, 2);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Insert(6, DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE_COULEUR"].Value.ToString());
						MyProject.Forms.Form_2_ARTICLES.Combo_COULEURS.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["COULEUR"].Value.ToString();
						int num3 = 0;
						int num4 = 0;
						byte[] array = new byte[13];
						int num5 = 0;
						int num6;
						int num7;
						do
						{
							array[num5] = (byte)Conversions.ToInteger(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Substring(num5, 1));
							if (unchecked(num5 % 2) == 1)
							{
								num4 += array[num5];
							}
							else
							{
								num3 += array[num5];
							}
							num5++;
							num6 = num5;
							num7 = 11;
						}
						while (num6 <= num7);
						unchecked
						{
							num5 = checked(num3 + num4 * 3) % 10;
						}
						if (num5 == 0)
						{
							array[12] = 0;
						}
						else
						{
							array[12] = (byte)(10 - num5);
						}
						byte[] bits = Module1.getBits(array);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Length - 1);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text + Conversions.ToString(array[12]);
						goto end_IL_0001;
					}
					case 540:
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
					try0001_dispatch = 540;
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

	private void DataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
						{
							e.Paint(e.CellBounds, (DataGridViewPaintParts)127);
							Image image = MyProject.Forms.Form_0_TEMPLATE.Picture_SUPP.Image;
							int width = image.Width;
							int height = image.Height;
							double a = (double)e.CellBounds.Left + (double)(e.CellBounds.Width - width) / 2.0;
							double a2 = (double)e.CellBounds.Top + (double)(e.CellBounds.Height - width) / 2.0;
							Graphics graphics = e.Graphics;
							Rectangle rectangle = new Rectangle((int)Math.Round(a), (int)Math.Round(a2), width, height);
							graphics.DrawImage(image, rectangle);
							((HandledEventArgs)(object)e).Handled = true;
						}
						goto end_IL_0001;
					case 299:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0165;
					end_IL_0001:;
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 299;
					continue;
				}
				break;
				IL_0165:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
					{
						int position = ((ContainerControl)this).BindingContext[(object)_DT_TEMP_2].Position;
						_DT_TEMP_2.Rows[position].Delete();
						MySqlCommandBuilder val = new MySqlCommandBuilder(_DA_TEMP_2);
						((DbDataAdapter)(object)_DA_TEMP_2).Update(_DT_TEMP_2);
						_DT_TEMP_2.AcceptChanges();
						((ContainerControl)this).BindingContext[(object)_DT_TEMP_2].Position = position;
					}
					goto end_IL_0001;
				case 248:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_012e;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 248;
				continue;
			}
			break;
			IL_012e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
	{
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
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(8, 2);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Insert(8, DataGridView2.Rows[((DataGridViewBand)DataGridView2.CurrentRow).Index].Cells["CODE_TAILLE"].Value.ToString());
						MyProject.Forms.Form_2_ARTICLES.Combo_TAILLES.Text = DataGridView2.Rows[((DataGridViewBand)DataGridView2.CurrentRow).Index].Cells["TAILLE"].Value.ToString();
						int num3 = 0;
						int num4 = 0;
						byte[] array = new byte[13];
						int num5 = 0;
						int num6;
						int num7;
						do
						{
							array[num5] = (byte)Conversions.ToInteger(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Substring(num5, 1));
							if (unchecked(num5 % 2) == 1)
							{
								num4 += array[num5];
							}
							else
							{
								num3 += array[num5];
							}
							num5++;
							num6 = num5;
							num7 = 11;
						}
						while (num6 <= num7);
						unchecked
						{
							num5 = checked(num3 + num4 * 3) % 10;
						}
						if (num5 == 0)
						{
							array[12] = 0;
						}
						else
						{
							array[12] = (byte)(10 - num5);
						}
						byte[] bits = Module1.getBits(array);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Length - 1);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text + Conversions.ToString(array[12]);
						goto end_IL_0001;
					}
					case 540:
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
					try0001_dispatch = 540;
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

	private void DataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
						{
							e.Paint(e.CellBounds, (DataGridViewPaintParts)127);
							Image image = MyProject.Forms.Form_0_TEMPLATE.Picture_SUPP.Image;
							int width = image.Width;
							int height = image.Height;
							double a = (double)e.CellBounds.Left + (double)(e.CellBounds.Width - width) / 2.0;
							double a2 = (double)e.CellBounds.Top + (double)(e.CellBounds.Height - width) / 2.0;
							Graphics graphics = e.Graphics;
							Rectangle rectangle = new Rectangle((int)Math.Round(a), (int)Math.Round(a2), width, height);
							graphics.DrawImage(image, rectangle);
							((HandledEventArgs)(object)e).Handled = true;
						}
						goto end_IL_0001;
					case 299:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0165;
					end_IL_0001:;
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 299;
					continue;
				}
				break;
				IL_0165:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
					{
						int position = ((ContainerControl)this).BindingContext[(object)_DT_TEMP_3].Position;
						_DT_TEMP_3.Rows[position].Delete();
						MySqlCommandBuilder val = new MySqlCommandBuilder(_DA_TEMP_3);
						((DbDataAdapter)(object)_DA_TEMP_3).Update(_DT_TEMP_3);
						_DT_TEMP_3.AcceptChanges();
						((ContainerControl)this).BindingContext[(object)_DT_TEMP_3].Position = position;
					}
					goto end_IL_0001;
				case 248:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_012e;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 248;
				continue;
			}
			break;
			IL_012e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
	{
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
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(10, 2);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Insert(10, DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["CODE_TYPE"].Value.ToString());
						MyProject.Forms.Form_2_ARTICLES.Text_DESCRIPTION.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["TYPE"].Value.ToString();
						int num3 = 0;
						int num4 = 0;
						byte[] array = new byte[13];
						int num5 = 0;
						int num6;
						int num7;
						do
						{
							array[num5] = (byte)Conversions.ToInteger(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Substring(num5, 1));
							if (unchecked(num5 % 2) == 1)
							{
								num4 += array[num5];
							}
							else
							{
								num3 += array[num5];
							}
							num5++;
							num6 = num5;
							num7 = 11;
						}
						while (num6 <= num7);
						unchecked
						{
							num5 = checked(num3 + num4 * 3) % 10;
						}
						if (num5 == 0)
						{
							array[12] = 0;
						}
						else
						{
							array[12] = (byte)(10 - num5);
						}
						byte[] bits = Module1.getBits(array);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Remove(MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text.Length - 1);
						MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text = MyProject.Forms.Form_2_ARTICLES.Text_CODE_RICHE.Text + Conversions.ToString(array[12]);
						goto end_IL_0001;
					}
					case 542:
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
					try0001_dispatch = 542;
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

	private void Button3_Click(object sender, EventArgs e)
	{
	}
}
