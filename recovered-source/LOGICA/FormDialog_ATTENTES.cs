using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ATTENTES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_ARABE")]
	private Button _Button_ARABE;

	[AccessedThroughProperty("Button_A5")]
	private Button _Button_A5;

	[AccessedThroughProperty("Button_A4")]
	private Button _Button_A4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label_ID_1")]
	private Label _Label_ID_1;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("CL")]
	private PrintDocument _CL;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private Label _Text_TOTAL_NET;

	[AccessedThroughProperty("Text_PRINTER_SOLDER")]
	private TextBox _Text_PRINTER_SOLDER;

	[AccessedThroughProperty("CAISSIER")]
	private DataGridViewTextBoxColumn _CAISSIER;

	[AccessedThroughProperty("V")]
	private DataGridViewTextBoxColumn _V;

	[AccessedThroughProperty("TOTAL_NETT")]
	private DataGridViewTextBoxColumn _TOTAL_NETT;

	[AccessedThroughProperty("DataGridView100")]
	private DataGridView _DataGridView100;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("Button_CONTINUE")]
	private Button _Button_CONTINUE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_V")]
	private DataGridViewTextBoxColumn _Prix_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("TOTAL_NET")]
	private DataGridViewTextBoxColumn _TOTAL_NET;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CODE_CLIENT")]
	private DataGridViewTextBoxColumn _CODE_CLIENT;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("NOTES_TYPE_PRIX")]
	private DataGridViewTextBoxColumn _NOTES_TYPE_PRIX;

	private string _string;

	internal virtual Button Button_ARABE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ARABE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_ARABE = value;
		}
	}

	internal virtual Button Button_A5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_A5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_A5 = value;
		}
	}

	internal virtual Button Button_A4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_A4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_A4 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).Click -= eventHandler;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_ID_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ID_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ID_1 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual PrintDocument CL
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_PrintPage;
			if (_CL != null)
			{
				_CL.PrintPage -= val;
			}
			_CL = value;
			if (_CL != null)
			{
				_CL.PrintPage += val;
			}
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Label Text_TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TOTAL_NET = value;
		}
	}

	internal virtual TextBox Text_PRINTER_SOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_SOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_SOLDER = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CAISSIER = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn V
	{
		[DebuggerNonUserCode]
		get
		{
			return _V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_V = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_NETT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NETT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NETT = value;
		}
	}

	internal virtual DataGridView DataGridView100
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView100_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView100_CellContentClick;
			if (_DataGridView100 != null)
			{
				_DataGridView100.CellClick -= val;
				_DataGridView100.CellContentClick -= val2;
			}
			_DataGridView100 = value;
			if (_DataGridView100 != null)
			{
				_DataGridView100.CellClick += val;
				_DataGridView100.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn DATES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATES = value;
		}
	}

	internal virtual Button Button_CONTINUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CONTINUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CONTINUE_Click;
			if (_Button_CONTINUE != null)
			{
				((Control)_Button_CONTINUE).Click -= eventHandler;
			}
			_Button_CONTINUE = value;
			if (_Button_CONTINUE != null)
			{
				((Control)_Button_CONTINUE).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Article
	{
		[DebuggerNonUserCode]
		get
		{
			return _Article;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Article = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Prix_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_V = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Qté
	{
		[DebuggerNonUserCode]
		get
		{
			return _Qté;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Qté = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn NOTES_TYPE_PRIX
	{
		[DebuggerNonUserCode]
		get
		{
			return _NOTES_TYPE_PRIX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NOTES_TYPE_PRIX = value;
		}
	}

	public FormDialog_ATTENTES()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Shown += FormDialog_ATTENTES_Shown;
		((Form)this).Load += FormDialog_ATTENTES_Load;
		__ENCAddToList(this);
		_string = "";
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected Obj, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected Obj, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected Obj, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected Obj, but got Unknown
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ATTENTES));
		Button_ARABE = new Button();
		Button_A5 = new Button();
		Button_A4 = new Button();
		Button2 = new Button();
		Label_ID_1 = new Label();
		Label18 = new Label();
		CL = new PrintDocument();
		Panel2 = new Panel();
		Text_TOTAL_NET = new Label();
		Text_PRINTER_SOLDER = new TextBox();
		CAISSIER = new DataGridViewTextBoxColumn();
		V = new DataGridViewTextBoxColumn();
		TOTAL_NETT = new DataGridViewTextBoxColumn();
		DataGridView100 = new DataGridView();
		DATES = new DataGridViewTextBoxColumn();
		Button_CONTINUE = new Button();
		DataGridView1 = new DataGridView();
		Article = new DataGridViewTextBoxColumn();
		Prix_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		TOTAL_NET = new DataGridViewTextBoxColumn();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CODE_CLIENT = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		NOTES_TYPE_PRIX = new DataGridViewTextBoxColumn();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)DataGridView100).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Button_ARABE).BackColor = Color.White;
		((Control)Button_ARABE).Cursor = Cursors.Hand;
		((ButtonBase)Button_ARABE).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE).FlatStyle = (FlatStyle)0;
		((Control)Button_ARABE).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_ARABE).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE).ImageAlign = (ContentAlignment)16;
		Button button_ARABE = Button_ARABE;
		Point location = new Point(495, 497);
		((Control)button_ARABE).Location = location;
		Button button_ARABE2 = Button_ARABE;
		Padding margin = new Padding(0);
		((Control)button_ARABE2).Margin = margin;
		((Control)Button_ARABE).Name = "Button_ARABE";
		Button button_ARABE3 = Button_ARABE;
		Size size = new Size(82, 45);
		((Control)button_ARABE3).Size = size;
		((Control)Button_ARABE).TabIndex = 1052;
		((ButtonBase)Button_ARABE).Text = "Arabe";
		((ButtonBase)Button_ARABE).UseVisualStyleBackColor = false;
		((Control)Button_ARABE).Visible = false;
		((ButtonBase)Button_A5).BackColor = Color.White;
		((Control)Button_A5).Cursor = Cursors.Hand;
		((ButtonBase)Button_A5).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_A5).FlatStyle = (FlatStyle)0;
		((Control)Button_A5).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_A5).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_A5).ImageAlign = (ContentAlignment)16;
		Button button_A = Button_A5;
		location = new Point(450, 497);
		((Control)button_A).Location = location;
		Button button_A2 = Button_A5;
		margin = new Padding(0);
		((Control)button_A2).Margin = margin;
		((Control)Button_A5).Name = "Button_A5";
		Button button_A3 = Button_A5;
		size = new Size(62, 45);
		((Control)button_A3).Size = size;
		((Control)Button_A5).TabIndex = 1051;
		((ButtonBase)Button_A5).Text = "A5";
		((ButtonBase)Button_A5).UseVisualStyleBackColor = false;
		((Control)Button_A5).Visible = false;
		((ButtonBase)Button_A4).BackColor = Color.White;
		((Control)Button_A4).Cursor = Cursors.Hand;
		((ButtonBase)Button_A4).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_A4).FlatStyle = (FlatStyle)0;
		((Control)Button_A4).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_A4).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_A4).ImageAlign = (ContentAlignment)16;
		Button button_A4 = Button_A4;
		location = new Point(400, 497);
		((Control)button_A4).Location = location;
		Button button_A5 = Button_A4;
		margin = new Padding(0);
		((Control)button_A5).Margin = margin;
		((Control)Button_A4).Name = "Button_A4";
		Button button_A6 = Button_A4;
		size = new Size(62, 45);
		((Control)button_A6).Size = size;
		((Control)Button_A4).TabIndex = 1050;
		((ButtonBase)Button_A4).Text = "A4";
		((ButtonBase)Button_A4).UseVisualStyleBackColor = false;
		((Control)Button_A4).Visible = false;
		((ButtonBase)Button2).BackColor = Color.White;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button2).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button = Button2;
		location = new Point(592, 497);
		((Control)button).Location = location;
		Button button2 = Button2;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button3 = Button2;
		size = new Size(100, 45);
		((Control)button3).Size = size;
		((Control)Button2).TabIndex = 1049;
		((ButtonBase)Button2).Text = "Imprimer";
		((ButtonBase)Button2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		Label_ID_1.AutoSize = true;
		((Control)Label_ID_1).BackColor = Color.Transparent;
		((Control)Label_ID_1).Font = new Font("Calibri", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_ID_1).ForeColor = Color.FromArgb(2, 45, 162);
		Label label_ID_ = Label_ID_1;
		location = new Point(400, 458);
		((Control)label_ID_).Location = location;
		((Control)Label_ID_1).Name = "Label_ID_1";
		Label label_ID_2 = Label_ID_1;
		size = new Size(13, 14);
		((Control)label_ID_2).Size = size;
		((Control)Label_ID_1).TabIndex = 1047;
		Label_ID_1.Text = "_";
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 20f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.White;
		Label label = Label18;
		location = new Point(5, 15);
		((Control)label).Location = location;
		((Control)Label18).Name = "Label18";
		Label label2 = Label18;
		size = new Size(172, 30);
		((Control)label2).Size = size;
		((Control)Label18).TabIndex = 689;
		Label18.Text = "TOTAL NET :";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Panel2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel2).Controls.Add((Control)(object)Label18);
		((Control)Panel2).Controls.Add((Control)(object)Text_TOTAL_NET);
		Panel panel = Panel2;
		location = new Point(400, 395);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(501, 60);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 1054;
		((Control)Text_TOTAL_NET).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Text_TOTAL_NET).Font = new Font("Segoe UI", 26f, (FontStyle)1);
		((Control)Text_TOTAL_NET).ForeColor = Color.White;
		Label text_TOTAL_NET = Text_TOTAL_NET;
		location = new Point(185, 12);
		((Control)text_TOTAL_NET).Location = location;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		Label text_TOTAL_NET2 = Text_TOTAL_NET;
		size = new Size(325, 43);
		((Control)text_TOTAL_NET2).Size = size;
		((Control)Text_TOTAL_NET).TabIndex = 986;
		Text_TOTAL_NET.TextAlign = (ContentAlignment)16;
		TextBox text_PRINTER_SOLDER = Text_PRINTER_SOLDER;
		location = new Point(794, 3);
		((Control)text_PRINTER_SOLDER).Location = location;
		((Control)Text_PRINTER_SOLDER).Name = "Text_PRINTER_SOLDER";
		TextBox text_PRINTER_SOLDER2 = Text_PRINTER_SOLDER;
		size = new Size(107, 20);
		((Control)text_PRINTER_SOLDER2).Size = size;
		((Control)Text_PRINTER_SOLDER).TabIndex = 1053;
		Text_PRINTER_SOLDER.Text = "Text_PRINTER_SOLDER";
		((Control)Text_PRINTER_SOLDER).Visible = false;
		((DataGridViewColumn)CAISSIER).DataPropertyName = "CAISSIER";
		((DataGridViewColumn)CAISSIER).HeaderText = "CAISSIER";
		((DataGridViewColumn)CAISSIER).Name = "CAISSIER";
		((DataGridViewColumn)V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)V).DataPropertyName = "V";
		val.Format = "N2";
		val.NullValue = null;
		((DataGridViewColumn)V).DefaultCellStyle = val;
		((DataGridViewColumn)V).HeaderText = "V";
		((DataGridViewColumn)V).MinimumWidth = 2;
		((DataGridViewColumn)V).Name = "V";
		V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)V).Visible = false;
		((DataGridViewColumn)V).Width = 2;
		((DataGridViewColumn)TOTAL_NETT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NETT).HeaderText = "TOTAL_NET";
		((DataGridViewColumn)TOTAL_NETT).Name = "TOTAL_NETT";
		DataGridView100.AllowUserToAddRows = false;
		DataGridView100.AllowUserToResizeRows = false;
		val2.BackColor = Color.FromArgb(240, 240, 240);
		DataGridView100.AlternatingRowsDefaultCellStyle = val2;
		DataGridView100.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView100.BackgroundColor = Color.White;
		DataGridView100.BorderStyle = (BorderStyle)2;
		DataGridView100.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView100.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val3.ForeColor = Color.FromArgb(34, 34, 34);
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		DataGridView100.ColumnHeadersDefaultCellStyle = val3;
		DataGridView100.ColumnHeadersHeight = 30;
		DataGridView100.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)V,
			(DataGridViewColumn)CAISSIER,
			(DataGridViewColumn)TOTAL_NETT,
			(DataGridViewColumn)DATES
		});
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.BackColor = SystemColors.Window;
		val4.Font = new Font("Calibri", 10f);
		val4.ForeColor = SystemColors.ControlText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)2;
		DataGridView100.DefaultCellStyle = val4;
		DataGridView100.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView100;
		location = new Point(12, 17);
		((Control)dataGridView).Location = location;
		((Control)DataGridView100).Name = "DataGridView100";
		DataGridView100.RowHeadersVisible = false;
		DataGridView100.RowHeadersWidth = 25;
		DataGridView100.RowTemplate.Height = 25;
		DataGridView100.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView100;
		size = new Size(375, 527);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView100).TabIndex = 1048;
		((DataGridViewColumn)DATES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES).HeaderText = "DATES";
		((DataGridViewColumn)DATES).Name = "DATES";
		((DataGridViewColumn)DATES).Width = 130;
		((ButtonBase)Button_CONTINUE).BackColor = Color.Green;
		((Control)Button_CONTINUE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CONTINUE).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button_CONTINUE).FlatStyle = (FlatStyle)0;
		((Control)Button_CONTINUE).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		((Control)Button_CONTINUE).ForeColor = SystemColors.ButtonHighlight;
		((ButtonBase)Button_CONTINUE).ImageAlign = (ContentAlignment)2;
		Button button_CONTINUE = Button_CONTINUE;
		location = new Point(699, 497);
		((Control)button_CONTINUE).Location = location;
		Button button_CONTINUE2 = Button_CONTINUE;
		margin = new Padding(0);
		((Control)button_CONTINUE2).Margin = margin;
		((Control)Button_CONTINUE).Name = "Button_CONTINUE";
		Button button_CONTINUE3 = Button_CONTINUE;
		size = new Size(202, 47);
		((Control)button_CONTINUE3).Size = size;
		((Control)Button_CONTINUE).TabIndex = 1046;
		((ButtonBase)Button_CONTINUE).Text = "Continue";
		((ButtonBase)Button_CONTINUE).UseVisualStyleBackColor = false;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		val5.BackColor = Color.FromArgb(240, 240, 240);
		DataGridView1.AlternatingRowsDefaultCellStyle = val5;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val6.ForeColor = Color.FromArgb(34, 34, 34);
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val6;
		DataGridView1.ColumnHeadersHeight = 30;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)TOTAL_NET,
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CODE_CLIENT,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)NOTES_TYPE_PRIX
		});
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Window;
		val7.Font = new Font("Calibri", 10f);
		val7.ForeColor = SystemColors.ControlText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val7;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView3 = DataGridView1;
		location = new Point(400, 17);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 25;
		DataGridView1.RowTemplate.Height = 25;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView1;
		size = new Size(501, 380);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView1).TabIndex = 1045;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Article).Resizable = (DataGridViewTriState)1;
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_V).DataPropertyName = "PRIX_V";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "N2";
		val8.NullValue = null;
		((DataGridViewColumn)Prix_V).DefaultCellStyle = val8;
		((DataGridViewColumn)Prix_V).HeaderText = "PRIX_V";
		((DataGridViewColumn)Prix_V).Name = "Prix_V";
		Prix_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Prix_V).Width = 72;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val9.Alignment = (DataGridViewContentAlignment)32;
		val9.NullValue = null;
		((DataGridViewColumn)Qté).DefaultCellStyle = val9;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).Width = 60;
		((DataGridViewColumn)TOTAL_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NET).DataPropertyName = "TOTAL_NET";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "N2";
		val10.NullValue = null;
		((DataGridViewColumn)TOTAL_NET).DefaultCellStyle = val10;
		((DataGridViewColumn)TOTAL_NET).HeaderText = "TOTAL_NET";
		((DataGridViewColumn)TOTAL_NET).Name = "TOTAL_NET";
		TOTAL_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TOTAL_NET).Width = 110;
		((DataGridViewColumn)ID_CLIENT).DataPropertyName = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Visible = false;
		((DataGridViewColumn)CODE_CLIENT).DataPropertyName = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).HeaderText = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).Name = "CODE_CLIENT";
		((DataGridViewColumn)CODE_CLIENT).Visible = false;
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)CLIENT).Visible = false;
		((DataGridViewColumn)NOTES_TYPE_PRIX).DataPropertyName = "NOTES_TYPE_PRIX";
		((DataGridViewColumn)NOTES_TYPE_PRIX).HeaderText = "NOTES_TYPE_PRIX";
		((DataGridViewColumn)NOTES_TYPE_PRIX).Name = "NOTES_TYPE_PRIX";
		((DataGridViewColumn)NOTES_TYPE_PRIX).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(913, 546);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_ARABE);
		((Control)this).Controls.Add((Control)(object)Button_A5);
		((Control)this).Controls.Add((Control)(object)Button_A4);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Label_ID_1);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Text_PRINTER_SOLDER);
		((Control)this).Controls.Add((Control)(object)DataGridView100);
		((Control)this).Controls.Add((Control)(object)Button_CONTINUE);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_ATTENTES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "ATTENTES";
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)DataGridView100).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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

	private void FormDialog_ATTENTES_Shown(object sender, EventArgs e)
	{
		DataGridView100.ClearSelection();
		Text_TOTAL_NET.Text = Conversions.ToString(0);
	}

	private void FormDialog_ATTENTES_Load(object sender, EventArgs e)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
				DataGridView1.DataSource = null;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.AutoResizeColumnHeadersHeight();
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.MultiSelect = true;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Columns[num2].SortMode = (DataGridViewColumnSortMode)2;
					num2++;
				}
				DataGridView1.ClearSelection();
				DataGridView1.Columns["Article"].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DataGridView100.AutoGenerateColumns = false;
				DataGridView100.RowTemplate.Height = 25;
				DataGridView100.BackgroundColor = Color.White;
				DataGridView100.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView100.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView100.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView100.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView100.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView100.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
				DataGridView100.DefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				DataGridView100.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView100.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView100.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView100.AutoResizeColumnHeadersHeight();
				DataGridView100.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView100.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView100.MultiSelect = true;
				DataGridView100.EditMode = (DataGridViewEditMode)4;
				DataGridView100.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num5 = ((BaseCollection)DataGridView100.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView100.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
					num6++;
				}
				DataGridView100.ClearSelection();
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("SELECT    V , MAX(Caissier)  as Caissier ,MAX(Dates)  as Dates ,MAX(Heure)  as Heure ,   sum(TOTAL_NET) as TOTAL_NET    ,  MAX(Client)  as Client         from        TABLE_ATTENTE   GROUP BY V  ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView100.Rows.Clear();
				int num8 = dataTable.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView100.Rows.Add(new object[4]
					{
						dataTable.Rows[num9]["V"].ToString(),
						dataTable.Rows[num9]["Caissier"].ToString(),
						Module1.FLOUSS(Conversions.ToDecimal(dataTable.Rows[num9]["TOTAL_NET"].ToString())),
						Conversions.ToDate(dataTable.Rows[num9]["Dates"]).ToString("dd/MM/yyy") + " " + Conversions.ToDate(dataTable.Rows[num9]["Heure"]).ToString("HH:mm") + " " + dataTable.Rows[num9]["Client"].ToString()
					});
					num9++;
				}
				dataTable.Clear();
				Label_ID_1.Text = "_";
				Text_PRINTER_SOLDER.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_CL.sni");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val3 = Graphics.FromImage((Image)(object)val2);
					val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val2 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_CONTINUE_Click(object sender, EventArgs e)
	{
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					return;
				}
				if (MyProject.Forms.Form_3_VENTE.DataGridView1.Rows.Count > 0)
				{
					MessageBox.Show("Le Ticket de vente est pleine", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					val.CommandText = "INSERT INTO    TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "        (ID, Dates, Heure, ID_ARTICLE, Code, Article, Famille , PRIX_A, PRIX_MP, PRIX_V, Qté, Remise, TOTAL_NET , TAUX_TVA ,PRINTER,PRINTER_DUPLICATA  ,GROUPE    )        SELECT     TABLE_ATTENTE.ID ,TABLE_ATTENTE.Dates, TABLE_ATTENTE.Heure, TABLE_ATTENTE.ID_ARTICLE, TABLE_ATTENTE.Code, TABLE_ATTENTE.Article, TABLE_ATTENTE.Famille , TABLE_ATTENTE.PRIX_A , TABLE_ATTENTE.PRIX_MP, TABLE_ATTENTE.PRIX_V,  TABLE_ATTENTE.Qté,  TABLE_ATTENTE.Remise, TABLE_ATTENTE.TOTAL_NET, TABLE_ATTENTE.TAUX_TVA, TABLE_ATTENTE.PRINTER, TABLE_ATTENTE.PRINTER_DUPLICATA, TABLE_ATTENTE.GROUPE       FROM      TABLE_ATTENTE                  WHERE       V like  '" + Strings.Trim(Label_ID_1.Text) + "'        ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "Delete  from TABLE_ATTENTE          WHERE       V     like  '" + Strings.Trim(Label_ID_1.Text) + "'     ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val2.Commit();
					Module1.cn_SQL.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					val2.Rollback();
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				Module1.dt1.Clear();
				Module1.da1 = new MySqlDataAdapter("select * from   TABLE_" + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "  ", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1.da1).Fill(Module1.dt1);
				MyProject.Forms.Form_3_VENTE.DataGridView1.DataSource = Module1.dt1;
				((Form)this).Close();
				((Control)MyProject.Forms.Form_3_VENTE.Panel_RAPPEL).Visible = false;
				MyProject.Forms.Form_3_VENTE.Button_CLIENT._ID_Button = DataGridView1.Rows[0].Cells["ID_CLIENT"].Value.ToString();
				MyProject.Forms.Form_3_VENTE.Button_CLIENT._CODE_Button = DataGridView1.Rows[0].Cells["CODE_CLIENT"].Value.ToString();
				((ButtonBase)MyProject.Forms.Form_3_VENTE.Button_CLIENT).Text = DataGridView1.Rows[0].Cells["CLIENT"].Value.ToString();
				MyProject.Forms.Form_3_VENTE.Text_TOTAL_NET_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
		}
	}

	private void DataGridView100_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (DataGridView100.Rows.Count == 0)
			{
				return;
			}
			if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0 && Operators.CompareString(DataGridView100.Rows[((DataGridViewBand)DataGridView100.CurrentRow).Index].Cells["CAISSIER"].Value.ToString(), Module1._USERNAME, TextCompare: false) != 0)
			{
				MessageBox.Show("vous n'avez pas le droit pour explorer cette commande", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
				DataGridView100.ClearSelection();
				return;
			}
			Label_ID_1.Text = DataGridView100.Rows[((DataGridViewBand)DataGridView100.CurrentRow).Index].Cells["V"].Value.ToString();
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select     Article,PRIX_V,Qté,TOTAL_NET,ID_CLIENT,CODE_CLIENT,CLIENT ,NOTES_TYPE_PRIX      from TABLE_ATTENTE      WHERE       V like  '" + Strings.Trim(Label_ID_1.Text) + "'     order by ID asc", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView1.AutoGenerateColumns = false;
			DataGridView1.DataSource = dataTable;
			double num = 0.0;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlCommand val2 = new MySqlCommand("select sum(TOTAL_NET) as n     from     TABLE_ATTENTE     Where     V  = '" + Label_ID_1.Text + "'             ", Module1.cn_SQL);
			num = ((val2.ExecuteScalar() != DBNull.Value) ? Conversions.ToDouble(val2.ExecuteScalar()) : 0.0);
			Module1.cn_SQL.Close();
			Text_TOTAL_NET.Text = Strings.FormatNumber(num);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val4 = Graphics.FromImage((Image)(object)val3);
				val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val3 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView100_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void CL_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text = Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Qté"].Value))) + "x", 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "\r\n";
				_string += "\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "--------------TICKET ATTENTE---------------\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "\r\n";
				_string += "\r\n\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
			if (DataGridView1.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
				{
					CL.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
				}
				CL.PrintController = (PrintController)new StandardPrintController();
				CL.Print();
			}
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
	}
}
