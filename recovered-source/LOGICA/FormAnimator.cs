using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LOGICA;

public class FormAnimator
{
	public enum AnimationMethod
	{
		Roll = 0,
		Centre = 0x10,
		Slide = 0x40000,
		Blend = 0x80000
	}

	[Flags]
	public enum AnimationDirection
	{
		Right = 1,
		Left = 2,
		Down = 4,
		Up = 8
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private const int AW_HIDE = 65536;

	private const int AW_ACTIVATE = 131072;

	private const int DEFAULT_DURATION = 250;

	[AccessedThroughProperty("_form")]
	private Form __form;

	private AnimationMethod _method;

	private AnimationDirection _direction;

	private int _duration;

	protected virtual Form _form
	{
		[DebuggerNonUserCode]
		get
		{
			return __form;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = Form_Closing;
			EventHandler eventHandler = Form_VisibleChanged;
			EventHandler eventHandler2 = Form_Load;
			if (__form != null)
			{
				__form.Closing -= cancelEventHandler;
				((Control)__form).VisibleChanged -= eventHandler;
				__form.Load -= eventHandler2;
			}
			__form = value;
			if (__form != null)
			{
				__form.Closing += cancelEventHandler;
				((Control)__form).VisibleChanged += eventHandler;
				__form.Load += eventHandler2;
			}
		}
	}

	public AnimationMethod Method
	{
		get
		{
			return _method;
		}
		set
		{
			_method = value;
		}
	}

	public AnimationDirection Direction
	{
		get
		{
			return _direction;
		}
		set
		{
			_direction = value;
		}
	}

	public int Duration
	{
		get
		{
			return _duration;
		}
		set
		{
			_duration = value;
		}
	}

	public Form Form => _form;

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

	[DllImport("user32")]
	private static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

	public FormAnimator(Form form)
	{
		__ENCAddToList(this);
		_form = form;
		_duration = 250;
	}

	public FormAnimator(Form form, AnimationMethod method, int duration)
		: this(form)
	{
		_method = method;
		_duration = duration;
	}

	public FormAnimator(Form form, AnimationMethod method, AnimationDirection direction, int duration)
		: this(form, method, duration)
	{
		_direction = direction;
	}

	private void Form_Load(object sender, EventArgs e)
	{
		if (_form.MdiParent == null || _method != AnimationMethod.Blend)
		{
			AnimateWindow(((Control)_form).Handle, _duration, (int)((AnimationMethod)0x20000 | _method) | (int)_direction);
		}
	}

	private void Form_VisibleChanged(object sender, EventArgs e)
	{
		if (_form.MdiParent == null)
		{
			int num = (int)_method | (int)_direction;
			AnimateWindow(dwFlags: (!((Control)_form).Visible) ? (num | 0x10000) : (num | 0x20000), hWnd: ((Control)_form).Handle, dwTime: _duration);
		}
	}

	private void Form_Closing(object sender, CancelEventArgs e)
	{
		if (!e.Cancel && (_form.MdiParent == null || _method != AnimationMethod.Blend))
		{
			AnimateWindow(((Control)_form).Handle, _duration, (int)((AnimationMethod)0x10000 | _method) | (int)_direction);
		}
	}
}
