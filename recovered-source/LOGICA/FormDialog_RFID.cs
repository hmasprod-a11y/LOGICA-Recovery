using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_RFID : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Text_NUM")]
	private TextBox _Text_NUM;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("Butt_00")]
	private Button _Butt_00;

	[AccessedThroughProperty("Butt_DRAFT")]
	private Button _Butt_DRAFT;

	[AccessedThroughProperty("Butt_DOT")]
	private Button _Butt_DOT;

	[AccessedThroughProperty("Butt_ok")]
	private Button _Butt_ok;

	[AccessedThroughProperty("Butt_9")]
	private Button _Butt_9;

	[AccessedThroughProperty("Butt_8")]
	private Button _Butt_8;

	[AccessedThroughProperty("Butt_7")]
	private Button _Butt_7;

	[AccessedThroughProperty("Butt_6")]
	private Button _Butt_6;

	[AccessedThroughProperty("Butt_5")]
	private Button _Butt_5;

	[AccessedThroughProperty("Butt_4")]
	private Button _Butt_4;

	[AccessedThroughProperty("Butt_3")]
	private Button _Butt_3;

	[AccessedThroughProperty("Butt_2")]
	private Button _Butt_2;

	[AccessedThroughProperty("Butt_1")]
	private Button _Butt_1;

	[AccessedThroughProperty("Butt_0")]
	private Button _Butt_0;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	internal virtual TextBox Text_NUM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_NUM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			KeyEventHandler val = Text_NUM_KeyDown;
			KeyPressEventHandler val2 = Text_NUM_KeyPress;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyDown -= val;
				((Control)_Text_NUM).KeyPress -= val2;
			}
			_Text_NUM = value;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyDown += val;
				((Control)_Text_NUM).KeyPress += val2;
			}
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
			EventHandler eventHandler = PictureBox_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.Tick -= eventHandler;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Tick += eventHandler;
			}
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

	internal virtual Button Butt_00
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_00;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_00 != null)
			{
				((Control)_Butt_00).Click -= eventHandler;
			}
			_Butt_00 = value;
			if (_Butt_00 != null)
			{
				((Control)_Butt_00).Click += eventHandler;
			}
		}
	}

	internal virtual Button Butt_DRAFT
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

	internal virtual Button Butt_DOT
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
			EventHandler eventHandler = Butt_DOT_Click;
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

	internal virtual Button Butt_ok
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_ok_Click;
			if (_Butt_ok != null)
			{
				((Control)_Butt_ok).Click -= eventHandler;
			}
			_Butt_ok = value;
			if (_Butt_ok != null)
			{
				((Control)_Butt_ok).Click += eventHandler;
			}
		}
	}

	internal virtual Button Butt_9
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

	internal virtual Button Butt_8
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

	internal virtual Button Butt_7
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

	internal virtual Button Butt_6
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

	internal virtual Button Butt_5
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

	internal virtual Button Butt_4
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

	internal virtual Button Butt_3
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

	internal virtual Button Butt_2
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

	internal virtual Button Butt_1
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

	internal virtual Button Butt_0
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

	[DebuggerNonUserCode]
	public FormDialog_RFID()
	{
		((Form)this).Load += Form_acces_Load;
		((Form)this).Shown += FormDialog_rfid_Shown;
		__ENCAddToList(this);
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected Obj, but got Unknown
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected Obj, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Expected Obj, but got Unknown
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected Obj, but got Unknown
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Expected Obj, but got Unknown
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected Obj, but got Unknown
		//IL_111b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected Obj, but got Unknown
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Expected Obj, but got Unknown
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected Obj, but got Unknown
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_RFID));
		Text_NUM = new TextBox();
		PictureBox1 = new PictureBox();
		Timer1 = new System.Windows.Forms.Timer(components);
		Panel1 = new Panel();
		Panel_CLAVIER = new Panel();
		Butt_00 = new Button();
		Butt_DRAFT = new Button();
		Butt_DOT = new Button();
		Butt_ok = new Button();
		Butt_9 = new Button();
		Butt_8 = new Button();
		Butt_7 = new Button();
		Butt_6 = new Button();
		Butt_5 = new Button();
		Butt_4 = new Button();
		Butt_3 = new Button();
		Butt_2 = new Button();
		Butt_1 = new Button();
		Butt_0 = new Button();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Label28 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)this).SuspendLayout();
		((TextBoxBase)Text_NUM).BorderStyle = (BorderStyle)0;
		((Control)Text_NUM).Font = new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox text_NUM = Text_NUM;
		Point location = new Point(3, 5);
		((Control)text_NUM).Location = location;
		((Control)Text_NUM).Name = "Text_NUM";
		Text_NUM.PasswordChar = '●';
		TextBox text_NUM2 = Text_NUM;
		Size size = new Size(300, 29);
		((Control)text_NUM2).Size = size;
		((Control)Text_NUM).TabIndex = 32;
		Text_NUM.TextAlign = (HorizontalAlignment)2;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		location = new Point(425, 112);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(222, 199);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		Timer1.Interval = 3000;
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)Text_NUM);
		Panel panel = Panel1;
		location = new Point(379, 316);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(312, 41);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 707;
		((Control)Panel_CLAVIER).BackColor = Color.Transparent;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_00);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DRAFT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DOT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_ok);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_9);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_8);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_7);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_6);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_5);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_4);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_3);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_0);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_BACK);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(379, 363);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(312, 235);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 769;
		((Control)Panel_CLAVIER).Visible = false;
		((ButtonBase)Butt_00).BackColor = Color.White;
		((Control)Butt_00).Cursor = Cursors.Hand;
		((ButtonBase)Butt_00).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_00).FlatStyle = (FlatStyle)0;
		((Control)Butt_00).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_ = Butt_00;
		location = new Point(163, 181);
		((Control)butt_).Location = location;
		((Control)Butt_00).Name = "Butt_00";
		Button butt_2 = Butt_00;
		size = new Size(61, 51);
		((Control)butt_2).Size = size;
		((Control)Butt_00).TabIndex = 701;
		((ButtonBase)Butt_00).Text = "00";
		((ButtonBase)Butt_00).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DRAFT).BackColor = Color.White;
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DRAFT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DRAFT).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Butt_DRAFT).Image = (Image)componentResourceManager.GetObject("Butt_DRAFT.Image");
		Button butt_DRAFT = Butt_DRAFT;
		location = new Point(243, 63);
		((Control)butt_DRAFT).Location = location;
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		Button butt_DRAFT2 = Butt_DRAFT;
		size = new Size(61, 51);
		((Control)butt_DRAFT2).Size = size;
		((Control)Butt_DRAFT).TabIndex = 689;
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.White;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Calibri", 9.75f);
		((ButtonBase)Butt_DOT).Image = (Image)componentResourceManager.GetObject("Butt_DOT.Image");
		Button butt_DOT = Butt_DOT;
		location = new Point(3, 181);
		((Control)butt_DOT).Location = location;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button butt_DOT2 = Butt_DOT;
		size = new Size(61, 51);
		((Control)butt_DOT2).Size = size;
		((Control)Butt_DOT).TabIndex = 687;
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((Control)Butt_ok).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ok).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ok).FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 197, 237);
		((ButtonBase)Butt_ok).FlatStyle = (FlatStyle)0;
		((Control)Butt_ok).Font = new Font("Calibri", 18.25f, (FontStyle)1);
		Button butt_ok = Butt_ok;
		location = new Point(243, 122);
		((Control)butt_ok).Location = location;
		((Control)Butt_ok).Name = "Butt_ok";
		Button butt_ok2 = Butt_ok;
		size = new Size(61, 110);
		((Control)butt_ok2).Size = size;
		((Control)Butt_ok).TabIndex = 27;
		((ButtonBase)Butt_ok).Text = "OK";
		((ButtonBase)Butt_ok).UseVisualStyleBackColor = true;
		((ButtonBase)Butt_9).BackColor = Color.White;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_3 = Butt_9;
		location = new Point(163, 4);
		((Control)butt_3).Location = location;
		((Control)Butt_9).Name = "Butt_9";
		Button butt_4 = Butt_9;
		size = new Size(61, 51);
		((Control)butt_4).Size = size;
		((Control)Butt_9).TabIndex = 686;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.White;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_5 = Butt_8;
		location = new Point(83, 4);
		((Control)butt_5).Location = location;
		((Control)Butt_8).Name = "Butt_8";
		Button butt_6 = Butt_8;
		size = new Size(61, 51);
		((Control)butt_6).Size = size;
		((Control)Butt_8).TabIndex = 685;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.White;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_7 = Butt_7;
		location = new Point(3, 4);
		((Control)butt_7).Location = location;
		((Control)Butt_7).Name = "Butt_7";
		Button butt_8 = Butt_7;
		size = new Size(61, 51);
		((Control)butt_8).Size = size;
		((Control)Butt_7).TabIndex = 684;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.White;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_9 = Butt_6;
		location = new Point(163, 63);
		((Control)butt_9).Location = location;
		((Control)Butt_6).Name = "Butt_6";
		Button butt_10 = Butt_6;
		size = new Size(61, 51);
		((Control)butt_10).Size = size;
		((Control)Butt_6).TabIndex = 683;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.White;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_11 = Butt_5;
		location = new Point(83, 63);
		((Control)butt_11).Location = location;
		((Control)Butt_5).Name = "Butt_5";
		Button butt_12 = Butt_5;
		size = new Size(61, 51);
		((Control)butt_12).Size = size;
		((Control)Butt_5).TabIndex = 682;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.White;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_13 = Butt_4;
		location = new Point(3, 63);
		((Control)butt_13).Location = location;
		((Control)Butt_4).Name = "Butt_4";
		Button butt_14 = Butt_4;
		size = new Size(61, 51);
		((Control)butt_14).Size = size;
		((Control)Butt_4).TabIndex = 681;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.White;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_15 = Butt_3;
		location = new Point(163, 122);
		((Control)butt_15).Location = location;
		((Control)Butt_3).Name = "Butt_3";
		Button butt_16 = Butt_3;
		size = new Size(61, 51);
		((Control)butt_16).Size = size;
		((Control)Butt_3).TabIndex = 680;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.White;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_17 = Butt_2;
		location = new Point(83, 122);
		((Control)butt_17).Location = location;
		((Control)Butt_2).Name = "Butt_2";
		Button butt_18 = Butt_2;
		size = new Size(61, 51);
		((Control)butt_18).Size = size;
		((Control)Butt_2).TabIndex = 679;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.White;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_19 = Butt_1;
		location = new Point(3, 122);
		((Control)butt_19).Location = location;
		((Control)Butt_1).Name = "Butt_1";
		Button butt_20 = Butt_1;
		size = new Size(61, 51);
		((Control)butt_20).Size = size;
		((Control)Butt_1).TabIndex = 678;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.White;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		Button butt_21 = Butt_0;
		location = new Point(83, 181);
		((Control)butt_21).Location = location;
		((Control)Butt_0).Name = "Butt_0";
		Button butt_22 = Butt_0;
		size = new Size(61, 51);
		((Control)butt_22).Size = size;
		((Control)Butt_0).TabIndex = 677;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.White;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.Black;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(243, 4);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		Padding margin = new Padding(0);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(61, 51);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 770;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((Control)Label28).Anchor = (AnchorStyles)13;
		((Control)Label28).BackColor = Color.Transparent;
		((Control)Label28).Font = new Font("Cambria", 12f);
		((Control)Label28).ForeColor = Color.FromArgb(2, 45, 162);
		Label label = Label28;
		location = new Point(201, 90);
		((Control)label).Location = location;
		((Control)Label28).Name = "Label28";
		Label label2 = Label28;
		size = new Size(685, 19);
		((Control)label2).Size = size;
		((Control)Label28).TabIndex = 770;
		Label28.Text = "Veuillez saisir votre code";
		Label28.TextAlign = (ContentAlignment)32;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1073, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label28);
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "FormDialog_RFID";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
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
			MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.DataSource = dataTable;
		}
		checked
		{
			int num = ((BaseCollection)MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns).Count - 1;
			int num2 = 5;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true).Count() == 1)
				{
					if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 1;
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = false;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 1;
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 3;
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
					{
						((Control)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).Visible = true;
						((ButtonBase)(Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE).Controls.Find("Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), true)[0]).FlatAppearance.BorderSize = 5;
					}
					if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), "FLASH", TextCompare: false) == 0)
					{
						if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).Visible = false;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_COMPTER_CAISSE).FlatAppearance.BorderSize = 5;
						}
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Columns[num2].Name.ToString(), "ANNULATION", TextCompare: false) == 0)
					{
						if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).Visible = false;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[num2].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
						{
							((Control)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).Visible = true;
							((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_ANNULATION_ALL).FlatAppearance.BorderSize = 5;
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
					((Control)MyProject.Forms.Form_3_VENTE.Panel_RACCOURCIES).Height = 0;
					return;
				}
				((Control)MyProject.Forms.Form_3_VENTE.Panel_RACCOURCIES).Height = 60;
				((Control)MyProject.Forms.Form_3_VENTE.FlowLayout_RACCOURCIES).Controls.Clear();
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (Operators.CompareString(text, "", TextCompare: false) == 0)
					{
						continue;
					}
					Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = (Button_CLAVIER_NOSELECT)(object)((Control)MyProject.Forms.Form_3_VENTE.TabPage1).Controls["Button_" + text];
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
					((Control)MyProject.Forms.Form_3_VENTE.FlowLayout_RACCOURCIES).Controls.Add((Control)(object)button_CLAVIER_NOSELECT2);
					FieldInfo field = typeof(Component).GetField("events", BindingFlags.Instance | BindingFlags.NonPublic);
					object objectValue = RuntimeHelpers.GetObjectValue(field.GetValue(((Control)MyProject.Forms.Form_3_VENTE.TabPage1).Controls["Button_" + text]));
					field.SetValue(((Control)MyProject.Forms.Form_3_VENTE.FlowLayout_RACCOURCIES).Controls[((Control)button_CLAVIER_NOSELECT2).Name], RuntimeHelpers.GetObjectValue(objectValue));
					try
					{
						if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "VISIBLE", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = true;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "INVISIBLE", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = false;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 1;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "ACCES MANAGER", TextCompare: false) == 0)
						{
							((Control)button_CLAVIER_NOSELECT2).Visible = true;
							((ButtonBase)button_CLAVIER_NOSELECT2).FlatAppearance.BorderSize = 3;
						}
						else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.DataGridView_ACCES.Rows[0].Cells[text].Value.ToString(), "ACCES ADMIN", TextCompare: false) == 0)
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
				((Control)MyProject.Forms.Form_3_VENTE.Panel_RACCOURCIES).Height = 0;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form_acces_Load(object sender, EventArgs e)
	{
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((Form)this).Opacity = 0.8;
		PictureBox pictureBox = PictureBox1;
		checked
		{
			Point location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)PictureBox1).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)PictureBox1).Height / 2.0));
			((Control)pictureBox).Location = location;
			Panel panel = Panel1;
			location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel1).Width / 2.0), ((Control)PictureBox1).Top + ((Control)PictureBox1).Height);
			((Control)panel).Location = location;
			Panel panel_CLAVIER = Panel_CLAVIER;
			location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_CLAVIER).Width / 2.0), ((Control)PictureBox1).Top + ((Control)PictureBox1).Height + ((Control)Panel1).Height);
			((Control)panel_CLAVIER).Location = location;
			((Control)Text_NUM).Focus();
			Timer1.Enabled = true;
		}
	}

	private void Text_NUM_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Butt_ok_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void Text_NUM_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (!((Control)Text_NUM).Focused)
		{
			((Control)Text_NUM).Focus();
		}
	}

	private void PictureBox_Click(object sender, EventArgs e)
	{
		if (((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = false;
		}
		else if (!((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = true;
		}
	}

	private void FormDialog_rfid_Shown(object sender, EventArgs e)
	{
		((Form)this).Activate();
		((Control)Text_NUM).Focus();
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(Operators.AddObject(Text_NUM.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
		((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
		((Control)Text_NUM).Focus();
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
					goto IL_0009;
				case 142:
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
							goto IL_0039;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num2 = 2;
					Text_NUM.Text = Text_NUM.Text.Remove(checked(Text_NUM.Text.Length - 1));
					goto IL_0039;
					IL_0039:
					num2 = 3;
					((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 4;
				((Control)Text_NUM).Focus();
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 142;
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

	private void Butt_DRAFT_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = "";
		((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
		((Control)Text_NUM).Focus();
	}

	private void Butt_DOT_Click(object sender, EventArgs e)
	{
		Application.Restart();
	}

	private void Butt_ok_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select   ListUser,Catégorie    From TABLE_PASS WHERE    ListPass = '" + Strings.Trim(Text_NUM.Text) + "'   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count != 0)
			{
				((Form)this).Close();
				Timer1.Enabled = false;
				Module1._USERNAME = Conversions.ToString(dataTable.Rows[0]["ListUser"]);
				Module1._USERCATEGORIE = Conversions.ToString(dataTable.Rows[0]["Catégorie"]);
				((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_CAISSIER).Text = Module1._USERNAME;
				Text_NUM.Text = "";
				((Control)Text_NUM).Focus();
				string right = "LOGIN RFID | ";
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				CREATION_ACCES();
				CREATION_RACCOURCIES();
			}
			else
			{
				Text_NUM.Text = "";
				((Control)Text_NUM).Focus();
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
		Text_NUM.Text = "";
		((Control)Text_NUM).Focus();
	}
}
