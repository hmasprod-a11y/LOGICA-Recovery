using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace LOGICA;

[DesignerGenerated]
public class ToastForm : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("messageLabel")]
	private Label _messageLabel;

	[AccessedThroughProperty("lifeTimer")]
	private System.Windows.Forms.Timer _lifeTimer;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	private static List<ToastForm> openForms = new List<ToastForm>();

	private bool allowFocus;

	private FormAnimator animator;

	private IntPtr currentForegroundWindow;

	protected virtual Label messageLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _messageLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = messageLabel_Click;
			if (_messageLabel != null)
			{
				((Control)_messageLabel).Click -= eventHandler;
			}
			_messageLabel = value;
			if (_messageLabel != null)
			{
				((Control)_messageLabel).Click += eventHandler;
			}
		}
	}

	protected virtual System.Windows.Forms.Timer lifeTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _lifeTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lifeTimer_Tick;
			if (_lifeTimer != null)
			{
				_lifeTimer.Tick -= eventHandler;
			}
			_lifeTimer = value;
			if (_lifeTimer != null)
			{
				_lifeTimer.Tick += eventHandler;
			}
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
			EventHandler eventHandler = PictureBox2_MouseLeave;
			EventHandler eventHandler2 = PictureBox2_MouseEnter;
			EventHandler eventHandler3 = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseLeave -= eventHandler;
				((Control)_PictureBox2).MouseEnter -= eventHandler2;
				((Control)_PictureBox2).Click -= eventHandler3;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseLeave += eventHandler;
				((Control)_PictureBox2).MouseEnter += eventHandler2;
				((Control)_PictureBox2).Click += eventHandler3;
			}
		}
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
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
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		components = new Container();
		messageLabel = new Label();
		lifeTimer = new System.Windows.Forms.Timer(components);
		Panel1 = new Panel();
		Panel3 = new Panel();
		PictureBox2 = new PictureBox();
		Panel2 = new Panel();
		PictureBox1 = new PictureBox();
		((Control)Panel1).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)messageLabel).Cursor = Cursors.Hand;
		((Control)messageLabel).Dock = (DockStyle)5;
		((Control)messageLabel).Font = new Font("Arial", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)messageLabel).ForeColor = Color.White;
		Label val = messageLabel;
		Point location = new Point(0, 0);
		((Control)val).Location = location;
		((Control)messageLabel).Name = "messageLabel";
		Label val2 = messageLabel;
		Size size = new Size(370, 74);
		((Control)val2).Size = size;
		((Control)messageLabel).TabIndex = 0;
		messageLabel.Text = "-";
		messageLabel.TextAlign = (ContentAlignment)32;
		((Control)Panel1).Controls.Add((Control)(object)Panel3);
		((Control)Panel1).Controls.Add((Control)(object)Panel2);
		((Control)Panel1).Dock = (DockStyle)5;
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(445, 74);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 2;
		((Control)Panel3).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel3).Controls.Add((Control)(object)messageLabel);
		((Control)Panel3).Dock = (DockStyle)5;
		Panel panel3 = Panel3;
		location = new Point(75, 0);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(370, 74);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 1;
		((Control)PictureBox2).BackColor = Color.Black;
		PictureBox pictureBox = PictureBox2;
		location = new Point(352, 3);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(15, 15);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 1;
		PictureBox2.TabStop = false;
		((Control)Panel2).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel2).Dock = (DockStyle)3;
		Panel panel5 = Panel2;
		location = new Point(0, 0);
		((Control)panel5).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel6 = Panel2;
		size = new Size(75, 74);
		((Control)panel6).Size = size;
		((Control)Panel2).TabIndex = 0;
		((Control)PictureBox1).Dock = (DockStyle)5;
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(75, 74);
		((Control)pictureBox4).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)3;
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.Black;
		size = new Size(445, 74);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "ToastForm";
		((Form)this).Text = "Toast Form";
		((Form)this).TopMost = true;
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32")]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	public ToastForm(int lifeTime, string message, Image icon)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		((Form)this).Load += ToastForm_Load;
		((Form)this).Activated += ToastForm_Activated;
		((Form)this).Shown += ToastForm_Shown;
		((Form)this).FormClosed += ToastForm_FormClosed;
		__ENCAddToList(this);
		allowFocus = false;
		InitializeComponent();
		lifeTimer.Interval = lifeTime;
		messageLabel.Text = message;
		PictureBox1.Image = icon;
		animator = new FormAnimator((Form)(object)this, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up, 500);
	}

	public void Show()
	{
		currentForegroundWindow = GetForegroundWindow();
		((Control)this).Show();
	}

	private void ToastForm_Load(object sender, EventArgs e)
	{
		PlayBackgroundSoundResource();
		checked
		{
			Point location = new Point(Screen.PrimaryScreen.WorkingArea.Width - ((Control)this).Width - 5, Screen.PrimaryScreen.WorkingArea.Height - ((Control)this).Height - 5);
			((Form)this).Location = location;
			foreach (ToastForm openForm in openForms)
			{
				ToastForm toastForm = openForm;
				((Control)toastForm).Top = ((Control)toastForm).Top - (((Control)this).Height + 5);
			}
			openForms.Add(this);
			lifeTimer.Start();
			((Form)this).Opacity = 0.85;
		}
	}

	public void PlayBackgroundSoundResource()
	{
		((Computer)MyProject.Computer).Audio.Play(Application.StartupPath + "\\notif.wav", (AudioPlayMode)1);
	}

	private void ToastForm_Activated(object sender, EventArgs e)
	{
		if (!allowFocus)
		{
			SetForegroundWindow(currentForegroundWindow);
		}
	}

	private void ToastForm_Shown(object sender, EventArgs e)
	{
		allowFocus = true;
		animator.Direction = FormAnimator.AnimationDirection.Down;
	}

	private void ToastForm_FormClosed(object sender, FormClosedEventArgs e)
	{
		foreach (ToastForm openForm in openForms)
		{
			if (openForm == this)
			{
				break;
			}
			ToastForm toastForm = openForm;
			((Control)toastForm).Top = checked(((Control)toastForm).Top + (((Control)this).Height + 5));
		}
		openForms.Remove(this);
	}

	private void lifeTimer_Tick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PictureBox2_MouseEnter(object sender, EventArgs e)
	{
		((Control)PictureBox2).BackColor = Color.Gray;
	}

	private void PictureBox2_MouseLeave(object sender, EventArgs e)
	{
		Color backColor = default;
		((Control)PictureBox2).BackColor = backColor;
	}

	private void messageLabel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)MyProject.Forms.FormDialog_ETAT_ALERTES_STOCK).Show();
		((Form)MyProject.Forms.FormDialog_ETAT_ALERTES_STOCK).TopMost = true;
	}
}
