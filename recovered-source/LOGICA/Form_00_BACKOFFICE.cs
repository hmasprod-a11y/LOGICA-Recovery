using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using SaaUI;

namespace LOGICA;

[DesignerGenerated]
public class Form_00_BACKOFFICE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("XdxToolStripMenuItem")]
	private ToolStripMenuItem _XdxToolStripMenuItem;

	[AccessedThroughProperty("Panel")]
	private Panel _Panel;

	[AccessedThroughProperty("SaaPanel1")]
	private SaaPanel _SaaPanel1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("BunifuButton1")]
	private BunifuButton _BunifuButton1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label_CONNEXION_1")]
	private SaaGlowing _Label_CONNEXION_1;

	[AccessedThroughProperty("Label_DB_1")]
	private Label _Label_DB_1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("SaaPanel9")]
	private SaaPanel _SaaPanel9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label_TOTAL_REMISE")]
	private Label _Label_TOTAL_REMISE;

	[AccessedThroughProperty("Label_TOTAL_OFFERT")]
	private Label _Label_TOTAL_OFFERT;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("SaaPanel2")]
	private SaaPanel _SaaPanel2;

	[AccessedThroughProperty("Label_TOTAL_VENTES")]
	private Label _Label_TOTAL_VENTES;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("SaaPanel4")]
	private SaaPanel _SaaPanel4;

	[AccessedThroughProperty("Label_NBR_TICKETS")]
	private Label _Label_NBR_TICKETS;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("SaaPanel7")]
	private SaaPanel _SaaPanel7;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label_TOTAL_RETOUR_AVOIR")]
	private Label _Label_TOTAL_RETOUR_AVOIR;

	[AccessedThroughProperty("PictureBox22")]
	private PictureBox _PictureBox22;

	[AccessedThroughProperty("SaaPanel5")]
	private SaaPanel _SaaPanel5;

	[AccessedThroughProperty("Label_TOTAL_RETOUR_REMB")]
	private Label _Label_TOTAL_RETOUR_REMB;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	[AccessedThroughProperty("Button_RJ1")]
	private Button_RJ _Button_RJ1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("SaaPanel3")]
	private SaaPanel _SaaPanel3;

	[AccessedThroughProperty("BunifuButton2")]
	private BunifuButton _BunifuButton2;

	[AccessedThroughProperty("Chart1")]
	private Chart _Chart1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TableLayoutPanel3")]
	private TableLayoutPanel _TableLayoutPanel3;

	[AccessedThroughProperty("SaaPanel8")]
	private SaaPanel _SaaPanel8;

	[AccessedThroughProperty("BunifuButton4")]
	private BunifuButton _BunifuButton4;

	[AccessedThroughProperty("Panel26")]
	private Panel _Panel26;

	[AccessedThroughProperty("Label_ARTICLE_TOP")]
	private Label _Label_ARTICLE_TOP;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Chart3")]
	private Chart _Chart3;

	[AccessedThroughProperty("SaaPanel6")]
	private SaaPanel _SaaPanel6;

	[AccessedThroughProperty("BunifuButton3")]
	private BunifuButton _BunifuButton3;

	[AccessedThroughProperty("Chart7")]
	private Chart _Chart7;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("TableLayoutPanel4")]
	private TableLayoutPanel _TableLayoutPanel4;

	[AccessedThroughProperty("SaaPanel10")]
	private SaaPanel _SaaPanel10;

	[AccessedThroughProperty("Panel38")]
	private Panel _Panel38;

	[AccessedThroughProperty("Label_CLIENT_TOP")]
	private Label _Label_CLIENT_TOP;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Chart4")]
	private Chart _Chart4;

	[AccessedThroughProperty("SaaPanel11")]
	private SaaPanel _SaaPanel11;

	[AccessedThroughProperty("Chart2")]
	private Chart _Chart2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("BunifuButton5")]
	private BunifuButton _BunifuButton5;

	[AccessedThroughProperty("BunifuButton7")]
	private BunifuButton _BunifuButton7;

	[AccessedThroughProperty("BunifuButton6")]
	private BunifuButton _BunifuButton6;

	[AccessedThroughProperty("BunifuButton8")]
	private BunifuButton _BunifuButton8;

	[AccessedThroughProperty("DataGrid_STATISTIQUE")]
	private DataGridView _DataGrid_STATISTIQUE;

	[AccessedThroughProperty("List_COLOR")]
	private ListBox _List_COLOR;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("BunifuDatePicker2")]
	private BunifuDatePicker _BunifuDatePicker2;

	[AccessedThroughProperty("BunifuDatePicker1")]
	private BunifuDatePicker _BunifuDatePicker1;

	internal virtual ToolStripMenuItem XdxToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _XdxToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XdxToolStripMenuItem = value;
		}
	}

	internal virtual Panel Panel
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel = value;
		}
	}

	internal virtual SaaPanel SaaPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel1 = value;
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

	internal virtual BunifuButton BunifuButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton1_Click;
			if (_BunifuButton1 != null)
			{
				((Control)_BunifuButton1).Click -= eventHandler;
			}
			_BunifuButton1 = value;
			if (_BunifuButton1 != null)
			{
				((Control)_BunifuButton1).Click += eventHandler;
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

	internal virtual SaaGlowing Label_CONNEXION_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CONNEXION_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CONNEXION_1 = value;
		}
	}

	internal virtual Label Label_DB_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DB_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DB_1 = value;
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
			_PictureBox1 = value;
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

	internal virtual SaaPanel SaaPanel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel9 = value;
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

	internal virtual Label Label_TOTAL_REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_REMISE = value;
		}
	}

	internal virtual Label Label_TOTAL_OFFERT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_OFFERT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_OFFERT = value;
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

	internal virtual SaaPanel SaaPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel2 = value;
		}
	}

	internal virtual Label Label_TOTAL_VENTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_VENTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_VENTES = value;
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

	internal virtual SaaPanel SaaPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel4 = value;
		}
	}

	internal virtual Label Label_NBR_TICKETS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_NBR_TICKETS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_NBR_TICKETS = value;
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

	internal virtual SaaPanel SaaPanel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel7 = value;
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

	internal virtual Label Label_TOTAL_RETOUR_AVOIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_RETOUR_AVOIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_RETOUR_AVOIR = value;
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

	internal virtual SaaPanel SaaPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel5 = value;
		}
	}

	internal virtual Label Label_TOTAL_RETOUR_REMB
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_RETOUR_REMB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_RETOUR_REMB = value;
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

	internal virtual Button_RJ Button_RJ1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ1_Click;
			if (_Button_RJ1 != null)
			{
				((Control)_Button_RJ1).Click -= eventHandler;
			}
			_Button_RJ1 = value;
			if (_Button_RJ1 != null)
			{
				((Control)_Button_RJ1).Click += eventHandler;
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

	internal virtual SaaPanel SaaPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel3 = value;
		}
	}

	internal virtual BunifuButton BunifuButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton2_Click;
			if (_BunifuButton2 != null)
			{
				((Control)_BunifuButton2).Click -= eventHandler;
			}
			_BunifuButton2 = value;
			if (_BunifuButton2 != null)
			{
				((Control)_BunifuButton2).Click += eventHandler;
			}
		}
	}

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

	internal virtual SaaPanel SaaPanel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel8 = value;
		}
	}

	internal virtual BunifuButton BunifuButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton4_Click;
			if (_BunifuButton4 != null)
			{
				((Control)_BunifuButton4).Click -= eventHandler;
			}
			_BunifuButton4 = value;
			if (_BunifuButton4 != null)
			{
				((Control)_BunifuButton4).Click += eventHandler;
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

	internal virtual SaaPanel SaaPanel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel6 = value;
		}
	}

	internal virtual BunifuButton BunifuButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton3_Click;
			if (_BunifuButton3 != null)
			{
				((Control)_BunifuButton3).Click -= eventHandler;
			}
			_BunifuButton3 = value;
			if (_BunifuButton3 != null)
			{
				((Control)_BunifuButton3).Click += eventHandler;
			}
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

	internal virtual SaaPanel SaaPanel10
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel10 = value;
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

	internal virtual SaaPanel SaaPanel11
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaaPanel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaaPanel11 = value;
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

	internal virtual BunifuButton BunifuButton5
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton5_Click;
			if (_BunifuButton5 != null)
			{
				((Control)_BunifuButton5).Click -= eventHandler;
			}
			_BunifuButton5 = value;
			if (_BunifuButton5 != null)
			{
				((Control)_BunifuButton5).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuButton BunifuButton7
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton7_Click;
			if (_BunifuButton7 != null)
			{
				((Control)_BunifuButton7).Click -= eventHandler;
			}
			_BunifuButton7 = value;
			if (_BunifuButton7 != null)
			{
				((Control)_BunifuButton7).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuButton BunifuButton6
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton6_Click;
			if (_BunifuButton6 != null)
			{
				((Control)_BunifuButton6).Click -= eventHandler;
			}
			_BunifuButton6 = value;
			if (_BunifuButton6 != null)
			{
				((Control)_BunifuButton6).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuButton BunifuButton8
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuButton8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuButton8_Click;
			if (_BunifuButton8 != null)
			{
				((Control)_BunifuButton8).Click -= eventHandler;
			}
			_BunifuButton8 = value;
			if (_BunifuButton8 != null)
			{
				((Control)_BunifuButton8).Click += eventHandler;
			}
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

	internal virtual BunifuDatePicker BunifuDatePicker2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuDatePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuDatePicker2 = value;
		}
	}

	internal virtual BunifuDatePicker BunifuDatePicker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuDatePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuDatePicker1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_00_BACKOFFICE()
	{
		((Form)this).Load += Form_00_BACKOFFICE_Load;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
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
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Expected Obj, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1445: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got Unknown
		//IL_1740: Unknown result type (might be due to invalid IL or missing references)
		//IL_174a: Expected Obj, but got Unknown
		//IL_183d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Expected Obj, but got Unknown
		//IL_1ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2006: Expected Obj, but got Unknown
		//IL_20f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2505: Unknown result type (might be due to invalid IL or missing references)
		//IL_2550: Unknown result type (might be due to invalid IL or missing references)
		//IL_2556: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c5: Expected Obj, but got Unknown
		//IL_2800: Unknown result type (might be due to invalid IL or missing references)
		//IL_280a: Expected Obj, but got Unknown
		//IL_28fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2903: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4c: Expected Obj, but got Unknown
		//IL_3087: Unknown result type (might be due to invalid IL or missing references)
		//IL_3091: Expected Obj, but got Unknown
		//IL_3184: Unknown result type (might be due to invalid IL or missing references)
		//IL_318a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3647: Unknown result type (might be due to invalid IL or missing references)
		//IL_364d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3698: Unknown result type (might be due to invalid IL or missing references)
		//IL_369e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3703: Unknown result type (might be due to invalid IL or missing references)
		//IL_370d: Expected Obj, but got Unknown
		//IL_3948: Unknown result type (might be due to invalid IL or missing references)
		//IL_3952: Expected Obj, but got Unknown
		//IL_3a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bdd: Expected Obj, but got Unknown
		//IL_4773: Unknown result type (might be due to invalid IL or missing references)
		//IL_4779: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_482f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4839: Expected Obj, but got Unknown
		//IL_4a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a7e: Expected Obj, but got Unknown
		//IL_4b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_5196: Unknown result type (might be due to invalid IL or missing references)
		//IL_519c: Unknown result type (might be due to invalid IL or missing references)
		//IL_51e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_5252: Unknown result type (might be due to invalid IL or missing references)
		//IL_525c: Expected Obj, but got Unknown
		//IL_5497: Unknown result type (might be due to invalid IL or missing references)
		//IL_54a1: Expected Obj, but got Unknown
		//IL_5582: Unknown result type (might be due to invalid IL or missing references)
		//IL_5588: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_00_BACKOFFICE));
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		ChartArea val3 = new ChartArea();
		Legend val4 = new Legend();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		ChartArea val6 = new ChartArea();
		Legend val7 = new Legend();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		ChartArea val9 = new ChartArea();
		Legend val10 = new Legend();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		ChartArea val12 = new ChartArea();
		Legend val13 = new Legend();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		ChartArea val15 = new ChartArea();
		Legend val16 = new Legend();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges val18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
		XdxToolStripMenuItem = new ToolStripMenuItem();
		Panel = new Panel();
		Panel1 = new Panel();
		Button_RJ1 = new Button_RJ();
		Label_CONNEXION_1 = new SaaGlowing();
		Label_DB_1 = new Label();
		PictureBox1 = new PictureBox();
		Panel2 = new Panel();
		PictureBox3 = new PictureBox();
		BunifuButton1 = new BunifuButton();
		BunifuDatePicker2 = new BunifuDatePicker();
		Panel4 = new Panel();
		TableLayoutPanel4 = new TableLayoutPanel();
		SaaPanel10 = new SaaPanel();
		BunifuButton7 = new BunifuButton();
		Panel38 = new Panel();
		Label_CLIENT_TOP = new Label();
		PictureBox9 = new PictureBox();
		Label9 = new Label();
		Chart4 = new Chart();
		SaaPanel11 = new SaaPanel();
		BunifuButton6 = new BunifuButton();
		Chart2 = new Chart();
		Label4 = new Label();
		SaaPanel3 = new SaaPanel();
		BunifuButton2 = new BunifuButton();
		Chart1 = new Chart();
		Label1 = new Label();
		TableLayoutPanel3 = new TableLayoutPanel();
		SaaPanel8 = new SaaPanel();
		BunifuButton4 = new BunifuButton();
		Panel26 = new Panel();
		Label_ARTICLE_TOP = new Label();
		PictureBox19 = new PictureBox();
		Label5 = new Label();
		Chart3 = new Chart();
		SaaPanel6 = new SaaPanel();
		BunifuButton3 = new BunifuButton();
		Chart7 = new Chart();
		Label3 = new Label();
		BunifuDatePicker1 = new BunifuDatePicker();
		TableLayoutPanel2 = new TableLayoutPanel();
		SaaPanel9 = new SaaPanel();
		Label10 = new Label();
		Label8 = new Label();
		Label_TOTAL_REMISE = new Label();
		Label_TOTAL_OFFERT = new Label();
		PictureBox2 = new PictureBox();
		SaaPanel2 = new SaaPanel();
		Label_TOTAL_VENTES = new Label();
		Label27 = new Label();
		PictureBox17 = new PictureBox();
		SaaPanel4 = new SaaPanel();
		Label_NBR_TICKETS = new Label();
		Label29 = new Label();
		PictureBox20 = new PictureBox();
		SaaPanel7 = new SaaPanel();
		BunifuButton5 = new BunifuButton();
		Label36 = new Label();
		Label_TOTAL_RETOUR_AVOIR = new Label();
		PictureBox22 = new PictureBox();
		SaaPanel5 = new SaaPanel();
		Label_TOTAL_RETOUR_REMB = new Label();
		Label35 = new Label();
		PictureBox21 = new PictureBox();
		SaaPanel1 = new SaaPanel();
		BunifuButton8 = new BunifuButton();
		Label6 = new Label();
		DataGrid_STATISTIQUE = new DataGridView();
		List_COLOR = new ListBox();
		((Control)Panel).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)TableLayoutPanel4).SuspendLayout();
		((Control)SaaPanel10).SuspendLayout();
		((Control)Panel38).SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)Chart4).BeginInit();
		((Control)SaaPanel11).SuspendLayout();
		((ISupportInitialize)Chart2).BeginInit();
		((Control)SaaPanel3).SuspendLayout();
		((ISupportInitialize)Chart1).BeginInit();
		((Control)TableLayoutPanel3).SuspendLayout();
		((Control)SaaPanel8).SuspendLayout();
		((Control)Panel26).SuspendLayout();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)Chart3).BeginInit();
		((Control)SaaPanel6).SuspendLayout();
		((ISupportInitialize)Chart7).BeginInit();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)SaaPanel9).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)SaaPanel2).SuspendLayout();
		((ISupportInitialize)PictureBox17).BeginInit();
		((Control)SaaPanel4).SuspendLayout();
		((ISupportInitialize)PictureBox20).BeginInit();
		((Control)SaaPanel7).SuspendLayout();
		((ISupportInitialize)PictureBox22).BeginInit();
		((Control)SaaPanel5).SuspendLayout();
		((ISupportInitialize)PictureBox21).BeginInit();
		((Control)SaaPanel1).SuspendLayout();
		((ISupportInitialize)DataGrid_STATISTIQUE).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStripItem)XdxToolStripMenuItem).Name = "XdxToolStripMenuItem";
		componentResourceManager.ApplyResources(XdxToolStripMenuItem, "XdxToolStripMenuItem");
		((Control)Panel).BackColor = Color.White;
		((Control)Panel).Controls.Add((Control)(object)Panel1);
		((Control)Panel).Controls.Add((Control)(object)Panel2);
		((Control)Panel).Controls.Add((Control)(object)SaaPanel1);
		componentResourceManager.ApplyResources(Panel, "Panel");
		((Control)Panel).Name = "Panel";
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).Controls.Add((Control)(object)Button_RJ1);
		((Control)Panel1).Controls.Add((Control)(object)Label_CONNEXION_1);
		((Control)Panel1).Controls.Add((Control)(object)Label_DB_1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel1).Name = "Panel1";
		Button_RJ1._BackgroundColor = Color.Transparent;
		Button_RJ1._BorderColor = Color.DeepPink;
		Button_RJ1._BorderRadius = 15;
		Button_RJ1._BorderSize = 2;
		Button_RJ1._TextColor = Color.DimGray;
		((ButtonBase)Button_RJ1).BackColor = Color.Transparent;
		((Control)Button_RJ1).Cursor = Cursors.Hand;
		((ButtonBase)Button_RJ1).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_RJ1, "Button_RJ1");
		((Control)Button_RJ1).ForeColor = Color.Black;
		((Control)Button_RJ1).Name = "Button_RJ1";
		((ButtonBase)Button_RJ1).UseVisualStyleBackColor = false;
		((Control)Label_CONNEXION_1).BackColor = Color.Transparent;
		Label_CONNEXION_1.Color = Color.Black;
		Label_CONNEXION_1.ForceTransparence = false;
		Label_CONNEXION_1.GrowingSpeed = 5;
		componentResourceManager.ApplyResources(Label_CONNEXION_1, "Label_CONNEXION_1");
		((Control)Label_CONNEXION_1).Name = "Label_CONNEXION_1";
		Label_CONNEXION_1.Stop = false;
		((Control)Label_DB_1).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_DB_1, "Label_DB_1");
		((Control)Label_DB_1).ForeColor = Color.Black;
		((Control)Label_DB_1).Name = "Label_DB_1";
		componentResourceManager.ApplyResources(PictureBox1, "PictureBox1");
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox1.TabStop = false;
		componentResourceManager.ApplyResources(Panel2, "Panel2");
		((Control)Panel2).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel2).Controls.Add((Control)(object)BunifuButton1);
		((Control)Panel2).Controls.Add((Control)(object)BunifuDatePicker2);
		((Control)Panel2).Controls.Add((Control)(object)Panel4);
		((Control)Panel2).Controls.Add((Control)(object)TableLayoutPanel4);
		((Control)Panel2).Controls.Add((Control)(object)SaaPanel3);
		((Control)Panel2).Controls.Add((Control)(object)TableLayoutPanel3);
		((Control)Panel2).Controls.Add((Control)(object)BunifuDatePicker1);
		((Control)Panel2).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel2).Name = "Panel2";
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		BunifuButton1.AllowAnimations = true;
		BunifuButton1.AllowMouseEffects = true;
		BunifuButton1.AllowToggling = false;
		componentResourceManager.ApplyResources(BunifuButton1, "BunifuButton1");
		BunifuButton1.AnimationSpeed = 200;
		BunifuButton1.AutoGenerateColors = false;
		BunifuButton1.AutoRoundBorders = true;
		BunifuButton1.AutoSizeLeftIcon = true;
		BunifuButton1.AutoSizeRightIcon = true;
		BunifuButton1.BackColor = Color.Transparent;
		BunifuButton1.BackColor1 = Color.Transparent;
		BunifuButton1.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton1.ButtonText = "Charger";
		BunifuButton1.ButtonTextMarginLeft = 0;
		BunifuButton1.ColorContrastOnClick = 45;
		BunifuButton1.ColorContrastOnHover = 45;
		((Control)BunifuButton1).Cursor = Cursors.Hand;
		val.BottomLeft = true;
		val.BottomRight = true;
		val.TopLeft = true;
		val.TopRight = true;
		BunifuButton1.CustomizableEdges = val;
		BunifuButton1.DialogResult = (DialogResult)0;
		BunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton1.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton1.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton1.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton1.ForeColor = Color.Black;
		BunifuButton1.IconLeftAlign = (ContentAlignment)16;
		BunifuButton1.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton = BunifuButton1;
		Padding iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton.IconLeftPadding = iconLeftPadding;
		BunifuButton1.IconMarginLeft = 11;
		BunifuButton1.IconPadding = 2;
		BunifuButton1.IconRightAlign = (ContentAlignment)64;
		BunifuButton1.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton2 = BunifuButton1;
		iconLeftPadding = new Padding(1);
		bunifuButton2.IconRightPadding = iconLeftPadding;
		BunifuButton1.IconSize = 11;
		BunifuButton1.IdleBorderColor = Color.FromArgb(22, 106, 238);
		BunifuButton1.IdleBorderRadius = 30;
		BunifuButton1.IdleBorderThickness = 1;
		BunifuButton1.IdleFillColor = Color.Transparent;
		BunifuButton1.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton1.IdleIconLeftImage");
		BunifuButton1.IdleIconRightImage = null;
		BunifuButton1.IndicateFocus = false;
		((Control)BunifuButton1).Name = "BunifuButton1";
		BunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton1.OnDisabledState.BorderRadius = 33;
		BunifuButton1.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton1.OnDisabledState.BorderThickness = 1;
		BunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton1.OnDisabledState.IconLeftImage = null;
		BunifuButton1.OnDisabledState.IconRightImage = null;
		BunifuButton1.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton1.onHoverState.BorderRadius = 33;
		BunifuButton1.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton1.onHoverState.BorderThickness = 1;
		BunifuButton1.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton1.onHoverState.ForeColor = Color.White;
		BunifuButton1.onHoverState.IconLeftImage = null;
		BunifuButton1.onHoverState.IconRightImage = null;
		BunifuButton1.OnIdleState.BorderColor = Color.FromArgb(22, 106, 238);
		BunifuButton1.OnIdleState.BorderRadius = 33;
		BunifuButton1.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton1.OnIdleState.BorderThickness = 1;
		BunifuButton1.OnIdleState.FillColor = Color.Transparent;
		BunifuButton1.OnIdleState.ForeColor = Color.Black;
		BunifuButton1.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton1.OnIdleState.IconLeftImage");
		BunifuButton1.OnIdleState.IconRightImage = null;
		BunifuButton1.OnPressedState.BorderColor = Color.FromArgb(22, 106, 238);
		BunifuButton1.OnPressedState.BorderRadius = 33;
		BunifuButton1.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton1.OnPressedState.BorderThickness = 1;
		BunifuButton1.OnPressedState.FillColor = Color.White;
		BunifuButton1.OnPressedState.ForeColor = Color.White;
		BunifuButton1.OnPressedState.IconLeftImage = null;
		BunifuButton1.OnPressedState.IconRightImage = null;
		BunifuButton1.TextAlign = (ContentAlignment)64;
		BunifuButton1.TextAlignment = (HorizontalAlignment)2;
		BunifuButton1.TextMarginLeft = 0;
		BunifuButton bunifuButton3 = BunifuButton1;
		iconLeftPadding = new Padding(0);
		bunifuButton3.TextPadding = iconLeftPadding;
		BunifuButton1.UseDefaultRadiusAndThickness = true;
		componentResourceManager.ApplyResources(BunifuDatePicker2, "BunifuDatePicker2");
		BunifuDatePicker2.BackColor = Color.Transparent;
		BunifuDatePicker2.BorderRadius = 2;
		BunifuDatePicker2.Color = Color.FromArgb(22, 106, 238);
		BunifuDatePicker2.DateBorderThickness = (Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness)1;
		BunifuDatePicker2.DateTextAlign = (Bunifu.UI.WinForms.BunifuDatePicker.TextAlign)0;
		BunifuDatePicker2.DisabledColor = Color.Gray;
		BunifuDatePicker2.DisplayWeekNumbers = false;
		BunifuDatePicker2.DPHeight = 0;
		BunifuDatePicker2.FillDatePicker = false;
		BunifuDatePicker2.ForeColor = Color.Black;
		BunifuDatePicker2.Icon = (Image)componentResourceManager.GetObject("BunifuDatePicker2.Icon");
		BunifuDatePicker2.IconColor = Color.Gray;
		BunifuDatePicker2.IconLocation = (Bunifu.UI.WinForms.BunifuDatePicker.Indicator)1;
		BunifuDatePicker2.LeftTextMargin = 5;
		((Control)BunifuDatePicker2).Name = "BunifuDatePicker2";
		componentResourceManager.ApplyResources(Panel4, "Panel4");
		((Control)Panel4).Name = "Panel4";
		componentResourceManager.ApplyResources(TableLayoutPanel4, "TableLayoutPanel4");
		((Control)TableLayoutPanel4).BackColor = Color.Transparent;
		TableLayoutPanel4.Controls.Add((Control)(object)SaaPanel10, 0, 0);
		TableLayoutPanel4.Controls.Add((Control)(object)SaaPanel11, 0, 0);
		((Control)TableLayoutPanel4).Name = "TableLayoutPanel4";
		SaaPanel10.BackColor = Color.White;
		SaaPanel10.BackColor2 = Color.White;
		SaaPanel10.BackColorAngle = 45f;
		SaaPanel10.Border = 1;
		SaaPanel10.BorderColor = Color.Silver;
		SaaPanel10.BorderColor2 = Color.Silver;
		SaaPanel10.BorderColorAngle = 1;
		SaaPanel10.ColorType = (PanelColorType)1;
		((Control)SaaPanel10).Controls.Add((Control)(object)BunifuButton7);
		((Control)SaaPanel10).Controls.Add((Control)(object)Panel38);
		((Control)SaaPanel10).Controls.Add((Control)(object)Label9);
		((Control)SaaPanel10).Controls.Add((Control)(object)Chart4);
		componentResourceManager.ApplyResources(SaaPanel10, "SaaPanel10");
		SaaPanel10.EnableDoubleBuffering = true;
		SaaPanel10.ForceDrawRegion = false;
		((Control)SaaPanel10).Name = "SaaPanel10";
		SaaPanel10.Radius.BottomLeft = 11;
		SaaPanel10.Radius.BottomRight = 11;
		SaaPanel10.Radius.TopLeft = 11;
		SaaPanel10.Radius.TopRight = 11;
		SaaPanel10.Transparence = 100;
		BunifuButton7.AllowAnimations = true;
		BunifuButton7.AllowMouseEffects = true;
		BunifuButton7.AllowToggling = false;
		BunifuButton7.AnimationSpeed = 200;
		BunifuButton7.AutoGenerateColors = false;
		BunifuButton7.AutoRoundBorders = true;
		BunifuButton7.AutoSizeLeftIcon = true;
		BunifuButton7.AutoSizeRightIcon = true;
		BunifuButton7.BackColor = Color.Transparent;
		BunifuButton7.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton7, "BunifuButton7");
		BunifuButton7.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton7.ButtonText = "Charger";
		BunifuButton7.ButtonTextMarginLeft = 0;
		BunifuButton7.ColorContrastOnClick = 45;
		BunifuButton7.ColorContrastOnHover = 45;
		((Control)BunifuButton7).Cursor = Cursors.Default;
		val2.BottomLeft = true;
		val2.BottomRight = true;
		val2.TopLeft = true;
		val2.TopRight = true;
		BunifuButton7.CustomizableEdges = val2;
		BunifuButton7.DialogResult = (DialogResult)0;
		BunifuButton7.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton7.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton7.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton7.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton7.ForeColor = Color.Black;
		BunifuButton7.IconLeftAlign = (ContentAlignment)16;
		BunifuButton7.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton4 = BunifuButton7;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton4.IconLeftPadding = iconLeftPadding;
		BunifuButton7.IconMarginLeft = 11;
		BunifuButton7.IconPadding = 2;
		BunifuButton7.IconRightAlign = (ContentAlignment)64;
		BunifuButton7.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton5 = BunifuButton7;
		iconLeftPadding = new Padding(1);
		bunifuButton5.IconRightPadding = iconLeftPadding;
		BunifuButton7.IconSize = 11;
		BunifuButton7.IdleBorderColor = Color.White;
		BunifuButton7.IdleBorderRadius = 34;
		BunifuButton7.IdleBorderThickness = 1;
		BunifuButton7.IdleFillColor = Color.Transparent;
		BunifuButton7.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton7.IdleIconLeftImage");
		BunifuButton7.IdleIconRightImage = null;
		BunifuButton7.IndicateFocus = false;
		((Control)BunifuButton7).Name = "BunifuButton7";
		BunifuButton7.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton7.OnDisabledState.BorderRadius = 33;
		BunifuButton7.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton7.OnDisabledState.BorderThickness = 1;
		BunifuButton7.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton7.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton7.OnDisabledState.IconLeftImage = null;
		BunifuButton7.OnDisabledState.IconRightImage = null;
		BunifuButton7.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton7.onHoverState.BorderRadius = 33;
		BunifuButton7.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton7.onHoverState.BorderThickness = 1;
		BunifuButton7.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton7.onHoverState.ForeColor = Color.White;
		BunifuButton7.onHoverState.IconLeftImage = null;
		BunifuButton7.onHoverState.IconRightImage = null;
		BunifuButton7.OnIdleState.BorderColor = Color.White;
		BunifuButton7.OnIdleState.BorderRadius = 33;
		BunifuButton7.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton7.OnIdleState.BorderThickness = 1;
		BunifuButton7.OnIdleState.FillColor = Color.Transparent;
		BunifuButton7.OnIdleState.ForeColor = Color.Black;
		BunifuButton7.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton7.OnIdleState.IconLeftImage");
		BunifuButton7.OnIdleState.IconRightImage = null;
		BunifuButton7.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton7.OnPressedState.BorderRadius = 33;
		BunifuButton7.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton7.OnPressedState.BorderThickness = 1;
		BunifuButton7.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton7.OnPressedState.ForeColor = Color.White;
		BunifuButton7.OnPressedState.IconLeftImage = null;
		BunifuButton7.OnPressedState.IconRightImage = null;
		BunifuButton7.TextAlign = (ContentAlignment)64;
		BunifuButton7.TextAlignment = (HorizontalAlignment)2;
		BunifuButton7.TextMarginLeft = 0;
		BunifuButton bunifuButton6 = BunifuButton7;
		iconLeftPadding = new Padding(0);
		bunifuButton6.TextPadding = iconLeftPadding;
		BunifuButton7.UseDefaultRadiusAndThickness = true;
		componentResourceManager.ApplyResources(Panel38, "Panel38");
		((Control)Panel38).BackColor = Color.White;
		((Control)Panel38).Controls.Add((Control)(object)Label_CLIENT_TOP);
		((Control)Panel38).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel38).Name = "Panel38";
		componentResourceManager.ApplyResources(Label_CLIENT_TOP, "Label_CLIENT_TOP");
		((Control)Label_CLIENT_TOP).Name = "Label_CLIENT_TOP";
		componentResourceManager.ApplyResources(PictureBox9, "PictureBox9");
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox9.TabStop = false;
		((Control)Label9).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.FromArgb(22, 106, 238);
		((Control)Label9).Name = "Label9";
		componentResourceManager.ApplyResources(Chart4, "Chart4");
		val3.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart4.ChartAreas).Add(val3);
		val4.Name = "Legend1";
		((Collection<Legend>)(object)Chart4.Legends).Add(val4);
		((Control)Chart4).Name = "Chart4";
		SaaPanel11.BackColor = Color.White;
		SaaPanel11.BackColor2 = Color.White;
		SaaPanel11.BackColorAngle = 45f;
		SaaPanel11.Border = 1;
		SaaPanel11.BorderColor = Color.Silver;
		SaaPanel11.BorderColor2 = Color.Silver;
		SaaPanel11.BorderColorAngle = 1;
		SaaPanel11.ColorType = (PanelColorType)1;
		((Control)SaaPanel11).Controls.Add((Control)(object)BunifuButton6);
		((Control)SaaPanel11).Controls.Add((Control)(object)Chart2);
		((Control)SaaPanel11).Controls.Add((Control)(object)Label4);
		componentResourceManager.ApplyResources(SaaPanel11, "SaaPanel11");
		SaaPanel11.EnableDoubleBuffering = true;
		SaaPanel11.ForceDrawRegion = false;
		((Control)SaaPanel11).Name = "SaaPanel11";
		SaaPanel11.Radius.BottomLeft = 11;
		SaaPanel11.Radius.BottomRight = 11;
		SaaPanel11.Radius.TopLeft = 11;
		SaaPanel11.Radius.TopRight = 11;
		SaaPanel11.Transparence = 100;
		BunifuButton6.AllowAnimations = true;
		BunifuButton6.AllowMouseEffects = true;
		BunifuButton6.AllowToggling = false;
		BunifuButton6.AnimationSpeed = 200;
		BunifuButton6.AutoGenerateColors = false;
		BunifuButton6.AutoRoundBorders = true;
		BunifuButton6.AutoSizeLeftIcon = true;
		BunifuButton6.AutoSizeRightIcon = true;
		BunifuButton6.BackColor = Color.Transparent;
		BunifuButton6.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton6, "BunifuButton6");
		BunifuButton6.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton6.ButtonText = "Charger";
		BunifuButton6.ButtonTextMarginLeft = 0;
		BunifuButton6.ColorContrastOnClick = 45;
		BunifuButton6.ColorContrastOnHover = 45;
		((Control)BunifuButton6).Cursor = Cursors.Default;
		val5.BottomLeft = true;
		val5.BottomRight = true;
		val5.TopLeft = true;
		val5.TopRight = true;
		BunifuButton6.CustomizableEdges = val5;
		BunifuButton6.DialogResult = (DialogResult)0;
		BunifuButton6.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton6.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton6.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton6.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton6.ForeColor = Color.Black;
		BunifuButton6.IconLeftAlign = (ContentAlignment)16;
		BunifuButton6.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton7 = BunifuButton6;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton7.IconLeftPadding = iconLeftPadding;
		BunifuButton6.IconMarginLeft = 11;
		BunifuButton6.IconPadding = 2;
		BunifuButton6.IconRightAlign = (ContentAlignment)64;
		BunifuButton6.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton8 = BunifuButton6;
		iconLeftPadding = new Padding(1);
		bunifuButton8.IconRightPadding = iconLeftPadding;
		BunifuButton6.IconSize = 11;
		BunifuButton6.IdleBorderColor = Color.White;
		BunifuButton6.IdleBorderRadius = 34;
		BunifuButton6.IdleBorderThickness = 1;
		BunifuButton6.IdleFillColor = Color.Transparent;
		BunifuButton6.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton6.IdleIconLeftImage");
		BunifuButton6.IdleIconRightImage = null;
		BunifuButton6.IndicateFocus = false;
		((Control)BunifuButton6).Name = "BunifuButton6";
		BunifuButton6.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton6.OnDisabledState.BorderRadius = 33;
		BunifuButton6.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton6.OnDisabledState.BorderThickness = 1;
		BunifuButton6.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton6.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton6.OnDisabledState.IconLeftImage = null;
		BunifuButton6.OnDisabledState.IconRightImage = null;
		BunifuButton6.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton6.onHoverState.BorderRadius = 33;
		BunifuButton6.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton6.onHoverState.BorderThickness = 1;
		BunifuButton6.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton6.onHoverState.ForeColor = Color.White;
		BunifuButton6.onHoverState.IconLeftImage = null;
		BunifuButton6.onHoverState.IconRightImage = null;
		BunifuButton6.OnIdleState.BorderColor = Color.White;
		BunifuButton6.OnIdleState.BorderRadius = 33;
		BunifuButton6.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton6.OnIdleState.BorderThickness = 1;
		BunifuButton6.OnIdleState.FillColor = Color.Transparent;
		BunifuButton6.OnIdleState.ForeColor = Color.Black;
		BunifuButton6.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton6.OnIdleState.IconLeftImage");
		BunifuButton6.OnIdleState.IconRightImage = null;
		BunifuButton6.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton6.OnPressedState.BorderRadius = 33;
		BunifuButton6.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton6.OnPressedState.BorderThickness = 1;
		BunifuButton6.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton6.OnPressedState.ForeColor = Color.White;
		BunifuButton6.OnPressedState.IconLeftImage = null;
		BunifuButton6.OnPressedState.IconRightImage = null;
		BunifuButton6.TextAlign = (ContentAlignment)64;
		BunifuButton6.TextAlignment = (HorizontalAlignment)2;
		BunifuButton6.TextMarginLeft = 0;
		BunifuButton bunifuButton9 = BunifuButton6;
		iconLeftPadding = new Padding(0);
		bunifuButton9.TextPadding = iconLeftPadding;
		BunifuButton6.UseDefaultRadiusAndThickness = true;
		val6.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart2.ChartAreas).Add(val6);
		val7.Name = "Legend1";
		((Collection<Legend>)(object)Chart2.Legends).Add(val7);
		componentResourceManager.ApplyResources(Chart2, "Chart2");
		((Control)Chart2).Name = "Chart2";
		((Control)Label4).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.FromArgb(22, 106, 238);
		((Control)Label4).Name = "Label4";
		componentResourceManager.ApplyResources(SaaPanel3, "SaaPanel3");
		SaaPanel3.BackColor = Color.White;
		SaaPanel3.BackColor2 = Color.White;
		SaaPanel3.BackColorAngle = 45f;
		SaaPanel3.Border = 1;
		SaaPanel3.BorderColor = Color.Silver;
		SaaPanel3.BorderColor2 = Color.Silver;
		SaaPanel3.BorderColorAngle = 1;
		SaaPanel3.ColorType = (PanelColorType)1;
		((Control)SaaPanel3).Controls.Add((Control)(object)BunifuButton2);
		((Control)SaaPanel3).Controls.Add((Control)(object)Chart1);
		((Control)SaaPanel3).Controls.Add((Control)(object)Label1);
		SaaPanel3.EnableDoubleBuffering = true;
		SaaPanel3.ForceDrawRegion = false;
		((Control)SaaPanel3).Name = "SaaPanel3";
		SaaPanel3.Radius.BottomLeft = 11;
		SaaPanel3.Radius.BottomRight = 11;
		SaaPanel3.Radius.TopLeft = 11;
		SaaPanel3.Radius.TopRight = 11;
		SaaPanel3.Transparence = 100;
		BunifuButton2.AllowAnimations = true;
		BunifuButton2.AllowMouseEffects = true;
		BunifuButton2.AllowToggling = false;
		BunifuButton2.AnimationSpeed = 200;
		BunifuButton2.AutoGenerateColors = false;
		BunifuButton2.AutoRoundBorders = true;
		BunifuButton2.AutoSizeLeftIcon = true;
		BunifuButton2.AutoSizeRightIcon = true;
		BunifuButton2.BackColor = Color.Transparent;
		BunifuButton2.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton2, "BunifuButton2");
		BunifuButton2.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton2.ButtonText = "Charger";
		BunifuButton2.ButtonTextMarginLeft = 0;
		BunifuButton2.ColorContrastOnClick = 45;
		BunifuButton2.ColorContrastOnHover = 45;
		((Control)BunifuButton2).Cursor = Cursors.Default;
		val8.BottomLeft = true;
		val8.BottomRight = true;
		val8.TopLeft = true;
		val8.TopRight = true;
		BunifuButton2.CustomizableEdges = val8;
		BunifuButton2.DialogResult = (DialogResult)0;
		BunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton2.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton2.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton2.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton2.ForeColor = Color.Black;
		BunifuButton2.IconLeftAlign = (ContentAlignment)16;
		BunifuButton2.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton10 = BunifuButton2;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton10.IconLeftPadding = iconLeftPadding;
		BunifuButton2.IconMarginLeft = 11;
		BunifuButton2.IconPadding = 2;
		BunifuButton2.IconRightAlign = (ContentAlignment)64;
		BunifuButton2.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton11 = BunifuButton2;
		iconLeftPadding = new Padding(1);
		bunifuButton11.IconRightPadding = iconLeftPadding;
		BunifuButton2.IconSize = 11;
		BunifuButton2.IdleBorderColor = Color.White;
		BunifuButton2.IdleBorderRadius = 34;
		BunifuButton2.IdleBorderThickness = 1;
		BunifuButton2.IdleFillColor = Color.Transparent;
		BunifuButton2.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton2.IdleIconLeftImage");
		BunifuButton2.IdleIconRightImage = null;
		BunifuButton2.IndicateFocus = false;
		((Control)BunifuButton2).Name = "BunifuButton2";
		BunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton2.OnDisabledState.BorderRadius = 33;
		BunifuButton2.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton2.OnDisabledState.BorderThickness = 1;
		BunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton2.OnDisabledState.IconLeftImage = null;
		BunifuButton2.OnDisabledState.IconRightImage = null;
		BunifuButton2.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton2.onHoverState.BorderRadius = 33;
		BunifuButton2.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton2.onHoverState.BorderThickness = 1;
		BunifuButton2.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton2.onHoverState.ForeColor = Color.White;
		BunifuButton2.onHoverState.IconLeftImage = null;
		BunifuButton2.onHoverState.IconRightImage = null;
		BunifuButton2.OnIdleState.BorderColor = Color.White;
		BunifuButton2.OnIdleState.BorderRadius = 33;
		BunifuButton2.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton2.OnIdleState.BorderThickness = 1;
		BunifuButton2.OnIdleState.FillColor = Color.Transparent;
		BunifuButton2.OnIdleState.ForeColor = Color.Black;
		BunifuButton2.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton2.OnIdleState.IconLeftImage");
		BunifuButton2.OnIdleState.IconRightImage = null;
		BunifuButton2.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton2.OnPressedState.BorderRadius = 33;
		BunifuButton2.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton2.OnPressedState.BorderThickness = 1;
		BunifuButton2.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton2.OnPressedState.ForeColor = Color.White;
		BunifuButton2.OnPressedState.IconLeftImage = null;
		BunifuButton2.OnPressedState.IconRightImage = null;
		BunifuButton2.TextAlign = (ContentAlignment)64;
		BunifuButton2.TextAlignment = (HorizontalAlignment)2;
		BunifuButton2.TextMarginLeft = 0;
		BunifuButton bunifuButton12 = BunifuButton2;
		iconLeftPadding = new Padding(0);
		bunifuButton12.TextPadding = iconLeftPadding;
		BunifuButton2.UseDefaultRadiusAndThickness = true;
		componentResourceManager.ApplyResources(Chart1, "Chart1");
		val9.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart1.ChartAreas).Add(val9);
		val10.Name = "Legend1";
		((Collection<Legend>)(object)Chart1.Legends).Add(val10);
		((Control)Chart1).Name = "Chart1";
		((Control)Label1).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Name = "Label1";
		componentResourceManager.ApplyResources(TableLayoutPanel3, "TableLayoutPanel3");
		((Control)TableLayoutPanel3).BackColor = Color.Transparent;
		TableLayoutPanel3.Controls.Add((Control)(object)SaaPanel8, 0, 0);
		TableLayoutPanel3.Controls.Add((Control)(object)SaaPanel6, 1, 0);
		((Control)TableLayoutPanel3).Name = "TableLayoutPanel3";
		SaaPanel8.BackColor = Color.White;
		SaaPanel8.BackColor2 = Color.White;
		SaaPanel8.BackColorAngle = 45f;
		SaaPanel8.Border = 1;
		SaaPanel8.BorderColor = Color.Silver;
		SaaPanel8.BorderColor2 = Color.Silver;
		SaaPanel8.BorderColorAngle = 1;
		SaaPanel8.ColorType = (PanelColorType)1;
		((Control)SaaPanel8).Controls.Add((Control)(object)BunifuButton4);
		((Control)SaaPanel8).Controls.Add((Control)(object)Panel26);
		((Control)SaaPanel8).Controls.Add((Control)(object)Label5);
		((Control)SaaPanel8).Controls.Add((Control)(object)Chart3);
		componentResourceManager.ApplyResources(SaaPanel8, "SaaPanel8");
		SaaPanel8.EnableDoubleBuffering = true;
		SaaPanel8.ForceDrawRegion = false;
		((Control)SaaPanel8).Name = "SaaPanel8";
		SaaPanel8.Radius.BottomLeft = 11;
		SaaPanel8.Radius.BottomRight = 11;
		SaaPanel8.Radius.TopLeft = 11;
		SaaPanel8.Radius.TopRight = 11;
		SaaPanel8.Transparence = 100;
		BunifuButton4.AllowAnimations = true;
		BunifuButton4.AllowMouseEffects = true;
		BunifuButton4.AllowToggling = false;
		BunifuButton4.AnimationSpeed = 200;
		BunifuButton4.AutoGenerateColors = false;
		BunifuButton4.AutoRoundBorders = true;
		BunifuButton4.AutoSizeLeftIcon = true;
		BunifuButton4.AutoSizeRightIcon = true;
		BunifuButton4.BackColor = Color.Transparent;
		BunifuButton4.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton4, "BunifuButton4");
		BunifuButton4.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton4.ButtonText = "Charger";
		BunifuButton4.ButtonTextMarginLeft = 0;
		BunifuButton4.ColorContrastOnClick = 45;
		BunifuButton4.ColorContrastOnHover = 45;
		((Control)BunifuButton4).Cursor = Cursors.Default;
		val11.BottomLeft = true;
		val11.BottomRight = true;
		val11.TopLeft = true;
		val11.TopRight = true;
		BunifuButton4.CustomizableEdges = val11;
		BunifuButton4.DialogResult = (DialogResult)0;
		BunifuButton4.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton4.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton4.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton4.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton4.ForeColor = Color.Black;
		BunifuButton4.IconLeftAlign = (ContentAlignment)16;
		BunifuButton4.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton13 = BunifuButton4;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton13.IconLeftPadding = iconLeftPadding;
		BunifuButton4.IconMarginLeft = 11;
		BunifuButton4.IconPadding = 2;
		BunifuButton4.IconRightAlign = (ContentAlignment)64;
		BunifuButton4.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton14 = BunifuButton4;
		iconLeftPadding = new Padding(1);
		bunifuButton14.IconRightPadding = iconLeftPadding;
		BunifuButton4.IconSize = 11;
		BunifuButton4.IdleBorderColor = Color.White;
		BunifuButton4.IdleBorderRadius = 34;
		BunifuButton4.IdleBorderThickness = 1;
		BunifuButton4.IdleFillColor = Color.Transparent;
		BunifuButton4.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton4.IdleIconLeftImage");
		BunifuButton4.IdleIconRightImage = null;
		BunifuButton4.IndicateFocus = false;
		((Control)BunifuButton4).Name = "BunifuButton4";
		BunifuButton4.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton4.OnDisabledState.BorderRadius = 33;
		BunifuButton4.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton4.OnDisabledState.BorderThickness = 1;
		BunifuButton4.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton4.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton4.OnDisabledState.IconLeftImage = null;
		BunifuButton4.OnDisabledState.IconRightImage = null;
		BunifuButton4.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton4.onHoverState.BorderRadius = 33;
		BunifuButton4.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton4.onHoverState.BorderThickness = 1;
		BunifuButton4.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton4.onHoverState.ForeColor = Color.White;
		BunifuButton4.onHoverState.IconLeftImage = null;
		BunifuButton4.onHoverState.IconRightImage = null;
		BunifuButton4.OnIdleState.BorderColor = Color.White;
		BunifuButton4.OnIdleState.BorderRadius = 33;
		BunifuButton4.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton4.OnIdleState.BorderThickness = 1;
		BunifuButton4.OnIdleState.FillColor = Color.Transparent;
		BunifuButton4.OnIdleState.ForeColor = Color.Black;
		BunifuButton4.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton4.OnIdleState.IconLeftImage");
		BunifuButton4.OnIdleState.IconRightImage = null;
		BunifuButton4.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton4.OnPressedState.BorderRadius = 33;
		BunifuButton4.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton4.OnPressedState.BorderThickness = 1;
		BunifuButton4.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton4.OnPressedState.ForeColor = Color.White;
		BunifuButton4.OnPressedState.IconLeftImage = null;
		BunifuButton4.OnPressedState.IconRightImage = null;
		BunifuButton4.TextAlign = (ContentAlignment)64;
		BunifuButton4.TextAlignment = (HorizontalAlignment)2;
		BunifuButton4.TextMarginLeft = 0;
		BunifuButton bunifuButton15 = BunifuButton4;
		iconLeftPadding = new Padding(0);
		bunifuButton15.TextPadding = iconLeftPadding;
		BunifuButton4.UseDefaultRadiusAndThickness = true;
		componentResourceManager.ApplyResources(Panel26, "Panel26");
		((Control)Panel26).BackColor = Color.White;
		((Control)Panel26).Controls.Add((Control)(object)Label_ARTICLE_TOP);
		((Control)Panel26).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel26).Name = "Panel26";
		componentResourceManager.ApplyResources(Label_ARTICLE_TOP, "Label_ARTICLE_TOP");
		((Control)Label_ARTICLE_TOP).Name = "Label_ARTICLE_TOP";
		componentResourceManager.ApplyResources(PictureBox19, "PictureBox19");
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox19.TabStop = false;
		((Control)Label5).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Name = "Label5";
		componentResourceManager.ApplyResources(Chart3, "Chart3");
		val12.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart3.ChartAreas).Add(val12);
		val13.Name = "Legend1";
		((Collection<Legend>)(object)Chart3.Legends).Add(val13);
		((Control)Chart3).Name = "Chart3";
		SaaPanel6.BackColor = Color.White;
		SaaPanel6.BackColor2 = Color.White;
		SaaPanel6.BackColorAngle = 45f;
		SaaPanel6.Border = 1;
		SaaPanel6.BorderColor = Color.Silver;
		SaaPanel6.BorderColor2 = Color.Silver;
		SaaPanel6.BorderColorAngle = 1;
		SaaPanel6.ColorType = (PanelColorType)1;
		((Control)SaaPanel6).Controls.Add((Control)(object)BunifuButton3);
		((Control)SaaPanel6).Controls.Add((Control)(object)Chart7);
		((Control)SaaPanel6).Controls.Add((Control)(object)Label3);
		componentResourceManager.ApplyResources(SaaPanel6, "SaaPanel6");
		SaaPanel6.EnableDoubleBuffering = true;
		SaaPanel6.ForceDrawRegion = false;
		((Control)SaaPanel6).Name = "SaaPanel6";
		SaaPanel6.Radius.BottomLeft = 11;
		SaaPanel6.Radius.BottomRight = 11;
		SaaPanel6.Radius.TopLeft = 11;
		SaaPanel6.Radius.TopRight = 11;
		SaaPanel6.Transparence = 100;
		BunifuButton3.AllowAnimations = true;
		BunifuButton3.AllowMouseEffects = true;
		BunifuButton3.AllowToggling = false;
		BunifuButton3.AnimationSpeed = 200;
		BunifuButton3.AutoGenerateColors = false;
		BunifuButton3.AutoRoundBorders = true;
		BunifuButton3.AutoSizeLeftIcon = true;
		BunifuButton3.AutoSizeRightIcon = true;
		BunifuButton3.BackColor = Color.Transparent;
		BunifuButton3.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton3, "BunifuButton3");
		BunifuButton3.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton3.ButtonText = "Charger";
		BunifuButton3.ButtonTextMarginLeft = 0;
		BunifuButton3.ColorContrastOnClick = 45;
		BunifuButton3.ColorContrastOnHover = 45;
		((Control)BunifuButton3).Cursor = Cursors.Default;
		val14.BottomLeft = true;
		val14.BottomRight = true;
		val14.TopLeft = true;
		val14.TopRight = true;
		BunifuButton3.CustomizableEdges = val14;
		BunifuButton3.DialogResult = (DialogResult)0;
		BunifuButton3.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton3.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton3.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton3.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton3.ForeColor = Color.Black;
		BunifuButton3.IconLeftAlign = (ContentAlignment)16;
		BunifuButton3.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton16 = BunifuButton3;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton16.IconLeftPadding = iconLeftPadding;
		BunifuButton3.IconMarginLeft = 11;
		BunifuButton3.IconPadding = 2;
		BunifuButton3.IconRightAlign = (ContentAlignment)64;
		BunifuButton3.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton17 = BunifuButton3;
		iconLeftPadding = new Padding(1);
		bunifuButton17.IconRightPadding = iconLeftPadding;
		BunifuButton3.IconSize = 11;
		BunifuButton3.IdleBorderColor = Color.White;
		BunifuButton3.IdleBorderRadius = 34;
		BunifuButton3.IdleBorderThickness = 1;
		BunifuButton3.IdleFillColor = Color.Transparent;
		BunifuButton3.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton3.IdleIconLeftImage");
		BunifuButton3.IdleIconRightImage = null;
		BunifuButton3.IndicateFocus = false;
		((Control)BunifuButton3).Name = "BunifuButton3";
		BunifuButton3.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton3.OnDisabledState.BorderRadius = 33;
		BunifuButton3.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton3.OnDisabledState.BorderThickness = 1;
		BunifuButton3.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton3.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton3.OnDisabledState.IconLeftImage = null;
		BunifuButton3.OnDisabledState.IconRightImage = null;
		BunifuButton3.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton3.onHoverState.BorderRadius = 33;
		BunifuButton3.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton3.onHoverState.BorderThickness = 1;
		BunifuButton3.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton3.onHoverState.ForeColor = Color.White;
		BunifuButton3.onHoverState.IconLeftImage = null;
		BunifuButton3.onHoverState.IconRightImage = null;
		BunifuButton3.OnIdleState.BorderColor = Color.White;
		BunifuButton3.OnIdleState.BorderRadius = 33;
		BunifuButton3.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton3.OnIdleState.BorderThickness = 1;
		BunifuButton3.OnIdleState.FillColor = Color.Transparent;
		BunifuButton3.OnIdleState.ForeColor = Color.Black;
		BunifuButton3.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton3.OnIdleState.IconLeftImage");
		BunifuButton3.OnIdleState.IconRightImage = null;
		BunifuButton3.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton3.OnPressedState.BorderRadius = 33;
		BunifuButton3.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton3.OnPressedState.BorderThickness = 1;
		BunifuButton3.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton3.OnPressedState.ForeColor = Color.White;
		BunifuButton3.OnPressedState.IconLeftImage = null;
		BunifuButton3.OnPressedState.IconRightImage = null;
		BunifuButton3.TextAlign = (ContentAlignment)64;
		BunifuButton3.TextAlignment = (HorizontalAlignment)2;
		BunifuButton3.TextMarginLeft = 0;
		BunifuButton bunifuButton18 = BunifuButton3;
		iconLeftPadding = new Padding(0);
		bunifuButton18.TextPadding = iconLeftPadding;
		BunifuButton3.UseDefaultRadiusAndThickness = true;
		val15.Name = "ChartArea1";
		((Collection<ChartArea>)(object)Chart7.ChartAreas).Add(val15);
		val16.Name = "Legend1";
		((Collection<Legend>)(object)Chart7.Legends).Add(val16);
		componentResourceManager.ApplyResources(Chart7, "Chart7");
		((Control)Chart7).Name = "Chart7";
		((Control)Label3).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.FromArgb(22, 106, 238);
		((Control)Label3).Name = "Label3";
		componentResourceManager.ApplyResources(BunifuDatePicker1, "BunifuDatePicker1");
		BunifuDatePicker1.BackColor = Color.Transparent;
		BunifuDatePicker1.BorderRadius = 2;
		BunifuDatePicker1.Color = Color.FromArgb(22, 106, 238);
		BunifuDatePicker1.DateBorderThickness = (Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness)1;
		BunifuDatePicker1.DateTextAlign = (Bunifu.UI.WinForms.BunifuDatePicker.TextAlign)0;
		BunifuDatePicker1.DisabledColor = Color.Gray;
		BunifuDatePicker1.DisplayWeekNumbers = false;
		BunifuDatePicker1.DPHeight = 0;
		BunifuDatePicker1.FillDatePicker = false;
		BunifuDatePicker1.ForeColor = Color.Black;
		BunifuDatePicker1.Icon = (Image)componentResourceManager.GetObject("BunifuDatePicker1.Icon");
		BunifuDatePicker1.IconColor = Color.Gray;
		BunifuDatePicker1.IconLocation = (Bunifu.UI.WinForms.BunifuDatePicker.Indicator)1;
		BunifuDatePicker1.LeftTextMargin = 5;
		((Control)BunifuDatePicker1).Name = "BunifuDatePicker1";
		componentResourceManager.ApplyResources(TableLayoutPanel2, "TableLayoutPanel2");
		((Control)TableLayoutPanel2).BackColor = Color.Transparent;
		TableLayoutPanel2.Controls.Add((Control)(object)SaaPanel9, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)SaaPanel2, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)SaaPanel4, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)SaaPanel7, 4, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)SaaPanel5, 3, 0);
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		SaaPanel9.BackColor = Color.FromArgb(22, 106, 238);
		SaaPanel9.BackColor2 = Color.FromArgb(218, 91, 229);
		SaaPanel9.BackColorAngle = -55f;
		SaaPanel9.Border = 0;
		SaaPanel9.BorderColor = Color.Red;
		SaaPanel9.BorderColor2 = Color.Red;
		SaaPanel9.BorderColorAngle = 0;
		SaaPanel9.ColorType = (PanelColorType)1;
		((Control)SaaPanel9).Controls.Add((Control)(object)Label10);
		((Control)SaaPanel9).Controls.Add((Control)(object)Label8);
		((Control)SaaPanel9).Controls.Add((Control)(object)Label_TOTAL_REMISE);
		((Control)SaaPanel9).Controls.Add((Control)(object)Label_TOTAL_OFFERT);
		((Control)SaaPanel9).Controls.Add((Control)(object)PictureBox2);
		componentResourceManager.ApplyResources(SaaPanel9, "SaaPanel9");
		SaaPanel9.EnableDoubleBuffering = true;
		SaaPanel9.ForceDrawRegion = true;
		((Control)SaaPanel9).Name = "SaaPanel9";
		SaaPanel9.Radius.BottomLeft = 11;
		SaaPanel9.Radius.BottomRight = 11;
		SaaPanel9.Radius.TopLeft = 11;
		SaaPanel9.Radius.TopRight = 11;
		SaaPanel9.Transparence = 100;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).ForeColor = Color.White;
		((Control)Label10).Name = "Label10";
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).ForeColor = Color.White;
		((Control)Label8).Name = "Label8";
		componentResourceManager.ApplyResources(Label_TOTAL_REMISE, "Label_TOTAL_REMISE");
		((Control)Label_TOTAL_REMISE).BackColor = Color.Transparent;
		((Control)Label_TOTAL_REMISE).ForeColor = Color.White;
		((Control)Label_TOTAL_REMISE).Name = "Label_TOTAL_REMISE";
		componentResourceManager.ApplyResources(Label_TOTAL_OFFERT, "Label_TOTAL_OFFERT");
		((Control)Label_TOTAL_OFFERT).BackColor = Color.Transparent;
		((Control)Label_TOTAL_OFFERT).ForeColor = Color.White;
		((Control)Label_TOTAL_OFFERT).Name = "Label_TOTAL_OFFERT";
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		SaaPanel2.BackColor = Color.FromArgb(230, 64, 9);
		SaaPanel2.BackColor2 = Color.FromArgb(244, 198, 93);
		SaaPanel2.BackColorAngle = 45f;
		SaaPanel2.Border = 0;
		SaaPanel2.BorderColor = Color.Red;
		SaaPanel2.BorderColor2 = Color.Red;
		SaaPanel2.BorderColorAngle = 0;
		SaaPanel2.ColorType = (PanelColorType)1;
		((Control)SaaPanel2).Controls.Add((Control)(object)Label_TOTAL_VENTES);
		((Control)SaaPanel2).Controls.Add((Control)(object)Label27);
		((Control)SaaPanel2).Controls.Add((Control)(object)PictureBox17);
		componentResourceManager.ApplyResources(SaaPanel2, "SaaPanel2");
		SaaPanel2.EnableDoubleBuffering = true;
		SaaPanel2.ForceDrawRegion = true;
		((Control)SaaPanel2).Name = "SaaPanel2";
		SaaPanel2.Radius.BottomLeft = 11;
		SaaPanel2.Radius.BottomRight = 11;
		SaaPanel2.Radius.TopLeft = 11;
		SaaPanel2.Radius.TopRight = 11;
		SaaPanel2.Transparence = 100;
		componentResourceManager.ApplyResources(Label_TOTAL_VENTES, "Label_TOTAL_VENTES");
		((Control)Label_TOTAL_VENTES).BackColor = Color.Transparent;
		((Control)Label_TOTAL_VENTES).ForeColor = Color.White;
		((Control)Label_TOTAL_VENTES).Name = "Label_TOTAL_VENTES";
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).BackColor = Color.Transparent;
		((Control)Label27).ForeColor = Color.White;
		((Control)Label27).Name = "Label27";
		componentResourceManager.ApplyResources(PictureBox17, "PictureBox17");
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox17.TabStop = false;
		SaaPanel4.BackColor = Color.FromArgb(63, 225, 153);
		SaaPanel4.BackColor2 = Color.FromArgb(38, 173, 221);
		SaaPanel4.BackColorAngle = 45f;
		SaaPanel4.Border = 0;
		SaaPanel4.BorderColor = Color.Red;
		SaaPanel4.BorderColor2 = Color.Red;
		SaaPanel4.BorderColorAngle = 0;
		SaaPanel4.ColorType = (PanelColorType)1;
		((Control)SaaPanel4).Controls.Add((Control)(object)Label_NBR_TICKETS);
		((Control)SaaPanel4).Controls.Add((Control)(object)Label29);
		((Control)SaaPanel4).Controls.Add((Control)(object)PictureBox20);
		componentResourceManager.ApplyResources(SaaPanel4, "SaaPanel4");
		SaaPanel4.EnableDoubleBuffering = true;
		SaaPanel4.ForceDrawRegion = true;
		((Control)SaaPanel4).Name = "SaaPanel4";
		SaaPanel4.Radius.BottomLeft = 11;
		SaaPanel4.Radius.BottomRight = 11;
		SaaPanel4.Radius.TopLeft = 11;
		SaaPanel4.Radius.TopRight = 11;
		SaaPanel4.Transparence = 100;
		componentResourceManager.ApplyResources(Label_NBR_TICKETS, "Label_NBR_TICKETS");
		((Control)Label_NBR_TICKETS).BackColor = Color.Transparent;
		((Control)Label_NBR_TICKETS).ForeColor = Color.White;
		((Control)Label_NBR_TICKETS).Name = "Label_NBR_TICKETS";
		componentResourceManager.ApplyResources(Label29, "Label29");
		((Control)Label29).BackColor = Color.Transparent;
		((Control)Label29).ForeColor = Color.White;
		((Control)Label29).Name = "Label29";
		componentResourceManager.ApplyResources(PictureBox20, "PictureBox20");
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox20.TabStop = false;
		SaaPanel7.BackColor = Color.FromArgb(22, 174, 100);
		SaaPanel7.BackColor2 = Color.FromArgb(249, 241, 61);
		SaaPanel7.BackColorAngle = 45f;
		SaaPanel7.Border = 0;
		SaaPanel7.BorderColor = Color.Red;
		SaaPanel7.BorderColor2 = Color.Red;
		SaaPanel7.BorderColorAngle = 0;
		SaaPanel7.ColorType = (PanelColorType)1;
		((Control)SaaPanel7).Controls.Add((Control)(object)BunifuButton5);
		((Control)SaaPanel7).Controls.Add((Control)(object)Label36);
		((Control)SaaPanel7).Controls.Add((Control)(object)Label_TOTAL_RETOUR_AVOIR);
		((Control)SaaPanel7).Controls.Add((Control)(object)PictureBox22);
		componentResourceManager.ApplyResources(SaaPanel7, "SaaPanel7");
		SaaPanel7.EnableDoubleBuffering = true;
		SaaPanel7.ForceDrawRegion = true;
		((Control)SaaPanel7).Name = "SaaPanel7";
		SaaPanel7.Radius.BottomLeft = 11;
		SaaPanel7.Radius.BottomRight = 11;
		SaaPanel7.Radius.TopLeft = 11;
		SaaPanel7.Radius.TopRight = 11;
		SaaPanel7.Transparence = 100;
		BunifuButton5.AllowAnimations = true;
		BunifuButton5.AllowMouseEffects = true;
		BunifuButton5.AllowToggling = false;
		BunifuButton5.AnimationSpeed = 200;
		BunifuButton5.AutoGenerateColors = false;
		BunifuButton5.AutoRoundBorders = true;
		BunifuButton5.AutoSizeLeftIcon = true;
		BunifuButton5.AutoSizeRightIcon = true;
		BunifuButton5.BackColor = Color.Transparent;
		BunifuButton5.BackColor1 = Color.Transparent;
		componentResourceManager.ApplyResources(BunifuButton5, "BunifuButton5");
		BunifuButton5.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton5.ButtonText = "Charger";
		BunifuButton5.ButtonTextMarginLeft = 0;
		BunifuButton5.ColorContrastOnClick = 45;
		BunifuButton5.ColorContrastOnHover = 45;
		((Control)BunifuButton5).Cursor = Cursors.Default;
		val17.BottomLeft = true;
		val17.BottomRight = true;
		val17.TopLeft = true;
		val17.TopRight = true;
		BunifuButton5.CustomizableEdges = val17;
		BunifuButton5.DialogResult = (DialogResult)0;
		BunifuButton5.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton5.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton5.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton5.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton5.ForeColor = Color.Black;
		BunifuButton5.IconLeftAlign = (ContentAlignment)16;
		BunifuButton5.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton19 = BunifuButton5;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton19.IconLeftPadding = iconLeftPadding;
		BunifuButton5.IconMarginLeft = 11;
		BunifuButton5.IconPadding = 2;
		BunifuButton5.IconRightAlign = (ContentAlignment)64;
		BunifuButton5.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton20 = BunifuButton5;
		iconLeftPadding = new Padding(1);
		bunifuButton20.IconRightPadding = iconLeftPadding;
		BunifuButton5.IconSize = 11;
		BunifuButton5.IdleBorderColor = Color.White;
		BunifuButton5.IdleBorderRadius = 34;
		BunifuButton5.IdleBorderThickness = 1;
		BunifuButton5.IdleFillColor = Color.Transparent;
		BunifuButton5.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton5.IdleIconLeftImage");
		BunifuButton5.IdleIconRightImage = null;
		BunifuButton5.IndicateFocus = false;
		((Control)BunifuButton5).Name = "BunifuButton5";
		BunifuButton5.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton5.OnDisabledState.BorderRadius = 33;
		BunifuButton5.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton5.OnDisabledState.BorderThickness = 1;
		BunifuButton5.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton5.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton5.OnDisabledState.IconLeftImage = null;
		BunifuButton5.OnDisabledState.IconRightImage = null;
		BunifuButton5.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton5.onHoverState.BorderRadius = 33;
		BunifuButton5.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton5.onHoverState.BorderThickness = 1;
		BunifuButton5.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton5.onHoverState.ForeColor = Color.White;
		BunifuButton5.onHoverState.IconLeftImage = null;
		BunifuButton5.onHoverState.IconRightImage = null;
		BunifuButton5.OnIdleState.BorderColor = Color.White;
		BunifuButton5.OnIdleState.BorderRadius = 33;
		BunifuButton5.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton5.OnIdleState.BorderThickness = 1;
		BunifuButton5.OnIdleState.FillColor = Color.Transparent;
		BunifuButton5.OnIdleState.ForeColor = Color.Black;
		BunifuButton5.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton5.OnIdleState.IconLeftImage");
		BunifuButton5.OnIdleState.IconRightImage = null;
		BunifuButton5.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
		BunifuButton5.OnPressedState.BorderRadius = 33;
		BunifuButton5.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton5.OnPressedState.BorderThickness = 1;
		BunifuButton5.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
		BunifuButton5.OnPressedState.ForeColor = Color.White;
		BunifuButton5.OnPressedState.IconLeftImage = null;
		BunifuButton5.OnPressedState.IconRightImage = null;
		BunifuButton5.TextAlign = (ContentAlignment)64;
		BunifuButton5.TextAlignment = (HorizontalAlignment)2;
		BunifuButton5.TextMarginLeft = 0;
		BunifuButton bunifuButton21 = BunifuButton5;
		iconLeftPadding = new Padding(0);
		bunifuButton21.TextPadding = iconLeftPadding;
		BunifuButton5.UseDefaultRadiusAndThickness = true;
		componentResourceManager.ApplyResources(Label36, "Label36");
		((Control)Label36).BackColor = Color.Transparent;
		((Control)Label36).ForeColor = Color.White;
		((Control)Label36).Name = "Label36";
		componentResourceManager.ApplyResources(Label_TOTAL_RETOUR_AVOIR, "Label_TOTAL_RETOUR_AVOIR");
		((Control)Label_TOTAL_RETOUR_AVOIR).BackColor = Color.Transparent;
		((Control)Label_TOTAL_RETOUR_AVOIR).ForeColor = Color.White;
		((Control)Label_TOTAL_RETOUR_AVOIR).Name = "Label_TOTAL_RETOUR_AVOIR";
		componentResourceManager.ApplyResources(PictureBox22, "PictureBox22");
		((Control)PictureBox22).Name = "PictureBox22";
		PictureBox22.TabStop = false;
		SaaPanel5.BackColor = Color.FromArgb(235, 58, 66);
		SaaPanel5.BackColor2 = Color.FromArgb(244, 126, 131);
		SaaPanel5.BackColorAngle = 45f;
		SaaPanel5.Border = 0;
		SaaPanel5.BorderColor = Color.Red;
		SaaPanel5.BorderColor2 = Color.Red;
		SaaPanel5.BorderColorAngle = 0;
		SaaPanel5.ColorType = (PanelColorType)1;
		((Control)SaaPanel5).Controls.Add((Control)(object)Label_TOTAL_RETOUR_REMB);
		((Control)SaaPanel5).Controls.Add((Control)(object)Label35);
		((Control)SaaPanel5).Controls.Add((Control)(object)PictureBox21);
		componentResourceManager.ApplyResources(SaaPanel5, "SaaPanel5");
		SaaPanel5.EnableDoubleBuffering = true;
		SaaPanel5.ForceDrawRegion = true;
		((Control)SaaPanel5).Name = "SaaPanel5";
		SaaPanel5.Radius.BottomLeft = 11;
		SaaPanel5.Radius.BottomRight = 11;
		SaaPanel5.Radius.TopLeft = 11;
		SaaPanel5.Radius.TopRight = 11;
		SaaPanel5.Transparence = 100;
		componentResourceManager.ApplyResources(Label_TOTAL_RETOUR_REMB, "Label_TOTAL_RETOUR_REMB");
		((Control)Label_TOTAL_RETOUR_REMB).BackColor = Color.Transparent;
		((Control)Label_TOTAL_RETOUR_REMB).ForeColor = Color.White;
		((Control)Label_TOTAL_RETOUR_REMB).Name = "Label_TOTAL_RETOUR_REMB";
		componentResourceManager.ApplyResources(Label35, "Label35");
		((Control)Label35).BackColor = Color.Transparent;
		((Control)Label35).ForeColor = Color.White;
		((Control)Label35).Name = "Label35";
		Label35.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(PictureBox21, "PictureBox21");
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox21.TabStop = false;
		SaaPanel1.BackColor = Color.FromArgb(22, 106, 238);
		SaaPanel1.BackColor2 = Color.FromArgb(218, 91, 229);
		SaaPanel1.BackColorAngle = -55f;
		SaaPanel1.Border = 0;
		SaaPanel1.BorderColor = Color.Red;
		SaaPanel1.BorderColor2 = Color.Red;
		SaaPanel1.BorderColorAngle = 0;
		SaaPanel1.ColorType = (PanelColorType)1;
		((Control)SaaPanel1).Controls.Add((Control)(object)BunifuButton8);
		((Control)SaaPanel1).Controls.Add((Control)(object)Label6);
		componentResourceManager.ApplyResources(SaaPanel1, "SaaPanel1");
		SaaPanel1.EnableDoubleBuffering = true;
		SaaPanel1.ForceDrawRegion = true;
		((Control)SaaPanel1).Name = "SaaPanel1";
		SaaPanel1.Radius.TopLeft = 22;
		SaaPanel1.Radius.TopRight = 22;
		SaaPanel1.Transparence = 100;
		BunifuButton8.AllowAnimations = true;
		BunifuButton8.AllowMouseEffects = true;
		BunifuButton8.AllowToggling = false;
		componentResourceManager.ApplyResources(BunifuButton8, "BunifuButton8");
		BunifuButton8.AnimationSpeed = 200;
		BunifuButton8.AutoGenerateColors = false;
		BunifuButton8.AutoRoundBorders = true;
		BunifuButton8.AutoSizeLeftIcon = true;
		BunifuButton8.AutoSizeRightIcon = true;
		BunifuButton8.BackColor = Color.Transparent;
		BunifuButton8.BackColor1 = Color.Transparent;
		BunifuButton8.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton8.ButtonText = "Paramètre";
		BunifuButton8.ButtonTextMarginLeft = 0;
		BunifuButton8.ColorContrastOnClick = 45;
		BunifuButton8.ColorContrastOnHover = 45;
		((Control)BunifuButton8).Cursor = Cursors.Hand;
		val18.BottomLeft = true;
		val18.BottomRight = true;
		val18.TopLeft = true;
		val18.TopRight = true;
		BunifuButton8.CustomizableEdges = val18;
		BunifuButton8.DialogResult = (DialogResult)0;
		BunifuButton8.DisabledBorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton8.DisabledFillColor = Color.FromArgb(204, 204, 204);
		BunifuButton8.DisabledForecolor = Color.FromArgb(168, 160, 168);
		BunifuButton8.FocusState = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates)2;
		BunifuButton8.ForeColor = Color.Black;
		BunifuButton8.IconLeftAlign = (ContentAlignment)16;
		BunifuButton8.IconLeftCursor = Cursors.Default;
		BunifuButton bunifuButton22 = BunifuButton8;
		iconLeftPadding = new Padding(5, 11, 11, 11);
		bunifuButton22.IconLeftPadding = iconLeftPadding;
		BunifuButton8.IconMarginLeft = 11;
		BunifuButton8.IconPadding = 2;
		BunifuButton8.IconRightAlign = (ContentAlignment)64;
		BunifuButton8.IconRightCursor = Cursors.Default;
		BunifuButton bunifuButton23 = BunifuButton8;
		iconLeftPadding = new Padding(1);
		bunifuButton23.IconRightPadding = iconLeftPadding;
		BunifuButton8.IconSize = 11;
		BunifuButton8.IdleBorderColor = Color.White;
		BunifuButton8.IdleBorderRadius = 34;
		BunifuButton8.IdleBorderThickness = 1;
		BunifuButton8.IdleFillColor = Color.Transparent;
		BunifuButton8.IdleIconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton8.IdleIconLeftImage");
		BunifuButton8.IdleIconRightImage = null;
		BunifuButton8.IndicateFocus = false;
		((Control)BunifuButton8).Name = "BunifuButton8";
		BunifuButton8.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
		BunifuButton8.OnDisabledState.BorderRadius = 33;
		BunifuButton8.OnDisabledState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton8.OnDisabledState.BorderThickness = 1;
		BunifuButton8.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
		BunifuButton8.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
		BunifuButton8.OnDisabledState.IconLeftImage = null;
		BunifuButton8.OnDisabledState.IconRightImage = null;
		BunifuButton8.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
		BunifuButton8.onHoverState.BorderRadius = 33;
		BunifuButton8.onHoverState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton8.onHoverState.BorderThickness = 1;
		BunifuButton8.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
		BunifuButton8.onHoverState.ForeColor = Color.White;
		BunifuButton8.onHoverState.IconLeftImage = null;
		BunifuButton8.onHoverState.IconRightImage = null;
		BunifuButton8.OnIdleState.BorderColor = Color.White;
		BunifuButton8.OnIdleState.BorderRadius = 33;
		BunifuButton8.OnIdleState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton8.OnIdleState.BorderThickness = 1;
		BunifuButton8.OnIdleState.FillColor = Color.Transparent;
		BunifuButton8.OnIdleState.ForeColor = Color.Black;
		BunifuButton8.OnIdleState.IconLeftImage = (Image)componentResourceManager.GetObject("BunifuButton8.OnIdleState.IconLeftImage");
		BunifuButton8.OnIdleState.IconRightImage = null;
		BunifuButton8.OnPressedState.BorderColor = Color.White;
		BunifuButton8.OnPressedState.BorderRadius = 33;
		BunifuButton8.OnPressedState.BorderStyle = (Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles)0;
		BunifuButton8.OnPressedState.BorderThickness = 1;
		BunifuButton8.OnPressedState.FillColor = Color.Transparent;
		BunifuButton8.OnPressedState.ForeColor = Color.White;
		BunifuButton8.OnPressedState.IconLeftImage = null;
		BunifuButton8.OnPressedState.IconRightImage = null;
		BunifuButton8.TextAlign = (ContentAlignment)64;
		BunifuButton8.TextAlignment = (HorizontalAlignment)2;
		BunifuButton8.TextMarginLeft = 0;
		BunifuButton bunifuButton24 = BunifuButton8;
		iconLeftPadding = new Padding(0);
		bunifuButton24.TextPadding = iconLeftPadding;
		BunifuButton8.UseDefaultRadiusAndThickness = true;
		((Control)Label6).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
		DataGrid_STATISTIQUE.AllowUserToAddRows = false;
		DataGrid_STATISTIQUE.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_STATISTIQUE.BackgroundColor = Color.White;
		DataGrid_STATISTIQUE.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_STATISTIQUE.EditMode = (DataGridViewEditMode)4;
		DataGrid_STATISTIQUE.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGrid_STATISTIQUE, "DataGrid_STATISTIQUE");
		((Control)DataGrid_STATISTIQUE).Name = "DataGrid_STATISTIQUE";
		DataGrid_STATISTIQUE.RowHeadersVisible = false;
		DataGrid_STATISTIQUE.SelectionMode = (DataGridViewSelectionMode)1;
		((ListControl)List_COLOR).FormattingEnabled = true;
		List_COLOR.Items.AddRange(new object[128]
		{
			componentResourceManager.GetString("List_COLOR.Items"),
			componentResourceManager.GetString("List_COLOR.Items1"),
			componentResourceManager.GetString("List_COLOR.Items2"),
			componentResourceManager.GetString("List_COLOR.Items3"),
			componentResourceManager.GetString("List_COLOR.Items4"),
			componentResourceManager.GetString("List_COLOR.Items5"),
			componentResourceManager.GetString("List_COLOR.Items6"),
			componentResourceManager.GetString("List_COLOR.Items7"),
			componentResourceManager.GetString("List_COLOR.Items8"),
			componentResourceManager.GetString("List_COLOR.Items9"),
			componentResourceManager.GetString("List_COLOR.Items10"),
			componentResourceManager.GetString("List_COLOR.Items11"),
			componentResourceManager.GetString("List_COLOR.Items12"),
			componentResourceManager.GetString("List_COLOR.Items13"),
			componentResourceManager.GetString("List_COLOR.Items14"),
			componentResourceManager.GetString("List_COLOR.Items15"),
			componentResourceManager.GetString("List_COLOR.Items16"),
			componentResourceManager.GetString("List_COLOR.Items17"),
			componentResourceManager.GetString("List_COLOR.Items18"),
			componentResourceManager.GetString("List_COLOR.Items19"),
			componentResourceManager.GetString("List_COLOR.Items20"),
			componentResourceManager.GetString("List_COLOR.Items21"),
			componentResourceManager.GetString("List_COLOR.Items22"),
			componentResourceManager.GetString("List_COLOR.Items23"),
			componentResourceManager.GetString("List_COLOR.Items24"),
			componentResourceManager.GetString("List_COLOR.Items25"),
			componentResourceManager.GetString("List_COLOR.Items26"),
			componentResourceManager.GetString("List_COLOR.Items27"),
			componentResourceManager.GetString("List_COLOR.Items28"),
			componentResourceManager.GetString("List_COLOR.Items29"),
			componentResourceManager.GetString("List_COLOR.Items30"),
			componentResourceManager.GetString("List_COLOR.Items31"),
			componentResourceManager.GetString("List_COLOR.Items32"),
			componentResourceManager.GetString("List_COLOR.Items33"),
			componentResourceManager.GetString("List_COLOR.Items34"),
			componentResourceManager.GetString("List_COLOR.Items35"),
			componentResourceManager.GetString("List_COLOR.Items36"),
			componentResourceManager.GetString("List_COLOR.Items37"),
			componentResourceManager.GetString("List_COLOR.Items38"),
			componentResourceManager.GetString("List_COLOR.Items39"),
			componentResourceManager.GetString("List_COLOR.Items40"),
			componentResourceManager.GetString("List_COLOR.Items41"),
			componentResourceManager.GetString("List_COLOR.Items42"),
			componentResourceManager.GetString("List_COLOR.Items43"),
			componentResourceManager.GetString("List_COLOR.Items44"),
			componentResourceManager.GetString("List_COLOR.Items45"),
			componentResourceManager.GetString("List_COLOR.Items46"),
			componentResourceManager.GetString("List_COLOR.Items47"),
			componentResourceManager.GetString("List_COLOR.Items48"),
			componentResourceManager.GetString("List_COLOR.Items49"),
			componentResourceManager.GetString("List_COLOR.Items50"),
			componentResourceManager.GetString("List_COLOR.Items51"),
			componentResourceManager.GetString("List_COLOR.Items52"),
			componentResourceManager.GetString("List_COLOR.Items53"),
			componentResourceManager.GetString("List_COLOR.Items54"),
			componentResourceManager.GetString("List_COLOR.Items55"),
			componentResourceManager.GetString("List_COLOR.Items56"),
			componentResourceManager.GetString("List_COLOR.Items57"),
			componentResourceManager.GetString("List_COLOR.Items58"),
			componentResourceManager.GetString("List_COLOR.Items59"),
			componentResourceManager.GetString("List_COLOR.Items60"),
			componentResourceManager.GetString("List_COLOR.Items61"),
			componentResourceManager.GetString("List_COLOR.Items62"),
			componentResourceManager.GetString("List_COLOR.Items63"),
			componentResourceManager.GetString("List_COLOR.Items64"),
			componentResourceManager.GetString("List_COLOR.Items65"),
			componentResourceManager.GetString("List_COLOR.Items66"),
			componentResourceManager.GetString("List_COLOR.Items67"),
			componentResourceManager.GetString("List_COLOR.Items68"),
			componentResourceManager.GetString("List_COLOR.Items69"),
			componentResourceManager.GetString("List_COLOR.Items70"),
			componentResourceManager.GetString("List_COLOR.Items71"),
			componentResourceManager.GetString("List_COLOR.Items72"),
			componentResourceManager.GetString("List_COLOR.Items73"),
			componentResourceManager.GetString("List_COLOR.Items74"),
			componentResourceManager.GetString("List_COLOR.Items75"),
			componentResourceManager.GetString("List_COLOR.Items76"),
			componentResourceManager.GetString("List_COLOR.Items77"),
			componentResourceManager.GetString("List_COLOR.Items78"),
			componentResourceManager.GetString("List_COLOR.Items79"),
			componentResourceManager.GetString("List_COLOR.Items80"),
			componentResourceManager.GetString("List_COLOR.Items81"),
			componentResourceManager.GetString("List_COLOR.Items82"),
			componentResourceManager.GetString("List_COLOR.Items83"),
			componentResourceManager.GetString("List_COLOR.Items84"),
			componentResourceManager.GetString("List_COLOR.Items85"),
			componentResourceManager.GetString("List_COLOR.Items86"),
			componentResourceManager.GetString("List_COLOR.Items87"),
			componentResourceManager.GetString("List_COLOR.Items88"),
			componentResourceManager.GetString("List_COLOR.Items89"),
			componentResourceManager.GetString("List_COLOR.Items90"),
			componentResourceManager.GetString("List_COLOR.Items91"),
			componentResourceManager.GetString("List_COLOR.Items92"),
			componentResourceManager.GetString("List_COLOR.Items93"),
			componentResourceManager.GetString("List_COLOR.Items94"),
			componentResourceManager.GetString("List_COLOR.Items95"),
			componentResourceManager.GetString("List_COLOR.Items96"),
			componentResourceManager.GetString("List_COLOR.Items97"),
			componentResourceManager.GetString("List_COLOR.Items98"),
			componentResourceManager.GetString("List_COLOR.Items99"),
			componentResourceManager.GetString("List_COLOR.Items100"),
			componentResourceManager.GetString("List_COLOR.Items101"),
			componentResourceManager.GetString("List_COLOR.Items102"),
			componentResourceManager.GetString("List_COLOR.Items103"),
			componentResourceManager.GetString("List_COLOR.Items104"),
			componentResourceManager.GetString("List_COLOR.Items105"),
			componentResourceManager.GetString("List_COLOR.Items106"),
			componentResourceManager.GetString("List_COLOR.Items107"),
			componentResourceManager.GetString("List_COLOR.Items108"),
			componentResourceManager.GetString("List_COLOR.Items109"),
			componentResourceManager.GetString("List_COLOR.Items110"),
			componentResourceManager.GetString("List_COLOR.Items111"),
			componentResourceManager.GetString("List_COLOR.Items112"),
			componentResourceManager.GetString("List_COLOR.Items113"),
			componentResourceManager.GetString("List_COLOR.Items114"),
			componentResourceManager.GetString("List_COLOR.Items115"),
			componentResourceManager.GetString("List_COLOR.Items116"),
			componentResourceManager.GetString("List_COLOR.Items117"),
			componentResourceManager.GetString("List_COLOR.Items118"),
			componentResourceManager.GetString("List_COLOR.Items119"),
			componentResourceManager.GetString("List_COLOR.Items120"),
			componentResourceManager.GetString("List_COLOR.Items121"),
			componentResourceManager.GetString("List_COLOR.Items122"),
			componentResourceManager.GetString("List_COLOR.Items123"),
			componentResourceManager.GetString("List_COLOR.Items124"),
			componentResourceManager.GetString("List_COLOR.Items125"),
			componentResourceManager.GetString("List_COLOR.Items126"),
			componentResourceManager.GetString("List_COLOR.Items127")
		});
		componentResourceManager.ApplyResources(List_COLOR, "List_COLOR");
		((Control)List_COLOR).Name = "List_COLOR";
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).Controls.Add((Control)(object)DataGrid_STATISTIQUE);
		((Control)this).Controls.Add((Control)(object)List_COLOR);
		((Control)this).Controls.Add((Control)(object)Panel);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_00_BACKOFFICE";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)TableLayoutPanel4).ResumeLayout(false);
		((Control)SaaPanel10).ResumeLayout(false);
		((Control)Panel38).ResumeLayout(false);
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)Chart4).EndInit();
		((Control)SaaPanel11).ResumeLayout(false);
		((ISupportInitialize)Chart2).EndInit();
		((Control)SaaPanel3).ResumeLayout(false);
		((ISupportInitialize)Chart1).EndInit();
		((Control)TableLayoutPanel3).ResumeLayout(false);
		((Control)SaaPanel8).ResumeLayout(false);
		((Control)Panel26).ResumeLayout(false);
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)Chart3).EndInit();
		((Control)SaaPanel6).ResumeLayout(false);
		((ISupportInitialize)Chart7).EndInit();
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)SaaPanel9).ResumeLayout(false);
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)SaaPanel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox17).EndInit();
		((Control)SaaPanel4).ResumeLayout(false);
		((ISupportInitialize)PictureBox20).EndInit();
		((Control)SaaPanel7).ResumeLayout(false);
		((ISupportInitialize)PictureBox22).EndInit();
		((Control)SaaPanel5).ResumeLayout(false);
		((ISupportInitialize)PictureBox21).EndInit();
		((Control)SaaPanel1).ResumeLayout(false);
		((ISupportInitialize)DataGrid_STATISTIQUE).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
		}
	}

	private void Form_00_BACKOFFICE_Load(object sender, EventArgs e)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		try
		{
			((Control)Panel).Dock = (DockStyle)5;
			if (!Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
			{
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

	private void BunifuButton5_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		try
		{
			string text = "WHERE       (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')         ";
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                     and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')                      ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label_TOTAL_VENTES.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
			val.CommandText = "select COUNT(TOTAL_NET) From TABLE_VENTES_ENTETE                          " + text + "                     and            (OPERATION = 'VENTE')      ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label_NBR_TICKETS.Text = Conversions.ToString(Conversion.Val(val.ExecuteScalar().ToString()));
			val.CommandText = "select sum((PRIX_V*Qté)-TOTAL_NET) as n     from TABLE_VENTES_JOURNAL           " + text + "                     and            (  REMISE = 100  )      ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label_TOTAL_OFFERT.Text = Conversions.ToString(Conversion.Val(val.ExecuteScalar().ToString()));
			val.CommandText = "select sum((PRIX_V*Qté)-TOTAL_NET) as n      from TABLE_VENTES_JOURNAL                         " + text + "                     and            ( REMISE <  100)      ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label_TOTAL_REMISE.Text = Conversions.ToString(Conversion.Val(val.ExecuteScalar().ToString()));
			val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                   and            (OPERATION = 'RETOUR REMBOURSEMENT')  ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label_TOTAL_RETOUR_REMB.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
			val.CommandText = "select Sum(TOTAL_NET) From TABLE_VENTES_JOURNAL                          " + text + "                   and             (OPERATION = 'RETOUR AVOIR')                  ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			Label36.Text = Strings.FormatNumber(Conversion.Val(val.ExecuteScalar().ToString())) + " DH";
			Module1.cn_SQL.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void BunifuButton2_Click(object sender, EventArgs e)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("HEURE", "HEURE");
				DataGrid_STATISTIQUE.Columns.Add("TOTAL", "TOTAL");
				DataGrid_STATISTIQUE.Columns.Add("HEURE_NAME", "HEURE_NAME");
				int num = 0;
				int num2;
				int num3;
				do
				{
					DataGrid_STATISTIQUE.Rows.Add(new object[3]
					{
						Strings.Format(num, "00"),
						"",
						Strings.Format(num, "00") + "h"
					});
					num++;
					num2 = num;
					num3 = 23;
				}
				while (num2 <= num3);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				int num4 = 0;
				int num5;
				do
				{
					dataTable.Clear();
					dataTable = new DataTable();
					val = new MySqlDataAdapter("select    sum(TOTAL_NET) as n     from  TABLE_VENTES_JOURNAL       WHERE           (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')     and        (datepart(hh,Heure) = " + Strings.Format(num4, "00") + ")          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')              ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
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
					num3 = 23;
				}
				while (num5 <= num3);
				dataTable.Clear();
				((Collection<ChartArea>)(object)Chart1.ChartAreas).Clear();
				((Collection<Series>)(object)Chart1.Series).Clear();
				((Collection<Legend>)(object)Chart1.Legends).Clear();
				Series val2 = Chart1.Series.Add("Series1");
				val2.ChartType = (SeriesChartType)14;
				val2.Name = "Ventes Mensuelles";
				((DataPointCustomProperties)val2).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val2).LabelForeColor = Color.DimGray;
				((DataPointCustomProperties)val2).LabelFormat = "0.00";
				((DataPointCustomProperties)val2).Font = new Font("Segoe UI", 9f, (FontStyle)1);
				((DataPointCustomProperties)val2).MarkerStyle = (MarkerStyle)2;
				((DataPointCustomProperties)val2).MarkerSize = 8;
				((DataPointCustomProperties)val2).BackGradientStyle = (GradientStyle)2;
				val2.Palette = (ChartColorPalette)2;
				((DataPointCustomProperties)val2).Color = Color.FromArgb(22, 106, 238);
				((DataPointCustomProperties)val2).BackSecondaryColor = Color.Transparent;
				Series val3 = Chart1.Series.Add("Series2");
				val3.ChartType = (SeriesChartType)4;
				((DataPointCustomProperties)val3).Color = Color.FromArgb(22, 106, 238);
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
					val2.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num7].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num7].Value) });
					val3.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num7].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num7].Value) });
					num7++;
				}
				ChartArea val4 = Chart1.ChartAreas.Add("ChartArea1");
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.Maximum = 25.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisY.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Height = 90f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart1.ChartAreas)["ChartArea1"].InnerPlotPosition.Width = 100f;
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

	private void BunifuButton4_Click(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		checked
		{
			try
			{
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
				val = new MySqlDataAdapter("select Code, Article, sum(Qté) as Qté   from TABLE_VENTES_JOURNAL    Where  (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')         group by Article,Code        ", Module1.cn_SQL);
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
				((Collection<ChartArea>)(object)Chart3.ChartAreas).Clear();
				((Collection<Series>)(object)Chart3.Series).Clear();
				((Collection<Legend>)(object)Chart3.Legends).Clear();
				ChartArea val2 = Chart3.ChartAreas.Add("ChartArea");
				Series val3 = Chart3.Series.Add("Series");
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["Series"]).Label = "#VALY";
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
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.Maximum = 11.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart3.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
				int num12 = 0;
				foreach (DataPoint item2 in (Collection<DataPoint>)(object)((ChartNamedElementCollection<Series>)(object)Chart3.Series)["Series"].Points)
				{
					string htmlColor = List_COLOR.Items[num12].ToString();
					((DataPointCustomProperties)item2).Color = ColorTranslator.FromHtml(htmlColor);
					num12++;
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

	private void BunifuButton3_Click(object sender, EventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("X", "X");
				DataGrid_STATISTIQUE.Columns.Add("Y", "Y");
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select  DISTINCT   MODE_P    from  TABLE_VENTES_REGLEMENTS      Where     Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " '                     ", Module1.cn_SQL);
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
					val2 = new MySqlDataAdapter("select   sum(MONTANT) as MONTANT    from   TABLE_VENTES_REGLEMENTS    Where    Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " '            And  MODE_P like '" + dataTable.Rows[num2]["MODE_P"].ToString() + "'        ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
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
				Series val3 = Chart7.Series.Add("series1");
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
				ChartArea val4 = Chart7.ChartAreas.Add("ChartArea");
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
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart7.Series)["series1"]).LegendText = "#VALX ( '#VALY DH )";
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

	private void BunifuButton6_Click(object sender, EventArgs e)
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGrid_STATISTIQUE.DataSource = null;
				DataGrid_STATISTIQUE.Rows.Clear();
				DataGrid_STATISTIQUE.Columns.Clear();
				DataGrid_STATISTIQUE.Columns.Add("type", "type");
				DataGrid_STATISTIQUE.Columns.Add("TOTAL", "TOTAL");
				DataGrid_STATISTIQUE.Columns.Add("HEURE_NAME", "HEURE_NAME");
				DataGrid_STATISTIQUE.Rows.Add(new object[3] { "SUR PLACE", "", "SUR PLACE" });
				DataGrid_STATISTIQUE.Rows.Add(new object[3] { "EMPORTER", "", "EMPORTER" });
				DataGrid_STATISTIQUE.Rows.Add(new object[3] { "LIVRAISON", "", "LIVRAISON" });
				DataGrid_STATISTIQUE.Rows.Add(new object[3] { "DIRECTE", "", "DIRECTE" });
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          And      (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'EMPORTER%'  )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            And     Notes  like 'LIVRAISON%'  )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE   (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')           And     Notes  like 'DIRECTE%'  )         ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				double num = Conversion.Val(dataTable.Rows[0]["n"].ToString());
				double num2 = Conversion.Val(dataTable.Rows[1]["n"].ToString());
				double num3 = Conversion.Val(dataTable.Rows[2]["n"].ToString());
				double num4 = Conversion.Val(dataTable.Rows[3]["n"].ToString());
				DataGrid_STATISTIQUE.Rows[0].Cells[1].Value = num;
				DataGrid_STATISTIQUE.Rows[1].Cells[1].Value = num2;
				DataGrid_STATISTIQUE.Rows[2].Cells[1].Value = num3;
				DataGrid_STATISTIQUE.Rows[3].Cells[1].Value = num4;
				dataTable.Clear();
				((Collection<ChartArea>)(object)Chart2.ChartAreas).Clear();
				((Collection<Series>)(object)Chart2.Series).Clear();
				((Collection<Legend>)(object)Chart2.Legends).Clear();
				Series val2 = Chart2.Series.Add("Series1");
				val2.ChartType = (SeriesChartType)10;
				val2.Name = "Ventes Mensuelles";
				((DataPointCustomProperties)val2).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val2).LabelForeColor = Color.DimGray;
				((DataPointCustomProperties)val2).LabelFormat = "0.00";
				((DataPointCustomProperties)val2).Font = new Font("Segoe UI", 9f, (FontStyle)1);
				((DataPointCustomProperties)val2).MarkerStyle = (MarkerStyle)2;
				((DataPointCustomProperties)val2).MarkerSize = 8;
				((DataPointCustomProperties)val2).BackGradientStyle = (GradientStyle)2;
				val2.Palette = (ChartColorPalette)10;
				int num5 = DataGrid_STATISTIQUE.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num8 = num5;
					if (num7 > num8)
					{
						break;
					}
					val2.Points.AddXY(RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[2, num6].Value), new object[1] { RuntimeHelpers.GetObjectValue(DataGrid_STATISTIQUE[1, num6].Value) });
					num6++;
				}
				ChartArea val3 = Chart2.ChartAreas.Add("ChartArea1");
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.LabelStyle.Angle = 0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.Maximum = 5.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisY.LabelStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.DimGray;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].InnerPlotPosition.Auto = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].InnerPlotPosition.Height = 90f;
				((ChartNamedElementCollection<ChartArea>)(object)Chart2.ChartAreas)["ChartArea1"].InnerPlotPosition.Width = 100f;
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

	private void BunifuButton7_Click(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		checked
		{
			try
			{
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
					val2 = new MySqlDataAdapter("select   sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where     (Dates = ' " + Strings.Format(DateTime.Now, "yyyy-MM-dd") + " ')         And     ID_Client =  '" + dataTable.Rows[num2]["ID_Client"].ToString() + "'         ", Module1.cn_SQL);
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
				((Collection<ChartArea>)(object)Chart4.ChartAreas).Clear();
				((Collection<Series>)(object)Chart4.Series).Clear();
				((Collection<Legend>)(object)Chart4.Legends).Clear();
				ChartArea val3 = Chart4.ChartAreas.Add("ChartArea");
				Series val4 = Chart4.Series.Add("Series");
				((DataPointCustomProperties)((ChartNamedElementCollection<Series>)(object)Chart4.Series)["Series"]).Label = "#VALY";
				val4.ChartArea = val3.Name;
				val4.ChartType = (SeriesChartType)10;
				((DataPointCustomProperties)val4).Color = Color.Blue;
				((DataPointCustomProperties)val4).BorderWidth = 3;
				val4.ShadowColor = Color.Black;
				((DataPointCustomProperties)val4).IsValueShownAsLabel = true;
				((DataPointCustomProperties)val4).LabelForeColor = Color.Black;
				if (DataGrid_STATISTIQUE.Rows.Count >= 4)
				{
					int num8 = 3;
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
				else if (DataGrid_STATISTIQUE.Rows.Count < 4)
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
				((DataPointCustomProperties)val4).BackGradientStyle = (GradientStyle)0;
				val4.Palette = (ChartColorPalette)0;
				((DataPointCustomProperties)val4).Color = Color.FromArgb(22, 106, 238);
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)1;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)5;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisY.MajorGrid.LineColor = Color.FromArgb(224, 224, 224);
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].BackColor = Color.White;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].ShadowColor = Color.Blue;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Interval = 1.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Minimum = 0.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.Maximum = 4.0;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.IsLabelAutoFit = false;
				((ChartNamedElementCollection<ChartArea>)(object)Chart4.ChartAreas)["ChartArea"].AxisX.LabelStyle.Angle = 0;
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

	private void BunifuButton8_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.Form_1_LOGIN).Close();
		((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
		((Control)MyProject.Forms.Form_1_LOGIN).Show();
		((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).Visible = true;
		((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).BringToFront();
	}

	private void BunifuButton1_Click(object sender, EventArgs e)
	{
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
				BunifuButton5_Click(RuntimeHelpers.GetObjectValue(sender), e);
				BunifuButton2_Click(RuntimeHelpers.GetObjectValue(sender), e);
				BunifuButton4_Click(RuntimeHelpers.GetObjectValue(sender), e);
				BunifuButton3_Click(RuntimeHelpers.GetObjectValue(sender), e);
				BunifuButton6_Click(RuntimeHelpers.GetObjectValue(sender), e);
				BunifuButton7_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Button_RJ1_Click(object sender, EventArgs e)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		((Control)Panel2).Visible = true;
		((Control)Panel2).BringToFront();
		MyProject.Forms.Form_0_TEMPLATE.Label_DB.Text = Label_DB_1.Text;
		Module1._CHEMIN_DB = Label_DB_1.Text;
		string text = "1433";
		string text2 = "logica";
		string text3 = "Sniper19912908Jawadino";
		Module1.cn_SQL = new MySqlConnection("Data Source=" + Module1._CHEMIN_DB + "," + text + "; Initial Catalog=" + Module1._NAME_DB + "; User ID=" + text2 + ";Password=" + text3 + "");
	}
}
