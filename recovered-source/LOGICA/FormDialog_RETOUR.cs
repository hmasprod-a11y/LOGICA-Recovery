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
public class FormDialog_RETOUR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Panel_RETOUR_AUTO")]
	private Panel _Panel_RETOUR_AUTO;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Text_N_TICKET")]
	private TextBox _Text_N_TICKET;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Button_FIND")]
	private Button _Button_FIND;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("Panel_TICKET")]
	private Panel _Panel_TICKET;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("Panel_CODE_BARRE")]
	private Panel _Panel_CODE_BARRE;

	[AccessedThroughProperty("Button_findd")]
	private Button _Button_findd;

	[AccessedThroughProperty("Text_CODE_BARRE")]
	private TextBox _Text_CODE_BARRE;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

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

	[AccessedThroughProperty("Button_NUMERIQUE")]
	private Button_CLAVIER_NOSELECT _Button_NUMERIQUE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("CHECK")]
	private DataGridViewCheckBoxColumn _CHECK;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("PRIX_A")]
	private DataGridViewTextBoxColumn _PRIX_A;

	[AccessedThroughProperty("PRIX_MP")]
	private DataGridViewTextBoxColumn _PRIX_MP;

	[AccessedThroughProperty("PRIX_V")]
	private DataGridViewTextBoxColumn _PRIX_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("REMISE")]
	private DataGridViewTextBoxColumn _REMISE;

	[AccessedThroughProperty("Total_NET")]
	private DataGridViewTextBoxColumn _Total_NET;

	[AccessedThroughProperty("TAUX_TVA")]
	private DataGridViewTextBoxColumn _TAUX_TVA;

	[AccessedThroughProperty("PRINTER")]
	private DataGridViewTextBoxColumn _PRINTER;

	[AccessedThroughProperty("PRINTER_DUPLICATA")]
	private DataGridViewTextBoxColumn _PRINTER_DUPLICATA;

	[AccessedThroughProperty("GROUPE")]
	private DataGridViewTextBoxColumn _GROUPE;

	[AccessedThroughProperty("VENDEUR")]
	private DataGridViewTextBoxColumn _VENDEUR;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CODE_CLIENT")]
	private DataGridViewTextBoxColumn _CODE_CLIENT;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

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

	internal virtual Panel Panel_RETOUR_AUTO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_RETOUR_AUTO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_RETOUR_AUTO = value;
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

	internal virtual TextBox Text_N_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_N_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox1_TextChanged;
			KeyEventHandler val = Text_N_TICKET_KeyDown;
			EventHandler eventHandler2 = Text_N_TICKET_LostFocus;
			EventHandler eventHandler3 = Text_N_TICKET_GotFocus;
			EventHandler eventHandler4 = Text_N_TICKET_Click;
			EventHandler eventHandler5 = Text_N_TICKET_TextChanged;
			if (_Text_N_TICKET != null)
			{
				((Control)_Text_N_TICKET).TextChanged -= eventHandler;
				((Control)_Text_N_TICKET).KeyDown -= val;
				((Control)_Text_N_TICKET).LostFocus -= eventHandler2;
				((Control)_Text_N_TICKET).GotFocus -= eventHandler3;
				((TextBoxBase)_Text_N_TICKET).Click -= eventHandler4;
				((Control)_Text_N_TICKET).TextChanged -= eventHandler5;
			}
			_Text_N_TICKET = value;
			if (_Text_N_TICKET != null)
			{
				((Control)_Text_N_TICKET).TextChanged += eventHandler;
				((Control)_Text_N_TICKET).KeyDown += val;
				((Control)_Text_N_TICKET).LostFocus += eventHandler2;
				((Control)_Text_N_TICKET).GotFocus += eventHandler3;
				((TextBoxBase)_Text_N_TICKET).Click += eventHandler4;
				((Control)_Text_N_TICKET).TextChanged += eventHandler5;
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker1 = value;
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

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual Button Button_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FIND_Click;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click -= eventHandler;
			}
			_Button_FIND = value;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click += eventHandler;
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

	internal virtual CheckBox CheckBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox7_CheckedChanged;
			if (_CheckBox7 != null)
			{
				_CheckBox7.CheckedChanged -= eventHandler;
			}
			_CheckBox7 = value;
			if (_CheckBox7 != null)
			{
				_CheckBox7.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_TICKET = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton2_CheckedChanged;
			EventHandler eventHandler2 = RadioButton2_Click;
			if (_RadioButton2 != null)
			{
				_RadioButton2.CheckedChanged -= eventHandler;
				((Control)_RadioButton2).Click -= eventHandler2;
			}
			_RadioButton2 = value;
			if (_RadioButton2 != null)
			{
				_RadioButton2.CheckedChanged += eventHandler;
				((Control)_RadioButton2).Click += eventHandler2;
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton1_Click;
			EventHandler eventHandler2 = RadioButton1_CheckedChanged;
			if (_RadioButton1 != null)
			{
				((Control)_RadioButton1).Click -= eventHandler;
				_RadioButton1.CheckedChanged -= eventHandler2;
			}
			_RadioButton1 = value;
			if (_RadioButton1 != null)
			{
				((Control)_RadioButton1).Click += eventHandler;
				_RadioButton1.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel_CODE_BARRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CODE_BARRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CODE_BARRE = value;
		}
	}

	internal virtual Button Button_findd
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_findd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_findd_Click;
			if (_Button_findd != null)
			{
				((Control)_Button_findd).Click -= eventHandler;
			}
			_Button_findd = value;
			if (_Button_findd != null)
			{
				((Control)_Button_findd).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_CODE_BARRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_BARRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyEventHandler val = Text_CODE_BARRE_KeyDown;
			EventHandler eventHandler = Text_CODE_BARRE_LostFocus;
			EventHandler eventHandler2 = Text_CODE_BARRE_GotFocus;
			EventHandler eventHandler3 = Text_CODE_BARRE_Click;
			EventHandler eventHandler4 = Text_CODE_BARRE_TextChanged;
			if (_Text_CODE_BARRE != null)
			{
				((Control)_Text_CODE_BARRE).KeyDown -= val;
				((Control)_Text_CODE_BARRE).LostFocus -= eventHandler;
				((Control)_Text_CODE_BARRE).GotFocus -= eventHandler2;
				((TextBoxBase)_Text_CODE_BARRE).Click -= eventHandler3;
				((Control)_Text_CODE_BARRE).TextChanged -= eventHandler4;
			}
			_Text_CODE_BARRE = value;
			if (_Text_CODE_BARRE != null)
			{
				((Control)_Text_CODE_BARRE).KeyDown += val;
				((Control)_Text_CODE_BARRE).LostFocus += eventHandler;
				((Control)_Text_CODE_BARRE).GotFocus += eventHandler2;
				((TextBoxBase)_Text_CODE_BARRE).Click += eventHandler3;
				((Control)_Text_CODE_BARRE).TextChanged += eventHandler4;
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

	internal virtual Button_CLAVIER_NOSELECT Button_NUMERIQUE
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
			DataGridViewCellEventHandler val = DataGridView1_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewCheckBoxColumn CHECK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CHECK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CHECK = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_ARTICLE = value;
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

	internal virtual DataGridViewTextBoxColumn Famille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Famille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Famille = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_A = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_MP
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_MP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_MP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V = value;
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

	internal virtual DataGridViewTextBoxColumn REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_REMISE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Total_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Total_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Total_NET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAUX_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAUX_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAUX_TVA = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRINTER = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRINTER_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRINTER_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRINTER_DUPLICATA = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn GROUPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _GROUPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GROUPE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VENDEUR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CLIENT = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_RETOUR()
	{
		((Form)this).Shown += FormDialog_RETOUR_Shown;
		((Form)this).Load += FormDialog_RETOUR_Load;
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
		//IL_0018: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
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
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected Obj, but got Unknown
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected Obj, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected Obj, but got Unknown
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Obj, but got Unknown
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected Obj, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Expected Obj, but got Unknown
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Expected Obj, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected Obj, but got Unknown
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected Obj, but got Unknown
		//IL_127c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected Obj, but got Unknown
		//IL_1378: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Expected Obj, but got Unknown
		//IL_1484: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Expected Obj, but got Unknown
		//IL_1591: Unknown result type (might be due to invalid IL or missing references)
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Expected Obj, but got Unknown
		//IL_1741: Unknown result type (might be due to invalid IL or missing references)
		//IL_174b: Expected Obj, but got Unknown
		//IL_181e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Expected Obj, but got Unknown
		//IL_184c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1856: Expected Obj, but got Unknown
		//IL_188a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1890: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1948: Expected Obj, but got Unknown
		//IL_196c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1976: Expected Obj, but got Unknown
		//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a60: Expected Obj, but got Unknown
		//IL_1c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c29: Expected Obj, but got Unknown
		//IL_1c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c46: Expected Obj, but got Unknown
		//IL_1cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfb: Expected Obj, but got Unknown
		//IL_1db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dba: Expected Obj, but got Unknown
		//IL_1e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3c: Expected Obj, but got Unknown
		//IL_1e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ede: Expected Obj, but got Unknown
		//IL_1f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f99: Expected Obj, but got Unknown
		//IL_2128: Unknown result type (might be due to invalid IL or missing references)
		//IL_2132: Expected Obj, but got Unknown
		//IL_21aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b4: Expected Obj, but got Unknown
		//IL_21db: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_224c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2256: Expected Obj, but got Unknown
		//IL_23d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23db: Expected Obj, but got Unknown
		//IL_2484: Unknown result type (might be due to invalid IL or missing references)
		//IL_248e: Expected Obj, but got Unknown
		//IL_24ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c4: Expected Obj, but got Unknown
		//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d9: Expected Obj, but got Unknown
		//IL_2fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc1: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_RETOUR));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		Button3 = new Button();
		Panel_RETOUR_AUTO = new Panel();
		Panel_CLAVIER = new Panel();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
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
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		CheckBox7 = new CheckBox();
		Panel_TICKET = new Panel();
		Button_NUMERIQUE = new Button_CLAVIER_NOSELECT();
		DateTimePicker1 = new DateTimePicker();
		Button_FIND = new Button();
		Text_N_TICKET = new TextBox();
		Label2 = new Label();
		Label25 = new Label();
		Panel_CODE_BARRE = new Panel();
		Button_findd = new Button();
		Text_CODE_BARRE = new TextBox();
		Label4 = new Label();
		Panel1 = new Panel();
		Label1 = new Label();
		Button1 = new Button();
		DataGridView1 = new DataGridView();
		CHECK = new DataGridViewCheckBoxColumn();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		PRIX_A = new DataGridViewTextBoxColumn();
		PRIX_MP = new DataGridViewTextBoxColumn();
		PRIX_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		REMISE = new DataGridViewTextBoxColumn();
		Total_NET = new DataGridViewTextBoxColumn();
		TAUX_TVA = new DataGridViewTextBoxColumn();
		PRINTER = new DataGridViewTextBoxColumn();
		PRINTER_DUPLICATA = new DataGridViewTextBoxColumn();
		GROUPE = new DataGridViewTextBoxColumn();
		VENDEUR = new DataGridViewTextBoxColumn();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CODE_CLIENT = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		((Control)Panel_RETOUR_AUTO).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel_TICKET).SuspendLayout();
		((Control)Panel_CODE_BARRE).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Button3).Cursor = Cursors.Hand;
		((Control)Button3).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button3).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button = Button3;
		Point location = new Point(13, 9);
		((Control)button).Location = location;
		Button button2 = Button3;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button3 = Button3;
		Size size = new Size(467, 111);
		((Control)button3).Size = size;
		((Control)Button3).TabIndex = 714;
		((ButtonBase)Button3).Text = "RETOUR MANUEL";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)Panel_RETOUR_AUTO).BackColor = Color.FromArgb(249, 249, 249);
		Panel_RETOUR_AUTO.BorderStyle = (BorderStyle)1;
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)RadioButton2);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)RadioButton1);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)CheckBox7);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)Panel_TICKET);
		((Control)Panel_RETOUR_AUTO).Controls.Add((Control)(object)Panel_CODE_BARRE);
		Panel panel_RETOUR_AUTO = Panel_RETOUR_AUTO;
		location = new Point(9, 12);
		((Control)panel_RETOUR_AUTO).Location = location;
		((Control)Panel_RETOUR_AUTO).Name = "Panel_RETOUR_AUTO";
		Panel panel_RETOUR_AUTO2 = Panel_RETOUR_AUTO;
		size = new Size(494, 473);
		((Control)panel_RETOUR_AUTO2).Size = size;
		((Control)Panel_RETOUR_AUTO).TabIndex = 768;
		((Control)Panel_RETOUR_AUTO).Visible = false;
		((Control)Panel_CLAVIER).BackColor = Color.Transparent;
		Panel_CLAVIER.BorderStyle = (BorderStyle)1;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
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
		location = new Point(440, 172);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(312, 254);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1042;
		((Control)Panel_CLAVIER).Visible = false;
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT1;
		location = new Point(228, 121);
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
		((ButtonBase)Butt_).BackColor = Color.White;
		((Control)Butt_).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_).Cursor = Cursors.Hand;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_).FlatStyle = (FlatStyle)0;
		((Control)Butt_).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_ = Butt_;
		location = new Point(159, 180);
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
		location = new Point(90, 180);
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
		location = new Point(21, 121);
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
		location = new Point(90, 121);
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
		location = new Point(21, 62);
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
		location = new Point(159, 121);
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
		location = new Point(90, 62);
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
		location = new Point(21, 3);
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
		location = new Point(90, 3);
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
		location = new Point(228, 3);
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
		location = new Point(159, 62);
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
		location = new Point(159, 3);
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
		location = new Point(21, 180);
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
		RadioButton2.Appearance = (Appearance)1;
		((Control)RadioButton2).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton2).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton2).FlatStyle = (FlatStyle)0;
		((Control)RadioButton2).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		RadioButton radioButton = RadioButton2;
		location = new Point(293, 9);
		((Control)radioButton).Location = location;
		((Control)RadioButton2).Name = "RadioButton2";
		RadioButton radioButton2 = RadioButton2;
		size = new Size(128, 44);
		((Control)radioButton2).Size = size;
		((Control)RadioButton2).TabIndex = 1039;
		RadioButton2.TabStop = true;
		((ButtonBase)RadioButton2).Text = "Code Barre";
		RadioButton2.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton2).UseVisualStyleBackColor = true;
		RadioButton1.Appearance = (Appearance)1;
		((Control)RadioButton1).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton1).FlatAppearance.CheckedBackColor = Color.Yellow;
		((ButtonBase)RadioButton1).FlatStyle = (FlatStyle)0;
		((Control)RadioButton1).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		RadioButton radioButton3 = RadioButton1;
		location = new Point(71, 9);
		((Control)radioButton3).Location = location;
		((Control)RadioButton1).Name = "RadioButton1";
		RadioButton radioButton4 = RadioButton1;
		size = new Size(128, 44);
		((Control)radioButton4).Size = size;
		((Control)RadioButton1).TabIndex = 1038;
		RadioButton1.TabStop = true;
		((ButtonBase)RadioButton1).Text = "N° Ticket";
		RadioButton1.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton1).UseVisualStyleBackColor = true;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(8, 426);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 37);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 1036;
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
		location = new Point(333, 426);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(156, 37);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1035;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((ButtonBase)CheckBox7).AutoSize = true;
		((ButtonBase)CheckBox7).BackColor = Color.FromArgb(249, 249, 249);
		((Control)CheckBox7).Font = new Font("Tahoma", 8f);
		((Control)CheckBox7).ForeColor = Color.Black;
		CheckBox checkBox = CheckBox7;
		location = new Point(8, 172);
		((Control)checkBox).Location = location;
		((Control)CheckBox7).Name = "CheckBox7";
		CheckBox checkBox2 = CheckBox7;
		size = new Size(108, 19);
		((Control)checkBox2).Size = size;
		((Control)CheckBox7).TabIndex = 1034;
		((ButtonBase)CheckBox7).Text = "Sélectionner Tout";
		((ButtonBase)CheckBox7).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox7).UseVisualStyleBackColor = false;
		Panel_TICKET.BorderStyle = (BorderStyle)1;
		((Control)Panel_TICKET).Controls.Add((Control)(object)Button_NUMERIQUE);
		((Control)Panel_TICKET).Controls.Add((Control)(object)DateTimePicker1);
		((Control)Panel_TICKET).Controls.Add((Control)(object)Button_FIND);
		((Control)Panel_TICKET).Controls.Add((Control)(object)Text_N_TICKET);
		((Control)Panel_TICKET).Controls.Add((Control)(object)Label2);
		((Control)Panel_TICKET).Controls.Add((Control)(object)Label25);
		Panel panel_TICKET = Panel_TICKET;
		location = new Point(8, 74);
		((Control)panel_TICKET).Location = location;
		((Control)Panel_TICKET).Name = "Panel_TICKET";
		Panel panel_TICKET2 = Panel_TICKET;
		size = new Size(481, 92);
		((Control)panel_TICKET2).Size = size;
		((Control)Panel_TICKET).TabIndex = 1037;
		((Control)Panel_TICKET).Visible = false;
		((Control)Button_NUMERIQUE).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_NUMERIQUE).Cursor = Cursors.Hand;
		((Control)Button_NUMERIQUE).Font = new Font("Tahoma", 2f);
		((ButtonBase)Button_NUMERIQUE).Image = (Image)componentResourceManager.GetObject("Button_NUMERIQUE.Image");
		Button_CLAVIER_NOSELECT button_NUMERIQUE = Button_NUMERIQUE;
		location = new Point(431, 48);
		((Control)button_NUMERIQUE).Location = location;
		((Control)Button_NUMERIQUE).Name = "Button_NUMERIQUE";
		Button_CLAVIER_NOSELECT button_NUMERIQUE2 = Button_NUMERIQUE;
		size = new Size(40, 38);
		((Control)button_NUMERIQUE2).Size = size;
		((Control)Button_NUMERIQUE).TabIndex = 1040;
		((ButtonBase)Button_NUMERIQUE).Text = "5";
		((ButtonBase)Button_NUMERIQUE).TextAlign = (ContentAlignment)512;
		((ButtonBase)Button_NUMERIQUE).UseVisualStyleBackColor = true;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(175, 12);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(239, 26);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker1).TabIndex = 1030;
		((Control)Button_FIND).Anchor = (AnchorStyles)9;
		((ButtonBase)Button_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_FIND).Cursor = Cursors.Hand;
		((ButtonBase)Button_FIND).Image = (Image)componentResourceManager.GetObject("Button_FIND.Image");
		Button button_FIND = Button_FIND;
		location = new Point(377, 50);
		((Control)button_FIND).Location = location;
		((Control)Button_FIND).Name = "Button_FIND";
		Button button_FIND2 = Button_FIND;
		size = new Size(37, 29);
		((Control)button_FIND2).Size = size;
		((Control)Button_FIND).TabIndex = 686;
		((ButtonBase)Button_FIND).UseVisualStyleBackColor = false;
		((Control)Text_N_TICKET).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_N_TICKET = Text_N_TICKET;
		location = new Point(175, 51);
		((Control)text_N_TICKET).Location = location;
		TextBox text_N_TICKET2 = Text_N_TICKET;
		margin = new Padding(0);
		((Control)text_N_TICKET2).Margin = margin;
		((Control)Text_N_TICKET).Name = "Text_N_TICKET";
		TextBox text_N_TICKET3 = Text_N_TICKET;
		size = new Size(239, 26);
		((Control)text_N_TICKET3).Size = size;
		((Control)Text_N_TICKET).TabIndex = 988;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label2;
		location = new Point(64, 12);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(105, 26);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1033;
		Label2.Text = "DATE";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label25).BackColor = Color.White;
		((Control)Label25).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label25).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label25;
		location = new Point(64, 50);
		((Control)label3).Location = location;
		((Control)Label25).Name = "Label25";
		Label label4 = Label25;
		size = new Size(105, 26);
		((Control)label4).Size = size;
		((Control)Label25).TabIndex = 1032;
		Label25.Text = "N° TICKET";
		Label25.TextAlign = (ContentAlignment)16;
		Panel_CODE_BARRE.BorderStyle = (BorderStyle)1;
		((Control)Panel_CODE_BARRE).Controls.Add((Control)(object)Button_findd);
		((Control)Panel_CODE_BARRE).Controls.Add((Control)(object)Text_CODE_BARRE);
		((Control)Panel_CODE_BARRE).Controls.Add((Control)(object)Label4);
		Panel panel_CODE_BARRE = Panel_CODE_BARRE;
		location = new Point(8, 74);
		((Control)panel_CODE_BARRE).Location = location;
		((Control)Panel_CODE_BARRE).Name = "Panel_CODE_BARRE";
		Panel panel_CODE_BARRE2 = Panel_CODE_BARRE;
		size = new Size(481, 92);
		((Control)panel_CODE_BARRE2).Size = size;
		((Control)Panel_CODE_BARRE).TabIndex = 1040;
		((Control)Panel_CODE_BARRE).Visible = false;
		((Control)Button_findd).Anchor = (AnchorStyles)9;
		((ButtonBase)Button_findd).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_findd).Cursor = Cursors.Hand;
		((ButtonBase)Button_findd).Image = (Image)componentResourceManager.GetObject("Button_findd.Image");
		Button button_findd = Button_findd;
		location = new Point(377, 31);
		((Control)button_findd).Location = location;
		((Control)Button_findd).Name = "Button_findd";
		Button button_findd2 = Button_findd;
		size = new Size(37, 29);
		((Control)button_findd2).Size = size;
		((Control)Button_findd).TabIndex = 686;
		((ButtonBase)Button_findd).UseVisualStyleBackColor = false;
		((Control)Text_CODE_BARRE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_BARRE = Text_CODE_BARRE;
		location = new Point(175, 33);
		((Control)text_CODE_BARRE).Location = location;
		TextBox text_CODE_BARRE2 = Text_CODE_BARRE;
		margin = new Padding(0);
		((Control)text_CODE_BARRE2).Margin = margin;
		((Control)Text_CODE_BARRE).Name = "Text_CODE_BARRE";
		TextBox text_CODE_BARRE3 = Text_CODE_BARRE;
		size = new Size(239, 26);
		((Control)text_CODE_BARRE3).Size = size;
		((Control)Text_CODE_BARRE).TabIndex = 988;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.FromArgb(64, 64, 64);
		Label label5 = Label4;
		location = new Point(64, 32);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(105, 26);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 1032;
		Label4.Text = "CODE BARRE";
		Label4.TextAlign = (ContentAlignment)16;
		((Control)Panel1).BackColor = Color.FromArgb(220, 232, 250);
		Panel1.BorderStyle = (BorderStyle)1;
		((Control)Panel1).Controls.Add((Control)(object)Label1);
		((Control)Panel1).Controls.Add((Control)(object)Button1);
		((Control)Panel1).Controls.Add((Control)(object)Button3);
		Panel panel = Panel1;
		location = new Point(9, 12);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(494, 473);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 769;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Tahoma", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.FromArgb(2, 45, 162);
		Label label7 = Label1;
		location = new Point(225, 226);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(43, 29);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 716;
		Label1.Text = "Ou";
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button4 = Button1;
		location = new Point(13, 352);
		((Control)button4).Location = location;
		Button button5 = Button1;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(467, 111);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 715;
		((ButtonBase)Button1).Text = "RETOUR AUTOMATIQUE";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView1.ColumnHeadersHeight = 16;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[19]
		{
			(DataGridViewColumn)CHECK,
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Famille,
			(DataGridViewColumn)PRIX_A,
			(DataGridViewColumn)PRIX_MP,
			(DataGridViewColumn)PRIX_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)REMISE,
			(DataGridViewColumn)Total_NET,
			(DataGridViewColumn)TAUX_TVA,
			(DataGridViewColumn)PRINTER,
			(DataGridViewColumn)PRINTER_DUPLICATA,
			(DataGridViewColumn)GROUPE,
			(DataGridViewColumn)VENDEUR,
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CODE_CLIENT,
			(DataGridViewColumn)CLIENT
		});
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Window;
		val.Font = new Font("Lucida Console", 8f);
		val.ForeColor = SystemColors.ControlText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		location = new Point(8, 197);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(481, 226);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1043;
		((DataGridViewColumn)CHECK).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CHECK).HeaderText = "CHECK";
		((DataGridViewColumn)CHECK).Name = "CHECK";
		((DataGridViewColumn)CHECK).Width = 50;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).MinimumWidth = 2;
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Visible = false;
		((DataGridViewColumn)ID_ARTICLE).Width = 2;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).FillWeight = 11.42857f;
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).MinimumWidth = 2;
		((DataGridViewColumn)Code).Name = "Code";
		Code.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Code).Visible = false;
		((DataGridViewColumn)Code).Width = 2;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).FillWeight = 188.5714f;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Article).Resizable = (DataGridViewTriState)1;
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Famille).DataPropertyName = "Famille";
		((DataGridViewColumn)Famille).HeaderText = "Famille";
		((DataGridViewColumn)Famille).MinimumWidth = 2;
		((DataGridViewColumn)Famille).Name = "Famille";
		Famille.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Famille).Visible = false;
		((DataGridViewColumn)Famille).Width = 2;
		((DataGridViewColumn)PRIX_A).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_A).DataPropertyName = "PRIX_A";
		((DataGridViewColumn)PRIX_A).HeaderText = "PRIX_A";
		((DataGridViewColumn)PRIX_A).MinimumWidth = 2;
		((DataGridViewColumn)PRIX_A).Name = "PRIX_A";
		PRIX_A.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)PRIX_A).Visible = false;
		((DataGridViewColumn)PRIX_A).Width = 2;
		((DataGridViewColumn)PRIX_MP).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_MP).DataPropertyName = "PRIX_MP";
		((DataGridViewColumn)PRIX_MP).HeaderText = "PRIX_MP";
		((DataGridViewColumn)PRIX_MP).MinimumWidth = 2;
		((DataGridViewColumn)PRIX_MP).Name = "PRIX_MP";
		PRIX_MP.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)PRIX_MP).Visible = false;
		((DataGridViewColumn)PRIX_MP).Width = 2;
		((DataGridViewColumn)PRIX_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V).DataPropertyName = "PRIX_V";
		val2.Format = "N2";
		val2.NullValue = null;
		((DataGridViewColumn)PRIX_V).DefaultCellStyle = val2;
		((DataGridViewColumn)PRIX_V).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V).Name = "PRIX_V";
		PRIX_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V).Width = 50;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)Qté).DefaultCellStyle = val3;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).Width = 42;
		((DataGridViewColumn)REMISE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)REMISE).DataPropertyName = "REMISE";
		((DataGridViewColumn)REMISE).HeaderText = "REMISE";
		((DataGridViewColumn)REMISE).MinimumWidth = 2;
		((DataGridViewColumn)REMISE).Name = "REMISE";
		((DataGridViewColumn)REMISE).Visible = false;
		((DataGridViewColumn)REMISE).Width = 2;
		((DataGridViewColumn)Total_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Total_NET).DataPropertyName = "Total_NET";
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)Total_NET).DefaultCellStyle = val4;
		((DataGridViewColumn)Total_NET).HeaderText = "Total_NET";
		((DataGridViewColumn)Total_NET).Name = "Total_NET";
		Total_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Total_NET).Width = 70;
		((DataGridViewColumn)TAUX_TVA).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TAUX_TVA).DataPropertyName = "TAUX_TVA";
		((DataGridViewColumn)TAUX_TVA).HeaderText = "TAUX_TVA";
		((DataGridViewColumn)TAUX_TVA).MinimumWidth = 2;
		((DataGridViewColumn)TAUX_TVA).Name = "TAUX_TVA";
		TAUX_TVA.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TAUX_TVA).Visible = false;
		((DataGridViewColumn)TAUX_TVA).Width = 2;
		((DataGridViewColumn)PRINTER).DataPropertyName = "PRINTER";
		((DataGridViewColumn)PRINTER).HeaderText = "PRINTER";
		((DataGridViewColumn)PRINTER).Name = "PRINTER";
		((DataGridViewColumn)PRINTER).Visible = false;
		((DataGridViewColumn)PRINTER_DUPLICATA).DataPropertyName = "PRINTER_DUPLICATA";
		((DataGridViewColumn)PRINTER_DUPLICATA).HeaderText = "PRINTER_DUPLICATA";
		((DataGridViewColumn)PRINTER_DUPLICATA).Name = "PRINTER_DUPLICATA";
		((DataGridViewColumn)PRINTER_DUPLICATA).Visible = false;
		((DataGridViewColumn)GROUPE).DataPropertyName = "GROUPE";
		((DataGridViewColumn)GROUPE).HeaderText = "GROUPE";
		((DataGridViewColumn)GROUPE).Name = "GROUPE";
		((DataGridViewColumn)GROUPE).Visible = false;
		((DataGridViewColumn)VENDEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)VENDEUR).DataPropertyName = "VENDEUR";
		((DataGridViewColumn)VENDEUR).HeaderText = "VENDEUR";
		((DataGridViewColumn)VENDEUR).MinimumWidth = 2;
		((DataGridViewColumn)VENDEUR).Name = "VENDEUR";
		((DataGridViewColumn)VENDEUR).Visible = false;
		((DataGridViewColumn)VENDEUR).Width = 2;
		((DataGridViewColumn)ID_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_CLIENT).DataPropertyName = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).MinimumWidth = 2;
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Visible = false;
		((DataGridViewColumn)ID_CLIENT).Width = 2;
		((DataGridViewColumn)CODE_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_CLIENT).DataPropertyName = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).HeaderText = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).MinimumWidth = 2;
		((DataGridViewColumn)CODE_CLIENT).Name = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).Visible = false;
		((DataGridViewColumn)CODE_CLIENT).Width = 2;
		((DataGridViewColumn)CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).MinimumWidth = 2;
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)CLIENT).Visible = false;
		((DataGridViewColumn)CLIENT).Width = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(514, 497);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Panel_RETOUR_AUTO);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_RETOUR";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = " ";
		((Form)this).TopMost = true;
		((Control)Panel_RETOUR_AUTO).ResumeLayout(false);
		((Control)Panel_RETOUR_AUTO).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel_TICKET).ResumeLayout(false);
		((Control)Panel_TICKET).PerformLayout();
		((Control)Panel_CODE_BARRE).ResumeLayout(false);
		((Control)Panel_CODE_BARRE).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Text_N_TICKET_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_N_TICKET_Click(object sender, EventArgs e)
	{
		((TextBoxBase)Text_N_TICKET).HideSelection = false;
		((TextBoxBase)Text_N_TICKET).SelectAll();
		NewLateBinding.LateCall(sender, null, "focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void Text_N_TICKET_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_N_TICKET).BackColor = Color.Yellow;
	}

	private void Text_N_TICKET_LostFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_N_TICKET).BackColor = Color.White;
		((TextBoxBase)Text_N_TICKET).HideSelection = false;
		((TextBoxBase)Text_N_TICKET).SelectAll();
	}

	private void Text_N_TICKET_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Button_FIND_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				((TextBoxBase)Text_N_TICKET).HideSelection = false;
				((TextBoxBase)Text_N_TICKET).SelectAll();
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

	private void Text_CODE_BARRE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_CODE_BARRE_Click(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE_BARRE).HideSelection = false;
		((TextBoxBase)Text_CODE_BARRE).SelectAll();
		NewLateBinding.LateCall(sender, null, "focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void Text_CODE_BARRE_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE_BARRE).BackColor = Color.Yellow;
	}

	private void Text_CODE_BARRE_LostFocus(object sender, EventArgs e)
	{
		((TextBoxBase)Text_CODE_BARRE).BackColor = Color.White;
		((TextBoxBase)Text_CODE_BARRE).HideSelection = false;
		((TextBoxBase)Text_CODE_BARRE).SelectAll();
	}

	private void Text_CODE_BARRE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Button_findd_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				((TextBoxBase)Text_CODE_BARRE).HideSelection = false;
				((TextBoxBase)Text_CODE_BARRE).SelectAll();
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

	private void Button_NUMERIQUE_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = true;
			((Control)Panel_CLAVIER).BringToFront();
			((Control)Panel_CLAVIER).Top = 167;
			((Control)Panel_CLAVIER).Left = 161;
		}
		else
		{
			((Control)Panel_CLAVIER).Visible = false;
		}
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_N_TICKET.Text = Conversions.ToString(Operators.AddObject(Text_N_TICKET.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
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
				Text_N_TICKET.Text = Text_N_TICKET.Text.Remove(checked(Text_N_TICKET.Text.Length - 1));
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

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Panel_FIND_Click(object sender, EventArgs e)
	{
	}

	private void Panel_FIND_Paint(object sender, PaintEventArgs e)
	{
	}

	private void FormDialog_RETOUR_Shown(object sender, EventArgs e)
	{
		((Control)Panel_RETOUR_AUTO).Visible = false;
	}

	private void FormDialog_RETOUR_Load(object sender, EventArgs e)
	{
		Text_N_TICKET.Text = "";
		((Control)Text_N_TICKET).Focus();
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
		DataGridView1.RowTemplate.Height = 35;
		DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
		checked
		{
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
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)Panel_RETOUR_AUTO).Visible = true;
		((Control)Panel_RETOUR_AUTO).BringToFront();
		Text_N_TICKET.Text = "";
		((Control)Text_N_TICKET).Focus();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_3_VENTE.Panel_FONCTIONS).Hide();
		((Form)this).Close();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.ColumnIndex == 0) | (e.ColumnIndex == 1) | (e.ColumnIndex == 2) | (e.ColumnIndex == 3) | (e.ColumnIndex == 4))
		{
			if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value, false, TextCompare: false))
			{
				DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value = true;
				DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].DefaultCellStyle.BackColor = Color.Red;
			}
			else
			{
				DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value = false;
				DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].DefaultCellStyle.BackColor = Color.White;
			}
		}
		SendKeys.Send("{RIGHT}{LEFT}");
		((Control)Text_N_TICKET).Focus();
	}

	private void Button_FIND_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select * from TABLE_VENTES_JOURNAL WHERE    TICKET   =  '" + Text_N_TICKET.Text + "'    AND        (  OPERATION = 'VENTE'   OR      OPERATION = 'CREDIT')          AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView1.DataSource = dataTable;
			((Control)Text_N_TICKET).Focus();
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

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_3_VENTE.Panel_FONCTIONS).Hide();
		((Form)this).Close();
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		checked
		{
			try
			{
				bool flag = false;
				int num = DataGridView1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num2].Cells[0].Value, true, TextCompare: false))
					{
						flag = true;
						break;
					}
					num2++;
				}
				if (!flag)
				{
					MessageBox.Show("Veuillez sélectionner des articles ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				int num6 = 0;
				int num8 = default;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num6].Cells[0].Value, true, TextCompare: false))
					{
						if (Module1.dt1.Rows.Count > 0)
						{
							num8 = Conversions.ToInteger(Operators.AddObject(Module1.dt1.Rows[Module1.dt1.Rows.Count - 1]["ID"], 1));
						}
						else if (Module1.dt1.Rows.Count == 0)
						{
							num8 = 1;
						}
						Module1.dt1.Rows.Add();
						int index = Module1.dt1.Rows.Count - 1;
						Module1.dt1.Rows[index]["ID"] = num8;
						Module1.dt1.Rows[index]["Dates"] = DateTime.Now.ToString("dd/MM/yyy");
						Module1.dt1.Rows[index]["Heure"] = DateTime.Now.ToString("HH:mm:ss");
						Module1.dt1.Rows[index]["ID_ARTICLE"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["ID_ARTICLE"].Value);
						Module1.dt1.Rows[index]["Code"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["Code"].Value);
						Module1.dt1.Rows[index]["Article"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["Article"].Value);
						Module1.dt1.Rows[index]["Famille"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["Famille"].Value);
						Module1.dt1.Rows[index]["PRIX_A"] = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PRIX_A"].Value));
						Module1.dt1.Rows[index]["PRIX_MP"] = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PRIX_MP"].Value));
						Module1.dt1.Rows[index]["Prix_V"] = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["Prix_V"].Value));
						Module1.dt1.Rows[index]["Qté"] = Operators.MultiplyObject(DataGridView1.Rows[num6].Cells["Qté"].Value, -1);
						Module1.dt1.Rows[index]["Remise"] = Operators.MultiplyObject(DataGridView1.Rows[num6].Cells["Remise"].Value, -1);
						Module1.dt1.Rows[index]["TOTAL_NET"] = Strings.FormatNumber(Conversions.ToDouble(DataGridView1.Rows[num6].Cells["TOTAL_NET"].Value) * -1.0);
						Module1.dt1.Rows[index]["TAUX_TVA"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["TAUX_TVA"].Value);
						Module1.dt1.Rows[index]["PRINTER"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PRINTER"].Value);
						Module1.dt1.Rows[index]["PRINTER_DUPLICATA"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["PRINTER_DUPLICATA"].Value);
						Module1.dt1.Rows[index]["GROUPE"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["GROUPE"].Value);
						Module1.dt1.Rows[index]["VENDEUR"] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells["VENDEUR"].Value);
						MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
					}
					num6++;
				}
				if (((Control)MyProject.Forms.Form_3_VENTE.Panel_RAPPEL).Visible)
				{
					((Control)MyProject.Forms.Form_3_VENTE.Panel_RAPPEL).Visible = false;
				}
				MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Form_3_VENTE.Text_CODE).Focus();
				((Control)MyProject.Forms.Form_3_VENTE.Panel_FONCTIONS).Hide();
				MyProject.Forms.Form_3_VENTE.Button_CLIENT._ID_Button = Conversions.ToString(DataGridView1.Rows[0].Cells["ID_CLIENT"].Value);
				MyProject.Forms.Form_3_VENTE.Button_CLIENT._CODE_Button = Conversions.ToString(DataGridView1.Rows[0].Cells["CODE_CLIENT"].Value);
				((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_CLIENT).Text = Conversions.ToString(DataGridView1.Rows[0].Cells["CLIENT"].Value);
				((Form)this).Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1.dt1.Clear();
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CheckBox7_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (CheckBox7.Checked)
			{
				int num = DataGridView1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						DataGridView1.Rows[num2].Cells[0].Value = true;
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (CheckBox7.Checked)
				{
					return;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						DataGridView1.Rows[num6].Cells[0].Value = false;
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
		((Control)Panel_TICKET).Visible = true;
		((Control)Panel_TICKET).BringToFront();
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton2_Click(object sender, EventArgs e)
	{
		((Control)Panel_CODE_BARRE).Visible = true;
		((Control)Panel_CODE_BARRE).BringToFront();
	}

	private void Button_findd_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select * from TABLE_VENTES_JOURNAL WHERE    ID_TICKET   =  '" + Text_CODE_BARRE.Text + "'    AND        (  OPERATION = 'VENTE'   OR      OPERATION = 'CREDIT')          AND       Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView1.DataSource = dataTable;
			((Control)Text_CODE_BARRE).Focus();
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
}
