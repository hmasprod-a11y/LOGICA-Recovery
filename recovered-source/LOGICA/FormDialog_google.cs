using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_google : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("Button_google")]
	private Button _Button_google;

	[AccessedThroughProperty("Panel_google")]
	private Panel _Panel_google;

	[AccessedThroughProperty("Button_bd")]
	private Button _Button_bd;

	[AccessedThroughProperty("Panel_bd")]
	private Panel _Panel_bd;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("FlowLayoutPanel2")]
	private FlowLayoutPanel _FlowLayoutPanel2;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel_text")]
	private Panel _Panel_text;

	[AccessedThroughProperty("Numeric1")]
	private NumericUpDown _Numeric1;

	[AccessedThroughProperty("Radio3")]
	private RadioButton _Radio3;

	[AccessedThroughProperty("Radio2")]
	private RadioButton _Radio2;

	[AccessedThroughProperty("Radio1")]
	private RadioButton _Radio1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_GO")]
	private TextBox _Text_GO;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Button_COLOR")]
	private Button _Button_COLOR;

	[AccessedThroughProperty("Button_TEXT")]
	private Button _Button_TEXT;

	[AccessedThroughProperty("Check_png")]
	private CheckBox _Check_png;

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = WebBrowser1_DocumentCompleted;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.DocumentCompleted -= val;
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.DocumentCompleted += val;
			}
		}
	}

	internal virtual Button Button_google
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_google;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_google_Click;
			if (_Button_google != null)
			{
				((Control)_Button_google).Click -= eventHandler;
			}
			_Button_google = value;
			if (_Button_google != null)
			{
				((Control)_Button_google).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_google
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_google;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_google = value;
		}
	}

	internal virtual Button Button_bd
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_bd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_bd_Click;
			if (_Button_bd != null)
			{
				((Control)_Button_bd).Click -= eventHandler;
			}
			_Button_bd = value;
			if (_Button_bd != null)
			{
				((Control)_Button_bd).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_bd
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_bd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_bd = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
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

	internal virtual FlowLayoutPanel FlowLayoutPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel2 = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox2 = value;
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
			_Button1 = value;
		}
	}

	internal virtual Panel Panel_text
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_text;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_text = value;
		}
	}

	internal virtual NumericUpDown Numeric1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Numeric1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Numeric1_ValueChanged;
			if (_Numeric1 != null)
			{
				_Numeric1.ValueChanged -= eventHandler;
			}
			_Numeric1 = value;
			if (_Numeric1 != null)
			{
				_Numeric1.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio3_CheckedChanged;
			if (_Radio3 != null)
			{
				_Radio3.CheckedChanged -= eventHandler;
			}
			_Radio3 = value;
			if (_Radio3 != null)
			{
				_Radio3.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio2_CheckedChanged;
			if (_Radio2 != null)
			{
				_Radio2.CheckedChanged -= eventHandler;
			}
			_Radio2 = value;
			if (_Radio2 != null)
			{
				_Radio2.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio1_CheckedChanged;
			if (_Radio1 != null)
			{
				_Radio1.CheckedChanged -= eventHandler;
			}
			_Radio1 = value;
			if (_Radio1 != null)
			{
				_Radio1.CheckedChanged += eventHandler;
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

	internal virtual TextBox Text_GO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_GO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_GO_TextChanged;
			EventHandler eventHandler2 = Text_GO_Click;
			if (_Text_GO != null)
			{
				((Control)_Text_GO).TextChanged -= eventHandler;
				((TextBoxBase)_Text_GO).Click -= eventHandler2;
			}
			_Text_GO = value;
			if (_Text_GO != null)
			{
				((Control)_Text_GO).TextChanged += eventHandler;
				((TextBoxBase)_Text_GO).Click += eventHandler2;
			}
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

	internal virtual Button Button_COLOR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_COLOR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_COLOR_Click;
			if (_Button_COLOR != null)
			{
				((Control)_Button_COLOR).Click -= eventHandler;
			}
			_Button_COLOR = value;
			if (_Button_COLOR != null)
			{
				((Control)_Button_COLOR).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_TEXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TEXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button13_Click;
			if (_Button_TEXT != null)
			{
				((Control)_Button_TEXT).Click -= eventHandler;
			}
			_Button_TEXT = value;
			if (_Button_TEXT != null)
			{
				((Control)_Button_TEXT).Click += eventHandler;
			}
		}
	}

	internal virtual CheckBox Check_png
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_png;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_png = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_google()
	{
		((Control)this).Resize += FormDialog_google_Resize;
		((Form)this).Load += FormDialog_google_Load;
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
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected Obj, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected Obj, but got Unknown
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected Obj, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected Obj, but got Unknown
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Expected Obj, but got Unknown
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected Obj, but got Unknown
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected Obj, but got Unknown
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_google));
		WebBrowser1 = new WebBrowser();
		Button_google = new Button();
		Panel_google = new Panel();
		Button4 = new Button();
		Button_bd = new Button();
		Panel_bd = new Panel();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		FlowLayoutPanel2 = new FlowLayoutPanel();
		Button1 = new Button();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		Panel_text = new Panel();
		Numeric1 = new NumericUpDown();
		Radio3 = new RadioButton();
		Radio2 = new RadioButton();
		Radio1 = new RadioButton();
		Label7 = new Label();
		Text_GO = new TextBox();
		Label15 = new Label();
		Button_COLOR = new Button();
		Button_TEXT = new Button();
		Check_png = new CheckBox();
		((Control)Panel_google).SuspendLayout();
		((Control)Panel_bd).SuspendLayout();
		((Control)FlowLayoutPanel2).SuspendLayout();
		((Control)Panel_text).SuspendLayout();
		((ISupportInitialize)Numeric1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).Anchor = (AnchorStyles)15;
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 3);
		((Control)webBrowser).Location = location;
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).MinimumSize = minimumSize;
		((Control)WebBrowser1).Name = "WebBrowser1";
		WebBrowser1.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(402, 666);
		((Control)webBrowser3).Size = minimumSize;
		((Control)WebBrowser1).TabIndex = 705;
		((Control)Button_google).Anchor = (AnchorStyles)13;
		((Control)Button_google).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_google).Image = (Image)componentResourceManager.GetObject("Button_google.Image");
		((ButtonBase)Button_google).ImageAlign = (ContentAlignment)16;
		Button button_google = Button_google;
		location = new Point(0, 0);
		((Control)button_google).Location = location;
		((Control)Button_google).Name = "Button_google";
		Button button_google2 = Button_google;
		minimumSize = new Size(402, 43);
		((Control)button_google2).Size = minimumSize;
		((Control)Button_google).TabIndex = 706;
		((ButtonBase)Button_google).Text = "Google";
		((ButtonBase)Button_google).UseVisualStyleBackColor = true;
		((Control)Panel_google).Anchor = (AnchorStyles)15;
		((Control)Panel_google).Controls.Add((Control)(object)Button4);
		((Control)Panel_google).Controls.Add((Control)(object)WebBrowser1);
		Panel panel_google = Panel_google;
		location = new Point(0, 73);
		((Control)panel_google).Location = location;
		((Control)Panel_google).Name = "Panel_google";
		Panel panel_google2 = Panel_google;
		minimumSize = new Size(402, 666);
		((Control)panel_google2).Size = minimumSize;
		((Control)Panel_google).TabIndex = 707;
		((Control)Panel_google).Visible = false;
		Button button = Button4;
		location = new Point(141, 63);
		((Control)button).Location = location;
		((Control)Button4).Name = "Button4";
		Button button2 = Button4;
		minimumSize = new Size(103, 52);
		((Control)button2).Size = minimumSize;
		((Control)Button4).TabIndex = 706;
		((ButtonBase)Button4).Text = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Button4).Visible = false;
		((Control)Button_bd).Anchor = (AnchorStyles)13;
		((Control)Button_bd).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_bd).Image = (Image)componentResourceManager.GetObject("Button_bd.Image");
		((ButtonBase)Button_bd).ImageAlign = (ContentAlignment)16;
		Button button_bd = Button_bd;
		location = new Point(0, 0);
		((Control)button_bd).Location = location;
		((Control)Button_bd).Name = "Button_bd";
		Button button_bd2 = Button_bd;
		minimumSize = new Size(402, 43);
		((Control)button_bd2).Size = minimumSize;
		((Control)Button_bd).TabIndex = 708;
		((ButtonBase)Button_bd).Text = "   Base\r\n   Données";
		((ButtonBase)Button_bd).UseVisualStyleBackColor = true;
		((Control)Panel_bd).Anchor = (AnchorStyles)15;
		((Control)Panel_bd).Controls.Add((Control)(object)FlowLayoutPanel1);
		((Control)Panel_bd).Controls.Add((Control)(object)FlowLayoutPanel2);
		Panel panel_bd = Panel_bd;
		location = new Point(0, 73);
		((Control)panel_bd).Location = location;
		((Control)Panel_bd).Name = "Panel_bd";
		Panel panel_bd2 = Panel_bd;
		minimumSize = new Size(402, 666);
		((Control)panel_bd2).Size = minimumSize;
		((Control)Panel_bd).TabIndex = 709;
		((Control)Panel_bd).Visible = false;
		((Control)FlowLayoutPanel1).Anchor = (AnchorStyles)15;
		((ScrollableControl)FlowLayoutPanel1).AutoScroll = true;
		((Control)FlowLayoutPanel1).BackColor = SystemColors.Control;
		((Panel)FlowLayoutPanel1).BorderStyle = (BorderStyle)1;
		((Control)FlowLayoutPanel1).Font = new Font("Tahoma", 7f);
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		location = new Point(0, 151);
		((Control)flowLayoutPanel).Location = location;
		FlowLayoutPanel flowLayoutPanel2 = FlowLayoutPanel1;
		Padding margin = new Padding(0);
		((Control)flowLayoutPanel2).Margin = margin;
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		FlowLayoutPanel flowLayoutPanel3 = FlowLayoutPanel1;
		minimumSize = new Size(402, 515);
		((Control)flowLayoutPanel3).Size = minimumSize;
		((Control)FlowLayoutPanel1).TabIndex = 707;
		((Control)FlowLayoutPanel2).Anchor = (AnchorStyles)13;
		((ScrollableControl)FlowLayoutPanel2).AutoScroll = true;
		((Control)FlowLayoutPanel2).BackColor = SystemColors.Control;
		((Panel)FlowLayoutPanel2).BorderStyle = (BorderStyle)1;
		((Control)FlowLayoutPanel2).Controls.Add((Control)(object)Button1);
		((Control)FlowLayoutPanel2).Font = new Font("Tahoma", 7f);
		FlowLayoutPanel flowLayoutPanel4 = FlowLayoutPanel2;
		location = new Point(0, 0);
		((Control)flowLayoutPanel4).Location = location;
		FlowLayoutPanel flowLayoutPanel5 = FlowLayoutPanel2;
		margin = new Padding(0);
		((Control)flowLayoutPanel5).Margin = margin;
		((Control)FlowLayoutPanel2).Name = "FlowLayoutPanel2";
		FlowLayoutPanel flowLayoutPanel6 = FlowLayoutPanel2;
		minimumSize = new Size(402, 140);
		((Control)flowLayoutPanel6).Size = minimumSize;
		((Control)FlowLayoutPanel2).TabIndex = 841;
		((ButtonBase)Button1).AutoSize = true;
		((Control)Button1).Font = new Font("Tahoma", 13f, (FontStyle)1);
		Button button3 = Button1;
		location = new Point(3, 3);
		((Control)button3).Location = location;
		((Control)Button1).Name = "Button1";
		Button button4 = Button1;
		minimumSize = new Size(152, 33);
		((Control)button4).Size = minimumSize;
		((Control)Button1).TabIndex = 0;
		((ButtonBase)Button1).Text = "Button1eeeee";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox listBox = ListBox1;
		location = new Point(485, 136);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		minimumSize = new Size(118, 251);
		((Control)listBox2).Size = minimumSize;
		((Control)ListBox1).TabIndex = 710;
		((Control)ListBox1).Visible = false;
		((ListControl)ListBox2).FormattingEnabled = true;
		ListBox2.HorizontalScrollbar = true;
		ListBox listBox3 = ListBox2;
		location = new Point(431, 36);
		((Control)listBox3).Location = location;
		((Control)ListBox2).Name = "ListBox2";
		ListBox2.ScrollAlwaysVisible = true;
		ListBox listBox4 = ListBox2;
		minimumSize = new Size(85, 56);
		((Control)listBox4).Size = minimumSize;
		((Control)ListBox2).TabIndex = 842;
		((Control)Panel_text).Anchor = (AnchorStyles)15;
		((Control)Panel_text).Controls.Add((Control)(object)Numeric1);
		((Control)Panel_text).Controls.Add((Control)(object)Radio3);
		((Control)Panel_text).Controls.Add((Control)(object)Radio2);
		((Control)Panel_text).Controls.Add((Control)(object)Radio1);
		((Control)Panel_text).Controls.Add((Control)(object)Label7);
		((Control)Panel_text).Controls.Add((Control)(object)Text_GO);
		((Control)Panel_text).Controls.Add((Control)(object)Label15);
		((Control)Panel_text).Controls.Add((Control)(object)Button_COLOR);
		Panel panel_text = Panel_text;
		location = new Point(0, 73);
		((Control)panel_text).Location = location;
		((Control)Panel_text).Name = "Panel_text";
		Panel panel_text2 = Panel_text;
		minimumSize = new Size(402, 666);
		((Control)panel_text2).Size = minimumSize;
		((Control)Panel_text).TabIndex = 843;
		((Control)Panel_text).Visible = false;
		((Control)Numeric1).Font = new Font("Tahoma", 17f, (FontStyle)1);
		NumericUpDown numeric = Numeric1;
		location = new Point(209, 74);
		((Control)numeric).Location = location;
		NumericUpDown numeric2 = Numeric1;
		decimal minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numeric2.Minimum = minimum;
		((Control)Numeric1).Name = "Numeric1";
		NumericUpDown numeric3 = Numeric1;
		minimumSize = new Size(52, 35);
		((Control)numeric3).Size = minimumSize;
		((Control)Numeric1).TabIndex = 850;
		minimum = (Numeric1.Value = new decimal(new int[4] { 13, 0, 0, 0 }));
		Radio3.Appearance = (Appearance)1;
		((ButtonBase)Radio3).AutoSize = true;
		((ButtonBase)Radio3).Image = (Image)componentResourceManager.GetObject("Radio3.Image");
		((ButtonBase)Radio3).ImeMode = (ImeMode)0;
		RadioButton radio = Radio3;
		location = new Point(229, 21);
		((Control)radio).Location = location;
		((Control)Radio3).Name = "Radio3";
		RadioButton radio2 = Radio3;
		minimumSize = new Size(32, 32);
		((Control)radio2).Size = minimumSize;
		((Control)Radio3).TabIndex = 849;
		Radio3.TabStop = true;
		((ButtonBase)Radio3).UseVisualStyleBackColor = true;
		Radio2.Appearance = (Appearance)1;
		((ButtonBase)Radio2).AutoSize = true;
		((ButtonBase)Radio2).Image = (Image)componentResourceManager.GetObject("Radio2.Image");
		((ButtonBase)Radio2).ImeMode = (ImeMode)0;
		RadioButton radio3 = Radio2;
		location = new Point(141, 21);
		((Control)radio3).Location = location;
		((Control)Radio2).Name = "Radio2";
		RadioButton radio4 = Radio2;
		minimumSize = new Size(32, 32);
		((Control)radio4).Size = minimumSize;
		((Control)Radio2).TabIndex = 848;
		Radio2.TabStop = true;
		((ButtonBase)Radio2).UseVisualStyleBackColor = true;
		Radio1.Appearance = (Appearance)1;
		((ButtonBase)Radio1).AutoSize = true;
		((ButtonBase)Radio1).Image = (Image)componentResourceManager.GetObject("Radio1.Image");
		((ButtonBase)Radio1).ImeMode = (ImeMode)0;
		RadioButton radio5 = Radio1;
		location = new Point(185, 21);
		((Control)radio5).Location = location;
		((Control)Radio1).Name = "Radio1";
		RadioButton radio6 = Radio1;
		minimumSize = new Size(32, 32);
		((Control)radio6).Size = minimumSize;
		((Control)Radio1).TabIndex = 847;
		Radio1.TabStop = true;
		((ButtonBase)Radio1).UseVisualStyleBackColor = true;
		((Control)Label7).BackColor = Color.Transparent;
		Label7.BorderStyle = (BorderStyle)2;
		((Control)Label7).Font = new Font("Cambria", 10f);
		((Control)Label7).ForeColor = Color.FromArgb(2, 45, 162);
		Label7.ImeMode = (ImeMode)0;
		Label label = Label7;
		location = new Point(141, 117);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		Label label2 = Label7;
		minimumSize = new Size(63, 35);
		((Control)label2).Size = minimumSize;
		((Control)Label7).TabIndex = 846;
		Label7.Text = "Couleur";
		Label7.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_GO).BorderStyle = (BorderStyle)1;
		((Control)Text_GO).Font = new Font("Segoe UI", 13f, (FontStyle)1);
		TextBox text_GO = Text_GO;
		location = new Point(141, 164);
		((Control)text_GO).Location = location;
		TextBox text_GO2 = Text_GO;
		margin = new Padding(0);
		((Control)text_GO2).Margin = margin;
		Text_GO.Multiline = true;
		((Control)Text_GO).Name = "Text_GO";
		TextBox text_GO3 = Text_GO;
		minimumSize = new Size(120, 76);
		((Control)text_GO3).Size = minimumSize;
		((Control)Text_GO).TabIndex = 843;
		((Control)Label15).BackColor = Color.Transparent;
		Label15.BorderStyle = (BorderStyle)2;
		((Control)Label15).Font = new Font("Cambria", 10f);
		((Control)Label15).ForeColor = Color.FromArgb(2, 45, 162);
		Label15.ImeMode = (ImeMode)0;
		Label label3 = Label15;
		location = new Point(141, 73);
		((Control)label3).Location = location;
		((Control)Label15).Name = "Label15";
		Label label4 = Label15;
		minimumSize = new Size(62, 35);
		((Control)label4).Size = minimumSize;
		((Control)Label15).TabIndex = 845;
		Label15.Text = "Taille";
		Label15.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_COLOR).Image = (Image)componentResourceManager.GetObject("Button_COLOR.Image");
		((ButtonBase)Button_COLOR).ImeMode = (ImeMode)0;
		Button button_COLOR = Button_COLOR;
		location = new Point(209, 117);
		((Control)button_COLOR).Location = location;
		((Control)Button_COLOR).Name = "Button_COLOR";
		Button button_COLOR2 = Button_COLOR;
		minimumSize = new Size(52, 35);
		((Control)button_COLOR2).Size = minimumSize;
		((Control)Button_COLOR).TabIndex = 844;
		((ButtonBase)Button_COLOR).UseVisualStyleBackColor = true;
		((Control)Button_TEXT).Cursor = Cursors.Hand;
		((Control)Button_TEXT).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_TEXT).Image = (Image)componentResourceManager.GetObject("Button_TEXT.Image");
		((ButtonBase)Button_TEXT).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_TEXT).ImeMode = (ImeMode)0;
		Button button_TEXT = Button_TEXT;
		location = new Point(0, 0);
		((Control)button_TEXT).Location = location;
		((Control)Button_TEXT).Name = "Button_TEXT";
		Button button_TEXT2 = Button_TEXT;
		minimumSize = new Size(402, 43);
		((Control)button_TEXT2).Size = minimumSize;
		((Control)Button_TEXT).TabIndex = 769;
		((ButtonBase)Button_TEXT).Text = "Text";
		((ButtonBase)Button_TEXT).UseVisualStyleBackColor = true;
		((ButtonBase)Check_png).AutoSize = true;
		Check_png.Checked = true;
		Check_png.CheckState = (CheckState)1;
		CheckBox check_png = Check_png;
		location = new Point(358, 53);
		((Control)check_png).Location = location;
		((Control)Check_png).Name = "Check_png";
		CheckBox check_png2 = Check_png;
		minimumSize = new Size(44, 17);
		((Control)check_png2).Size = minimumSize;
		((Control)Check_png).TabIndex = 847;
		((ButtonBase)Check_png).Text = "png";
		((ButtonBase)Check_png).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		minimumSize = new Size(404, 742);
		((Form)this).ClientSize = minimumSize;
		((Control)this).Controls.Add((Control)(object)Check_png);
		((Control)this).Controls.Add((Control)(object)ListBox2);
		((Control)this).Controls.Add((Control)(object)ListBox1);
		((Control)this).Controls.Add((Control)(object)Button_google);
		((Control)this).Controls.Add((Control)(object)Button_bd);
		((Control)this).Controls.Add((Control)(object)Button_TEXT);
		((Control)this).Controls.Add((Control)(object)Panel_google);
		((Control)this).Controls.Add((Control)(object)Panel_text);
		((Control)this).Controls.Add((Control)(object)Panel_bd);
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_google";
		((Form)this).ShowIcon = false;
		((Form)this).Text = " ";
		((Form)this).TopMost = true;
		((Control)Panel_google).ResumeLayout(false);
		((Control)Panel_bd).ResumeLayout(false);
		((Control)FlowLayoutPanel2).ResumeLayout(false);
		((Control)FlowLayoutPanel2).PerformLayout();
		((Control)Panel_text).ResumeLayout(false);
		((Control)Panel_text).PerformLayout();
		((ISupportInitialize)Numeric1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button_google_Click(object sender, EventArgs e)
	{
		((Control)Panel_google).Visible = true;
		((Control)Panel_bd).Visible = false;
		((Control)Panel_text).Visible = false;
		((Control)Panel_google).BringToFront();
		string text = "";
		if (Check_png.Checked)
		{
			text = " + png";
		}
		if (Operators.CompareString(((Form)this).Text, "ARTICLE", TextCompare: false) == 0)
		{
			WebBrowser1.Navigate("https://www.bing.com/images/search?q=" + MyProject.Forms.Form_2_ARTICLES.Text_ARTICLE.Text + text);
		}
		else if (Operators.CompareString(((Form)this).Text, "FAMILLE", TextCompare: false) == 0)
		{
			WebBrowser1.Navigate("https://www.bing.com/images/search?q=" + MyProject.Forms.Form_2_Familles.Text_FAMILLE.Text + text);
		}
	}

	private void FormDialog_google_Load(object sender, EventArgs e)
	{
		((Control)this).Top = 0;
		((Control)this).Left = 0;
	}

	private void Button_bd_Click(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_google).Visible = false;
		((Control)Panel_bd).Visible = true;
		((Control)Panel_text).Visible = false;
		((Control)Panel_bd).BringToFront();
		ListBox2.Items.Clear();
		foreach (string directory in ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(Module1._CHEMIN_FOLDER + "\\bd\\config.img\\", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[1] { "*" }))
		{
			ListBox2.Items.Add((object)Path.GetFileName(directory));
		}
		((Control)FlowLayoutPanel2).Controls.Clear();
		checked
		{
			int num = ListBox2.Items.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Button val = new Button();
					((ButtonBase)val).AutoSize = true;
					((Control)val).Font = new Font("Tahoma", 13f, (FontStyle)1);
					((ButtonBase)val).Text = ListBox2.Items[num2].ToString();
					Padding margin = new Padding(0, 0, 0, 0);
					((Control)val).Margin = margin;
					((Control)val).Cursor = Cursors.Hand;
					((Control)val).Click += CAT_click;
					((Control)FlowLayoutPanel2).Controls.Add((Control)(object)val);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void CAT_click(object sender, EventArgs e)
	{
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				ReadOnlyCollection<string> files = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Module1._CHEMIN_FOLDER + "\\bd\\config.img\\", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "\\")), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[1] { "*.jpg" });
				ListBox1.Items.Clear();
				foreach (string item in files)
				{
					ListBox1.Items.Add((object)item);
				}
				((Control)FlowLayoutPanel1).Controls.Clear();
				int num = ListBox1.Items.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						PictureBox val = new PictureBox();
						Padding margin = new Padding(0, 0, 0, 0);
						((Control)val).Margin = margin;
						((Control)val).Width = 120;
						((Control)val).Height = 86;
						((Control)val).Cursor = Cursors.Hand;
						val.Image = Image.FromFile(ListBox1.Items[num2].ToString());
						val.SizeMode = (PictureBoxSizeMode)1;
						((Control)val).Click += FAM_click;
						((Control)FlowLayoutPanel1).Controls.Add((Control)(object)val);
						num2++;
						continue;
					}
					break;
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

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	public void FAM_click(object sender, EventArgs e)
	{
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(((Form)this).Text, "ARTICLE", TextCompare: false) == 0)
			{
				MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "Image", new object[0], null, null, null);
				Bitmap val = new Bitmap(((Control)MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE).Size.Width, ((Control)MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE).Size.Height);
				PictureBox picture_IMAGE = MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE;
				Rectangle rectangle = new Rectangle(0, 0, ((Control)MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE).Width, ((Control)MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE).Height);
				((Control)picture_IMAGE).DrawToBitmap(val, rectangle);
				MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE.Image = (Image)(object)val;
				MyProject.Forms.Form_2_ARTICLES.Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
			}
			else if (Operators.CompareString(((Form)this).Text, "FAMILLE", TextCompare: false) != 0)
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

	private void Button5_Click(object sender, EventArgs e)
	{
	}

	private void FormDialog_google_Resize(object sender, EventArgs e)
	{
		((Control)Panel_google).Width = ((Control)this).Width;
		((Control)Panel_bd).Width = ((Control)this).Width;
	}

	private void Button4_Click(object sender, EventArgs e)
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
					WebBrowser1.Navigate("https://www.google.com/search?rlz=1C1CHBD_frMA805MA805&biw=1366&bih=635&tbm=isch&sa=1&ei=a4RZW_H8HYuqswGt8qZo&q=" + MyProject.Forms.Form_2_ARTICLES.Text_ARTICLE.Text);
					break;
				case 86:
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
				try0001_dispatch = 86;
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

	private void Button13_Click(object sender, EventArgs e)
	{
		((Control)Panel_google).Visible = false;
		((Control)Panel_bd).Visible = false;
		((Control)Panel_text).Visible = true;
		((Control)Panel_text).BringToFront();
	}

	private void Radio1_CheckedChanged(object sender, EventArgs e)
	{
		Text_GO.TextAlign = (HorizontalAlignment)2;
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Radio2_CheckedChanged(object sender, EventArgs e)
	{
		Text_GO.TextAlign = (HorizontalAlignment)0;
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Radio3_CheckedChanged(object sender, EventArgs e)
	{
		Text_GO.TextAlign = (HorizontalAlignment)1;
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Text_GO_TextChanged(object sender, EventArgs e)
	{
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Text_GO_Click(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		if (Operators.CompareString(((Form)this).Text, "ARTICLE", TextCompare: false) == 0)
		{
			((Control)MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE).Refresh();
			Bitmap val = new Bitmap(((Control)Text_GO).Size.Width, ((Control)Text_GO).Size.Height);
			TextBox text_GO = Text_GO;
			Rectangle rectangle = new Rectangle(0, 0, ((Control)Text_GO).Width, ((Control)Text_GO).Height);
			((Control)text_GO).DrawToBitmap(val, rectangle);
			MyProject.Forms.Form_2_ARTICLES.Picture_IMAGE.Image = (Image)(object)val;
			((TextBoxBase)Text_GO).AutoSize = false;
			((Control)Text_GO).Invalidate();
			MyProject.Forms.Form_2_ARTICLES.Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
		}
		else if (Operators.CompareString(((Form)this).Text, "FAMILLE", TextCompare: false) != 0)
		{
		}
	}

	private void Numeric1_ValueChanged(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		((Control)Text_GO).Font = new Font("Segoe UI", (float)Convert.ToInt32(Numeric1.Value), (FontStyle)1);
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button_COLOR_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		ColorDialog val = new ColorDialog();
		((CommonDialog)val).ShowDialog();
		((TextBoxBase)Text_GO).BackColor = val.Color;
		Text_GO_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}
}
