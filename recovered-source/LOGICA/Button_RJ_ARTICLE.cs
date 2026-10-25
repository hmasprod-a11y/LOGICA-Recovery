using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LOGICA;

public class Button_RJ_ARTICLE : Button
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Color m_color;

	private decimal borderSize;

	private int borderRadius;

	private Color borderColor;

	public string _PRIX
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public Color _COLOR_PRIX
	{
		get
		{
			return m_color;
		}
		set
		{
			m_color = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public decimal _BorderSize
	{
		get
		{
			return borderSize;
		}
		set
		{
			borderSize = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public int _BorderRadius
	{
		get
		{
			return borderRadius;
		}
		set
		{
			borderRadius = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color _BorderColor
	{
		get
		{
			return borderColor;
		}
		set
		{
			borderColor = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color _BackgroundColor
	{
		get
		{
			return ((ButtonBase)this).BackColor;
		}
		set
		{
			((ButtonBase)this).BackColor = value;
		}
	}

	[Category("RJ Code Advance")]
	public Color _TextColor
	{
		get
		{
			return ((Control)this).ForeColor;
		}
		set
		{
			((Control)this).ForeColor = value;
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

	private void Button_Paint(object sender, PaintEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got Unknown
		Size size = e.Graphics.MeasureString(_PRIX, new Font("Calibri", 8f, (FontStyle)1)).ToSize();
		e.Graphics.FillRectangle((Brush)new SolidBrush(m_color), 2, 2, checked(size.Width + 15), size.Height);
		e.Graphics.DrawString(_PRIX, new Font("Calibri", 8f, (FontStyle)1), (Brush)new SolidBrush(Color.White), 12f, 2f);
	}

	private void Button_GotFocus(object sender, EventArgs e)
	{
		((ButtonBase)this).BackColor = Color.Yellow;
	}

	private void Button_LostFocus(object sender, EventArgs e)
	{
		((ButtonBase)this).BackColor = Color.White;
	}

	public Button_RJ_ARTICLE()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		((Control)this).Paint += Button_Paint;
		((Control)this).GotFocus += Button_GotFocus;
		((Control)this).LostFocus += Button_LostFocus;
		__ENCAddToList(this);
		m_color = Color.FromArgb(22, 106, 238);
		borderSize = 1.5m;
		borderRadius = 14;
		borderColor = Color.PaleVioletRed;
		base.SetStyle((ControlStyles)512, false);
		((ButtonBase)this).FlatStyle = (FlatStyle)0;
		((ButtonBase)this).FlatAppearance.BorderSize = 0;
		Size size = new Size(150, 40);
		((Control)this).Size = size;
		((ButtonBase)this).BackColor = Color.MediumSlateBlue;
		((Control)this).ForeColor = Color.White;
		((Control)this).Resize += Button_Resize;
	}

	private GraphicsPath GetFigurePath(Rectangle rect, int radius)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		GraphicsPath val = new GraphicsPath();
		float num = (float)radius * 2f;
		val.StartFigure();
		val.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
		val.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
		val.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		val.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		val.CloseFigure();
		return val;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		base.OnPaint(pevent);
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		Rectangle rect = Rectangle.Inflate(clientRectangle, Convert.ToInt32(decimal.Negate(borderSize)), Convert.ToInt32(decimal.Negate(borderSize)));
		int num = 2;
		if (decimal.Compare(borderSize, 0m) > 0)
		{
			num = Convert.ToInt32(borderSize);
		}
		if (borderRadius > 2)
		{
			GraphicsPath figurePath = GetFigurePath(clientRectangle, borderRadius);
			try
			{
				GraphicsPath figurePath2 = GetFigurePath(rect, Convert.ToInt32(decimal.Subtract(new decimal(borderRadius), borderSize)));
				try
				{
					Pen val = new Pen(((Control)this).Parent.BackColor, (float)num);
					try
					{
						Pen val2 = new Pen(borderColor, Convert.ToSingle(borderSize));
						try
						{
							pevent.Graphics.SmoothingMode = (SmoothingMode)4;
							((Control)this).Region = new Region(figurePath);
							pevent.Graphics.DrawPath(val, figurePath);
							if (decimal.Compare(borderSize, 1m) >= 0)
							{
								pevent.Graphics.DrawPath(val2, figurePath2);
							}
							return;
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)figurePath2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)figurePath)?.Dispose();
			}
		}
		pevent.Graphics.SmoothingMode = (SmoothingMode)3;
		((Control)this).Region = new Region(clientRectangle);
		checked
		{
			if (decimal.Compare(borderSize, 1m) >= 0)
			{
				Pen val3 = new Pen(borderColor, Convert.ToSingle(borderSize));
				try
				{
					val3.Alignment = (PenAlignment)1;
					pevent.Graphics.DrawRectangle(val3, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		((Control)this).Parent.BackColorChanged += Container_BackColorChanged;
	}

	private void Container_BackColorChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void Button_Resize(object sender, EventArgs e)
	{
		if (borderRadius > ((Control)this).Height)
		{
			borderRadius = ((Control)this).Height;
		}
	}
}
