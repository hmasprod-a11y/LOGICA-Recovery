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
using CustomControls.RJControls;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_5_CLIENTS_LISTE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel_HISTORIQUE")]
	private Panel _Panel_HISTORIQUE;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Panel_FICHE")]
	private Panel _Panel_FICHE;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Text_CODE_CLIENT")]
	private TextBox _Text_CODE_CLIENT;

	[AccessedThroughProperty("Text_ADRESSE")]
	private TextBox _Text_ADRESSE;

	[AccessedThroughProperty("Text_CLIENT")]
	private TextBox _Text_CLIENT;

	[AccessedThroughProperty("Text_TEL")]
	private TextBox _Text_TEL;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("Label_TOP3")]
	private Label _Label_TOP3;

	[AccessedThroughProperty("Label_TOP2")]
	private Label _Label_TOP2;

	[AccessedThroughProperty("Label_TOP1")]
	private Label _Label_TOP1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label_TOP4")]
	private Label _Label_TOP4;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Text_ID_CLIENT")]
	private TextBox _Text_ID_CLIENT;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CODE_CLIENT")]
	private DataGridViewTextBoxColumn _CODE_CLIENT;

	[AccessedThroughProperty("Client")]
	private DataGridViewTextBoxColumn _Client;

	[AccessedThroughProperty("TELEPHONE")]
	private DataGridViewTextBoxColumn _TELEPHONE;

	[AccessedThroughProperty("ADRESSE")]
	private DataGridViewTextBoxColumn _ADRESSE;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Button_CLAVIERR")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIERR;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private Button_RJ _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private Button_RJ _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private RJTextBox _Text_FIND;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	[AccessedThroughProperty("ID_TICKET")]
	private DataGridViewTextBoxColumn _ID_TICKET;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_V")]
	private DataGridViewTextBoxColumn _Prix_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	private DataTable _dt;

	private MySqlDataAdapter _da;

	private object _sql;

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
			EventHandler eventHandler = DataGridView1_DoubleClick;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
			}
		}
	}

	internal virtual Button Button15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button15_Click;
			if (_Button15 != null)
			{
				((Control)_Button15).Click -= eventHandler;
			}
			_Button15 = value;
			if (_Button15 != null)
			{
				((Control)_Button15).Click += eventHandler;
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

	internal virtual Label Label_TABLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TABLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TABLE = value;
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

	internal virtual Panel Panel_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_HISTORIQUE = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView2 = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).Click -= eventHandler;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).Click += eventHandler;
			}
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

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).Click -= eventHandler;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).Click += eventHandler;
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

	internal virtual TextBox Text_CODE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_CLIENT = value;
		}
	}

	internal virtual TextBox Text_ADRESSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ADRESSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ADRESSE = value;
		}
	}

	internal virtual TextBox Text_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CLIENT = value;
		}
	}

	internal virtual TextBox Text_TEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TEL = value;
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

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
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

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button7_Click;
			if (_Button7 != null)
			{
				((Control)_Button7).Click -= eventHandler;
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView3 = value;
		}
	}

	internal virtual Label Label_TOP3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP3 = value;
		}
	}

	internal virtual Label Label_TOP2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP2 = value;
		}
	}

	internal virtual Label Label_TOP1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP1 = value;
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

	internal virtual Label Label_TOP4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP4 = value;
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

	internal virtual TextBox Text_ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_CLIENT = value;
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

	internal virtual DataGridViewTextBoxColumn Client
	{
		[DebuggerNonUserCode]
		get
		{
			return _Client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Client = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TELEPHONE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TELEPHONE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TELEPHONE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ADRESSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ADRESSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ADRESSE = value;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIERR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIERR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIERR_Click;
			if (_Button_CLAVIERR != null)
			{
				((Control)_Button_CLAVIERR).Click -= eventHandler;
			}
			_Button_CLAVIERR = value;
			if (_Button_CLAVIERR != null)
			{
				((Control)_Button_CLAVIERR).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_FIND = value;
		}
	}

	internal virtual Button_RJ Picture_REFRESH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_REFRESH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_REFRESH_Click;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click -= eventHandler;
			}
			_Picture_REFRESH = value;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Picture_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_FIND_Click;
			if (_Picture_FIND != null)
			{
				((Control)_Picture_FIND).Click -= eventHandler;
			}
			_Picture_FIND = value;
			if (_Picture_FIND != null)
			{
				((Control)_Picture_FIND).Click += eventHandler;
			}
		}
	}

	protected virtual RJTextBox Text_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_FIND_TextChanged;
			if (_Text_FIND != null)
			{
				_Text_FIND._TextChanged -= eventHandler;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				_Text_FIND._TextChanged += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_TICKET = value;
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

	public Form_5_CLIENTS_LISTE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_LISTE_CLIENTS_Load;
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Shown += Form_5_CLIENTS_LISTE_Shown;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		__ENCAddToList(this);
		_dt = new DataTable();
		_da = new MySqlDataAdapter();
		_sql = "";
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
		//IL_0024: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
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
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected Obj, but got Unknown
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected Obj, but got Unknown
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected Obj, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected Obj, but got Unknown
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected Obj, but got Unknown
		//IL_133a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Expected Obj, but got Unknown
		//IL_13fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Expected Obj, but got Unknown
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c7: Expected Obj, but got Unknown
		//IL_1580: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Expected Obj, but got Unknown
		//IL_1637: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Expected Obj, but got Unknown
		//IL_1654: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected Obj, but got Unknown
		//IL_170a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1714: Expected Obj, but got Unknown
		//IL_1727: Unknown result type (might be due to invalid IL or missing references)
		//IL_1731: Expected Obj, but got Unknown
		//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e7: Expected Obj, but got Unknown
		//IL_17fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1804: Expected Obj, but got Unknown
		//IL_18fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1905: Expected Obj, but got Unknown
		//IL_19c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cb: Expected Obj, but got Unknown
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c50: Expected Obj, but got Unknown
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef4: Expected Obj, but got Unknown
		//IL_1fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Expected Obj, but got Unknown
		//IL_2030: Unknown result type (might be due to invalid IL or missing references)
		//IL_203a: Expected Obj, but got Unknown
		//IL_2111: Unknown result type (might be due to invalid IL or missing references)
		//IL_211b: Expected Obj, but got Unknown
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2149: Expected Obj, but got Unknown
		//IL_217d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2183: Unknown result type (might be due to invalid IL or missing references)
		//IL_2231: Unknown result type (might be due to invalid IL or missing references)
		//IL_223b: Expected Obj, but got Unknown
		//IL_225f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2269: Expected Obj, but got Unknown
		//IL_22a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_232e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2338: Expected Obj, but got Unknown
		//IL_23e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ea: Expected Obj, but got Unknown
		//IL_2492: Unknown result type (might be due to invalid IL or missing references)
		//IL_249c: Expected Obj, but got Unknown
		//IL_2544: Unknown result type (might be due to invalid IL or missing references)
		//IL_254e: Expected Obj, but got Unknown
		//IL_261f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2629: Expected Obj, but got Unknown
		//IL_26fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2706: Expected Obj, but got Unknown
		//IL_27a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b3: Expected Obj, but got Unknown
		//IL_283c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2846: Expected Obj, but got Unknown
		//IL_28cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d9: Expected Obj, but got Unknown
		//IL_2962: Unknown result type (might be due to invalid IL or missing references)
		//IL_296c: Expected Obj, but got Unknown
		//IL_2a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a96: Expected Obj, but got Unknown
		//IL_2ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc4: Expected Obj, but got Unknown
		//IL_2df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfa: Expected Obj, but got Unknown
		//IL_2ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee1: Expected Obj, but got Unknown
		//IL_2f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff3: Expected Obj, but got Unknown
		//IL_31ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d4: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS_LISTE));
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridView1 = new DataGridView();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CODE_CLIENT = new DataGridViewTextBoxColumn();
		Client = new DataGridViewTextBoxColumn();
		TELEPHONE = new DataGridViewTextBoxColumn();
		ADRESSE = new DataGridViewTextBoxColumn();
		Button15 = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TABLE = new Label();
		Button1 = new Button();
		Panel_HISTORIQUE = new Panel();
		Label6 = new Label();
		DataGridView3 = new DataGridView();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Button244 = new Button();
		Label_TOP4 = new Label();
		Label9 = new Label();
		Label_TOP3 = new Label();
		Label_TOP2 = new Label();
		Label_TOP1 = new Label();
		Button4 = new Button();
		Button3 = new Button();
		Button2 = new Button();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		ID_TICKET = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Prix_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		Button6 = new Button();
		Panel_FICHE = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Text_ID_CLIENT = new TextBox();
		Label11 = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Label10 = new Label();
		Label2 = new Label();
		Label24 = new Label();
		Label8 = new Label();
		Label_TOP = new Label();
		Text_ID = new TextBox();
		Text_CODE_CLIENT = new TextBox();
		Text_ADRESSE = new TextBox();
		Text_CLIENT = new TextBox();
		Text_TEL = new TextBox();
		Label1 = new Label();
		Button7 = new Button();
		Panel_FIND = new Panel();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Button_CLAVIERR = new Button_CLAVIER_NOSELECT();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_HISTORIQUE).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)Panel_FICHE).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)13;
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
		DataGridView1.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CODE_CLIENT,
			(DataGridViewColumn)Client,
			(DataGridViewColumn)TELEPHONE,
			(DataGridViewColumn)ADRESSE
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(3, 44);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(826, 506);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 4;
		((DataGridViewColumn)ID_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_CLIENT).DataPropertyName = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_CLIENT).DataPropertyName = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).HeaderText = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).MinimumWidth = 2;
		((DataGridViewColumn)CODE_CLIENT).Name = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).Width = 2;
		((DataGridViewColumn)Client).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Client).DataPropertyName = "CLIENT";
		((DataGridViewColumn)Client).FillWeight = 12.98701f;
		((DataGridViewColumn)Client).HeaderText = "CLIENT";
		((DataGridViewColumn)Client).Name = "Client";
		Client.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Client).Width = 200;
		((DataGridViewColumn)TELEPHONE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TELEPHONE).DataPropertyName = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).FillWeight = 187.013f;
		((DataGridViewColumn)TELEPHONE).HeaderText = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).Name = "TELEPHONE";
		TELEPHONE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TELEPHONE).Width = 120;
		((DataGridViewColumn)ADRESSE).DataPropertyName = "ADRESSE";
		((DataGridViewColumn)ADRESSE).HeaderText = "ADRESSE";
		((DataGridViewColumn)ADRESSE).Name = "ADRESSE";
		((ButtonBase)Button15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button15).Cursor = Cursors.Hand;
		((ButtonBase)Button15).FlatStyle = (FlatStyle)0;
		((Control)Button15).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button15).ForeColor = Color.White;
		Button button = Button15;
		location = new Point(671, 553);
		((Control)button).Location = location;
		Button button2 = Button15;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button15).Name = "Button15";
		Button button3 = Button15;
		size = new Size(155, 54);
		((Control)button3).Size = size;
		((Control)Button15).TabIndex = 1036;
		((ButtonBase)Button15).Text = "Valider Client";
		((ButtonBase)Button15).UseVisualStyleBackColor = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 666);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(825, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1040;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 44);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 626);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1039;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(829, 44);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 626);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1038;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Cursor = Cursors.Hand;
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(833, 44);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1037;
		Label_TABLE.Text = "CLIENTS";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button1).BackColor = Color.Red;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button1).ForeColor = Color.White;
		Button button4 = Button1;
		location = new Point(671, 607);
		((Control)button4).Location = location;
		Button button5 = Button1;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(155, 54);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 1042;
		((ButtonBase)Button1).Text = "Annuler Client";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((Control)Panel_HISTORIQUE).BackColor = Color.FromArgb(249, 249, 249);
		Panel_HISTORIQUE.BorderStyle = (BorderStyle)1;
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label6);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label5);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label4);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button244);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_TOP4);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label9);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_TOP3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_TOP2);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_TOP1);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button4);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button2);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)DataGridView2);
		Panel panel_HISTORIQUE = Panel_HISTORIQUE;
		location = new Point(3, 44);
		((Control)panel_HISTORIQUE).Location = location;
		((Control)Panel_HISTORIQUE).Name = "Panel_HISTORIQUE";
		Panel panel_HISTORIQUE2 = Panel_HISTORIQUE;
		size = new Size(826, 506);
		((Control)panel_HISTORIQUE2).Size = size;
		((Control)Panel_HISTORIQUE).TabIndex = 1043;
		((Control)Panel_HISTORIQUE).Visible = false;
		((Control)Label6).BackColor = Color.DarkMagenta;
		((Control)Label6).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.White;
		Label label = Label6;
		location = new Point(602, 251);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(23, 44);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 1001;
		Label6.Text = "4";
		Label6.TextAlign = (ContentAlignment)32;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView dataGridView3 = DataGridView3;
		location = new Point(654, 149);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView dataGridView4 = DataGridView3;
		size = new Size(145, 75);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView3).TabIndex = 706;
		((Control)DataGridView3).Visible = false;
		((Control)Label5).BackColor = Color.DarkMagenta;
		((Control)Label5).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.White;
		Label label3 = Label5;
		location = new Point(602, 206);
		((Control)label3).Location = location;
		((Control)Label5).Name = "Label5";
		Label label4 = Label5;
		size = new Size(23, 44);
		((Control)label4).Size = size;
		((Control)Label5).TabIndex = 1000;
		Label5.Text = "3";
		Label5.TextAlign = (ContentAlignment)32;
		((Control)Label4).BackColor = Color.DarkMagenta;
		((Control)Label4).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.White;
		Label label5 = Label4;
		location = new Point(602, 161);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(23, 44);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 999;
		Label4.Text = "2";
		Label4.TextAlign = (ContentAlignment)32;
		((Control)Label3).BackColor = Color.DarkMagenta;
		((Control)Label3).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.White;
		Label label7 = Label3;
		location = new Point(602, 116);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(23, 44);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 998;
		Label3.Text = "1";
		Label3.TextAlign = (ContentAlignment)32;
		((Control)Button244).Anchor = (AnchorStyles)9;
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((ButtonBase)Button244).FlatStyle = (FlatStyle)0;
		((Control)Button244).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button244).ForeColor = Color.White;
		((ButtonBase)Button244).Image = (Image)componentResourceManager.GetObject("Button244.Image");
		((ButtonBase)Button244).ImeMode = (ImeMode)0;
		Button button7 = Button244;
		location = new Point(767, 0);
		((Control)button7).Location = location;
		Button button8 = Button244;
		margin = new Padding(0);
		((Control)button8).Margin = margin;
		((Control)Button244).Name = "Button244";
		Button button9 = Button244;
		size = new Size(57, 29);
		((Control)button9).Size = size;
		((Control)Button244).TabIndex = 997;
		((ButtonBase)Button244).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		Label_TOP4.BorderStyle = (BorderStyle)2;
		Label_TOP4.FlatStyle = (FlatStyle)0;
		((Control)Label_TOP4).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		Label label_TOP = Label_TOP4;
		location = new Point(602, 251);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP4).Name = "Label_TOP4";
		Label label_TOP2 = Label_TOP4;
		size = new Size(217, 44);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP4).TabIndex = 995;
		Label_TOP4.Text = "-";
		Label_TOP4.TextAlign = (ContentAlignment)32;
		Label_TOP4.UseCompatibleTextRendering = true;
		((Control)Label9).BackColor = Color.DarkMagenta;
		((Control)Label9).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.White;
		Label label9 = Label9;
		location = new Point(602, 68);
		((Control)label9).Location = location;
		((Control)Label9).Name = "Label9";
		Label label10 = Label9;
		size = new Size(217, 44);
		((Control)label10).Size = size;
		((Control)Label9).TabIndex = 994;
		Label9.Text = "Top Articles";
		Label9.TextAlign = (ContentAlignment)32;
		Label_TOP3.BorderStyle = (BorderStyle)2;
		Label_TOP3.FlatStyle = (FlatStyle)0;
		((Control)Label_TOP3).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		Label label_TOP3 = Label_TOP3;
		location = new Point(602, 206);
		((Control)label_TOP3).Location = location;
		((Control)Label_TOP3).Name = "Label_TOP3";
		Label label_TOP4 = Label_TOP3;
		size = new Size(217, 44);
		((Control)label_TOP4).Size = size;
		((Control)Label_TOP3).TabIndex = 709;
		Label_TOP3.Text = "-";
		Label_TOP3.TextAlign = (ContentAlignment)32;
		Label_TOP3.UseCompatibleTextRendering = true;
		Label_TOP2.BorderStyle = (BorderStyle)2;
		Label_TOP2.FlatStyle = (FlatStyle)0;
		((Control)Label_TOP2).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		Label label_TOP5 = Label_TOP2;
		location = new Point(602, 161);
		((Control)label_TOP5).Location = location;
		((Control)Label_TOP2).Name = "Label_TOP2";
		Label label_TOP6 = Label_TOP2;
		size = new Size(217, 44);
		((Control)label_TOP6).Size = size;
		((Control)Label_TOP2).TabIndex = 708;
		Label_TOP2.Text = "-";
		Label_TOP2.TextAlign = (ContentAlignment)32;
		Label_TOP2.UseCompatibleTextRendering = true;
		Label_TOP1.BorderStyle = (BorderStyle)2;
		Label_TOP1.FlatStyle = (FlatStyle)0;
		((Control)Label_TOP1).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label_TOP7 = Label_TOP1;
		location = new Point(602, 116);
		((Control)label_TOP7).Location = location;
		((Control)Label_TOP1).Name = "Label_TOP1";
		Label label_TOP8 = Label_TOP1;
		size = new Size(217, 44);
		((Control)label_TOP8).Size = size;
		((Control)Label_TOP1).TabIndex = 707;
		Label_TOP1.Text = "-";
		Label_TOP1.TextAlign = (ContentAlignment)32;
		Label_TOP1.UseCompatibleTextRendering = true;
		((Control)Button4).Cursor = Cursors.Hand;
		((Control)Button4).Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button4).Image = (Image)componentResourceManager.GetObject("Button4.Image");
		((ButtonBase)Button4).ImageAlign = (ContentAlignment)16;
		Button button10 = Button4;
		location = new Point(404, 5);
		((Control)button10).Location = location;
		((Control)Button4).Name = "Button4";
		Button button11 = Button4;
		size = new Size(190, 57);
		((Control)button11).Size = size;
		((Control)Button4).TabIndex = 703;
		((ButtonBase)Button4).Text = "Cette\r\nAnnée";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Button3).Cursor = Cursors.Hand;
		((Control)Button3).Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button12 = Button3;
		location = new Point(206, 5);
		((Control)button12).Location = location;
		((Control)Button3).Name = "Button3";
		Button button13 = Button3;
		size = new Size(190, 57);
		((Control)button13).Size = size;
		((Control)Button3).TabIndex = 702;
		((ButtonBase)Button3).Text = "Ce\r\nMois";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button14 = Button2;
		location = new Point(8, 5);
		((Control)button14).Location = location;
		((Control)Button2).Name = "Button2";
		Button button15 = Button2;
		size = new Size(190, 57);
		((Control)button15).Size = size;
		((Control)Button2).TabIndex = 701;
		((ButtonBase)Button2).Text = "   Cette\r\n   Semaine";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToDeleteRows = false;
		DataGridView2.AllowUserToResizeColumns = false;
		DataGridView2.AllowUserToResizeRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Tahoma", 8f);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		DataGridView2.ColumnHeadersDefaultCellStyle = val3;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn5,
			(DataGridViewColumn)ID_TICKET,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_V,
			(DataGridViewColumn)Qté
		});
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.BackColor = SystemColors.Window;
		val4.Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.ControlText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val4;
		DataGridView2.EditMode = (DataGridViewEditMode)4;
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView5 = DataGridView2;
		location = new Point(8, 68);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersVisible = false;
		DataGridView2.RowHeadersWidth = 11;
		DataGridView dataGridView6 = DataGridView2;
		size = new Size(588, 424);
		((Control)dataGridView6).Size = size;
		((Control)DataGridView2).TabIndex = 704;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).DataPropertyName = "Dates";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Dates";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		DataGridViewTextBoxColumn5.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID_TICKET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_TICKET).DataPropertyName = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).HeaderText = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).MinimumWidth = 2;
		((DataGridViewColumn)ID_TICKET).Name = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).Width = 2;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Prix_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_V).DataPropertyName = "Prix_V";
		((DataGridViewColumn)Prix_V).HeaderText = "Prix_V";
		((DataGridViewColumn)Prix_V).Name = "Prix_V";
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		((DataGridViewColumn)Qté).Width = 50;
		((ButtonBase)Button6).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatStyle = (FlatStyle)0;
		((Control)Button6).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button6).ForeColor = Color.White;
		Button button16 = Button6;
		location = new Point(7, 553);
		((Control)button16).Location = location;
		Button button17 = Button6;
		margin = new Padding(0);
		((Control)button17).Margin = margin;
		((Control)Button6).Name = "Button6";
		Button button18 = Button6;
		size = new Size(155, 54);
		((Control)button18).Size = size;
		((Control)Button6).TabIndex = 1045;
		((ButtonBase)Button6).Text = "Nouveau";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		((Control)Panel_FICHE).BackColor = Color.White;
		Panel_FICHE.BorderStyle = (BorderStyle)1;
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ID_CLIENT);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label11);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label10);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label24);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label8);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ID);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_CODE_CLIENT);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ADRESSE);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_CLIENT);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_TEL);
		Panel panel_FICHE = Panel_FICHE;
		location = new Point(156, 234);
		((Control)panel_FICHE).Location = location;
		((Control)Panel_FICHE).Name = "Panel_FICHE";
		Panel panel_FICHE2 = Panel_FICHE;
		size = new Size(521, 202);
		((Control)panel_FICHE2).Size = size;
		((Control)Panel_FICHE).TabIndex = 1046;
		((Control)Panel_FICHE).Visible = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(241, 163);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 983;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_ID_CLIENT).BackColor = Color.White;
		((Control)Text_ID_CLIENT).Enabled = false;
		((Control)Text_ID_CLIENT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID_CLIENT = Text_ID_CLIENT;
		location = new Point(345, 29);
		((Control)text_ID_CLIENT).Location = location;
		((Control)Text_ID_CLIENT).Name = "Text_ID_CLIENT";
		TextBox text_ID_CLIENT2 = Text_ID_CLIENT;
		size = new Size(166, 29);
		((Control)text_ID_CLIENT2).Size = size;
		((Control)Text_ID_CLIENT).TabIndex = 981;
		((Control)Label11).BackColor = SystemColors.Control;
		((Control)Label11).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.Black;
		Label11.ImeMode = (ImeMode)0;
		Label label11 = Label11;
		location = new Point(259, 29);
		((Control)label11).Location = location;
		((Control)Label11).Name = "Label11";
		Label label12 = Label11;
		size = new Size(81, 26);
		((Control)label12).Size = size;
		((Control)Label11).TabIndex = 982;
		Label11.Text = "ID Client";
		Label11.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(3, 163);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 30);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 869;
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
		location = new Point(355, 163);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(156, 30);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 868;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label13 = Label10;
		location = new Point(8, 125);
		((Control)label13).Location = location;
		((Control)Label10).Name = "Label10";
		Label label14 = Label10;
		size = new Size(108, 26);
		((Control)label14).Size = size;
		((Control)Label10).TabIndex = 866;
		Label10.Text = "Adresse";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label15 = Label2;
		location = new Point(8, 93);
		((Control)label15).Location = location;
		((Control)Label2).Name = "Label2";
		Label label16 = Label2;
		size = new Size(108, 26);
		((Control)label16).Size = size;
		((Control)Label2).TabIndex = 867;
		Label2.Text = "Tel";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.Black;
		Label label17 = Label24;
		location = new Point(8, 29);
		((Control)label17).Location = location;
		((Control)Label24).Name = "Label24";
		Label label18 = Label24;
		size = new Size(108, 26);
		((Control)label18).Size = size;
		((Control)Label24).TabIndex = 864;
		Label24.Text = "Code Client";
		Label24.TextAlign = (ContentAlignment)16;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label19 = Label8;
		location = new Point(8, 61);
		((Control)label19).Location = location;
		((Control)Label8).Name = "Label8";
		Label label20 = Label8;
		size = new Size(108, 26);
		((Control)label20).Size = size;
		((Control)Label8).TabIndex = 865;
		Label8.Text = "Client";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP9 = Label_TOP;
		location = new Point(0, 0);
		((Control)label_TOP9).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP10 = Label_TOP;
		size = new Size(519, 24);
		((Control)label_TOP10).Size = size;
		((Control)Label_TOP).TabIndex = 863;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(175, 29);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(32, 29);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 700;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((TextBoxBase)Text_CODE_CLIENT).BackColor = Color.White;
		((TextBoxBase)Text_CODE_CLIENT).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_CLIENT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_CLIENT = Text_CODE_CLIENT;
		location = new Point(122, 29);
		((Control)text_CODE_CLIENT).Location = location;
		((Control)Text_CODE_CLIENT).Name = "Text_CODE_CLIENT";
		TextBox text_CODE_CLIENT2 = Text_CODE_CLIENT;
		size = new Size(131, 29);
		((Control)text_CODE_CLIENT2).Size = size;
		((Control)Text_CODE_CLIENT).TabIndex = 696;
		((TextBoxBase)Text_ADRESSE).BackColor = Color.White;
		((TextBoxBase)Text_ADRESSE).BorderStyle = (BorderStyle)1;
		((Control)Text_ADRESSE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ADRESSE = Text_ADRESSE;
		location = new Point(122, 125);
		((Control)text_ADRESSE).Location = location;
		((Control)Text_ADRESSE).Name = "Text_ADRESSE";
		TextBox text_ADRESSE2 = Text_ADRESSE;
		size = new Size(389, 29);
		((Control)text_ADRESSE2).Size = size;
		((Control)Text_ADRESSE).TabIndex = 694;
		((TextBoxBase)Text_CLIENT).BackColor = Color.White;
		((TextBoxBase)Text_CLIENT).BorderStyle = (BorderStyle)1;
		((Control)Text_CLIENT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CLIENT = Text_CLIENT;
		location = new Point(122, 61);
		((Control)text_CLIENT).Location = location;
		((Control)Text_CLIENT).Name = "Text_CLIENT";
		TextBox text_CLIENT2 = Text_CLIENT;
		size = new Size(389, 29);
		((Control)text_CLIENT2).Size = size;
		((Control)Text_CLIENT).TabIndex = 689;
		((TextBoxBase)Text_TEL).BackColor = Color.White;
		((TextBoxBase)Text_TEL).BorderStyle = (BorderStyle)1;
		((Control)Text_TEL).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TEL = Text_TEL;
		location = new Point(122, 93);
		((Control)text_TEL).Location = location;
		((Control)Text_TEL).Name = "Text_TEL";
		TextBox text_TEL2 = Text_TEL;
		size = new Size(389, 29);
		((Control)text_TEL2).Size = size;
		((Control)Text_TEL).TabIndex = 693;
		Label1.AutoSize = true;
		Label label21 = Label1;
		location = new Point(733, 9);
		((Control)label21).Location = location;
		((Control)Label1).Name = "Label1";
		Label label22 = Label1;
		size = new Size(38, 13);
		((Control)label22).Size = size;
		((Control)Label1).TabIndex = 1049;
		Label1.Text = "Label1";
		((Control)Label1).Visible = false;
		((ButtonBase)Button7).BackColor = Color.DarkMagenta;
		((Control)Button7).Cursor = Cursors.Hand;
		((ButtonBase)Button7).FlatStyle = (FlatStyle)0;
		((Control)Button7).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button7).ForeColor = Color.White;
		Button button19 = Button7;
		location = new Point(339, 553);
		((Control)button19).Location = location;
		Button button20 = Button7;
		margin = new Padding(0);
		((Control)button20).Margin = margin;
		((Control)Button7).Name = "Button7";
		Button button21 = Button7;
		size = new Size(155, 54);
		((Control)button21).Size = size;
		((Control)Button7).TabIndex = 1055;
		((ButtonBase)Button7).Text = "Historique";
		((ButtonBase)Button7).UseVisualStyleBackColor = false;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		Panel panel_FIND = Panel_FIND;
		location = new Point(77, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(534, 44);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1057;
		Picture_REFRESH._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_REFRESH._BorderColor = Color.White;
		Picture_REFRESH._BorderRadius = 16;
		Picture_REFRESH._BorderSize = 1;
		Picture_REFRESH._TextColor = Color.White;
		((ButtonBase)Picture_REFRESH).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_REFRESH).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_REFRESH).FlatStyle = (FlatStyle)0;
		((Control)Picture_REFRESH).ForeColor = Color.White;
		((ButtonBase)Picture_REFRESH).Image = (Image)componentResourceManager.GetObject("Picture_REFRESH.Image");
		((ButtonBase)Picture_REFRESH).ImeMode = (ImeMode)0;
		Button_RJ picture_REFRESH = Picture_REFRESH;
		location = new Point(342, 6);
		((Control)picture_REFRESH).Location = location;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		Button_RJ picture_REFRESH2 = Picture_REFRESH;
		size = new Size(33, 33);
		((Control)picture_REFRESH2).Size = size;
		((Control)Picture_REFRESH).TabIndex = 1048;
		((ButtonBase)Picture_REFRESH).UseVisualStyleBackColor = false;
		Picture_FIND._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_FIND._BorderColor = Color.White;
		Picture_FIND._BorderRadius = 16;
		Picture_FIND._BorderSize = 1;
		Picture_FIND._TextColor = Color.White;
		((ButtonBase)Picture_FIND).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_FIND).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_FIND).FlatStyle = (FlatStyle)0;
		((Control)Picture_FIND).ForeColor = Color.White;
		((ButtonBase)Picture_FIND).Image = (Image)componentResourceManager.GetObject("Picture_FIND.Image");
		((ButtonBase)Picture_FIND).ImeMode = (ImeMode)0;
		Button_RJ picture_FIND = Picture_FIND;
		location = new Point(305, 6);
		((Control)picture_FIND).Location = location;
		((Control)Picture_FIND).Name = "Picture_FIND";
		Button_RJ picture_FIND2 = Picture_FIND;
		size = new Size(33, 33);
		((Control)picture_FIND2).Size = size;
		((Control)Picture_FIND).TabIndex = 987;
		((ButtonBase)Picture_FIND).UseVisualStyleBackColor = false;
		Text_FIND.BackColor = Color.FromArgb(75, 141, 242);
		Text_FIND.BorderColor = Color.White;
		Text_FIND.BorderFocusColor = Color.White;
		Text_FIND.BorderRadius = 16;
		Text_FIND.BorderSize = 1;
		Text_FIND.Font = new Font("Comic Sans MS", 9.75f);
		Text_FIND.ForeColor = Color.White;
		RJTextBox text_FIND = Text_FIND;
		location = new Point(4, 6);
		((Control)text_FIND).Location = location;
		RJTextBox text_FIND2 = Text_FIND;
		margin = new Padding(4);
		((Control)text_FIND2).Margin = margin;
		Text_FIND.Multiline = false;
		((Control)Text_FIND).Name = "Text_FIND";
		RJTextBox text_FIND3 = Text_FIND;
		margin = new Padding(10, 7, 10, 7);
		((Control)text_FIND3).Padding = margin;
		Text_FIND.PasswordChar = false;
		Text_FIND.PlaceholderColor = Color.White;
		Text_FIND.PlaceholderText = "";
		RJTextBox text_FIND4 = Text_FIND;
		size = new Size(334, 33);
		((Control)text_FIND4).Size = size;
		((Control)Text_FIND).TabIndex = 986;
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		((Control)Button_CLAVIERR).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIERR.BackgroundImage");
		((Control)Button_CLAVIERR).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIERR).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIERR = Button_CLAVIERR;
		location = new Point(398, 630);
		((Control)button_CLAVIERR).Location = location;
		((Control)Button_CLAVIERR).Name = "Button_CLAVIERR";
		Button_CLAVIER_NOSELECT button_CLAVIERR2 = Button_CLAVIERR;
		size = new Size(36, 31);
		((Control)button_CLAVIERR2).Size = size;
		((Control)Button_CLAVIERR).TabIndex = 1056;
		((ButtonBase)Button_CLAVIERR).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(833, 670);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Button_CLAVIERR);
		((Control)this).Controls.Add((Control)(object)Button7);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Button6);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Button15);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Panel_FICHE);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Panel_HISTORIQUE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_5_CLIENTS_LISTE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_HISTORIQUE).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)Panel_FICHE).ResumeLayout(false);
		((Control)Panel_FICHE).PerformLayout();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Text_FIND_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
	}

	private void Text_FIND_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.White }, null, null);
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

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
	}

	private void FormDialog_LISTE_CLIENTS_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		_dt.Clear();
		_da = new MySqlDataAdapter("select            ID, ID_CLIENT,CODE_CLIENT,CLIENT,DATES,TELEPHONE,ADRESSE ,ETAT,CREDIT_INITIAL             from TABLE_CLIENTS    order by Client", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.RowTemplate.Height = 30;
		DataGridView1.DataSource = _dt;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
		DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
		DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
		DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
		DataGridView1.AutoResizeColumnHeadersHeight();
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView1.MultiSelect = true;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
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
			DataGridView1.AllowUserToAddRows = false;
			DataGridView1.AllowUserToDeleteRows = false;
			DataGridView1.AllowUserToOrderColumns = true;
			DataGridView1.AllowUserToResizeColumns = true;
			DataGridView1.AllowUserToResizeRows = false;
			((Control)Panel_HISTORIQUE).Visible = false;
			Label_TOP1.Text = "";
			Label_TOP2.Text = "";
			Label_TOP3.Text = "";
			Label_TOP4.Text = "";
		}
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				Form val = Application.OpenForms[Label1.Text];
				if (val != null)
				{
					((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0])._ID_Button = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value.ToString();
					((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0])._CODE_Button = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE_CLIENT"].Value.ToString();
					((ButtonBase)(Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0]).Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CLIENT"].Value.ToString();
				}
				else
				{
					MessageBox.Show("Le formulaire spécifié n'est pas ouvert.");
				}
				((Form)this).Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Form val = Application.OpenForms[Label1.Text];
		if (val != null)
		{
			((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0])._ID_Button = "";
			((Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0])._CODE_Button = "";
			((ButtonBase)(Button_ID_CODE)(object)((Control)val).Controls.Find("Button_CLIENT", true)[0]).Text = "";
		}
		else
		{
			MessageBox.Show("Le formulaire spécifié n'est pas ouvert.");
		}
		((Form)this).Close();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		((Control)Panel_HISTORIQUE).Hide();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  ID,Dates,ID_TICKET,ARTICLE,Prix_V,QTé   from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between     ' "), Strings.Format(DateTime.Now.Date.AddDays(-7.0), "yyyy-MM-dd")), " '    And  ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '       order by ID   desc ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView2.AutoGenerateColumns = false;
				DataGridView2.RowTemplate.Height = 20;
				DataGridView2.DataSource = dataTable;
				int num = DataGridView2.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (num2 == 0)
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num2].Cells[1].Value, DataGridView2.Rows[num2 - 1].Cells[1].Value, TextCompare: false))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor;
					}
					else if (DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor == Color.FromArgb(217, 225, 242))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					num2++;
				}
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable2.Clear();
				val2 = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  Article, sum(Qté) as Qté   from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between      ' "), Strings.Format(DateTime.Now.Date.AddDays(-7.0), "yyyy-MM-dd")), " '     And     ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '        group by Article        ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				DataGridView3.DataSource = dataTable2;
				DataGridView3.Sort(DataGridView3.Columns[1], ListSortDirection.Descending);
				try
				{
					Label_TOP1.Text = "";
					Label_TOP2.Text = "";
					Label_TOP3.Text = "";
					Label_TOP4.Text = "";
					Label_TOP1.Text = Conversions.ToString(DataGridView3.Rows[0].Cells[0].Value);
					Label_TOP2.Text = Conversions.ToString(DataGridView3.Rows[1].Cells[0].Value);
					Label_TOP3.Text = Conversions.ToString(DataGridView3.Rows[2].Cells[0].Value);
					Label_TOP4.Text = Conversions.ToString(DataGridView3.Rows[3].Cells[0].Value);
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
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  ID,Dates,ID_TICKET,ARTICLE,Prix_V,QTé    from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between    ' "), Strings.Format(DateTime.Now.Date.AddDays(-30.0), "yyyy-MM-dd")), " '     And      ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '   order by ID   desc ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView2.AutoGenerateColumns = false;
				DataGridView2.RowTemplate.Height = 20;
				DataGridView2.DataSource = dataTable;
				int num = DataGridView2.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (num2 == 0)
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num2].Cells[1].Value, DataGridView2.Rows[num2 - 1].Cells[1].Value, TextCompare: false))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor;
					}
					else if (DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor == Color.FromArgb(217, 225, 242))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					num2++;
				}
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable2.Clear();
				val2 = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  Article, sum(Qté) as Qté   from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between     ' "), Strings.Format(DateTime.Now.Date.AddDays(-30.0), "yyyy-MM-dd")), " '       And       ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '         group by Article        ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				DataGridView3.DataSource = dataTable2;
				DataGridView3.Sort(DataGridView3.Columns[1], ListSortDirection.Descending);
				try
				{
					Label_TOP1.Text = "";
					Label_TOP2.Text = "";
					Label_TOP3.Text = "";
					Label_TOP4.Text = "";
					Label_TOP1.Text = Conversions.ToString(DataGridView3.Rows[0].Cells[0].Value);
					Label_TOP2.Text = Conversions.ToString(DataGridView3.Rows[1].Cells[0].Value);
					Label_TOP3.Text = Conversions.ToString(DataGridView3.Rows[2].Cells[0].Value);
					Label_TOP4.Text = Conversions.ToString(DataGridView3.Rows[3].Cells[0].Value);
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
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  ID,Dates,ID_TICKET,ARTICLE,Prix_V,QTé    from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between    ' "), Strings.Format(DateTime.Now.Date.AddDays(-365.0), "yyyy-MM-dd")), " '     And      ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '   order by ID   desc ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView2.AutoGenerateColumns = false;
				DataGridView2.RowTemplate.Height = 20;
				DataGridView2.DataSource = dataTable;
				int num = DataGridView2.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (num2 == 0)
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num2].Cells[1].Value, DataGridView2.Rows[num2 - 1].Cells[1].Value, TextCompare: false))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor;
					}
					else if (DataGridView2.Rows[num2 - 1].DefaultCellStyle.BackColor == Color.FromArgb(217, 225, 242))
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
					}
					num2++;
				}
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable2.Clear();
				val2 = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select  Article, sum(Qté) as Qté   from TABLE_VENTES_JOURNAL    Where  ID_CLIENT =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), "'   and   Dates   between       ' "), Strings.Format(DateTime.Now.Date.AddDays(-365.0), "yyyy-MM-dd")), " '    And    ' "), Strings.Format(DateTime.Now.Date, "yyyy-MM-dd")), " '      group by Article        ")), Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				DataGridView3.DataSource = dataTable2;
				DataGridView3.Sort(DataGridView3.Columns[1], ListSortDirection.Descending);
				try
				{
					Label_TOP1.Text = "";
					Label_TOP2.Text = "";
					Label_TOP3.Text = "";
					Label_TOP4.Text = "";
					Label_TOP1.Text = Conversions.ToString(DataGridView3.Rows[0].Cells[0].Value);
					Label_TOP2.Text = Conversions.ToString(DataGridView3.Rows[1].Cells[0].Value);
					Label_TOP3.Text = Conversions.ToString(DataGridView3.Rows[2].Cells[0].Value);
					Label_TOP4.Text = Conversions.ToString(DataGridView3.Rows[3].Cells[0].Value);
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
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		try
		{
			((Control)Text_CLIENT).Focus();
			((Control)Panel_FICHE).Visible = true;
			((Control)Panel_FICHE).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			Text_ID.Text = "";
			Text_ID_CLIENT.Text = "";
			Text_CODE_CLIENT.Text = "";
			Text_CLIENT.Text = "";
			Text_ADRESSE.Text = "";
			Text_TEL.Text = "";
			Label_TOP.Text = "NOUVEAU";
			((Control)Text_CLIENT).Focus();
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

	private void Panel_REFRESH_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Form_5_CLIENTS_LISTE_Shown(object sender, EventArgs e)
	{
		((UserControl)Text_FIND).Text = "";
		((Control)Text_FIND).Focus();
	}

	private void DataGridView1_DoubleClick(object sender, EventArgs e)
	{
		Button15.PerformClick();
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_FICHE).Hide();
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_CLIENT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					if (Operators.CompareString(Text_CODE_CLIENT.Text, "", TextCompare: false) != 0)
					{
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select ID,CODE_CLIENT,CLIENT     from TABLE_CLIENTS WHERE   CODE_CLIENT = '" + Text_CODE_CLIENT.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable.Rows[0]["CLIENT"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					MySqlCommand val2 = new MySqlCommand();
					val2.CommandText = "SELECT MAX(ID) From TABLE_CLIENTS ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val2.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val2.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					val2.CommandText = "Select CLIENT from TABLE_NUM  where ID = 0 ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string value = ((val2.ExecuteScalar() != DBNull.Value) ? ("CL" + Strings.Format(Conversions.ToDouble(val2.ExecuteScalar()), "000000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					_dt.Rows.Add();
					int index = _dt.Rows.Count - 1;
					_dt.Rows[index]["ID"] = num;
					_dt.Rows[index]["ID_CLIENT"] = value;
					_dt.Rows[index]["CODE_CLIENT"] = Strings.Trim(Text_CODE_CLIENT.Text);
					_dt.Rows[index]["CLIENT"] = Strings.Trim(Text_CLIENT.Text);
					_dt.Rows[index]["DATES"] = DateTime.Now.Date;
					_dt.Rows[index]["ADRESSE"] = Text_ADRESSE.Text;
					_dt.Rows[index]["TELEPHONE"] = Text_TEL.Text;
					_dt.Rows[index]["ETAT"] = "VALIDER";
					_dt.Rows[index]["CREDIT_INITIAL"] = 0;
					MySqlCommandBuilder val3 = new MySqlCommandBuilder(_da);
					((DbDataAdapter)(object)_da).Update(_dt);
					_dt.AcceptChanges();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val2.CommandText = "UPDATE     TABLE_NUM    SET CLIENT =  CLIENT + 1   ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					((UserControl)Text_FIND).Text = Text_CODE_CLIENT.Text;
				}
				((Control)Panel_FICHE).Hide();
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
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
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

	private void Button7_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count != 0)
		{
			if (!((Control)Panel_HISTORIQUE).Visible)
			{
				((Control)Panel_HISTORIQUE).Visible = true;
				((Control)Panel_HISTORIQUE).BringToFront();
				DataGridView2.DataSource = null;
			}
			else
			{
				((Control)Panel_HISTORIQUE).Visible = false;
			}
		}
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		((Control)Panel_HISTORIQUE).Visible = false;
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

	private void Button_CLAVIERR_Click(object sender, EventArgs e)
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

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		try
		{
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "         WHERE   CLIENT   like  '%" + Text_FIND.Texts + "%'      or       TELEPHONE like  '%" + Text_FIND.Texts + "%'   or   CODE_CLIENT  =  '" + Text_FIND.Texts + "'                              order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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

	public void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		try
		{
			Text_FIND.Texts = "";
			_dt.Clear();
			_da = new MySqlDataAdapter("select * from      TABLE_" + Label_TABLE.Text + "                  order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			DataGridView1.DataSource = _dt;
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
}
