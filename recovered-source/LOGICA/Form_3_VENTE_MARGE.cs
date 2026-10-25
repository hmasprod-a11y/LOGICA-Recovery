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
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_3_VENTE_MARGE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("FlowLayout_FAMILLES")]
	private FlowLayoutPanel _FlowLayout_FAMILLES;

	[AccessedThroughProperty("Ticket")]
	private DataGridViewTextBoxColumn _Ticket;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_A")]
	private DataGridViewTextBoxColumn _Prix_A;

	[AccessedThroughProperty("Prix_MP")]
	private DataGridViewTextBoxColumn _Prix_MP;

	[AccessedThroughProperty("Prix_V")]
	private DataGridViewTextBoxColumn _Prix_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("Remise")]
	private DataGridViewTextBoxColumn _Remise;

	[AccessedThroughProperty("Total_Net")]
	private DataGridViewTextBoxColumn _Total_Net;

	[AccessedThroughProperty("Opération")]
	private DataGridViewTextBoxColumn _Opération;

	[AccessedThroughProperty("Panel7727")]
	private Panel _Panel7727;

	[AccessedThroughProperty("Button_CALC_ENREGISTRER")]
	private Button _Button_CALC_ENREGISTRER;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("TextBox33398")]
	private TextBox _TextBox33398;

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
			_DataGridView1 = value;
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
			_FlowLayout_FAMILLES = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ticket
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ticket;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ticket = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Dates
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dates;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dates = value;
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

	internal virtual DataGridViewTextBoxColumn Prix_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_A = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Prix_MP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_MP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_MP = value;
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

	internal virtual DataGridViewTextBoxColumn Remise
	{
		[DebuggerNonUserCode]
		get
		{
			return _Remise;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Remise = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Total_Net
	{
		[DebuggerNonUserCode]
		get
		{
			return _Total_Net;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Total_Net = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Opération
	{
		[DebuggerNonUserCode]
		get
		{
			return _Opération;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Opération = value;
		}
	}

	internal virtual Panel Panel7727
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7727;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7727 = value;
		}
	}

	internal virtual Button Button_CALC_ENREGISTRER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC_ENREGISTRER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_ENREGISTRER_Click;
			if (_Button_CALC_ENREGISTRER != null)
			{
				((Control)_Button_CALC_ENREGISTRER).Click -= eventHandler;
			}
			_Button_CALC_ENREGISTRER = value;
			if (_Button_CALC_ENREGISTRER != null)
			{
				((Control)_Button_CALC_ENREGISTRER).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual TextBox TextBox33398
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox33398;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox33398 = value;
		}
	}

	public Form_3_VENTE_MARGE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_JOURNAL_REGELEMENTS_Load;
		((Control)this).KeyDown += me_KeyDown;
		__ENCAddToList(this);
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
		//IL_000e: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
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
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_3_VENTE_MARGE));
		DataGridView1 = new DataGridView();
		Ticket = new DataGridViewTextBoxColumn();
		Dates = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Prix_A = new DataGridViewTextBoxColumn();
		Prix_MP = new DataGridViewTextBoxColumn();
		Prix_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		Remise = new DataGridViewTextBoxColumn();
		Total_Net = new DataGridViewTextBoxColumn();
		Opération = new DataGridViewTextBoxColumn();
		FlowLayout_FAMILLES = new FlowLayoutPanel();
		Panel7727 = new Panel();
		Button_CALC_ENREGISTRER = new Button();
		PictureBox3 = new PictureBox();
		TextBox33398 = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel7727).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[10]
		{
			(DataGridViewColumn)Ticket,
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_A,
			(DataGridViewColumn)Prix_MP,
			(DataGridViewColumn)Prix_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)Remise,
			(DataGridViewColumn)Total_Net,
			(DataGridViewColumn)Opération
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
		Size size = new Size(1036, 339);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 2;
		((DataGridViewColumn)Ticket).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Ticket).HeaderText = "Ticket";
		((DataGridViewColumn)Ticket).Name = "Ticket";
		((DataGridViewColumn)Ticket).Width = 60;
		((DataGridViewColumn)Dates).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val3.Format = "d";
		val3.NullValue = null;
		((DataGridViewColumn)Dates).DefaultCellStyle = val3;
		((DataGridViewColumn)Dates).HeaderText = "Dates";
		((DataGridViewColumn)Dates).Name = "Dates";
		((DataGridViewColumn)Dates).Width = 80;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Prix_A).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)Prix_A).DefaultCellStyle = val4;
		((DataGridViewColumn)Prix_A).HeaderText = "Prix_A";
		((DataGridViewColumn)Prix_A).Name = "Prix_A";
		((DataGridViewColumn)Prix_A).Width = 60;
		((DataGridViewColumn)Prix_MP).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		((DataGridViewColumn)Prix_MP).DefaultCellStyle = val5;
		((DataGridViewColumn)Prix_MP).HeaderText = "Prix_MP";
		((DataGridViewColumn)Prix_MP).Name = "Prix_MP";
		((DataGridViewColumn)Prix_MP).Width = 65;
		((DataGridViewColumn)Prix_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "N2";
		((DataGridViewColumn)Prix_V).DefaultCellStyle = val6;
		((DataGridViewColumn)Prix_V).HeaderText = "Prix_V";
		((DataGridViewColumn)Prix_V).Name = "Prix_V";
		((DataGridViewColumn)Prix_V).Width = 60;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val7.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)Qté).DefaultCellStyle = val7;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		((DataGridViewColumn)Qté).Width = 40;
		((DataGridViewColumn)Remise).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val8.Alignment = (DataGridViewContentAlignment)32;
		val8.Format = "N2";
		((DataGridViewColumn)Remise).DefaultCellStyle = val8;
		((DataGridViewColumn)Remise).HeaderText = "Remise";
		((DataGridViewColumn)Remise).Name = "Remise";
		((DataGridViewColumn)Remise).Width = 60;
		((DataGridViewColumn)Total_Net).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val9.Alignment = (DataGridViewContentAlignment)16;
		val9.NullValue = null;
		((DataGridViewColumn)Total_Net).DefaultCellStyle = val9;
		((DataGridViewColumn)Total_Net).HeaderText = "Total_Net";
		((DataGridViewColumn)Total_Net).Name = "Total_Net";
		((DataGridViewColumn)Total_Net).Width = 200;
		((DataGridViewColumn)Opération).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Opération).DataPropertyName = "Opération";
		((DataGridViewColumn)Opération).HeaderText = "Opération";
		((DataGridViewColumn)Opération).Name = "Opération";
		((DataGridViewColumn)Opération).Width = 120;
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
		size = new Size(1036, 58);
		((Control)flowLayout_FAMILLES3).Size = size;
		((Control)FlowLayout_FAMILLES).TabIndex = 993;
		((Control)Panel7727).Anchor = (AnchorStyles)6;
		((Control)Panel7727).BackColor = Color.FromArgb(64, 64, 64);
		((Control)Panel7727).Controls.Add((Control)(object)Button_CALC_ENREGISTRER);
		((Control)Panel7727).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel7727).Controls.Add((Control)(object)TextBox33398);
		Panel panel = Panel7727;
		location = new Point(0, 308);
		((Control)panel).Location = location;
		((Control)Panel7727).Name = "Panel7727";
		Panel panel2 = Panel7727;
		size = new Size(360, 31);
		((Control)panel2).Size = size;
		((Control)Panel7727).TabIndex = 1066;
		((Control)Panel7727).Visible = false;
		((Control)Button_CALC_ENREGISTRER).ForeColor = Color.Red;
		Button button_CALC_ENREGISTRER = Button_CALC_ENREGISTRER;
		location = new Point(314, 2);
		((Control)button_CALC_ENREGISTRER).Location = location;
		((Control)Button_CALC_ENREGISTRER).Name = "Button_CALC_ENREGISTRER";
		Button button_CALC_ENREGISTRER2 = Button_CALC_ENREGISTRER;
		size = new Size(43, 24);
		((Control)button_CALC_ENREGISTRER2).Size = size;
		((Control)Button_CALC_ENREGISTRER).TabIndex = 992;
		((ButtonBase)Button_CALC_ENREGISTRER).Text = "CALC";
		((ButtonBase)Button_CALC_ENREGISTRER).UseVisualStyleBackColor = true;
		((Control)Button_CALC_ENREGISTRER).Visible = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		location = new Point(6, 2);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(31, 26);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 992;
		PictureBox3.TabStop = false;
		((TextBoxBase)TextBox33398).BackColor = Color.FromArgb(64, 64, 64);
		((TextBoxBase)TextBox33398).BorderStyle = (BorderStyle)1;
		((Control)TextBox33398).Font = new Font("Cambria", 12f, (FontStyle)1);
		((TextBoxBase)TextBox33398).ForeColor = Color.White;
		TextBox textBox = TextBox33398;
		location = new Point(43, 2);
		((Control)textBox).Location = location;
		((Control)TextBox33398).Name = "TextBox33398";
		((TextBoxBase)TextBox33398).ReadOnly = true;
		TextBox textBox2 = TextBox33398;
		size = new Size(314, 26);
		((Control)textBox2).Size = size;
		((Control)TextBox33398).TabIndex = 977;
		TextBox33398.Text = "Il y a ... Erreurs";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1036, 398);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel7727);
		((Control)this).Controls.Add((Control)(object)FlowLayout_FAMILLES);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_3_VENTE_MARGE";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "MARGE";
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel7727).ResumeLayout(false);
		((Control)Panel7727).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void _COLORISE_DATAGRID()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		checked
		{
			int num = DataGridView1.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num2].Cells[0].Value, "", TextCompare: false))
					{
						DataGridView1.Rows[num2].Cells["Total_Net"].Style.BackColor = Color.Green;
						DataGridView1.Rows[num2].Cells["Total_Net"].Style.ForeColor = Color.White;
						DataGridView1.Rows[num2].Height = 70;
						DataGridView1.Rows[num2].Cells["Total_Net"].Style.Font = new Font("Inconsolata Condensed", 12f, (FontStyle)1);
					}
					num2++;
					continue;
				}
				break;
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

	private void FormDialog_JOURNAL_REGELEMENTS_Load(object sender, EventArgs e)
	{
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_1811: Unknown result type (might be due to invalid IL or missing references)
		//IL_1818: Expected Obj, but got Unknown
		//IL_190e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Expected Obj, but got Unknown
		//IL_1a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a72: Expected Obj, but got Unknown
		//IL_1b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Expected Obj, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected Obj, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected Obj, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Expected Obj, but got Unknown
		//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cee: Expected Obj, but got Unknown
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
				((Control)this).Top = 0;
				((Control)this).Height = ((Control)MyProject.Forms.Form_0_TEMPLATE).Height;
				DataGridView1.Rows.Clear();
				((Control)FlowLayout_FAMILLES).Controls.Clear();
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text))
				{
					_dt.Clear();
					_dt = new DataTable();
					_da = new MySqlDataAdapter("select   TICKET,DATES,ARTICLE,PRIX_A,PRIX_MP,PRIX_V,QTé,REMISE,TOTAL_NET,CLIENT,OPERATION      from    TABLE_VENTES_JOURNAL   Where   CLOTURE_GLOBALE IS  NULL      order by ID desc", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					if (_dt.Rows.Count == 0)
					{
						Module1._QUITTER_PATIENTER = true;
						return;
					}
					string right = _dt.Rows[0]["TICKET"].ToString();
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					int num4 = _dt.Rows.Count - 1;
					int num5 = 0;
					while (true)
					{
						int num6 = num5;
						int num7 = num4;
						if (num6 > num7)
						{
							break;
						}
						if (Operators.CompareString(_dt.Rows[num5]["TICKET"].ToString(), right, TextCompare: false) == 0)
						{
							DataGridView1.Rows.Add(new object[10]
							{
								_dt.Rows[num5]["TICKET"].ToString(),
								Conversions.ToDate(_dt.Rows[num5]["DATES"]).ToString("dd/MM/yyy"),
								_dt.Rows[num5]["ARTICLE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_A"].ToString())),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_MP"].ToString())),
								_dt.Rows[num5]["PRIX_V"].ToString(),
								_dt.Rows[num5]["QTé"].ToString(),
								_dt.Rows[num5]["REMISE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())),
								_dt.Rows[num5]["OPERATION"].ToString() + " " + _dt.Rows[num5]["CLIENT"].ToString()
							});
							num = decimal.Add(num, Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())));
							num2 = decimal.Add(num2, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_A"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["Qté"].ToString())))));
							num3 = decimal.Add(num3, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_MP"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["Qté"].ToString())))));
						}
						else
						{
							DataGridView1.Rows.Add(new object[9]
							{
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"Total Net : " + Conversions.ToString(Module1.FLOUSS(num)) + " DH\r\nMarge A   : " + Conversions.ToString(Module1.FLOUSS(num2)) + " DH\r\nMarge MP  : " + Conversions.ToString(Module1.FLOUSS(num3)) + " DH"
							});
							right = _dt.Rows[num5]["TICKET"].ToString();
							num = 0m;
							num2 = 0m;
							num3 = 0m;
							DataGridView1.Rows.Add(new object[10]
							{
								_dt.Rows[num5]["TICKET"].ToString(),
								Conversions.ToDate(_dt.Rows[num5]["DATES"]).ToString("dd/MM/yyy"),
								_dt.Rows[num5]["ARTICLE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_A"].ToString())),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_MP"].ToString())),
								_dt.Rows[num5]["PRIX_V"].ToString(),
								_dt.Rows[num5]["QTé"].ToString(),
								_dt.Rows[num5]["REMISE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())),
								_dt.Rows[num5]["OPERATION"].ToString() + " " + _dt.Rows[num5]["CLIENT"].ToString()
							});
							num = new decimal(Convert.ToDouble(num) + Conversions.ToDouble(_dt.Rows[num5]["TOTAL_NET"].ToString()));
							num2 = decimal.Add(num2, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_A"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["Qté"].ToString())))));
							num3 = decimal.Add(num3, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["PRIX_MP"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num5]["Qté"].ToString())))));
						}
						if (num5 == _dt.Rows.Count - 1)
						{
							DataGridView1.Rows.Add(new object[9]
							{
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"Total Net : " + Conversions.ToString(Module1.FLOUSS(num)) + " DH\r\nMarge A   : " + Conversions.ToString(Module1.FLOUSS(num2)) + " DH\r\nMarge MP  : " + Conversions.ToString(Module1.FLOUSS(num3)) + " DH"
							});
						}
						num5++;
					}
					_COLORISE_DATAGRID();
					double num8 = 0.0;
					double num9 = 0.0;
					MySqlDataAdapter val = new MySqlDataAdapter();
					DataTable dataTable = new DataTable();
					dataTable.Clear();
					val = new MySqlDataAdapter("(select sum(TOTAL_NET - (PRIX_MP * Qté) ) as n     from TABLE_VENTES_JOURNAL WHERE      CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT'    OR      OPERATION = 'CREDIT'   )    )       UNION ALL     (select sum(TOTAL_NET - (PRIX_A * Qté) ) as n     from TABLE_VENTES_JOURNAL WHERE      CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT'    OR      OPERATION = 'CREDIT'   )    )  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					num8 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
					num9 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[1]["n"].ToString())));
					((Control)FlowLayout_FAMILLES).Controls.Clear();
					Button_RJ_ARTICLE button_RJ_ARTICLE = new Button_RJ_ARTICLE();
					((ButtonBase)button_RJ_ARTICLE).Text = Strings.LSet("MARGE (MP)", 11) + ":" + Strings.RSet(Strings.FormatNumber(num8), 8) + " DH";
					button_RJ_ARTICLE._BackgroundColor = Color.White;
					button_RJ_ARTICLE._BorderColor = Color.FromArgb(22, 106, 238);
					button_RJ_ARTICLE._BorderRadius = 8;
					button_RJ_ARTICLE._BorderSize = 1.5m;
					button_RJ_ARTICLE._TextColor = Color.Black;
					((Control)button_RJ_ARTICLE).Cursor = Cursors.Hand;
					((ButtonBase)button_RJ_ARTICLE).FlatStyle = (FlatStyle)2;
					((Control)button_RJ_ARTICLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
					((Control)button_RJ_ARTICLE).ForeColor = Color.Black;
					((Control)button_RJ_ARTICLE).Width = 200;
					((ButtonBase)button_RJ_ARTICLE).TextAlign = (ContentAlignment)16;
					((ButtonBase)button_RJ_ARTICLE).UseVisualStyleBackColor = false;
					((Control)button_RJ_ARTICLE).Click += FAM_click;
					((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE);
					button_RJ_ARTICLE = new Button_RJ_ARTICLE();
					((ButtonBase)button_RJ_ARTICLE).Text = Strings.LSet("MARGE (A)", 11) + ":" + Strings.RSet(Strings.FormatNumber(num9), 8) + " DH";
					button_RJ_ARTICLE._BackgroundColor = Color.White;
					button_RJ_ARTICLE._BorderColor = Color.FromArgb(22, 106, 238);
					button_RJ_ARTICLE._BorderRadius = 8;
					button_RJ_ARTICLE._BorderSize = 1.5m;
					button_RJ_ARTICLE._TextColor = Color.Black;
					((Control)button_RJ_ARTICLE).Cursor = Cursors.Hand;
					((ButtonBase)button_RJ_ARTICLE).FlatStyle = (FlatStyle)2;
					((Control)button_RJ_ARTICLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
					((Control)button_RJ_ARTICLE).ForeColor = Color.Black;
					((Control)button_RJ_ARTICLE).Width = 180;
					((ButtonBase)button_RJ_ARTICLE).TextAlign = (ContentAlignment)16;
					((ButtonBase)button_RJ_ARTICLE).UseVisualStyleBackColor = false;
					((Control)button_RJ_ARTICLE).Click += FAM_click;
					((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE);
				}
				else
				{
					_dt.Clear();
					_dt = new DataTable();
					_da = new MySqlDataAdapter("select   TICKET,DATES,ARTICLE,PRIX_A,PRIX_MP,PRIX_V,QTé,REMISE,TOTAL_NET,CLIENT,OPERATION      from    TABLE_VENTES_JOURNAL   Where  Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '      order by ID desc", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					if (_dt.Rows.Count == 0)
					{
						Module1._QUITTER_PATIENTER = true;
						return;
					}
					string right2 = _dt.Rows[0]["TICKET"].ToString();
					decimal num10 = 0m;
					decimal num11 = 0m;
					decimal num12 = 0m;
					int num13 = _dt.Rows.Count - 1;
					int num14 = 0;
					while (true)
					{
						int num15 = num14;
						int num7 = num13;
						if (num15 > num7)
						{
							break;
						}
						if (Operators.CompareString(_dt.Rows[num14]["TICKET"].ToString(), right2, TextCompare: false) == 0)
						{
							DataGridView1.Rows.Add(new object[10]
							{
								_dt.Rows[num14]["TICKET"].ToString(),
								Conversions.ToDate(_dt.Rows[num14]["DATES"]).ToString("dd/MM/yyy"),
								_dt.Rows[num14]["ARTICLE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_A"].ToString())),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_MP"].ToString())),
								_dt.Rows[num14]["PRIX_V"].ToString(),
								_dt.Rows[num14]["QTé"].ToString(),
								_dt.Rows[num14]["REMISE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())),
								_dt.Rows[num14]["OPERATION"].ToString() + " " + _dt.Rows[num14]["CLIENT"].ToString()
							});
							num10 = decimal.Add(num10, Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())));
							num11 = decimal.Add(num11, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_A"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["Qté"].ToString())))));
							num12 = decimal.Add(num12, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_MP"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["Qté"].ToString())))));
						}
						else
						{
							DataGridView1.Rows.Add(new object[9]
							{
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"Total Net : " + Conversions.ToString(Module1.FLOUSS(num10)) + " DH\r\nMarge A   : " + Conversions.ToString(Module1.FLOUSS(num11)) + " DH\r\nMarge MP  : " + Conversions.ToString(Module1.FLOUSS(num12)) + " DH"
							});
							right2 = _dt.Rows[num14]["TICKET"].ToString();
							num10 = 0m;
							num11 = 0m;
							num12 = 0m;
							DataGridView1.Rows.Add(new object[10]
							{
								_dt.Rows[num14]["TICKET"].ToString(),
								Conversions.ToDate(_dt.Rows[num14]["DATES"]).ToString("dd/MM/yyy"),
								_dt.Rows[num14]["ARTICLE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_A"].ToString())),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_MP"].ToString())),
								_dt.Rows[num14]["PRIX_V"].ToString(),
								_dt.Rows[num14]["QTé"].ToString(),
								_dt.Rows[num14]["REMISE"].ToString(),
								Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())),
								_dt.Rows[num14]["OPERATION"].ToString() + " " + _dt.Rows[num14]["CLIENT"].ToString()
							});
							num10 = new decimal(Convert.ToDouble(num10) + Conversions.ToDouble(_dt.Rows[num14]["TOTAL_NET"].ToString()));
							num11 = decimal.Add(num11, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_A"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["Qté"].ToString())))));
							num12 = decimal.Add(num12, decimal.Subtract(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["TOTAL_NET"].ToString())), decimal.Multiply(Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["PRIX_MP"].ToString())), Module1.FLOUSS(Conversions.ToDecimal(_dt.Rows[num14]["Qté"].ToString())))));
						}
						if (num14 == _dt.Rows.Count - 1)
						{
							DataGridView1.Rows.Add(new object[9]
							{
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"",
								"Total Net : " + Conversions.ToString(Module1.FLOUSS(num10)) + " DH\r\nMarge A   : " + Conversions.ToString(Module1.FLOUSS(num11)) + " DH\r\nMarge MP  : " + Conversions.ToString(Module1.FLOUSS(num12)) + " DH"
							});
						}
						num14++;
					}
					_COLORISE_DATAGRID();
					double num16 = 0.0;
					double num17 = 0.0;
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					DataTable dataTable2 = new DataTable();
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("(select sum(TOTAL_NET - (PRIX_MP * Qté) ) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT'    OR      OPERATION = 'CREDIT'   )    )       UNION ALL     (select sum(TOTAL_NET - (PRIX_A * Qté) ) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT'    OR      OPERATION = 'CREDIT'   )    )  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					num16 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["n"].ToString())));
					num17 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable2.Rows[1]["n"].ToString())));
					((Control)FlowLayout_FAMILLES).Controls.Clear();
					Button_RJ_ARTICLE button_RJ_ARTICLE2 = new Button_RJ_ARTICLE();
					((ButtonBase)button_RJ_ARTICLE2).Text = Strings.LSet("MARGE (MP)", 11) + ":" + Strings.RSet(Strings.FormatNumber(num16), 8) + " DH";
					button_RJ_ARTICLE2._BackgroundColor = Color.White;
					button_RJ_ARTICLE2._BorderColor = Color.FromArgb(22, 106, 238);
					button_RJ_ARTICLE2._BorderRadius = 8;
					button_RJ_ARTICLE2._BorderSize = 1.5m;
					button_RJ_ARTICLE2._TextColor = Color.Black;
					((Control)button_RJ_ARTICLE2).Cursor = Cursors.Hand;
					((ButtonBase)button_RJ_ARTICLE2).FlatStyle = (FlatStyle)2;
					((Control)button_RJ_ARTICLE2).Font = new Font("Tahoma", 9f, (FontStyle)1);
					((Control)button_RJ_ARTICLE2).ForeColor = Color.Black;
					((Control)button_RJ_ARTICLE2).Width = 200;
					((ButtonBase)button_RJ_ARTICLE2).TextAlign = (ContentAlignment)16;
					((ButtonBase)button_RJ_ARTICLE2).UseVisualStyleBackColor = false;
					((Control)button_RJ_ARTICLE2).Click += FAM_click;
					((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE2);
					button_RJ_ARTICLE2 = new Button_RJ_ARTICLE();
					((ButtonBase)button_RJ_ARTICLE2).Text = Strings.LSet("MARGE (A)", 11) + ":" + Strings.RSet(Strings.FormatNumber(num17), 8) + " DH";
					button_RJ_ARTICLE2._BackgroundColor = Color.White;
					button_RJ_ARTICLE2._BorderColor = Color.FromArgb(22, 106, 238);
					button_RJ_ARTICLE2._BorderRadius = 8;
					button_RJ_ARTICLE2._BorderSize = 1.5m;
					button_RJ_ARTICLE2._TextColor = Color.Black;
					((Control)button_RJ_ARTICLE2).Cursor = Cursors.Hand;
					((ButtonBase)button_RJ_ARTICLE2).FlatStyle = (FlatStyle)2;
					((Control)button_RJ_ARTICLE2).Font = new Font("Tahoma", 9f, (FontStyle)1);
					((Control)button_RJ_ARTICLE2).ForeColor = Color.Black;
					((Control)button_RJ_ARTICLE2).Width = 174;
					((ButtonBase)button_RJ_ARTICLE2).TextAlign = (ContentAlignment)16;
					((ButtonBase)button_RJ_ARTICLE2).UseVisualStyleBackColor = false;
					((Control)button_RJ_ARTICLE2).Click += FAM_click;
					((Control)FlowLayout_FAMILLES).Controls.Add((Control)(object)button_RJ_ARTICLE2);
				}
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
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
				int num18 = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num19 = 0;
				while (true)
				{
					int num20 = num19;
					int num7 = num18;
					if (num20 > num7)
					{
						break;
					}
					DataGridView1.Columns[num19].SortMode = (DataGridViewColumnSortMode)2;
					num19++;
				}
				DataGridView1.AllowUserToAddRows = false;
				DataGridView1.AllowUserToDeleteRows = false;
				DataGridView1.AllowUserToOrderColumns = true;
				DataGridView1.AllowUserToResizeColumns = true;
				DataGridView1.AllowUserToResizeRows = false;
				DataGridView1.Columns["TOTAL_NET"].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DataGridView1.ClearSelection();
				Button_CALC_ENREGISTRER_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		decimal num = 0m;
		string right = Conversions.ToString(DataGridView1.Rows[0].Cells[0].Value);
		checked
		{
			int num2 = DataGridView1.Rows.Count - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (num3 != 0)
				{
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num3].Cells[0].Value, right, TextCompare: false))
					{
						num = Conversions.ToDecimal(Operators.AddObject(num, DataGridView1.Rows[num3].Cells[7].Value));
					}
					else
					{
						DataGridViewRow val = (DataGridViewRow)DataGridView1.Rows[0].Clone();
						val.Cells[6].Value = "TOTAL TICKET";
						val.Cells[7].Value = num;
						DataGridView1.Rows.Insert(num3, val);
						right = Conversions.ToString(DataGridView1.Rows[num3].Cells[0].Value);
						num = Conversions.ToDecimal(Operators.AddObject(0m, DataGridView1.Rows[num3].Cells[7].Value));
						num3 += 2;
					}
				}
				num3++;
			}
		}
	}

	private void Button_CALC_ENREGISTRER_Click(object sender, EventArgs e)
	{
		int num = 0;
		checked
		{
			int num2 = DataGridView1.Rows.Count - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(DataGridView1.Rows[num3].Cells["Prix_A"].Value, DataGridView1.Rows[num3].Cells["Prix_V"].Value, TextCompare: false), Operators.CompareObjectNotEqual(DataGridView1.Rows[num3].Cells["Ticket"].Value, "", TextCompare: false))))
				{
					DataGridView1.Rows[num3].Cells["Prix_A"].Style.BackColor = Color.Red;
					DataGridView1.Rows[num3].Cells["Prix_V"].Style.BackColor = Color.Red;
					num++;
				}
				num3++;
			}
			if (num > 0)
			{
				TextBox33398.Text = "Il y a " + Conversions.ToString(num) + " Erreurs";
				((Control)Panel7727).Visible = true;
				((Control)Panel7727).BringToFront();
			}
		}
	}
}
