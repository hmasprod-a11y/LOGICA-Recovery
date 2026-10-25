using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using LOGICA.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_AFFICHEUR_2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer_TOTAL_NET")]
	private System.Windows.Forms.Timer _Timer_TOTAL_NET;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel_PUB")]
	private Panel _Panel_PUB;

	[AccessedThroughProperty("Panel_PANIER")]
	private Panel _Panel_PANIER;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private TextBox _Text_TOTAL_NET;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label_SOURI")]
	private Label _Label_SOURI;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox100")]
	private PictureBox _PictureBox100;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_V")]
	private DataGridViewTextBoxColumn _Prix_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("TOTAL_NET")]
	private DataGridViewTextBoxColumn _TOTAL_NET;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Timer_PICTURES")]
	private System.Windows.Forms.Timer _Timer_PICTURES;

	[AccessedThroughProperty("Timer3")]
	private System.Windows.Forms.Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private System.Windows.Forms.Timer _Timer4;

	[AccessedThroughProperty("AxWindowsMediaPlayer1")]
	private AxWindowsMediaPlayer _AxWindowsMediaPlayer1;

	private int _retarde;

	private string _souris;

	internal virtual System.Windows.Forms.Timer Timer_TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer_TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer_TOTAL_NET != null)
			{
				_Timer_TOTAL_NET.Tick -= eventHandler;
			}
			_Timer_TOTAL_NET = value;
			if (_Timer_TOTAL_NET != null)
			{
				_Timer_TOTAL_NET.Tick += eventHandler;
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
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
			EventHandler eventHandler = PictureBox11_DoubleClick;
			EventHandler eventHandler2 = PictureBox11_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).DoubleClick -= eventHandler;
				((Control)_PictureBox1).Click -= eventHandler2;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).DoubleClick += eventHandler;
				((Control)_PictureBox1).Click += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel_PUB
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_PUB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel1_Paint;
			if (_Panel_PUB != null)
			{
				((Control)_Panel_PUB).Paint -= val;
			}
			_Panel_PUB = value;
			if (_Panel_PUB != null)
			{
				((Control)_Panel_PUB).Paint += val;
			}
		}
	}

	internal virtual Panel Panel_PANIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_PANIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel100_Paint;
			if (_Panel_PANIER != null)
			{
				((Control)_Panel_PANIER).Paint -= val;
			}
			_Panel_PANIER = value;
			if (_Panel_PANIER != null)
			{
				((Control)_Panel_PANIER).Paint += val;
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
			_Text_TOTAL_NET = value;
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

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
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

	internal virtual Label Label_SOURI
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_SOURI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_SOURI_Click;
			EventHandler eventHandler2 = Label_SOURI_TextChanged;
			if (_Label_SOURI != null)
			{
				((Control)_Label_SOURI).Click -= eventHandler;
				((Control)_Label_SOURI).TextChanged -= eventHandler2;
			}
			_Label_SOURI = value;
			if (_Label_SOURI != null)
			{
				((Control)_Label_SOURI).Click += eventHandler;
				((Control)_Label_SOURI).TextChanged += eventHandler2;
			}
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
			EventHandler eventHandler = PictureBox100_DoubleClick;
			EventHandler eventHandler2 = PictureBox100_Click;
			if (_PictureBox100 != null)
			{
				((Control)_PictureBox100).DoubleClick -= eventHandler;
				((Control)_PictureBox100).Click -= eventHandler2;
			}
			_PictureBox100 = value;
			if (_PictureBox100 != null)
			{
				((Control)_PictureBox100).DoubleClick += eventHandler;
				((Control)_PictureBox100).Click += eventHandler2;
			}
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

	internal virtual System.Windows.Forms.Timer Timer_PICTURES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer_PICTURES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_PICTURES_Tick;
			if (_Timer_PICTURES != null)
			{
				_Timer_PICTURES.Tick -= eventHandler;
			}
			_Timer_PICTURES = value;
			if (_Timer_PICTURES != null)
			{
				_Timer_PICTURES.Tick += eventHandler;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.Tick -= eventHandler;
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.Tick += eventHandler;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.Tick -= eventHandler;
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.Tick += eventHandler;
			}
		}
	}

	internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AxWindowsMediaPlayer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AxWindowsMediaPlayer1 = value;
		}
	}

	public FormDialog_AFFICHEUR_2()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Form)this).FormClosed += Form_AFFICHEUR_2_FormClosed;
		((Form)this).Shown += Form_Afficheur2_Shown;
		((Form)this).Load += Form_Afficheur2_Load;
		__ENCAddToList(this);
		_retarde = 0;
		_souris = "";
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected Obj, but got Unknown
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Expected Obj, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e7: Expected Obj, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_AFFICHEUR_2));
		Timer_TOTAL_NET = new System.Windows.Forms.Timer(components);
		ProgressBar1 = new ProgressBar();
		ListBox1 = new ListBox();
		PictureBox1 = new PictureBox();
		Panel_PUB = new Panel();
		Panel_PANIER = new Panel();
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel4 = new Panel();
		Text_TOTAL_NET = new TextBox();
		Label18 = new Label();
		TextBox1 = new TextBox();
		Label1 = new Label();
		Panel3 = new Panel();
		PictureBox100 = new PictureBox();
		Label_SOURI = new Label();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		Panel5 = new Panel();
		DataGridView1 = new DataGridView();
		Article = new DataGridViewTextBoxColumn();
		Prix_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		TOTAL_NET = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Timer_PICTURES = new System.Windows.Forms.Timer(components);
		Timer3 = new System.Windows.Forms.Timer(components);
		Timer4 = new System.Windows.Forms.Timer(components);
		AxWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel_PUB).SuspendLayout();
		((Control)Panel_PANIER).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox100).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)AxWindowsMediaPlayer1).BeginInit();
		((Control)this).SuspendLayout();
		Timer_TOTAL_NET.Interval = 500;
		ProgressBar progressBar = ProgressBar1;
		Point location = new Point(453, 53);
		((Control)progressBar).Location = location;
		((Control)ProgressBar1).Name = "ProgressBar1";
		ProgressBar progressBar2 = ProgressBar1;
		Size size = new Size(290, 13);
		((Control)progressBar2).Size = size;
		((Control)ProgressBar1).TabIndex = 53;
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox listBox = ListBox1;
		location = new Point(136, 53);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(130, 277);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 51;
		((Control)PictureBox1).BackColor = Color.White;
		PictureBox pictureBox = PictureBox1;
		location = new Point(453, 87);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(290, 69);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 50;
		PictureBox1.TabStop = false;
		((Control)Panel_PUB).BackColor = Color.DarkMagenta;
		((Control)Panel_PUB).Controls.Add((Control)(object)AxWindowsMediaPlayer1);
		((Control)Panel_PUB).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_PUB).Controls.Add((Control)(object)ProgressBar1);
		((Control)Panel_PUB).Controls.Add((Control)(object)ListBox1);
		Panel panel_PUB = Panel_PUB;
		location = new Point(0, 0);
		((Control)panel_PUB).Location = location;
		((Control)Panel_PUB).Name = "Panel_PUB";
		Panel panel_PUB2 = Panel_PUB;
		size = new Size(863, 562);
		((Control)panel_PUB2).Size = size;
		((Control)Panel_PUB).TabIndex = 54;
		((Control)Panel_PANIER).BackColor = Color.White;
		((Control)Panel_PANIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_PANIER = Panel_PANIER;
		location = new Point(0, 0);
		((Control)panel_PANIER).Location = location;
		((Control)Panel_PANIER).Name = "Panel_PANIER";
		Panel panel_PANIER2 = Panel_PANIER;
		size = new Size(899, 562);
		((Control)panel_PANIER2).Size = size;
		((Control)Panel_PANIER).TabIndex = 55;
		((Control)TableLayoutPanel1).BackColor = Color.Transparent;
		TableLayoutPanel1.ColumnCount = 1;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel1.Controls.Add((Control)(object)Panel4, 0, 2);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel3, 0, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel5, 0, 1);
		((Control)TableLayoutPanel1).Dock = (DockStyle)5;
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel1;
		location = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel1.RowCount = 3;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)1, 120f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)1, 80f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel1;
		size = new Size(899, 562);
		((Control)tableLayoutPanel2).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 55;
		((Control)Panel4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel4).Controls.Add((Control)(object)Text_TOTAL_NET);
		((Control)Panel4).Controls.Add((Control)(object)Label18);
		((Control)Panel4).Controls.Add((Control)(object)TextBox1);
		((Control)Panel4).Controls.Add((Control)(object)Label1);
		((Control)Panel4).Dock = (DockStyle)5;
		Panel panel = Panel4;
		location = new Point(3, 485);
		((Control)panel).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel2 = Panel4;
		size = new Size(893, 74);
		((Control)panel2).Size = size;
		((Control)Panel4).TabIndex = 692;
		((Control)Text_TOTAL_NET).Anchor = (AnchorStyles)9;
		((TextBoxBase)Text_TOTAL_NET).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)Text_TOTAL_NET).BorderStyle = (BorderStyle)0;
		((Control)Text_TOTAL_NET).Font = new Font("Segoe UI", 44f, (FontStyle)1);
		((TextBoxBase)Text_TOTAL_NET).ForeColor = Color.White;
		TextBox text_TOTAL_NET = Text_TOTAL_NET;
		location = new Point(573, 3);
		((Control)text_TOTAL_NET).Location = location;
		Text_TOTAL_NET.Multiline = true;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		((TextBoxBase)Text_TOTAL_NET).ReadOnly = true;
		TextBox text_TOTAL_NET2 = Text_TOTAL_NET;
		size = new Size(318, 71);
		((Control)text_TOTAL_NET2).Size = size;
		((Control)Text_TOTAL_NET).TabIndex = 688;
		Text_TOTAL_NET.TextAlign = (HorizontalAlignment)1;
		((Control)Label18).Anchor = (AnchorStyles)9;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 34f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.White;
		Label label = Label18;
		location = new Point(255, 3);
		((Control)label).Location = location;
		((Control)Label18).Name = "Label18";
		Label label2 = Label18;
		size = new Size(318, 71);
		((Control)label2).Size = size;
		((Control)Label18).TabIndex = 689;
		Label18.Text = "TOTAL NET :";
		Label18.TextAlign = (ContentAlignment)64;
		((TextBoxBase)TextBox1).BackColor = Color.White;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Segoe UI", 60f, (FontStyle)1);
		((TextBoxBase)TextBox1).ForeColor = Color.Black;
		TextBox textBox = TextBox1;
		location = new Point(117, 278);
		((Control)textBox).Location = location;
		TextBox1.Multiline = true;
		((Control)TextBox1).Name = "TextBox1";
		((TextBoxBase)TextBox1).ReadOnly = true;
		TextBox textBox2 = TextBox1;
		size = new Size(576, 86);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 688;
		TextBox1.TextAlign = (HorizontalAlignment)2;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Segoe UI", 60f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label3 = Label1;
		location = new Point(117, 189);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(576, 86);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 689;
		Label1.Text = "TOTAL NET";
		Label1.TextAlign = (ContentAlignment)32;
		((Control)Panel3).BackColor = Color.Transparent;
		((Control)Panel3).Controls.Add((Control)(object)PictureBox100);
		((Control)Panel3).Controls.Add((Control)(object)Label_SOURI);
		((Control)Panel3).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel3).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel3).Dock = (DockStyle)5;
		Panel panel3 = Panel3;
		location = new Point(3, 3);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(893, 114);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 1031;
		((Control)PictureBox100).Anchor = (AnchorStyles)13;
		((Control)PictureBox100).BackColor = Color.Transparent;
		PictureBox pictureBox3 = PictureBox100;
		location = new Point(294, 0);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox100).Name = "PictureBox100";
		PictureBox pictureBox4 = PictureBox100;
		size = new Size(306, 111);
		((Control)pictureBox4).Size = size;
		PictureBox100.SizeMode = (PictureBoxSizeMode)4;
		PictureBox100.TabIndex = 693;
		PictureBox100.TabStop = false;
		Label_SOURI.AutoSize = true;
		Label label_SOURI = Label_SOURI;
		location = new Point(392, 84);
		((Control)label_SOURI).Location = location;
		((Control)Label_SOURI).Name = "Label_SOURI";
		Label label_SOURI2 = Label_SOURI;
		size = new Size(70, 13);
		((Control)label_SOURI2).Size = size;
		((Control)Label_SOURI).TabIndex = 694;
		Label_SOURI.Text = "Label_SOURI";
		((Control)Label_SOURI).Visible = false;
		((Control)PictureBox2).BackColor = Color.Transparent;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(-3, 40);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(297, 35);
		((Control)pictureBox6).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2.TabIndex = 692;
		PictureBox2.TabStop = false;
		((Control)PictureBox3).Anchor = (AnchorStyles)9;
		((Control)PictureBox3).BackColor = Color.Transparent;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox7 = PictureBox3;
		location = new Point(598, 40);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox8 = PictureBox3;
		size = new Size(298, 35);
		((Control)pictureBox8).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 691;
		PictureBox3.TabStop = false;
		((Control)Panel5).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel5).Dock = (DockStyle)5;
		Panel panel5 = Panel5;
		location = new Point(3, 123);
		((Control)panel5).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel6 = Panel5;
		size = new Size(893, 356);
		((Control)panel6).Size = size;
		((Control)Panel5).TabIndex = 1034;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeight = 30;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)TOTAL_NET,
			(DataGridViewColumn)Code
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Calibri", 22f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		((Control)DataGridView1).Dock = (DockStyle)5;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(893, 356);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 690;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Article).Resizable = (DataGridViewTriState)1;
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_V).DataPropertyName = "PRIX_V";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)Prix_V).DefaultCellStyle = val3;
		((DataGridViewColumn)Prix_V).HeaderText = "PRIX_V";
		((DataGridViewColumn)Prix_V).Name = "Prix_V";
		Prix_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_V).Width = 130;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)Qté).DefaultCellStyle = val4;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TOTAL_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NET).DataPropertyName = "TOTAL_NET";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		val5.NullValue = null;
		((DataGridViewColumn)TOTAL_NET).DefaultCellStyle = val5;
		((DataGridViewColumn)TOTAL_NET).HeaderText = "TOTAL_NET";
		((DataGridViewColumn)TOTAL_NET).Name = "TOTAL_NET";
		TOTAL_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TOTAL_NET).Width = 130;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).MinimumWidth = 2;
		((DataGridViewColumn)Code).Name = "Code";
		Code.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Code).Width = 2;
		Timer_PICTURES.Interval = 500;
		Timer3.Interval = 1000;
		Timer4.Interval = 500;
		((AxHost)AxWindowsMediaPlayer1).Enabled = true;
		AxWindowsMediaPlayer axWindowsMediaPlayer = AxWindowsMediaPlayer1;
		location = new Point(453, 185);
		((Control)axWindowsMediaPlayer).Location = location;
		((Control)AxWindowsMediaPlayer1).Name = "AxWindowsMediaPlayer1";
		((AxHost)AxWindowsMediaPlayer1).OcxState = (System.Windows.Forms.AxHost.State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState");
		AxWindowsMediaPlayer axWindowsMediaPlayer2 = AxWindowsMediaPlayer1;
		size = new Size(290, 145);
		((Control)axWindowsMediaPlayer2).Size = size;
		((Control)AxWindowsMediaPlayer1).TabIndex = 31;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.WhiteSmoke;
		size = new Size(952, 562);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_PUB);
		((Control)this).Controls.Add((Control)(object)Panel_PANIER);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_AFFICHEUR_2_DIRECTE";
		((Form)this).ShowIcon = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel_PUB).ResumeLayout(false);
		((Control)Panel_PANIER).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox100).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)AxWindowsMediaPlayer1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form_AFFICHEUR_2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Timer_TOTAL_NET.Enabled = false;
		Timer3.Enabled = false;
		Timer4.Enabled = false;
	}

	private void Form_Afficheur2_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)Panel_PANIER).Dock = (DockStyle)5;
			((Control)Panel_PUB).Dock = (DockStyle)5;
			((Control)Panel_PANIER).BringToFront();
			PictureBox100.Image = MyProject.Forms.Form_3_VENTE.PictureBox100.Image;
			Timer_TOTAL_NET.Enabled = true;
			Timer3.Enabled = true;
			Timer4.Enabled = true;
			DataGridView1.AutoGenerateColumns = false;
			DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
			DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
			DataGridView1.RowTemplate.Height = 60;
			DataGridView1.DataSource = Module1.dt1;
			DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
			DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
			ReadOnlyCollection<string> files = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles("C:\\PHOTOS", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[1] { "*.*" });
			foreach (string item in files)
			{
				ListBox1.Items.Add((object)item);
			}
			if (ListBox1.Items.Count > 0)
			{
				Random random = new Random();
				int num = random.Next(0, ListBox1.Items.Count);
				if (Operators.CompareString(Path.GetExtension(ListBox1.Items[num].ToString()), ".mp4", TextCompare: false) == 0)
				{
					((Form)this).Text = "VIDEO";
					((Control)AxWindowsMediaPlayer1).BringToFront();
					((Control)AxWindowsMediaPlayer1).Dock = (DockStyle)5;
					AxWindowsMediaPlayer1.settings.autoStart = false;
					AxWindowsMediaPlayer1.settings.setMode("loop", varfMode: true);
					AxWindowsMediaPlayer1.uiMode = "None";
					AxWindowsMediaPlayer1.stretchToFit = true;
					AxWindowsMediaPlayer1.URL = ListBox1.Items[num].ToString();
					AxWindowsMediaPlayer1.Ctlcontrols.play();
					((Control)AxWindowsMediaPlayer1).Visible = true;
					AxWindowsMediaPlayer1.enableContextMenu = false;
				}
				else
				{
					((Form)this).Text = "PHOTO";
					((Control)PictureBox1).BringToFront();
					((Control)PictureBox1).Dock = (DockStyle)5;
					PictureBox1.Image = Image.FromFile(ListBox1.Items[num].ToString());
					((Control)ProgressBar1).BringToFront();
				}
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

	private void PictureBox11_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox11_DoubleClick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (MyProject.Forms.Form_3_VENTE.DataGridView1.Rows.Count != 0)
		{
			Text_TOTAL_NET.Text = MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET.Text + " DH";
		}
		else
		{
			Text_TOTAL_NET.Text = "0 DH";
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Form_Afficheur2_Shown(object sender, EventArgs e)
	{
		checked
		{
			((Control)PictureBox100).Left = (int)Math.Round((double)((Control)Panel3).Width / 2.0 - (double)((Control)PictureBox100).Width / 2.0);
			((Control)PictureBox100).Top = (int)Math.Round((double)((Control)Panel3).Height / 2.0 - (double)((Control)PictureBox100).Height / 2.0);
			((Control)ProgressBar1).Top = 0;
			((Control)ProgressBar1).Left = 0;
			((Control)ProgressBar1).Width = ((Control)this).Width;
		}
	}

	private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click_1(object sender, EventArgs e)
	{
		((Control)this).Left = checked(((Control)this).Left - 1);
		NewLateBinding.LateSet(sender, null, "text", new object[1] { ((Control)this).Left }, null, null);
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void PictureBox100_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox100_DoubleClick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Panel100_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Timer_PICTURES_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		int num5 = default;
		Random random = default;
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
					goto IL_0009;
				case 280:
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
							goto IL_0041;
						case 5:
							goto IL_0051;
						case 6:
							goto IL_005a;
						case 7:
							goto IL_0075;
						case 8:
							goto IL_0084;
						case 9:
							goto IL_0094;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0075:
					num2 = 7;
					((Control)PictureBox1).BringToFront();
					goto IL_0084;
					IL_0084:
					num2 = 8;
					((Control)PictureBox1).Dock = (DockStyle)5;
					goto IL_0094;
					IL_005a:
					num2 = 6;
					num5 = random.Next(0, ListBox1.Items.Count);
					goto IL_0075;
					IL_0094:
					num2 = 9;
					PictureBox1.Image = Image.FromFile(ListBox1.Items[num5].ToString());
					break;
					IL_0009:
					num2 = 2;
					ProgressBar1.Value = checked(ProgressBar1.Value + 10);
					goto IL_0026;
					IL_0026:
					num2 = 3;
					if (ProgressBar1.Value != 100)
					{
						goto end_IL_0001_3;
					}
					goto IL_0041;
					IL_0041:
					num2 = 4;
					ProgressBar1.Value = 0;
					goto IL_0051;
					IL_0051:
					num2 = 5;
					random = new Random();
					goto IL_005a;
					end_IL_0001_2:
					break;
				}
				num2 = 10;
				((Control)ProgressBar1).BringToFront();
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 280;
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

	private void Timer3_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				_souris = Label_SOURI.Text;
				if (MyProject.Forms.Form_3_VENTE.DataGridView1.Rows.Count == 0)
				{
					if (Operators.CompareString(Cursor.Position.ToString(), _souris, TextCompare: false) == 0)
					{
						_retarde++;
					}
				}
				else
				{
					Label_SOURI_TextChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (_retarde != 20)
				{
					return;
				}
				if (ListBox1.Items.Count > 0)
				{
					((Control)Panel_PUB).BringToFront();
					if (Operators.CompareString(((Form)this).Text, "VIDEO", TextCompare: false) == 0)
					{
						((Control)AxWindowsMediaPlayer1).BringToFront();
						((Control)AxWindowsMediaPlayer1).Dock = (DockStyle)5;
						Random random = new Random();
						int num = random.Next(0, ListBox1.Items.Count);
						AxWindowsMediaPlayer1.URL = ListBox1.Items[num].ToString();
						AxWindowsMediaPlayer1.Ctlcontrols.play();
					}
					else if (Operators.CompareString(((Form)this).Text, "PHOTO", TextCompare: false) == 0)
					{
						Timer_PICTURES.Enabled = true;
					}
				}
				_retarde = 0;
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

	private void Timer4_Tick(object sender, EventArgs e)
	{
		Label_SOURI.Text = Cursor.Position.ToString();
	}

	private void Label_SOURI_Click(object sender, EventArgs e)
	{
	}

	private void Label_SOURI_TextChanged(object sender, EventArgs e)
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
					goto IL_0009;
				case 111:
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
							goto IL_0017;
						case 4:
							goto IL_002a;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num2 = 2;
					((Control)Panel_PUB).SendToBack();
					goto IL_0017;
					IL_0017:
					num2 = 3;
					AxWindowsMediaPlayer1.Ctlcontrols.stop();
					goto IL_002a;
					IL_002a:
					num2 = 4;
					Timer_PICTURES.Enabled = false;
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 5;
				_retarde = 0;
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 111;
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
}
