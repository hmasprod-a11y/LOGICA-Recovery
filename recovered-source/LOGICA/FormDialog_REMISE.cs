using System;
using System.Collections.Generic;
using System.ComponentModel;
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
public class FormDialog_REMISE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("RadioButton_GLOBALE")]
	private RadioButton _RadioButton_GLOBALE;

	[AccessedThroughProperty("RadioButton_ARTICLE")]
	private RadioButton _RadioButton_ARTICLE;

	[AccessedThroughProperty("Text_NUM")]
	private TextBox _Text_NUM;

	[AccessedThroughProperty("Button39")]
	private Button _Button39;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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

	[AccessedThroughProperty("RadioButton_DH")]
	private RadioButton _RadioButton_DH;

	[AccessedThroughProperty("RadioButton_POURCENTAGE")]
	private RadioButton _RadioButton_POURCENTAGE;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	internal virtual RadioButton RadioButton_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton_GLOBALE = value;
		}
	}

	internal virtual RadioButton RadioButton_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton_ARTICLE = value;
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
			KeyPressEventHandler val = TextBox9_KeyPress;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyPress -= val;
			}
			_Text_NUM = value;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).KeyPress += val;
			}
		}
	}

	internal virtual Button Button39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button39_Click;
			if (_Button39 != null)
			{
				((Control)_Button39).Click -= eventHandler;
			}
			_Button39 = value;
			if (_Button39 != null)
			{
				((Control)_Button39).Click += eventHandler;
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

	internal virtual RadioButton RadioButton_DH
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_DH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton_DH_CheckedChanged;
			if (_RadioButton_DH != null)
			{
				_RadioButton_DH.CheckedChanged -= eventHandler;
			}
			_RadioButton_DH = value;
			if (_RadioButton_DH != null)
			{
				_RadioButton_DH.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton RadioButton_POURCENTAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_POURCENTAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton_POURCENTAGE_CheckedChanged;
			if (_RadioButton_POURCENTAGE != null)
			{
				_RadioButton_POURCENTAGE.CheckedChanged -= eventHandler;
			}
			_RadioButton_POURCENTAGE = value;
			if (_RadioButton_POURCENTAGE != null)
			{
				_RadioButton_POURCENTAGE.CheckedChanged += eventHandler;
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

	[DebuggerNonUserCode]
	public FormDialog_REMISE()
	{
		((Form)this).Load += FormDialog_REMISE_Load;
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
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
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected Obj, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected Obj, but got Unknown
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected Obj, but got Unknown
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected Obj, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got Unknown
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Expected Obj, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Unknown result type (might be due to invalid IL or missing references)
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected Obj, but got Unknown
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected Obj, but got Unknown
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected Obj, but got Unknown
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497: Unknown result type (might be due to invalid IL or missing references)
		//IL_149d: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Expected Obj, but got Unknown
		//IL_15c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16eb: Expected Obj, but got Unknown
		//IL_171e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Unknown result type (might be due to invalid IL or missing references)
		//IL_1746: Unknown result type (might be due to invalid IL or missing references)
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Expected Obj, but got Unknown
		//IL_187a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_199f: Expected Obj, but got Unknown
		//IL_19d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afa: Expected Obj, but got Unknown
		//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf5: Expected Obj, but got Unknown
		//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c11: Expected Obj, but got Unknown
		//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbc: Expected Obj, but got Unknown
		//IL_1cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd8: Expected Obj, but got Unknown
		//IL_1da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Expected Obj, but got Unknown
		//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dda: Expected Obj, but got Unknown
		//IL_1e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f19: Expected Obj, but got Unknown
		//IL_1f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f46: Expected Obj, but got Unknown
		//IL_1f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Expected Obj, but got Unknown
		//IL_2071: Unknown result type (might be due to invalid IL or missing references)
		//IL_2077: Unknown result type (might be due to invalid IL or missing references)
		//IL_2139: Unknown result type (might be due to invalid IL or missing references)
		//IL_2143: Expected Obj, but got Unknown
		//IL_217e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2184: Unknown result type (might be due to invalid IL or missing references)
		//IL_2234: Unknown result type (might be due to invalid IL or missing references)
		//IL_223e: Expected Obj, but got Unknown
		//IL_2261: Unknown result type (might be due to invalid IL or missing references)
		//IL_226b: Expected Obj, but got Unknown
		//IL_229f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2353: Unknown result type (might be due to invalid IL or missing references)
		//IL_235d: Expected Obj, but got Unknown
		//IL_2380: Unknown result type (might be due to invalid IL or missing references)
		//IL_238a: Expected Obj, but got Unknown
		//IL_23c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2508: Unknown result type (might be due to invalid IL or missing references)
		//IL_2512: Expected Obj, but got Unknown
		//IL_253d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2547: Expected Obj, but got Unknown
		//IL_26e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26eb: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_REMISE));
		RadioButton_GLOBALE = new RadioButton();
		RadioButton_ARTICLE = new RadioButton();
		Text_NUM = new TextBox();
		Button1 = new Button();
		Button39 = new Button();
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
		RadioButton_DH = new RadioButton();
		RadioButton_POURCENTAGE = new RadioButton();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Panel1 = new Panel();
		Button2 = new Button();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		RadioButton_GLOBALE.Appearance = (Appearance)1;
		((Control)RadioButton_GLOBALE).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_GLOBALE).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton_GLOBALE).FlatStyle = (FlatStyle)0;
		((Control)RadioButton_GLOBALE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)RadioButton_GLOBALE).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)RadioButton_GLOBALE).Image = (Image)componentResourceManager.GetObject("RadioButton_GLOBALE.Image");
		((ButtonBase)RadioButton_GLOBALE).ImageAlign = (ContentAlignment)16;
		RadioButton radioButton_GLOBALE = RadioButton_GLOBALE;
		Point location = new Point(190, 12);
		((Control)radioButton_GLOBALE).Location = location;
		RadioButton radioButton_GLOBALE2 = RadioButton_GLOBALE;
		Padding margin = new Padding(0);
		((Control)radioButton_GLOBALE2).Margin = margin;
		((Control)RadioButton_GLOBALE).Name = "RadioButton_GLOBALE";
		RadioButton radioButton_GLOBALE3 = RadioButton_GLOBALE;
		Size size = new Size(170, 48);
		((Control)radioButton_GLOBALE3).Size = size;
		((Control)RadioButton_GLOBALE).TabIndex = 694;
		((ButtonBase)RadioButton_GLOBALE).Text = "Remise Globale";
		RadioButton_GLOBALE.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton_GLOBALE).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)RadioButton_GLOBALE).UseVisualStyleBackColor = true;
		RadioButton_ARTICLE.Appearance = (Appearance)1;
		((Control)RadioButton_ARTICLE).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_ARTICLE).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton_ARTICLE).FlatStyle = (FlatStyle)0;
		((Control)RadioButton_ARTICLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)RadioButton_ARTICLE).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)RadioButton_ARTICLE).Image = (Image)componentResourceManager.GetObject("RadioButton_ARTICLE.Image");
		((ButtonBase)RadioButton_ARTICLE).ImageAlign = (ContentAlignment)16;
		RadioButton radioButton_ARTICLE = RadioButton_ARTICLE;
		location = new Point(12, 12);
		((Control)radioButton_ARTICLE).Location = location;
		RadioButton radioButton_ARTICLE2 = RadioButton_ARTICLE;
		margin = new Padding(0);
		((Control)radioButton_ARTICLE2).Margin = margin;
		((Control)RadioButton_ARTICLE).Name = "RadioButton_ARTICLE";
		RadioButton radioButton_ARTICLE3 = RadioButton_ARTICLE;
		size = new Size(170, 48);
		((Control)radioButton_ARTICLE3).Size = size;
		((Control)RadioButton_ARTICLE).TabIndex = 693;
		((ButtonBase)RadioButton_ARTICLE).Text = "Remise Article";
		RadioButton_ARTICLE.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton_ARTICLE).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)RadioButton_ARTICLE).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_NUM).BorderStyle = (BorderStyle)1;
		((Control)Text_NUM).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		TextBox text_NUM = Text_NUM;
		location = new Point(12, 94);
		((Control)text_NUM).Location = location;
		((Control)Text_NUM).Name = "Text_NUM";
		TextBox text_NUM2 = Text_NUM;
		size = new Size(348, 33);
		((Control)text_NUM2).Size = size;
		((Control)Text_NUM).TabIndex = 691;
		((ButtonBase)Button1).BackColor = Color.White;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatAppearance.BorderColor = Color.FromArgb(167, 197, 237);
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Calibri", 12.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button = Button1;
		location = new Point(197, 411);
		((Control)button).Location = location;
		((Control)Button1).Name = "Button1";
		Button button2 = Button1;
		size = new Size(163, 44);
		((Control)button2).Size = size;
		((Control)Button1).TabIndex = 700;
		((ButtonBase)Button1).Text = "         Ticket Offert";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((ButtonBase)Button39).BackColor = Color.White;
		((Control)Button39).Cursor = Cursors.Hand;
		((ButtonBase)Button39).FlatAppearance.BorderColor = Color.FromArgb(167, 197, 237);
		((ButtonBase)Button39).FlatStyle = (FlatStyle)0;
		((Control)Button39).Font = new Font("Calibri", 12.25f, (FontStyle)1);
		((Control)Button39).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button39).Image = (Image)componentResourceManager.GetObject("Button39.Image");
		((ButtonBase)Button39).ImageAlign = (ContentAlignment)16;
		Button button3 = Button39;
		location = new Point(12, 411);
		((Control)button3).Location = location;
		((Control)Button39).Name = "Button39";
		Button button4 = Button39;
		size = new Size(181, 44);
		((Control)button4).Size = size;
		((Control)Button39).TabIndex = 688;
		((ButtonBase)Button39).Text = "         Article Offert";
		((ButtonBase)Button39).UseVisualStyleBackColor = false;
		((Control)Panel_CLAVIER).BackColor = Color.Black;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(12, 129);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(348, 276);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1067;
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
		RadioButton_DH.Appearance = (Appearance)1;
		((Control)RadioButton_DH).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_DH).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton_DH).FlatStyle = (FlatStyle)0;
		((Control)RadioButton_DH).Font = new Font("Tahoma", 12f, (FontStyle)1);
		((Control)RadioButton_DH).ForeColor = Color.FromArgb(2, 45, 162);
		RadioButton radioButton_DH = RadioButton_DH;
		location = new Point(0, 0);
		((Control)radioButton_DH).Location = location;
		RadioButton radioButton_DH2 = RadioButton_DH;
		margin = new Padding(0);
		((Control)radioButton_DH2).Margin = margin;
		((Control)RadioButton_DH).Name = "RadioButton_DH";
		RadioButton radioButton_DH3 = RadioButton_DH;
		size = new Size(58, 32);
		((Control)radioButton_DH3).Size = size;
		((Control)RadioButton_DH).TabIndex = 1068;
		((ButtonBase)RadioButton_DH).Text = "DH";
		RadioButton_DH.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton_DH).UseVisualStyleBackColor = true;
		RadioButton_POURCENTAGE.Appearance = (Appearance)1;
		((Control)RadioButton_POURCENTAGE).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_POURCENTAGE).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton_POURCENTAGE).FlatStyle = (FlatStyle)0;
		((Control)RadioButton_POURCENTAGE).Font = new Font("Tahoma", 12f, (FontStyle)1);
		((Control)RadioButton_POURCENTAGE).ForeColor = Color.FromArgb(2, 45, 162);
		RadioButton radioButton_POURCENTAGE = RadioButton_POURCENTAGE;
		location = new Point(58, 0);
		((Control)radioButton_POURCENTAGE).Location = location;
		RadioButton radioButton_POURCENTAGE2 = RadioButton_POURCENTAGE;
		margin = new Padding(0);
		((Control)radioButton_POURCENTAGE2).Margin = margin;
		((Control)RadioButton_POURCENTAGE).Name = "RadioButton_POURCENTAGE";
		RadioButton radioButton_POURCENTAGE3 = RadioButton_POURCENTAGE;
		size = new Size(58, 32);
		((Control)radioButton_POURCENTAGE3).Size = size;
		((Control)RadioButton_POURCENTAGE).TabIndex = 1069;
		((ButtonBase)RadioButton_POURCENTAGE).Text = "%";
		RadioButton_POURCENTAGE.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton_POURCENTAGE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(12, 545);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(155, 54);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 1071;
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
		location = new Point(205, 545);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(155, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1070;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)Panel1).Controls.Add((Control)(object)RadioButton_DH);
		((Control)Panel1).Controls.Add((Control)(object)RadioButton_POURCENTAGE);
		Panel panel = Panel1;
		location = new Point(242, 94);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(118, 34);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1072;
		((ButtonBase)Button2).BackColor = Color.White;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.Red;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Calibri", 12.25f, (FontStyle)1);
		((Control)Button2).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button5 = Button2;
		location = new Point(12, 473);
		((Control)button5).Location = location;
		((Control)Button2).Name = "Button2";
		Button button6 = Button2;
		size = new Size(348, 44);
		((Control)button6).Size = size;
		((Control)Button2).TabIndex = 1075;
		((ButtonBase)Button2).Text = "Annuler la Remise";
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(372, 611);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Button_CLOSE);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Text_NUM);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)RadioButton_ARTICLE);
		((Control)this).Controls.Add((Control)(object)Button39);
		((Control)this).Controls.Add((Control)(object)RadioButton_GLOBALE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_REMISE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "REMISE";
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Button39_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(100);
		RadioButton_POURCENTAGE.Checked = true;
		RadioButton_ARTICLE.PerformClick();
		Button_SAVE.PerformClick();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(100);
		RadioButton_POURCENTAGE.Checked = true;
		RadioButton_GLOBALE.PerformClick();
		Button_SAVE.PerformClick();
	}

	private void FormDialog_REMISE_Load(object sender, EventArgs e)
	{
		Text_NUM.Text = "";
		RadioButton_GLOBALE.Checked = true;
		RadioButton_POURCENTAGE.Checked = true;
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

	private void RadioButton_DH_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton_POURCENTAGE_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Text_NUM.Text, "", TextCompare: false) == 0 || MyProject.Forms.Form_3_VENTE.DataGridView1.RowCount == 0)
				{
					return;
				}
				if (RadioButton_POURCENTAGE.Checked)
				{
					if (decimal.Compare(Conversions.ToDecimal(Text_NUM.Text), 100m) > 0)
					{
						MessageBox.Show("Veuillez remplir le champ -REMISE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					if (RadioButton_ARTICLE.Checked)
					{
						int rowIndex = MyProject.Forms.Form_3_VENTE.DataGridView1.CurrentCell.RowIndex;
						Module1.dt1.Rows[rowIndex]["TOTAL_NET"] = Strings.FormatNumber(Operators.MultiplyObject(Module1.dt1.Rows[rowIndex]["PRIX_V"], Module1.dt1.Rows[rowIndex]["Qté"]));
						Module1.dt1.Rows[rowIndex]["Remise"] = Math.Round(Conversions.ToDecimal(Text_NUM.Text), 2);
						Module1.dt1.Rows[rowIndex]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Module1.dt1.Rows[rowIndex]["TOTAL_NET"], Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[rowIndex]["PRIX_V"], Module1.dt1.Rows[rowIndex]["Qté"]), Module1.dt1.Rows[rowIndex]["Remise"]), 100)));
						MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
					}
					else if (RadioButton_GLOBALE.Checked)
					{
						int num = Module1.dt1.Rows.Count - 1;
						int num2 = 0;
						while (true)
						{
							int num3 = num2;
							int num4 = num;
							if (num3 <= num4)
							{
								Module1.dt1.Rows[num2]["TOTAL_NET"] = Strings.FormatNumber(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]));
								Module1.dt1.Rows[num2]["Remise"] = Math.Round(Conversions.ToDecimal(Text_NUM.Text), 2);
								Module1.dt1.Rows[num2]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Module1.dt1.Rows[num2]["TOTAL_NET"], Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[num2]["PRIX_V"], Module1.dt1.Rows[num2]["Qté"]), Module1.dt1.Rows[num2]["Remise"]), 100)));
								MySqlCommandBuilder val2 = new MySqlCommandBuilder(Module1.da1);
								((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
								Module1.dt1.AcceptChanges();
								num2++;
								continue;
							}
							break;
						}
					}
				}
				else if (RadioButton_DH.Checked)
				{
					if (RadioButton_ARTICLE.Checked)
					{
						int rowIndex2 = MyProject.Forms.Form_3_VENTE.DataGridView1.CurrentCell.RowIndex;
						Module1.dt1.Rows[rowIndex2]["TOTAL_NET"] = Strings.FormatNumber(Operators.MultiplyObject(Module1.dt1.Rows[rowIndex2]["PRIX_V"], Module1.dt1.Rows[rowIndex2]["Qté"]));
						Module1.dt1.Rows[rowIndex2]["Remise"] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(Operators.DivideObject(Text_NUM.Text, Module1.dt1.Rows[rowIndex2]["TOTAL_NET"]))) / 0.01, 2);
						Module1.dt1.Rows[rowIndex2]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Module1.dt1.Rows[rowIndex2]["TOTAL_NET"], Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[rowIndex2]["PRIX_V"], Module1.dt1.Rows[rowIndex2]["Qté"]), Module1.dt1.Rows[rowIndex2]["Remise"]), 100)));
						MySqlCommandBuilder val3 = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
					}
					else if (RadioButton_GLOBALE.Checked)
					{
						decimal num5 = Math.Round(decimal.Divide(decimal.Multiply(Conversions.ToDecimal(Text_NUM.Text), 100m), Conversions.ToDecimal(MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET.Text)), 2);
						int num6 = Module1.dt1.Rows.Count - 1;
						int num7 = 0;
						while (true)
						{
							int num8 = num7;
							int num4 = num6;
							if (num8 > num4)
							{
								break;
							}
							Module1.dt1.Rows[num7]["TOTAL_NET"] = Strings.FormatNumber(Operators.MultiplyObject(Module1.dt1.Rows[num7]["PRIX_V"], Module1.dt1.Rows[num7]["Qté"]));
							Module1.dt1.Rows[num7]["Remise"] = num5;
							Module1.dt1.Rows[num7]["TOTAL_NET"] = Strings.FormatNumber(Operators.SubtractObject(Module1.dt1.Rows[num7]["TOTAL_NET"], Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Module1.dt1.Rows[num7]["PRIX_V"], Module1.dt1.Rows[num7]["Qté"]), Module1.dt1.Rows[num7]["Remise"]), 100)));
							MySqlCommandBuilder val4 = new MySqlCommandBuilder(Module1.da1);
							((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
							Module1.dt1.AcceptChanges();
							num7++;
						}
					}
				}
				MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				Text_NUM.Text = "";
				((Form)this).Close();
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
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val5 = null;
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

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(0);
		RadioButton_POURCENTAGE.Checked = true;
		RadioButton_GLOBALE.PerformClick();
		Button_SAVE.PerformClick();
	}
}
