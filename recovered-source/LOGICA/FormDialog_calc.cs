using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_calc : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel_DEVIS")]
	private Panel _Panel_DEVIS;

	[AccessedThroughProperty("Button_DEVISE_5")]
	private Button _Button_DEVISE_5;

	[AccessedThroughProperty("Button_DEVISE_1")]
	private Button _Button_DEVISE_1;

	[AccessedThroughProperty("Button_DEVISE_2")]
	private Button _Button_DEVISE_2;

	[AccessedThroughProperty("Button_DEVISE_10")]
	private Button _Button_DEVISE_10;

	[AccessedThroughProperty("Button_DEVISE_20")]
	private Button _Button_DEVISE_20;

	[AccessedThroughProperty("Button_DEVISE_50")]
	private Button _Button_DEVISE_50;

	[AccessedThroughProperty("Button_DEVISE_200")]
	private Button _Button_DEVISE_200;

	[AccessedThroughProperty("Button_DEVISE_100")]
	private Button _Button_DEVISE_100;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private TextBox _Text_TOTAL_NET;

	[AccessedThroughProperty("Button_SOLDER")]
	private Button _Button_SOLDER;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Panel_MODE_P")]
	private Panel _Panel_MODE_P;

	[AccessedThroughProperty("Button_APERCU")]
	private Button _Button_APERCU;

	[AccessedThroughProperty("DataGridView_CALC")]
	private DataGridView _DataGridView_CALC;

	[AccessedThroughProperty("Button_calc")]
	private Button _Button_calc;

	[AccessedThroughProperty("Button_NUMERIQUE")]
	private Button _Button_NUMERIQUE;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

	[AccessedThroughProperty("Butt_")]
	private Button_CLAVIER_NOSELECT _Butt_;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button_REFRESH")]
	private Button _Button_REFRESH;

	[AccessedThroughProperty("Button_RESTE")]
	private Button _Button_RESTE;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("FlowLayoutPanel_MODE_P")]
	private FlowLayoutPanel _FlowLayoutPanel_MODE_P;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label_NUM")]
	private Label _Label_NUM;

	[AccessedThroughProperty("MONTANT")]
	private DataGridViewTextBoxColumn _MONTANT;

	[AccessedThroughProperty("PAYER")]
	private DataGridViewTextBoxColumn _PAYER;

	[AccessedThroughProperty("RENDU")]
	private DataGridViewTextBoxColumn _RENDU;

	[AccessedThroughProperty("MODE_P")]
	private DataGridViewTextBoxColumn _MODE_P;

	[AccessedThroughProperty("supp")]
	private DataGridViewButtonColumn _supp;

	[AccessedThroughProperty("Panel_RETOUR")]
	private Panel _Panel_RETOUR;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Panel_REMARQUE")]
	private Panel _Panel_REMARQUE;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Text_REMARQUE")]
	private TextBox _Text_REMARQUE;

	[AccessedThroughProperty("Button_DEVISE_0_5")]
	private Button _Button_DEVISE_0_5;

	internal virtual Panel Panel_DEVIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_DEVIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_DEVIS = value;
		}
	}

	internal virtual Button Button_DEVISE_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_5 != null)
			{
				((Control)_Button_DEVISE_5).Click -= eventHandler;
			}
			_Button_DEVISE_5 = value;
			if (_Button_DEVISE_5 != null)
			{
				((Control)_Button_DEVISE_5).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_1 != null)
			{
				((Control)_Button_DEVISE_1).Click -= eventHandler;
			}
			_Button_DEVISE_1 = value;
			if (_Button_DEVISE_1 != null)
			{
				((Control)_Button_DEVISE_1).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_2 != null)
			{
				((Control)_Button_DEVISE_2).Click -= eventHandler;
			}
			_Button_DEVISE_2 = value;
			if (_Button_DEVISE_2 != null)
			{
				((Control)_Button_DEVISE_2).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_10 != null)
			{
				((Control)_Button_DEVISE_10).Click -= eventHandler;
			}
			_Button_DEVISE_10 = value;
			if (_Button_DEVISE_10 != null)
			{
				((Control)_Button_DEVISE_10).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_20 != null)
			{
				((Control)_Button_DEVISE_20).Click -= eventHandler;
			}
			_Button_DEVISE_20 = value;
			if (_Button_DEVISE_20 != null)
			{
				((Control)_Button_DEVISE_20).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_50 != null)
			{
				((Control)_Button_DEVISE_50).Click -= eventHandler;
			}
			_Button_DEVISE_50 = value;
			if (_Button_DEVISE_50 != null)
			{
				((Control)_Button_DEVISE_50).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_200
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_200;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_200 != null)
			{
				((Control)_Button_DEVISE_200).Click -= eventHandler;
			}
			_Button_DEVISE_200 = value;
			if (_Button_DEVISE_200 != null)
			{
				((Control)_Button_DEVISE_200).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVISE_100
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_100 != null)
			{
				((Control)_Button_DEVISE_100).Click -= eventHandler;
			}
			_Button_DEVISE_100 = value;
			if (_Button_DEVISE_100 != null)
			{
				((Control)_Button_DEVISE_100).Click += eventHandler;
			}
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
			EventHandler eventHandler = Text_TOTAL_NET_TextChanged;
			if (_Text_TOTAL_NET != null)
			{
				((Control)_Text_TOTAL_NET).TextChanged -= eventHandler;
			}
			_Text_TOTAL_NET = value;
			if (_Text_TOTAL_NET != null)
			{
				((Control)_Text_TOTAL_NET).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_SOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SOLDER_Click;
			if (_Button_SOLDER != null)
			{
				((Control)_Button_SOLDER).Click -= eventHandler;
			}
			_Button_SOLDER = value;
			if (_Button_SOLDER != null)
			{
				((Control)_Button_SOLDER).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button12_Click;
			if (_Button12 != null)
			{
				((Control)_Button12).Click -= eventHandler;
			}
			_Button12 = value;
			if (_Button12 != null)
			{
				((Control)_Button12).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_MODE_P = value;
		}
	}

	internal virtual Button Button_APERCU
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_APERCU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_APERCU_Click;
			if (_Button_APERCU != null)
			{
				((Control)_Button_APERCU).Click -= eventHandler;
			}
			_Button_APERCU = value;
			if (_Button_APERCU != null)
			{
				((Control)_Button_APERCU).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView_CALC
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_CALC;
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView1_CellValueChanged;
			DataGridViewEditingControlShowingEventHandler val2 = DataGridView1_EditingControlShowing;
			DataGridViewCellEventHandler val3 = DataGridView_CALC_CellClick;
			DataGridViewCellEventHandler val4 = DataGridView1_CellContentClick;
			if (_DataGridView_CALC != null)
			{
				_DataGridView_CALC.CellValueChanged -= val;
				_DataGridView_CALC.EditingControlShowing -= val2;
				_DataGridView_CALC.CellClick -= val3;
				_DataGridView_CALC.CellContentClick -= val4;
			}
			_DataGridView_CALC = value;
			if (_DataGridView_CALC != null)
			{
				_DataGridView_CALC.CellValueChanged += val;
				_DataGridView_CALC.EditingControlShowing += val2;
				_DataGridView_CALC.CellClick += val3;
				_DataGridView_CALC.CellContentClick += val4;
			}
		}
	}

	internal virtual Button Button_calc
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_calc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_calc_Click;
			if (_Button_calc != null)
			{
				((Control)_Button_calc).Click -= eventHandler;
			}
			_Button_calc = value;
			if (_Button_calc != null)
			{
				((Control)_Button_calc).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_NUMERIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_NUMERIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_NUMERIQUE_Click;
			if (_Button_NUMERIQUE != null)
			{
				((Control)_Button_NUMERIQUE).Click -= eventHandler;
			}
			_Button_NUMERIQUE = value;
			if (_Button_NUMERIQUE != null)
			{
				((Control)_Button_NUMERIQUE).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT1_Click;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT1 = value;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click += eventHandler;
			}
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Button Button_REFRESH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_REFRESH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_REFRESH_Click;
			if (_Button_REFRESH != null)
			{
				((Control)_Button_REFRESH).Click -= eventHandler;
			}
			_Button_REFRESH = value;
			if (_Button_REFRESH != null)
			{
				((Control)_Button_REFRESH).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_RESTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RESTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RESTE_Click;
			if (_Button_RESTE != null)
			{
				((Control)_Button_RESTE).Click -= eventHandler;
			}
			_Button_RESTE = value;
			if (_Button_RESTE != null)
			{
				((Control)_Button_RESTE).Click += eventHandler;
			}
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

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
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

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
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

	internal virtual FlowLayoutPanel FlowLayoutPanel_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel_MODE_P = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label_NUM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_NUM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_NUM = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MONTANT
	{
		[DebuggerNonUserCode]
		get
		{
			return _MONTANT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MONTANT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PAYER
	{
		[DebuggerNonUserCode]
		get
		{
			return _PAYER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PAYER = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn RENDU
	{
		[DebuggerNonUserCode]
		get
		{
			return _RENDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RENDU = value;
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

	internal virtual DataGridViewButtonColumn supp
	{
		[DebuggerNonUserCode]
		get
		{
			return _supp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_supp = value;
		}
	}

	internal virtual Panel Panel_RETOUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_RETOUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_RETOUR = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).Click -= eventHandler;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).Click += eventHandler;
			}
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

	internal virtual Panel Panel_REMARQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_REMARQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_REMARQUE = value;
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

	internal virtual TextBox Text_REMARQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_REMARQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_REMARQUE = value;
		}
	}

	internal virtual Button Button_DEVISE_0_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVISE_0_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVISE_0_5 != null)
			{
				((Control)_Button_DEVISE_0_5).Click -= eventHandler;
			}
			_Button_DEVISE_0_5 = value;
			if (_Button_DEVISE_0_5 != null)
			{
				((Control)_Button_DEVISE_0_5).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_calc()
	{
		((Form)this).Load += FormDialog_calc_Load;
		((Form)this).Shown += Form_Shown;
		((Form)this).Shown += FormDialog_calc_Shown;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
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
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected Obj, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected Obj, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected Obj, but got Unknown
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected Obj, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected Obj, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected Obj, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected Obj, but got Unknown
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected Obj, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected Obj, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected Obj, but got Unknown
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected Obj, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected Obj, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff9: Expected Obj, but got Unknown
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected Obj, but got Unknown
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d2: Expected Obj, but got Unknown
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Expected Obj, but got Unknown
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_1292: Expected Obj, but got Unknown
		//IL_1456: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Expected Obj, but got Unknown
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1531: Expected Obj, but got Unknown
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Expected Obj, but got Unknown
		//IL_162b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1635: Expected Obj, but got Unknown
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1673: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Unknown result type (might be due to invalid IL or missing references)
		//IL_1722: Expected Obj, but got Unknown
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Expected Obj, but got Unknown
		//IL_1784: Unknown result type (might be due to invalid IL or missing references)
		//IL_178a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1992: Unknown result type (might be due to invalid IL or missing references)
		//IL_199c: Expected Obj, but got Unknown
		//IL_1a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Expected Obj, but got Unknown
		//IL_1b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b33: Expected Obj, but got Unknown
		//IL_1bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bff: Expected Obj, but got Unknown
		//IL_1fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fee: Expected Obj, but got Unknown
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_202f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ac: Expected Obj, but got Unknown
		//IL_21a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Expected Obj, but got Unknown
		//IL_21eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22af: Expected Obj, but got Unknown
		//IL_22ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cc: Expected Obj, but got Unknown
		//IL_2404: Unknown result type (might be due to invalid IL or missing references)
		//IL_240a: Unknown result type (might be due to invalid IL or missing references)
		//IL_24cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected Obj, but got Unknown
		//IL_2514: Unknown result type (might be due to invalid IL or missing references)
		//IL_251a: Unknown result type (might be due to invalid IL or missing references)
		//IL_25df: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e9: Expected Obj, but got Unknown
		//IL_261e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2624: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f3: Expected Obj, but got Unknown
		//IL_272e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2734: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2803: Expected Obj, but got Unknown
		//IL_283b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2841: Unknown result type (might be due to invalid IL or missing references)
		//IL_2906: Unknown result type (might be due to invalid IL or missing references)
		//IL_2910: Expected Obj, but got Unknown
		//IL_2945: Unknown result type (might be due to invalid IL or missing references)
		//IL_294b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1a: Expected Obj, but got Unknown
		//IL_2a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b27: Expected Obj, but got Unknown
		//IL_2b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b54: Expected Obj, but got Unknown
		//IL_2b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c3f: Expected Obj, but got Unknown
		//IL_2c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4c: Expected Obj, but got Unknown
		//IL_2d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e59: Expected Obj, but got Unknown
		//IL_2e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6b: Expected Obj, but got Unknown
		//IL_306c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3076: Expected Obj, but got Unknown
		//IL_323e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3248: Expected Obj, but got Unknown
		//IL_325a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3264: Expected Obj, but got Unknown
		//IL_3302: Unknown result type (might be due to invalid IL or missing references)
		//IL_330c: Expected Obj, but got Unknown
		//IL_331e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3328: Expected Obj, but got Unknown
		//IL_34a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b1: Expected Obj, but got Unknown
		//IL_3554: Unknown result type (might be due to invalid IL or missing references)
		//IL_355e: Expected Obj, but got Unknown
		//IL_35ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f8: Expected Obj, but got Unknown
		//IL_3692: Unknown result type (might be due to invalid IL or missing references)
		//IL_369c: Expected Obj, but got Unknown
		//IL_387b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3885: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_calc));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		Panel_DEVIS = new Panel();
		Label2 = new Label();
		Label3 = new Label();
		Label6 = new Label();
		Label10 = new Label();
		Button_DEVISE_5 = new Button();
		Button_DEVISE_1 = new Button();
		Button_DEVISE_2 = new Button();
		Button_DEVISE_10 = new Button();
		Button_DEVISE_20 = new Button();
		Button_DEVISE_50 = new Button();
		Button_DEVISE_200 = new Button();
		Button_DEVISE_100 = new Button();
		Panel2 = new Panel();
		Button_REFRESH = new Button();
		Button_NUMERIQUE = new Button();
		DataGridView_CALC = new DataGridView();
		MONTANT = new DataGridViewTextBoxColumn();
		PAYER = new DataGridViewTextBoxColumn();
		RENDU = new DataGridViewTextBoxColumn();
		MODE_P = new DataGridViewTextBoxColumn();
		supp = new DataGridViewButtonColumn();
		Text_TOTAL_NET = new TextBox();
		Button_SOLDER = new Button();
		Button12 = new Button();
		Panel_MODE_P = new Panel();
		FlowLayoutPanel_MODE_P = new FlowLayoutPanel();
		Label13 = new Label();
		Label9 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Button_APERCU = new Button();
		Button_calc = new Button();
		Panel_CLAVIER = new Panel();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		Label_NUM = new Label();
		Butt_ = new Button_CLAVIER_NOSELECT();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Button_RESTE = new Button();
		Button1 = new Button();
		Label11 = new Label();
		Panel_RETOUR = new Panel();
		Button3 = new Button();
		Button2 = new Button();
		Panel_REMARQUE = new Panel();
		Label19 = new Label();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Text_REMARQUE = new TextBox();
		Button_DEVISE_0_5 = new Button();
		((Control)Panel_DEVIS).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)DataGridView_CALC).BeginInit();
		((Control)Panel_MODE_P).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel_RETOUR).SuspendLayout();
		((Control)Panel_REMARQUE).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel_DEVIS).BackColor = Color.White;
		Panel_DEVIS.BorderStyle = (BorderStyle)1;
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_0_5);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Label2);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Label3);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Label6);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Label10);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_5);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_1);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_2);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_10);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_20);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_50);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_200);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Button_DEVISE_100);
		((Control)Panel_DEVIS).Controls.Add((Control)(object)Panel2);
		Panel panel_DEVIS = Panel_DEVIS;
		Point location = new Point(12, 167);
		((Control)panel_DEVIS).Location = location;
		((Control)Panel_DEVIS).Name = "Panel_DEVIS";
		Panel panel_DEVIS2 = Panel_DEVIS;
		Size size = new Size(503, 157);
		((Control)panel_DEVIS2).Size = size;
		((Control)Panel_DEVIS).TabIndex = 701;
		((Control)Label2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label2).Dock = (DockStyle)1;
		((Control)Label2).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label = Label2;
		location = new Point(2, 0);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(497, 2);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1013;
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label3).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label3).Cursor = Cursors.Hand;
		((Control)Label3).Dock = (DockStyle)2;
		((Control)Label3).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label3 = Label3;
		location = new Point(2, 153);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(497, 2);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 1012;
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label6).Cursor = Cursors.Hand;
		((Control)Label6).Dock = (DockStyle)4;
		((Control)Label6).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label5 = Label6;
		location = new Point(499, 0);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(2, 155);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 1011;
		Label6.TextAlign = (ContentAlignment)16;
		((Control)Label10).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label10).Cursor = Cursors.Hand;
		((Control)Label10).Dock = (DockStyle)3;
		((Control)Label10).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label7 = Label10;
		location = new Point(0, 0);
		((Control)label7).Location = location;
		((Control)Label10).Name = "Label10";
		Label label8 = Label10;
		size = new Size(2, 155);
		((Control)label8).Size = size;
		((Control)Label10).TabIndex = 1010;
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Button_DEVISE_5).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_5.BackgroundImage");
		((Control)Button_DEVISE_5).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_5).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_5).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_ = Button_DEVISE_5;
		location = new Point(362, 4);
		((Control)button_DEVISE_).Location = location;
		((Control)Button_DEVISE_5).Name = "Button_DEVISE_5";
		Button button_DEVISE_2 = Button_DEVISE_5;
		size = new Size(49, 49);
		((Control)button_DEVISE_2).Size = size;
		((Control)Button_DEVISE_5).TabIndex = 408;
		((ButtonBase)Button_DEVISE_5).Text = "5";
		((ButtonBase)Button_DEVISE_5).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_5).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_1).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_1.BackgroundImage");
		((Control)Button_DEVISE_1).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_1).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_1).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_3 = Button_DEVISE_1;
		location = new Point(363, 59);
		((Control)button_DEVISE_3).Location = location;
		((Control)Button_DEVISE_1).Name = "Button_DEVISE_1";
		Button button_DEVISE_4 = Button_DEVISE_1;
		size = new Size(49, 49);
		((Control)button_DEVISE_4).Size = size;
		((Control)Button_DEVISE_1).TabIndex = 407;
		((ButtonBase)Button_DEVISE_1).Text = "1";
		((ButtonBase)Button_DEVISE_1).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_1).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_2).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_2.BackgroundImage");
		((Control)Button_DEVISE_2).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_2).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_2).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_5 = Button_DEVISE_2;
		location = new Point(297, 59);
		((Control)button_DEVISE_5).Location = location;
		((Control)Button_DEVISE_2).Name = "Button_DEVISE_2";
		Button button_DEVISE_6 = Button_DEVISE_2;
		size = new Size(49, 49);
		((Control)button_DEVISE_6).Size = size;
		((Control)Button_DEVISE_2).TabIndex = 406;
		((ButtonBase)Button_DEVISE_2).Text = "2";
		((ButtonBase)Button_DEVISE_2).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_2).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_10).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_10.BackgroundImage");
		((Control)Button_DEVISE_10).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_10).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_10).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_7 = Button_DEVISE_10;
		location = new Point(297, 4);
		((Control)button_DEVISE_7).Location = location;
		((Control)Button_DEVISE_10).Name = "Button_DEVISE_10";
		Button button_DEVISE_8 = Button_DEVISE_10;
		size = new Size(49, 49);
		((Control)button_DEVISE_8).Size = size;
		((Control)Button_DEVISE_10).TabIndex = 405;
		((ButtonBase)Button_DEVISE_10).Text = "10";
		((ButtonBase)Button_DEVISE_10).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_10).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_20).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_20.BackgroundImage");
		((Control)Button_DEVISE_20).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_20).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_20).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_9 = Button_DEVISE_20;
		location = new Point(150, 81);
		((Control)button_DEVISE_9).Location = location;
		((Control)Button_DEVISE_20).Name = "Button_DEVISE_20";
		Button button_DEVISE_10 = Button_DEVISE_20;
		size = new Size(139, 63);
		((Control)button_DEVISE_10).Size = size;
		((Control)Button_DEVISE_20).TabIndex = 404;
		((ButtonBase)Button_DEVISE_20).Text = "20";
		((ButtonBase)Button_DEVISE_20).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_20).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_50).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_50.BackgroundImage");
		((Control)Button_DEVISE_50).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_50).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_50).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_11 = Button_DEVISE_50;
		location = new Point(5, 81);
		((Control)button_DEVISE_11).Location = location;
		((Control)Button_DEVISE_50).Name = "Button_DEVISE_50";
		Button button_DEVISE_12 = Button_DEVISE_50;
		size = new Size(139, 63);
		((Control)button_DEVISE_12).Size = size;
		((Control)Button_DEVISE_50).TabIndex = 403;
		((ButtonBase)Button_DEVISE_50).Text = "50";
		((ButtonBase)Button_DEVISE_50).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_50).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_200).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_200.BackgroundImage");
		((Control)Button_DEVISE_200).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_200).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_200).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_13 = Button_DEVISE_200;
		location = new Point(5, 11);
		((Control)button_DEVISE_13).Location = location;
		((Control)Button_DEVISE_200).Name = "Button_DEVISE_200";
		Button button_DEVISE_14 = Button_DEVISE_200;
		size = new Size(139, 63);
		((Control)button_DEVISE_14).Size = size;
		((Control)Button_DEVISE_200).TabIndex = 402;
		((ButtonBase)Button_DEVISE_200).Text = "200";
		((ButtonBase)Button_DEVISE_200).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_200).UseVisualStyleBackColor = true;
		((Control)Button_DEVISE_100).BackgroundImage = (Image)componentResourceManager.GetObject("Button_DEVISE_100.BackgroundImage");
		((Control)Button_DEVISE_100).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_100).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_100).Font = new Font("Tahoma", 2f);
		Button button_DEVISE_15 = Button_DEVISE_100;
		location = new Point(150, 11);
		((Control)button_DEVISE_15).Location = location;
		((Control)Button_DEVISE_100).Name = "Button_DEVISE_100";
		Button button_DEVISE_16 = Button_DEVISE_100;
		size = new Size(139, 63);
		((Control)button_DEVISE_16).Size = size;
		((Control)Button_DEVISE_100).TabIndex = 401;
		((ButtonBase)Button_DEVISE_100).Text = "100";
		((ButtonBase)Button_DEVISE_100).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_DEVISE_100).UseVisualStyleBackColor = true;
		((Control)Panel2).BackColor = Color.White;
		Panel2.BorderStyle = (BorderStyle)1;
		((Control)Panel2).Controls.Add((Control)(object)Button_REFRESH);
		((Control)Panel2).Controls.Add((Control)(object)Button_NUMERIQUE);
		Panel panel = Panel2;
		location = new Point(431, -1);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(69, 157);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 822;
		((Control)Button_REFRESH).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_REFRESH).Cursor = Cursors.Hand;
		((Control)Button_REFRESH).Font = new Font("Tahoma", 2f);
		((ButtonBase)Button_REFRESH).Image = (Image)componentResourceManager.GetObject("Button_REFRESH.Image");
		Button button_REFRESH = Button_REFRESH;
		location = new Point(6, 11);
		((Control)button_REFRESH).Location = location;
		((Control)Button_REFRESH).Name = "Button_REFRESH";
		Button button_REFRESH2 = Button_REFRESH;
		size = new Size(54, 63);
		((Control)button_REFRESH2).Size = size;
		((Control)Button_REFRESH).TabIndex = 411;
		((ButtonBase)Button_REFRESH).Text = "5";
		((ButtonBase)Button_REFRESH).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_REFRESH).UseVisualStyleBackColor = true;
		((Control)Button_NUMERIQUE).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_NUMERIQUE).Cursor = Cursors.Hand;
		((Control)Button_NUMERIQUE).Font = new Font("Tahoma", 2f);
		((ButtonBase)Button_NUMERIQUE).Image = (Image)componentResourceManager.GetObject("Button_NUMERIQUE.Image");
		Button button_NUMERIQUE = Button_NUMERIQUE;
		location = new Point(6, 80);
		((Control)button_NUMERIQUE).Location = location;
		((Control)Button_NUMERIQUE).Name = "Button_NUMERIQUE";
		Button button_NUMERIQUE2 = Button_NUMERIQUE;
		size = new Size(54, 63);
		((Control)button_NUMERIQUE2).Size = size;
		((Control)Button_NUMERIQUE).TabIndex = 410;
		((ButtonBase)Button_NUMERIQUE).Text = "5";
		((ButtonBase)Button_NUMERIQUE).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_NUMERIQUE).UseVisualStyleBackColor = true;
		DataGridView_CALC.AllowUserToAddRows = false;
		DataGridView_CALC.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_CALC.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView_CALC.ColumnHeadersDefaultCellStyle = val;
		DataGridView_CALC.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_CALC.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)MONTANT,
			(DataGridViewColumn)PAYER,
			(DataGridViewColumn)RENDU,
			(DataGridViewColumn)MODE_P,
			(DataGridViewColumn)supp
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView_CALC.DefaultCellStyle = val2;
		DataGridView_CALC.EditMode = (DataGridViewEditMode)0;
		DataGridView_CALC.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_CALC = DataGridView_CALC;
		location = new Point(12, 330);
		((Control)dataGridView_CALC).Location = location;
		((Control)DataGridView_CALC).Name = "DataGridView_CALC";
		DataGridView_CALC.RowHeadersVisible = false;
		DataGridView dataGridView_CALC2 = DataGridView_CALC;
		size = new Size(503, 106);
		((Control)dataGridView_CALC2).Size = size;
		((Control)DataGridView_CALC).TabIndex = 817;
		((DataGridViewColumn)MONTANT).HeaderText = "MONTANT";
		((DataGridViewColumn)MONTANT).Name = "MONTANT";
		((DataGridViewColumn)MONTANT).ReadOnly = true;
		MONTANT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)PAYER).HeaderText = "PAYER";
		((DataGridViewColumn)PAYER).Name = "PAYER";
		PAYER.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)RENDU).HeaderText = "RENDU";
		((DataGridViewColumn)RENDU).Name = "RENDU";
		((DataGridViewColumn)RENDU).ReadOnly = true;
		RENDU.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)MODE_P).HeaderText = "MODE_P";
		((DataGridViewColumn)MODE_P).Name = "MODE_P";
		((DataGridViewColumn)MODE_P).ReadOnly = true;
		MODE_P.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = Color.Red;
		supp.DefaultCellStyle = val3;
		supp.FlatStyle = (FlatStyle)0;
		((DataGridViewColumn)supp).HeaderText = "";
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).ReadOnly = true;
		((DataGridViewColumn)supp).SortMode = (DataGridViewColumnSortMode)2;
		supp.Text = "X";
		supp.UseColumnTextForButtonValue = true;
		((DataGridViewColumn)supp).Width = 72;
		((TextBoxBase)Text_TOTAL_NET).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)Text_TOTAL_NET).BorderStyle = (BorderStyle)1;
		((Control)Text_TOTAL_NET).Font = new Font("Segoe UI", 21f, (FontStyle)1);
		((TextBoxBase)Text_TOTAL_NET).ForeColor = Color.White;
		TextBox text_TOTAL_NET = Text_TOTAL_NET;
		location = new Point(12, 1);
		((Control)text_TOTAL_NET).Location = location;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		((TextBoxBase)Text_TOTAL_NET).ReadOnly = true;
		TextBox text_TOTAL_NET2 = Text_TOTAL_NET;
		size = new Size(503, 45);
		((Control)text_TOTAL_NET2).Size = size;
		((Control)Text_TOTAL_NET).TabIndex = 392;
		Text_TOTAL_NET.TextAlign = (HorizontalAlignment)2;
		((ButtonBase)Button_SOLDER).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SOLDER).Cursor = Cursors.Hand;
		((ButtonBase)Button_SOLDER).FlatStyle = (FlatStyle)0;
		((Control)Button_SOLDER).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Button_SOLDER).ForeColor = Color.White;
		((ButtonBase)Button_SOLDER).Image = (Image)componentResourceManager.GetObject("Button_SOLDER.Image");
		((ButtonBase)Button_SOLDER).ImageAlign = (ContentAlignment)16;
		Button button_SOLDER = Button_SOLDER;
		location = new Point(360, 546);
		((Control)button_SOLDER).Location = location;
		Button button_SOLDER2 = Button_SOLDER;
		Padding margin = new Padding(0);
		((Control)button_SOLDER2).Margin = margin;
		((Control)Button_SOLDER).Name = "Button_SOLDER";
		Button button_SOLDER3 = Button_SOLDER;
		size = new Size(155, 54);
		((Control)button_SOLDER3).Size = size;
		((Control)Button_SOLDER).TabIndex = 704;
		((ButtonBase)Button_SOLDER).Text = "  Solder";
		((ButtonBase)Button_SOLDER).UseVisualStyleBackColor = false;
		((ButtonBase)Button12).BackColor = Color.Red;
		((Control)Button12).Cursor = Cursors.Hand;
		((ButtonBase)Button12).FlatStyle = (FlatStyle)0;
		((Control)Button12).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Button12).ForeColor = Color.White;
		((ButtonBase)Button12).Image = (Image)componentResourceManager.GetObject("Button12.Image");
		((ButtonBase)Button12).ImageAlign = (ContentAlignment)16;
		Button button = Button12;
		location = new Point(12, 546);
		((Control)button).Location = location;
		Button button2 = Button12;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button12).Name = "Button12";
		Button button3 = Button12;
		size = new Size(155, 54);
		((Control)button3).Size = size;
		((Control)Button12).TabIndex = 703;
		((ButtonBase)Button12).Text = "  Fermer";
		((ButtonBase)Button12).UseVisualStyleBackColor = false;
		((ScrollableControl)Panel_MODE_P).AutoScroll = true;
		((Control)Panel_MODE_P).BackColor = Color.White;
		Panel_MODE_P.BorderStyle = (BorderStyle)1;
		((Control)Panel_MODE_P).Controls.Add((Control)(object)FlowLayoutPanel_MODE_P);
		((Control)Panel_MODE_P).Controls.Add((Control)(object)Label13);
		((Control)Panel_MODE_P).Controls.Add((Control)(object)Label9);
		((Control)Panel_MODE_P).Controls.Add((Control)(object)Label5);
		((Control)Panel_MODE_P).Controls.Add((Control)(object)Label4);
		Panel panel_MODE_P = Panel_MODE_P;
		location = new Point(12, 47);
		((Control)panel_MODE_P).Location = location;
		((Control)Panel_MODE_P).Name = "Panel_MODE_P";
		Panel panel_MODE_P2 = Panel_MODE_P;
		size = new Size(503, 114);
		((Control)panel_MODE_P2).Size = size;
		((Control)Panel_MODE_P).TabIndex = 731;
		((Panel)FlowLayoutPanel_MODE_P).AutoSize = true;
		((Control)FlowLayoutPanel_MODE_P).BackColor = Color.White;
		FlowLayoutPanel flowLayoutPanel_MODE_P = FlowLayoutPanel_MODE_P;
		location = new Point(208, 3);
		((Control)flowLayoutPanel_MODE_P).Location = location;
		((Control)FlowLayoutPanel_MODE_P).Name = "FlowLayoutPanel_MODE_P";
		FlowLayoutPanel flowLayoutPanel_MODE_P2 = FlowLayoutPanel_MODE_P;
		size = new Size(84, 33);
		((Control)flowLayoutPanel_MODE_P2).Size = size;
		((Control)FlowLayoutPanel_MODE_P).TabIndex = 0;
		((Control)Label13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label13).Dock = (DockStyle)1;
		((Control)Label13).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label9 = Label13;
		location = new Point(2, 0);
		((Control)label9).Location = location;
		((Control)Label13).Name = "Label13";
		Label label10 = Label13;
		size = new Size(497, 2);
		((Control)label10).Size = size;
		((Control)Label13).TabIndex = 1009;
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label9).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label9).Cursor = Cursors.Hand;
		((Control)Label9).Dock = (DockStyle)2;
		((Control)Label9).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label11 = Label9;
		location = new Point(2, 110);
		((Control)label11).Location = location;
		((Control)Label9).Name = "Label9";
		Label label12 = Label9;
		size = new Size(497, 2);
		((Control)label12).Size = size;
		((Control)Label9).TabIndex = 1008;
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Cursor = Cursors.Hand;
		((Control)Label5).Dock = (DockStyle)4;
		((Control)Label5).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label13 = Label5;
		location = new Point(499, 0);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(2, 112);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 1007;
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label4).Cursor = Cursors.Hand;
		((Control)Label4).Dock = (DockStyle)3;
		((Control)Label4).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label15 = Label4;
		location = new Point(0, 0);
		((Control)label15).Location = location;
		((Control)Label4).Name = "Label4";
		Label label16 = Label4;
		size = new Size(2, 112);
		((Control)label16).Size = size;
		((Control)Label4).TabIndex = 1006;
		Label4.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_APERCU).FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
		((ButtonBase)Button_APERCU).FlatStyle = (FlatStyle)0;
		Button button_APERCU = Button_APERCU;
		location = new Point(5, -6);
		((Control)button_APERCU).Location = location;
		((Control)Button_APERCU).Name = "Button_APERCU";
		Button button_APERCU2 = Button_APERCU;
		size = new Size(11, 10);
		((Control)button_APERCU2).Size = size;
		((Control)Button_APERCU).TabIndex = 732;
		((ButtonBase)Button_APERCU).UseVisualStyleBackColor = true;
		((Control)Button_calc).ForeColor = Color.Red;
		Button button_calc = Button_calc;
		location = new Point(214, 559);
		((Control)button_calc).Location = location;
		((Control)Button_calc).Name = "Button_calc";
		Button button_calc2 = Button_calc;
		size = new Size(76, 26);
		((Control)button_calc2).Size = size;
		((Control)Button_calc).TabIndex = 819;
		((ButtonBase)Button_calc).Text = "Button_calc";
		((ButtonBase)Button_calc).UseVisualStyleBackColor = true;
		((Control)Button_calc).Visible = false;
		((Control)Panel_CLAVIER).BackColor = Color.Transparent;
		Panel_CLAVIER.BorderStyle = (BorderStyle)1;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Label_NUM);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DOT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_4);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_3);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_5);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_7);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_8);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_BACK);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_6);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_9);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_0);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(12, 167);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(503, 269);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 821;
		((Control)Panel_CLAVIER).Visible = false;
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT1;
		location = new Point(323, 138);
		((Control)button_CLAVIER_NOSELECT).Location = location;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = Button_CLAVIER_NOSELECT1;
		margin = new Padding(0);
		((Control)button_CLAVIER_NOSELECT2).Margin = margin;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT3 = Button_CLAVIER_NOSELECT1;
		size = new Size(61, 110);
		((Control)button_CLAVIER_NOSELECT3).Size = size;
		((Control)Button_CLAVIER_NOSELECT1).TabIndex = 795;
		((ButtonBase)Button_CLAVIER_NOSELECT1).Text = "OK";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		((Control)Label_NUM).Font = new Font("Calibri", 20f, (FontStyle)1);
		((Control)Label_NUM).ForeColor = Color.Silver;
		Label label_NUM = Label_NUM;
		location = new Point(116, -9);
		((Control)label_NUM).Location = location;
		((Control)Label_NUM).Name = "Label_NUM";
		Label label_NUM2 = Label_NUM;
		size = new Size(268, 26);
		((Control)label_NUM2).Size = size;
		((Control)Label_NUM).TabIndex = 796;
		Label_NUM.Text = "0";
		Label_NUM.TextAlign = (ContentAlignment)32;
		Label_NUM.UseCompatibleTextRendering = true;
		((ButtonBase)Butt_).BackColor = Color.White;
		((Control)Butt_).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_).Cursor = Cursors.Hand;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_).FlatStyle = (FlatStyle)0;
		((Control)Butt_).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_ = Butt_;
		location = new Point(254, 197);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_;
		margin = new Padding(0);
		((Control)butt_2).Margin = margin;
		((Control)Butt_).Name = "Butt_";
		Button_CLAVIER_NOSELECT butt_3 = Butt_;
		size = new Size(61, 51);
		((Control)butt_3).Size = size;
		((Control)Butt_).TabIndex = 794;
		((ButtonBase)Butt_).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.White;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(185, 197);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(0);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		size = new Size(61, 51);
		((Control)butt_DOT3).Size = size;
		((Control)Butt_DOT).TabIndex = 793;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.White;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_4 = Butt_1;
		location = new Point(116, 138);
		((Control)butt_4).Location = location;
		Button_CLAVIER_NOSELECT butt_5 = Butt_1;
		margin = new Padding(0);
		((Control)butt_5).Margin = margin;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_6 = Butt_1;
		size = new Size(61, 51);
		((Control)butt_6).Size = size;
		((Control)Butt_1).TabIndex = 785;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.White;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_7 = Butt_2;
		location = new Point(185, 138);
		((Control)butt_7).Location = location;
		Button_CLAVIER_NOSELECT butt_8 = Butt_2;
		margin = new Padding(0);
		((Control)butt_8).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_9 = Butt_2;
		size = new Size(61, 51);
		((Control)butt_9).Size = size;
		((Control)Butt_2).TabIndex = 784;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.White;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_10 = Butt_4;
		location = new Point(116, 79);
		((Control)butt_10).Location = location;
		Button_CLAVIER_NOSELECT butt_11 = Butt_4;
		margin = new Padding(0);
		((Control)butt_11).Margin = margin;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_12 = Butt_4;
		size = new Size(61, 51);
		((Control)butt_12).Size = size;
		((Control)Butt_4).TabIndex = 788;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.White;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_13 = Butt_3;
		location = new Point(254, 138);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_3;
		margin = new Padding(0);
		((Control)butt_14).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_15 = Butt_3;
		size = new Size(61, 51);
		((Control)butt_15).Size = size;
		((Control)Butt_3).TabIndex = 783;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.White;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_16 = Butt_5;
		location = new Point(185, 79);
		((Control)butt_16).Location = location;
		Button_CLAVIER_NOSELECT butt_17 = Butt_5;
		margin = new Padding(0);
		((Control)butt_17).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_18 = Butt_5;
		size = new Size(61, 51);
		((Control)butt_18).Size = size;
		((Control)Butt_5).TabIndex = 786;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.White;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_19 = Butt_7;
		location = new Point(116, 20);
		((Control)butt_19).Location = location;
		Button_CLAVIER_NOSELECT butt_20 = Butt_7;
		margin = new Padding(0);
		((Control)butt_20).Margin = margin;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_21 = Butt_7;
		size = new Size(61, 51);
		((Control)butt_21).Size = size;
		((Control)Butt_7).TabIndex = 790;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.White;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_22 = Butt_8;
		location = new Point(185, 20);
		((Control)butt_22).Location = location;
		Button_CLAVIER_NOSELECT butt_23 = Butt_8;
		margin = new Padding(0);
		((Control)butt_23).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_24 = Butt_8;
		size = new Size(61, 51);
		((Control)butt_24).Size = size;
		((Control)Butt_8).TabIndex = 791;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.White;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.Black;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(323, 20);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		margin = new Padding(0);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(61, 110);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 782;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.White;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_25 = Butt_6;
		location = new Point(254, 79);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_6;
		margin = new Padding(0);
		((Control)butt_26).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_27 = Butt_6;
		size = new Size(61, 51);
		((Control)butt_27).Size = size;
		((Control)Butt_6).TabIndex = 789;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.White;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_28 = Butt_9;
		location = new Point(254, 20);
		((Control)butt_28).Location = location;
		Button_CLAVIER_NOSELECT butt_29 = Butt_9;
		margin = new Padding(0);
		((Control)butt_29).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_30 = Butt_9;
		size = new Size(61, 51);
		((Control)butt_30).Size = size;
		((Control)Butt_9).TabIndex = 787;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.White;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_31 = Butt_0;
		location = new Point(116, 197);
		((Control)butt_31).Location = location;
		Button_CLAVIER_NOSELECT butt_32 = Butt_0;
		margin = new Padding(0);
		((Control)butt_32).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_33 = Butt_0;
		size = new Size(61, 51);
		((Control)butt_33).Size = size;
		((Control)Butt_0).TabIndex = 792;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Button_RESTE).BackColor = Color.Yellow;
		((Control)Button_RESTE).Cursor = Cursors.Hand;
		((ButtonBase)Button_RESTE).FlatAppearance.BorderColor = Color.LightGray;
		((ButtonBase)Button_RESTE).FlatAppearance.BorderSize = 2;
		((ButtonBase)Button_RESTE).FlatStyle = (FlatStyle)0;
		((Control)Button_RESTE).Font = new Font("Segoe UI", 21f, (FontStyle)1);
		((Control)Button_RESTE).ForeColor = Color.Black;
		((ButtonBase)Button_RESTE).ImageAlign = (ContentAlignment)16;
		Button button_RESTE = Button_RESTE;
		location = new Point(167, 491);
		((Control)button_RESTE).Location = location;
		((Control)Button_RESTE).Name = "Button_RESTE";
		Button button_RESTE2 = Button_RESTE;
		size = new Size(264, 40);
		((Control)button_RESTE2).Size = size;
		((Control)Button_RESTE).TabIndex = 818;
		((ButtonBase)Button_RESTE).UseCompatibleTextRendering = true;
		((ButtonBase)Button_RESTE).UseVisualStyleBackColor = false;
		((ButtonBase)Button1).BackColor = Color.Yellow;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatAppearance.BorderColor = Color.LightGray;
		((ButtonBase)Button1).FlatAppearance.BorderSize = 2;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.Black;
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button4 = Button1;
		location = new Point(96, 491);
		((Control)button4).Location = location;
		((Control)Button1).Name = "Button1";
		Button button5 = Button1;
		size = new Size(73, 40);
		((Control)button5).Size = size;
		((Control)Button1).TabIndex = 822;
		((ButtonBase)Button1).Text = "RESTE";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		Label11.AutoSize = true;
		Label label17 = Label11;
		location = new Point(143, 494);
		((Control)label17).Location = location;
		((Control)Label11).Name = "Label11";
		Label label18 = Label11;
		size = new Size(226, 52);
		((Control)label18).Size = size;
		((Control)Label11).TabIndex = 824;
		Label11.Text = "si il y a des multi mode de paiements\r\ntoujours choisir ESPECES que le premier mode\r\n\r\nle reste client toujours ESPECES";
		((Control)Label11).Visible = false;
		((Control)Panel_RETOUR).Controls.Add((Control)(object)Button3);
		((Control)Panel_RETOUR).Controls.Add((Control)(object)Button2);
		Panel panel_RETOUR = Panel_RETOUR;
		location = new Point(12, 1);
		((Control)panel_RETOUR).Location = location;
		((Control)Panel_RETOUR).Name = "Panel_RETOUR";
		Panel panel_RETOUR2 = Panel_RETOUR;
		size = new Size(503, 530);
		((Control)panel_RETOUR2).Size = size;
		((Control)Panel_RETOUR).TabIndex = 825;
		((Control)Panel_RETOUR).Visible = false;
		((Control)Button3).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		Button button6 = Button3;
		location = new Point(77, 242);
		((Control)button6).Location = location;
		((Control)Button3).Name = "Button3";
		Button button7 = Button3;
		size = new Size(348, 205);
		((Control)button7).Size = size;
		((Control)Button3).TabIndex = 1;
		((ButtonBase)Button3).Text = "Avoir";
		((ButtonBase)Button3).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)Button2).Font = new Font("Calibri", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)2;
		Button button8 = Button2;
		location = new Point(77, 22);
		((Control)button8).Location = location;
		((Control)Button2).Name = "Button2";
		Button button9 = Button2;
		size = new Size(348, 205);
		((Control)button9).Size = size;
		((Control)Button2).TabIndex = 0;
		((ButtonBase)Button2).Text = "Remboursement";
		((ButtonBase)Button2).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((ScrollableControl)Panel_REMARQUE).AutoScroll = true;
		Panel_REMARQUE.BorderStyle = (BorderStyle)1;
		((Control)Panel_REMARQUE).Controls.Add((Control)(object)Label19);
		((Control)Panel_REMARQUE).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_REMARQUE).Controls.Add((Control)(object)Text_REMARQUE);
		Panel panel_REMARQUE = Panel_REMARQUE;
		location = new Point(12, 438);
		((Control)panel_REMARQUE).Location = location;
		((Control)Panel_REMARQUE).Name = "Panel_REMARQUE";
		Panel panel_REMARQUE2 = Panel_REMARQUE;
		size = new Size(503, 47);
		((Control)panel_REMARQUE2).Size = size;
		((Control)Panel_REMARQUE).TabIndex = 829;
		((Control)Panel_REMARQUE).Visible = false;
		((Control)Label19).BackColor = SystemColors.Control;
		((Control)Label19).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label19).ForeColor = Color.Black;
		Label19.ImeMode = (ImeMode)0;
		Label label19 = Label19;
		location = new Point(2, 6);
		((Control)label19).Location = location;
		((Control)Label19).Name = "Label19";
		Label label20 = Label19;
		size = new Size(127, 31);
		((Control)label20).Size = size;
		((Control)Label19).TabIndex = 867;
		Label19.Text = "Remarque";
		Label19.TextAlign = (ContentAlignment)16;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(462, 6);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 866;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)Text_REMARQUE).Font = new Font("Segoe UI", 12f);
		TextBox text_REMARQUE = Text_REMARQUE;
		location = new Point(132, 6);
		((Control)text_REMARQUE).Location = location;
		Text_REMARQUE.Multiline = true;
		((Control)Text_REMARQUE).Name = "Text_REMARQUE";
		TextBox text_REMARQUE2 = Text_REMARQUE;
		size = new Size(324, 31);
		((Control)text_REMARQUE2).Size = size;
		((Control)Text_REMARQUE).TabIndex = 865;
		((Control)Button_DEVISE_0_5).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_DEVISE_0_5).Cursor = Cursors.Hand;
		((Control)Button_DEVISE_0_5).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button_DEVISE_0_ = Button_DEVISE_0_5;
		location = new Point(297, 114);
		((Control)button_DEVISE_0_).Location = location;
		((Control)Button_DEVISE_0_5).Name = "Button_DEVISE_0_5";
		Button button_DEVISE_0_2 = Button_DEVISE_0_5;
		size = new Size(114, 36);
		((Control)button_DEVISE_0_2).Size = size;
		((Control)Button_DEVISE_0_5).TabIndex = 1014;
		((ButtonBase)Button_DEVISE_0_5).Text = "0.5";
		((ButtonBase)Button_DEVISE_0_5).UseCompatibleTextRendering = true;
		((ButtonBase)Button_DEVISE_0_5).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(527, 605);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Panel_REMARQUE);
		((Control)this).Controls.Add((Control)(object)DataGridView_CALC);
		((Control)this).Controls.Add((Control)(object)Text_TOTAL_NET);
		((Control)this).Controls.Add((Control)(object)Button_calc);
		((Control)this).Controls.Add((Control)(object)Button_APERCU);
		((Control)this).Controls.Add((Control)(object)Panel_MODE_P);
		((Control)this).Controls.Add((Control)(object)Button12);
		((Control)this).Controls.Add((Control)(object)Button_SOLDER);
		((Control)this).Controls.Add((Control)(object)Button_RESTE);
		((Control)this).Controls.Add((Control)(object)Panel_DEVIS);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Panel_RETOUR);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_calc";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = " ";
		((Control)Panel_DEVIS).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)DataGridView_CALC).EndInit();
		((Control)Panel_MODE_P).ResumeLayout(false);
		((Control)Panel_MODE_P).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel_RETOUR).ResumeLayout(false);
		((Control)Panel_REMARQUE).ResumeLayout(false);
		((Control)Panel_REMARQUE).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)FlowLayoutPanel_MODE_P).Left = checked((int)Math.Round((double)((Control)Panel_MODE_P).Width / 2.0 - (double)((Control)FlowLayoutPanel_MODE_P).Width / 2.0));
	}

	private void FormDialog_calc_Load(object sender, EventArgs e)
	{
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Text_TOTAL_NET.Text = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET.Text));
				((Control)FlowLayoutPanel_MODE_P).Controls.Clear();
				int num = MyProject.Forms.Form_3_VENTE.DataGridView_MODE_P.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					Button val = new Button();
					((ButtonBase)val).Text = MyProject.Forms.Form_3_VENTE.DataGridView_MODE_P.Rows[num2].Cells[0].Value.ToString();
					((Control)val).Name = "Button_" + MyProject.Forms.Form_3_VENTE.DataGridView_MODE_P.Rows[num2].Cells[0].Value.ToString();
					((ButtonBase)val).TextAlign = (ContentAlignment)512;
					Padding margin = new Padding(5, 0, 5, 0);
					((Control)val).Margin = margin;
					((Control)val).Width = 85;
					((Control)val).Height = 94;
					((ButtonBase)val).Image = Image.FromFile(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + MyProject.Forms.Form_3_VENTE.DataGridView_MODE_P.Rows[num2].Cells[1].Value.ToString());
					((ButtonBase)val).ImageAlign = (ContentAlignment)2;
					((ButtonBase)val).FlatStyle = (FlatStyle)0;
					((ButtonBase)val).FlatAppearance.BorderSize = 0;
					((Control)val).Cursor = Cursors.Hand;
					((Control)val).Font = new Font("Calibri", 12f, (FontStyle)1);
					((Control)val).ForeColor = Color.FromArgb(2, 45, 162);
					((Control)val).Click += FAM_click;
					((Control)FlowLayoutPanel_MODE_P).Controls.Add((Control)(object)val);
					num2++;
				}
				((Control)Panel_CLAVIER).Visible = false;
				DataGridView_CALC.Rows.Clear();
				((Control)Panel_REMARQUE).Visible = false;
				Text_REMARQUE.Text = "";
				((ButtonBase)Button_RESTE).Text = "";
				Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), e);
				if (Operators.CompareString(((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text, "VENTE", TextCompare: false) == 0)
				{
					((Control)Panel_RETOUR).Visible = false;
				}
				else if (Operators.CompareString(((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text, "RETOUR", TextCompare: false) == 0)
				{
					((Control)Panel_RETOUR).Visible = true;
					((Control)Panel_RETOUR).BringToFront();
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
		}
	}

	public void FAM_click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				DataGridView_CALC.Rows.Add(new object[4]
				{
					Conversion.Val(((ButtonBase)Button_RESTE).Text),
					0,
					0,
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null))
				});
				Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), e);
				DataGridView_CALC.CurrentCell = DataGridView_CALC.Rows[DataGridView_CALC.Rows.Count - 1].Cells[1];
				((Control)DataGridView_CALC).Focus();
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), "ESPECES", TextCompare: false))
				{
					Button_RESTE.PerformClick();
					((Control)Panel_REMARQUE).Visible = true;
				}
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

	private void Button12_Click(object sender, EventArgs e)
	{
		if (((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text.Contains("RETOUR"))
		{
			((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text = "RETOUR";
		}
		Module1._quittersolder = true;
		((Form)this).Close();
	}

	private void Button_SOLDER_Click(object sender, EventArgs e)
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView_CALC.Rows.Count == 0)
			{
				MessageBox.Show("Choisissez une mode de paiement", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (Operators.CompareString(((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text, "RETOUR REMBOURSEMENT", TextCompare: false) == 0)
			{
				if (DataGridView_CALC.Rows.Count > 1)
				{
					MessageBox.Show("Choisissez un seul mode de paiement pour le retour", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Conversions.ToDouble(((ButtonBase)Button_RESTE).Text) != 0.0)
				{
					MessageBox.Show("Le Reste doit être à zéro (0)", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
			}
			if (decimal.Compare(Conversions.ToDecimal(((ButtonBase)Button_RESTE).Text), 0m) > 0)
			{
				MessageBox.Show("Solder le Reste", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			Module1._quittersolder = false;
			((Form)this).Close();
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

	private void Button_DEVIS_Click(object sender, EventArgs e)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_CALC.Rows.Count == 0)
			{
				Button val = (Button)((Control)FlowLayoutPanel_MODE_P).Controls["Button_ESPECES"];
				val.PerformClick();
				Button_REFRESH.PerformClick();
			}
			DataGridView_CALC.Rows[((DataGridViewBand)DataGridView_CALC.CurrentRow).Index].Cells[1].Value = Operators.AddObject(DataGridView_CALC.Rows[((DataGridViewBand)DataGridView_CALC.CurrentRow).Index].Cells[1].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null))));
			Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), e);
			((Control)DataGridView_CALC).Focus();
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
	}

	private void Button_APERCU_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		PrintPreviewDialog val = new PrintPreviewDialog();
		val.Text = "";
		val.Document = MyProject.Forms.Form_3_VENTE.CL_FR_3C;
		((Control)val).Controls[1].Visible = false;
		val.PrintPreviewControl.Zoom = 2.0;
		((Form)val).WindowState = (FormWindowState)2;
		((Form)val).ShowDialog();
	}

	private void Text_TOTAL_NET_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_RESTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button_calc_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataGridView_CALC.Rows)
			{
				DataGridViewRow val = item;
				val.Height = (int)Math.Round((double)(((Control)DataGridView_CALC).Height - DataGridView_CALC.ColumnHeadersHeight - 3) / (double)DataGridView_CALC.Rows.Count);
			}
			int num = DataGridView_CALC.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView_CALC.Rows[num2].Cells[2].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.SubtractObject(DataGridView_CALC.Rows[num2].Cells[1].Value, DataGridView_CALC.Rows[num2].Cells[0].Value)));
				num2++;
			}
			double num5 = 0.0;
			double num6 = 0.0;
			int num7 = DataGridView_CALC.Rows.Count - 1;
			int num8 = 0;
			while (true)
			{
				int num9 = num8;
				int num4 = num7;
				if (num9 > num4)
				{
					break;
				}
				num5 = Conversions.ToDouble(Operators.AddObject(num5, DataGridView_CALC.Rows[num8].Cells[1].Value));
				num6 = Conversions.ToDouble(Operators.AddObject(num6, DataGridView_CALC.Rows[num8].Cells[2].Value));
				num8++;
			}
			((ButtonBase)Button_RESTE).Text = Conversions.ToString(Module1.FLOUSS(new decimal(Conversion.Val(Text_TOTAL_NET.Text) - Conversion.Val(num5))));
			if (Conversion.Val(((ButtonBase)Button_RESTE).Text) > 0.0)
			{
				((Control)Button_SOLDER).Enabled = false;
			}
			else if (Conversion.Val(((ButtonBase)Button_RESTE).Text) <= 0.0)
			{
				((Control)Button_SOLDER).Enabled = true;
			}
			if (DataGridView_CALC.Rows.Count > 0)
			{
				DataGridView_CALC.Rows[0].Cells[1].Style.BackColor = Color.Yellow;
			}
		}
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		try
		{
			if (e.ColumnIndex == 4)
			{
				DataGridView_CALC.Rows.RemoveAt(DataGridView_CALC.CurrentCell.RowIndex);
				Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void DataGridView_CALC_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView_CALC.Rows.Count != 0 && ((e.ColumnIndex == 0) | (e.ColumnIndex == 2) | (e.ColumnIndex == 3)))
				{
					DataGridView_CALC.CurrentCell = DataGridView_CALC.Rows[DataGridView_CALC.Rows.Count - 1].Cells[1];
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

	private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		if (DataGridView_CALC.CurrentCell.ColumnIndex == 1)
		{
			((Control)(TextBox)e.Control).KeyPress += TextBox_keyPress;
		}
	}

	private void TextBox_keyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
	}

	private void Button_NUMERIQUE_Click(object sender, EventArgs e)
	{
		if (DataGridView_CALC.Rows.Count != 0)
		{
			((Control)Panel_CLAVIER).Visible = true;
			((Control)Panel_CLAVIER).BringToFront();
			Label_NUM.Text = "";
			((Control)DataGridView_CALC).Focus();
		}
	}

	private void Button_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_CALC.Rows.Count != 0)
			{
				DataGridView_CALC.Rows[((DataGridViewBand)DataGridView_CALC.CurrentRow).Index].Cells[1].Value = "0";
				((Control)DataGridView_CALC).Focus();
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

	private void Button_RESTE_Click(object sender, EventArgs e)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_CALC.Rows.Count == 0)
			{
				Button val = (Button)((Control)FlowLayoutPanel_MODE_P).Controls["Button_ESPECES"];
				val.PerformClick();
				Button_REFRESH.PerformClick();
			}
			DataGridView_CALC.Rows[((DataGridViewBand)DataGridView_CALC.CurrentRow).Index].Cells[1].Value = Conversion.Val(((ButtonBase)Button_RESTE).Text);
			Button_calc_Click(RuntimeHelpers.GetObjectValue(sender), e);
			((Control)DataGridView_CALC).Focus();
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
	}

	private void FormDialog_calc_Shown(object sender, EventArgs e)
	{
		((Control)DataGridView_CALC).Focus();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Button_RESTE.PerformClick();
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Label_NUM.Text = Conversions.ToString(Operators.AddObject(Label_NUM.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
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
				Label_NUM.Text = Label_NUM.Text.Remove(checked(Label_NUM.Text.Length - 1));
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

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridView_CALC.Rows[((DataGridViewBand)DataGridView_CALC.CurrentRow).Index].Cells[1].Value = Conversion.Val(Label_NUM.Text);
			((Control)DataGridView_CALC).Focus();
			SendKeys.Send("{RIGHT}{LEFT}");
			Label_NUM.Text = "";
			((Control)Panel_CLAVIER).Visible = false;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text = "RETOUR REMBOURSEMENT";
		Button val = (Button)((Control)FlowLayoutPanel_MODE_P).Controls["Button_ESPECES"];
		val.PerformClick();
		Button_RESTE.PerformClick();
		((Control)Panel_RETOUR).Visible = false;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_OPERATION).Text = "RETOUR AVOIR";
		Module1._quittersolder = false;
		((Form)this).Close();
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
