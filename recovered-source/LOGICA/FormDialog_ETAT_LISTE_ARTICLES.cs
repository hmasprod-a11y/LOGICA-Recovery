using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
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
public class FormDialog_ETAT_LISTE_ARTICLES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Print_ETAT_LISTE_ARTICLES")]
	private PrintDocument _Print_ETAT_LISTE_ARTICLES;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("DataGridView_FAMILLES")]
	private DataGridView _DataGridView_FAMILLES;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("PRIX_V_1")]
	private DataGridViewTextBoxColumn _PRIX_V_1;

	private DataTable _DT_TEMP;

	private MySqlDataAdapter _DA_TEMP;

	private DataTable dt_ARTICLE_FIND;

	private MySqlDataAdapter da_ARTICLE_FIND;

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

	internal virtual PrintDocument Print_ETAT_LISTE_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_ETAT_LISTE_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_ETAT_LISTE_ARTICLES_PrintPage;
			if (_Print_ETAT_LISTE_ARTICLES != null)
			{
				_Print_ETAT_LISTE_ARTICLES.PrintPage -= val;
			}
			_Print_ETAT_LISTE_ARTICLES = value;
			if (_Print_ETAT_LISTE_ARTICLES != null)
			{
				_Print_ETAT_LISTE_ARTICLES.PrintPage += val;
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
			EventHandler eventHandler = Button_ConsRapport_Click;
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

	internal virtual Button Button14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button14_Click;
			if (_Button14 != null)
			{
				((Control)_Button14).Click -= eventHandler;
			}
			_Button14 = value;
			if (_Button14 != null)
			{
				((Control)_Button14).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_FAMILLES_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGridView_FAMILLES_CellClick;
			if (_DataGridView_FAMILLES != null)
			{
				_DataGridView_FAMILLES.CellContentClick -= val;
				_DataGridView_FAMILLES.CellClick -= val2;
			}
			_DataGridView_FAMILLES = value;
			if (_DataGridView_FAMILLES != null)
			{
				_DataGridView_FAMILLES.CellContentClick += val;
				_DataGridView_FAMILLES.CellClick += val2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
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
			_Label_TABLE = value;
		}
	}

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView2_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView2_CellContentClick;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellClick -= val;
				_DataGridView2.CellContentClick -= val2;
			}
			_DataGridView2 = value;
			if (_DataGridView2 != null)
			{
				_DataGridView2.CellClick += val;
				_DataGridView2.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Code
	{
		[DebuggerNonUserCode]
		get
		{
			return _Code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Code = value;
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

	internal virtual DataGridViewTextBoxColumn Famille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Famille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Famille = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_V_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V_1 = value;
		}
	}

	public FormDialog_ETAT_LISTE_ARTICLES()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_MODE_STOCK_Load;
		__ENCAddToList(this);
		_DT_TEMP = new DataTable();
		_DA_TEMP = new MySqlDataAdapter();
		dt_ARTICLE_FIND = new DataTable();
		da_ARTICLE_FIND = new MySqlDataAdapter();
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETAT_LISTE_ARTICLES));
		DataGridView1 = new DataGridView();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		PRIX_V_1 = new DataGridViewTextBoxColumn();
		Button_PrintRapport = new Button();
		Print_ETAT_LISTE_ARTICLES = new PrintDocument();
		Button14 = new Button();
		DataGridView_FAMILLES = new DataGridView();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		Label_TABLE = new Label();
		Label1 = new Label();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)DataGridView_FAMILLES).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Famille,
			(DataGridViewColumn)PRIX_V_1
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		Point location = new Point(242, 2);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		Size size = new Size(778, 588);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1040;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).FillWeight = 426.3959f;
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)Article).DefaultCellStyle = val3;
		((DataGridViewColumn)Article).FillWeight = 45.60068f;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Famille).DataPropertyName = "Famille";
		((DataGridViewColumn)Famille).FillWeight = 45.60068f;
		((DataGridViewColumn)Famille).HeaderText = "Famille";
		((DataGridViewColumn)Famille).Name = "Famille";
		Famille.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).Width = 120;
		((DataGridViewColumn)PRIX_V_1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V_1).DataPropertyName = "PRIX_V_1";
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)PRIX_V_1).DefaultCellStyle = val4;
		((DataGridViewColumn)PRIX_V_1).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V_1).Name = "PRIX_V_1";
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(853, 596);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(160, 37);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 1050;
		((ButtonBase)Button_PrintRapport).Text = "IMPRIMER";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Button14).Cursor = Cursors.Hand;
		((Control)Button14).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Button14).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button14).Image = (Image)componentResourceManager.GetObject("Button14.Image");
		((ButtonBase)Button14).ImageAlign = (ContentAlignment)16;
		Button button = Button14;
		location = new Point(853, 636);
		((Control)button).Location = location;
		Button button2 = Button14;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button14).Name = "Button14";
		Button button3 = Button14;
		size = new Size(160, 37);
		((Control)button3).Size = size;
		((Control)Button14).TabIndex = 1058;
		((ButtonBase)Button14).Text = "EXPORTER";
		((ButtonBase)Button14).UseVisualStyleBackColor = true;
		DataGridView_FAMILLES.AllowUserToAddRows = false;
		DataGridView_FAMILLES.AllowUserToResizeRows = false;
		DataGridView_FAMILLES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_FAMILLES.BackgroundColor = Color.White;
		DataGridView_FAMILLES.BorderStyle = (BorderStyle)2;
		DataGridView_FAMILLES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_FAMILLES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_FAMILLES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_FAMILLES.ColumnHeadersVisible = false;
		DataGridView_FAMILLES.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn4 });
		((Control)DataGridView_FAMILLES).Cursor = Cursors.Default;
		DataGridView_FAMILLES.EditMode = (DataGridViewEditMode)4;
		DataGridView_FAMILLES.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_FAMILLES = DataGridView_FAMILLES;
		location = new Point(12, 32);
		((Control)dataGridView_FAMILLES).Location = location;
		((Control)DataGridView_FAMILLES).Name = "DataGridView_FAMILLES";
		DataGridView_FAMILLES.RowHeadersVisible = false;
		DataGridView_FAMILLES.RowHeadersWidth = 25;
		DataGridView_FAMILLES.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_FAMILLES2 = DataGridView_FAMILLES;
		size = new Size(224, 409);
		((Control)dataGridView_FAMILLES2).Size = size;
		((Control)DataGridView_FAMILLES).TabIndex = 1059;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Famille";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(12, 2);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(224, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1060;
		Label_TABLE.Text = "Les Familles";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.White;
		Label label = Label1;
		location = new Point(12, 465);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(224, 30);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1062;
		Label1.Text = "Trier Par";
		Label1.TextAlign = (ContentAlignment)16;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToResizeRows = false;
		DataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView2.BackgroundColor = Color.White;
		DataGridView2.BorderStyle = (BorderStyle)2;
		DataGridView2.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView2.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.ColumnHeadersVisible = false;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn1 });
		((Control)DataGridView2).Cursor = Cursors.Default;
		DataGridView2.EditMode = (DataGridViewEditMode)4;
		DataGridView2.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(12, 495);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.RowHeadersVisible = false;
		DataGridView2.RowHeadersWidth = 25;
		DataGridView2.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(224, 95);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 1061;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Famille";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)DataGridView2);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)DataGridView_FAMILLES);
		((Control)this).Controls.Add((Control)(object)Button14);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Button_PrintRapport);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_ETAT_LISTE_ARTICLES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)DataGridView_FAMILLES).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_MODE_STOCK_Load(object sender, EventArgs e)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						DataGridView1.AutoGenerateColumns = false;
						DataGridView1.RowTemplate.Height = 15;
						DataGridView1.DataSource = _DT_TEMP;
						DataGridView1.BackgroundColor = Color.White;
						DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
						DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
						DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
						DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
						DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
						DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
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
						int num3 = ((BaseCollection)DataGridView1.Columns).Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							DataGridView1.Columns[num4].SortMode = (DataGridViewColumnSortMode)2;
							num4++;
						}
						DataGridView1.AllowUserToAddRows = false;
						DataGridView1.AllowUserToDeleteRows = false;
						DataGridView1.AllowUserToOrderColumns = true;
						DataGridView1.AllowUserToResizeColumns = true;
						DataGridView1.AllowUserToResizeRows = false;
						Module1.dt1.Clear();
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select Famille from TABLE_FAMILLES order by Ordre asc", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						DataGridView_FAMILLES.RowTemplate.Height = 15;
						DataGridView_FAMILLES.Rows.Clear();
						DataGridView_FAMILLES.Rows.Add(new object[1] { "TOUT" });
						int num7 = dataTable.Rows.Count - 1;
						int num8 = 0;
						while (true)
						{
							int num9 = num8;
							int num6 = num7;
							if (num9 > num6)
							{
								break;
							}
							DataGridView_FAMILLES.Rows.Add(new object[1] { dataTable.Rows[num8]["Famille"].ToString() });
							num8++;
						}
						DataGridView2.Rows.Add(new object[1] { "CODE" });
						DataGridView2.Rows.Add(new object[1] { "ARTICLE" });
						DataGridView2.Rows.Add(new object[1] { "PRIX_V" });
						goto end_IL_0001;
					}
					case 887:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 887;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_Click(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					_DT_TEMP.Clear();
					_DA_TEMP = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from     TABLE_ARTICLES      Where           MODE_STOCK  like  '", NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)), "'               order by  MODE_STOCK,FAMILLE,Article asc ")), Module1.cn_SQL);
					((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
					DataGridView1.DataSource = _DT_TEMP;
					goto end_IL_0001;
				case 143:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 143;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button_RAPPORT_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					goto end_IL_0001;
				case 33:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 33;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					_DT_TEMP.Clear();
					_DA_TEMP = new MySqlDataAdapter("select * from     TABLE_ARTICLES      Where           Qté    <=  Alert               order by  FAMILLE,Article asc ", Module1.cn_SQL);
					((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
					DataGridView1.DataSource = _DT_TEMP;
					goto end_IL_0001;
				case 102:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 102;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void Print_ETAT_LISTE_ARTICLES_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 300, 20);
						string text = Conversions.ToString(DataGridView_FAMILLES.Rows[((DataGridViewBand)DataGridView_FAMILLES.CurrentRow).Index].Cells[0].Value);
						e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle((double)e.PageBounds.Width / 2.0 - (double)(e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f)), 0f, new StringFormat((StringFormatFlags)8192));
						string text2 = "";
						int num3 = 0;
						int num4 = DataGridView1.RowCount - 1;
						int num5 = 0;
						while (true)
						{
							int num6 = num5;
							int num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							text2 = Strings.LSet(Conversions.ToString(DataGridView1.Rows[num5].Cells["CODE"].Value), 15) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num5].Cells["ARTICLE"].Value), 17) + " " + Strings.RSet(Conversions.ToString(DataGridView1.Rows[num5].Cells["PRIX_V_1"].Value), 12);
							e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num3 * 16 + 10), new StringFormat((StringFormatFlags)8192));
							num3++;
							num5++;
						}
						Module1._QUITTER_PATIENTER = true;
						goto end_IL_0001;
					}
					case 519:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 519;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_ConsRapport_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PrintPreviewDialog val = new PrintPreviewDialog();
		val.Document = Print_ETAT_LISTE_ARTICLES;
		val.PrintPreviewControl.Zoom = 2.0;
		((Form)val).WindowState = (FormWindowState)2;
		((Form)val).ShowDialog();
	}

	private void Button_PRINT_80MM_Click(object sender, EventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				int num = DataGridView1.Rows.Count * 20 + 20 + 100;
				PrintPreviewDialog val = new PrintPreviewDialog();
				val.Document = Print_ETAT_LISTE_ARTICLES;
				val.PrintPreviewControl.Zoom = 2.0;
				((Form)val).WindowState = (FormWindowState)2;
				((Form)val).ShowDialog();
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_PRINT_A4_Click(object sender, EventArgs e)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
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
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num6].Cells[num9].Value, null, TextCompare: false))
					{
						dataTable.Rows[num6][num9] = "";
					}
					else
					{
						dataTable.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
					}
					num9++;
				}
				num6++;
			}
			ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
			((Collection<ReportDataSource>)(object)MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.LocalReport.DataSources).Clear();
			((Collection<ReportDataSource>)(object)MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.LocalReport.DataSources).Add(item);
			MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.RefreshReport();
			MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.SetDisplayMode((DisplayMode)1);
			MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.ZoomMode = (ZoomMode)2;
			MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.ZoomPercent = 25;
			((Control)MyProject.Forms.Report_ETAT_STOCK).Show();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "Text Files (*.csv)|*.csv";
		((FileDialog)val).FileName = "ETAT_STOCK_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
		if ((int)((CommonDialog)val).ShowDialog() != 1)
		{
			return;
		}
		string separator = ";";
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
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
				string[] array = new string[((BaseCollection)DataGridView1.Columns).Count - 1 + 1];
				if (num2.Equals(0))
				{
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
						array[num6] = DataGridView1.Columns[num6].HeaderText;
						num6++;
					}
					stringBuilder.AppendLine(string.Join(separator, array));
				}
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
					if (!DataGridView1.Rows[num2].IsNewRow)
					{
						if (Operators.ConditionalCompareObjectEqual(DataGridView1[num9, num2].Value, null, TextCompare: false))
						{
							array[num9] = "";
						}
						else
						{
							array[num9] = DataGridView1[num9, num2].Value.ToString();
						}
					}
					num9++;
				}
				if (!DataGridView1.Rows[num2].IsNewRow)
				{
					stringBuilder.AppendLine(string.Join(separator, array));
				}
				num2++;
			}
			File.WriteAllText(((FileDialog)val).FileName, stringBuilder.ToString(), Encoding.Default);
			MessageBox.Show("exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void DataGridView_FAMILLES_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_FAMILLES_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Operators.ConditionalCompareObjectEqual(DataGridView_FAMILLES.Rows[((DataGridViewBand)DataGridView_FAMILLES.CurrentRow).Index].Cells[0].Value, "TOUT", TextCompare: false))
					{
						dt_ARTICLE_FIND.Clear();
						da_ARTICLE_FIND = new MySqlDataAdapter("select    Code,Article,FAMILLE,PRIX_V_1    from   TABLE_ARTICLES    order by      CODE     asc   ", Module1.cn_SQL);
						((DbDataAdapter)(object)da_ARTICLE_FIND).Fill(dt_ARTICLE_FIND);
					}
					else
					{
						dt_ARTICLE_FIND.Clear();
						da_ARTICLE_FIND = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select    Code,Article,FAMILLE,PRIX_V_1    from   TABLE_ARTICLES    Where   Famille = '", DataGridView_FAMILLES.Rows[((DataGridViewBand)DataGridView_FAMILLES.CurrentRow).Index].Cells[0].Value), "'    order by      CODE     asc ")), Module1.cn_SQL);
						((DbDataAdapter)(object)da_ARTICLE_FIND).Fill(dt_ARTICLE_FIND);
					}
					DataGridView1.AutoGenerateColumns = false;
					DataGridView1.DataSource = dt_ARTICLE_FIND;
					DataGridView1.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
					goto end_IL_0001;
				case 314:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 314;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[((DataGridViewBand)DataGridView2.CurrentRow).Index].Cells[0].Value, "CODE", TextCompare: false))
					{
						DataView dataView = new DataView(dt_ARTICLE_FIND);
						dataView.Sort = "CODE ASC";
						DataGridView1.DataSource = dataView;
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[((DataGridViewBand)DataGridView2.CurrentRow).Index].Cells[0].Value, "ARTICLE", TextCompare: false))
					{
						DataView dataView2 = new DataView(dt_ARTICLE_FIND);
						dataView2.Sort = "ARTICLE ASC";
						DataGridView1.DataSource = dataView2;
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[((DataGridViewBand)DataGridView2.CurrentRow).Index].Cells[0].Value, "PRIX_V", TextCompare: false))
					{
						DataView dataView3 = new DataView(dt_ARTICLE_FIND);
						dataView3.Sort = "PRIX_V_1 ASC";
						DataGridView1.DataSource = dataView3;
					}
					goto end_IL_0001;
				case 347:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 347;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
