using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ETIQUETTE_AUTOC_A4 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel_CONFIG")]
	private Panel _Panel_CONFIG;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Numeric_TOP_TOP")]
	private NumericUpDown _Numeric_TOP_TOP;

	[AccessedThroughProperty("Numeric_LEFT_LEFT")]
	private NumericUpDown _Numeric_LEFT_LEFT;

	[AccessedThroughProperty("Numeric_NBR_ETIQUETTE_LIGNE")]
	private NumericUpDown _Numeric_NBR_ETIQUETTE_LIGNE;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Numeric_TOP")]
	private NumericUpDown _Numeric_TOP;

	[AccessedThroughProperty("Numeric_LEFT")]
	private NumericUpDown _Numeric_LEFT;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button_GO")]
	private Button _Button_GO;

	[AccessedThroughProperty("Text_code")]
	private TextBox _Text_code;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_article")]
	private TextBox _Text_article;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Numeric_qte")]
	private NumericUpDown _Numeric_qte;

	[AccessedThroughProperty("Text_prix_v")]
	private TextBox _Text_prix_v;

	internal virtual PrintDocument PrintDocument1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = PrintDocument1_PrintPage;
			if (_PrintDocument1 != null)
			{
				_PrintDocument1.PrintPage -= val;
			}
			_PrintDocument1 = value;
			if (_PrintDocument1 != null)
			{
				_PrintDocument1.PrintPage += val;
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

	internal virtual Panel Panel_CONFIG
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CONFIG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CONFIG = value;
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

	internal virtual NumericUpDown Numeric_TOP_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_TOP_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_TOP_TOP = value;
		}
	}

	internal virtual NumericUpDown Numeric_LEFT_LEFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_LEFT_LEFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_LEFT_LEFT = value;
		}
	}

	internal virtual NumericUpDown Numeric_NBR_ETIQUETTE_LIGNE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_NBR_ETIQUETTE_LIGNE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_NBR_ETIQUETTE_LIGNE = value;
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

	internal virtual NumericUpDown Numeric_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_TOP = value;
		}
	}

	internal virtual NumericUpDown Numeric_LEFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_LEFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_LEFT = value;
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
			_Button_GO = value;
		}
	}

	internal virtual TextBox Text_code
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_code = value;
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

	internal virtual TextBox Text_article
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_article;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_article = value;
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

	internal virtual NumericUpDown Numeric_qte
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric_qte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Numeric_qte = value;
		}
	}

	internal virtual TextBox Text_prix_v
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_prix_v;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_prix_v = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_ETIQUETTE_AUTOC_A4()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_etiquette_autoc_Load;
		((Form)this).FormClosed += FormDialog_etiquette_autoc_FormClosed;
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
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected Obj, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected Obj, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_1023: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Expected Obj, but got Unknown
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_122b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Expected Obj, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected Obj, but got Unknown
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got Unknown
		//IL_1440: Unknown result type (might be due to invalid IL or missing references)
		//IL_144a: Expected Obj, but got Unknown
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_1511: Expected Obj, but got Unknown
		//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c7: Expected Obj, but got Unknown
		//IL_168e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected Obj, but got Unknown
		//IL_176a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1774: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETIQUETTE_AUTOC_A4));
		PrintDocument1 = new PrintDocument();
		Panel2 = new Panel();
		Button6 = new Button();
		Panel_CONFIG = new Panel();
		Label12 = new Label();
		Label9 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Numeric_TOP_TOP = new NumericUpDown();
		Numeric_LEFT_LEFT = new NumericUpDown();
		Numeric_NBR_ETIQUETTE_LIGNE = new NumericUpDown();
		Label15 = new Label();
		Label14 = new Label();
		Numeric_TOP = new NumericUpDown();
		Numeric_LEFT = new NumericUpDown();
		Label11 = new Label();
		Button2 = new Button();
		Button1 = new Button();
		Label1 = new Label();
		Button_GO = new Button();
		Text_code = new TextBox();
		Label7 = new Label();
		Text_article = new TextBox();
		Label5 = new Label();
		Label2 = new Label();
		Numeric_qte = new NumericUpDown();
		Text_prix_v = new TextBox();
		((Control)Panel2).SuspendLayout();
		((Control)Panel_CONFIG).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)Numeric_TOP_TOP).BeginInit();
		((ISupportInitialize)Numeric_LEFT_LEFT).BeginInit();
		((ISupportInitialize)Numeric_NBR_ETIQUETTE_LIGNE).BeginInit();
		((ISupportInitialize)Numeric_TOP).BeginInit();
		((ISupportInitialize)Numeric_LEFT).BeginInit();
		((ISupportInitialize)Numeric_qte).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel2).BackColor = Color.FromArgb(220, 232, 250);
		Panel2.BorderStyle = (BorderStyle)1;
		((Control)Panel2).Controls.Add((Control)(object)Button2);
		((Control)Panel2).Controls.Add((Control)(object)Label1);
		((Control)Panel2).Controls.Add((Control)(object)Button_GO);
		((Control)Panel2).Controls.Add((Control)(object)Button1);
		((Control)Panel2).Controls.Add((Control)(object)Text_code);
		((Control)Panel2).Controls.Add((Control)(object)Label7);
		((Control)Panel2).Controls.Add((Control)(object)Text_article);
		((Control)Panel2).Controls.Add((Control)(object)Label5);
		((Control)Panel2).Controls.Add((Control)(object)Label2);
		((Control)Panel2).Controls.Add((Control)(object)Numeric_qte);
		((Control)Panel2).Controls.Add((Control)(object)Text_prix_v);
		((Control)Panel2).Controls.Add((Control)(object)Button6);
		((Control)Panel2).Controls.Add((Control)(object)Panel_CONFIG);
		Panel panel = Panel2;
		Point location = new Point(10, 10);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		Size size = new Size(433, 610);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 0;
		((Control)Button6).Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		((ButtonBase)Button6).Image = (Image)componentResourceManager.GetObject("Button6.Image");
		((ButtonBase)Button6).ImageAlign = (ContentAlignment)16;
		Button button = Button6;
		location = new Point(9, 297);
		((Control)button).Location = location;
		((Control)Button6).Name = "Button6";
		Button button2 = Button6;
		size = new Size(116, 30);
		((Control)button2).Size = size;
		((Control)Button6).TabIndex = 995;
		((ButtonBase)Button6).Text = "Paramètres";
		((ButtonBase)Button6).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button6).UseVisualStyleBackColor = true;
		((Control)Panel_CONFIG).BackColor = Color.FromArgb(220, 232, 250);
		Panel_CONFIG.BorderStyle = (BorderStyle)1;
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label12);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label9);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_TOP_TOP);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_LEFT_LEFT);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_NBR_ETIQUETTE_LIGNE);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label15);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label14);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_TOP);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Numeric_LEFT);
		((Control)Panel_CONFIG).Controls.Add((Control)(object)Label11);
		Panel panel_CONFIG = Panel_CONFIG;
		location = new Point(9, 333);
		((Control)panel_CONFIG).Location = location;
		((Control)Panel_CONFIG).Name = "Panel_CONFIG";
		Panel panel_CONFIG2 = Panel_CONFIG;
		size = new Size(413, 221);
		((Control)panel_CONFIG2).Size = size;
		((Control)Panel_CONFIG).TabIndex = 994;
		((Control)Panel_CONFIG).Visible = false;
		Label12.AutoSize = true;
		((Control)Label12).BackColor = Color.Transparent;
		((Control)Label12).Font = new Font("Cambria", 10f);
		((Control)Label12).ForeColor = Color.FromArgb(2, 45, 162);
		Label label = Label12;
		location = new Point(227, 47);
		((Control)label).Location = location;
		((Control)Label12).Name = "Label12";
		Label label2 = Label12;
		size = new Size(66, 16);
		((Control)label2).Size = size;
		((Control)Label12).TabIndex = 1018;
		Label12.Text = "ESPACE Y";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Cambria", 10f);
		((Control)Label9).ForeColor = Color.FromArgb(2, 45, 162);
		Label label3 = Label9;
		location = new Point(227, 16);
		((Control)label3).Location = location;
		((Control)Label9).Name = "Label9";
		Label label4 = Label9;
		size = new Size(66, 16);
		((Control)label4).Size = size;
		((Control)Label9).TabIndex = 1017;
		Label9.Text = "ESPACE X";
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(84, 40);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(32, 32);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 1016;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(84, 9);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(32, 32);
		((Control)pictureBox4).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 1015;
		PictureBox1.TabStop = false;
		((Control)Numeric_TOP_TOP).Font = new Font("Tahoma", 8f);
		NumericUpDown numeric_TOP_TOP = Numeric_TOP_TOP;
		location = new Point(299, 45);
		((Control)numeric_TOP_TOP).Location = location;
		NumericUpDown numeric_TOP_TOP2 = Numeric_TOP_TOP;
		decimal maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		numeric_TOP_TOP2.Maximum = maximum;
		((Control)Numeric_TOP_TOP).Name = "Numeric_TOP_TOP";
		NumericUpDown numeric_TOP_TOP3 = Numeric_TOP_TOP;
		size = new Size(50, 20);
		((Control)numeric_TOP_TOP3).Size = size;
		((Control)Numeric_TOP_TOP).TabIndex = 1009;
		maximum = (Numeric_TOP_TOP.Value = new decimal(new int[4] { 100, 0, 0, 0 }));
		((Control)Numeric_LEFT_LEFT).Font = new Font("Tahoma", 8f);
		NumericUpDown numeric_LEFT_LEFT = Numeric_LEFT_LEFT;
		location = new Point(299, 14);
		((Control)numeric_LEFT_LEFT).Location = location;
		maximum = (Numeric_LEFT_LEFT.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		((Control)Numeric_LEFT_LEFT).Name = "Numeric_LEFT_LEFT";
		NumericUpDown numeric_LEFT_LEFT2 = Numeric_LEFT_LEFT;
		size = new Size(50, 20);
		((Control)numeric_LEFT_LEFT2).Size = size;
		((Control)Numeric_LEFT_LEFT).TabIndex = 1008;
		maximum = (Numeric_LEFT_LEFT.Value = new decimal(new int[4] { 230, 0, 0, 0 }));
		((Control)Numeric_NBR_ETIQUETTE_LIGNE).Font = new Font("Tahoma", 8f);
		NumericUpDown numeric_NBR_ETIQUETTE_LIGNE = Numeric_NBR_ETIQUETTE_LIGNE;
		location = new Point(192, 130);
		((Control)numeric_NBR_ETIQUETTE_LIGNE).Location = location;
		maximum = (Numeric_NBR_ETIQUETTE_LIGNE.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		((Control)Numeric_NBR_ETIQUETTE_LIGNE).Name = "Numeric_NBR_ETIQUETTE_LIGNE";
		NumericUpDown numeric_NBR_ETIQUETTE_LIGNE2 = Numeric_NBR_ETIQUETTE_LIGNE;
		size = new Size(50, 20);
		((Control)numeric_NBR_ETIQUETTE_LIGNE2).Size = size;
		((Control)Numeric_NBR_ETIQUETTE_LIGNE).TabIndex = 1007;
		maximum = (Numeric_NBR_ETIQUETTE_LIGNE.Value = new decimal(new int[4] { 4, 0, 0, 0 }));
		Label15.AutoSize = true;
		((Control)Label15).BackColor = Color.Transparent;
		((Control)Label15).Font = new Font("Cambria", 10f);
		((Control)Label15).ForeColor = Color.FromArgb(2, 45, 162);
		Label label5 = Label15;
		location = new Point(10, 46);
		((Control)label5).Location = location;
		((Control)Label15).Name = "Label15";
		Label label6 = Label15;
		size = new Size(16, 16);
		((Control)label6).Size = size;
		((Control)Label15).TabIndex = 1013;
		Label15.Text = "Y";
		Label14.AutoSize = true;
		((Control)Label14).BackColor = Color.Transparent;
		((Control)Label14).Font = new Font("Cambria", 10f);
		((Control)Label14).ForeColor = Color.FromArgb(2, 45, 162);
		Label label7 = Label14;
		location = new Point(10, 15);
		((Control)label7).Location = location;
		((Control)Label14).Name = "Label14";
		Label label8 = Label14;
		size = new Size(16, 16);
		((Control)label8).Size = size;
		((Control)Label14).TabIndex = 1012;
		Label14.Text = "X";
		NumericUpDown numeric_TOP = Numeric_TOP;
		location = new Point(28, 46);
		((Control)numeric_TOP).Location = location;
		maximum = (Numeric_TOP.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (Numeric_TOP.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)Numeric_TOP).Name = "Numeric_TOP";
		NumericUpDown numeric_TOP2 = Numeric_TOP;
		size = new Size(50, 20);
		((Control)numeric_TOP2).Size = size;
		((Control)Numeric_TOP).TabIndex = 1011;
		NumericUpDown numeric_LEFT = Numeric_LEFT;
		location = new Point(28, 15);
		((Control)numeric_LEFT).Location = location;
		maximum = (Numeric_LEFT.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		maximum = (Numeric_LEFT.Minimum = new decimal(new int[4] { 1000, 0, 0, -2147483648 }));
		((Control)Numeric_LEFT).Name = "Numeric_LEFT";
		NumericUpDown numeric_LEFT2 = Numeric_LEFT;
		size = new Size(50, 20);
		((Control)numeric_LEFT2).Size = size;
		((Control)Numeric_LEFT).TabIndex = 1010;
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Font = new Font("Cambria", 10f);
		((Control)Label11).ForeColor = Color.FromArgb(2, 45, 162);
		Label label9 = Label11;
		location = new Point(74, 130);
		((Control)label9).Location = location;
		((Control)Label11).Name = "Label11";
		Label label10 = Label11;
		size = new Size(112, 16);
		((Control)label10).Size = size;
		((Control)Label11).TabIndex = 1014;
		Label11.Text = "Etiquettes/Ligne";
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button3 = Button2;
		location = new Point(286, 560);
		((Control)button3).Location = location;
		((Control)Button2).Name = "Button2";
		Button button4 = Button2;
		size = new Size(136, 39);
		((Control)button4).Size = size;
		((Control)Button2).TabIndex = 129;
		((ButtonBase)Button2).Text = "   Imprimer";
		((ButtonBase)Button2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button5 = Button1;
		location = new Point(9, 560);
		((Control)button5).Location = location;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(136, 39);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 128;
		((ButtonBase)Button1).Text = "    Aperçu";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((Control)Label1).BackColor = Color.Transparent;
		Label1.BorderStyle = (BorderStyle)2;
		((Control)Label1).Font = new Font("Calibri", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.FromArgb(2, 45, 162);
		Label label11 = Label1;
		location = new Point(9, 13);
		((Control)label11).Location = location;
		((Control)Label1).Name = "Label1";
		Label label12 = Label1;
		size = new Size(78, 24);
		((Control)label12).Size = size;
		((Control)Label1).TabIndex = 1000;
		Label1.Text = "CODE";
		Label1.TextAlign = (ContentAlignment)16;
		Button button_GO = Button_GO;
		location = new Point(411, 13);
		((Control)button_GO).Location = location;
		((Control)Button_GO).Name = "Button_GO";
		Button button_GO2 = Button_GO;
		size = new Size(10, 10);
		((Control)button_GO2).Size = size;
		((Control)Button_GO).TabIndex = 1004;
		((ButtonBase)Button_GO).Text = "GO";
		((ButtonBase)Button_GO).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_code).BackColor = Color.FromArgb(255, 99, 124);
		((TextBoxBase)Text_code).BorderStyle = (BorderStyle)1;
		((Control)Text_code).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_code).ForeColor = Color.White;
		TextBox text_code = Text_code;
		location = new Point(93, 13);
		((Control)text_code).Location = location;
		((Control)Text_code).Name = "Text_code";
		TextBox text_code2 = Text_code;
		size = new Size(328, 24);
		((Control)text_code2).Size = size;
		((Control)Text_code).TabIndex = 996;
		((Control)Label7).BackColor = Color.Transparent;
		Label7.BorderStyle = (BorderStyle)2;
		((Control)Label7).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.FromArgb(2, 45, 162);
		Label label13 = Label7;
		location = new Point(9, 104);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(78, 39);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 1003;
		Label7.Text = "QTE";
		Label7.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_article).BackColor = Color.FromArgb(46, 204, 113);
		((TextBoxBase)Text_article).BorderStyle = (BorderStyle)1;
		((Control)Text_article).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_article).ForeColor = Color.White;
		TextBox text_article = Text_article;
		location = new Point(93, 43);
		((Control)text_article).Location = location;
		((Control)Text_article).Name = "Text_article";
		TextBox text_article2 = Text_article;
		size = new Size(328, 24);
		((Control)text_article2).Size = size;
		((Control)Text_article).TabIndex = 997;
		((Control)Label5).BackColor = Color.Transparent;
		Label5.BorderStyle = (BorderStyle)2;
		((Control)Label5).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.FromArgb(2, 45, 162);
		Label label15 = Label5;
		location = new Point(9, 73);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(78, 24);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 1002;
		Label5.Text = "PRIX_V";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = Color.Transparent;
		Label2.BorderStyle = (BorderStyle)2;
		((Control)Label2).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.FromArgb(2, 45, 162);
		Label label17 = Label2;
		location = new Point(9, 43);
		((Control)label17).Location = location;
		((Control)Label2).Name = "Label2";
		Label label18 = Label2;
		size = new Size(78, 24);
		((Control)label18).Size = size;
		((Control)Label2).TabIndex = 1001;
		Label2.Text = "ARTICLE";
		Label2.TextAlign = (ContentAlignment)16;
		((UpDownBase)Numeric_qte).BorderStyle = (BorderStyle)1;
		((Control)Numeric_qte).Font = new Font("Cambria", 20.25f, (FontStyle)1);
		NumericUpDown numeric_qte = Numeric_qte;
		location = new Point(93, 104);
		((Control)numeric_qte).Location = location;
		((Control)Numeric_qte).Name = "Numeric_qte";
		NumericUpDown numeric_qte2 = Numeric_qte;
		size = new Size(328, 39);
		((Control)numeric_qte2).Size = size;
		((Control)Numeric_qte).TabIndex = 999;
		maximum = (Numeric_qte.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		((TextBoxBase)Text_prix_v).BackColor = Color.FromArgb(54, 198, 236);
		((TextBoxBase)Text_prix_v).BorderStyle = (BorderStyle)1;
		((Control)Text_prix_v).Font = new Font("Tahoma", 10f);
		((TextBoxBase)Text_prix_v).ForeColor = Color.White;
		TextBox text_prix_v = Text_prix_v;
		location = new Point(93, 73);
		((Control)text_prix_v).Location = location;
		((Control)Text_prix_v).Name = "Text_prix_v";
		TextBox text_prix_v2 = Text_prix_v;
		size = new Size(328, 24);
		((Control)text_prix_v2).Size = size;
		((Control)Text_prix_v).TabIndex = 998;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(453, 628);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_etiquette_autoc_A4";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "AUTOCOLLANT";
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel_CONFIG).ResumeLayout(false);
		((Control)Panel_CONFIG).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)Numeric_TOP_TOP).EndInit();
		((ISupportInitialize)Numeric_LEFT_LEFT).EndInit();
		((ISupportInitialize)Numeric_NBR_ETIQUETTE_LIGNE).EndInit();
		((ISupportInitialize)Numeric_TOP).EndInit();
		((ISupportInitialize)Numeric_LEFT).EndInit();
		((ISupportInitialize)Numeric_qte).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_etiquette_autoc_FormClosed(object sender, FormClosedEventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		StreamWriter streamWriter = new StreamWriter(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_A4.sni", append: false, Encoding.UTF8);
		foreach (Control control in ((Control)Panel_CONFIG).Controls)
		{
			Control val = control;
			if ((val is TextBox) | (val is NumericUpDown))
			{
				streamWriter.WriteLine(val.Name + "|" + val.Text);
			}
			if (val is CheckBox)
			{
				streamWriter.WriteLine(val.Name + "|" + Conversions.ToString(((CheckBox)val).Checked));
			}
			if (val is RadioButton)
			{
				streamWriter.WriteLine(val.Name + "|" + Conversions.ToString(((RadioButton)val).Checked));
			}
			if (val is ComboBox)
			{
				streamWriter.WriteLine(val.Name + "|" + ((ComboBox)val).Text);
			}
		}
		streamWriter.Close();
	}

	private void FormDialog_etiquette_autoc_Load(object sender, EventArgs e)
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StreamReader streamReader = new StreamReader(Module1._CHEMIN_FOLDER + "\\bd\\config\\etiquette_AUTOC_A4.sni", Encoding.UTF8);
			while (streamReader.Peek() > -1)
			{
				string[] array = streamReader.ReadLine().Split(new char[1] { '|' });
				Control val = ((Control)Panel_CONFIG).Controls[array[0]];
				if ((val is TextBox) | (val is NumericUpDown))
				{
					val.Text = array[1];
				}
				if (val is CheckBox)
				{
					((CheckBox)val).Checked = Conversions.ToBoolean(array[1]);
				}
				if (val is RadioButton)
				{
					((RadioButton)val).Checked = Conversions.ToBoolean(array[1]);
				}
				if (val is ComboBox)
				{
					((ComboBox)val).Text = array[1];
				}
			}
			streamReader.Close();
			Text_code.Text = "";
			Text_article.Text = "";
			Text_prix_v.Text = "";
			Text_code.Text = Strings.Trim(Conversions.ToString(MyProject.Forms.Form_2_ARTICLES.DataGridView1.Rows[((DataGridViewBand)MyProject.Forms.Form_2_ARTICLES.DataGridView1.CurrentRow).Index].Cells[0].Value));
			Text_article.Text = Strings.Trim(Conversions.ToString(MyProject.Forms.Form_2_ARTICLES.DataGridView1.Rows[((DataGridViewBand)MyProject.Forms.Form_2_ARTICLES.DataGridView1.CurrentRow).Index].Cells[1].Value));
			Text_prix_v.Text = Strings.FormatNumber(Strings.Trim(Conversions.ToString(MyProject.Forms.Form_2_ARTICLES.DataGridView1.Rows[((DataGridViewBand)MyProject.Forms.Form_2_ARTICLES.DataGridView1.CurrentRow).Index].Cells[3].Value)));
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		try
		{
			PrintDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 827, 1169);
			PrintPreviewDialog val = new PrintPreviewDialog();
			val.Document = PrintDocument1;
			val.PrintPreviewControl.Zoom = 1.0;
			((Form)val).WindowState = (FormWindowState)2;
			((Form)val).ShowDialog();
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		try
		{
			PrintDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 827, 1169);
			PrintPreviewDialog val = new PrintPreviewDialog();
			val.Document = PrintDocument1;
			val.PrintPreviewControl.Zoom = 1.0;
			((Form)val).WindowState = (FormWindowState)2;
			((Form)val).ShowDialog();
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

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		Module1.Code128(Text_code.Text, "A");
		string binaryz = Module1.Binaryz;
		Bitmap val = new Bitmap(Strings.Len(Module1.Binaryz), 60, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, ((Image)val).Width, ((Image)val).Height);
		Brush val3 = (Brush)new LinearGradientBrush(rectangle, Color.White, Color.White, (LinearGradientMode)2);
		val2.FillRectangle(val3, rectangle);
		int num = Conversions.ToInteger(Numeric_LEFT.Text);
		int num2 = Conversions.ToInteger(Numeric_TOP.Text);
		double num3 = Convert.ToDouble(decimal.Divide(Numeric_qte.Value, Numeric_NBR_ETIQUETTE_LIGNE.Value));
		double num4 = num3;
		double num5 = 1.0;
		checked
		{
			while (true)
			{
				double num6 = num5;
				double num7 = num4;
				if (!(num6 <= num7))
				{
					break;
				}
				decimal value = Numeric_NBR_ETIQUETTE_LIGNE.Value;
				decimal num8 = 1m;
				while (ObjectFlowControl.ForLoopControl.ForNextCheckDec(num8, value, 1m))
				{
					int num9 = Strings.Len(Module1.Binaryz);
					int num10 = 1;
					while (true)
					{
						int num11 = num10;
						int num12 = num9;
						if (num11 > num12)
						{
							break;
						}
						string left = Strings.Mid(Module1.Binaryz, num10, 1);
						if (Operators.CompareString(left, "0", TextCompare: false) == 0)
						{
							Pen val4 = new Pen(Color.Black, 1f);
							Point point = new Point(num10 + num, 0 + num2);
							Point point2 = new Point(num10 + num, 40 + num2);
							e.Graphics.DrawLine(val4, point, point2);
						}
						else
						{
							Pen val4 = new Pen(Color.White, 1f);
							Point point = new Point(num10 + num, 0 + num2);
							Point point2 = new Point(num10 + num, 40 + num2);
							e.Graphics.DrawLine(val4, point, point2);
						}
						num10++;
					}
					e.Graphics.DrawString(Strings.Mid(Text_article.Text, 1, 12), new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, (float)num, (float)(num2 - 10), new StringFormat((StringFormatFlags)8192));
					e.Graphics.DrawString(Text_code.Text + " . " + Text_prix_v.Text + " DH", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, (float)num, (float)(num2 + 40), new StringFormat((StringFormatFlags)8192));
					num = Convert.ToInt32(decimal.Add(new decimal(num), Numeric_LEFT_LEFT.Value));
					num8 = decimal.Add(num8, 1m);
				}
				num = Conversions.ToInteger(Numeric_LEFT.Text);
				num2 = Convert.ToInt32(decimal.Add(new decimal(num2), Numeric_TOP_TOP.Value));
				num5++;
			}
		}
	}

	private void Text_code_TextChanged(object sender, EventArgs e)
	{
		Button_GO.PerformClick();
	}

	private void Text_article_TextChanged(object sender, EventArgs e)
	{
		Button_GO.PerformClick();
	}

	private void Text_prix_v_TextChanged(object sender, EventArgs e)
	{
		Button_GO.PerformClick();
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		((Control)Panel_CONFIG).Visible = true;
	}

	private void Button_GO_Click(object sender, EventArgs e)
	{
	}
}
