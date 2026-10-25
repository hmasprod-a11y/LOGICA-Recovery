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

[DefaultProperty("Text")]
[ToolboxItem(true)]
[Description("Display the Bar that indicates the Progress of Operation.")]
[ToolboxBitmap(typeof(Button_MBGlassButton), "MBGlassStyleButton.MBGlassButton.bmp")]
[ToolboxItemFilter("System.Windows.Forms")]
[DefaultEvent("Click")]
public class Button_MBGlassButton : Button
{
	public enum MB_SplitLocation
	{
		Bottom,
		Right,
		None
	}

	public enum MB_ShowBase
	{
		Yes,
		No
	}

	public enum MB_GroupPos
	{
		None,
		Left,
		Center,
		Right,
		Top,
		Bottom
	}

	public enum MB_Arrow
	{
		None,
		ToRight,
		ToDown
	}

	public enum MB_SplitButton
	{
		Yes,
		No
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer Components;

	private MB_SplitLocation _splitlocation;

	private Size _ImageSize;

	private int _imageoffset;

	private int _radius;

	private MB_ShowBase _showbase;

	private MB_ShowBase _tempshowbase;

	private MB_GroupPos _grouppos;

	private MB_Arrow _arrow;

	private MB_SplitButton _splitbutton;

	private int _splitdistance;

	private bool _keeppressed;

	private bool _ispressed;

	private Point _menupos;

	private Color _baseColor;

	private Color _onColor;

	private Color _pressColor;

	private Color _baseStroke;

	private Color _onStroke;

	private Color _pressStroke;

	private Color _colorStroke;

	private int A0;

	private int R0;

	private int G0;

	private int B0;

	private int offsetx;

	private int offsety;

	private int imageheight;

	private int imagewidth;

	private System.Windows.Forms.Timer Timer1;

	private int i_factor;

	private int i_fR;

	private int i_fG;

	private int i_fB;

	private int i_fA;

	private int i_mode;

	private bool mouse;

	private int xmouse;

	private int ymouse;

	[DefaultValue(0)]
	[Description("Split location for MBGlassButton")]
	[Category("MBGlassButton Appearance")]
	[Browsable(true)]
	public MB_SplitLocation SplitLocation
	{
		get
		{
			return _splitlocation;
		}
		set
		{
			_splitlocation = value;
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[DefaultValue("24,24")]
	[Description("Set Image Size of MBGlassButton")]
	[Category("MBGlassButton Image Settings")]
	public Size ImageSize
	{
		get
		{
			return _ImageSize;
		}
		set
		{
			_ImageSize = value;
		}
	}

	[Browsable(true)]
	[Description("Display Glass Style Base for MBGlassButton")]
	[Category("MBGlassButton Settings")]
	[DefaultValue(0)]
	public MB_ShowBase ShowBase
	{
		get
		{
			return _showbase;
		}
		set
		{
			_showbase = value;
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[Description("Radius of MBGlassButton Corners")]
	[DefaultValue(6)]
	[Category("MBGlassButton Settings")]
	public int Radius
	{
		get
		{
			return _radius;
		}
		set
		{
			if (_radius > 2)
			{
				_radius = value;
			}
			((Control)this).Refresh();
		}
	}

	[Description("Set the Group Position for MBGlassButton")]
	[Category("MBGlassButton Position")]
	[DefaultValue(0)]
	[Browsable(true)]
	public MB_GroupPos GroupPosition
	{
		get
		{
			return _grouppos;
		}
		set
		{
			_grouppos = value;
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[Description("Display Arrow on MBGlassButton")]
	[DefaultValue(0)]
	[Category("MBGlassButton Arrow")]
	public MB_Arrow Arrow
	{
		get
		{
			return _arrow;
		}
		set
		{
			_arrow = value;
			((Control)this).Refresh();
		}
	}

	[Category("MBGlassButton Split Settings")]
	[Browsable(true)]
	[DefaultValue(1)]
	[Description("Split MBGlassButton into Two Parts")]
	public MB_SplitButton SplitButton
	{
		get
		{
			return _splitbutton;
		}
		set
		{
			_splitbutton = value;
			((Control)this).Refresh();
		}
	}

	[Description("Set Split Distance for MBGlassButton")]
	[DefaultValue(0)]
	[Category("MBGlassButton Split Settings")]
	[Browsable(true)]
	public int SplitDistance
	{
		get
		{
			return _splitdistance;
		}
		set
		{
			_splitdistance = value;
			((Control)this).Refresh();
		}
	}

	[Description("Keep MBGlassButton Pressed if Clicked")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("MBGlassButton Appearance")]
	public bool KeepPressed
	{
		get
		{
			return _keeppressed;
		}
		set
		{
			_keeppressed = value;
		}
	}

	[DefaultValue(false)]
	[Description("Keep MBGlassButton Selected if Focused")]
	[Category("MBGlassButton Appearance")]
	[Browsable(true)]
	public bool IsPressed
	{
		get
		{
			return _ispressed;
		}
		set
		{
			_ispressed = value;
		}
	}

	[Description("Set MenuList Position for MBGlassButton")]
	[Category("MBGlassButton Menu")]
	[Browsable(true)]
	[DefaultValue("0, 0")]
	public Point MenuListPosition
	{
		get
		{
			return _menupos;
		}
		set
		{
			_menupos = value;
		}
	}

	[Browsable(true)]
	[DefaultValue("186, 209, 240")]
	[Description("Set Base Color of MBGlassButton")]
	[Category("MBGlassButton Color")]
	public Color BaseColor
	{
		get
		{
			return _baseColor;
		}
		set
		{
			_baseColor = value;
			R0 = _baseColor.R;
			B0 = _baseColor.B;
			G0 = _baseColor.G;
			A0 = _baseColor.A;
			MBColor mBColor = new MBColor(_baseColor);
			if (mBColor.BC < 50)
			{
				mBColor.SetBrightness(60);
			}
			else
			{
				mBColor.SetBrightness(30);
			}
			if (_baseColor.A > 0)
			{
				_baseStroke = Color.FromArgb(100, mBColor.GetColor());
			}
			else
			{
				_baseStroke = Color.FromArgb(0, mBColor.GetColor());
			}
			((Control)this).Refresh();
		}
	}

	[Description("Set Mouse On Color of MBGlassButton")]
	[DefaultValue("255, 214, 78")]
	[Browsable(true)]
	[Category("MBGlassButton Color")]
	public Color OnColor
	{
		get
		{
			return _onColor;
		}
		set
		{
			_onColor = value;
			MBColor mBColor = new MBColor(_onColor);
			if (mBColor.BC < 50)
			{
				mBColor.SetBrightness(60);
			}
			else
			{
				mBColor.SetBrightness(30);
			}
			if (_baseStroke.A > 0)
			{
				_onStroke = Color.FromArgb(100, mBColor.GetColor());
			}
			else
			{
				_onStroke = Color.FromArgb(0, mBColor.GetColor());
			}
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[Description("Set Mouse Press Color of MBGlassButton")]
	[Category("MBGlassButton Color")]
	[DefaultValue("255, 128, 0")]
	public Color PressColor
	{
		get
		{
			return _pressColor;
		}
		set
		{
			_pressColor = value;
			MBColor mBColor = new MBColor(_pressColor);
			if (mBColor.BC < 50)
			{
				mBColor.SetBrightness(60);
			}
			else
			{
				mBColor.SetBrightness(30);
			}
			if (_baseStroke.A > 0)
			{
				_pressStroke = Color.FromArgb(100, mBColor.GetColor());
			}
			else
			{
				_pressStroke = Color.FromArgb(0, mBColor.GetColor());
			}
			((Control)this).Refresh();
		}
	}

	[Description("Set Base Stroke Color of MBGlassButton")]
	[Category("MBGlassButton Color")]
	[Browsable(true)]
	[DefaultValue("152, 187, 213")]
	public Color BaseStrokeColor
	{
		get
		{
			return _baseStroke;
		}
		set
		{
			_baseStroke = value;
		}
	}

	[Browsable(true)]
	[Description("Set On Stroke Color of MBGlassButton")]
	[Category("MBGlassButton Color")]
	[DefaultValue("196, 177, 118")]
	public Color OnStrokeColor
	{
		get
		{
			return _onStroke;
		}
		set
		{
			_onStroke = value;
		}
	}

	[Category("MBGlassButton Color")]
	[Description("Set Press Stroke Color of MBGlassButton")]
	[Browsable(true)]
	[DefaultValue("128, 64, 0")]
	public Color PressStrokeColor
	{
		get
		{
			return _pressStroke;
		}
		set
		{
			_pressStroke = value;
		}
	}

	[Category("MBGlassButton Appearance")]
	[Browsable(true)]
	[Description("Set Fading Speed of MBGlassButton")]
	[DefaultValue(35)]
	public int GlowingingSpeed
	{
		get
		{
			return i_factor;
		}
		set
		{
			if (value > -1)
			{
				i_factor = value;
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

	public Button_MBGlassButton()
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		((Control)this).ContextMenuStripChanged += MBGlassButton_ContextMenuStripChanged;
		__ENCAddToList(this);
		ref Size imageSize = ref _ImageSize;
		imageSize = new Size(24, 24);
		_imageoffset = 0;
		_radius = 6;
		_splitbutton = MB_SplitButton.No;
		_splitdistance = 0;
		_keeppressed = false;
		_ispressed = false;
		ref Point menupos = ref _menupos;
		menupos = new Point(0, 0);
		_baseColor = Color.FromArgb(211, 211, 211);
		_onColor = Color.FromArgb(255, 214, 78);
		_pressColor = Color.FromArgb(255, 128, 0);
		_baseStroke = Color.FromArgb(192, 192, 192);
		_onStroke = Color.FromArgb(196, 177, 118);
		_pressStroke = Color.FromArgb(128, 64, 0);
		_colorStroke = Color.FromArgb(255, 255, 255);
		offsetx = 0;
		offsety = 0;
		imageheight = 0;
		imagewidth = 0;
		Timer1 = new System.Windows.Forms.Timer();
		i_factor = 35;
		i_fR = 1;
		i_fG = 1;
		i_fB = 1;
		i_fA = 1;
		i_mode = 0;
		mouse = false;
		xmouse = 0;
		ymouse = 0;
		InitializeComponent();
		base.SetStyle((ControlStyles)2066, true);
		base.SetStyle((ControlStyles)4, false);
		((ButtonBase)this).FlatAppearance.BorderSize = 0;
		((ButtonBase)this).FlatStyle = (FlatStyle)0;
		((ButtonBase)this).BackColor = Color.Transparent;
		Timer1.Interval = 5;
		Timer1.Tick += Timer1_Tick;
	}

	public void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)this).Name = "MBGlassButton";
		Size size = new Size(112, 35);
		((Control)this).Size = size;
		((Control)this).ResumeLayout(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Components != null)
		{
			Components.Dispose();
		}
		base.Dispose(disposing);
	}

	protected override void OnCreateControl()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		base.OnCreateControl();
		A0 = BaseColor.A;
		R0 = BaseColor.R;
		G0 = BaseColor.G;
		B0 = BaseColor.B;
		_colorStroke = _baseStroke;
		Point location = new Point(-1, -1);
		Size size = checked(new Size(((Control)this).Width + _radius, ((Control)this).Height + _radius));
		Rectangle re = new Rectangle(location, size);
		Size size2 = default;
		if (((Control)this).Size != size2)
		{
			GraphicsPath val = new GraphicsPath();
			DrawArc(re, val);
			((Control)this).Region = new Region(val);
		}
	}

	public Color GetColorIncreased(Color color, int h, int s, int b)
	{
		MBColor mBColor = new MBColor(color);
		int num = Conversions.ToInteger(mBColor.GetSaturation());
		float vC = Conversions.ToSingle(Operators.AddObject(b, mBColor.GetBrightness()));
		checked
		{
			float hC = h + mBColor.GetHue();
			float sC = s + num;
			mBColor.VC = vC;
			mBColor.HC = hC;
			mBColor.SC = sC;
			return mBColor.GetColor();
		}
	}

	public object GetColor(int A, int R, int G, int B)
	{
		checked
		{
			A = ((A + A0 <= 255) ? (A + A0) : 255);
			R = ((R + R0 <= 255) ? (R + R0) : 255);
			G = ((G + G0 <= 255) ? (G + G0) : 255);
			B = ((B + B0 <= 255) ? (B + B0) : 255);
			return Color.FromArgb(A, R, G, B);
		}
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Graphics graphics = pevent.Graphics;
		graphics.SmoothingMode = (SmoothingMode)2;
		graphics.InterpolationMode = (InterpolationMode)2;
		Point point = new Point(-1, -1);
		Point location = point;
		checked
		{
			Size size = new Size(((Control)this).Width + _radius, ((Control)this).Height + _radius);
			Rectangle rectangle = new Rectangle(location, size);
			GraphicsPath pa = new GraphicsPath();
			point = new Point(0, 0);
			Point location2 = point;
			size = new Size(((Control)this).Width - 1, ((Control)this).Height - 1);
			Rectangle re = new Rectangle(location2, size);
			DrawArc(re, pa);
			FillGradients(graphics, pa);
			DrawImage(graphics);
			DrawText(graphics);
			DrawArrow(graphics);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		Point location = new Point(-1, -1);
		Size size = checked(new Size(((Control)this).Width + _radius, ((Control)this).Height + _radius));
		Rectangle re = new Rectangle(location, size);
		Size size2 = default;
		if (((Control)this).Size != size2)
		{
			GraphicsPath val = new GraphicsPath();
			DrawArc(re, val);
			((Control)this).Region = new Region(val);
		}
		base.OnResize(e);
	}

	private void MBGlassButton_ContextMenuStripChanged(object sender, EventArgs e)
	{
		if (((Control)this).ContextMenuStrip != null)
		{
			((ToolStrip)((Control)this).ContextMenuStrip).Renderer = (ToolStripRenderer)(object)new MBMenuRendere();
		}
	}

	public void FillGradients(Graphics gr, GraphicsPath pa)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		checked
		{
			int num = (int)Math.Round((double)((Control)this).Height / 3.0);
			int height = ((Control)this).Height;
			int num2 = (int)Math.Round((double)(height - num) / 2.0);
			if (_showbase != MB_ShowBase.Yes)
			{
				return;
			}
			Point point = new Point(0, 0);
			Point location = point;
			Size size = new Size(((Control)this).Width - 1, ((Control)this).Height - 1);
			Rectangle rectangle = new Rectangle(location, size);
			pa = new GraphicsPath();
			DrawArc(rectangle, pa);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, (LinearGradientMode)1);
			float[] positions = new float[4] { 0f, 0.3f, 0.35f, 1f };
			Color color2 = default;
			Color[] colors;
			if (i_mode == 0)
			{
				Color[] array = new Color[4];
				ref Color reference = ref array[0];
				object color = GetColor(0, 35, 24, 9);
				reference = ((color != null) ? ((Color)color) : color2);
				ref Color reference2 = ref array[1];
				object color3 = GetColor(0, 13, 8, 3);
				reference2 = ((color3 != null) ? ((Color)color3) : color2);
				ref Color reference3 = ref array[2];
				reference3 = Color.FromArgb(A0, R0, G0, B0);
				ref Color reference4 = ref array[3];
				object color4 = GetColor(0, 28, 29, 14);
				reference4 = ((color4 != null) ? ((Color)color4) : color2);
				colors = array;
			}
			else
			{
				Color[] array = new Color[4];
				ref Color reference5 = ref array[0];
				object color5 = GetColor(0, 0, 50, 100);
				reference5 = ((color5 != null) ? ((Color)color5) : color2);
				ref Color reference6 = ref array[1];
				object color6 = GetColor(0, 0, 0, 30);
				reference6 = ((color6 != null) ? ((Color)color6) : color2);
				ref Color reference7 = ref array[2];
				reference7 = Color.FromArgb(A0, R0, G0, B0);
				ref Color reference8 = ref array[3];
				object color7 = GetColor(0, 0, 50, 100);
				reference8 = ((color7 != null) ? ((Color)color7) : color2);
				colors = array;
			}
			ColorBlend val2 = new ColorBlend();
			val2.Colors = colors;
			val2.Positions = positions;
			val.InterpolationColors = val2;
			gr.FillPath((Brush)(object)val, pa);
			point = new Point(0, 0);
			Point location2 = point;
			size = new Size(((Control)this).Width, (int)Math.Round((double)((Control)this).Height / 3.0));
			rectangle = new Rectangle(location2, size);
			pa = new GraphicsPath();
			int radius = _radius--;
			DrawArc(rectangle, pa);
			if (A0 > 80)
			{
				gr.FillPath((Brush)new SolidBrush(Color.FromArgb(60, 255, 255, 255)), pa);
			}
			_radius = radius;
			if ((_splitbutton == MB_SplitButton.Yes) & mouse)
			{
				FillSplitPart(gr);
			}
			if (i_mode == 2)
			{
				rectangle = new Rectangle(1, 1, ((Control)this).Width - 2, ((Control)this).Height);
				pa = new GraphicsPath();
				DrawShadow(rectangle, pa);
				gr.DrawPath(new Pen(Color.FromArgb(50, 20, 20, 20), 2f), pa);
			}
			else
			{
				rectangle = new Rectangle(1, 1, ((Control)this).Width - 2, ((Control)this).Height - 1);
				pa = new GraphicsPath();
				DrawShadow(rectangle, pa);
				if (A0 > 80)
				{
					gr.DrawPath(new Pen(Color.FromArgb(100, 250, 250, 250), 3f), pa);
				}
			}
			Point point2;
			if (_splitbutton == MB_SplitButton.Yes)
			{
				if (_splitlocation == MB_SplitLocation.Bottom)
				{
					switch (i_mode)
					{
					case 1:
					{
						Pen val4 = new Pen(_onStroke);
						point = new Point(1, ((Control)this).Height - _splitdistance);
						Point point4 = point;
						point2 = new Point(((Control)this).Width - 1, ((Control)this).Height - _splitdistance);
						gr.DrawLine(val4, point4, point2);
						break;
					}
					case 2:
					{
						Pen val3 = new Pen(_pressStroke);
						point2 = new Point(1, ((Control)this).Height - _splitdistance);
						Point point3 = point2;
						point = new Point(((Control)this).Width - 1, ((Control)this).Height - _splitdistance);
						gr.DrawLine(val3, point3, point);
						break;
					}
					}
				}
				else if (_splitlocation == MB_SplitLocation.Right)
				{
					switch (i_mode)
					{
					case 1:
					{
						Pen val6 = new Pen(_onStroke);
						point2 = new Point(((Control)this).Width - _splitdistance, 0);
						Point point6 = point2;
						point = new Point(((Control)this).Width - _splitdistance, ((Control)this).Height);
						gr.DrawLine(val6, point6, point);
						break;
					}
					case 2:
					{
						Pen val5 = new Pen(_pressStroke);
						point2 = new Point(((Control)this).Width - _splitdistance, 0);
						Point point5 = point2;
						point = new Point(((Control)this).Width - _splitdistance, ((Control)this).Height);
						gr.DrawLine(val5, point5, point);
						break;
					}
					}
				}
			}
			point2 = new Point(0, 0);
			Point location3 = point2;
			size = new Size(((Control)this).Width - 1, ((Control)this).Height - 1);
			rectangle = new Rectangle(location3, size);
			pa = new GraphicsPath();
			DrawArc(rectangle, pa);
			gr.DrawPath(new Pen(_colorStroke, 0.9f), pa);
			pa.Dispose();
			((Brush)val).Dispose();
		}
	}

	public void DrawImage(Graphics gr)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Invalid comparison between Unknown and I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Invalid comparison between Unknown and I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Invalid comparison between Unknown and I4
		if (((ButtonBase)this).Image != null)
		{
			Rectangle rectangle = new Rectangle(8, 8, ImageSize.Width, ImageSize.Height);
			ContentAlignment imageAlign = ((ButtonBase)this).ImageAlign;
			if ((int)imageAlign == 2)
			{
				rectangle = new Rectangle(checked((int)Math.Round((double)((Control)this).Width / 2.0 - (double)ImageSize.Width / 2.0)), 8, ImageSize.Width, ImageSize.Height);
			}
			else if ((int)imageAlign == 4)
			{
				rectangle = new Rectangle(checked(((Control)this).Width - 8 - ImageSize.Width), 8, ImageSize.Width, ImageSize.Height);
			}
			else if ((int)imageAlign == 16)
			{
				rectangle = new Rectangle(8, checked((int)Math.Round((double)((Control)this).Height / 2.0 - (double)ImageSize.Height / 2.0)), ImageSize.Width, ImageSize.Height);
			}
			else if ((int)imageAlign == 32)
			{
				rectangle = checked(new Rectangle((int)Math.Round((double)((Control)this).Width / 2.0 - (double)ImageSize.Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)ImageSize.Height / 2.0), ImageSize.Width, ImageSize.Height));
			}
			else if ((int)imageAlign == 64)
			{
				rectangle = checked(new Rectangle(((Control)this).Width - 8 - ImageSize.Width, (int)Math.Round((double)((Control)this).Height / 2.0 - (double)ImageSize.Height / 2.0), ImageSize.Width, ImageSize.Height));
			}
			else if ((int)imageAlign == 256)
			{
				rectangle = new Rectangle(8, checked(((Control)this).Height - 8 - ImageSize.Height), ImageSize.Width, ImageSize.Height);
			}
			else if ((int)imageAlign == 512)
			{
				rectangle = checked(new Rectangle((int)Math.Round((double)((Control)this).Width / 2.0 - (double)ImageSize.Width / 2.0), ((Control)this).Height - 8 - ImageSize.Height, ImageSize.Width, ImageSize.Height));
			}
			else if ((int)imageAlign == 1024)
			{
				rectangle = checked(new Rectangle(((Control)this).Width - 8 - ImageSize.Width, ((Control)this).Height - 8 - ImageSize.Height, ImageSize.Width, ImageSize.Height));
			}
			gr.DrawImage(((ButtonBase)this).Image, rectangle);
		}
	}

	public void DrawText(Graphics g)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		StringFormat val = (StringFormat)TextAlignment(((ButtonBase)this).TextAlign);
		Rectangle rectangle = checked((!((SplitButton == MB_SplitButton.Yes) & (SplitLocation == MB_SplitLocation.Right))) ? new Rectangle(8, 8, ((Control)this).Width - 17, ((Control)this).Height - 17) : new Rectangle(8, 8, ((Control)this).Width - 17 - _splitdistance, ((Control)this).Height - 17));
		g.DrawString(((ButtonBase)this).Text, ((Control)this).Font, (Brush)new SolidBrush(((Control)this).ForeColor), (RectangleF)rectangle, val);
	}

	private object TextAlignment(ContentAlignment textalign)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		StringFormat val = new StringFormat();
		if ((int)textalign == 1)
		{
			val.LineAlignment = (StringAlignment)0;
		}
		else if ((int)textalign == 2)
		{
			val.LineAlignment = (StringAlignment)0;
		}
		else if ((int)textalign == 4)
		{
			val.LineAlignment = (StringAlignment)0;
		}
		else if ((int)textalign == 16)
		{
			val.LineAlignment = (StringAlignment)1;
		}
		else if ((int)textalign == 32)
		{
			val.LineAlignment = (StringAlignment)1;
		}
		else if ((int)textalign == 64)
		{
			val.LineAlignment = (StringAlignment)1;
		}
		else if ((int)textalign == 256)
		{
			val.LineAlignment = (StringAlignment)2;
		}
		else if ((int)textalign == 512)
		{
			val.LineAlignment = (StringAlignment)2;
		}
		else if ((int)textalign == 1024)
		{
			val.LineAlignment = (StringAlignment)2;
		}
		if ((int)textalign == 1)
		{
			val.Alignment = (StringAlignment)0;
		}
		else if ((int)textalign == 16)
		{
			val.Alignment = (StringAlignment)0;
		}
		else if ((int)textalign == 256)
		{
			val.Alignment = (StringAlignment)0;
		}
		else if ((int)textalign == 2)
		{
			val.Alignment = (StringAlignment)1;
		}
		else if ((int)textalign == 32)
		{
			val.Alignment = (StringAlignment)1;
		}
		else if ((int)textalign == 512)
		{
			val.Alignment = (StringAlignment)1;
		}
		else if ((int)textalign == 4)
		{
			val.Alignment = (StringAlignment)2;
		}
		else if ((int)textalign == 64)
		{
			val.Alignment = (StringAlignment)2;
		}
		else if ((int)textalign == 1024)
		{
			val.Alignment = (StringAlignment)2;
		}
		return val;
	}

	public void DrawArc(Rectangle re, GraphicsPath pa)
	{
		if (_radius < 2)
		{
			_radius = 2;
		}
		int num = _radius;
		int num2 = _radius;
		int num3 = _radius;
		int num4 = _radius;
		switch ((int)_grouppos)
		{
		case 1:
			num2 = 1;
			num4 = 1;
			break;
		case 2:
			num = 1;
			num3 = 1;
			num2 = 1;
			num4 = 1;
			break;
		case 3:
			num = 1;
			num3 = 1;
			break;
		case 4:
			num3 = 1;
			num4 = 1;
			break;
		case 5:
			num = 1;
			num2 = 1;
			break;
		}
		pa.AddArc(re.X, re.Y, num, num, 180f, 90f);
		checked
		{
			pa.AddArc(re.Width - num2, re.Y, num2, num2, 270f, 90f);
			pa.AddArc(re.Width - num4, re.Height - num4, num4, num4, 0f, 90f);
			pa.AddArc(re.X, re.Height - num3, num3, num3, 90f, 90f);
			pa.CloseFigure();
		}
	}

	public void DrawShadow(Rectangle re, GraphicsPath pa)
	{
		int num = _radius;
		int num2 = _radius;
		int num3 = _radius;
		int num4 = _radius;
		switch ((int)_grouppos)
		{
		case 1:
			num2 = 1;
			num4 = 1;
			break;
		case 2:
			num = 1;
			num3 = 1;
			num2 = 1;
			num4 = 1;
			break;
		case 3:
			num = 1;
			num3 = 1;
			break;
		case 4:
			num3 = 1;
			num4 = 1;
			break;
		case 5:
			num = 1;
			num2 = 1;
			break;
		}
		pa.AddArc(re.X, re.Y, num, num, 180f, 90f);
		checked
		{
			pa.AddArc(re.Width - num2, re.Y, num2, num2, 270f, 90f);
			pa.AddArc(re.Width - num4, re.Height - num4, num4, num4, 0f, 90f);
			pa.AddArc(re.X, re.Height - num3, num3, num3, 90f, 90f);
			pa.CloseFigure();
		}
	}

	public void DrawArrow(Graphics gr)
	{
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		int num = 1;
		MBColor mBColor = new MBColor(Color.FromArgb(R0, G0, B0));
		MBColor mBColor2 = new MBColor(((Control)this).ForeColor);
		if (Operators.ConditionalCompareObjectGreater(mBColor.GetBrightness(), 50, TextCompare: false))
		{
			mBColor2.BC = 1;
			mBColor2.SC = 80f;
		}
		else
		{
			mBColor2.BC = 99;
			mBColor2.SC = 20f;
		}
		Color color = mBColor2.GetColor();
		checked
		{
			switch (unchecked((int)_arrow))
			{
			case 2:
				if (_splitlocation == MB_SplitLocation.Right)
				{
					int num3 = ((Control)this).Width - _splitdistance - 4;
					if (_splitdistance == 0)
					{
						num3 -= 10;
					}
					Point[] array = new Point[3];
					ref Point reference4 = ref array[0];
					Point point3 = new Point((int)Math.Round((double)_splitdistance / 2.0 + (double)num3 + (double)(8 * num) - (double)_imageoffset), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)num / 2.0));
					reference4 = point3;
					ref Point reference5 = ref array[1];
					Point point2 = new Point((int)Math.Round((double)_splitdistance / 2.0 + (double)num3 + 0.5 * (double)num - (double)_imageoffset), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)num / 2.0));
					reference5 = point2;
					ref Point reference6 = ref array[2];
					Point point = new Point((int)Math.Round((double)_splitdistance / 2.0 + (double)num3 + (double)(4 * num) - (double)_imageoffset), (int)Math.Round((double)((Control)this).Height / 2.0 + (double)(num * 2)));
					reference6 = point;
					Point[] array3 = array;
					gr.FillPolygon((Brush)new SolidBrush(color), array3);
				}
				else if (_splitlocation == MB_SplitLocation.Bottom)
				{
					Point[] array = new Point[3];
					ref Point reference7 = ref array[0];
					Point point = new Point((int)Math.Round((double)((Control)this).Width / 2.0 + (double)(5 * num) - (double)_imageoffset), ((Control)this).Height - _imageoffset - 5 * num);
					reference7 = point;
					ref Point reference8 = ref array[1];
					Point point2 = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)(4 * num) - (double)_imageoffset), ((Control)this).Height - _imageoffset - 5 * num);
					reference8 = point2;
					ref Point reference9 = ref array[2];
					Point point3 = new Point((int)Math.Round((double)((Control)this).Width / 2.0 + (double)(1 * num) - (double)_imageoffset), ((Control)this).Height - _imageoffset - 2 * num);
					reference9 = point3;
					Point[] array4 = array;
					gr.FillPolygon((Brush)new SolidBrush(color), array4);
				}
				break;
			case 1:
				if (_splitlocation == MB_SplitLocation.Right)
				{
					int num2 = ((Control)this).Width - _splitdistance + 4 * _imageoffset;
					if (_splitdistance == 0)
					{
						num2 -= 15;
					}
					Point[] array = new Point[3];
					ref Point reference = ref array[0];
					Point point = new Point(num2 + 4, (int)Math.Round((double)((Control)this).Height / 2.0 - (double)(4 * num)));
					reference = point;
					ref Point reference2 = ref array[1];
					Point point2 = new Point(num2 + 8, (int)Math.Round((double)((Control)this).Height / 2.0));
					reference2 = point2;
					ref Point reference3 = ref array[2];
					Point point3 = new Point(num2 + 4, (int)Math.Round((double)((Control)this).Height / 2.0 + (double)(4 * num)));
					reference3 = point3;
					Point[] array2 = array;
					gr.FillPolygon((Brush)new SolidBrush(color), array2);
				}
				break;
			}
		}
	}

	public void FillSplitPart(Graphics g)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		Color color = Color.FromArgb(200, 255, 255, 255);
		checked
		{
			int num = ((Control)this).Width - _splitdistance;
			int num2 = 0;
			int num3 = ((Control)this).Height - _splitdistance;
			int num4 = 0;
			SolidBrush val = new SolidBrush(color);
			if (_splitlocation == MB_SplitLocation.Right)
			{
				if ((xmouse < ((Control)this).Width - _splitdistance) & mouse)
				{
					Rectangle re = new Rectangle(num + 1, 1, ((Control)this).Width - 2, ((Control)this).Height - 1);
					GraphicsPath val2 = new GraphicsPath();
					int radius = _radius;
					_radius = 4;
					DrawArc(re, val2);
					_radius = radius;
					g.FillPath((Brush)(object)val, val2);
				}
				else if (mouse)
				{
					Rectangle re2 = new Rectangle(num2 + 1, 1, ((Control)this).Width - _splitdistance - 1, ((Control)this).Height - 1);
					GraphicsPath val3 = new GraphicsPath();
					int radius2 = _radius;
					_radius = 4;
					DrawArc(re2, val3);
					_radius = radius2;
					g.FillPath((Brush)(object)val, val3);
				}
			}
			else if (_splitlocation == MB_SplitLocation.Bottom)
			{
				if ((ymouse < ((Control)this).Height - _splitdistance) & mouse)
				{
					Rectangle re3 = new Rectangle(1, num3 + 1, ((Control)this).Width - 1, ((Control)this).Height - 1);
					GraphicsPath val4 = new GraphicsPath();
					int radius3 = _radius;
					_radius = 4;
					DrawArc(re3, val4);
					_radius = radius3;
					g.FillPath((Brush)(object)val, val4);
				}
				else if (mouse)
				{
					Rectangle re4 = new Rectangle(1, num4 + 1, ((Control)this).Width - 1, ((Control)this).Height - _splitdistance - 1);
					GraphicsPath val5 = new GraphicsPath();
					int radius4 = _radius;
					_radius = 4;
					DrawArc(re4, val5);
					_radius = radius4;
					g.FillPath((Brush)(object)val, val5);
				}
			}
			((Brush)val).Dispose();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (i_mode == 1)
			{
				if (Math.Abs(OnColor.R - R0) > i_factor)
				{
					i_fR = i_factor;
				}
				else
				{
					i_fR = 1;
				}
				if (Math.Abs(OnColor.G - G0) > i_factor)
				{
					i_fG = i_factor;
				}
				else
				{
					i_fG = 1;
				}
				if (Math.Abs(OnColor.B - B0) > i_factor)
				{
					i_fB = i_factor;
				}
				else
				{
					i_fB = 1;
				}
				if (OnColor.R < R0)
				{
					R0 -= i_fR;
				}
				else if (OnColor.R > R0)
				{
					R0 += i_fR;
				}
				if (OnColor.G < G0)
				{
					G0 -= i_fG;
				}
				else if (OnColor.G > G0)
				{
					G0 += i_fG;
				}
				if (OnColor.B < B0)
				{
					B0 -= i_fB;
				}
				else if (OnColor.B > B0)
				{
					B0 += i_fB;
				}
				if (OnColor == Color.FromArgb(R0, G0, B0))
				{
					Timer1.Stop();
				}
				else
				{
					((Control)this).Refresh();
				}
			}
			if (i_mode == 0)
			{
				if (Math.Abs(BaseColor.R - R0) < i_factor)
				{
					i_fR = 1;
				}
				else
				{
					i_fR = i_factor;
				}
				if (Math.Abs(BaseColor.G - G0) < i_factor)
				{
					i_fG = 1;
				}
				else
				{
					i_fG = i_factor;
				}
				if (Math.Abs(BaseColor.B - B0) < i_factor)
				{
					i_fB = 1;
				}
				else
				{
					i_fB = i_factor;
				}
				if (Math.Abs(BaseColor.A - A0) < i_factor)
				{
					i_fA = 1;
				}
				else
				{
					i_fA = i_factor;
				}
				if (BaseColor.R < R0)
				{
					R0 -= i_fR;
				}
				else if (BaseColor.R > R0)
				{
					R0 += i_fR;
				}
				if (BaseColor.G < G0)
				{
					G0 -= i_fG;
				}
				else if (BaseColor.G > G0)
				{
					G0 += i_fG;
				}
				if (BaseColor.B < B0)
				{
					B0 -= i_fB;
				}
				else if (BaseColor.B > B0)
				{
					B0 += i_fB;
				}
				if (BaseColor.A < A0)
				{
					A0 -= i_fA;
				}
				else if (BaseColor.A > A0)
				{
					A0 += i_fA;
				}
				if (BaseColor == Color.FromArgb(A0, R0, G0, B0))
				{
					Timer1.Stop();
				}
				else
				{
					((Control)this).Refresh();
				}
			}
			((Control)this).Refresh();
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		_colorStroke = OnStrokeColor;
		_tempshowbase = _showbase;
		_showbase = MB_ShowBase.Yes;
		i_mode = 1;
		xmouse = ((Control)this).PointToClient(Cursor.Position).X;
		mouse = true;
		A0 = 200;
		if (i_factor == 0)
		{
			R0 = _onColor.R;
			G0 = _onColor.G;
			B0 = _onColor.B;
		}
		Timer1.Start();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		UpdateMouseLeave();
	}

	public void UpdateMouseLeave()
	{
		if (!_keeppressed | (_keeppressed & !_ispressed))
		{
			_colorStroke = BaseStrokeColor;
			_showbase = _tempshowbase;
			i_mode = 0;
			mouse = false;
			if (i_factor == 0)
			{
				R0 = _baseColor.R;
				G0 = _baseColor.G;
				B0 = _baseColor.B;
				((Control)this).Refresh();
			}
			else
			{
				Timer1.Stop();
				Timer1.Start();
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs mevent)
	{
		base.OnMouseDown(mevent);
		R0 = PressColor.R;
		G0 = PressColor.G;
		B0 = PressColor.B;
		_colorStroke = PressStrokeColor;
		_showbase = MB_ShowBase.Yes;
		i_mode = 2;
		xmouse = ((Control)this).PointToClient(Cursor.Position).X;
		ymouse = ((Control)this).PointToClient(Cursor.Position).Y;
		mouse = true;
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		R0 = OnColor.R;
		G0 = OnColor.G;
		B0 = OnColor.B;
		_colorStroke = OnStrokeColor;
		_showbase = MB_ShowBase.Yes;
		i_mode = 1;
		mouse = true;
		checked
		{
			if ((_splitlocation == MB_SplitLocation.Right) & (xmouse > ((Control)this).Width - _splitdistance) & (_splitbutton == MB_SplitButton.Yes))
			{
				if (_arrow == MB_Arrow.ToDown)
				{
					if (((Control)this).ContextMenuStrip != null)
					{
						((ToolStripDropDown)((Control)this).ContextMenuStrip).Opacity = 1.0;
						((Control)((Control)this).ContextMenuStrip).Width = ((Control)this).Width;
						((ToolStripDropDown)((Control)this).ContextMenuStrip).Show((Control)(object)this, 0, ((Control)this).Height);
					}
				}
				else if (_arrow == MB_Arrow.ToRight && ((Control)this).ContextMenuStrip != null)
				{
					ContextMenuStrip contextMenuStrip = ((Control)this).ContextMenuStrip;
					((Control)contextMenuStrip).Width = ((Control)this).Width;
					((ToolStripDropDown)((Control)this).ContextMenuStrip).Opacity = 1.0;
					if (MenuListPosition.Y == 0)
					{
						((ToolStripDropDown)((Control)this).ContextMenuStrip).Show((Control)(object)this, ((Control)this).Width + 2, -((Control)this).Height);
					}
					else
					{
						((ToolStripDropDown)((Control)this).ContextMenuStrip).Show((Control)(object)this, ((Control)this).Width + 2, MenuListPosition.Y);
					}
				}
				return;
			}
			if ((_splitlocation == MB_SplitLocation.Bottom) & (ymouse > ((Control)this).Height - _splitdistance) & (_splitbutton == MB_SplitButton.Yes))
			{
				if (_arrow == MB_Arrow.ToDown && ((Control)this).ContextMenuStrip != null)
				{
					((Control)((Control)this).ContextMenuStrip).Width = ((Control)this).Width;
					((ToolStripDropDown)((Control)this).ContextMenuStrip).Show((Control)(object)this, 0, ((Control)this).Height);
				}
				return;
			}
			base.OnMouseUp(mevent);
			if (!_keeppressed)
			{
				return;
			}
			_ispressed = true;
			foreach (Control control in ((Control)this).Parent.Controls)
			{
				Control val = control;
				if ((Operators.CompareString(val.Name, ((Control)this).Name, TextCompare: false) != 0) & (val is Button_MBGlassButton))
				{
					((Button_MBGlassButton)(object)val)._ispressed = false;
					((Button_MBGlassButton)(object)val).UpdateMouseLeave();
				}
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		if (mouse & (SplitButton == MB_SplitButton.Yes))
		{
			xmouse = ((Control)this).PointToClient(Cursor.Position).X;
			ymouse = ((Control)this).PointToClient(Cursor.Position).Y;
			((Control)this).Refresh();
		}
		base.OnMouseMove(mevent);
	}
}
