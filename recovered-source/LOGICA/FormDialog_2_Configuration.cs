using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_2_Configuration : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox_FR_4C")]
	private PictureBox _PictureBox_FR_4C;

	[AccessedThroughProperty("PictureBox_FR_2L")]
	private PictureBox _PictureBox_FR_2L;

	[AccessedThroughProperty("DataGridView_MODELE_TICKET")]
	private DataGridView _DataGridView_MODELE_TICKET;

	[AccessedThroughProperty("x")]
	private DataGridViewTextBoxColumn _x;

	[AccessedThroughProperty("Label_MODELE_TICKET")]
	private Label _Label_MODELE_TICKET;

	[AccessedThroughProperty("PictureBox_FR_3C")]
	private PictureBox _PictureBox_FR_3C;

	[AccessedThroughProperty("PictureBox_AR_4C")]
	private PictureBox _PictureBox_AR_4C;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("CheckBox_me_STARTUP")]
	private CheckBox_IPHONE _CheckBox_me_STARTUP;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Panel12")]
	private Panel _Panel12;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("OBJET")]
	private ColumnHeader _OBJET;

	[AccessedThroughProperty("VALEUR")]
	private ColumnHeader _VALEUR;

	[AccessedThroughProperty("Label79")]
	private Label _Label79;

	[AccessedThroughProperty("Button20324")]
	private Button _Button20324;

	[AccessedThroughProperty("Combo_PRINTER_RAPPORT")]
	private ComboBox _Combo_PRINTER_RAPPORT;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Button4378")]
	private Button _Button4378;

	[AccessedThroughProperty("Button4423")]
	private Button _Button4423;

	[AccessedThroughProperty("Button4143")]
	private Button _Button4143;

	[AccessedThroughProperty("Button4234")]
	private Button _Button4234;

	[AccessedThroughProperty("Button2454")]
	private Button _Button2454;

	[AccessedThroughProperty("Button2034")]
	private Button _Button2034;

	[AccessedThroughProperty("Combo_BRANCHEMENT")]
	private ComboBox _Combo_BRANCHEMENT;

	[AccessedThroughProperty("Button34")]
	private Button _Button34;

	[AccessedThroughProperty("Combo_PRINTER_C4")]
	private ComboBox _Combo_PRINTER_C4;

	[AccessedThroughProperty("Combo_PRINTER_C3")]
	private ComboBox _Combo_PRINTER_C3;

	[AccessedThroughProperty("Combo_PRINTER_SOLDER")]
	private ComboBox _Combo_PRINTER_SOLDER;

	[AccessedThroughProperty("Combo_PRINTER_ADDITION")]
	private ComboBox _Combo_PRINTER_ADDITION;

	[AccessedThroughProperty("Combo_PRINTER_C2")]
	private ComboBox _Combo_PRINTER_C2;

	[AccessedThroughProperty("Combo_PRINTER_C1")]
	private ComboBox _Combo_PRINTER_C1;

	[AccessedThroughProperty("Panel16")]
	private Panel _Panel16;

	[AccessedThroughProperty("CheckBox_me_CLOTURE_CAISSIER_OBLIGER")]
	private CheckBox_IPHONE _CheckBox_me_CLOTURE_CAISSIER_OBLIGER;

	[AccessedThroughProperty("Label84")]
	private Label _Label84;

	[AccessedThroughProperty("CheckBox_me_AJOUT_STOCK")]
	private CheckBox_IPHONE _CheckBox_me_AJOUT_STOCK;

	[AccessedThroughProperty("Label78")]
	private Label _Label78;

	[AccessedThroughProperty("CheckBox_me_ECRAN_PUB")]
	private CheckBox_IPHONE _CheckBox_me_ECRAN_PUB;

	[AccessedThroughProperty("Label77")]
	private Label _Label77;

	[AccessedThroughProperty("CheckBox_me_SOLDER_SANS_TICKET")]
	private CheckBox_IPHONE _CheckBox_me_SOLDER_SANS_TICKET;

	[AccessedThroughProperty("Label72")]
	private Label _Label72;

	[AccessedThroughProperty("CheckBox_me_GESTION_CLOTURE")]
	private CheckBox_IPHONE _CheckBox_me_GESTION_CLOTURE;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("CheckBox_me_MODE_WINDOWS")]
	private CheckBox_IPHONE _CheckBox_me_MODE_WINDOWS;

	[AccessedThroughProperty("CheckBox_me_GESTION_CREDIT")]
	private CheckBox_IPHONE _CheckBox_me_GESTION_CREDIT;

	[AccessedThroughProperty("CheckBox_me_CLIENT")]
	private CheckBox_IPHONE _CheckBox_me_CLIENT;

	[AccessedThroughProperty("CheckBox_me_VENDEUR")]
	private CheckBox_IPHONE _CheckBox_me_VENDEUR;

	[AccessedThroughProperty("CheckBox_me_RFID")]
	private CheckBox_IPHONE _CheckBox_me_RFID;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("CheckBox_me_BLOCAGE_STOCK")]
	private CheckBox_IPHONE _CheckBox_me_BLOCAGE_STOCK;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("CheckBox_me_MODIF_STOCK")]
	private CheckBox_IPHONE _CheckBox_me_MODIF_STOCK;

	[AccessedThroughProperty("CheckBox_me_STOCK")]
	private CheckBox_IPHONE _CheckBox_me_STOCK;

	[AccessedThroughProperty("CheckBox_me_MODEP")]
	private CheckBox_IPHONE _CheckBox_me_MODEP;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("CheckBox_me_GESTION_GROUPE_FAMILLE")]
	private CheckBox_IPHONE _CheckBox_me_GESTION_GROUPE_FAMILLE;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox_AR_3C")]
	private PictureBox _PictureBox_AR_3C;

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

	internal virtual PictureBox PictureBox_FR_4C
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_FR_4C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_FR_4C = value;
		}
	}

	internal virtual PictureBox PictureBox_FR_2L
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_FR_2L;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_FR_2L = value;
		}
	}

	internal virtual DataGridView DataGridView_MODELE_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_MODELE_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_MODELE_TICKET_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView_MODELE_TICKET_CellContentClick;
			if (_DataGridView_MODELE_TICKET != null)
			{
				_DataGridView_MODELE_TICKET.CellClick -= val;
				_DataGridView_MODELE_TICKET.CellContentClick -= val2;
			}
			_DataGridView_MODELE_TICKET = value;
			if (_DataGridView_MODELE_TICKET != null)
			{
				_DataGridView_MODELE_TICKET.CellClick += val;
				_DataGridView_MODELE_TICKET.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn x
	{
		[DebuggerNonUserCode]
		get
		{
			return _x;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_x = value;
		}
	}

	internal virtual Label Label_MODELE_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_MODELE_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_MODELE_TICKET = value;
		}
	}

	internal virtual PictureBox PictureBox_FR_3C
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_FR_3C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_FR_3C = value;
		}
	}

	internal virtual PictureBox PictureBox_AR_4C
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_AR_4C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_AR_4C = value;
		}
	}

	internal virtual Button Button_SAVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SAVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SAVE_Click;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click -= eventHandler;
			}
			_Button_SAVE = value;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel8 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_STARTUP
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_STARTUP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox_me_STARTUP_Load;
			if (_CheckBox_me_STARTUP != null)
			{
				((UserControl)_CheckBox_me_STARTUP).Load -= eventHandler;
			}
			_CheckBox_me_STARTUP = value;
			if (_CheckBox_me_STARTUP != null)
			{
				((UserControl)_CheckBox_me_STARTUP).Load += eventHandler;
			}
		}
	}

	internal virtual Label Label44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label44 = value;
		}
	}

	internal virtual Panel Panel12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel12 = value;
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

	internal virtual Label Label79
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label79 = value;
		}
	}

	internal virtual Button Button20324
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button20324;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button20324_Click;
			if (_Button20324 != null)
			{
				((Control)_Button20324).Click -= eventHandler;
			}
			_Button20324 = value;
			if (_Button20324 != null)
			{
				((Control)_Button20324).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_PRINTER_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_RAPPORT = value;
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

	internal virtual Label Label48
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label48 = value;
		}
	}

	internal virtual Label Label49
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label49 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label47
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label47 = value;
		}
	}

	internal virtual Label Label46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label46 = value;
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

	internal virtual Button Button4378
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4378;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4378_Click;
			if (_Button4378 != null)
			{
				((Control)_Button4378).Click -= eventHandler;
			}
			_Button4378 = value;
			if (_Button4378 != null)
			{
				((Control)_Button4378).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button4423
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4423;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4423_Click;
			if (_Button4423 != null)
			{
				((Control)_Button4423).Click -= eventHandler;
			}
			_Button4423 = value;
			if (_Button4423 != null)
			{
				((Control)_Button4423).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button4143
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4143;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4143_Click;
			if (_Button4143 != null)
			{
				((Control)_Button4143).Click -= eventHandler;
			}
			_Button4143 = value;
			if (_Button4143 != null)
			{
				((Control)_Button4143).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button4234
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4234;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4234_Click;
			if (_Button4234 != null)
			{
				((Control)_Button4234).Click -= eventHandler;
			}
			_Button4234 = value;
			if (_Button4234 != null)
			{
				((Control)_Button4234).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button2454
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2454;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2454_Click;
			if (_Button2454 != null)
			{
				((Control)_Button2454).Click -= eventHandler;
			}
			_Button2454 = value;
			if (_Button2454 != null)
			{
				((Control)_Button2454).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button2034
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2034;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2034_Click;
			if (_Button2034 != null)
			{
				((Control)_Button2034).Click -= eventHandler;
			}
			_Button2034 = value;
			if (_Button2034 != null)
			{
				((Control)_Button2034).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_BRANCHEMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_BRANCHEMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_BRANCHEMENT_TextChanged;
			if (_Combo_BRANCHEMENT != null)
			{
				((Control)_Combo_BRANCHEMENT).TextChanged -= eventHandler;
			}
			_Combo_BRANCHEMENT = value;
			if (_Combo_BRANCHEMENT != null)
			{
				((Control)_Combo_BRANCHEMENT).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button34_Click;
			if (_Button34 != null)
			{
				((Control)_Button34).Click -= eventHandler;
			}
			_Button34 = value;
			if (_Button34 != null)
			{
				((Control)_Button34).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_PRINTER_C4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_C4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_C4 = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER_C3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_C3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_C3 = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER_SOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_SOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_SOLDER = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER_ADDITION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_ADDITION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_ADDITION = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER_C2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_C2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_C2 = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER_C1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_C1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_C1 = value;
		}
	}

	internal virtual Panel Panel16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel16 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_CLOTURE_CAISSIER_OBLIGER
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_CLOTURE_CAISSIER_OBLIGER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_CLOTURE_CAISSIER_OBLIGER != null)
			{
				_CheckBox_me_CLOTURE_CAISSIER_OBLIGER.CheckedChanged -= obj;
			}
			_CheckBox_me_CLOTURE_CAISSIER_OBLIGER = value;
			if (_CheckBox_me_CLOTURE_CAISSIER_OBLIGER != null)
			{
				_CheckBox_me_CLOTURE_CAISSIER_OBLIGER.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label84
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label84 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_AJOUT_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_AJOUT_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_AJOUT_STOCK != null)
			{
				_CheckBox_me_AJOUT_STOCK.CheckedChanged -= obj;
			}
			_CheckBox_me_AJOUT_STOCK = value;
			if (_CheckBox_me_AJOUT_STOCK != null)
			{
				_CheckBox_me_AJOUT_STOCK.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label78
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label78 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_ECRAN_PUB
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_ECRAN_PUB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_ECRAN_PUB = value;
		}
	}

	internal virtual Label Label77
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label77 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_SOLDER_SANS_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_SOLDER_SANS_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_SOLDER_SANS_TICKET != null)
			{
				_CheckBox_me_SOLDER_SANS_TICKET.CheckedChanged -= obj;
			}
			_CheckBox_me_SOLDER_SANS_TICKET = value;
			if (_CheckBox_me_SOLDER_SANS_TICKET != null)
			{
				_CheckBox_me_SOLDER_SANS_TICKET.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label72
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label72 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_GESTION_CLOTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_GESTION_CLOTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_GESTION_CLOTURE != null)
			{
				_CheckBox_me_GESTION_CLOTURE.CheckedChanged -= obj;
			}
			_CheckBox_me_GESTION_CLOTURE = value;
			if (_CheckBox_me_GESTION_CLOTURE != null)
			{
				_CheckBox_me_GESTION_CLOTURE.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_MODE_WINDOWS
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_MODE_WINDOWS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_MODE_WINDOWS = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_GESTION_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_GESTION_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_GESTION_CREDIT = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_CLIENT = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_VENDEUR = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_RFID
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_RFID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox_me_RFID = value;
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

	internal virtual Label Label39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label39 = value;
		}
	}

	internal virtual Label Label40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label40 = value;
		}
	}

	internal virtual Label Label41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label41 = value;
		}
	}

	internal virtual Label Label42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label42 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_BLOCAGE_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_BLOCAGE_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_BLOCAGE_STOCK != null)
			{
				_CheckBox_me_BLOCAGE_STOCK.CheckedChanged -= obj;
			}
			_CheckBox_me_BLOCAGE_STOCK = value;
			if (_CheckBox_me_BLOCAGE_STOCK != null)
			{
				_CheckBox_me_BLOCAGE_STOCK.CheckedChanged += obj;
			}
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

	internal virtual CheckBox_IPHONE CheckBox_me_MODIF_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_MODIF_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_MODIF_STOCK != null)
			{
				_CheckBox_me_MODIF_STOCK.CheckedChanged -= obj;
			}
			_CheckBox_me_MODIF_STOCK = value;
			if (_CheckBox_me_MODIF_STOCK != null)
			{
				_CheckBox_me_MODIF_STOCK.CheckedChanged += obj;
			}
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_STOCK != null)
			{
				_CheckBox_me_STOCK.CheckedChanged -= obj;
			}
			_CheckBox_me_STOCK = value;
			if (_CheckBox_me_STOCK != null)
			{
				_CheckBox_me_STOCK.CheckedChanged += obj;
			}
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_MODEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_MODEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_MODEP != null)
			{
				_CheckBox_me_MODEP.CheckedChanged -= obj;
			}
			_CheckBox_me_MODEP = value;
			if (_CheckBox_me_MODEP != null)
			{
				_CheckBox_me_MODEP.CheckedChanged += obj;
			}
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual CheckBox_IPHONE CheckBox_me_GESTION_GROUPE_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox_me_GESTION_GROUPE_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CheckBox_IPHONE.CheckedChangedEventHandler obj = CheckBox_me_MODEP_CheckedChanged;
			if (_CheckBox_me_GESTION_GROUPE_FAMILLE != null)
			{
				_CheckBox_me_GESTION_GROUPE_FAMILLE.CheckedChanged -= obj;
			}
			_CheckBox_me_GESTION_GROUPE_FAMILLE = value;
			if (_CheckBox_me_GESTION_GROUPE_FAMILLE != null)
			{
				_CheckBox_me_GESTION_GROUPE_FAMILLE.CheckedChanged += obj;
			}
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

	internal virtual PictureBox PictureBox_AR_3C
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_AR_3C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_AR_3C = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_2_Configuration()
	{
		((Form)this).Load += FormDialog_2_Configuration_Load;
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
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_2_Configuration));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Panel1 = new Panel();
		PictureBox_FR_4C = new PictureBox();
		PictureBox_FR_2L = new PictureBox();
		DataGridView_MODELE_TICKET = new DataGridView();
		x = new DataGridViewTextBoxColumn();
		Label_MODELE_TICKET = new Label();
		PictureBox_FR_3C = new PictureBox();
		PictureBox_AR_4C = new PictureBox();
		Button_SAVE = new Button();
		Panel8 = new Panel();
		CheckBox_me_STARTUP = new CheckBox_IPHONE();
		Label44 = new Label();
		Panel12 = new Panel();
		ListView1 = new ListView();
		OBJET = new ColumnHeader();
		VALEUR = new ColumnHeader();
		Label79 = new Label();
		Button20324 = new Button();
		Combo_PRINTER_RAPPORT = new ComboBox();
		Label8 = new Label();
		Label48 = new Label();
		Label49 = new Label();
		Label5 = new Label();
		Label47 = new Label();
		Label46 = new Label();
		Label7 = new Label();
		Button4378 = new Button();
		Button4423 = new Button();
		Button4143 = new Button();
		Button4234 = new Button();
		Button2454 = new Button();
		Button2034 = new Button();
		Combo_BRANCHEMENT = new ComboBox();
		Button34 = new Button();
		Combo_PRINTER_C4 = new ComboBox();
		Combo_PRINTER_C3 = new ComboBox();
		Combo_PRINTER_SOLDER = new ComboBox();
		Combo_PRINTER_ADDITION = new ComboBox();
		Combo_PRINTER_C2 = new ComboBox();
		Combo_PRINTER_C1 = new ComboBox();
		Panel16 = new Panel();
		CheckBox_me_GESTION_GROUPE_FAMILLE = new CheckBox_IPHONE();
		Label1 = new Label();
		CheckBox_me_CLOTURE_CAISSIER_OBLIGER = new CheckBox_IPHONE();
		Label84 = new Label();
		CheckBox_me_AJOUT_STOCK = new CheckBox_IPHONE();
		Label78 = new Label();
		CheckBox_me_ECRAN_PUB = new CheckBox_IPHONE();
		Label77 = new Label();
		CheckBox_me_SOLDER_SANS_TICKET = new CheckBox_IPHONE();
		Label72 = new Label();
		CheckBox_me_GESTION_CLOTURE = new CheckBox_IPHONE();
		Label10 = new Label();
		CheckBox_me_MODE_WINDOWS = new CheckBox_IPHONE();
		CheckBox_me_GESTION_CREDIT = new CheckBox_IPHONE();
		CheckBox_me_CLIENT = new CheckBox_IPHONE();
		CheckBox_me_VENDEUR = new CheckBox_IPHONE();
		CheckBox_me_RFID = new CheckBox_IPHONE();
		Label38 = new Label();
		Label39 = new Label();
		Label40 = new Label();
		Label41 = new Label();
		Label42 = new Label();
		CheckBox_me_BLOCAGE_STOCK = new CheckBox_IPHONE();
		Label24 = new Label();
		CheckBox_me_MODIF_STOCK = new CheckBox_IPHONE();
		CheckBox_me_STOCK = new CheckBox_IPHONE();
		CheckBox_me_MODEP = new CheckBox_IPHONE();
		Label13 = new Label();
		Label16 = new Label();
		Label19 = new Label();
		PictureBox_AR_3C = new PictureBox();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox_FR_4C).BeginInit();
		((ISupportInitialize)PictureBox_FR_2L).BeginInit();
		((ISupportInitialize)DataGridView_MODELE_TICKET).BeginInit();
		((ISupportInitialize)PictureBox_FR_3C).BeginInit();
		((ISupportInitialize)PictureBox_AR_4C).BeginInit();
		((Control)Panel8).SuspendLayout();
		((Control)Panel12).SuspendLayout();
		((Control)Panel16).SuspendLayout();
		((ISupportInitialize)PictureBox_AR_3C).BeginInit();
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
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).BackColor = Color.White;
		Panel1.BorderStyle = (BorderStyle)1;
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_AR_3C);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_MODELE_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Label_MODELE_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_AR_4C);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_FR_4C);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_FR_2L);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_FR_3C);
		((Control)Panel1).Name = "Panel1";
		PictureBox_FR_4C.BorderStyle = (BorderStyle)1;
		((Control)PictureBox_FR_4C).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox_FR_4C, "PictureBox_FR_4C");
		((Control)PictureBox_FR_4C).Name = "PictureBox_FR_4C";
		PictureBox_FR_4C.TabStop = false;
		PictureBox_FR_2L.BorderStyle = (BorderStyle)1;
		((Control)PictureBox_FR_2L).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox_FR_2L, "PictureBox_FR_2L");
		((Control)PictureBox_FR_2L).Name = "PictureBox_FR_2L";
		PictureBox_FR_2L.TabStop = false;
		DataGridView_MODELE_TICKET.AllowUserToAddRows = false;
		DataGridView_MODELE_TICKET.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_MODELE_TICKET.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView_MODELE_TICKET.ColumnHeadersDefaultCellStyle = val;
		DataGridView_MODELE_TICKET.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_MODELE_TICKET.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)x });
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView_MODELE_TICKET.DefaultCellStyle = val2;
		DataGridView_MODELE_TICKET.EditMode = (DataGridViewEditMode)0;
		DataGridView_MODELE_TICKET.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView_MODELE_TICKET, "DataGridView_MODELE_TICKET");
		((Control)DataGridView_MODELE_TICKET).Name = "DataGridView_MODELE_TICKET";
		DataGridView_MODELE_TICKET.RowHeadersVisible = false;
		((Control)DataGridView_MODELE_TICKET).Tag = "MODELE_TICKET";
		componentResourceManager.ApplyResources(x, "x");
		((DataGridViewColumn)x).Name = "x";
		((DataGridViewColumn)x).ReadOnly = true;
		x.SortMode = (DataGridViewColumnSortMode)2;
		((Control)Label_MODELE_TICKET).BackColor = Color.FromArgb(70, 70, 70);
		componentResourceManager.ApplyResources(Label_MODELE_TICKET, "Label_MODELE_TICKET");
		((Control)Label_MODELE_TICKET).ForeColor = Color.White;
		((Control)Label_MODELE_TICKET).Name = "Label_MODELE_TICKET";
		((Control)Label_MODELE_TICKET).Tag = "MODELE_TICKET";
		Label_MODELE_TICKET.UseCompatibleTextRendering = true;
		PictureBox_FR_3C.BorderStyle = (BorderStyle)1;
		((Control)PictureBox_FR_3C).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox_FR_3C, "PictureBox_FR_3C");
		((Control)PictureBox_FR_3C).Name = "PictureBox_FR_3C";
		PictureBox_FR_3C.TabStop = false;
		PictureBox_AR_4C.BorderStyle = (BorderStyle)1;
		((Control)PictureBox_AR_4C).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox_AR_4C, "PictureBox_AR_4C");
		((Control)PictureBox_AR_4C).Name = "PictureBox_AR_4C";
		PictureBox_AR_4C.TabStop = false;
		componentResourceManager.ApplyResources(Button_SAVE, "Button_SAVE");
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((Control)Button_SAVE).ForeColor = Color.White;
		((Control)Button_SAVE).Name = "Button_SAVE";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel8, "Panel8");
		((Control)Panel8).BackColor = Color.White;
		Panel8.BorderStyle = (BorderStyle)1;
		((Control)Panel8).Controls.Add((Control)(object)CheckBox_me_STARTUP);
		((Control)Panel8).Controls.Add((Control)(object)Label44);
		((Control)Panel8).Name = "Panel8";
		CheckBox_me_STARTUP.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_STARTUP, "CheckBox_me_STARTUP");
		((Control)CheckBox_me_STARTUP).Name = "CheckBox_me_STARTUP";
		((Control)Label44).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label44, "Label44");
		((Control)Label44).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label44).Name = "Label44";
		componentResourceManager.ApplyResources(Panel12, "Panel12");
		((Control)Panel12).BackColor = Color.White;
		Panel12.BorderStyle = (BorderStyle)1;
		((Control)Panel12).Controls.Add((Control)(object)ListView1);
		((Control)Panel12).Controls.Add((Control)(object)Label79);
		((Control)Panel12).Controls.Add((Control)(object)Button20324);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_RAPPORT);
		((Control)Panel12).Controls.Add((Control)(object)Label8);
		((Control)Panel12).Controls.Add((Control)(object)Label48);
		((Control)Panel12).Controls.Add((Control)(object)Label49);
		((Control)Panel12).Controls.Add((Control)(object)Label5);
		((Control)Panel12).Controls.Add((Control)(object)Label47);
		((Control)Panel12).Controls.Add((Control)(object)Label46);
		((Control)Panel12).Controls.Add((Control)(object)Label7);
		((Control)Panel12).Controls.Add((Control)(object)Button4378);
		((Control)Panel12).Controls.Add((Control)(object)Button4423);
		((Control)Panel12).Controls.Add((Control)(object)Button4143);
		((Control)Panel12).Controls.Add((Control)(object)Button4234);
		((Control)Panel12).Controls.Add((Control)(object)Button2454);
		((Control)Panel12).Controls.Add((Control)(object)Button2034);
		((Control)Panel12).Controls.Add((Control)(object)Combo_BRANCHEMENT);
		((Control)Panel12).Controls.Add((Control)(object)Button34);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_C4);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_C3);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_SOLDER);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_ADDITION);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_C2);
		((Control)Panel12).Controls.Add((Control)(object)Combo_PRINTER_C1);
		((Control)Panel12).Name = "Panel12";
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
		((Control)Label79).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label79, "Label79");
		((Control)Label79).ForeColor = Color.DimGray;
		((Control)Label79).Name = "Label79";
		componentResourceManager.ApplyResources(Button20324, "Button20324");
		((Control)Button20324).Name = "Button20324";
		((ButtonBase)Button20324).UseCompatibleTextRendering = true;
		((ButtonBase)Button20324).UseVisualStyleBackColor = true;
		Combo_PRINTER_RAPPORT.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_RAPPORT, "Combo_PRINTER_RAPPORT");
		((ListControl)Combo_PRINTER_RAPPORT).FormattingEnabled = true;
		((Control)Combo_PRINTER_RAPPORT).Name = "Combo_PRINTER_RAPPORT";
		((Control)Label8).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.DimGray;
		((Control)Label8).Name = "Label8";
		((Control)Label48).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label48, "Label48");
		((Control)Label48).ForeColor = Color.DimGray;
		((Control)Label48).Name = "Label48";
		((Control)Label49).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label49, "Label49");
		((Control)Label49).ForeColor = Color.DimGray;
		((Control)Label49).Name = "Label49";
		((Control)Label5).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.DimGray;
		((Control)Label5).Name = "Label5";
		((Control)Label47).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label47, "Label47");
		((Control)Label47).ForeColor = Color.DimGray;
		((Control)Label47).Name = "Label47";
		((Control)Label46).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label46, "Label46");
		((Control)Label46).ForeColor = Color.DimGray;
		((Control)Label46).Name = "Label46";
		((Control)Label7).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.DimGray;
		((Control)Label7).Name = "Label7";
		componentResourceManager.ApplyResources(Button4378, "Button4378");
		((Control)Button4378).Name = "Button4378";
		((ButtonBase)Button4378).UseCompatibleTextRendering = true;
		((ButtonBase)Button4378).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button4423, "Button4423");
		((Control)Button4423).Name = "Button4423";
		((ButtonBase)Button4423).UseCompatibleTextRendering = true;
		((ButtonBase)Button4423).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button4143, "Button4143");
		((Control)Button4143).Name = "Button4143";
		((ButtonBase)Button4143).UseCompatibleTextRendering = true;
		((ButtonBase)Button4143).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button4234, "Button4234");
		((Control)Button4234).Name = "Button4234";
		((ButtonBase)Button4234).UseCompatibleTextRendering = true;
		((ButtonBase)Button4234).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button2454, "Button2454");
		((Control)Button2454).Name = "Button2454";
		((ButtonBase)Button2454).UseCompatibleTextRendering = true;
		((ButtonBase)Button2454).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button2034, "Button2034");
		((Control)Button2034).Name = "Button2034";
		((ButtonBase)Button2034).UseCompatibleTextRendering = true;
		((ButtonBase)Button2034).UseVisualStyleBackColor = true;
		Combo_BRANCHEMENT.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_BRANCHEMENT, "Combo_BRANCHEMENT");
		((ListControl)Combo_BRANCHEMENT).FormattingEnabled = true;
		Combo_BRANCHEMENT.Items.AddRange(new object[2]
		{
			componentResourceManager.GetString("Combo_BRANCHEMENT.Items"),
			componentResourceManager.GetString("Combo_BRANCHEMENT.Items1")
		});
		((Control)Combo_BRANCHEMENT).Name = "Combo_BRANCHEMENT";
		((Control)Combo_BRANCHEMENT).Tag = "BRANCHEMENT";
		((ButtonBase)Button34).BackColor = Color.White;
		componentResourceManager.ApplyResources(Button34, "Button34");
		((Control)Button34).Name = "Button34";
		((ButtonBase)Button34).UseCompatibleTextRendering = true;
		((ButtonBase)Button34).UseVisualStyleBackColor = false;
		Combo_PRINTER_C4.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_C4, "Combo_PRINTER_C4");
		((ListControl)Combo_PRINTER_C4).FormattingEnabled = true;
		((Control)Combo_PRINTER_C4).Name = "Combo_PRINTER_C4";
		Combo_PRINTER_C3.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_C3, "Combo_PRINTER_C3");
		((ListControl)Combo_PRINTER_C3).FormattingEnabled = true;
		((Control)Combo_PRINTER_C3).Name = "Combo_PRINTER_C3";
		Combo_PRINTER_SOLDER.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_SOLDER, "Combo_PRINTER_SOLDER");
		((ListControl)Combo_PRINTER_SOLDER).FormattingEnabled = true;
		((Control)Combo_PRINTER_SOLDER).Name = "Combo_PRINTER_SOLDER";
		Combo_PRINTER_ADDITION.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_ADDITION, "Combo_PRINTER_ADDITION");
		((ListControl)Combo_PRINTER_ADDITION).FormattingEnabled = true;
		((Control)Combo_PRINTER_ADDITION).Name = "Combo_PRINTER_ADDITION";
		Combo_PRINTER_C2.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_C2, "Combo_PRINTER_C2");
		((ListControl)Combo_PRINTER_C2).FormattingEnabled = true;
		((Control)Combo_PRINTER_C2).Name = "Combo_PRINTER_C2";
		Combo_PRINTER_C1.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRINTER_C1, "Combo_PRINTER_C1");
		((ListControl)Combo_PRINTER_C1).FormattingEnabled = true;
		((Control)Combo_PRINTER_C1).Name = "Combo_PRINTER_C1";
		componentResourceManager.ApplyResources(Panel16, "Panel16");
		((Control)Panel16).BackColor = Color.White;
		Panel16.BorderStyle = (BorderStyle)1;
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_GESTION_GROUPE_FAMILLE);
		((Control)Panel16).Controls.Add((Control)(object)Label1);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_CLOTURE_CAISSIER_OBLIGER);
		((Control)Panel16).Controls.Add((Control)(object)Label84);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_AJOUT_STOCK);
		((Control)Panel16).Controls.Add((Control)(object)Label78);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_ECRAN_PUB);
		((Control)Panel16).Controls.Add((Control)(object)Label77);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_SOLDER_SANS_TICKET);
		((Control)Panel16).Controls.Add((Control)(object)Label72);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_GESTION_CLOTURE);
		((Control)Panel16).Controls.Add((Control)(object)Label10);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_MODE_WINDOWS);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_GESTION_CREDIT);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_CLIENT);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_VENDEUR);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_RFID);
		((Control)Panel16).Controls.Add((Control)(object)Label38);
		((Control)Panel16).Controls.Add((Control)(object)Label39);
		((Control)Panel16).Controls.Add((Control)(object)Label40);
		((Control)Panel16).Controls.Add((Control)(object)Label41);
		((Control)Panel16).Controls.Add((Control)(object)Label42);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_BLOCAGE_STOCK);
		((Control)Panel16).Controls.Add((Control)(object)Label24);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_MODIF_STOCK);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_STOCK);
		((Control)Panel16).Controls.Add((Control)(object)CheckBox_me_MODEP);
		((Control)Panel16).Controls.Add((Control)(object)Label13);
		((Control)Panel16).Controls.Add((Control)(object)Label16);
		((Control)Panel16).Controls.Add((Control)(object)Label19);
		((Control)Panel16).Name = "Panel16";
		CheckBox_me_GESTION_GROUPE_FAMILLE.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_GESTION_GROUPE_FAMILLE, "CheckBox_me_GESTION_GROUPE_FAMILLE");
		((Control)CheckBox_me_GESTION_GROUPE_FAMILLE).Name = "CheckBox_me_GESTION_GROUPE_FAMILLE";
		((Control)CheckBox_me_GESTION_GROUPE_FAMILLE).Tag = "GROUPES";
		((Control)Label1).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label1).Name = "Label1";
		CheckBox_me_CLOTURE_CAISSIER_OBLIGER.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_CLOTURE_CAISSIER_OBLIGER, "CheckBox_me_CLOTURE_CAISSIER_OBLIGER");
		((Control)CheckBox_me_CLOTURE_CAISSIER_OBLIGER).Name = "CheckBox_me_CLOTURE_CAISSIER_OBLIGER";
		((Control)CheckBox_me_CLOTURE_CAISSIER_OBLIGER).Tag = "CLOTURE_CAISSIER_OBLIGER";
		((Control)Label84).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label84, "Label84");
		((Control)Label84).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label84).Name = "Label84";
		CheckBox_me_AJOUT_STOCK.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_AJOUT_STOCK, "CheckBox_me_AJOUT_STOCK");
		((Control)CheckBox_me_AJOUT_STOCK).Name = "CheckBox_me_AJOUT_STOCK";
		((Control)CheckBox_me_AJOUT_STOCK).Tag = "AJOUT_STOCK_MANUEL";
		((Control)Label78).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label78, "Label78");
		((Control)Label78).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label78).Name = "Label78";
		CheckBox_me_ECRAN_PUB.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_ECRAN_PUB, "CheckBox_me_ECRAN_PUB");
		((Control)CheckBox_me_ECRAN_PUB).Name = "CheckBox_me_ECRAN_PUB";
		((Control)Label77).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label77, "Label77");
		((Control)Label77).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label77).Name = "Label77";
		CheckBox_me_SOLDER_SANS_TICKET.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_SOLDER_SANS_TICKET, "CheckBox_me_SOLDER_SANS_TICKET");
		((Control)CheckBox_me_SOLDER_SANS_TICKET).Name = "CheckBox_me_SOLDER_SANS_TICKET";
		((Control)CheckBox_me_SOLDER_SANS_TICKET).Tag = "SOLDER_SANS_TICKET";
		((Control)Label72).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label72, "Label72");
		((Control)Label72).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label72).Name = "Label72";
		CheckBox_me_GESTION_CLOTURE.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_GESTION_CLOTURE, "CheckBox_me_GESTION_CLOTURE");
		((Control)CheckBox_me_GESTION_CLOTURE).Name = "CheckBox_me_GESTION_CLOTURE";
		((Control)CheckBox_me_GESTION_CLOTURE).Tag = "GESTION_CLOTURE";
		((Control)Label10).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label10).Name = "Label10";
		CheckBox_me_MODE_WINDOWS.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_MODE_WINDOWS, "CheckBox_me_MODE_WINDOWS");
		((Control)CheckBox_me_MODE_WINDOWS).Name = "CheckBox_me_MODE_WINDOWS";
		CheckBox_me_GESTION_CREDIT.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_GESTION_CREDIT, "CheckBox_me_GESTION_CREDIT");
		((Control)CheckBox_me_GESTION_CREDIT).Name = "CheckBox_me_GESTION_CREDIT";
		CheckBox_me_CLIENT.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_CLIENT, "CheckBox_me_CLIENT");
		((Control)CheckBox_me_CLIENT).Name = "CheckBox_me_CLIENT";
		CheckBox_me_VENDEUR.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_VENDEUR, "CheckBox_me_VENDEUR");
		((Control)CheckBox_me_VENDEUR).Name = "CheckBox_me_VENDEUR";
		CheckBox_me_RFID.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_RFID, "CheckBox_me_RFID");
		((Control)CheckBox_me_RFID).Name = "CheckBox_me_RFID";
		((Control)Label38).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label38, "Label38");
		((Control)Label38).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label38).Name = "Label38";
		((Control)Label39).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label39, "Label39");
		((Control)Label39).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label39).Name = "Label39";
		((Control)Label40).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label40, "Label40");
		((Control)Label40).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label40).Name = "Label40";
		((Control)Label41).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label41, "Label41");
		((Control)Label41).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label41).Name = "Label41";
		((Control)Label42).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label42, "Label42");
		((Control)Label42).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label42).Name = "Label42";
		CheckBox_me_BLOCAGE_STOCK.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_BLOCAGE_STOCK, "CheckBox_me_BLOCAGE_STOCK");
		((Control)CheckBox_me_BLOCAGE_STOCK).Name = "CheckBox_me_BLOCAGE_STOCK";
		((Control)CheckBox_me_BLOCAGE_STOCK).Tag = "BLOCAGE_STOCK_INSUFFISANT";
		((Control)Label24).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label24, "Label24");
		((Control)Label24).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label24).Name = "Label24";
		CheckBox_me_MODIF_STOCK.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_MODIF_STOCK, "CheckBox_me_MODIF_STOCK");
		((Control)CheckBox_me_MODIF_STOCK).Name = "CheckBox_me_MODIF_STOCK";
		((Control)CheckBox_me_MODIF_STOCK).Tag = "MODIF_STOCK_MANUEL";
		CheckBox_me_STOCK.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_STOCK, "CheckBox_me_STOCK");
		((Control)CheckBox_me_STOCK).Name = "CheckBox_me_STOCK";
		((Control)CheckBox_me_STOCK).Tag = "GESTION_STOCK";
		CheckBox_me_MODEP.Checked = false;
		componentResourceManager.ApplyResources(CheckBox_me_MODEP, "CheckBox_me_MODEP");
		((Control)CheckBox_me_MODEP).Name = "CheckBox_me_MODEP";
		((Control)CheckBox_me_MODEP).Tag = "FENETRE_MODE_P";
		((Control)Label13).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label13, "Label13");
		((Control)Label13).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label13).Name = "Label13";
		((Control)Label16).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label16, "Label16");
		((Control)Label16).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label16).Name = "Label16";
		((Control)Label19).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label19, "Label19");
		((Control)Label19).ForeColor = Color.FromArgb(70, 70, 70);
		((Control)Label19).Name = "Label19";
		((Control)PictureBox_AR_3C).BackColor = Color.White;
		PictureBox_AR_3C.BorderStyle = (BorderStyle)1;
		((Control)PictureBox_AR_3C).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox_AR_3C, "PictureBox_AR_3C");
		((Control)PictureBox_AR_3C).Name = "PictureBox_AR_3C";
		PictureBox_AR_3C.TabStop = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.WhiteSmoke;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Control)this).Controls.Add((Control)(object)Panel8);
		((Control)this).Controls.Add((Control)(object)Panel12);
		((Control)this).Controls.Add((Control)(object)Panel16);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_2_Configuration";
		((Form)this).ShowIcon = false;
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox_FR_4C).EndInit();
		((ISupportInitialize)PictureBox_FR_2L).EndInit();
		((ISupportInitialize)DataGridView_MODELE_TICKET).EndInit();
		((ISupportInitialize)PictureBox_FR_3C).EndInit();
		((ISupportInitialize)PictureBox_AR_4C).EndInit();
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel12).ResumeLayout(false);
		((Control)Panel16).ResumeLayout(false);
		((ISupportInitialize)PictureBox_AR_3C).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_2_Configuration_Load(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		DataGridView_MODELE_TICKET.Rows.Clear();
		DataGridView_MODELE_TICKET.Columns[0].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
		DataGridView_MODELE_TICKET.Rows.Add(new object[1] { "FR_3C" });
		DataGridView_MODELE_TICKET.Rows.Add(new object[1] { "FR_4C" });
		DataGridView_MODELE_TICKET.Rows.Add(new object[1] { "FR_2L" });
		DataGridView_MODELE_TICKET.Rows.Add(new object[1] { "AR_3C" });
		DataGridView_MODELE_TICKET.Rows.Add(new object[1] { "AR_4C" });
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataGridView_MODELE_TICKET.Rows)
			{
				DataGridViewRow val = item;
				val.Height = (int)Math.Round((double)(((Control)DataGridView_MODELE_TICKET).Height - DataGridView_MODELE_TICKET.ColumnHeadersHeight - 3) / (double)DataGridView_MODELE_TICKET.Rows.Count);
			}
			MySqlCommand val2 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val2.CommandText = "select    *     from     TABLE_PARAMETRES         ";
			val2.Connection = Module1.cn_SQL;
			val2.ExecuteNonQuery();
			ListView1.Items.Clear();
			MySqlDataReader val3 = val2.ExecuteReader();
			if (val3.HasRows)
			{
				while (val3.Read())
				{
					ListView1.Items.Add(val3["OBJET"].ToString());
					ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(val3["VALEUR"].ToString());
				}
			}
			val3.Close();
			Module1.cn_SQL.Close();
			CheckBox_me_MODEP.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("FENETRE_MODE_P", false, 0).Index].SubItems[1].Text);
			CheckBox_me_STOCK.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("GESTION_STOCK", false, 0).Index].SubItems[1].Text);
			CheckBox_me_MODIF_STOCK.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("MODIF_STOCK_MANUEL", false, 0).Index].SubItems[1].Text);
			CheckBox_me_AJOUT_STOCK.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("AJOUT_STOCK_MANUEL", false, 0).Index].SubItems[1].Text);
			CheckBox_me_BLOCAGE_STOCK.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("BLOCAGE_STOCK_INSUFFISANT", false, 0).Index].SubItems[1].Text);
			CheckBox_me_SOLDER_SANS_TICKET.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("SOLDER_SANS_TICKET", false, 0).Index].SubItems[1].Text);
			CheckBox_me_GESTION_CLOTURE.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text);
			CheckBox_me_CLOTURE_CAISSIER_OBLIGER.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("CLOTURE_CAISSIER_OBLIGER", false, 0).Index].SubItems[1].Text);
			CheckBox_me_GESTION_GROUPE_FAMILLE.Checked = Conversions.ToBoolean(ListView1.Items[ListView1.FindItemWithText("GROUPES", false, 0).Index].SubItems[1].Text);
			Combo_BRANCHEMENT.Text = ListView1.Items[ListView1.FindItemWithText("BRANCHEMENT", false, 0).Index].SubItems[1].Text;
			switch (ListView1.Items[ListView1.FindItemWithText("MODELE_TICKET", false, 0).Index].SubItems[1].Text)
			{
			case "FR_3C":
				DataGridView_MODELE_TICKET.CurrentCell = DataGridView_MODELE_TICKET.Rows[0].Cells[0];
				break;
			case "AR":
				DataGridView_MODELE_TICKET.CurrentCell = DataGridView_MODELE_TICKET.Rows[1].Cells[0];
				break;
			case "FR_4C":
				DataGridView_MODELE_TICKET.CurrentCell = DataGridView_MODELE_TICKET.Rows[2].Cells[0];
				break;
			case "FR_2L":
				DataGridView_MODELE_TICKET.CurrentCell = DataGridView_MODELE_TICKET.Rows[3].Cells[0];
				break;
			}
			CheckBox_me_RFID.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/acces_rfid.sni"));
			CheckBox_me_VENDEUR.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/choix_vendeur.sni"));
			CheckBox_me_CLIENT.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/choix_client.sni"));
			CheckBox_me_GESTION_CREDIT.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/gestion_credit.sni"));
			CheckBox_me_MODE_WINDOWS.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/mode_windows.sni"));
			CheckBox_me_ECRAN_PUB.Checked = Conversions.ToBoolean(File.ReadAllText(Application.StartupPath + "/afficher_ecran_pub.sni"));
			Combo_PRINTER_RAPPORT.Items.Clear();
			Combo_PRINTER_SOLDER.Items.Clear();
			Combo_PRINTER_ADDITION.Items.Clear();
			Combo_PRINTER_C1.Items.Clear();
			Combo_PRINTER_C2.Items.Clear();
			Combo_PRINTER_C3.Items.Clear();
			Combo_PRINTER_C4.Items.Clear();
			Combo_PRINTER_RAPPORT.Items.Add((object)"");
			Combo_PRINTER_SOLDER.Items.Add((object)"");
			Combo_PRINTER_ADDITION.Items.Add((object)"");
			Combo_PRINTER_C1.Items.Add((object)"");
			Combo_PRINTER_C2.Items.Add((object)"");
			Combo_PRINTER_C3.Items.Add((object)"");
			Combo_PRINTER_C4.Items.Add((object)"");
			Combo_PRINTER_RAPPORT.Items.Add((object)"0");
			Combo_PRINTER_SOLDER.Items.Add((object)"0");
			Combo_PRINTER_ADDITION.Items.Add((object)"0");
			Combo_PRINTER_C1.Items.Add((object)"0");
			Combo_PRINTER_C2.Items.Add((object)"0");
			Combo_PRINTER_C3.Items.Add((object)"0");
			Combo_PRINTER_C4.Items.Add((object)"0");
			foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
			{
				string text = Conversions.ToString(installedPrinter);
				Combo_PRINTER_RAPPORT.Items.Add((object)text);
				Combo_PRINTER_SOLDER.Items.Add((object)text);
				Combo_PRINTER_ADDITION.Items.Add((object)text);
				Combo_PRINTER_C1.Items.Add((object)text);
				Combo_PRINTER_C2.Items.Add((object)text);
				Combo_PRINTER_C3.Items.Add((object)text);
				Combo_PRINTER_C4.Items.Add((object)text);
			}
			Combo_PRINTER_RAPPORT.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_RAPPORT.sni");
			Combo_PRINTER_SOLDER.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_CL.sni");
			Combo_PRINTER_ADDITION.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_ADD.sni");
			Combo_PRINTER_C1.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C1.sni");
			Combo_PRINTER_C2.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C2.sni");
			Combo_PRINTER_C3.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C3.sni");
			Combo_PRINTER_C4.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_C4.sni");
			CheckBox_me_STOCK.Checked = true;
			((Control)CheckBox_me_STOCK).Enabled = false;
		}
	}

	private void CheckBox_me_STARTUP_Load(object sender, EventArgs e)
	{
	}

	private void CheckBox_me_MODEP_CheckedChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
		}
	}

	private void Combo_BRANCHEMENT_TextChanged(object sender, EventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
		}
	}

	private void DataGridView_MODELE_TICKET_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_MODELE_TICKET_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		ListViewItem val = ListView1.FindItemWithText(Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null)), false, 0);
		if (val != null)
		{
			ListView1.Items[val.Index].Selected = true;
			ListView1.Items[val.Index].SubItems[1].Text = DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString();
		}
		if (Operators.CompareString(DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString(), "FR_3C", TextCompare: false) == 0)
		{
			((Control)PictureBox_FR_3C).Visible = true;
			((Control)PictureBox_FR_3C).BringToFront();
		}
		else if (Operators.CompareString(DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString(), "FR_4C", TextCompare: false) == 0)
		{
			((Control)PictureBox_FR_4C).Visible = true;
			((Control)PictureBox_FR_4C).BringToFront();
		}
		else if (Operators.CompareString(DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString(), "FR_2L", TextCompare: false) == 0)
		{
			((Control)PictureBox_FR_2L).Visible = true;
			((Control)PictureBox_FR_2L).BringToFront();
		}
		else if (Operators.CompareString(DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString(), "AR_3C", TextCompare: false) == 0)
		{
			((Control)PictureBox_AR_3C).Visible = true;
			((Control)PictureBox_AR_3C).BringToFront();
		}
		else if (Operators.CompareString(DataGridView_MODELE_TICKET.Rows[((DataGridViewBand)DataGridView_MODELE_TICKET.CurrentRow).Index].Cells[0].Value.ToString(), "AR_4C", TextCompare: false) == 0)
		{
			((Control)PictureBox_AR_4C).Visible = true;
			((Control)PictureBox_AR_4C).BringToFront();
		}
	}

	private void Button20324_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_RAPPORT.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button2034_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_SOLDER.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button2454_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_ADDITION.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button4234_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_C1.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button4143_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_C2.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button4423_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_C3.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button4378_Click(object sender, EventArgs e)
	{
		string text = Combo_PRINTER_C4.Text;
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
			string text2 = "";
			rawPrinterHelper.OpenPrint(text);
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!8\u001ba1TEST IMPRESSION\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001b!\0\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1 \r\n \r\n \n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba0\u001b!\0" + "-".PadRight(42, '-') + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n");
			rawPrinterHelper.SendStringToPrinter(text, "\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n");
			rawPrinterHelper.SendStringToPrinter(text, "\n\n\u001bi\r\n\u001b@\u001bp\0.}\n");
			rawPrinterHelper.ClosePrint();
		}
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("control.exe");
		processStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
		processStartInfo.Arguments = "printers";
		Process.Start(processStartInfo);
		((Form)MyProject.Forms.Form_0_TEMPLATE).WindowState = (FormWindowState)1;
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (CheckBox_me_STARTUP.Checked && (!((ServerComputer)MyProject.Computer).FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\LOGICA.lnk") | !((ServerComputer)MyProject.Computer).FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\LOGICA.lnk")))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell"));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "CreateShortcut", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\LOGICA.lnk" }, null, null, null));
					NewLateBinding.LateSet(objectValue2, null, "TargetPath", new object[1] { Module1._CHEMIN_FOLDER + "\\" + Application.ProductName + ".exe" }, null, null);
					NewLateBinding.LateSet(objectValue2, null, "WindowStyle", new object[1] { 1 }, null, null);
					NewLateBinding.LateCall(objectValue2, null, "Save", new object[0], null, null, null, IgnoreReturn: true);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell"));
					object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, null, "CreateShortcut", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\LOGICA.lnk" }, null, null, null));
					NewLateBinding.LateSet(objectValue4, null, "TargetPath", new object[1] { Module1._CHEMIN_FOLDER + "\\" + Application.ProductName + ".exe" }, null, null);
					NewLateBinding.LateSet(objectValue4, null, "WindowStyle", new object[1] { 1 }, null, null);
					NewLateBinding.LateCall(objectValue4, null, "Save", new object[0], null, null, null, IgnoreReturn: true);
				}
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
				MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text = ListView1.Items[ListView1.FindItemWithText("BRANCHEMENT", false, 0).Index].SubItems[1].Text;
				File.WriteAllText(Application.StartupPath + "/acces_rfid.sni", Conversions.ToString(CheckBox_me_RFID.Checked));
				File.WriteAllText(Application.StartupPath + "/choix_vendeur.sni", Conversions.ToString(CheckBox_me_VENDEUR.Checked));
				File.WriteAllText(Application.StartupPath + "/choix_client.sni", Conversions.ToString(CheckBox_me_CLIENT.Checked));
				File.WriteAllText(Application.StartupPath + "/gestion_credit.sni", Conversions.ToString(CheckBox_me_GESTION_CREDIT.Checked));
				File.WriteAllText(Application.StartupPath + "/mode_windows.sni", Conversions.ToString(CheckBox_me_MODE_WINDOWS.Checked));
				File.WriteAllText(Application.StartupPath + "/afficher_ecran_pub.sni", Conversions.ToString(CheckBox_me_ECRAN_PUB.Checked));
				if (CheckBox_me_ECRAN_PUB.Checked)
				{
					((ServerComputer)MyProject.Computer).FileSystem.CreateDirectory("c:\\PHOTOS");
					if (!((ServerComputer)MyProject.Computer).FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\PHOTOS.lnk"))
					{
						object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell"));
						object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, null, "CreateShortcut", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\PHOTOS.lnk" }, null, null, null));
						NewLateBinding.LateSet(objectValue6, null, "TargetPath", new object[1] { "c:\\PHOTOS" }, null, null);
						NewLateBinding.LateSet(objectValue6, null, "WindowStyle", new object[1] { 1 }, null, null);
						NewLateBinding.LateCall(objectValue6, null, "Save", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				File.WriteAllText(Application.StartupPath + "/PRINTER_RAPPORT.sni", Combo_PRINTER_RAPPORT.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_CL.sni", Combo_PRINTER_SOLDER.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_ADD.sni", Combo_PRINTER_ADDITION.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_C1.sni", Combo_PRINTER_C1.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_C2.sni", Combo_PRINTER_C2.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_C3.sni", Combo_PRINTER_C3.Text);
				File.WriteAllText(Application.StartupPath + "/PRINTER_C4.sni", Combo_PRINTER_C4.Text);
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
					Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val3 = null;
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

	private void PictureBox_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Dock", new object[0], null, null, null), (object)(DockStyle)5, TextCompare: false))
		{
			NewLateBinding.LateCall(sender, null, "BringToFront", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(sender, null, "Dock", new object[1] { (object)(DockStyle)0 }, null, null);
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Dock", new object[0], null, null, null), (object)(DockStyle)0, TextCompare: false))
		{
			NewLateBinding.LateCall(sender, null, "BringToFront", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(sender, null, "Dock", new object[1] { (object)(DockStyle)5 }, null, null);
		}
	}

	private void RadioButton_MODELE_3COL_CheckedChanged(object sender, EventArgs e)
	{
	}
}

