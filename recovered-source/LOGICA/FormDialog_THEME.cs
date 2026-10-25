using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_THEME : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Button_BLEU")]
	private Button _Button_BLEU;

	[AccessedThroughProperty("Button_VERT")]
	private Button _Button_VERT;

	[AccessedThroughProperty("Button_ORANGE")]
	private Button _Button_ORANGE;

	[AccessedThroughProperty("Button_MAUVE")]
	private Button _Button_MAUVE;

	[AccessedThroughProperty("Button_JAUNE")]
	private Button _Button_JAUNE;

	[AccessedThroughProperty("Button_VIOLETFONCE")]
	private Button _Button_VIOLETFONCE;

	[AccessedThroughProperty("Button_ROUGE")]
	private Button _Button_ROUGE;

	[AccessedThroughProperty("Button_MARRON")]
	private Button _Button_MARRON;

	[AccessedThroughProperty("Button_VIOLET")]
	private Button _Button_VIOLET;

	[AccessedThroughProperty("Button_NOIR")]
	private Button _Button_NOIR;

	[AccessedThroughProperty("Button_BLEUNUIT")]
	private Button _Button_BLEUNUIT;

	[AccessedThroughProperty("Button_GRIS")]
	private Button _Button_GRIS;

	[AccessedThroughProperty("Button_VERTFONCE")]
	private Button _Button_VERTFONCE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

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

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Button Button_BLEU
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_BLEU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_BLEU != null)
			{
				((Control)_Button_BLEU).Click -= eventHandler;
			}
			_Button_BLEU = value;
			if (_Button_BLEU != null)
			{
				((Control)_Button_BLEU).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_VERT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VERT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_VERT != null)
			{
				((Control)_Button_VERT).Click -= eventHandler;
			}
			_Button_VERT = value;
			if (_Button_VERT != null)
			{
				((Control)_Button_VERT).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ORANGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ORANGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_ORANGE != null)
			{
				((Control)_Button_ORANGE).Click -= eventHandler;
			}
			_Button_ORANGE = value;
			if (_Button_ORANGE != null)
			{
				((Control)_Button_ORANGE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_MAUVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MAUVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_MAUVE != null)
			{
				((Control)_Button_MAUVE).Click -= eventHandler;
			}
			_Button_MAUVE = value;
			if (_Button_MAUVE != null)
			{
				((Control)_Button_MAUVE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_JAUNE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_JAUNE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_JAUNE != null)
			{
				((Control)_Button_JAUNE).Click -= eventHandler;
			}
			_Button_JAUNE = value;
			if (_Button_JAUNE != null)
			{
				((Control)_Button_JAUNE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_VIOLETFONCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VIOLETFONCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_VIOLETFONCE != null)
			{
				((Control)_Button_VIOLETFONCE).Click -= eventHandler;
			}
			_Button_VIOLETFONCE = value;
			if (_Button_VIOLETFONCE != null)
			{
				((Control)_Button_VIOLETFONCE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ROUGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ROUGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_ROUGE != null)
			{
				((Control)_Button_ROUGE).Click -= eventHandler;
			}
			_Button_ROUGE = value;
			if (_Button_ROUGE != null)
			{
				((Control)_Button_ROUGE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_MARRON
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MARRON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_MARRON != null)
			{
				((Control)_Button_MARRON).Click -= eventHandler;
			}
			_Button_MARRON = value;
			if (_Button_MARRON != null)
			{
				((Control)_Button_MARRON).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_VIOLET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VIOLET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_VIOLET != null)
			{
				((Control)_Button_VIOLET).Click -= eventHandler;
			}
			_Button_VIOLET = value;
			if (_Button_VIOLET != null)
			{
				((Control)_Button_VIOLET).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_NOIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_NOIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_NOIR != null)
			{
				((Control)_Button_NOIR).Click -= eventHandler;
			}
			_Button_NOIR = value;
			if (_Button_NOIR != null)
			{
				((Control)_Button_NOIR).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_BLEUNUIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_BLEUNUIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_BLEUNUIT != null)
			{
				((Control)_Button_BLEUNUIT).Click -= eventHandler;
			}
			_Button_BLEUNUIT = value;
			if (_Button_BLEUNUIT != null)
			{
				((Control)_Button_BLEUNUIT).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_GRIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GRIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_GRIS != null)
			{
				((Control)_Button_GRIS).Click -= eventHandler;
			}
			_Button_GRIS = value;
			if (_Button_GRIS != null)
			{
				((Control)_Button_GRIS).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_VERTFONCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VERTFONCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BLEU_Click;
			if (_Button_VERTFONCE != null)
			{
				((Control)_Button_VERTFONCE).Click -= eventHandler;
			}
			_Button_VERTFONCE = value;
			if (_Button_VERTFONCE != null)
			{
				((Control)_Button_VERTFONCE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_SAVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SAVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SAVE_Click;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click -= eventHandler;
			}
			_Button_SAVE = value;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_THEME()
	{
		((Form)this).Load += FormDialog_THEME_Load;
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected Obj, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected Obj, but got Unknown
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected Obj, but got Unknown
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected Obj, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected Obj, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected Obj, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected Obj, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected Obj, but got Unknown
		//IL_114f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Expected Obj, but got Unknown
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186: Expected Obj, but got Unknown
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1469: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_THEME));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Button_BLEU = new Button();
		Button_VERT = new Button();
		Button_ORANGE = new Button();
		Button_MAUVE = new Button();
		Button_JAUNE = new Button();
		Button_VIOLETFONCE = new Button();
		Button_ROUGE = new Button();
		Button_MARRON = new Button();
		Button_VIOLET = new Button();
		Button_NOIR = new Button();
		Button_BLEUNUIT = new Button();
		Button_GRIS = new Button();
		Button_VERTFONCE = new Button();
		Button_SAVE = new Button();
		((Control)this).SuspendLayout();
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		Label label = Label1;
		Point location = new Point(15, 12);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(49, 27);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		((Control)Label2).BackColor = Color.FromArgb(149, 189, 26);
		Label label3 = Label2;
		location = new Point(15, 47);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(49, 27);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1;
		((Control)Label3).BackColor = Color.FromArgb(237, 146, 2);
		Label label5 = Label3;
		location = new Point(15, 82);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(49, 27);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 2;
		((Control)Label4).BackColor = Color.FromArgb(223, 16, 120);
		Label label7 = Label4;
		location = new Point(15, 117);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(49, 27);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 3;
		((Control)Label5).BackColor = Color.FromArgb(255, 218, 19);
		Label label9 = Label5;
		location = new Point(15, 152);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(49, 27);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 4;
		((Control)Label6).BackColor = Color.FromArgb(198, 48, 35);
		Label label11 = Label6;
		location = new Point(15, 292);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(49, 27);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 8;
		((Control)Label7).BackColor = Color.FromArgb(121, 85, 72);
		Label label13 = Label7;
		location = new Point(15, 257);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(49, 27);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 7;
		((Control)Label8).BackColor = Color.FromArgb(156, 39, 176);
		Label label15 = Label8;
		location = new Point(15, 222);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(49, 27);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 6;
		((Control)Label9).BackColor = Color.FromArgb(67, 86, 106);
		Label label17 = Label9;
		location = new Point(15, 187);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(49, 27);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 5;
		((Control)Label10).BackColor = Color.FromArgb(0, 150, 136);
		Label label19 = Label10;
		location = new Point(15, 362);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(49, 27);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 10;
		((Control)Label11).BackColor = Color.FromArgb(103, 58, 183);
		Label label21 = Label11;
		location = new Point(15, 327);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(49, 27);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 9;
		((Control)Label13).BackColor = Color.FromArgb(15, 5, 107);
		Label label23 = Label13;
		location = new Point(15, 432);
		((Control)label23).Location = location;
		((Control)Label13).Name = "Label13";
		Label label24 = Label13;
		size = new Size(49, 27);
		((Control)label24).Size = size;
		((Control)Label13).TabIndex = 12;
		((Control)Label14).BackColor = Color.FromArgb(55, 71, 79);
		Label label25 = Label14;
		location = new Point(15, 397);
		((Control)label25).Location = location;
		((Control)Label14).Name = "Label14";
		Label label26 = Label14;
		size = new Size(49, 27);
		((Control)label26).Size = size;
		((Control)Label14).TabIndex = 11;
		((ButtonBase)Button_BLEU).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_BLEU).FlatStyle = (FlatStyle)0;
		((Control)Button_BLEU).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_BLEU = Button_BLEU;
		location = new Point(12, 9);
		((Control)button_BLEU).Location = location;
		((Control)Button_BLEU).Name = "Button_BLEU";
		Button button_BLEU2 = Button_BLEU;
		size = new Size(257, 33);
		((Control)button_BLEU2).Size = size;
		((Control)Button_BLEU).TabIndex = 13;
		((Control)Button_BLEU).Tag = "22; 106; 238";
		((ButtonBase)Button_BLEU).Text = "BLEU";
		((ButtonBase)Button_BLEU).UseVisualStyleBackColor = true;
		((ButtonBase)Button_VERT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_VERT).FlatStyle = (FlatStyle)0;
		((Control)Button_VERT).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_VERT = Button_VERT;
		location = new Point(12, 44);
		((Control)button_VERT).Location = location;
		((Control)Button_VERT).Name = "Button_VERT";
		Button button_VERT2 = Button_VERT;
		size = new Size(257, 33);
		((Control)button_VERT2).Size = size;
		((Control)Button_VERT).TabIndex = 14;
		((Control)Button_VERT).Tag = "149; 189; 26";
		((ButtonBase)Button_VERT).Text = "VERT";
		((ButtonBase)Button_VERT).UseVisualStyleBackColor = true;
		((ButtonBase)Button_ORANGE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_ORANGE).FlatStyle = (FlatStyle)0;
		((Control)Button_ORANGE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_ORANGE = Button_ORANGE;
		location = new Point(12, 79);
		((Control)button_ORANGE).Location = location;
		((Control)Button_ORANGE).Name = "Button_ORANGE";
		Button button_ORANGE2 = Button_ORANGE;
		size = new Size(257, 33);
		((Control)button_ORANGE2).Size = size;
		((Control)Button_ORANGE).TabIndex = 15;
		((Control)Button_ORANGE).Tag = "237; 146; 2";
		((ButtonBase)Button_ORANGE).Text = "ORANGE";
		((ButtonBase)Button_ORANGE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_MAUVE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_MAUVE).FlatStyle = (FlatStyle)0;
		((Control)Button_MAUVE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_MAUVE = Button_MAUVE;
		location = new Point(12, 114);
		((Control)button_MAUVE).Location = location;
		((Control)Button_MAUVE).Name = "Button_MAUVE";
		Button button_MAUVE2 = Button_MAUVE;
		size = new Size(257, 33);
		((Control)button_MAUVE2).Size = size;
		((Control)Button_MAUVE).TabIndex = 16;
		((Control)Button_MAUVE).Tag = "223; 16; 120";
		((ButtonBase)Button_MAUVE).Text = "MAUVE";
		((ButtonBase)Button_MAUVE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_JAUNE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_JAUNE).FlatStyle = (FlatStyle)0;
		((Control)Button_JAUNE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_JAUNE = Button_JAUNE;
		location = new Point(12, 149);
		((Control)button_JAUNE).Location = location;
		((Control)Button_JAUNE).Name = "Button_JAUNE";
		Button button_JAUNE2 = Button_JAUNE;
		size = new Size(257, 33);
		((Control)button_JAUNE2).Size = size;
		((Control)Button_JAUNE).TabIndex = 17;
		((Control)Button_JAUNE).Tag = "255; 218; 19";
		((ButtonBase)Button_JAUNE).Text = "JAUNE";
		((ButtonBase)Button_JAUNE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_VIOLETFONCE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_VIOLETFONCE).FlatStyle = (FlatStyle)0;
		((Control)Button_VIOLETFONCE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_VIOLETFONCE = Button_VIOLETFONCE;
		location = new Point(12, 324);
		((Control)button_VIOLETFONCE).Location = location;
		((Control)Button_VIOLETFONCE).Name = "Button_VIOLETFONCE";
		Button button_VIOLETFONCE2 = Button_VIOLETFONCE;
		size = new Size(257, 33);
		((Control)button_VIOLETFONCE2).Size = size;
		((Control)Button_VIOLETFONCE).TabIndex = 22;
		((Control)Button_VIOLETFONCE).Tag = "103; 58; 183";
		((ButtonBase)Button_VIOLETFONCE).Text = "VIOLET FONCE";
		((ButtonBase)Button_VIOLETFONCE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_ROUGE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_ROUGE).FlatStyle = (FlatStyle)0;
		((Control)Button_ROUGE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_ROUGE = Button_ROUGE;
		location = new Point(12, 289);
		((Control)button_ROUGE).Location = location;
		((Control)Button_ROUGE).Name = "Button_ROUGE";
		Button button_ROUGE2 = Button_ROUGE;
		size = new Size(257, 33);
		((Control)button_ROUGE2).Size = size;
		((Control)Button_ROUGE).TabIndex = 21;
		((Control)Button_ROUGE).Tag = "198; 48; 35";
		((ButtonBase)Button_ROUGE).Text = "ROUGE";
		((ButtonBase)Button_ROUGE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_MARRON).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_MARRON).FlatStyle = (FlatStyle)0;
		((Control)Button_MARRON).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_MARRON = Button_MARRON;
		location = new Point(12, 254);
		((Control)button_MARRON).Location = location;
		((Control)Button_MARRON).Name = "Button_MARRON";
		Button button_MARRON2 = Button_MARRON;
		size = new Size(257, 33);
		((Control)button_MARRON2).Size = size;
		((Control)Button_MARRON).TabIndex = 20;
		((Control)Button_MARRON).Tag = "121; 85; 72";
		((ButtonBase)Button_MARRON).Text = "MARRON";
		((ButtonBase)Button_MARRON).UseVisualStyleBackColor = true;
		((ButtonBase)Button_VIOLET).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_VIOLET).FlatStyle = (FlatStyle)0;
		((Control)Button_VIOLET).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_VIOLET = Button_VIOLET;
		location = new Point(12, 219);
		((Control)button_VIOLET).Location = location;
		((Control)Button_VIOLET).Name = "Button_VIOLET";
		Button button_VIOLET2 = Button_VIOLET;
		size = new Size(257, 33);
		((Control)button_VIOLET2).Size = size;
		((Control)Button_VIOLET).TabIndex = 19;
		((Control)Button_VIOLET).Tag = "156; 39; 176";
		((ButtonBase)Button_VIOLET).Text = "VIOLET";
		((ButtonBase)Button_VIOLET).UseVisualStyleBackColor = true;
		((ButtonBase)Button_NOIR).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_NOIR).FlatStyle = (FlatStyle)0;
		((Control)Button_NOIR).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_NOIR = Button_NOIR;
		location = new Point(12, 184);
		((Control)button_NOIR).Location = location;
		((Control)Button_NOIR).Name = "Button_NOIR";
		Button button_NOIR2 = Button_NOIR;
		size = new Size(257, 33);
		((Control)button_NOIR2).Size = size;
		((Control)Button_NOIR).TabIndex = 18;
		((Control)Button_NOIR).Tag = "67; 86; 106";
		((ButtonBase)Button_NOIR).Text = "NOIR";
		((ButtonBase)Button_NOIR).UseVisualStyleBackColor = true;
		((ButtonBase)Button_BLEUNUIT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_BLEUNUIT).FlatStyle = (FlatStyle)0;
		((Control)Button_BLEUNUIT).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_BLEUNUIT = Button_BLEUNUIT;
		location = new Point(12, 429);
		((Control)button_BLEUNUIT).Location = location;
		((Control)Button_BLEUNUIT).Name = "Button_BLEUNUIT";
		Button button_BLEUNUIT2 = Button_BLEUNUIT;
		size = new Size(257, 33);
		((Control)button_BLEUNUIT2).Size = size;
		((Control)Button_BLEUNUIT).TabIndex = 25;
		((Control)Button_BLEUNUIT).Tag = "15; 5; 107";
		((ButtonBase)Button_BLEUNUIT).Text = "BLEU NUIT";
		((ButtonBase)Button_BLEUNUIT).UseVisualStyleBackColor = true;
		((ButtonBase)Button_GRIS).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_GRIS).FlatStyle = (FlatStyle)0;
		((Control)Button_GRIS).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_GRIS = Button_GRIS;
		location = new Point(12, 394);
		((Control)button_GRIS).Location = location;
		((Control)Button_GRIS).Name = "Button_GRIS";
		Button button_GRIS2 = Button_GRIS;
		size = new Size(257, 33);
		((Control)button_GRIS2).Size = size;
		((Control)Button_GRIS).TabIndex = 24;
		((Control)Button_GRIS).Tag = "55; 71; 79";
		((ButtonBase)Button_GRIS).Text = "GRIS";
		((ButtonBase)Button_GRIS).UseVisualStyleBackColor = true;
		((ButtonBase)Button_VERTFONCE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_VERTFONCE).FlatStyle = (FlatStyle)0;
		((Control)Button_VERTFONCE).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button button_VERTFONCE = Button_VERTFONCE;
		location = new Point(12, 359);
		((Control)button_VERTFONCE).Location = location;
		((Control)Button_VERTFONCE).Name = "Button_VERTFONCE";
		Button button_VERTFONCE2 = Button_VERTFONCE;
		size = new Size(257, 33);
		((Control)button_VERTFONCE2).Size = size;
		((Control)Button_VERTFONCE).TabIndex = 23;
		((Control)Button_VERTFONCE).Tag = "0; 150; 136";
		((ButtonBase)Button_VERTFONCE).Text = "VERT FONCE";
		((ButtonBase)Button_VERTFONCE).UseVisualStyleBackColor = true;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(68, 477);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		Padding margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(155, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1069;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(291, 540);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Button_BLEUNUIT);
		((Control)this).Controls.Add((Control)(object)Button_GRIS);
		((Control)this).Controls.Add((Control)(object)Button_VERTFONCE);
		((Control)this).Controls.Add((Control)(object)Button_VIOLETFONCE);
		((Control)this).Controls.Add((Control)(object)Button_ROUGE);
		((Control)this).Controls.Add((Control)(object)Button_MARRON);
		((Control)this).Controls.Add((Control)(object)Button_VIOLET);
		((Control)this).Controls.Add((Control)(object)Button_NOIR);
		((Control)this).Controls.Add((Control)(object)Button_JAUNE);
		((Control)this).Controls.Add((Control)(object)Button_MAUVE);
		((Control)this).Controls.Add((Control)(object)Button_ORANGE);
		((Control)this).Controls.Add((Control)(object)Button_VERT);
		((Control)this).Controls.Add((Control)(object)Button_BLEU);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_THEME";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "THEME";
		((Control)this).ResumeLayout(false);
	}

	private void Button_BLEU_Click(object sender, EventArgs e)
	{
		string text = NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null).ToString();
		string[] array = text.Split(new char[1] { ';' });
		((Form)this).Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null));
		((Control)MyProject.Forms.Form_3_VENTE.Panel33).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label4).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label5).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label7).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label8).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label2).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label9).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label11).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label12).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label16).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label17).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label19).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label20).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label6).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label27).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label28).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label29).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label_TOP).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label_LEFT).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label_BOTTOM).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Label_RIGHT).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_SOLDER_NOT_PRINTER).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		MyProject.Forms.Form_3_VENTE.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((Control)MyProject.Forms.Form_3_VENTE.Panel2).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
		((TextBoxBase)MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET).BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
	}

	private void FormDialog_THEME_Load(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_3_VENTE.FlowLayout_ARTICLES).Controls.Clear();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		try
		{
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "UPDATE     TABLE_PARAMETRES    SET    VALEUR = '" + ((Form)this).Text.ToString() + "'     where  OBJET = 'THEME'      ";
			val.Connection = Module1.cn_SQL;
			val.ExecuteNonQuery();
			MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("THEME", false, 0).Index].SubItems[1].Text = ((Form)this).Text.ToString();
			ColorConverter colorConverter = new ColorConverter();
			Color backColor = (Color)colorConverter.ConvertFromString(MyProject.Forms.Form_3_VENTE.Text_THEME.Text);
			((TextBoxBase)MyProject.Forms.Form_3_VENTE.Text_THEME).BackColor = backColor;
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception e2 = ex;
			StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Button_BLEU.PerformClick();
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}
}
