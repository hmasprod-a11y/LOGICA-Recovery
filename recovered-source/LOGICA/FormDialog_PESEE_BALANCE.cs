using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_PESEE_BALANCE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Radio_GRAMME")]
	private RadioButton _Radio_GRAMME;

	[AccessedThroughProperty("Radio_KG")]
	private RadioButton _Radio_KG;

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

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Text_TOTAL")]
	private TextBox _Text_TOTAL;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Text_PRIX_V")]
	private TextBox _Text_PRIX_V;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Text_BALANCE")]
	private TextBox _Text_BALANCE;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	internal virtual RadioButton Radio_GRAMME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_GRAMME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Radio_GRAMME = value;
		}
	}

	internal virtual RadioButton Radio_KG
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_KG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Radio_KG = value;
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

	internal virtual TextBox Text_TOTAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_TOTAL_TextChanged;
			EventHandler eventHandler2 = Text_TOTAL_LostFocus;
			EventHandler eventHandler3 = Text_TOTAL_GotFocus;
			KeyPressEventHandler val = Text_TOTAL_KeyPress;
			if (_Text_TOTAL != null)
			{
				((Control)_Text_TOTAL).TextChanged -= eventHandler;
				((Control)_Text_TOTAL).LostFocus -= eventHandler2;
				((Control)_Text_TOTAL).GotFocus -= eventHandler3;
				((Control)_Text_TOTAL).KeyPress -= val;
			}
			_Text_TOTAL = value;
			if (_Text_TOTAL != null)
			{
				((Control)_Text_TOTAL).TextChanged += eventHandler;
				((Control)_Text_TOTAL).LostFocus += eventHandler2;
				((Control)_Text_TOTAL).GotFocus += eventHandler3;
				((Control)_Text_TOTAL).KeyPress += val;
			}
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

	internal virtual TextBox Text_PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRIX_V = value;
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

	internal virtual TextBox Text_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_BALANCE_KeyPress;
			EventHandler eventHandler = Text_BALANCE_TextChanged;
			EventHandler eventHandler2 = Text_BALANCE_LostFocus;
			EventHandler eventHandler3 = Text_BALANCE_GotFocus;
			if (_Text_BALANCE != null)
			{
				((Control)_Text_BALANCE).KeyPress -= val;
				((Control)_Text_BALANCE).TextChanged -= eventHandler;
				((Control)_Text_BALANCE).LostFocus -= eventHandler2;
				((Control)_Text_BALANCE).GotFocus -= eventHandler3;
			}
			_Text_BALANCE = value;
			if (_Text_BALANCE != null)
			{
				((Control)_Text_BALANCE).KeyPress += val;
				((Control)_Text_BALANCE).TextChanged += eventHandler;
				((Control)_Text_BALANCE).LostFocus += eventHandler2;
				((Control)_Text_BALANCE).GotFocus += eventHandler3;
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

	[DebuggerNonUserCode]
	public FormDialog_PESEE_BALANCE()
	{
		((Form)this).Load += FormDialog_PESEE_BALANCE_Load;
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
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
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
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected Obj, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected Obj, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected Obj, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected Obj, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected Obj, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected Obj, but got Unknown
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Expected Obj, but got Unknown
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Unknown result type (might be due to invalid IL or missing references)
		//IL_119e: Expected Obj, but got Unknown
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected Obj, but got Unknown
		//IL_132e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1449: Unknown result type (might be due to invalid IL or missing references)
		//IL_1453: Expected Obj, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Expected Obj, but got Unknown
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1605: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected Obj, but got Unknown
		//IL_1739: Unknown result type (might be due to invalid IL or missing references)
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Expected Obj, but got Unknown
		//IL_1894: Unknown result type (might be due to invalid IL or missing references)
		//IL_189a: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b9: Expected Obj, but got Unknown
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa5: Expected Obj, but got Unknown
		//IL_1ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac1: Expected Obj, but got Unknown
		//IL_1b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Expected Obj, but got Unknown
		//IL_1b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b88: Expected Obj, but got Unknown
		//IL_1c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5d: Expected Obj, but got Unknown
		//IL_1c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8a: Expected Obj, but got Unknown
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc9: Expected Obj, but got Unknown
		//IL_1dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df6: Expected Obj, but got Unknown
		//IL_1e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Expected Obj, but got Unknown
		//IL_1f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f99: Expected Obj, but got Unknown
		//IL_2051: Unknown result type (might be due to invalid IL or missing references)
		//IL_205b: Expected Obj, but got Unknown
		//IL_2121: Unknown result type (might be due to invalid IL or missing references)
		//IL_212b: Expected Obj, but got Unknown
		//IL_21e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ea: Expected Obj, but got Unknown
		//IL_22af: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b9: Expected Obj, but got Unknown
		//IL_235e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2368: Expected Obj, but got Unknown
		//IL_2529: Unknown result type (might be due to invalid IL or missing references)
		//IL_2533: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_PESEE_BALANCE));
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Radio_GRAMME = new RadioButton();
		Radio_KG = new RadioButton();
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
		Label23 = new Label();
		Text_TOTAL = new TextBox();
		Label22 = new Label();
		Text_PRIX_V = new TextBox();
		Label21 = new Label();
		Text_BALANCE = new TextBox();
		Label1 = new Label();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		Point location = new Point(10, 492);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		Padding margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		Size size = new Size(155, 54);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 787;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(292, 492);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(155, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 786;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		Radio_GRAMME.Appearance = (Appearance)1;
		((Control)Radio_GRAMME).Cursor = Cursors.Hand;
		((ButtonBase)Radio_GRAMME).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)Radio_GRAMME).FlatStyle = (FlatStyle)0;
		((Control)Radio_GRAMME).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_GRAMME).ForeColor = Color.FromArgb(2, 45, 162);
		RadioButton radio_GRAMME = Radio_GRAMME;
		location = new Point(345, 7);
		((Control)radio_GRAMME).Location = location;
		((Control)Radio_GRAMME).Name = "Radio_GRAMME";
		RadioButton radio_GRAMME2 = Radio_GRAMME;
		size = new Size(121, 48);
		((Control)radio_GRAMME2).Size = size;
		((Control)Radio_GRAMME).TabIndex = 788;
		((ButtonBase)Radio_GRAMME).Text = "Gramme";
		Radio_GRAMME.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_GRAMME).UseVisualStyleBackColor = true;
		((Control)Radio_GRAMME).Visible = false;
		Radio_KG.Appearance = (Appearance)1;
		((Control)Radio_KG).Cursor = Cursors.Hand;
		((ButtonBase)Radio_KG).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)Radio_KG).FlatStyle = (FlatStyle)0;
		((Control)Radio_KG).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_KG).ForeColor = Color.FromArgb(2, 45, 162);
		RadioButton radio_KG = Radio_KG;
		location = new Point(345, 62);
		((Control)radio_KG).Location = location;
		((Control)Radio_KG).Name = "Radio_KG";
		RadioButton radio_KG2 = Radio_KG;
		size = new Size(121, 48);
		((Control)radio_KG2).Size = size;
		((Control)Radio_KG).TabIndex = 789;
		((ButtonBase)Radio_KG).Text = "Kg";
		Radio_KG.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_KG).UseVisualStyleBackColor = true;
		((Control)Radio_KG).Visible = false;
		((Control)Panel_CLAVIER).BackColor = Color.Black;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(10, 210);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(437, 276);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1079;
		((Control)TableLayoutPanel2).BackColor = Color.Black;
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
		size = new Size(366, 276);
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
		size = new Size(117, 66);
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
		size = new Size(117, 64);
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
		location = new Point(124, 139);
		((Control)butt_9).Location = location;
		Button_CLAVIER_NOSELECT butt_10 = Butt_2;
		margin = new Padding(2);
		((Control)butt_10).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_11 = Butt_2;
		margin = new Padding(1);
		((Control)butt_11).Padding = margin;
		Button_CLAVIER_NOSELECT butt_12 = Butt_2;
		size = new Size(117, 64);
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
		location = new Point(245, 139);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_3;
		margin = new Padding(2);
		((Control)butt_14).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_15 = Butt_3;
		margin = new Padding(1);
		((Control)butt_15).Padding = margin;
		Button_CLAVIER_NOSELECT butt_16 = Butt_3;
		size = new Size(118, 64);
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
		size = new Size(117, 64);
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
		location = new Point(124, 71);
		((Control)butt_21).Location = location;
		Button_CLAVIER_NOSELECT butt_22 = Butt_5;
		margin = new Padding(2);
		((Control)butt_22).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_23 = Butt_5;
		margin = new Padding(1);
		((Control)butt_23).Padding = margin;
		Button_CLAVIER_NOSELECT butt_24 = Butt_5;
		size = new Size(117, 64);
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
		location = new Point(245, 71);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_6;
		margin = new Padding(2);
		((Control)butt_26).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_27 = Butt_6;
		margin = new Padding(1);
		((Control)butt_27).Padding = margin;
		Button_CLAVIER_NOSELECT butt_28 = Butt_6;
		size = new Size(118, 64);
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
		size = new Size(117, 64);
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
		location = new Point(124, 3);
		((Control)butt_33).Location = location;
		Button_CLAVIER_NOSELECT butt_34 = Butt_8;
		margin = new Padding(2);
		((Control)butt_34).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_35 = Butt_8;
		margin = new Padding(1);
		((Control)butt_35).Padding = margin;
		Button_CLAVIER_NOSELECT butt_36 = Butt_8;
		size = new Size(117, 64);
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
		location = new Point(124, 207);
		((Control)butt_37).Location = location;
		Button_CLAVIER_NOSELECT butt_38 = Butt_0;
		margin = new Padding(2);
		((Control)butt_38).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_39 = Butt_0;
		margin = new Padding(1);
		((Control)butt_39).Padding = margin;
		Button_CLAVIER_NOSELECT butt_40 = Butt_0;
		size = new Size(117, 66);
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
		location = new Point(245, 3);
		((Control)butt_41).Location = location;
		Button_CLAVIER_NOSELECT butt_42 = Butt_9;
		margin = new Padding(2);
		((Control)butt_42).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_43 = Butt_9;
		margin = new Padding(1);
		((Control)butt_43).Padding = margin;
		Button_CLAVIER_NOSELECT butt_44 = Butt_9;
		size = new Size(118, 64);
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
		location = new Point(245, 207);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(2);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		margin = new Padding(1);
		((Control)butt_DOT3).Padding = margin;
		Button_CLAVIER_NOSELECT butt_DOT4 = Butt_DOT;
		size = new Size(118, 66);
		((Control)butt_DOT4).Size = size;
		((Control)Butt_DOT).TabIndex = 790;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel1).BackColor = Color.Black;
		TableLayoutPanel1.ColumnCount = 2;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)1, 69f));
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_DRAFT, 1, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_BACK, 1, 0);
		((Control)TableLayoutPanel1).Dock = (DockStyle)4;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel1;
		location = new Point(366, 0);
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
		((Control)Label23).BackColor = Color.Black;
		Label23.BorderStyle = (BorderStyle)2;
		((Control)Label23).Font = new Font("Segoe UI", 22.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label = Label23;
		location = new Point(10, 141);
		((Control)label).Location = location;
		((Control)Label23).Name = "Label23";
		Label label2 = Label23;
		size = new Size(120, 66);
		((Control)label2).Size = size;
		((Control)Label23).TabIndex = 1085;
		Label23.Text = "Total";
		Label23.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_TOTAL).BackColor = Color.Black;
		((TextBoxBase)Text_TOTAL).BorderStyle = (BorderStyle)1;
		((Control)Text_TOTAL).Cursor = Cursors.Hand;
		((Control)Text_TOTAL).Font = new Font("Tahoma", 36.25f, (FontStyle)1);
		((TextBoxBase)Text_TOTAL).ForeColor = Color.Yellow;
		TextBox text_TOTAL = Text_TOTAL;
		location = new Point(126, 141);
		((Control)text_TOTAL).Location = location;
		((Control)Text_TOTAL).Name = "Text_TOTAL";
		((TextBoxBase)Text_TOTAL).ReadOnly = true;
		TextBox text_TOTAL2 = Text_TOTAL;
		size = new Size(322, 66);
		((Control)text_TOTAL2).Size = size;
		((Control)Text_TOTAL).TabIndex = 1084;
		Text_TOTAL.TextAlign = (HorizontalAlignment)2;
		((Control)Label22).BackColor = Color.Black;
		Label22.BorderStyle = (BorderStyle)2;
		((Control)Label22).Font = new Font("Segoe UI", 22.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label3 = Label22;
		location = new Point(10, 75);
		((Control)label3).Location = location;
		((Control)Label22).Name = "Label22";
		Label label4 = Label22;
		size = new Size(120, 66);
		((Control)label4).Size = size;
		((Control)Label22).TabIndex = 1083;
		Label22.Text = "Prix ";
		Label22.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_PRIX_V).BackColor = Color.Black;
		((TextBoxBase)Text_PRIX_V).BorderStyle = (BorderStyle)1;
		((Control)Text_PRIX_V).Cursor = Cursors.Hand;
		((Control)Text_PRIX_V).Font = new Font("Tahoma", 36.25f, (FontStyle)1);
		((TextBoxBase)Text_PRIX_V).ForeColor = Color.Yellow;
		TextBox text_PRIX_V = Text_PRIX_V;
		location = new Point(126, 75);
		((Control)text_PRIX_V).Location = location;
		((Control)Text_PRIX_V).Name = "Text_PRIX_V";
		((TextBoxBase)Text_PRIX_V).ReadOnly = true;
		TextBox text_PRIX_V2 = Text_PRIX_V;
		size = new Size(322, 66);
		((Control)text_PRIX_V2).Size = size;
		((Control)Text_PRIX_V).TabIndex = 1082;
		Text_PRIX_V.TextAlign = (HorizontalAlignment)2;
		((Control)Label21).BackColor = Color.Black;
		Label21.BorderStyle = (BorderStyle)2;
		((Control)Label21).Font = new Font("Segoe UI", 22.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label5 = Label21;
		location = new Point(10, 7);
		((Control)label5).Location = location;
		((Control)Label21).Name = "Label21";
		Label label6 = Label21;
		size = new Size(120, 66);
		((Control)label6).Size = size;
		((Control)Label21).TabIndex = 1081;
		Label21.Text = "Poids";
		Label21.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_BALANCE).BackColor = Color.Black;
		((TextBoxBase)Text_BALANCE).BorderStyle = (BorderStyle)1;
		((Control)Text_BALANCE).Cursor = Cursors.Hand;
		((Control)Text_BALANCE).Font = new Font("Tahoma", 36.25f, (FontStyle)1);
		((TextBoxBase)Text_BALANCE).ForeColor = Color.Yellow;
		TextBox text_BALANCE = Text_BALANCE;
		location = new Point(126, 7);
		((Control)text_BALANCE).Location = location;
		((Control)Text_BALANCE).Name = "Text_BALANCE";
		((TextBoxBase)Text_BALANCE).ReadOnly = true;
		TextBox text_BALANCE2 = Text_BALANCE;
		size = new Size(322, 66);
		((Control)text_BALANCE2).Size = size;
		((Control)Text_BALANCE).TabIndex = 1080;
		Text_BALANCE.TextAlign = (HorizontalAlignment)2;
		((Control)Label1).BackColor = Color.Black;
		((Control)Label1).Font = new Font("Segoe UI", 12.2f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.White;
		Label label7 = Label1;
		location = new Point(82, 89);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(44, 46);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 1083;
		Label1.Text = "(Kg)";
		Label1.TextAlign = (ContentAlignment)16;
		Label1.UseCompatibleTextRendering = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(453, 553);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Radio_GRAMME);
		((Control)this).Controls.Add((Control)(object)Radio_KG);
		((Control)this).Controls.Add((Control)(object)Label23);
		((Control)this).Controls.Add((Control)(object)Text_TOTAL);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Label22);
		((Control)this).Controls.Add((Control)(object)Text_PRIX_V);
		((Control)this).Controls.Add((Control)(object)Label21);
		((Control)this).Controls.Add((Control)(object)Text_BALANCE);
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Button_CLOSE);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_PESEE_BALANCE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "PESEE";
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void FormDialog_PESEE_BALANCE_Load(object sender, EventArgs e)
	{
		Text_BALANCE.Text = "";
		Text_TOTAL.Text = "";
		Radio_KG.Checked = true;
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		if (Versioned.IsNumeric(Text_BALANCE.Text) && Versioned.IsNumeric(Text_TOTAL.Text) && decimal.Compare(Conversions.ToDecimal(Text_TOTAL.Text), 0m) != 0)
		{
			if (Radio_GRAMME.Checked)
			{
				MyProject.Forms.Form_3_VENTE.Label_QTE.Text = Conversions.ToString(Conversions.ToDouble(Text_BALANCE.Text) / 1000.0);
			}
			else if (Radio_KG.Checked)
			{
				MyProject.Forms.Form_3_VENTE.Label_QTE.Text = Text_BALANCE.Text;
			}
			Module1._quitter_pesee = false;
			((Form)this).Close();
		}
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		Module1._quitter_pesee = true;
		((Form)this).Close();
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		if (((Control)Text_BALANCE).Focused)
		{
			Text_BALANCE.Text = Conversions.ToString(Operators.AddObject(Text_BALANCE.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
		}
		else if (((Control)Text_TOTAL).Focused)
		{
			Text_TOTAL.Text = Conversions.ToString(Operators.AddObject(Text_TOTAL.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
		}
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
				case 195:
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
							goto IL_001a;
						case 5:
							goto IL_004c;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 7:
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num2 = 2;
					if (((Control)Text_BALANCE).Focused)
					{
						goto IL_001a;
					}
					goto IL_004c;
					IL_001a:
					num2 = 3;
					Text_BALANCE.Text = Text_BALANCE.Text.Remove(checked(Text_BALANCE.Text.Length - 1));
					goto end_IL_0001_3;
					IL_004c:
					num2 = 5;
					if (!((Control)Text_TOTAL).Focused)
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 6;
				Text_TOTAL.Text = Text_TOTAL.Text.Remove(checked(Text_TOTAL.Text.Length - 1));
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 195;
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
		if (((Control)Text_BALANCE).Focused)
		{
			Text_BALANCE.Text = "";
		}
		else if (((Control)Text_TOTAL).Focused)
		{
			Text_TOTAL.Text = "";
		}
	}

	private void Text_BALANCE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_BALANCE_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
		NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.Black }, null, null);
	}

	private void Text_BALANCE_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Black }, null, null);
		NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.White }, null, null);
	}

	private void Text_BALANCE_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default;
		Color color = default;
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
					object obj = NewLateBinding.LateGet(sender, null, "BackColor", new object[0], null, null, null);
					if (((obj != null) ? ((Color)obj) : color) == Color.Yellow)
					{
						if (!Versioned.IsNumeric(Text_BALANCE.Text))
						{
							Text_TOTAL.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PRIX_V.Text) * 0.0)));
						}
						else
						{
							Text_TOTAL.Text = Math.Round(new decimal(Conversions.ToDouble(Text_PRIX_V.Text) * Conversions.ToDouble(Text_BALANCE.Text)), 3, MidpointRounding.AwayFromZero).ToString("N3");
						}
					}
					goto end_IL_0001;
				}
				case 245:
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
				try0001_dispatch = 245;
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

	private void Text_TOTAL_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_TOTAL_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
		NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.Black }, null, null);
	}

	private void Text_TOTAL_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Black }, null, null);
		NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.White }, null, null);
	}

	private void Text_TOTAL_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default;
		Color color = default;
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
					object obj = NewLateBinding.LateGet(sender, null, "BackColor", new object[0], null, null, null);
					if (((obj != null) ? ((Color)obj) : color) == Color.Yellow)
					{
						if (!Versioned.IsNumeric(Text_TOTAL.Text))
						{
							Text_BALANCE.Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversions.ToDouble(Text_PRIX_V.Text) * 0.0)));
						}
						else
						{
							Text_BALANCE.Text = Math.Round(new decimal(Conversions.ToDouble(Text_TOTAL.Text) / Conversions.ToDouble(Text_PRIX_V.Text)), 4, MidpointRounding.AwayFromZero).ToString("N4");
						}
					}
					goto end_IL_0001;
				}
				case 245:
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
				try0001_dispatch = 245;
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
