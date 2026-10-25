using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

public class ClsCapture
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("dad")]
	private Form _dad;

	[AccessedThroughProperty("dd")]
	private Control _dd;

	[AccessedThroughProperty("Btn_exit")]
	private Button _Btn_exit;

	[AccessedThroughProperty("Btn_Min")]
	private Button _Btn_Min;

	private bool bCaptureMe;

	private Point pLocation;

	protected virtual Form dad
	{
		[DebuggerNonUserCode]
		get
		{
			return _dad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			MouseEventHandler val = Form1_MouseUp;
			if (_dad != null)
			{
				((Control)_dad).MouseUp -= val;
			}
			_dad = value;
			if (_dad != null)
			{
				((Control)_dad).MouseUp += val;
			}
		}
	}

	protected virtual Control dd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			MouseEventHandler val = Form1_MouseUp;
			if (_dd != null)
			{
				_dd.MouseUp -= val;
			}
			_dd = value;
			if (_dd != null)
			{
				_dd.MouseUp += val;
			}
		}
	}

	protected virtual Button Btn_exit
	{
		[DebuggerNonUserCode]
		get
		{
			return _Btn_exit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Btn_exit = value;
		}
	}

	protected virtual Button Btn_Min
	{
		[DebuggerNonUserCode]
		get
		{
			return _Btn_Min;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Btn_Min = value;
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

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			bCaptureMe = true;
			pLocation = e.Location;
			NewLateBinding.LateCall(sender, null, "BringToFront", new object[0], null, null, null, IgnoreReturn: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		checked
		{
			try
			{
				if (bCaptureMe)
				{
					if ((dd == null && ((Control)dad).Cursor != Cursors.SizeNESW && ((Control)dad).Cursor != Cursors.SizeNWSE && ((Control)dad).Cursor != Cursors.SizeNS && ((Control)dad).Cursor != Cursors.SizeWE) ? true : false)
					{
						Form val = dad;
						Point location = new Point(dad.Location.X - pLocation.X + e.X, dad.Location.Y - pLocation.Y + e.Y);
						val.Location = location;
					}
					else if ((dd.Cursor != Cursors.SizeNESW && dd.Cursor != Cursors.SizeNWSE && dd.Cursor != Cursors.SizeNS && dd.Cursor != Cursors.SizeWE) ? true : false)
					{
						Control val2 = dd;
						Point location2 = new Point(dd.Location.X - pLocation.X + e.X, dd.Location.Y - pLocation.Y + e.Y);
						val2.Location = location2;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		try
		{
			bCaptureMe = false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public ClsCapture(Form Frm, bool MakeRound)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		__ENCAddToList(this);
		Btn_exit = new Button();
		Btn_Min = new Button();
		pLocation = default;
		dad = Frm;
		if (MakeRound)
		{
			RoundShape();
			((Control)Btn_exit).Click += Close_Click;
			((Control)Btn_Min).Click += Min_Click;
		}
		((Control)dad).MouseDown += Form1_MouseDown;
		((Control)dad).MouseUp += Form1_MouseUp;
		((Control)dad).MouseMove += Form1_MouseMove;
	}

	public ClsCapture(Control pnl)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		__ENCAddToList(this);
		Btn_exit = new Button();
		Btn_Min = new Button();
		pLocation = default;
		dd = pnl;
		dd.MouseDown += Form1_MouseDown;
		dd.MouseUp += Form1_MouseUp;
		dd.MouseMove += Form1_MouseMove;
	}

	public void RoundShape()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		checked
		{
			try
			{
				dad.FormBorderStyle = (FormBorderStyle)0;
				GraphicsPath val = new GraphicsPath();
				val.AddPie(0, 0, 40, 40, 180f, 90f);
				val.AddPie(((Control)dad).Width - 40, 0, 40, 40, 270f, 90f);
				val.AddPie(0, ((Control)dad).Height - 40, 40, 40, 90f, 90f);
				val.AddPie(((Control)dad).Width - 40, ((Control)dad).Height - 40, 40, 40, 0f, 90f);
				Rectangle rectangle = new Rectangle(20, 0, ((Control)dad).Width - 40, ((Control)dad).Height);
				val.AddRectangle(rectangle);
				rectangle = new Rectangle(0, 20, 20, ((Control)dad).Height - 40);
				val.AddRectangle(rectangle);
				rectangle = new Rectangle(((Control)dad).Width - 20, 20, 20, ((Control)dad).Height - 40);
				val.AddRectangle(rectangle);
				((Control)dad).Region = new Region(val);
				((Control)Btn_exit).Cursor = Cursors.Hand;
				((ButtonBase)Btn_exit).FlatAppearance.BorderSize = 0;
				((ButtonBase)Btn_exit).FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
				((ButtonBase)Btn_exit).FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
				((ButtonBase)Btn_exit).FlatStyle = (FlatStyle)0;
				Button btn_exit = Btn_exit;
				Point location = new Point(((Control)dad).Width - 18, 0);
				((Control)btn_exit).Location = location;
				((Control)Btn_exit).Name = "BtnClose";
				Button btn_exit2 = Btn_exit;
				Size size = new Size(18, 21);
				((Control)btn_exit2).Size = size;
				((Control)Btn_exit).TabIndex = 6;
				((ButtonBase)Btn_exit).Text = "X";
				((ButtonBase)Btn_exit).UseVisualStyleBackColor = true;
				((Control)Btn_exit).BringToFront();
				((Control)Btn_Min).Cursor = Cursors.Hand;
				((ButtonBase)Btn_Min).FlatAppearance.BorderSize = 0;
				((ButtonBase)Btn_Min).FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
				((ButtonBase)Btn_Min).FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
				((ButtonBase)Btn_Min).FlatStyle = (FlatStyle)0;
				Button btn_Min = Btn_Min;
				location = new Point(((Control)dad).Width - 36, 0);
				((Control)btn_Min).Location = location;
				((Control)Btn_Min).Name = "BtnClose";
				Button btn_Min2 = Btn_Min;
				size = new Size(18, 21);
				((Control)btn_Min2).Size = size;
				((Control)Btn_Min).TabIndex = 6;
				((ButtonBase)Btn_Min).Text = "_";
				((ButtonBase)Btn_Min).UseVisualStyleBackColor = true;
				((Control)Btn_Min).BringToFront();
				((Control)dad).Controls.Add((Control)(object)Btn_exit);
				((Control)dad).Controls.Add((Control)(object)Btn_Min);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Close_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((Control)(Button)sender).FindForm().Close();
	}

	private void Min_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((Control)(Button)sender).FindForm().WindowState = (FormWindowState)1;
	}

	public static void CaptureAllCtrls(Control fr)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		foreach (Control control in fr.Controls)
		{
			Control val = control;
			if (val is Panel)
			{
				CaptureAllCtrls(val);
			}
			else
			{
				CaptureMe(val);
			}
		}
	}

	public static void CaptureMe(Form frm, bool MakeMeRound = false)
	{
		ClsCapture clsCapture = new ClsCapture(frm, MakeMeRound);
	}

	public static void CaptureMe(Control pnl)
	{
		ClsCapture clsCapture = new ClsCapture(pnl);
	}
}
