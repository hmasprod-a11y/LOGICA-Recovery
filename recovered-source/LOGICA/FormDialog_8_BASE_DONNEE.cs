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
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_8_BASE_DONNEE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("Check_COMPACTER")]
	private CheckBox _Check_COMPACTER;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Text_SQL")]
	private TextBox _Text_SQL;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("DataGridView_ID")]
	private DataGridView _DataGridView_ID;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("Label_ID_TICKET")]
	private Label _Label_ID_TICKET;

	[AccessedThroughProperty("Panel21233")]
	private Panel _Panel21233;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label_MODE_P")]
	private Label _Label_MODE_P;

	[AccessedThroughProperty("Button43233")]
	private Button _Button43233;

	[AccessedThroughProperty("Text_MODE_P_FIND")]
	private TextBox _Text_MODE_P_FIND;

	[AccessedThroughProperty("Panel232323")]
	private Panel _Panel232323;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label_CLIENT")]
	private Label _Label_CLIENT;

	[AccessedThroughProperty("Label_ID_CLIENT")]
	private Label _Label_ID_CLIENT;

	[AccessedThroughProperty("Button43333")]
	private Button _Button43333;

	[AccessedThroughProperty("Text_ID_CLIENT_FIND")]
	private TextBox _Text_ID_CLIENT_FIND;

	[AccessedThroughProperty("Radio_CHANG_MODE_P")]
	private RadioButton _Radio_CHANG_MODE_P;

	[AccessedThroughProperty("Radio_CHANG_CLIENT")]
	private RadioButton _Radio_CHANG_CLIENT;

	[AccessedThroughProperty("Radio_SUPPRIMER")]
	private RadioButton _Radio_SUPPRIMER;

	[AccessedThroughProperty("Label1232243")]
	private Label _Label1232243;

	[AccessedThroughProperty("Button164343")]
	private Button _Button164343;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_ID_TICKET")]
	private TextBox _Text_ID_TICKET;

	[AccessedThroughProperty("Button13232")]
	private Button _Button13232;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("Radio_VALIDER")]
	private RadioButton _Radio_VALIDER;

	[AccessedThroughProperty("Radio_ENREGISTRER")]
	private RadioButton _Radio_ENREGISTRER;

	[AccessedThroughProperty("Label_ID_DOC")]
	private Label _Label_ID_DOC;

	[AccessedThroughProperty("Label632323")]
	private Label _Label632323;

	[AccessedThroughProperty("Button44421")]
	private Button _Button44421;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Combo_TYPE_DOC")]
	private ComboBox _Combo_TYPE_DOC;

	[AccessedThroughProperty("Button26323")]
	private Button _Button26323;

	[AccessedThroughProperty("Text_ID_DOC")]
	private TextBox _Text_ID_DOC;

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

	internal virtual CheckedListBox CheckedListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual CheckBox Check_COMPACTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_COMPACTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_COMPACTER = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual CheckBox CheckBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox7_CheckedChanged;
			if (_CheckBox7 != null)
			{
				_CheckBox7.CheckedChanged -= eventHandler;
			}
			_CheckBox7 = value;
			if (_CheckBox7 != null)
			{
				_CheckBox7.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button9_Click;
			if (_Button9 != null)
			{
				((Control)_Button9).Click -= eventHandler;
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				((Control)_Button9).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_SQL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_SQL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyEventHandler val = Text_SQL_KeyDown;
			EventHandler eventHandler = Text_SQL_TextChanged;
			if (_Text_SQL != null)
			{
				((Control)_Text_SQL).KeyDown -= val;
				((Control)_Text_SQL).TextChanged -= eventHandler;
			}
			_Text_SQL = value;
			if (_Text_SQL != null)
			{
				((Control)_Text_SQL).KeyDown += val;
				((Control)_Text_SQL).TextChanged += eventHandler;
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

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
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

	internal virtual DataGridView DataGridView_ID
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_ID = value;
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

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
		}
	}

	internal virtual Label Label_ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ID_TICKET = value;
		}
	}

	internal virtual Panel Panel21233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel21233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel21233 = value;
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

	internal virtual Label Label_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_MODE_P = value;
		}
	}

	internal virtual Button Button43233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button43233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button43233_Click;
			if (_Button43233 != null)
			{
				((Control)_Button43233).Click -= eventHandler;
			}
			_Button43233 = value;
			if (_Button43233 != null)
			{
				((Control)_Button43233).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_MODE_P_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MODE_P_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_MODE_P_FIND = value;
		}
	}

	internal virtual Panel Panel232323
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel232323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel232323 = value;
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

	internal virtual Label Label_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CLIENT = value;
		}
	}

	internal virtual Label Label_ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ID_CLIENT = value;
		}
	}

	internal virtual Button Button43333
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button43333;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button43333_Click;
			if (_Button43333 != null)
			{
				((Control)_Button43333).Click -= eventHandler;
			}
			_Button43333 = value;
			if (_Button43333 != null)
			{
				((Control)_Button43333).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_ID_CLIENT_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_CLIENT_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_CLIENT_FIND = value;
		}
	}

	internal virtual RadioButton Radio_CHANG_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_CHANG_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_CHANG_MODE_P_CheckedChanged;
			if (_Radio_CHANG_MODE_P != null)
			{
				_Radio_CHANG_MODE_P.CheckedChanged -= eventHandler;
			}
			_Radio_CHANG_MODE_P = value;
			if (_Radio_CHANG_MODE_P != null)
			{
				_Radio_CHANG_MODE_P.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio_CHANG_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_CHANG_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_CHANG_CLIENT_CheckedChanged;
			if (_Radio_CHANG_CLIENT != null)
			{
				_Radio_CHANG_CLIENT.CheckedChanged -= eventHandler;
			}
			_Radio_CHANG_CLIENT = value;
			if (_Radio_CHANG_CLIENT != null)
			{
				_Radio_CHANG_CLIENT.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio_SUPPRIMER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_SUPPRIMER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Radio_SUPPRIMER = value;
		}
	}

	internal virtual Label Label1232243
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1232243;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1232243 = value;
		}
	}

	internal virtual Button Button164343
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button164343;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button164343_Click;
			if (_Button164343 != null)
			{
				((Control)_Button164343).Click -= eventHandler;
			}
			_Button164343 = value;
			if (_Button164343 != null)
			{
				((Control)_Button164343).Click += eventHandler;
			}
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

	internal virtual TextBox Text_ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_TICKET = value;
		}
	}

	internal virtual Button Button13232
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button13232;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button13232_Click;
			if (_Button13232 != null)
			{
				((Control)_Button13232).Click -= eventHandler;
			}
			_Button13232 = value;
			if (_Button13232 != null)
			{
				((Control)_Button13232).Click += eventHandler;
			}
		}
	}

	internal virtual TabPage TabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage7 = value;
		}
	}

	internal virtual RadioButton Radio_VALIDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_VALIDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Radio_VALIDER = value;
		}
	}

	internal virtual RadioButton Radio_ENREGISTRER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_ENREGISTRER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Radio_ENREGISTRER = value;
		}
	}

	internal virtual Label Label_ID_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ID_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ID_DOC = value;
		}
	}

	internal virtual Label Label632323
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label632323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label632323 = value;
		}
	}

	internal virtual Button Button44421
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button44421;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button44421_Click;
			if (_Button44421 != null)
			{
				((Control)_Button44421).Click -= eventHandler;
			}
			_Button44421 = value;
			if (_Button44421 != null)
			{
				((Control)_Button44421).Click += eventHandler;
			}
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

	internal virtual ComboBox Combo_TYPE_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TYPE_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_TYPE_DOC = value;
		}
	}

	internal virtual Button Button26323
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button26323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button26323_Click;
			if (_Button26323 != null)
			{
				((Control)_Button26323).Click -= eventHandler;
			}
			_Button26323 = value;
			if (_Button26323 != null)
			{
				((Control)_Button26323).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_ID_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_DOC = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_8_BASE_DONNEE()
	{
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_8_BASE_DONNEE));
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		CheckedListBox1 = new CheckedListBox();
		Check_COMPACTER = new CheckBox();
		Label12 = new Label();
		CheckBox7 = new CheckBox();
		Button9 = new Button();
		Text_SQL = new TextBox();
		Panel1 = new Panel();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox5 = new PictureBox();
		Label1 = new Label();
		Panel3 = new Panel();
		Button1 = new Button();
		Button3 = new Button();
		DataGridView_ID = new DataGridView();
		Button2 = new Button();
		TabControl1 = new TabControl();
		TabPage6 = new TabPage();
		Label_ID_TICKET = new Label();
		Panel21233 = new Panel();
		TextBox1 = new TextBox();
		Label_MODE_P = new Label();
		Button43233 = new Button();
		Text_MODE_P_FIND = new TextBox();
		Panel232323 = new Panel();
		TextBox2 = new TextBox();
		Label_CLIENT = new Label();
		Label_ID_CLIENT = new Label();
		Button43333 = new Button();
		Text_ID_CLIENT_FIND = new TextBox();
		Radio_CHANG_MODE_P = new RadioButton();
		Radio_CHANG_CLIENT = new RadioButton();
		Radio_SUPPRIMER = new RadioButton();
		Label1232243 = new Label();
		Button164343 = new Button();
		Label7 = new Label();
		Text_ID_TICKET = new TextBox();
		Button13232 = new Button();
		TabPage7 = new TabPage();
		Radio_VALIDER = new RadioButton();
		Radio_ENREGISTRER = new RadioButton();
		Label_ID_DOC = new Label();
		Label632323 = new Label();
		Button44421 = new Button();
		Label4 = new Label();
		Combo_TYPE_DOC = new ComboBox();
		Button26323 = new Button();
		Text_ID_DOC = new TextBox();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)DataGridView_ID).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)Panel21233).SuspendLayout();
		((Control)Panel232323).SuspendLayout();
		((Control)TabPage7).SuspendLayout();
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
		((ListControl)CheckedListBox1).FormattingEnabled = true;
		((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).AddRange(new object[27]
		{
			componentResourceManager.GetString("CheckedListBox1.Items"),
			componentResourceManager.GetString("CheckedListBox1.Items1"),
			componentResourceManager.GetString("CheckedListBox1.Items2"),
			componentResourceManager.GetString("CheckedListBox1.Items3"),
			componentResourceManager.GetString("CheckedListBox1.Items4"),
			componentResourceManager.GetString("CheckedListBox1.Items5"),
			componentResourceManager.GetString("CheckedListBox1.Items6"),
			componentResourceManager.GetString("CheckedListBox1.Items7"),
			componentResourceManager.GetString("CheckedListBox1.Items8"),
			componentResourceManager.GetString("CheckedListBox1.Items9"),
			componentResourceManager.GetString("CheckedListBox1.Items10"),
			componentResourceManager.GetString("CheckedListBox1.Items11"),
			componentResourceManager.GetString("CheckedListBox1.Items12"),
			componentResourceManager.GetString("CheckedListBox1.Items13"),
			componentResourceManager.GetString("CheckedListBox1.Items14"),
			componentResourceManager.GetString("CheckedListBox1.Items15"),
			componentResourceManager.GetString("CheckedListBox1.Items16"),
			componentResourceManager.GetString("CheckedListBox1.Items17"),
			componentResourceManager.GetString("CheckedListBox1.Items18"),
			componentResourceManager.GetString("CheckedListBox1.Items19"),
			componentResourceManager.GetString("CheckedListBox1.Items20"),
			componentResourceManager.GetString("CheckedListBox1.Items21"),
			componentResourceManager.GetString("CheckedListBox1.Items22"),
			componentResourceManager.GetString("CheckedListBox1.Items23"),
			componentResourceManager.GetString("CheckedListBox1.Items24"),
			componentResourceManager.GetString("CheckedListBox1.Items25"),
			componentResourceManager.GetString("CheckedListBox1.Items26")
		});
		componentResourceManager.ApplyResources(CheckedListBox1, "CheckedListBox1");
		((Control)CheckedListBox1).Name = "CheckedListBox1";
		CheckedListBox1.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Check_COMPACTER, "Check_COMPACTER");
		((ButtonBase)Check_COMPACTER).BackColor = Color.White;
		Check_COMPACTER.Checked = true;
		Check_COMPACTER.CheckState = (CheckState)1;
		((Control)Check_COMPACTER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Check_COMPACTER).Name = "Check_COMPACTER";
		((ButtonBase)Check_COMPACTER).UseCompatibleTextRendering = true;
		((ButtonBase)Check_COMPACTER).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Label12, "Label12");
		((Control)Label12).BackColor = Color.White;
		((Control)Label12).ForeColor = Color.FromArgb(232, 72, 73);
		((Control)Label12).Name = "Label12";
		Label12.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(CheckBox7, "CheckBox7");
		((ButtonBase)CheckBox7).BackColor = Color.White;
		((Control)CheckBox7).ForeColor = Color.Black;
		((Control)CheckBox7).Name = "CheckBox7";
		((ButtonBase)CheckBox7).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox7).UseVisualStyleBackColor = false;
		((Control)Button9).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button9, "Button9");
		((Control)Button9).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button9).Name = "Button9";
		((ButtonBase)Button9).UseCompatibleTextRendering = true;
		((ButtonBase)Button9).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_SQL).BorderStyle = (BorderStyle)0;
		((TextBoxBase)Text_SQL).ForeColor = Color.White;
		componentResourceManager.ApplyResources(Text_SQL, "Text_SQL");
		((Control)Text_SQL).Name = "Text_SQL";
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).BackColor = Color.Black;
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel1).Controls.Add((Control)(object)Label1);
		((Control)Panel1).Name = "Panel1";
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).ForeColor = Color.Yellow;
		((Control)Label3).Name = "Label3";
		Label3.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).ForeColor = Color.Yellow;
		((Control)Label2).Name = "Label2";
		Label2.UseCompatibleTextRendering = true;
		((Control)PictureBox5).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(PictureBox5, "PictureBox5");
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox5.TabStop = false;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).ForeColor = Color.Yellow;
		((Control)Label1).Name = "Label1";
		Label1.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Panel3, "Panel3");
		((Control)Panel3).BackColor = Color.White;
		Panel3.BorderStyle = (BorderStyle)1;
		((Control)Panel3).Controls.Add((Control)(object)Button1);
		((Control)Panel3).Controls.Add((Control)(object)Button3);
		((Control)Panel3).Controls.Add((Control)(object)DataGridView_ID);
		((Control)Panel3).Controls.Add((Control)(object)Button2);
		((Control)Panel3).Name = "Panel3";
		componentResourceManager.ApplyResources(Button1, "Button1");
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button3, "Button3");
		((Control)Button3).Name = "Button3";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		DataGridView_ID.AllowUserToAddRows = false;
		DataGridView_ID.AllowUserToDeleteRows = false;
		DataGridView_ID.AllowUserToResizeColumns = false;
		DataGridView_ID.AllowUserToResizeRows = false;
		componentResourceManager.ApplyResources(DataGridView_ID, "DataGridView_ID");
		DataGridView_ID.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_ID.BackgroundColor = Color.White;
		DataGridView_ID.BorderStyle = (BorderStyle)2;
		DataGridView_ID.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_ID.EnableHeadersVisualStyles = false;
		((Control)DataGridView_ID).Name = "DataGridView_ID";
		DataGridView_ID.RowHeadersVisible = false;
		DataGridView_ID.SelectionMode = (DataGridViewSelectionMode)1;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(TabControl1, "TabControl1");
		((Control)TabControl1).Controls.Add((Control)(object)TabPage6);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage7);
		TabControl1.Multiline = true;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		((Control)TabPage6).Controls.Add((Control)(object)Label_ID_TICKET);
		((Control)TabPage6).Controls.Add((Control)(object)Panel21233);
		((Control)TabPage6).Controls.Add((Control)(object)Panel232323);
		((Control)TabPage6).Controls.Add((Control)(object)Radio_CHANG_MODE_P);
		((Control)TabPage6).Controls.Add((Control)(object)Radio_CHANG_CLIENT);
		((Control)TabPage6).Controls.Add((Control)(object)Radio_SUPPRIMER);
		((Control)TabPage6).Controls.Add((Control)(object)Label1232243);
		((Control)TabPage6).Controls.Add((Control)(object)Button164343);
		((Control)TabPage6).Controls.Add((Control)(object)Label7);
		((Control)TabPage6).Controls.Add((Control)(object)Text_ID_TICKET);
		((Control)TabPage6).Controls.Add((Control)(object)Button13232);
		componentResourceManager.ApplyResources(TabPage6, "TabPage6");
		((Control)TabPage6).Name = "TabPage6";
		TabPage6.UseVisualStyleBackColor = true;
		((Control)Label_ID_TICKET).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_ID_TICKET, "Label_ID_TICKET");
		((Control)Label_ID_TICKET).ForeColor = Color.Black;
		((Control)Label_ID_TICKET).Name = "Label_ID_TICKET";
		((Control)Panel21233).Controls.Add((Control)(object)TextBox1);
		((Control)Panel21233).Controls.Add((Control)(object)Label_MODE_P);
		((Control)Panel21233).Controls.Add((Control)(object)Button43233);
		((Control)Panel21233).Controls.Add((Control)(object)Text_MODE_P_FIND);
		componentResourceManager.ApplyResources(Panel21233, "Panel21233");
		((Control)Panel21233).Name = "Panel21233";
		((TextBoxBase)TextBox1).BackColor = SystemColors.Control;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(TextBox1, "TextBox1");
		((Control)TextBox1).Name = "TextBox1";
		((TextBoxBase)TextBox1).ReadOnly = true;
		((Control)Label_MODE_P).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_MODE_P, "Label_MODE_P");
		((Control)Label_MODE_P).ForeColor = Color.Black;
		((Control)Label_MODE_P).Name = "Label_MODE_P";
		((Control)Button43233).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button43233, "Button43233");
		((Control)Button43233).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button43233).Name = "Button43233";
		((ButtonBase)Button43233).UseCompatibleTextRendering = true;
		((ButtonBase)Button43233).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_MODE_P_FIND).BackColor = SystemColors.Control;
		((TextBoxBase)Text_MODE_P_FIND).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_MODE_P_FIND, "Text_MODE_P_FIND");
		((Control)Text_MODE_P_FIND).Name = "Text_MODE_P_FIND";
		((Control)Panel232323).Controls.Add((Control)(object)TextBox2);
		((Control)Panel232323).Controls.Add((Control)(object)Label_CLIENT);
		((Control)Panel232323).Controls.Add((Control)(object)Label_ID_CLIENT);
		((Control)Panel232323).Controls.Add((Control)(object)Button43333);
		((Control)Panel232323).Controls.Add((Control)(object)Text_ID_CLIENT_FIND);
		componentResourceManager.ApplyResources(Panel232323, "Panel232323");
		((Control)Panel232323).Name = "Panel232323";
		((TextBoxBase)TextBox2).BackColor = SystemColors.Control;
		((TextBoxBase)TextBox2).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(TextBox2, "TextBox2");
		((Control)TextBox2).Name = "TextBox2";
		((TextBoxBase)TextBox2).ReadOnly = true;
		((Control)Label_CLIENT).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_CLIENT, "Label_CLIENT");
		((Control)Label_CLIENT).ForeColor = Color.Black;
		((Control)Label_CLIENT).Name = "Label_CLIENT";
		((Control)Label_ID_CLIENT).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_ID_CLIENT, "Label_ID_CLIENT");
		((Control)Label_ID_CLIENT).ForeColor = Color.Black;
		((Control)Label_ID_CLIENT).Name = "Label_ID_CLIENT";
		((Control)Button43333).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button43333, "Button43333");
		((Control)Button43333).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button43333).Name = "Button43333";
		((ButtonBase)Button43333).UseCompatibleTextRendering = true;
		((ButtonBase)Button43333).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_ID_CLIENT_FIND).BackColor = SystemColors.Control;
		((TextBoxBase)Text_ID_CLIENT_FIND).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_ID_CLIENT_FIND, "Text_ID_CLIENT_FIND");
		((Control)Text_ID_CLIENT_FIND).Name = "Text_ID_CLIENT_FIND";
		componentResourceManager.ApplyResources(Radio_CHANG_MODE_P, "Radio_CHANG_MODE_P");
		((Control)Radio_CHANG_MODE_P).Name = "Radio_CHANG_MODE_P";
		Radio_CHANG_MODE_P.TabStop = true;
		((ButtonBase)Radio_CHANG_MODE_P).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_CHANG_CLIENT, "Radio_CHANG_CLIENT");
		((Control)Radio_CHANG_CLIENT).Name = "Radio_CHANG_CLIENT";
		Radio_CHANG_CLIENT.TabStop = true;
		((ButtonBase)Radio_CHANG_CLIENT).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_SUPPRIMER, "Radio_SUPPRIMER");
		((Control)Radio_SUPPRIMER).Name = "Radio_SUPPRIMER";
		Radio_SUPPRIMER.TabStop = true;
		((ButtonBase)Radio_SUPPRIMER).UseVisualStyleBackColor = true;
		((Control)Label1232243).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label1232243, "Label1232243");
		((Control)Label1232243).ForeColor = Color.Black;
		((Control)Label1232243).Name = "Label1232243";
		((Control)Button164343).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button164343, "Button164343");
		((Control)Button164343).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button164343).Name = "Button164343";
		((ButtonBase)Button164343).UseVisualStyleBackColor = true;
		((Control)Label7).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.Black;
		((Control)Label7).Name = "Label7";
		((TextBoxBase)Text_ID_TICKET).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_ID_TICKET, "Text_ID_TICKET");
		((Control)Text_ID_TICKET).Name = "Text_ID_TICKET";
		((ButtonBase)Button13232).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button13232).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button13232, "Button13232");
		((Control)Button13232).ForeColor = Color.White;
		((Control)Button13232).Name = "Button13232";
		((ButtonBase)Button13232).UseVisualStyleBackColor = false;
		((Control)TabPage7).Controls.Add((Control)(object)Radio_VALIDER);
		((Control)TabPage7).Controls.Add((Control)(object)Radio_ENREGISTRER);
		((Control)TabPage7).Controls.Add((Control)(object)Label_ID_DOC);
		((Control)TabPage7).Controls.Add((Control)(object)Label632323);
		((Control)TabPage7).Controls.Add((Control)(object)Button44421);
		((Control)TabPage7).Controls.Add((Control)(object)Label4);
		((Control)TabPage7).Controls.Add((Control)(object)Combo_TYPE_DOC);
		((Control)TabPage7).Controls.Add((Control)(object)Button26323);
		((Control)TabPage7).Controls.Add((Control)(object)Text_ID_DOC);
		componentResourceManager.ApplyResources(TabPage7, "TabPage7");
		((Control)TabPage7).Name = "TabPage7";
		TabPage7.UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_VALIDER, "Radio_VALIDER");
		((Control)Radio_VALIDER).Name = "Radio_VALIDER";
		Radio_VALIDER.TabStop = true;
		((ButtonBase)Radio_VALIDER).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_ENREGISTRER, "Radio_ENREGISTRER");
		((Control)Radio_ENREGISTRER).Name = "Radio_ENREGISTRER";
		Radio_ENREGISTRER.TabStop = true;
		((ButtonBase)Radio_ENREGISTRER).UseVisualStyleBackColor = true;
		((Control)Label_ID_DOC).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_ID_DOC, "Label_ID_DOC");
		((Control)Label_ID_DOC).ForeColor = Color.Black;
		((Control)Label_ID_DOC).Name = "Label_ID_DOC";
		((Control)Label632323).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label632323, "Label632323");
		((Control)Label632323).ForeColor = Color.Black;
		((Control)Label632323).Name = "Label632323";
		((Control)Button44421).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button44421, "Button44421");
		((Control)Button44421).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button44421).Name = "Button44421";
		((ButtonBase)Button44421).UseVisualStyleBackColor = true;
		((Control)Label4).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.Black;
		((Control)Label4).Name = "Label4";
		Combo_TYPE_DOC.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_TYPE_DOC, "Combo_TYPE_DOC");
		((ListControl)Combo_TYPE_DOC).FormattingEnabled = true;
		Combo_TYPE_DOC.Items.AddRange(new object[7]
		{
			componentResourceManager.GetString("Combo_TYPE_DOC.Items"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items1"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items2"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items3"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items4"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items5"),
			componentResourceManager.GetString("Combo_TYPE_DOC.Items6")
		});
		((Control)Combo_TYPE_DOC).Name = "Combo_TYPE_DOC";
		((ButtonBase)Button26323).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button26323).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button26323, "Button26323");
		((Control)Button26323).ForeColor = Color.White;
		((Control)Button26323).Name = "Button26323";
		((ButtonBase)Button26323).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_ID_DOC).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_ID_DOC, "Text_ID_DOC");
		((Control)Text_ID_DOC).Name = "Text_ID_DOC";
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		((Control)this).Controls.Add((Control)(object)TabControl1);
		((Control)this).Controls.Add((Control)(object)Panel3);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Text_SQL);
		((Control)this).Controls.Add((Control)(object)CheckedListBox1);
		((Control)this).Controls.Add((Control)(object)Check_COMPACTER);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)CheckBox7);
		((Control)this).Controls.Add((Control)(object)Button9);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_8_BASE_DONNEE";
		((Form)this).ShowIcon = false;
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)DataGridView_ID).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage6).PerformLayout();
		((Control)Panel21233).ResumeLayout(false);
		((Control)Panel21233).PerformLayout();
		((Control)Panel232323).ResumeLayout(false);
		((Control)Panel232323).PerformLayout();
		((Control)TabPage7).ResumeLayout(false);
		((Control)TabPage7).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CheckBox7_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (CheckBox7.Checked)
			{
				int num = ((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						CheckedListBox1.SetItemChecked(num2, true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (CheckBox7.Checked)
				{
					return;
				}
				int num5 = ((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						CheckedListBox1.SetItemChecked(num6, false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		if ((int)MessageBox.Show("Voulez-vous vraiment Exécuter Ces Actions ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
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
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception e2 = ex5;
						StackTrace stackTrace3 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
						int fileLineNumber3 = frame3.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				string right = "EFFACER BASE DE DONNEES | ";
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				Module1.cn_SQL.Open();
				MySqlCommand val = new MySqlCommand();
				val.CommandType = CommandType.Text;
				val.CommandText = "BACKUP DATABASE      " + Module1._NAME_DB + "      TO DISK='" + Module1._CHEMIN_FOLDER + "\\bd\\backup\\" + DateTime.Now.ToString("yyMMddHHmmssfff_SUPP") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text + "_configue.sni' ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				Module1.cn_SQL.Close();
				try
				{
					foreach (object checkedItem in CheckedListBox1.CheckedItems)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
						MySqlCommand val2 = new MySqlCommand();
						val2.CommandText = "Delete   from TABLE_" + objectValue.ToString() + " ";
						val2.Connection = Module1.cn_SQL;
						val2.CommandType = CommandType.Text;
						if (Module1.cn_SQL.State != ConnectionState.Open)
						{
							Module1.cn_SQL.Open();
						}
						val2.ExecuteNonQuery();
						Module1.cn_SQL.Close();
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
					ProjectData.ClearProjectError();
				}
				Module1._QUITTER_PATIENTER = true;
				MessageBox.Show("Exécutée avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				StackTrace stackTrace2 = new StackTrace(ex4, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex4.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Text_SQL_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_SQL_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = Text_SQL.Text;
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				Module1.cn_SQL.Close();
				Text_SQL.Text = "";
			}
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		val = new MySqlDataAdapter("select * from TABLE_NUM  ", Module1.cn_SQL);
		dataTable = new DataTable();
		dataTable.Clear();
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView_ID.DataSource = dataTable;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				int num = ((BaseCollection)DataGridView_ID.Columns).Count - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						DataGridView_ID.Rows[0].Cells[num2].Value = 1;
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
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				int num = ((BaseCollection)DataGridView_ID.Columns).Count - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (!Versioned.IsNumeric(DataGridView_ID.Rows[0].Cells[num2].Value.ToString()))
					{
						Interaction.MsgBox("ERREUR " + DataGridView_ID.Columns[num2].Name.ToString());
						return;
					}
					num2++;
				}
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					int num5 = ((BaseCollection)DataGridView_ID.Columns).Count - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("UPDATE     TABLE_NUM    SET " + DataGridView_ID.Columns[num6].Name.ToString(), " = "), DataGridView_ID.Rows[0].Cells[num6].Value), "    WHERE    ID = 0                           "));
						val.Connection = Module1.cn_SQL;
						val.ExecuteNonQuery();
						num6++;
					}
					val2.Commit();
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
					val2.Rollback();
					Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				StackTrace stackTrace2 = new StackTrace(ex4, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex4.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button164343_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		MySqlCommand val = new MySqlCommand();
		val.CommandText = "select   sum(TOTAL_NET) as n ,  min(ticket) as m ,  min(Dates) as d ,  min(Client) as c       from      TABLE_VENTES_JOURNAL     WHERE     ID_TICKET = '" + Strings.Trim(Text_ID_TICKET.Text) + "'    ";
		val.Connection = Module1.cn_SQL;
		val.CommandType = CommandType.Text;
		decimal num = 0m;
		string text = "";
		string text2 = "";
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlDataReader val2 = val.ExecuteReader();
			if (val2.Read())
			{
				Label_ID_TICKET.Text = Strings.Trim(Text_ID_TICKET.Text);
				num = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val2["n"])).ToString());
				text = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["m"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["m"])).ToString());
				DateTime dateTime = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val2["d"])).ToString("yyyy-MM-dd"));
				text2 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["c"])).ToString());
				Label1232243.Text = "ID Ticket : " + Strings.Trim(Text_ID_TICKET.Text) + "\r\nN Ticket : " + text + "\r\nDate : " + Conversions.ToString(dateTime) + "\r\nClient : " + text2 + "\r\nTotal de ce Ticket : " + Strings.FormatNumber(num);
			}
			else
			{
				Label_ID_TICKET.Text = "";
				num = 0m;
				text = "";
				DateTime dateTime = default;
				text2 = "";
				Label1232243.Text = "";
			}
			val2.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label_ID_TICKET.Text = "";
			num = 0m;
			text = "";
			DateTime dateTime = default;
			text2 = "";
			Label1232243.Text = "";
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Module1.cn_SQL.Close();
		}
	}

	private void Button43333_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		MySqlCommand val = new MySqlCommand();
		val.CommandText = "select   ID_CLIENT,CLIENT       from      TABLE_CLIENTS     WHERE     ID_CLIENT = '" + Strings.Trim(Text_ID_CLIENT_FIND.Text) + "'    ";
		val.Connection = Module1.cn_SQL;
		val.CommandType = CommandType.Text;
		string text = "";
		string text2 = "";
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlDataReader val2 = val.ExecuteReader();
			if (val2.Read())
			{
				text = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["ID_CLIENT"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["ID_CLIENT"])).ToString());
				text2 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["CLIENT"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["CLIENT"])).ToString());
			}
			else
			{
				text = "";
				text2 = "";
			}
			val2.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Module1.cn_SQL.Close();
		}
		Label_ID_CLIENT.Text = text;
		Label_CLIENT.Text = text2;
	}

	private void Radio_CHANG_CLIENT_CheckedChanged(object sender, EventArgs e)
	{
		if (Radio_CHANG_CLIENT.Checked)
		{
			((Control)Panel232323).Visible = true;
		}
		else
		{
			((Control)Panel232323).Visible = false;
		}
	}

	private void Radio_CHANG_MODE_P_CheckedChanged(object sender, EventArgs e)
	{
		if (Radio_CHANG_MODE_P.Checked)
		{
			((Control)Panel21233).Visible = true;
		}
		else
		{
			((Control)Panel21233).Visible = false;
		}
	}

	private void Button43233_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		MySqlCommand val = new MySqlCommand();
		val.CommandText = "select  MODE_P       from      TABLE_MODE_P     WHERE     MODE_P like '%" + Strings.Trim(Text_MODE_P_FIND.Text) + "%'    ";
		val.Connection = Module1.cn_SQL;
		val.CommandType = CommandType.Text;
		string text = "";
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlDataReader val2 = val.ExecuteReader();
			if (val2.Read())
			{
				text = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["MODE_P"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["MODE_P"])).ToString());
			}
			else
			{
				text = "";
			}
			val2.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Module1.cn_SQL.Close();
		}
		Label_MODE_P.Text = text;
	}

	private void Button44421_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Expected Obj, but got Unknown
		//IL_1353: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Expected Obj, but got Unknown
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "COMMANDES", TextCompare: false) == 0)
		{
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "select   sum(TOTAL_TTC_DOC) as n ,  min(FOURNISSEUR) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_COMMANDES_ENTETE     WHERE     ID_BC = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			decimal num = 0m;
			string text = "";
			DateTime dateTime = default;
			string text2 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val2 = val.ExecuteReader();
				if (val2.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val2["n"])).ToString());
					text = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["f"])).ToString());
					dateTime = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val2["d"])).ToString("yyyy-MM-dd"));
					text2 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val2["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val2["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nFournisseur : " + text + "\r\nDate : " + Conversions.ToString(dateTime) + "\r\nEtat : " + text2 + "\r\nTotal : " + Strings.FormatNumber(num);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num = 0m;
					text = "";
					dateTime = default;
					text2 = "";
					Label632323.Text = "";
				}
				val2.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Label_ID_DOC.Text = "";
				num = 0m;
				text = "";
				dateTime = default;
				text2 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "RECEPTIONS", TextCompare: false) == 0)
		{
			MySqlCommand val3 = new MySqlCommand();
			val3.CommandText = "select   sum(TOTAL_NET_ACHATS) as n ,  min(FOURNISSEUR) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_RECEPTIONS_ENTETE     WHERE     ID_BR = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val3.Connection = Module1.cn_SQL;
			val3.CommandType = CommandType.Text;
			decimal num2 = 0m;
			string text3 = "";
			DateTime dateTime2 = default;
			string text4 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val4 = val3.ExecuteReader();
				if (val4.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num2 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val4["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val4["n"])).ToString());
					text3 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val4["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val4["f"])).ToString());
					dateTime2 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val4["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val4["d"])).ToString("yyyy-MM-dd"));
					text4 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val4["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val4["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nFournisseur : " + text3 + "\r\nDate : " + Conversions.ToString(dateTime2) + "\r\nEtat : " + text4 + "\r\nTotal : " + Strings.FormatNumber(num2);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num2 = 0m;
					text3 = "";
					dateTime2 = default;
					text4 = "";
					Label632323.Text = "";
				}
				val4.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Label_ID_DOC.Text = "";
				num2 = 0m;
				text3 = "";
				dateTime2 = default;
				text4 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "SORTIES", TextCompare: false) == 0)
		{
			MySqlCommand val5 = new MySqlCommand();
			val5.CommandText = "select   sum(TOTAL_NET_ACHATS) as n ,  min(FOURNISSEUR) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_SORTIES_ENTETE     WHERE     ID_BS = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val5.Connection = Module1.cn_SQL;
			val5.CommandType = CommandType.Text;
			decimal num3 = 0m;
			string text5 = "";
			DateTime dateTime3 = default;
			string text6 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val6 = val5.ExecuteReader();
				if (val6.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num3 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val6["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val6["n"])).ToString());
					text5 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val6["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val6["f"])).ToString());
					dateTime3 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val6["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val6["d"])).ToString("yyyy-MM-dd"));
					text6 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val6["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val6["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nFournisseur : " + text5 + "\r\nDate : " + Conversions.ToString(dateTime3) + "\r\nEtat : " + text6 + "\r\nTotal : " + Strings.FormatNumber(num3);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num3 = 0m;
					text5 = "";
					dateTime3 = default;
					text6 = "";
					Label632323.Text = "";
				}
				val6.Close();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Label_ID_DOC.Text = "";
				num3 = 0m;
				text5 = "";
				dateTime3 = default;
				text6 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex6.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "INVENTAIRES", TextCompare: false) == 0)
		{
			MySqlCommand val7 = new MySqlCommand();
			val7.CommandText = "select   sum(TOTAL_VALEUR) as n ,  min(UTILISATEUR) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_INVENTAIRES_ENTETE     WHERE     ID_INV = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val7.Connection = Module1.cn_SQL;
			val7.CommandType = CommandType.Text;
			decimal num4 = 0m;
			string text7 = "";
			DateTime dateTime4 = default;
			string text8 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val8 = val7.ExecuteReader();
				if (val8.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num4 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val8["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val8["n"])).ToString());
					text7 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val8["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val8["f"])).ToString());
					dateTime4 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val8["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val8["d"])).ToString("yyyy-MM-dd"));
					text8 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val8["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val8["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nFournisseur : " + text7 + "\r\nDate : " + Conversions.ToString(dateTime4) + "\r\nEtat : " + text8 + "\r\nTotal : " + Strings.FormatNumber(num4);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num4 = 0m;
					text7 = "";
					dateTime4 = default;
					text8 = "";
					Label632323.Text = "";
				}
				val8.Close();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				Label_ID_DOC.Text = "";
				num4 = 0m;
				text7 = "";
				dateTime4 = default;
				text8 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex8.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "DEVIS", TextCompare: false) == 0)
		{
			MySqlCommand val9 = new MySqlCommand();
			val9.CommandText = "select   sum(TOTAL_TTC_DOC) as n ,  min(CLIENT) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_DEVIS_ENTETE     WHERE     ID_DEVIS = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val9.Connection = Module1.cn_SQL;
			val9.CommandType = CommandType.Text;
			decimal num5 = 0m;
			string text9 = "";
			DateTime dateTime5 = default;
			string text10 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val10 = val9.ExecuteReader();
				if (val10.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num5 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val10["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val10["n"])).ToString());
					text9 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val10["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val10["f"])).ToString());
					dateTime5 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val10["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val10["d"])).ToString("yyyy-MM-dd"));
					text10 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val10["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val10["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nClient : " + text9 + "\r\nDate : " + Conversions.ToString(dateTime5) + "\r\nEtat : " + text10 + "\r\nTOTAL TTC DOC : " + Strings.FormatNumber(num5);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num5 = 0m;
					text9 = "";
					dateTime5 = default;
					text10 = "";
					Label632323.Text = "";
				}
				val10.Close();
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				Label_ID_DOC.Text = "";
				num5 = 0m;
				text9 = "";
				dateTime5 = default;
				text10 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex10.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "BL", TextCompare: false) == 0)
		{
			MySqlCommand val11 = new MySqlCommand();
			val11.CommandText = "select   sum(TOTAL_TTC_DOC) as n ,  min(CLIENT) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_BL_ENTETE     WHERE     ID_BL = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
			val11.Connection = Module1.cn_SQL;
			val11.CommandType = CommandType.Text;
			decimal num6 = 0m;
			string text11 = "";
			DateTime dateTime6 = default;
			string text12 = "";
			try
			{
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlDataReader val12 = val11.ExecuteReader();
				if (val12.Read())
				{
					Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
					num6 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val12["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val12["n"])).ToString());
					text11 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val12["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val12["f"])).ToString());
					dateTime6 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val12["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val12["d"])).ToString("yyyy-MM-dd"));
					text12 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val12["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val12["c"])).ToString());
					Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nClient : " + text11 + "\r\nDate : " + Conversions.ToString(dateTime6) + "\r\nEtat : " + text12 + "\r\nTOTAL TTC DOC : " + Strings.FormatNumber(num6);
				}
				else
				{
					Label_ID_DOC.Text = "";
					num6 = 0m;
					text11 = "";
					dateTime6 = default;
					text12 = "";
					Label632323.Text = "";
				}
				val12.Close();
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception ex12 = ex11;
				Label_ID_DOC.Text = "";
				num6 = 0m;
				text11 = "";
				dateTime6 = default;
				text12 = "";
				Label632323.Text = "";
				Interaction.MsgBox(ex12.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Module1.cn_SQL.Close();
			}
		}
		if (Operators.CompareString(Combo_TYPE_DOC.Text, "FACTURE", TextCompare: false) != 0)
		{
			return;
		}
		MySqlCommand val13 = new MySqlCommand();
		val13.CommandText = "select   sum(TOTAL_TTC_DOC) as n ,  min(CLIENT) as f ,  min(Dates) as d ,  min(ETAT) as c       from      TABLE_FACTURE_ENTETE     WHERE     ID_FACTURE = '" + Strings.Trim(Text_ID_DOC.Text) + "'    ";
		val13.Connection = Module1.cn_SQL;
		val13.CommandType = CommandType.Text;
		decimal num7 = 0m;
		string text13 = "";
		DateTime dateTime7 = default;
		string text14 = "";
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlDataReader val14 = val13.ExecuteReader();
			if (val14.Read())
			{
				Label_ID_DOC.Text = Strings.Trim(Text_ID_DOC.Text);
				num7 = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val14["n"])) ? ((object)0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(val14["n"])).ToString());
				text13 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val14["f"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val14["f"])).ToString());
				dateTime7 = Conversions.ToDate(Information.IsDBNull(RuntimeHelpers.GetObjectValue(val14["d"])) ? "" : Convert.ToDateTime(RuntimeHelpers.GetObjectValue(val14["d"])).ToString("yyyy-MM-dd"));
				text14 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(val14["c"])) ? "" : Convert.ToString(RuntimeHelpers.GetObjectValue(val14["c"])).ToString());
				Label632323.Text = "ID Doc : " + Strings.Trim(Text_ID_DOC.Text) + "\r\nClient : " + text13 + "\r\nDate : " + Conversions.ToString(dateTime7) + "\r\nEtat : " + text14 + "\r\nTOTAL TTC DOC : " + Strings.FormatNumber(num7);
			}
			else
			{
				Label_ID_DOC.Text = "";
				num7 = 0m;
				text13 = "";
				dateTime7 = default;
				text14 = "";
				Label632323.Text = "";
			}
			val14.Close();
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			Label_ID_DOC.Text = "";
			num7 = 0m;
			text13 = "";
			dateTime7 = default;
			text14 = "";
			Label632323.Text = "";
			Interaction.MsgBox(ex14.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Module1.cn_SQL.Close();
		}
	}

	private void Button13232_Click(object sender, EventArgs e)
	{
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Label_ID_TICKET.Text, "", TextCompare: false) == 0 || (int)MessageBox.Show("Attention, Tous les changements seront effectués sur votre responsabilité.\r\nVoulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1 || (int)MessageBox.Show("Voulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
			{
				return;
			}
			if (Radio_SUPPRIMER.Checked)
			{
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "DELETE    from TABLE_VENTES_ENTETE            WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				val.CommandText = "DELETE    from TABLE_VENTES_JOURNAL            WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				val.CommandText = "DELETE    from TABLE_VENTES_REGLEMENTS          WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				string right = "Radio_SUPPRIMER | " + Label_ID_TICKET.Text;
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				Module1.cn_SQL.Close();
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
			else if (Radio_CHANG_CLIENT.Checked)
			{
				MySqlCommand val2 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val2.CommandText = "update      TABLE_VENTES_ENTETE     set id_client = '" + Strings.Trim(Label_ID_CLIENT.Text) + "'  , client = '" + Strings.Trim(Label_CLIENT.Text) + "'        WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val2.Connection = Module1.cn_SQL;
				val2.ExecuteNonQuery();
				val2.CommandText = "update      TABLE_VENTES_JOURNAL    set id_client = '" + Strings.Trim(Label_ID_CLIENT.Text) + "'  , client = '" + Strings.Trim(Label_CLIENT.Text) + "'        WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val2.Connection = Module1.cn_SQL;
				val2.ExecuteNonQuery();
				val2.CommandText = "update      TABLE_VENTES_REGLEMENTS  set id_client = '" + Strings.Trim(Label_ID_CLIENT.Text) + "'  , client = '" + Strings.Trim(Label_CLIENT.Text) + "'        WHERE     ID_TICKET = '" + Strings.Trim(Label_ID_TICKET.Text) + "'              ";
				val2.Connection = Module1.cn_SQL;
				val2.ExecuteNonQuery();
				string right2 = "Radio_CHANG_CLIENT | " + Label_ID_TICKET.Text;
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), "\r\n")), Encoding.UTF8);
				Module1.cn_SQL.Close();
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
			else if (Radio_CHANG_MODE_P.Checked)
			{
				MySqlCommand val3 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val3.CommandText = "update      TABLE_VENTES_REGLEMENTS    set MODE_P = '" + Strings.Trim(Label_MODE_P.Text) + "'      WHERE     ID_TICKET = '" + Strings.Trim(Text_ID_TICKET.Text) + "'              ";
				val3.Connection = Module1.cn_SQL;
				val3.ExecuteNonQuery();
				string right3 = "Radio_CHANG_MODE_P | " + Label_ID_TICKET.Text;
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right3), "\r\n")), Encoding.UTF8);
				Module1.cn_SQL.Close();
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
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
				Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val5 = Graphics.FromImage((Image)(object)val4);
				val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val4 = null;
				string right4 = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right4), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button26323_Click(object sender, EventArgs e)
	{
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Operators.CompareString(Combo_TYPE_DOC.Text, null, TextCompare: false) == 0) | (Operators.CompareString(Label_ID_DOC.Text, "", TextCompare: false) == 0))
			{
				return;
			}
			string text = "";
			switch (Combo_TYPE_DOC.Text)
			{
			case "RECEPTIONS":
				text = "ID_BR";
				break;
			case "SORTIES":
				text = "ID_BS";
				break;
			case "INVENTAIRES":
				text = "ID_INV";
				break;
			case "DEVIS":
				text = "ID_DEVIS";
				break;
			case "BL":
				text = "ID_BL";
				break;
			case "FACTURE":
				text = "ID_FACTURE";
				break;
			}
			string text2 = "";
			if (Radio_ENREGISTRER.Checked)
			{
				text2 = "ENREGISTRER";
			}
			if (Radio_VALIDER.Checked)
			{
				text2 = "VALIDER";
			}
			if ((int)MessageBox.Show("Attention, Tous les changements seront effectués sur votre responsabilité.\r\nVoulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1 && (int)MessageBox.Show("Voulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "UPDATE     TABLE_" + Combo_TYPE_DOC.Text + "_ENTETE    SET ETAT = '" + text2 + "'            WHERE     " + text + " = '" + Strings.Trim(Label_ID_DOC.Text) + "'              ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				val.CommandText = "UPDATE     TABLE_" + Combo_TYPE_DOC.Text + "_DETAILS    SET ETAT = '" + text2 + "'            WHERE     " + text + " = '" + Strings.Trim(Label_ID_DOC.Text) + "'              ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				string right = "UPDATE DOC ENREGISTRER | " + Combo_TYPE_DOC.Text + " | " + Label_ID_DOC.Text;
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				Module1.cn_SQL.Close();
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			}
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
				string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right2 = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text3 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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
