using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_info : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Text_LICENCE")]
	private TextBox _Text_LICENCE;

	[AccessedThroughProperty("Text_LICENCE_HASH")]
	private TextBox _Text_LICENCE_HASH;

	[AccessedThroughProperty("Text_LICENCE_DATE")]
	private TextBox _Text_LICENCE_DATE;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

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
			EventHandler eventHandler = PictureBox2_DoubleClick;
			EventHandler eventHandler2 = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).DoubleClick -= eventHandler;
				((Control)_PictureBox2).Click -= eventHandler2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).DoubleClick += eventHandler;
				((Control)_PictureBox2).Click += eventHandler2;
			}
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

	internal virtual System.Windows.Forms.Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.Tick -= eventHandler;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Tick += eventHandler;
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
			EventHandler eventHandler = Label7_Click;
			if (_Label7 != null)
			{
				((Control)_Label7).Click -= eventHandler;
			}
			_Label7 = value;
			if (_Label7 != null)
			{
				((Control)_Label7).Click += eventHandler;
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
			EventHandler eventHandler = Button1_Click_1;
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

	internal virtual TextBox Text_LICENCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LICENCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LICENCE = value;
		}
	}

	internal virtual TextBox Text_LICENCE_HASH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LICENCE_HASH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LICENCE_HASH = value;
		}
	}

	internal virtual TextBox Text_LICENCE_DATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LICENCE_DATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LICENCE_DATE = value;
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

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual TextBox TextBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual TextBox TextBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox8 = value;
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

	[DebuggerNonUserCode]
	public FormDialog_info()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Form)this).FormClosed += FormDialog_info_FormClosed;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Form)this).Load += Form1_Load;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
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
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_info));
		Panel1 = new Panel();
		Label11 = new Label();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		TextBox8 = new TextBox();
		PictureBox6 = new PictureBox();
		TextBox1 = new TextBox();
		Text_LICENCE_DATE = new TextBox();
		Text_LICENCE_HASH = new TextBox();
		Text_LICENCE = new TextBox();
		Label9 = new Label();
		Label8 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label1 = new Label();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		Label3 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox5 = new PictureBox();
		TextBox5 = new TextBox();
		Timer1 = new System.Windows.Forms.Timer(components);
		Label7 = new Label();
		Button2 = new Button();
		Button1 = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)Label11);
		((Control)Panel1).Controls.Add((Control)(object)TextBox6);
		((Control)Panel1).Controls.Add((Control)(object)TextBox7);
		((Control)Panel1).Controls.Add((Control)(object)TextBox8);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)TextBox1);
		((Control)Panel1).Controls.Add((Control)(object)Text_LICENCE_DATE);
		((Control)Panel1).Controls.Add((Control)(object)Text_LICENCE_HASH);
		((Control)Panel1).Controls.Add((Control)(object)Text_LICENCE);
		((Control)Panel1).Controls.Add((Control)(object)Label9);
		((Control)Panel1).Controls.Add((Control)(object)Label8);
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)Label5);
		((Control)Panel1).Controls.Add((Control)(object)Label1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel1).Controls.Add((Control)(object)TextBox5);
		((Control)Panel1).Name = "Panel1";
		componentResourceManager.ApplyResources(Label11, "Label11");
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).ForeColor = Color.DimGray;
		((Control)Label11).Name = "Label11";
		componentResourceManager.ApplyResources(TextBox6, "TextBox6");
		((TextBoxBase)TextBox6).BackColor = Color.White;
		((TextBoxBase)TextBox6).BorderStyle = (BorderStyle)0;
		((Control)TextBox6).Name = "TextBox6";
		((TextBoxBase)TextBox6).ReadOnly = true;
		componentResourceManager.ApplyResources(TextBox7, "TextBox7");
		((TextBoxBase)TextBox7).BackColor = Color.White;
		((TextBoxBase)TextBox7).BorderStyle = (BorderStyle)0;
		((Control)TextBox7).Name = "TextBox7";
		((TextBoxBase)TextBox7).ReadOnly = true;
		componentResourceManager.ApplyResources(TextBox8, "TextBox8");
		((TextBoxBase)TextBox8).BackColor = Color.White;
		((TextBoxBase)TextBox8).BorderStyle = (BorderStyle)0;
		((Control)TextBox8).Name = "TextBox8";
		((TextBoxBase)TextBox8).ReadOnly = true;
		componentResourceManager.ApplyResources(PictureBox6, "PictureBox6");
		((Control)PictureBox6).BackColor = Color.Black;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox6.TabStop = false;
		componentResourceManager.ApplyResources(TextBox1, "TextBox1");
		((TextBoxBase)TextBox1).BackColor = Color.White;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Name = "TextBox1";
		((TextBoxBase)TextBox1).ReadOnly = true;
		componentResourceManager.ApplyResources(Text_LICENCE_DATE, "Text_LICENCE_DATE");
		((TextBoxBase)Text_LICENCE_DATE).BackColor = Color.White;
		((TextBoxBase)Text_LICENCE_DATE).BorderStyle = (BorderStyle)0;
		((Control)Text_LICENCE_DATE).Name = "Text_LICENCE_DATE";
		((TextBoxBase)Text_LICENCE_DATE).ReadOnly = true;
		componentResourceManager.ApplyResources(Text_LICENCE_HASH, "Text_LICENCE_HASH");
		((TextBoxBase)Text_LICENCE_HASH).BackColor = Color.White;
		((TextBoxBase)Text_LICENCE_HASH).BorderStyle = (BorderStyle)0;
		((Control)Text_LICENCE_HASH).Name = "Text_LICENCE_HASH";
		((TextBoxBase)Text_LICENCE_HASH).ReadOnly = true;
		componentResourceManager.ApplyResources(Text_LICENCE, "Text_LICENCE");
		((TextBoxBase)Text_LICENCE).BackColor = Color.White;
		((TextBoxBase)Text_LICENCE).BorderStyle = (BorderStyle)0;
		((Control)Text_LICENCE).Name = "Text_LICENCE";
		((TextBoxBase)Text_LICENCE).ReadOnly = true;
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).Name = "Label9";
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).Cursor = Cursors.Hand;
		((Control)Label8).ForeColor = Color.Black;
		((Control)Label8).Name = "Label8";
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = SystemColors.HotTrack;
		((Control)Label6).Name = "Label6";
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = SystemColors.HotTrack;
		((Control)Label5).Name = "Label5";
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).Name = "Label1";
		componentResourceManager.ApplyResources(PictureBox4, "PictureBox4");
		((Control)PictureBox4).BackColor = Color.Black;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox4.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).Name = "Label3";
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox5, "PictureBox5");
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox5.TabStop = false;
		componentResourceManager.ApplyResources(TextBox5, "TextBox5");
		((TextBoxBase)TextBox5).BackColor = Color.White;
		((TextBoxBase)TextBox5).BorderStyle = (BorderStyle)0;
		((Control)TextBox5).Name = "TextBox5";
		((TextBoxBase)TextBox5).ReadOnly = true;
		Timer1.Interval = 50;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).Name = "Label7";
		componentResourceManager.ApplyResources(Button2, "Button2");
		((ButtonBase)Button2).BackColor = Color.Red;
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).ForeColor = Color.White;
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button1, "Button1");
		((ButtonBase)Button1).BackColor = Color.Blue;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).ForeColor = Color.White;
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_info";
		((Form)this).TopMost = true;
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void FormDialog_info_FormClosed(object sender, FormClosedEventArgs e)
	{
		Timer1.Enabled = false;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		Timer1.Enabled = true;
		string text = "";
		try
		{
			DateTime date = DateTime.Now.Date;
			DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form_1_LOGIN.Text_LICENCE_DATE.Text).AddDays(365.0);
			text = Conversions.ToString(DateAndTime.DateDiff("d", date, dateTime));
			if (Conversions.ToDouble(text) <= 0.0)
			{
				text = "EXPIRE";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Text_LICENCE.Text = MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text;
		Text_LICENCE_HASH.Text = Strings.Trim(File.ReadAllText(Application.StartupPath + "/hash_licence.sni"));
		Text_LICENCE_DATE.Text = MyProject.Forms.Form_1_LOGIN.Text_LICENCE_DATE.Text + "   (RESTE " + text + "j)";
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)Label7).Left = checked(((Control)Label7).Left - 5);
		if (((Control)Label7).Left < -280)
		{
			((Control)Label7).Left = 560;
		}
	}

	private void Label7_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		try
		{
			Interaction.Shell(Module1._CHEMIN_FOLDER + "\\bd\\config\\aide2.exe");
			Timer1.Enabled = false;
			ProjectData.EndApp();
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

	private void PictureBox2_DoubleClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button1_Click_1(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		try
		{
			Process.Start("https://download.teamviewer.com/QS");
			Process.Start("https://www.teamviewer.com/fr/info/quicksupport/");
			Timer1.Enabled = false;
			ProjectData.EndApp();
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

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		Label label = Label9;
		label.Text = Conversions.ToString(Conversions.ToDouble(label.Text) + 1.0);
		if (Conversions.ToDouble(Label9.Text) == 10.0)
		{
			((Control)PictureBox5).Visible = true;
			((Control)PictureBox5).BringToFront();
		}
	}
}
