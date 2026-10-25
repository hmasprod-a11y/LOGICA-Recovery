using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_3_Configuration_Suite : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("Panel15")]
	private Panel _Panel15;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Button18")]
	private Button _Button18;

	[AccessedThroughProperty("TextTicket_CL")]
	private TextBox _TextTicket_CL;

	[AccessedThroughProperty("Button26")]
	private Button _Button26;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("OBJET")]
	private ColumnHeader _OBJET;

	[AccessedThroughProperty("VALEUR")]
	private ColumnHeader _VALEUR;

	[AccessedThroughProperty("CheckBox_me_AFFICHER_CODEBARRE")]
	private CheckBox_IPHONE _CheckBox_me_AFFICHER_CODEBARRE;

	[AccessedThroughProperty("Label75")]
	private Label _Label75;

	[AccessedThroughProperty("CheckBox_me_AFFICHER_MODEV")]
	private CheckBox_IPHONE _CheckBox_me_AFFICHER_MODEV;

	[AccessedThroughProperty("Label74")]
	private Label _Label74;

	[AccessedThroughProperty("CheckBox_me_AFFICHER_N_TICKET")]
	private CheckBox_IPHONE _CheckBox_me_AFFICHER_N_TICKET;

	[AccessedThroughProperty("Label73")]
	private Label _Label73;

	[AccessedThroughProperty("CheckBox_me_AFFICHER_MODEP")]
	private CheckBox_IPHONE _CheckBox_me_AFFICHER_MODEP;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Button98")]
	private Button _Button98;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("DataGridView_pied")]
	private DataGridView _DataGridView_pied;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("txtTransmit")]
	private TextBox _txtTransmit;

	[AccessedThroughProperty("Button21")]
	private Button _Button21;

	[AccessedThroughProperty("Combo_BAUDRATE")]
	private ComboBox _Combo_BAUDRATE;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Combo_PORT")]
	private ComboBox _Combo_PORT;

	[AccessedThroughProperty("Panel13")]
	private Panel _Panel13;

	[AccessedThroughProperty("Combo_PORT_2")]
	private ComboBox _Combo_PORT_2;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Label76")]
	private Label _Label76;

	[AccessedThroughProperty("Text_MAIL_TITRE")]
	private TextBox _Text_MAIL_TITRE;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Text_mail")]
	private TextBox _Text_mail;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

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

	internal virtual Panel Panel15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel15 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label33 = value;
		}
	}

	internal virtual Button Button18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button18_Click;
			if (_Button18 != null)
			{
				((Control)_Button18).Click -= eventHandler;
			}
			_Button18 = value;
			if (_Button18 != null)
			{
				((Control)_Button18).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox TextTicket_CL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextTicket_CL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextTicket_CL = value;
		}
	}

	internal virtual Button Button26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button26_Click;
			if (_Button26 != null)
			{
				((Control)_Button26).Click -= eventHandler;
			}
			_Button26 = value;
			if (_Button26 != null)
			{
				((Control)_Button26).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
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

	internal virtual CheckBox_IPHONE CheckBox_me_AFFICHER_CODEBARRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_AFFICHER_CODEBARRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_AFFICHER_MODEP_CheckedChanged;
			if (_CheckBox_me_AFFICHER_CODEBARRE != null)
			{
				_CheckBox_me_AFFICHER_CODEBARRE.CheckedChanged -= obj;
			}
			_CheckBox_me_AFFICHER_CODEBARRE = value;
			if (_CheckBox_me_AFFICHER_CODEBARRE != null)
			{
				_CheckBox_me_AFFICHER_CODEBARRE.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label75
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label75 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_AFFICHER_MODEV
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_AFFICHER_MODEV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_AFFICHER_MODEP_CheckedChanged;
			if (_CheckBox_me_AFFICHER_MODEV != null)
			{
				_CheckBox_me_AFFICHER_MODEV.CheckedChanged -= obj;
			}
			_CheckBox_me_AFFICHER_MODEV = value;
			if (_CheckBox_me_AFFICHER_MODEV != null)
			{
				_CheckBox_me_AFFICHER_MODEV.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label74
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label74 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_AFFICHER_N_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_AFFICHER_N_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_AFFICHER_MODEP_CheckedChanged;
			if (_CheckBox_me_AFFICHER_N_TICKET != null)
			{
				_CheckBox_me_AFFICHER_N_TICKET.CheckedChanged -= obj;
			}
			_CheckBox_me_AFFICHER_N_TICKET = value;
			if (_CheckBox_me_AFFICHER_N_TICKET != null)
			{
				_CheckBox_me_AFFICHER_N_TICKET.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label73
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label73 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_AFFICHER_MODEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_AFFICHER_MODEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_AFFICHER_MODEP_CheckedChanged;
			EventHandler eventHandler = CheckBox_me_AFFICHER_MODEP_Load;
			if (_CheckBox_me_AFFICHER_MODEP != null)
			{
				_CheckBox_me_AFFICHER_MODEP.CheckedChanged -= obj;
				((UserControl)_CheckBox_me_AFFICHER_MODEP).Load -= eventHandler;
			}
			_CheckBox_me_AFFICHER_MODEP = value;
			if (_CheckBox_me_AFFICHER_MODEP != null)
			{
				_CheckBox_me_AFFICHER_MODEP.CheckedChanged += obj;
				((UserControl)_CheckBox_me_AFFICHER_MODEP).Load += eventHandler;
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

	internal virtual Button Button98
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button98_Click;
			if (_Button98 != null)
			{
				((Control)_Button98).Click -= eventHandler;
			}
			_Button98 = value;
			if (_Button98 != null)
			{
				((Control)_Button98).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual DataGridView DataGridView_pied
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_pied;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_pied_CellContentClick;
			EventHandler eventHandler = DataGridView_pied_Validated;
			if (_DataGridView_pied != null)
			{
				_DataGridView_pied.CellContentClick -= val;
				((Control)_DataGridView_pied).Validated -= eventHandler;
			}
			_DataGridView_pied = value;
			if (_DataGridView_pied != null)
			{
				_DataGridView_pied.CellContentClick += val;
				((Control)_DataGridView_pied).Validated += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn Column1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column1 = value;
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

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
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

	internal virtual TextBox txtTransmit
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTransmit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTransmit = value;
		}
	}

	internal virtual Button Button21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button21_Click;
			if (_Button21 != null)
			{
				((Control)_Button21).Click -= eventHandler;
			}
			_Button21 = value;
			if (_Button21 != null)
			{
				((Control)_Button21).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_BAUDRATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_BAUDRATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_WIFI_TextChanged;
			if (_Combo_BAUDRATE != null)
			{
				((Control)_Combo_BAUDRATE).TextChanged -= eventHandler;
			}
			_Combo_BAUDRATE = value;
			if (_Combo_BAUDRATE != null)
			{
				((Control)_Combo_BAUDRATE).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label32 = value;
		}
	}

	internal virtual ComboBox Combo_PORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_WIFI_TextChanged;
			if (_Combo_PORT != null)
			{
				((Control)_Combo_PORT).TextChanged -= eventHandler;
			}
			_Combo_PORT = value;
			if (_Combo_PORT != null)
			{
				((Control)_Combo_PORT).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel13 = value;
		}
	}

	internal virtual ComboBox Combo_PORT_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PORT_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_WIFI_TextChanged;
			if (_Combo_PORT_2 != null)
			{
				((Control)_Combo_PORT_2).TextChanged -= eventHandler;
			}
			_Combo_PORT_2 = value;
			if (_Combo_PORT_2 != null)
			{
				((Control)_Combo_PORT_2).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
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

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual Label Label76
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label76 = value;
		}
	}

	internal virtual TextBox Text_MAIL_TITRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MAIL_TITRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_WIFI_TextChanged;
			if (_Text_MAIL_TITRE != null)
			{
				((Control)_Text_MAIL_TITRE).TextChanged -= eventHandler;
			}
			_Text_MAIL_TITRE = value;
			if (_Text_MAIL_TITRE != null)
			{
				((Control)_Text_MAIL_TITRE).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Button Button15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button15_Click;
			if (_Button15 != null)
			{
				((Control)_Button15).Click -= eventHandler;
			}
			_Button15 = value;
			if (_Button15 != null)
			{
				((Control)_Button15).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_mail
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_mail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_WIFI_TextChanged;
			if (_Text_mail != null)
			{
				((Control)_Text_mail).TextChanged -= eventHandler;
			}
			_Text_mail = value;
			if (_Text_mail != null)
			{
				((Control)_Text_mail).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label34 = value;
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

	[DebuggerNonUserCode]
	public FormDialog_3_Configuration_Suite()
	{
		((Form)this).Load += FormDialog_3_Configuration_Suite_Load;
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
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
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
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected Obj, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_3_Configuration_Suite));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Panel15 = new Panel();
		Label6 = new Label();
		Label33 = new Label();
		Button18 = new Button();
		TextTicket_CL = new TextBox();
		Button26 = new Button();
		Panel5 = new Panel();
		ListView1 = new ListView();
		OBJET = new ColumnHeader();
		VALEUR = new ColumnHeader();
		CheckBox_me_AFFICHER_CODEBARRE = new CheckBox_IPHONE();
		Label75 = new Label();
		CheckBox_me_AFFICHER_MODEV = new CheckBox_IPHONE();
		Label74 = new Label();
		CheckBox_me_AFFICHER_N_TICKET = new CheckBox_IPHONE();
		Label73 = new Label();
		CheckBox_me_AFFICHER_MODEP = new CheckBox_IPHONE();
		Label7 = new Label();
		Button98 = new Button();
		Label9 = new Label();
		DataGridView_pied = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Panel2 = new Panel();
		Label24 = new Label();
		Label26 = new Label();
		txtTransmit = new TextBox();
		Button21 = new Button();
		Combo_BAUDRATE = new ComboBox();
		Label32 = new Label();
		Combo_PORT = new ComboBox();
		Panel13 = new Panel();
		Combo_PORT_2 = new ComboBox();
		Label15 = new Label();
		Label28 = new Label();
		Panel4 = new Panel();
		Label76 = new Label();
		Text_MAIL_TITRE = new TextBox();
		Label20 = new Label();
		Button15 = new Button();
		Text_mail = new TextBox();
		Label34 = new Label();
		Button4 = new Button();
		((Control)Panel15).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)DataGridView_pied).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel13).SuspendLayout();
		((Control)Panel4).SuspendLayout();
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
		((Control)Panel15).BackColor = Color.White;
		Panel15.BorderStyle = (BorderStyle)1;
		((Control)Panel15).Controls.Add((Control)(object)Label6);
		((Control)Panel15).Controls.Add((Control)(object)Label33);
		((Control)Panel15).Controls.Add((Control)(object)Button18);
		((Control)Panel15).Controls.Add((Control)(object)TextTicket_CL);
		((Control)Panel15).Controls.Add((Control)(object)Button26);
		componentResourceManager.ApplyResources(Panel15, "Panel15");
		((Control)Panel15).Name = "Panel15";
		((Control)Label6).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
		Label6.UseCompatibleTextRendering = true;
		((Control)Label33).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label33, "Label33");
		((Control)Label33).ForeColor = Color.DimGray;
		((Control)Label33).Name = "Label33";
		((Control)Button18).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button18, "Button18");
		((Control)Button18).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button18).Name = "Button18";
		((ButtonBase)Button18).UseCompatibleTextRendering = true;
		((ButtonBase)Button18).UseVisualStyleBackColor = true;
		((TextBoxBase)TextTicket_CL).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(TextTicket_CL, "TextTicket_CL");
		((Control)TextTicket_CL).Name = "TextTicket_CL";
		((ButtonBase)Button26).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button26).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button26, "Button26");
		((Control)Button26).ForeColor = Color.White;
		((Control)Button26).Name = "Button26";
		((ButtonBase)Button26).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel5, "Panel5");
		((Control)Panel5).BackColor = Color.White;
		Panel5.BorderStyle = (BorderStyle)1;
		((Control)Panel5).Controls.Add((Control)(object)ListView1);
		((Control)Panel5).Controls.Add((Control)(object)CheckBox_me_AFFICHER_CODEBARRE);
		((Control)Panel5).Controls.Add((Control)(object)Label75);
		((Control)Panel5).Controls.Add((Control)(object)CheckBox_me_AFFICHER_MODEV);
		((Control)Panel5).Controls.Add((Control)(object)Label74);
		((Control)Panel5).Controls.Add((Control)(object)CheckBox_me_AFFICHER_N_TICKET);
		((Control)Panel5).Controls.Add((Control)(object)Label73);
		((Control)Panel5).Controls.Add((Control)(object)CheckBox_me_AFFICHER_MODEP);
		((Control)Panel5).Controls.Add((Control)(object)Label7);
		((Control)Panel5).Controls.Add((Control)(object)Button98);
		((Control)Panel5).Controls.Add((Control)(object)Label9);
		((Control)Panel5).Controls.Add((Control)(object)DataGridView_pied);
		((Control)Panel5).Name = "Panel5";
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
		CheckBox_me_AFFICHER_CODEBARRE.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_AFFICHER_CODEBARRE, "CheckBox_me_AFFICHER_CODEBARRE");
		((Control)CheckBox_me_AFFICHER_CODEBARRE).Name = "CheckBox_me_AFFICHER_CODEBARRE";
		((Control)CheckBox_me_AFFICHER_CODEBARRE).Tag = "AFFICHER_CODE_BARRE";
		((Control)Label75).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label75, "Label75");
		((Control)Label75).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label75).Name = "Label75";
		CheckBox_me_AFFICHER_MODEV.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_AFFICHER_MODEV, "CheckBox_me_AFFICHER_MODEV");
		((Control)CheckBox_me_AFFICHER_MODEV).Name = "CheckBox_me_AFFICHER_MODEV";
		((Control)CheckBox_me_AFFICHER_MODEV).Tag = "AFFICHER_MODE_V";
		((Control)Label74).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label74, "Label74");
		((Control)Label74).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label74).Name = "Label74";
		CheckBox_me_AFFICHER_N_TICKET.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_AFFICHER_N_TICKET, "CheckBox_me_AFFICHER_N_TICKET");
		((Control)CheckBox_me_AFFICHER_N_TICKET).Name = "CheckBox_me_AFFICHER_N_TICKET";
		((Control)CheckBox_me_AFFICHER_N_TICKET).Tag = "AFFICHER_N_TICKET";
		((Control)Label73).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label73, "Label73");
		((Control)Label73).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label73).Name = "Label73";
		CheckBox_me_AFFICHER_MODEP.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_AFFICHER_MODEP, "CheckBox_me_AFFICHER_MODEP");
		((Control)CheckBox_me_AFFICHER_MODEP).Name = "CheckBox_me_AFFICHER_MODEP";
		((Control)CheckBox_me_AFFICHER_MODEP).Tag = "AFFICHER_MODE_P";
		((Control)Label7).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label7).Name = "Label7";
		((Control)Button98).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button98, "Button98");
		((Control)Button98).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button98).Name = "Button98";
		((ButtonBase)Button98).UseCompatibleTextRendering = true;
		((ButtonBase)Button98).UseVisualStyleBackColor = true;
		((Control)Label9).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.White;
		((Control)Label9).Name = "Label9";
		Label9.UseCompatibleTextRendering = true;
		DataGridView_pied.AllowUserToResizeColumns = false;
		DataGridView_pied.AllowUserToResizeRows = false;
		DataGridView_pied.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_pied.BackgroundColor = Color.White;
		DataGridView_pied.CellBorderStyle = (DataGridViewCellBorderStyle)9;
		DataGridView_pied.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Tahoma", 8f);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView_pied.ColumnHeadersDefaultCellStyle = val;
		componentResourceManager.ApplyResources(DataGridView_pied, "DataGridView_pied");
		DataGridView_pied.ColumnHeadersVisible = false;
		DataGridView_pied.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)Column1 });
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Inconsolata Condensed", 15f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView_pied.DefaultCellStyle = val2;
		DataGridView_pied.EditMode = (DataGridViewEditMode)0;
		DataGridView_pied.EnableHeadersVisualStyles = false;
		DataGridView_pied.GridColor = SystemColors.ButtonFace;
		((Control)DataGridView_pied).Name = "DataGridView_pied";
		DataGridView_pied.RowHeadersVisible = false;
		DataGridView_pied.SelectionMode = (DataGridViewSelectionMode)1;
		((Control)DataGridView_pied).Tag = "PIED_TICKET";
		componentResourceManager.ApplyResources(Column1, "Column1");
		((DataGridViewColumn)Column1).Name = "Column1";
		((Control)Panel2).BackColor = Color.White;
		Panel2.BorderStyle = (BorderStyle)1;
		((Control)Panel2).Controls.Add((Control)(object)Label24);
		((Control)Panel2).Controls.Add((Control)(object)Label26);
		((Control)Panel2).Controls.Add((Control)(object)txtTransmit);
		((Control)Panel2).Controls.Add((Control)(object)Button21);
		((Control)Panel2).Controls.Add((Control)(object)Combo_BAUDRATE);
		((Control)Panel2).Controls.Add((Control)(object)Label32);
		((Control)Panel2).Controls.Add((Control)(object)Combo_PORT);
		componentResourceManager.ApplyResources(Panel2, "Panel2");
		((Control)Panel2).Name = "Panel2";
		((Control)Label24).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label24, "Label24");
		((Control)Label24).ForeColor = Color.DimGray;
		((Control)Label24).Name = "Label24";
		((Control)Label26).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label26, "Label26");
		((Control)Label26).ForeColor = Color.DimGray;
		((Control)Label26).Name = "Label26";
		componentResourceManager.ApplyResources(txtTransmit, "txtTransmit");
		((Control)txtTransmit).Name = "txtTransmit";
		componentResourceManager.ApplyResources(Button21, "Button21");
		((Control)Button21).Name = "Button21";
		((ButtonBase)Button21).UseCompatibleTextRendering = true;
		((ButtonBase)Button21).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Combo_BAUDRATE, "Combo_BAUDRATE");
		((ListControl)Combo_BAUDRATE).FormattingEnabled = true;
		Combo_BAUDRATE.Items.AddRange(new object[6]
		{
			componentResourceManager.GetString("Combo_BAUDRATE.Items"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items1"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items2"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items3"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items4"),
			componentResourceManager.GetString("Combo_BAUDRATE.Items5")
		});
		((Control)Combo_BAUDRATE).Name = "Combo_BAUDRATE";
		((Control)Combo_BAUDRATE).Tag = "AFFICHEUR_BAUDRATE";
		((Control)Label32).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label32, "Label32");
		((Control)Label32).ForeColor = Color.White;
		((Control)Label32).Name = "Label32";
		Label32.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Combo_PORT, "Combo_PORT");
		((ListControl)Combo_PORT).FormattingEnabled = true;
		Combo_PORT.Items.AddRange(new object[14]
		{
			componentResourceManager.GetString("Combo_PORT.Items"),
			componentResourceManager.GetString("Combo_PORT.Items1"),
			componentResourceManager.GetString("Combo_PORT.Items2"),
			componentResourceManager.GetString("Combo_PORT.Items3"),
			componentResourceManager.GetString("Combo_PORT.Items4"),
			componentResourceManager.GetString("Combo_PORT.Items5"),
			componentResourceManager.GetString("Combo_PORT.Items6"),
			componentResourceManager.GetString("Combo_PORT.Items7"),
			componentResourceManager.GetString("Combo_PORT.Items8"),
			componentResourceManager.GetString("Combo_PORT.Items9"),
			componentResourceManager.GetString("Combo_PORT.Items10"),
			componentResourceManager.GetString("Combo_PORT.Items11"),
			componentResourceManager.GetString("Combo_PORT.Items12"),
			componentResourceManager.GetString("Combo_PORT.Items13")
		});
		((Control)Combo_PORT).Name = "Combo_PORT";
		((Control)Combo_PORT).Tag = "AFFICHEUR_PORT";
		((Control)Panel13).BackColor = Color.White;
		Panel13.BorderStyle = (BorderStyle)1;
		((Control)Panel13).Controls.Add((Control)(object)Combo_PORT_2);
		((Control)Panel13).Controls.Add((Control)(object)Label15);
		((Control)Panel13).Controls.Add((Control)(object)Label28);
		componentResourceManager.ApplyResources(Panel13, "Panel13");
		((Control)Panel13).Name = "Panel13";
		componentResourceManager.ApplyResources(Combo_PORT_2, "Combo_PORT_2");
		((ListControl)Combo_PORT_2).FormattingEnabled = true;
		Combo_PORT_2.Items.AddRange(new object[14]
		{
			componentResourceManager.GetString("Combo_PORT_2.Items"),
			componentResourceManager.GetString("Combo_PORT_2.Items1"),
			componentResourceManager.GetString("Combo_PORT_2.Items2"),
			componentResourceManager.GetString("Combo_PORT_2.Items3"),
			componentResourceManager.GetString("Combo_PORT_2.Items4"),
			componentResourceManager.GetString("Combo_PORT_2.Items5"),
			componentResourceManager.GetString("Combo_PORT_2.Items6"),
			componentResourceManager.GetString("Combo_PORT_2.Items7"),
			componentResourceManager.GetString("Combo_PORT_2.Items8"),
			componentResourceManager.GetString("Combo_PORT_2.Items9"),
			componentResourceManager.GetString("Combo_PORT_2.Items10"),
			componentResourceManager.GetString("Combo_PORT_2.Items11"),
			componentResourceManager.GetString("Combo_PORT_2.Items12"),
			componentResourceManager.GetString("Combo_PORT_2.Items13")
		});
		((Control)Combo_PORT_2).Name = "Combo_PORT_2";
		((Control)Combo_PORT_2).Tag = "BALANCE_PORT";
		((Control)Label15).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label15, "Label15");
		((Control)Label15).ForeColor = Color.DimGray;
		((Control)Label15).Name = "Label15";
		((Control)Label28).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label28, "Label28");
		((Control)Label28).ForeColor = Color.White;
		((Control)Label28).Name = "Label28";
		Label28.UseCompatibleTextRendering = true;
		((Control)Panel4).BackColor = Color.White;
		Panel4.BorderStyle = (BorderStyle)1;
		((Control)Panel4).Controls.Add((Control)(object)Label76);
		((Control)Panel4).Controls.Add((Control)(object)Text_MAIL_TITRE);
		((Control)Panel4).Controls.Add((Control)(object)Label20);
		((Control)Panel4).Controls.Add((Control)(object)Button15);
		((Control)Panel4).Controls.Add((Control)(object)Text_mail);
		((Control)Panel4).Controls.Add((Control)(object)Label34);
		componentResourceManager.ApplyResources(Panel4, "Panel4");
		((Control)Panel4).Name = "Panel4";
		((Control)Label76).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label76, "Label76");
		((Control)Label76).ForeColor = Color.DimGray;
		((Control)Label76).Name = "Label76";
		((TextBoxBase)Text_MAIL_TITRE).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_MAIL_TITRE, "Text_MAIL_TITRE");
		((Control)Text_MAIL_TITRE).Name = "Text_MAIL_TITRE";
		((Control)Text_MAIL_TITRE).Tag = "MAIL_TITRE";
		((Control)Label20).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label20, "Label20");
		((Control)Label20).ForeColor = Color.DimGray;
		((Control)Label20).Name = "Label20";
		componentResourceManager.ApplyResources(Button15, "Button15");
		((Control)Button15).Name = "Button15";
		((ButtonBase)Button15).UseCompatibleTextRendering = true;
		((ButtonBase)Button15).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_mail).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_mail, "Text_mail");
		((Control)Text_mail).Name = "Text_mail";
		((Control)Text_mail).Tag = "MAIL_ADRESSE";
		((Control)Label34).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label34, "Label34");
		((Control)Label34).ForeColor = Color.White;
		((Control)Label34).Name = "Label34";
		Label34.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Button4, "Button4");
		((ButtonBase)Button4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button4).Cursor = Cursors.Hand;
		((Control)Button4).ForeColor = Color.White;
		((Control)Button4).Name = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.WhiteSmoke;
		((Control)this).Controls.Add((Control)(object)Panel15);
		((Control)this).Controls.Add((Control)(object)Panel5);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel13);
		((Control)this).Controls.Add((Control)(object)Panel4);
		((Control)this).Controls.Add((Control)(object)Button4);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_3_Configuration_Suite";
		((Form)this).ShowIcon = false;
		((Control)Panel15).ResumeLayout(false);
		((Control)Panel15).PerformLayout();
		((Control)Panel5).ResumeLayout(false);
		((ISupportInitialize)DataGridView_pied).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel13).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_3_Configuration_Suite_Load(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		MySqlCommand val = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		val.CommandText = "select    *     from     TABLE_PARAMETRES     where     ID   BETWEEN   21  AND  40    ";
		val.Connection = Module1.cn_SQL;
		val.ExecuteNonQuery();
		ListView1.Items.Clear();
		MySqlDataReader val2 = val.ExecuteReader();
		if (val2.HasRows)
		{
			while (val2.Read())
			{
				ListView1.Items.Add(val2["OBJET"].ToString());
				ListView1.Items[checked(ListView1.Items.Count - 1)].SubItems.Add(val2["VALEUR"].ToString());
			}
		}
		val2.Close();
		Module1.cn_SQL.Close();
		CheckBox_me_AFFICHER_MODEP.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("AFFICHER_MODE_P", false, 0).Index].SubItems[1].Text);
		CheckBox_me_AFFICHER_N_TICKET.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("AFFICHER_N_TICKET", false, 0).Index].SubItems[1].Text);
		CheckBox_me_AFFICHER_MODEV.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("AFFICHER_MODE_V", false, 0).Index].SubItems[1].Text);
		DataGridView_pied.Rows.Clear();
		string text = "";
		StringReader stringReader = new StringReader(Strings.Trim(ListView1.Items[ListView1.FindItemWithText("PIED_TICKET", false, 0).Index].SubItems[1].Text));
		while (stringReader.Peek() != -1)
		{
			DataGridView_pied.Rows.Add(new object[1] { stringReader.ReadLine() });
		}
		stringReader.Close();
		CheckBox_me_AFFICHER_CODEBARRE.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("AFFICHER_CODE_BARRE", false, 0).Index].SubItems[1].Text);
		Combo_PORT.Text = ListView1.Items[ListView1.FindItemWithText("AFFICHEUR_PORT", false, 0).Index].SubItems[1].Text;
		Combo_BAUDRATE.Text = ListView1.Items[ListView1.FindItemWithText("AFFICHEUR_BAUDRATE", false, 0).Index].SubItems[1].Text;
		Combo_PORT_2.Text = ListView1.Items[ListView1.FindItemWithText("BALANCE_PORT", false, 0).Index].SubItems[1].Text;
		Text_mail.Text = ListView1.Items[ListView1.FindItemWithText("MAIL_ADRESSE", false, 0).Index].SubItems[1].Text;
		Text_MAIL_TITRE.Text = ListView1.Items[ListView1.FindItemWithText("MAIL_TITRE", false, 0).Index].SubItems[1].Text;
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val3 = new MySqlDataAdapter();
		dataTable.Clear();
		val3 = new MySqlDataAdapter("Select * from TABLE_NUM   ", Module1.cn_SQL);
		((DbDataAdapter)(object)val3).Fill(dataTable);
		TextTicket_CL.Text = Conversions.ToString(dataTable.Rows[0]["CL"]);
	}

	private void CheckBox_me_AFFICHER_MODEP_Load(object sender, EventArgs e)
	{
	}

	private void CheckBox_me_AFFICHER_MODEP_CheckedChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
		}
	}

	private void Text_WIFI_TextChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
		}
	}

	private void DataGridView_pied_Validated(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val == null)
		{
			return;
		}
		string text = "";
		checked
		{
			int num = DataGridView_pied.Rows.Count - 2;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Conversions.ToBoolean(Operators.OrObject(DataGridView_pied.Rows[num2].Cells[0].Value == DBNull.Value, Operators.CompareObjectEqual(DataGridView_pied.Rows[num2].Cells[0].Value, null, TextCompare: false))))
				{
					DataGridView_pied.Rows[num2].Cells[0].Value = " ";
				}
				text = text + DataGridView_pied.Rows[num2].Cells[0].Value.ToString() + "\r\n";
				num2++;
			}
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = text;
		}
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		TextTicket_CL.Text = "000001";
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlCommand val = new MySqlCommand("UPDATE     TABLE_NUM    SET CL =  " + Conversions.ToString(Conversion.Val(TextTicket_CL.Text)) + "    ", Module1.cn_SQL);
			try
			{
				val.ExecuteNonQuery();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Module1.cn_SQL.Close();
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void Button21_Click(object sender, EventArgs e)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		try
		{
			SerialPort val = ((Computer)MyProject.Computer).Ports.OpenSerialPort(Combo_PORT.Text);
			try
			{
				val.StopBits = (StopBits)1;
				val.BaudRate = Conversions.ToInteger(Combo_BAUDRATE.Text);
				val.DataBits = 8;
				val.Parity = (Parity)0;
				val.Handshake = (Handshake)0;
				val.WriteLine("\r\n\r\n\r\nTOTAL: " + txtTransmit.Text.PadRight(11) + "DH   ***BIENVENUE***  ");
			}
			finally
			{
				((IDisposable)val)?.Dispose();
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

	private void Button15_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(Text_mail.Text, "", TextCompare: false) == 0)
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
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("TEST MAIL AUTO - LOGICA");
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("logica.application@gmail.com");
				mailMessage.To.Add(Text_mail.Text);
				mailMessage.Subject = "Rapport LOGICA";
				mailMessage.Body = stringBuilder.ToString();
				mailMessage.IsBodyHtml = true;
				mailMessage.BodyEncoding = Encoding.UTF8;
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential("logica.application@gmail.com", "uvwauedhmlgwqkwc");
				smtpClient.Send(mailMessage);
				Module1._QUITTER_PATIENTER = true;
				Interaction.MsgBox("Order Sent", MsgBoxStyle.Information, "Success");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				Interaction.MsgBox("Something went wrong", MsgBoxStyle.Information, "Failed");
				Interaction.MsgBox(ex2.ToString());
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
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
					val.CommandText = "UPDATE TABLE_PARAMETRES SET VALEUR =       N'" + ListView1.Items[num2].SubItems[1].Text + "'        WHERE OBJET = N'" + ListView1.Items[num2].Text + "'";
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

	private void Button98_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridView_pied.Rows.RemoveAt(DataGridView_pied.CurrentCell.RowIndex);
			((Control)DataGridView_pied).Focus();
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

	private void DataGridView_pied_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
