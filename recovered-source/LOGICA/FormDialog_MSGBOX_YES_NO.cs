using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_MSGBOX_YES_NO : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT2")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT2;

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT1_Click;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT1 = value;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click += eventHandler;
			}
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT2_Click;
			if (_Button_CLAVIER_NOSELECT2 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT2).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT2 = value;
			if (_Button_CLAVIER_NOSELECT2 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT2).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_MSGBOX_YES_NO()
	{
		((Form)this).Load += FormDialog_ARTICLE_INCONNU_Load;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		Label1 = new Label();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button_CLAVIER_NOSELECT2 = new Button_CLAVIER_NOSELECT();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		((Control)this).SuspendLayout();
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Segoe UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.Black;
		Label label = Label1;
		Point location = new Point(12, 39);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(452, 74);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 690;
		((Control)Label1).Tag = "";
		Label1.TextAlign = (ContentAlignment)32;
		((Control)Label_BOTTOM).BackColor = Color.Red;
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(6, 190);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(464, 6);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 859;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.Red;
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 0);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(6, 196);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 858;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.Red;
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(470, 0);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(6, 196);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 857;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.Red;
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(6, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(464, 29);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 860;
		Label_TOP.Text = "Attention";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_CLAVIER_NOSELECT2).BackColor = Color.Red;
		((Control)Button_CLAVIER_NOSELECT2).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT2).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT2).Font = new Font("Tahoma", 16f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT2).ForeColor = Color.White;
		((ButtonBase)Button_CLAVIER_NOSELECT2).ImageAlign = (ContentAlignment)64;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT2;
		location = new Point(296, 122);
		((Control)button_CLAVIER_NOSELECT).Location = location;
		((Control)Button_CLAVIER_NOSELECT2).Name = "Button_CLAVIER_NOSELECT2";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = Button_CLAVIER_NOSELECT2;
		size = new Size(168, 62);
		((Control)button_CLAVIER_NOSELECT2).Size = size;
		((Control)Button_CLAVIER_NOSELECT2).TabIndex = 861;
		((ButtonBase)Button_CLAVIER_NOSELECT2).Text = "Non";
		((ButtonBase)Button_CLAVIER_NOSELECT2).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Tahoma", 16f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.White;
		((ButtonBase)Button_CLAVIER_NOSELECT1).ImageAlign = (ContentAlignment)64;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT3 = Button_CLAVIER_NOSELECT1;
		location = new Point(12, 122);
		((Control)button_CLAVIER_NOSELECT3).Location = location;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT4 = Button_CLAVIER_NOSELECT1;
		size = new Size(168, 62);
		((Control)button_CLAVIER_NOSELECT4).Size = size;
		((Control)Button_CLAVIER_NOSELECT1).TabIndex = 1;
		((ButtonBase)Button_CLAVIER_NOSELECT1).Text = "Oui";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(476, 196);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT2);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "FormDialog_MSGBOX_YES_NO";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Form1";
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_ARTICLE_INCONNU_Load(object sender, EventArgs e)
	{
		SystemSounds.Asterisk.Play();
	}

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		((Control)this).Tag = "oui";
		((Form)this).Close();
	}

	private void Button_CLAVIER_NOSELECT2_Click(object sender, EventArgs e)
	{
		((Control)this).Tag = "non";
		((Form)this).Close();
	}
}
