using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LOGICA;

public class MBMenuRendere : ToolStripProfessionalRenderer
{
	private int R0;

	private int G0;

	private int B0;

	private Color StrokeColor;

	private int offsetx;

	private int offsety;

	private int imageheight;

	private int imagewidth;

	private int _radius;

	public MBMenuRendere()
	{
		R0 = 255;
		G0 = 214;
		B0 = 78;
		StrokeColor = Color.FromArgb(196, 177, 118);
		offsetx = 3;
		offsety = 2;
		imageheight = 0;
		imagewidth = 0;
		_radius = 6;
	}

	protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		if (e.Item.Selected)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			GraphicsPath val = new GraphicsPath();
			Rectangle rectangle = checked(new Rectangle(2, 1, e.Item.Size.Width - 2, e.Item.Size.Height - 1));
			DrawArc(rectangle, val);
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle, Color.White, Color.White, (LinearGradientMode)1);
			float[] positions = new float[4] { 0f, 0.4f, 0.45f, 1f };
			Color[] colors = new Color[4]
			{
				GetRendererColor(0, 50, 100),
				GetRendererColor(0, 0, 30),
				Color.FromArgb(R0, G0, B0),
				GetRendererColor(0, 50, 100)
			};
			ColorBlend val3 = new ColorBlend();
			val3.Colors = colors;
			val3.Positions = positions;
			val2.InterpolationColors = val3;
			graphics.FillPath((Brush)(object)val2, val);
			graphics.DrawPath(new Pen(StrokeColor), val);
			((Brush)val2).Dispose();
		}
		else
		{
			base.OnRenderMenuItemBackground(e);
		}
	}

	protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
	{
		((ToolStripItemRenderEventArgs)e).Graphics.SmoothingMode = (SmoothingMode)2;
		checked
		{
			if (e.Image != null)
			{
				imageheight = ((ToolStripItemRenderEventArgs)e).Item.Height - offsety * 2;
				imagewidth = (int)Math.Round(Convert.ToDouble(imageheight) / (double)e.Image.Height * (double)e.Image.Width);
			}
			Graphics graphics = ((ToolStripItemRenderEventArgs)e).Graphics;
			Image image = e.Image;
			Rectangle rectangle = new Rectangle(offsetx, offsety, imagewidth, imageheight);
			graphics.DrawImage(image, rectangle);
		}
	}

	public void DrawArc(Rectangle re, GraphicsPath pa)
	{
		int radius = _radius;
		int radius2 = _radius;
		int radius3 = _radius;
		int radius4 = _radius;
		pa.AddArc(re.X, re.Y, radius, radius, 180f, 90f);
		checked
		{
			pa.AddArc(re.Width - radius2, re.Y, radius2, radius2, 270f, 90f);
			pa.AddArc(re.Width - radius4, re.Height - radius4, radius4, radius4, 0f, 90f);
			pa.AddArc(re.X, re.Height - radius3, radius3, radius3, 90f, 90f);
			pa.CloseFigure();
		}
	}

	public Color GetRendererColor(int R, int G, int B)
	{
		checked
		{
			R = ((R + R0 <= 255) ? (R + R0) : 255);
			G = ((G + G0 <= 255) ? (G + G0) : 255);
			B = ((B + B0 <= 255) ? (B + B0) : 255);
			return Color.FromArgb(R, G, B);
		}
	}
}
