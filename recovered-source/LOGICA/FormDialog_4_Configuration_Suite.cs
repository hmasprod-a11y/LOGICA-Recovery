using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_4_Configuration_Suite : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	[AccessedThroughProperty("LinkLabel3")]
	private LinkLabel _LinkLabel3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("OBJET")]
	private ColumnHeader _OBJET;

	[AccessedThroughProperty("VALEUR")]
	private ColumnHeader _VALEUR;

	[AccessedThroughProperty("Panel14")]
	private Panel _Panel14;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("DataGridView_pied_doc")]
	private DataGridView _DataGridView_pied_doc;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("NumericUpDown_CODE_ARTICLE_BALANCE")]
	private NumericUpDown _NumericUpDown_CODE_ARTICLE_BALANCE;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("Panel11")]
	private Panel _Panel11;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("NumericUpDown_CODE_ARTICLE")]
	private NumericUpDown _NumericUpDown_CODE_ARTICLE;

	[AccessedThroughProperty("Panel17")]
	private Panel _Panel17;

	[AccessedThroughProperty("RadioButton_FR")]
	private RadioButton _RadioButton_FR;

	[AccessedThroughProperty("RadioButton_AR")]
	private RadioButton _RadioButton_AR;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	internal virtual DataGridViewImageColumn DataGridViewImageColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewImageColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewImageColumn1 = value;
		}
	}

	internal virtual DataGridViewImageColumn DataGridViewImageColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewImageColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewImageColumn2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			LinkLabelLinkClickedEventHandler val = LinkLabel4_LinkClicked;
			if (_LinkLabel4 != null)
			{
				_LinkLabel4.LinkClicked -= val;
			}
			_LinkLabel4 = value;
			if (_LinkLabel4 != null)
			{
				_LinkLabel4.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel LinkLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			LinkLabelLinkClickedEventHandler val = LinkLabel3_LinkClicked;
			if (_LinkLabel3 != null)
			{
				_LinkLabel3.LinkClicked -= val;
			}
			_LinkLabel3 = value;
			if (_LinkLabel3 != null)
			{
				_LinkLabel3.LinkClicked += val;
			}
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

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual ColumnHeader OBJET
	{
		[DebuggerNonUserCode]
		get
		{
			return _OBJET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OBJET = value;
		}
	}

	internal virtual ColumnHeader VALEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _VALEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VALEUR = value;
		}
	}

	internal virtual Panel Panel14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel14 = value;
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

	internal virtual Button Button12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button12_Click;
			if (_Button12 != null)
			{
				((Control)_Button12).Click -= eventHandler;
			}
			_Button12 = value;
			if (_Button12 != null)
			{
				((Control)_Button12).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView_pied_doc
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_pied_doc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView_pied_doc_Validated;
			DataGridViewCellEventHandler val = DataGridView_pied_doc_CellContentClick;
			if (_DataGridView_pied_doc != null)
			{
				((Control)_DataGridView_pied_doc).Validated -= eventHandler;
				_DataGridView_pied_doc.CellContentClick -= val;
			}
			_DataGridView_pied_doc = value;
			if (_DataGridView_pied_doc != null)
			{
				((Control)_DataGridView_pied_doc).Validated += eventHandler;
				_DataGridView_pied_doc.CellContentClick += val;
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

	internal virtual NumericUpDown NumericUpDown_CODE_ARTICLE_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown_CODE_ARTICLE_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_CODE_ARTICLE_ValueChanged;
			if (_NumericUpDown_CODE_ARTICLE_BALANCE != null)
			{
				_NumericUpDown_CODE_ARTICLE_BALANCE.ValueChanged -= eventHandler;
			}
			_NumericUpDown_CODE_ARTICLE_BALANCE = value;
			if (_NumericUpDown_CODE_ARTICLE_BALANCE != null)
			{
				_NumericUpDown_CODE_ARTICLE_BALANCE.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7 = value;
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

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_CODE_ARTICLE_ValueChanged;
			if (_NumericUpDown1 != null)
			{
				_NumericUpDown1.ValueChanged -= eventHandler;
			}
			_NumericUpDown1 = value;
			if (_NumericUpDown1 != null)
			{
				_NumericUpDown1.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			LinkLabelLinkClickedEventHandler val = LinkLabel2_LinkClicked;
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.LinkClicked -= val;
			}
			_LinkLabel2 = value;
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.LinkClicked += val;
			}
		}
	}

	internal virtual Panel Panel11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel11 = value;
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

	internal virtual NumericUpDown NumericUpDown_CODE_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown_CODE_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NumericUpDown_CODE_ARTICLE_ValueChanged;
			if (_NumericUpDown_CODE_ARTICLE != null)
			{
				_NumericUpDown_CODE_ARTICLE.ValueChanged -= eventHandler;
			}
			_NumericUpDown_CODE_ARTICLE = value;
			if (_NumericUpDown_CODE_ARTICLE != null)
			{
				_NumericUpDown_CODE_ARTICLE.ValueChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel17 = value;
		}
	}

	internal virtual RadioButton RadioButton_FR
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton_FR_CheckedChanged;
			if (_RadioButton_FR != null)
			{
				_RadioButton_FR.CheckedChanged -= eventHandler;
			}
			_RadioButton_FR = value;
			if (_RadioButton_FR != null)
			{
				_RadioButton_FR.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton RadioButton_AR
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton_AR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton_AR_CheckedChanged;
			if (_RadioButton_AR != null)
			{
				_RadioButton_AR.CheckedChanged -= eventHandler;
			}
			_RadioButton_AR = value;
			if (_RadioButton_AR != null)
			{
				_RadioButton_AR.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			LinkLabelLinkClickedEventHandler val = LinkLabel1_LinkClicked;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.LinkClicked -= val;
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.LinkClicked += val;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_4_Configuration_Suite()
	{
		((Form)this).Load += FormDialog_4_Configuration_Suite_Load;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_4_Configuration_Suite));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		LinkLabel4 = new LinkLabel();
		LinkLabel3 = new LinkLabel();
		Button2 = new Button();
		ListView1 = new ListView();
		OBJET = new ColumnHeader();
		VALEUR = new ColumnHeader();
		Panel14 = new Panel();
		Label27 = new Label();
		Button12 = new Button();
		DataGridView_pied_doc = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		Panel1 = new Panel();
		Label1 = new Label();
		NumericUpDown_CODE_ARTICLE_BALANCE = new NumericUpDown();
		Panel7 = new Panel();
		Label8 = new Label();
		NumericUpDown1 = new NumericUpDown();
		LinkLabel2 = new LinkLabel();
		Panel11 = new Panel();
		Label18 = new Label();
		Label14 = new Label();
		NumericUpDown_CODE_ARTICLE = new NumericUpDown();
		Panel17 = new Panel();
		RadioButton_FR = new RadioButton();
		RadioButton_AR = new RadioButton();
		LinkLabel1 = new LinkLabel();
		((Control)Panel14).SuspendLayout();
		((ISupportInitialize)DataGridView_pied_doc).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)NumericUpDown_CODE_ARTICLE_BALANCE).BeginInit();
		((Control)Panel7).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)Panel11).SuspendLayout();
		((ISupportInitialize)NumericUpDown_CODE_ARTICLE).BeginInit();
		((Control)Panel17).SuspendLayout();
		((Control)this).SuspendLayout();
		((DataGridViewColumn)DataGridViewImageColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn1).FillWeight = 152.2843f;
		DataGridViewImageColumn1.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)DataGridViewImageColumn1).Name = "DataGridViewImageColumn1";
		((DataGridViewColumn)DataGridViewImageColumn1).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn1, "DataGridViewImageColumn1");
		((DataGridViewColumn)DataGridViewImageColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn2).FillWeight = 128.1901f;
		DataGridViewImageColumn2.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)DataGridViewImageColumn2).Name = "DataGridViewImageColumn2";
		((DataGridViewColumn)DataGridViewImageColumn2).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn2, "DataGridViewImageColumn2");
		((Control)LinkLabel4).BackColor = Color.Yellow;
		((Control)LinkLabel4).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(LinkLabel4, "LinkLabel4");
		((Control)LinkLabel4).Name = "LinkLabel4";
		LinkLabel4.TabStop = true;
		((Control)LinkLabel3).BackColor = Color.Yellow;
		((Control)LinkLabel3).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(LinkLabel3, "LinkLabel3");
		((Control)LinkLabel3).Name = "LinkLabel3";
		LinkLabel3.TabStop = true;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((ButtonBase)Button2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).ForeColor = Color.White;
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		ListView1.Activation = (ItemActivation)1;
		ListView1.Columns.AddRange(new ColumnHeader[2] { OBJET, VALEUR });
		ListView1.FullRowSelect = true;
		componentResourceManager.ApplyResources(ListView1, "ListView1");
		ListView1.MultiSelect = false;
		((Control)ListView1).Name = "ListView1";
		ListView1.UseCompatibleStateImageBehavior = false;
		ListView1.View = (View)1;
		componentResourceManager.ApplyResources(OBJET, "OBJET");
		componentResourceManager.ApplyResources(VALEUR, "VALEUR");
		componentResourceManager.ApplyResources(Panel14, "Panel14");
		((Control)Panel14).BackColor = Color.Transparent;
		Panel14.BorderStyle = (BorderStyle)1;
		((Control)Panel14).Controls.Add((Control)(object)Label27);
		((Control)Panel14).Controls.Add((Control)(object)Button12);
		((Control)Panel14).Controls.Add((Control)(object)DataGridView_pied_doc);
		((Control)Panel14).Name = "Panel14";
		((Control)Label27).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).ForeColor = Color.White;
		((Control)Label27).Name = "Label27";
		Label27.UseCompatibleTextRendering = true;
		((Control)Button12).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button12, "Button12");
		((Control)Button12).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button12).Name = "Button12";
		((ButtonBase)Button12).UseCompatibleTextRendering = true;
		((ButtonBase)Button12).UseVisualStyleBackColor = true;
		DataGridView_pied_doc.AllowUserToResizeColumns = false;
		DataGridView_pied_doc.AllowUserToResizeRows = false;
		DataGridView_pied_doc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_pied_doc.BackgroundColor = Color.White;
		DataGridView_pied_doc.CellBorderStyle = (DataGridViewCellBorderStyle)9;
		DataGridView_pied_doc.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView_pied_doc.ColumnHeadersDefaultCellStyle = val;
		componentResourceManager.ApplyResources(DataGridView_pied_doc, "DataGridView_pied_doc");
		DataGridView_pied_doc.ColumnHeadersVisible = false;
		DataGridView_pied_doc.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn1 });
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Inconsolata Condensed", 15f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView_pied_doc.DefaultCellStyle = val2;
		DataGridView_pied_doc.EditMode = (DataGridViewEditMode)0;
		DataGridView_pied_doc.EnableHeadersVisualStyles = false;
		DataGridView_pied_doc.GridColor = SystemColors.ButtonFace;
		((Control)DataGridView_pied_doc).Name = "DataGridView_pied_doc";
		DataGridView_pied_doc.RowHeadersVisible = false;
		DataGridView_pied_doc.SelectionMode = (DataGridViewSelectionMode)1;
		((Control)DataGridView_pied_doc).Tag = "PIED_DOC";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1");
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((Control)Panel1).BackColor = Color.White;
		Panel1.BorderStyle = (BorderStyle)1;
		((Control)Panel1).Controls.Add((Control)(object)Label1);
		((Control)Panel1).Controls.Add((Control)(object)NumericUpDown_CODE_ARTICLE_BALANCE);
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).Name = "Panel1";
		((Control)Label1).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.DimGray;
		((Control)Label1).Name = "Label1";
		componentResourceManager.ApplyResources(NumericUpDown_CODE_ARTICLE_BALANCE, "NumericUpDown_CODE_ARTICLE_BALANCE");
		((Control)NumericUpDown_CODE_ARTICLE_BALANCE).Name = "NumericUpDown_CODE_ARTICLE_BALANCE";
		((Control)NumericUpDown_CODE_ARTICLE_BALANCE).Tag = "NBR_CODE_BALANCE";
		((Control)Panel7).BackColor = Color.White;
		Panel7.BorderStyle = (BorderStyle)1;
		((Control)Panel7).Controls.Add((Control)(object)Label8);
		((Control)Panel7).Controls.Add((Control)(object)NumericUpDown1);
		componentResourceManager.ApplyResources(Panel7, "Panel7");
		((Control)Panel7).Name = "Panel7";
		((Control)Label8).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.DimGray;
		((Control)Label8).Name = "Label8";
		componentResourceManager.ApplyResources(NumericUpDown1, "NumericUpDown1");
		((Control)NumericUpDown1).Name = "NumericUpDown1";
		((Control)NumericUpDown1).Tag = "HEURE_RETARD";
		((Control)LinkLabel2).BackColor = Color.Yellow;
		((Control)LinkLabel2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(LinkLabel2, "LinkLabel2");
		((Control)LinkLabel2).Name = "LinkLabel2";
		LinkLabel2.TabStop = true;
		((Control)Panel11).BackColor = Color.White;
		Panel11.BorderStyle = (BorderStyle)1;
		((Control)Panel11).Controls.Add((Control)(object)Label18);
		((Control)Panel11).Controls.Add((Control)(object)Label14);
		((Control)Panel11).Controls.Add((Control)(object)NumericUpDown_CODE_ARTICLE);
		componentResourceManager.ApplyResources(Panel11, "Panel11");
		((Control)Panel11).Name = "Panel11";
		((Control)Label18).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).ForeColor = Color.DimGray;
		((Control)Label18).Name = "Label18";
		componentResourceManager.ApplyResources(Label14, "Label14");
		((Control)Label14).BackColor = Color.Transparent;
		((Control)Label14).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label14).Name = "Label14";
		Label14.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(NumericUpDown_CODE_ARTICLE, "NumericUpDown_CODE_ARTICLE");
		((Control)NumericUpDown_CODE_ARTICLE).Name = "NumericUpDown_CODE_ARTICLE";
		((Control)NumericUpDown_CODE_ARTICLE).Tag = "NBR_CODE_ARTICLE";
		((Control)Panel17).BackColor = Color.White;
		Panel17.BorderStyle = (BorderStyle)1;
		((Control)Panel17).Controls.Add((Control)(object)RadioButton_FR);
		((Control)Panel17).Controls.Add((Control)(object)RadioButton_AR);
		componentResourceManager.ApplyResources(Panel17, "Panel17");
		((Control)Panel17).Name = "Panel17";
		componentResourceManager.ApplyResources(RadioButton_FR, "RadioButton_FR");
		((Control)RadioButton_FR).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_FR).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)RadioButton_FR).Name = "RadioButton_FR";
		RadioButton_FR.TabStop = true;
		((Control)RadioButton_FR).Tag = "LANGUE";
		((ButtonBase)RadioButton_FR).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(RadioButton_AR, "RadioButton_AR");
		((Control)RadioButton_AR).Cursor = Cursors.Hand;
		((ButtonBase)RadioButton_AR).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)RadioButton_AR).Name = "RadioButton_AR";
		RadioButton_AR.TabStop = true;
		((Control)RadioButton_AR).Tag = "LANGUE";
		((ButtonBase)RadioButton_AR).UseVisualStyleBackColor = true;
		((Control)LinkLabel1).BackColor = Color.Yellow;
		((Control)LinkLabel1).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(LinkLabel1, "LinkLabel1");
		((Control)LinkLabel1).Name = "LinkLabel1";
		LinkLabel1.TabStop = true;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.WhiteSmoke;
		((Control)this).Controls.Add((Control)(object)LinkLabel4);
		((Control)this).Controls.Add((Control)(object)LinkLabel3);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)ListView1);
		((Control)this).Controls.Add((Control)(object)Panel14);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Panel7);
		((Control)this).Controls.Add((Control)(object)LinkLabel2);
		((Control)this).Controls.Add((Control)(object)Panel11);
		((Control)this).Controls.Add((Control)(object)Panel17);
		((Control)this).Controls.Add((Control)(object)LinkLabel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_4_Configuration_Suite";
		((Form)this).ShowIcon = false;
		((Control)Panel14).ResumeLayout(false);
		((ISupportInitialize)DataGridView_pied_doc).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)NumericUpDown_CODE_ARTICLE_BALANCE).EndInit();
		((Control)Panel7).ResumeLayout(false);
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)Panel11).ResumeLayout(false);
		((Control)Panel11).PerformLayout();
		((ISupportInitialize)NumericUpDown_CODE_ARTICLE).EndInit();
		((Control)Panel17).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_4_Configuration_Suite_Load(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		MySqlCommand val = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		val.CommandText = "select    *     from     TABLE_PARAMETRES     where     ID   BETWEEN   41  AND  50    ";
		val.Connection = Module1.cn_SQL;
		val.ExecuteNonQuery();
		ListView1.Items.Clear();
		MySqlDataReader val2 = val.ExecuteReader();
		checked
		{
			if (val2.HasRows)
			{
				while (val2.Read())
				{
					ListView1.Items.Add(val2["OBJET"].ToString());
					ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(val2["VALEUR"].ToString());
				}
			}
			val2.Close();
			Module1.cn_SQL.Close();
			NumericUpDown_CODE_ARTICLE.Text = ListView1.Items[ListView1.FindItemWithText("NBR_CODE_ARTICLE", false, 0).Index].SubItems[1].Text;
			NumericUpDown_CODE_ARTICLE_BALANCE.Text = ListView1.Items[ListView1.FindItemWithText("NBR_CODE_BALANCE", false, 0).Index].SubItems[1].Text;
			NumericUpDown1.Text = ListView1.Items[ListView1.FindItemWithText("HEURE_RETARD", false, 0).Index].SubItems[1].Text;
			if (Operators.CompareString(ListView1.Items[ListView1.FindItemWithText("LANGUE", false, 0).Index].SubItems[1].Text, "fr", TextCompare: false) == 0)
			{
				RadioButton_FR.Checked = true;
			}
			else if (Operators.CompareString(ListView1.Items[ListView1.FindItemWithText("LANGUE", false, 0).Index].SubItems[1].Text, "ar", TextCompare: false) == 0)
			{
				RadioButton_AR.Checked = true;
			}
			DataGridView_pied_doc.Rows.Clear();
			string text = "";
			StringReader stringReader = new StringReader(Strings.Trim(ListView1.Items[ListView1.FindItemWithText("PIED_DOC", false, 0).Index].SubItems[1].Text));
			while (stringReader.Peek() != -1)
			{
				DataGridView_pied_doc.Rows.Add(new object[1] { stringReader.ReadLine() });
				DataGridView_pied_doc.CurrentCell = DataGridView_pied_doc.Rows[DataGridView_pied_doc.Rows.Count - 1].Cells[0];
				DataGridView_pied_doc.Rows[DataGridView_pied_doc.Rows.Count - 1].Selected = true;
			}
			stringReader.Close();
		}
	}

	private void Button11_Click_1(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		File.WriteAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\code_article.sni", NumericUpDown_CODE_ARTICLE.Text);
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (RadioButton_FR.Checked)
		{
			File.WriteAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\langue.sni", "fr");
		}
		else if (RadioButton_AR.Checked)
		{
			File.WriteAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\langue.sni", "ar");
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button20_Click_2(object sender, EventArgs e)
	{
		File.WriteAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\heures_retard.sni", NumericUpDown1.Text);
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://download.microsoft.com/download/B/9/5/B95E7D3E-F4B6-425A-AA08-C55CE562A661/MSChart.exe");
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://download.microsoft.com/download/A/7/5/A75827B3-03EC-4662-B3DE-826B31DBF790/ReportViewer.exe");
	}

	private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x32-624fr.exe");
	}

	private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://drive.usercontent.google.com/download?id=1IeS8hF6ahecXYxBpwp_N3k-hP5aJ5rf6&export=download&authuser=0&confirm=t&uuid=d2d60908-c0d9-4311-9ca5-1acc4a94ac9f&at=APZUnTV3Qh3dC0IigJHYEG1C3VjJ%3A1706005960996");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		File.WriteAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\code_article_balance.sni", NumericUpDown_CODE_ARTICLE_BALANCE.Text);
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridView_pied_doc.Rows.RemoveAt(DataGridView_pied_doc.CurrentCell.RowIndex);
			((Control)DataGridView_pied_doc).Focus();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception e2 = ex;
			StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				int num = ListView1.Items.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					val.CommandText = "UPDATE     TABLE_PARAMETRES    SET    VALEUR = N'" + ListView1.Items[num2].SubItems[1].Text + "'     where  OBJET = '" + ListView1.Items[num2].Text + "'      ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					num2++;
				}
				val.CommandText = "select    *     from     TABLE_PARAMETRES       ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				MyProject.Forms.Form_0_TEMPLATE.ListView1.Items.Clear();
				MySqlDataReader val2 = val.ExecuteReader();
				if (val2.HasRows)
				{
					while (val2.Read())
					{
						MyProject.Forms.Form_0_TEMPLATE.ListView1.Items.Add(val2["OBJET"].ToString());
						MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.Items.Count - 1].SubItems.Add(val2["VALEUR"].ToString());
					}
				}
				val2.Close();
				Module1.cn_SQL.Close();
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void NumericUpDown_CODE_ARTICLE_ValueChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}
	}

	private void DataGridView_pied_doc_Validated(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val == null)
		{
			return;
		}
		string text = "";
		checked
		{
			int num = DataGridView_pied_doc.Rows.Count - 2;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Conversions.ToBoolean(Operators.OrObject(DataGridView_pied_doc.Rows[num2].Cells[0].Value == DBNull.Value, Operators.CompareObjectEqual(DataGridView_pied_doc.Rows[num2].Cells[0].Value, null, TextCompare: false))))
				{
					DataGridView_pied_doc.Rows[num2].Cells[0].Value = " ";
				}
				text = text + DataGridView_pied_doc.Rows[num2].Cells[0].Value.ToString() + "\r\n";
				num2++;
			}
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = text;
		}
	}

	private void RadioButton_FR_CheckedChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = "fr";
		}
	}

	private void RadioButton_AR_CheckedChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = "ar";
		}
	}

	private void DataGridView_pied_doc_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
