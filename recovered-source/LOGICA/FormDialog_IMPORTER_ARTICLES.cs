using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClosedXML.Excel;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_IMPORTER_ARTICLES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button_VALIDER")]
	private Button _Button_VALIDER;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_ANNULER")]
	private Button _Button_ANNULER;

	[AccessedThroughProperty("Button_PARCOURIR")]
	private Button _Button_PARCOURIR;

	[AccessedThroughProperty("Button_SUPPRESSION")]
	private Button _Button_SUPPRESSION;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Text_TOTAL_LIGNES_BD")]
	private TextBox _Text_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Button_VERIFIER")]
	private Button _Button_VERIFIER;

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
			DataGridViewCellEventHandler val = DataGridView1_CellEnter;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellEnter -= val;
				_DataGridView1.CellContentClick -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellEnter += val;
				_DataGridView1.CellContentClick += val2;
			}
		}
	}

	internal virtual Button Button_VALIDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VALIDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_VALIDER_Click;
			if (_Button_VALIDER != null)
			{
				((Control)_Button_VALIDER).Click -= eventHandler;
			}
			_Button_VALIDER = value;
			if (_Button_VALIDER != null)
			{
				((Control)_Button_VALIDER).Click += eventHandler;
			}
		}
	}

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

	internal virtual Button Button_ANNULER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ANNULER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button_ANNULER != null)
			{
				((Control)_Button_ANNULER).Click -= eventHandler;
			}
			_Button_ANNULER = value;
			if (_Button_ANNULER != null)
			{
				((Control)_Button_ANNULER).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PARCOURIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PARCOURIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button_PARCOURIR != null)
			{
				((Control)_Button_PARCOURIR).Click -= eventHandler;
			}
			_Button_PARCOURIR = value;
			if (_Button_PARCOURIR != null)
			{
				((Control)_Button_PARCOURIR).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_SUPPRESSION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SUPPRESSION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SUPPRESSION_Click;
			if (_Button_SUPPRESSION != null)
			{
				((Control)_Button_SUPPRESSION).Click -= eventHandler;
			}
			_Button_SUPPRESSION = value;
			if (_Button_SUPPRESSION != null)
			{
				((Control)_Button_SUPPRESSION).Click += eventHandler;
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

	internal virtual TextBox Text_TOTAL_LIGNES_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL_LIGNES_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TOTAL_LIGNES_BD = value;
		}
	}

	internal virtual Button Button_VERIFIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VERIFIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_VERIFIER_Click;
			if (_Button_VERIFIER != null)
			{
				((Control)_Button_VERIFIER).Click -= eventHandler;
			}
			_Button_VERIFIER = value;
			if (_Button_VERIFIER != null)
			{
				((Control)_Button_VERIFIER).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_IMPORTER_ARTICLES()
	{
		((Form)this).Load += Form_5_CLIENTS_IMPORTER_Load;
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
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected Obj, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected Obj, but got Unknown
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_IMPORTER_ARTICLES));
		DataGridView1 = new DataGridView();
		Button_VALIDER = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button_ANNULER = new Button();
		Button_PARCOURIR = new Button();
		Button_SUPPRESSION = new Button();
		Panel2 = new Panel();
		Text_TOTAL_LIGNES_BD = new TextBox();
		Button_VERIFIER = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.Window;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(11, 33);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(937, 520);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 4;
		((Control)Button_VALIDER).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_VALIDER).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_VALIDER).Cursor = Cursors.Hand;
		((Control)Button_VALIDER).Enabled = false;
		((ButtonBase)Button_VALIDER).FlatStyle = (FlatStyle)0;
		((Control)Button_VALIDER).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_VALIDER).ForeColor = Color.White;
		Button button_VALIDER = Button_VALIDER;
		location = new Point(529, 599);
		((Control)button_VALIDER).Location = location;
		Button button_VALIDER2 = Button_VALIDER;
		Padding margin = new Padding(0);
		((Control)button_VALIDER2).Margin = margin;
		((Control)Button_VALIDER).Name = "Button_VALIDER";
		Button button_VALIDER3 = Button_VALIDER;
		size = new Size(155, 54);
		((Control)button_VALIDER3).Size = size;
		((Control)Button_VALIDER).TabIndex = 1036;
		((ButtonBase)Button_VALIDER).Text = "Valider";
		((ButtonBase)Button_VALIDER).UseVisualStyleBackColor = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 668);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(950, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1040;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 30);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 642);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1039;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(954, 30);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 642);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1038;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(0, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(958, 30);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 1037;
		Label_TOP.TextAlign = (ContentAlignment)16;
		((Control)Button_ANNULER).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_ANNULER).BackColor = Color.Red;
		((Control)Button_ANNULER).Cursor = Cursors.Hand;
		Button_ANNULER.DialogResult = (DialogResult)2;
		((ButtonBase)Button_ANNULER).FlatStyle = (FlatStyle)0;
		((Control)Button_ANNULER).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_ANNULER).ForeColor = Color.White;
		Button button_ANNULER = Button_ANNULER;
		location = new Point(789, 599);
		((Control)button_ANNULER).Location = location;
		Button button_ANNULER2 = Button_ANNULER;
		margin = new Padding(0);
		((Control)button_ANNULER2).Margin = margin;
		((Control)Button_ANNULER).Name = "Button_ANNULER";
		Button button_ANNULER3 = Button_ANNULER;
		size = new Size(155, 54);
		((Control)button_ANNULER3).Size = size;
		((Control)Button_ANNULER).TabIndex = 1042;
		((ButtonBase)Button_ANNULER).Text = "Annuler";
		((ButtonBase)Button_ANNULER).UseVisualStyleBackColor = false;
		((Control)Button_PARCOURIR).Anchor = (AnchorStyles)6;
		((ButtonBase)Button_PARCOURIR).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_PARCOURIR).Cursor = Cursors.Hand;
		((ButtonBase)Button_PARCOURIR).FlatStyle = (FlatStyle)0;
		((Control)Button_PARCOURIR).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_PARCOURIR).ForeColor = Color.White;
		Button button_PARCOURIR = Button_PARCOURIR;
		location = new Point(9, 599);
		((Control)button_PARCOURIR).Location = location;
		Button button_PARCOURIR2 = Button_PARCOURIR;
		margin = new Padding(0);
		((Control)button_PARCOURIR2).Margin = margin;
		((Control)Button_PARCOURIR).Name = "Button_PARCOURIR";
		Button button_PARCOURIR3 = Button_PARCOURIR;
		size = new Size(155, 54);
		((Control)button_PARCOURIR3).Size = size;
		((Control)Button_PARCOURIR).TabIndex = 1048;
		((ButtonBase)Button_PARCOURIR).Text = "Parcourir";
		((ButtonBase)Button_PARCOURIR).UseVisualStyleBackColor = false;
		((Control)Button_SUPPRESSION).Anchor = (AnchorStyles)6;
		((Control)Button_SUPPRESSION).BackgroundImageLayout = (ImageLayout)3;
		((Control)Button_SUPPRESSION).Cursor = Cursors.Hand;
		((ButtonBase)Button_SUPPRESSION).FlatStyle = (FlatStyle)0;
		((Control)Button_SUPPRESSION).Font = new Font("Tahoma", 18f, (FontStyle)1);
		((Control)Button_SUPPRESSION).ForeColor = Color.Red;
		((ButtonBase)Button_SUPPRESSION).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_SUPPRESSION).ImeMode = (ImeMode)0;
		Button button_SUPPRESSION = Button_SUPPRESSION;
		location = new Point(875, 1);
		((Control)button_SUPPRESSION).Location = location;
		Button button_SUPPRESSION2 = Button_SUPPRESSION;
		margin = new Padding(0);
		((Control)button_SUPPRESSION2).Margin = margin;
		((Control)Button_SUPPRESSION).Name = "Button_SUPPRESSION";
		Button button_SUPPRESSION3 = Button_SUPPRESSION;
		size = new Size(54, 29);
		((Control)button_SUPPRESSION3).Size = size;
		((Control)Button_SUPPRESSION).TabIndex = 1050;
		((ButtonBase)Button_SUPPRESSION).Text = "-";
		((ButtonBase)Button_SUPPRESSION).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button_SUPPRESSION).UseVisualStyleBackColor = true;
		((Control)Panel2).Anchor = (AnchorStyles)14;
		((Control)Panel2).BackColor = Color.FromArgb(64, 64, 64);
		((Control)Panel2).Controls.Add((Control)(object)Button_SUPPRESSION);
		((Control)Panel2).Controls.Add((Control)(object)Text_TOTAL_LIGNES_BD);
		Panel panel = Panel2;
		location = new Point(9, 556);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(937, 31);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 1061;
		((TextBoxBase)Text_TOTAL_LIGNES_BD).BackColor = Color.FromArgb(64, 64, 64);
		((TextBoxBase)Text_TOTAL_LIGNES_BD).BorderStyle = (BorderStyle)1;
		((Control)Text_TOTAL_LIGNES_BD).Font = new Font("Cambria", 12f, (FontStyle)1);
		((TextBoxBase)Text_TOTAL_LIGNES_BD).ForeColor = Color.White;
		TextBox text_TOTAL_LIGNES_BD = Text_TOTAL_LIGNES_BD;
		location = new Point(4, 2);
		((Control)text_TOTAL_LIGNES_BD).Location = location;
		((Control)Text_TOTAL_LIGNES_BD).Name = "Text_TOTAL_LIGNES_BD";
		((TextBoxBase)Text_TOTAL_LIGNES_BD).ReadOnly = true;
		TextBox text_TOTAL_LIGNES_BD2 = Text_TOTAL_LIGNES_BD;
		size = new Size(66, 26);
		((Control)text_TOTAL_LIGNES_BD2).Size = size;
		((Control)Text_TOTAL_LIGNES_BD).TabIndex = 977;
		Text_TOTAL_LIGNES_BD.TextAlign = (HorizontalAlignment)2;
		((Control)Button_VERIFIER).Anchor = (AnchorStyles)6;
		((ButtonBase)Button_VERIFIER).BackColor = Color.FromArgb(192, 0, 192);
		((Control)Button_VERIFIER).Cursor = Cursors.Hand;
		((ButtonBase)Button_VERIFIER).FlatStyle = (FlatStyle)0;
		((Control)Button_VERIFIER).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_VERIFIER).ForeColor = Color.White;
		Button button_VERIFIER = Button_VERIFIER;
		location = new Point(269, 599);
		((Control)button_VERIFIER).Location = location;
		Button button_VERIFIER2 = Button_VERIFIER;
		margin = new Padding(0);
		((Control)button_VERIFIER2).Margin = margin;
		((Control)Button_VERIFIER).Name = "Button_VERIFIER";
		Button button_VERIFIER3 = Button_VERIFIER;
		size = new Size(155, 54);
		((Control)button_VERIFIER3).Size = size;
		((Control)Button_VERIFIER).TabIndex = 1062;
		((ButtonBase)Button_VERIFIER).Text = "Vérifier";
		((ButtonBase)Button_VERIFIER).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		((Form)this).CancelButton = (IButtonControl)(object)Button_ANNULER;
		size = new Size(958, 672);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_VERIFIER);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Button_PARCOURIR);
		((Control)this).Controls.Add((Control)(object)Button_ANNULER);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Button_VALIDER);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_IMPORTER_ARTICLES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "IMPORTATION EXCEL";
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public static DataTable ExcelToDatatable_ClosedXML(FileStream fileStream, string SheetName)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		checked
		{
			DataTable result;
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				XLWorkbook val2 = new XLWorkbook((Stream)fileStream);
				try
				{
					IXLWorksheet val3 = ((IEnumerable<IXLWorksheet>)val2.Worksheets).Where([SpecialName] (IXLWorksheet x) => Operators.CompareString(x.Name.ToLower(), SheetName.ToLower(), TextCompare: false) == 0).FirstOrDefault();
					bool flag = true;
					foreach (IXLRow item in (IEnumerable<IXLRow>)val3.Rows())
					{
						if (flag)
						{
							foreach (IXLCell item2 in (IEnumerable<IXLCell>)((IXLRangeBase)item).Cells())
							{
								dataTable.Columns.Add(item2.Value.ToString());
							}
							flag = false;
							continue;
						}
						dataTable.Rows.Add();
						int num = 0;
						foreach (IXLCell item3 in (IEnumerable<IXLCell>)((IXLRangeBase)item).Cells())
						{
							string value = string.Empty;
							try
							{
								value = item3.Value.ToString();
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							dataTable.Rows[dataTable.Rows.Count - 1][num] = value;
							num++;
						}
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				result = dataTable;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private void Form_5_CLIENTS_IMPORTER_Load(object sender, EventArgs e)
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		DataGridView1.DataSource = null;
		DataGridView1.RowTemplate.Height = 35;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
		DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
		DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
		DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
		DataGridView1.EnableHeadersVisualStyles = false;
		((DataGridViewCell)DataGridView1.Columns[5].HeaderCell).Style.BackColor = Color.Yellow;
		((DataGridViewCell)DataGridView1.Columns[6].HeaderCell).Style.BackColor = Color.Yellow;
		((DataGridViewCell)DataGridView1.Columns[7].HeaderCell).Style.BackColor = Color.Yellow;
		((DataGridViewCell)DataGridView1.Columns[8].HeaderCell).Style.BackColor = Color.Yellow;
		((DataGridViewCell)DataGridView1.Columns[10].HeaderCell).Style.BackColor = Color.Tomato;
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
			((Control)Button_VALIDER).Enabled = false;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
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
					DataGridView1.Rows[num3].Cells[0].Value = Strings.Trim(DataGridView1.Rows[num3].Cells[0].Value.ToString());
					DataGridView1.Rows[num3].Cells[1].Value = Strings.Trim(DataGridView1.Rows[num3].Cells[1].Value.ToString());
					DataGridView1.Rows[num3].Cells[2].Value = Strings.Trim(DataGridView1.Rows[num3].Cells[2].Value.ToString());
					DataGridView1.Rows[num3].Cells[3].Value = Strings.Trim(DataGridView1.Rows[num3].Cells[3].Value.ToString());
					if (DataGridView1.Rows[num3].Cells[0].Value.ToString().Contains("'"))
					{
						DataGridView1.Rows[num3].Cells[0].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(DataGridView1.Rows[num3].Cells[0].Value, null, "Replace", new object[2] { "'", "" }, null, null, null));
					}
					if (DataGridView1.Rows[num3].Cells[1].Value.ToString().Contains("'"))
					{
						DataGridView1.Rows[num3].Cells[1].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(DataGridView1.Rows[num3].Cells[1].Value, null, "Replace", new object[2] { "'", "" }, null, null, null));
					}
					if (DataGridView1.Rows[num3].Cells[2].Value.ToString().Contains("'"))
					{
						DataGridView1.Rows[num3].Cells[2].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(DataGridView1.Rows[num3].Cells[2].Value, null, "Replace", new object[2] { "'", "" }, null, null, null));
					}
					if (DataGridView1.Rows[num3].Cells[3].Value.ToString().Contains("'"))
					{
						DataGridView1.Rows[num3].Cells[3].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(DataGridView1.Rows[num3].Cells[3].Value, null, "Replace", new object[2] { "'", "" }, null, null, null));
					}
					if ((DataGridView1.Rows[num3].Cells[0].Value == DBNull.Value) | (DataGridView1.Rows[num3].Cells[0].Value == null) | (Operators.CompareString(DataGridView1.Rows[num3].Cells[0].Value.ToString(), "", TextCompare: false) == 0))
					{
						DataGridView1.Rows[num3].Cells[0].Style.BackColor = Color.FromArgb(255, 128, 128);
						num++;
					}
					if ((DataGridView1.Rows[num3].Cells[1].Value == DBNull.Value) | (DataGridView1.Rows[num3].Cells[1].Value == null) | (Operators.CompareString(DataGridView1.Rows[num3].Cells[1].Value.ToString(), "", TextCompare: false) == 0))
					{
						DataGridView1.Rows[num3].Cells[1].Style.BackColor = Color.FromArgb(255, 128, 128);
						num++;
					}
					if ((DataGridView1.Rows[num3].Cells[2].Value == DBNull.Value) | (DataGridView1.Rows[num3].Cells[2].Value == null) | (Operators.CompareString(DataGridView1.Rows[num3].Cells[2].Value.ToString(), "", TextCompare: false) == 0))
					{
						DataGridView1.Rows[num3].Cells[2].Style.BackColor = Color.FromArgb(255, 128, 128);
						num++;
					}
					if ((DataGridView1.Rows[num3].Cells[3].Value == DBNull.Value) | (DataGridView1.Rows[num3].Cells[3].Value == null) | (Operators.CompareString(DataGridView1.Rows[num3].Cells[3].Value.ToString(), "", TextCompare: false) == 0))
					{
						DataGridView1.Rows[num3].Cells[3].Style.BackColor = Color.FromArgb(255, 128, 128);
						num++;
					}
					DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells[0];
					DataGridView1.Rows[DataGridView1.Rows.Count - 1].Selected = true;
					num3++;
				}
				if (num == 0)
				{
					((Control)Button_VALIDER).Enabled = true;
				}
				else
				{
					((Control)Button_VALIDER).Enabled = false;
				}
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

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button_VALIDER_Click(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Obj, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception e3 = ex4;
						StackTrace stackTrace3 = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
						int fileLineNumber3 = frame3.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val4 = new MySqlDataAdapter();
					int num = DataGridView1.Rows.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						val.CommandText = "SELECT MAX(ID) From TABLE_ARTICLES ";
						val.Connection = Module1.cn_SQL;
						val.CommandType = CommandType.Text;
						int num5 = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()) + 1.0)));
						val.CommandText = "Select ARTICLE from TABLE_NUM  where ID = 0 ";
						val.Connection = Module1.cn_SQL;
						val.CommandType = CommandType.Text;
						string text = ((val.ExecuteScalar() != DBNull.Value) ? ("ART" + Strings.Format(Conversions.ToDouble(val.ExecuteScalar()), "000000")) : Conversions.ToString(0));
						val.CommandText = "INSERT  INTO   TABLE_ARTICLES      ( ID,ID_ARTICLE,Code,Article,Famille,Sous_Famille,Description,Prix_A,PRIX_MP,PRIX_V_1,PRIX_V_2,STOCK,Alert,DATES,DATE_INVENTAIRE,STOCK_INITIAL,TAUX_TVA,UNITE,REFERENCE,FOURNISSEUR,MODE_STOCK,PRINTER,PRINTER_DUPLICATA,Images   ,Taille,Couleur,Emplacement,PROMOTION,FENETRE_PESAGE,BALANCE)         values        (   @ID,@ID_ARTICLE,@Code,@Article,@Famille,@Sous_Famille,@Description,@Prix_A,@PRIX_MP,@PRIX_V_1,@PRIX_V_2,@STOCK,@Alert,@DATES,@DATE_INVENTAIRE,@STOCK_INITIAL,@TAUX_TVA,@UNITE,@REFERENCE,@FOURNISSEUR,@MODE_STOCK,@PRINTER,@PRINTER_DUPLICATA,@Images      ,@Taille,@Couleur,@Emplacement,@PROMOTION,@FENETRE_PESAGE,@BALANCE    )          ";
						val.Connection = Module1.cn_SQL;
						val.Parameters.Add(new MySqlParameter("@ID", (MySqlDbType)3)).Value = num5;
						val.Parameters.Add(new MySqlParameter("@ID_ARTICLE", (MySqlDbType)253)).Value = text;
						val.Parameters.Add(new MySqlParameter("@Code", (MySqlDbType)253)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["Code"].Value);
						val.Parameters.Add(new MySqlParameter("@Article", (MySqlDbType)253)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["Article"].Value);
						val.Parameters.Add(new MySqlParameter("@Famille", (MySqlDbType)253)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["Famille"].Value);
						val.Parameters.Add(new MySqlParameter("@Sous_Famille", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@Description", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@Prix_A", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PRIX_A"].Value);
						val.Parameters.Add(new MySqlParameter("@PRIX_MP", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PRIX_A"].Value);
						val.Parameters.Add(new MySqlParameter("@PRIX_V_1", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PRIX_V"].Value);
						val.Parameters.Add(new MySqlParameter("@PRIX_V_2", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["PRIX_V"].Value);
						val.Parameters.Add(new MySqlParameter("@STOCK", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["STOCK"].Value);
						val.Parameters.Add(new MySqlParameter("@Alert", (MySqlDbType)0)).Value = 0;
						val.Parameters.Add(new MySqlParameter("@DATES", (MySqlDbType)10)).Value = Conversions.ToDate(DateTime.Now.ToString("dd-MM-yyyy"));
						val.Parameters.Add(new MySqlParameter("@DATE_INVENTAIRE", (MySqlDbType)10)).Value = Conversions.ToDate(DateTime.Now.ToString("dd-MM-yyyy"));
						val.Parameters.Add(new MySqlParameter("@STOCK_INITIAL", (MySqlDbType)0)).Value = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num2].Cells["STOCK"].Value);
						val.Parameters.Add(new MySqlParameter("@TAUX_TVA", (MySqlDbType)0)).Value = 20;
						val.Parameters.Add(new MySqlParameter("@UNITE", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@REFERENCE", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@FOURNISSEUR", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@MODE_STOCK", (MySqlDbType)253)).Value = "FINI";
						val.Parameters.Add(new MySqlParameter("@PRINTER", (MySqlDbType)253)).Value = 0;
						val.Parameters.Add(new MySqlParameter("@PRINTER_DUPLICATA", (MySqlDbType)253)).Value = 0;
						val.Parameters.Add(new MySqlParameter("@Images", (MySqlDbType)253)).Value = 0;
						val.Parameters.Add(new MySqlParameter("@TAILLE", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@COULEUR", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@EMPLACEMENT", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@PROMOTION", (MySqlDbType)0)).Value = 0;
						val.Parameters.Add(new MySqlParameter("@FENETRE_PESAGE", (MySqlDbType)253)).Value = "";
						val.Parameters.Add(new MySqlParameter("@BALANCE", (MySqlDbType)253)).Value = "";
						val.ExecuteNonQuery();
						val.Parameters.Clear();
						if (Module1.cn_SQL.State != ConnectionState.Open)
						{
							Module1.cn_SQL.Open();
						}
						val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("dd/MM/yyy"), "' ,  '"), DateTime.Now.ToString("HH:mm:ss")), "'  ,'Création d''article'   ,'"), text), "','"), DataGridView1.Rows[num2].Cells["Code"].Value), "' ,'"), DataGridView1.Rows[num2].Cells["ARTICLE"].Value), "'  ,'"), DataGridView1.Rows[num2].Cells["STOCK"].Value), "'        )        "));
						val.Connection = Module1.cn_SQL;
						val.ExecuteNonQuery();
						val.CommandText = "UPDATE     TABLE_NUM    SET ARTICLE =  ARTICLE + 1   ";
						val.Connection = Module1.cn_SQL;
						val.ExecuteNonQuery();
						num2++;
					}
					string[] array = (from DataGridViewRow row in (IEnumerable)DataGridView1.Rows
						where !row.IsNewRow
						select Conversions.ToString(row.Cells["famille"].Value)).Distinct().ToArray();
					int num6 = array.Count() - 1;
					int num7 = 0;
					while (true)
					{
						int num8 = num7;
						int num4 = num6;
						if (num8 > num4)
						{
							break;
						}
						val.CommandText = "Select  count(id)  from TABLE_FAMILLES  where  famille = '" + array[num7].ToString() + "'     ";
						val.Connection = Module1.cn_SQL;
						val.CommandType = CommandType.Text;
						int num9 = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(val.ExecuteScalar())));
						if (val.ExecuteScalar() != DBNull.Value && num9 == 0)
						{
							val.CommandText = "Select  max(id)  from TABLE_FAMILLES    ";
							val.Connection = Module1.cn_SQL;
							val.CommandType = CommandType.Text;
							int num10 = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()))));
							val.CommandText = "Select  max(Ordre)  from TABLE_FAMILLES    ";
							val.Connection = Module1.cn_SQL;
							val.CommandType = CommandType.Text;
							int num11 = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()))));
							val.CommandText = "INSERT INTO TABLE_FAMILLES (ID,Ordre,FAMILLE,GROUPE,VISIBLE,TYPE) VALUES('" + Conversions.ToString(num10 + 1) + "','" + Conversions.ToString(num11 + 1) + "','" + array[num7].ToString() + "','','OUI','FAMILLE')";
							val.Connection = Module1.cn_SQL;
							val.CommandType = CommandType.Text;
							val.ExecuteNonQuery();
						}
						num7++;
					}
					val2.Commit();
					Module1.cn_SQL.Close();
					Module1._QUITTER_PATIENTER = true;
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					val2.Rollback();
					Module1._QUITTER_PATIENTER = true;
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				((Control)Button_VALIDER).Enabled = false;
				((Form)this).Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		checked
		{
			try
			{
				OpenFileDialog val = new OpenFileDialog();
				((FileDialog)val).Filter = "Excel (xlsx)|*.xlsx";
				if (unchecked((int)((CommonDialog)val).ShowDialog()) != 1 || Operators.CompareString(((FileDialog)val).FileName, "", TextCompare: false) == 0)
				{
					return;
				}
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
				DataGridView1.Columns.Clear();
				string fileName = ((FileDialog)val).FileName;
				FileStream fileStream = new FileStream(fileName, FileMode.Open);
				DataTable dataSource = ExcelToDatatable_ClosedXML(fileStream, "Feuil1");
				DataGridView1.DataSource = dataSource;
				fileStream.Dispose();
				if (DataGridView1.RowCount > 0)
				{
					DataGridView1.Rows.RemoveAt(DataGridView1.Rows.Count - 1);
					int num = DataGridView1.RowCount - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						int num5 = ((BaseCollection)DataGridView1.Columns).Count - 1;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							DataGridView1.Rows[num2].Cells[num6].Value = Strings.Trim(DataGridView1.Rows[num2].Cells[num6].Value.ToString());
							DataGridView1.Rows[num2].Cells[num6].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(DataGridView1.Rows[num2].Cells[num6].Value, null, "Replace", new object[2] { "'", "" }, null, null, null));
							DataGridView1.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
							num6++;
						}
						DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells[0];
						DataGridView1.Rows[DataGridView1.Rows.Count - 1].Selected = true;
						num2++;
					}
					DataGridViewTextBoxColumn val2 = new DataGridViewTextBoxColumn();
					((DataGridViewBand)val2).Tag = false;
					((DataGridViewColumn)val2).Name = "INDEX";
					((DataGridViewColumn)val2).Width = 33;
					DataGridView1.Columns.Insert(0, (DataGridViewColumn)(object)val2);
				}
				int num8 = DataGridView1.RowCount - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView1.Rows[num9].Cells["INDEX"].Value = num9 + 1;
					num9++;
				}
				((Control)Button_VALIDER).Enabled = false;
				Module1._QUITTER_PATIENTER = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_SUPPRESSION_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button_SUPPRESSION_ALL_Click(object sender, EventArgs e)
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				int num = DataGridView1.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						int position = ((ContainerControl)this).BindingContext[(object)Module1.dt1].Position;
						Module1.dt1.Rows[position].Delete();
						MySqlCommandBuilder val = new MySqlCommandBuilder(Module1.da1);
						((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);
						Module1.dt1.AcceptChanges();
						((ContainerControl)this).BindingContext[(object)Module1.dt1].Position = position;
						num2++;
						continue;
					}
					break;
				}
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		Text_TOTAL_LIGNES_BD.Text = Conversions.ToString(Conversions.ToDouble(DataGridView1.CurrentCell.RowIndex.ToString()) + 1.0) + "/" + Conversions.ToString(DataGridView1.Rows.Count);
	}

	private void Button_VERIFIER_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		checked
		{
			try
			{
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataTable dataTable = new DataTable();
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = DataGridView1.Rows.Count - 1;
				int num5 = 0;
				while (true)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					int num8 = ((BaseCollection)DataGridView1.Columns).Count - 1;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						num7 = num8;
						if (num10 > num7)
						{
							break;
						}
						if ((DataGridView1.Rows[num5].Cells[num9].Value == DBNull.Value) | (DataGridView1.Rows[num5].Cells[num9].Value == null) | (Operators.CompareString(DataGridView1.Rows[num5].Cells[num9].Value.ToString(), "", TextCompare: false) == 0))
						{
							DataGridView1.Rows[num5].Cells[num9].Style.BackColor = Color.FromArgb(255, 128, 128);
							num++;
						}
						if (Operators.CompareString(DataGridView1.Columns[num9].Name.ToString(), "PRIX_A", TextCompare: false) == 0 && !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num5].Cells["PRIX_A"].Value)))
						{
							DataGridView1.Rows[num5].Cells["PRIX_A"].Style.BackColor = Color.FromArgb(255, 128, 128);
							num3++;
						}
						if (Operators.CompareString(DataGridView1.Columns[num9].Name.ToString(), "PRIX_V", TextCompare: false) == 0 && !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num5].Cells["PRIX_V"].Value)))
						{
							DataGridView1.Rows[num5].Cells["PRIX_V"].Style.BackColor = Color.FromArgb(255, 128, 128);
							num3++;
						}
						if (Operators.CompareString(DataGridView1.Columns[num9].Name.ToString(), "STOCK", TextCompare: false) == 0 && !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num5].Cells["STOCK"].Value)))
						{
							DataGridView1.Rows[num5].Cells["STOCK"].Style.BackColor = Color.FromArgb(255, 128, 128);
							num3++;
						}
						num9++;
					}
					dataTable.Clear();
					val = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select  Code     from TABLE_ARTICLES WHERE   Code = '", DataGridView1.Rows[num5].Cells["Code"].Value), "'   ")), Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						num2++;
					}
					Application.DoEvents();
					Thread.Sleep(1);
					DataGridView1.CurrentCell = DataGridView1.Rows[num5].Cells[0];
					num5++;
				}
				MessageBox.Show("- Vous Avez ('" + Conversions.ToString(num) + "') Cellule vide\r\n- Vous Avez ('" + Conversions.ToString(num2) + "') Code est déja utilisé\r\n- Vous Avez ('" + Conversions.ToString(num3) + "') Cellule non-numérique", "Rapport", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				if ((num == 0) & (num2 == 0) & (num3 == 0))
				{
					((Control)Button_VALIDER).Enabled = true;
				}
				else
				{
					((Control)Button_VALIDER).Enabled = false;
				}
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

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		DataGridViewTextBoxColumn val = new DataGridViewTextBoxColumn();
		((DataGridViewBand)val).Tag = false;
		((DataGridViewColumn)val).Name = "INDEX";
		((DataGridViewColumn)val).Width = 43;
		DataGridView1.Columns.Insert(0, (DataGridViewColumn)(object)val);
	}
}
