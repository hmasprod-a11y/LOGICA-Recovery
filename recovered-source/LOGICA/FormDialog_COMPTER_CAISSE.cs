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
public class FormDialog_COMPTER_CAISSE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("MODE_P")]
	private DataGridViewTextBoxColumn _MODE_P;

	[AccessedThroughProperty("MONTANT")]
	private DataGridViewTextBoxColumn _MONTANT;

	[AccessedThroughProperty("CAISSE")]
	private DataGridViewTextBoxColumn _CAISSE;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Text_200")]
	private TextBox _Text_200;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Text_100")]
	private TextBox _Text_100;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Text_50")]
	private TextBox _Text_50;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Text_20")]
	private TextBox _Text_20;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Text_10")]
	private TextBox _Text_10;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Text_5")]
	private TextBox _Text_5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Text_2")]
	private TextBox _Text_2;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_1")]
	private TextBox _Text_1;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Text_0_5")]
	private TextBox _Text_0_5;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Text_0_2")]
	private TextBox _Text_0_2;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Text_0_1")]
	private TextBox _Text_0_1;

	[AccessedThroughProperty("Panel_FICHE")]
	private Panel _Panel_FICHE;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Text_TOTAL_ESPECES")]
	private TextBox _Text_TOTAL_ESPECES;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Button_CAISSIER")]
	private Button _Button_CAISSIER;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private TextBox _Text_TOTAL_NET;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

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

	internal virtual DataGridViewTextBoxColumn CAISSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CAISSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CAISSE = value;
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

	internal virtual TextBox Text_200
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_200;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_TextChanged;
			EventHandler eventHandler3 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler4 = TextBox_LostFocus;
			if (_Text_200 != null)
			{
				((Control)_Text_200).GotFocus -= eventHandler;
				((Control)_Text_200).TextChanged -= eventHandler2;
				((TextBoxBase)_Text_200).Click -= eventHandler3;
				((Control)_Text_200).KeyPress -= val;
				((Control)_Text_200).LostFocus -= eventHandler4;
			}
			_Text_200 = value;
			if (_Text_200 != null)
			{
				((Control)_Text_200).GotFocus += eventHandler;
				((Control)_Text_200).TextChanged += eventHandler2;
				((TextBoxBase)_Text_200).Click += eventHandler3;
				((Control)_Text_200).KeyPress += val;
				((Control)_Text_200).LostFocus += eventHandler4;
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

	internal virtual TextBox Text_100
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_100 != null)
			{
				((Control)_Text_100).GotFocus -= eventHandler;
				((TextBoxBase)_Text_100).Click -= eventHandler2;
				((Control)_Text_100).KeyPress -= val;
				((Control)_Text_100).LostFocus -= eventHandler3;
			}
			_Text_100 = value;
			if (_Text_100 != null)
			{
				((Control)_Text_100).GotFocus += eventHandler;
				((TextBoxBase)_Text_100).Click += eventHandler2;
				((Control)_Text_100).KeyPress += val;
				((Control)_Text_100).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_50 != null)
			{
				((Control)_Text_50).GotFocus -= eventHandler;
				((TextBoxBase)_Text_50).Click -= eventHandler2;
				((Control)_Text_50).KeyPress -= val;
				((Control)_Text_50).LostFocus -= eventHandler3;
			}
			_Text_50 = value;
			if (_Text_50 != null)
			{
				((Control)_Text_50).GotFocus += eventHandler;
				((TextBoxBase)_Text_50).Click += eventHandler2;
				((Control)_Text_50).KeyPress += val;
				((Control)_Text_50).LostFocus += eventHandler3;
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

	internal virtual TextBox Text_20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_20 != null)
			{
				((Control)_Text_20).GotFocus -= eventHandler;
				((TextBoxBase)_Text_20).Click -= eventHandler2;
				((Control)_Text_20).KeyPress -= val;
				((Control)_Text_20).LostFocus -= eventHandler3;
			}
			_Text_20 = value;
			if (_Text_20 != null)
			{
				((Control)_Text_20).GotFocus += eventHandler;
				((TextBoxBase)_Text_20).Click += eventHandler2;
				((Control)_Text_20).KeyPress += val;
				((Control)_Text_20).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_10 != null)
			{
				((Control)_Text_10).GotFocus -= eventHandler;
				((TextBoxBase)_Text_10).Click -= eventHandler2;
				((Control)_Text_10).KeyPress -= val;
				((Control)_Text_10).LostFocus -= eventHandler3;
			}
			_Text_10 = value;
			if (_Text_10 != null)
			{
				((Control)_Text_10).GotFocus += eventHandler;
				((TextBoxBase)_Text_10).Click += eventHandler2;
				((Control)_Text_10).KeyPress += val;
				((Control)_Text_10).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_5 != null)
			{
				((Control)_Text_5).GotFocus -= eventHandler;
				((TextBoxBase)_Text_5).Click -= eventHandler2;
				((Control)_Text_5).KeyPress -= val;
				((Control)_Text_5).LostFocus -= eventHandler3;
			}
			_Text_5 = value;
			if (_Text_5 != null)
			{
				((Control)_Text_5).GotFocus += eventHandler;
				((TextBoxBase)_Text_5).Click += eventHandler2;
				((Control)_Text_5).KeyPress += val;
				((Control)_Text_5).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_2 != null)
			{
				((Control)_Text_2).GotFocus -= eventHandler;
				((TextBoxBase)_Text_2).Click -= eventHandler2;
				((Control)_Text_2).KeyPress -= val;
				((Control)_Text_2).LostFocus -= eventHandler3;
			}
			_Text_2 = value;
			if (_Text_2 != null)
			{
				((Control)_Text_2).GotFocus += eventHandler;
				((TextBoxBase)_Text_2).Click += eventHandler2;
				((Control)_Text_2).KeyPress += val;
				((Control)_Text_2).LostFocus += eventHandler3;
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual TextBox Text_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_1 != null)
			{
				((Control)_Text_1).GotFocus -= eventHandler;
				((TextBoxBase)_Text_1).Click -= eventHandler2;
				((Control)_Text_1).KeyPress -= val;
				((Control)_Text_1).LostFocus -= eventHandler3;
			}
			_Text_1 = value;
			if (_Text_1 != null)
			{
				((Control)_Text_1).GotFocus += eventHandler;
				((TextBoxBase)_Text_1).Click += eventHandler2;
				((Control)_Text_1).KeyPress += val;
				((Control)_Text_1).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_0_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_0_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_0_5 != null)
			{
				((Control)_Text_0_5).GotFocus -= eventHandler;
				((TextBoxBase)_Text_0_5).Click -= eventHandler2;
				((Control)_Text_0_5).KeyPress -= val;
				((Control)_Text_0_5).LostFocus -= eventHandler3;
			}
			_Text_0_5 = value;
			if (_Text_0_5 != null)
			{
				((Control)_Text_0_5).GotFocus += eventHandler;
				((TextBoxBase)_Text_0_5).Click += eventHandler2;
				((Control)_Text_0_5).KeyPress += val;
				((Control)_Text_0_5).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_0_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_0_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_0_2 != null)
			{
				((Control)_Text_0_2).GotFocus -= eventHandler;
				((TextBoxBase)_Text_0_2).Click -= eventHandler2;
				((Control)_Text_0_2).KeyPress -= val;
				((Control)_Text_0_2).LostFocus -= eventHandler3;
			}
			_Text_0_2 = value;
			if (_Text_0_2 != null)
			{
				((Control)_Text_0_2).GotFocus += eventHandler;
				((TextBoxBase)_Text_0_2).Click += eventHandler2;
				((Control)_Text_0_2).KeyPress += val;
				((Control)_Text_0_2).LostFocus += eventHandler3;
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

	internal virtual TextBox Text_0_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_0_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_GotFocus;
			EventHandler eventHandler2 = Text_200_Click;
			KeyPressEventHandler val = Text_200_KeyPress;
			EventHandler eventHandler3 = TextBox_LostFocus;
			if (_Text_0_1 != null)
			{
				((Control)_Text_0_1).GotFocus -= eventHandler;
				((TextBoxBase)_Text_0_1).Click -= eventHandler2;
				((Control)_Text_0_1).KeyPress -= val;
				((Control)_Text_0_1).LostFocus -= eventHandler3;
			}
			_Text_0_1 = value;
			if (_Text_0_1 != null)
			{
				((Control)_Text_0_1).GotFocus += eventHandler;
				((TextBoxBase)_Text_0_1).Click += eventHandler2;
				((Control)_Text_0_1).KeyPress += val;
				((Control)_Text_0_1).LostFocus += eventHandler3;
			}
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

	internal virtual TextBox Text_TOTAL_ESPECES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL_ESPECES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TOTAL_ESPECES = value;
		}
	}

	internal virtual Label Label35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label35 = value;
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

	internal virtual Button Button_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_CAISSIER = value;
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

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
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
	public FormDialog_COMPTER_CAISSE()
	{
		((Form)this).Load += FormDialog_COMPTER_CAISSE_Load;
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
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected Obj, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected Obj, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected Obj, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Expected Obj, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected Obj, but got Unknown
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected Obj, but got Unknown
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected Obj, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected Obj, but got Unknown
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Expected Obj, but got Unknown
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1244: Expected Obj, but got Unknown
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1303: Expected Obj, but got Unknown
		//IL_132a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Expected Obj, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Expected Obj, but got Unknown
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1804: Expected Obj, but got Unknown
		//IL_1954: Unknown result type (might be due to invalid IL or missing references)
		//IL_195e: Expected Obj, but got Unknown
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Expected Obj, but got Unknown
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b04: Expected Obj, but got Unknown
		//IL_1bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd5: Expected Obj, but got Unknown
		//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca2: Expected Obj, but got Unknown
		//IL_1d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5e: Expected Obj, but got Unknown
		//IL_1d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7a: Expected Obj, but got Unknown
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected Obj, but got Unknown
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_2033: Expected Obj, but got Unknown
		//IL_2103: Unknown result type (might be due to invalid IL or missing references)
		//IL_210d: Expected Obj, but got Unknown
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e7: Expected Obj, but got Unknown
		//IL_22b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bd: Expected Obj, but got Unknown
		//IL_241c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2426: Expected Obj, but got Unknown
		//IL_2438: Unknown result type (might be due to invalid IL or missing references)
		//IL_2442: Expected Obj, but got Unknown
		//IL_2454: Unknown result type (might be due to invalid IL or missing references)
		//IL_245e: Expected Obj, but got Unknown
		//IL_2470: Unknown result type (might be due to invalid IL or missing references)
		//IL_247a: Expected Obj, but got Unknown
		//IL_248c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2496: Expected Obj, but got Unknown
		//IL_24a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b2: Expected Obj, but got Unknown
		//IL_24c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ce: Expected Obj, but got Unknown
		//IL_24e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ea: Expected Obj, but got Unknown
		//IL_24fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2506: Expected Obj, but got Unknown
		//IL_2518: Unknown result type (might be due to invalid IL or missing references)
		//IL_2522: Expected Obj, but got Unknown
		//IL_2534: Unknown result type (might be due to invalid IL or missing references)
		//IL_253e: Expected Obj, but got Unknown
		//IL_26bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f1: Expected Obj, but got Unknown
		//IL_2703: Unknown result type (might be due to invalid IL or missing references)
		//IL_270d: Expected Obj, but got Unknown
		//IL_271f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2729: Expected Obj, but got Unknown
		//IL_273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2745: Expected Obj, but got Unknown
		//IL_2757: Unknown result type (might be due to invalid IL or missing references)
		//IL_2761: Expected Obj, but got Unknown
		//IL_2773: Unknown result type (might be due to invalid IL or missing references)
		//IL_277d: Expected Obj, but got Unknown
		//IL_27e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f1: Expected Obj, but got Unknown
		//IL_2803: Unknown result type (might be due to invalid IL or missing references)
		//IL_280d: Expected Obj, but got Unknown
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_2889: Unknown result type (might be due to invalid IL or missing references)
		//IL_28af: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b9: Expected Obj, but got Unknown
		//IL_28cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d5: Expected Obj, but got Unknown
		//IL_29a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29aa: Expected Obj, but got Unknown
		//IL_29e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b02: Expected Obj, but got Unknown
		//IL_2b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5e: Expected Obj, but got Unknown
		//IL_2c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dbb: Expected Obj, but got Unknown
		//IL_2df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1b: Expected Obj, but got Unknown
		//IL_2f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_306a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3074: Expected Obj, but got Unknown
		//IL_30a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30af: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ce: Expected Obj, but got Unknown
		//IL_3206: Unknown result type (might be due to invalid IL or missing references)
		//IL_320c: Unknown result type (might be due to invalid IL or missing references)
		//IL_322e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3234: Unknown result type (might be due to invalid IL or missing references)
		//IL_3321: Unknown result type (might be due to invalid IL or missing references)
		//IL_332b: Expected Obj, but got Unknown
		//IL_335e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3364: Unknown result type (might be due to invalid IL or missing references)
		//IL_3386: Unknown result type (might be due to invalid IL or missing references)
		//IL_338c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3479: Unknown result type (might be due to invalid IL or missing references)
		//IL_3483: Expected Obj, but got Unknown
		//IL_34b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_34df: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_35dc: Expected Obj, but got Unknown
		//IL_3614: Unknown result type (might be due to invalid IL or missing references)
		//IL_361a: Unknown result type (might be due to invalid IL or missing references)
		//IL_363c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3642: Unknown result type (might be due to invalid IL or missing references)
		//IL_372f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3739: Expected Obj, but got Unknown
		//IL_3770: Unknown result type (might be due to invalid IL or missing references)
		//IL_3776: Unknown result type (might be due to invalid IL or missing references)
		//IL_3798: Unknown result type (might be due to invalid IL or missing references)
		//IL_379e: Unknown result type (might be due to invalid IL or missing references)
		//IL_388b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3895: Expected Obj, but got Unknown
		//IL_38d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_39eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f5: Expected Obj, but got Unknown
		//IL_3a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a22: Expected Obj, but got Unknown
		//IL_3a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b62: Expected Obj, but got Unknown
		//IL_3b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b8f: Expected Obj, but got Unknown
		//IL_3bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c67: Expected Obj, but got Unknown
		//IL_3d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d9e: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_COMPTER_CAISSE));
		DataGridView1 = new DataGridView();
		MODE_P = new DataGridViewTextBoxColumn();
		MONTANT = new DataGridViewTextBoxColumn();
		CAISSE = new DataGridViewTextBoxColumn();
		Label13 = new Label();
		Text_200 = new TextBox();
		Label1 = new Label();
		Text_100 = new TextBox();
		Label2 = new Label();
		Text_50 = new TextBox();
		Label3 = new Label();
		Text_20 = new TextBox();
		Label4 = new Label();
		Text_10 = new TextBox();
		Label5 = new Label();
		Text_5 = new TextBox();
		Label6 = new Label();
		Text_2 = new TextBox();
		Label7 = new Label();
		Text_1 = new TextBox();
		Label8 = new Label();
		Text_0_5 = new TextBox();
		Label9 = new Label();
		Text_0_2 = new TextBox();
		Label10 = new Label();
		Text_0_1 = new TextBox();
		Panel_FICHE = new Panel();
		Label_BOTTOM = new Label();
		Panel2 = new Panel();
		Text_TOTAL_ESPECES = new TextBox();
		Label35 = new Label();
		Label_RIGHT = new Label();
		Label_LEFT = new Label();
		Label_TOP = new Label();
		Button_CAISSIER = new Button();
		Panel3 = new Panel();
		Text_TOTAL_NET = new TextBox();
		Label11 = new Label();
		Label12 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		TableLayoutPanel1 = new TableLayoutPanel();
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
		Butt_DRAFT = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FICHE).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
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
		DataGridView1.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)MODE_P,
			(DataGridViewColumn)MONTANT,
			(DataGridViewColumn)CAISSE
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(9, 49);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(327, 220);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1063;
		((DataGridViewColumn)MODE_P).HeaderText = "MODE_P";
		((DataGridViewColumn)MODE_P).Name = "MODE_P";
		((DataGridViewColumn)MONTANT).HeaderText = "MONTANT";
		((DataGridViewColumn)MONTANT).Name = "MONTANT";
		((DataGridViewColumn)CAISSE).HeaderText = "CAISSE";
		((DataGridViewColumn)CAISSE).Name = "CAISSE";
		((Control)Label13).BackColor = Color.Transparent;
		((Control)Label13).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label13).ForeColor = Color.Black;
		Label13.ImeMode = (ImeMode)0;
		Label label = Label13;
		location = new Point(70, 9);
		((Control)label).Location = location;
		((Control)Label13).Name = "Label13";
		Label label2 = Label13;
		size = new Size(65, 30);
		((Control)label2).Size = size;
		((Control)Label13).TabIndex = 1065;
		Label13.Text = "x 200";
		Label13.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_200).BorderStyle = (BorderStyle)1;
		((Control)Text_200).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_ = Text_200;
		location = new Point(13, 9);
		((Control)text_).Location = location;
		TextBox text_2 = Text_200;
		Padding margin = new Padding(0);
		((Control)text_2).Margin = margin;
		((Control)Text_200).Name = "Text_200";
		TextBox text_3 = Text_200;
		size = new Size(59, 30);
		((Control)text_3).Size = size;
		((Control)Text_200).TabIndex = 0;
		Text_200.Text = "0";
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label1.ImeMode = (ImeMode)0;
		Label label3 = Label1;
		location = new Point(70, 47);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(65, 30);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 1067;
		Label1.Text = "x 100";
		Label1.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_100).BorderStyle = (BorderStyle)1;
		((Control)Text_100).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_4 = Text_100;
		location = new Point(13, 47);
		((Control)text_4).Location = location;
		TextBox text_5 = Text_100;
		margin = new Padding(0);
		((Control)text_5).Margin = margin;
		((Control)Text_100).Name = "Text_100";
		TextBox text_6 = Text_100;
		size = new Size(59, 30);
		((Control)text_6).Size = size;
		((Control)Text_100).TabIndex = 1;
		Text_100.Text = "0";
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label2.ImeMode = (ImeMode)0;
		Label label5 = Label2;
		location = new Point(70, 85);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(65, 30);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 1069;
		Label2.Text = "x 50";
		Label2.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_50).BorderStyle = (BorderStyle)1;
		((Control)Text_50).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_7 = Text_50;
		location = new Point(13, 85);
		((Control)text_7).Location = location;
		TextBox text_8 = Text_50;
		margin = new Padding(0);
		((Control)text_8).Margin = margin;
		((Control)Text_50).Name = "Text_50";
		TextBox text_9 = Text_50;
		size = new Size(59, 30);
		((Control)text_9).Size = size;
		((Control)Text_50).TabIndex = 2;
		Text_50.Text = "0";
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label3.ImeMode = (ImeMode)0;
		Label label7 = Label3;
		location = new Point(70, 123);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(65, 30);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 1071;
		Label3.Text = "x 20";
		Label3.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_20).BorderStyle = (BorderStyle)1;
		((Control)Text_20).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_10 = Text_20;
		location = new Point(13, 123);
		((Control)text_10).Location = location;
		TextBox text_11 = Text_20;
		margin = new Padding(0);
		((Control)text_11).Margin = margin;
		((Control)Text_20).Name = "Text_20";
		TextBox text_12 = Text_20;
		size = new Size(59, 30);
		((Control)text_12).Size = size;
		((Control)Text_20).TabIndex = 3;
		Text_20.Text = "0";
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label4.ImeMode = (ImeMode)0;
		Label label9 = Label4;
		location = new Point(70, 161);
		((Control)label9).Location = location;
		((Control)Label4).Name = "Label4";
		Label label10 = Label4;
		size = new Size(65, 30);
		((Control)label10).Size = size;
		((Control)Label4).TabIndex = 1073;
		Label4.Text = "x 10";
		Label4.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_10).BorderStyle = (BorderStyle)1;
		((Control)Text_10).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_13 = Text_10;
		location = new Point(13, 161);
		((Control)text_13).Location = location;
		TextBox text_14 = Text_10;
		margin = new Padding(0);
		((Control)text_14).Margin = margin;
		((Control)Text_10).Name = "Text_10";
		TextBox text_15 = Text_10;
		size = new Size(59, 30);
		((Control)text_15).Size = size;
		((Control)Text_10).TabIndex = 4;
		Text_10.Text = "0";
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.Black;
		Label5.ImeMode = (ImeMode)0;
		Label label11 = Label5;
		location = new Point(70, 199);
		((Control)label11).Location = location;
		((Control)Label5).Name = "Label5";
		Label label12 = Label5;
		size = new Size(65, 30);
		((Control)label12).Size = size;
		((Control)Label5).TabIndex = 1075;
		Label5.Text = "x 5";
		Label5.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_5).BorderStyle = (BorderStyle)1;
		((Control)Text_5).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_16 = Text_5;
		location = new Point(13, 199);
		((Control)text_16).Location = location;
		TextBox text_17 = Text_5;
		margin = new Padding(0);
		((Control)text_17).Margin = margin;
		((Control)Text_5).Name = "Text_5";
		TextBox text_18 = Text_5;
		size = new Size(59, 30);
		((Control)text_18).Size = size;
		((Control)Text_5).TabIndex = 5;
		Text_5.Text = "0";
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.Black;
		Label6.ImeMode = (ImeMode)0;
		Label label13 = Label6;
		location = new Point(230, 9);
		((Control)label13).Location = location;
		((Control)Label6).Name = "Label6";
		Label label14 = Label6;
		size = new Size(65, 30);
		((Control)label14).Size = size;
		((Control)Label6).TabIndex = 1077;
		Label6.Text = "x 2";
		Label6.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_2).BorderStyle = (BorderStyle)1;
		((Control)Text_2).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_19 = Text_2;
		location = new Point(173, 9);
		((Control)text_19).Location = location;
		TextBox text_20 = Text_2;
		margin = new Padding(0);
		((Control)text_20).Margin = margin;
		((Control)Text_2).Name = "Text_2";
		TextBox text_21 = Text_2;
		size = new Size(59, 30);
		((Control)text_21).Size = size;
		((Control)Text_2).TabIndex = 6;
		Text_2.Text = "0";
		((Control)Label7).BackColor = Color.Transparent;
		((Control)Label7).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.Black;
		Label7.ImeMode = (ImeMode)0;
		Label label15 = Label7;
		location = new Point(230, 47);
		((Control)label15).Location = location;
		((Control)Label7).Name = "Label7";
		Label label16 = Label7;
		size = new Size(65, 30);
		((Control)label16).Size = size;
		((Control)Label7).TabIndex = 1079;
		Label7.Text = "x 1";
		Label7.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_1).BorderStyle = (BorderStyle)1;
		((Control)Text_1).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_22 = Text_1;
		location = new Point(173, 47);
		((Control)text_22).Location = location;
		TextBox text_23 = Text_1;
		margin = new Padding(0);
		((Control)text_23).Margin = margin;
		((Control)Text_1).Name = "Text_1";
		TextBox text_24 = Text_1;
		size = new Size(59, 30);
		((Control)text_24).Size = size;
		((Control)Text_1).TabIndex = 7;
		Text_1.Text = "0";
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label8.ImeMode = (ImeMode)0;
		Label label17 = Label8;
		location = new Point(230, 85);
		((Control)label17).Location = location;
		((Control)Label8).Name = "Label8";
		Label label18 = Label8;
		size = new Size(65, 30);
		((Control)label18).Size = size;
		((Control)Label8).TabIndex = 1081;
		Label8.Text = "x 0.5";
		Label8.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_0_5).BorderStyle = (BorderStyle)1;
		((Control)Text_0_5).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_0_ = Text_0_5;
		location = new Point(173, 85);
		((Control)text_0_).Location = location;
		TextBox text_0_2 = Text_0_5;
		margin = new Padding(0);
		((Control)text_0_2).Margin = margin;
		((Control)Text_0_5).Name = "Text_0_5";
		TextBox text_0_3 = Text_0_5;
		size = new Size(59, 30);
		((Control)text_0_3).Size = size;
		((Control)Text_0_5).TabIndex = 8;
		Text_0_5.Text = "0";
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.Black;
		Label9.ImeMode = (ImeMode)0;
		Label label19 = Label9;
		location = new Point(230, 123);
		((Control)label19).Location = location;
		((Control)Label9).Name = "Label9";
		Label label20 = Label9;
		size = new Size(65, 30);
		((Control)label20).Size = size;
		((Control)Label9).TabIndex = 1083;
		Label9.Text = "x 0.2";
		Label9.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_0_2).BorderStyle = (BorderStyle)1;
		((Control)Text_0_2).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_0_4 = Text_0_2;
		location = new Point(173, 123);
		((Control)text_0_4).Location = location;
		TextBox text_0_5 = Text_0_2;
		margin = new Padding(0);
		((Control)text_0_5).Margin = margin;
		((Control)Text_0_2).Name = "Text_0_2";
		TextBox text_0_6 = Text_0_2;
		size = new Size(59, 30);
		((Control)text_0_6).Size = size;
		((Control)Text_0_2).TabIndex = 9;
		Text_0_2.Text = "0";
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label10.ImeMode = (ImeMode)0;
		Label label21 = Label10;
		location = new Point(230, 161);
		((Control)label21).Location = location;
		((Control)Label10).Name = "Label10";
		Label label22 = Label10;
		size = new Size(65, 30);
		((Control)label22).Size = size;
		((Control)Label10).TabIndex = 1085;
		Label10.Text = "x 0.1";
		Label10.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_0_1).BorderStyle = (BorderStyle)1;
		((Control)Text_0_1).Font = new Font("Segoe UI", 15f, (FontStyle)1);
		TextBox text_0_7 = Text_0_1;
		location = new Point(173, 161);
		((Control)text_0_7).Location = location;
		TextBox text_0_8 = Text_0_1;
		margin = new Padding(0);
		((Control)text_0_8).Margin = margin;
		((Control)Text_0_1).Name = "Text_0_1";
		TextBox text_0_9 = Text_0_1;
		size = new Size(59, 30);
		((Control)text_0_9).Size = size;
		((Control)Text_0_1).TabIndex = 10;
		Text_0_1.Text = "0";
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Panel2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_200);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_100);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_0_1);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_50);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_0_2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_20);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_0_5);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_10);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_1);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_5);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label13);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label1);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label3);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label4);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label5);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label10);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label9);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label8);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label7);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label6);
		Panel panel_FICHE = Panel_FICHE;
		location = new Point(358, 12);
		((Control)panel_FICHE).Location = location;
		((Control)Panel_FICHE).Name = "Panel_FICHE";
		Panel panel_FICHE2 = Panel_FICHE;
		size = new Size(307, 276);
		((Control)panel_FICHE2).Size = size;
		((Control)Panel_FICHE).TabIndex = 0;
		((Control)Label_BOTTOM).BackColor = Color.Magenta;
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label_BOTTOM.ImeMode = (ImeMode)0;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 272);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(299, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1089;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Panel2).BackColor = Color.Magenta;
		((Control)Panel2).Controls.Add((Control)(object)Text_TOTAL_ESPECES);
		((Control)Panel2).Controls.Add((Control)(object)Label35);
		Panel panel = Panel2;
		location = new Point(3, 240);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(301, 33);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 1088;
		((TextBoxBase)Text_TOTAL_ESPECES).BackColor = Color.Magenta;
		((TextBoxBase)Text_TOTAL_ESPECES).BorderStyle = (BorderStyle)0;
		((Control)Text_TOTAL_ESPECES).Font = new Font("Segoe UI", 24f, (FontStyle)1);
		((TextBoxBase)Text_TOTAL_ESPECES).ForeColor = Color.White;
		TextBox text_TOTAL_ESPECES = Text_TOTAL_ESPECES;
		location = new Point(134, -2);
		((Control)text_TOTAL_ESPECES).Location = location;
		Text_TOTAL_ESPECES.Multiline = true;
		((Control)Text_TOTAL_ESPECES).Name = "Text_TOTAL_ESPECES";
		((TextBoxBase)Text_TOTAL_ESPECES).ReadOnly = true;
		TextBox text_TOTAL_ESPECES2 = Text_TOTAL_ESPECES;
		size = new Size(160, 35);
		((Control)text_TOTAL_ESPECES2).Size = size;
		((Control)Text_TOTAL_ESPECES).TabIndex = 384;
		((Control)Text_TOTAL_ESPECES).Tag = "";
		((Control)Label35).BackColor = Color.Transparent;
		((Control)Label35).Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label35).ForeColor = Color.White;
		Label35.ImeMode = (ImeMode)0;
		Label label23 = Label35;
		location = new Point(3, 2);
		((Control)label23).Location = location;
		((Control)Label35).Name = "Label35";
		Label label24 = Label35;
		size = new Size(131, 28);
		((Control)label24).Size = size;
		((Control)Label35).TabIndex = 385;
		Label35.Text = "Total espèces:";
		Label35.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.Magenta;
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label_RIGHT.ImeMode = (ImeMode)0;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(303, 4);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 272);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1088;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.Magenta;
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label_LEFT.ImeMode = (ImeMode)0;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 4);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 272);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1087;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.Magenta;
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TOP).ForeColor = Color.White;
		Label_TOP.ImeMode = (ImeMode)0;
		Label label_TOP = Label_TOP;
		location = new Point(0, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(307, 4);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 1086;
		Label_TOP.TextAlign = (ContentAlignment)16;
		((Control)Button_CAISSIER).Cursor = Cursors.Hand;
		((ButtonBase)Button_CAISSIER).FlatStyle = (FlatStyle)0;
		((Control)Button_CAISSIER).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		((ButtonBase)Button_CAISSIER).Image = (Image)componentResourceManager.GetObject("Button_CAISSIER.Image");
		((ButtonBase)Button_CAISSIER).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_CAISSIER).ImeMode = (ImeMode)0;
		Button button_CAISSIER = Button_CAISSIER;
		location = new Point(9, 11);
		((Control)button_CAISSIER).Location = location;
		Button button_CAISSIER2 = Button_CAISSIER;
		margin = new Padding(0);
		((Control)button_CAISSIER2).Margin = margin;
		((Control)Button_CAISSIER).Name = "Button_CAISSIER";
		Button button_CAISSIER3 = Button_CAISSIER;
		size = new Size(327, 36);
		((Control)button_CAISSIER3).Size = size;
		((Control)Button_CAISSIER).TabIndex = 1089;
		((ButtonBase)Button_CAISSIER).UseVisualStyleBackColor = true;
		((Control)Panel3).Controls.Add((Control)(object)Text_TOTAL_NET);
		((Control)Panel3).Controls.Add((Control)(object)Label11);
		((Control)Panel3).Controls.Add((Control)(object)Button_CAISSIER);
		((Control)Panel3).Controls.Add((Control)(object)Label12);
		((Control)Panel3).Controls.Add((Control)(object)Label14);
		((Control)Panel3).Controls.Add((Control)(object)Label15);
		((Control)Panel3).Controls.Add((Control)(object)DataGridView1);
		Panel panel3 = Panel3;
		location = new Point(8, 12);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(344, 276);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 1090;
		((TextBoxBase)Text_TOTAL_NET).BackColor = Color.White;
		((TextBoxBase)Text_TOTAL_NET).BorderStyle = (BorderStyle)0;
		((Control)Text_TOTAL_NET).Font = new Font("Segoe UI", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)Text_TOTAL_NET).ForeColor = Color.Black;
		TextBox text_TOTAL_NET = Text_TOTAL_NET;
		location = new Point(119, 311);
		((Control)text_TOTAL_NET).Location = location;
		Text_TOTAL_NET.Multiline = true;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		((TextBoxBase)Text_TOTAL_NET).ReadOnly = true;
		TextBox text_TOTAL_NET2 = Text_TOTAL_NET;
		size = new Size(108, 22);
		((Control)text_TOTAL_NET2).Size = size;
		((Control)Text_TOTAL_NET).TabIndex = 384;
		((Control)Text_TOTAL_NET).Tag = "";
		((Control)Label11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).Dock = (DockStyle)2;
		((Control)Label11).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.White;
		Label11.ImeMode = (ImeMode)0;
		Label label25 = Label11;
		location = new Point(4, 272);
		((Control)label25).Location = location;
		((Control)Label11).Name = "Label11";
		Label label26 = Label11;
		size = new Size(336, 4);
		((Control)label26).Size = size;
		((Control)Label11).TabIndex = 1089;
		Label11.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label12).Cursor = Cursors.Hand;
		((Control)Label12).Dock = (DockStyle)4;
		((Control)Label12).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.White;
		Label12.ImeMode = (ImeMode)0;
		Label label27 = Label12;
		location = new Point(340, 4);
		((Control)label27).Location = location;
		((Control)Label12).Name = "Label12";
		Label label28 = Label12;
		size = new Size(4, 272);
		((Control)label28).Size = size;
		((Control)Label12).TabIndex = 1088;
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)3;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label14).ForeColor = Color.White;
		Label14.ImeMode = (ImeMode)0;
		Label label29 = Label14;
		location = new Point(0, 4);
		((Control)label29).Location = location;
		((Control)Label14).Name = "Label14";
		Label label30 = Label14;
		size = new Size(4, 272);
		((Control)label30).Size = size;
		((Control)Label14).TabIndex = 1087;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label15).Cursor = Cursors.Hand;
		((Control)Label15).Dock = (DockStyle)1;
		((Control)Label15).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label15).ForeColor = Color.White;
		Label15.ImeMode = (ImeMode)0;
		Label label31 = Label15;
		location = new Point(0, 0);
		((Control)label31).Location = location;
		((Control)Label15).Name = "Label15";
		Label label32 = Label15;
		size = new Size(344, 4);
		((Control)label32).Size = size;
		((Control)Label15).TabIndex = 1086;
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Panel_CLAVIER).BackColor = Color.Black;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(671, 12);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(348, 276);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1093;
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
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Calibri", 18f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT1;
		location = new Point(671, 294);
		((Control)button_CLAVIER_NOSELECT).Location = location;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = Button_CLAVIER_NOSELECT1;
		size = new Size(348, 54);
		((Control)button_CLAVIER_NOSELECT2).Size = size;
		((Control)Button_CLAVIER_NOSELECT1).TabIndex = 1092;
		((ButtonBase)Button_CLAVIER_NOSELECT1).Text = "OK";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1026, 358);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)this).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
		((Control)this).Controls.Add((Control)(object)Panel3);
		((Control)this).Controls.Add((Control)(object)Panel_FICHE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_COMPTER_CAISSE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "COMPTER LA CAISSE";
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FICHE).ResumeLayout(false);
		((Control)Panel_FICHE).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_COMPTER_CAISSE_Load(object sender, EventArgs e)
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		((ButtonBase)Button_CAISSIER).Text = Module1._USERNAME;
		checked
		{
			if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text, "True", TextCompare: false) == 0)
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'      and            CLOTURE_CAISSIER IS  NULL                      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataTable dataTable2 = new DataTable();
				DataGridView1.Rows.Clear();
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					val2 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE        MODE_P  = '" + Strings.Trim(dataTable.Rows[num2]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'          and            CLOTURE_CAISSIER IS  NULL               ", Module1.cn_SQL);
					dataTable2 = new DataTable();
					dataTable2.Clear();
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					double num5 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
					DataGridView1.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["MODE_P"].ToString(),
						Strings.FormatNumber(num5)
					});
					num2++;
				}
				dataTable2.Clear();
				dataTable2 = new DataTable();
				val2 = new MySqlDataAdapter("select sum(TOTAL_NET) as n   from   TABLE_VENTES_JOURNAL    WHERE        CLOTURE_CAISSIER IS  NULL           And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				Text_TOTAL_NET.Text = Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["n"].ToString()));
				return;
			}
			DataTable dataTable3 = new DataTable();
			MySqlDataAdapter val3 = new MySqlDataAdapter();
			dataTable3.Clear();
			val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '      And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'     ", Module1.cn_SQL);
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			MySqlDataAdapter val4 = new MySqlDataAdapter();
			DataTable dataTable4 = new DataTable();
			DataGridView1.Rows.Clear();
			int num6 = dataTable3.Rows.Count - 1;
			int num7 = 0;
			while (true)
			{
				int num8 = num7;
				int num4 = num6;
				if (num8 > num4)
				{
					break;
				}
				val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'      And     MODE_P  = '" + Strings.Trim(dataTable3.Rows[num7]["MODE_P"].ToString()) + "'  ", Module1.cn_SQL);
				dataTable4 = new DataTable();
				dataTable4.Clear();
				((DbDataAdapter)(object)val4).Fill(dataTable4);
				double num9 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
				DataGridView1.Rows.Add(new object[2]
				{
					dataTable3.Rows[num7]["MODE_P"].ToString(),
					Strings.FormatNumber(num9)
				});
				num7++;
			}
			dataTable4.Clear();
			dataTable4 = new DataTable();
			val4 = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '        And     Caissier like  '" + Strings.Trim(((ButtonBase)Button_CAISSIER).Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')                ", Module1.cn_SQL);
			((DbDataAdapter)(object)val4).Fill(dataTable4);
			Text_TOTAL_NET.Text = Strings.FormatNumber(Conversion.Val(dataTable4.Rows[0]["n"].ToString()));
		}
	}

	private void Text_200_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_200_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "HideSelection", new object[1] { false }, null, null);
		NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(sender, null, "focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void Text_200_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
	}

	private void TextBox_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.White }, null, null);
		if ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null))), "", TextCompare: false) == 0) | !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null))))
		{
			NewLateBinding.LateSet(sender, null, "text", new object[1] { 0 }, null, null);
		}
		decimal num = new decimal(Convert.ToDouble(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(0m, decimal.Multiply(Conversions.ToDecimal(Text_200.Text), 200m)), decimal.Multiply(Conversions.ToDecimal(Text_100.Text), 100m)), decimal.Multiply(Conversions.ToDecimal(Text_50.Text), 50m)), decimal.Multiply(Conversions.ToDecimal(Text_20.Text), 20m)), decimal.Multiply(Conversions.ToDecimal(Text_10.Text), 10m)), decimal.Multiply(Conversions.ToDecimal(Text_5.Text), 5m)), decimal.Multiply(Conversions.ToDecimal(Text_2.Text), 2m)), decimal.Multiply(Conversions.ToDecimal(Text_1.Text), 1m))) + Convert.ToDouble(Conversions.ToDecimal(Text_0_5.Text)) * 0.5 + Convert.ToDouble(Conversions.ToDecimal(Text_0_2.Text)) * 0.2 + Convert.ToDouble(Conversions.ToDecimal(Text_0_1.Text)) * 0.1);
		Text_TOTAL_ESPECES.Text = Strings.FormatNumber(num);
		checked
		{
			int num2 = DataGridView1.Rows.Count - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 <= num5)
				{
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num3].Cells["MODE_P"].Value, "ESPECES", TextCompare: false))
					{
						DataGridView1.Rows[num3].Cells["CAISSE"].Value = Strings.FormatNumber(num);
					}
					num3++;
					continue;
				}
				break;
			}
		}
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("{", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "}")));
	}

	private void Butt_BACK_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		int num3 = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num2 = 1;
					SendKeys.Send("{BACKSPACE}");
					break;
				case 55:
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
				ProjectData.ClearProjectError();
				num3 = -2;
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 55;
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
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		Control val = ((Control)this).Controls["Panel1"];
		foreach (Control control in val.Controls)
		{
			Control val2 = control;
			if (val2.Focused)
			{
				val2.Text = "";
			}
		}
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button_SOLDER_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{Tab}");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{Tab}");
	}

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{Tab}");
	}
}
