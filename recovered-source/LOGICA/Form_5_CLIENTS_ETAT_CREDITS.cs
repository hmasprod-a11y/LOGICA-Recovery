using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_5_CLIENTS_ETAT_CREDITS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel_SITUATION")]
	private Panel _Panel_SITUATION;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Button_ok")]
	private Button _Button_ok;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Button_PRINT_80MM")]
	private Button _Button_PRINT_80MM;

	[AccessedThroughProperty("Button_PRINT_A4")]
	private Button _Button_PRINT_A4;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Print_CLIENTS")]
	private PrintDocument _Print_CLIENTS;

	[AccessedThroughProperty("Text_TOTAL_RELIQUAT")]
	private TextBox _Text_TOTAL_RELIQUAT;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("ID_CLIENT")]
	private DataGridViewTextBoxColumn _ID_CLIENT;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("CREDIT_INITIAL")]
	private DataGridViewTextBoxColumn _CREDIT_INITIAL;

	[AccessedThroughProperty("TOTAL_CREDIT")]
	private DataGridViewTextBoxColumn _TOTAL_CREDIT;

	[AccessedThroughProperty("TOTAL_RETOUR")]
	private DataGridViewTextBoxColumn _TOTAL_RETOUR;

	[AccessedThroughProperty("TOTAL_REGLE")]
	private DataGridViewTextBoxColumn _TOTAL_REGLE;

	[AccessedThroughProperty("RELIQUAT")]
	private DataGridViewTextBoxColumn _RELIQUAT;

	internal virtual Panel Panel_SITUATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_SITUATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_SITUATION = value;
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
		}
	}

	internal virtual Button Button_ok
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ok_Click;
			if (_Button_ok != null)
			{
				((Control)_Button_ok).Click -= eventHandler;
			}
			_Button_ok = value;
			if (_Button_ok != null)
			{
				((Control)_Button_ok).Click += eventHandler;
			}
		}
	}

	internal virtual DateTimePicker DateTime1_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTime1_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTime1_FIND = value;
		}
	}

	internal virtual DateTimePicker DateTime2_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTime2_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTime2_FIND = value;
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

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
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

	internal virtual Button Button_PRINT_80MM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRINT_80MM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRINT_80MM_Click;
			if (_Button_PRINT_80MM != null)
			{
				((Control)_Button_PRINT_80MM).Click -= eventHandler;
			}
			_Button_PRINT_80MM = value;
			if (_Button_PRINT_80MM != null)
			{
				((Control)_Button_PRINT_80MM).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PRINT_A4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRINT_A4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRINT_A4_Click;
			if (_Button_PRINT_A4 != null)
			{
				((Control)_Button_PRINT_A4).Click -= eventHandler;
			}
			_Button_PRINT_A4 = value;
			if (_Button_PRINT_A4 != null)
			{
				((Control)_Button_PRINT_A4).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PrintRapport
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintRapport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PrintRapport_Click;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click -= eventHandler;
			}
			_Button_PrintRapport = value;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click += eventHandler;
			}
		}
	}

	internal virtual PrintDocument Print_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_CLIENTS_PrintPage;
			if (_Print_CLIENTS != null)
			{
				_Print_CLIENTS.PrintPage -= val;
			}
			_Print_CLIENTS = value;
			if (_Print_CLIENTS != null)
			{
				_Print_CLIENTS.PrintPage += val;
			}
		}
	}

	internal virtual TextBox Text_TOTAL_RELIQUAT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL_RELIQUAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TOTAL_RELIQUAT = value;
		}
	}

	internal virtual Label Label38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label38 = value;
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

	internal virtual DataGridViewTextBoxColumn CREDIT_INITIAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _CREDIT_INITIAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CREDIT_INITIAL = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_CREDIT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_RETOUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_RETOUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_RETOUR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_REGLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_REGLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_REGLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn RELIQUAT
	{
		[DebuggerNonUserCode]
		get
		{
			return _RELIQUAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RELIQUAT = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_5_CLIENTS_ETAT_CREDITS()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		((Form)this).Load += Form_5_CLIENTS_CREDIT_Load;
		((Control)this).KeyDown += me_KeyDown;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected Obj, but got Unknown
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected Obj, but got Unknown
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Expected Obj, but got Unknown
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected Obj, but got Unknown
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Expected Obj, but got Unknown
		//IL_1035: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Expected Obj, but got Unknown
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS_ETAT_CREDITS));
		Panel_SITUATION = new Panel();
		DataGridView1 = new DataGridView();
		ID_CLIENT = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		CREDIT_INITIAL = new DataGridViewTextBoxColumn();
		TOTAL_CREDIT = new DataGridViewTextBoxColumn();
		TOTAL_RETOUR = new DataGridViewTextBoxColumn();
		TOTAL_REGLE = new DataGridViewTextBoxColumn();
		RELIQUAT = new DataGridViewTextBoxColumn();
		Text_TOTAL_RELIQUAT = new TextBox();
		Label38 = new Label();
		PictureBox5 = new PictureBox();
		Button_ok = new Button();
		DateTime1_FIND = new DateTimePicker();
		DateTime2_FIND = new DateTimePicker();
		Label11 = new Label();
		Label14 = new Label();
		Label26 = new Label();
		Label28 = new Label();
		Button_PRINT_A4 = new Button();
		Button_PrintRapport = new Button();
		Button_PRINT_80MM = new Button();
		Print_CLIENTS = new PrintDocument();
		((Control)Panel_SITUATION).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_SITUATION).BackColor = Color.White;
		Panel_SITUATION.BorderStyle = (BorderStyle)1;
		((Control)Panel_SITUATION).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Text_TOTAL_RELIQUAT);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Label38);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Button_ok);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Label11);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Label14);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Label26);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Label28);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Button_PRINT_A4);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Button_PrintRapport);
		((Control)Panel_SITUATION).Controls.Add((Control)(object)Button_PRINT_80MM);
		((Control)Panel_SITUATION).Dock = (DockStyle)5;
		Panel panel_SITUATION = Panel_SITUATION;
		Point location = new Point(0, 0);
		((Control)panel_SITUATION).Location = location;
		((Control)Panel_SITUATION).Name = "Panel_SITUATION";
		Panel panel_SITUATION2 = Panel_SITUATION;
		Size size = new Size(1025, 692);
		((Control)panel_SITUATION2).Size = size;
		((Control)Panel_SITUATION).TabIndex = 1046;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 9f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[7]
		{
			(DataGridViewColumn)ID_CLIENT,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)CREDIT_INITIAL,
			(DataGridViewColumn)TOTAL_CREDIT,
			(DataGridViewColumn)TOTAL_RETOUR,
			(DataGridViewColumn)TOTAL_REGLE,
			(DataGridViewColumn)RELIQUAT
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		location = new Point(12, 68);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1000, 533);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1069;
		((DataGridViewColumn)ID_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_CLIENT).HeaderText = "ID_CLIENT";
		((DataGridViewColumn)ID_CLIENT).MinimumWidth = 2;
		((DataGridViewColumn)ID_CLIENT).Name = "ID_CLIENT";
		ID_CLIENT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		CLIENT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)CREDIT_INITIAL).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "N2";
		val2.NullValue = null;
		((DataGridViewColumn)CREDIT_INITIAL).DefaultCellStyle = val2;
		((DataGridViewColumn)CREDIT_INITIAL).HeaderText = "CREDIT INITIAL";
		((DataGridViewColumn)CREDIT_INITIAL).Name = "CREDIT_INITIAL";
		CREDIT_INITIAL.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TOTAL_CREDIT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)TOTAL_CREDIT).DefaultCellStyle = val3;
		((DataGridViewColumn)TOTAL_CREDIT).HeaderText = "TOTAL CREDIT";
		((DataGridViewColumn)TOTAL_CREDIT).Name = "TOTAL_CREDIT";
		TOTAL_CREDIT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TOTAL_RETOUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)TOTAL_RETOUR).DefaultCellStyle = val4;
		((DataGridViewColumn)TOTAL_RETOUR).HeaderText = "TOTAL RETOUR";
		((DataGridViewColumn)TOTAL_RETOUR).Name = "TOTAL_RETOUR";
		TOTAL_RETOUR.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TOTAL_REGLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		val5.NullValue = null;
		((DataGridViewColumn)TOTAL_REGLE).DefaultCellStyle = val5;
		((DataGridViewColumn)TOTAL_REGLE).HeaderText = "TOTAL REGLE";
		((DataGridViewColumn)TOTAL_REGLE).Name = "TOTAL_REGLE";
		TOTAL_REGLE.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)RELIQUAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "N2";
		val6.NullValue = null;
		((DataGridViewColumn)RELIQUAT).DefaultCellStyle = val6;
		((DataGridViewColumn)RELIQUAT).HeaderText = "RELIQUAT";
		((DataGridViewColumn)RELIQUAT).Name = "RELIQUAT";
		RELIQUAT.SortMode = (DataGridViewColumnSortMode)2;
		((Control)Text_TOTAL_RELIQUAT).Anchor = (AnchorStyles)9;
		((TextBoxBase)Text_TOTAL_RELIQUAT).BackColor = Color.FromArgb(64, 64, 64);
		((TextBoxBase)Text_TOTAL_RELIQUAT).BorderStyle = (BorderStyle)1;
		((Control)Text_TOTAL_RELIQUAT).Font = new Font("Cambria", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)Text_TOTAL_RELIQUAT).ForeColor = Color.White;
		TextBox text_TOTAL_RELIQUAT = Text_TOTAL_RELIQUAT;
		location = new Point(868, 607);
		((Control)text_TOTAL_RELIQUAT).Location = location;
		((Control)Text_TOTAL_RELIQUAT).Name = "Text_TOTAL_RELIQUAT";
		((TextBoxBase)Text_TOTAL_RELIQUAT).ReadOnly = true;
		TextBox text_TOTAL_RELIQUAT2 = Text_TOTAL_RELIQUAT;
		size = new Size(145, 26);
		((Control)text_TOTAL_RELIQUAT2).Size = size;
		((Control)Text_TOTAL_RELIQUAT).TabIndex = 1067;
		Text_TOTAL_RELIQUAT.TextAlign = (HorizontalAlignment)1;
		((Control)Label38).Anchor = (AnchorStyles)9;
		((Control)Label38).BackColor = Color.FromArgb(64, 64, 64);
		((Control)Label38).Font = new Font("Calibri", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label38).ForeColor = Color.White;
		Label label = Label38;
		location = new Point(735, 607);
		((Control)label).Location = location;
		((Control)Label38).Name = "Label38";
		Label label2 = Label38;
		size = new Size(142, 26);
		((Control)label2).Size = size;
		((Control)Label38).TabIndex = 1068;
		Label38.Text = "TOTAL RELIQUAT :";
		Label38.TextAlign = (ContentAlignment)16;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox = PictureBox5;
		location = new Point(113, 36);
		((Control)pictureBox).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox2 = PictureBox5;
		size = new Size(35, 22);
		((Control)pictureBox2).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)4;
		PictureBox5.TabIndex = 1047;
		PictureBox5.TabStop = false;
		((Control)Button_ok).Cursor = Cursors.Hand;
		((Control)Button_ok).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_ok).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button_ok).ImageAlign = (ContentAlignment)16;
		Button button_ok = Button_ok;
		location = new Point(252, 36);
		((Control)button_ok).Location = location;
		Button button_ok2 = Button_ok;
		Padding margin = new Padding(0);
		((Control)button_ok2).Margin = margin;
		((Control)Button_ok).Name = "Button_ok";
		Button button_ok3 = Button_ok;
		size = new Size(41, 22);
		((Control)button_ok3).Size = size;
		((Control)Button_ok).TabIndex = 1046;
		((ButtonBase)Button_ok).Text = "OK";
		((ButtonBase)Button_ok).UseVisualStyleBackColor = true;
		DateTime1_FIND.CustomFormat = "yyyy-MM-dd";
		((Control)DateTime1_FIND).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime1_FIND = DateTime1_FIND;
		location = new Point(12, 36);
		((Control)dateTime1_FIND).Location = location;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		DateTimePicker dateTime1_FIND2 = DateTime1_FIND;
		size = new Size(101, 22);
		((Control)dateTime1_FIND2).Size = size;
		((Control)DateTime1_FIND).TabIndex = 1045;
		DateTimePicker dateTime1_FIND3 = DateTime1_FIND;
		DateTime value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
		dateTime1_FIND3.Value = value;
		DateTime2_FIND.CustomFormat = "yyyy-MM-dd";
		((Control)DateTime2_FIND).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime2_FIND = DateTime2_FIND;
		location = new Point(148, 36);
		((Control)dateTime2_FIND).Location = location;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		DateTimePicker dateTime2_FIND2 = DateTime2_FIND;
		size = new Size(101, 22);
		((Control)dateTime2_FIND2).Size = size;
		((Control)DateTime2_FIND).TabIndex = 1044;
		((Control)Label11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).Dock = (DockStyle)2;
		((Control)Label11).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label3 = Label11;
		location = new Point(4, 686);
		((Control)label3).Location = location;
		((Control)Label11).Name = "Label11";
		Label label4 = Label11;
		size = new Size(1015, 4);
		((Control)label4).Size = size;
		((Control)Label11).TabIndex = 866;
		Label11.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)3;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label5 = Label14;
		location = new Point(0, 24);
		((Control)label5).Location = location;
		((Control)Label14).Name = "Label14";
		Label label6 = Label14;
		size = new Size(4, 666);
		((Control)label6).Size = size;
		((Control)Label14).TabIndex = 865;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label26).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label26).Cursor = Cursors.Hand;
		((Control)Label26).Dock = (DockStyle)4;
		((Control)Label26).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label26).ForeColor = Color.White;
		Label label7 = Label26;
		location = new Point(1019, 24);
		((Control)label7).Location = location;
		((Control)Label26).Name = "Label26";
		Label label8 = Label26;
		size = new Size(4, 666);
		((Control)label8).Size = size;
		((Control)Label26).TabIndex = 864;
		Label26.TextAlign = (ContentAlignment)16;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)1;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label9 = Label28;
		location = new Point(0, 0);
		((Control)label9).Location = location;
		((Control)Label28).Name = "Label28";
		Label label10 = Label28;
		size = new Size(1023, 24);
		((Control)label10).Size = size;
		((Control)Label28).TabIndex = 862;
		Label28.Text = "-";
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Button_PRINT_A4).Cursor = Cursors.Hand;
		((Control)Button_PRINT_A4).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PRINT_A4).ImageAlign = (ContentAlignment)16;
		Button button_PRINT_A = Button_PRINT_A4;
		location = new Point(932, 643);
		((Control)button_PRINT_A).Location = location;
		((Control)Button_PRINT_A4).Name = "Button_PRINT_A4";
		Button button_PRINT_A2 = Button_PRINT_A4;
		size = new Size(80, 36);
		((Control)button_PRINT_A2).Size = size;
		((Control)Button_PRINT_A4).TabIndex = 1064;
		((ButtonBase)Button_PRINT_A4).Text = "A4";
		((ButtonBase)Button_PRINT_A4).UseVisualStyleBackColor = true;
		((Control)Button_PRINT_A4).Visible = false;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(852, 643);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(160, 36);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 1062;
		((ButtonBase)Button_PrintRapport).Text = "IMPRIMER";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Button_PRINT_80MM).Cursor = Cursors.Hand;
		((Control)Button_PRINT_80MM).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PRINT_80MM).ImageAlign = (ContentAlignment)16;
		Button button_PRINT_80MM = Button_PRINT_80MM;
		location = new Point(852, 643);
		((Control)button_PRINT_80MM).Location = location;
		((Control)Button_PRINT_80MM).Name = "Button_PRINT_80MM";
		Button button_PRINT_80MM2 = Button_PRINT_80MM;
		size = new Size(80, 36);
		((Control)button_PRINT_80MM2).Size = size;
		((Control)Button_PRINT_80MM).TabIndex = 1063;
		((ButtonBase)Button_PRINT_80MM).Text = "80mm";
		((ButtonBase)Button_PRINT_80MM).UseVisualStyleBackColor = true;
		((Control)Button_PRINT_80MM).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_SITUATION);
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Form_5_CLIENTS_ETAT_CREDITS";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)Panel_SITUATION).ResumeLayout(false);
		((Control)Panel_SITUATION).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Button_ok_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select ID_CLIENT,CLIENT,CREDIT_INITIAL     from TABLE_CLIENTS     order  by CLIENT   ASC   ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView1.Rows.Clear();
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Rows.Add(new object[6]
					{
						dataTable.Rows[num2]["ID_CLIENT"].ToString(),
						dataTable.Rows[num2]["CLIENT"].ToString(),
						Conversions.ToDecimal(dataTable.Rows[num2]["CREDIT_INITIAL"].ToString()),
						"",
						"",
						""
					});
					num2++;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable.Clear();
					val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE   Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '         AND          ID_CLIENT  =  '" + DataGridView1.Rows[num6].Cells[0].Value.ToString() + "'            AND     OPERATION  =  'CREDIT'          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					decimal num8 = 0m;
					num8 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
					DataGridView1.Rows[num6].Cells["TOTAL_CREDIT"].Value = num8;
					dataTable.Clear();
					val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE   Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '         AND          ID_CLIENT  =  '" + DataGridView1.Rows[num6].Cells[0].Value.ToString() + "'            AND     OPERATION  =  'RETOUR CREDIT'          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					decimal num9 = 0m;
					num9 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
					DataGridView1.Rows[num6].Cells["TOTAL_RETOUR"].Value = num9;
					dataTable.Clear();
					val = new MySqlDataAdapter("select    SUM(MONTANT)      as N           from   TABLE_CLIENTS_REGLE       WHERE   Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '         AND           ID_CLIENT  =  '" + DataGridView1.Rows[num6].Cells[0].Value.ToString() + "'                  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					decimal num10 = 0m;
					num10 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
					DataGridView1.Rows[num6].Cells["TOTAL_REGLE"].Value = num10;
					DataGridView1.Rows[num6].Cells["RELIQUAT"].Value = Conversions.ToDecimal(Operators.SubtractObject(Operators.AddObject(decimal.Add(num8, num9), DataGridView1.Rows[num6].Cells["CREDIT_INITIAL"].Value), num10));
					num6++;
				}
				decimal num11 = 0m;
				int num12 = DataGridView1.Rows.Count - 1;
				int num13 = 0;
				while (true)
				{
					int num14 = num13;
					int num4 = num12;
					if (num14 > num4)
					{
						break;
					}
					num11 = Conversions.ToDecimal(Operators.AddObject(num11, DataGridView1.Rows[num13].Cells["RELIQUAT"].Value));
					num13++;
				}
				Text_TOTAL_RELIQUAT.Text = Strings.FormatNumber(Module1.FLOUSS(num11));
				int num15 = DataGridView1.Rows.Count - 1;
				while (true)
				{
					int num16 = num15;
					int num4 = 0;
					if (num16 < num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num15].Cells["RELIQUAT"].Value, 0, TextCompare: false))
					{
						DataGridView1.Rows.RemoveAt(num15);
					}
					num15 += -1;
				}
				DataGridView1.Sort(DataGridView1.Columns["RELIQUAT"], ListSortDirection.Descending);
				Module1._QUITTER_PATIENTER = true;
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

	private void me_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void Form_5_CLIENTS_CREDIT_Load(object sender, EventArgs e)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		DateTime1_FIND.Text = "01/01/2000";
		DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
		DataGridView1.RowTemplate.Height = 30;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
		DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
		DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
		DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
		DataGridView1.EnableHeadersVisualStyles = false;
		((DataGridViewCell)DataGridView1.Columns[2].HeaderCell).Style.BackColor = Color.Coral;
		((DataGridViewCell)DataGridView1.Columns[3].HeaderCell).Style.BackColor = Color.Coral;
		((DataGridViewCell)DataGridView1.Columns[4].HeaderCell).Style.BackColor = Color.Coral;
		((DataGridViewCell)DataGridView1.Columns[5].HeaderCell).Style.BackColor = Color.LawnGreen;
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
		checked
		{
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
		}
	}

	private void Button_PrintRapport_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count != 0)
		{
			NewLateBinding.LateSet(sender, null, "visible", new object[1] { false }, null, null);
			((Control)Button_PRINT_80MM).Visible = true;
			((Control)Button_PRINT_A4).Visible = true;
		}
	}

	private void Button_PRINT_80MM_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				PrintPreviewDialog val = new PrintPreviewDialog();
				val.Document = Print_CLIENTS;
				val.PrintPreviewControl.Zoom = 2.0;
				((Form)val).WindowState = (FormWindowState)2;
				((Form)val).ShowDialog();
				Module1._QUITTER_PATIENTER = true;
				((Control)Button_PrintRapport).Visible = true;
				((Control)Button_PRINT_80MM).Visible = false;
				((Control)Button_PRINT_A4).Visible = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.ToString());
				Module1._QUITTER_PATIENTER = true;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_PRINT_A4_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTime1_FIND.Text + " --> " + DateTime2_FIND.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_RELIQUAT", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Text_TOTAL_RELIQUAT.Text)))));
				DataTable dataTable = new DataTable();
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
					dataTable.Columns.Add(DataGridView1.Columns[num2].Name.ToString());
					dataTable.Columns[DataGridView1.Columns[num2].Name.ToString()].Caption = DataGridView1.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable.Rows.Add();
					int num8 = ((BaseCollection)DataGridView1.Columns).Count - 1;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						dataTable.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_CLIENTS_ETAT_CREDITS.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_CLIENTS_ETAT_CREDITS).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)Button_PrintRapport).Visible = true;
				((Control)Button_PRINT_80MM).Visible = false;
				((Control)Button_PRINT_A4).Visible = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.ToString());
				Module1._QUITTER_PATIENTER = true;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Print_CLIENTS_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 300, 20);
				string text = "ETAT CLIENTS";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 14f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 14f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-ddy") + " ==> " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-ddy"), new Font("Lucida Console", 6.4f, (FontStyle)0), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("INITIAL | CREDIT | RETOUR | REGLE | RELIQUAT ", new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
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
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DataGridView1.Rows[num3].Cells["CLIENT"].Value, "\r\n"), Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["CREDIT_INITIAL"].Value))), 8)), Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_CREDIT"].Value))), 8)), Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_RETOUR"].Value))), 8)), Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_REGLE"].Value))), 8)), Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["RELIQUAT"].Value))), 8)));
					e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num += 2;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL RELIQUAT: " + Text_TOTAL_RELIQUAT.Text + " DH", new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(120 + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				Module1._QUITTER_PATIENTER = true;
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
					string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text3 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			Module1._QUITTER_PATIENTER = true;
		}
	}
}
