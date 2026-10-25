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
public class Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("DATESs")]
	private DataGridViewTextBoxColumn _DATESs;

	[AccessedThroughProperty("HEURE")]
	private DataGridViewTextBoxColumn _HEURE;

	[AccessedThroughProperty("UTILISATEUR")]
	private DataGridViewTextBoxColumn _UTILISATEUR;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("VALEUR_ANCIENNE")]
	private DataGridViewTextBoxColumn _VALEUR_ANCIENNE;

	[AccessedThroughProperty("VALEUR_NOUVELLE")]
	private DataGridViewTextBoxColumn _VALEUR_NOUVELLE;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Button_RJ1")]
	private Button_RJ _Button_RJ1;

	[AccessedThroughProperty("Button_RJ4")]
	private Button_RJ _Button_RJ4;

	[AccessedThroughProperty("Button_RJ3")]
	private Button_RJ _Button_RJ3;

	[AccessedThroughProperty("Button_RJ2")]
	private Button_RJ _Button_RJ2;

	[AccessedThroughProperty("Picture_REFRESH")]
	private Button_RJ _Picture_REFRESH;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Panel112233")]
	private Panel _Panel112233;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	private int x;

	private int y;

	private Point newpoint;

	private DataTable _dt;

	private MySqlDataAdapter _da;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView1_CellEnter;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			DataGridViewBindingCompleteEventHandler val3 = DataGridView1_DataBindingComplete;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellEnter -= val;
				_DataGridView1.CellContentClick -= val2;
				_DataGridView1.DataBindingComplete -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellEnter += val;
				_DataGridView1.CellContentClick += val2;
				_DataGridView1.DataBindingComplete += val3;
			}
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

	internal virtual DataGridViewTextBoxColumn HEURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _HEURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HEURE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UTILISATEUR = value;
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

	internal virtual DataGridViewTextBoxColumn VALEUR_ANCIENNE
	{
		[DebuggerNonUserCode]
		get
		{
			return _VALEUR_ANCIENNE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VALEUR_ANCIENNE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn VALEUR_NOUVELLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _VALEUR_NOUVELLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VALEUR_NOUVELLE = value;
		}
	}

	internal virtual Label Label_TABLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TABLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = Label_TABLE_Click;
			MouseEventHandler val = Label_TOP_MouseMove;
			MouseEventHandler val2 = Label_TOP_MouseDown;
			if (_Label_TABLE != null)
			{
				((Control)_Label_TABLE).Click -= eventHandler;
				((Control)_Label_TABLE).MouseMove -= val;
				((Control)_Label_TABLE).MouseDown -= val2;
			}
			_Label_TABLE = value;
			if (_Label_TABLE != null)
			{
				((Control)_Label_TABLE).Click += eventHandler;
				((Control)_Label_TABLE).MouseMove += val;
				((Control)_Label_TABLE).MouseDown += val2;
			}
		}
	}

	internal virtual Button Button244
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button244;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button244_Click;
			if (_Button244 != null)
			{
				((Control)_Button244).Click -= eventHandler;
			}
			_Button244 = value;
			if (_Button244 != null)
			{
				((Control)_Button244).Click += eventHandler;
			}
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel2 = value;
		}
	}

	internal virtual Button_RJ Button_RJ1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ1_Click;
			if (_Button_RJ1 != null)
			{
				((Control)_Button_RJ1).Click -= eventHandler;
			}
			_Button_RJ1 = value;
			if (_Button_RJ1 != null)
			{
				((Control)_Button_RJ1).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RJ4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ4_Click;
			if (_Button_RJ4 != null)
			{
				((Control)_Button_RJ4).Click -= eventHandler;
			}
			_Button_RJ4 = value;
			if (_Button_RJ4 != null)
			{
				((Control)_Button_RJ4).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RJ3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ3_Click;
			if (_Button_RJ3 != null)
			{
				((Control)_Button_RJ3).Click -= eventHandler;
			}
			_Button_RJ3 = value;
			if (_Button_RJ3 != null)
			{
				((Control)_Button_RJ3).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RJ2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ2_Click;
			if (_Button_RJ2 != null)
			{
				((Control)_Button_RJ2).Click -= eventHandler;
			}
			_Button_RJ2 = value;
			if (_Button_RJ2 != null)
			{
				((Control)_Button_RJ2).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Picture_REFRESH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_REFRESH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_REFRESH_Click;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click -= eventHandler;
			}
			_Picture_REFRESH = value;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_FIND = value;
		}
	}

	internal virtual Panel Panel112233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel112233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel112233 = value;
		}
	}

	internal virtual Label Label_TOTAL_LIGNES_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_LIGNES_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_LIGNES_BD = value;
		}
	}

	internal virtual Button Button_CALC_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_BD_Click;
			if (_Button_CALC_BD != null)
			{
				((Control)_Button_CALC_BD).Click -= eventHandler;
			}
			_Button_CALC_BD = value;
			if (_Button_CALC_BD != null)
			{
				((Control)_Button_CALC_BD).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label4141
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4141;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4141 = value;
		}
	}

	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	public Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_me_Load;
		__ENCAddToList(this);
		newpoint = default;
		_dt = new DataTable();
		_da = new MySqlDataAdapter();
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
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected Obj, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected Obj, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected Obj, but got Unknown
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected Obj, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected Obj, but got Unknown
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected Obj, but got Unknown
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected Obj, but got Unknown
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected Obj, but got Unknown
		//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ba: Expected Obj, but got Unknown
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL));
		DataGridView1 = new DataGridView();
		DATESs = new DataGridViewTextBoxColumn();
		HEURE = new DataGridViewTextBoxColumn();
		UTILISATEUR = new DataGridViewTextBoxColumn();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		VALEUR_ANCIENNE = new DataGridViewTextBoxColumn();
		VALEUR_NOUVELLE = new DataGridViewTextBoxColumn();
		Label_TABLE = new Label();
		Button244 = new Button();
		TableLayoutPanel2 = new TableLayoutPanel();
		Button_RJ4 = new Button_RJ();
		Button_RJ3 = new Button_RJ();
		Button_RJ2 = new Button_RJ();
		Button_RJ1 = new Button_RJ();
		Picture_REFRESH = new Button_RJ();
		Panel_FIND = new Panel();
		Panel112233 = new Panel();
		Label_TOTAL_LIGNES_BD = new Label();
		Button_CALC_BD = new Button();
		Label4141 = new Label();
		Label28 = new Label();
		Label27 = new Label();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel112233).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Tahoma", 8f);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)DATESs,
			(DataGridViewColumn)HEURE,
			(DataGridViewColumn)UTILISATEUR,
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)VALEUR_ANCIENNE,
			(DataGridViewColumn)VALEUR_NOUVELLE
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 10f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		((Control)DataGridView1).Dock = (DockStyle)5;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(0, 76);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(850, 362);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 2;
		((DataGridViewColumn)DATESs).DataPropertyName = "DATES";
		((DataGridViewColumn)DATESs).HeaderText = "DATES";
		((DataGridViewColumn)DATESs).Name = "DATESs";
		((DataGridViewColumn)HEURE).DataPropertyName = "HEURE";
		((DataGridViewColumn)HEURE).HeaderText = "HEURE";
		((DataGridViewColumn)HEURE).Name = "HEURE";
		((DataGridViewColumn)UTILISATEUR).DataPropertyName = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).HeaderText = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).Name = "UTILISATEUR";
		((DataGridViewColumn)ID_CLIENT).DataPropertyName = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)VALEUR_ANCIENNE).DataPropertyName = "VALEUR_ANCIENNE";
		((DataGridViewColumn)VALEUR_ANCIENNE).HeaderText = "VALEUR_ANCIENNE";
		((DataGridViewColumn)VALEUR_ANCIENNE).Name = "VALEUR_ANCIENNE";
		((DataGridViewColumn)VALEUR_NOUVELLE).DataPropertyName = "VALEUR_NOUVELLE";
		((DataGridViewColumn)VALEUR_NOUVELLE).HeaderText = "VALEUR_NOUVELLE";
		((DataGridViewColumn)VALEUR_NOUVELLE).Name = "VALEUR_NOUVELLE";
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(850, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1038;
		Label_TABLE.Text = "CLIENTS_HISTORIQUE_CREDIT_INITIAL";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Button244).Anchor = (AnchorStyles)9;
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((ButtonBase)Button244).FlatStyle = (FlatStyle)0;
		((Control)Button244).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button244).ForeColor = Color.White;
		((ButtonBase)Button244).Image = (Image)componentResourceManager.GetObject("Button244.Image");
		((ButtonBase)Button244).ImeMode = (ImeMode)0;
		Button button = Button244;
		location = new Point(793, 0);
		((Control)button).Location = location;
		Button button2 = Button244;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button244).Name = "Button244";
		Button button3 = Button244;
		size = new Size(57, 29);
		((Control)button3).Size = size;
		((Control)Button244).TabIndex = 1039;
		((ButtonBase)Button244).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		TableLayoutPanel2.ColumnCount = 4;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 20f));
		TableLayoutPanel2.Controls.Add((Control)(object)Button_RJ4, 3, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_RJ3, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_RJ2, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Button_RJ1, 0, 0);
		((Control)TableLayoutPanel2).Dock = (DockStyle)1;
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel2;
		location = new Point(0, 30);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel2.RowCount = 1;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 46f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel2;
		size = new Size(850, 46);
		((Control)tableLayoutPanel2).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1042;
		Button_RJ4._BackgroundColor = Color.White;
		Button_RJ4._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._BorderRadius = 8;
		Button_RJ4._BorderSize = 1;
		Button_RJ4._TextColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ4).BackColor = Color.White;
		((Control)Button_RJ4).Cursor = Cursors.Hand;
		((Control)Button_RJ4).Dock = (DockStyle)5;
		((ButtonBase)Button_RJ4).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ4).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ4).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_RJ4).ForeColor = Color.FromArgb(22, 106, 238);
		Button_RJ button_RJ = Button_RJ4;
		location = new Point(639, 3);
		((Control)button_RJ).Location = location;
		((Control)Button_RJ4).Name = "Button_RJ4";
		Button_RJ button_RJ2 = Button_RJ4;
		size = new Size(208, 40);
		((Control)button_RJ2).Size = size;
		((Control)Button_RJ4).TabIndex = 1046;
		((ButtonBase)Button_RJ4).Text = "Année";
		((ButtonBase)Button_RJ4).UseVisualStyleBackColor = false;
		Button_RJ3._BackgroundColor = Color.White;
		Button_RJ3._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._BorderRadius = 8;
		Button_RJ3._BorderSize = 1;
		Button_RJ3._TextColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ3).BackColor = Color.White;
		((Control)Button_RJ3).Cursor = Cursors.Hand;
		((Control)Button_RJ3).Dock = (DockStyle)5;
		((ButtonBase)Button_RJ3).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ3).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ3).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_RJ3).ForeColor = Color.FromArgb(22, 106, 238);
		Button_RJ button_RJ3 = Button_RJ3;
		location = new Point(427, 3);
		((Control)button_RJ3).Location = location;
		((Control)Button_RJ3).Name = "Button_RJ3";
		Button_RJ button_RJ4 = Button_RJ3;
		size = new Size(206, 40);
		((Control)button_RJ4).Size = size;
		((Control)Button_RJ3).TabIndex = 1045;
		((ButtonBase)Button_RJ3).Text = "Mois";
		((ButtonBase)Button_RJ3).UseVisualStyleBackColor = false;
		Button_RJ2._BackgroundColor = Color.White;
		Button_RJ2._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._BorderRadius = 8;
		Button_RJ2._BorderSize = 1;
		Button_RJ2._TextColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ2).BackColor = Color.White;
		((Control)Button_RJ2).Cursor = Cursors.Hand;
		((Control)Button_RJ2).Dock = (DockStyle)5;
		((ButtonBase)Button_RJ2).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ2).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ2).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_RJ2).ForeColor = Color.FromArgb(22, 106, 238);
		Button_RJ button_RJ5 = Button_RJ2;
		location = new Point(215, 3);
		((Control)button_RJ5).Location = location;
		((Control)Button_RJ2).Name = "Button_RJ2";
		Button_RJ button_RJ6 = Button_RJ2;
		size = new Size(206, 40);
		((Control)button_RJ6).Size = size;
		((Control)Button_RJ2).TabIndex = 1044;
		((ButtonBase)Button_RJ2).Text = "Semaine";
		((ButtonBase)Button_RJ2).UseVisualStyleBackColor = false;
		Button_RJ1._BackgroundColor = Color.White;
		Button_RJ1._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ1._BorderRadius = 8;
		Button_RJ1._BorderSize = 1;
		Button_RJ1._TextColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ1).BackColor = Color.White;
		((Control)Button_RJ1).Cursor = Cursors.Hand;
		((Control)Button_RJ1).Dock = (DockStyle)5;
		((ButtonBase)Button_RJ1).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ1).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ1).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_RJ1).ForeColor = Color.FromArgb(22, 106, 238);
		Button_RJ button_RJ7 = Button_RJ1;
		location = new Point(3, 3);
		((Control)button_RJ7).Location = location;
		((Control)Button_RJ1).Name = "Button_RJ1";
		Button_RJ button_RJ8 = Button_RJ1;
		size = new Size(206, 40);
		((Control)button_RJ8).Size = size;
		((Control)Button_RJ1).TabIndex = 1043;
		((ButtonBase)Button_RJ1).Text = "Jour";
		((ButtonBase)Button_RJ1).UseVisualStyleBackColor = false;
		Picture_REFRESH._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_REFRESH._BorderColor = Color.White;
		Picture_REFRESH._BorderRadius = 16;
		Picture_REFRESH._BorderSize = 1;
		Picture_REFRESH._TextColor = Color.White;
		((ButtonBase)Picture_REFRESH).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_REFRESH).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_REFRESH).FlatStyle = (FlatStyle)0;
		((Control)Picture_REFRESH).ForeColor = Color.White;
		((ButtonBase)Picture_REFRESH).Image = (Image)componentResourceManager.GetObject("Picture_REFRESH.Image");
		Button_RJ picture_REFRESH = Picture_REFRESH;
		location = new Point(4, 0);
		((Control)picture_REFRESH).Location = location;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		Button_RJ picture_REFRESH2 = Picture_REFRESH;
		size = new Size(30, 30);
		((Control)picture_REFRESH2).Size = size;
		((Control)Picture_REFRESH).TabIndex = 1062;
		((ButtonBase)Picture_REFRESH).UseVisualStyleBackColor = false;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		Panel panel_FIND = Panel_FIND;
		location = new Point(252, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(41, 30);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1063;
		((Control)Panel112233).BackColor = Color.Transparent;
		((Control)Panel112233).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Button_CALC_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Label4141);
		((Control)Panel112233).Controls.Add((Control)(object)Label28);
		((Control)Panel112233).Controls.Add((Control)(object)Label27);
		((Control)Panel112233).Dock = (DockStyle)2;
		Panel panel = Panel112233;
		location = new Point(0, 407);
		((Control)panel).Location = location;
		((Control)Panel112233).Name = "Panel112233";
		Panel panel2 = Panel112233;
		size = new Size(850, 31);
		((Control)panel2).Size = size;
		((Control)Panel112233).TabIndex = 1064;
		((Control)Label_TOTAL_LIGNES_BD).BackColor = Color.White;
		((Control)Label_TOTAL_LIGNES_BD).Font = new Font("Calibri", 11f, (FontStyle)1);
		((Control)Label_TOTAL_LIGNES_BD).ForeColor = Color.FromArgb(64, 64, 64);
		Label label_TOTAL_LIGNES_BD = Label_TOTAL_LIGNES_BD;
		location = new Point(3, 1);
		((Control)label_TOTAL_LIGNES_BD).Location = location;
		((Control)Label_TOTAL_LIGNES_BD).Name = "Label_TOTAL_LIGNES_BD";
		Label label_TOTAL_LIGNES_BD2 = Label_TOTAL_LIGNES_BD;
		size = new Size(66, 29);
		((Control)label_TOTAL_LIGNES_BD2).Size = size;
		((Control)Label_TOTAL_LIGNES_BD).TabIndex = 1070;
		Label_TOTAL_LIGNES_BD.Text = "-/-";
		Label_TOTAL_LIGNES_BD.TextAlign = (ContentAlignment)16;
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		Button button_CALC_BD = Button_CALC_BD;
		location = new Point(190, 5);
		((Control)button_CALC_BD).Location = location;
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		Button button_CALC_BD2 = Button_CALC_BD;
		size = new Size(48, 16);
		((Control)button_CALC_BD2).Size = size;
		((Control)Button_CALC_BD).TabIndex = 985;
		((ButtonBase)Button_CALC_BD).Text = "CALC";
		((ButtonBase)Button_CALC_BD).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		((Control)Button_CALC_BD).Visible = false;
		((Control)Label4141).Anchor = (AnchorStyles)9;
		((Control)Label4141).BackColor = Color.White;
		((Control)Label4141).Font = new Font("Calibri", 11f, (FontStyle)1);
		((Control)Label4141).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label4141;
		location = new Point(473, 1);
		((Control)label).Location = location;
		((Control)Label4141).Name = "Label4141";
		Label label2 = Label4141;
		size = new Size(375, 29);
		((Control)label2).Size = size;
		((Control)Label4141).TabIndex = 1066;
		Label4141.Text = "-";
		Label4141.TextAlign = (ContentAlignment)64;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)2;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label3 = Label28;
		location = new Point(0, 30);
		((Control)label3).Location = location;
		((Control)Label28).Name = "Label28";
		Label label4 = Label28;
		size = new Size(850, 1);
		((Control)label4).Size = size;
		((Control)Label28).TabIndex = 1064;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)1;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label5 = Label27;
		location = new Point(0, 0);
		((Control)label5).Location = location;
		((Control)Label27).Name = "Label27";
		Label label6 = Label27;
		size = new Size(850, 1);
		((Control)label6).Size = size;
		((Control)Label27).TabIndex = 1063;
		Label27.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(850, 438);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Panel112233);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)this).Controls.Add((Control)(object)Button244);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel112233).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Label_TOP_MouseDown(object sender, MouseEventArgs e)
	{
		checked
		{
			x = Control.MousePosition.X - ((Form)this).Location.X;
			y = Control.MousePosition.Y - ((Form)this).Location.Y;
		}
	}

	private void Label_TOP_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			newpoint = Control.MousePosition;
			checked
			{
				newpoint.X -= x;
				newpoint.Y -= y;
				((Form)this).Location = newpoint;
				Application.DoEvents();
			}
		}
	}

	private void FormDialog_me_Load(object sender, EventArgs e)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 30;
				DataGridView1.DataSource = _dt;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
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
				DataGridView1.AllowUserToAddRows = false;
				DataGridView1.AllowUserToDeleteRows = false;
				DataGridView1.AllowUserToOrderColumns = true;
				DataGridView1.AllowUserToResizeColumns = true;
				DataGridView1.AllowUserToResizeRows = false;
				Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button_RJ1_Click(object sender, EventArgs e)
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		Button_RJ1._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._BackgroundColor = Color.White;
		Button_RJ3._BackgroundColor = Color.White;
		Button_RJ4._BackgroundColor = Color.White;
		Button_RJ1._TextColor = Color.White;
		Button_RJ2._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._TextColor = Color.FromArgb(22, 106, 238);
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter("select *    from       TABLE_" + Label_TABLE.Text + "    Where        Dates = ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '            ORDER by  ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.DataSource = _dt;
	}

	private void Button_RJ2_Click(object sender, EventArgs e)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		Button_RJ1._BackgroundColor = Color.White;
		Button_RJ2._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._BackgroundColor = Color.White;
		Button_RJ4._BackgroundColor = Color.White;
		Button_RJ1._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._TextColor = Color.White;
		Button_RJ3._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._TextColor = Color.FromArgb(22, 106, 238);
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter(checked("select *    from       TABLE_" + Label_TABLE.Text + "     where       Dates   between   ' " + DateAndTime.DateAdd("d", 1 - DateAndTime.Weekday(DateAndTime.Today, FirstDayOfWeek.Monday), DateAndTime.Today).ToString("yyyy-MM-dd") + " '     And      ' " + DateAndTime.DateAdd("d", 1 - DateAndTime.Weekday(DateAndTime.Today, FirstDayOfWeek.Monday), DateAndTime.Today).AddDays(6.0).ToString("yyyy-MM-dd")) + " '            ORDER by  ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.DataSource = _dt;
	}

	private void Button_RJ3_Click(object sender, EventArgs e)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		Button_RJ1._BackgroundColor = Color.White;
		Button_RJ2._BackgroundColor = Color.White;
		Button_RJ3._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._BackgroundColor = Color.White;
		Button_RJ1._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._TextColor = Color.White;
		Button_RJ4._TextColor = Color.FromArgb(22, 106, 238);
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter("select *    from       TABLE_" + Label_TABLE.Text + "    Where         (MONTH(Dates) = " + DateTime.Now.ToString("MM") + " )          and           (year(Dates) = " + DateTime.Now.ToString("yyy") + " )                   ORDER by  ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.DataSource = _dt;
	}

	private void Button_RJ4_Click(object sender, EventArgs e)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		Button_RJ1._BackgroundColor = Color.White;
		Button_RJ2._BackgroundColor = Color.White;
		Button_RJ3._BackgroundColor = Color.White;
		Button_RJ4._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ1._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._TextColor = Color.White;
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter("select *    from       TABLE_" + Label_TABLE.Text + "    Where                 (year(Dates) = " + DateTime.Now.ToString("yyy") + " )                 ORDER by  ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.DataSource = _dt;
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
	}

	private void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		Button_RJ1._BackgroundColor = Color.White;
		Button_RJ2._BackgroundColor = Color.White;
		Button_RJ3._BackgroundColor = Color.White;
		Button_RJ4._BackgroundColor = Color.White;
		Button_RJ1._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ2._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ3._TextColor = Color.FromArgb(22, 106, 238);
		Button_RJ4._TextColor = Color.FromArgb(22, 106, 238);
		_dt.Clear();
		_dt = new DataTable();
		_da = new MySqlDataAdapter("select *    from       TABLE_" + Label_TABLE.Text + "         ORDER by  ID desc", Module1.cn_SQL);
		((DbDataAdapter)(object)_da).Fill(_dt);
		DataGridView1.DataSource = _dt;
		Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Label_TABLE_Click(object sender, EventArgs e)
	{
	}

	private void Button_CALC_BD_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count > 0)
		{
			Label_TOTAL_LIGNES_BD.Text = Conversions.ToString(Conversions.ToDouble(DataGridView1.CurrentCell.RowIndex.ToString()) + 1.0) + "/" + Conversions.ToString(DataGridView1.Rows.Count);
		}
		else
		{
			Label_TOTAL_LIGNES_BD.Text = Conversions.ToString(0) + "/" + Conversions.ToString(0);
		}
		Label4141.Text = "Nbr Lignes : " + Conversions.ToString(DataGridView1.Rows.Count);
	}
}
