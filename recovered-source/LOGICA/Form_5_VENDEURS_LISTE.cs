using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_5_VENDEURS_LISTE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_vendeur20")]
	private Button _Button_vendeur20;

	[AccessedThroughProperty("Button_vendeur19")]
	private Button _Button_vendeur19;

	[AccessedThroughProperty("Button_vendeur18")]
	private Button _Button_vendeur18;

	[AccessedThroughProperty("Button_vendeur17")]
	private Button _Button_vendeur17;

	[AccessedThroughProperty("Button_vendeur16")]
	private Button _Button_vendeur16;

	[AccessedThroughProperty("Button_vendeur15")]
	private Button _Button_vendeur15;

	[AccessedThroughProperty("Button_vendeur14")]
	private Button _Button_vendeur14;

	[AccessedThroughProperty("Button_vendeur13")]
	private Button _Button_vendeur13;

	[AccessedThroughProperty("Button_vendeur12")]
	private Button _Button_vendeur12;

	[AccessedThroughProperty("Button_vendeur11")]
	private Button _Button_vendeur11;

	[AccessedThroughProperty("Button_vendeur10")]
	private Button _Button_vendeur10;

	[AccessedThroughProperty("Button_vendeur9")]
	private Button _Button_vendeur9;

	[AccessedThroughProperty("Button_vendeur8")]
	private Button _Button_vendeur8;

	[AccessedThroughProperty("Button_vendeur7")]
	private Button _Button_vendeur7;

	[AccessedThroughProperty("Button_vendeur6")]
	private Button _Button_vendeur6;

	[AccessedThroughProperty("Button_vendeur5")]
	private Button _Button_vendeur5;

	[AccessedThroughProperty("Button_vendeur4")]
	private Button _Button_vendeur4;

	[AccessedThroughProperty("Button_vendeur3")]
	private Button _Button_vendeur3;

	[AccessedThroughProperty("Button_vendeur2")]
	private Button _Button_vendeur2;

	[AccessedThroughProperty("Button_vendeur1")]
	private Button _Button_vendeur1;

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

	internal virtual Button Button_vendeur20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur20 != null)
			{
				((Control)_Button_vendeur20).Click -= eventHandler;
			}
			_Button_vendeur20 = value;
			if (_Button_vendeur20 != null)
			{
				((Control)_Button_vendeur20).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur19 != null)
			{
				((Control)_Button_vendeur19).Click -= eventHandler;
			}
			_Button_vendeur19 = value;
			if (_Button_vendeur19 != null)
			{
				((Control)_Button_vendeur19).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur18 != null)
			{
				((Control)_Button_vendeur18).Click -= eventHandler;
			}
			_Button_vendeur18 = value;
			if (_Button_vendeur18 != null)
			{
				((Control)_Button_vendeur18).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur17 != null)
			{
				((Control)_Button_vendeur17).Click -= eventHandler;
			}
			_Button_vendeur17 = value;
			if (_Button_vendeur17 != null)
			{
				((Control)_Button_vendeur17).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur16 != null)
			{
				((Control)_Button_vendeur16).Click -= eventHandler;
			}
			_Button_vendeur16 = value;
			if (_Button_vendeur16 != null)
			{
				((Control)_Button_vendeur16).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur15 != null)
			{
				((Control)_Button_vendeur15).Click -= eventHandler;
			}
			_Button_vendeur15 = value;
			if (_Button_vendeur15 != null)
			{
				((Control)_Button_vendeur15).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur14 != null)
			{
				((Control)_Button_vendeur14).Click -= eventHandler;
			}
			_Button_vendeur14 = value;
			if (_Button_vendeur14 != null)
			{
				((Control)_Button_vendeur14).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur13 != null)
			{
				((Control)_Button_vendeur13).Click -= eventHandler;
			}
			_Button_vendeur13 = value;
			if (_Button_vendeur13 != null)
			{
				((Control)_Button_vendeur13).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur12 != null)
			{
				((Control)_Button_vendeur12).Click -= eventHandler;
			}
			_Button_vendeur12 = value;
			if (_Button_vendeur12 != null)
			{
				((Control)_Button_vendeur12).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur11 != null)
			{
				((Control)_Button_vendeur11).Click -= eventHandler;
			}
			_Button_vendeur11 = value;
			if (_Button_vendeur11 != null)
			{
				((Control)_Button_vendeur11).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur10 != null)
			{
				((Control)_Button_vendeur10).Click -= eventHandler;
			}
			_Button_vendeur10 = value;
			if (_Button_vendeur10 != null)
			{
				((Control)_Button_vendeur10).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur9 != null)
			{
				((Control)_Button_vendeur9).Click -= eventHandler;
			}
			_Button_vendeur9 = value;
			if (_Button_vendeur9 != null)
			{
				((Control)_Button_vendeur9).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur8 != null)
			{
				((Control)_Button_vendeur8).Click -= eventHandler;
			}
			_Button_vendeur8 = value;
			if (_Button_vendeur8 != null)
			{
				((Control)_Button_vendeur8).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur7 != null)
			{
				((Control)_Button_vendeur7).Click -= eventHandler;
			}
			_Button_vendeur7 = value;
			if (_Button_vendeur7 != null)
			{
				((Control)_Button_vendeur7).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur6 != null)
			{
				((Control)_Button_vendeur6).Click -= eventHandler;
			}
			_Button_vendeur6 = value;
			if (_Button_vendeur6 != null)
			{
				((Control)_Button_vendeur6).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur5 != null)
			{
				((Control)_Button_vendeur5).Click -= eventHandler;
			}
			_Button_vendeur5 = value;
			if (_Button_vendeur5 != null)
			{
				((Control)_Button_vendeur5).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur4 != null)
			{
				((Control)_Button_vendeur4).Click -= eventHandler;
			}
			_Button_vendeur4 = value;
			if (_Button_vendeur4 != null)
			{
				((Control)_Button_vendeur4).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur3 != null)
			{
				((Control)_Button_vendeur3).Click -= eventHandler;
			}
			_Button_vendeur3 = value;
			if (_Button_vendeur3 != null)
			{
				((Control)_Button_vendeur3).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur2 != null)
			{
				((Control)_Button_vendeur2).Click -= eventHandler;
			}
			_Button_vendeur2 = value;
			if (_Button_vendeur2 != null)
			{
				((Control)_Button_vendeur2).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_vendeur1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_vendeur1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_vendeurs_Click;
			if (_Button_vendeur1 != null)
			{
				((Control)_Button_vendeur1).Click -= eventHandler;
			}
			_Button_vendeur1 = value;
			if (_Button_vendeur1 != null)
			{
				((Control)_Button_vendeur1).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public Form_5_VENDEURS_LISTE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Load += Form_5_VENDEURS_LISTE_Load;
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected Obj, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected Obj, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected Obj, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected Obj, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected Obj, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected Obj, but got Unknown
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected Obj, but got Unknown
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected Obj, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected Obj, but got Unknown
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected Obj, but got Unknown
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Expected Obj, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected Obj, but got Unknown
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_1013: Expected Obj, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected Obj, but got Unknown
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected Obj, but got Unknown
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Expected Obj, but got Unknown
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Expected Obj, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected Obj, but got Unknown
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected Obj, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected Obj, but got Unknown
		//IL_15d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_VENDEURS_LISTE));
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button_vendeur20 = new Button();
		Button_vendeur19 = new Button();
		Button_vendeur18 = new Button();
		Button_vendeur17 = new Button();
		Button_vendeur16 = new Button();
		Button_vendeur15 = new Button();
		Button_vendeur14 = new Button();
		Button_vendeur13 = new Button();
		Button_vendeur12 = new Button();
		Button_vendeur11 = new Button();
		Button_vendeur10 = new Button();
		Button_vendeur9 = new Button();
		Button_vendeur8 = new Button();
		Button_vendeur7 = new Button();
		Button_vendeur6 = new Button();
		Button_vendeur5 = new Button();
		Button_vendeur4 = new Button();
		Button_vendeur3 = new Button();
		Button_vendeur2 = new Button();
		Button_vendeur1 = new Button();
		((Control)this).SuspendLayout();
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		Point location = new Point(4, 668);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		Size size = new Size(642, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1040;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 0);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 672);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1039;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(646, 0);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 672);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1038;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(4, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(642, 30);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 1041;
		Label_TOP.Text = "VENDEURS";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((Control)Button_vendeur20).Cursor = Cursors.Hand;
		((Control)Button_vendeur20).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur20).ImageAlign = (ContentAlignment)16;
		Button button_vendeur = Button_vendeur20;
		location = new Point(485, 596);
		((Control)button_vendeur).Location = location;
		((Control)Button_vendeur20).Name = "Button_vendeur20";
		Button button_vendeur2 = Button_vendeur20;
		size = new Size(143, 34);
		((Control)button_vendeur2).Size = size;
		((Control)Button_vendeur20).TabIndex = 1062;
		((ButtonBase)Button_vendeur20).UseVisualStyleBackColor = true;
		((Control)Button_vendeur20).Visible = false;
		((Control)Button_vendeur19).Cursor = Cursors.Hand;
		((Control)Button_vendeur19).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur19).ImageAlign = (ContentAlignment)16;
		Button button_vendeur3 = Button_vendeur19;
		location = new Point(485, 562);
		((Control)button_vendeur3).Location = location;
		((Control)Button_vendeur19).Name = "Button_vendeur19";
		Button button_vendeur4 = Button_vendeur19;
		size = new Size(143, 34);
		((Control)button_vendeur4).Size = size;
		((Control)Button_vendeur19).TabIndex = 1061;
		((ButtonBase)Button_vendeur19).UseVisualStyleBackColor = true;
		((Control)Button_vendeur19).Visible = false;
		((Control)Button_vendeur18).Cursor = Cursors.Hand;
		((Control)Button_vendeur18).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur18).ImageAlign = (ContentAlignment)16;
		Button button_vendeur5 = Button_vendeur18;
		location = new Point(485, 528);
		((Control)button_vendeur5).Location = location;
		((Control)Button_vendeur18).Name = "Button_vendeur18";
		Button button_vendeur6 = Button_vendeur18;
		size = new Size(143, 34);
		((Control)button_vendeur6).Size = size;
		((Control)Button_vendeur18).TabIndex = 1060;
		((ButtonBase)Button_vendeur18).UseVisualStyleBackColor = true;
		((Control)Button_vendeur18).Visible = false;
		((Control)Button_vendeur17).Cursor = Cursors.Hand;
		((Control)Button_vendeur17).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur17).ImageAlign = (ContentAlignment)16;
		Button button_vendeur7 = Button_vendeur17;
		location = new Point(485, 494);
		((Control)button_vendeur7).Location = location;
		((Control)Button_vendeur17).Name = "Button_vendeur17";
		Button button_vendeur8 = Button_vendeur17;
		size = new Size(143, 34);
		((Control)button_vendeur8).Size = size;
		((Control)Button_vendeur17).TabIndex = 1059;
		((ButtonBase)Button_vendeur17).UseVisualStyleBackColor = true;
		((Control)Button_vendeur17).Visible = false;
		((Control)Button_vendeur16).Cursor = Cursors.Hand;
		((Control)Button_vendeur16).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur16).ImageAlign = (ContentAlignment)16;
		Button button_vendeur9 = Button_vendeur16;
		location = new Point(485, 460);
		((Control)button_vendeur9).Location = location;
		((Control)Button_vendeur16).Name = "Button_vendeur16";
		Button button_vendeur10 = Button_vendeur16;
		size = new Size(143, 34);
		((Control)button_vendeur10).Size = size;
		((Control)Button_vendeur16).TabIndex = 1058;
		((ButtonBase)Button_vendeur16).UseVisualStyleBackColor = true;
		((Control)Button_vendeur16).Visible = false;
		((Control)Button_vendeur15).Cursor = Cursors.Hand;
		((Control)Button_vendeur15).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur15).ImageAlign = (ContentAlignment)16;
		Button button_vendeur11 = Button_vendeur15;
		location = new Point(485, 426);
		((Control)button_vendeur11).Location = location;
		((Control)Button_vendeur15).Name = "Button_vendeur15";
		Button button_vendeur12 = Button_vendeur15;
		size = new Size(143, 34);
		((Control)button_vendeur12).Size = size;
		((Control)Button_vendeur15).TabIndex = 1057;
		((ButtonBase)Button_vendeur15).UseVisualStyleBackColor = true;
		((Control)Button_vendeur15).Visible = false;
		((Control)Button_vendeur14).Cursor = Cursors.Hand;
		((Control)Button_vendeur14).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur14).ImageAlign = (ContentAlignment)16;
		Button button_vendeur13 = Button_vendeur14;
		location = new Point(485, 392);
		((Control)button_vendeur13).Location = location;
		((Control)Button_vendeur14).Name = "Button_vendeur14";
		Button button_vendeur14 = Button_vendeur14;
		size = new Size(143, 34);
		((Control)button_vendeur14).Size = size;
		((Control)Button_vendeur14).TabIndex = 1056;
		((ButtonBase)Button_vendeur14).UseVisualStyleBackColor = true;
		((Control)Button_vendeur14).Visible = false;
		((Control)Button_vendeur13).Cursor = Cursors.Hand;
		((Control)Button_vendeur13).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_vendeur13).ImageAlign = (ContentAlignment)16;
		Button button_vendeur15 = Button_vendeur13;
		location = new Point(485, 358);
		((Control)button_vendeur15).Location = location;
		((Control)Button_vendeur13).Name = "Button_vendeur13";
		Button button_vendeur16 = Button_vendeur13;
		size = new Size(143, 34);
		((Control)button_vendeur16).Size = size;
		((Control)Button_vendeur13).TabIndex = 1055;
		((ButtonBase)Button_vendeur13).UseVisualStyleBackColor = true;
		((Control)Button_vendeur13).Visible = false;
		((Control)Button_vendeur12).Cursor = Cursors.Hand;
		((Control)Button_vendeur12).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur12).Image = (Image)componentResourceManager.GetObject("Button_vendeur12.Image");
		((ButtonBase)Button_vendeur12).ImageAlign = (ContentAlignment)16;
		Button button_vendeur17 = Button_vendeur12;
		location = new Point(195, 581);
		((Control)button_vendeur17).Location = location;
		((Control)Button_vendeur12).Name = "Button_vendeur12";
		Button button_vendeur18 = Button_vendeur12;
		size = new Size(261, 49);
		((Control)button_vendeur18).Size = size;
		((Control)Button_vendeur12).TabIndex = 1054;
		((ButtonBase)Button_vendeur12).UseVisualStyleBackColor = true;
		((Control)Button_vendeur12).Visible = false;
		((Control)Button_vendeur11).Cursor = Cursors.Hand;
		((Control)Button_vendeur11).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur11).Image = (Image)componentResourceManager.GetObject("Button_vendeur11.Image");
		((ButtonBase)Button_vendeur11).ImageAlign = (ContentAlignment)16;
		Button button_vendeur19 = Button_vendeur11;
		location = new Point(195, 532);
		((Control)button_vendeur19).Location = location;
		((Control)Button_vendeur11).Name = "Button_vendeur11";
		Button button_vendeur20 = Button_vendeur11;
		size = new Size(261, 49);
		((Control)button_vendeur20).Size = size;
		((Control)Button_vendeur11).TabIndex = 1053;
		((ButtonBase)Button_vendeur11).UseVisualStyleBackColor = true;
		((Control)Button_vendeur11).Visible = false;
		((Control)Button_vendeur10).Cursor = Cursors.Hand;
		((Control)Button_vendeur10).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur10).Image = (Image)componentResourceManager.GetObject("Button_vendeur10.Image");
		((ButtonBase)Button_vendeur10).ImageAlign = (ContentAlignment)16;
		Button button_vendeur21 = Button_vendeur10;
		location = new Point(195, 483);
		((Control)button_vendeur21).Location = location;
		((Control)Button_vendeur10).Name = "Button_vendeur10";
		Button button_vendeur22 = Button_vendeur10;
		size = new Size(261, 49);
		((Control)button_vendeur22).Size = size;
		((Control)Button_vendeur10).TabIndex = 1052;
		((ButtonBase)Button_vendeur10).UseVisualStyleBackColor = true;
		((Control)Button_vendeur10).Visible = false;
		((Control)Button_vendeur9).Cursor = Cursors.Hand;
		((Control)Button_vendeur9).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur9).Image = (Image)componentResourceManager.GetObject("Button_vendeur9.Image");
		((ButtonBase)Button_vendeur9).ImageAlign = (ContentAlignment)16;
		Button button_vendeur23 = Button_vendeur9;
		location = new Point(195, 434);
		((Control)button_vendeur23).Location = location;
		((Control)Button_vendeur9).Name = "Button_vendeur9";
		Button button_vendeur24 = Button_vendeur9;
		size = new Size(261, 49);
		((Control)button_vendeur24).Size = size;
		((Control)Button_vendeur9).TabIndex = 1051;
		((ButtonBase)Button_vendeur9).UseVisualStyleBackColor = true;
		((Control)Button_vendeur9).Visible = false;
		((Control)Button_vendeur8).Cursor = Cursors.Hand;
		((Control)Button_vendeur8).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur8).Image = (Image)componentResourceManager.GetObject("Button_vendeur8.Image");
		((ButtonBase)Button_vendeur8).ImageAlign = (ContentAlignment)16;
		Button button_vendeur25 = Button_vendeur8;
		location = new Point(195, 385);
		((Control)button_vendeur25).Location = location;
		((Control)Button_vendeur8).Name = "Button_vendeur8";
		Button button_vendeur26 = Button_vendeur8;
		size = new Size(261, 49);
		((Control)button_vendeur26).Size = size;
		((Control)Button_vendeur8).TabIndex = 1050;
		((ButtonBase)Button_vendeur8).UseVisualStyleBackColor = true;
		((Control)Button_vendeur8).Visible = false;
		((Control)Button_vendeur7).Cursor = Cursors.Hand;
		((Control)Button_vendeur7).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur7).Image = (Image)componentResourceManager.GetObject("Button_vendeur7.Image");
		((ButtonBase)Button_vendeur7).ImageAlign = (ContentAlignment)16;
		Button button_vendeur27 = Button_vendeur7;
		location = new Point(195, 336);
		((Control)button_vendeur27).Location = location;
		((Control)Button_vendeur7).Name = "Button_vendeur7";
		Button button_vendeur28 = Button_vendeur7;
		size = new Size(261, 49);
		((Control)button_vendeur28).Size = size;
		((Control)Button_vendeur7).TabIndex = 1049;
		((ButtonBase)Button_vendeur7).UseVisualStyleBackColor = true;
		((Control)Button_vendeur7).Visible = false;
		((Control)Button_vendeur6).Cursor = Cursors.Hand;
		((Control)Button_vendeur6).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur6).Image = (Image)componentResourceManager.GetObject("Button_vendeur6.Image");
		((ButtonBase)Button_vendeur6).ImageAlign = (ContentAlignment)16;
		Button button_vendeur29 = Button_vendeur6;
		location = new Point(195, 287);
		((Control)button_vendeur29).Location = location;
		((Control)Button_vendeur6).Name = "Button_vendeur6";
		Button button_vendeur30 = Button_vendeur6;
		size = new Size(261, 49);
		((Control)button_vendeur30).Size = size;
		((Control)Button_vendeur6).TabIndex = 1048;
		((ButtonBase)Button_vendeur6).UseVisualStyleBackColor = true;
		((Control)Button_vendeur6).Visible = false;
		((Control)Button_vendeur5).Cursor = Cursors.Hand;
		((Control)Button_vendeur5).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur5).Image = (Image)componentResourceManager.GetObject("Button_vendeur5.Image");
		((ButtonBase)Button_vendeur5).ImageAlign = (ContentAlignment)16;
		Button button_vendeur31 = Button_vendeur5;
		location = new Point(195, 238);
		((Control)button_vendeur31).Location = location;
		((Control)Button_vendeur5).Name = "Button_vendeur5";
		Button button_vendeur32 = Button_vendeur5;
		size = new Size(261, 49);
		((Control)button_vendeur32).Size = size;
		((Control)Button_vendeur5).TabIndex = 1047;
		((ButtonBase)Button_vendeur5).UseVisualStyleBackColor = true;
		((Control)Button_vendeur5).Visible = false;
		((Control)Button_vendeur4).Cursor = Cursors.Hand;
		((Control)Button_vendeur4).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur4).Image = (Image)componentResourceManager.GetObject("Button_vendeur4.Image");
		((ButtonBase)Button_vendeur4).ImageAlign = (ContentAlignment)16;
		Button button_vendeur33 = Button_vendeur4;
		location = new Point(195, 189);
		((Control)button_vendeur33).Location = location;
		((Control)Button_vendeur4).Name = "Button_vendeur4";
		Button button_vendeur34 = Button_vendeur4;
		size = new Size(261, 49);
		((Control)button_vendeur34).Size = size;
		((Control)Button_vendeur4).TabIndex = 1046;
		((ButtonBase)Button_vendeur4).UseVisualStyleBackColor = true;
		((Control)Button_vendeur4).Visible = false;
		((Control)Button_vendeur3).Cursor = Cursors.Hand;
		((Control)Button_vendeur3).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur3).Image = (Image)componentResourceManager.GetObject("Button_vendeur3.Image");
		((ButtonBase)Button_vendeur3).ImageAlign = (ContentAlignment)16;
		Button button_vendeur35 = Button_vendeur3;
		location = new Point(195, 140);
		((Control)button_vendeur35).Location = location;
		((Control)Button_vendeur3).Name = "Button_vendeur3";
		Button button_vendeur36 = Button_vendeur3;
		size = new Size(261, 49);
		((Control)button_vendeur36).Size = size;
		((Control)Button_vendeur3).TabIndex = 1045;
		((ButtonBase)Button_vendeur3).UseVisualStyleBackColor = true;
		((Control)Button_vendeur3).Visible = false;
		((Control)Button_vendeur2).Cursor = Cursors.Hand;
		((Control)Button_vendeur2).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur2).Image = (Image)componentResourceManager.GetObject("Button_vendeur2.Image");
		((ButtonBase)Button_vendeur2).ImageAlign = (ContentAlignment)16;
		Button button_vendeur37 = Button_vendeur2;
		location = new Point(195, 91);
		((Control)button_vendeur37).Location = location;
		((Control)Button_vendeur2).Name = "Button_vendeur2";
		Button button_vendeur38 = Button_vendeur2;
		size = new Size(261, 49);
		((Control)button_vendeur38).Size = size;
		((Control)Button_vendeur2).TabIndex = 1044;
		((ButtonBase)Button_vendeur2).UseVisualStyleBackColor = true;
		((Control)Button_vendeur2).Visible = false;
		((Control)Button_vendeur1).Cursor = Cursors.Hand;
		((Control)Button_vendeur1).Font = new Font("Segoe UI", 15.75f, (FontStyle)1);
		((ButtonBase)Button_vendeur1).Image = (Image)componentResourceManager.GetObject("Button_vendeur1.Image");
		((ButtonBase)Button_vendeur1).ImageAlign = (ContentAlignment)16;
		Button button_vendeur39 = Button_vendeur1;
		location = new Point(195, 42);
		((Control)button_vendeur39).Location = location;
		((Control)Button_vendeur1).Name = "Button_vendeur1";
		Button button_vendeur40 = Button_vendeur1;
		size = new Size(261, 49);
		((Control)button_vendeur40).Size = size;
		((Control)Button_vendeur1).TabIndex = 1043;
		((ButtonBase)Button_vendeur1).UseVisualStyleBackColor = true;
		((Control)Button_vendeur1).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(650, 672);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_vendeur20);
		((Control)this).Controls.Add((Control)(object)Button_vendeur19);
		((Control)this).Controls.Add((Control)(object)Button_vendeur18);
		((Control)this).Controls.Add((Control)(object)Button_vendeur17);
		((Control)this).Controls.Add((Control)(object)Button_vendeur16);
		((Control)this).Controls.Add((Control)(object)Button_vendeur15);
		((Control)this).Controls.Add((Control)(object)Button_vendeur14);
		((Control)this).Controls.Add((Control)(object)Button_vendeur13);
		((Control)this).Controls.Add((Control)(object)Button_vendeur12);
		((Control)this).Controls.Add((Control)(object)Button_vendeur11);
		((Control)this).Controls.Add((Control)(object)Button_vendeur10);
		((Control)this).Controls.Add((Control)(object)Button_vendeur9);
		((Control)this).Controls.Add((Control)(object)Button_vendeur8);
		((Control)this).Controls.Add((Control)(object)Button_vendeur7);
		((Control)this).Controls.Add((Control)(object)Button_vendeur6);
		((Control)this).Controls.Add((Control)(object)Button_vendeur5);
		((Control)this).Controls.Add((Control)(object)Button_vendeur4);
		((Control)this).Controls.Add((Control)(object)Button_vendeur3);
		((Control)this).Controls.Add((Control)(object)Button_vendeur2);
		((Control)this).Controls.Add((Control)(object)Button_vendeur1);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_5_VENDEURS_LISTE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).ResumeLayout(false);
	}

	private void me_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void Form_5_VENDEURS_LISTE_Load(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		checked
		{
			int num = MyProject.Forms.Form_3_VENTE.ListBox_VENDEURS.Items.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Button val = (Button)((Control)this).Controls["Button_vendeur" + Conversions.ToString(num2 + 1)];
					((Control)val).Visible = true;
					((ButtonBase)val).Text = MyProject.Forms.Form_3_VENTE.ListBox_VENDEURS.Items[num2].ToString();
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button_vendeurs_Click(object sender, EventArgs e)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		if (Module1.dt1.Rows.Count == 0)
		{
			((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_VENDEUR).Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null));
		}
		else
		{
			Module1.dt1.Rows[0]["Vendeur"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null));
			MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
			((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
			Module1.dt1.AcceptChanges();
			((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_VENDEUR).Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null));
		}
		((Form)this).Close();
	}
}
