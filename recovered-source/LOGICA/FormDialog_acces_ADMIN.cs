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
public class FormDialog_acces_ADMIN : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Text_NUM")]
	private TextBox _Text_NUM;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Butt_")]
	private Button_CLAVIER_NOSELECT _Butt_;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Butt_DRAFT")]
	private Button_CLAVIER_NOSELECT _Butt_DRAFT;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

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
			KeyPressEventHandler val = Text_NUM_KeyPress;
			KeyEventHandler val2 = Text_NUM_KeyDown;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyPress -= val;
				((Control)_Text_NUM).KeyDown -= val2;
			}
			_Text_NUM = value;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyPress += val;
				((Control)_Text_NUM).KeyDown += val2;
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

	[DebuggerNonUserCode]
	public FormDialog_acces_ADMIN()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_acces_ADMIN_Load;
		((Form)this).Shown += FormDialog_acces_ADMIN_Shown;
		((Control)this).KeyDown += me_KeyDown;
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
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
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
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Obj, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected Obj, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected Obj, but got Unknown
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected Obj, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected Obj, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected Obj, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got Unknown
		//IL_1051: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cf: Expected Obj, but got Unknown
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_132e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Expected Obj, but got Unknown
		//IL_145d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1578: Unknown result type (might be due to invalid IL or missing references)
		//IL_1582: Expected Obj, but got Unknown
		//IL_15b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16da: Expected Obj, but got Unknown
		//IL_1711: Unknown result type (might be due to invalid IL or missing references)
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_1739: Unknown result type (might be due to invalid IL or missing references)
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_182c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1836: Expected Obj, but got Unknown
		//IL_186c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Unknown result type (might be due to invalid IL or missing references)
		//IL_1894: Unknown result type (might be due to invalid IL or missing references)
		//IL_189a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1987: Unknown result type (might be due to invalid IL or missing references)
		//IL_1991: Expected Obj, but got Unknown
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8c: Expected Obj, but got Unknown
		//IL_1a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa8: Expected Obj, but got Unknown
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b53: Expected Obj, but got Unknown
		//IL_1b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected Obj, but got Unknown
		//IL_1c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c44: Expected Obj, but got Unknown
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c71: Expected Obj, but got Unknown
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db0: Expected Obj, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected Obj, but got Unknown
		//IL_1e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3e: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_acces_ADMIN));
		PictureBox1 = new PictureBox();
		Label28 = new Label();
		Text_NUM = new TextBox();
		Timer1 = new System.Windows.Forms.Timer(components);
		Button_SAVE = new Button();
		Button_CLOSE = new Button();
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		Butt_ = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		TableLayoutPanel1 = new TableLayoutPanel();
		Butt_DRAFT = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(107, 24);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(186, 158);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		Label28.AutoSize = true;
		((Control)Label28).BackColor = Color.Transparent;
		((Control)Label28).Font = new Font("Cambria", 12f);
		((Control)Label28).ForeColor = Color.FromArgb(2, 45, 162);
		Label label = Label28;
		location = new Point(83, 2);
		((Control)label).Location = location;
		((Control)Label28).Name = "Label28";
		Label label2 = Label28;
		size = new Size(235, 19);
		((Control)label2).Size = size;
		((Control)Label28).TabIndex = 703;
		Label28.Text = "Veuillez saisir votre code ADMIN";
		((TextBoxBase)Text_NUM).BorderStyle = (BorderStyle)0;
		((Control)Text_NUM).Font = new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox text_NUM = Text_NUM;
		location = new Point(35, 186);
		((Control)text_NUM).Location = location;
		((Control)Text_NUM).Name = "Text_NUM";
		Text_NUM.PasswordChar = '●';
		TextBox text_NUM2 = Text_NUM;
		size = new Size(331, 29);
		((Control)text_NUM2).Size = size;
		((Control)Text_NUM).TabIndex = 32;
		Text_NUM.TextAlign = (HorizontalAlignment)2;
		Timer1.Interval = 3000;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(219, 512);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		Padding margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(155, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1059;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(26, 512);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(155, 54);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 1060;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((Control)Panel_CLAVIER).BackColor = Color.Black;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(26, 221);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(348, 276);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1068;
		((Control)TableLayoutPanel2).BackColor = Color.FromArgb(167, 197, 237);
		TableLayoutPanel2.ColumnCount = 3;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_, 0, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_1, 0, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_2, 1, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_3, 2, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_4, 0, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_5, 1, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_6, 2, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_7, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_8, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_0, 1, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_9, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_DOT, 2, 3);
		((Control)TableLayoutPanel2).Dock = (DockStyle)5;
		((Control)TableLayoutPanel2).ForeColor = Color.Black;
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel2;
		location = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel2;
		margin = new Padding(1);
		((Control)tableLayoutPanel2).Padding = margin;
		TableLayoutPanel2.RowCount = 4;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel2;
		size = new Size(277, 276);
		((Control)tableLayoutPanel3).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1052;
		((ButtonBase)Butt_).BackColor = Color.White;
		((Control)Butt_).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_).Cursor = Cursors.Hand;
		((Control)Butt_).Dock = (DockStyle)5;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_).FlatStyle = (FlatStyle)0;
		((Control)Butt_).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_ = Butt_;
		location = new Point(3, 207);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_;
		margin = new Padding(2);
		((Control)butt_2).Margin = margin;
		((Control)Butt_).Name = "Butt_";
		Button_CLAVIER_NOSELECT butt_3 = Butt_;
		margin = new Padding(1);
		((Control)butt_3).Padding = margin;
		Button_CLAVIER_NOSELECT butt_4 = Butt_;
		size = new Size(87, 66);
		((Control)butt_4).Size = size;
		((Control)Butt_).TabIndex = 791;
		((ButtonBase)Butt_).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.White;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((Control)Butt_1).Dock = (DockStyle)5;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_1).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_5 = Butt_1;
		location = new Point(3, 139);
		((Control)butt_5).Location = location;
		Button_CLAVIER_NOSELECT butt_6 = Butt_1;
		margin = new Padding(2);
		((Control)butt_6).Margin = margin;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_7 = Butt_1;
		margin = new Padding(1);
		((Control)butt_7).Padding = margin;
		Button_CLAVIER_NOSELECT butt_8 = Butt_1;
		size = new Size(87, 64);
		((Control)butt_8).Size = size;
		((Control)Butt_1).TabIndex = 775;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.White;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((Control)Butt_2).Dock = (DockStyle)5;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_2).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_9 = Butt_2;
		location = new Point(94, 139);
		((Control)butt_9).Location = location;
		Button_CLAVIER_NOSELECT butt_10 = Butt_2;
		margin = new Padding(2);
		((Control)butt_10).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_11 = Butt_2;
		margin = new Padding(1);
		((Control)butt_11).Padding = margin;
		Button_CLAVIER_NOSELECT butt_12 = Butt_2;
		size = new Size(87, 64);
		((Control)butt_12).Size = size;
		((Control)Butt_2).TabIndex = 774;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.White;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((Control)Butt_3).Dock = (DockStyle)5;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_3).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_13 = Butt_3;
		location = new Point(185, 139);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_3;
		margin = new Padding(2);
		((Control)butt_14).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_15 = Butt_3;
		margin = new Padding(1);
		((Control)butt_15).Padding = margin;
		Button_CLAVIER_NOSELECT butt_16 = Butt_3;
		size = new Size(89, 64);
		((Control)butt_16).Size = size;
		((Control)Butt_3).TabIndex = 777;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.White;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((Control)Butt_4).Dock = (DockStyle)5;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_4).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_17 = Butt_4;
		location = new Point(3, 71);
		((Control)butt_17).Location = location;
		Button_CLAVIER_NOSELECT butt_18 = Butt_4;
		margin = new Padding(2);
		((Control)butt_18).Margin = margin;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_19 = Butt_4;
		margin = new Padding(1);
		((Control)butt_19).Padding = margin;
		Button_CLAVIER_NOSELECT butt_20 = Butt_4;
		size = new Size(87, 64);
		((Control)butt_20).Size = size;
		((Control)Butt_4).TabIndex = 779;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.White;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((Control)Butt_5).Dock = (DockStyle)5;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_5).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_21 = Butt_5;
		location = new Point(94, 71);
		((Control)butt_21).Location = location;
		Button_CLAVIER_NOSELECT butt_22 = Butt_5;
		margin = new Padding(2);
		((Control)butt_22).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_23 = Butt_5;
		margin = new Padding(1);
		((Control)butt_23).Padding = margin;
		Button_CLAVIER_NOSELECT butt_24 = Butt_5;
		size = new Size(87, 64);
		((Control)butt_24).Size = size;
		((Control)Butt_5).TabIndex = 778;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.White;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((Control)Butt_6).Dock = (DockStyle)5;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_6).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_25 = Butt_6;
		location = new Point(185, 71);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_6;
		margin = new Padding(2);
		((Control)butt_26).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_27 = Butt_6;
		margin = new Padding(1);
		((Control)butt_27).Padding = margin;
		Button_CLAVIER_NOSELECT butt_28 = Butt_6;
		size = new Size(89, 64);
		((Control)butt_28).Size = size;
		((Control)Butt_6).TabIndex = 780;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.White;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((Control)Butt_7).Dock = (DockStyle)5;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_7).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_29 = Butt_7;
		location = new Point(3, 3);
		((Control)butt_29).Location = location;
		Button_CLAVIER_NOSELECT butt_30 = Butt_7;
		margin = new Padding(2);
		((Control)butt_30).Margin = margin;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_31 = Butt_7;
		margin = new Padding(1);
		((Control)butt_31).Padding = margin;
		Button_CLAVIER_NOSELECT butt_32 = Butt_7;
		size = new Size(87, 64);
		((Control)butt_32).Size = size;
		((Control)Butt_7).TabIndex = 781;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.White;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((Control)Butt_8).Dock = (DockStyle)5;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_8).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_33 = Butt_8;
		location = new Point(94, 3);
		((Control)butt_33).Location = location;
		Button_CLAVIER_NOSELECT butt_34 = Butt_8;
		margin = new Padding(2);
		((Control)butt_34).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_35 = Butt_8;
		margin = new Padding(1);
		((Control)butt_35).Padding = margin;
		Button_CLAVIER_NOSELECT butt_36 = Butt_8;
		size = new Size(87, 64);
		((Control)butt_36).Size = size;
		((Control)Butt_8).TabIndex = 783;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.White;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((Control)Butt_0).Dock = (DockStyle)5;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_0).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_37 = Butt_0;
		location = new Point(94, 207);
		((Control)butt_37).Location = location;
		Button_CLAVIER_NOSELECT butt_38 = Butt_0;
		margin = new Padding(2);
		((Control)butt_38).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_39 = Butt_0;
		margin = new Padding(1);
		((Control)butt_39).Padding = margin;
		Button_CLAVIER_NOSELECT butt_40 = Butt_0;
		size = new Size(87, 66);
		((Control)butt_40).Size = size;
		((Control)Butt_0).TabIndex = 784;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.White;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((Control)Butt_9).Dock = (DockStyle)5;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_9).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_41 = Butt_9;
		location = new Point(185, 3);
		((Control)butt_41).Location = location;
		Button_CLAVIER_NOSELECT butt_42 = Butt_9;
		margin = new Padding(2);
		((Control)butt_42).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_43 = Butt_9;
		margin = new Padding(1);
		((Control)butt_43).Padding = margin;
		Button_CLAVIER_NOSELECT butt_44 = Butt_9;
		size = new Size(89, 64);
		((Control)butt_44).Size = size;
		((Control)Butt_9).TabIndex = 782;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.White;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((Control)Butt_DOT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_DOT).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(185, 207);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(2);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		margin = new Padding(1);
		((Control)butt_DOT3).Padding = margin;
		Button_CLAVIER_NOSELECT butt_DOT4 = Butt_DOT;
		size = new Size(89, 66);
		((Control)butt_DOT4).Size = size;
		((Control)Butt_DOT).TabIndex = 790;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel1).BackColor = Color.FromArgb(167, 197, 237);
		TableLayoutPanel1.ColumnCount = 2;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)1, 69f));
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_DRAFT, 1, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_BACK, 1, 0);
		((Control)TableLayoutPanel1).Dock = (DockStyle)4;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel1;
		location = new Point(277, 0);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel1;
		margin = new Padding(1);
		((Control)tableLayoutPanel5).Padding = margin;
		TableLayoutPanel1.RowCount = 2;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel tableLayoutPanel6 = TableLayoutPanel1;
		size = new Size(71, 276);
		((Control)tableLayoutPanel6).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 1053;
		((ButtonBase)Butt_DRAFT).BackColor = Color.White;
		((Control)Butt_DRAFT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((Control)Butt_DRAFT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DRAFT).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_DRAFT).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_DRAFT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DRAFT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_DRAFT).ForeColor = Color.Black;
		((ButtonBase)Butt_DRAFT).Image = (Image)componentResourceManager.GetObject("Butt_DRAFT.Image");
		Button_CLAVIER_NOSELECT butt_DRAFT = Butt_DRAFT;
		location = new Point(1, 141);
		((Control)butt_DRAFT).Location = location;
		Button_CLAVIER_NOSELECT butt_DRAFT2 = Butt_DRAFT;
		margin = new Padding(0, 3, 3, 3);
		((Control)butt_DRAFT2).Margin = margin;
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		Button_CLAVIER_NOSELECT butt_DRAFT3 = Butt_DRAFT;
		margin = new Padding(1);
		((Control)butt_DRAFT3).Padding = margin;
		Button_CLAVIER_NOSELECT butt_DRAFT4 = Butt_DRAFT;
		size = new Size(66, 131);
		((Control)butt_DRAFT4).Size = size;
		((Control)Butt_DRAFT).TabIndex = 771;
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.White;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((Control)Butt_BACK).Dock = (DockStyle)5;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatAppearance.MouseDownBackColor = Color.Yellow;
		((ButtonBase)Butt_BACK).FlatAppearance.MouseOverBackColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.Black;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(1, 4);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		margin = new Padding(0, 3, 3, 3);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		margin = new Padding(1);
		((Control)butt_BACK3).Padding = margin;
		Button_CLAVIER_NOSELECT butt_BACK4 = Butt_BACK;
		size = new Size(66, 131);
		((Control)butt_BACK4).Size = size;
		((Control)Butt_BACK).TabIndex = 770;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(401, 575);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Button_CLOSE);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Control)this).Controls.Add((Control)(object)Text_NUM);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Label28);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_acces_ADMIN";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
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

	private void FormDialog_acces_ADMIN_Load(object sender, EventArgs e)
	{
		((Control)Text_NUM).Focus();
		Timer1.Enabled = true;
	}

	private void FormDialog_acces_ADMIN_Shown(object sender, EventArgs e)
	{
		((Control)Text_NUM).Focus();
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
				Button_SAVE_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select    ID     From TABLE_PASS WHERE    ListPass = '" + Strings.Trim(Text_NUM.Text) + "' and  Catégorie = 'ADMIN'   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count != 0)
			{
				((Form)this).Close();
				Timer1.Enabled = false;
				Text_NUM.Text = "";
				((Control)Text_NUM).Focus();
				Module1._acces = true;
			}
			else
			{
				Text_NUM.Text = "";
				((Control)Text_NUM).Focus();
			}
			dataTable.Clear();
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
		Text_NUM.Text = "";
		((Control)Text_NUM).Focus();
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		Module1._acces = false;
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(Operators.AddObject(Text_NUM.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
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
				Text_NUM.Text = Text_NUM.Text.Remove(checked(Text_NUM.Text.Length - 1));
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

	private void Butt_DRAFT_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = "";
	}
}
