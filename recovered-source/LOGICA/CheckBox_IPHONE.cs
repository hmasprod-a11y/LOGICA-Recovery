using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class CheckBox_IPHONE : UserControl
{
	public delegate void CheckedChangedEventHandler(object sender, EventArgs e);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Picture_LOGO")]
	private PictureBox _Picture_LOGO;

	private bool _checked;

	internal virtual PictureBox Picture_LOGO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_LOGO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_LOGO = value;
		}
	}

	public bool Checked
	{
		get
		{
			return _checked;
		}
		set
		{
			if (!_checked.Equals(value))
			{
				_checked = value;
				OnCheckedChanged();
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event CheckedChangedEventHandler CheckedChanged;

	[DebuggerNonUserCode]
	public CheckBox_IPHONE()
	{
		((UserControl)this).Load += CheckBox_me_Load;
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CheckBox_IPHONE));
		Picture_LOGO = new PictureBox();
		((ISupportInitialize)Picture_LOGO).BeginInit();
		((Control)this).SuspendLayout();
		Picture_LOGO.Image = (Image)componentResourceManager.GetObject("Picture_LOGO.Image");
		PictureBox picture_LOGO = Picture_LOGO;
		Point location = new Point(3, 3);
		((Control)picture_LOGO).Location = location;
		((Control)Picture_LOGO).Name = "Picture_LOGO";
		PictureBox picture_LOGO2 = Picture_LOGO;
		Size size = new Size(23, 23);
		((Control)picture_LOGO2).Size = size;
		Picture_LOGO.SizeMode = (PictureBoxSizeMode)2;
		Picture_LOGO.TabIndex = 3;
		Picture_LOGO.TabStop = false;
		((Control)Picture_LOGO).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)Picture_LOGO);
		((Control)this).Name = "CheckBox_me";
		size = new Size(52, 29);
		((Control)this).Size = size;
		((ISupportInitialize)Picture_LOGO).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected virtual void OnCheckedChanged()
	{
		CheckedChanged?.Invoke(this, EventArgs.Empty);
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		Checked = !Checked;
		((Control)this).Invalidate();
		base.OnMouseClick(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		base.OnPaintBackground(e);
		e.Graphics.SmoothingMode = (SmoothingMode)4;
		GraphicsPath val = new GraphicsPath();
		checked
		{
			try
			{
				Padding padding = ((Control)this).Padding;
				int all = padding.All;
				int num = ((Control)this).Height - 2 * all;
				val.AddArc(all, all, num, num, 90f, 180f);
				val.AddArc(((Control)this).Width - num - all, all, num, num, -90f, 180f);
				val.CloseFigure();
				e.Graphics.FillPath((Brush)(Checked ? new SolidBrush(Color.FromArgb(27, 161, 226)) : new SolidBrush(Color.FromArgb(70, 70, 70))), val);
				num = ((Control)this).Height - 1;
				Rectangle rectangle2;
				if (!Checked)
				{
					Rectangle rectangle = new Rectangle(0, 0, num, num);
					rectangle2 = rectangle;
				}
				else
				{
					Rectangle rectangle3 = new Rectangle(((Control)this).Width - num - 1, 0, num, num);
					rectangle2 = rectangle3;
				}
				Rectangle rectangle4 = rectangle2;
				e.Graphics.FillEllipse(Checked ? Brushes.Black : Brushes.LightSlateGray, rectangle4);
				e.Graphics.DrawImage(Picture_LOGO.Image, rectangle4);
				if (Checked)
				{
					Graphics graphics = e.Graphics;
					Font val2 = new Font("Caliri", 9f, (FontStyle)1);
					Brush white = Brushes.White;
					PointF pointF = new PointF((float)((double)rectangle4.Width / 2.0 / 4.0), (float)((double)rectangle4.Y + (double)rectangle4.Height / 8.0));
					graphics.DrawString("ON", val2, white, pointF);
				}
				else
				{
					Graphics graphics2 = e.Graphics;
					Font val3 = new Font("Caliri", 9f, (FontStyle)1);
					Brush white2 = Brushes.White;
					PointF pointF = new PointF(rectangle4.Width, (float)((double)rectangle4.Y + (double)rectangle4.Height / 8.0));
					graphics2.DrawString("OFF", val3, white2, pointF);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private void CheckBox_me_Load(object sender, EventArgs e)
	{
	}
}
