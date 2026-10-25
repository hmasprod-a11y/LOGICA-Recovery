using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_PATIENTER_BALANCE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	private int i;

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
			EventHandler eventHandler = PictureBox_Click;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
			}
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

	[DebuggerNonUserCode]
	public FormDialog_PATIENTER_BALANCE()
	{
		((Control)this).DoubleClick += FormDialog_PATIENTER_BALANCE_DoubleClick;
		((Form)this).Load += Form_acces_Load;
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_PATIENTER_BALANCE));
		PictureBox5 = new PictureBox();
		Timer1 = new System.Windows.Forms.Timer(components);
		Panel2 = new Panel();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox = PictureBox5;
		Point location = new Point(208, 65);
		((Control)pictureBox).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox2 = PictureBox5;
		Size size = new Size(282, 196);
		((Control)pictureBox2).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)4;
		PictureBox5.TabIndex = 4;
		PictureBox5.TabStop = false;
		Timer1.Enabled = true;
		((Control)Panel2).Anchor = (AnchorStyles)0;
		((Control)Panel2).BackColor = Color.Transparent;
		((Control)Panel2).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox5);
		Panel panel = Panel2;
		location = new Point(171, 190);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(731, 312);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 5;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(232, 209);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(239, 42);
		((Control)pictureBox4).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 7;
		PictureBox3.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(90, 71);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(124, 142);
		((Control)pictureBox6).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2.TabIndex = 6;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(487, 65);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(116, 161);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 5;
		PictureBox1.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1073, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "FormDialog_rfid";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_PATIENTER_BALANCE_DoubleClick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Form_acces_Load(object sender, EventArgs e)
	{
		((Form)this).TopMost = true;
		((Form)this).TopLevel = true;
	}

	private void PictureBox_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		checked
		{
			Point location;
			if (((Control)Panel2).Height < 286)
			{
				((Control)Panel2).Height = 286;
				Panel panel = Panel2;
				location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel2).Width / 2.0), (int)Math.Round(Conversions.ToDouble(Screen.PrimaryScreen.WorkingArea.Size.Height.ToString()) - (double)((Control)Panel2).Height));
				((Control)panel).Location = location;
			}
			else if (((Control)Panel2).Height == 286)
			{
				((Control)Panel2).Height = 16;
				location = (((Control)Panel2).Location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel2).Width / 2.0), (int)Math.Round(Conversions.ToDouble(Screen.PrimaryScreen.WorkingArea.Size.Height.ToString()) - (double)((Control)Panel2).Height)));
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Module1._QUITTER_PATIENTER)
		{
			Timer1.Enabled = false;
			Module1._QUITTER_PATIENTER = false;
			((Form)this).Close();
		}
	}
}
