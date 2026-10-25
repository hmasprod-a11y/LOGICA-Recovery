using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
public class Form_3_VENTE_ENTETE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("ID_TICKET")]
	private DataGridViewTextBoxColumn _ID_TICKET;

	[AccessedThroughProperty("DATESs")]
	private DataGridViewTextBoxColumn _DATESs;

	[AccessedThroughProperty("TICKETt")]
	private DataGridViewTextBoxColumn _TICKETt;

	[AccessedThroughProperty("CAISSIERr")]
	private DataGridViewTextBoxColumn _CAISSIERr;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("Total_NET")]
	private DataGridViewTextBoxColumn _Total_NET;

	[AccessedThroughProperty("OPERATION")]
	private DataGridViewTextBoxColumn _OPERATION;

	[AccessedThroughProperty("FlowLayout_FAMILLES")]
	private FlowLayoutPanel _FlowLayout_FAMILLES;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private DataTable _dt;

	private MySqlDataAdapter _da;

	private int a;

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

	internal virtual DataGridViewTextBoxColumn ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_TICKET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATESs
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATESs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATESs = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TICKETt
	{
		[DebuggerNonUserCode]
		get
		{
			return _TICKETt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TICKETt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CAISSIERr
	{
		[DebuggerNonUserCode]
		get
		{
			return _CAISSIERr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CAISSIERr = value;
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

	internal virtual DataGridViewTextBoxColumn Total_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Total_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Total_NET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn OPERATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _OPERATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OPERATION = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayout_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayout_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = FlowLayout_FAMILLES_Paint;
			EventHandler eventHandler = FlowLayout_FAMILLES_DoubleClick;
			if (_FlowLayout_FAMILLES != null)
			{
				((Control)_FlowLayout_FAMILLES).Paint -= val;
				((Control)_FlowLayout_FAMILLES).DoubleClick -= eventHandler;
			}
			_FlowLayout_FAMILLES = value;
			if (_FlowLayout_FAMILLES != null)
			{
				((Control)_FlowLayout_FAMILLES).Paint += val;
				((Control)_FlowLayout_FAMILLES).DoubleClick += eventHandler;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).Click -= eventHandler;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).Click -= eventHandler;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
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

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView2 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).Click += eventHandler;
			}
		}
	}

	public Form_3_VENTE_ENTETE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_JOURNAL_ENTETE_Load;
		((Control)this).KeyDown += me_KeyDown;
		__ENCAddToList(this);
		_dt = new DataTable();
		_da = new MySqlDataAdapter();
		a = 0;
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
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_3_VENTE_ENTETE));
		DataGridView1 = new DataGridView();
		ID_TICKET = new DataGridViewTextBoxColumn();
		DATESs = new DataGridViewTextBoxColumn();
		TICKETt = new DataGridViewTextBoxColumn();
		CAISSIERr = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		Total_NET = new DataGridViewTextBoxColumn();
		OPERATION = new DataGridViewTextBoxColumn();
		FlowLayout_FAMILLES = new FlowLayoutPanel();
		Panel1 = new Panel();
		Button5 = new Button();
		TextBox4 = new TextBox();
		Button4 = new Button();
		Button3 = new Button();
		TextBox3 = new TextBox();
		Button2 = new Button();
		TextBox2 = new TextBox();
		DataGridView2 = new DataGridView();
		TextBox1 = new TextBox();
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)ID_TICKET,
			(DataGridViewColumn)DATESs,
			(DataGridViewColumn)TICKETt,
			(DataGridViewColumn)CAISSIERr,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)Total_NET,
			(DataGridViewColumn)OPERATION
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 10f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(0, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(861, 339);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 2;
		((DataGridViewColumn)ID_TICKET).DataPropertyName = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).HeaderText = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).Name = "ID_TICKET";
		((DataGridViewColumn)DATESs).DataPropertyName = "DATES";
		((DataGridViewColumn)DATESs).HeaderText = "DATES";
		((DataGridViewColumn)DATESs).Name = "DATESs";
		((DataGridViewColumn)TICKETt).DataPropertyName = "TICKET";
		((DataGridViewColumn)TICKETt).HeaderText = "TICKET";
		((DataGridViewColumn)TICKETt).Name = "TICKETt";
		((DataGridViewColumn)CAISSIERr).DataPropertyName = "CAISSIER";
		((DataGridViewColumn)CAISSIERr).HeaderText = "CAISSIER";
		((DataGridViewColumn)CAISSIERr).Name = "CAISSIERr";
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)Total_NET).DataPropertyName = "Total_NET";
		((DataGridViewColumn)Total_NET).HeaderText = "Total_NET";
		((DataGridViewColumn)Total_NET).Name = "Total_NET";
		((DataGridViewColumn)OPERATION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)OPERATION).DataPropertyName = "OPERATION";
		((DataGridViewColumn)OPERATION).HeaderText = "OPERATION";
		((DataGridViewColumn)OPERATION).Name = "OPERATION";
		((DataGridViewColumn)OPERATION).Width = 150;
		((Control)FlowLayout_FAMILLES).Anchor = (AnchorStyles)14;
		((ScrollableControl)FlowLayout_FAMILLES).AutoScroll = true;
		((Control)FlowLayout_FAMILLES).BackColor = Color.White;
		((Control)FlowLayout_FAMILLES).Font = new Font("Tahoma", 7f);
		FlowLayoutPanel flowLayout_FAMILLES = FlowLayout_FAMILLES;
		location = new Point(0, 342);
		((Control)flowLayout_FAMILLES).Location = location;
		FlowLayoutPanel flowLayout_FAMILLES2 = FlowLayout_FAMILLES;
		Padding margin = new Padding(0);
		((Control)flowLayout_FAMILLES2).Margin = margin;
		((Control)FlowLayout_FAMILLES).Name = "FlowLayout_FAMILLES";
		FlowLayoutPanel flowLayout_FAMILLES3 = FlowLayout_FAMILLES;
		size = new Size(861, 58);
		((Control)flowLayout_FAMILLES3).Size = size;
		((Control)FlowLayout_FAMILLES).TabIndex = 994;
		((Control)Panel1).Controls.Add((Control)(object)CheckBox1);
		((Control)Panel1).Controls.Add((Control)(object)Button5);
		((Control)Panel1).Controls.Add((Control)(object)TextBox4);
		((Control)Panel1).Controls.Add((Control)(object)Button4);
		((Control)Panel1).Controls.Add((Control)(object)Button3);
		((Control)Panel1).Controls.Add((Control)(object)TextBox3);
		((Control)Panel1).Controls.Add((Control)(object)Button2);
		((Control)Panel1).Controls.Add((Control)(object)TextBox2);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView2);
		((Control)Panel1).Controls.Add((Control)(object)TextBox1);
		((Control)Panel1).Controls.Add((Control)(object)Button1);
		Panel panel = Panel1;
		location = new Point(22, 76);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(817, 246);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1000;
		((Control)Panel1).Visible = false;
		Button button = Button5;
		location = new Point(688, 157);
		((Control)button).Location = location;
		((Control)Button5).Name = "Button5";
		Button button2 = Button5;
		size = new Size(78, 46);
		((Control)button2).Size = size;
		((Control)Button5).TabIndex = 1005;
		((ButtonBase)Button5).Text = "delete";
		((ButtonBase)Button5).UseVisualStyleBackColor = true;
		TextBox textBox = TextBox4;
		location = new Point(518, 197);
		((Control)textBox).Location = location;
		((Control)TextBox4).Name = "TextBox4";
		TextBox textBox2 = TextBox4;
		size = new Size(78, 20);
		((Control)textBox2).Size = size;
		((Control)TextBox4).TabIndex = 1004;
		Button button3 = Button4;
		location = new Point(518, 145);
		((Control)button3).Location = location;
		((Control)Button4).Name = "Button4";
		Button button4 = Button4;
		size = new Size(78, 46);
		((Control)button4).Size = size;
		((Control)Button4).TabIndex = 1003;
		((ButtonBase)Button4).Text = "TOTAL CHECKED";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		Button button5 = Button3;
		location = new Point(342, 157);
		((Control)button5).Location = location;
		((Control)Button3).Name = "Button3";
		Button button6 = Button3;
		size = new Size(78, 46);
		((Control)button6).Size = size;
		((Control)Button3).TabIndex = 1002;
		((ButtonBase)Button3).Text = "SELECT MONTANT";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		TextBox textBox3 = TextBox3;
		location = new Point(236, 171);
		((Control)textBox3).Location = location;
		((Control)TextBox3).Name = "TextBox3";
		TextBox textBox4 = TextBox3;
		size = new Size(78, 20);
		((Control)textBox4).Size = size;
		((Control)TextBox3).TabIndex = 1001;
		Button button7 = Button2;
		location = new Point(101, 145);
		((Control)button7).Location = location;
		((Control)Button2).Name = "Button2";
		Button button8 = Button2;
		size = new Size(78, 46);
		((Control)button8).Size = size;
		((Control)Button2).TabIndex = 1000;
		((ButtonBase)Button2).Text = "ESPECES";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		TextBox textBox5 = TextBox2;
		location = new Point(101, 197);
		((Control)textBox5).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox textBox6 = TextBox2;
		size = new Size(78, 20);
		((Control)textBox6).Size = size;
		((Control)TextBox2).TabIndex = 999;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToDeleteRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(3, 3);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(811, 136);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 997;
		TextBox textBox7 = TextBox1;
		location = new Point(3, 197);
		((Control)textBox7).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox8 = TextBox1;
		size = new Size(78, 20);
		((Control)textBox8).Size = size;
		((Control)TextBox1).TabIndex = 998;
		Button button9 = Button1;
		location = new Point(3, 145);
		((Control)button9).Location = location;
		((Control)Button1).Name = "Button1";
		Button button10 = Button1;
		size = new Size(78, 46);
		((Control)button10).Size = size;
		((Control)Button1).TabIndex = 995;
		((ButtonBase)Button1).Text = "TOUT";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((ButtonBase)CheckBox1).AutoSize = true;
		CheckBox checkBox = CheckBox1;
		location = new Point(799, 229);
		((Control)checkBox).Location = location;
		((Control)CheckBox1).Name = "CheckBox1";
		CheckBox checkBox2 = CheckBox1;
		size = new Size(15, 14);
		((Control)checkBox2).Size = size;
		((Control)CheckBox1).TabIndex = 1007;
		((ButtonBase)CheckBox1).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(861, 398);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)FlowLayout_FAMILLES);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_3_VENTE_ENTETE";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "VENTE ENTETE";
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView2).EndInit();
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

	private void FormDialog_JOURNAL_ENTETE_Load(object sender, EventArgs e)
	{
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected Obj, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected Obj, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		checked
		{
			try
			{
				((Control)this).Top = 0;
				((Control)this).Height = ((Control)MyProject.Forms.Form_0_TEMPLATE).Height;
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text))
				{
					_dt.Clear();
					_dt = new DataTable();
					_da = new MySqlDataAdapter("select  ID_TICKET,DATES,TICKET,CAISSIER,CLIENT,TOTAL_NET,OPERATION      from    TABLE_VENTES_ENTETE   Where   CLOTURE_GLOBALE IS  NULL      order by ID desc", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select   DISTINCT     OPERATION    from TABLE_VENTES_ENTETE   Where   CLOTURE_GLOBALE IS  NULL      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					DataTable dataTable2 = new DataTable();
					((Control)FlowLayout_FAMILLES).Controls.Clear();
					int num = dataTable.Rows.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							val2 = new MySqlDataAdapter(" select sum(Total_NET) as n     from    TABLE_VENTES_ENTETE     WHERE       OPERATION  = '" + Strings.Trim(dataTable.Rows[num2]["OPERATION"].ToString()) + "'          AND    CLOTURE_GLOBALE IS  NULL    ", Module1.cn_SQL);
							dataTable2 = new DataTable();
							dataTable2.Clear();
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							double num5 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
							val2 = new MySqlDataAdapter("select   DISTINCT     ID_TICKET         from    TABLE_VENTES_ENTETE        WHERE       OPERATION  = '" + Strings.Trim(dataTable.Rows[num2]["OPERATION"].ToString()) + "'          AND    CLOTURE_GLOBALE IS  NULL       ", Module1.cn_SQL);
							dataTable2 = new DataTable();
							dataTable2.Clear();
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							double num6 = Conversion.Val(dataTable2.Rows.Count);
							Button_RJ_ARTICLE button_RJ_ARTICLE = new Button_RJ_ARTICLE();
							((Control)button_RJ_ARTICLE).Name = "Button_FAMILLE_" + Conversions.ToString(num2);
							((ButtonBase)button_RJ_ARTICLE).Text = Strings.LSet(dataTable.Rows[num2]["OPERATION"].ToString(), 8) + ": (" + Conversions.ToString(num6) + ")\r\n" + Strings.RSet(Strings.FormatNumber(num5), 8) + " DH";
							button_RJ_ARTICLE._BackgroundColor = Color.White;
							button_RJ_ARTICLE._BorderColor = Color.FromArgb(22, 106, 238);
							button_RJ_ARTICLE._BorderRadius = 8;
							button_RJ_ARTICLE._BorderSize = 1.5m;
							button_RJ_ARTICLE._TextColor = Color.Black;
							((Control)button_RJ_ARTICLE).Cursor = Cursors.Hand;
							((ButtonBase)button_RJ_ARTICLE).FlatStyle = (FlatStyle)2;
							((Control)button_RJ_ARTICLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
							((Control)button_RJ_ARTICLE).ForeColor = Color.Black;
							((ButtonBase)button_RJ_ARTICLE).TextAlign = (ContentAlignment)16;
							((ButtonBase)button_RJ_ARTICLE).UseVisualStyleBackColor = false;
							((Control)button_RJ_ARTICLE).Click += FAM_click;
							((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE);
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					_dt.Clear();
					_dt = new DataTable();
					_da = new MySqlDataAdapter("select   ID_TICKET,DATES,TICKET,CAISSIER,CLIENT,TOTAL_NET,OPERATION       from    TABLE_VENTES_ENTETE   Where  Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '       order by ID desc", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					DataTable dataTable3 = new DataTable();
					MySqlDataAdapter val3 = new MySqlDataAdapter();
					dataTable3.Clear();
					val3 = new MySqlDataAdapter("select   DISTINCT     OPERATION    from TABLE_VENTES_ENTETE   Where  Dates   between        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val3).Fill(dataTable3);
					MySqlDataAdapter val4 = new MySqlDataAdapter();
					DataTable dataTable4 = new DataTable();
					((Control)FlowLayout_FAMILLES).Controls.Clear();
					int num7 = dataTable3.Rows.Count - 1;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						int num4 = num7;
						if (num9 > num4)
						{
							break;
						}
						val4 = new MySqlDataAdapter("select sum(Total_NET) as n     from    TABLE_VENTES_ENTETE     WHERE    Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     OPERATION  = '" + Strings.Trim(dataTable3.Rows[num8]["OPERATION"].ToString()) + "'  ", Module1.cn_SQL);
						dataTable4 = new DataTable();
						dataTable4.Clear();
						((DbDataAdapter)(object)val4).Fill(dataTable4);
						double num10 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
						val4 = new MySqlDataAdapter("select   DISTINCT     ID_TICKET         from    TABLE_VENTES_ENTETE        WHERE   Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     OPERATION  = '" + Strings.Trim(dataTable3.Rows[num8]["OPERATION"].ToString()) + "'  ", Module1.cn_SQL);
						dataTable4 = new DataTable();
						dataTable4.Clear();
						((DbDataAdapter)(object)val4).Fill(dataTable4);
						double num11 = Conversion.Val(dataTable4.Rows.Count);
						Button_RJ_ARTICLE button_RJ_ARTICLE2 = new Button_RJ_ARTICLE();
						((Control)button_RJ_ARTICLE2).Name = "Button_FAMILLE_" + Conversions.ToString(num8);
						((ButtonBase)button_RJ_ARTICLE2).Text = Strings.LSet(dataTable3.Rows[num8]["OPERATION"].ToString(), 8) + ": (" + Conversions.ToString(num11) + ")\r\n" + Strings.RSet(Strings.FormatNumber(num10), 8) + " DH";
						button_RJ_ARTICLE2._BackgroundColor = Color.White;
						button_RJ_ARTICLE2._BorderColor = Color.FromArgb(22, 106, 238);
						button_RJ_ARTICLE2._BorderRadius = 8;
						button_RJ_ARTICLE2._BorderSize = 1.5m;
						button_RJ_ARTICLE2._TextColor = Color.Black;
						((Control)button_RJ_ARTICLE2).Cursor = Cursors.Hand;
						((ButtonBase)button_RJ_ARTICLE2).FlatStyle = (FlatStyle)2;
						((Control)button_RJ_ARTICLE2).Font = new Font("Tahoma", 9f, (FontStyle)1);
						((Control)button_RJ_ARTICLE2).ForeColor = Color.Black;
						((ButtonBase)button_RJ_ARTICLE2).TextAlign = (ContentAlignment)16;
						((ButtonBase)button_RJ_ARTICLE2).UseVisualStyleBackColor = false;
						((Control)button_RJ_ARTICLE2).Click += FAM_click;
						((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE2);
						num8++;
					}
				}
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
				DataGridView1.DataSource = _dt;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9f, (FontStyle)0);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.AutoResizeColumnHeadersHeight();
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.MultiSelect = true;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num12 = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num13 = 0;
				while (true)
				{
					int num14 = num13;
					int num4 = num12;
					if (num14 > num4)
					{
						break;
					}
					DataGridView1.Columns[num13].SortMode = (DataGridViewColumnSortMode)2;
					num13++;
				}
				DataGridView1.AllowUserToAddRows = false;
				DataGridView1.AllowUserToDeleteRows = false;
				DataGridView1.AllowUserToOrderColumns = true;
				DataGridView1.AllowUserToResizeColumns = true;
				DataGridView1.AllowUserToResizeRows = false;
				DataGridView1.ClearSelection();
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
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val5 = null;
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

	public void FAM_click(object sender, EventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		try
		{
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
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		DataGridView1.EditMode = (DataGridViewEditMode)0;
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter("select   ID_TICKET, TOTAL_NET,OPERATION       from    TABLE_VENTES_ENTETE   Where  Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '    AND OPERATION  = 'VENTE'   order by ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView2.DataSource = null;
		DataGridView2.Columns.Clear();
		DataGridViewCheckBoxColumn val = new DataGridViewCheckBoxColumn();
		((DataGridViewBand)val).Tag = false;
		((DataGridViewColumn)val).Name = "Delete";
		((DataGridViewColumn)val).Width = 43;
		((DataGridViewColumn)val).ReadOnly = false;
		DataGridView2.Columns.Add((DataGridViewColumn)(object)val);
		DataGridViewTextBoxColumn val2 = new DataGridViewTextBoxColumn();
		((DataGridViewBand)val2).Tag = false;
		((DataGridViewColumn)val2).Name = "ID_TICKET";
		((DataGridViewColumn)val2).Width = 43;
		((DataGridViewColumn)val2).ReadOnly = false;
		DataGridView2.Columns.Add((DataGridViewColumn)(object)val2);
		DataGridViewTextBoxColumn val3 = new DataGridViewTextBoxColumn();
		((DataGridViewBand)val3).Tag = false;
		((DataGridViewColumn)val3).Name = "TOTAL_NET";
		((DataGridViewColumn)val3).Width = 43;
		((DataGridViewColumn)val3).ReadOnly = false;
		DataGridView2.Columns.Add((DataGridViewColumn)(object)val3);
		DataGridViewTextBoxColumn val4 = new DataGridViewTextBoxColumn();
		((DataGridViewBand)val4).Tag = false;
		((DataGridViewColumn)val4).Name = "OPERATION";
		((DataGridViewColumn)val4).Width = 43;
		((DataGridViewColumn)val4).ReadOnly = false;
		DataGridView2.Columns.Add((DataGridViewColumn)(object)val4);
		DataGridViewTextBoxColumn val5 = new DataGridViewTextBoxColumn();
		((DataGridViewBand)val5).Tag = false;
		((DataGridViewColumn)val5).Name = "MODE_P";
		((DataGridViewColumn)val5).Width = 43;
		((DataGridViewColumn)val5).ReadOnly = false;
		DataGridView2.Columns.Add((DataGridViewColumn)(object)val5);
		checked
		{
			int num = _dt.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView2.Rows.Add(new object[5]
				{
					false,
					_dt.Rows[num2]["ID_TICKET"].ToString(),
					_dt.Rows[num2]["TOTAL_NET"].ToString(),
					_dt.Rows[num2]["OPERATION"].ToString(),
					""
				});
				num2++;
			}
			int num5 = DataGridView2.Rows.Count - 1;
			int num6 = 0;
			while (true)
			{
				int num7 = num6;
				int num4 = num5;
				if (num7 > num4)
				{
					break;
				}
				_dt.Clear();
				_dt = new DataTable();
				_da = new MySqlDataAdapter("select   ID_TICKET, MODE_P     from    TABLE_VENTES_REGLEMENTS   Where  Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '     And     ID_TICKET  = '" + DataGridView2.Rows[num6].Cells[1].Value.ToString() + "'      order by ID desc", Module1.cn_SQL);
				((DbDataAdapter)(object)_da).Fill(_dt);
				int num8 = _dt.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView2.Rows[num6].Cells[4].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(DataGridView2.Rows[num6].Cells[4].Value, ";"), _dt.Rows[num9]["MODE_P"].ToString());
					num9++;
				}
				num6++;
			}
			decimal num11 = 0m;
			int num12 = DataGridView2.Rows.Count - 1;
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				int num4 = num12;
				if (num14 > num4)
				{
					break;
				}
				num11 = Conversions.ToDecimal(Operators.AddObject(num11, DataGridView2.Rows[num13].Cells[2].Value));
				num13++;
			}
			TextBox1.Text = Conversions.ToString(num11);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = DataGridView2.RowCount - 1;
			while (true)
			{
				int num2 = num;
				int num3 = 0;
				if (num2 < num3)
				{
					break;
				}
				if (!DataGridView2.Rows[num].Cells[4].Value.ToString().Contains("ESPECES"))
				{
					DataGridView2.Rows.RemoveAt(num);
				}
				num += -1;
			}
			int num4 = DataGridView2.RowCount - 1;
			while (true)
			{
				int num5 = num4;
				int num3 = 0;
				if (num5 < num3)
				{
					break;
				}
				if (DataGridView2.Rows[num4].Cells[4].Value.ToString().Contains("CARTE"))
				{
					DataGridView2.Rows.RemoveAt(num4);
				}
				num4 += -1;
			}
			decimal num6 = 0m;
			int num7 = DataGridView2.Rows.Count - 1;
			int num8 = 0;
			while (true)
			{
				int num9 = num8;
				int num3 = num7;
				if (num9 > num3)
				{
					break;
				}
				num6 = Conversions.ToDecimal(Operators.AddObject(num6, DataGridView2.Rows[num8].Cells[2].Value));
				num8++;
			}
			TextBox2.Text = Conversions.ToString(num6);
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = DataGridView2.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView2.Rows[num2].Cells[0].Value = false;
				num2++;
			}
			decimal num6;
			do
			{
				Random random = new Random();
				int num5 = random.Next(0, DataGridView2.Rows.Count - 1);
				DataGridView2.Rows[num5].Cells[0].Value = true;
				num6 = 0m;
				int num7 = DataGridView2.Rows.Count - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num4 = num7;
					if (num9 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num8].Cells[0].Value, true, TextCompare: false))
					{
						num6 = Conversions.ToDecimal(Operators.AddObject(num6, DataGridView2.Rows[num8].Cells[2].Value));
					}
					num8++;
				}
			}
			while (!(Convert.ToDouble(num6) >= Conversion.Val(TextBox3.Text)));
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		decimal num = 0m;
		checked
		{
			int num2 = DataGridView2.Rows.Count - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells[0].Value, true, TextCompare: false))
				{
					num = Conversions.ToDecimal(Operators.AddObject(num, DataGridView2.Rows[num3].Cells[2].Value));
				}
				num3++;
			}
			TextBox4.Text = Conversions.ToString(num);
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		MySqlCommand val = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		checked
		{
			int num = DataGridView2.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num2].Cells[0].Value, true, TextCompare: false))
				{
					val.CommandText = "Delete   from TABLE_VENTES_ENTETE     where   ID_TICKET = '" + DataGridView2.Rows[num2].Cells[1].Value.ToString() + "'      and   Dates   between        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '    ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "Delete   from TABLE_VENTES_JOURNAL     where   ID_TICKET = '" + DataGridView2.Rows[num2].Cells[1].Value.ToString() + "'      and   Dates   between        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '    ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "Delete   from TABLE_VENTES_REGLEMENTS     where   ID_TICKET = '" + DataGridView2.Rows[num2].Cells[1].Value.ToString() + "'      and   Dates   between        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '    ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
				}
				num2++;
			}
			Module1.cn_SQL.Close();
		}
	}

	private void FlowLayout_FAMILLES_DoubleClick(object sender, EventArgs e)
	{
		checked
		{
			a++;
			if ((a == 10) & CheckBox1.Checked)
			{
				((Control)Panel1).Visible = true;
			}
		}
	}

	private void FlowLayout_FAMILLES_Paint(object sender, PaintEventArgs e)
	{
	}
}
