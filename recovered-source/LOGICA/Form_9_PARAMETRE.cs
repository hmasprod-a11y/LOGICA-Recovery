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
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_9_PARAMETRE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel00")]
	private Panel _Panel00;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("BunifuGradientPanel_HEADER")]
	private Bunifu.UI.WinForms.BunifuGradientPanel _BunifuGradientPanel_HEADER;

	[AccessedThroughProperty("Label80")]
	private Label _Label80;

	[AccessedThroughProperty("MenuSidebar")]
	private PictureBox _MenuSidebar;

	[AccessedThroughProperty("Sidebar")]
	private Bunifu.UI.WinForms.BunifuGradientPanel _Sidebar;

	[AccessedThroughProperty("PictureBox16323")]
	private PictureBox _PictureBox16323;

	[AccessedThroughProperty("BunifuFlatButton_A_PROPOS")]
	private BunifuFlatButton _BunifuFlatButton_A_PROPOS;

	[AccessedThroughProperty("BunifuFlatButton_BASE_DONEES")]
	private BunifuFlatButton _BunifuFlatButton_BASE_DONEES;

	[AccessedThroughProperty("bunifuFlatButton_MODE_PAIEMENT")]
	private BunifuFlatButton _bunifuFlatButton_MODE_PAIEMENT;

	[AccessedThroughProperty("bunifuFlatButton_CONFIG_SUITE2")]
	private BunifuFlatButton _bunifuFlatButton_CONFIG_SUITE2;

	[AccessedThroughProperty("bunifuFlatButton_CONFIG_SUITE")]
	private BunifuFlatButton _bunifuFlatButton_CONFIG_SUITE;

	[AccessedThroughProperty("bunifuFlatButton_CONFIG")]
	private BunifuFlatButton _bunifuFlatButton_CONFIG;

	[AccessedThroughProperty("bunifuFlatButton_UTILISATEURS")]
	private BunifuFlatButton _bunifuFlatButton_UTILISATEURS;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

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

	internal virtual Panel Panel00
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel00;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel00 = value;
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

	internal virtual Bunifu.UI.WinForms.BunifuGradientPanel BunifuGradientPanel_HEADER
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuGradientPanel_HEADER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuGradientPanel_HEADER = value;
		}
	}

	internal virtual Label Label80
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label80 = value;
		}
	}

	protected virtual PictureBox MenuSidebar
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuSidebar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MenuSidebar_Click;
			if (_MenuSidebar != null)
			{
				((Control)_MenuSidebar).Click -= eventHandler;
			}
			_MenuSidebar = value;
			if (_MenuSidebar != null)
			{
				((Control)_MenuSidebar).Click += eventHandler;
			}
		}
	}

	internal virtual Bunifu.UI.WinForms.BunifuGradientPanel Sidebar
	{
		[DebuggerNonUserCode]
		get
		{
			return _Sidebar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Sidebar = value;
		}
	}

	internal virtual PictureBox PictureBox16323
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox16323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox16323 = value;
		}
	}

	protected virtual BunifuFlatButton BunifuFlatButton_A_PROPOS
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuFlatButton_A_PROPOS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton1_Click;
			EventHandler eventHandler2 = BunifuFlatButton_A_PROPOS_Click;
			if (_BunifuFlatButton_A_PROPOS != null)
			{
				((Control)_BunifuFlatButton_A_PROPOS).Click -= eventHandler;
				((Control)_BunifuFlatButton_A_PROPOS).Click -= eventHandler2;
			}
			_BunifuFlatButton_A_PROPOS = value;
			if (_BunifuFlatButton_A_PROPOS != null)
			{
				((Control)_BunifuFlatButton_A_PROPOS).Click += eventHandler;
				((Control)_BunifuFlatButton_A_PROPOS).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton BunifuFlatButton_BASE_DONEES
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuFlatButton_BASE_DONEES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuFlatButton_BASE_DONEES_Click;
			EventHandler eventHandler2 = bunifuFlatButton1_Click;
			if (_BunifuFlatButton_BASE_DONEES != null)
			{
				((Control)_BunifuFlatButton_BASE_DONEES).Click -= eventHandler;
				((Control)_BunifuFlatButton_BASE_DONEES).Click -= eventHandler2;
			}
			_BunifuFlatButton_BASE_DONEES = value;
			if (_BunifuFlatButton_BASE_DONEES != null)
			{
				((Control)_BunifuFlatButton_BASE_DONEES).Click += eventHandler;
				((Control)_BunifuFlatButton_BASE_DONEES).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton bunifuFlatButton_MODE_PAIEMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _bunifuFlatButton_MODE_PAIEMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton_MODE_PAIEMENT_Click;
			EventHandler eventHandler2 = bunifuFlatButton1_Click;
			if (_bunifuFlatButton_MODE_PAIEMENT != null)
			{
				((Control)_bunifuFlatButton_MODE_PAIEMENT).Click -= eventHandler;
				((Control)_bunifuFlatButton_MODE_PAIEMENT).Click -= eventHandler2;
			}
			_bunifuFlatButton_MODE_PAIEMENT = value;
			if (_bunifuFlatButton_MODE_PAIEMENT != null)
			{
				((Control)_bunifuFlatButton_MODE_PAIEMENT).Click += eventHandler;
				((Control)_bunifuFlatButton_MODE_PAIEMENT).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton bunifuFlatButton_CONFIG_SUITE2
	{
		[DebuggerNonUserCode]
		get
		{
			return _bunifuFlatButton_CONFIG_SUITE2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton_CONFIG_SUITE2_Click;
			EventHandler eventHandler2 = bunifuFlatButton1_Click;
			if (_bunifuFlatButton_CONFIG_SUITE2 != null)
			{
				((Control)_bunifuFlatButton_CONFIG_SUITE2).Click -= eventHandler;
				((Control)_bunifuFlatButton_CONFIG_SUITE2).Click -= eventHandler2;
			}
			_bunifuFlatButton_CONFIG_SUITE2 = value;
			if (_bunifuFlatButton_CONFIG_SUITE2 != null)
			{
				((Control)_bunifuFlatButton_CONFIG_SUITE2).Click += eventHandler;
				((Control)_bunifuFlatButton_CONFIG_SUITE2).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton bunifuFlatButton_CONFIG_SUITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _bunifuFlatButton_CONFIG_SUITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton1_Click;
			EventHandler eventHandler2 = bunifuFlatButton_CONFIG_SUITE_Click;
			if (_bunifuFlatButton_CONFIG_SUITE != null)
			{
				((Control)_bunifuFlatButton_CONFIG_SUITE).Click -= eventHandler;
				((Control)_bunifuFlatButton_CONFIG_SUITE).Click -= eventHandler2;
			}
			_bunifuFlatButton_CONFIG_SUITE = value;
			if (_bunifuFlatButton_CONFIG_SUITE != null)
			{
				((Control)_bunifuFlatButton_CONFIG_SUITE).Click += eventHandler;
				((Control)_bunifuFlatButton_CONFIG_SUITE).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton bunifuFlatButton_CONFIG
	{
		[DebuggerNonUserCode]
		get
		{
			return _bunifuFlatButton_CONFIG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton1_Click;
			EventHandler eventHandler2 = bunifuFlatButton_CONFIG_Click;
			if (_bunifuFlatButton_CONFIG != null)
			{
				((Control)_bunifuFlatButton_CONFIG).Click -= eventHandler;
				((Control)_bunifuFlatButton_CONFIG).Click -= eventHandler2;
			}
			_bunifuFlatButton_CONFIG = value;
			if (_bunifuFlatButton_CONFIG != null)
			{
				((Control)_bunifuFlatButton_CONFIG).Click += eventHandler;
				((Control)_bunifuFlatButton_CONFIG).Click += eventHandler2;
			}
		}
	}

	protected virtual BunifuFlatButton bunifuFlatButton_UTILISATEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _bunifuFlatButton_UTILISATEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bunifuFlatButton1_Click;
			EventHandler eventHandler2 = bunifuFlatButton_UTILISATEURS_Click;
			if (_bunifuFlatButton_UTILISATEURS != null)
			{
				((Control)_bunifuFlatButton_UTILISATEURS).Click -= eventHandler;
				((Control)_bunifuFlatButton_UTILISATEURS).Click -= eventHandler2;
			}
			_bunifuFlatButton_UTILISATEURS = value;
			if (_bunifuFlatButton_UTILISATEURS != null)
			{
				((Control)_bunifuFlatButton_UTILISATEURS).Click += eventHandler;
				((Control)_bunifuFlatButton_UTILISATEURS).Click += eventHandler2;
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

	[DebuggerNonUserCode]
	public Form_9_PARAMETRE()
	{
		((Form)this).Load += Form_paramétre_Load;
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
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got Unknown
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected Obj, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected Obj, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected Obj, but got Unknown
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Expected Obj, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Expected Obj, but got Unknown
		//IL_133f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1349: Expected Obj, but got Unknown
		//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected Obj, but got Unknown
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Expected Obj, but got Unknown
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Expected Obj, but got Unknown
		//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Expected Obj, but got Unknown
		//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1759: Unknown result type (might be due to invalid IL or missing references)
		//IL_1763: Expected Obj, but got Unknown
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_1851: Expected Obj, but got Unknown
		//IL_1874: Unknown result type (might be due to invalid IL or missing references)
		//IL_187e: Expected Obj, but got Unknown
		//IL_18a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1936: Unknown result type (might be due to invalid IL or missing references)
		//IL_1940: Expected Obj, but got Unknown
		//IL_19c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cb: Expected Obj, but got Unknown
		//IL_1aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab3: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_9_PARAMETRE));
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel00 = new Panel();
		Panel1 = new Panel();
		Sidebar = new Bunifu.UI.WinForms.BunifuGradientPanel();
		PictureBox16323 = new PictureBox();
		BunifuFlatButton_A_PROPOS = new BunifuFlatButton();
		BunifuFlatButton_BASE_DONEES = new BunifuFlatButton();
		bunifuFlatButton_MODE_PAIEMENT = new BunifuFlatButton();
		bunifuFlatButton_CONFIG_SUITE2 = new BunifuFlatButton();
		bunifuFlatButton_CONFIG_SUITE = new BunifuFlatButton();
		bunifuFlatButton_CONFIG = new BunifuFlatButton();
		bunifuFlatButton_UTILISATEURS = new BunifuFlatButton();
		BunifuGradientPanel_HEADER = new Bunifu.UI.WinForms.BunifuGradientPanel();
		Label80 = new Label();
		Button244 = new Button();
		MenuSidebar = new PictureBox();
		PictureBox1 = new PictureBox();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel00).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Sidebar).SuspendLayout();
		((ISupportInitialize)PictureBox16323).BeginInit();
		((Control)BunifuGradientPanel_HEADER).SuspendLayout();
		((ISupportInitialize)MenuSidebar).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TableLayoutPanel1).BackColor = Color.White;
		TableLayoutPanel1.ColumnCount = 1;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel1.Controls.Add((Control)(object)Panel00, 0, 0);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel1;
		Point location = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel1.RowCount = 1;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel1;
		Size size = new Size(1052, 708);
		((Control)tableLayoutPanel2).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 1045;
		((Control)Panel00).Controls.Add((Control)(object)Panel1);
		((Control)Panel00).Controls.Add((Control)(object)Sidebar);
		((Control)Panel00).Controls.Add((Control)(object)BunifuGradientPanel_HEADER);
		((Control)Panel00).Dock = (DockStyle)5;
		Panel panel = Panel00;
		location = new Point(0, 0);
		((Control)panel).Location = location;
		Panel panel2 = Panel00;
		Padding margin = new Padding(0);
		((Control)panel2).Margin = margin;
		((Control)Panel00).Name = "Panel00";
		Panel panel3 = Panel00;
		size = new Size(1052, 708);
		((Control)panel3).Size = size;
		((Control)Panel00).TabIndex = 2;
		((Control)Panel1).Anchor = (AnchorStyles)15;
		((Control)Panel1).Controls.Add((Control)(object)PictureBox1);
		Panel panel4 = Panel1;
		location = new Point(219, 43);
		((Control)panel4).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel5 = Panel1;
		size = new Size(830, 662);
		((Control)panel5).Size = size;
		((Control)Panel1).TabIndex = 1057;
		Sidebar.BackColor = Color.Transparent;
		((Control)Sidebar).BackgroundImage = (Image)componentResourceManager.GetObject("Sidebar.BackgroundImage");
		((Control)Sidebar).BackgroundImageLayout = (ImageLayout)3;
		Sidebar.BorderRadius = 0;
		((Control)Sidebar).Controls.Add((Control)(object)PictureBox16323);
		((Control)Sidebar).Controls.Add((Control)(object)BunifuFlatButton_A_PROPOS);
		((Control)Sidebar).Controls.Add((Control)(object)BunifuFlatButton_BASE_DONEES);
		((Control)Sidebar).Controls.Add((Control)(object)bunifuFlatButton_MODE_PAIEMENT);
		((Control)Sidebar).Controls.Add((Control)(object)bunifuFlatButton_CONFIG_SUITE2);
		((Control)Sidebar).Controls.Add((Control)(object)bunifuFlatButton_CONFIG_SUITE);
		((Control)Sidebar).Controls.Add((Control)(object)bunifuFlatButton_CONFIG);
		((Control)Sidebar).Controls.Add((Control)(object)bunifuFlatButton_UTILISATEURS);
		((Control)Sidebar).Dock = (DockStyle)3;
		((Control)Sidebar).Font = new Font("Microsoft Sans Serif", 9f);
		Sidebar.GradientBottomLeft = Color.FromArgb(22, 106, 238);
		Sidebar.GradientBottomRight = Color.FromArgb(218, 91, 229);
		Sidebar.GradientTopLeft = Color.FromArgb(22, 106, 238);
		Sidebar.GradientTopRight = Color.FromArgb(22, 106, 238);
		Bunifu.UI.WinForms.BunifuGradientPanel sidebar = Sidebar;
		location = new Point(0, 43);
		((Control)sidebar).Location = location;
		Bunifu.UI.WinForms.BunifuGradientPanel sidebar2 = Sidebar;
		margin = new Padding(0);
		((Control)sidebar2).Margin = margin;
		((Control)Sidebar).Name = "Sidebar";
		Sidebar.Quality = 10;
		Bunifu.UI.WinForms.BunifuGradientPanel sidebar3 = Sidebar;
		size = new Size(216, 665);
		((Control)sidebar3).Size = size;
		((Control)Sidebar).TabIndex = 1055;
		((Control)PictureBox16323).BackColor = Color.FromArgb(218, 91, 229);
		PictureBox pictureBox = PictureBox16323;
		location = new Point(10, 12);
		((Control)pictureBox).Location = location;
		((Control)PictureBox16323).Name = "PictureBox16323";
		PictureBox pictureBox2 = PictureBox16323;
		size = new Size(4, 42);
		((Control)pictureBox2).Size = size;
		PictureBox16323.TabIndex = 24;
		PictureBox16323.TabStop = false;
		BunifuFlatButton_A_PROPOS.Active = false;
		BunifuFlatButton_A_PROPOS.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)BunifuFlatButton_A_PROPOS).BackColor = Color.Transparent;
		((Control)BunifuFlatButton_A_PROPOS).BackgroundImageLayout = (ImageLayout)3;
		BunifuFlatButton_A_PROPOS.BorderRadius = 0;
		BunifuFlatButton_A_PROPOS.ButtonText = " À propos - Aide";
		((Control)BunifuFlatButton_A_PROPOS).Cursor = Cursors.Hand;
		BunifuFlatButton_A_PROPOS.DisabledColor = Color.Gray;
		BunifuFlatButton_A_PROPOS.Iconcolor = Color.Transparent;
		BunifuFlatButton_A_PROPOS.Iconimage = (Image)componentResourceManager.GetObject("BunifuFlatButton_A_PROPOS.Iconimage");
		BunifuFlatButton_A_PROPOS.Iconimage_right = null;
		BunifuFlatButton_A_PROPOS.Iconimage_right_Selected = null;
		BunifuFlatButton_A_PROPOS.Iconimage_Selected = null;
		BunifuFlatButton_A_PROPOS.IconMarginLeft = 0;
		BunifuFlatButton_A_PROPOS.IconMarginRight = 0;
		BunifuFlatButton_A_PROPOS.IconRightVisible = true;
		BunifuFlatButton_A_PROPOS.IconRightZoom = 0.0;
		BunifuFlatButton_A_PROPOS.IconVisible = true;
		BunifuFlatButton_A_PROPOS.IconZoom = 50.0;
		BunifuFlatButton_A_PROPOS.IsTab = true;
		BunifuFlatButton bunifuFlatButton_A_PROPOS = BunifuFlatButton_A_PROPOS;
		location = new Point(10, 312);
		((Control)bunifuFlatButton_A_PROPOS).Location = location;
		BunifuFlatButton bunifuFlatButton_A_PROPOS2 = BunifuFlatButton_A_PROPOS;
		margin = new Padding(5, 3, 5, 3);
		((Control)bunifuFlatButton_A_PROPOS2).Margin = margin;
		((Control)BunifuFlatButton_A_PROPOS).Name = "BunifuFlatButton_A_PROPOS";
		BunifuFlatButton_A_PROPOS.Normalcolor = Color.Transparent;
		BunifuFlatButton_A_PROPOS.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		BunifuFlatButton_A_PROPOS.OnHoverTextColor = Color.Transparent;
		BunifuFlatButton_A_PROPOS.selected = false;
		BunifuFlatButton bunifuFlatButton_A_PROPOS3 = BunifuFlatButton_A_PROPOS;
		size = new Size(197, 42);
		((Control)bunifuFlatButton_A_PROPOS3).Size = size;
		((Control)BunifuFlatButton_A_PROPOS).TabIndex = 23;
		BunifuFlatButton_A_PROPOS.Text = " À propos - Aide";
		BunifuFlatButton_A_PROPOS.TextAlign = (ContentAlignment)16;
		BunifuFlatButton_A_PROPOS.Textcolor = Color.WhiteSmoke;
		BunifuFlatButton_A_PROPOS.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		BunifuFlatButton_BASE_DONEES.Active = false;
		BunifuFlatButton_BASE_DONEES.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)BunifuFlatButton_BASE_DONEES).BackColor = Color.Transparent;
		((Control)BunifuFlatButton_BASE_DONEES).BackgroundImageLayout = (ImageLayout)3;
		BunifuFlatButton_BASE_DONEES.BorderRadius = 0;
		BunifuFlatButton_BASE_DONEES.ButtonText = " Base de Données";
		((Control)BunifuFlatButton_BASE_DONEES).Cursor = Cursors.Hand;
		BunifuFlatButton_BASE_DONEES.DisabledColor = Color.Gray;
		BunifuFlatButton_BASE_DONEES.Iconcolor = Color.Transparent;
		BunifuFlatButton_BASE_DONEES.Iconimage = (Image)componentResourceManager.GetObject("BunifuFlatButton_BASE_DONEES.Iconimage");
		BunifuFlatButton_BASE_DONEES.Iconimage_right = null;
		BunifuFlatButton_BASE_DONEES.Iconimage_right_Selected = null;
		BunifuFlatButton_BASE_DONEES.Iconimage_Selected = null;
		BunifuFlatButton_BASE_DONEES.IconMarginLeft = 0;
		BunifuFlatButton_BASE_DONEES.IconMarginRight = 0;
		BunifuFlatButton_BASE_DONEES.IconRightVisible = true;
		BunifuFlatButton_BASE_DONEES.IconRightZoom = 0.0;
		BunifuFlatButton_BASE_DONEES.IconVisible = true;
		BunifuFlatButton_BASE_DONEES.IconZoom = 50.0;
		BunifuFlatButton_BASE_DONEES.IsTab = true;
		BunifuFlatButton bunifuFlatButton_BASE_DONEES = BunifuFlatButton_BASE_DONEES;
		location = new Point(10, 262);
		((Control)bunifuFlatButton_BASE_DONEES).Location = location;
		BunifuFlatButton bunifuFlatButton_BASE_DONEES2 = BunifuFlatButton_BASE_DONEES;
		margin = new Padding(5, 3, 5, 3);
		((Control)bunifuFlatButton_BASE_DONEES2).Margin = margin;
		((Control)BunifuFlatButton_BASE_DONEES).Name = "BunifuFlatButton_BASE_DONEES";
		BunifuFlatButton_BASE_DONEES.Normalcolor = Color.Transparent;
		BunifuFlatButton_BASE_DONEES.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		BunifuFlatButton_BASE_DONEES.OnHoverTextColor = Color.Transparent;
		BunifuFlatButton_BASE_DONEES.selected = false;
		BunifuFlatButton bunifuFlatButton_BASE_DONEES3 = BunifuFlatButton_BASE_DONEES;
		size = new Size(197, 42);
		((Control)bunifuFlatButton_BASE_DONEES3).Size = size;
		((Control)BunifuFlatButton_BASE_DONEES).TabIndex = 22;
		BunifuFlatButton_BASE_DONEES.Text = " Base de Données";
		BunifuFlatButton_BASE_DONEES.TextAlign = (ContentAlignment)16;
		BunifuFlatButton_BASE_DONEES.Textcolor = Color.WhiteSmoke;
		BunifuFlatButton_BASE_DONEES.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		bunifuFlatButton_MODE_PAIEMENT.Active = false;
		bunifuFlatButton_MODE_PAIEMENT.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_MODE_PAIEMENT).BackColor = Color.Transparent;
		((Control)bunifuFlatButton_MODE_PAIEMENT).BackgroundImageLayout = (ImageLayout)3;
		bunifuFlatButton_MODE_PAIEMENT.BorderRadius = 0;
		bunifuFlatButton_MODE_PAIEMENT.ButtonText = " Mode Paiement";
		((Control)bunifuFlatButton_MODE_PAIEMENT).Cursor = Cursors.Hand;
		bunifuFlatButton_MODE_PAIEMENT.DisabledColor = Color.Gray;
		bunifuFlatButton_MODE_PAIEMENT.Iconcolor = Color.Transparent;
		bunifuFlatButton_MODE_PAIEMENT.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton_MODE_PAIEMENT.Iconimage");
		bunifuFlatButton_MODE_PAIEMENT.Iconimage_right = null;
		bunifuFlatButton_MODE_PAIEMENT.Iconimage_right_Selected = null;
		bunifuFlatButton_MODE_PAIEMENT.Iconimage_Selected = null;
		bunifuFlatButton_MODE_PAIEMENT.IconMarginLeft = 0;
		bunifuFlatButton_MODE_PAIEMENT.IconMarginRight = 0;
		bunifuFlatButton_MODE_PAIEMENT.IconRightVisible = true;
		bunifuFlatButton_MODE_PAIEMENT.IconRightZoom = 0.0;
		bunifuFlatButton_MODE_PAIEMENT.IconVisible = true;
		bunifuFlatButton_MODE_PAIEMENT.IconZoom = 50.0;
		bunifuFlatButton_MODE_PAIEMENT.IsTab = true;
		BunifuFlatButton val = bunifuFlatButton_MODE_PAIEMENT;
		location = new Point(10, 212);
		((Control)val).Location = location;
		((Control)bunifuFlatButton_MODE_PAIEMENT).Name = "bunifuFlatButton_MODE_PAIEMENT";
		bunifuFlatButton_MODE_PAIEMENT.Normalcolor = Color.Transparent;
		bunifuFlatButton_MODE_PAIEMENT.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		bunifuFlatButton_MODE_PAIEMENT.OnHoverTextColor = Color.Transparent;
		bunifuFlatButton_MODE_PAIEMENT.selected = false;
		BunifuFlatButton val2 = bunifuFlatButton_MODE_PAIEMENT;
		size = new Size(197, 42);
		((Control)val2).Size = size;
		((Control)bunifuFlatButton_MODE_PAIEMENT).TabIndex = 19;
		bunifuFlatButton_MODE_PAIEMENT.Text = " Mode Paiement";
		bunifuFlatButton_MODE_PAIEMENT.TextAlign = (ContentAlignment)16;
		bunifuFlatButton_MODE_PAIEMENT.Textcolor = Color.WhiteSmoke;
		bunifuFlatButton_MODE_PAIEMENT.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		bunifuFlatButton_CONFIG_SUITE2.Active = false;
		bunifuFlatButton_CONFIG_SUITE2.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_CONFIG_SUITE2).BackColor = Color.Transparent;
		((Control)bunifuFlatButton_CONFIG_SUITE2).BackgroundImageLayout = (ImageLayout)3;
		bunifuFlatButton_CONFIG_SUITE2.BorderRadius = 0;
		bunifuFlatButton_CONFIG_SUITE2.ButtonText = " Configuration Suite";
		((Control)bunifuFlatButton_CONFIG_SUITE2).Cursor = Cursors.Hand;
		bunifuFlatButton_CONFIG_SUITE2.DisabledColor = Color.Gray;
		bunifuFlatButton_CONFIG_SUITE2.Iconcolor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE2.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton_CONFIG_SUITE2.Iconimage");
		bunifuFlatButton_CONFIG_SUITE2.Iconimage_right = null;
		bunifuFlatButton_CONFIG_SUITE2.Iconimage_right_Selected = null;
		bunifuFlatButton_CONFIG_SUITE2.Iconimage_Selected = null;
		bunifuFlatButton_CONFIG_SUITE2.IconMarginLeft = 0;
		bunifuFlatButton_CONFIG_SUITE2.IconMarginRight = 0;
		bunifuFlatButton_CONFIG_SUITE2.IconRightVisible = true;
		bunifuFlatButton_CONFIG_SUITE2.IconRightZoom = 0.0;
		bunifuFlatButton_CONFIG_SUITE2.IconVisible = true;
		bunifuFlatButton_CONFIG_SUITE2.IconZoom = 50.0;
		bunifuFlatButton_CONFIG_SUITE2.IsTab = true;
		BunifuFlatButton val3 = bunifuFlatButton_CONFIG_SUITE2;
		location = new Point(10, 162);
		((Control)val3).Location = location;
		((Control)bunifuFlatButton_CONFIG_SUITE2).Name = "bunifuFlatButton_CONFIG_SUITE2";
		bunifuFlatButton_CONFIG_SUITE2.Normalcolor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE2.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		bunifuFlatButton_CONFIG_SUITE2.OnHoverTextColor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE2.selected = false;
		BunifuFlatButton val4 = bunifuFlatButton_CONFIG_SUITE2;
		size = new Size(197, 42);
		((Control)val4).Size = size;
		((Control)bunifuFlatButton_CONFIG_SUITE2).TabIndex = 18;
		bunifuFlatButton_CONFIG_SUITE2.Text = " Configuration Suite";
		bunifuFlatButton_CONFIG_SUITE2.TextAlign = (ContentAlignment)16;
		bunifuFlatButton_CONFIG_SUITE2.Textcolor = Color.WhiteSmoke;
		bunifuFlatButton_CONFIG_SUITE2.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		bunifuFlatButton_CONFIG_SUITE.Active = false;
		bunifuFlatButton_CONFIG_SUITE.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_CONFIG_SUITE).BackColor = Color.Transparent;
		((Control)bunifuFlatButton_CONFIG_SUITE).BackgroundImageLayout = (ImageLayout)3;
		bunifuFlatButton_CONFIG_SUITE.BorderRadius = 0;
		bunifuFlatButton_CONFIG_SUITE.ButtonText = " Configuration Suite";
		((Control)bunifuFlatButton_CONFIG_SUITE).Cursor = Cursors.Hand;
		bunifuFlatButton_CONFIG_SUITE.DisabledColor = Color.Gray;
		bunifuFlatButton_CONFIG_SUITE.Iconcolor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton_CONFIG_SUITE.Iconimage");
		bunifuFlatButton_CONFIG_SUITE.Iconimage_right = null;
		bunifuFlatButton_CONFIG_SUITE.Iconimage_right_Selected = null;
		bunifuFlatButton_CONFIG_SUITE.Iconimage_Selected = null;
		bunifuFlatButton_CONFIG_SUITE.IconMarginLeft = 0;
		bunifuFlatButton_CONFIG_SUITE.IconMarginRight = 0;
		bunifuFlatButton_CONFIG_SUITE.IconRightVisible = true;
		bunifuFlatButton_CONFIG_SUITE.IconRightZoom = 0.0;
		bunifuFlatButton_CONFIG_SUITE.IconVisible = true;
		bunifuFlatButton_CONFIG_SUITE.IconZoom = 50.0;
		bunifuFlatButton_CONFIG_SUITE.IsTab = true;
		BunifuFlatButton val5 = bunifuFlatButton_CONFIG_SUITE;
		location = new Point(10, 112);
		((Control)val5).Location = location;
		((Control)bunifuFlatButton_CONFIG_SUITE).Name = "bunifuFlatButton_CONFIG_SUITE";
		bunifuFlatButton_CONFIG_SUITE.Normalcolor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		bunifuFlatButton_CONFIG_SUITE.OnHoverTextColor = Color.Transparent;
		bunifuFlatButton_CONFIG_SUITE.selected = false;
		BunifuFlatButton val6 = bunifuFlatButton_CONFIG_SUITE;
		size = new Size(197, 42);
		((Control)val6).Size = size;
		((Control)bunifuFlatButton_CONFIG_SUITE).TabIndex = 17;
		bunifuFlatButton_CONFIG_SUITE.Text = " Configuration Suite";
		bunifuFlatButton_CONFIG_SUITE.TextAlign = (ContentAlignment)16;
		bunifuFlatButton_CONFIG_SUITE.Textcolor = Color.WhiteSmoke;
		bunifuFlatButton_CONFIG_SUITE.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		bunifuFlatButton_CONFIG.Active = false;
		bunifuFlatButton_CONFIG.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_CONFIG).BackColor = Color.Transparent;
		((Control)bunifuFlatButton_CONFIG).BackgroundImageLayout = (ImageLayout)3;
		bunifuFlatButton_CONFIG.BorderRadius = 0;
		bunifuFlatButton_CONFIG.ButtonText = " Configuration";
		((Control)bunifuFlatButton_CONFIG).Cursor = Cursors.Hand;
		bunifuFlatButton_CONFIG.DisabledColor = Color.Gray;
		bunifuFlatButton_CONFIG.Iconcolor = Color.Transparent;
		bunifuFlatButton_CONFIG.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton_CONFIG.Iconimage");
		bunifuFlatButton_CONFIG.Iconimage_right = null;
		bunifuFlatButton_CONFIG.Iconimage_right_Selected = null;
		bunifuFlatButton_CONFIG.Iconimage_Selected = null;
		bunifuFlatButton_CONFIG.IconMarginLeft = 0;
		bunifuFlatButton_CONFIG.IconMarginRight = 0;
		bunifuFlatButton_CONFIG.IconRightVisible = true;
		bunifuFlatButton_CONFIG.IconRightZoom = 0.0;
		bunifuFlatButton_CONFIG.IconVisible = true;
		bunifuFlatButton_CONFIG.IconZoom = 50.0;
		bunifuFlatButton_CONFIG.IsTab = true;
		BunifuFlatButton val7 = bunifuFlatButton_CONFIG;
		location = new Point(10, 62);
		((Control)val7).Location = location;
		((Control)bunifuFlatButton_CONFIG).Name = "bunifuFlatButton_CONFIG";
		bunifuFlatButton_CONFIG.Normalcolor = Color.Transparent;
		bunifuFlatButton_CONFIG.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		bunifuFlatButton_CONFIG.OnHoverTextColor = Color.Transparent;
		bunifuFlatButton_CONFIG.selected = false;
		BunifuFlatButton val8 = bunifuFlatButton_CONFIG;
		size = new Size(197, 42);
		((Control)val8).Size = size;
		((Control)bunifuFlatButton_CONFIG).TabIndex = 16;
		bunifuFlatButton_CONFIG.Text = " Configuration";
		bunifuFlatButton_CONFIG.TextAlign = (ContentAlignment)16;
		bunifuFlatButton_CONFIG.Textcolor = Color.WhiteSmoke;
		bunifuFlatButton_CONFIG.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1);
		bunifuFlatButton_UTILISATEURS.Active = true;
		bunifuFlatButton_UTILISATEURS.Activecolor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_UTILISATEURS).BackColor = Color.FromArgb(50, 80, 36, 95);
		((Control)bunifuFlatButton_UTILISATEURS).BackgroundImageLayout = (ImageLayout)3;
		bunifuFlatButton_UTILISATEURS.BorderRadius = 0;
		bunifuFlatButton_UTILISATEURS.ButtonText = " Les Utilisateurs";
		((Control)bunifuFlatButton_UTILISATEURS).Cursor = Cursors.Hand;
		bunifuFlatButton_UTILISATEURS.DisabledColor = Color.Gray;
		((Control)bunifuFlatButton_UTILISATEURS).Font = new Font("Microsoft Sans Serif", 9f);
		bunifuFlatButton_UTILISATEURS.Iconcolor = Color.Transparent;
		bunifuFlatButton_UTILISATEURS.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton_UTILISATEURS.Iconimage");
		bunifuFlatButton_UTILISATEURS.Iconimage_right = null;
		bunifuFlatButton_UTILISATEURS.Iconimage_right_Selected = null;
		bunifuFlatButton_UTILISATEURS.Iconimage_Selected = null;
		bunifuFlatButton_UTILISATEURS.IconMarginLeft = 0;
		bunifuFlatButton_UTILISATEURS.IconMarginRight = 0;
		bunifuFlatButton_UTILISATEURS.IconRightVisible = true;
		bunifuFlatButton_UTILISATEURS.IconRightZoom = 0.0;
		bunifuFlatButton_UTILISATEURS.IconVisible = true;
		bunifuFlatButton_UTILISATEURS.IconZoom = 50.0;
		bunifuFlatButton_UTILISATEURS.IsTab = true;
		BunifuFlatButton val9 = bunifuFlatButton_UTILISATEURS;
		location = new Point(10, 12);
		((Control)val9).Location = location;
		BunifuFlatButton val10 = bunifuFlatButton_UTILISATEURS;
		margin = new Padding(4, 3, 4, 3);
		((Control)val10).Margin = margin;
		((Control)bunifuFlatButton_UTILISATEURS).Name = "bunifuFlatButton_UTILISATEURS";
		bunifuFlatButton_UTILISATEURS.Normalcolor = Color.Transparent;
		bunifuFlatButton_UTILISATEURS.OnHovercolor = Color.FromArgb(50, 80, 36, 95);
		bunifuFlatButton_UTILISATEURS.OnHoverTextColor = Color.Transparent;
		bunifuFlatButton_UTILISATEURS.selected = true;
		BunifuFlatButton val11 = bunifuFlatButton_UTILISATEURS;
		size = new Size(197, 42);
		((Control)val11).Size = size;
		((Control)bunifuFlatButton_UTILISATEURS).TabIndex = 15;
		bunifuFlatButton_UTILISATEURS.Text = " Les Utilisateurs";
		bunifuFlatButton_UTILISATEURS.TextAlign = (ContentAlignment)16;
		bunifuFlatButton_UTILISATEURS.Textcolor = Color.WhiteSmoke;
		bunifuFlatButton_UTILISATEURS.TextFont = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		BunifuGradientPanel_HEADER.BackColor = Color.Transparent;
		((Control)BunifuGradientPanel_HEADER).BackgroundImage = (Image)componentResourceManager.GetObject("BunifuGradientPanel_HEADER.BackgroundImage");
		((Control)BunifuGradientPanel_HEADER).BackgroundImageLayout = (ImageLayout)3;
		BunifuGradientPanel_HEADER.BorderRadius = 0;
		((Control)BunifuGradientPanel_HEADER).Controls.Add((Control)(object)Label80);
		((Control)BunifuGradientPanel_HEADER).Controls.Add((Control)(object)Button244);
		((Control)BunifuGradientPanel_HEADER).Controls.Add((Control)(object)MenuSidebar);
		((Control)BunifuGradientPanel_HEADER).Dock = (DockStyle)1;
		BunifuGradientPanel_HEADER.GradientBottomLeft = Color.FromArgb(22, 106, 238);
		BunifuGradientPanel_HEADER.GradientBottomRight = Color.FromArgb(218, 91, 229);
		BunifuGradientPanel_HEADER.GradientTopLeft = Color.FromArgb(22, 106, 238);
		BunifuGradientPanel_HEADER.GradientTopRight = Color.FromArgb(218, 91, 229);
		Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel_HEADER = BunifuGradientPanel_HEADER;
		location = new Point(0, 0);
		((Control)bunifuGradientPanel_HEADER).Location = location;
		Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel_HEADER2 = BunifuGradientPanel_HEADER;
		margin = new Padding(0);
		((Control)bunifuGradientPanel_HEADER2).Margin = margin;
		((Control)BunifuGradientPanel_HEADER).Name = "BunifuGradientPanel_HEADER";
		BunifuGradientPanel_HEADER.Quality = 10;
		Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel_HEADER3 = BunifuGradientPanel_HEADER;
		size = new Size(1052, 43);
		((Control)bunifuGradientPanel_HEADER3).Size = size;
		((Control)BunifuGradientPanel_HEADER).TabIndex = 1054;
		((Control)Label80).BackColor = Color.Transparent;
		((Control)Label80).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label80).ForeColor = Color.White;
		Label80.ImeMode = (ImeMode)0;
		Label label = Label80;
		location = new Point(39, 11);
		((Control)label).Location = location;
		((Control)Label80).Name = "Label80";
		Label label2 = Label80;
		size = new Size(177, 21);
		((Control)label2).Size = size;
		((Control)Label80).TabIndex = 951;
		Label80.Text = "Paramètres";
		Label80.TextAlign = (ContentAlignment)16;
		((Control)Button244).Anchor = (AnchorStyles)9;
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((ButtonBase)Button244).FlatStyle = (FlatStyle)0;
		((Control)Button244).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button244).ForeColor = Color.White;
		((ButtonBase)Button244).Image = (Image)componentResourceManager.GetObject("Button244.Image");
		Button button = Button244;
		location = new Point(984, 7);
		((Control)button).Location = location;
		Button button2 = Button244;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button244).Name = "Button244";
		Button button3 = Button244;
		size = new Size(57, 29);
		((Control)button3).Size = size;
		((Control)Button244).TabIndex = 559;
		((ButtonBase)Button244).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button244).UseCompatibleTextRendering = true;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		((Control)MenuSidebar).Cursor = Cursors.Hand;
		MenuSidebar.Image = (Image)componentResourceManager.GetObject("MenuSidebar.Image");
		PictureBox menuSidebar = MenuSidebar;
		location = new Point(10, 11);
		((Control)menuSidebar).Location = location;
		((Control)MenuSidebar).Name = "MenuSidebar";
		PictureBox menuSidebar2 = MenuSidebar;
		size = new Size(23, 21);
		((Control)menuSidebar2).Size = size;
		MenuSidebar.SizeMode = (PictureBoxSizeMode)1;
		MenuSidebar.TabIndex = 560;
		MenuSidebar.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(3, 28);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(153, 106);
		((Control)pictureBox4).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(1374, 780);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Form_9_PARAMETRE";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel00).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Sidebar).ResumeLayout(false);
		((ISupportInitialize)PictureBox16323).EndInit();
		((Control)BunifuGradientPanel_HEADER).ResumeLayout(false);
		((ISupportInitialize)MenuSidebar).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form_paramétre_Load(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		try
		{
			((Control)TableLayoutPanel1).Dock = (DockStyle)5;
			if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
			{
				((ButtonBase)Button244).Image = MyProject.Forms.Form_0_TEMPLATE.PictureBox_SORTIE.Image;
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

	private void Button244_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select    ID     from TABLE_PASS  WHERE   Catégorie = 'ADMIN'  ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				MessageBox.Show("La création d'un compte avec la catégorie (ADMIN) est obligatoire.\r\n إنشاء حساب من نوع (المدير) هو أمر إلزامي", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				return;
			}
			((Form)MyProject.Forms.Form_1_LOGIN).Close();
			((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
			((Control)MyProject.Forms.Form_1_LOGIN).Show();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).BringToFront();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).Show();
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

	private void MenuSidebar_Click(object sender, EventArgs e)
	{
		if (((Control)Sidebar).Width == 216)
		{
			((Control)Sidebar).Width = 52;
		}
		else
		{
			((Control)Sidebar).Width = 216;
		}
	}

	private void bunifuFlatButton1_Click(object sender, EventArgs e)
	{
		((Control)PictureBox16323).Top = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "top", new object[0], null, null, null));
	}

	private void bunifuFlatButton_UTILISATEURS_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_1_UTILISATEURS).Close();
		((Form)MyProject.Forms.FormDialog_1_UTILISATEURS).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_1_UTILISATEURS);
		((Control)MyProject.Forms.FormDialog_1_UTILISATEURS).Show();
		((Control)MyProject.Forms.FormDialog_1_UTILISATEURS).Dock = (DockStyle)5;
	}

	private void bunifuFlatButton_CONFIG_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_2_Configuration).Close();
		((Form)MyProject.Forms.FormDialog_2_Configuration).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_2_Configuration);
		((Control)MyProject.Forms.FormDialog_2_Configuration).Show();
		((Control)MyProject.Forms.FormDialog_2_Configuration).Dock = (DockStyle)5;
	}

	private void bunifuFlatButton_CONFIG_SUITE_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_3_Configuration_Suite).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_3_Configuration_Suite);
		((Control)MyProject.Forms.FormDialog_3_Configuration_Suite).Show();
		((Control)MyProject.Forms.FormDialog_3_Configuration_Suite).Dock = (DockStyle)5;
	}

	private void bunifuFlatButton_CONFIG_SUITE2_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_4_Configuration_Suite).Close();
		((Form)MyProject.Forms.FormDialog_4_Configuration_Suite).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_4_Configuration_Suite);
		((Control)MyProject.Forms.FormDialog_4_Configuration_Suite).Show();
		((Control)MyProject.Forms.FormDialog_4_Configuration_Suite).Dock = (DockStyle)5;
	}

	private void bunifuFlatButton_MODE_PAIEMENT_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_5_MODE_P).Close();
		((Form)MyProject.Forms.FormDialog_5_MODE_P).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_5_MODE_P);
		((Control)MyProject.Forms.FormDialog_5_MODE_P).Show();
		((Control)MyProject.Forms.FormDialog_5_MODE_P).Dock = (DockStyle)5;
	}

	private void BunifuFlatButton_BASE_DONEES_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.FormDialog_8_BASE_DONNEE).Close();
		((Form)MyProject.Forms.FormDialog_8_BASE_DONNEE).TopLevel = false;
		((Control)Panel1).Controls.Clear();
		((Control)Panel1).Controls.Add((Control)(object)MyProject.Forms.FormDialog_8_BASE_DONNEE);
		((Control)MyProject.Forms.FormDialog_8_BASE_DONNEE).Show();
		((Control)MyProject.Forms.FormDialog_8_BASE_DONNEE).Dock = (DockStyle)5;
	}

	private void BunifuFlatButton_A_PROPOS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_info).Show();
	}
}
