using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_RAPPORT : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("ListBox_RAPPORT_GLOBALE")]
	private ListBox _ListBox_RAPPORT_GLOBALE;

	[AccessedThroughProperty("ListBox_CAISSIERS")]
	private ListBox _ListBox_CAISSIERS;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Button_PrintCaissier")]
	private Button _Button_PrintCaissier;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

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

	internal virtual ListBox ListBox_RAPPORT_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_RAPPORT_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_RAPPORT_GLOBALE = value;
		}
	}

	internal virtual ListBox ListBox_CAISSIERS
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_CAISSIERS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_CAISSIERS = value;
		}
	}

	internal virtual Button Button_PrintRapport
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintRapport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PrintRapport_Click;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click -= eventHandler;
			}
			_Button_PrintRapport = value;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click += eventHandler;
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

	internal virtual Button Button_PrintCaissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintCaissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PrintCaissier_Click;
			if (_Button_PrintCaissier != null)
			{
				((Control)_Button_PrintCaissier).Click -= eventHandler;
			}
			_Button_PrintCaissier = value;
			if (_Button_PrintCaissier != null)
			{
				((Control)_Button_PrintCaissier).Click += eventHandler;
			}
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

	internal virtual Button Button20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button20_Click;
			if (_Button20 != null)
			{
				((Control)_Button20).Click -= eventHandler;
			}
			_Button20 = value;
			if (_Button20 != null)
			{
				((Control)_Button20).Click += eventHandler;
			}
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

	[DebuggerNonUserCode]
	public FormDialog_RAPPORT()
	{
		((Form)this).Load += FormDialog_config_Load;
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
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected Obj, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected Obj, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Expected Obj, but got Unknown
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected Obj, but got Unknown
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f42: Expected Obj, but got Unknown
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_100d: Expected Obj, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected Obj, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected Obj, but got Unknown
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Expected Obj, but got Unknown
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cb: Expected Obj, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected Obj, but got Unknown
		//IL_149e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a8: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_RAPPORT));
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		ListBox_RAPPORT_GLOBALE = new ListBox();
		ListBox_CAISSIERS = new ListBox();
		Button_PrintRapport = new Button();
		Panel1 = new Panel();
		Label2 = new Label();
		Panel2 = new Panel();
		Label3 = new Label();
		Button_PrintCaissier = new Button();
		Panel8 = new Panel();
		Label1 = new Label();
		Label9 = new Label();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label30 = new Label();
		Button20 = new Button();
		Button5 = new Button();
		DateTimePicker1 = new DateTimePicker();
		DateTimePicker2 = new DateTimePicker();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		Point location = new Point(4, 504);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		Size size = new Size(449, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 988;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 4);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 504);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 987;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(453, 4);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 504);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 986;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(0, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(457, 4);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 985;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		ListBox_RAPPORT_GLOBALE.Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ListControl)ListBox_RAPPORT_GLOBALE).FormattingEnabled = true;
		ListBox_RAPPORT_GLOBALE.ItemHeight = 19;
		ListBox_RAPPORT_GLOBALE.Items.AddRange(new object[2] { "Par Famille", "Par Article" });
		ListBox listBox_RAPPORT_GLOBALE = ListBox_RAPPORT_GLOBALE;
		location = new Point(20, 42);
		((Control)listBox_RAPPORT_GLOBALE).Location = location;
		((Control)ListBox_RAPPORT_GLOBALE).Name = "ListBox_RAPPORT_GLOBALE";
		ListBox listBox_RAPPORT_GLOBALE2 = ListBox_RAPPORT_GLOBALE;
		size = new Size(175, 61);
		((Control)listBox_RAPPORT_GLOBALE2).Size = size;
		((Control)ListBox_RAPPORT_GLOBALE).TabIndex = 989;
		ListBox_CAISSIERS.Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)ListBox_CAISSIERS).FormattingEnabled = true;
		ListBox_CAISSIERS.ItemHeight = 19;
		ListBox listBox_CAISSIERS = ListBox_CAISSIERS;
		location = new Point(20, 42);
		((Control)listBox_CAISSIERS).Location = location;
		((Control)ListBox_CAISSIERS).Name = "ListBox_CAISSIERS";
		ListBox listBox_CAISSIERS2 = ListBox_CAISSIERS;
		size = new Size(175, 61);
		((Control)listBox_CAISSIERS2).Size = size;
		((Control)ListBox_CAISSIERS).TabIndex = 990;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(201, 42);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(214, 61);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 991;
		((ButtonBase)Button_PrintRapport).Text = "IMPRIMER";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		Panel1.BorderStyle = (BorderStyle)1;
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)Button_PrintRapport);
		((Control)Panel1).Controls.Add((Control)(object)ListBox_RAPPORT_GLOBALE);
		Panel panel = Panel1;
		location = new Point(12, 12);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(430, 120);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 993;
		((Control)Label2).BackColor = Color.FromArgb(44, 53, 68);
		((Control)Label2).Cursor = Cursors.Hand;
		((Control)Label2).Dock = (DockStyle)1;
		((Control)Label2).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label = Label2;
		location = new Point(0, 0);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(428, 24);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 858;
		Label2.Text = "Rapport Globale";
		Label2.TextAlign = (ContentAlignment)16;
		Panel2.BorderStyle = (BorderStyle)1;
		((Control)Panel2).Controls.Add((Control)(object)Label3);
		((Control)Panel2).Controls.Add((Control)(object)ListBox_CAISSIERS);
		((Control)Panel2).Controls.Add((Control)(object)Button_PrintCaissier);
		Panel panel3 = Panel2;
		location = new Point(12, 185);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(430, 120);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 994;
		((Control)Label3).BackColor = Color.FromArgb(44, 53, 68);
		((Control)Label3).Cursor = Cursors.Hand;
		((Control)Label3).Dock = (DockStyle)1;
		((Control)Label3).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label3 = Label3;
		location = new Point(0, 0);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(428, 24);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 858;
		Label3.Text = "Rapport Caissier";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Button_PrintCaissier).Cursor = Cursors.Hand;
		((Control)Button_PrintCaissier).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintCaissier).Image = (Image)componentResourceManager.GetObject("Button_PrintCaissier.Image");
		((ButtonBase)Button_PrintCaissier).ImageAlign = (ContentAlignment)16;
		Button button_PrintCaissier = Button_PrintCaissier;
		location = new Point(201, 42);
		((Control)button_PrintCaissier).Location = location;
		((Control)Button_PrintCaissier).Name = "Button_PrintCaissier";
		Button button_PrintCaissier2 = Button_PrintCaissier;
		size = new Size(214, 61);
		((Control)button_PrintCaissier2).Size = size;
		((Control)Button_PrintCaissier).TabIndex = 992;
		((ButtonBase)Button_PrintCaissier).Text = "IMPRIMER";
		((ButtonBase)Button_PrintCaissier).UseVisualStyleBackColor = true;
		((Control)Panel8).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel8).Controls.Add((Control)(object)Label1);
		((Control)Panel8).Controls.Add((Control)(object)Label9);
		((Control)Panel8).Controls.Add((Control)(object)Label27);
		((Control)Panel8).Controls.Add((Control)(object)Label28);
		((Control)Panel8).Controls.Add((Control)(object)Label29);
		((Control)Panel8).Controls.Add((Control)(object)Label30);
		((Control)Panel8).Controls.Add((Control)(object)Button20);
		((Control)Panel8).Controls.Add((Control)(object)Button5);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker1);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker2);
		Panel panel5 = Panel8;
		location = new Point(135, 413);
		((Control)panel5).Location = location;
		((Control)Panel8).Name = "Panel8";
		Panel panel6 = Panel8;
		size = new Size(157, 83);
		((Control)panel6).Size = size;
		((Control)Panel8).TabIndex = 995;
		((Control)Label1).BackColor = Color.WhiteSmoke;
		((Control)Label1).Font = new Font("Tahoma", 8f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.FromArgb(64, 64, 64);
		Label label5 = Label1;
		location = new Point(4, 57);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(27, 20);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 979;
		Label1.Text = "A";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Label9).BackColor = Color.WhiteSmoke;
		((Control)Label9).Font = new Font("Tahoma", 8f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.FromArgb(64, 64, 64);
		Label label7 = Label9;
		location = new Point(4, 29);
		((Control)label7).Location = location;
		((Control)Label9).Name = "Label9";
		Label label8 = Label9;
		size = new Size(27, 20);
		((Control)label8).Size = size;
		((Control)Label9).TabIndex = 980;
		Label9.Text = "De";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)2;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label9 = Label27;
		location = new Point(1, 82);
		((Control)label9).Location = location;
		((Control)Label27).Name = "Label27";
		Label label10 = Label27;
		size = new Size(155, 1);
		((Control)label10).Size = size;
		((Control)Label27).TabIndex = 999;
		Label27.TextAlign = (ContentAlignment)16;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)3;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label11 = Label28;
		location = new Point(0, 1);
		((Control)label11).Location = location;
		((Control)Label28).Name = "Label28";
		Label label12 = Label28;
		size = new Size(1, 82);
		((Control)label12).Size = size;
		((Control)Label28).TabIndex = 998;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label29).Cursor = Cursors.Hand;
		((Control)Label29).Dock = (DockStyle)4;
		((Control)Label29).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label29).ForeColor = Color.White;
		Label label13 = Label29;
		location = new Point(156, 1);
		((Control)label13).Location = location;
		((Control)Label29).Name = "Label29";
		Label label14 = Label29;
		size = new Size(1, 82);
		((Control)label14).Size = size;
		((Control)Label29).TabIndex = 997;
		Label29.TextAlign = (ContentAlignment)16;
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label30).Cursor = Cursors.Hand;
		((Control)Label30).Dock = (DockStyle)1;
		((Control)Label30).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label30).ForeColor = Color.White;
		Label label15 = Label30;
		location = new Point(0, 0);
		((Control)label15).Location = location;
		((Control)Label30).Name = "Label30";
		Label label16 = Label30;
		size = new Size(157, 1);
		((Control)label16).Size = size;
		((Control)Label30).TabIndex = 996;
		Label30.Text = "-";
		Label30.TextAlign = (ContentAlignment)16;
		((Control)Button20).Cursor = Cursors.Hand;
		((ButtonBase)Button20).FlatStyle = (FlatStyle)0;
		((Control)Button20).Font = new Font("Tahoma", 10f, (FontStyle)1);
		((Control)Button20).ForeColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)Button20).Image = (Image)componentResourceManager.GetObject("Button20.Image");
		((ButtonBase)Button20).ImageAlign = (ContentAlignment)64;
		Button button = Button20;
		location = new Point(83, 5);
		((Control)button).Location = location;
		Button button2 = Button20;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button20).Name = "Button20";
		Button button3 = Button20;
		size = new Size(68, 21);
		((Control)button3).Size = size;
		((Control)Button20).TabIndex = 683;
		((ButtonBase)Button20).TextImageRelation = (TextImageRelation)8;
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).FlatStyle = (FlatStyle)0;
		((Control)Button5).Font = new Font("Tahoma", 10f, (FontStyle)1);
		((Control)Button5).ForeColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		((ButtonBase)Button5).ImageAlign = (ContentAlignment)16;
		Button button4 = Button5;
		location = new Point(6, 5);
		((Control)button4).Location = location;
		Button button5 = Button5;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button5).Name = "Button5";
		Button button6 = Button5;
		size = new Size(68, 21);
		((Control)button6).Size = size;
		((Control)Button5).TabIndex = 682;
		((ButtonBase)Button5).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button5).UseVisualStyleBackColor = true;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Enabled = false;
		((Control)DateTimePicker1).Font = new Font("Tahoma", 8f, (FontStyle)1);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(37, 29);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(114, 20);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker1).TabIndex = 363;
		DateTimePicker2.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker2).Enabled = false;
		((Control)DateTimePicker2).Font = new Font("Tahoma", 8f, (FontStyle)1);
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker3 = DateTimePicker2;
		location = new Point(37, 55);
		((Control)dateTimePicker3).Location = location;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DateTimePicker dateTimePicker4 = DateTimePicker2;
		size = new Size(114, 20);
		((Control)dateTimePicker4).Size = size;
		((Control)DateTimePicker2).TabIndex = 362;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(457, 508);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel8);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_RAPPORT";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "RAPPORT";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel8).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_config_Load(object sender, EventArgs e)
	{
		ListBox_CAISSIERS.Items.Clear();
		ListBox_CAISSIERS.Items.Add((object)((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_CAISSIER).Text);
		ListBox_RAPPORT_GLOBALE.SelectedIndex = 0;
		ListBox_CAISSIERS.SelectedIndex = 0;
	}

	private void Button_PrintRapport_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
		((Form)this).Close();
		string text = DateTimePicker1.Text;
		string text2 = DateTimePicker2.Text;
		string text3 = ListBox_RAPPORT_GLOBALE.Text;
		MyProject.Forms.Form_3_VENTE.Button244_Click(RuntimeHelpers.GetObjectValue(sender), e);
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Show();
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).SendToBack();
		((TabControl)MyProject.Forms.Form_3_VENTE_JOURNAL.TabControlEx1).SelectedIndex = 0;
		MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Text = text;
		MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Text = text2;
		MyProject.Forms.Form_3_VENTE_JOURNAL.ListBox_RAPPORT_GLOBALE.Text = text3;
		MyProject.Forms.Form_3_VENTE_JOURNAL.Button_PrintRapport.PerformClick();
		((Form)MyProject.Forms.Form_3_VENTE_JOURNAL).Close();
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void Button_PrintCaissier_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
		((Form)this).Close();
		string text = DateTimePicker1.Text;
		string text2 = DateTimePicker2.Text;
		string text3 = ListBox_CAISSIERS.Text;
		MyProject.Forms.Form_3_VENTE.Button244_Click(RuntimeHelpers.GetObjectValue(sender), e);
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Show();
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).SendToBack();
		((TabControl)MyProject.Forms.Form_3_VENTE_JOURNAL.TabControlEx1).SelectedIndex = 1;
		MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Text = text;
		MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Text = text2;
		MyProject.Forms.Form_3_VENTE_JOURNAL.ListBox_CAISSIERS.Text = text3;
		MyProject.Forms.Form_3_VENTE_JOURNAL.Button_PrintCaissier.PerformClick();
		((Form)MyProject.Forms.Form_3_VENTE_JOURNAL).Close();
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-1.0);
		DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1.0);
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1.0);
		DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1.0);
	}
}
