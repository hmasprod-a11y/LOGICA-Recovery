using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_9_STATISTIQUES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Chart1")]
	private Chart _Chart1;

	[AccessedThroughProperty("Button_GO")]
	private Button _Button_GO;

	[AccessedThroughProperty("Panel26")]
	private Panel _Panel26;

	[AccessedThroughProperty("Label_ARTICLE_TOP")]
	private Label _Label_ARTICLE_TOP;

	[AccessedThroughProperty("DateTimePicker5")]
	private DateTimePicker _DateTimePicker5;

	[AccessedThroughProperty("DateTimePicker6")]
	private DateTimePicker _DateTimePicker6;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DateTimePicker3")]
	private DateTimePicker _DateTimePicker3;

	[AccessedThroughProperty("DateTimePicker4")]
	private DateTimePicker _DateTimePicker4;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("TabControlEx1")]
	private TabControlEx _TabControlEx1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("List_COLOR")]
	private ListBox _List_COLOR;

	[AccessedThroughProperty("DataGrid_STATISTIQUE")]
	private DataGridView _DataGrid_STATISTIQUE;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Label_CHIFFRE_ANNEE")]
	private Label _Label_CHIFFRE_ANNEE;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label_TOP_MOIS")]
	private Label _Label_TOP_MOIS;

	[AccessedThroughProperty("Label_TOP_MOIS_CHIFFRE")]
	private Label _Label_TOP_MOIS_CHIFFRE;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel24")]
	private Panel _Panel24;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Panel36")]
	private Panel _Panel36;

	[AccessedThroughProperty("Panel39")]
	private Panel _Panel39;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Panel40")]
	private Panel _Panel40;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("Panel45")]
	private Panel _Panel45;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Panel46")]
	private Panel _Panel46;

	[AccessedThroughProperty("PictureBox22")]
	private PictureBox _PictureBox22;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("Panel42")]
	private Panel _Panel42;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Panel43")]
	private Panel _Panel43;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("PictureBox23")]
	private PictureBox _PictureBox23;

	[AccessedThroughProperty("PictureBox24")]
	private PictureBox _PictureBox24;

	[AccessedThroughProperty("PictureBox25")]
	private PictureBox _PictureBox25;

	[AccessedThroughProperty("PictureBox26")]
	private PictureBox _PictureBox26;

	[AccessedThroughProperty("PictureBox27")]
	private PictureBox _PictureBox27;

	[AccessedThroughProperty("PictureBox28")]
	private PictureBox _PictureBox28;

	[AccessedThroughProperty("PictureBox29")]
	private PictureBox _PictureBox29;

	[AccessedThroughProperty("PictureBox30")]
	private PictureBox _PictureBox30;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("Panel9")]
	private Panel _Panel9;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Panel12")]
	private Panel _Panel12;

	[AccessedThroughProperty("Panel10")]
	private Panel _Panel10;

	[AccessedThroughProperty("Panel11")]
	private Panel _Panel11;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Panel14")]
	private Panel _Panel14;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Panel13")]
	private Panel _Panel13;

	[AccessedThroughProperty("DateTimePicker11")]
	private DateTimePicker _DateTimePicker11;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("DateTimePicker12")]
	private DateTimePicker _DateTimePicker12;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Panel38")]
	private Panel _Panel38;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("Label_CLIENT_TOP")]
	private Label _Label_CLIENT_TOP;

	[AccessedThroughProperty("Panel15")]
	private Panel _Panel15;

	[AccessedThroughProperty("Panel16")]
	private Panel _Panel16;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("TextBox_ANNEE")]
	private TextBox _TextBox_ANNEE;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Chart7")]
	private Chart _Chart7;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Panel21")]
	private Panel _Panel21;

	[AccessedThroughProperty("Panel32")]
	private Panel _Panel32;

	[AccessedThroughProperty("Label_VENDEUR_TOP")]
	private Label _Label_VENDEUR_TOP;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("Panel17")]
	private Panel _Panel17;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Chart4")]
	private Chart _Chart4;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Panel19")]
	private Panel _Panel19;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("DateTimePicker9")]
	private DateTimePicker _DateTimePicker9;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("DateTimePicker10")]
	private DateTimePicker _DateTimePicker10;

	[AccessedThroughProperty("Panel20")]
	private Panel _Panel20;

	[AccessedThroughProperty("Panel22")]
	private Panel _Panel22;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("DateTimePicker13")]
	private DateTimePicker _DateTimePicker13;

	[AccessedThroughProperty("PictureBox31")]
	private PictureBox _PictureBox31;

	[AccessedThroughProperty("DateTimePicker14")]
	private DateTimePicker _DateTimePicker14;

	[AccessedThroughProperty("Panel23")]
	private Panel _Panel23;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Chart3")]
	private Chart _Chart3;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Panel25")]
	private Panel _Panel25;

	[AccessedThroughProperty("Label_CAISSIER_TOP")]
	private Label _Label_CAISSIER_TOP;

	[AccessedThroughProperty("PictureBox32")]
	private PictureBox _PictureBox32;

	[AccessedThroughProperty("Panel27")]
	private Panel _Panel27;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Chart5")]
	private Chart _Chart5;

	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("Label52")]
	private Label _Label52;

	[AccessedThroughProperty("Panel28")]
	private Panel _Panel28;

	[AccessedThroughProperty("Label53")]
	private Label _Label53;

	[AccessedThroughProperty("Chart6")]
	private Chart _Chart6;

	[AccessedThroughProperty("Label54")]
	private Label _Label54;

	[AccessedThroughProperty("Label55")]
	private Label _Label55;

	[AccessedThroughProperty("Label56")]
	private Label _Label56;

	[AccessedThroughProperty("DataGridView4")]
	private DataGridView _DataGridView4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

	[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel29")]
	private Panel _Panel29;

	[AccessedThroughProperty("Label57")]
	private Label _Label57;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("Chart2")]
	private Chart _Chart2;

	[AccessedThroughProperty("Label59")]
	private Label _Label59;

	[AccessedThroughProperty("Label60")]
	private Label _Label60;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	internal virtual Chart Chart1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart1 = value;
		}
	}

	internal virtual Button Button_GO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_GO_Click;
			if (_Button_GO != null)
			{
				((Control)_Button_GO).Click -= eventHandler;
			}
			_Button_GO = value;
			if (_Button_GO != null)
			{
				((Control)_Button_GO).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel26 = value;
		}
	}

	internal virtual Label Label_ARTICLE_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ARTICLE_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ARTICLE_TOP = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker5 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker6 = value;
		}
	}

	internal virtual PictureBox PictureBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox13 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn3 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker3 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker4 = value;
		}
	}

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
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

	internal virtual PictureBox PictureBox19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox19 = value;
		}
	}

	internal virtual TabControlEx TabControlEx1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlEx1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual ListBox List_COLOR
	{
		[DebuggerNonUserCode]
		get
		{
			return _List_COLOR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_List_COLOR = value;
		}
	}

	internal virtual DataGridView DataGrid_STATISTIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_STATISTIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGrid_STATISTIQUE = value;
		}
	}

	internal virtual Panel Panel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel6 = value;
		}
	}

	internal virtual Label Label31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label31 = value;
		}
	}

	internal virtual Label Label32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label32 = value;
		}
	}

	internal virtual Label Label33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label33 = value;
		}
	}

	internal virtual Label Label34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label34 = value;
		}
	}

	internal virtual Panel Panel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel8 = value;
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

	internal virtual Label Label_CHIFFRE_ANNEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CHIFFRE_ANNEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CHIFFRE_ANNEE = value;
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

	internal virtual Label Label_TOP_MOIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP_MOIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP_MOIS = value;
		}
	}

	internal virtual Label Label_TOP_MOIS_CHIFFRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP_MOIS_CHIFFRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP_MOIS_CHIFFRE = value;
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

	internal virtual Panel Panel24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel24 = value;
		}
	}

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	internal virtual Panel Panel36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel36 = value;
		}
	}

	internal virtual Panel Panel39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel39 = value;
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

	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
		}
	}

	internal virtual Panel Panel40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel40 = value;
		}
	}

	internal virtual PictureBox PictureBox20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox20 = value;
		}
	}

	internal virtual Panel Panel45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel45 = value;
		}
	}

	internal virtual Label Label36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label36 = value;
		}
	}

	internal virtual Label Label37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label37 = value;
		}
	}

	internal virtual Panel Panel46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel46 = value;
		}
	}

	internal virtual PictureBox PictureBox22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox22 = value;
		}
	}

	internal virtual PictureBox PictureBox17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox17 = value;
		}
	}

	internal virtual Panel Panel42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel42 = value;
		}
	}

	internal virtual PictureBox PictureBox21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox21 = value;
		}
	}

	internal virtual Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30 = value;
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

	internal virtual Panel Panel43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel43 = value;
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

	internal virtual Label Label40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label40 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
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

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
		}
	}

	internal virtual PictureBox PictureBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox11 = value;
		}
	}

	internal virtual PictureBox PictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox12 = value;
		}
	}

	internal virtual PictureBox PictureBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox14 = value;
		}
	}

	internal virtual PictureBox PictureBox23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox23 = value;
		}
	}

	internal virtual PictureBox PictureBox24
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox24 = value;
		}
	}

	internal virtual PictureBox PictureBox25
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox25 = value;
		}
	}

	internal virtual PictureBox PictureBox26
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox26 = value;
		}
	}

	internal virtual PictureBox PictureBox27
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox27 = value;
		}
	}

	internal virtual PictureBox PictureBox28
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox28 = value;
		}
	}

	internal virtual PictureBox PictureBox29
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox29 = value;
		}
	}

	internal virtual PictureBox PictureBox30
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox30 = value;
		}
	}

	internal virtual Panel Panel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7 = value;
		}
	}

	internal virtual Panel Panel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel9 = value;
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

	internal virtual Panel Panel12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel12 = value;
		}
	}

	internal virtual Panel Panel10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel10 = value;
		}
	}

	internal virtual Panel Panel11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel11 = value;
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

	internal virtual Panel Panel14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel14 = value;
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

	internal virtual Panel Panel13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel13 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker11
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker11 = value;
		}
	}

	internal virtual PictureBox PictureBox18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox18 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker12
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker12 = value;
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

	internal virtual Panel Panel38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel38 = value;
		}
	}

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox9 = value;
		}
	}

	internal virtual Label Label_CLIENT_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CLIENT_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CLIENT_TOP = value;
		}
	}

	internal virtual Panel Panel15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel15 = value;
		}
	}

	internal virtual Panel Panel16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel16 = value;
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

	internal virtual DateTimePicker DateTimePicker2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker2 = value;
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox6 = value;
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
			EventHandler eventHandler = Label9_Click;
			if (_Label9 != null)
			{
				((Control)_Label9).Click -= eventHandler;
			}
			_Label9 = value;
			if (_Label9 != null)
			{
				((Control)_Label9).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label14_Click;
			if (_Label14 != null)
			{
				((Control)_Label14).Click -= eventHandler;
			}
			_Label14 = value;
			if (_Label14 != null)
			{
				((Control)_Label14).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox TextBox_ANNEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_ANNEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_ANNEE = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
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

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Chart Chart7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart7 = value;
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

	internal virtual Panel Panel21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel21 = value;
		}
	}

	internal virtual Panel Panel32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel32 = value;
		}
	}

	internal virtual Label Label_VENDEUR_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VENDEUR_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_VENDEUR_TOP = value;
		}
	}

	internal virtual PictureBox PictureBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox15 = value;
		}
	}

	internal virtual Panel Panel17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel17 = value;
		}
	}

	internal virtual Label Label38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label38 = value;
		}
	}

	internal virtual Label Label39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label39 = value;
		}
	}

	internal virtual Label Label41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label41 = value;
		}
	}

	internal virtual Chart Chart4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart4 = value;
		}
	}

	internal virtual Label Label42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label42 = value;
		}
	}

	internal virtual Panel Panel19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel19 = value;
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

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).Click += eventHandler;
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker9
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker9 = value;
		}
	}

	internal virtual PictureBox PictureBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox16 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker10
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker10 = value;
		}
	}

	internal virtual Panel Panel20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel20 = value;
		}
	}

	internal virtual Panel Panel22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel22 = value;
		}
	}

	internal virtual Label Label48
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label48 = value;
		}
	}

	internal virtual Label Label43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label43 = value;
		}
	}

	internal virtual Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button9_Click;
			if (_Button9 != null)
			{
				((Control)_Button9).Click -= eventHandler;
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				((Control)_Button9).Click += eventHandler;
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker13
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker13 = value;
		}
	}

	internal virtual PictureBox PictureBox31
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox31 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker14
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker14 = value;
		}
	}

	internal virtual Panel Panel23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel23 = value;
		}
	}

	internal virtual Label Label44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label44 = value;
		}
	}

	internal virtual Label Label45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label45 = value;
		}
	}

	internal virtual Label Label46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label46 = value;
		}
	}

	internal virtual Chart Chart3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart3 = value;
		}
	}

	internal virtual Label Label47
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label47 = value;
		}
	}

	internal virtual Panel Panel25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel25 = value;
		}
	}

	internal virtual Label Label_CAISSIER_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CAISSIER_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CAISSIER_TOP = value;
		}
	}

	internal virtual PictureBox PictureBox32
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox32 = value;
		}
	}

	internal virtual Panel Panel27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel27 = value;
		}
	}

	internal virtual Label Label49
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label49 = value;
		}
	}

	internal virtual Chart Chart5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart5 = value;
		}
	}

	internal virtual Label Label50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label50 = value;
		}
	}

	internal virtual Label Label51
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label51 = value;
		}
	}

	internal virtual Label Label52
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label52 = value;
		}
	}

	internal virtual Panel Panel28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel28 = value;
		}
	}

	internal virtual Label Label53
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label53 = value;
		}
	}

	internal virtual Chart Chart6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart6 = value;
		}
	}

	internal virtual Label Label54
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label54 = value;
		}
	}

	internal virtual Label Label55
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label55 = value;
		}
	}

	internal virtual Label Label56
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label56 = value;
		}
	}

	internal virtual DataGridView DataGridView4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn10 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn11 = value;
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

	internal virtual Panel Panel29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel29 = value;
		}
	}

	internal virtual Label Label57
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label57 = value;
		}
	}

	internal virtual Label Label58
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label58 = value;
		}
	}

	internal virtual Chart Chart2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chart2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chart2 = value;
		}
	}

	internal virtual Label Label59
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label59 = value;
		}
	}

	internal virtual Label Label60
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label60 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn6 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_9_STATISTIQUES()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		((Form)this).FormClosed += Form_9_STATISTIQUES_FormClosed;
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Load += Form_9_STATISTIQUES_Load;
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
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected Obj, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected Obj, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected Obj, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got Unknown
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected Obj, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected Obj, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected Obj, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected Obj, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected Obj, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected Obj, but got Unknown
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_1161: Expected Obj, but got Unknown
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected Obj, but got Unknown
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Expected Obj, but got Unknown
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348: Expected Obj, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Expected Obj, but got Unknown
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Expected Obj, but got Unknown
		//IL_173e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1748: Expected Obj, but got Unknown
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1817: Expected Obj, but got Unknown
		//IL_18d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e2: Expected Obj, but got Unknown
		//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b1: Expected Obj, but got Unknown
		//IL_1a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Expected Obj, but got Unknown
		//IL_1a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a90: Expected Obj, but got Unknown
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aac: Expected Obj, but got Unknown
		//IL_1abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Expected Obj, but got Unknown
		//IL_1ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae4: Expected Obj, but got Unknown
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb1: Expected Obj, but got Unknown
		//IL_1bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcd: Expected Obj, but got Unknown
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d73: Expected Obj, but got Unknown
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected Obj, but got Unknown
		//IL_1ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Expected Obj, but got Unknown
		//IL_1f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f39: Expected Obj, but got Unknown
		//IL_1fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd1: Expected Obj, but got Unknown
		//IL_2070: Unknown result type (might be due to invalid IL or missing references)
		//IL_207a: Expected Obj, but got Unknown
		//IL_2135: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Expected Obj, but got Unknown
		//IL_21fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2204: Expected Obj, but got Unknown
		//IL_2383: Unknown result type (might be due to invalid IL or missing references)
		//IL_2389: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fa: Expected Obj, but got Unknown
		//IL_248e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2498: Expected Obj, but got Unknown
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Expected Obj, but got Unknown
		//IL_25b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c0: Expected Obj, but got Unknown
		//IL_264e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2658: Expected Obj, but got Unknown
		//IL_26f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2701: Expected Obj, but got Unknown
		//IL_27ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c4: Expected Obj, but got Unknown
		//IL_287f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2889: Expected Obj, but got Unknown
		//IL_2a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7d: Expected Obj, but got Unknown
		//IL_2b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1b: Expected Obj, but got Unknown
		//IL_2bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb7: Expected Obj, but got Unknown
		//IL_2c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c43: Expected Obj, but got Unknown
		//IL_2cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cdb: Expected Obj, but got Unknown
		//IL_2d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d84: Expected Obj, but got Unknown
		//IL_2e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e48: Expected Obj, but got Unknown
		//IL_2ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2efb: Expected Obj, but got Unknown
		//IL_3099: Unknown result type (might be due to invalid IL or missing references)
		//IL_309f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3106: Unknown result type (might be due to invalid IL or missing references)
		//IL_3110: Expected Obj, but got Unknown
		//IL_31a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ae: Expected Obj, but got Unknown
		//IL_3240: Unknown result type (might be due to invalid IL or missing references)
		//IL_324a: Expected Obj, but got Unknown
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d6: Expected Obj, but got Unknown
		//IL_3364: Unknown result type (might be due to invalid IL or missing references)
		//IL_336e: Expected Obj, but got Unknown
		//IL_340d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3417: Expected Obj, but got Unknown
		//IL_34d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_34da: Expected Obj, but got Unknown
		//IL_3595: Unknown result type (might be due to invalid IL or missing references)
		//IL_359f: Expected Obj, but got Unknown
		//IL_3824: Unknown result type (might be due to invalid IL or missing references)
		//IL_382e: Expected Obj, but got Unknown
		//IL_3905: Unknown result type (might be due to invalid IL or missing references)
		//IL_390f: Expected Obj, but got Unknown
		//IL_39de: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e8: Expected Obj, but got Unknown
		//IL_3a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a9d: Expected Obj, but got Unknown
		//IL_3b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b72: Expected Obj, but got Unknown
		//IL_3b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba0: Expected Obj, but got Unknown
		//IL_3bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_4469: Unknown result type (might be due to invalid IL or missing references)
		//IL_4473: Expected Obj, but got Unknown
		//IL_4538: Unknown result type (might be due to invalid IL or missing references)
		//IL_4542: Expected Obj, but got Unknown
		//IL_4624: Unknown result type (might be due to invalid IL or missing references)
		//IL_462a: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46da: Expected Obj, but got Unknown
		//IL_479f: Unknown result type (might be due to invalid IL or missing references)
		//IL_47a9: Expected Obj, but got Unknown
		//IL_49b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c0: Expected Obj, but got Unknown
		//IL_49f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a9e: Expected Obj, but got Unknown
		//IL_4ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b7c: Expected Obj, but got Unknown
		//IL_4bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c57: Expected Obj, but got Unknown
		//IL_4d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d11: Expected Obj, but got Unknown
		//IL_4de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dee: Expected Obj, but got Unknown
		//IL_4eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ebd: Expected Obj, but got Unknown
		//IL_4f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f88: Expected Obj, but got Unknown
		//IL_504d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5057: Expected Obj, but got Unknown
		//IL_5213: Unknown result type (might be due to invalid IL or missing references)
		//IL_521d: Expected Obj, but got Unknown
		//IL_522f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5239: Expected Obj, but got Unknown
		//IL_52c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_52ca: Expected Obj, but got Unknown
		//IL_52dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_52e6: Expected Obj, but got Unknown
		//IL_52f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5302: Expected Obj, but got Unknown
		//IL_54b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_54c2: Expected Obj, but got Unknown
		//IL_5559: Unknown result type (might be due to invalid IL or missing references)
		//IL_5563: Expected Obj, but got Unknown
		//IL_571c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5726: Expected Obj, but got Unknown
		//IL_57eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_57f5: Expected Obj, but got Unknown
		//IL_58b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_58c0: Expected Obj, but got Unknown
		//IL_5a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a45: Expected Obj, but got Unknown
		//IL_5c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c1f: Expected Obj, but got Unknown
		//IL_5cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cdf: Expected Obj, but got Unknown
		//IL_5daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5db4: Expected Obj, but got Unknown
		//IL_5dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5de2: Expected Obj, but got Unknown
		//IL_5e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ec5: Expected Obj, but got Unknown
		//IL_5f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f92: Expected Obj, but got Unknown
		//IL_6035: Unknown result type (might be due to invalid IL or missing references)
		//IL_603f: Expected Obj, but got Unknown
		//IL_6290: Unknown result type (might be due to invalid IL or missing references)
		//IL_629a: Expected Obj, but got Unknown
		//IL_6350: Unknown result type (might be due to invalid IL or missing references)
		//IL_635a: Expected Obj, but got Unknown
		//IL_6425: Unknown result type (might be due to invalid IL or missing references)
		//IL_642f: Expected Obj, but got Unknown
		//IL_6453: Unknown result type (might be due to invalid IL or missing references)
		//IL_645d: Expected Obj, but got Unknown
		//IL_6491: Unknown result type (might be due to invalid IL or missing references)
		//IL_6497: Unknown result type (might be due to invalid IL or missing references)
		//IL_6536: Unknown result type (might be due to invalid IL or missing references)
		//IL_6540: Expected Obj, but got Unknown
		//IL_6603: Unknown result type (might be due to invalid IL or missing references)
		//IL_660d: Expected Obj, but got Unknown
		//IL_66b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_66ba: Expected Obj, but got Unknown
		//IL_6867: Unknown result type (might be due to invalid IL or missing references)
		//IL_6871: Expected Obj, but got Unknown
		//IL_6936: Unknown result type (might be due to invalid IL or missing references)
		//IL_6940: Expected Obj, but got Unknown
		//IL_6a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a0b: Expected Obj, but got Unknown
		//IL_6b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b90: Expected Obj, but got Unknown
		//IL_6cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cff: Expected Obj, but got Unknown
		//IL_6d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_6da0: Expected Obj, but got Unknown
		//IL_6e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_717f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7189: Expected Obj, but got Unknown
		//IL_7405: Unknown result type (might be due to invalid IL or missing references)
		//IL_740f: Expected Obj, but got Unknown
		//IL_758c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7596: Expected Obj, but got Unknown
		//IL_7657: Unknown result type (might be due to invalid IL or missing references)
		//IL_7661: Expected Obj, but got Unknown
		//IL_7726: Unknown result type (might be due to invalid IL or missing references)
		//IL_7730: Expected Obj, but got Unknown
		//IL_7900: Unknown result type (might be due to invalid IL or missing references)
		//IL_790a: Expected Obj, but got Unknown
		//IL_79c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_79cd: Expected Obj, but got Unknown
		//IL_7a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a9a: Expected Obj, but got Unknown
		//IL_7b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b47: Expected Obj, but got Unknown
		//IL_7bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bfa: Expected Obj, but got Unknown
		//IL_7c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c28: Expected Obj, but got Unknown
		//IL_7c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d08: Expected Obj, but got Unknown
		//IL_7e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e73: Expected Obj, but got Unknown
		//IL_7f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f0f: Expected Obj, but got Unknown
		//IL_7ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_8001: Unknown result type (might be due to invalid IL or missing references)
		//IL_8111: Unknown result type (might be due to invalid IL or missing references)
		//IL_811b: Expected Obj, but got Unknown
		//IL_8579: Unknown result type (might be due to invalid IL or missing references)
		//IL_8583: Expected Obj, but got Unknown
		//IL_8700: Unknown result type (might be due to invalid IL or missing references)
		//IL_870a: Expected Obj, but got Unknown
		//IL_87cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_87d5: Expected Obj, but got Unknown
		//IL_889a: Unknown result type (might be due to invalid IL or missing references)
		//IL_88a4: Expected Obj, but got Unknown
		//IL_8a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a7e: Expected Obj, but got Unknown
		//IL_8b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b41: Expected Obj, but got Unknown
		//IL_8c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c0e: Expected Obj, but got Unknown
		//IL_8cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8cbb: Expected Obj, but got Unknown
		//IL_8d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d58: Expected Obj, but got Unknown
		//IL_8e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e2d: Expected Obj, but got Unknown
		//IL_8e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e5b: Expected Obj, but got Unknown
		//IL_8e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fe7: Expected Obj, but got Unknown
		//IL_9079: Unknown result type (might be due to invalid IL or missing references)
		//IL_9083: Expected Obj, but got Unknown
		//IL_9158: Unknown result type (might be due to invalid IL or missing references)
		//IL_915e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9495: Unknown result type (might be due to invalid IL or missing references)
		//IL_949f: Expected Obj, but got Unknown
		//IL_94e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_94e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_96a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_96ae: Expected Obj, but got Unknown
		//IL_9773: Unknown result type (might be due to invalid IL or missing references)
		//IL_977d: Expected Obj, but got Unknown
		//IL_98f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_9900: Expected Obj, but got Unknown
		//IL_99c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_99cf: Expected Obj, but got Unknown
		//IL_9b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ba9: Expected Obj, but got Unknown
		//IL_9c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c7f: Expected Obj, but got Unknown
		//IL_9ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cad: Expected Obj, but got Unknown
		//IL_9ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d90: Expected Obj, but got Unknown
		//IL_9e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e53: Expected Obj, but got Unknown
		//IL_9ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_9efd: Expected Obj, but got Unknown
		//IL_9f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fa7: Expected Obj, but got Unknown
		//IL_a08c: Unknown result type (might be due to invalid IL or missing references)
		//IL_a096: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_9_STATISTIQUES));
		ChartArea val = new ChartArea();
		Legend val2 = new Legend();
		ChartArea val3 = new ChartArea();
		Legend val4 = new Legend();
		ChartArea val5 = new ChartArea();
		Legend val6 = new Legend();
		ChartArea val7 = new ChartArea();
		Legend val8 = new Legend();
		ChartArea val9 = new ChartArea();
		Legend val10 = new Legend();
		ChartArea val11 = new ChartArea();
		Legend val12 = new Legend();
		ChartArea val13 = new ChartArea();
		Legend val14 = new Legend();
		TabControlEx1 = new TabControlEx();
		TabPage1 = new TabPage();
		Panel7 = new Panel();
		Panel9 = new Panel();
		Label1 = new Label();
		Button3 = new Button();
		DateTimePicker3 = new DateTimePicker();
		PictureBox8 = new PictureBox();
		DateTimePicker4 = new DateTimePicker();
		Panel3 = new Panel();
		Chart7 = new Chart();
		Label10 = new Label();
		Label19 = new Label();
		Label21 = new Label();
		Label40 = new Label();
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel24 = new Panel();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox17 = new PictureBox();
		Label26 = new Label();
		Label27 = new Label();
		Panel36 = new Panel();
		Panel39 = new Panel();
		PictureBox10 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox14 = new PictureBox();
		PictureBox20 = new PictureBox();
		Label28 = new Label();
		Label29 = new Label();
		Panel40 = new Panel();
		Panel42 = new Panel();
		PictureBox23 = new PictureBox();
		PictureBox24 = new PictureBox();
		PictureBox25 = new PictureBox();
		PictureBox26 = new PictureBox();
		PictureBox21 = new PictureBox();
		Label30 = new Label();
		Panel43 = new Panel();
		Label35 = new Label();
		Panel45 = new Panel();
		PictureBox27 = new PictureBox();
		PictureBox28 = new PictureBox();
		PictureBox29 = new PictureBox();
		PictureBox30 = new PictureBox();
		PictureBox22 = new PictureBox();
		Label36 = new Label();
		Label37 = new Label();
		Panel46 = new Panel();
		Panel1 = new Panel();
		Panel5 = new Panel();
		Label9 = new Label();
		Label14 = new Label();
		TextBox_ANNEE = new TextBox();
		Label16 = new Label();
		Button_GO = new Button();
		List_COLOR = new ListBox();
		DataGrid_STATISTIQUE = new DataGridView();
		Panel6 = new Panel();
		Label31 = new Label();
		Label32 = new Label();
		Chart1 = new Chart();
		Label33 = new Label();
		Label34 = new Label();
		Panel8 = new Panel();
		Label_TOP_MOIS_CHIFFRE = new Label();
		Label_TOP_MOIS = new Label();
		Label_CHIFFRE_ANNEE = new Label();
		Label15 = new Label();
		Label18 = new Label();
		Label22 = new Label();
		Label23 = new Label();
		Label24 = new Label();
		Label25 = new Label();
		TabPage4 = new TabPage();
		Panel2 = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		Panel21 = new Panel();
		Panel32 = new Panel();
		Label_VENDEUR_TOP = new Label();
		PictureBox15 = new PictureBox();
		Panel17 = new Panel();
		Label38 = new Label();
		Label39 = new Label();
		Label41 = new Label();
		Chart4 = new Chart();
		Label42 = new Label();
		Panel19 = new Panel();
		Label2 = new Label();
		Label3 = new Label();
		Button5 = new Button();
		DateTimePicker9 = new DateTimePicker();
		PictureBox16 = new PictureBox();
		DateTimePicker10 = new DateTimePicker();
		Panel20 = new Panel();
		Panel22 = new Panel();
		Label48 = new Label();
		Label43 = new Label();
		Button9 = new Button();
		DateTimePicker13 = new DateTimePicker();
		PictureBox31 = new PictureBox();
		DateTimePicker14 = new DateTimePicker();
		Panel23 = new Panel();
		Label44 = new Label();
		Label45 = new Label();
		Label46 = new Label();
		Chart3 = new Chart();
		Label47 = new Label();
		Panel25 = new Panel();
		Label_CAISSIER_TOP = new Label();
		PictureBox32 = new PictureBox();
		TabPage5 = new TabPage();
		Panel12 = new Panel();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		Label11 = new Label();
		Panel10 = new Panel();
		Panel27 = new Panel();
		Label49 = new Label();
		Chart5 = new Chart();
		Label50 = new Label();
		Label51 = new Label();
		Label52 = new Label();
		Panel11 = new Panel();
		Label20 = new Label();
		DateTimePicker5 = new DateTimePicker();
		PictureBox13 = new PictureBox();
		DateTimePicker6 = new DateTimePicker();
		Button4 = new Button();
		Label6 = new Label();
		Panel26 = new Panel();
		PictureBox19 = new PictureBox();
		Label_ARTICLE_TOP = new Label();
		TabPage3 = new TabPage();
		Panel14 = new Panel();
		Label12 = new Label();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		Panel4 = new Panel();
		Panel28 = new Panel();
		Label53 = new Label();
		Chart6 = new Chart();
		Label54 = new Label();
		Label55 = new Label();
		Label56 = new Label();
		Panel13 = new Panel();
		Label17 = new Label();
		DateTimePicker11 = new DateTimePicker();
		PictureBox18 = new PictureBox();
		DateTimePicker12 = new DateTimePicker();
		Label8 = new Label();
		Button6 = new Button();
		Panel38 = new Panel();
		PictureBox9 = new PictureBox();
		Label_CLIENT_TOP = new Label();
		TabPage2 = new TabPage();
		Panel15 = new Panel();
		DataGridView4 = new DataGridView();
		DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
		Button1 = new Button();
		Panel29 = new Panel();
		Label57 = new Label();
		Label58 = new Label();
		Chart2 = new Chart();
		Label59 = new Label();
		Label60 = new Label();
		Panel16 = new Panel();
		Label4 = new Label();
		Button2 = new Button();
		DateTimePicker1 = new DateTimePicker();
		DateTimePicker2 = new DateTimePicker();
		PictureBox6 = new PictureBox();
		Label5 = new Label();
		((Control)TabControlEx1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel7).SuspendLayout();
		((Control)Panel9).SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)Chart7).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel24).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((Control)Panel39).SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((Control)Panel42).SuspendLayout();
		((ISupportInitialize)PictureBox23).BeginInit();
		((ISupportInitialize)PictureBox24).BeginInit();
		((ISupportInitialize)PictureBox25).BeginInit();
		((ISupportInitialize)PictureBox26).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((Control)Panel45).SuspendLayout();
		((ISupportInitialize)PictureBox27).BeginInit();
		((ISupportInitialize)PictureBox28).BeginInit();
		((ISupportInitialize)PictureBox29).BeginInit();
		((ISupportInitialize)PictureBox30).BeginInit();
		((ISupportInitialize)PictureBox22).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)DataGrid_STATISTIQUE).BeginInit();
		((Control)Panel6).SuspendLayout();
		((ISupportInitialize)Chart1).BeginInit();
		((Control)Panel8).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)Panel21).SuspendLayout();
		((Control)Panel32).SuspendLayout();
		((ISupportInitialize)PictureBox15).BeginInit();
		((Control)Panel17).SuspendLayout();
		((ISupportInitialize)Chart4).BeginInit();
		((Control)Panel19).SuspendLayout();
		((ISupportInitialize)PictureBox16).BeginInit();
		((Control)Panel20).SuspendLayout();
		((Control)Panel22).SuspendLayout();
		((ISupportInitialize)PictureBox31).BeginInit();
		((Control)Panel23).SuspendLayout();
		((ISupportInitialize)Chart3).BeginInit();
		((Control)Panel25).SuspendLayout();
		((ISupportInitialize)PictureBox32).BeginInit();
		((Control)TabPage5).SuspendLayout();
		((Control)Panel12).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)Panel10).SuspendLayout();
		((Control)Panel27).SuspendLayout();
		((ISupportInitialize)Chart5).BeginInit();
		((Control)Panel11).SuspendLayout();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)Panel26).SuspendLayout();
		((ISupportInitialize)PictureBox19).BeginInit();
		((Control)TabPage3).SuspendLayout();
		((Control)Panel14).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((Control)Panel4).SuspendLayout();
		((Control)Panel28).SuspendLayout();
		((ISupportInitialize)Chart6).BeginInit();
		((Control)Panel13).SuspendLayout();
		((ISupportInitialize)PictureBox18).BeginInit();
		((Control)Panel38).SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel15).SuspendLayout();
		((ISupportInitialize)DataGridView4).BeginInit();
		((Control)Panel29).SuspendLayout();
		((ISupportInitialize)Chart2).BeginInit();
		((Control)Panel16).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)this).SuspendLayout();
		TabControlEx1.Alignment = (TabAlignment)2;
		TabControlEx1.BackColor = Color.WhiteSmoke;
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage4);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage5);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage3);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControlEx1).Dock = (DockStyle)5;
		TabControlEx1.DrawMode = (TabDrawMode)1;
		TabControlEx1.HeaderAlignment = (ContentAlignment)16;
		TabControlEx1.HeaderBackColor = Color.WhiteSmoke;
		TabControlEx1.HeaderFont = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControlEx1.HeaderHeight = 40;
		TabControlEx tabControlEx = TabControlEx1;
		Padding headerPadding = new Padding(3, 0, 0, 0);
		tabControlEx.HeaderPadding = headerPadding;
		TabControlEx1.HeaderSelectedBackColor = Color.FromArgb(44, 53, 68);
		TabControlEx1.HeaderWidth = 150;
		TabControlEx tabControlEx2 = TabControlEx1;
		Size itemSize = new Size(40, 150);
		tabControlEx2.ItemSize = itemSize;
		TabControlEx tabControlEx3 = TabControlEx1;
		Point location = new Point(0, 0);
		((Control)tabControlEx3).Location = location;
		TabControlEx tabControlEx4 = TabControlEx1;
		headerPadding = new Padding(0);
		((Control)tabControlEx4).Margin = headerPadding;
		TabControlEx1.Multiline = true;
		((Control)TabControlEx1).Name = "TabControlEx1";
		TabControlEx tabControlEx5 = TabControlEx1;
		location = new Point(0, 0);
		((TabControl)tabControlEx5).Padding = location;
		((TabControl)TabControlEx1).SelectedIndex = 0;
		TabControlEx tabControlEx6 = TabControlEx1;
		itemSize = new Size(1025, 692);
		((Control)tabControlEx6).Size = itemSize;
		TabControlEx1.SizeMode = (TabSizeMode)2;
		((Control)TabControlEx1).TabIndex = 1050;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Panel7);
		((Control)TabPage1).Controls.Add((Control)(object)Panel1);
		TabPage tabPage = TabPage1;
		location = new Point(154, 4);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		headerPadding = new Padding(3);
		((Control)tabPage2).Padding = headerPadding;
		TabPage tabPage3 = TabPage1;
		itemSize = new Size(867, 684);
		((Control)tabPage3).Size = itemSize;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "Evolution des Ventes ";
		((Control)Panel7).Anchor = (AnchorStyles)15;
		((Control)Panel7).Controls.Add((Control)(object)Panel9);
		((Control)Panel7).Controls.Add((Control)(object)Panel3);
		Panel panel = Panel7;
		location = new Point(3, 344);
		((Control)panel).Location = location;
		((Control)Panel7).Name = "Panel7";
		Panel panel2 = Panel7;
		itemSize = new Size(861, 334);
		((Control)panel2).Size = itemSize;
		((Control)Panel7).TabIndex = 1058;
		((Control)Panel9).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel9).Controls.Add((Control)(object)Label1);
		((Control)Panel9).Controls.Add((Control)(object)Button3);
		((Control)Panel9).Controls.Add((Control)(object)DateTimePicker3);
		((Control)Panel9).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel9).Controls.Add((Control)(object)DateTimePicker4);
		((Control)Panel9).Dock = (DockStyle)1;
		Panel panel3 = Panel9;
		location = new Point(0, 0);
		((Control)panel3).Location = location;
		((Control)Panel9).Name = "Panel9";
		Panel panel4 = Panel9;
		itemSize = new Size(861, 43);
		((Control)panel4).Size = itemSize;
		((Control)Panel9).TabIndex = 998;
		((Control)Label1).Anchor = (AnchorStyles)9;
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label = Label1;
		location = new Point(370, 8);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		itemSize = new Size(68, 26);
		((Control)label2).Size = itemSize;
		((Control)Label1).TabIndex = 1051;
		Label1.Text = "Période";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Button3).Anchor = (AnchorStyles)9;
		((ButtonBase)Button3).BackColor = Color.Transparent;
		((Control)Button3).Cursor = Cursors.Hand;
		((Control)Button3).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button3).ForeColor = Color.Black;
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button = Button3;
		location = new Point(736, 2);
		((Control)button).Location = location;
		Button button2 = Button3;
		headerPadding = new Padding(0);
		((Control)button2).Margin = headerPadding;
		((Control)Button3).Name = "Button3";
		Button button3 = Button3;
		itemSize = new Size(123, 39);
		((Control)button3).Size = itemSize;
		((Control)Button3).TabIndex = 1047;
		((ButtonBase)Button3).Text = "CHARGER";
		((ButtonBase)Button3).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)DateTimePicker3).Anchor = (AnchorStyles)9;
		DateTimePicker3.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker3).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker3.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker3;
		location = new Point(444, 8);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker3).Name = "DateTimePicker3";
		DateTimePicker dateTimePicker2 = DateTimePicker3;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker2).Size = itemSize;
		((Control)DateTimePicker3).TabIndex = 1048;
		DateTimePicker dateTimePicker3 = DateTimePicker3;
		DateTime value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker3.Value = value;
		((Control)PictureBox8).Anchor = (AnchorStyles)9;
		((Control)PictureBox8).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox = PictureBox8;
		location = new Point(566, 8);
		((Control)pictureBox).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox2 = PictureBox8;
		itemSize = new Size(35, 26);
		((Control)pictureBox2).Size = itemSize;
		PictureBox8.SizeMode = (PictureBoxSizeMode)4;
		PictureBox8.TabIndex = 1050;
		PictureBox8.TabStop = false;
		((Control)DateTimePicker4).Anchor = (AnchorStyles)9;
		DateTimePicker4.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker4).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker4.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker4 = DateTimePicker4;
		location = new Point(601, 8);
		((Control)dateTimePicker4).Location = location;
		((Control)DateTimePicker4).Name = "DateTimePicker4";
		DateTimePicker dateTimePicker5 = DateTimePicker4;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker5).Size = itemSize;
		((Control)DateTimePicker4).TabIndex = 1049;
		((Control)Panel3).Anchor = (AnchorStyles)15;
		((Control)Panel3).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel3).Controls.Add((Control)(object)Chart7);
		((Control)Panel3).Controls.Add((Control)(object)Label10);
		((Control)Panel3).Controls.Add((Control)(object)Label19);
		((Control)Panel3).Controls.Add((Control)(object)Label21);
		((Control)Panel3).Controls.Add((Control)(object)Label40);
		((Control)Panel3).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel5 = Panel3;
		location = new Point(3, 45);
		((Control)panel5).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel6 = Panel3;
		itemSize = new Size(857, 289);
		((Control)panel6).Size = itemSize;
		((Control)Panel3).TabIndex = 1055;
		((Control)Chart7).Anchor = (AnchorStyles)15;
		val.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart7.ChartAreas).Add(val);
		val2.Name = "Legend1";
		((Collection<Legend>)(object)Chart7.Legends).Add(val2);
		Chart chart = Chart7;
		location = new Point(6, 100);
		((Control)chart).Location = location;
		((Control)Chart7).Name = "Chart7";
		Chart chart2 = Chart7;
		itemSize = new Size(845, 185);
		chart2.Size = itemSize;
		((Control)Chart7).TabIndex = 1044;
		((Control)Chart7).Text = "Chart7";
		((Control)Label10).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label10).Cursor = Cursors.Hand;
		((Control)Label10).Dock = (DockStyle)2;
		((Control)Label10).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label3 = Label10;
		location = new Point(1, 288);
		((Control)label3).Location = location;
		((Control)Label10).Name = "Label10";
		Label label4 = Label10;
		itemSize = new Size(855, 1);
		((Control)label4).Size = itemSize;
		((Control)Label10).TabIndex = 995;
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label19).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label19).Cursor = Cursors.Hand;
		((Control)Label19).Dock = (DockStyle)3;
		((Control)Label19).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.White;
		Label label5 = Label19;
		location = new Point(0, 1);
		((Control)label5).Location = location;
		((Control)Label19).Name = "Label19";
		Label label6 = Label19;
		itemSize = new Size(1, 288);
		((Control)label6).Size = itemSize;
		((Control)Label19).TabIndex = 994;
		Label19.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Dock = (DockStyle)4;
		((Control)Label21).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label7 = Label21;
		location = new Point(856, 1);
		((Control)label7).Location = location;
		((Control)Label21).Name = "Label21";
		Label label8 = Label21;
		itemSize = new Size(1, 288);
		((Control)label8).Size = itemSize;
		((Control)Label21).TabIndex = 993;
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Label40).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label40).Cursor = Cursors.Hand;
		((Control)Label40).Dock = (DockStyle)1;
		((Control)Label40).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label40).ForeColor = Color.FromArgb(64, 64, 64);
		Label label9 = Label40;
		location = new Point(0, 0);
		((Control)label9).Location = location;
		((Control)Label40).Name = "Label40";
		Label label10 = Label40;
		itemSize = new Size(857, 1);
		((Control)label10).Size = itemSize;
		((Control)Label40).TabIndex = 992;
		Label40.Text = "-";
		Label40.TextAlign = (ContentAlignment)16;
		((Control)TableLayoutPanel1).Anchor = (AnchorStyles)13;
		TableLayoutPanel1.ColumnCount = 4;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel1.Controls.Add((Control)(object)Panel24, 0, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel39, 1, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel42, 2, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel45, 3, 0);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel1;
		location = new Point(0, 1);
		((Control)tableLayoutPanel).Location = location;
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel1;
		headerPadding = new Padding(0);
		((Control)tableLayoutPanel2).Margin = headerPadding;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel1.RowCount = 1;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)1, 96f));
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel1;
		itemSize = new Size(857, 96);
		((Control)tableLayoutPanel3).Size = itemSize;
		((Control)TableLayoutPanel1).TabIndex = 1042;
		((Control)Panel24).BackColor = Color.FromArgb(240, 40, 74);
		((Control)Panel24).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel24).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel24).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel24).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel24).Controls.Add((Control)(object)PictureBox17);
		((Control)Panel24).Controls.Add((Control)(object)Label26);
		((Control)Panel24).Controls.Add((Control)(object)Label27);
		((Control)Panel24).Controls.Add((Control)(object)Panel36);
		((Control)Panel24).Dock = (DockStyle)5;
		Panel panel7 = Panel24;
		location = new Point(6, 6);
		((Control)panel7).Location = location;
		Panel panel8 = Panel24;
		headerPadding = new Padding(6);
		((Control)panel8).Margin = headerPadding;
		((Control)Panel24).Name = "Panel24";
		Panel panel9 = Panel24;
		itemSize = new Size(202, 84);
		((Control)panel9).Size = itemSize;
		((Control)Panel24).TabIndex = 966;
		((Control)PictureBox4).Anchor = (AnchorStyles)10;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox3 = PictureBox4;
		location = new Point(192, 73);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox4 = PictureBox4;
		itemSize = new Size(10, 11);
		((Control)pictureBox4).Size = itemSize;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 955;
		PictureBox4.TabStop = false;
		((Control)PictureBox5).Anchor = (AnchorStyles)9;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox5 = PictureBox5;
		location = new Point(191, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox6 = PictureBox5;
		itemSize = new Size(11, 10);
		((Control)pictureBox6).Size = itemSize;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 954;
		PictureBox5.TabStop = false;
		((Control)PictureBox2).Anchor = (AnchorStyles)6;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox7 = PictureBox2;
		location = new Point(0, 74);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox8 = PictureBox2;
		itemSize = new Size(11, 10);
		((Control)pictureBox8).Size = itemSize;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 953;
		PictureBox2.TabStop = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox9 = PictureBox3;
		location = new Point(0, 0);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox10 = PictureBox3;
		itemSize = new Size(10, 11);
		((Control)pictureBox10).Size = itemSize;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 952;
		PictureBox3.TabStop = false;
		((Control)PictureBox17).Dock = (DockStyle)3;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox11 = PictureBox17;
		location = new Point(0, 0);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox12 = PictureBox17;
		itemSize = new Size(72, 84);
		((Control)pictureBox12).Size = itemSize;
		PictureBox17.SizeMode = (PictureBoxSizeMode)4;
		PictureBox17.TabIndex = 789;
		PictureBox17.TabStop = false;
		((Control)Label26).Anchor = (AnchorStyles)13;
		((Control)Label26).BackColor = Color.Transparent;
		((Control)Label26).Font = new Font("Segoe UI", 18f, (FontStyle)1);
		((Control)Label26).ForeColor = Color.White;
		Label label11 = Label26;
		location = new Point(72, 5);
		((Control)label11).Location = location;
		((Control)Label26).Name = "Label26";
		Label label12 = Label26;
		itemSize = new Size(131, 27);
		((Control)label12).Size = itemSize;
		((Control)Label26).TabIndex = 945;
		Label26.Text = "00.00";
		Label26.TextAlign = (ContentAlignment)32;
		((Control)Label27).Anchor = (AnchorStyles)13;
		((Control)Label27).BackColor = Color.Transparent;
		((Control)Label27).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label13 = Label27;
		location = new Point(72, 46);
		((Control)label13).Location = location;
		((Control)Label27).Name = "Label27";
		Label label14 = Label27;
		itemSize = new Size(131, 36);
		((Control)label14).Size = itemSize;
		((Control)Label27).TabIndex = 944;
		Label27.Text = "Total Ventes";
		Label27.TextAlign = (ContentAlignment)32;
		((Control)Panel36).Anchor = (AnchorStyles)13;
		((Control)Panel36).BackColor = Color.Transparent;
		((Control)Panel36).BackgroundImage = (Image)componentResourceManager.GetObject("Panel36.BackgroundImage");
		((Control)Panel36).ForeColor = Color.FromArgb(214, 214, 214);
		Panel panel10 = Panel36;
		location = new Point(59, 40);
		((Control)panel10).Location = location;
		((Control)Panel36).Name = "Panel36";
		Panel panel11 = Panel36;
		itemSize = new Size(195, 3);
		((Control)panel11).Size = itemSize;
		((Control)Panel36).TabIndex = 943;
		((Control)Panel39).BackColor = Color.FromArgb(255, 152, 1);
		((Control)Panel39).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel39).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel39).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel39).Controls.Add((Control)(object)PictureBox14);
		((Control)Panel39).Controls.Add((Control)(object)PictureBox20);
		((Control)Panel39).Controls.Add((Control)(object)Label28);
		((Control)Panel39).Controls.Add((Control)(object)Label29);
		((Control)Panel39).Controls.Add((Control)(object)Panel40);
		((Control)Panel39).Dock = (DockStyle)5;
		Panel panel12 = Panel39;
		location = new Point(220, 6);
		((Control)panel12).Location = location;
		Panel panel13 = Panel39;
		headerPadding = new Padding(6);
		((Control)panel13).Margin = headerPadding;
		((Control)Panel39).Name = "Panel39";
		Panel panel14 = Panel39;
		itemSize = new Size(202, 84);
		((Control)panel14).Size = itemSize;
		((Control)Panel39).TabIndex = 968;
		((Control)PictureBox10).Anchor = (AnchorStyles)10;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox13 = PictureBox10;
		location = new Point(192, 73);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox14 = PictureBox10;
		itemSize = new Size(10, 11);
		((Control)pictureBox14).Size = itemSize;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 955;
		PictureBox10.TabStop = false;
		((Control)PictureBox11).Anchor = (AnchorStyles)9;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox15 = PictureBox11;
		location = new Point(191, 0);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox16 = PictureBox11;
		itemSize = new Size(11, 10);
		((Control)pictureBox16).Size = itemSize;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 954;
		PictureBox11.TabStop = false;
		((Control)PictureBox12).Anchor = (AnchorStyles)6;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox17 = PictureBox12;
		location = new Point(0, 74);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox18 = PictureBox12;
		itemSize = new Size(11, 10);
		((Control)pictureBox18).Size = itemSize;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 953;
		PictureBox12.TabStop = false;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox19 = PictureBox14;
		location = new Point(0, 0);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox20 = PictureBox14;
		itemSize = new Size(10, 11);
		((Control)pictureBox20).Size = itemSize;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 952;
		PictureBox14.TabStop = false;
		((Control)PictureBox20).Dock = (DockStyle)3;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox21 = PictureBox20;
		location = new Point(0, 0);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox22 = PictureBox20;
		itemSize = new Size(72, 84);
		((Control)pictureBox22).Size = itemSize;
		PictureBox20.SizeMode = (PictureBoxSizeMode)4;
		PictureBox20.TabIndex = 789;
		PictureBox20.TabStop = false;
		((Control)Label28).Anchor = (AnchorStyles)13;
		((Control)Label28).BackColor = Color.Transparent;
		((Control)Label28).Font = new Font("Segoe UI", 18f, (FontStyle)1);
		((Control)Label28).ForeColor = Color.White;
		Label label15 = Label28;
		location = new Point(72, 5);
		((Control)label15).Location = location;
		((Control)Label28).Name = "Label28";
		Label label16 = Label28;
		itemSize = new Size(131, 27);
		((Control)label16).Size = itemSize;
		((Control)Label28).TabIndex = 946;
		Label28.Text = "00.00";
		Label28.TextAlign = (ContentAlignment)32;
		((Control)Label29).Anchor = (AnchorStyles)13;
		((Control)Label29).BackColor = Color.Transparent;
		((Control)Label29).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label29).ForeColor = Color.White;
		Label label17 = Label29;
		location = new Point(72, 46);
		((Control)label17).Location = location;
		((Control)Label29).Name = "Label29";
		Label label18 = Label29;
		itemSize = new Size(131, 36);
		((Control)label18).Size = itemSize;
		((Control)Label29).TabIndex = 945;
		Label29.Text = "Nombre Tickets\r\nde Vente";
		Label29.TextAlign = (ContentAlignment)32;
		((Control)Panel40).Anchor = (AnchorStyles)13;
		((Control)Panel40).BackColor = Color.Transparent;
		((Control)Panel40).BackgroundImage = (Image)componentResourceManager.GetObject("Panel40.BackgroundImage");
		((Control)Panel40).ForeColor = Color.FromArgb(214, 214, 214);
		Panel panel15 = Panel40;
		location = new Point(59, 40);
		((Control)panel15).Location = location;
		((Control)Panel40).Name = "Panel40";
		Panel panel16 = Panel40;
		itemSize = new Size(195, 3);
		((Control)panel16).Size = itemSize;
		((Control)Panel40).TabIndex = 943;
		((Control)Panel42).BackColor = Color.FromArgb(24, 119, 242);
		((Control)Panel42).Controls.Add((Control)(object)PictureBox23);
		((Control)Panel42).Controls.Add((Control)(object)PictureBox24);
		((Control)Panel42).Controls.Add((Control)(object)PictureBox25);
		((Control)Panel42).Controls.Add((Control)(object)PictureBox26);
		((Control)Panel42).Controls.Add((Control)(object)PictureBox21);
		((Control)Panel42).Controls.Add((Control)(object)Label30);
		((Control)Panel42).Controls.Add((Control)(object)Panel43);
		((Control)Panel42).Controls.Add((Control)(object)Label35);
		((Control)Panel42).Dock = (DockStyle)5;
		Panel panel17 = Panel42;
		location = new Point(434, 6);
		((Control)panel17).Location = location;
		Panel panel18 = Panel42;
		headerPadding = new Padding(6);
		((Control)panel18).Margin = headerPadding;
		((Control)Panel42).Name = "Panel42";
		Panel panel19 = Panel42;
		itemSize = new Size(202, 84);
		((Control)panel19).Size = itemSize;
		((Control)Panel42).TabIndex = 969;
		((Control)PictureBox23).Anchor = (AnchorStyles)10;
		PictureBox23.Image = (Image)componentResourceManager.GetObject("PictureBox23.Image");
		PictureBox pictureBox23 = PictureBox23;
		location = new Point(192, 73);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox23).Name = "PictureBox23";
		PictureBox pictureBox24 = PictureBox23;
		itemSize = new Size(10, 11);
		((Control)pictureBox24).Size = itemSize;
		PictureBox23.SizeMode = (PictureBoxSizeMode)2;
		PictureBox23.TabIndex = 955;
		PictureBox23.TabStop = false;
		((Control)PictureBox24).Anchor = (AnchorStyles)9;
		PictureBox24.Image = (Image)componentResourceManager.GetObject("PictureBox24.Image");
		PictureBox pictureBox25 = PictureBox24;
		location = new Point(191, 0);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox24).Name = "PictureBox24";
		PictureBox pictureBox26 = PictureBox24;
		itemSize = new Size(11, 10);
		((Control)pictureBox26).Size = itemSize;
		PictureBox24.SizeMode = (PictureBoxSizeMode)2;
		PictureBox24.TabIndex = 954;
		PictureBox24.TabStop = false;
		((Control)PictureBox25).Anchor = (AnchorStyles)6;
		PictureBox25.Image = (Image)componentResourceManager.GetObject("PictureBox25.Image");
		PictureBox pictureBox27 = PictureBox25;
		location = new Point(0, 74);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox25).Name = "PictureBox25";
		PictureBox pictureBox28 = PictureBox25;
		itemSize = new Size(11, 10);
		((Control)pictureBox28).Size = itemSize;
		PictureBox25.SizeMode = (PictureBoxSizeMode)2;
		PictureBox25.TabIndex = 953;
		PictureBox25.TabStop = false;
		PictureBox26.Image = (Image)componentResourceManager.GetObject("PictureBox26.Image");
		PictureBox pictureBox29 = PictureBox26;
		location = new Point(0, 0);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox26).Name = "PictureBox26";
		PictureBox pictureBox30 = PictureBox26;
		itemSize = new Size(10, 11);
		((Control)pictureBox30).Size = itemSize;
		PictureBox26.SizeMode = (PictureBoxSizeMode)2;
		PictureBox26.TabIndex = 952;
		PictureBox26.TabStop = false;
		((Control)PictureBox21).Dock = (DockStyle)3;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox pictureBox31 = PictureBox21;
		location = new Point(0, 0);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox pictureBox32 = PictureBox21;
		itemSize = new Size(72, 84);
		((Control)pictureBox32).Size = itemSize;
		PictureBox21.SizeMode = (PictureBoxSizeMode)4;
		PictureBox21.TabIndex = 789;
		PictureBox21.TabStop = false;
		((Control)Label30).Anchor = (AnchorStyles)13;
		((Control)Label30).BackColor = Color.Transparent;
		((Control)Label30).Font = new Font("Segoe UI", 18f, (FontStyle)1);
		((Control)Label30).ForeColor = Color.White;
		Label label19 = Label30;
		location = new Point(72, 5);
		((Control)label19).Location = location;
		((Control)Label30).Name = "Label30";
		Label label20 = Label30;
		itemSize = new Size(131, 27);
		((Control)label20).Size = itemSize;
		((Control)Label30).TabIndex = 947;
		Label30.Text = "00.00";
		Label30.TextAlign = (ContentAlignment)32;
		((Control)Panel43).Anchor = (AnchorStyles)13;
		((Control)Panel43).BackColor = Color.Transparent;
		((Control)Panel43).BackgroundImage = (Image)componentResourceManager.GetObject("Panel43.BackgroundImage");
		((Control)Panel43).ForeColor = Color.FromArgb(214, 214, 214);
		Panel panel20 = Panel43;
		location = new Point(59, 40);
		((Control)panel20).Location = location;
		((Control)Panel43).Name = "Panel43";
		Panel panel21 = Panel43;
		itemSize = new Size(195, 3);
		((Control)panel21).Size = itemSize;
		((Control)Panel43).TabIndex = 943;
		((Control)Label35).Anchor = (AnchorStyles)13;
		((Control)Label35).BackColor = Color.Transparent;
		((Control)Label35).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label35).ForeColor = Color.White;
		Label label21 = Label35;
		location = new Point(72, 49);
		((Control)label21).Location = location;
		((Control)Label35).Name = "Label35";
		Label label22 = Label35;
		itemSize = new Size(131, 36);
		((Control)label22).Size = itemSize;
		((Control)Label35).TabIndex = 946;
		Label35.Text = "Total Retour\r\nRemboursement";
		Label35.TextAlign = (ContentAlignment)32;
		Label35.UseCompatibleTextRendering = true;
		((Control)Panel45).BackColor = Color.FromArgb(42, 187, 167);
		((Control)Panel45).Controls.Add((Control)(object)PictureBox27);
		((Control)Panel45).Controls.Add((Control)(object)PictureBox28);
		((Control)Panel45).Controls.Add((Control)(object)PictureBox29);
		((Control)Panel45).Controls.Add((Control)(object)PictureBox30);
		((Control)Panel45).Controls.Add((Control)(object)PictureBox22);
		((Control)Panel45).Controls.Add((Control)(object)Label36);
		((Control)Panel45).Controls.Add((Control)(object)Label37);
		((Control)Panel45).Controls.Add((Control)(object)Panel46);
		((Control)Panel45).Dock = (DockStyle)5;
		Panel panel22 = Panel45;
		location = new Point(648, 6);
		((Control)panel22).Location = location;
		Panel panel23 = Panel45;
		headerPadding = new Padding(6);
		((Control)panel23).Margin = headerPadding;
		((Control)Panel45).Name = "Panel45";
		Panel panel24 = Panel45;
		itemSize = new Size(203, 84);
		((Control)panel24).Size = itemSize;
		((Control)Panel45).TabIndex = 970;
		((Control)PictureBox27).Anchor = (AnchorStyles)10;
		PictureBox27.Image = (Image)componentResourceManager.GetObject("PictureBox27.Image");
		PictureBox pictureBox33 = PictureBox27;
		location = new Point(192, 73);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox27).Name = "PictureBox27";
		PictureBox pictureBox34 = PictureBox27;
		itemSize = new Size(10, 11);
		((Control)pictureBox34).Size = itemSize;
		PictureBox27.SizeMode = (PictureBoxSizeMode)2;
		PictureBox27.TabIndex = 955;
		PictureBox27.TabStop = false;
		((Control)PictureBox28).Anchor = (AnchorStyles)9;
		PictureBox28.Image = (Image)componentResourceManager.GetObject("PictureBox28.Image");
		PictureBox pictureBox35 = PictureBox28;
		location = new Point(191, 0);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox28).Name = "PictureBox28";
		PictureBox pictureBox36 = PictureBox28;
		itemSize = new Size(11, 10);
		((Control)pictureBox36).Size = itemSize;
		PictureBox28.SizeMode = (PictureBoxSizeMode)2;
		PictureBox28.TabIndex = 954;
		PictureBox28.TabStop = false;
		((Control)PictureBox29).Anchor = (AnchorStyles)6;
		PictureBox29.Image = (Image)componentResourceManager.GetObject("PictureBox29.Image");
		PictureBox pictureBox37 = PictureBox29;
		location = new Point(0, 74);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox29).Name = "PictureBox29";
		PictureBox pictureBox38 = PictureBox29;
		itemSize = new Size(11, 10);
		((Control)pictureBox38).Size = itemSize;
		PictureBox29.SizeMode = (PictureBoxSizeMode)2;
		PictureBox29.TabIndex = 953;
		PictureBox29.TabStop = false;
		PictureBox30.Image = (Image)componentResourceManager.GetObject("PictureBox30.Image");
		PictureBox pictureBox39 = PictureBox30;
		location = new Point(0, 0);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox30).Name = "PictureBox30";
		PictureBox pictureBox40 = PictureBox30;
		itemSize = new Size(10, 11);
		((Control)pictureBox40).Size = itemSize;
		PictureBox30.SizeMode = (PictureBoxSizeMode)2;
		PictureBox30.TabIndex = 952;
		PictureBox30.TabStop = false;
		((Control)PictureBox22).Dock = (DockStyle)3;
		PictureBox22.Image = (Image)componentResourceManager.GetObject("PictureBox22.Image");
		PictureBox pictureBox41 = PictureBox22;
		location = new Point(0, 0);
		((Control)pictureBox41).Location = location;
		((Control)PictureBox22).Name = "PictureBox22";
		PictureBox pictureBox42 = PictureBox22;
		itemSize = new Size(72, 84);
		((Control)pictureBox42).Size = itemSize;
		PictureBox22.SizeMode = (PictureBoxSizeMode)4;
		PictureBox22.TabIndex = 789;
		PictureBox22.TabStop = false;
		((Control)Label36).Anchor = (AnchorStyles)13;
		((Control)Label36).BackColor = Color.Transparent;
		((Control)Label36).Font = new Font("Segoe UI", 18f, (FontStyle)1);
		((Control)Label36).ForeColor = Color.White;
		Label label23 = Label36;
		location = new Point(72, 5);
		((Control)label23).Location = location;
		((Control)Label36).Name = "Label36";
		Label label24 = Label36;
		itemSize = new Size(131, 27);
		((Control)label24).Size = itemSize;
		((Control)Label36).TabIndex = 947;
		Label36.Text = "00.00";
		Label36.TextAlign = (ContentAlignment)32;
		((Control)Label37).Anchor = (AnchorStyles)13;
		((Control)Label37).BackColor = Color.Transparent;
		((Control)Label37).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label37).ForeColor = Color.White;
		Label label25 = Label37;
		location = new Point(72, 46);
		((Control)label25).Location = location;
		((Control)Label37).Name = "Label37";
		Label label26 = Label37;
		itemSize = new Size(131, 36);
		((Control)label26).Size = itemSize;
		((Control)Label37).TabIndex = 946;
		Label37.Text = "Total Retour\r\nAvoir";
		Label37.TextAlign = (ContentAlignment)32;
		((Control)Panel46).Anchor = (AnchorStyles)13;
		((Control)Panel46).BackColor = Color.Transparent;
		((Control)Panel46).BackgroundImage = (Image)componentResourceManager.GetObject("Panel46.BackgroundImage");
		((Control)Panel46).ForeColor = Color.FromArgb(214, 214, 214);
		Panel panel25 = Panel46;
		location = new Point(59, 40);
		((Control)panel25).Location = location;
		((Control)Panel46).Name = "Panel46";
		Panel panel26 = Panel46;
		itemSize = new Size(195, 3);
		((Control)panel26).Size = itemSize;
		((Control)Panel46).TabIndex = 943;
		((Control)Panel1).Anchor = (AnchorStyles)13;
		((Control)Panel1).Controls.Add((Control)(object)Panel5);
		((Control)Panel1).Controls.Add((Control)(object)Panel6);
		((Control)Panel1).Controls.Add((Control)(object)Panel8);
		Panel panel27 = Panel1;
		location = new Point(3, 3);
		((Control)panel27).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel28 = Panel1;
		itemSize = new Size(861, 335);
		((Control)panel28).Size = itemSize;
		((Control)Panel1).TabIndex = 1057;
		((Control)Panel5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel5).Controls.Add((Control)(object)Label9);
		((Control)Panel5).Controls.Add((Control)(object)Label14);
		((Control)Panel5).Controls.Add((Control)(object)TextBox_ANNEE);
		((Control)Panel5).Controls.Add((Control)(object)Label16);
		((Control)Panel5).Controls.Add((Control)(object)Button_GO);
		((Control)Panel5).Controls.Add((Control)(object)List_COLOR);
		((Control)Panel5).Controls.Add((Control)(object)DataGrid_STATISTIQUE);
		((Control)Panel5).Dock = (DockStyle)1;
		Panel panel29 = Panel5;
		location = new Point(0, 0);
		((Control)panel29).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel30 = Panel5;
		itemSize = new Size(861, 43);
		((Control)panel30).Size = itemSize;
		((Control)Panel5).TabIndex = 998;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Cursor = Cursors.Hand;
		Label9.FlatStyle = (FlatStyle)0;
		((Control)Label9).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.White;
		Label label27 = Label9;
		location = new Point(294, 14);
		((Control)label27).Location = location;
		((Control)Label9).Name = "Label9";
		Label label28 = Label9;
		itemSize = new Size(14, 15);
		((Control)label28).Size = itemSize;
		((Control)Label9).TabIndex = 1147;
		Label9.Text = "-";
		Label9.TextAlign = (ContentAlignment)16;
		Label9.UseCompatibleTextRendering = true;
		((Control)Label14).BackColor = Color.Transparent;
		((Control)Label14).Cursor = Cursors.Hand;
		Label14.FlatStyle = (FlatStyle)0;
		((Control)Label14).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Label14).ForeColor = Color.White;
		Label label29 = Label14;
		location = new Point(309, 14);
		((Control)label29).Location = location;
		((Control)Label14).Name = "Label14";
		Label label30 = Label14;
		itemSize = new Size(14, 15);
		((Control)label30).Size = itemSize;
		((Control)Label14).TabIndex = 1146;
		Label14.Text = "+";
		Label14.TextAlign = (ContentAlignment)16;
		Label14.UseCompatibleTextRendering = true;
		((TextBoxBase)TextBox_ANNEE).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)TextBox_ANNEE).BorderStyle = (BorderStyle)0;
		((Control)TextBox_ANNEE).Font = new Font("Segoe UI", 14.25f, (FontStyle)1);
		((TextBoxBase)TextBox_ANNEE).ForeColor = Color.White;
		TextBox textBox_ANNEE = TextBox_ANNEE;
		location = new Point(239, 10);
		((Control)textBox_ANNEE).Location = location;
		((Control)TextBox_ANNEE).Name = "TextBox_ANNEE";
		((TextBoxBase)TextBox_ANNEE).ReadOnly = true;
		TextBox textBox_ANNEE2 = TextBox_ANNEE;
		itemSize = new Size(50, 22);
		((Control)textBox_ANNEE2).Size = itemSize;
		((Control)TextBox_ANNEE).TabIndex = 1145;
		TextBox_ANNEE.Text = "2022";
		((Control)Label16).BackColor = Color.Transparent;
		((Control)Label16).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Label16).ForeColor = Color.White;
		Label label31 = Label16;
		location = new Point(-1, 8);
		((Control)label31).Location = location;
		((Control)Label16).Name = "Label16";
		Label label32 = Label16;
		itemSize = new Size(300, 26);
		((Control)label32).Size = itemSize;
		((Control)Label16).TabIndex = 1144;
		Label16.Text = "Ventes Mensuelles de l'année";
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Button_GO).Anchor = (AnchorStyles)9;
		((ButtonBase)Button_GO).BackColor = Color.Transparent;
		((Control)Button_GO).Cursor = Cursors.Hand;
		((Control)Button_GO).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button_GO).ForeColor = Color.Black;
		((ButtonBase)Button_GO).Image = (Image)componentResourceManager.GetObject("Button_GO.Image");
		((ButtonBase)Button_GO).ImageAlign = (ContentAlignment)16;
		Button button_GO = Button_GO;
		location = new Point(736, 2);
		((Control)button_GO).Location = location;
		Button button_GO2 = Button_GO;
		headerPadding = new Padding(0);
		((Control)button_GO2).Margin = headerPadding;
		((Control)Button_GO).Name = "Button_GO";
		Button button_GO3 = Button_GO;
		itemSize = new Size(123, 39);
		((Control)button_GO3).Size = itemSize;
		((Control)Button_GO).TabIndex = 0;
		((ButtonBase)Button_GO).Text = "CHARGER";
		((ButtonBase)Button_GO).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_GO).UseVisualStyleBackColor = false;
		((ListControl)List_COLOR).FormattingEnabled = true;
		List_COLOR.Items.AddRange(new object[128]
		{
			"#FF6668", "#BAE591", "#56A8FB", "#FECC58", "#F5669D", "#FC9264", "#5DC0C4", "#BFBFBF", "#FF1493", "#FFD700",
			"#9B59B6", "#FFFF00", "#FFFFFF", "#808000", "#7FFF00", "#00BFFF", "#FF6347", "#34495E", "#FF00FF", "#FFA500",
			"#2ECC71", "#E67E22", "#3498DB", "#95A5A6", "#FF1493", "#FFD700", "#9B59B6", "#FFFF00", "#FFFFFF", "#808000",
			"#7FFF00", "#00BFFF", "#FF6347", "#34495E", "#FF00FF", "#FFA500", "#2ECC71", "#E67E22", "#3498DB", "#95A5A6",
			"#FF1493", "#FFD700", "#9B59B6", "#FFFF00", "#FFFFFF", "#808000", "#7FFF00", "#00BFFF", "#FF6347", "#34495E",
			"#FF00FF", "#FFA500", "#2ECC71", "#E67E22", "#3498DB", "#95A5A6", "#FF1493", "#FFD700", "#9B59B6", "#FFFF00",
			"#FFFFFF", "#808000", "#7FFF00", "#00BFFF", "#FF6347", "#34495E", "#FF00FF", "#FFA500", "#2ECC71", "#E67E22",
			"#3498DB", "#95A5A6", "#FF1493", "#FFD700", "#9B59B6", "#FFFF00", "#FFFFFF", "#808000", "#7FFF00", "#00BFFF",
			"#FF6347", "#34495E", "#FF00FF", "#FFA500", "#2ECC71", "#E67E22", "#3498DB", "#95A5A6", "#FF1493", "#FFD700",
			"#9B59B6", "#FFFF00", "#FFFFFF", "#808000", "#7FFF00", "#00BFFF", "#FF6347", "#34495E", "#FF00FF", "#FFA500",
			"#2ECC71", "#E67E22", "#3498DB", "#95A5A6", "#FF1493", "#FFD700", "#9B59B6", "#FFFF00", "#FFFFFF", "#808000",
			"#7FFF00", "#00BFFF", "#FF6347", "#34495E", "#FF00FF", "#FFA500", "#2ECC71", "#E67E22", "#3498DB", "#95A5A6",
			"#FF1493", "#FFD700", "#9B59B6", "#FFFF00", "#FFFFFF", "#808000", "#7FFF00", "#00BFFF"
		});
		ListBox list_COLOR = List_COLOR;
		location = new Point(679, 5);
		((Control)list_COLOR).Location = location;
		((Control)List_COLOR).Name = "List_COLOR";
		ListBox list_COLOR2 = List_COLOR;
		itemSize = new Size(58, 30);
		((Control)list_COLOR2).Size = itemSize;
		((Control)List_COLOR).TabIndex = 957;
		((Control)List_COLOR).Visible = false;
		DataGrid_STATISTIQUE.AllowUserToAddRows = false;
		DataGrid_STATISTIQUE.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_STATISTIQUE.BackgroundColor = Color.White;
		DataGrid_STATISTIQUE.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_STATISTIQUE.EditMode = (DataGridViewEditMode)4;
		DataGrid_STATISTIQUE.EnableHeadersVisualStyles = false;
		DataGridView dataGrid_STATISTIQUE = DataGrid_STATISTIQUE;
		location = new Point(509, 2);
		((Control)dataGrid_STATISTIQUE).Location = location;
		((Control)DataGrid_STATISTIQUE).Name = "DataGrid_STATISTIQUE";
		DataGrid_STATISTIQUE.RowHeadersVisible = false;
		DataGrid_STATISTIQUE.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGrid_STATISTIQUE2 = DataGrid_STATISTIQUE;
		itemSize = new Size(163, 38);
		((Control)dataGrid_STATISTIQUE2).Size = itemSize;
		((Control)DataGrid_STATISTIQUE).TabIndex = 956;
		((Control)DataGrid_STATISTIQUE).Visible = false;
		((Control)Panel6).Anchor = (AnchorStyles)13;
		((Control)Panel6).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel6).Controls.Add((Control)(object)Label31);
		((Control)Panel6).Controls.Add((Control)(object)Label32);
		((Control)Panel6).Controls.Add((Control)(object)Chart1);
		((Control)Panel6).Controls.Add((Control)(object)Label33);
		((Control)Panel6).Controls.Add((Control)(object)Label34);
		Panel panel31 = Panel6;
		location = new Point(3, 45);
		((Control)panel31).Location = location;
		((Control)Panel6).Name = "Panel6";
		Panel panel32 = Panel6;
		itemSize = new Size(536, 289);
		((Control)panel32).Size = itemSize;
		((Control)Panel6).TabIndex = 994;
		((Control)Label31).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label31).Cursor = Cursors.Hand;
		((Control)Label31).Dock = (DockStyle)2;
		((Control)Label31).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label31).ForeColor = Color.White;
		Label label33 = Label31;
		location = new Point(1, 288);
		((Control)label33).Location = location;
		((Control)Label31).Name = "Label31";
		Label label34 = Label31;
		itemSize = new Size(534, 1);
		((Control)label34).Size = itemSize;
		((Control)Label31).TabIndex = 995;
		Label31.TextAlign = (ContentAlignment)16;
		((Control)Label32).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label32).Cursor = Cursors.Hand;
		((Control)Label32).Dock = (DockStyle)3;
		((Control)Label32).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label32).ForeColor = Color.White;
		Label label35 = Label32;
		location = new Point(0, 1);
		((Control)label35).Location = location;
		((Control)Label32).Name = "Label32";
		Label label36 = Label32;
		itemSize = new Size(1, 288);
		((Control)label36).Size = itemSize;
		((Control)Label32).TabIndex = 994;
		Label32.TextAlign = (ContentAlignment)16;
		val3.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart1.ChartAreas).Add(val3);
		((Control)Chart1).Dock = (DockStyle)5;
		val4.Name = "Legend1";
		((Collection<Legend>)(object)Chart1.Legends).Add(val4);
		Chart chart3 = Chart1;
		location = new Point(0, 1);
		((Control)chart3).Location = location;
		Chart chart4 = Chart1;
		headerPadding = new Padding(0);
		((Control)chart4).Margin = headerPadding;
		((Control)Chart1).Name = "Chart1";
		Chart chart5 = Chart1;
		itemSize = new Size(535, 288);
		chart5.Size = itemSize;
		((Control)Chart1).TabIndex = 955;
		((Control)Chart1).Text = "Chart2";
		((Control)Label33).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label33).Cursor = Cursors.Hand;
		((Control)Label33).Dock = (DockStyle)4;
		((Control)Label33).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label33).ForeColor = Color.White;
		Label label37 = Label33;
		location = new Point(535, 1);
		((Control)label37).Location = location;
		((Control)Label33).Name = "Label33";
		Label label38 = Label33;
		itemSize = new Size(1, 288);
		((Control)label38).Size = itemSize;
		((Control)Label33).TabIndex = 993;
		Label33.TextAlign = (ContentAlignment)16;
		((Control)Label34).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label34).Cursor = Cursors.Hand;
		((Control)Label34).Dock = (DockStyle)1;
		((Control)Label34).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label34).ForeColor = Color.FromArgb(64, 64, 64);
		Label label39 = Label34;
		location = new Point(0, 0);
		((Control)label39).Location = location;
		((Control)Label34).Name = "Label34";
		Label label40 = Label34;
		itemSize = new Size(536, 1);
		((Control)label40).Size = itemSize;
		((Control)Label34).TabIndex = 992;
		Label34.Text = "-";
		Label34.TextAlign = (ContentAlignment)16;
		((Control)Panel8).Anchor = (AnchorStyles)9;
		((Control)Panel8).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel8).Controls.Add((Control)(object)Label_TOP_MOIS_CHIFFRE);
		((Control)Panel8).Controls.Add((Control)(object)Label_TOP_MOIS);
		((Control)Panel8).Controls.Add((Control)(object)Label_CHIFFRE_ANNEE);
		((Control)Panel8).Controls.Add((Control)(object)Label15);
		((Control)Panel8).Controls.Add((Control)(object)Label18);
		((Control)Panel8).Controls.Add((Control)(object)Label22);
		((Control)Panel8).Controls.Add((Control)(object)Label23);
		((Control)Panel8).Controls.Add((Control)(object)Label24);
		((Control)Panel8).Controls.Add((Control)(object)Label25);
		Panel panel33 = Panel8;
		location = new Point(544, 45);
		((Control)panel33).Location = location;
		((Control)Panel8).Name = "Panel8";
		Panel panel34 = Panel8;
		itemSize = new Size(315, 289);
		((Control)panel34).Size = itemSize;
		((Control)Panel8).TabIndex = 995;
		((Control)Label_TOP_MOIS_CHIFFRE).BackColor = Color.Transparent;
		((Control)Label_TOP_MOIS_CHIFFRE).Font = new Font("Segoe UI", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP_MOIS_CHIFFRE).ForeColor = Color.Black;
		Label label_TOP_MOIS_CHIFFRE = Label_TOP_MOIS_CHIFFRE;
		location = new Point(3, 248);
		((Control)label_TOP_MOIS_CHIFFRE).Location = location;
		Label label_TOP_MOIS_CHIFFRE2 = Label_TOP_MOIS_CHIFFRE;
		headerPadding = new Padding(0);
		((Control)label_TOP_MOIS_CHIFFRE2).Margin = headerPadding;
		((Control)Label_TOP_MOIS_CHIFFRE).Name = "Label_TOP_MOIS_CHIFFRE";
		Label label_TOP_MOIS_CHIFFRE3 = Label_TOP_MOIS_CHIFFRE;
		itemSize = new Size(300, 30);
		((Control)label_TOP_MOIS_CHIFFRE3).Size = itemSize;
		((Control)Label_TOP_MOIS_CHIFFRE).TabIndex = 999;
		Label_TOP_MOIS_CHIFFRE.Text = "0";
		Label_TOP_MOIS_CHIFFRE.TextAlign = (ContentAlignment)16;
		Label_TOP_MOIS_CHIFFRE.UseCompatibleTextRendering = true;
		((Control)Label_TOP_MOIS).BackColor = Color.Transparent;
		((Control)Label_TOP_MOIS).Font = new Font("Segoe UI", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP_MOIS).ForeColor = Color.Black;
		Label label_TOP_MOIS = Label_TOP_MOIS;
		location = new Point(3, 210);
		((Control)label_TOP_MOIS).Location = location;
		Label label_TOP_MOIS2 = Label_TOP_MOIS;
		headerPadding = new Padding(0);
		((Control)label_TOP_MOIS2).Margin = headerPadding;
		((Control)Label_TOP_MOIS).Name = "Label_TOP_MOIS";
		Label label_TOP_MOIS3 = Label_TOP_MOIS;
		itemSize = new Size(300, 30);
		((Control)label_TOP_MOIS3).Size = itemSize;
		((Control)Label_TOP_MOIS).TabIndex = 998;
		Label_TOP_MOIS.Text = "-";
		Label_TOP_MOIS.TextAlign = (ContentAlignment)16;
		Label_TOP_MOIS.UseCompatibleTextRendering = true;
		((Control)Label_CHIFFRE_ANNEE).BackColor = Color.White;
		((Control)Label_CHIFFRE_ANNEE).Font = new Font("Segoe UI", 60f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_CHIFFRE_ANNEE).ForeColor = Color.Black;
		Label label_CHIFFRE_ANNEE = Label_CHIFFRE_ANNEE;
		location = new Point(7, 40);
		((Control)label_CHIFFRE_ANNEE).Location = location;
		Label label_CHIFFRE_ANNEE2 = Label_CHIFFRE_ANNEE;
		headerPadding = new Padding(0);
		((Control)label_CHIFFRE_ANNEE2).Margin = headerPadding;
		((Control)Label_CHIFFRE_ANNEE).Name = "Label_CHIFFRE_ANNEE";
		Label label_CHIFFRE_ANNEE3 = Label_CHIFFRE_ANNEE;
		itemSize = new Size(300, 117);
		((Control)label_CHIFFRE_ANNEE3).Size = itemSize;
		((Control)Label_CHIFFRE_ANNEE).TabIndex = 997;
		Label_CHIFFRE_ANNEE.Text = "0";
		Label_CHIFFRE_ANNEE.TextAlign = (ContentAlignment)16;
		Label_CHIFFRE_ANNEE.UseCompatibleTextRendering = true;
		((Control)Label15).BackColor = Color.Transparent;
		((Control)Label15).Font = new Font("Segoe UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.Black;
		Label label41 = Label15;
		location = new Point(3, 166);
		((Control)label41).Location = location;
		((Control)Label15).Name = "Label15";
		Label label42 = Label15;
		itemSize = new Size(213, 36);
		((Control)label42).Size = itemSize;
		((Control)Label15).TabIndex = 996;
		Label15.Text = "Top Mois :";
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.Black;
		Label label43 = Label18;
		location = new Point(3, 1);
		((Control)label43).Location = location;
		((Control)Label18).Name = "Label18";
		Label label44 = Label18;
		itemSize = new Size(213, 36);
		((Control)label44).Size = itemSize;
		((Control)Label18).TabIndex = 996;
		Label18.Text = "Total Ventes :";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Label22).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label22).Cursor = Cursors.Hand;
		((Control)Label22).Dock = (DockStyle)2;
		((Control)Label22).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label45 = Label22;
		location = new Point(1, 288);
		((Control)label45).Location = location;
		((Control)Label22).Name = "Label22";
		Label label46 = Label22;
		itemSize = new Size(313, 1);
		((Control)label46).Size = itemSize;
		((Control)Label22).TabIndex = 995;
		Label22.TextAlign = (ContentAlignment)16;
		((Control)Label23).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label23).Cursor = Cursors.Hand;
		((Control)Label23).Dock = (DockStyle)3;
		((Control)Label23).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label47 = Label23;
		location = new Point(0, 1);
		((Control)label47).Location = location;
		((Control)Label23).Name = "Label23";
		Label label48 = Label23;
		itemSize = new Size(1, 288);
		((Control)label48).Size = itemSize;
		((Control)Label23).TabIndex = 994;
		Label23.TextAlign = (ContentAlignment)16;
		((Control)Label24).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label24).Cursor = Cursors.Hand;
		((Control)Label24).Dock = (DockStyle)4;
		((Control)Label24).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label24).ForeColor = Color.White;
		Label label49 = Label24;
		location = new Point(314, 1);
		((Control)label49).Location = location;
		((Control)Label24).Name = "Label24";
		Label label50 = Label24;
		itemSize = new Size(1, 288);
		((Control)label50).Size = itemSize;
		((Control)Label24).TabIndex = 993;
		Label24.TextAlign = (ContentAlignment)16;
		((Control)Label25).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label25).Cursor = Cursors.Hand;
		((Control)Label25).Dock = (DockStyle)1;
		((Control)Label25).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label25).ForeColor = Color.FromArgb(64, 64, 64);
		Label label51 = Label25;
		location = new Point(0, 0);
		((Control)label51).Location = location;
		((Control)Label25).Name = "Label25";
		Label label52 = Label25;
		itemSize = new Size(315, 1);
		((Control)label52).Size = itemSize;
		((Control)Label25).TabIndex = 992;
		Label25.Text = "-";
		Label25.TextAlign = (ContentAlignment)16;
		TabPage4.BackColor = Color.White;
		((Control)TabPage4).Controls.Add((Control)(object)Panel2);
		TabPage tabPage4 = TabPage4;
		location = new Point(154, 4);
		tabPage4.Location = location;
		((Control)TabPage4).Name = "TabPage4";
		TabPage tabPage5 = TabPage4;
		itemSize = new Size(867, 684);
		((Control)tabPage5).Size = itemSize;
		TabPage4.TabIndex = 5;
		TabPage4.Text = "Top Caissier";
		((Control)Panel2).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel2).Dock = (DockStyle)5;
		Panel panel35 = Panel2;
		location = new Point(0, 0);
		((Control)panel35).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel36 = Panel2;
		itemSize = new Size(867, 684);
		((Control)panel36).Size = itemSize;
		((Control)Panel2).TabIndex = 1052;
		TableLayoutPanel2.ColumnCount = 1;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.Controls.Add((Control)(object)Panel21, 0, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Panel20, 0, 0);
		((Control)TableLayoutPanel2).Dock = (DockStyle)5;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel2;
		location = new Point(0, 0);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel2.RowCount = 2;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel2;
		itemSize = new Size(867, 684);
		((Control)tableLayoutPanel5).Size = itemSize;
		((Control)TableLayoutPanel2).TabIndex = 1003;
		((Control)Panel21).Controls.Add((Control)(object)Panel32);
		((Control)Panel21).Controls.Add((Control)(object)Panel17);
		((Control)Panel21).Controls.Add((Control)(object)Panel19);
		((Control)Panel21).Dock = (DockStyle)5;
		Panel panel37 = Panel21;
		location = new Point(3, 345);
		((Control)panel37).Location = location;
		((Control)Panel21).Name = "Panel21";
		Panel panel38 = Panel21;
		itemSize = new Size(861, 336);
		((Control)panel38).Size = itemSize;
		((Control)Panel21).TabIndex = 1;
		((Control)Panel32).Anchor = (AnchorStyles)11;
		((Control)Panel32).BackColor = Color.White;
		((Control)Panel32).Controls.Add((Control)(object)Label_VENDEUR_TOP);
		((Control)Panel32).Controls.Add((Control)(object)PictureBox15);
		Panel panel39 = Panel32;
		location = new Point(586, 49);
		((Control)panel39).Location = location;
		((Control)Panel32).Name = "Panel32";
		Panel panel40 = Panel32;
		itemSize = new Size(272, 286);
		((Control)panel40).Size = itemSize;
		((Control)Panel32).TabIndex = 993;
		((Control)Panel32).Visible = false;
		((Control)Label_VENDEUR_TOP).Anchor = (AnchorStyles)14;
		((Control)Label_VENDEUR_TOP).Font = new Font("Tahoma", 15f, (FontStyle)1);
		Label label_VENDEUR_TOP = Label_VENDEUR_TOP;
		location = new Point(3, 229);
		((Control)label_VENDEUR_TOP).Location = location;
		((Control)Label_VENDEUR_TOP).Name = "Label_VENDEUR_TOP";
		Label label_VENDEUR_TOP2 = Label_VENDEUR_TOP;
		itemSize = new Size(266, 56);
		((Control)label_VENDEUR_TOP2).Size = itemSize;
		((Control)Label_VENDEUR_TOP).TabIndex = 1;
		Label_VENDEUR_TOP.Text = "-";
		Label_VENDEUR_TOP.TextAlign = (ContentAlignment)32;
		((Control)PictureBox15).Anchor = (AnchorStyles)15;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox43 = PictureBox15;
		location = new Point(46, 3);
		((Control)pictureBox43).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox44 = PictureBox15;
		itemSize = new Size(179, 223);
		((Control)pictureBox44).Size = itemSize;
		PictureBox15.SizeMode = (PictureBoxSizeMode)4;
		PictureBox15.TabIndex = 0;
		PictureBox15.TabStop = false;
		((Control)Panel17).Anchor = (AnchorStyles)15;
		((Control)Panel17).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel17).Controls.Add((Control)(object)Label38);
		((Control)Panel17).Controls.Add((Control)(object)Label39);
		((Control)Panel17).Controls.Add((Control)(object)Label41);
		((Control)Panel17).Controls.Add((Control)(object)Chart4);
		((Control)Panel17).Controls.Add((Control)(object)Label42);
		Panel panel41 = Panel17;
		location = new Point(4, 49);
		((Control)panel41).Location = location;
		((Control)Panel17).Name = "Panel17";
		Panel panel42 = Panel17;
		itemSize = new Size(574, 281);
		((Control)panel42).Size = itemSize;
		((Control)Panel17).TabIndex = 1000;
		((Control)Label38).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label38).Cursor = Cursors.Hand;
		((Control)Label38).Dock = (DockStyle)2;
		((Control)Label38).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label38).ForeColor = Color.White;
		Label label53 = Label38;
		location = new Point(1, 280);
		((Control)label53).Location = location;
		((Control)Label38).Name = "Label38";
		Label label54 = Label38;
		itemSize = new Size(572, 1);
		((Control)label54).Size = itemSize;
		((Control)Label38).TabIndex = 995;
		Label38.TextAlign = (ContentAlignment)16;
		((Control)Label39).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label39).Cursor = Cursors.Hand;
		((Control)Label39).Dock = (DockStyle)3;
		((Control)Label39).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label39).ForeColor = Color.White;
		Label label55 = Label39;
		location = new Point(0, 1);
		((Control)label55).Location = location;
		((Control)Label39).Name = "Label39";
		Label label56 = Label39;
		itemSize = new Size(1, 280);
		((Control)label56).Size = itemSize;
		((Control)Label39).TabIndex = 994;
		Label39.TextAlign = (ContentAlignment)16;
		((Control)Label41).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label41).Cursor = Cursors.Hand;
		((Control)Label41).Dock = (DockStyle)4;
		((Control)Label41).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label41).ForeColor = Color.White;
		Label label57 = Label41;
		location = new Point(573, 1);
		((Control)label57).Location = location;
		((Control)Label41).Name = "Label41";
		Label label58 = Label41;
		itemSize = new Size(1, 280);
		((Control)label58).Size = itemSize;
		((Control)Label41).TabIndex = 993;
		Label41.TextAlign = (ContentAlignment)16;
		val5.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart4.ChartAreas).Add(val5);
		((Control)Chart4).Dock = (DockStyle)5;
		val6.Name = "Legend1";
		((Collection<Legend>)(object)Chart4.Legends).Add(val6);
		Chart chart6 = Chart4;
		location = new Point(0, 1);
		((Control)chart6).Location = location;
		((Control)Chart4).Name = "Chart4";
		Chart chart7 = Chart4;
		itemSize = new Size(574, 280);
		chart7.Size = itemSize;
		((Control)Chart4).TabIndex = 989;
		((Control)Chart4).Text = "Chart4";
		((Control)Label42).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label42).Cursor = Cursors.Hand;
		((Control)Label42).Dock = (DockStyle)1;
		((Control)Label42).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label42).ForeColor = Color.FromArgb(64, 64, 64);
		Label label59 = Label42;
		location = new Point(0, 0);
		((Control)label59).Location = location;
		((Control)Label42).Name = "Label42";
		Label label60 = Label42;
		itemSize = new Size(574, 1);
		((Control)label60).Size = itemSize;
		((Control)Label42).TabIndex = 992;
		Label42.Text = "-";
		Label42.TextAlign = (ContentAlignment)16;
		((Control)Panel19).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel19).Controls.Add((Control)(object)Label2);
		((Control)Panel19).Controls.Add((Control)(object)Label3);
		((Control)Panel19).Controls.Add((Control)(object)Button5);
		((Control)Panel19).Controls.Add((Control)(object)DateTimePicker9);
		((Control)Panel19).Controls.Add((Control)(object)PictureBox16);
		((Control)Panel19).Controls.Add((Control)(object)DateTimePicker10);
		((Control)Panel19).Dock = (DockStyle)1;
		Panel panel43 = Panel19;
		location = new Point(0, 0);
		((Control)panel43).Location = location;
		((Control)Panel19).Name = "Panel19";
		Panel panel44 = Panel19;
		itemSize = new Size(861, 43);
		((Control)panel44).Size = itemSize;
		((Control)Panel19).TabIndex = 999;
		((Control)Label2).Anchor = (AnchorStyles)9;
		((Control)Label2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label2).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label61 = Label2;
		location = new Point(366, 8);
		((Control)label61).Location = location;
		((Control)Label2).Name = "Label2";
		Label label62 = Label2;
		itemSize = new Size(68, 26);
		((Control)label62).Size = itemSize;
		((Control)Label2).TabIndex = 1052;
		Label2.Text = "Période";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label3).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label3).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label63 = Label3;
		location = new Point(0, 8);
		((Control)label63).Location = location;
		((Control)Label3).Name = "Label3";
		Label label64 = Label3;
		itemSize = new Size(346, 26);
		((Control)label64).Size = itemSize;
		((Control)Label3).TabIndex = 997;
		Label3.Text = "Top Vendeur";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Button5).Anchor = (AnchorStyles)9;
		((ButtonBase)Button5).BackColor = Color.Transparent;
		((Control)Button5).Cursor = Cursors.Hand;
		((Control)Button5).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button5).ForeColor = Color.Black;
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		((ButtonBase)Button5).ImageAlign = (ContentAlignment)16;
		Button button4 = Button5;
		location = new Point(733, 2);
		((Control)button4).Location = location;
		Button button5 = Button5;
		headerPadding = new Padding(0);
		((Control)button5).Margin = headerPadding;
		((Control)Button5).Name = "Button5";
		Button button6 = Button5;
		itemSize = new Size(123, 39);
		((Control)button6).Size = itemSize;
		((Control)Button5).TabIndex = 1046;
		((ButtonBase)Button5).Text = "CHARGER";
		((ButtonBase)Button5).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		((Control)DateTimePicker9).Anchor = (AnchorStyles)9;
		DateTimePicker9.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker9).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker9.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker6 = DateTimePicker9;
		location = new Point(440, 8);
		((Control)dateTimePicker6).Location = location;
		((Control)DateTimePicker9).Name = "DateTimePicker9";
		DateTimePicker dateTimePicker7 = DateTimePicker9;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker7).Size = itemSize;
		((Control)DateTimePicker9).TabIndex = 1038;
		DateTimePicker dateTimePicker8 = DateTimePicker9;
		value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker8.Value = value;
		((Control)PictureBox16).Anchor = (AnchorStyles)9;
		((Control)PictureBox16).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox45 = PictureBox16;
		location = new Point(562, 8);
		((Control)pictureBox45).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox46 = PictureBox16;
		itemSize = new Size(35, 26);
		((Control)pictureBox46).Size = itemSize;
		PictureBox16.SizeMode = (PictureBoxSizeMode)4;
		PictureBox16.TabIndex = 1040;
		PictureBox16.TabStop = false;
		((Control)DateTimePicker10).Anchor = (AnchorStyles)9;
		DateTimePicker10.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker10).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker10.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker9 = DateTimePicker10;
		location = new Point(597, 8);
		((Control)dateTimePicker9).Location = location;
		((Control)DateTimePicker10).Name = "DateTimePicker10";
		DateTimePicker dateTimePicker10 = DateTimePicker10;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker10).Size = itemSize;
		((Control)DateTimePicker10).TabIndex = 1039;
		((Control)Panel20).Controls.Add((Control)(object)Panel22);
		((Control)Panel20).Controls.Add((Control)(object)Panel23);
		((Control)Panel20).Controls.Add((Control)(object)Panel25);
		((Control)Panel20).Dock = (DockStyle)5;
		Panel panel45 = Panel20;
		location = new Point(3, 3);
		((Control)panel45).Location = location;
		((Control)Panel20).Name = "Panel20";
		Panel panel46 = Panel20;
		itemSize = new Size(861, 336);
		((Control)panel46).Size = itemSize;
		((Control)Panel20).TabIndex = 0;
		((Control)Panel22).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel22).Controls.Add((Control)(object)Label48);
		((Control)Panel22).Controls.Add((Control)(object)Label43);
		((Control)Panel22).Controls.Add((Control)(object)Button9);
		((Control)Panel22).Controls.Add((Control)(object)DateTimePicker13);
		((Control)Panel22).Controls.Add((Control)(object)PictureBox31);
		((Control)Panel22).Controls.Add((Control)(object)DateTimePicker14);
		((Control)Panel22).Dock = (DockStyle)1;
		Panel panel47 = Panel22;
		location = new Point(0, 0);
		((Control)panel47).Location = location;
		((Control)Panel22).Name = "Panel22";
		Panel panel48 = Panel22;
		itemSize = new Size(861, 43);
		((Control)panel48).Size = itemSize;
		((Control)Panel22).TabIndex = 1002;
		((Control)Label48).Anchor = (AnchorStyles)9;
		((Control)Label48).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label48).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label48).ForeColor = Color.White;
		Label label65 = Label48;
		location = new Point(366, 8);
		((Control)label65).Location = location;
		((Control)Label48).Name = "Label48";
		Label label66 = Label48;
		itemSize = new Size(68, 26);
		((Control)label66).Size = itemSize;
		((Control)Label48).TabIndex = 1052;
		Label48.Text = "Période";
		Label48.TextAlign = (ContentAlignment)16;
		((Control)Label43).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label43).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label43).ForeColor = Color.White;
		Label label67 = Label43;
		location = new Point(0, 8);
		((Control)label67).Location = location;
		((Control)Label43).Name = "Label43";
		Label label68 = Label43;
		itemSize = new Size(346, 26);
		((Control)label68).Size = itemSize;
		((Control)Label43).TabIndex = 997;
		Label43.Text = "Top Caissier";
		Label43.TextAlign = (ContentAlignment)16;
		((Control)Button9).Anchor = (AnchorStyles)9;
		((ButtonBase)Button9).BackColor = Color.Transparent;
		((Control)Button9).Cursor = Cursors.Hand;
		((Control)Button9).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button9).ForeColor = Color.Black;
		((ButtonBase)Button9).Image = (Image)componentResourceManager.GetObject("Button9.Image");
		((ButtonBase)Button9).ImageAlign = (ContentAlignment)16;
		Button button7 = Button9;
		location = new Point(733, 2);
		((Control)button7).Location = location;
		Button button8 = Button9;
		headerPadding = new Padding(0);
		((Control)button8).Margin = headerPadding;
		((Control)Button9).Name = "Button9";
		Button button9 = Button9;
		itemSize = new Size(123, 39);
		((Control)button9).Size = itemSize;
		((Control)Button9).TabIndex = 1046;
		((ButtonBase)Button9).Text = "CHARGER";
		((ButtonBase)Button9).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button9).UseVisualStyleBackColor = false;
		((Control)DateTimePicker13).Anchor = (AnchorStyles)9;
		DateTimePicker13.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker13).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker13.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker11 = DateTimePicker13;
		location = new Point(440, 8);
		((Control)dateTimePicker11).Location = location;
		((Control)DateTimePicker13).Name = "DateTimePicker13";
		DateTimePicker dateTimePicker12 = DateTimePicker13;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker12).Size = itemSize;
		((Control)DateTimePicker13).TabIndex = 1038;
		DateTimePicker dateTimePicker13 = DateTimePicker13;
		value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker13.Value = value;
		((Control)PictureBox31).Anchor = (AnchorStyles)9;
		((Control)PictureBox31).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox31.Image = (Image)componentResourceManager.GetObject("PictureBox31.Image");
		PictureBox pictureBox47 = PictureBox31;
		location = new Point(562, 8);
		((Control)pictureBox47).Location = location;
		((Control)PictureBox31).Name = "PictureBox31";
		PictureBox pictureBox48 = PictureBox31;
		itemSize = new Size(35, 26);
		((Control)pictureBox48).Size = itemSize;
		PictureBox31.SizeMode = (PictureBoxSizeMode)4;
		PictureBox31.TabIndex = 1040;
		PictureBox31.TabStop = false;
		((Control)DateTimePicker14).Anchor = (AnchorStyles)9;
		DateTimePicker14.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker14).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker14.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker14 = DateTimePicker14;
		location = new Point(597, 8);
		((Control)dateTimePicker14).Location = location;
		((Control)DateTimePicker14).Name = "DateTimePicker14";
		DateTimePicker dateTimePicker15 = DateTimePicker14;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker15).Size = itemSize;
		((Control)DateTimePicker14).TabIndex = 1039;
		((Control)Panel23).Anchor = (AnchorStyles)15;
		((Control)Panel23).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel23).Controls.Add((Control)(object)Label44);
		((Control)Panel23).Controls.Add((Control)(object)Label45);
		((Control)Panel23).Controls.Add((Control)(object)Label46);
		((Control)Panel23).Controls.Add((Control)(object)Chart3);
		((Control)Panel23).Controls.Add((Control)(object)Label47);
		Panel panel49 = Panel23;
		location = new Point(4, 49);
		((Control)panel49).Location = location;
		((Control)Panel23).Name = "Panel23";
		Panel panel50 = Panel23;
		itemSize = new Size(574, 281);
		((Control)panel50).Size = itemSize;
		((Control)Panel23).TabIndex = 1003;
		((Control)Label44).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label44).Cursor = Cursors.Hand;
		((Control)Label44).Dock = (DockStyle)2;
		((Control)Label44).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label44).ForeColor = Color.White;
		Label label69 = Label44;
		location = new Point(1, 280);
		((Control)label69).Location = location;
		((Control)Label44).Name = "Label44";
		Label label70 = Label44;
		itemSize = new Size(572, 1);
		((Control)label70).Size = itemSize;
		((Control)Label44).TabIndex = 995;
		Label44.TextAlign = (ContentAlignment)16;
		((Control)Label45).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label45).Cursor = Cursors.Hand;
		((Control)Label45).Dock = (DockStyle)3;
		((Control)Label45).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label45).ForeColor = Color.White;
		Label label71 = Label45;
		location = new Point(0, 1);
		((Control)label71).Location = location;
		((Control)Label45).Name = "Label45";
		Label label72 = Label45;
		itemSize = new Size(1, 280);
		((Control)label72).Size = itemSize;
		((Control)Label45).TabIndex = 994;
		Label45.TextAlign = (ContentAlignment)16;
		((Control)Label46).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label46).Cursor = Cursors.Hand;
		((Control)Label46).Dock = (DockStyle)4;
		((Control)Label46).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label46).ForeColor = Color.White;
		Label label73 = Label46;
		location = new Point(573, 1);
		((Control)label73).Location = location;
		((Control)Label46).Name = "Label46";
		Label label74 = Label46;
		itemSize = new Size(1, 280);
		((Control)label74).Size = itemSize;
		((Control)Label46).TabIndex = 993;
		Label46.TextAlign = (ContentAlignment)16;
		val7.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart3.ChartAreas).Add(val7);
		((Control)Chart3).Dock = (DockStyle)5;
		val8.Name = "Legend1";
		((Collection<Legend>)(object)Chart3.Legends).Add(val8);
		Chart chart8 = Chart3;
		location = new Point(0, 1);
		((Control)chart8).Location = location;
		((Control)Chart3).Name = "Chart3";
		Chart chart9 = Chart3;
		itemSize = new Size(574, 280);
		chart9.Size = itemSize;
		((Control)Chart3).TabIndex = 989;
		((Control)Chart3).Text = "Chart7";
		((Control)Label47).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label47).Cursor = Cursors.Hand;
		((Control)Label47).Dock = (DockStyle)1;
		((Control)Label47).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label47).ForeColor = Color.FromArgb(64, 64, 64);
		Label label75 = Label47;
		location = new Point(0, 0);
		((Control)label75).Location = location;
		((Control)Label47).Name = "Label47";
		Label label76 = Label47;
		itemSize = new Size(574, 1);
		((Control)label76).Size = itemSize;
		((Control)Label47).TabIndex = 992;
		Label47.Text = "-";
		Label47.TextAlign = (ContentAlignment)16;
		((Control)Panel25).Anchor = (AnchorStyles)11;
		((Control)Panel25).BackColor = Color.White;
		((Control)Panel25).Controls.Add((Control)(object)Label_CAISSIER_TOP);
		((Control)Panel25).Controls.Add((Control)(object)PictureBox32);
		Panel panel51 = Panel25;
		location = new Point(586, 49);
		((Control)panel51).Location = location;
		((Control)Panel25).Name = "Panel25";
		Panel panel52 = Panel25;
		itemSize = new Size(272, 286);
		((Control)panel52).Size = itemSize;
		((Control)Panel25).TabIndex = 1001;
		((Control)Panel25).Visible = false;
		((Control)Label_CAISSIER_TOP).Anchor = (AnchorStyles)14;
		((Control)Label_CAISSIER_TOP).Font = new Font("Tahoma", 15f, (FontStyle)1);
		Label label_CAISSIER_TOP = Label_CAISSIER_TOP;
		location = new Point(3, 229);
		((Control)label_CAISSIER_TOP).Location = location;
		((Control)Label_CAISSIER_TOP).Name = "Label_CAISSIER_TOP";
		Label label_CAISSIER_TOP2 = Label_CAISSIER_TOP;
		itemSize = new Size(266, 56);
		((Control)label_CAISSIER_TOP2).Size = itemSize;
		((Control)Label_CAISSIER_TOP).TabIndex = 1;
		Label_CAISSIER_TOP.Text = "-";
		Label_CAISSIER_TOP.TextAlign = (ContentAlignment)32;
		((Control)PictureBox32).Anchor = (AnchorStyles)15;
		PictureBox32.Image = (Image)componentResourceManager.GetObject("PictureBox32.Image");
		PictureBox pictureBox49 = PictureBox32;
		location = new Point(46, 3);
		((Control)pictureBox49).Location = location;
		((Control)PictureBox32).Name = "PictureBox32";
		PictureBox pictureBox50 = PictureBox32;
		itemSize = new Size(179, 223);
		((Control)pictureBox50).Size = itemSize;
		PictureBox32.SizeMode = (PictureBoxSizeMode)4;
		PictureBox32.TabIndex = 0;
		PictureBox32.TabStop = false;
		TabPage5.BackColor = Color.White;
		((Control)TabPage5).Controls.Add((Control)(object)Panel12);
		((Control)TabPage5).Controls.Add((Control)(object)Panel10);
		TabPage tabPage6 = TabPage5;
		location = new Point(154, 4);
		tabPage6.Location = location;
		((Control)TabPage5).Name = "TabPage5";
		TabPage tabPage7 = TabPage5;
		headerPadding = new Padding(3);
		((Control)tabPage7).Padding = headerPadding;
		TabPage tabPage8 = TabPage5;
		itemSize = new Size(867, 684);
		((Control)tabPage8).Size = itemSize;
		TabPage5.TabIndex = 4;
		TabPage5.Text = "Top 10 Articles";
		((Control)Panel12).Anchor = (AnchorStyles)14;
		((Control)Panel12).Controls.Add((Control)(object)DataGridView2);
		((Control)Panel12).Controls.Add((Control)(object)Label11);
		Panel panel53 = Panel12;
		location = new Point(3, 397);
		((Control)panel53).Location = location;
		((Control)Panel12).Name = "Panel12";
		Panel panel54 = Panel12;
		itemSize = new Size(861, 281);
		((Control)panel54).Size = itemSize;
		((Control)Panel12).TabIndex = 1049;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToDeleteRows = false;
		DataGridView2.AllowUserToResizeColumns = false;
		DataGridView2.AllowUserToResizeRows = false;
		((Control)DataGridView2).Anchor = (AnchorStyles)13;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		DataGridView2.BorderStyle = (BorderStyle)2;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn3
		});
		DataGridView2.EditMode = (DataGridViewEditMode)4;
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView2;
		location = new Point(7, 43);
		((Control)dataGridView).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersVisible = false;
		DataGridView2.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView2;
		itemSize = new Size(847, 235);
		((Control)dataGridView2).Size = itemSize;
		((Control)DataGridView2).TabIndex = 1048;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 120;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "Qté";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Width = 60;
		((Control)Label11).Anchor = (AnchorStyles)13;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.Black;
		Label label77 = Label11;
		location = new Point(7, 4);
		((Control)label77).Location = location;
		((Control)Label11).Name = "Label11";
		Label label78 = Label11;
		itemSize = new Size(847, 36);
		((Control)label78).Size = itemSize;
		((Control)Label11).TabIndex = 1047;
		Label11.Text = "Liste des Articles Moins Vendus";
		Label11.TextAlign = (ContentAlignment)32;
		((Control)Panel10).Anchor = (AnchorStyles)15;
		((Control)Panel10).Controls.Add((Control)(object)Panel27);
		((Control)Panel10).Controls.Add((Control)(object)Panel11);
		((Control)Panel10).Controls.Add((Control)(object)Panel26);
		Panel panel55 = Panel10;
		location = new Point(3, 3);
		((Control)panel55).Location = location;
		((Control)Panel10).Name = "Panel10";
		Panel panel56 = Panel10;
		itemSize = new Size(861, 388);
		((Control)panel56).Size = itemSize;
		((Control)Panel10).TabIndex = 1048;
		((Control)Panel27).Anchor = (AnchorStyles)15;
		((Control)Panel27).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel27).Controls.Add((Control)(object)Label49);
		((Control)Panel27).Controls.Add((Control)(object)Chart5);
		((Control)Panel27).Controls.Add((Control)(object)Label50);
		((Control)Panel27).Controls.Add((Control)(object)Label51);
		((Control)Panel27).Controls.Add((Control)(object)Label52);
		Panel panel57 = Panel27;
		location = new Point(4, 49);
		((Control)panel57).Location = location;
		((Control)Panel27).Name = "Panel27";
		Panel panel58 = Panel27;
		itemSize = new Size(573, 336);
		((Control)panel58).Size = itemSize;
		((Control)Panel27).TabIndex = 1000;
		((Control)Label49).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label49).Cursor = Cursors.Hand;
		((Control)Label49).Dock = (DockStyle)2;
		((Control)Label49).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label49).ForeColor = Color.White;
		Label label79 = Label49;
		location = new Point(1, 335);
		((Control)label79).Location = location;
		((Control)Label49).Name = "Label49";
		Label label80 = Label49;
		itemSize = new Size(571, 1);
		((Control)label80).Size = itemSize;
		((Control)Label49).TabIndex = 995;
		Label49.TextAlign = (ContentAlignment)16;
		val9.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart5.ChartAreas).Add(val9);
		((Control)Chart5).Dock = (DockStyle)5;
		val10.Name = "Legend1";
		((Collection<Legend>)(object)Chart5.Legends).Add(val10);
		Chart chart10 = Chart5;
		location = new Point(1, 1);
		((Control)chart10).Location = location;
		((Control)Chart5).Name = "Chart5";
		Chart chart11 = Chart5;
		itemSize = new Size(571, 335);
		chart11.Size = itemSize;
		((Control)Chart5).TabIndex = 989;
		((Control)Chart5).Text = "Chart5";
		((Control)Label50).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label50).Cursor = Cursors.Hand;
		((Control)Label50).Dock = (DockStyle)3;
		((Control)Label50).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label50).ForeColor = Color.White;
		Label label81 = Label50;
		location = new Point(0, 1);
		((Control)label81).Location = location;
		((Control)Label50).Name = "Label50";
		Label label82 = Label50;
		itemSize = new Size(1, 335);
		((Control)label82).Size = itemSize;
		((Control)Label50).TabIndex = 994;
		Label50.TextAlign = (ContentAlignment)16;
		((Control)Label51).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label51).Cursor = Cursors.Hand;
		((Control)Label51).Dock = (DockStyle)4;
		((Control)Label51).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label51).ForeColor = Color.White;
		Label label83 = Label51;
		location = new Point(572, 1);
		((Control)label83).Location = location;
		((Control)Label51).Name = "Label51";
		Label label84 = Label51;
		itemSize = new Size(1, 335);
		((Control)label84).Size = itemSize;
		((Control)Label51).TabIndex = 993;
		Label51.TextAlign = (ContentAlignment)16;
		((Control)Label52).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label52).Cursor = Cursors.Hand;
		((Control)Label52).Dock = (DockStyle)1;
		((Control)Label52).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label52).ForeColor = Color.FromArgb(64, 64, 64);
		Label label85 = Label52;
		location = new Point(0, 0);
		((Control)label85).Location = location;
		((Control)Label52).Name = "Label52";
		Label label86 = Label52;
		itemSize = new Size(573, 1);
		((Control)label86).Size = itemSize;
		((Control)Label52).TabIndex = 992;
		Label52.Text = "-";
		Label52.TextAlign = (ContentAlignment)16;
		((Control)Panel11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel11).Controls.Add((Control)(object)Label20);
		((Control)Panel11).Controls.Add((Control)(object)DateTimePicker5);
		((Control)Panel11).Controls.Add((Control)(object)PictureBox13);
		((Control)Panel11).Controls.Add((Control)(object)DateTimePicker6);
		((Control)Panel11).Controls.Add((Control)(object)Button4);
		((Control)Panel11).Controls.Add((Control)(object)Label6);
		((Control)Panel11).Dock = (DockStyle)1;
		Panel panel59 = Panel11;
		location = new Point(0, 0);
		((Control)panel59).Location = location;
		((Control)Panel11).Name = "Panel11";
		Panel panel60 = Panel11;
		itemSize = new Size(861, 43);
		((Control)panel60).Size = itemSize;
		((Control)Panel11).TabIndex = 998;
		((Control)Label20).Anchor = (AnchorStyles)9;
		((Control)Label20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label20).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.White;
		Label label87 = Label20;
		location = new Point(370, 8);
		((Control)label87).Location = location;
		((Control)Label20).Name = "Label20";
		Label label88 = Label20;
		itemSize = new Size(68, 26);
		((Control)label88).Size = itemSize;
		((Control)Label20).TabIndex = 1053;
		Label20.Text = "Période";
		Label20.TextAlign = (ContentAlignment)16;
		((Control)DateTimePicker5).Anchor = (AnchorStyles)9;
		DateTimePicker5.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker5).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker5.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker16 = DateTimePicker5;
		location = new Point(444, 8);
		((Control)dateTimePicker16).Location = location;
		((Control)DateTimePicker5).Name = "DateTimePicker5";
		DateTimePicker dateTimePicker17 = DateTimePicker5;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker17).Size = itemSize;
		((Control)DateTimePicker5).TabIndex = 1038;
		DateTimePicker dateTimePicker18 = DateTimePicker5;
		value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker18.Value = value;
		((Control)PictureBox13).Anchor = (AnchorStyles)9;
		((Control)PictureBox13).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox51 = PictureBox13;
		location = new Point(566, 8);
		((Control)pictureBox51).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox52 = PictureBox13;
		itemSize = new Size(35, 26);
		((Control)pictureBox52).Size = itemSize;
		PictureBox13.SizeMode = (PictureBoxSizeMode)4;
		PictureBox13.TabIndex = 1040;
		PictureBox13.TabStop = false;
		((Control)DateTimePicker6).Anchor = (AnchorStyles)9;
		DateTimePicker6.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker6).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker6.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker19 = DateTimePicker6;
		location = new Point(601, 8);
		((Control)dateTimePicker19).Location = location;
		((Control)DateTimePicker6).Name = "DateTimePicker6";
		DateTimePicker dateTimePicker20 = DateTimePicker6;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker20).Size = itemSize;
		((Control)DateTimePicker6).TabIndex = 1039;
		((Control)Button4).Anchor = (AnchorStyles)9;
		((ButtonBase)Button4).BackColor = Color.Transparent;
		((Control)Button4).Cursor = Cursors.Hand;
		((Control)Button4).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button4).ForeColor = Color.Black;
		((ButtonBase)Button4).Image = (Image)componentResourceManager.GetObject("Button4.Image");
		((ButtonBase)Button4).ImageAlign = (ContentAlignment)16;
		Button button10 = Button4;
		location = new Point(736, 2);
		((Control)button10).Location = location;
		Button button11 = Button4;
		headerPadding = new Padding(0);
		((Control)button11).Margin = headerPadding;
		((Control)Button4).Name = "Button4";
		Button button12 = Button4;
		itemSize = new Size(123, 39);
		((Control)button12).Size = itemSize;
		((Control)Button4).TabIndex = 1046;
		((ButtonBase)Button4).Text = "CHARGER";
		((ButtonBase)Button4).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button4).UseVisualStyleBackColor = false;
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label6).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label89 = Label6;
		location = new Point(0, 8);
		((Control)label89).Location = location;
		((Control)Label6).Name = "Label6";
		Label label90 = Label6;
		itemSize = new Size(346, 26);
		((Control)label90).Size = itemSize;
		((Control)Label6).TabIndex = 997;
		Label6.Text = "Top 10 Articles Les Plus Vendus";
		Label6.TextAlign = (ContentAlignment)16;
		((Control)Panel26).Anchor = (AnchorStyles)11;
		((Control)Panel26).BackColor = Color.White;
		((Control)Panel26).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel26).Controls.Add((Control)(object)Label_ARTICLE_TOP);
		Panel panel61 = Panel26;
		location = new Point(582, 49);
		((Control)panel61).Location = location;
		((Control)Panel26).Name = "Panel26";
		Panel panel62 = Panel26;
		itemSize = new Size(275, 336);
		((Control)panel62).Size = itemSize;
		((Control)Panel26).TabIndex = 993;
		((Control)Panel26).Visible = false;
		((Control)PictureBox19).Anchor = (AnchorStyles)15;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox53 = PictureBox19;
		location = new Point(46, 43);
		((Control)pictureBox53).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox54 = PictureBox19;
		itemSize = new Size(182, 167);
		((Control)pictureBox54).Size = itemSize;
		PictureBox19.SizeMode = (PictureBoxSizeMode)4;
		PictureBox19.TabIndex = 2;
		PictureBox19.TabStop = false;
		((Control)Label_ARTICLE_TOP).Anchor = (AnchorStyles)14;
		((Control)Label_ARTICLE_TOP).Font = new Font("Tahoma", 15f, (FontStyle)1);
		Label label_ARTICLE_TOP = Label_ARTICLE_TOP;
		location = new Point(3, 210);
		((Control)label_ARTICLE_TOP).Location = location;
		((Control)Label_ARTICLE_TOP).Name = "Label_ARTICLE_TOP";
		Label label_ARTICLE_TOP2 = Label_ARTICLE_TOP;
		itemSize = new Size(269, 56);
		((Control)label_ARTICLE_TOP2).Size = itemSize;
		((Control)Label_ARTICLE_TOP).TabIndex = 1;
		Label_ARTICLE_TOP.Text = "-";
		Label_ARTICLE_TOP.TextAlign = (ContentAlignment)32;
		TabPage3.BackColor = Color.White;
		((Control)TabPage3).Controls.Add((Control)(object)Panel14);
		((Control)TabPage3).Controls.Add((Control)(object)Panel4);
		TabPage tabPage9 = TabPage3;
		location = new Point(154, 4);
		tabPage9.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage10 = TabPage3;
		headerPadding = new Padding(3);
		((Control)tabPage10).Padding = headerPadding;
		TabPage tabPage11 = TabPage3;
		itemSize = new Size(867, 684);
		((Control)tabPage11).Size = itemSize;
		TabPage3.TabIndex = 2;
		TabPage3.Text = "Top 10 Clients";
		((Control)Panel14).Anchor = (AnchorStyles)14;
		((Control)Panel14).Controls.Add((Control)(object)Label12);
		((Control)Panel14).Controls.Add((Control)(object)DataGridView3);
		Panel panel63 = Panel14;
		location = new Point(3, 397);
		((Control)panel63).Location = location;
		((Control)Panel14).Name = "Panel14";
		Panel panel64 = Panel14;
		itemSize = new Size(861, 281);
		((Control)panel64).Size = itemSize;
		((Control)Panel14).TabIndex = 1052;
		((Control)Label12).Anchor = (AnchorStyles)14;
		((Control)Label12).BackColor = Color.Transparent;
		((Control)Label12).Font = new Font("Tahoma", 14.25f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.Black;
		Label label91 = Label12;
		location = new Point(7, 4);
		((Control)label91).Location = location;
		((Control)Label12).Name = "Label12";
		Label label92 = Label12;
		itemSize = new Size(847, 36);
		((Control)label92).Size = itemSize;
		((Control)Label12).TabIndex = 1050;
		Label12.Text = "Liste des Client Moins Fidéles";
		Label12.TextAlign = (ContentAlignment)32;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AllowUserToDeleteRows = false;
		DataGridView3.AllowUserToResizeColumns = false;
		DataGridView3.AllowUserToResizeRows = false;
		((Control)DataGridView3).Anchor = (AnchorStyles)14;
		DataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView3.BackgroundColor = Color.White;
		DataGridView3.BorderStyle = (BorderStyle)2;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn5,
			(DataGridViewColumn)DataGridViewTextBoxColumn6
		});
		DataGridView3.EditMode = (DataGridViewEditMode)4;
		DataGridView3.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView3;
		location = new Point(7, 43);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.RowHeadersVisible = false;
		DataGridView3.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView3;
		itemSize = new Size(847, 235);
		((Control)dataGridView4).Size = itemSize;
		((Control)DataGridView3).TabIndex = 1049;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "ID_Client";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Width = 120;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Client";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).HeaderText = "Total_Net";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Name = "DataGridViewTextBoxColumn6";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Width = 120;
		((Control)Panel4).Anchor = (AnchorStyles)15;
		((Control)Panel4).Controls.Add((Control)(object)Panel28);
		((Control)Panel4).Controls.Add((Control)(object)Panel13);
		((Control)Panel4).Controls.Add((Control)(object)Panel38);
		Panel panel65 = Panel4;
		location = new Point(3, 3);
		((Control)panel65).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel66 = Panel4;
		itemSize = new Size(861, 388);
		((Control)panel66).Size = itemSize;
		((Control)Panel4).TabIndex = 1051;
		((Control)Panel28).Anchor = (AnchorStyles)15;
		((Control)Panel28).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel28).Controls.Add((Control)(object)Label53);
		((Control)Panel28).Controls.Add((Control)(object)Chart6);
		((Control)Panel28).Controls.Add((Control)(object)Label54);
		((Control)Panel28).Controls.Add((Control)(object)Label55);
		((Control)Panel28).Controls.Add((Control)(object)Label56);
		Panel panel67 = Panel28;
		location = new Point(4, 49);
		((Control)panel67).Location = location;
		((Control)Panel28).Name = "Panel28";
		Panel panel68 = Panel28;
		itemSize = new Size(573, 336);
		((Control)panel68).Size = itemSize;
		((Control)Panel28).TabIndex = 1001;
		((Control)Label53).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label53).Cursor = Cursors.Hand;
		((Control)Label53).Dock = (DockStyle)2;
		((Control)Label53).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label53).ForeColor = Color.White;
		Label label93 = Label53;
		location = new Point(1, 335);
		((Control)label93).Location = location;
		((Control)Label53).Name = "Label53";
		Label label94 = Label53;
		itemSize = new Size(571, 1);
		((Control)label94).Size = itemSize;
		((Control)Label53).TabIndex = 995;
		Label53.TextAlign = (ContentAlignment)16;
		val11.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart6.ChartAreas).Add(val11);
		((Control)Chart6).Dock = (DockStyle)5;
		val12.Name = "Legend1";
		((Collection<Legend>)(object)Chart6.Legends).Add(val12);
		Chart chart12 = Chart6;
		location = new Point(1, 1);
		((Control)chart12).Location = location;
		((Control)Chart6).Name = "Chart6";
		Chart chart13 = Chart6;
		itemSize = new Size(571, 335);
		chart13.Size = itemSize;
		((Control)Chart6).TabIndex = 989;
		((Control)Chart6).Text = "Chart6";
		((Control)Label54).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label54).Cursor = Cursors.Hand;
		((Control)Label54).Dock = (DockStyle)3;
		((Control)Label54).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label54).ForeColor = Color.White;
		Label label95 = Label54;
		location = new Point(0, 1);
		((Control)label95).Location = location;
		((Control)Label54).Name = "Label54";
		Label label96 = Label54;
		itemSize = new Size(1, 335);
		((Control)label96).Size = itemSize;
		((Control)Label54).TabIndex = 994;
		Label54.TextAlign = (ContentAlignment)16;
		((Control)Label55).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label55).Cursor = Cursors.Hand;
		((Control)Label55).Dock = (DockStyle)4;
		((Control)Label55).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label55).ForeColor = Color.White;
		Label label97 = Label55;
		location = new Point(572, 1);
		((Control)label97).Location = location;
		((Control)Label55).Name = "Label55";
		Label label98 = Label55;
		itemSize = new Size(1, 335);
		((Control)label98).Size = itemSize;
		((Control)Label55).TabIndex = 993;
		Label55.TextAlign = (ContentAlignment)16;
		((Control)Label56).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label56).Cursor = Cursors.Hand;
		((Control)Label56).Dock = (DockStyle)1;
		((Control)Label56).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label56).ForeColor = Color.FromArgb(64, 64, 64);
		Label label99 = Label56;
		location = new Point(0, 0);
		((Control)label99).Location = location;
		((Control)Label56).Name = "Label56";
		Label label100 = Label56;
		itemSize = new Size(573, 1);
		((Control)label100).Size = itemSize;
		((Control)Label56).TabIndex = 992;
		Label56.Text = "-";
		Label56.TextAlign = (ContentAlignment)16;
		((Control)Panel13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel13).Controls.Add((Control)(object)Label17);
		((Control)Panel13).Controls.Add((Control)(object)DateTimePicker11);
		((Control)Panel13).Controls.Add((Control)(object)PictureBox18);
		((Control)Panel13).Controls.Add((Control)(object)DateTimePicker12);
		((Control)Panel13).Controls.Add((Control)(object)Label8);
		((Control)Panel13).Controls.Add((Control)(object)Button6);
		((Control)Panel13).Dock = (DockStyle)1;
		Panel panel69 = Panel13;
		location = new Point(0, 0);
		((Control)panel69).Location = location;
		((Control)Panel13).Name = "Panel13";
		Panel panel70 = Panel13;
		itemSize = new Size(861, 43);
		((Control)panel70).Size = itemSize;
		((Control)Panel13).TabIndex = 998;
		((Control)Label17).Anchor = (AnchorStyles)9;
		((Control)Label17).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label17).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label101 = Label17;
		location = new Point(371, 8);
		((Control)label101).Location = location;
		((Control)Label17).Name = "Label17";
		Label label102 = Label17;
		itemSize = new Size(68, 26);
		((Control)label102).Size = itemSize;
		((Control)Label17).TabIndex = 1053;
		Label17.Text = "Période";
		Label17.TextAlign = (ContentAlignment)16;
		((Control)DateTimePicker11).Anchor = (AnchorStyles)9;
		DateTimePicker11.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker11).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker11.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker21 = DateTimePicker11;
		location = new Point(445, 8);
		((Control)dateTimePicker21).Location = location;
		((Control)DateTimePicker11).Name = "DateTimePicker11";
		DateTimePicker dateTimePicker22 = DateTimePicker11;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker22).Size = itemSize;
		((Control)DateTimePicker11).TabIndex = 1038;
		DateTimePicker dateTimePicker23 = DateTimePicker11;
		value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker23.Value = value;
		((Control)PictureBox18).Anchor = (AnchorStyles)9;
		((Control)PictureBox18).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox55 = PictureBox18;
		location = new Point(567, 8);
		((Control)pictureBox55).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox56 = PictureBox18;
		itemSize = new Size(35, 26);
		((Control)pictureBox56).Size = itemSize;
		PictureBox18.SizeMode = (PictureBoxSizeMode)4;
		PictureBox18.TabIndex = 1040;
		PictureBox18.TabStop = false;
		((Control)DateTimePicker12).Anchor = (AnchorStyles)9;
		DateTimePicker12.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker12).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker12.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker24 = DateTimePicker12;
		location = new Point(602, 8);
		((Control)dateTimePicker24).Location = location;
		((Control)DateTimePicker12).Name = "DateTimePicker12";
		DateTimePicker dateTimePicker25 = DateTimePicker12;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker25).Size = itemSize;
		((Control)DateTimePicker12).TabIndex = 1039;
		((Control)Label8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label8).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label103 = Label8;
		location = new Point(0, 8);
		((Control)label103).Location = location;
		((Control)Label8).Name = "Label8";
		Label label104 = Label8;
		itemSize = new Size(346, 26);
		((Control)label104).Size = itemSize;
		((Control)Label8).TabIndex = 997;
		Label8.Text = "Top 10 Clients Fidèles";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)Button6).Anchor = (AnchorStyles)9;
		((ButtonBase)Button6).BackColor = Color.Transparent;
		((Control)Button6).Cursor = Cursors.Hand;
		((Control)Button6).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button6).ForeColor = Color.Black;
		((ButtonBase)Button6).Image = (Image)componentResourceManager.GetObject("Button6.Image");
		((ButtonBase)Button6).ImageAlign = (ContentAlignment)16;
		Button button13 = Button6;
		location = new Point(736, 2);
		((Control)button13).Location = location;
		Button button14 = Button6;
		headerPadding = new Padding(0);
		((Control)button14).Margin = headerPadding;
		((Control)Button6).Name = "Button6";
		Button button15 = Button6;
		itemSize = new Size(123, 39);
		((Control)button15).Size = itemSize;
		((Control)Button6).TabIndex = 1046;
		((ButtonBase)Button6).Text = "CHARGER";
		((ButtonBase)Button6).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		((Control)Panel38).Anchor = (AnchorStyles)11;
		((Control)Panel38).BackColor = Color.White;
		((Control)Panel38).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel38).Controls.Add((Control)(object)Label_CLIENT_TOP);
		Panel panel71 = Panel38;
		location = new Point(582, 49);
		((Control)panel71).Location = location;
		((Control)Panel38).Name = "Panel38";
		Panel panel72 = Panel38;
		itemSize = new Size(275, 336);
		((Control)panel72).Size = itemSize;
		((Control)Panel38).TabIndex = 993;
		((Control)Panel38).Visible = false;
		((Control)PictureBox9).Anchor = (AnchorStyles)15;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox57 = PictureBox9;
		location = new Point(46, 43);
		((Control)pictureBox57).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox58 = PictureBox9;
		itemSize = new Size(182, 167);
		((Control)pictureBox58).Size = itemSize;
		PictureBox9.SizeMode = (PictureBoxSizeMode)4;
		PictureBox9.TabIndex = 0;
		PictureBox9.TabStop = false;
		((Control)Label_CLIENT_TOP).Anchor = (AnchorStyles)14;
		((Control)Label_CLIENT_TOP).Font = new Font("Tahoma", 15f, (FontStyle)1);
		Label label_CLIENT_TOP = Label_CLIENT_TOP;
		location = new Point(3, 210);
		((Control)label_CLIENT_TOP).Location = location;
		((Control)Label_CLIENT_TOP).Name = "Label_CLIENT_TOP";
		Label label_CLIENT_TOP2 = Label_CLIENT_TOP;
		itemSize = new Size(269, 56);
		((Control)label_CLIENT_TOP2).Size = itemSize;
		((Control)Label_CLIENT_TOP).TabIndex = 1;
		Label_CLIENT_TOP.Text = "-";
		Label_CLIENT_TOP.TextAlign = (ContentAlignment)32;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Panel15);
		TabPage tabPage12 = TabPage2;
		location = new Point(154, 4);
		tabPage12.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage13 = TabPage2;
		headerPadding = new Padding(3);
		((Control)tabPage13).Padding = headerPadding;
		TabPage tabPage14 = TabPage2;
		itemSize = new Size(867, 684);
		((Control)tabPage14).Size = itemSize;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Evolution Article";
		((Control)Panel15).Controls.Add((Control)(object)DataGridView4);
		((Control)Panel15).Controls.Add((Control)(object)Button1);
		((Control)Panel15).Controls.Add((Control)(object)Panel29);
		((Control)Panel15).Controls.Add((Control)(object)Panel16);
		((Control)Panel15).Dock = (DockStyle)5;
		Panel panel73 = Panel15;
		location = new Point(3, 3);
		((Control)panel73).Location = location;
		((Control)Panel15).Name = "Panel15";
		Panel panel74 = Panel15;
		itemSize = new Size(861, 678);
		((Control)panel74).Size = itemSize;
		((Control)Panel15).TabIndex = 1053;
		DataGridView4.AllowUserToAddRows = false;
		DataGridView4.AllowUserToDeleteRows = false;
		DataGridView4.AllowUserToResizeRows = false;
		((Control)DataGridView4).Anchor = (AnchorStyles)7;
		DataGridView4.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView4.BackgroundColor = Color.White;
		DataGridView4.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView4.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView4.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView4.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn10,
			(DataGridViewColumn)DataGridViewTextBoxColumn11
		});
		DataGridView4.EditMode = (DataGridViewEditMode)4;
		DataGridView4.EnableHeadersVisualStyles = false;
		DataGridView dataGridView5 = DataGridView4;
		location = new Point(4, 109);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView4).Name = "DataGridView4";
		DataGridView4.ReadOnly = true;
		DataGridView4.RowHeadersVisible = false;
		DataGridView4.RowHeadersWidth = 11;
		DataGridView4.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView6 = DataGridView4;
		itemSize = new Size(193, 564);
		((Control)dataGridView6).Size = itemSize;
		((Control)DataGridView4).TabIndex = 1077;
		((DataGridViewColumn)DataGridViewTextBoxColumn10).FillWeight = 188.5714f;
		((DataGridViewColumn)DataGridViewTextBoxColumn10).HeaderText = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn10).Name = "DataGridViewTextBoxColumn10";
		((DataGridViewColumn)DataGridViewTextBoxColumn10).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn10).Resizable = (DataGridViewTriState)1;
		DataGridViewTextBoxColumn10.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn11).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn11).HeaderText = "Type";
		((DataGridViewColumn)DataGridViewTextBoxColumn11).Name = "DataGridViewTextBoxColumn11";
		((DataGridViewColumn)DataGridViewTextBoxColumn11).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn11).Width = 70;
		((ButtonBase)Button1).BackColor = Color.Transparent;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).Font = new Font("Calibri", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button1).ForeColor = Color.Black;
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button16 = Button1;
		location = new Point(4, 59);
		((Control)button16).Location = location;
		Button button17 = Button1;
		headerPadding = new Padding(0);
		((Control)button17).Margin = headerPadding;
		((Control)Button1).Name = "Button1";
		Button button18 = Button1;
		itemSize = new Size(193, 22);
		((Control)button18).Size = itemSize;
		((Control)Button1).TabIndex = 1076;
		((ButtonBase)Button1).Text = "Charger Les Articles";
		((ButtonBase)Button1).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((Control)Panel29).Anchor = (AnchorStyles)15;
		((Control)Panel29).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel29).Controls.Add((Control)(object)Label57);
		((Control)Panel29).Controls.Add((Control)(object)Label58);
		((Control)Panel29).Controls.Add((Control)(object)Chart2);
		((Control)Panel29).Controls.Add((Control)(object)Label59);
		((Control)Panel29).Controls.Add((Control)(object)Label60);
		Panel panel75 = Panel29;
		location = new Point(203, 109);
		((Control)panel75).Location = location;
		((Control)Panel29).Name = "Panel29";
		Panel panel76 = Panel29;
		itemSize = new Size(653, 564);
		((Control)panel76).Size = itemSize;
		((Control)Panel29).TabIndex = 1078;
		((Control)Label57).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label57).Cursor = Cursors.Hand;
		((Control)Label57).Dock = (DockStyle)2;
		((Control)Label57).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label57).ForeColor = Color.White;
		Label label105 = Label57;
		location = new Point(1, 563);
		((Control)label105).Location = location;
		((Control)Label57).Name = "Label57";
		Label label106 = Label57;
		itemSize = new Size(651, 1);
		((Control)label106).Size = itemSize;
		((Control)Label57).TabIndex = 995;
		Label57.TextAlign = (ContentAlignment)16;
		((Control)Label58).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label58).Cursor = Cursors.Hand;
		((Control)Label58).Dock = (DockStyle)3;
		((Control)Label58).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label58).ForeColor = Color.White;
		Label label107 = Label58;
		location = new Point(0, 1);
		((Control)label107).Location = location;
		((Control)Label58).Name = "Label58";
		Label label108 = Label58;
		itemSize = new Size(1, 563);
		((Control)label108).Size = itemSize;
		((Control)Label58).TabIndex = 994;
		Label58.TextAlign = (ContentAlignment)16;
		val13.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart2.ChartAreas).Add(val13);
		((Control)Chart2).Dock = (DockStyle)5;
		val14.Name = "Legend1";
		((Collection<Legend>)(object)Chart2.Legends).Add(val14);
		Chart chart14 = Chart2;
		location = new Point(0, 1);
		((Control)chart14).Location = location;
		((Control)Chart2).Name = "Chart2";
		Chart chart15 = Chart2;
		itemSize = new Size(652, 563);
		chart15.Size = itemSize;
		((Control)Chart2).TabIndex = 955;
		((Control)Chart2).Text = "Chart2";
		((Control)Label59).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label59).Cursor = Cursors.Hand;
		((Control)Label59).Dock = (DockStyle)4;
		((Control)Label59).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label59).ForeColor = Color.White;
		Label label109 = Label59;
		location = new Point(652, 1);
		((Control)label109).Location = location;
		((Control)Label59).Name = "Label59";
		Label label110 = Label59;
		itemSize = new Size(1, 563);
		((Control)label110).Size = itemSize;
		((Control)Label59).TabIndex = 993;
		Label59.TextAlign = (ContentAlignment)16;
		((Control)Label60).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label60).Cursor = Cursors.Hand;
		((Control)Label60).Dock = (DockStyle)1;
		((Control)Label60).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label60).ForeColor = Color.FromArgb(64, 64, 64);
		Label label111 = Label60;
		location = new Point(0, 0);
		((Control)label111).Location = location;
		((Control)Label60).Name = "Label60";
		Label label112 = Label60;
		itemSize = new Size(653, 1);
		((Control)label112).Size = itemSize;
		((Control)Label60).TabIndex = 992;
		Label60.Text = "-";
		Label60.TextAlign = (ContentAlignment)16;
		((Control)Panel16).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel16).Controls.Add((Control)(object)Label4);
		((Control)Panel16).Controls.Add((Control)(object)Button2);
		((Control)Panel16).Controls.Add((Control)(object)DateTimePicker1);
		((Control)Panel16).Controls.Add((Control)(object)DateTimePicker2);
		((Control)Panel16).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel16).Controls.Add((Control)(object)Label5);
		((Control)Panel16).Dock = (DockStyle)1;
		Panel panel77 = Panel16;
		location = new Point(0, 0);
		((Control)panel77).Location = location;
		((Control)Panel16).Name = "Panel16";
		Panel panel78 = Panel16;
		itemSize = new Size(861, 43);
		((Control)panel78).Size = itemSize;
		((Control)Panel16).TabIndex = 998;
		((Control)Label4).Anchor = (AnchorStyles)9;
		((Control)Label4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label4).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label113 = Label4;
		location = new Point(369, 8);
		((Control)label113).Location = location;
		((Control)Label4).Name = "Label4";
		Label label114 = Label4;
		itemSize = new Size(68, 26);
		((Control)label114).Size = itemSize;
		((Control)Label4).TabIndex = 1055;
		Label4.Text = "Période";
		Label4.TextAlign = (ContentAlignment)16;
		((Control)Button2).Anchor = (AnchorStyles)9;
		((ButtonBase)Button2).BackColor = Color.Transparent;
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button2).ForeColor = Color.Black;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button19 = Button2;
		location = new Point(736, 2);
		((Control)button19).Location = location;
		Button button20 = Button2;
		headerPadding = new Padding(0);
		((Control)button20).Margin = headerPadding;
		((Control)Button2).Name = "Button2";
		Button button21 = Button2;
		itemSize = new Size(123, 39);
		((Control)button21).Size = itemSize;
		((Control)Button2).TabIndex = 1047;
		((ButtonBase)Button2).Text = "CHARGER";
		((ButtonBase)Button2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		((Control)DateTimePicker1).Anchor = (AnchorStyles)9;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker26 = DateTimePicker1;
		location = new Point(443, 8);
		((Control)dateTimePicker26).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker27 = DateTimePicker1;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker27).Size = itemSize;
		((Control)DateTimePicker1).TabIndex = 1048;
		DateTimePicker dateTimePicker28 = DateTimePicker1;
		value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTimePicker28.Value = value;
		((Control)DateTimePicker2).Anchor = (AnchorStyles)9;
		DateTimePicker2.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker2).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker29 = DateTimePicker2;
		location = new Point(600, 8);
		((Control)dateTimePicker29).Location = location;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DateTimePicker dateTimePicker30 = DateTimePicker2;
		itemSize = new Size(122, 26);
		((Control)dateTimePicker30).Size = itemSize;
		((Control)DateTimePicker2).TabIndex = 1049;
		((Control)PictureBox6).Anchor = (AnchorStyles)9;
		((Control)PictureBox6).BackColor = Color.FromArgb(22, 106, 238);
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox59 = PictureBox6;
		location = new Point(565, 8);
		((Control)pictureBox59).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox60 = PictureBox6;
		itemSize = new Size(35, 26);
		((Control)pictureBox60).Size = itemSize;
		PictureBox6.SizeMode = (PictureBoxSizeMode)4;
		PictureBox6.TabIndex = 1050;
		PictureBox6.TabStop = false;
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label115 = Label5;
		location = new Point(0, 8);
		((Control)label115).Location = location;
		((Control)Label5).Name = "Label5";
		Label label116 = Label5;
		itemSize = new Size(192, 26);
		((Control)label116).Size = itemSize;
		((Control)Label5).TabIndex = 997;
		Label5.Text = "Evolution Article";
		Label5.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		itemSize = new Size(1025, 692);
		((Form)this).ClientSize = itemSize;
		((Control)this).Controls.Add((Control)(object)TabControlEx1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Form_9_STATISTIQUES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "STATISTIQUES";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)TabControlEx1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel9).ResumeLayout(false);
		((ISupportInitialize)PictureBox8).EndInit();
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)Chart7).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel24).ResumeLayout(false);
		((Control)Panel24).PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((Control)Panel39).ResumeLayout(false);
		((Control)Panel39).PerformLayout();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((Control)Panel42).ResumeLayout(false);
		((Control)Panel42).PerformLayout();
		((ISupportInitialize)PictureBox23).EndInit();
		((ISupportInitialize)PictureBox24).EndInit();
		((ISupportInitialize)PictureBox25).EndInit();
		((ISupportInitialize)PictureBox26).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((Control)Panel45).ResumeLayout(false);
		((Control)Panel45).PerformLayout();
		((ISupportInitialize)PictureBox27).EndInit();
		((ISupportInitialize)PictureBox28).EndInit();
		((ISupportInitialize)PictureBox29).EndInit();
		((ISupportInitialize)PictureBox30).EndInit();
		((ISupportInitialize)PictureBox22).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)DataGrid_STATISTIQUE).EndInit();
		((Control)Panel6).ResumeLayout(false);
		((ISupportInitialize)Chart1).EndInit();
		((Control)Panel8).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)Panel21).ResumeLayout(false);
		((Control)Panel32).ResumeLayout(false);
		((ISupportInitialize)PictureBox15).EndInit();
		((Control)Panel17).ResumeLayout(false);
		((ISupportInitialize)Chart4).EndInit();
		((Control)Panel19).ResumeLayout(false);
		((ISupportInitialize)PictureBox16).EndInit();
		((Control)Panel20).ResumeLayout(false);
		((Control)Panel22).ResumeLayout(false);
		((ISupportInitialize)PictureBox31).EndInit();
		((Control)Panel23).ResumeLayout(false);
		((ISupportInitialize)Chart3).EndInit();
		((Control)Panel25).ResumeLayout(false);
		((ISupportInitialize)PictureBox32).EndInit();
		((Control)TabPage5).ResumeLayout(false);
		((Control)Panel12).ResumeLayout(false);
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)Panel10).ResumeLayout(false);
		((Control)Panel27).ResumeLayout(false);
		((ISupportInitialize)Chart5).EndInit();
		((Control)Panel11).ResumeLayout(false);
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)Panel26).ResumeLayout(false);
		((ISupportInitialize)PictureBox19).EndInit();
		((Control)TabPage3).ResumeLayout(false);
		((Control)Panel14).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel28).ResumeLayout(false);
		((ISupportInitialize)Chart6).EndInit();
		((Control)Panel13).ResumeLayout(false);
		((ISupportInitialize)PictureBox18).EndInit();
		((Control)Panel38).ResumeLayout(false);
		((ISupportInitialize)PictureBox9).EndInit();
		((Control)TabPage2).ResumeLayout(false);
		((Control)Panel15).ResumeLayout(false);
		((ISupportInitialize)DataGridView4).EndInit();
		((Control)Panel29).ResumeLayout(false);
		((ISupportInitialize)Chart2).EndInit();
		((Control)Panel16).ResumeLayout(false);
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void me_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Component)(object)this).Dispose();
		}
	}

	private void Form_9_STATISTIQUES_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void Form_9_STATISTIQUES_Load(object sender, EventArgs e)
	{
		try
		{
			TextBox_ANNEE.Text = Conversions.ToString(DateAndTime.Year(DateAndTime.Now));
			DateTimePicker5.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker3.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker9.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker13.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker11.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker1.Value = Conversions.ToDate(Conversions.ToDate("01/" + Conversions.ToString(DateAndTime.Month(DateTime.Now.Date)) + "/" + Conversions.ToString(DateAndTime.Year(DateTime.Now.Date))).ToString("dd/MM/yyy"));
			DateTimePicker1_ValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Button_GO_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL      WHERE    (year(Dates) = " + Conversions.ToDate("01/01/" + TextBox_ANNEE.Text).ToString("yyy") + " )              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				Label_CHIFFRE_ANNEE.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString()));
				while (((Control)Label_CHIFFRE_ANNEE).Width < TextRenderer.MeasureText(Label_CHIFFRE_ANNEE.Text, new Font(((Control)Label_CHIFFRE_ANNEE).Font.FontFamily, ((Control)Label_CHIFFRE_ANNEE).Font.Size, ((Control)Label_CHIFFRE_ANNEE).Font.Style)).Width)
				{
					((Control)Label_CHIFFRE_ANNEE).Font = new Font(((Control)Label_CHIFFRE_ANNEE).Font.FontFamily, ((Control)Label_CHIFFRE_ANNEE).Font.Size - 0.5f, ((Control)Label_CHIFFRE_ANNEE).Font.Style);
				}
				Module1.cn_SQL.Close();
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("MOIS", "MOIS");
				DataGrid_STATISTIQUE.Columns.Add("TOTAL", "TOTAL");
				DataGrid_STATISTIQUE.Columns.Add("MOIS_NAME", "MOIS_NAME");
				int num = 1;
				int num2;
				int num3;
				do
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						Strings.Format(num, "00"),
						"",
						Conversions.ToDate("01/" + Strings.Format(num, "00") + "/2000").ToString("MMM")
					});
					num++;
					num2 = num;
					num3 = 12;
				}
				while (num2 <= num3);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				int num4 = 0;
				int num5;
				do
				{
					dataTable.Clear();
					dataTable = new DataTable();
					val2 = new MySqlDataAdapter("select    sum(TOTAL_NET) as n     from  TABLE_VENTES_JOURNAL   WHERE         (MONTH(Dates) = " + Conversions.ToString(num4 + 1) + " )    and           (year(Dates) = " + Conversions.ToDate("01/01/" + TextBox_ANNEE.Text).ToString("yyy") + " )                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')              ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable);
					if (dataTable.Rows[0]["n"] == DBNull.Value)
					{
						DataGrid_STATISTIQUE.Rows[num4].Cells[1].Value = "0";
					}
					else
					{
						DataGrid_STATISTIQUE.Rows[num4].Cells[1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["n"]);
					}
					num4++;
					num5 = num4;
					num3 = 11;
				}
				while (num5 <= num3);
				dataTable.Clear();
				string text = (from row in ((IEnumerable)DataGrid_STATISTIQUE.Rows).Cast<object>().Select((Func<object, DataGridViewRow>)([SpecialName] (object row) =>
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Expected Obj, but got Unknown
						return (DataGridViewRow)row;
					}))
					where Operators.CompareString(row.Cells[1].FormattedValue.ToString(), string.Empty, TextCompare: false) != 0
					select Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells[1].FormattedValue))).Max().ToString();
				Label_TOP_MOIS_CHIFFRE.Text = Strings.FormatNumber(text);
				int num6 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num7 = 0;
				while (true)
				{
					int num8 = num7;
					num3 = num6;
					if (num8 > num3)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGrid_STATISTIQUE.Rows[num7].Cells[1].Value, text, TextCompare: false))
					{
						Label_TOP_MOIS.Text = Conversions.ToString(DataGrid_STATISTIQUE.Rows[num7].Cells[2].Value);
						break;
					}
					num7++;
				}
				((Collection<ChartArea>)(object)Chart1.ChartAreas).Clear();
				((Collection<Series>)(object)Chart1.Series).Clear();
				((Collection<Legend>)(object)Chart1.Legends).Clear();
				Series val3 = Chart1.Series.Add("Series1");
				val3.ChartType = (SeriesChartType)10;
				val3.Name = "Ventes Mensuelles";
				((DataPointCustomProperties)val3).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val3).LabelForeColor = Color.DimGray;
				((DataPointCustomProperties)val3).LabelFormat = "0.00";
				((DataPointCustomProperties)val3).Font = new Font("Segoe UI", 11f, (FontStyle)1);
				((DataPointCustomProperties)val3).MarkerStyle = (MarkerStyle)2;
				((DataPointCustomProperties)val3).MarkerSize = 8;
				Series val4 = Chart1.Series.Add("Series2");
				val4.ChartType = (SeriesChartType)4;
				((DataPointCustomProperties)val4).Color = Color.Gray;
				int num9 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num10 = 0;
				while (true)
				{
					int num11 = num10;
					num3 = num9;
					if (num11 > num3)
					{
						break;
					}
					val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num10].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num10].Value) });
					val4.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num10].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num10].Value) });
					num10++;
				}
				ChartArea val5 = Chart1.ChartAreas.Add("ChartArea1");
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Maximum = 13.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisY.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Height = 90f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Width = 100f;
				int num12 = 0;
				foreach (DataPoint item in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart1.Series)["Ventes Mensuelles"].Points)
				{
					string htmlColor = List_COLOR.Items[num12].ToString();
					((DataPointCustomProperties)item).Color = ColorTranslator.FromHtml(htmlColor);
					num12++;
				}
				Module1._QUITTER_PATIENTER = true;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				((Control)Panel26).Visible = true;
				Label_ARTICLE_TOP.Text = "";
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataGrid_STATISTIQUE.Columns.Add("Z", "Z");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select Code, Article, sum(Qté) as Qté   from TABLE_VENTES_JOURNAL    Where  Dates   between   ' " + Strings.Format(DateTimePicker5.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker6.Value, "yyyy-MM-dd") + " '        group by Article,Code        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
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
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["Code"].ToString(),
						dataTable.Rows[num2]["Article"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable.Rows[num2]["Qté"].ToString()))
					});
					num2++;
				}
				dataTable.Clear();
				DataTable dataTable2 = new DataTable("Location");
				dataTable2.Columns.Add("X", typeof(string));
				dataTable2.Columns.Add("Y", typeof(string));
				dataTable2.Columns.Add("Z", typeof(double));
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable2.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[1].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[2].Value));
					num6++;
				}
				dataTable2.AcceptChanges();
				DataView dataView = new DataView(dataTable2);
				dataView.Sort = "Z DESC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item in dataView)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(item["X"]),
						RuntimeHelpers.GetObjectValue(item["Y"]),
						RuntimeHelpers.GetObjectValue(item["Z"])
					});
				}
				if (DataGrid_STATISTIQUE.Rows.Count > 0)
				{
					Label_ARTICLE_TOP.Text = Conversions.ToString(DataGrid_STATISTIQUE.Rows[0].Cells[1].Value);
				}
				((Collection<ChartArea>)(object)Chart5.ChartAreas).Clear();
				((Collection<Series>)(object)Chart5.Series).Clear();
				((Collection<Legend>)(object)Chart5.Legends).Clear();
				ChartArea val2 = Chart5.ChartAreas.Add("ChartArea");
				Series val3 = Chart5.Series.Add("Series");
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart5.Series)["Series"]).Label = "#VALY";
				val3.ChartArea = val2.Name;
				val3.ChartType = (SeriesChartType)7;
				((DataPointCustomProperties)val3).Color = Color.Blue;
				((DataPointCustomProperties)val3).BorderWidth = 3;
				val3.ShadowColor = Color.Black;
				((DataPointCustomProperties)val3).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val3).LabelForeColor = Color.Black;
				if (DataGrid_STATISTIQUE.Rows.Count >= 10)
				{
					int num8 = 9;
					int num9;
					int num4;
					do
					{
						val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num8].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num8].Value) });
						num8 += -1;
						num9 = num8;
						num4 = 0;
					}
					while (num9 >= num4);
				}
				else if (DataGrid_STATISTIQUE.Rows.Count < 10)
				{
					int num10 = DataGrid_STATISTIQUE.Rows.Count - 1;
					while (true)
					{
						int num11 = num10;
						int num4 = 0;
						if (num11 < num4)
						{
							break;
						}
						val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num10].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num10].Value) });
						num10 += -1;
					}
				}
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart5.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				int num12 = 0;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart5.Series)["Series"].Points)
				{
					string htmlColor = List_COLOR.Items[num12].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num12++;
				}
				DataTable dataTable3 = new DataTable("Location");
				dataTable3.Columns.Add("X", typeof(string));
				dataTable3.Columns.Add("Y", typeof(string));
				dataTable3.Columns.Add("Z", typeof(double));
				int num13 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num14 = 0;
				while (true)
				{
					int num15 = num14;
					int num4 = num13;
					if (num15 > num4)
					{
						break;
					}
					dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[1].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[2].Value));
					num14++;
				}
				dataTable3.AcceptChanges();
				DataView dataView2 = new DataView(dataTable2);
				dataView2.Sort = "Z ASC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item3 in dataView2)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(item3["X"]),
						RuntimeHelpers.GetObjectValue(item3["Y"]),
						RuntimeHelpers.GetObjectValue(item3["Z"])
					});
				}
				DataGridView2.Rows.Clear();
				int num16 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num17 = 0;
				while (true)
				{
					int num18 = num17;
					int num4 = num16;
					if (num18 > num4)
					{
						break;
					}
					DataGridView2.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num17].Cells[0].Value),
						RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num17].Cells[1].Value),
						RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num17].Cells[2].Value)
					});
					num17++;
				}
				DataGridView2.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
				Module1._QUITTER_PATIENTER = true;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView4.Rows.Count == 0)
				{
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("JOUR", "JOUR");
				DataGrid_STATISTIQUE.Columns.Add("TOTAL", "TOTAL");
				DateTime date = Conversions.ToDate(DateTimePicker1.Text);
				DateTime date2 = Conversions.ToDate(DateTimePicker2.Text);
				int num = (int)DateAndTime.DateDiff(DateInterval.Day, date, date2);
				DateTime dateTime = Conversions.ToDate(DateTimePicker1.Text);
				int num2 = num;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						Strings.Format(dateTime, "dd/MM/yyyy"),
						""
					});
					dateTime = dateTime.AddDays(1.0);
					num3++;
				}
				string text = "";
				text = ((!Operators.ConditionalCompareObjectEqual(DataGridView4.Rows[((DataGridViewBand)DataGridView4.CurrentRow).Index].Cells[0].Value, "Tout Les Articles", TextCompare: false)) ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("  And    Article = '", DataGridView4.Rows[((DataGridViewBand)DataGridView4.CurrentRow).Index].Cells[0].Value), "'      ")) : "");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				int num6 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num7 = 0;
				while (true)
				{
					int num8 = num7;
					int num5 = num6;
					if (num8 > num5)
					{
						break;
					}
					dataTable.Clear();
					dataTable = new DataTable();
					val = new MySqlDataAdapter("select    sum(TOTAL_NET) as n     from  TABLE_VENTES_JOURNAL   WHERE    Dates   between   ' " + Strings.Format(Conversions.ToDate(DataGrid_STATISTIQUE.Rows[num7].Cells[0].Value), "yyyy-MM-dd") + " '     And      ' " + Strings.Format(Conversions.ToDate(DataGrid_STATISTIQUE.Rows[num7].Cells[0].Value), "yyyy-MM-dd") + " '                     " + text + "              ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows[0]["n"] == DBNull.Value)
					{
						DataGrid_STATISTIQUE.Rows[num7].Cells[1].Value = "0";
					}
					else
					{
						DataGrid_STATISTIQUE.Rows[num7].Cells[1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["n"]);
					}
					num7++;
				}
				dataTable.Clear();
				((Collection<ChartArea>)(object)Chart2.ChartAreas).Clear();
				((Collection<Series>)(object)Chart2.Series).Clear();
				((Collection<Legend>)(object)Chart2.Legends).Clear();
				Series val2 = Chart2.Series.Add("Series1");
				val2.Name = "Rapport Mensuel";
				((DataPointCustomProperties)val2).Color = Color.FromArgb(22, 106, 238);
				((DataPointCustomProperties)val2).BorderWidth = 3;
				val2.ShadowColor = Color.Black;
				((DataPointCustomProperties)val2).IsValueShownAsLabel = true;
				val2.SmartLabelStyle.Enabled = false;
				((DataPointCustomProperties)val2).LabelAngle = -90;
				((DataPointCustomProperties)val2).LabelForeColor = Color.Black;
				((DataPointCustomProperties)val2).LabelFormat = "0.0 DH";
				((DataPointCustomProperties)val2).MarkerStyle = (MarkerStyle)2;
				((DataPointCustomProperties)val2).MarkerSize = 8;
				val2.ChartType = (SeriesChartType)14;
				int num9 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num10 = 0;
				while (true)
				{
					int num11 = num10;
					int num5 = num9;
					if (num11 > num5)
					{
						break;
					}
					val2.Points.AddXY((object)("Le " + Strings.Format(Conversions.ToDate(DataGrid_STATISTIQUE[0, num10].Value), "dd")), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num10].Value) });
					num10++;
				}
				ChartArea val3 = Chart2.ChartAreas.Add("ChartArea1");
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Title = "Les Jours";
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Angle = -70;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Maximum = DataGrid_STATISTIQUE.Rows.Count + 1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisY.Title = "Total Net";
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].ShadowColor = Color.Blue;
				int num12 = 0;
				foreach (DataPoint item in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart2.Series)["Rapport Mensuel"].Points)
				{
					string htmlColor = List_COLOR.Items[num12].ToString();
					((DataPointCustomProperties)item).Color = ColorTranslator.FromHtml(htmlColor);
					num12++;
				}
				Module1._QUITTER_PATIENTER = true;
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

	private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
	{
		int num = DateAndTime.Month(DateTimePicker1.Value);
		int num2 = DateAndTime.Year(DateTimePicker1.Value);
		checked
		{
			num++;
			if (num == 13)
			{
				num = 1;
				num2++;
			}
			DateTime dateTime = Conversions.ToDate("01/" + Conversions.ToString(num) + "/" + Conversions.ToString(num2));
			DateTimePicker2.Value = DateAndTime.DateAdd("d", -1.0, dateTime);
		}
	}

	private void Panel_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				string text = "WHERE       Dates  between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '         ";
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                     and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')                      ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				Label26.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
				val.CommandText = "select COUNT(ID) From TABLE_VENTES_ENTETE                          " + text + "                     and            (OPERATION = 'VENTE')      ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				Label28.Text = Conversions.ToString(Conversion.Val(val.ExecuteScalar().ToString()));
				val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                   and            (OPERATION = 'RETOUR REMBOURSEMENT')  ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				Label30.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
				val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                   and             (OPERATION = 'RETOUR AVOIR')                  ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				Label36.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
				Module1.cn_SQL.Close();
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val2 = new MySqlDataAdapter("select  DISTINCT   MODE_P    from  TABLE_VENTES_REGLEMENTS      Where   Dates   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '                  ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					val3 = new MySqlDataAdapter("select   sum(MONTANT) as MONTANT    from   TABLE_VENTES_REGLEMENTS    Where   Dates   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '         And  MODE_P like '" + dataTable.Rows[num2]["MODE_P"].ToString() + "'        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val3).Fill(dataTable2);
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["MODE_P"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["MONTANT"].ToString()))
					});
					num2++;
				}
				dataTable.Clear();
				dataTable2.Clear();
				DataTable dataTable3 = new DataTable("Location");
				dataTable3.Columns.Add("X", typeof(string));
				dataTable3.Columns.Add("Y", typeof(double));
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[1].Value));
					num6++;
				}
				dataTable3.AcceptChanges();
				DataView dataView = new DataView(dataTable3);
				dataView.Sort = "Y DESC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item in dataView)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						RuntimeHelpers.GetObjectValue(item["X"]),
						RuntimeHelpers.GetObjectValue(item["Y"])
					});
				}
				((Collection<ChartArea>)(object)Chart7.ChartAreas).Clear();
				((Collection<Series>)(object)Chart7.Series).Clear();
				((Collection<Legend>)(object)Chart7.Legends).Clear();
				Series val4 = Chart7.Series.Add("series1");
				val4.ChartType = (SeriesChartType)18;
				((DataPointCustomProperties)val4).Color = Color.Blue;
				((DataPointCustomProperties)val4).BorderWidth = 3;
				val4.ShadowColor = Color.Black;
				((DataPointCustomProperties)val4).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val4).LabelForeColor = Color.Black;
				int num8 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val4.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[0, num9].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num9].Value) });
					num9++;
				}
				ChartArea val5 = Chart7.ChartAreas.Add("ChartArea");
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].Area3DStyle.Enable3D = true;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].Area3DStyle.PointDepth = 50;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].InnerPlotPosition.Height = 100f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart7.ChartAreas)["ChartArea"].InnerPlotPosition.Width = 100f;
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart7.Series)["series1"]).Label = "#VALX (#PERCENT{00.00 %} )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart7.Series)["series1"]).LegendText = "#VALX ( 'VALY DH )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart7.Series)["series1"])["PieLabelStyle"] = "Outside";
				((Collection<Legend>)(object)Chart7.Legends).Clear();
				Chart7.Legends.Add("Legend1");
				((Collection<Legend>)(object)Chart7.Legends)[0].Title = "MODE DE PAIEMENT";
				((Collection<Legend>)(object)Chart7.Legends)[0].LegendStyle = (LegendStyle)0;
				((Collection<Legend>)(object)Chart7.Legends)[0].TableStyle = (LegendTableStyle)1;
				((Collection<Legend>)(object)Chart7.Legends)[0].Alignment = (StringAlignment)0;
				((Collection<Legend>)(object)Chart7.Legends)[0].Docking = (Docking)1;
				((Collection<Legend>)(object)Chart7.Legends)[0].IsDockedInsideChartArea = false;
				((Collection<Legend>)(object)Chart7.Legends)[0].BorderColor = Color.White;
				((Collection<Legend>)(object)Chart7.Legends)[0].BackColor = Color.White;
				int num11 = 10;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart7.Series)["series1"].Points)
				{
					string htmlColor = List_COLOR.Items[num11].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num11++;
				}
				Module1._QUITTER_PATIENTER = true;
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

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				((Control)Panel38).Visible = true;
				Label_CLIENT_TOP.Text = "";
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataGrid_STATISTIQUE.Columns.Add("Z", "Z");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select   ID_Client,Client   from  TABLE_CLIENTS                   ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select   sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where   Dates   between   ' " + Strings.Format(DateTimePicker11.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker12.Value, "yyyy-MM-dd") + " '       And     ID_Client =  '" + dataTable.Rows[num2]["ID_Client"].ToString() + "'         ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["ID_Client"].ToString(),
						dataTable.Rows[num2]["Client"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))
					});
					num2++;
				}
				dataTable.Clear();
				dataTable2.Clear();
				DataTable dataTable3 = new DataTable("Location");
				dataTable3.Columns.Add("X", typeof(string));
				dataTable3.Columns.Add("Y", typeof(string));
				dataTable3.Columns.Add("Z", typeof(double));
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[1].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[2].Value));
					num6++;
				}
				dataTable3.AcceptChanges();
				DataView dataView = new DataView(dataTable3);
				dataView.Sort = "Z DESC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item in dataView)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(item["X"]),
						RuntimeHelpers.GetObjectValue(item["Y"]),
						RuntimeHelpers.GetObjectValue(item["Z"])
					});
				}
				if (DataGrid_STATISTIQUE.Rows.Count > 0)
				{
					Label_CLIENT_TOP.Text = Conversions.ToString(DataGrid_STATISTIQUE.Rows[0].Cells[1].Value);
				}
				((Collection<ChartArea>)(object)Chart6.ChartAreas).Clear();
				((Collection<Series>)(object)Chart6.Series).Clear();
				((Collection<Legend>)(object)Chart6.Legends).Clear();
				ChartArea val3 = Chart6.ChartAreas.Add("ChartArea");
				Series val4 = Chart6.Series.Add("Series");
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart6.Series)["Series"]).Label = "#VALY";
				val4.ChartArea = val3.Name;
				val4.ChartType = (SeriesChartType)7;
				((DataPointCustomProperties)val4).Color = Color.Blue;
				((DataPointCustomProperties)val4).BorderWidth = 3;
				val4.ShadowColor = Color.Black;
				((DataPointCustomProperties)val4).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val4).LabelForeColor = Color.Black;
				if (DataGrid_STATISTIQUE.Rows.Count >= 10)
				{
					int num8 = 9;
					int num9;
					int num4;
					do
					{
						val4.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num8].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num8].Value) });
						num8 += -1;
						num9 = num8;
						num4 = 0;
					}
					while (num9 >= num4);
				}
				else if (DataGrid_STATISTIQUE.Rows.Count < 10)
				{
					int num10 = DataGrid_STATISTIQUE.Rows.Count - 1;
					while (true)
					{
						int num11 = num10;
						int num4 = 0;
						if (num11 < num4)
						{
							break;
						}
						val4.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num10].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num10].Value) });
						num10 += -1;
					}
				}
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart6.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				int num12 = 0;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart6.Series)["Series"].Points)
				{
					string htmlColor = List_COLOR.Items[num12].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num12++;
				}
				DataTable dataTable4 = new DataTable("Location");
				dataTable4.Columns.Add("X", typeof(string));
				dataTable4.Columns.Add("Y", typeof(string));
				dataTable4.Columns.Add("Z", typeof(double));
				int num13 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num14 = 0;
				while (true)
				{
					int num15 = num14;
					int num4 = num13;
					if (num15 > num4)
					{
						break;
					}
					dataTable4.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[1].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num14].Cells[2].Value));
					num14++;
				}
				dataTable4.AcceptChanges();
				DataView dataView2 = new DataView(dataTable3);
				dataView2.Sort = "Z ASC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item3 in dataView2)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(item3["X"]),
						RuntimeHelpers.GetObjectValue(item3["Y"]),
						RuntimeHelpers.GetObjectValue(item3["Z"])
					});
				}
				DataGridView3.Rows.Clear();
				int num16 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num17 = 0;
				while (true)
				{
					int num18 = num17;
					int num4 = num16;
					if (num18 > num4)
					{
						break;
					}
					DataGridView3.Rows.Add(new object[3]
					{
						RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num17].Cells[0].Value),
						RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num17].Cells[1].Value),
						Operators.ConcatenateObject(DataGrid_STATISTIQUE.Rows[num17].Cells[2].Value, " DH")
					});
					num17++;
				}
				DataGridView3.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView3.DefaultCellStyle.SelectionForeColor = Color.Black;
				Module1._QUITTER_PATIENTER = true;
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

	private void Label9_Click(object sender, EventArgs e)
	{
		TextBox_ANNEE.Text = Conversions.ToString(Conversion.Val(TextBox_ANNEE.Text) - 1.0);
	}

	private void Label14_Click(object sender, EventArgs e)
	{
		TextBox_ANNEE.Text = Conversions.ToString(Conversion.Val(TextBox_ANNEE.Text) + 1.0);
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				((Control)Panel25).Visible = true;
				Label_CAISSIER_TOP.Text = "";
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select  DISTINCT   Caissier    from  TABLE_VENTES_JOURNAL      Where   Dates   between   ' " + Strings.Format(DateTimePicker13.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker14.Value, "yyyy-MM-dd") + " '                  ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select   sum(Total_Net) as Total_Net    from   TABLE_VENTES_JOURNAL    Where   Dates   between   ' " + Strings.Format(DateTimePicker13.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker14.Value, "yyyy-MM-dd") + " '         And  caissier like '" + dataTable.Rows[num2]["Caissier"].ToString() + "'        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["Caissier"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Total_Net"].ToString()))
					});
					num2++;
				}
				dataTable.Clear();
				dataTable2.Clear();
				DataTable dataTable3 = new DataTable("Location");
				dataTable3.Columns.Add("X", typeof(string));
				dataTable3.Columns.Add("Y", typeof(double));
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[1].Value));
					num6++;
				}
				dataTable3.AcceptChanges();
				DataView dataView = new DataView(dataTable3);
				dataView.Sort = "Y DESC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item in dataView)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						RuntimeHelpers.GetObjectValue(item["X"]),
						RuntimeHelpers.GetObjectValue(item["Y"])
					});
				}
				if (DataGrid_STATISTIQUE.Rows.Count > 0)
				{
					Label_CAISSIER_TOP.Text = Conversions.ToString(DataGrid_STATISTIQUE.Rows[0].Cells[0].Value);
				}
				((Collection<ChartArea>)(object)Chart3.ChartAreas).Clear();
				((Collection<Series>)(object)Chart3.Series).Clear();
				((Collection<Legend>)(object)Chart3.Legends).Clear();
				Series val3 = Chart3.Series.Add("series1");
				val3.ChartType = (SeriesChartType)18;
				((DataPointCustomProperties)val3).Color = Color.Blue;
				((DataPointCustomProperties)val3).BorderWidth = 3;
				val3.ShadowColor = Color.Black;
				((DataPointCustomProperties)val3).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val3).LabelForeColor = Color.Black;
				int num8 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[0, num9].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num9].Value) });
					num9++;
				}
				ChartArea val4 = Chart3.ChartAreas.Add("ChartArea");
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].Area3DStyle.Enable3D = true;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].Area3DStyle.PointDepth = 50;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].InnerPlotPosition.Height = 100f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].InnerPlotPosition.Width = 100f;
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["series1"]).Label = "#VALX (#PERCENT{00.00 %} )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["series1"]).LegendText = "#VALX ( 'VALY DH )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["series1"])["PieLabelStyle"] = "Outside";
				((Collection<Legend>)(object)Chart3.Legends).Clear();
				Chart3.Legends.Add("Legend1");
				((Collection<Legend>)(object)Chart3.Legends)[0].LegendStyle = (LegendStyle)0;
				((Collection<Legend>)(object)Chart3.Legends)[0].TableStyle = (LegendTableStyle)1;
				((Collection<Legend>)(object)Chart3.Legends)[0].Alignment = (StringAlignment)0;
				((Collection<Legend>)(object)Chart3.Legends)[0].Docking = (Docking)1;
				((Collection<Legend>)(object)Chart3.Legends)[0].IsDockedInsideChartArea = false;
				((Collection<Legend>)(object)Chart3.Legends)[0].BorderColor = Color.White;
				((Collection<Legend>)(object)Chart3.Legends)[0].BackColor = Color.White;
				int num11 = 0;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["series1"].Points)
				{
					string htmlColor = List_COLOR.Items[num11].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num11++;
				}
				Module1._QUITTER_PATIENTER = true;
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

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				((Control)Panel32).Visible = true;
				Label_VENDEUR_TOP.Text = "";
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select  DISTINCT   Vendeur    from  TABLE_VENTES_JOURNAL      Where   Dates   between   ' " + Strings.Format(DateTimePicker9.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker10.Value, "yyyy-MM-dd") + " '                  ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select   sum(Total_Net) as Total_Net    from   TABLE_VENTES_JOURNAL    Where   Dates   between   ' " + Strings.Format(DateTimePicker9.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker10.Value, "yyyy-MM-dd") + " '         And  Vendeur like '" + dataTable.Rows[num2]["Vendeur"].ToString() + "'        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["Vendeur"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Total_Net"].ToString()))
					});
					num2++;
				}
				dataTable.Clear();
				dataTable2.Clear();
				DataTable dataTable3 = new DataTable("Location");
				dataTable3.Columns.Add("X", typeof(string));
				dataTable3.Columns.Add("Y", typeof(double));
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[0].Value), RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE.Rows[num6].Cells[1].Value));
					num6++;
				}
				dataTable3.AcceptChanges();
				DataView dataView = new DataView(dataTable3);
				dataView.Sort = "Y DESC";
				DataGrid_STATISTIQUE.Rows.Clear();
				foreach (DataRowView item in dataView)
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[2]
					{
						RuntimeHelpers.GetObjectValue(item["X"]),
						RuntimeHelpers.GetObjectValue(item["Y"])
					});
				}
				if (DataGrid_STATISTIQUE.Rows.Count > 0)
				{
					Label_VENDEUR_TOP.Text = Conversions.ToString(DataGrid_STATISTIQUE.Rows[0].Cells[0].Value);
				}
				((Collection<ChartArea>)(object)Chart4.ChartAreas).Clear();
				((Collection<Series>)(object)Chart4.Series).Clear();
				((Collection<Legend>)(object)Chart4.Legends).Clear();
				Series val3 = Chart4.Series.Add("series1");
				val3.ChartType = (SeriesChartType)18;
				((DataPointCustomProperties)val3).Color = Color.Blue;
				((DataPointCustomProperties)val3).BorderWidth = 3;
				val3.ShadowColor = Color.Black;
				((DataPointCustomProperties)val3).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val3).LabelForeColor = Color.Black;
				int num8 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[0, num9].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num9].Value) });
					num9++;
				}
				ChartArea val4 = Chart4.ChartAreas.Add("ChartArea");
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].Area3DStyle.Enable3D = true;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].Area3DStyle.PointDepth = 50;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].InnerPlotPosition.Height = 100f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].InnerPlotPosition.Width = 100f;
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart4.Series)["series1"]).Label = "#VALX (#PERCENT{00.00 %} )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart4.Series)["series1"]).LegendText = "#VALX ( 'VALY DH )";
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart4.Series)["series1"])["PieLabelStyle"] = "Outside";
				((Collection<Legend>)(object)Chart4.Legends).Clear();
				Chart4.Legends.Add("Legend1");
				((Collection<Legend>)(object)Chart4.Legends)[0].LegendStyle = (LegendStyle)0;
				((Collection<Legend>)(object)Chart4.Legends)[0].TableStyle = (LegendTableStyle)1;
				((Collection<Legend>)(object)Chart4.Legends)[0].Alignment = (StringAlignment)0;
				((Collection<Legend>)(object)Chart4.Legends)[0].Docking = (Docking)1;
				((Collection<Legend>)(object)Chart4.Legends)[0].IsDockedInsideChartArea = false;
				((Collection<Legend>)(object)Chart4.Legends)[0].BorderColor = Color.White;
				((Collection<Legend>)(object)Chart4.Legends)[0].BackColor = Color.White;
				int num11 = 0;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart4.Series)["series1"].Points)
				{
					string htmlColor = List_COLOR.Items[num11].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num11++;
				}
				Module1._QUITTER_PATIENTER = true;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select Article from TABLE_ARTICLES  order by Article asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView4.Rows.Clear();
				DataGridView4.Rows.Add(new object[1] { "Tout Les Articles" });
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
					DataGridView4.Rows.Add(new object[1] { dataTable.Rows[num2]["Article"].ToString() });
					num2++;
				}
				dataTable.Clear();
				Module1._QUITTER_PATIENTER = true;
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
}
