using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

public class MBColor
{
	public enum MB_Color
	{
		RED,
		GREEN,
		BLUE,
		NONE
	}

	private uint _ac;

	private int _rc;

	private int _gc;

	private int _bc;

	private int _hc;

	private int _sc;

	private int _vc;

	private int maxval;

	private int minval;

	private MB_Color CompMax;

	private MB_Color CompMain;

	public uint AC
	{
		get
		{
			return _ac;
		}
		set
		{
			Math.Min(value, 255L);
		}
	}

	public int RC
	{
		get
		{
			return _rc;
		}
		set
		{
			_rc = Math.Min(value, 255);
		}
	}

	public int GC
	{
		get
		{
			return _gc;
		}
		set
		{
			_gc = Math.Min(value, 255);
		}
	}

	public int BC
	{
		get
		{
			return _bc;
		}
		set
		{
			_bc = Math.Min(value, 255);
		}
	}

	public float HC
	{
		get
		{
			return _hc;
		}
		set
		{
			checked
			{
				_hc = (int)Math.Round(Math.Min(value, 310f));
				_hc = (int)Math.Round(Math.Max(HC, 0f));
			}
		}
	}

	public float SC
	{
		get
		{
			return _sc;
		}
		set
		{
			checked
			{
				_sc = (int)Math.Round(Math.Min(value, 100f));
				_sc = (int)Math.Round(Math.Max(SC, 0f));
			}
		}
	}

	public float VC
	{
		get
		{
			return _vc;
		}
		set
		{
			checked
			{
				_vc = (int)Math.Round(Math.Min(value, 100f));
				_vc = (int)Math.Round(Math.Max(VC, 0f));
			}
		}
	}

	public MBColor(Color color)
	{
		_ac = 0u;
		_rc = 0;
		_gc = 0;
		_bc = 0;
		_hc = 0;
		_sc = 0;
		_vc = 0;
		maxval = 0;
		minval = 0;
		_rc = color.R;
		_gc = color.G;
		_bc = color.B;
		_ac = color.A;
		HSV();
	}

	public MBColor(uint a, int r, int g, int b)
	{
		_ac = 0u;
		_rc = 0;
		_gc = 0;
		_bc = 0;
		_hc = 0;
		_sc = 0;
		_vc = 0;
		maxval = 0;
		minval = 0;
		_hc = r;
		_gc = g;
		_vc = b;
		_ac = a;
		GetColor();
	}

	public Color GetColor()
	{
		double num = (float)_hc / 100f;
		double num2 = (float)_sc / 100f;
		double num3 = (float)_vc / 100f;
		if (_sc == 0)
		{
			int num4 = checked((int)Math.Round(255.0 * num3));
			_rc = 0 - ((0 - ((_gc == _bc) ? 1 : 0) == num4) ? 1 : 0);
			return Color.FromArgb(_rc, _gc, _bc);
		}
		checked
		{
			int num5 = (int)Math.Round(255.0 * (1.0 - num2) * num3);
			float num6 = (float)_hc / 60f;
			if (num6 == 0f)
			{
				RC = (int)Math.Round(255.0 * num3);
				GC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(HC / 60f) + (double)num5);
				BC = num5;
			}
			else if (num6 == 1f)
			{
				RC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(1f - HC % 60f / 60f) + (double)num5);
				GC = (int)Math.Round(255.0 * num3);
				BC = num5;
			}
			else if (num6 == 2f)
			{
				RC = num5;
				GC = (int)Math.Round(255.0 * num3);
				BC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(HC % 60f / 60f) + (double)num5);
			}
			else if (num6 == 3f)
			{
				RC = num5;
				GC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(1f - HC % 60f / 60f) + (double)num5);
				BC = (int)Math.Round(255.0 * num3);
			}
			else if (num6 == 4f)
			{
				RC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(HC % 60f / 60f) + (double)num5);
				GC = num5;
				BC = (int)Math.Round(255.0 * num3);
			}
			else if (num6 == 5f)
			{
				RC = (int)Math.Round(255.0 * num3);
				GC = num5;
				BC = (int)Math.Round((255.0 * num3 - (double)num5) * (double)(1f - HC % 60f / 60f) + (double)num5);
			}
			return Color.FromArgb((int)_ac, _rc, _gc, _bc);
		}
	}

	private void HSV()
	{
		_hc = GetHue();
		_sc = Conversions.ToInteger(GetSaturation());
		_vc = Conversions.ToInteger(GetBrightness());
	}

	public void ColorMax()
	{
		if (_rc > _gc)
		{
			if (_rc < _bc)
			{
				maxval = _bc;
				CompMax = MB_Color.BLUE;
			}
			else
			{
				maxval = _rc;
				CompMax = MB_Color.RED;
			}
		}
		else if (_gc < _bc)
		{
			maxval = _bc;
			CompMax = MB_Color.BLUE;
		}
		else
		{
			maxval = _gc;
			CompMax = MB_Color.GREEN;
		}
	}

	public void ColorMin()
	{
		if (_rc < _gc)
		{
			if (_rc > _bc)
			{
				maxval = _bc;
				CompMax = MB_Color.BLUE;
			}
			else
			{
				maxval = _rc;
				CompMax = MB_Color.RED;
			}
		}
		else if (_gc > _bc)
		{
			maxval = _bc;
			CompMax = MB_Color.BLUE;
		}
		else
		{
			maxval = _gc;
			CompMax = MB_Color.GREEN;
		}
	}

	public object GetBrightness()
	{
		ColorMax();
		return (double)checked(100 * maxval) / 255.0;
	}

	public object GetSaturation()
	{
		ColorMax();
		ColorMin();
		if (CompMax == MB_Color.NONE)
		{
			return 0;
		}
		if (maxval != minval)
		{
			double value = Convert.ToDouble(decimal.Divide(new decimal(minval), new decimal(maxval)));
			value = Convert.ToDouble(decimal.Subtract(1m, new decimal(value)));
			value = Convert.ToDouble(decimal.Multiply(new decimal(value), 100m));
			return Convert.ToUInt16(value);
		}
		return 0;
	}

	public ushort GetHue()
	{
		ColorMax();
		ColorMin();
		if (maxval == minval)
		{
			return 0;
		}
		checked
		{
			if (CompMax == MB_Color.RED)
			{
				if (GC >= BC)
				{
					decimal d = decimal.Divide(new decimal(GC - BC), new decimal(maxval - minval));
					return Convert.ToUInt16(decimal.Multiply(60m, d));
				}
				decimal d2 = decimal.Divide(new decimal(BC - GC), new decimal(maxval - minval));
				d2 = decimal.Multiply(60m, d2);
				return Convert.ToUInt16(decimal.Subtract(360m, d2));
			}
			if (CompMax == MB_Color.GREEN)
			{
				if (BC >= RC)
				{
					decimal d3 = decimal.Divide(new decimal(BC - RC), new decimal(maxval - minval));
					d3 = decimal.Multiply(60m, d3);
					return Convert.ToUInt16(decimal.Add(120m, d3));
				}
				decimal d4 = decimal.Divide(new decimal(RC - BC), new decimal(maxval - minval));
				d4 = decimal.Multiply(60m, d4);
				return Convert.ToUInt16(decimal.Subtract(120m, d4));
			}
			if (CompMax == MB_Color.BLUE)
			{
				if (RC >= GC)
				{
					decimal d5 = decimal.Divide(new decimal(RC - GC), new decimal(maxval - minval));
					d5 = decimal.Multiply(60m, d5);
					return Convert.ToUInt16(decimal.Add(240m, d5));
				}
				decimal d6 = decimal.Divide(new decimal(GC - RC), new decimal(maxval - minval));
				d6 = decimal.Multiply(60m, d6);
				return Convert.ToUInt16(decimal.Subtract(240m, d6));
			}
			return 0;
		}
	}

	public void SetBrightness(int val)
	{
		VC = val;
	}
}
