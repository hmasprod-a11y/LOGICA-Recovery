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
public class Form_3_VENTE_RETOURS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("FlowLayout_FAMILLES")]
	private FlowLayoutPanel _FlowLayout_FAMILLES;

	[AccessedThroughProperty("ID_TICKET")]
	private DataGridViewTextBoxColumn _ID_TICKET;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("PRIX_V")]
	private DataGridViewTextBoxColumn _PRIX_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("Total_NETt")]
	private DataGridViewTextBoxColumn _Total_NETt;

	[AccessedThroughProperty("Caissier")]
	private DataGridViewTextBoxColumn _Caissier;

	[AccessedThroughProperty("OPERATION")]
	private DataGridViewTextBoxColumn _OPERATION;

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

	internal virtual DataGridViewTextBoxColumn PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V = value;
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

	internal virtual DataGridViewTextBoxColumn Total_NETt
	{
		[DebuggerNonUserCode]
		get
		{
			return _Total_NETt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Total_NETt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Caissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Caissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Caissier = value;
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

	public Form_3_VENTE_RETOURS()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_LOG_RETOURS_Load;
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
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_3_VENTE_RETOURS));
		DataGridView1 = new DataGridView();
		ID_TICKET = new DataGridViewTextBoxColumn();
		Dates = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		PRIX_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		Total_NETt = new DataGridViewTextBoxColumn();
		Caissier = new DataGridViewTextBoxColumn();
		OPERATION = new DataGridViewTextBoxColumn();
		FlowLayout_FAMILLES = new FlowLayoutPanel();
		((ISupportInitialize)DataGridView1).BeginInit();
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
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)ID_TICKET,
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)PRIX_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)Total_NETt,
			(DataGridViewColumn)Caissier,
			(DataGridViewColumn)OPERATION
		});
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(0, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(861, 339);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 854;
		((DataGridViewColumn)ID_TICKET).DataPropertyName = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).HeaderText = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).Name = "ID_TICKET";
		ID_TICKET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Dates).DataPropertyName = "Dates";
		((DataGridViewColumn)Dates).HeaderText = "Dates";
		((DataGridViewColumn)Dates).Name = "Dates";
		Dates.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V).DataPropertyName = "PRIX_V";
		((DataGridViewColumn)PRIX_V).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V).Name = "PRIX_V";
		PRIX_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		((DataGridViewColumn)Total_NETt).DataPropertyName = "TOTAL_NET";
		((DataGridViewColumn)Total_NETt).HeaderText = "TOTAL_NET";
		((DataGridViewColumn)Total_NETt).Name = "Total_NETt";
		Total_NETt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Caissier).DataPropertyName = "Caissier";
		((DataGridViewColumn)Caissier).HeaderText = "Caissier";
		((DataGridViewColumn)Caissier).Name = "Caissier";
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
		((Control)FlowLayout_FAMILLES).TabIndex = 995;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(861, 398);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)FlowLayout_FAMILLES);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_3_VENTE_RETOURS";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "VENTE RETOURS";
		((ISupportInitialize)DataGridView1).EndInit();
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

	private void FormDialog_LOG_RETOURS_Load(object sender, EventArgs e)
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
					_da = new MySqlDataAdapter("select    ID_TICKET,DATES,ARTICLE,PRIX_V,Qté,TOTAL_NET,CAISSIER,OPERATION          from    TABLE_VENTES_JOURNAL   Where   CLOTURE_GLOBALE IS  NULL     And     (OPERATION  = 'RETOUR REMBOURSEMENT'     or    OPERATION  = 'RETOUR AVOIR')    order by ID desc", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select   DISTINCT     OPERATION    from TABLE_VENTES_JOURNAL   Where   CLOTURE_GLOBALE IS  NULL  And     (OPERATION  = 'RETOUR REMBOURSEMENT'     or    OPERATION  = 'RETOUR AVOIR')     ", Module1.cn_SQL);
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
							val2 = new MySqlDataAdapter(" select sum(Total_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE       OPERATION  = '" + Strings.Trim(dataTable.Rows[num2]["OPERATION"].ToString()) + "'          AND    CLOTURE_GLOBALE IS  NULL    ", Module1.cn_SQL);
							dataTable2 = new DataTable();
							dataTable2.Clear();
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							double num5 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
							val2 = new MySqlDataAdapter("select   DISTINCT     ID_TICKET         from    TABLE_VENTES_JOURNAL        WHERE       OPERATION  = '" + Strings.Trim(dataTable.Rows[num2]["OPERATION"].ToString()) + "'          AND    CLOTURE_GLOBALE IS  NULL       ", Module1.cn_SQL);
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
					_da = new MySqlDataAdapter("select     ID_TICKET,DATES,ARTICLE,PRIX_V,Qté,TOTAL_NET,CAISSIER,OPERATION       from     TABLE_VENTES_JOURNAL        Where  Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '                And     (OPERATION  = 'RETOUR REMBOURSEMENT'     or    OPERATION  = 'RETOUR AVOIR')          order by ID desc ", Module1.cn_SQL);
					((DbDataAdapter)(object)_da).Fill(_dt);
					DataTable dataTable3 = new DataTable();
					MySqlDataAdapter val3 = new MySqlDataAdapter();
					dataTable3.Clear();
					val3 = new MySqlDataAdapter("select   DISTINCT     OPERATION    from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '   And     (OPERATION  = 'RETOUR REMBOURSEMENT'     or    OPERATION  = 'RETOUR AVOIR')     ", Module1.cn_SQL);
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
						val4 = new MySqlDataAdapter("select sum(Total_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     OPERATION  = '" + Strings.Trim(dataTable3.Rows[num8]["OPERATION"].ToString()) + "'  ", Module1.cn_SQL);
						dataTable4 = new DataTable();
						dataTable4.Clear();
						((DbDataAdapter)(object)val4).Fill(dataTable4);
						double num10 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
						val4 = new MySqlDataAdapter("select   DISTINCT     ID_TICKET         from    TABLE_VENTES_JOURNAL        WHERE   Dates   between   ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(MyProject.Forms.Form_3_VENTE_JOURNAL.DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     OPERATION  = '" + Strings.Trim(dataTable3.Rows[num8]["OPERATION"].ToString()) + "'  ", Module1.cn_SQL);
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
}
