using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LOGICA;

public class TabControlEx : TabControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _HeaderWidth;

	private int _HeaderHeight;

	private ContentAlignment _HeaderAlignment;

	private Padding _HeaderPadding;

	private Font _HeaderFont;

	private Color _HeaderBackColor;

	private SolidBrush _HeaderBackBrush;

	private Color _HeaderBorderColor;

	private Pen _HeaderBackPen;

	private Color _HeaderForeColor;

	private SolidBrush _HeaderForeBrush;

	private Color _HeaderSelectedBackColor;

	private SolidBrush _HeaderSelectedBackBrush;

	private Color _HeaderSelectedForeColor;

	private Brush _HeaderSelectedForeBrush;

	private Color _BackColor;

	private SolidBrush _BackBrush;

	[DefaultValue(100)]
	public int HeaderWidth
	{
		get
		{
			return _HeaderWidth;
		}
		set
		{
			_HeaderWidth = value;
			Size itemSize = new Size(ItemSize.Width, value);
			ItemSize = itemSize;
		}
	}

	[DefaultValue(32)]
	public int HeaderHeight
	{
		get
		{
			return _HeaderHeight;
		}
		set
		{
			_HeaderHeight = value;
			Size itemSize = new Size(value, ItemSize.Height);
			ItemSize = itemSize;
		}
	}

	[DefaultValue(typeof(ContentAlignment), "ContentAlignment.MiddleLeft")]
	public ContentAlignment HeaderAlignment
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return _HeaderAlignment;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_HeaderAlignment = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(typeof(Padding), "3,3,3,3")]
	public Padding HeaderPadding
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return _HeaderPadding;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_HeaderPadding = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(typeof(Color), "White")]
	public Color HeaderBorderColor
	{
		get
		{
			return _HeaderBorderColor;
		}
		set
		{
			if (!(value == _HeaderBorderColor))
			{
				_HeaderBorderColor = value;
				if (_HeaderBackPen != null)
				{
					_HeaderBackPen.Dispose();
					_HeaderBackPen = null;
				}
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(typeof(Color), "LightGray")]
	public Color HeaderBackColor
	{
		get
		{
			return _HeaderBackColor;
		}
		set
		{
			if (!(value == _HeaderBackColor))
			{
				_HeaderBackColor = value;
				if (_HeaderBackBrush != null)
				{
					((Brush)_HeaderBackBrush).Dispose();
					_HeaderBackBrush = null;
				}
				((Control)this).Invalidate();
			}
		}
	}

	private SolidBrush HeaderBackBrush
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_HeaderBackBrush == null)
			{
				_HeaderBackBrush = new SolidBrush(HeaderBackColor);
			}
			return _HeaderBackBrush;
		}
	}

	private Pen HeaderPen
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_HeaderBackPen == null)
			{
				_HeaderBackPen = new Pen(HeaderBorderColor);
			}
			return _HeaderBackPen;
		}
	}

	[DefaultValue(typeof(Color), "Black")]
	public Color HeaderForeColor
	{
		get
		{
			return _HeaderForeColor;
		}
		set
		{
			if (!(value == _HeaderForeColor))
			{
				_HeaderForeColor = value;
				if (_HeaderForeBrush != null)
				{
					((Brush)_HeaderForeBrush).Dispose();
					_HeaderForeBrush = null;
				}
				((Control)this).Invalidate();
			}
		}
	}

	private SolidBrush HeaderForeBrush
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_HeaderForeBrush == null)
			{
				_HeaderForeBrush = new SolidBrush(HeaderForeColor);
			}
			return _HeaderForeBrush;
		}
	}

	[DefaultValue(typeof(Color), "DarkGray")]
	public Color HeaderSelectedBackColor
	{
		get
		{
			return _HeaderSelectedBackColor;
		}
		set
		{
			if (!(value == _HeaderSelectedBackColor))
			{
				_HeaderSelectedBackColor = value;
				if (_HeaderSelectedBackBrush != null)
				{
					((Brush)_HeaderSelectedBackBrush).Dispose();
					_HeaderSelectedBackBrush = null;
				}
				((Control)this).Invalidate();
			}
		}
	}

	private SolidBrush HeaderSelectedBackBrush
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_HeaderSelectedBackBrush == null)
			{
				_HeaderSelectedBackBrush = new SolidBrush(HeaderSelectedBackColor);
			}
			return _HeaderSelectedBackBrush;
		}
	}

	[DefaultValue(typeof(Color), "White")]
	public Color HeaderSelectedForeColor
	{
		get
		{
			return _HeaderSelectedForeColor;
		}
		set
		{
			if (!(value == _HeaderSelectedForeColor))
			{
				_HeaderSelectedForeColor = value;
				_HeaderSelectedForeBrush.Dispose();
				_HeaderSelectedForeBrush = null;
				((Control)this).Invalidate();
			}
		}
	}

	private SolidBrush HeaderSelectedForeBrush
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_HeaderSelectedForeBrush == null)
			{
				_HeaderSelectedForeBrush = (Brush)new SolidBrush(HeaderSelectedForeColor);
			}
			return (SolidBrush)_HeaderSelectedForeBrush;
		}
	}

	public Font HeaderFont
	{
		get
		{
			return _HeaderFont;
		}
		set
		{
			_HeaderFont = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(typeof(Color), "White")]
	[Browsable(true)]
	public override Color BackColor
	{
		get
		{
			return _BackColor;
		}
		set
		{
			if (!(_BackColor == value))
			{
				_BackColor = value;
				if (_BackBrush != null)
				{
					((Brush)_BackBrush).Dispose();
					_BackBrush = null;
				}
				((Control)this).Invalidate();
			}
		}
	}

	private SolidBrush BackBrush
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if (_BackBrush == null)
			{
				_BackBrush = new SolidBrush(BackColor);
			}
			return _BackBrush;
		}
	}

	[Browsable(false)]
	public TabDrawMode DrawMode
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return ((TabControl)this).DrawMode;
		}
		set
		{
			((TabControl)this).DrawMode = (TabDrawMode)1;
		}
	}

	[Browsable(false)]
	public TabAlignment Alignment
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return ((TabControl)this).Alignment;
		}
		set
		{
			((TabControl)this).Alignment = (TabAlignment)2;
		}
	}

	[Browsable(false)]
	public TabAppearance Appearance
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return ((TabControl)this).Appearance;
		}
		set
		{
			((TabControl)this).Appearance = (TabAppearance)0;
		}
	}

	[Browsable(false)]
	public Size ItemSize
	{
		get
		{
			return ((TabControl)this).ItemSize;
		}
		set
		{
			((TabControl)this).ItemSize = value;
		}
	}

	[Browsable(false)]
	public TabSizeMode SizeMode
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return ((TabControl)this).SizeMode;
		}
		set
		{
			((TabControl)this).SizeMode = (TabSizeMode)2;
		}
	}

	[Browsable(false)]
	public bool Multiline
	{
		get
		{
			return ((TabControl)this).Multiline;
		}
		set
		{
			((TabControl)this).Multiline = true;
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

	public TabControlEx()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		__ENCAddToList(this);
		_HeaderWidth = 100;
		_HeaderHeight = 32;
		_HeaderAlignment = (ContentAlignment)16;
		ref Padding headerPadding = ref _HeaderPadding;
		headerPadding = new Padding(3);
		_BackColor = Color.White;
		_HeaderBorderColor = Color.White;
		_HeaderFont = ((Control)this).Font;
		_HeaderForeColor = Color.Black;
		_HeaderBackColor = Color.DarkGray;
		_HeaderSelectedBackColor = Color.LightGray;
		_HeaderSelectedForeColor = Color.White;
		DrawMode = (TabDrawMode)1;
		SizeMode = (TabSizeMode)2;
		Alignment = (TabAlignment)2;
		Size itemSize = new Size(HeaderHeight, HeaderWidth);
		ItemSize = itemSize;
		base.SetStyle((ControlStyles)8192, true);
		base.SetStyle((ControlStyles)2, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Graphics graphics = e.Graphics;
		graphics.FillRectangle((Brush)(object)BackBrush, e.ClipRectangle);
		checked
		{
			int num = ((TabControl)this).TabPages.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					DrawTabButton(graphics, num2);
					DrawTabText(graphics, num2);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void DrawTabButton(Graphics g, int TabPageIndex)
	{
		Rectangle tabRect = ((TabControl)this).GetTabRect(TabPageIndex);
		checked
		{
			tabRect.Width += 2;
			if (TabPageIndex == 0)
			{
				tabRect.Height -= 2;
				tabRect.Y += 2;
			}
			if (((TabControl)this).SelectedIndex == TabPageIndex)
			{
				g.FillRectangle((Brush)(object)HeaderSelectedBackBrush, tabRect);
				if (((Control)this).Focused)
				{
					Rectangle rectangle = new Rectangle(tabRect.Left + 2, tabRect.Top + 2, tabRect.Width - 4, tabRect.Height - 5);
					ControlPaint.DrawFocusRectangle(g, rectangle);
				}
			}
			else
			{
				g.FillRectangle((Brush)(object)HeaderBackBrush, tabRect);
			}
			if (TabPageIndex == 0)
			{
				g.DrawLine(HeaderPen, tabRect.Left, tabRect.Top, tabRect.Right, tabRect.Top);
			}
			g.DrawLine(HeaderPen, tabRect.Left, tabRect.Top, tabRect.Left, tabRect.Bottom - 1);
			g.DrawLine(HeaderPen, tabRect.Left, tabRect.Bottom - 1, tabRect.Right, tabRect.Bottom - 1);
		}
	}

	private void DrawTabText(Graphics g, int TabPageIndex)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		Rectangle tabRect = ((TabControl)this).GetTabRect(TabPageIndex);
		string text = ((TabControl)this).TabPages[TabPageIndex].Text;
		SizeF sizeF = g.MeasureString(text, HeaderFont);
		ContentAlignment headerAlignment = HeaderAlignment;
		Padding headerPadding;
		int num = default;
		Padding headerPadding2;
		if (((int)headerAlignment == 16 || (int)headerAlignment == 256 || (int)headerAlignment == 1) ? true : false)
		{
			int left = tabRect.Left;
			headerPadding = HeaderPadding;
			num = checked(left + headerPadding.Left);
		}
		else if (((int)headerAlignment == 64 || (int)headerAlignment == 1024 || (int)headerAlignment == 4) ? true : false)
		{
			float num2 = (float)tabRect.Right - sizeF.Width;
			headerPadding = HeaderPadding;
			num = checked((int)Math.Round(num2 - (float)headerPadding.Right));
		}
		else if (((int)headerAlignment == 32 || (int)headerAlignment == 512 || (int)headerAlignment == 2) ? true : false)
		{
			float num3 = tabRect.Left;
			int width = tabRect.Width;
			headerPadding = HeaderPadding;
			checked
			{
				int num4 = width - headerPadding.Left;
				headerPadding2 = HeaderPadding;
				num = (int)Math.Round(num3 + ((float)(num4 - headerPadding2.Right) - sizeF.Width) / 2f);
			}
		}
		ContentAlignment headerAlignment2 = HeaderAlignment;
		int num5 = default;
		if (((int)headerAlignment2 == 1 || (int)headerAlignment2 == 2 || (int)headerAlignment2 == 4) ? true : false)
		{
			int top = tabRect.Top;
			headerPadding2 = HeaderPadding;
			num5 = checked(top + headerPadding2.Top);
		}
		else if (((int)headerAlignment2 == 256 || (int)headerAlignment2 == 512 || (int)headerAlignment2 == 1024) ? true : false)
		{
			float num6 = (float)tabRect.Bottom - sizeF.Height;
			headerPadding2 = HeaderPadding;
			num5 = checked((int)Math.Round(num6 - (float)headerPadding2.Bottom));
		}
		else if (((int)headerAlignment2 == 32 || (int)headerAlignment2 == 16 || (int)headerAlignment2 == 64) ? true : false)
		{
			float num7 = tabRect.Top;
			int height = tabRect.Height;
			headerPadding2 = HeaderPadding;
			num5 = checked((int)Math.Round(num7 + ((float)(height - headerPadding2.Top) - sizeF.Height) / 2f));
		}
		if (((TabControl)this).SelectedIndex == TabPageIndex)
		{
			g.DrawString(text, HeaderFont, (Brush)(object)HeaderSelectedForeBrush, (float)num, (float)num5);
		}
		else
		{
			g.DrawString(text, HeaderFont, (Brush)(object)HeaderForeBrush, (float)num, (float)num5);
		}
	}
}
