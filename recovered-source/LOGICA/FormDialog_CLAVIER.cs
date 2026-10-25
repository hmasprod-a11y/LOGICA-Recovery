using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_CLAVIER : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_N")]
	private Button_CLAVIER_NOSELECT _Butt_N;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_B")]
	private Button_CLAVIER_NOSELECT _Butt_B;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_V")]
	private Button_CLAVIER_NOSELECT _Butt_V;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_C")]
	private Button_CLAVIER_NOSELECT _Butt_C;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_X")]
	private Button_CLAVIER_NOSELECT _Butt_X;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_W")]
	private Button_CLAVIER_NOSELECT _Butt_W;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Butt_M")]
	private Button_CLAVIER_NOSELECT _Butt_M;

	[AccessedThroughProperty("Butt_A")]
	private Button_CLAVIER_NOSELECT _Butt_A;

	[AccessedThroughProperty("Butt_L")]
	private Button_CLAVIER_NOSELECT _Butt_L;

	[AccessedThroughProperty("Butt_Z")]
	private Button_CLAVIER_NOSELECT _Butt_Z;

	[AccessedThroughProperty("Butt_K")]
	private Button_CLAVIER_NOSELECT _Butt_K;

	[AccessedThroughProperty("Butt_E")]
	private Button_CLAVIER_NOSELECT _Butt_E;

	[AccessedThroughProperty("Butt_J")]
	private Button_CLAVIER_NOSELECT _Butt_J;

	[AccessedThroughProperty("Butt_R")]
	private Button_CLAVIER_NOSELECT _Butt_R;

	[AccessedThroughProperty("Butt_H")]
	private Button_CLAVIER_NOSELECT _Butt_H;

	[AccessedThroughProperty("Butt_T")]
	private Button_CLAVIER_NOSELECT _Butt_T;

	[AccessedThroughProperty("Butt_G")]
	private Button_CLAVIER_NOSELECT _Butt_G;

	[AccessedThroughProperty("Butt_Y")]
	private Button_CLAVIER_NOSELECT _Butt_Y;

	[AccessedThroughProperty("Butt_F")]
	private Button_CLAVIER_NOSELECT _Butt_F;

	[AccessedThroughProperty("Butt_U")]
	private Button_CLAVIER_NOSELECT _Butt_U;

	[AccessedThroughProperty("Butt_D")]
	private Button_CLAVIER_NOSELECT _Butt_D;

	[AccessedThroughProperty("Butt_I")]
	private Button_CLAVIER_NOSELECT _Butt_I;

	[AccessedThroughProperty("Butt_S")]
	private Button_CLAVIER_NOSELECT _Butt_S;

	[AccessedThroughProperty("Butt_O")]
	private Button_CLAVIER_NOSELECT _Butt_O;

	[AccessedThroughProperty("Butt_Q")]
	private Button_CLAVIER_NOSELECT _Butt_Q;

	[AccessedThroughProperty("Butt_P")]
	private Button_CLAVIER_NOSELECT _Butt_P;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("TableLayoutPanel3")]
	private TableLayoutPanel _TableLayoutPanel3;

	[AccessedThroughProperty("Butt_AR")]
	private Button_CLAVIER_NOSELECT _Butt_AR;

	[AccessedThroughProperty("Butt_SPACE")]
	private Button_CLAVIER_NOSELECT _Butt_SPACE;

	[AccessedThroughProperty("Panel_CLAVIER_AR")]
	private Panel _Panel_CLAVIER_AR;

	[AccessedThroughProperty("TableLayoutPanel4")]
	private TableLayoutPanel _TableLayoutPanel4;

	[AccessedThroughProperty("Butt_1_AR")]
	private Button_CLAVIER_NOSELECT _Butt_1_AR;

	[AccessedThroughProperty("Butt_2_AR")]
	private Button_CLAVIER_NOSELECT _Butt_2_AR;

	[AccessedThroughProperty("Butt_3_AR")]
	private Button_CLAVIER_NOSELECT _Butt_3_AR;

	[AccessedThroughProperty("Butt_4_AR")]
	private Button_CLAVIER_NOSELECT _Butt_4_AR;

	[AccessedThroughProperty("Butt_5_AR")]
	private Button_CLAVIER_NOSELECT _Butt_5_AR;

	[AccessedThroughProperty("Butt_6_AR")]
	private Button_CLAVIER_NOSELECT _Butt_6_AR;

	[AccessedThroughProperty("Butt_7_AR")]
	private Button_CLAVIER_NOSELECT _Butt_7_AR;

	[AccessedThroughProperty("Butt_8_AR")]
	private Button_CLAVIER_NOSELECT _Butt_8_AR;

	[AccessedThroughProperty("Butt_9_AR")]
	private Button_CLAVIER_NOSELECT _Butt_9_AR;

	[AccessedThroughProperty("Butt_0_AR")]
	private Button_CLAVIER_NOSELECT _Butt_0_AR;

	[AccessedThroughProperty("Butt_ك")]
	private Button_CLAVIER_NOSELECT _Butt_ك;

	[AccessedThroughProperty("Butt_ض")]
	private Button_CLAVIER_NOSELECT _Butt_ض;

	[AccessedThroughProperty("Butt_م")]
	private Button_CLAVIER_NOSELECT _Butt_م;

	[AccessedThroughProperty("Butt_ص")]
	private Button_CLAVIER_NOSELECT _Butt_ص;

	[AccessedThroughProperty("Butt_ن")]
	private Button_CLAVIER_NOSELECT _Butt_ن;

	[AccessedThroughProperty("Butt_ث")]
	private Button_CLAVIER_NOSELECT _Butt_ث;

	[AccessedThroughProperty("Butt_ت")]
	private Button_CLAVIER_NOSELECT _Butt_ت;

	[AccessedThroughProperty("Butt_ق")]
	private Button_CLAVIER_NOSELECT _Butt_ق;

	[AccessedThroughProperty("Butt_ا")]
	private Button_CLAVIER_NOSELECT _Butt_ا;

	[AccessedThroughProperty("Butt_ف")]
	private Button_CLAVIER_NOSELECT _Butt_ف;

	[AccessedThroughProperty("Butt_ل")]
	private Button_CLAVIER_NOSELECT _Butt_ل;

	[AccessedThroughProperty("Butt_غ")]
	private Button_CLAVIER_NOSELECT _Butt_غ;

	[AccessedThroughProperty("Butt_ب")]
	private Button_CLAVIER_NOSELECT _Butt_ب;

	[AccessedThroughProperty("Butt_ع")]
	private Button_CLAVIER_NOSELECT _Butt_ع;

	[AccessedThroughProperty("Butt_ي")]
	private Button_CLAVIER_NOSELECT _Butt_ي;

	[AccessedThroughProperty("Butt_ه")]
	private Button_CLAVIER_NOSELECT _Butt_ه;

	[AccessedThroughProperty("Butt_س")]
	private Button_CLAVIER_NOSELECT _Butt_س;

	[AccessedThroughProperty("Butt_خ")]
	private Button_CLAVIER_NOSELECT _Butt_خ;

	[AccessedThroughProperty("Butt_ش")]
	private Button_CLAVIER_NOSELECT _Butt_ش;

	[AccessedThroughProperty("Butt_ح")]
	private Button_CLAVIER_NOSELECT _Butt_ح;

	[AccessedThroughProperty("Butt_ج")]
	private Button_CLAVIER_NOSELECT _Butt_ج;

	[AccessedThroughProperty("Butt_BACK_AR")]
	private Button_CLAVIER_NOSELECT _Butt_BACK_AR;

	[AccessedThroughProperty("Butt_د")]
	private Button_CLAVIER_NOSELECT _Butt_د;

	[AccessedThroughProperty("Butt_ذ")]
	private Button_CLAVIER_NOSELECT _Butt_ذ;

	[AccessedThroughProperty("Butt_ط")]
	private Button_CLAVIER_NOSELECT _Butt_ط;

	[AccessedThroughProperty("Butt_DOT_AR")]
	private Button_CLAVIER_NOSELECT _Butt_DOT_AR;

	[AccessedThroughProperty("Butt_ظ")]
	private Button_CLAVIER_NOSELECT _Butt_ظ;

	[AccessedThroughProperty("Butt_ز")]
	private Button_CLAVIER_NOSELECT _Butt_ز;

	[AccessedThroughProperty("Butt_و")]
	private Button_CLAVIER_NOSELECT _Butt_و;

	[AccessedThroughProperty("Butt_ة")]
	private Button_CLAVIER_NOSELECT _Butt_ة;

	[AccessedThroughProperty("Butt_ى")]
	private Button_CLAVIER_NOSELECT _Butt_ى;

	[AccessedThroughProperty("Butt_لا")]
	private Button_CLAVIER_NOSELECT _Butt_لا;

	[AccessedThroughProperty("Butt_ر")]
	private Button_CLAVIER_NOSELECT _Butt_ر;

	[AccessedThroughProperty("Butt_ؤ")]
	private Button_CLAVIER_NOSELECT _Butt_ؤ;

	[AccessedThroughProperty("Butt_ء")]
	private Button_CLAVIER_NOSELECT _Butt_ء;

	[AccessedThroughProperty("Butt_ئ")]
	private Button_CLAVIER_NOSELECT _Butt_ئ;

	[AccessedThroughProperty("TableLayoutPanel5")]
	private TableLayoutPanel _TableLayoutPanel5;

	[AccessedThroughProperty("Butt_FR")]
	private Button_CLAVIER_NOSELECT _Butt_FR;

	[AccessedThroughProperty("Butt_SPACE_AR")]
	private Button_CLAVIER_NOSELECT _Butt_SPACE_AR;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Butt_ENTER")]
	private Button_CLAVIER_NOSELECT _Butt_ENTER;

	[AccessedThroughProperty("Butt_ENTER_AR")]
	private Button_CLAVIER_NOSELECT _Butt_ENTER_AR;

	private const int WS_EX_TOPMOST = 8;

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

	internal virtual Button_CLAVIER_NOSELECT Butt_N
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_N;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_N != null)
			{
				((Control)_Butt_N).Click -= eventHandler;
			}
			_Butt_N = value;
			if (_Butt_N != null)
			{
				((Control)_Butt_N).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_B
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_B;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_B != null)
			{
				((Control)_Butt_B).Click -= eventHandler;
			}
			_Butt_B = value;
			if (_Butt_B != null)
			{
				((Control)_Butt_B).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_V != null)
			{
				((Control)_Butt_V).Click -= eventHandler;
			}
			_Butt_V = value;
			if (_Butt_V != null)
			{
				((Control)_Butt_V).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_C
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_C != null)
			{
				((Control)_Butt_C).Click -= eventHandler;
			}
			_Butt_C = value;
			if (_Butt_C != null)
			{
				((Control)_Butt_C).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_X
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_X;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_X != null)
			{
				((Control)_Butt_X).Click -= eventHandler;
			}
			_Butt_X = value;
			if (_Butt_X != null)
			{
				((Control)_Butt_X).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_W
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_W;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_W != null)
			{
				((Control)_Butt_W).Click -= eventHandler;
			}
			_Butt_W = value;
			if (_Butt_W != null)
			{
				((Control)_Butt_W).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_M != null)
			{
				((Control)_Butt_M).Click -= eventHandler;
			}
			_Butt_M = value;
			if (_Butt_M != null)
			{
				((Control)_Butt_M).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_A != null)
			{
				((Control)_Butt_A).Click -= eventHandler;
			}
			_Butt_A = value;
			if (_Butt_A != null)
			{
				((Control)_Butt_A).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_L
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_L;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_L != null)
			{
				((Control)_Butt_L).Click -= eventHandler;
			}
			_Butt_L = value;
			if (_Butt_L != null)
			{
				((Control)_Butt_L).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Z
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Z;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Z != null)
			{
				((Control)_Butt_Z).Click -= eventHandler;
			}
			_Butt_Z = value;
			if (_Butt_Z != null)
			{
				((Control)_Butt_Z).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_K
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_K;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_K != null)
			{
				((Control)_Butt_K).Click -= eventHandler;
			}
			_Butt_K = value;
			if (_Butt_K != null)
			{
				((Control)_Butt_K).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_E
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_E;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_E != null)
			{
				((Control)_Butt_E).Click -= eventHandler;
			}
			_Butt_E = value;
			if (_Butt_E != null)
			{
				((Control)_Butt_E).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_J
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_J;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_J != null)
			{
				((Control)_Butt_J).Click -= eventHandler;
			}
			_Butt_J = value;
			if (_Butt_J != null)
			{
				((Control)_Butt_J).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_R
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_R;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_R != null)
			{
				((Control)_Butt_R).Click -= eventHandler;
			}
			_Butt_R = value;
			if (_Butt_R != null)
			{
				((Control)_Butt_R).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_H
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_H;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_H != null)
			{
				((Control)_Butt_H).Click -= eventHandler;
			}
			_Butt_H = value;
			if (_Butt_H != null)
			{
				((Control)_Butt_H).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_T
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_T;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_T != null)
			{
				((Control)_Butt_T).Click -= eventHandler;
			}
			_Butt_T = value;
			if (_Butt_T != null)
			{
				((Control)_Butt_T).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_G
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_G;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_G != null)
			{
				((Control)_Butt_G).Click -= eventHandler;
			}
			_Butt_G = value;
			if (_Butt_G != null)
			{
				((Control)_Butt_G).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Y
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Y != null)
			{
				((Control)_Butt_Y).Click -= eventHandler;
			}
			_Butt_Y = value;
			if (_Butt_Y != null)
			{
				((Control)_Butt_Y).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_F
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_F;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_F != null)
			{
				((Control)_Butt_F).Click -= eventHandler;
			}
			_Butt_F = value;
			if (_Butt_F != null)
			{
				((Control)_Butt_F).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_U
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_U;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_U != null)
			{
				((Control)_Butt_U).Click -= eventHandler;
			}
			_Butt_U = value;
			if (_Butt_U != null)
			{
				((Control)_Butt_U).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_D
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_D;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_D != null)
			{
				((Control)_Butt_D).Click -= eventHandler;
			}
			_Butt_D = value;
			if (_Butt_D != null)
			{
				((Control)_Butt_D).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_I
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_I;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_I != null)
			{
				((Control)_Butt_I).Click -= eventHandler;
			}
			_Butt_I = value;
			if (_Butt_I != null)
			{
				((Control)_Butt_I).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_S
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_S;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_S != null)
			{
				((Control)_Butt_S).Click -= eventHandler;
			}
			_Butt_S = value;
			if (_Butt_S != null)
			{
				((Control)_Butt_S).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_O
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_O;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_O != null)
			{
				((Control)_Butt_O).Click -= eventHandler;
			}
			_Butt_O = value;
			if (_Butt_O != null)
			{
				((Control)_Butt_O).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Q
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Q != null)
			{
				((Control)_Butt_Q).Click -= eventHandler;
			}
			_Butt_Q = value;
			if (_Butt_Q != null)
			{
				((Control)_Butt_Q).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_P != null)
			{
				((Control)_Butt_P).Click -= eventHandler;
			}
			_Butt_P = value;
			if (_Butt_P != null)
			{
				((Control)_Butt_P).Click += eventHandler;
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

	internal virtual TableLayoutPanel TableLayoutPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel3 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_AR_Click;
			if (_Butt_AR != null)
			{
				((Control)_Butt_AR).Click -= eventHandler;
			}
			_Butt_AR = value;
			if (_Butt_AR != null)
			{
				((Control)_Butt_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_SPACE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_SPACE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_SPACE_Click;
			if (_Butt_SPACE != null)
			{
				((Control)_Butt_SPACE).Click -= eventHandler;
			}
			_Butt_SPACE = value;
			if (_Butt_SPACE != null)
			{
				((Control)_Butt_SPACE).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_CLAVIER_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLAVIER_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLAVIER_AR = value;
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel4 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_1_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_1_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_1_AR != null)
			{
				((Control)_Butt_1_AR).Click -= eventHandler;
			}
			_Butt_1_AR = value;
			if (_Butt_1_AR != null)
			{
				((Control)_Butt_1_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_2_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_2_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_2_AR != null)
			{
				((Control)_Butt_2_AR).Click -= eventHandler;
			}
			_Butt_2_AR = value;
			if (_Butt_2_AR != null)
			{
				((Control)_Butt_2_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_3_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_3_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_3_AR != null)
			{
				((Control)_Butt_3_AR).Click -= eventHandler;
			}
			_Butt_3_AR = value;
			if (_Butt_3_AR != null)
			{
				((Control)_Butt_3_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_4_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_4_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_4_AR != null)
			{
				((Control)_Butt_4_AR).Click -= eventHandler;
			}
			_Butt_4_AR = value;
			if (_Butt_4_AR != null)
			{
				((Control)_Butt_4_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_5_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_5_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_5_AR != null)
			{
				((Control)_Butt_5_AR).Click -= eventHandler;
			}
			_Butt_5_AR = value;
			if (_Butt_5_AR != null)
			{
				((Control)_Butt_5_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_6_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_6_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_6_AR != null)
			{
				((Control)_Butt_6_AR).Click -= eventHandler;
			}
			_Butt_6_AR = value;
			if (_Butt_6_AR != null)
			{
				((Control)_Butt_6_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_7_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_7_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_7_AR != null)
			{
				((Control)_Butt_7_AR).Click -= eventHandler;
			}
			_Butt_7_AR = value;
			if (_Butt_7_AR != null)
			{
				((Control)_Butt_7_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_8_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_8_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_8_AR != null)
			{
				((Control)_Butt_8_AR).Click -= eventHandler;
			}
			_Butt_8_AR = value;
			if (_Butt_8_AR != null)
			{
				((Control)_Butt_8_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_9_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_9_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_9_AR != null)
			{
				((Control)_Butt_9_AR).Click -= eventHandler;
			}
			_Butt_9_AR = value;
			if (_Butt_9_AR != null)
			{
				((Control)_Butt_9_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_0_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_0_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_0_AR != null)
			{
				((Control)_Butt_0_AR).Click -= eventHandler;
			}
			_Butt_0_AR = value;
			if (_Butt_0_AR != null)
			{
				((Control)_Butt_0_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ك
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ك;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ك != null)
			{
				((Control)_Butt_ك).Click -= eventHandler;
			}
			_Butt_ك = value;
			if (_Butt_ك != null)
			{
				((Control)_Butt_ك).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ض
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ض;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ض != null)
			{
				((Control)_Butt_ض).Click -= eventHandler;
			}
			_Butt_ض = value;
			if (_Butt_ض != null)
			{
				((Control)_Butt_ض).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_م
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_م;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_م != null)
			{
				((Control)_Butt_م).Click -= eventHandler;
			}
			_Butt_م = value;
			if (_Butt_م != null)
			{
				((Control)_Butt_م).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ص
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ص;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ص != null)
			{
				((Control)_Butt_ص).Click -= eventHandler;
			}
			_Butt_ص = value;
			if (_Butt_ص != null)
			{
				((Control)_Butt_ص).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ن
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ن;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ن != null)
			{
				((Control)_Butt_ن).Click -= eventHandler;
			}
			_Butt_ن = value;
			if (_Butt_ن != null)
			{
				((Control)_Butt_ن).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ث
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ث;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ث != null)
			{
				((Control)_Butt_ث).Click -= eventHandler;
			}
			_Butt_ث = value;
			if (_Butt_ث != null)
			{
				((Control)_Butt_ث).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ت
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ت;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ت != null)
			{
				((Control)_Butt_ت).Click -= eventHandler;
			}
			_Butt_ت = value;
			if (_Butt_ت != null)
			{
				((Control)_Butt_ت).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ق
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ق;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ق != null)
			{
				((Control)_Butt_ق).Click -= eventHandler;
			}
			_Butt_ق = value;
			if (_Butt_ق != null)
			{
				((Control)_Butt_ق).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ا
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ا;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ا != null)
			{
				((Control)_Butt_ا).Click -= eventHandler;
			}
			_Butt_ا = value;
			if (_Butt_ا != null)
			{
				((Control)_Butt_ا).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ف
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ف;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ف != null)
			{
				((Control)_Butt_ف).Click -= eventHandler;
			}
			_Butt_ف = value;
			if (_Butt_ف != null)
			{
				((Control)_Butt_ف).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ل
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ل;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ل != null)
			{
				((Control)_Butt_ل).Click -= eventHandler;
			}
			_Butt_ل = value;
			if (_Butt_ل != null)
			{
				((Control)_Butt_ل).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_غ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_غ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_غ != null)
			{
				((Control)_Butt_غ).Click -= eventHandler;
			}
			_Butt_غ = value;
			if (_Butt_غ != null)
			{
				((Control)_Butt_غ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ب
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ب;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ب != null)
			{
				((Control)_Butt_ب).Click -= eventHandler;
			}
			_Butt_ب = value;
			if (_Butt_ب != null)
			{
				((Control)_Butt_ب).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ع
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ع;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ع != null)
			{
				((Control)_Butt_ع).Click -= eventHandler;
			}
			_Butt_ع = value;
			if (_Butt_ع != null)
			{
				((Control)_Butt_ع).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ي
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ي;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ي != null)
			{
				((Control)_Butt_ي).Click -= eventHandler;
			}
			_Butt_ي = value;
			if (_Butt_ي != null)
			{
				((Control)_Butt_ي).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ه
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ه;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ه != null)
			{
				((Control)_Butt_ه).Click -= eventHandler;
			}
			_Butt_ه = value;
			if (_Butt_ه != null)
			{
				((Control)_Butt_ه).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_س
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_س;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_س != null)
			{
				((Control)_Butt_س).Click -= eventHandler;
			}
			_Butt_س = value;
			if (_Butt_س != null)
			{
				((Control)_Butt_س).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_خ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_خ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_خ != null)
			{
				((Control)_Butt_خ).Click -= eventHandler;
			}
			_Butt_خ = value;
			if (_Butt_خ != null)
			{
				((Control)_Butt_خ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ش
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ش;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ش != null)
			{
				((Control)_Butt_ش).Click -= eventHandler;
			}
			_Butt_ش = value;
			if (_Butt_ش != null)
			{
				((Control)_Butt_ش).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ح
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ح;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ح != null)
			{
				((Control)_Butt_ح).Click -= eventHandler;
			}
			_Butt_ح = value;
			if (_Butt_ح != null)
			{
				((Control)_Butt_ح).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ج
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ج;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ج != null)
			{
				((Control)_Butt_ج).Click -= eventHandler;
			}
			_Butt_ج = value;
			if (_Butt_ج != null)
			{
				((Control)_Butt_ج).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_BACK_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_BACK_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_BACK_AR_Click;
			if (_Butt_BACK_AR != null)
			{
				((Control)_Butt_BACK_AR).Click -= eventHandler;
			}
			_Butt_BACK_AR = value;
			if (_Butt_BACK_AR != null)
			{
				((Control)_Butt_BACK_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_د
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_د;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_د != null)
			{
				((Control)_Butt_د).Click -= eventHandler;
			}
			_Butt_د = value;
			if (_Butt_د != null)
			{
				((Control)_Butt_د).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ذ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ذ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ذ != null)
			{
				((Control)_Butt_ذ).Click -= eventHandler;
			}
			_Butt_ذ = value;
			if (_Butt_ذ != null)
			{
				((Control)_Butt_ذ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ط
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ط;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ط != null)
			{
				((Control)_Butt_ط).Click -= eventHandler;
			}
			_Butt_ط = value;
			if (_Butt_ط != null)
			{
				((Control)_Butt_ط).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_DOT_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_DOT_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_DOT_AR != null)
			{
				((Control)_Butt_DOT_AR).Click -= eventHandler;
			}
			_Butt_DOT_AR = value;
			if (_Butt_DOT_AR != null)
			{
				((Control)_Butt_DOT_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ظ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ظ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ظ != null)
			{
				((Control)_Butt_ظ).Click -= eventHandler;
			}
			_Butt_ظ = value;
			if (_Butt_ظ != null)
			{
				((Control)_Butt_ظ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ز
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ز;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ز != null)
			{
				((Control)_Butt_ز).Click -= eventHandler;
			}
			_Butt_ز = value;
			if (_Butt_ز != null)
			{
				((Control)_Butt_ز).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_و
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_و;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_و != null)
			{
				((Control)_Butt_و).Click -= eventHandler;
			}
			_Butt_و = value;
			if (_Butt_و != null)
			{
				((Control)_Butt_و).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ة
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ة;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ة != null)
			{
				((Control)_Butt_ة).Click -= eventHandler;
			}
			_Butt_ة = value;
			if (_Butt_ة != null)
			{
				((Control)_Butt_ة).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ى
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ى;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ى != null)
			{
				((Control)_Butt_ى).Click -= eventHandler;
			}
			_Butt_ى = value;
			if (_Butt_ى != null)
			{
				((Control)_Butt_ى).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_لا
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_لا;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_لا != null)
			{
				((Control)_Butt_لا).Click -= eventHandler;
			}
			_Butt_لا = value;
			if (_Butt_لا != null)
			{
				((Control)_Butt_لا).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ر
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ر;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ر != null)
			{
				((Control)_Butt_ر).Click -= eventHandler;
			}
			_Butt_ر = value;
			if (_Butt_ر != null)
			{
				((Control)_Butt_ر).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ؤ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ؤ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ؤ != null)
			{
				((Control)_Butt_ؤ).Click -= eventHandler;
			}
			_Butt_ؤ = value;
			if (_Butt_ؤ != null)
			{
				((Control)_Butt_ؤ).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ء
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ء;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ء != null)
			{
				((Control)_Butt_ء).Click -= eventHandler;
			}
			_Butt_ء = value;
			if (_Butt_ء != null)
			{
				((Control)_Butt_ء).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ئ
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ئ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click_AR;
			if (_Butt_ئ != null)
			{
				((Control)_Butt_ئ).Click -= eventHandler;
			}
			_Butt_ئ = value;
			if (_Butt_ئ != null)
			{
				((Control)_Butt_ئ).Click += eventHandler;
			}
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel5 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_FR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_FR_Click;
			if (_Butt_FR != null)
			{
				((Control)_Butt_FR).Click -= eventHandler;
			}
			_Butt_FR = value;
			if (_Butt_FR != null)
			{
				((Control)_Butt_FR).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_SPACE_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_SPACE_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_SPACE_AR_Click;
			if (_Butt_SPACE_AR != null)
			{
				((Control)_Butt_SPACE_AR).Click -= eventHandler;
			}
			_Butt_SPACE_AR = value;
			if (_Butt_SPACE_AR != null)
			{
				((Control)_Butt_SPACE_AR).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button244
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button244;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button244_Click;
			if (_Button244 != null)
			{
				((Control)_Button244).Click -= eventHandler;
			}
			_Button244 = value;
			if (_Button244 != null)
			{
				((Control)_Button244).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_ENTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ENTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_ENTER_Click;
			if (_Butt_ENTER != null)
			{
				((Control)_Butt_ENTER).Click -= eventHandler;
			}
			_Butt_ENTER = value;
			if (_Butt_ENTER != null)
			{
				((Control)_Butt_ENTER).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_ENTER_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ENTER_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_ENTER_AR_Click;
			if (_Butt_ENTER_AR != null)
			{
				((Control)_Butt_ENTER_AR).Click -= eventHandler;
			}
			_Butt_ENTER_AR = value;
			if (_Butt_ENTER_AR != null)
			{
				((Control)_Butt_ENTER_AR).Click += eventHandler;
			}
		}
	}

	protected override bool ShowWithoutActivation => true;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 8;
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_CLAVIER()
	{
		((Form)this).Load += Form1_Load;
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected Obj, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected Obj, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected Obj, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected Obj, but got Unknown
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected Obj, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected Obj, but got Unknown
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected Obj, but got Unknown
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected Obj, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected Obj, but got Unknown
		//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected Obj, but got Unknown
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected Obj, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected Obj, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected Obj, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected Obj, but got Unknown
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Expected Obj, but got Unknown
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Expected Obj, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa5: Expected Obj, but got Unknown
		//IL_1488: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14be: Expected Obj, but got Unknown
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Expected Obj, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected Obj, but got Unknown
		//IL_1508: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Expected Obj, but got Unknown
		//IL_1579: Unknown result type (might be due to invalid IL or missing references)
		//IL_1583: Expected Obj, but got Unknown
		//IL_1595: Unknown result type (might be due to invalid IL or missing references)
		//IL_159f: Expected Obj, but got Unknown
		//IL_15b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Expected Obj, but got Unknown
		//IL_1630: Unknown result type (might be due to invalid IL or missing references)
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1666: Expected Obj, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected Obj, but got Unknown
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_1736: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f1: Expected Obj, but got Unknown
		//IL_18ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Expected Obj, but got Unknown
		//IL_196d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1977: Expected Obj, but got Unknown
		//IL_1a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3c: Expected Obj, but got Unknown
		//IL_1b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Expected Obj, but got Unknown
		//IL_1b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6f: Expected Obj, but got Unknown
		//IL_1ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d90: Expected Obj, but got Unknown
		//IL_1dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb2: Expected Obj, but got Unknown
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd8: Expected Obj, but got Unknown
		//IL_200b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2011: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fa: Expected Obj, but got Unknown
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Expected Obj, but got Unknown
		//IL_2256: Unknown result type (might be due to invalid IL or missing references)
		//IL_225c: Unknown result type (might be due to invalid IL or missing references)
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2345: Expected Obj, but got Unknown
		//IL_237c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2382: Unknown result type (might be due to invalid IL or missing references)
		//IL_2461: Unknown result type (might be due to invalid IL or missing references)
		//IL_246b: Expected Obj, but got Unknown
		//IL_24a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2586: Unknown result type (might be due to invalid IL or missing references)
		//IL_2590: Expected Obj, but got Unknown
		//IL_25c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b6: Expected Obj, but got Unknown
		//IL_26ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27db: Expected Obj, but got Unknown
		//IL_2812: Unknown result type (might be due to invalid IL or missing references)
		//IL_2818: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2901: Expected Obj, but got Unknown
		//IL_2937: Unknown result type (might be due to invalid IL or missing references)
		//IL_293d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a26: Expected Obj, but got Unknown
		//IL_2a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b49: Expected Obj, but got Unknown
		//IL_2b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6e: Expected Obj, but got Unknown
		//IL_2ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d93: Expected Obj, but got Unknown
		//IL_2dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb8: Expected Obj, but got Unknown
		//IL_2eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2feb: Expected Obj, but got Unknown
		//IL_301e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3024: Unknown result type (might be due to invalid IL or missing references)
		//IL_3103: Unknown result type (might be due to invalid IL or missing references)
		//IL_310d: Expected Obj, but got Unknown
		//IL_3144: Unknown result type (might be due to invalid IL or missing references)
		//IL_314a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3229: Unknown result type (might be due to invalid IL or missing references)
		//IL_3233: Expected Obj, but got Unknown
		//IL_3267: Unknown result type (might be due to invalid IL or missing references)
		//IL_326d: Unknown result type (might be due to invalid IL or missing references)
		//IL_334c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3356: Expected Obj, but got Unknown
		//IL_338d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3393: Unknown result type (might be due to invalid IL or missing references)
		//IL_3472: Unknown result type (might be due to invalid IL or missing references)
		//IL_347c: Expected Obj, but got Unknown
		//IL_34b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3595: Unknown result type (might be due to invalid IL or missing references)
		//IL_359f: Expected Obj, but got Unknown
		//IL_35d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c5: Expected Obj, but got Unknown
		//IL_36fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3702: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37eb: Expected Obj, but got Unknown
		//IL_3822: Unknown result type (might be due to invalid IL or missing references)
		//IL_3828: Unknown result type (might be due to invalid IL or missing references)
		//IL_3907: Unknown result type (might be due to invalid IL or missing references)
		//IL_3911: Expected Obj, but got Unknown
		//IL_3948: Unknown result type (might be due to invalid IL or missing references)
		//IL_394e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a37: Expected Obj, but got Unknown
		//IL_3a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b5d: Expected Obj, but got Unknown
		//IL_3b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c83: Expected Obj, but got Unknown
		//IL_3cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da9: Expected Obj, but got Unknown
		//IL_3de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ecf: Expected Obj, but got Unknown
		//IL_3f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff5: Expected Obj, but got Unknown
		//IL_402c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4032: Unknown result type (might be due to invalid IL or missing references)
		//IL_4111: Unknown result type (might be due to invalid IL or missing references)
		//IL_411b: Expected Obj, but got Unknown
		//IL_414f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4155: Unknown result type (might be due to invalid IL or missing references)
		//IL_4234: Unknown result type (might be due to invalid IL or missing references)
		//IL_423e: Expected Obj, but got Unknown
		//IL_4275: Unknown result type (might be due to invalid IL or missing references)
		//IL_427b: Unknown result type (might be due to invalid IL or missing references)
		//IL_435a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4364: Expected Obj, but got Unknown
		//IL_4398: Unknown result type (might be due to invalid IL or missing references)
		//IL_439e: Unknown result type (might be due to invalid IL or missing references)
		//IL_447d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4487: Expected Obj, but got Unknown
		//IL_44be: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ad: Expected Obj, but got Unknown
		//IL_45d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_45da: Expected Obj, but got Unknown
		//IL_45ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4605: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d0: Expected Obj, but got Unknown
		//IL_46f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_46fd: Expected Obj, but got Unknown
		//IL_4723: Unknown result type (might be due to invalid IL or missing references)
		//IL_4729: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_47f4: Expected Obj, but got Unknown
		//IL_4817: Unknown result type (might be due to invalid IL or missing references)
		//IL_4821: Expected Obj, but got Unknown
		//IL_4842: Unknown result type (might be due to invalid IL or missing references)
		//IL_4848: Unknown result type (might be due to invalid IL or missing references)
		//IL_4916: Unknown result type (might be due to invalid IL or missing references)
		//IL_4920: Expected Obj, but got Unknown
		//IL_4943: Unknown result type (might be due to invalid IL or missing references)
		//IL_494d: Expected Obj, but got Unknown
		//IL_496f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4975: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a50: Expected Obj, but got Unknown
		//IL_4a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b71: Expected Obj, but got Unknown
		//IL_4ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c93: Expected Obj, but got Unknown
		//IL_4cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_4db5: Expected Obj, but got Unknown
		//IL_4deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eda: Expected Obj, but got Unknown
		//IL_4f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fff: Expected Obj, but got Unknown
		//IL_5035: Unknown result type (might be due to invalid IL or missing references)
		//IL_503b: Unknown result type (might be due to invalid IL or missing references)
		//IL_511a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5124: Expected Obj, but got Unknown
		//IL_515a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5160: Unknown result type (might be due to invalid IL or missing references)
		//IL_523f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5249: Expected Obj, but got Unknown
		//IL_527f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5285: Unknown result type (might be due to invalid IL or missing references)
		//IL_5364: Unknown result type (might be due to invalid IL or missing references)
		//IL_536e: Expected Obj, but got Unknown
		//IL_53a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_53aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5489: Unknown result type (might be due to invalid IL or missing references)
		//IL_5493: Expected Obj, but got Unknown
		//IL_54c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_54cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_55ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_55b8: Expected Obj, but got Unknown
		//IL_55ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_55f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_56e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_56eb: Expected Obj, but got Unknown
		//IL_571e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5724: Unknown result type (might be due to invalid IL or missing references)
		//IL_5803: Unknown result type (might be due to invalid IL or missing references)
		//IL_580d: Expected Obj, but got Unknown
		//IL_5844: Unknown result type (might be due to invalid IL or missing references)
		//IL_584a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5929: Unknown result type (might be due to invalid IL or missing references)
		//IL_5933: Expected Obj, but got Unknown
		//IL_5967: Unknown result type (might be due to invalid IL or missing references)
		//IL_596d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a56: Expected Obj, but got Unknown
		//IL_5a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b7c: Expected Obj, but got Unknown
		//IL_5bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c9f: Expected Obj, but got Unknown
		//IL_5cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dc5: Expected Obj, but got Unknown
		//IL_5dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eeb: Expected Obj, but got Unknown
		//IL_5f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_6007: Unknown result type (might be due to invalid IL or missing references)
		//IL_6011: Expected Obj, but got Unknown
		//IL_6048: Unknown result type (might be due to invalid IL or missing references)
		//IL_604e: Unknown result type (might be due to invalid IL or missing references)
		//IL_612d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6137: Expected Obj, but got Unknown
		//IL_616e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6174: Unknown result type (might be due to invalid IL or missing references)
		//IL_6253: Unknown result type (might be due to invalid IL or missing references)
		//IL_625d: Expected Obj, but got Unknown
		//IL_6294: Unknown result type (might be due to invalid IL or missing references)
		//IL_629a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6379: Unknown result type (might be due to invalid IL or missing references)
		//IL_6383: Expected Obj, but got Unknown
		//IL_63ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_63c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_649f: Unknown result type (might be due to invalid IL or missing references)
		//IL_64a9: Expected Obj, but got Unknown
		//IL_64e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_64e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_65c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_65cf: Expected Obj, but got Unknown
		//IL_6606: Unknown result type (might be due to invalid IL or missing references)
		//IL_660c: Unknown result type (might be due to invalid IL or missing references)
		//IL_66eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_66f5: Expected Obj, but got Unknown
		//IL_672c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6732: Unknown result type (might be due to invalid IL or missing references)
		//IL_6811: Unknown result type (might be due to invalid IL or missing references)
		//IL_681b: Expected Obj, but got Unknown
		//IL_684f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6855: Unknown result type (might be due to invalid IL or missing references)
		//IL_6934: Unknown result type (might be due to invalid IL or missing references)
		//IL_693e: Expected Obj, but got Unknown
		//IL_6975: Unknown result type (might be due to invalid IL or missing references)
		//IL_697b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a64: Expected Obj, but got Unknown
		//IL_6a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b87: Expected Obj, but got Unknown
		//IL_6bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cad: Expected Obj, but got Unknown
		//IL_6ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dd3: Expected Obj, but got Unknown
		//IL_6df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e00: Expected Obj, but got Unknown
		//IL_6e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ef6: Expected Obj, but got Unknown
		//IL_6f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_7012: Unknown result type (might be due to invalid IL or missing references)
		//IL_701c: Expected Obj, but got Unknown
		//IL_7053: Unknown result type (might be due to invalid IL or missing references)
		//IL_7059: Unknown result type (might be due to invalid IL or missing references)
		//IL_7138: Unknown result type (might be due to invalid IL or missing references)
		//IL_7142: Expected Obj, but got Unknown
		//IL_7179: Unknown result type (might be due to invalid IL or missing references)
		//IL_717f: Unknown result type (might be due to invalid IL or missing references)
		//IL_725e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7268: Expected Obj, but got Unknown
		//IL_729f: Unknown result type (might be due to invalid IL or missing references)
		//IL_72a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7384: Unknown result type (might be due to invalid IL or missing references)
		//IL_738e: Expected Obj, but got Unknown
		//IL_73c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_73cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_74aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_74b4: Expected Obj, but got Unknown
		//IL_74eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_74f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_75d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_75da: Expected Obj, but got Unknown
		//IL_7611: Unknown result type (might be due to invalid IL or missing references)
		//IL_7617: Unknown result type (might be due to invalid IL or missing references)
		//IL_76f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7700: Expected Obj, but got Unknown
		//IL_7737: Unknown result type (might be due to invalid IL or missing references)
		//IL_773d: Unknown result type (might be due to invalid IL or missing references)
		//IL_781c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7826: Expected Obj, but got Unknown
		//IL_785d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7863: Unknown result type (might be due to invalid IL or missing references)
		//IL_7942: Unknown result type (might be due to invalid IL or missing references)
		//IL_794c: Expected Obj, but got Unknown
		//IL_7983: Unknown result type (might be due to invalid IL or missing references)
		//IL_7989: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a72: Expected Obj, but got Unknown
		//IL_7aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_7aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b98: Expected Obj, but got Unknown
		//IL_7bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cbe: Expected Obj, but got Unknown
		//IL_7cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7de1: Expected Obj, but got Unknown
		//IL_7e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f04: Expected Obj, but got Unknown
		//IL_7f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f31: Expected Obj, but got Unknown
		//IL_7f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_801e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8028: Expected Obj, but got Unknown
		//IL_804b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8055: Expected Obj, but got Unknown
		//IL_8076: Unknown result type (might be due to invalid IL or missing references)
		//IL_807c: Unknown result type (might be due to invalid IL or missing references)
		//IL_814a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8154: Expected Obj, but got Unknown
		//IL_8177: Unknown result type (might be due to invalid IL or missing references)
		//IL_8181: Expected Obj, but got Unknown
		//IL_81a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_81a9: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_CLAVIER));
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		TableLayoutPanel3 = new TableLayoutPanel();
		Panel_CLAVIER_AR = new Panel();
		TableLayoutPanel4 = new TableLayoutPanel();
		TableLayoutPanel5 = new TableLayoutPanel();
		Button244 = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_N = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_B = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_V = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_C = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_X = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_W = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Butt_M = new Button_CLAVIER_NOSELECT();
		Butt_A = new Button_CLAVIER_NOSELECT();
		Butt_L = new Button_CLAVIER_NOSELECT();
		Butt_Z = new Button_CLAVIER_NOSELECT();
		Butt_K = new Button_CLAVIER_NOSELECT();
		Butt_E = new Button_CLAVIER_NOSELECT();
		Butt_J = new Button_CLAVIER_NOSELECT();
		Butt_R = new Button_CLAVIER_NOSELECT();
		Butt_H = new Button_CLAVIER_NOSELECT();
		Butt_T = new Button_CLAVIER_NOSELECT();
		Butt_G = new Button_CLAVIER_NOSELECT();
		Butt_Y = new Button_CLAVIER_NOSELECT();
		Butt_F = new Button_CLAVIER_NOSELECT();
		Butt_U = new Button_CLAVIER_NOSELECT();
		Butt_D = new Button_CLAVIER_NOSELECT();
		Butt_I = new Button_CLAVIER_NOSELECT();
		Butt_S = new Button_CLAVIER_NOSELECT();
		Butt_O = new Button_CLAVIER_NOSELECT();
		Butt_Q = new Button_CLAVIER_NOSELECT();
		Butt_P = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Butt_ENTER = new Button_CLAVIER_NOSELECT();
		Butt_AR = new Button_CLAVIER_NOSELECT();
		Butt_SPACE = new Button_CLAVIER_NOSELECT();
		Butt_1_AR = new Button_CLAVIER_NOSELECT();
		Butt_2_AR = new Button_CLAVIER_NOSELECT();
		Butt_3_AR = new Button_CLAVIER_NOSELECT();
		Butt_4_AR = new Button_CLAVIER_NOSELECT();
		Butt_5_AR = new Button_CLAVIER_NOSELECT();
		Butt_6_AR = new Button_CLAVIER_NOSELECT();
		Butt_7_AR = new Button_CLAVIER_NOSELECT();
		Butt_8_AR = new Button_CLAVIER_NOSELECT();
		Butt_9_AR = new Button_CLAVIER_NOSELECT();
		Butt_0_AR = new Button_CLAVIER_NOSELECT();
		Butt_ك = new Button_CLAVIER_NOSELECT();
		Butt_ض = new Button_CLAVIER_NOSELECT();
		Butt_م = new Button_CLAVIER_NOSELECT();
		Butt_ص = new Button_CLAVIER_NOSELECT();
		Butt_ن = new Button_CLAVIER_NOSELECT();
		Butt_ث = new Button_CLAVIER_NOSELECT();
		Butt_ت = new Button_CLAVIER_NOSELECT();
		Butt_ق = new Button_CLAVIER_NOSELECT();
		Butt_ا = new Button_CLAVIER_NOSELECT();
		Butt_ف = new Button_CLAVIER_NOSELECT();
		Butt_ل = new Button_CLAVIER_NOSELECT();
		Butt_غ = new Button_CLAVIER_NOSELECT();
		Butt_ب = new Button_CLAVIER_NOSELECT();
		Butt_ع = new Button_CLAVIER_NOSELECT();
		Butt_ي = new Button_CLAVIER_NOSELECT();
		Butt_ه = new Button_CLAVIER_NOSELECT();
		Butt_س = new Button_CLAVIER_NOSELECT();
		Butt_خ = new Button_CLAVIER_NOSELECT();
		Butt_ش = new Button_CLAVIER_NOSELECT();
		Butt_ح = new Button_CLAVIER_NOSELECT();
		Butt_ج = new Button_CLAVIER_NOSELECT();
		Butt_BACK_AR = new Button_CLAVIER_NOSELECT();
		Butt_د = new Button_CLAVIER_NOSELECT();
		Butt_ذ = new Button_CLAVIER_NOSELECT();
		Butt_ط = new Button_CLAVIER_NOSELECT();
		Butt_DOT_AR = new Button_CLAVIER_NOSELECT();
		Butt_ظ = new Button_CLAVIER_NOSELECT();
		Butt_ز = new Button_CLAVIER_NOSELECT();
		Butt_و = new Button_CLAVIER_NOSELECT();
		Butt_ة = new Button_CLAVIER_NOSELECT();
		Butt_ى = new Button_CLAVIER_NOSELECT();
		Butt_لا = new Button_CLAVIER_NOSELECT();
		Butt_ر = new Button_CLAVIER_NOSELECT();
		Butt_ؤ = new Button_CLAVIER_NOSELECT();
		Butt_ء = new Button_CLAVIER_NOSELECT();
		Butt_ئ = new Button_CLAVIER_NOSELECT();
		Butt_ENTER_AR = new Button_CLAVIER_NOSELECT();
		Butt_FR = new Button_CLAVIER_NOSELECT();
		Butt_SPACE_AR = new Button_CLAVIER_NOSELECT();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel3).SuspendLayout();
		((Control)Panel_CLAVIER_AR).SuspendLayout();
		((Control)TableLayoutPanel4).SuspendLayout();
		((Control)TableLayoutPanel5).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel_CLAVIER).Anchor = (AnchorStyles)14;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel3);
		Panel panel_CLAVIER = Panel_CLAVIER;
		Point location = new Point(7, 45);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		Size size = new Size(666, 213);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1059;
		((Control)TableLayoutPanel2).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel2.ColumnCount = 12;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_DOT, 8, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_1, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_2, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_N, 7, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_3, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_B, 6, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_4, 3, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_V, 5, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_5, 4, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_C, 4, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_6, 5, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_X, 3, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_7, 6, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_W, 2, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_8, 7, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_9, 8, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_0, 9, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_M, 10, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_A, 0, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_L, 9, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Z, 1, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_K, 8, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_E, 2, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_J, 7, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_R, 3, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_H, 6, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_T, 4, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_G, 5, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Y, 5, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_F, 4, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_U, 6, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_D, 3, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_I, 7, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_S, 2, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_O, 8, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Q, 1, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_P, 9, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_BACK, 11, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_ENTER, 11, 3);
		((Control)TableLayoutPanel2).Dock = (DockStyle)5;
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel2;
		location = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel2;
		Padding padding = new Padding(1);
		((Control)tableLayoutPanel2).Padding = padding;
		TableLayoutPanel2.RowCount = 4;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel2;
		size = new Size(666, 162);
		((Control)tableLayoutPanel3).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1052;
		((Control)TableLayoutPanel3).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel3.ColumnCount = 3;
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel3.Controls.Add((Control)(object)Butt_AR, 0, 0);
		TableLayoutPanel3.Controls.Add((Control)(object)Butt_SPACE, 1, 0);
		((Control)TableLayoutPanel3).Dock = (DockStyle)2;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel3;
		location = new Point(0, 162);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel3).Name = "TableLayoutPanel3";
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel3;
		padding = new Padding(1);
		((Control)tableLayoutPanel5).Padding = padding;
		TableLayoutPanel3.RowCount = 1;
		TableLayoutPanel3.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel6 = TableLayoutPanel3;
		size = new Size(666, 51);
		((Control)tableLayoutPanel6).Size = size;
		((Control)TableLayoutPanel3).TabIndex = 1053;
		((Control)Panel_CLAVIER_AR).Anchor = (AnchorStyles)14;
		((Control)Panel_CLAVIER_AR).Controls.Add((Control)(object)TableLayoutPanel4);
		((Control)Panel_CLAVIER_AR).Controls.Add((Control)(object)TableLayoutPanel5);
		Panel panel_CLAVIER_AR = Panel_CLAVIER_AR;
		location = new Point(7, 45);
		((Control)panel_CLAVIER_AR).Location = location;
		((Control)Panel_CLAVIER_AR).Name = "Panel_CLAVIER_AR";
		Panel panel_CLAVIER_AR2 = Panel_CLAVIER_AR;
		size = new Size(666, 213);
		((Control)panel_CLAVIER_AR2).Size = size;
		((Control)Panel_CLAVIER_AR).TabIndex = 1060;
		((Control)TableLayoutPanel4).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel4.ColumnCount = 14;
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.143265f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.140406f));
		TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle((SizeType)2, 7.140406f));
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_1_AR, 0, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_2_AR, 1, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_3_AR, 2, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_4_AR, 3, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_5_AR, 4, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_6_AR, 5, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_7_AR, 6, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_8_AR, 7, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_9_AR, 8, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_0_AR, 9, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ك, 10, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ض, 0, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_م, 9, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ص, 1, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ن, 8, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ث, 2, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ت, 7, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ق, 3, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ا, 6, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ف, 4, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ل, 5, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_غ, 5, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ب, 4, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ع, 6, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ي, 3, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ه, 7, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_س, 2, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_خ, 8, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ش, 1, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ح, 9, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ج, 10, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_BACK_AR, 13, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_د, 11, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ذ, 12, 1);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ط, 11, 2);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_DOT_AR, 12, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ظ, 10, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ز, 9, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_و, 8, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ة, 7, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ى, 6, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_لا, 5, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ر, 4, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ؤ, 3, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ء, 2, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ئ, 1, 3);
		TableLayoutPanel4.Controls.Add((Control)(object)Butt_ENTER_AR, 13, 3);
		((Control)TableLayoutPanel4).Dock = (DockStyle)5;
		TableLayoutPanel tableLayoutPanel7 = TableLayoutPanel4;
		location = new Point(0, 0);
		((Control)tableLayoutPanel7).Location = location;
		((Control)TableLayoutPanel4).Name = "TableLayoutPanel4";
		TableLayoutPanel tableLayoutPanel8 = TableLayoutPanel4;
		padding = new Padding(1);
		((Control)tableLayoutPanel8).Padding = padding;
		TableLayoutPanel4.RowCount = 4;
		TableLayoutPanel4.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel4.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel4.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel4.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel tableLayoutPanel9 = TableLayoutPanel4;
		size = new Size(666, 162);
		((Control)tableLayoutPanel9).Size = size;
		((Control)TableLayoutPanel4).TabIndex = 1052;
		((Control)TableLayoutPanel5).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel5.ColumnCount = 3;
		TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel5.Controls.Add((Control)(object)Butt_FR, 0, 0);
		TableLayoutPanel5.Controls.Add((Control)(object)Butt_SPACE_AR, 1, 0);
		((Control)TableLayoutPanel5).Dock = (DockStyle)2;
		TableLayoutPanel tableLayoutPanel10 = TableLayoutPanel5;
		location = new Point(0, 162);
		((Control)tableLayoutPanel10).Location = location;
		((Control)TableLayoutPanel5).Name = "TableLayoutPanel5";
		TableLayoutPanel tableLayoutPanel11 = TableLayoutPanel5;
		padding = new Padding(1);
		((Control)tableLayoutPanel11).Padding = padding;
		TableLayoutPanel5.RowCount = 1;
		TableLayoutPanel5.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel12 = TableLayoutPanel5;
		size = new Size(666, 51);
		((Control)tableLayoutPanel12).Size = size;
		((Control)TableLayoutPanel5).TabIndex = 1053;
		((Control)Button244).Anchor = (AnchorStyles)9;
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((ButtonBase)Button244).FlatStyle = (FlatStyle)0;
		((Control)Button244).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button244).ForeColor = Color.White;
		((ButtonBase)Button244).ImageAlign = (ContentAlignment)2;
		Button button = Button244;
		location = new Point(599, 7);
		((Control)button).Location = location;
		Button button2 = Button244;
		padding = new Padding(0);
		((Control)button2).Margin = padding;
		((Control)Button244).Name = "Button244";
		Button button3 = Button244;
		size = new Size(74, 30);
		((Control)button3).Size = size;
		((Control)Button244).TabIndex = 1061;
		((ButtonBase)Button244).Text = "X";
		((ButtonBase)Button244).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		((Control)Label_BOTTOM).BackColor = Color.Black;
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 261);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(678, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1063;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.Black;
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 0);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 265);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1062;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.Black;
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(678, 4);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 257);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1065;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.Black;
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(4, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(678, 4);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 1064;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Butt_DOT).BackColor = Color.Transparent;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((Control)Butt_DOT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(441, 121);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		padding = new Padding(0);
		((Control)butt_DOT2).Margin = padding;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		size = new Size(55, 40);
		((Control)butt_DOT3).Size = size;
		((Control)Butt_DOT).TabIndex = 789;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.Transparent;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((Control)Butt_1).Dock = (DockStyle)5;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ = Butt_1;
		location = new Point(1, 1);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_1;
		padding = new Padding(0);
		((Control)butt_2).Margin = padding;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_3 = Butt_1;
		size = new Size(55, 40);
		((Control)butt_3).Size = size;
		((Control)Butt_1).TabIndex = 773;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.Transparent;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((Control)Butt_2).Dock = (DockStyle)5;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_4 = Butt_2;
		location = new Point(56, 1);
		((Control)butt_4).Location = location;
		Button_CLAVIER_NOSELECT butt_5 = Butt_2;
		padding = new Padding(0);
		((Control)butt_5).Margin = padding;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_6 = Butt_2;
		size = new Size(55, 40);
		((Control)butt_6).Size = size;
		((Control)Butt_2).TabIndex = 772;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_N).BackColor = Color.Transparent;
		((Control)Butt_N).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_N).Cursor = Cursors.Hand;
		((Control)Butt_N).Dock = (DockStyle)5;
		((ButtonBase)Butt_N).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_N).FlatStyle = (FlatStyle)0;
		((Control)Butt_N).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_N).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_N = Butt_N;
		location = new Point(386, 121);
		((Control)butt_N).Location = location;
		Button_CLAVIER_NOSELECT butt_N2 = Butt_N;
		padding = new Padding(0);
		((Control)butt_N2).Margin = padding;
		((Control)Butt_N).Name = "Butt_N";
		Button_CLAVIER_NOSELECT butt_N3 = Butt_N;
		size = new Size(55, 40);
		((Control)butt_N3).Size = size;
		((Control)Butt_N).TabIndex = 768;
		((ButtonBase)Butt_N).Text = "N";
		((ButtonBase)Butt_N).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_N).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.Transparent;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((Control)Butt_3).Dock = (DockStyle)5;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_7 = Butt_3;
		location = new Point(111, 1);
		((Control)butt_7).Location = location;
		Button_CLAVIER_NOSELECT butt_8 = Butt_3;
		padding = new Padding(0);
		((Control)butt_8).Margin = padding;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_9 = Butt_3;
		size = new Size(55, 40);
		((Control)butt_9).Size = size;
		((Control)Butt_3).TabIndex = 771;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_B).BackColor = Color.Transparent;
		((Control)Butt_B).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_B).Cursor = Cursors.Hand;
		((Control)Butt_B).Dock = (DockStyle)5;
		((ButtonBase)Butt_B).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_B).FlatStyle = (FlatStyle)0;
		((Control)Butt_B).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_B).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_B = Butt_B;
		location = new Point(331, 121);
		((Control)butt_B).Location = location;
		Button_CLAVIER_NOSELECT butt_B2 = Butt_B;
		padding = new Padding(0);
		((Control)butt_B2).Margin = padding;
		((Control)Butt_B).Name = "Butt_B";
		Button_CLAVIER_NOSELECT butt_B3 = Butt_B;
		size = new Size(55, 40);
		((Control)butt_B3).Size = size;
		((Control)Butt_B).TabIndex = 735;
		((ButtonBase)Butt_B).Text = "B";
		((ButtonBase)Butt_B).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_B).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.Transparent;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((Control)Butt_4).Dock = (DockStyle)5;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_10 = Butt_4;
		location = new Point(166, 1);
		((Control)butt_10).Location = location;
		Button_CLAVIER_NOSELECT butt_11 = Butt_4;
		padding = new Padding(0);
		((Control)butt_11).Margin = padding;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_12 = Butt_4;
		size = new Size(55, 40);
		((Control)butt_12).Size = size;
		((Control)Butt_4).TabIndex = 776;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_V).BackColor = Color.Transparent;
		((Control)Butt_V).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_V).Cursor = Cursors.Hand;
		((Control)Butt_V).Dock = (DockStyle)5;
		((ButtonBase)Butt_V).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_V).FlatStyle = (FlatStyle)0;
		((Control)Butt_V).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_V).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_V = Butt_V;
		location = new Point(276, 121);
		((Control)butt_V).Location = location;
		Button_CLAVIER_NOSELECT butt_V2 = Butt_V;
		padding = new Padding(0);
		((Control)butt_V2).Margin = padding;
		((Control)Butt_V).Name = "Butt_V";
		Button_CLAVIER_NOSELECT butt_V3 = Butt_V;
		size = new Size(55, 40);
		((Control)butt_V3).Size = size;
		((Control)Butt_V).TabIndex = 766;
		((ButtonBase)Butt_V).Text = "V";
		((ButtonBase)Butt_V).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_V).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.Transparent;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((Control)Butt_5).Dock = (DockStyle)5;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_13 = Butt_5;
		location = new Point(221, 1);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_5;
		padding = new Padding(0);
		((Control)butt_14).Margin = padding;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_15 = Butt_5;
		size = new Size(55, 40);
		((Control)butt_15).Size = size;
		((Control)Butt_5).TabIndex = 774;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_C).BackColor = Color.Transparent;
		((Control)Butt_C).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_C).Cursor = Cursors.Hand;
		((Control)Butt_C).Dock = (DockStyle)5;
		((ButtonBase)Butt_C).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_C).FlatStyle = (FlatStyle)0;
		((Control)Butt_C).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_C).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_C = Butt_C;
		location = new Point(221, 121);
		((Control)butt_C).Location = location;
		Button_CLAVIER_NOSELECT butt_C2 = Butt_C;
		padding = new Padding(0);
		((Control)butt_C2).Margin = padding;
		((Control)Butt_C).Name = "Butt_C";
		Button_CLAVIER_NOSELECT butt_C3 = Butt_C;
		size = new Size(55, 40);
		((Control)butt_C3).Size = size;
		((Control)Butt_C).TabIndex = 734;
		((ButtonBase)Butt_C).Text = "C";
		((ButtonBase)Butt_C).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_C).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.Transparent;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((Control)Butt_6).Dock = (DockStyle)5;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_16 = Butt_6;
		location = new Point(276, 1);
		((Control)butt_16).Location = location;
		Button_CLAVIER_NOSELECT butt_17 = Butt_6;
		padding = new Padding(0);
		((Control)butt_17).Margin = padding;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_18 = Butt_6;
		size = new Size(55, 40);
		((Control)butt_18).Size = size;
		((Control)Butt_6).TabIndex = 777;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_X).BackColor = Color.Transparent;
		((Control)Butt_X).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_X).Cursor = Cursors.Hand;
		((Control)Butt_X).Dock = (DockStyle)5;
		((ButtonBase)Butt_X).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_X).FlatStyle = (FlatStyle)0;
		((Control)Butt_X).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_X).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_X = Butt_X;
		location = new Point(166, 121);
		((Control)butt_X).Location = location;
		Button_CLAVIER_NOSELECT butt_X2 = Butt_X;
		padding = new Padding(0);
		((Control)butt_X2).Margin = padding;
		((Control)Butt_X).Name = "Butt_X";
		Button_CLAVIER_NOSELECT butt_X3 = Butt_X;
		size = new Size(55, 40);
		((Control)butt_X3).Size = size;
		((Control)Butt_X).TabIndex = 764;
		((ButtonBase)Butt_X).Text = "X";
		((ButtonBase)Butt_X).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_X).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.Transparent;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((Control)Butt_7).Dock = (DockStyle)5;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_19 = Butt_7;
		location = new Point(331, 1);
		((Control)butt_19).Location = location;
		Button_CLAVIER_NOSELECT butt_20 = Butt_7;
		padding = new Padding(0);
		((Control)butt_20).Margin = padding;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_21 = Butt_7;
		size = new Size(55, 40);
		((Control)butt_21).Size = size;
		((Control)Butt_7).TabIndex = 778;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_W).BackColor = Color.Transparent;
		((Control)Butt_W).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_W).Cursor = Cursors.Hand;
		((Control)Butt_W).Dock = (DockStyle)5;
		((ButtonBase)Butt_W).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_W).FlatStyle = (FlatStyle)0;
		((Control)Butt_W).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_W).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_W = Butt_W;
		location = new Point(111, 121);
		((Control)butt_W).Location = location;
		Button_CLAVIER_NOSELECT butt_W2 = Butt_W;
		padding = new Padding(0);
		((Control)butt_W2).Margin = padding;
		((Control)Butt_W).Name = "Butt_W";
		Button_CLAVIER_NOSELECT butt_W3 = Butt_W;
		size = new Size(55, 40);
		((Control)butt_W3).Size = size;
		((Control)Butt_W).TabIndex = 763;
		((ButtonBase)Butt_W).Text = "W";
		((ButtonBase)Butt_W).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_W).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.Transparent;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((Control)Butt_8).Dock = (DockStyle)5;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_22 = Butt_8;
		location = new Point(386, 1);
		((Control)butt_22).Location = location;
		Button_CLAVIER_NOSELECT butt_23 = Butt_8;
		padding = new Padding(0);
		((Control)butt_23).Margin = padding;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_24 = Butt_8;
		size = new Size(55, 40);
		((Control)butt_24).Size = size;
		((Control)Butt_8).TabIndex = 779;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.Transparent;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((Control)Butt_9).Dock = (DockStyle)5;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_25 = Butt_9;
		location = new Point(441, 1);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_9;
		padding = new Padding(0);
		((Control)butt_26).Margin = padding;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_27 = Butt_9;
		size = new Size(55, 40);
		((Control)butt_27).Size = size;
		((Control)Butt_9).TabIndex = 775;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.Transparent;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((Control)Butt_0).Dock = (DockStyle)5;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_28 = Butt_0;
		location = new Point(496, 1);
		((Control)butt_28).Location = location;
		Button_CLAVIER_NOSELECT butt_29 = Butt_0;
		padding = new Padding(0);
		((Control)butt_29).Margin = padding;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_30 = Butt_0;
		size = new Size(55, 40);
		((Control)butt_30).Size = size;
		((Control)Butt_0).TabIndex = 781;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_M).BackColor = Color.Transparent;
		((Control)Butt_M).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_M).Cursor = Cursors.Hand;
		((Control)Butt_M).Dock = (DockStyle)5;
		((ButtonBase)Butt_M).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_M).FlatStyle = (FlatStyle)0;
		((Control)Butt_M).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_M).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_M = Butt_M;
		location = new Point(551, 81);
		((Control)butt_M).Location = location;
		Button_CLAVIER_NOSELECT butt_M2 = Butt_M;
		padding = new Padding(0);
		((Control)butt_M2).Margin = padding;
		((Control)Butt_M).Name = "Butt_M";
		Button_CLAVIER_NOSELECT butt_M3 = Butt_M;
		size = new Size(55, 40);
		((Control)butt_M3).Size = size;
		((Control)Butt_M).TabIndex = 762;
		((ButtonBase)Butt_M).Text = "M";
		((ButtonBase)Butt_M).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_M).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_A).BackColor = Color.Transparent;
		((Control)Butt_A).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_A).CausesValidation = false;
		((Control)Butt_A).Cursor = Cursors.Hand;
		((Control)Butt_A).Dock = (DockStyle)5;
		((ButtonBase)Butt_A).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_A).FlatStyle = (FlatStyle)0;
		((Control)Butt_A).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_A).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_A = Butt_A;
		location = new Point(1, 41);
		((Control)butt_A).Location = location;
		Button_CLAVIER_NOSELECT butt_A2 = Butt_A;
		padding = new Padding(0);
		((Control)butt_A2).Margin = padding;
		((Control)Butt_A).Name = "Butt_A";
		Button_CLAVIER_NOSELECT butt_A3 = Butt_A;
		size = new Size(55, 40);
		((Control)butt_A3).Size = size;
		((Control)Butt_A).TabIndex = 743;
		((ButtonBase)Butt_A).Text = "A";
		((ButtonBase)Butt_A).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_A).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_L).BackColor = Color.Transparent;
		((Control)Butt_L).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_L).Cursor = Cursors.Hand;
		((Control)Butt_L).Dock = (DockStyle)5;
		((ButtonBase)Butt_L).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_L).FlatStyle = (FlatStyle)0;
		((Control)Butt_L).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_L).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_L = Butt_L;
		location = new Point(496, 81);
		((Control)butt_L).Location = location;
		Button_CLAVIER_NOSELECT butt_L2 = Butt_L;
		padding = new Padding(0);
		((Control)butt_L2).Margin = padding;
		((Control)Butt_L).Name = "Butt_L";
		Button_CLAVIER_NOSELECT butt_L3 = Butt_L;
		size = new Size(55, 40);
		((Control)butt_L3).Size = size;
		((Control)Butt_L).TabIndex = 761;
		((ButtonBase)Butt_L).Text = "L";
		((ButtonBase)Butt_L).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_L).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Z).BackColor = Color.Transparent;
		((Control)Butt_Z).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Z).Cursor = Cursors.Hand;
		((Control)Butt_Z).Dock = (DockStyle)5;
		((ButtonBase)Butt_Z).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Z).FlatStyle = (FlatStyle)0;
		((Control)Butt_Z).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Z).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Z = Butt_Z;
		location = new Point(56, 41);
		((Control)butt_Z).Location = location;
		Button_CLAVIER_NOSELECT butt_Z2 = Butt_Z;
		padding = new Padding(0);
		((Control)butt_Z2).Margin = padding;
		((Control)Butt_Z).Name = "Butt_Z";
		Button_CLAVIER_NOSELECT butt_Z3 = Butt_Z;
		size = new Size(55, 40);
		((Control)butt_Z3).Size = size;
		((Control)Butt_Z).TabIndex = 744;
		((ButtonBase)Butt_Z).Text = "Z";
		((ButtonBase)Butt_Z).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Z).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_K).BackColor = Color.Transparent;
		((Control)Butt_K).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_K).Cursor = Cursors.Hand;
		((Control)Butt_K).Dock = (DockStyle)5;
		((ButtonBase)Butt_K).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_K).FlatStyle = (FlatStyle)0;
		((Control)Butt_K).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_K).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_K = Butt_K;
		location = new Point(441, 81);
		((Control)butt_K).Location = location;
		Button_CLAVIER_NOSELECT butt_K2 = Butt_K;
		padding = new Padding(0);
		((Control)butt_K2).Margin = padding;
		((Control)Butt_K).Name = "Butt_K";
		Button_CLAVIER_NOSELECT butt_K3 = Butt_K;
		size = new Size(55, 40);
		((Control)butt_K3).Size = size;
		((Control)Butt_K).TabIndex = 760;
		((ButtonBase)Butt_K).Text = "K";
		((ButtonBase)Butt_K).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_K).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_E).BackColor = Color.Transparent;
		((Control)Butt_E).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_E).Cursor = Cursors.Hand;
		((Control)Butt_E).Dock = (DockStyle)5;
		((ButtonBase)Butt_E).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_E).FlatStyle = (FlatStyle)0;
		((Control)Butt_E).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_E).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_E = Butt_E;
		location = new Point(111, 41);
		((Control)butt_E).Location = location;
		Button_CLAVIER_NOSELECT butt_E2 = Butt_E;
		padding = new Padding(0);
		((Control)butt_E2).Margin = padding;
		((Control)Butt_E).Name = "Butt_E";
		Button_CLAVIER_NOSELECT butt_E3 = Butt_E;
		size = new Size(55, 40);
		((Control)butt_E3).Size = size;
		((Control)Butt_E).TabIndex = 745;
		((ButtonBase)Butt_E).Text = "E";
		((ButtonBase)Butt_E).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_E).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_J).BackColor = Color.Transparent;
		((Control)Butt_J).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_J).Cursor = Cursors.Hand;
		((Control)Butt_J).Dock = (DockStyle)5;
		((ButtonBase)Butt_J).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_J).FlatStyle = (FlatStyle)0;
		((Control)Butt_J).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_J).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_J = Butt_J;
		location = new Point(386, 81);
		((Control)butt_J).Location = location;
		Button_CLAVIER_NOSELECT butt_J2 = Butt_J;
		padding = new Padding(0);
		((Control)butt_J2).Margin = padding;
		((Control)Butt_J).Name = "Butt_J";
		Button_CLAVIER_NOSELECT butt_J3 = Butt_J;
		size = new Size(55, 40);
		((Control)butt_J3).Size = size;
		((Control)Butt_J).TabIndex = 759;
		((ButtonBase)Butt_J).Text = "J";
		((ButtonBase)Butt_J).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_J).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_R).BackColor = Color.Transparent;
		((Control)Butt_R).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_R).Cursor = Cursors.Hand;
		((Control)Butt_R).Dock = (DockStyle)5;
		((ButtonBase)Butt_R).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_R).FlatStyle = (FlatStyle)0;
		((Control)Butt_R).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_R).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_R = Butt_R;
		location = new Point(166, 41);
		((Control)butt_R).Location = location;
		Button_CLAVIER_NOSELECT butt_R2 = Butt_R;
		padding = new Padding(0);
		((Control)butt_R2).Margin = padding;
		((Control)Butt_R).Name = "Butt_R";
		Button_CLAVIER_NOSELECT butt_R3 = Butt_R;
		size = new Size(55, 40);
		((Control)butt_R3).Size = size;
		((Control)Butt_R).TabIndex = 746;
		((ButtonBase)Butt_R).Text = "R";
		((ButtonBase)Butt_R).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_R).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_H).BackColor = Color.Transparent;
		((Control)Butt_H).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_H).Cursor = Cursors.Hand;
		((Control)Butt_H).Dock = (DockStyle)5;
		((ButtonBase)Butt_H).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_H).FlatStyle = (FlatStyle)0;
		((Control)Butt_H).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_H).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_H = Butt_H;
		location = new Point(331, 81);
		((Control)butt_H).Location = location;
		Button_CLAVIER_NOSELECT butt_H2 = Butt_H;
		padding = new Padding(0);
		((Control)butt_H2).Margin = padding;
		((Control)Butt_H).Name = "Butt_H";
		Button_CLAVIER_NOSELECT butt_H3 = Butt_H;
		size = new Size(55, 40);
		((Control)butt_H3).Size = size;
		((Control)Butt_H).TabIndex = 758;
		((ButtonBase)Butt_H).Text = "H";
		((ButtonBase)Butt_H).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_H).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_T).BackColor = Color.Transparent;
		((Control)Butt_T).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_T).Cursor = Cursors.Hand;
		((Control)Butt_T).Dock = (DockStyle)5;
		((ButtonBase)Butt_T).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_T).FlatStyle = (FlatStyle)0;
		((Control)Butt_T).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_T).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_T = Butt_T;
		location = new Point(221, 41);
		((Control)butt_T).Location = location;
		Button_CLAVIER_NOSELECT butt_T2 = Butt_T;
		padding = new Padding(0);
		((Control)butt_T2).Margin = padding;
		((Control)Butt_T).Name = "Butt_T";
		Button_CLAVIER_NOSELECT butt_T3 = Butt_T;
		size = new Size(55, 40);
		((Control)butt_T3).Size = size;
		((Control)Butt_T).TabIndex = 747;
		((ButtonBase)Butt_T).Text = "T";
		((ButtonBase)Butt_T).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_T).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_G).BackColor = Color.Transparent;
		((Control)Butt_G).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_G).Cursor = Cursors.Hand;
		((Control)Butt_G).Dock = (DockStyle)5;
		((ButtonBase)Butt_G).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_G).FlatStyle = (FlatStyle)0;
		((Control)Butt_G).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_G).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_G = Butt_G;
		location = new Point(276, 81);
		((Control)butt_G).Location = location;
		Button_CLAVIER_NOSELECT butt_G2 = Butt_G;
		padding = new Padding(0);
		((Control)butt_G2).Margin = padding;
		((Control)Butt_G).Name = "Butt_G";
		Button_CLAVIER_NOSELECT butt_G3 = Butt_G;
		size = new Size(55, 40);
		((Control)butt_G3).Size = size;
		((Control)Butt_G).TabIndex = 757;
		((ButtonBase)Butt_G).Text = "G";
		((ButtonBase)Butt_G).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_G).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Y).BackColor = Color.Transparent;
		((Control)Butt_Y).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Y).Cursor = Cursors.Hand;
		((Control)Butt_Y).Dock = (DockStyle)5;
		((ButtonBase)Butt_Y).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Y).FlatStyle = (FlatStyle)0;
		((Control)Butt_Y).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Y).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Y = Butt_Y;
		location = new Point(276, 41);
		((Control)butt_Y).Location = location;
		Button_CLAVIER_NOSELECT butt_Y2 = Butt_Y;
		padding = new Padding(0);
		((Control)butt_Y2).Margin = padding;
		((Control)Butt_Y).Name = "Butt_Y";
		Button_CLAVIER_NOSELECT butt_Y3 = Butt_Y;
		size = new Size(55, 40);
		((Control)butt_Y3).Size = size;
		((Control)Butt_Y).TabIndex = 748;
		((ButtonBase)Butt_Y).Text = "Y";
		((ButtonBase)Butt_Y).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Y).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_F).BackColor = Color.Transparent;
		((Control)Butt_F).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_F).Cursor = Cursors.Hand;
		((Control)Butt_F).Dock = (DockStyle)5;
		((ButtonBase)Butt_F).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_F).FlatStyle = (FlatStyle)0;
		((Control)Butt_F).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_F).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_F = Butt_F;
		location = new Point(221, 81);
		((Control)butt_F).Location = location;
		Button_CLAVIER_NOSELECT butt_F2 = Butt_F;
		padding = new Padding(0);
		((Control)butt_F2).Margin = padding;
		((Control)Butt_F).Name = "Butt_F";
		Button_CLAVIER_NOSELECT butt_F3 = Butt_F;
		size = new Size(55, 40);
		((Control)butt_F3).Size = size;
		((Control)Butt_F).TabIndex = 756;
		((ButtonBase)Butt_F).Text = "F";
		((ButtonBase)Butt_F).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_F).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_U).BackColor = Color.Transparent;
		((Control)Butt_U).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_U).Cursor = Cursors.Hand;
		((Control)Butt_U).Dock = (DockStyle)5;
		((ButtonBase)Butt_U).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_U).FlatStyle = (FlatStyle)0;
		((Control)Butt_U).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_U).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_U = Butt_U;
		location = new Point(331, 41);
		((Control)butt_U).Location = location;
		Button_CLAVIER_NOSELECT butt_U2 = Butt_U;
		padding = new Padding(0);
		((Control)butt_U2).Margin = padding;
		((Control)Butt_U).Name = "Butt_U";
		Button_CLAVIER_NOSELECT butt_U3 = Butt_U;
		size = new Size(55, 40);
		((Control)butt_U3).Size = size;
		((Control)Butt_U).TabIndex = 749;
		((ButtonBase)Butt_U).Text = "U";
		((ButtonBase)Butt_U).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_U).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_D).BackColor = Color.Transparent;
		((Control)Butt_D).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_D).Cursor = Cursors.Hand;
		((Control)Butt_D).Dock = (DockStyle)5;
		((ButtonBase)Butt_D).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_D).FlatStyle = (FlatStyle)0;
		((Control)Butt_D).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_D).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_D = Butt_D;
		location = new Point(166, 81);
		((Control)butt_D).Location = location;
		Button_CLAVIER_NOSELECT butt_D2 = Butt_D;
		padding = new Padding(0);
		((Control)butt_D2).Margin = padding;
		((Control)Butt_D).Name = "Butt_D";
		Button_CLAVIER_NOSELECT butt_D3 = Butt_D;
		size = new Size(55, 40);
		((Control)butt_D3).Size = size;
		((Control)Butt_D).TabIndex = 755;
		((ButtonBase)Butt_D).Text = "D";
		((ButtonBase)Butt_D).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_D).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_I).BackColor = Color.Transparent;
		((Control)Butt_I).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_I).Cursor = Cursors.Hand;
		((Control)Butt_I).Dock = (DockStyle)5;
		((ButtonBase)Butt_I).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_I).FlatStyle = (FlatStyle)0;
		((Control)Butt_I).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_I).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_I = Butt_I;
		location = new Point(386, 41);
		((Control)butt_I).Location = location;
		Button_CLAVIER_NOSELECT butt_I2 = Butt_I;
		padding = new Padding(0);
		((Control)butt_I2).Margin = padding;
		((Control)Butt_I).Name = "Butt_I";
		Button_CLAVIER_NOSELECT butt_I3 = Butt_I;
		size = new Size(55, 40);
		((Control)butt_I3).Size = size;
		((Control)Butt_I).TabIndex = 750;
		((ButtonBase)Butt_I).Text = "I";
		((ButtonBase)Butt_I).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_I).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_S).BackColor = Color.Transparent;
		((Control)Butt_S).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_S).Cursor = Cursors.Hand;
		((Control)Butt_S).Dock = (DockStyle)5;
		((ButtonBase)Butt_S).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_S).FlatStyle = (FlatStyle)0;
		((Control)Butt_S).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_S).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_S = Butt_S;
		location = new Point(111, 81);
		((Control)butt_S).Location = location;
		Button_CLAVIER_NOSELECT butt_S2 = Butt_S;
		padding = new Padding(0);
		((Control)butt_S2).Margin = padding;
		((Control)Butt_S).Name = "Butt_S";
		Button_CLAVIER_NOSELECT butt_S3 = Butt_S;
		size = new Size(55, 40);
		((Control)butt_S3).Size = size;
		((Control)Butt_S).TabIndex = 754;
		((ButtonBase)Butt_S).Text = "S";
		((ButtonBase)Butt_S).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_S).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_O).BackColor = Color.Transparent;
		((Control)Butt_O).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_O).Cursor = Cursors.Hand;
		((Control)Butt_O).Dock = (DockStyle)5;
		((ButtonBase)Butt_O).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_O).FlatStyle = (FlatStyle)0;
		((Control)Butt_O).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_O).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_O = Butt_O;
		location = new Point(441, 41);
		((Control)butt_O).Location = location;
		Button_CLAVIER_NOSELECT butt_O2 = Butt_O;
		padding = new Padding(0);
		((Control)butt_O2).Margin = padding;
		((Control)Butt_O).Name = "Butt_O";
		Button_CLAVIER_NOSELECT butt_O3 = Butt_O;
		size = new Size(55, 40);
		((Control)butt_O3).Size = size;
		((Control)Butt_O).TabIndex = 751;
		((ButtonBase)Butt_O).Text = "O";
		((ButtonBase)Butt_O).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_O).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Q).BackColor = Color.Transparent;
		((Control)Butt_Q).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Q).Cursor = Cursors.Hand;
		((Control)Butt_Q).Dock = (DockStyle)5;
		((ButtonBase)Butt_Q).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Q).FlatStyle = (FlatStyle)0;
		((Control)Butt_Q).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Q).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Q = Butt_Q;
		location = new Point(56, 81);
		((Control)butt_Q).Location = location;
		Button_CLAVIER_NOSELECT butt_Q2 = Butt_Q;
		padding = new Padding(0);
		((Control)butt_Q2).Margin = padding;
		((Control)Butt_Q).Name = "Butt_Q";
		Button_CLAVIER_NOSELECT butt_Q3 = Butt_Q;
		size = new Size(55, 40);
		((Control)butt_Q3).Size = size;
		((Control)Butt_Q).TabIndex = 753;
		((ButtonBase)Butt_Q).Text = "Q";
		((ButtonBase)Butt_Q).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Q).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_P).BackColor = Color.Transparent;
		((Control)Butt_P).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_P).Cursor = Cursors.Hand;
		((Control)Butt_P).Dock = (DockStyle)5;
		((ButtonBase)Butt_P).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_P).FlatStyle = (FlatStyle)0;
		((Control)Butt_P).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_P).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_P = Butt_P;
		location = new Point(496, 41);
		((Control)butt_P).Location = location;
		Button_CLAVIER_NOSELECT butt_P2 = Butt_P;
		padding = new Padding(0);
		((Control)butt_P2).Margin = padding;
		((Control)Butt_P).Name = "Butt_P";
		Button_CLAVIER_NOSELECT butt_P3 = Butt_P;
		size = new Size(55, 40);
		((Control)butt_P3).Size = size;
		((Control)Butt_P).TabIndex = 752;
		((ButtonBase)Butt_P).Text = "P";
		((ButtonBase)Butt_P).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_P).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.Transparent;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((Control)Butt_BACK).Dock = (DockStyle)5;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.White;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(606, 1);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		padding = new Padding(0);
		((Control)butt_BACK2).Margin = padding;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(59, 40);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 769;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ENTER).BackColor = Color.Transparent;
		((Control)Butt_ENTER).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ENTER).Cursor = Cursors.Hand;
		((Control)Butt_ENTER).Dock = (DockStyle)5;
		((ButtonBase)Butt_ENTER).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ENTER).FlatStyle = (FlatStyle)0;
		((Control)Butt_ENTER).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_ENTER).ForeColor = Color.White;
		((ButtonBase)Butt_ENTER).Image = (Image)componentResourceManager.GetObject("Butt_ENTER.Image");
		Button_CLAVIER_NOSELECT butt_ENTER = Butt_ENTER;
		location = new Point(606, 121);
		((Control)butt_ENTER).Location = location;
		Button_CLAVIER_NOSELECT butt_ENTER2 = Butt_ENTER;
		padding = new Padding(0);
		((Control)butt_ENTER2).Margin = padding;
		((Control)Butt_ENTER).Name = "Butt_ENTER";
		Button_CLAVIER_NOSELECT butt_ENTER3 = Butt_ENTER;
		size = new Size(59, 40);
		((Control)butt_ENTER3).Size = size;
		((Control)Butt_ENTER).TabIndex = 790;
		((ButtonBase)Butt_ENTER).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_AR).BackColor = Color.Transparent;
		((Control)Butt_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_AR).Cursor = Cursors.Hand;
		((Control)Butt_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_AR).ForeColor = Color.White;
		((ButtonBase)Butt_AR).Image = (Image)componentResourceManager.GetObject("Butt_AR.Image");
		Button_CLAVIER_NOSELECT butt_AR = Butt_AR;
		location = new Point(1, 1);
		((Control)butt_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_AR2 = Butt_AR;
		padding = new Padding(0);
		((Control)butt_AR2).Margin = padding;
		((Control)Butt_AR).Name = "Butt_AR";
		Button_CLAVIER_NOSELECT butt_AR3 = Butt_AR;
		size = new Size(100, 49);
		((Control)butt_AR3).Size = size;
		((Control)Butt_AR).TabIndex = 791;
		((ButtonBase)Butt_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_SPACE).BackColor = Color.Transparent;
		((Control)Butt_SPACE).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_SPACE).Cursor = Cursors.Hand;
		((Control)Butt_SPACE).Dock = (DockStyle)5;
		((ButtonBase)Butt_SPACE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_SPACE).FlatStyle = (FlatStyle)0;
		((Control)Butt_SPACE).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_SPACE).ForeColor = Color.Black;
		((ButtonBase)Butt_SPACE).Image = (Image)componentResourceManager.GetObject("Butt_SPACE.Image");
		Button_CLAVIER_NOSELECT butt_SPACE = Butt_SPACE;
		location = new Point(101, 1);
		((Control)butt_SPACE).Location = location;
		Button_CLAVIER_NOSELECT butt_SPACE2 = Butt_SPACE;
		padding = new Padding(0);
		((Control)butt_SPACE2).Margin = padding;
		((Control)Butt_SPACE).Name = "Butt_SPACE";
		Button_CLAVIER_NOSELECT butt_SPACE3 = Butt_SPACE;
		size = new Size(464, 49);
		((Control)butt_SPACE3).Size = size;
		((Control)Butt_SPACE).TabIndex = 785;
		((ButtonBase)Butt_SPACE).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1_AR).BackColor = Color.Transparent;
		((Control)Butt_1_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1_AR).CausesValidation = false;
		((Control)Butt_1_AR).Cursor = Cursors.Hand;
		((Control)Butt_1_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_1_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_1_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_1_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_1_AR = Butt_1_AR;
		location = new Point(1, 1);
		((Control)butt_1_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_1_AR2 = Butt_1_AR;
		padding = new Padding(0);
		((Control)butt_1_AR2).Margin = padding;
		((Control)Butt_1_AR).Name = "Butt_1_AR";
		Button_CLAVIER_NOSELECT butt_1_AR3 = Butt_1_AR;
		size = new Size(47, 40);
		((Control)butt_1_AR3).Size = size;
		((Control)Butt_1_AR).TabIndex = 773;
		((ButtonBase)Butt_1_AR).Text = "1";
		((ButtonBase)Butt_1_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_1_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2_AR).BackColor = Color.Transparent;
		((Control)Butt_2_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2_AR).Cursor = Cursors.Hand;
		((Control)Butt_2_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_2_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_2_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_2_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_2_AR = Butt_2_AR;
		location = new Point(48, 1);
		((Control)butt_2_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_2_AR2 = Butt_2_AR;
		padding = new Padding(0);
		((Control)butt_2_AR2).Margin = padding;
		((Control)Butt_2_AR).Name = "Butt_2_AR";
		Button_CLAVIER_NOSELECT butt_2_AR3 = Butt_2_AR;
		size = new Size(47, 40);
		((Control)butt_2_AR3).Size = size;
		((Control)Butt_2_AR).TabIndex = 772;
		((ButtonBase)Butt_2_AR).Text = "2";
		((ButtonBase)Butt_2_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_2_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3_AR).BackColor = Color.Transparent;
		((Control)Butt_3_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3_AR).Cursor = Cursors.Hand;
		((Control)Butt_3_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_3_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_3_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_3_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_3_AR = Butt_3_AR;
		location = new Point(95, 1);
		((Control)butt_3_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_3_AR2 = Butt_3_AR;
		padding = new Padding(0);
		((Control)butt_3_AR2).Margin = padding;
		((Control)Butt_3_AR).Name = "Butt_3_AR";
		Button_CLAVIER_NOSELECT butt_3_AR3 = Butt_3_AR;
		size = new Size(47, 40);
		((Control)butt_3_AR3).Size = size;
		((Control)Butt_3_AR).TabIndex = 771;
		((ButtonBase)Butt_3_AR).Text = "3";
		((ButtonBase)Butt_3_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_3_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4_AR).BackColor = Color.Transparent;
		((Control)Butt_4_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4_AR).Cursor = Cursors.Hand;
		((Control)Butt_4_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_4_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_4_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_4_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_4_AR = Butt_4_AR;
		location = new Point(142, 1);
		((Control)butt_4_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_4_AR2 = Butt_4_AR;
		padding = new Padding(0);
		((Control)butt_4_AR2).Margin = padding;
		((Control)Butt_4_AR).Name = "Butt_4_AR";
		Button_CLAVIER_NOSELECT butt_4_AR3 = Butt_4_AR;
		size = new Size(47, 40);
		((Control)butt_4_AR3).Size = size;
		((Control)Butt_4_AR).TabIndex = 776;
		((ButtonBase)Butt_4_AR).Text = "4";
		((ButtonBase)Butt_4_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_4_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5_AR).BackColor = Color.Transparent;
		((Control)Butt_5_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5_AR).Cursor = Cursors.Hand;
		((Control)Butt_5_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_5_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_5_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_5_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_5_AR = Butt_5_AR;
		location = new Point(189, 1);
		((Control)butt_5_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_5_AR2 = Butt_5_AR;
		padding = new Padding(0);
		((Control)butt_5_AR2).Margin = padding;
		((Control)Butt_5_AR).Name = "Butt_5_AR";
		Button_CLAVIER_NOSELECT butt_5_AR3 = Butt_5_AR;
		size = new Size(47, 40);
		((Control)butt_5_AR3).Size = size;
		((Control)Butt_5_AR).TabIndex = 774;
		((ButtonBase)Butt_5_AR).Text = "5";
		((ButtonBase)Butt_5_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_5_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6_AR).BackColor = Color.Transparent;
		((Control)Butt_6_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6_AR).Cursor = Cursors.Hand;
		((Control)Butt_6_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_6_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_6_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_6_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_6_AR = Butt_6_AR;
		location = new Point(236, 1);
		((Control)butt_6_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_6_AR2 = Butt_6_AR;
		padding = new Padding(0);
		((Control)butt_6_AR2).Margin = padding;
		((Control)Butt_6_AR).Name = "Butt_6_AR";
		Button_CLAVIER_NOSELECT butt_6_AR3 = Butt_6_AR;
		size = new Size(47, 40);
		((Control)butt_6_AR3).Size = size;
		((Control)Butt_6_AR).TabIndex = 777;
		((ButtonBase)Butt_6_AR).Text = "6";
		((ButtonBase)Butt_6_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_6_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7_AR).BackColor = Color.Transparent;
		((Control)Butt_7_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7_AR).Cursor = Cursors.Hand;
		((Control)Butt_7_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_7_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_7_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_7_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_7_AR = Butt_7_AR;
		location = new Point(283, 1);
		((Control)butt_7_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_7_AR2 = Butt_7_AR;
		padding = new Padding(0);
		((Control)butt_7_AR2).Margin = padding;
		((Control)Butt_7_AR).Name = "Butt_7_AR";
		Button_CLAVIER_NOSELECT butt_7_AR3 = Butt_7_AR;
		size = new Size(47, 40);
		((Control)butt_7_AR3).Size = size;
		((Control)Butt_7_AR).TabIndex = 778;
		((ButtonBase)Butt_7_AR).Text = "7";
		((ButtonBase)Butt_7_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_7_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8_AR).BackColor = Color.Transparent;
		((Control)Butt_8_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8_AR).Cursor = Cursors.Hand;
		((Control)Butt_8_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_8_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_8_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_8_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_8_AR = Butt_8_AR;
		location = new Point(330, 1);
		((Control)butt_8_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_8_AR2 = Butt_8_AR;
		padding = new Padding(0);
		((Control)butt_8_AR2).Margin = padding;
		((Control)Butt_8_AR).Name = "Butt_8_AR";
		Button_CLAVIER_NOSELECT butt_8_AR3 = Butt_8_AR;
		size = new Size(47, 40);
		((Control)butt_8_AR3).Size = size;
		((Control)Butt_8_AR).TabIndex = 779;
		((ButtonBase)Butt_8_AR).Text = "8";
		((ButtonBase)Butt_8_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_8_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9_AR).BackColor = Color.Transparent;
		((Control)Butt_9_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9_AR).Cursor = Cursors.Hand;
		((Control)Butt_9_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_9_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_9_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_9_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_9_AR = Butt_9_AR;
		location = new Point(377, 1);
		((Control)butt_9_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_9_AR2 = Butt_9_AR;
		padding = new Padding(0);
		((Control)butt_9_AR2).Margin = padding;
		((Control)Butt_9_AR).Name = "Butt_9_AR";
		Button_CLAVIER_NOSELECT butt_9_AR3 = Butt_9_AR;
		size = new Size(47, 40);
		((Control)butt_9_AR3).Size = size;
		((Control)Butt_9_AR).TabIndex = 775;
		((ButtonBase)Butt_9_AR).Text = "9";
		((ButtonBase)Butt_9_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_9_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0_AR).BackColor = Color.Transparent;
		((Control)Butt_0_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0_AR).Cursor = Cursors.Hand;
		((Control)Butt_0_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_0_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_0_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_0_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_0_AR = Butt_0_AR;
		location = new Point(424, 1);
		((Control)butt_0_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_0_AR2 = Butt_0_AR;
		padding = new Padding(0);
		((Control)butt_0_AR2).Margin = padding;
		((Control)Butt_0_AR).Name = "Butt_0_AR";
		Button_CLAVIER_NOSELECT butt_0_AR3 = Butt_0_AR;
		size = new Size(47, 40);
		((Control)butt_0_AR3).Size = size;
		((Control)Butt_0_AR).TabIndex = 781;
		((ButtonBase)Butt_0_AR).Text = "0";
		((ButtonBase)Butt_0_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_0_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ك).BackColor = Color.Transparent;
		((Control)Butt_ك).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ك).Cursor = Cursors.Hand;
		((Control)Butt_ك).Dock = (DockStyle)5;
		((ButtonBase)Butt_ك).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ك).FlatStyle = (FlatStyle)0;
		((Control)Butt_ك).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ك).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ك = Butt_ك;
		location = new Point(471, 81);
		((Control)butt_ك).Location = location;
		Button_CLAVIER_NOSELECT butt_ك2 = Butt_ك;
		padding = new Padding(0);
		((Control)butt_ك2).Margin = padding;
		((Control)Butt_ك).Name = "Butt_ك";
		Button_CLAVIER_NOSELECT butt_ك3 = Butt_ك;
		size = new Size(47, 40);
		((Control)butt_ك3).Size = size;
		((Control)Butt_ك).TabIndex = 762;
		((ButtonBase)Butt_ك).Text = "ك";
		((ButtonBase)Butt_ك).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ك).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ض).BackColor = Color.Transparent;
		((Control)Butt_ض).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ض).CausesValidation = false;
		((Control)Butt_ض).Cursor = Cursors.Hand;
		((Control)Butt_ض).Dock = (DockStyle)5;
		((ButtonBase)Butt_ض).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ض).FlatStyle = (FlatStyle)0;
		((Control)Butt_ض).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ض).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ض = Butt_ض;
		location = new Point(1, 41);
		((Control)butt_ض).Location = location;
		Button_CLAVIER_NOSELECT butt_ض2 = Butt_ض;
		padding = new Padding(0);
		((Control)butt_ض2).Margin = padding;
		((Control)Butt_ض).Name = "Butt_ض";
		Button_CLAVIER_NOSELECT butt_ض3 = Butt_ض;
		size = new Size(47, 40);
		((Control)butt_ض3).Size = size;
		((Control)Butt_ض).TabIndex = 743;
		((ButtonBase)Butt_ض).Text = "ض";
		((ButtonBase)Butt_ض).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ض).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_م).BackColor = Color.Transparent;
		((Control)Butt_م).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_م).Cursor = Cursors.Hand;
		((Control)Butt_م).Dock = (DockStyle)5;
		((ButtonBase)Butt_م).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_م).FlatStyle = (FlatStyle)0;
		((Control)Butt_م).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_م).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_م = Butt_م;
		location = new Point(424, 81);
		((Control)butt_م).Location = location;
		Button_CLAVIER_NOSELECT butt_م2 = Butt_م;
		padding = new Padding(0);
		((Control)butt_م2).Margin = padding;
		((Control)Butt_م).Name = "Butt_م";
		Button_CLAVIER_NOSELECT butt_م3 = Butt_م;
		size = new Size(47, 40);
		((Control)butt_م3).Size = size;
		((Control)Butt_م).TabIndex = 761;
		((ButtonBase)Butt_م).Text = "م";
		((ButtonBase)Butt_م).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_م).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ص).BackColor = Color.Transparent;
		((Control)Butt_ص).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ص).Cursor = Cursors.Hand;
		((Control)Butt_ص).Dock = (DockStyle)5;
		((ButtonBase)Butt_ص).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ص).FlatStyle = (FlatStyle)0;
		((Control)Butt_ص).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ص).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ص = Butt_ص;
		location = new Point(48, 41);
		((Control)butt_ص).Location = location;
		Button_CLAVIER_NOSELECT butt_ص2 = Butt_ص;
		padding = new Padding(0);
		((Control)butt_ص2).Margin = padding;
		((Control)Butt_ص).Name = "Butt_ص";
		Button_CLAVIER_NOSELECT butt_ص3 = Butt_ص;
		size = new Size(47, 40);
		((Control)butt_ص3).Size = size;
		((Control)Butt_ص).TabIndex = 744;
		((ButtonBase)Butt_ص).Text = "ص";
		((ButtonBase)Butt_ص).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ص).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ن).BackColor = Color.Transparent;
		((Control)Butt_ن).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ن).Cursor = Cursors.Hand;
		((Control)Butt_ن).Dock = (DockStyle)5;
		((ButtonBase)Butt_ن).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ن).FlatStyle = (FlatStyle)0;
		((Control)Butt_ن).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ن).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ن = Butt_ن;
		location = new Point(377, 81);
		((Control)butt_ن).Location = location;
		Button_CLAVIER_NOSELECT butt_ن2 = Butt_ن;
		padding = new Padding(0);
		((Control)butt_ن2).Margin = padding;
		((Control)Butt_ن).Name = "Butt_ن";
		Button_CLAVIER_NOSELECT butt_ن3 = Butt_ن;
		size = new Size(47, 40);
		((Control)butt_ن3).Size = size;
		((Control)Butt_ن).TabIndex = 760;
		((ButtonBase)Butt_ن).Text = "ن";
		((ButtonBase)Butt_ن).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ن).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ث).BackColor = Color.Transparent;
		((Control)Butt_ث).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ث).Cursor = Cursors.Hand;
		((Control)Butt_ث).Dock = (DockStyle)5;
		((ButtonBase)Butt_ث).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ث).FlatStyle = (FlatStyle)0;
		((Control)Butt_ث).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ث).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ث = Butt_ث;
		location = new Point(95, 41);
		((Control)butt_ث).Location = location;
		Button_CLAVIER_NOSELECT butt_ث2 = Butt_ث;
		padding = new Padding(0);
		((Control)butt_ث2).Margin = padding;
		((Control)Butt_ث).Name = "Butt_ث";
		Button_CLAVIER_NOSELECT butt_ث3 = Butt_ث;
		size = new Size(47, 40);
		((Control)butt_ث3).Size = size;
		((Control)Butt_ث).TabIndex = 745;
		((ButtonBase)Butt_ث).Text = "ث";
		((ButtonBase)Butt_ث).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ث).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ت).BackColor = Color.Transparent;
		((Control)Butt_ت).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ت).Cursor = Cursors.Hand;
		((Control)Butt_ت).Dock = (DockStyle)5;
		((ButtonBase)Butt_ت).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ت).FlatStyle = (FlatStyle)0;
		((Control)Butt_ت).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ت).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ت = Butt_ت;
		location = new Point(330, 81);
		((Control)butt_ت).Location = location;
		Button_CLAVIER_NOSELECT butt_ت2 = Butt_ت;
		padding = new Padding(0);
		((Control)butt_ت2).Margin = padding;
		((Control)Butt_ت).Name = "Butt_ت";
		Button_CLAVIER_NOSELECT butt_ت3 = Butt_ت;
		size = new Size(47, 40);
		((Control)butt_ت3).Size = size;
		((Control)Butt_ت).TabIndex = 759;
		((ButtonBase)Butt_ت).Text = "ت";
		((ButtonBase)Butt_ت).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ت).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ق).BackColor = Color.Transparent;
		((Control)Butt_ق).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ق).Cursor = Cursors.Hand;
		((Control)Butt_ق).Dock = (DockStyle)5;
		((ButtonBase)Butt_ق).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ق).FlatStyle = (FlatStyle)0;
		((Control)Butt_ق).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ق).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ق = Butt_ق;
		location = new Point(142, 41);
		((Control)butt_ق).Location = location;
		Button_CLAVIER_NOSELECT butt_ق2 = Butt_ق;
		padding = new Padding(0);
		((Control)butt_ق2).Margin = padding;
		((Control)Butt_ق).Name = "Butt_ق";
		Button_CLAVIER_NOSELECT butt_ق3 = Butt_ق;
		size = new Size(47, 40);
		((Control)butt_ق3).Size = size;
		((Control)Butt_ق).TabIndex = 746;
		((ButtonBase)Butt_ق).Text = "ق";
		((ButtonBase)Butt_ق).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ق).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ا).BackColor = Color.Transparent;
		((Control)Butt_ا).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ا).Cursor = Cursors.Hand;
		((Control)Butt_ا).Dock = (DockStyle)5;
		((ButtonBase)Butt_ا).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ا).FlatStyle = (FlatStyle)0;
		((Control)Butt_ا).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ا).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ا = Butt_ا;
		location = new Point(283, 81);
		((Control)butt_ا).Location = location;
		Button_CLAVIER_NOSELECT butt_ا2 = Butt_ا;
		padding = new Padding(0);
		((Control)butt_ا2).Margin = padding;
		((Control)Butt_ا).Name = "Butt_ا";
		Button_CLAVIER_NOSELECT butt_ا3 = Butt_ا;
		size = new Size(47, 40);
		((Control)butt_ا3).Size = size;
		((Control)Butt_ا).TabIndex = 758;
		((ButtonBase)Butt_ا).Text = "ا";
		((ButtonBase)Butt_ا).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ا).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ف).BackColor = Color.Transparent;
		((Control)Butt_ف).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ف).Cursor = Cursors.Hand;
		((Control)Butt_ف).Dock = (DockStyle)5;
		((ButtonBase)Butt_ف).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ف).FlatStyle = (FlatStyle)0;
		((Control)Butt_ف).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ف).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ف = Butt_ف;
		location = new Point(189, 41);
		((Control)butt_ف).Location = location;
		Button_CLAVIER_NOSELECT butt_ف2 = Butt_ف;
		padding = new Padding(0);
		((Control)butt_ف2).Margin = padding;
		((Control)Butt_ف).Name = "Butt_ف";
		Button_CLAVIER_NOSELECT butt_ف3 = Butt_ف;
		size = new Size(47, 40);
		((Control)butt_ف3).Size = size;
		((Control)Butt_ف).TabIndex = 747;
		((ButtonBase)Butt_ف).Text = "ف";
		((ButtonBase)Butt_ف).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ف).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ل).BackColor = Color.Transparent;
		((Control)Butt_ل).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ل).Cursor = Cursors.Hand;
		((Control)Butt_ل).Dock = (DockStyle)5;
		((ButtonBase)Butt_ل).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ل).FlatStyle = (FlatStyle)0;
		((Control)Butt_ل).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ل).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ل = Butt_ل;
		location = new Point(236, 81);
		((Control)butt_ل).Location = location;
		Button_CLAVIER_NOSELECT butt_ل2 = Butt_ل;
		padding = new Padding(0);
		((Control)butt_ل2).Margin = padding;
		((Control)Butt_ل).Name = "Butt_ل";
		Button_CLAVIER_NOSELECT butt_ل3 = Butt_ل;
		size = new Size(47, 40);
		((Control)butt_ل3).Size = size;
		((Control)Butt_ل).TabIndex = 757;
		((ButtonBase)Butt_ل).Text = "ل";
		((ButtonBase)Butt_ل).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ل).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_غ).BackColor = Color.Transparent;
		((Control)Butt_غ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_غ).Cursor = Cursors.Hand;
		((Control)Butt_غ).Dock = (DockStyle)5;
		((ButtonBase)Butt_غ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_غ).FlatStyle = (FlatStyle)0;
		((Control)Butt_غ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_غ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_غ = Butt_غ;
		location = new Point(236, 41);
		((Control)butt_غ).Location = location;
		Button_CLAVIER_NOSELECT butt_غ2 = Butt_غ;
		padding = new Padding(0);
		((Control)butt_غ2).Margin = padding;
		((Control)Butt_غ).Name = "Butt_غ";
		Button_CLAVIER_NOSELECT butt_غ3 = Butt_غ;
		size = new Size(47, 40);
		((Control)butt_غ3).Size = size;
		((Control)Butt_غ).TabIndex = 748;
		((ButtonBase)Butt_غ).Text = "غ";
		((ButtonBase)Butt_غ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_غ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ب).BackColor = Color.Transparent;
		((Control)Butt_ب).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ب).Cursor = Cursors.Hand;
		((Control)Butt_ب).Dock = (DockStyle)5;
		((ButtonBase)Butt_ب).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ب).FlatStyle = (FlatStyle)0;
		((Control)Butt_ب).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ب).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ب = Butt_ب;
		location = new Point(189, 81);
		((Control)butt_ب).Location = location;
		Button_CLAVIER_NOSELECT butt_ب2 = Butt_ب;
		padding = new Padding(0);
		((Control)butt_ب2).Margin = padding;
		((Control)Butt_ب).Name = "Butt_ب";
		Button_CLAVIER_NOSELECT butt_ب3 = Butt_ب;
		size = new Size(47, 40);
		((Control)butt_ب3).Size = size;
		((Control)Butt_ب).TabIndex = 756;
		((ButtonBase)Butt_ب).Text = "ب";
		((ButtonBase)Butt_ب).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ب).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ع).BackColor = Color.Transparent;
		((Control)Butt_ع).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ع).Cursor = Cursors.Hand;
		((Control)Butt_ع).Dock = (DockStyle)5;
		((ButtonBase)Butt_ع).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ع).FlatStyle = (FlatStyle)0;
		((Control)Butt_ع).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ع).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ع = Butt_ع;
		location = new Point(283, 41);
		((Control)butt_ع).Location = location;
		Button_CLAVIER_NOSELECT butt_ع2 = Butt_ع;
		padding = new Padding(0);
		((Control)butt_ع2).Margin = padding;
		((Control)Butt_ع).Name = "Butt_ع";
		Button_CLAVIER_NOSELECT butt_ع3 = Butt_ع;
		size = new Size(47, 40);
		((Control)butt_ع3).Size = size;
		((Control)Butt_ع).TabIndex = 749;
		((ButtonBase)Butt_ع).Text = "ع";
		((ButtonBase)Butt_ع).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ع).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ي).BackColor = Color.Transparent;
		((Control)Butt_ي).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ي).Cursor = Cursors.Hand;
		((Control)Butt_ي).Dock = (DockStyle)5;
		((ButtonBase)Butt_ي).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ي).FlatStyle = (FlatStyle)0;
		((Control)Butt_ي).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ي).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ي = Butt_ي;
		location = new Point(142, 81);
		((Control)butt_ي).Location = location;
		Button_CLAVIER_NOSELECT butt_ي2 = Butt_ي;
		padding = new Padding(0);
		((Control)butt_ي2).Margin = padding;
		((Control)Butt_ي).Name = "Butt_ي";
		Button_CLAVIER_NOSELECT butt_ي3 = Butt_ي;
		size = new Size(47, 40);
		((Control)butt_ي3).Size = size;
		((Control)Butt_ي).TabIndex = 755;
		((ButtonBase)Butt_ي).Text = "ي";
		((ButtonBase)Butt_ي).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ي).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ه).BackColor = Color.Transparent;
		((Control)Butt_ه).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ه).Cursor = Cursors.Hand;
		((Control)Butt_ه).Dock = (DockStyle)5;
		((ButtonBase)Butt_ه).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ه).FlatStyle = (FlatStyle)0;
		((Control)Butt_ه).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ه).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ه = Butt_ه;
		location = new Point(330, 41);
		((Control)butt_ه).Location = location;
		Button_CLAVIER_NOSELECT butt_ه2 = Butt_ه;
		padding = new Padding(0);
		((Control)butt_ه2).Margin = padding;
		((Control)Butt_ه).Name = "Butt_ه";
		Button_CLAVIER_NOSELECT butt_ه3 = Butt_ه;
		size = new Size(47, 40);
		((Control)butt_ه3).Size = size;
		((Control)Butt_ه).TabIndex = 750;
		((ButtonBase)Butt_ه).Text = "ه";
		((ButtonBase)Butt_ه).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ه).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_س).BackColor = Color.Transparent;
		((Control)Butt_س).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_س).Cursor = Cursors.Hand;
		((Control)Butt_س).Dock = (DockStyle)5;
		((ButtonBase)Butt_س).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_س).FlatStyle = (FlatStyle)0;
		((Control)Butt_س).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_س).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_س = Butt_س;
		location = new Point(95, 81);
		((Control)butt_س).Location = location;
		Button_CLAVIER_NOSELECT butt_س2 = Butt_س;
		padding = new Padding(0);
		((Control)butt_س2).Margin = padding;
		((Control)Butt_س).Name = "Butt_س";
		Button_CLAVIER_NOSELECT butt_س3 = Butt_س;
		size = new Size(47, 40);
		((Control)butt_س3).Size = size;
		((Control)Butt_س).TabIndex = 754;
		((ButtonBase)Butt_س).Text = "س";
		((ButtonBase)Butt_س).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_س).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_خ).BackColor = Color.Transparent;
		((Control)Butt_خ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_خ).Cursor = Cursors.Hand;
		((Control)Butt_خ).Dock = (DockStyle)5;
		((ButtonBase)Butt_خ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_خ).FlatStyle = (FlatStyle)0;
		((Control)Butt_خ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_خ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_خ = Butt_خ;
		location = new Point(377, 41);
		((Control)butt_خ).Location = location;
		Button_CLAVIER_NOSELECT butt_خ2 = Butt_خ;
		padding = new Padding(0);
		((Control)butt_خ2).Margin = padding;
		((Control)Butt_خ).Name = "Butt_خ";
		Button_CLAVIER_NOSELECT butt_خ3 = Butt_خ;
		size = new Size(47, 40);
		((Control)butt_خ3).Size = size;
		((Control)Butt_خ).TabIndex = 751;
		((ButtonBase)Butt_خ).Text = "خ";
		((ButtonBase)Butt_خ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_خ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ش).BackColor = Color.Transparent;
		((Control)Butt_ش).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ش).Cursor = Cursors.Hand;
		((Control)Butt_ش).Dock = (DockStyle)5;
		((ButtonBase)Butt_ش).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ش).FlatStyle = (FlatStyle)0;
		((Control)Butt_ش).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ش).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ش = Butt_ش;
		location = new Point(48, 81);
		((Control)butt_ش).Location = location;
		Button_CLAVIER_NOSELECT butt_ش2 = Butt_ش;
		padding = new Padding(0);
		((Control)butt_ش2).Margin = padding;
		((Control)Butt_ش).Name = "Butt_ش";
		Button_CLAVIER_NOSELECT butt_ش3 = Butt_ش;
		size = new Size(47, 40);
		((Control)butt_ش3).Size = size;
		((Control)Butt_ش).TabIndex = 753;
		((ButtonBase)Butt_ش).Text = "ش";
		((ButtonBase)Butt_ش).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ش).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ح).BackColor = Color.Transparent;
		((Control)Butt_ح).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ح).Cursor = Cursors.Hand;
		((Control)Butt_ح).Dock = (DockStyle)5;
		((ButtonBase)Butt_ح).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ح).FlatStyle = (FlatStyle)0;
		((Control)Butt_ح).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ح).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ح = Butt_ح;
		location = new Point(424, 41);
		((Control)butt_ح).Location = location;
		Button_CLAVIER_NOSELECT butt_ح2 = Butt_ح;
		padding = new Padding(0);
		((Control)butt_ح2).Margin = padding;
		((Control)Butt_ح).Name = "Butt_ح";
		Button_CLAVIER_NOSELECT butt_ح3 = Butt_ح;
		size = new Size(47, 40);
		((Control)butt_ح3).Size = size;
		((Control)Butt_ح).TabIndex = 752;
		((ButtonBase)Butt_ح).Text = "ح";
		((ButtonBase)Butt_ح).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ح).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ج).BackColor = Color.Transparent;
		((Control)Butt_ج).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ج).Cursor = Cursors.Hand;
		((Control)Butt_ج).Dock = (DockStyle)5;
		((ButtonBase)Butt_ج).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ج).FlatStyle = (FlatStyle)0;
		((Control)Butt_ج).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ج).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ج = Butt_ج;
		location = new Point(471, 41);
		((Control)butt_ج).Location = location;
		Button_CLAVIER_NOSELECT butt_ج2 = Butt_ج;
		padding = new Padding(0);
		((Control)butt_ج2).Margin = padding;
		((Control)Butt_ج).Name = "Butt_ج";
		Button_CLAVIER_NOSELECT butt_ج3 = Butt_ج;
		size = new Size(47, 40);
		((Control)butt_ج3).Size = size;
		((Control)Butt_ج).TabIndex = 790;
		((ButtonBase)Butt_ج).Text = "ج";
		((ButtonBase)Butt_ج).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ج).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK_AR).BackColor = Color.Transparent;
		((Control)Butt_BACK_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK_AR).Cursor = Cursors.Hand;
		((Control)Butt_BACK_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_BACK_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK_AR).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK_AR).ForeColor = Color.White;
		((ButtonBase)Butt_BACK_AR).Image = (Image)componentResourceManager.GetObject("Butt_BACK_AR.Image");
		Button_CLAVIER_NOSELECT butt_BACK_AR = Butt_BACK_AR;
		location = new Point(612, 1);
		((Control)butt_BACK_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK_AR2 = Butt_BACK_AR;
		padding = new Padding(0);
		((Control)butt_BACK_AR2).Margin = padding;
		((Control)Butt_BACK_AR).Name = "Butt_BACK_AR";
		Button_CLAVIER_NOSELECT butt_BACK_AR3 = Butt_BACK_AR;
		size = new Size(53, 40);
		((Control)butt_BACK_AR3).Size = size;
		((Control)Butt_BACK_AR).TabIndex = 769;
		((ButtonBase)Butt_BACK_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_د).BackColor = Color.Transparent;
		((Control)Butt_د).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_د).Cursor = Cursors.Hand;
		((Control)Butt_د).Dock = (DockStyle)5;
		((ButtonBase)Butt_د).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_د).FlatStyle = (FlatStyle)0;
		((Control)Butt_د).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_د).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_د = Butt_د;
		location = new Point(518, 41);
		((Control)butt_د).Location = location;
		Button_CLAVIER_NOSELECT butt_د2 = Butt_د;
		padding = new Padding(0);
		((Control)butt_د2).Margin = padding;
		((Control)Butt_د).Name = "Butt_د";
		Button_CLAVIER_NOSELECT butt_د3 = Butt_د;
		size = new Size(47, 40);
		((Control)butt_د3).Size = size;
		((Control)Butt_د).TabIndex = 791;
		((ButtonBase)Butt_د).Text = "د";
		((ButtonBase)Butt_د).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_د).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ذ).BackColor = Color.Transparent;
		((Control)Butt_ذ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ذ).Cursor = Cursors.Hand;
		((Control)Butt_ذ).Dock = (DockStyle)5;
		((ButtonBase)Butt_ذ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ذ).FlatStyle = (FlatStyle)0;
		((Control)Butt_ذ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ذ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ذ = Butt_ذ;
		location = new Point(565, 41);
		((Control)butt_ذ).Location = location;
		Button_CLAVIER_NOSELECT butt_ذ2 = Butt_ذ;
		padding = new Padding(0);
		((Control)butt_ذ2).Margin = padding;
		((Control)Butt_ذ).Name = "Butt_ذ";
		Button_CLAVIER_NOSELECT butt_ذ3 = Butt_ذ;
		size = new Size(47, 40);
		((Control)butt_ذ3).Size = size;
		((Control)Butt_ذ).TabIndex = 792;
		((ButtonBase)Butt_ذ).Text = "ذ";
		((ButtonBase)Butt_ذ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ذ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ط).BackColor = Color.Transparent;
		((Control)Butt_ط).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ط).Cursor = Cursors.Hand;
		((Control)Butt_ط).Dock = (DockStyle)5;
		((ButtonBase)Butt_ط).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ط).FlatStyle = (FlatStyle)0;
		((Control)Butt_ط).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ط).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ط = Butt_ط;
		location = new Point(518, 81);
		((Control)butt_ط).Location = location;
		Button_CLAVIER_NOSELECT butt_ط2 = Butt_ط;
		padding = new Padding(0);
		((Control)butt_ط2).Margin = padding;
		((Control)Butt_ط).Name = "Butt_ط";
		Button_CLAVIER_NOSELECT butt_ط3 = Butt_ط;
		size = new Size(47, 40);
		((Control)butt_ط3).Size = size;
		((Control)Butt_ط).TabIndex = 793;
		((ButtonBase)Butt_ط).Text = "ط";
		((ButtonBase)Butt_ط).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ط).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT_AR).BackColor = Color.Transparent;
		((Control)Butt_DOT_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT_AR).Cursor = Cursors.Hand;
		((Control)Butt_DOT_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_DOT_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT_AR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_DOT_AR).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_DOT_AR = Butt_DOT_AR;
		location = new Point(565, 121);
		((Control)butt_DOT_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT_AR2 = Butt_DOT_AR;
		padding = new Padding(0);
		((Control)butt_DOT_AR2).Margin = padding;
		((Control)Butt_DOT_AR).Name = "Butt_DOT_AR";
		Button_CLAVIER_NOSELECT butt_DOT_AR3 = Butt_DOT_AR;
		size = new Size(47, 40);
		((Control)butt_DOT_AR3).Size = size;
		((Control)Butt_DOT_AR).TabIndex = 789;
		((ButtonBase)Butt_DOT_AR).Text = ".";
		((ButtonBase)Butt_DOT_AR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_DOT_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ظ).BackColor = Color.Transparent;
		((Control)Butt_ظ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ظ).Cursor = Cursors.Hand;
		((Control)Butt_ظ).Dock = (DockStyle)5;
		((ButtonBase)Butt_ظ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ظ).FlatStyle = (FlatStyle)0;
		((Control)Butt_ظ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ظ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ظ = Butt_ظ;
		location = new Point(471, 121);
		((Control)butt_ظ).Location = location;
		Button_CLAVIER_NOSELECT butt_ظ2 = Butt_ظ;
		padding = new Padding(0);
		((Control)butt_ظ2).Margin = padding;
		((Control)Butt_ظ).Name = "Butt_ظ";
		Button_CLAVIER_NOSELECT butt_ظ3 = Butt_ظ;
		size = new Size(47, 40);
		((Control)butt_ظ3).Size = size;
		((Control)Butt_ظ).TabIndex = 800;
		((ButtonBase)Butt_ظ).Text = "ظ";
		((ButtonBase)Butt_ظ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ظ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ز).BackColor = Color.Transparent;
		((Control)Butt_ز).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ز).Cursor = Cursors.Hand;
		((Control)Butt_ز).Dock = (DockStyle)5;
		((ButtonBase)Butt_ز).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ز).FlatStyle = (FlatStyle)0;
		((Control)Butt_ز).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ز).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ز = Butt_ز;
		location = new Point(424, 121);
		((Control)butt_ز).Location = location;
		Button_CLAVIER_NOSELECT butt_ز2 = Butt_ز;
		padding = new Padding(0);
		((Control)butt_ز2).Margin = padding;
		((Control)Butt_ز).Name = "Butt_ز";
		Button_CLAVIER_NOSELECT butt_ز3 = Butt_ز;
		size = new Size(47, 40);
		((Control)butt_ز3).Size = size;
		((Control)Butt_ز).TabIndex = 799;
		((ButtonBase)Butt_ز).Text = "ز";
		((ButtonBase)Butt_ز).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ز).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_و).BackColor = Color.Transparent;
		((Control)Butt_و).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_و).Cursor = Cursors.Hand;
		((Control)Butt_و).Dock = (DockStyle)5;
		((ButtonBase)Butt_و).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_و).FlatStyle = (FlatStyle)0;
		((Control)Butt_و).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_و).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_و = Butt_و;
		location = new Point(377, 121);
		((Control)butt_و).Location = location;
		Button_CLAVIER_NOSELECT butt_و2 = Butt_و;
		padding = new Padding(0);
		((Control)butt_و2).Margin = padding;
		((Control)Butt_و).Name = "Butt_و";
		Button_CLAVIER_NOSELECT butt_و3 = Butt_و;
		size = new Size(47, 40);
		((Control)butt_و3).Size = size;
		((Control)Butt_و).TabIndex = 795;
		((ButtonBase)Butt_و).Text = "و";
		((ButtonBase)Butt_و).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_و).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ة).BackColor = Color.Transparent;
		((Control)Butt_ة).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ة).Cursor = Cursors.Hand;
		((Control)Butt_ة).Dock = (DockStyle)5;
		((ButtonBase)Butt_ة).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ة).FlatStyle = (FlatStyle)0;
		((Control)Butt_ة).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ة).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ة = Butt_ة;
		location = new Point(330, 121);
		((Control)butt_ة).Location = location;
		Button_CLAVIER_NOSELECT butt_ة2 = Butt_ة;
		padding = new Padding(0);
		((Control)butt_ة2).Margin = padding;
		((Control)Butt_ة).Name = "Butt_ة";
		Button_CLAVIER_NOSELECT butt_ة3 = Butt_ة;
		size = new Size(47, 40);
		((Control)butt_ة3).Size = size;
		((Control)Butt_ة).TabIndex = 796;
		((ButtonBase)Butt_ة).Text = "ة";
		((ButtonBase)Butt_ة).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ة).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ى).BackColor = Color.Transparent;
		((Control)Butt_ى).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ى).Cursor = Cursors.Hand;
		((Control)Butt_ى).Dock = (DockStyle)5;
		((ButtonBase)Butt_ى).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ى).FlatStyle = (FlatStyle)0;
		((Control)Butt_ى).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ى).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ى = Butt_ى;
		location = new Point(283, 121);
		((Control)butt_ى).Location = location;
		Button_CLAVIER_NOSELECT butt_ى2 = Butt_ى;
		padding = new Padding(0);
		((Control)butt_ى2).Margin = padding;
		((Control)Butt_ى).Name = "Butt_ى";
		Button_CLAVIER_NOSELECT butt_ى3 = Butt_ى;
		size = new Size(47, 40);
		((Control)butt_ى3).Size = size;
		((Control)Butt_ى).TabIndex = 797;
		((ButtonBase)Butt_ى).Text = "ى";
		((ButtonBase)Butt_ى).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ى).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_لا).BackColor = Color.Transparent;
		((Control)Butt_لا).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_لا).Cursor = Cursors.Hand;
		((Control)Butt_لا).Dock = (DockStyle)5;
		((ButtonBase)Butt_لا).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_لا).FlatStyle = (FlatStyle)0;
		((Control)Butt_لا).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_لا).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_لا = Butt_لا;
		location = new Point(236, 121);
		((Control)butt_لا).Location = location;
		Button_CLAVIER_NOSELECT butt_لا2 = Butt_لا;
		padding = new Padding(0);
		((Control)butt_لا2).Margin = padding;
		((Control)Butt_لا).Name = "Butt_لا";
		Button_CLAVIER_NOSELECT butt_لا3 = Butt_لا;
		size = new Size(47, 40);
		((Control)butt_لا3).Size = size;
		((Control)Butt_لا).TabIndex = 794;
		((ButtonBase)Butt_لا).Text = "لا";
		((ButtonBase)Butt_لا).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_لا).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ر).BackColor = Color.Transparent;
		((Control)Butt_ر).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ر).Cursor = Cursors.Hand;
		((Control)Butt_ر).Dock = (DockStyle)5;
		((ButtonBase)Butt_ر).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ر).FlatStyle = (FlatStyle)0;
		((Control)Butt_ر).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ر).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ر = Butt_ر;
		location = new Point(189, 121);
		((Control)butt_ر).Location = location;
		Button_CLAVIER_NOSELECT butt_ر2 = Butt_ر;
		padding = new Padding(0);
		((Control)butt_ر2).Margin = padding;
		((Control)Butt_ر).Name = "Butt_ر";
		Button_CLAVIER_NOSELECT butt_ر3 = Butt_ر;
		size = new Size(47, 40);
		((Control)butt_ر3).Size = size;
		((Control)Butt_ر).TabIndex = 798;
		((ButtonBase)Butt_ر).Text = "ر";
		((ButtonBase)Butt_ر).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ر).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ؤ).BackColor = Color.Transparent;
		((Control)Butt_ؤ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ؤ).Cursor = Cursors.Hand;
		((Control)Butt_ؤ).Dock = (DockStyle)5;
		((ButtonBase)Butt_ؤ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ؤ).FlatStyle = (FlatStyle)0;
		((Control)Butt_ؤ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ؤ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ؤ = Butt_ؤ;
		location = new Point(142, 121);
		((Control)butt_ؤ).Location = location;
		Button_CLAVIER_NOSELECT butt_ؤ2 = Butt_ؤ;
		padding = new Padding(0);
		((Control)butt_ؤ2).Margin = padding;
		((Control)Butt_ؤ).Name = "Butt_ؤ";
		Button_CLAVIER_NOSELECT butt_ؤ3 = Butt_ؤ;
		size = new Size(47, 40);
		((Control)butt_ؤ3).Size = size;
		((Control)Butt_ؤ).TabIndex = 803;
		((ButtonBase)Butt_ؤ).Text = "ؤ";
		((ButtonBase)Butt_ؤ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ؤ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ء).BackColor = Color.Transparent;
		((Control)Butt_ء).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ء).Cursor = Cursors.Hand;
		((Control)Butt_ء).Dock = (DockStyle)5;
		((ButtonBase)Butt_ء).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ء).FlatStyle = (FlatStyle)0;
		((Control)Butt_ء).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ء).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ء = Butt_ء;
		location = new Point(95, 121);
		((Control)butt_ء).Location = location;
		Button_CLAVIER_NOSELECT butt_ء2 = Butt_ء;
		padding = new Padding(0);
		((Control)butt_ء2).Margin = padding;
		((Control)Butt_ء).Name = "Butt_ء";
		Button_CLAVIER_NOSELECT butt_ء3 = Butt_ء;
		size = new Size(47, 40);
		((Control)butt_ء3).Size = size;
		((Control)Butt_ء).TabIndex = 802;
		((ButtonBase)Butt_ء).Text = "ء";
		((ButtonBase)Butt_ء).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ء).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ئ).BackColor = Color.Transparent;
		((Control)Butt_ئ).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ئ).Cursor = Cursors.Hand;
		((Control)Butt_ئ).Dock = (DockStyle)5;
		((ButtonBase)Butt_ئ).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ئ).FlatStyle = (FlatStyle)0;
		((Control)Butt_ئ).Font = new Font("Tahoma", 16.25f, (FontStyle)1);
		((Control)Butt_ئ).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ئ = Butt_ئ;
		location = new Point(48, 121);
		((Control)butt_ئ).Location = location;
		Button_CLAVIER_NOSELECT butt_ئ2 = Butt_ئ;
		padding = new Padding(0);
		((Control)butt_ئ2).Margin = padding;
		((Control)Butt_ئ).Name = "Butt_ئ";
		Button_CLAVIER_NOSELECT butt_ئ3 = Butt_ئ;
		size = new Size(47, 40);
		((Control)butt_ئ3).Size = size;
		((Control)Butt_ئ).TabIndex = 801;
		((ButtonBase)Butt_ئ).Text = "ئ";
		((ButtonBase)Butt_ئ).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_ئ).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ENTER_AR).BackColor = Color.Transparent;
		((Control)Butt_ENTER_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_ENTER_AR).Cursor = Cursors.Hand;
		((Control)Butt_ENTER_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_ENTER_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_ENTER_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_ENTER_AR).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_ENTER_AR).ForeColor = Color.White;
		((ButtonBase)Butt_ENTER_AR).Image = (Image)componentResourceManager.GetObject("Butt_ENTER_AR.Image");
		Button_CLAVIER_NOSELECT butt_ENTER_AR = Butt_ENTER_AR;
		location = new Point(612, 121);
		((Control)butt_ENTER_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_ENTER_AR2 = Butt_ENTER_AR;
		padding = new Padding(0);
		((Control)butt_ENTER_AR2).Margin = padding;
		((Control)Butt_ENTER_AR).Name = "Butt_ENTER_AR";
		Button_CLAVIER_NOSELECT butt_ENTER_AR3 = Butt_ENTER_AR;
		size = new Size(53, 40);
		((Control)butt_ENTER_AR3).Size = size;
		((Control)Butt_ENTER_AR).TabIndex = 804;
		((ButtonBase)Butt_ENTER_AR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_FR).BackColor = Color.Transparent;
		((Control)Butt_FR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_FR).Cursor = Cursors.Hand;
		((Control)Butt_FR).Dock = (DockStyle)5;
		((ButtonBase)Butt_FR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_FR).FlatStyle = (FlatStyle)0;
		((Control)Butt_FR).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_FR).ForeColor = Color.White;
		((ButtonBase)Butt_FR).Image = (Image)componentResourceManager.GetObject("Butt_FR.Image");
		Button_CLAVIER_NOSELECT butt_FR = Butt_FR;
		location = new Point(1, 1);
		((Control)butt_FR).Location = location;
		Button_CLAVIER_NOSELECT butt_FR2 = Butt_FR;
		padding = new Padding(0);
		((Control)butt_FR2).Margin = padding;
		((Control)Butt_FR).Name = "Butt_FR";
		Button_CLAVIER_NOSELECT butt_FR3 = Butt_FR;
		size = new Size(100, 49);
		((Control)butt_FR3).Size = size;
		((Control)Butt_FR).TabIndex = 791;
		((ButtonBase)Butt_FR).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_FR).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_SPACE_AR).BackColor = Color.Transparent;
		((Control)Butt_SPACE_AR).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_SPACE_AR).Cursor = Cursors.Hand;
		((Control)Butt_SPACE_AR).Dock = (DockStyle)5;
		((ButtonBase)Butt_SPACE_AR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_SPACE_AR).FlatStyle = (FlatStyle)0;
		((Control)Butt_SPACE_AR).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_SPACE_AR).ForeColor = Color.Black;
		((ButtonBase)Butt_SPACE_AR).Image = (Image)componentResourceManager.GetObject("Butt_SPACE_AR.Image");
		Button_CLAVIER_NOSELECT butt_SPACE_AR = Butt_SPACE_AR;
		location = new Point(101, 1);
		((Control)butt_SPACE_AR).Location = location;
		Button_CLAVIER_NOSELECT butt_SPACE_AR2 = Butt_SPACE_AR;
		padding = new Padding(0);
		((Control)butt_SPACE_AR2).Margin = padding;
		((Control)Butt_SPACE_AR).Name = "Butt_SPACE_AR";
		Button_CLAVIER_NOSELECT butt_SPACE_AR3 = Butt_SPACE_AR;
		size = new Size(464, 49);
		((Control)butt_SPACE_AR3).Size = size;
		((Control)Butt_SPACE_AR).TabIndex = 785;
		((ButtonBase)Butt_SPACE_AR).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(682, 265);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Button244);
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER_AR);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "FormDialog_CLAVIER";
		((Form)this).Text = "Form1";
		((Form)this).TopMost = true;
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel3).ResumeLayout(false);
		((Control)Panel_CLAVIER_AR).ResumeLayout(false);
		((Control)TableLayoutPanel4).ResumeLayout(false);
		((Control)TableLayoutPanel5).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("{", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "}")));
	}

	private void Butt_SPACE_Click(object sender, EventArgs e)
	{
		SendKeys.Send(" ");
	}

	private void Butt_BACK_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{BACKSPACE}");
	}

	private void Butt_ENTER_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{ENTER}");
	}

	private void Butt_DRAFT_Click(object sender, EventArgs e)
	{
	}

	private void Butt_AR_Click(object sender, EventArgs e)
	{
		((Control)Panel_CLAVIER_AR).BringToFront();
	}

	private void Butt_Click_AR(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("{", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "}")));
	}

	private void Butt_SPACE_AR_Click(object sender, EventArgs e)
	{
		SendKeys.Send(" ");
	}

	private void Butt_BACK_AR_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{BACKSPACE}");
	}

	private void Butt_ENTER_AR_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{ENTER}");
	}

	private void Butt_DRAFT_AR_Click(object sender, EventArgs e)
	{
	}

	private void Butt_FR_Click(object sender, EventArgs e)
	{
		((Control)Panel_CLAVIER).BringToFront();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		checked
		{
			((Control)this).Left = Screen.PrimaryScreen.WorkingArea.Width - ((Control)this).Width;
			((Control)this).Top = Screen.PrimaryScreen.WorkingArea.Height - ((Control)this).Height;
		}
	}
}
