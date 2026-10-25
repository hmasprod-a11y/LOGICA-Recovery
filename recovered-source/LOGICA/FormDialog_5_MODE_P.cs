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
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_5_MODE_P : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage10")]
	private TabPage _TabPage10;

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

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Label64")]
	private Label _Label64;

	[AccessedThroughProperty("Button108")]
	private Button _Button108;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Label65")]
	private Label _Label65;

	[AccessedThroughProperty("Text_MODE_P")]
	private TextBox _Text_MODE_P;

	[AccessedThroughProperty("Text_LIEN_PICTURE")]
	private TextBox _Text_LIEN_PICTURE;

	[AccessedThroughProperty("Picture_IMAGE")]
	private PictureBox _Picture_IMAGE;

	[AccessedThroughProperty("Panel_COULEUR")]
	private Panel _Panel_COULEUR;

	[AccessedThroughProperty("Label73")]
	private Label _Label73;

	[AccessedThroughProperty("PictureBox1116")]
	private PictureBox _PictureBox1116;

	[AccessedThroughProperty("Label72")]
	private Label _Label72;

	[AccessedThroughProperty("PictureBox1205")]
	private PictureBox _PictureBox1205;

	[AccessedThroughProperty("Label71")]
	private Label _Label71;

	[AccessedThroughProperty("PictureBox1944")]
	private PictureBox _PictureBox1944;

	[AccessedThroughProperty("Label70")]
	private Label _Label70;

	[AccessedThroughProperty("Label69")]
	private Label _Label69;

	[AccessedThroughProperty("Label67")]
	private Label _Label67;

	[AccessedThroughProperty("Label66")]
	private Label _Label66;

	[AccessedThroughProperty("PictureBox1893")]
	private PictureBox _PictureBox1893;

	[AccessedThroughProperty("PictureBox1166")]
	private PictureBox _PictureBox1166;

	[AccessedThroughProperty("PictureBox1650")]
	private PictureBox _PictureBox1650;

	[AccessedThroughProperty("PictureBox4459")]
	private PictureBox _PictureBox4459;

	[AccessedThroughProperty("Picture_COLOR_8")]
	private PictureBox _Picture_COLOR_8;

	[AccessedThroughProperty("Picture_COLOR_4")]
	private PictureBox _Picture_COLOR_4;

	[AccessedThroughProperty("Picture_COLOR_7")]
	private PictureBox _Picture_COLOR_7;

	[AccessedThroughProperty("Picture_COLOR_2")]
	private PictureBox _Picture_COLOR_2;

	[AccessedThroughProperty("Picture_COLOR_16")]
	private PictureBox _Picture_COLOR_16;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox4480")]
	private PictureBox _PictureBox4480;

	[AccessedThroughProperty("imgg")]
	private DataGridViewImageColumn _imgg;

	[AccessedThroughProperty("MODE_P")]
	private DataGridViewTextBoxColumn _MODE_P;

	[AccessedThroughProperty("Images")]
	private DataGridViewTextBoxColumn _Images;

	[AccessedThroughProperty("sup")]
	private DataGridViewButtonColumn _sup;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	private DataTable dtt;

	private MySqlDataAdapter daa;

	private int x;

	private int y;

	private Point newpoint;

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
			DataGridViewCellEventHandler val = DataGridView1_CellContentClick;
			DataGridViewBindingCompleteEventHandler val2 = DataGridView1_DataBindingComplete;
			DataGridViewCellPaintingEventHandler val3 = DataGridView1_CellPainting;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick -= val;
				_DataGridView1.DataBindingComplete -= val2;
				_DataGridView1.CellPainting -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick += val;
				_DataGridView1.DataBindingComplete += val2;
				_DataGridView1.CellPainting += val3;
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

	internal virtual TabPage TabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage10 = value;
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

	internal virtual Button Button108
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button108;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button108 = value;
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

	internal virtual TextBox Text_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_MODE_P = value;
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
			_Text_LIEN_PICTURE = value;
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
			_Picture_IMAGE = value;
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

	internal virtual PictureBox PictureBox1116
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1116;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1116_Click;
			if (_PictureBox1116 != null)
			{
				((Control)_PictureBox1116).Click -= eventHandler;
			}
			_PictureBox1116 = value;
			if (_PictureBox1116 != null)
			{
				((Control)_PictureBox1116).Click += eventHandler;
			}
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

	internal virtual PictureBox PictureBox1205
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1205;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1205_Click;
			if (_PictureBox1205 != null)
			{
				((Control)_PictureBox1205).Click -= eventHandler;
			}
			_PictureBox1205 = value;
			if (_PictureBox1205 != null)
			{
				((Control)_PictureBox1205).Click += eventHandler;
			}
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

	internal virtual PictureBox PictureBox1944
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1944;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1944_Click;
			if (_PictureBox1944 != null)
			{
				((Control)_PictureBox1944).Click -= eventHandler;
			}
			_PictureBox1944 = value;
			if (_PictureBox1944 != null)
			{
				((Control)_PictureBox1944).Click += eventHandler;
			}
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

	internal virtual PictureBox PictureBox1893
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1893;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1893_Click;
			if (_PictureBox1893 != null)
			{
				((Control)_PictureBox1893).Click -= eventHandler;
			}
			_PictureBox1893 = value;
			if (_PictureBox1893 != null)
			{
				((Control)_PictureBox1893).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox1166
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1166;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1166_Click;
			if (_PictureBox1166 != null)
			{
				((Control)_PictureBox1166).Click -= eventHandler;
			}
			_PictureBox1166 = value;
			if (_PictureBox1166 != null)
			{
				((Control)_PictureBox1166).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox1650
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1650;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1650_Click;
			if (_PictureBox1650 != null)
			{
				((Control)_PictureBox1650).Click -= eventHandler;
			}
			_PictureBox1650 = value;
			if (_PictureBox1650 != null)
			{
				((Control)_PictureBox1650).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox4459
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4459;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox4459_Click;
			if (_PictureBox4459 != null)
			{
				((Control)_PictureBox4459).Click -= eventHandler;
			}
			_PictureBox4459 = value;
			if (_PictureBox4459 != null)
			{
				((Control)_PictureBox4459).Click += eventHandler;
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
			EventHandler eventHandler = Picture_COLOR_8_Click;
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
			EventHandler eventHandler = Picture_COLOR_4_Click;
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

	internal virtual PictureBox Picture_COLOR_7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_7_Click;
			if (_Picture_COLOR_7 != null)
			{
				((Control)_Picture_COLOR_7).Click -= eventHandler;
			}
			_Picture_COLOR_7 = value;
			if (_Picture_COLOR_7 != null)
			{
				((Control)_Picture_COLOR_7).Click += eventHandler;
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
			EventHandler eventHandler = Picture_COLOR_2_Click;
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
			EventHandler eventHandler = Picture_COLOR_16_Click;
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

	internal virtual PictureBox PictureBox4480
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4480;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox4480_Click;
			if (_PictureBox4480 != null)
			{
				((Control)_PictureBox4480).Click -= eventHandler;
			}
			_PictureBox4480 = value;
			if (_PictureBox4480 != null)
			{
				((Control)_PictureBox4480).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewImageColumn imgg
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgg = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MODE_P = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Images
	{
		[DebuggerNonUserCode]
		get
		{
			return _Images;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Images = value;
		}
	}

	internal virtual DataGridViewButtonColumn sup
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

	public FormDialog_5_MODE_P()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Form)this).Shown += Form_Shown;
		((Form)this).Load += FormDialog_UTILISATEURS_Load;
		__ENCAddToList(this);
		dtt = new DataTable();
		daa = new MySqlDataAdapter();
		newpoint = default;
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
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
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected Obj, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected Obj, but got Unknown
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected Obj, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected Obj, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected Obj, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected Obj, but got Unknown
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Expected Obj, but got Unknown
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected Obj, but got Unknown
		//IL_146e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected Obj, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Expected Obj, but got Unknown
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f1: Expected Obj, but got Unknown
		//IL_1692: Unknown result type (might be due to invalid IL or missing references)
		//IL_169c: Expected Obj, but got Unknown
		//IL_1760: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected Obj, but got Unknown
		//IL_180b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1815: Expected Obj, but got Unknown
		//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18de: Expected Obj, but got Unknown
		//IL_199a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a4: Expected Obj, but got Unknown
		//IL_1a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected Obj, but got Unknown
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Expected Obj, but got Unknown
		//IL_1bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be5: Expected Obj, but got Unknown
		//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c92: Expected Obj, but got Unknown
		//IL_1d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3f: Expected Obj, but got Unknown
		//IL_20e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Expected Obj, but got Unknown
		//IL_21c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cc: Expected Obj, but got Unknown
		//IL_229b: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a5: Expected Obj, but got Unknown
		//IL_2379: Unknown result type (might be due to invalid IL or missing references)
		//IL_2383: Expected Obj, but got Unknown
		//IL_2464: Unknown result type (might be due to invalid IL or missing references)
		//IL_246e: Expected Obj, but got Unknown
		//IL_254c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2556: Expected Obj, but got Unknown
		//IL_2579: Unknown result type (might be due to invalid IL or missing references)
		//IL_2583: Expected Obj, but got Unknown
		//IL_25bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2673: Unknown result type (might be due to invalid IL or missing references)
		//IL_267d: Expected Obj, but got Unknown
		//IL_26a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26aa: Expected Obj, but got Unknown
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2767: Unknown result type (might be due to invalid IL or missing references)
		//IL_2771: Expected Obj, but got Unknown
		//IL_2889: Unknown result type (might be due to invalid IL or missing references)
		//IL_2893: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_5_MODE_P));
		DataGridView1 = new DataGridView();
		imgg = new DataGridViewImageColumn();
		MODE_P = new DataGridViewTextBoxColumn();
		Images = new DataGridViewTextBoxColumn();
		sup = new DataGridViewButtonColumn();
		Button8 = new Button();
		Panel_INFO = new Panel();
		TabControl2 = new TabControl();
		TabPage10 = new TabPage();
		Label64 = new Label();
		Button108 = new Button();
		Text_ID = new TextBox();
		Label65 = new Label();
		Text_MODE_P = new TextBox();
		Text_LIEN_PICTURE = new TextBox();
		Picture_IMAGE = new PictureBox();
		Panel_COULEUR = new Panel();
		Label1 = new Label();
		PictureBox4480 = new PictureBox();
		Label73 = new Label();
		PictureBox1116 = new PictureBox();
		Label72 = new Label();
		PictureBox1205 = new PictureBox();
		Label71 = new Label();
		PictureBox1944 = new PictureBox();
		Label70 = new Label();
		Label69 = new Label();
		Label67 = new Label();
		Label66 = new Label();
		PictureBox1893 = new PictureBox();
		PictureBox1166 = new PictureBox();
		PictureBox1650 = new PictureBox();
		PictureBox4459 = new PictureBox();
		Picture_COLOR_8 = new PictureBox();
		Picture_COLOR_4 = new PictureBox();
		Picture_COLOR_7 = new PictureBox();
		Picture_COLOR_2 = new PictureBox();
		Picture_COLOR_16 = new PictureBox();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button11 = new Button();
		Button10 = new Button();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage10).SuspendLayout();
		((ISupportInitialize)Picture_IMAGE).BeginInit();
		((Control)Panel_COULEUR).SuspendLayout();
		((ISupportInitialize)PictureBox4480).BeginInit();
		((ISupportInitialize)PictureBox1116).BeginInit();
		((ISupportInitialize)PictureBox1205).BeginInit();
		((ISupportInitialize)PictureBox1944).BeginInit();
		((ISupportInitialize)PictureBox1893).BeginInit();
		((ISupportInitialize)PictureBox1166).BeginInit();
		((ISupportInitialize)PictureBox1650).BeginInit();
		((ISupportInitialize)PictureBox4459).BeginInit();
		((ISupportInitialize)Picture_COLOR_8).BeginInit();
		((ISupportInitialize)Picture_COLOR_4).BeginInit();
		((ISupportInitialize)Picture_COLOR_7).BeginInit();
		((ISupportInitialize)Picture_COLOR_2).BeginInit();
		((ISupportInitialize)Picture_COLOR_16).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)imgg,
			(DataGridViewColumn)MODE_P,
			(DataGridViewColumn)Images,
			(DataGridViewColumn)sup
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Tahoma", 8f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		((Control)DataGridView1).Dock = (DockStyle)1;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(0, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Tahoma", 8f);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		DataGridView1.RowHeadersDefaultCellStyle = val3;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(925, 503);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 989;
		((DataGridViewColumn)imgg).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)imgg).DataPropertyName = "imgg";
		((DataGridViewColumn)imgg).HeaderText = "img";
		imgg.ImageLayout = (DataGridViewImageCellLayout)2;
		((DataGridViewColumn)imgg).Name = "imgg";
		((DataGridViewColumn)imgg).Width = 60;
		((DataGridViewColumn)MODE_P).DataPropertyName = "MODE_P";
		((DataGridViewColumn)MODE_P).FillWeight = 73.17519f;
		((DataGridViewColumn)MODE_P).HeaderText = "MODE_P";
		((DataGridViewColumn)MODE_P).Name = "MODE_P";
		MODE_P.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Images).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Images).DataPropertyName = "Images";
		((DataGridViewColumn)Images).FillWeight = 73.17519f;
		((DataGridViewColumn)Images).HeaderText = "Images";
		((DataGridViewColumn)Images).MinimumWidth = 2;
		((DataGridViewColumn)Images).Name = "Images";
		Images.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Images).Width = 5;
		((DataGridViewColumn)sup).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)sup).FillWeight = 152.2843f;
		sup.FlatStyle = (FlatStyle)0;
		((DataGridViewColumn)sup).HeaderText = "";
		((DataGridViewColumn)sup).Name = "sup";
		((DataGridViewColumn)sup).Width = 40;
		((ButtonBase)Button8).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button8).Cursor = Cursors.Hand;
		((ButtonBase)Button8).FlatStyle = (FlatStyle)0;
		((Control)Button8).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Button8).ForeColor = Color.White;
		((ButtonBase)Button8).Image = (Image)componentResourceManager.GetObject("Button8.Image");
		((ButtonBase)Button8).ImageAlign = (ContentAlignment)16;
		Button button = Button8;
		location = new Point(12, 556);
		((Control)button).Location = location;
		((Control)Button8).Name = "Button8";
		Button button2 = Button8;
		size = new Size(221, 45);
		((Control)button2).Size = size;
		((Control)Button8).TabIndex = 991;
		((ButtonBase)Button8).Text = "   Nouveau";
		((ButtonBase)Button8).UseCompatibleTextRendering = true;
		((ButtonBase)Button8).UseVisualStyleBackColor = false;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl2);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button11);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button10);
		Panel panel_INFO = Panel_INFO;
		location = new Point(166, 0);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		size = new Size(631, 504);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 992;
		((Control)Panel_INFO).Visible = false;
		((Control)TabControl2).Controls.Add((Control)(object)TabPage10);
		((Control)TabControl2).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl = TabControl2;
		size = new Size(60, 28);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl2;
		location = new Point(6, 27);
		((Control)tabControl2).Location = location;
		((Control)TabControl2).Name = "TabControl2";
		TabControl2.SelectedIndex = 0;
		TabControl tabControl3 = TabControl2;
		size = new Size(616, 419);
		((Control)tabControl3).Size = size;
		((Control)TabControl2).TabIndex = 703;
		TabPage10.BackColor = Color.FromArgb(249, 249, 249);
		((Control)TabPage10).Controls.Add((Control)(object)Label64);
		((Control)TabPage10).Controls.Add((Control)(object)Button108);
		((Control)TabPage10).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage10).Controls.Add((Control)(object)Label65);
		((Control)TabPage10).Controls.Add((Control)(object)Text_MODE_P);
		((Control)TabPage10).Controls.Add((Control)(object)Text_LIEN_PICTURE);
		((Control)TabPage10).Controls.Add((Control)(object)Picture_IMAGE);
		((Control)TabPage10).Controls.Add((Control)(object)Panel_COULEUR);
		TabPage tabPage = TabPage10;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage10).Name = "TabPage10";
		TabPage tabPage2 = TabPage10;
		Padding padding = new Padding(3);
		((Control)tabPage2).Padding = padding;
		TabPage tabPage3 = TabPage10;
		size = new Size(608, 383);
		((Control)tabPage3).Size = size;
		TabPage10.TabIndex = 0;
		TabPage10.Text = "●";
		((Control)Label64).BackColor = Color.WhiteSmoke;
		((Control)Label64).Font = new Font("Arial", 9.75f, (FontStyle)1);
		((Control)Label64).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label64;
		location = new Point(30, 64);
		((Control)label).Location = location;
		((Control)Label64).Name = "Label64";
		Label label2 = Label64;
		size = new Size(127, 26);
		((Control)label2).Size = size;
		((Control)Label64).TabIndex = 773;
		Label64.Text = "Image";
		Label64.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button108).Image = (Image)componentResourceManager.GetObject("Button108.Image");
		Button button3 = Button108;
		location = new Point(209, 105);
		((Control)button3).Location = location;
		((Control)Button108).Name = "Button108";
		Button button4 = Button108;
		size = new Size(30, 26);
		((Control)button4).Size = size;
		((Control)Button108).TabIndex = 768;
		((ButtonBase)Button108).UseVisualStyleBackColor = true;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Arial", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(163, 22);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(33, 26);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 770;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((Control)Label65).BackColor = Color.WhiteSmoke;
		((Control)Label65).Font = new Font("Arial", 9.75f, (FontStyle)1);
		((Control)Label65).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label65;
		location = new Point(30, 22);
		((Control)label3).Location = location;
		((Control)Label65).Name = "Label65";
		Label label4 = Label65;
		size = new Size(127, 26);
		((Control)label4).Size = size;
		((Control)Label65).TabIndex = 772;
		Label65.Text = "Mode Paiement";
		Label65.TextAlign = (ContentAlignment)16;
		((Control)Text_MODE_P).Font = new Font("Arial", 12f, (FontStyle)1);
		TextBox text_MODE_P = Text_MODE_P;
		location = new Point(163, 22);
		((Control)text_MODE_P).Location = location;
		((Control)Text_MODE_P).Name = "Text_MODE_P";
		TextBox text_MODE_P2 = Text_MODE_P;
		size = new Size(420, 26);
		((Control)text_MODE_P2).Size = size;
		((Control)Text_MODE_P).TabIndex = 769;
		((TextBoxBase)Text_LIEN_PICTURE).BackColor = Color.FromArgb(249, 249, 249);
		((TextBoxBase)Text_LIEN_PICTURE).BorderStyle = (BorderStyle)0;
		((Control)Text_LIEN_PICTURE).Font = new Font("Tahoma", 6f);
		TextBox text_LIEN_PICTURE = Text_LIEN_PICTURE;
		location = new Point(163, 109);
		((Control)text_LIEN_PICTURE).Location = location;
		((Control)Text_LIEN_PICTURE).Name = "Text_LIEN_PICTURE";
		TextBox text_LIEN_PICTURE2 = Text_LIEN_PICTURE;
		size = new Size(48, 10);
		((Control)text_LIEN_PICTURE2).Size = size;
		((Control)Text_LIEN_PICTURE).TabIndex = 774;
		Text_LIEN_PICTURE.Text = "0.Png";
		((Control)Picture_IMAGE).BackColor = Color.Transparent;
		PictureBox picture_IMAGE = Picture_IMAGE;
		location = new Point(163, 54);
		((Control)picture_IMAGE).Location = location;
		((Control)Picture_IMAGE).Name = "Picture_IMAGE";
		PictureBox picture_IMAGE2 = Picture_IMAGE;
		size = new Size(76, 49);
		((Control)picture_IMAGE2).Size = size;
		Picture_IMAGE.SizeMode = (PictureBoxSizeMode)1;
		Picture_IMAGE.TabIndex = 771;
		Picture_IMAGE.TabStop = false;
		((ScrollableControl)Panel_COULEUR).AutoScroll = true;
		Panel_COULEUR.BorderStyle = (BorderStyle)1;
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label1);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox4480);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label73);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1116);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label72);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1205);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label71);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1944);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label70);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label69);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label67);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Label66);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1893);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1166);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox1650);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)PictureBox4459);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_8);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_4);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_7);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_2);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_16);
		Panel panel_COULEUR = Panel_COULEUR;
		location = new Point(391, 54);
		((Control)panel_COULEUR).Location = location;
		((Control)Panel_COULEUR).Name = "Panel_COULEUR";
		Panel panel_COULEUR2 = Panel_COULEUR;
		size = new Size(192, 323);
		((Control)panel_COULEUR2).Size = size;
		((Control)Panel_COULEUR).TabIndex = 775;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Tahoma", 9.75f);
		((Control)Label1).ForeColor = Color.FromArgb(2, 45, 162);
		Label label5 = Label1;
		location = new Point(90, 403);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(54, 21);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 1005;
		Label1.Text = "CADEAU";
		Label1.UseCompatibleTextRendering = true;
		((Control)PictureBox4480).BackColor = Color.White;
		((Control)PictureBox4480).Cursor = Cursors.Hand;
		PictureBox4480.Image = (Image)componentResourceManager.GetObject("PictureBox4480.Image");
		PictureBox pictureBox = PictureBox4480;
		location = new Point(8, 388);
		((Control)pictureBox).Location = location;
		((Control)PictureBox4480).Name = "PictureBox4480";
		PictureBox pictureBox2 = PictureBox4480;
		size = new Size(76, 49);
		((Control)pictureBox2).Size = size;
		PictureBox4480.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4480.TabIndex = 1004;
		PictureBox4480.TabStop = false;
		Label73.AutoSize = true;
		((Control)Label73).BackColor = Color.Transparent;
		((Control)Label73).Font = new Font("Tahoma", 9.75f);
		((Control)Label73).ForeColor = Color.FromArgb(2, 45, 162);
		Label label7 = Label73;
		location = new Point(90, 294);
		((Control)label7).Location = location;
		((Control)Label73).Name = "Label73";
		Label label8 = Label73;
		size = new Size(78, 21);
		((Control)label8).Size = size;
		((Control)Label73).TabIndex = 1003;
		Label73.Text = "VERSEMENT";
		Label73.UseCompatibleTextRendering = true;
		((Control)PictureBox1116).BackColor = Color.White;
		((Control)PictureBox1116).Cursor = Cursors.Hand;
		PictureBox1116.Image = (Image)componentResourceManager.GetObject("PictureBox1116.Image");
		PictureBox pictureBox3 = PictureBox1116;
		location = new Point(8, 278);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1116).Name = "PictureBox1116";
		PictureBox pictureBox4 = PictureBox1116;
		size = new Size(76, 49);
		((Control)pictureBox4).Size = size;
		PictureBox1116.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1116.TabIndex = 1002;
		PictureBox1116.TabStop = false;
		Label72.AutoSize = true;
		((Control)Label72).BackColor = Color.Transparent;
		((Control)Label72).Font = new Font("Tahoma", 9.75f);
		((Control)Label72).ForeColor = Color.FromArgb(2, 45, 162);
		Label label9 = Label72;
		location = new Point(90, 239);
		((Control)label9).Location = location;
		((Control)Label72).Name = "Label72";
		Label label10 = Label72;
		size = new Size(68, 21);
		((Control)label10).Size = size;
		((Control)Label72).TabIndex = 1001;
		Label72.Text = "VIREMENT";
		Label72.UseCompatibleTextRendering = true;
		((Control)PictureBox1205).BackColor = Color.White;
		((Control)PictureBox1205).Cursor = Cursors.Hand;
		PictureBox1205.Image = (Image)componentResourceManager.GetObject("PictureBox1205.Image");
		PictureBox pictureBox5 = PictureBox1205;
		location = new Point(8, 223);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1205).Name = "PictureBox1205";
		PictureBox pictureBox6 = PictureBox1205;
		size = new Size(76, 49);
		((Control)pictureBox6).Size = size;
		PictureBox1205.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1205.TabIndex = 1000;
		PictureBox1205.TabStop = false;
		Label71.AutoSize = true;
		((Control)Label71).BackColor = Color.Transparent;
		((Control)Label71).Font = new Font("Tahoma", 9.75f);
		((Control)Label71).ForeColor = Color.FromArgb(2, 45, 162);
		Label label11 = Label71;
		location = new Point(90, 181);
		((Control)label11).Location = location;
		((Control)Label71).Name = "Label71";
		Label label12 = Label71;
		size = new Size(42, 21);
		((Control)label12).Size = size;
		((Control)Label71).TabIndex = 999;
		Label71.Text = "EFFET";
		Label71.UseCompatibleTextRendering = true;
		((Control)PictureBox1944).BackColor = Color.White;
		((Control)PictureBox1944).Cursor = Cursors.Hand;
		PictureBox1944.Image = (Image)componentResourceManager.GetObject("PictureBox1944.Image");
		PictureBox pictureBox7 = PictureBox1944;
		location = new Point(8, 168);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1944).Name = "PictureBox1944";
		PictureBox pictureBox8 = PictureBox1944;
		size = new Size(76, 49);
		((Control)pictureBox8).Size = size;
		PictureBox1944.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1944.TabIndex = 998;
		PictureBox1944.TabStop = false;
		Label70.AutoSize = true;
		((Control)Label70).BackColor = Color.Transparent;
		((Control)Label70).Font = new Font("Tahoma", 9.75f);
		((Control)Label70).ForeColor = Color.FromArgb(2, 45, 162);
		Label label13 = Label70;
		location = new Point(90, 348);
		((Control)label13).Location = location;
		((Control)Label70).Name = "Label70";
		Label label14 = Label70;
		size = new Size(44, 21);
		((Control)label14).Size = size;
		((Control)Label70).TabIndex = 997;
		Label70.Text = "AVOIR";
		Label70.UseCompatibleTextRendering = true;
		Label69.AutoSize = true;
		((Control)Label69).BackColor = Color.Transparent;
		((Control)Label69).Font = new Font("Tahoma", 9.75f);
		((Control)Label69).ForeColor = Color.FromArgb(2, 45, 162);
		Label label15 = Label69;
		location = new Point(90, 126);
		((Control)label15).Location = location;
		((Control)Label69).Name = "Label69";
		Label label16 = Label69;
		size = new Size(55, 21);
		((Control)label16).Size = size;
		((Control)Label69).TabIndex = 995;
		Label69.Text = "CHEQUE";
		Label69.UseCompatibleTextRendering = true;
		Label67.AutoSize = true;
		((Control)Label67).BackColor = Color.Transparent;
		((Control)Label67).Font = new Font("Tahoma", 9.75f);
		((Control)Label67).ForeColor = Color.FromArgb(2, 45, 162);
		Label label17 = Label67;
		location = new Point(90, 71);
		((Control)label17).Location = location;
		((Control)Label67).Name = "Label67";
		Label label18 = Label67;
		size = new Size(45, 21);
		((Control)label18).Size = size;
		((Control)Label67).TabIndex = 994;
		Label67.Text = "CARTE";
		Label67.UseCompatibleTextRendering = true;
		Label66.AutoSize = true;
		((Control)Label66).BackColor = Color.Transparent;
		((Control)Label66).Font = new Font("Tahoma", 9.75f);
		((Control)Label66).ForeColor = Color.FromArgb(2, 45, 162);
		Label label19 = Label66;
		location = new Point(90, 18);
		((Control)label19).Location = location;
		((Control)Label66).Name = "Label66";
		Label label20 = Label66;
		size = new Size(58, 21);
		((Control)label20).Size = size;
		((Control)Label66).TabIndex = 993;
		Label66.Text = "ESPECES";
		Label66.UseCompatibleTextRendering = true;
		((Control)PictureBox1893).BackColor = Color.White;
		((Control)PictureBox1893).Cursor = Cursors.Hand;
		PictureBox1893.Image = (Image)componentResourceManager.GetObject("PictureBox1893.Image");
		PictureBox pictureBox9 = PictureBox1893;
		location = new Point(8, 333);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox1893).Name = "PictureBox1893";
		PictureBox pictureBox10 = PictureBox1893;
		size = new Size(76, 49);
		((Control)pictureBox10).Size = size;
		PictureBox1893.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1893.TabIndex = 784;
		PictureBox1893.TabStop = false;
		((Control)PictureBox1166).BackColor = Color.White;
		((Control)PictureBox1166).Cursor = Cursors.Hand;
		PictureBox1166.Image = (Image)componentResourceManager.GetObject("PictureBox1166.Image");
		PictureBox pictureBox11 = PictureBox1166;
		location = new Point(8, 113);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox1166).Name = "PictureBox1166";
		PictureBox pictureBox12 = PictureBox1166;
		size = new Size(76, 49);
		((Control)pictureBox12).Size = size;
		PictureBox1166.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1166.TabIndex = 782;
		PictureBox1166.TabStop = false;
		((Control)PictureBox1650).BackColor = Color.White;
		((Control)PictureBox1650).Cursor = Cursors.Hand;
		PictureBox1650.Image = (Image)componentResourceManager.GetObject("PictureBox1650.Image");
		PictureBox pictureBox13 = PictureBox1650;
		location = new Point(8, 58);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox1650).Name = "PictureBox1650";
		PictureBox pictureBox14 = PictureBox1650;
		size = new Size(76, 49);
		((Control)pictureBox14).Size = size;
		PictureBox1650.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1650.TabIndex = 781;
		PictureBox1650.TabStop = false;
		((Control)PictureBox4459).BackColor = Color.White;
		((Control)PictureBox4459).Cursor = Cursors.Hand;
		PictureBox4459.Image = (Image)componentResourceManager.GetObject("PictureBox4459.Image");
		PictureBox pictureBox15 = PictureBox4459;
		location = new Point(8, 3);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox4459).Name = "PictureBox4459";
		PictureBox pictureBox16 = PictureBox4459;
		size = new Size(76, 49);
		((Control)pictureBox16).Size = size;
		PictureBox4459.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4459.TabIndex = 780;
		PictureBox4459.TabStop = false;
		((Control)Picture_COLOR_8).BackColor = Color.Red;
		((Control)Picture_COLOR_8).Cursor = Cursors.Hand;
		PictureBox picture_COLOR_ = Picture_COLOR_8;
		location = new Point(8, 443);
		((Control)picture_COLOR_).Location = location;
		((Control)Picture_COLOR_8).Name = "Picture_COLOR_8";
		PictureBox picture_COLOR_2 = Picture_COLOR_8;
		size = new Size(76, 49);
		((Control)picture_COLOR_2).Size = size;
		Picture_COLOR_8.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_8.TabIndex = 760;
		Picture_COLOR_8.TabStop = false;
		((Control)Picture_COLOR_4).BackColor = Color.DodgerBlue;
		((Control)Picture_COLOR_4).Cursor = Cursors.Hand;
		PictureBox picture_COLOR_3 = Picture_COLOR_4;
		location = new Point(8, 498);
		((Control)picture_COLOR_3).Location = location;
		((Control)Picture_COLOR_4).Name = "Picture_COLOR_4";
		PictureBox picture_COLOR_4 = Picture_COLOR_4;
		size = new Size(76, 49);
		((Control)picture_COLOR_4).Size = size;
		Picture_COLOR_4.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_4.TabIndex = 757;
		Picture_COLOR_4.TabStop = false;
		((Control)Picture_COLOR_7).BackColor = Color.Gold;
		((Control)Picture_COLOR_7).Cursor = Cursors.Hand;
		PictureBox picture_COLOR_5 = Picture_COLOR_7;
		location = new Point(8, 553);
		((Control)picture_COLOR_5).Location = location;
		((Control)Picture_COLOR_7).Name = "Picture_COLOR_7";
		PictureBox picture_COLOR_6 = Picture_COLOR_7;
		size = new Size(76, 49);
		((Control)picture_COLOR_6).Size = size;
		Picture_COLOR_7.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_7.TabIndex = 758;
		Picture_COLOR_7.TabStop = false;
		((Control)Picture_COLOR_2).BackColor = Color.FromArgb(46, 204, 113);
		((Control)Picture_COLOR_2).Cursor = Cursors.Hand;
		PictureBox picture_COLOR_7 = Picture_COLOR_2;
		location = new Point(8, 663);
		((Control)picture_COLOR_7).Location = location;
		((Control)Picture_COLOR_2).Name = "Picture_COLOR_2";
		PictureBox picture_COLOR_8 = Picture_COLOR_2;
		size = new Size(76, 49);
		((Control)picture_COLOR_8).Size = size;
		Picture_COLOR_2.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_2.TabIndex = 755;
		Picture_COLOR_2.TabStop = false;
		((Control)Picture_COLOR_16).BackColor = Color.MediumOrchid;
		((Control)Picture_COLOR_16).Cursor = Cursors.Hand;
		PictureBox picture_COLOR_9 = Picture_COLOR_16;
		location = new Point(8, 608);
		((Control)picture_COLOR_9).Location = location;
		((Control)Picture_COLOR_16).Name = "Picture_COLOR_16";
		PictureBox picture_COLOR_10 = Picture_COLOR_16;
		size = new Size(76, 49);
		((Control)picture_COLOR_10).Size = size;
		Picture_COLOR_16.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_16.TabIndex = 771;
		Picture_COLOR_16.TabStop = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 498);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(621, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 866;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		Label_BOTTOM.UseCompatibleTextRendering = true;
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
		size = new Size(4, 478);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 865;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		Label_LEFT.UseCompatibleTextRendering = true;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(625, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 478);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 864;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		Label_RIGHT.UseCompatibleTextRendering = true;
		((Control)Label_INDEX).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX).ForeColor = Color.White;
		Label label_INDEX = Label_INDEX;
		location = new Point(593, 0);
		((Control)label_INDEX).Location = location;
		((Control)Label_INDEX).Name = "Label_INDEX";
		Label label_INDEX2 = Label_INDEX;
		size = new Size(36, 24);
		((Control)label_INDEX2).Size = size;
		((Control)Label_INDEX).TabIndex = 863;
		Label_INDEX.Text = "-";
		Label_INDEX.TextAlign = (ContentAlignment)64;
		Label_INDEX.UseCompatibleTextRendering = true;
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
		size = new Size(629, 24);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 862;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		Label_TOP.UseCompatibleTextRendering = true;
		((ButtonBase)Button11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button11).Cursor = Cursors.Hand;
		((ButtonBase)Button11).FlatStyle = (FlatStyle)0;
		((Control)Button11).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Button11).ForeColor = Color.White;
		((ButtonBase)Button11).Image = (Image)componentResourceManager.GetObject("Button11.Image");
		((ButtonBase)Button11).ImageAlign = (ContentAlignment)16;
		Button button5 = Button11;
		location = new Point(401, 449);
		((Control)button5).Location = location;
		Button button6 = Button11;
		padding = new Padding(0);
		((Control)button6).Margin = padding;
		((Control)Button11).Name = "Button11";
		Button button7 = Button11;
		size = new Size(221, 45);
		((Control)button7).Size = size;
		((Control)Button11).TabIndex = 698;
		((ButtonBase)Button11).Text = "Enregistrer";
		((ButtonBase)Button11).UseCompatibleTextRendering = true;
		((ButtonBase)Button11).UseVisualStyleBackColor = false;
		((ButtonBase)Button10).BackColor = Color.Red;
		((Control)Button10).Cursor = Cursors.Hand;
		((ButtonBase)Button10).FlatStyle = (FlatStyle)0;
		((Control)Button10).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Button10).ForeColor = Color.White;
		((ButtonBase)Button10).Image = (Image)componentResourceManager.GetObject("Button10.Image");
		((ButtonBase)Button10).ImageAlign = (ContentAlignment)16;
		Button button8 = Button10;
		location = new Point(6, 449);
		((Control)button8).Location = location;
		Button button9 = Button10;
		padding = new Padding(0);
		((Control)button9).Margin = padding;
		((Control)Button10).Name = "Button10";
		Button button10 = Button10;
		size = new Size(221, 45);
		((Control)button10).Size = size;
		((Control)Button10).TabIndex = 700;
		((ButtonBase)Button10).Text = "  Fermer";
		((ButtonBase)Button10).UseCompatibleTextRendering = true;
		((ButtonBase)Button10).UseVisualStyleBackColor = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(296, 455);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 1032;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(925, 613);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Button8);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_5_MODE_P";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage10).ResumeLayout(false);
		((Control)TabPage10).PerformLayout();
		((ISupportInitialize)Picture_IMAGE).EndInit();
		((Control)Panel_COULEUR).ResumeLayout(false);
		((Control)Panel_COULEUR).PerformLayout();
		((ISupportInitialize)PictureBox4480).EndInit();
		((ISupportInitialize)PictureBox1116).EndInit();
		((ISupportInitialize)PictureBox1205).EndInit();
		((ISupportInitialize)PictureBox1944).EndInit();
		((ISupportInitialize)PictureBox1893).EndInit();
		((ISupportInitialize)PictureBox1166).EndInit();
		((ISupportInitialize)PictureBox1650).EndInit();
		((ISupportInitialize)PictureBox4459).EndInit();
		((ISupportInitialize)Picture_COLOR_8).EndInit();
		((ISupportInitialize)Picture_COLOR_4).EndInit();
		((ISupportInitialize)Picture_COLOR_7).EndInit();
		((ISupportInitialize)Picture_COLOR_2).EndInit();
		((ISupportInitialize)Picture_COLOR_16).EndInit();
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

	private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		int num5 = default;
		FileStream fileStream = default;
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
				case 230:
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
							goto IL_006a;
						case 5:
							goto IL_0095;
						case 6:
							goto IL_009f;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_006a:
					num2 = 4;
					DataGridView1.Rows[num5].Cells[0].Value = Image.FromStream((Stream)fileStream);
					goto IL_0095;
					IL_0095:
					num2 = 5;
					fileStream.Close();
					goto IL_009f;
					IL_0026:
					num2 = 3;
					fileStream = new FileStream(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + DataGridView1.Rows[num5].Cells["Images"].Value.ToString(), FileMode.Open, FileAccess.Read);
					goto IL_006a;
					IL_009f:
					num2 = 6;
					num5 = checked(num5 + 1);
					goto IL_00a7;
					IL_0009:
					num2 = 2;
					num6 = checked(DataGridView1.Rows.Count - 1);
					num5 = 0;
					goto IL_00a7;
					IL_00a7:
					num7 = num5;
					num8 = num6;
					if (num7 > num8)
					{
						goto end_IL_0001_2;
					}
					goto IL_0026;
					end_IL_0001:
					break;
				}
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 230;
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

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		checked
		{
			try
			{
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		try
		{
			if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				string right = Conversions.ToString(Operators.ConcatenateObject("SUPPRESION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[1].Value));
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				int position = ((ContainerControl)this).BindingContext[(object)dtt].Position;
				dtt.Rows[position].Delete();
				MySqlCommandBuilder val = new MySqlCommandBuilder(daa);
				((DbDataAdapter)(object)daa).Update(dtt);
				dtt.AcceptChanges();
				((ContainerControl)this).BindingContext[(object)dtt].Position = position;
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

	private void Form_Shown(object sender, EventArgs e)
	{
		Panel panel_INFO = Panel_INFO;
		Point location = checked(new Point((int)Math.Round((double)((Control)DataGridView1).Width / 2.0 - (double)((Control)Panel_INFO).Width / 2.0), (int)Math.Round((double)((Control)DataGridView1).Height / 2.0 - (double)((Control)Panel_INFO).Height / 2.0)));
		((Control)panel_INFO).Location = location;
	}

	private void FormDialog_UTILISATEURS_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		checked
		{
			try
			{
				dtt.Clear();
				daa = new MySqlDataAdapter("select * from      TABLE_MODE_P      order by ID asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)daa).Fill(dtt);
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 40;
				DataGridView1.DataSource = dtt;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10f, (FontStyle)1);
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.ColumnHeadersHeight = 30;
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.DefaultCellStyle.Font = new Font("Arial", 14f, (FontStyle)0);
				DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
				DataGridView1.RowHeadersWidth = 25;
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
				DataGridView1.EnableHeadersVisualStyles = false;
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

	private void Button11_Click(object sender, EventArgs e)
	{
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Strings.Trim(Text_MODE_P.Text), "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Text_MODE_P- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Picture_IMAGE.Image.Save(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text, ImageFormat.Png);
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					dtt.Rows.Add();
					int index = dtt.Rows.Count - 1;
					dtt.Rows[index]["ID"] = Text_ID.Text;
					dtt.Rows[index]["MODE_P"] = Strings.Trim(Text_MODE_P.Text);
					dtt.Rows[index]["Images"] = Text_LIEN_PICTURE.Text;
					MySqlCommandBuilder val = new MySqlCommandBuilder(daa);
					((DbDataAdapter)(object)daa).Update(dtt);
					dtt.AcceptChanges();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					int position = ((ContainerControl)this).BindingContext[(object)dtt].Position;
					dtt.Rows[position]["ID"] = Text_ID.Text;
					dtt.Rows[position]["MODE_P"] = Strings.Trim(Text_MODE_P.Text);
					dtt.Rows[position]["Images"] = Text_LIEN_PICTURE.Text;
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(daa);
					((DbDataAdapter)(object)daa).Update(dtt);
					dtt.AcceptChanges();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void Button10_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Visible = false;
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		checked
		{
			try
			{
				dtt.Clear();
				daa = new MySqlDataAdapter("select * from TABLE_MODE_P     order by    ID     asc", Module1.cn_SQL);
				((DbDataAdapter)(object)daa).Fill(dtt);
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_TOP.Text = "NOUVEAU";
				int num = dtt.Rows.Count - 1;
				int num2 = 0;
				int num5 = default;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectGreater(dtt.Rows[num2]["ID"], num5, TextCompare: false))
					{
						num5 = Conversions.ToInteger(dtt.Rows[num2]["ID"]);
					}
					num2++;
				}
				Text_ID.Text = Conversions.ToString(num5 + 1);
				Text_MODE_P.Text = "";
				Text_LIEN_PICTURE.Text = "0.png";
				Picture_IMAGE.ImageLocation = Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text;
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

	private void Button26_Click(object sender, EventArgs e)
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

	private void PictureBox4459_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "ESPECES";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "ESPECES.png";
	}

	private void PictureBox1650_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "CARTE";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "CARTE.png";
	}

	private void PictureBox1166_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "CHEQUE";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "CHEQUE.png";
	}

	private void PictureBox1944_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "EFFET";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "EFFET.png";
	}

	private void PictureBox1205_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "VIREMENT";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "VIREMENT.png";
	}

	private void PictureBox1116_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "VERSEMENT";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "VERSEMENT.png";
	}

	private void PictureBox1002_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "CREDIT";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "CREDIT.png";
	}

	private void PictureBox1893_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "AVOIR";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "AVOIR.png";
	}

	private void PictureBox4480_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Text_MODE_P.Text = "CADEAU";
		((Control)Text_MODE_P).Enabled = false;
		Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		Text_LIEN_PICTURE.Text = "CADEAU.png";
	}

	private void Picture_COLOR_8_Click(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		Text_MODE_P.Text = "";
		((Control)Text_MODE_P).Enabled = true;
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
		Text_LIEN_PICTURE.Text = "RED.png";
	}

	private void Picture_COLOR_4_Click(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		Text_MODE_P.Text = "";
		((Control)Text_MODE_P).Enabled = true;
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
		Text_LIEN_PICTURE.Text = "BLUE.png";
	}

	private void Picture_COLOR_7_Click(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		Text_MODE_P.Text = "";
		((Control)Text_MODE_P).Enabled = true;
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
		Text_LIEN_PICTURE.Text = "YELLOW.png";
	}

	private void Picture_COLOR_16_Click(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		Text_MODE_P.Text = "";
		((Control)Text_MODE_P).Enabled = true;
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
		Text_LIEN_PICTURE.Text = "VIOLET.png";
	}

	private void Picture_COLOR_2_Click(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		Text_MODE_P.Text = "";
		((Control)Text_MODE_P).Enabled = true;
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
		Text_LIEN_PICTURE.Text = "GREEN.png";
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
