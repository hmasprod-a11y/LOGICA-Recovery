using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ROBOT : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Combo_PRINTER_DUPLICATA")]
	private ComboBox _Combo_PRINTER_DUPLICATA;

	[AccessedThroughProperty("Combo_PRINTER")]
	private ComboBox _Combo_PRINTER;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Combo_MODE_STOCK")]
	private ComboBox _Combo_MODE_STOCK;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Combo_FENETRE_PESAGE")]
	private ComboBox _Combo_FENETRE_PESAGE;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Combo_TAUX_TVA")]
	private ComboBox _Combo_TAUX_TVA;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Combo_UNITE")]
	private ComboBox _Combo_UNITE;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Combo_FAMILLE")]
	private ComboBox _Combo_FAMILLE;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Picture_GOOGLE3")]
	private PictureBox _Picture_GOOGLE3;

	[AccessedThroughProperty("Picture_GOOGLE2")]
	private PictureBox _Picture_GOOGLE2;

	[AccessedThroughProperty("Picture_GOOGLE1")]
	private PictureBox _Picture_GOOGLE1;

	[AccessedThroughProperty("Picture_GOOGLE6")]
	private PictureBox _Picture_GOOGLE6;

	[AccessedThroughProperty("Picture_GOOGLE5")]
	private PictureBox _Picture_GOOGLE5;

	[AccessedThroughProperty("Picture_GOOGLE4")]
	private PictureBox _Picture_GOOGLE4;

	[AccessedThroughProperty("Picture_GOOGLE8")]
	private PictureBox _Picture_GOOGLE8;

	[AccessedThroughProperty("Picture_GOOGLE7")]
	private PictureBox _Picture_GOOGLE7;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Text_LIEN_PICTURE")]
	private TextBox _Text_LIEN_PICTURE;

	[AccessedThroughProperty("Picture_IMAGE")]
	private PictureBox _Picture_IMAGE;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Combo_TYPE")]
	private ComboBox _Combo_TYPE;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("Column3")]
	private DataGridViewTextBoxColumn _Column3;

	[AccessedThroughProperty("Picture_GOOGLE12")]
	private PictureBox _Picture_GOOGLE12;

	[AccessedThroughProperty("Picture_GOOGLE11")]
	private PictureBox _Picture_GOOGLE11;

	[AccessedThroughProperty("Picture_GOOGLE10")]
	private PictureBox _Picture_GOOGLE10;

	[AccessedThroughProperty("Picture_GOOGLE9")]
	private PictureBox _Picture_GOOGLE9;

	[AccessedThroughProperty("Panel_COULEUR")]
	private Panel _Panel_COULEUR;

	[AccessedThroughProperty("Picture_COLOR_23")]
	private PictureBox _Picture_COLOR_23;

	[AccessedThroughProperty("Picture_COLOR_22")]
	private PictureBox _Picture_COLOR_22;

	[AccessedThroughProperty("Picture_COLOR_21")]
	private PictureBox _Picture_COLOR_21;

	[AccessedThroughProperty("Picture_COLOR_20")]
	private PictureBox _Picture_COLOR_20;

	[AccessedThroughProperty("Picture_COLOR_19")]
	private PictureBox _Picture_COLOR_19;

	[AccessedThroughProperty("Picture_COLOR_18")]
	private PictureBox _Picture_COLOR_18;

	[AccessedThroughProperty("Picture_COLOR_17")]
	private PictureBox _Picture_COLOR_17;

	[AccessedThroughProperty("Picture_COLOR_16")]
	private PictureBox _Picture_COLOR_16;

	[AccessedThroughProperty("Picture_COLOR_15")]
	private PictureBox _Picture_COLOR_15;

	[AccessedThroughProperty("Picture_COLOR_13")]
	private PictureBox _Picture_COLOR_13;

	[AccessedThroughProperty("Picture_COLOR_12")]
	private PictureBox _Picture_COLOR_12;

	[AccessedThroughProperty("Picture_COLOR_11")]
	private PictureBox _Picture_COLOR_11;

	[AccessedThroughProperty("Picture_COLOR_6")]
	private PictureBox _Picture_COLOR_6;

	[AccessedThroughProperty("Picture_COLOR_10")]
	private PictureBox _Picture_COLOR_10;

	[AccessedThroughProperty("Picture_COLOR_5")]
	private PictureBox _Picture_COLOR_5;

	[AccessedThroughProperty("Picture_COLOR_1")]
	private PictureBox _Picture_COLOR_1;

	[AccessedThroughProperty("Picture_COLOR_8")]
	private PictureBox _Picture_COLOR_8;

	[AccessedThroughProperty("Picture_COLOR_9")]
	private PictureBox _Picture_COLOR_9;

	[AccessedThroughProperty("Picture_COLOR_7")]
	private PictureBox _Picture_COLOR_7;

	[AccessedThroughProperty("Picture_COLOR_4")]
	private PictureBox _Picture_COLOR_4;

	[AccessedThroughProperty("Picture_COLOR_3")]
	private PictureBox _Picture_COLOR_3;

	[AccessedThroughProperty("Picture_COLOR_2")]
	private PictureBox _Picture_COLOR_2;

	[AccessedThroughProperty("Text_ARTICLE")]
	private TextBox _Text_ARTICLE;

	[AccessedThroughProperty("Button_FIND")]
	private Button _Button_FIND;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Combo_PROMOTION")]
	private ComboBox _Combo_PROMOTION;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Button_M_SHIFTS")]
	private Button _Button_M_SHIFTS;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Button17")]
	private Button _Button17;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Text_COMPOSITION")]
	private TextBox _Text_COMPOSITION;

	[AccessedThroughProperty("Button19")]
	private Button _Button19;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Button18")]
	private Button _Button18;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("Combo_BALANCE")]
	private ComboBox _Combo_BALANCE;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("Check_png")]
	private CheckBox _Check_png;

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

	internal virtual Label Label37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label37 = value;
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

	internal virtual ComboBox Combo_PRINTER_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER_DUPLICATA = value;
		}
	}

	internal virtual ComboBox Combo_PRINTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRINTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRINTER = value;
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
			EventHandler eventHandler = CheckedListBox1_SelectedIndexChanged;
			if (_CheckedListBox1 != null)
			{
				((ListBox)_CheckedListBox1).SelectedIndexChanged -= eventHandler;
			}
			_CheckedListBox1 = value;
			if (_CheckedListBox1 != null)
			{
				((ListBox)_CheckedListBox1).SelectedIndexChanged += eventHandler;
			}
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
			EventHandler eventHandler = Button1_Click_1;
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

	internal virtual ComboBox Combo_MODE_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_MODE_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_MODE_STOCK = value;
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

	internal virtual ComboBox Combo_FENETRE_PESAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FENETRE_PESAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FENETRE_PESAGE = value;
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

	internal virtual ComboBox Combo_TAUX_TVA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TAUX_TVA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_TAUX_TVA = value;
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_UNITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_UNITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_UNITE = value;
		}
	}

	internal virtual Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30 = value;
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

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).Click -= eventHandler;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FAMILLE = value;
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

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button7_Click;
			if (_Button7 != null)
			{
				((Control)_Button7).Click -= eventHandler;
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal virtual PictureBox Picture_GOOGLE3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE3 != null)
			{
				((Control)_Picture_GOOGLE3).Click -= eventHandler;
			}
			_Picture_GOOGLE3 = value;
			if (_Picture_GOOGLE3 != null)
			{
				((Control)_Picture_GOOGLE3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE2 != null)
			{
				((Control)_Picture_GOOGLE2).Click -= eventHandler;
			}
			_Picture_GOOGLE2 = value;
			if (_Picture_GOOGLE2 != null)
			{
				((Control)_Picture_GOOGLE2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE1 != null)
			{
				((Control)_Picture_GOOGLE1).Click -= eventHandler;
			}
			_Picture_GOOGLE1 = value;
			if (_Picture_GOOGLE1 != null)
			{
				((Control)_Picture_GOOGLE1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE6 != null)
			{
				((Control)_Picture_GOOGLE6).Click -= eventHandler;
			}
			_Picture_GOOGLE6 = value;
			if (_Picture_GOOGLE6 != null)
			{
				((Control)_Picture_GOOGLE6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE5 != null)
			{
				((Control)_Picture_GOOGLE5).Click -= eventHandler;
			}
			_Picture_GOOGLE5 = value;
			if (_Picture_GOOGLE5 != null)
			{
				((Control)_Picture_GOOGLE5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE4 != null)
			{
				((Control)_Picture_GOOGLE4).Click -= eventHandler;
			}
			_Picture_GOOGLE4 = value;
			if (_Picture_GOOGLE4 != null)
			{
				((Control)_Picture_GOOGLE4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE8 != null)
			{
				((Control)_Picture_GOOGLE8).Click -= eventHandler;
			}
			_Picture_GOOGLE8 = value;
			if (_Picture_GOOGLE8 != null)
			{
				((Control)_Picture_GOOGLE8).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE7 != null)
			{
				((Control)_Picture_GOOGLE7).Click -= eventHandler;
			}
			_Picture_GOOGLE7 = value;
			if (_Picture_GOOGLE7 != null)
			{
				((Control)_Picture_GOOGLE7).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_INFO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_INFO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_INFO = value;
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

	internal virtual Button Button11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button11_Click;
			if (_Button11 != null)
			{
				((Control)_Button11).Click -= eventHandler;
			}
			_Button11 = value;
			if (_Button11 != null)
			{
				((Control)_Button11).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button10_Click;
			if (_Button10 != null)
			{
				((Control)_Button10).Click -= eventHandler;
			}
			_Button10 = value;
			if (_Button10 != null)
			{
				((Control)_Button10).Click += eventHandler;
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

	internal virtual TextBox Text_LIEN_PICTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LIEN_PICTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_LIEN_PICTURE_TextChanged;
			if (_Text_LIEN_PICTURE != null)
			{
				((Control)_Text_LIEN_PICTURE).TextChanged -= eventHandler;
			}
			_Text_LIEN_PICTURE = value;
			if (_Text_LIEN_PICTURE != null)
			{
				((Control)_Text_LIEN_PICTURE).TextChanged += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_IMAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_IMAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_IMAGE = value;
		}
	}

	internal virtual TextBox Text_ID
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID = value;
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
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click -= eventHandler;
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click += eventHandler;
			}
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
			EventHandler eventHandler = PictureBox5_Click;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox6_Click;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click -= eventHandler;
			}
			_PictureBox6 = value;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox7_Click;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).Click -= eventHandler;
			}
			_PictureBox7 = value;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).Click += eventHandler;
			}
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

	internal virtual ComboBox Combo_TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_TYPE = value;
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

	internal virtual Button Button13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button13_Click;
			if (_Button13 != null)
			{
				((Control)_Button13).Click -= eventHandler;
			}
			_Button13 = value;
			if (_Button13 != null)
			{
				((Control)_Button13).Click += eventHandler;
			}
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
			DataGridViewCellEventHandler val = DataGridView1_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellEnter;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick -= val;
				_DataGridView1.CellEnter -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick += val;
				_DataGridView1.CellEnter += val2;
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

	internal virtual DataGridViewTextBoxColumn Column2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column3 = value;
		}
	}

	internal virtual PictureBox Picture_GOOGLE12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE12 != null)
			{
				((Control)_Picture_GOOGLE12).Click -= eventHandler;
			}
			_Picture_GOOGLE12 = value;
			if (_Picture_GOOGLE12 != null)
			{
				((Control)_Picture_GOOGLE12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE11 != null)
			{
				((Control)_Picture_GOOGLE11).Click -= eventHandler;
			}
			_Picture_GOOGLE11 = value;
			if (_Picture_GOOGLE11 != null)
			{
				((Control)_Picture_GOOGLE11).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE10 != null)
			{
				((Control)_Picture_GOOGLE10).Click -= eventHandler;
			}
			_Picture_GOOGLE10 = value;
			if (_Picture_GOOGLE10 != null)
			{
				((Control)_Picture_GOOGLE10).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_GOOGLE9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_GOOGLE9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_GOOGLE_Click;
			if (_Picture_GOOGLE9 != null)
			{
				((Control)_Picture_GOOGLE9).Click -= eventHandler;
			}
			_Picture_GOOGLE9 = value;
			if (_Picture_GOOGLE9 != null)
			{
				((Control)_Picture_GOOGLE9).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_COULEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_COULEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_COULEUR = value;
		}
	}

	internal virtual PictureBox Picture_COLOR_23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_23 != null)
			{
				((Control)_Picture_COLOR_23).Click -= eventHandler;
			}
			_Picture_COLOR_23 = value;
			if (_Picture_COLOR_23 != null)
			{
				((Control)_Picture_COLOR_23).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_22 != null)
			{
				((Control)_Picture_COLOR_22).Click -= eventHandler;
			}
			_Picture_COLOR_22 = value;
			if (_Picture_COLOR_22 != null)
			{
				((Control)_Picture_COLOR_22).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_21 != null)
			{
				((Control)_Picture_COLOR_21).Click -= eventHandler;
			}
			_Picture_COLOR_21 = value;
			if (_Picture_COLOR_21 != null)
			{
				((Control)_Picture_COLOR_21).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_20 != null)
			{
				((Control)_Picture_COLOR_20).Click -= eventHandler;
			}
			_Picture_COLOR_20 = value;
			if (_Picture_COLOR_20 != null)
			{
				((Control)_Picture_COLOR_20).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_19 != null)
			{
				((Control)_Picture_COLOR_19).Click -= eventHandler;
			}
			_Picture_COLOR_19 = value;
			if (_Picture_COLOR_19 != null)
			{
				((Control)_Picture_COLOR_19).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_18 != null)
			{
				((Control)_Picture_COLOR_18).Click -= eventHandler;
			}
			_Picture_COLOR_18 = value;
			if (_Picture_COLOR_18 != null)
			{
				((Control)_Picture_COLOR_18).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_COLOR_17 = value;
		}
	}

	internal virtual PictureBox Picture_COLOR_16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_16 != null)
			{
				((Control)_Picture_COLOR_16).Click -= eventHandler;
			}
			_Picture_COLOR_16 = value;
			if (_Picture_COLOR_16 != null)
			{
				((Control)_Picture_COLOR_16).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_15 != null)
			{
				((Control)_Picture_COLOR_15).Click -= eventHandler;
			}
			_Picture_COLOR_15 = value;
			if (_Picture_COLOR_15 != null)
			{
				((Control)_Picture_COLOR_15).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_13 != null)
			{
				((Control)_Picture_COLOR_13).Click -= eventHandler;
			}
			_Picture_COLOR_13 = value;
			if (_Picture_COLOR_13 != null)
			{
				((Control)_Picture_COLOR_13).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_12 != null)
			{
				((Control)_Picture_COLOR_12).Click -= eventHandler;
			}
			_Picture_COLOR_12 = value;
			if (_Picture_COLOR_12 != null)
			{
				((Control)_Picture_COLOR_12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_11 != null)
			{
				((Control)_Picture_COLOR_11).Click -= eventHandler;
			}
			_Picture_COLOR_11 = value;
			if (_Picture_COLOR_11 != null)
			{
				((Control)_Picture_COLOR_11).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_6 != null)
			{
				((Control)_Picture_COLOR_6).Click -= eventHandler;
			}
			_Picture_COLOR_6 = value;
			if (_Picture_COLOR_6 != null)
			{
				((Control)_Picture_COLOR_6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_10 != null)
			{
				((Control)_Picture_COLOR_10).Click -= eventHandler;
			}
			_Picture_COLOR_10 = value;
			if (_Picture_COLOR_10 != null)
			{
				((Control)_Picture_COLOR_10).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_5 != null)
			{
				((Control)_Picture_COLOR_5).Click -= eventHandler;
			}
			_Picture_COLOR_5 = value;
			if (_Picture_COLOR_5 != null)
			{
				((Control)_Picture_COLOR_5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_1 != null)
			{
				((Control)_Picture_COLOR_1).Click -= eventHandler;
			}
			_Picture_COLOR_1 = value;
			if (_Picture_COLOR_1 != null)
			{
				((Control)_Picture_COLOR_1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_8 != null)
			{
				((Control)_Picture_COLOR_8).Click -= eventHandler;
			}
			_Picture_COLOR_8 = value;
			if (_Picture_COLOR_8 != null)
			{
				((Control)_Picture_COLOR_8).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_9 != null)
			{
				((Control)_Picture_COLOR_9).Click -= eventHandler;
			}
			_Picture_COLOR_9 = value;
			if (_Picture_COLOR_9 != null)
			{
				((Control)_Picture_COLOR_9).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_COLOR_7 = value;
		}
	}

	internal virtual PictureBox Picture_COLOR_4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_4 != null)
			{
				((Control)_Picture_COLOR_4).Click -= eventHandler;
			}
			_Picture_COLOR_4 = value;
			if (_Picture_COLOR_4 != null)
			{
				((Control)_Picture_COLOR_4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_3 != null)
			{
				((Control)_Picture_COLOR_3).Click -= eventHandler;
			}
			_Picture_COLOR_3 = value;
			if (_Picture_COLOR_3 != null)
			{
				((Control)_Picture_COLOR_3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_COLOR_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_COLOR_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_COLOR_Click;
			if (_Picture_COLOR_2 != null)
			{
				((Control)_Picture_COLOR_2).Click -= eventHandler;
			}
			_Picture_COLOR_2 = value;
			if (_Picture_COLOR_2 != null)
			{
				((Control)_Picture_COLOR_2).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_ARTICLE_TextChanged;
			KeyEventHandler val = Text_ARTICLE_KeyDown;
			if (_Text_ARTICLE != null)
			{
				((Control)_Text_ARTICLE).TextChanged -= eventHandler;
				((Control)_Text_ARTICLE).KeyDown -= val;
			}
			_Text_ARTICLE = value;
			if (_Text_ARTICLE != null)
			{
				((Control)_Text_ARTICLE).TextChanged += eventHandler;
				((Control)_Text_ARTICLE).KeyDown += val;
			}
		}
	}

	internal virtual Button Button_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FIND_Click;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click -= eventHandler;
			}
			_Button_FIND = value;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button8_Click;
			if (_Button8 != null)
			{
				((Control)_Button8).Click -= eventHandler;
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				((Control)_Button8).Click += eventHandler;
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

	internal virtual ComboBox Combo_PROMOTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PROMOTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PROMOTION = value;
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

	internal virtual Button Button_M_SHIFTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_M_SHIFTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_M_SHIFTS_Click;
			if (_Button_M_SHIFTS != null)
			{
				((Control)_Button_M_SHIFTS).Click -= eventHandler;
			}
			_Button_M_SHIFTS = value;
			if (_Button_M_SHIFTS != null)
			{
				((Control)_Button_M_SHIFTS).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
		}
	}

	internal virtual Button Button16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button16_Click;
			if (_Button16 != null)
			{
				((Control)_Button16).Click -= eventHandler;
			}
			_Button16 = value;
			if (_Button16 != null)
			{
				((Control)_Button16).Click += eventHandler;
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

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox9_Click;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click -= eventHandler;
			}
			_PictureBox9 = value;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
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

	internal virtual Button Button17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button17_Click;
			if (_Button17 != null)
			{
				((Control)_Button17).Click -= eventHandler;
			}
			_Button17 = value;
			if (_Button17 != null)
			{
				((Control)_Button17).Click += eventHandler;
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual TextBox Text_COMPOSITION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_COMPOSITION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_COMPOSITION = value;
		}
	}

	internal virtual Button Button19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button19_Click;
			if (_Button19 != null)
			{
				((Control)_Button19).Click -= eventHandler;
			}
			_Button19 = value;
			if (_Button19 != null)
			{
				((Control)_Button19).Click += eventHandler;
			}
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

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Button Button20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button20_Click;
			if (_Button20 != null)
			{
				((Control)_Button20).Click -= eventHandler;
			}
			_Button20 = value;
			if (_Button20 != null)
			{
				((Control)_Button20).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox Combo_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_BALANCE = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
		}
	}

	internal virtual CheckBox Check_png
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_png;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_png = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_ROBOT()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Form)this).FormClosed += FormDialog_ROBOT_FormClosed;
		((Form)this).Load += FormDialog_ROBOT_Load;
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
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
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
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Expected Obj, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected Obj, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected Obj, but got Unknown
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected Obj, but got Unknown
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected Obj, but got Unknown
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected Obj, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected Obj, but got Unknown
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected Obj, but got Unknown
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Expected Obj, but got Unknown
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Expected Obj, but got Unknown
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1350: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Expected Obj, but got Unknown
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_1397: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Expected Obj, but got Unknown
		//IL_14e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ec: Expected Obj, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected Obj, but got Unknown
		//IL_167b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1685: Expected Obj, but got Unknown
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected Obj, but got Unknown
		//IL_180a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1814: Expected Obj, but got Unknown
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected Obj, but got Unknown
		//IL_1983: Unknown result type (might be due to invalid IL or missing references)
		//IL_198d: Expected Obj, but got Unknown
		//IL_1a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b: Expected Obj, but got Unknown
		//IL_1b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b16: Expected Obj, but got Unknown
		//IL_1c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3c: Expected Obj, but got Unknown
		//IL_1c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfc: Expected Obj, but got Unknown
		//IL_1ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de5: Expected Obj, but got Unknown
		//IL_1e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9f: Expected Obj, but got Unknown
		//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f83: Expected Obj, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2054: Unknown result type (might be due to invalid IL or missing references)
		//IL_205e: Expected Obj, but got Unknown
		//IL_214e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2158: Expected Obj, but got Unknown
		//IL_2232: Unknown result type (might be due to invalid IL or missing references)
		//IL_223c: Expected Obj, but got Unknown
		//IL_2273: Unknown result type (might be due to invalid IL or missing references)
		//IL_2279: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f9: Expected Obj, but got Unknown
		//IL_29bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c9: Expected Obj, but got Unknown
		//IL_2a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a97: Expected Obj, but got Unknown
		//IL_2b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b61: Expected Obj, but got Unknown
		//IL_2c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2f: Expected Obj, but got Unknown
		//IL_2db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc3: Expected Obj, but got Unknown
		//IL_2eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef7: Expected Obj, but got Unknown
		//IL_2f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f24: Expected Obj, but got Unknown
		//IL_2f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_300b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3015: Expected Obj, but got Unknown
		//IL_30af: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b9: Expected Obj, but got Unknown
		//IL_30cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d5: Expected Obj, but got Unknown
		//IL_318a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3194: Expected Obj, but got Unknown
		//IL_31a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b0: Expected Obj, but got Unknown
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a8: Expected Obj, but got Unknown
		//IL_35b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c0: Expected Obj, but got Unknown
		//IL_35fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3600: Unknown result type (might be due to invalid IL or missing references)
		//IL_3687: Unknown result type (might be due to invalid IL or missing references)
		//IL_3691: Expected Obj, but got Unknown
		//IL_376d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3777: Expected Obj, but got Unknown
		//IL_37b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_383e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3848: Expected Obj, but got Unknown
		//IL_38fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3905: Expected Obj, but got Unknown
		//IL_39c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ca: Expected Obj, but got Unknown
		//IL_3a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7a: Expected Obj, but got Unknown
		//IL_3b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0b: Expected Obj, but got Unknown
		//IL_3bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bba: Expected Obj, but got Unknown
		//IL_3c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5f: Expected Obj, but got Unknown
		//IL_4001: Unknown result type (might be due to invalid IL or missing references)
		//IL_400b: Expected Obj, but got Unknown
		//IL_50af: Unknown result type (might be due to invalid IL or missing references)
		//IL_50b9: Expected Obj, but got Unknown
		//IL_50f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_50f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_517d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5187: Expected Obj, but got Unknown
		//IL_5238: Unknown result type (might be due to invalid IL or missing references)
		//IL_5242: Expected Obj, but got Unknown
		//IL_52d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_52dc: Expected Obj, but got Unknown
		//IL_536d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5377: Expected Obj, but got Unknown
		//IL_560c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5616: Expected Obj, but got Unknown
		//IL_56ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_56b5: Expected Obj, but got Unknown
		//IL_5759: Unknown result type (might be due to invalid IL or missing references)
		//IL_5763: Expected Obj, but got Unknown
		//IL_5ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bad: Expected Obj, but got Unknown
		//IL_5c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c94: Expected Obj, but got Unknown
		//IL_5cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d54: Expected Obj, but got Unknown
		//IL_5e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e18: Expected Obj, but got Unknown
		//IL_5ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ed5: Expected Obj, but got Unknown
		//IL_5fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fad: Expected Obj, but got Unknown
		//IL_5fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_6074: Unknown result type (might be due to invalid IL or missing references)
		//IL_607e: Expected Obj, but got Unknown
		//IL_6121: Unknown result type (might be due to invalid IL or missing references)
		//IL_612b: Expected Obj, but got Unknown
		//IL_6237: Unknown result type (might be due to invalid IL or missing references)
		//IL_6241: Expected Obj, but got Unknown
		//IL_6314: Unknown result type (might be due to invalid IL or missing references)
		//IL_631e: Expected Obj, but got Unknown
		//IL_6358: Unknown result type (might be due to invalid IL or missing references)
		//IL_635e: Unknown result type (might be due to invalid IL or missing references)
		//IL_63e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_63ef: Expected Obj, but got Unknown
		//IL_64a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_64ad: Expected Obj, but got Unknown
		//IL_6589: Unknown result type (might be due to invalid IL or missing references)
		//IL_6593: Expected Obj, but got Unknown
		//IL_65cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_65d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_665a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6664: Expected Obj, but got Unknown
		//IL_6707: Unknown result type (might be due to invalid IL or missing references)
		//IL_6711: Expected Obj, but got Unknown
		//IL_67cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_67d5: Expected Obj, but got Unknown
		//IL_6888: Unknown result type (might be due to invalid IL or missing references)
		//IL_6892: Expected Obj, but got Unknown
		//IL_6911: Unknown result type (might be due to invalid IL or missing references)
		//IL_691b: Expected Obj, but got Unknown
		//IL_6aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ab2: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ROBOT));
		Label28 = new Label();
		Label32 = new Label();
		Label37 = new Label();
		Label24 = new Label();
		Label2 = new Label();
		Combo_PRINTER_DUPLICATA = new ComboBox();
		Combo_PRINTER = new ComboBox();
		Label6 = new Label();
		CheckedListBox1 = new CheckedListBox();
		CheckBox7 = new CheckBox();
		Button15 = new Button();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Combo_MODE_STOCK = new ComboBox();
		Label46 = new Label();
		Combo_FENETRE_PESAGE = new ComboBox();
		Button4 = new Button();
		Label1 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label7 = new Label();
		Combo_TAUX_TVA = new ComboBox();
		Button5 = new Button();
		Combo_UNITE = new ComboBox();
		Label30 = new Label();
		Label8 = new Label();
		Button6 = new Button();
		Combo_FAMILLE = new ComboBox();
		Label9 = new Label();
		Button7 = new Button();
		PictureBox2 = new PictureBox();
		Picture_GOOGLE8 = new PictureBox();
		Picture_GOOGLE7 = new PictureBox();
		Picture_GOOGLE6 = new PictureBox();
		Picture_GOOGLE5 = new PictureBox();
		Picture_GOOGLE4 = new PictureBox();
		Picture_GOOGLE3 = new PictureBox();
		Picture_GOOGLE2 = new PictureBox();
		Picture_GOOGLE1 = new PictureBox();
		Panel_INFO = new Panel();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Panel1 = new Panel();
		Button16 = new Button();
		Button_M_SHIFTS = new Button();
		Button11 = new Button();
		Button10 = new Button();
		Button9 = new Button();
		Panel3 = new Panel();
		PictureBox6 = new PictureBox();
		Panel5 = new Panel();
		Button19 = new Button();
		Label19 = new Label();
		Button18 = new Button();
		Label20 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		Button17 = new Button();
		ListBox1 = new ListBox();
		Text_COMPOSITION = new TextBox();
		PictureBox9 = new PictureBox();
		Panel2 = new Panel();
		Button_FIND = new Button();
		Panel_COULEUR = new Panel();
		Picture_COLOR_23 = new PictureBox();
		Picture_COLOR_22 = new PictureBox();
		Picture_COLOR_21 = new PictureBox();
		Picture_COLOR_20 = new PictureBox();
		Picture_COLOR_19 = new PictureBox();
		Picture_COLOR_18 = new PictureBox();
		Picture_COLOR_17 = new PictureBox();
		Picture_COLOR_15 = new PictureBox();
		Picture_COLOR_12 = new PictureBox();
		Picture_COLOR_16 = new PictureBox();
		Picture_COLOR_11 = new PictureBox();
		Picture_COLOR_6 = new PictureBox();
		Picture_COLOR_10 = new PictureBox();
		Picture_COLOR_13 = new PictureBox();
		Picture_COLOR_5 = new PictureBox();
		Picture_COLOR_1 = new PictureBox();
		Picture_COLOR_8 = new PictureBox();
		Picture_COLOR_9 = new PictureBox();
		Picture_COLOR_7 = new PictureBox();
		Picture_COLOR_4 = new PictureBox();
		Picture_COLOR_3 = new PictureBox();
		Picture_COLOR_2 = new PictureBox();
		Picture_GOOGLE12 = new PictureBox();
		Picture_GOOGLE11 = new PictureBox();
		Picture_GOOGLE10 = new PictureBox();
		Picture_GOOGLE9 = new PictureBox();
		Button13 = new Button();
		Label11 = new Label();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		Picture_IMAGE = new PictureBox();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Text_LIEN_PICTURE = new TextBox();
		Text_ID = new TextBox();
		Text_ARTICLE = new TextBox();
		Panel4 = new Panel();
		Label21 = new Label();
		Button20 = new Button();
		Combo_BALANCE = new ComboBox();
		Label22 = new Label();
		PictureBox8 = new PictureBox();
		Button14 = new Button();
		Label15 = new Label();
		Combo_PROMOTION = new ComboBox();
		Label16 = new Label();
		Button8 = new Button();
		Label13 = new Label();
		Label14 = new Label();
		Button12 = new Button();
		Label10 = new Label();
		Combo_TYPE = new ComboBox();
		Label12 = new Label();
		PictureBox7 = new PictureBox();
		PictureBox10 = new PictureBox();
		Check_png = new CheckBox();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)Picture_GOOGLE8).BeginInit();
		((ISupportInitialize)Picture_GOOGLE7).BeginInit();
		((ISupportInitialize)Picture_GOOGLE6).BeginInit();
		((ISupportInitialize)Picture_GOOGLE5).BeginInit();
		((ISupportInitialize)Picture_GOOGLE4).BeginInit();
		((ISupportInitialize)Picture_GOOGLE3).BeginInit();
		((ISupportInitialize)Picture_GOOGLE2).BeginInit();
		((ISupportInitialize)Picture_GOOGLE1).BeginInit();
		((Control)Panel_INFO).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel_COULEUR).SuspendLayout();
		((ISupportInitialize)Picture_COLOR_23).BeginInit();
		((ISupportInitialize)Picture_COLOR_22).BeginInit();
		((ISupportInitialize)Picture_COLOR_21).BeginInit();
		((ISupportInitialize)Picture_COLOR_20).BeginInit();
		((ISupportInitialize)Picture_COLOR_19).BeginInit();
		((ISupportInitialize)Picture_COLOR_18).BeginInit();
		((ISupportInitialize)Picture_COLOR_17).BeginInit();
		((ISupportInitialize)Picture_COLOR_15).BeginInit();
		((ISupportInitialize)Picture_COLOR_12).BeginInit();
		((ISupportInitialize)Picture_COLOR_16).BeginInit();
		((ISupportInitialize)Picture_COLOR_11).BeginInit();
		((ISupportInitialize)Picture_COLOR_6).BeginInit();
		((ISupportInitialize)Picture_COLOR_10).BeginInit();
		((ISupportInitialize)Picture_COLOR_13).BeginInit();
		((ISupportInitialize)Picture_COLOR_5).BeginInit();
		((ISupportInitialize)Picture_COLOR_1).BeginInit();
		((ISupportInitialize)Picture_COLOR_8).BeginInit();
		((ISupportInitialize)Picture_COLOR_9).BeginInit();
		((ISupportInitialize)Picture_COLOR_7).BeginInit();
		((ISupportInitialize)Picture_COLOR_4).BeginInit();
		((ISupportInitialize)Picture_COLOR_3).BeginInit();
		((ISupportInitialize)Picture_COLOR_2).BeginInit();
		((ISupportInitialize)Picture_GOOGLE12).BeginInit();
		((ISupportInitialize)Picture_GOOGLE11).BeginInit();
		((ISupportInitialize)Picture_GOOGLE10).BeginInit();
		((ISupportInitialize)Picture_GOOGLE9).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)Picture_IMAGE).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel4).SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label28).BackColor = Color.WhiteSmoke;
		((Control)Label28).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label28).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label28;
		Point location = new Point(7, 37);
		((Control)label).Location = location;
		((Control)Label28).Name = "Label28";
		Label label2 = Label28;
		Size size = new Size(274, 27);
		((Control)label2).Size = size;
		((Control)Label28).TabIndex = 1056;
		Label28.Text = "Famille";
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label32).BackColor = Color.WhiteSmoke;
		((Control)Label32).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label32).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label32;
		location = new Point(7, 254);
		((Control)label3).Location = location;
		((Control)Label32).Name = "Label32";
		Label label4 = Label32;
		size = new Size(274, 27);
		((Control)label4).Size = size;
		((Control)Label32).TabIndex = 1062;
		Label32.Text = "Taux TVA";
		Label32.TextAlign = (ContentAlignment)16;
		((Control)Label37).BackColor = Color.WhiteSmoke;
		((Control)Label37).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label37).ForeColor = Color.FromArgb(64, 64, 64);
		Label label5 = Label37;
		location = new Point(7, 198);
		((Control)label5).Location = location;
		((Control)Label37).Name = "Label37";
		Label label6 = Label37;
		size = new Size(274, 27);
		((Control)label6).Size = size;
		((Control)Label37).TabIndex = 1061;
		Label37.Text = "Printer Duplicata";
		Label37.TextAlign = (ContentAlignment)16;
		((Control)Label24).BackColor = Color.WhiteSmoke;
		((Control)Label24).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.FromArgb(64, 64, 64);
		Label label7 = Label24;
		location = new Point(7, 155);
		((Control)label7).Location = location;
		((Control)Label24).Name = "Label24";
		Label label8 = Label24;
		size = new Size(274, 27);
		((Control)label8).Size = size;
		((Control)Label24).TabIndex = 1059;
		Label24.Text = "Printer";
		Label24.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = Color.WhiteSmoke;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label9 = Label2;
		location = new Point(7, 80);
		((Control)label9).Location = location;
		((Control)Label2).Name = "Label2";
		Label label10 = Label2;
		size = new Size(274, 27);
		((Control)label10).Size = size;
		((Control)Label2).TabIndex = 1058;
		Label2.Text = "Mode Stock";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Combo_PRINTER_DUPLICATA).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_PRINTER_DUPLICATA).FormattingEnabled = true;
		Combo_PRINTER_DUPLICATA.Items.AddRange(new object[8] { "0", "C1", "C2", "C3", "C4", "C5", "C6", "C7" });
		ComboBox combo_PRINTER_DUPLICATA = Combo_PRINTER_DUPLICATA;
		location = new Point(288, 198);
		((Control)combo_PRINTER_DUPLICATA).Location = location;
		((Control)Combo_PRINTER_DUPLICATA).Name = "Combo_PRINTER_DUPLICATA";
		ComboBox combo_PRINTER_DUPLICATA2 = Combo_PRINTER_DUPLICATA;
		size = new Size(103, 29);
		((Control)combo_PRINTER_DUPLICATA2).Size = size;
		((Control)Combo_PRINTER_DUPLICATA).TabIndex = 1064;
		((Control)Combo_PRINTER).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_PRINTER).FormattingEnabled = true;
		Combo_PRINTER.Items.AddRange(new object[8] { "0", "C1", "C2", "C3", "C4", "C5", "C6", "C7" });
		ComboBox combo_PRINTER = Combo_PRINTER;
		location = new Point(288, 155);
		((Control)combo_PRINTER).Location = location;
		((Control)Combo_PRINTER).Name = "Combo_PRINTER";
		ComboBox combo_PRINTER2 = Combo_PRINTER;
		size = new Size(103, 29);
		((Control)combo_PRINTER2).Size = size;
		((Control)Combo_PRINTER).TabIndex = 1063;
		((Control)Label6).BackColor = Color.WhiteSmoke;
		((Control)Label6).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.FromArgb(64, 64, 64);
		Label label11 = Label6;
		location = new Point(41, 7);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(236, 27);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 1065;
		Label6.Text = "Coloriser les images aléatoire";
		Label6.TextAlign = (ContentAlignment)16;
		((ListBox)CheckedListBox1).Font = new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)CheckedListBox1).FormattingEnabled = true;
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(9, 26);
		((Control)checkedListBox).Location = location;
		((Control)CheckedListBox1).Name = "CheckedListBox1";
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(180, 508);
		((Control)checkedListBox2).Size = size;
		((Control)CheckedListBox1).TabIndex = 1066;
		CheckedListBox1.UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox7).AutoSize = true;
		((ButtonBase)CheckBox7).BackColor = Color.White;
		((Control)CheckBox7).Font = new Font("Tahoma", 8f);
		((Control)CheckBox7).ForeColor = Color.Black;
		CheckBox checkBox = CheckBox7;
		location = new Point(12, 7);
		((Control)checkBox).Location = location;
		((Control)CheckBox7).Name = "CheckBox7";
		CheckBox checkBox2 = CheckBox7;
		size = new Size(108, 19);
		((Control)checkBox2).Size = size;
		((Control)CheckBox7).TabIndex = 1067;
		((ButtonBase)CheckBox7).Text = "Sélectionner Tout";
		((ButtonBase)CheckBox7).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox7).UseVisualStyleBackColor = false;
		((ButtonBase)Button15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button15).Cursor = Cursors.Hand;
		((ButtonBase)Button15).FlatStyle = (FlatStyle)0;
		((Control)Button15).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button15).ForeColor = Color.White;
		Button button = Button15;
		location = new Point(394, 155);
		((Control)button).Location = location;
		Button button2 = Button15;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button15).Name = "Button15";
		Button button3 = Button15;
		size = new Size(139, 27);
		((Control)button3).Size = size;
		((Control)Button15).TabIndex = 1068;
		((ButtonBase)Button15).Text = "Valider";
		((ButtonBase)Button15).UseVisualStyleBackColor = false;
		((ButtonBase)Button1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button1).ForeColor = Color.White;
		Button button4 = Button1;
		location = new Point(394, 198);
		((Control)button4).Location = location;
		Button button5 = Button1;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button1).Name = "Button1";
		Button button6 = Button1;
		size = new Size(139, 27);
		((Control)button6).Size = size;
		((Control)Button1).TabIndex = 1069;
		((ButtonBase)Button1).Text = "Valider";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((ButtonBase)Button2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button2).ForeColor = Color.White;
		Button button7 = Button2;
		location = new Point(389, 7);
		((Control)button7).Location = location;
		Button button8 = Button2;
		margin = new Padding(0);
		((Control)button8).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button9 = Button2;
		size = new Size(140, 27);
		((Control)button9).Size = size;
		((Control)Button2).TabIndex = 1070;
		((ButtonBase)Button2).Text = "Valider";
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		((ButtonBase)Button3).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button3).ForeColor = Color.White;
		Button button10 = Button3;
		location = new Point(394, 80);
		((Control)button10).Location = location;
		Button button11 = Button3;
		margin = new Padding(0);
		((Control)button11).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button12 = Button3;
		size = new Size(139, 27);
		((Control)button12).Size = size;
		((Control)Button3).TabIndex = 1072;
		((ButtonBase)Button3).Text = "Valider";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)Combo_MODE_STOCK).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_MODE_STOCK).FormattingEnabled = true;
		Combo_MODE_STOCK.Items.AddRange(new object[4] { "0", "FINI", "NON FINI", "MATIERE PREMIERE" });
		ComboBox combo_MODE_STOCK = Combo_MODE_STOCK;
		location = new Point(288, 80);
		((Control)combo_MODE_STOCK).Location = location;
		((Control)Combo_MODE_STOCK).Name = "Combo_MODE_STOCK";
		ComboBox combo_MODE_STOCK2 = Combo_MODE_STOCK;
		size = new Size(103, 29);
		((Control)combo_MODE_STOCK2).Size = size;
		((Control)Combo_MODE_STOCK).TabIndex = 1071;
		((Control)Label46).BackColor = Color.WhiteSmoke;
		((Control)Label46).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label46).ForeColor = Color.FromArgb(64, 64, 64);
		Label label13 = Label46;
		location = new Point(7, 166);
		((Control)label13).Location = location;
		((Control)Label46).Name = "Label46";
		Label label14 = Label46;
		size = new Size(274, 27);
		((Control)label14).Size = size;
		((Control)Label46).TabIndex = 1073;
		Label46.Text = "Fenêtre Pesage";
		Label46.TextAlign = (ContentAlignment)16;
		((Control)Combo_FENETRE_PESAGE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_FENETRE_PESAGE).FormattingEnabled = true;
		Combo_FENETRE_PESAGE.Items.AddRange(new object[2] { "", "OUI" });
		ComboBox combo_FENETRE_PESAGE = Combo_FENETRE_PESAGE;
		location = new Point(288, 166);
		((Control)combo_FENETRE_PESAGE).Location = location;
		((Control)Combo_FENETRE_PESAGE).Name = "Combo_FENETRE_PESAGE";
		ComboBox combo_FENETRE_PESAGE2 = Combo_FENETRE_PESAGE;
		size = new Size(103, 29);
		((Control)combo_FENETRE_PESAGE2).Size = size;
		((Control)Combo_FENETRE_PESAGE).TabIndex = 1075;
		((ButtonBase)Button4).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button4).Cursor = Cursors.Hand;
		((ButtonBase)Button4).FlatStyle = (FlatStyle)0;
		((Control)Button4).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button4).ForeColor = Color.White;
		Button button13 = Button4;
		location = new Point(394, 166);
		((Control)button13).Location = location;
		Button button14 = Button4;
		margin = new Padding(0);
		((Control)button14).Margin = margin;
		((Control)Button4).Name = "Button4";
		Button button15 = Button4;
		size = new Size(139, 27);
		((Control)button15).Size = size;
		((Control)Button4).TabIndex = 1076;
		((ButtonBase)Button4).Text = "Valider";
		((ButtonBase)Button4).UseVisualStyleBackColor = false;
		((Control)Label1).BackColor = Color.WhiteSmoke;
		((Control)Label1).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.FromArgb(64, 64, 64);
		Label label15 = Label1;
		location = new Point(190, 155);
		((Control)label15).Location = location;
		((Control)Label1).Name = "Label1";
		Label label16 = Label1;
		size = new Size(92, 27);
		((Control)label16).Size = size;
		((Control)Label1).TabIndex = 1077;
		Label1.Text = "Changer au";
		Label1.TextAlign = (ContentAlignment)64;
		((Control)Label3).BackColor = Color.WhiteSmoke;
		((Control)Label3).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.FromArgb(64, 64, 64);
		Label label17 = Label3;
		location = new Point(190, 198);
		((Control)label17).Location = location;
		((Control)Label3).Name = "Label3";
		Label label18 = Label3;
		size = new Size(92, 27);
		((Control)label18).Size = size;
		((Control)Label3).TabIndex = 1078;
		Label3.Text = "Changer au";
		Label3.TextAlign = (ContentAlignment)64;
		((Control)Label4).BackColor = Color.WhiteSmoke;
		((Control)Label4).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.FromArgb(64, 64, 64);
		Label label19 = Label4;
		location = new Point(190, 80);
		((Control)label19).Location = location;
		((Control)Label4).Name = "Label4";
		Label label20 = Label4;
		size = new Size(92, 27);
		((Control)label20).Size = size;
		((Control)Label4).TabIndex = 1079;
		Label4.Text = "Changer au";
		Label4.TextAlign = (ContentAlignment)64;
		((Control)Label5).BackColor = Color.WhiteSmoke;
		((Control)Label5).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.FromArgb(64, 64, 64);
		Label label21 = Label5;
		location = new Point(190, 166);
		((Control)label21).Location = location;
		((Control)Label5).Name = "Label5";
		Label label22 = Label5;
		size = new Size(92, 27);
		((Control)label22).Size = size;
		((Control)Label5).TabIndex = 1080;
		Label5.Text = "Changer au";
		Label5.TextAlign = (ContentAlignment)64;
		((Control)Label7).BackColor = Color.WhiteSmoke;
		((Control)Label7).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.FromArgb(64, 64, 64);
		Label label23 = Label7;
		location = new Point(190, 254);
		((Control)label23).Location = location;
		((Control)Label7).Name = "Label7";
		Label label24 = Label7;
		size = new Size(92, 27);
		((Control)label24).Size = size;
		((Control)Label7).TabIndex = 1081;
		Label7.Text = "Changer au";
		Label7.TextAlign = (ContentAlignment)64;
		Combo_TAUX_TVA.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_TAUX_TVA.AutoCompleteSource = (AutoCompleteSource)256;
		((Control)Combo_TAUX_TVA).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_TAUX_TVA).FormattingEnabled = true;
		Combo_TAUX_TVA.IntegralHeight = false;
		Combo_TAUX_TVA.Items.AddRange(new object[5] { "0", "7", "10", "14", "20" });
		ComboBox combo_TAUX_TVA = Combo_TAUX_TVA;
		location = new Point(288, 254);
		((Control)combo_TAUX_TVA).Location = location;
		Combo_TAUX_TVA.MaxDropDownItems = 12;
		((Control)Combo_TAUX_TVA).Name = "Combo_TAUX_TVA";
		ComboBox combo_TAUX_TVA2 = Combo_TAUX_TVA;
		size = new Size(103, 29);
		((Control)combo_TAUX_TVA2).Size = size;
		((Control)Combo_TAUX_TVA).TabIndex = 1082;
		((ButtonBase)Button5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).FlatStyle = (FlatStyle)0;
		((Control)Button5).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button5).ForeColor = Color.White;
		Button button16 = Button5;
		location = new Point(394, 254);
		((Control)button16).Location = location;
		Button button17 = Button5;
		margin = new Padding(0);
		((Control)button17).Margin = margin;
		((Control)Button5).Name = "Button5";
		Button button18 = Button5;
		size = new Size(139, 27);
		((Control)button18).Size = size;
		((Control)Button5).TabIndex = 1083;
		((ButtonBase)Button5).Text = "Valider";
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		((Control)Combo_UNITE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_UNITE).FormattingEnabled = true;
		Combo_UNITE.Items.AddRange(new object[6] { "Unité", "Gramme", "Kg", "Tonne", "Mètre", "Litre" });
		ComboBox combo_UNITE = Combo_UNITE;
		location = new Point(288, 123);
		((Control)combo_UNITE).Location = location;
		((Control)Combo_UNITE).Name = "Combo_UNITE";
		ComboBox combo_UNITE2 = Combo_UNITE;
		size = new Size(103, 29);
		((Control)combo_UNITE2).Size = size;
		((Control)Combo_UNITE).TabIndex = 1085;
		((Control)Label30).BackColor = Color.WhiteSmoke;
		((Control)Label30).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label30).ForeColor = Color.FromArgb(64, 64, 64);
		Label label25 = Label30;
		location = new Point(7, 123);
		((Control)label25).Location = location;
		((Control)Label30).Name = "Label30";
		Label label26 = Label30;
		size = new Size(274, 27);
		((Control)label26).Size = size;
		((Control)Label30).TabIndex = 1084;
		Label30.Text = "Unité";
		Label30.TextAlign = (ContentAlignment)16;
		((Control)Label8).BackColor = Color.WhiteSmoke;
		((Control)Label8).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.FromArgb(64, 64, 64);
		Label label27 = Label8;
		location = new Point(190, 123);
		((Control)label27).Location = location;
		((Control)Label8).Name = "Label8";
		Label label28 = Label8;
		size = new Size(92, 27);
		((Control)label28).Size = size;
		((Control)Label8).TabIndex = 1086;
		Label8.Text = "Changer au";
		Label8.TextAlign = (ContentAlignment)64;
		((ButtonBase)Button6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatStyle = (FlatStyle)0;
		((Control)Button6).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button6).ForeColor = Color.White;
		Button button19 = Button6;
		location = new Point(394, 123);
		((Control)button19).Location = location;
		Button button20 = Button6;
		margin = new Padding(0);
		((Control)button20).Margin = margin;
		((Control)Button6).Name = "Button6";
		Button button21 = Button6;
		size = new Size(139, 27);
		((Control)button21).Size = size;
		((Control)Button6).TabIndex = 1087;
		((ButtonBase)Button6).Text = "Valider";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		Combo_FAMILLE.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_FAMILLE.AutoCompleteSource = (AutoCompleteSource)256;
		((Control)Combo_FAMILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_FAMILLE).FormattingEnabled = true;
		Combo_FAMILLE.IntegralHeight = false;
		Combo_FAMILLE.Items.AddRange(new object[5] { "0", "7", "10", "14", "20" });
		ComboBox combo_FAMILLE = Combo_FAMILLE;
		location = new Point(288, 37);
		((Control)combo_FAMILLE).Location = location;
		Combo_FAMILLE.MaxDropDownItems = 12;
		((Control)Combo_FAMILLE).Name = "Combo_FAMILLE";
		ComboBox combo_FAMILLE2 = Combo_FAMILLE;
		size = new Size(103, 29);
		((Control)combo_FAMILLE2).Size = size;
		((Control)Combo_FAMILLE).TabIndex = 1088;
		((Control)Label9).BackColor = Color.WhiteSmoke;
		((Control)Label9).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.FromArgb(64, 64, 64);
		Label label29 = Label9;
		location = new Point(190, 37);
		((Control)label29).Location = location;
		((Control)Label9).Name = "Label9";
		Label label30 = Label9;
		size = new Size(92, 27);
		((Control)label30).Size = size;
		((Control)Label9).TabIndex = 1089;
		Label9.Text = "Changer au";
		Label9.TextAlign = (ContentAlignment)64;
		((ButtonBase)Button7).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button7).Cursor = Cursors.Hand;
		((ButtonBase)Button7).FlatStyle = (FlatStyle)0;
		((Control)Button7).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button7).ForeColor = Color.White;
		Button button22 = Button7;
		location = new Point(394, 37);
		((Control)button22).Location = location;
		Button button23 = Button7;
		margin = new Padding(0);
		((Control)button23).Margin = margin;
		((Control)Button7).Name = "Button7";
		Button button24 = Button7;
		size = new Size(139, 27);
		((Control)button24).Size = size;
		((Control)Button7).TabIndex = 1090;
		((ButtonBase)Button7).Text = "Valider";
		((ButtonBase)Button7).UseVisualStyleBackColor = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(283, 7);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(103, 27);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 1091;
		PictureBox2.TabStop = false;
		Picture_GOOGLE8.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE8).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE = Picture_GOOGLE8;
		location = new Point(405, 285);
		((Control)picture_GOOGLE).Location = location;
		((Control)Picture_GOOGLE8).Name = "Picture_GOOGLE8";
		PictureBox picture_GOOGLE2 = Picture_GOOGLE8;
		size = new Size(127, 80);
		((Control)picture_GOOGLE2).Size = size;
		Picture_GOOGLE8.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE8.TabIndex = 1100;
		Picture_GOOGLE8.TabStop = false;
		Picture_GOOGLE7.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE7).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE3 = Picture_GOOGLE7;
		location = new Point(272, 285);
		((Control)picture_GOOGLE3).Location = location;
		((Control)Picture_GOOGLE7).Name = "Picture_GOOGLE7";
		PictureBox picture_GOOGLE4 = Picture_GOOGLE7;
		size = new Size(127, 80);
		((Control)picture_GOOGLE4).Size = size;
		Picture_GOOGLE7.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE7.TabIndex = 1099;
		Picture_GOOGLE7.TabStop = false;
		Picture_GOOGLE6.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE6).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE5 = Picture_GOOGLE6;
		location = new Point(139, 285);
		((Control)picture_GOOGLE5).Location = location;
		((Control)Picture_GOOGLE6).Name = "Picture_GOOGLE6";
		PictureBox picture_GOOGLE6 = Picture_GOOGLE6;
		size = new Size(127, 80);
		((Control)picture_GOOGLE6).Size = size;
		Picture_GOOGLE6.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE6.TabIndex = 1098;
		Picture_GOOGLE6.TabStop = false;
		Picture_GOOGLE5.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE5).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE7 = Picture_GOOGLE5;
		location = new Point(6, 285);
		((Control)picture_GOOGLE7).Location = location;
		((Control)Picture_GOOGLE5).Name = "Picture_GOOGLE5";
		PictureBox picture_GOOGLE8 = Picture_GOOGLE5;
		size = new Size(127, 80);
		((Control)picture_GOOGLE8).Size = size;
		Picture_GOOGLE5.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE5.TabIndex = 1097;
		Picture_GOOGLE5.TabStop = false;
		Picture_GOOGLE4.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE4).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE9 = Picture_GOOGLE4;
		location = new Point(405, 203);
		((Control)picture_GOOGLE9).Location = location;
		((Control)Picture_GOOGLE4).Name = "Picture_GOOGLE4";
		PictureBox picture_GOOGLE10 = Picture_GOOGLE4;
		size = new Size(127, 80);
		((Control)picture_GOOGLE10).Size = size;
		Picture_GOOGLE4.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE4.TabIndex = 1096;
		Picture_GOOGLE4.TabStop = false;
		Picture_GOOGLE3.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE3).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE11 = Picture_GOOGLE3;
		location = new Point(272, 203);
		((Control)picture_GOOGLE11).Location = location;
		((Control)Picture_GOOGLE3).Name = "Picture_GOOGLE3";
		PictureBox picture_GOOGLE12 = Picture_GOOGLE3;
		size = new Size(127, 80);
		((Control)picture_GOOGLE12).Size = size;
		Picture_GOOGLE3.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE3.TabIndex = 1095;
		Picture_GOOGLE3.TabStop = false;
		Picture_GOOGLE2.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE2).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE13 = Picture_GOOGLE2;
		location = new Point(139, 203);
		((Control)picture_GOOGLE13).Location = location;
		((Control)Picture_GOOGLE2).Name = "Picture_GOOGLE2";
		PictureBox picture_GOOGLE14 = Picture_GOOGLE2;
		size = new Size(127, 80);
		((Control)picture_GOOGLE14).Size = size;
		Picture_GOOGLE2.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE2.TabIndex = 1094;
		Picture_GOOGLE2.TabStop = false;
		Picture_GOOGLE1.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE1).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE15 = Picture_GOOGLE1;
		location = new Point(6, 203);
		((Control)picture_GOOGLE15).Location = location;
		((Control)Picture_GOOGLE1).Name = "Picture_GOOGLE1";
		PictureBox picture_GOOGLE16 = Picture_GOOGLE1;
		size = new Size(127, 80);
		((Control)picture_GOOGLE16).Size = size;
		Picture_GOOGLE1.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE1.TabIndex = 1093;
		Picture_GOOGLE1.TabStop = false;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)CheckedListBox1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)CheckBox7);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel2);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel4);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel3);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel5);
		Panel panel_INFO = Panel_INFO;
		location = new Point(176, 10);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		size = new Size(751, 542);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 1094;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 536);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(741, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 861;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 4);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 536);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 860;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(745, 4);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 536);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 859;
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
		size = new Size(749, 4);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 857;
		Label_TOP.TextAlign = (ContentAlignment)16;
		((Control)Panel1).BackColor = Color.FromArgb(249, 249, 249);
		((Control)Panel1).Controls.Add((Control)(object)Button16);
		((Control)Panel1).Controls.Add((Control)(object)Button_M_SHIFTS);
		((Control)Panel1).Controls.Add((Control)(object)Button11);
		((Control)Panel1).Controls.Add((Control)(object)Button10);
		((Control)Panel1).Controls.Add((Control)(object)Button9);
		Panel panel = Panel1;
		location = new Point(195, 26);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(541, 508);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1093;
		((Control)Button16).Cursor = Cursors.Hand;
		((Control)Button16).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button16).ImageAlign = (ContentAlignment)16;
		Button button25 = Button16;
		location = new Point(70, 266);
		((Control)button25).Location = location;
		((Control)Button16).Name = "Button16";
		Button button26 = Button16;
		size = new Size(401, 69);
		((Control)button26).Size = size;
		((Control)Button16).TabIndex = 1046;
		((ButtonBase)Button16).Text = "Traitement des Compositions";
		((ButtonBase)Button16).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button16).UseVisualStyleBackColor = true;
		((Control)Button_M_SHIFTS).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_M_SHIFTS).BackColor = Color.Black;
		((Control)Button_M_SHIFTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_M_SHIFTS).FlatAppearance.MouseOverBackColor = Color.DimGray;
		((ButtonBase)Button_M_SHIFTS).FlatStyle = (FlatStyle)0;
		((Control)Button_M_SHIFTS).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Button_M_SHIFTS).ForeColor = Color.White;
		((ButtonBase)Button_M_SHIFTS).Image = (Image)componentResourceManager.GetObject("Button_M_SHIFTS.Image");
		((ButtonBase)Button_M_SHIFTS).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_M_SHIFTS).ImeMode = (ImeMode)0;
		Button button_M_SHIFTS = Button_M_SHIFTS;
		location = new Point(10, 460);
		((Control)button_M_SHIFTS).Location = location;
		Button button_M_SHIFTS2 = Button_M_SHIFTS;
		margin = new Padding(0);
		((Control)button_M_SHIFTS2).Margin = margin;
		((Control)Button_M_SHIFTS).Name = "Button_M_SHIFTS";
		Button button_M_SHIFTS3 = Button_M_SHIFTS;
		size = new Size(102, 40);
		((Control)button_M_SHIFTS3).Size = size;
		((Control)Button_M_SHIFTS).TabIndex = 1045;
		((ButtonBase)Button_M_SHIFTS).Text = "   Import";
		((ButtonBase)Button_M_SHIFTS).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_M_SHIFTS).UseVisualStyleBackColor = false;
		((Control)Button_M_SHIFTS).Visible = false;
		((Control)Button11).Cursor = Cursors.Hand;
		((Control)Button11).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button27 = Button11;
		location = new Point(70, 359);
		((Control)button27).Location = location;
		((Control)Button11).Name = "Button11";
		Button button28 = Button11;
		size = new Size(401, 69);
		((Control)button28).Size = size;
		((Control)Button11).TabIndex = 2;
		((ButtonBase)Button11).Text = "Autre";
		((ButtonBase)Button11).UseVisualStyleBackColor = true;
		((Control)Button10).Cursor = Cursors.Hand;
		((Control)Button10).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button10).Image = (Image)componentResourceManager.GetObject("Button10.Image");
		((ButtonBase)Button10).ImageAlign = (ContentAlignment)16;
		Button button29 = Button10;
		location = new Point(70, 173);
		((Control)button29).Location = location;
		((Control)Button10).Name = "Button10";
		Button button30 = Button10;
		size = new Size(401, 69);
		((Control)button30).Size = size;
		((Control)Button10).TabIndex = 1;
		((ButtonBase)Button10).Text = "Traitement des imprimantes";
		((ButtonBase)Button10).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button10).UseVisualStyleBackColor = true;
		((Control)Button9).Cursor = Cursors.Hand;
		((Control)Button9).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button9).Image = (Image)componentResourceManager.GetObject("Button9.Image");
		((ButtonBase)Button9).ImageAlign = (ContentAlignment)16;
		Button button31 = Button9;
		location = new Point(70, 80);
		((Control)button31).Location = location;
		((Control)Button9).Name = "Button9";
		Button button32 = Button9;
		size = new Size(401, 69);
		((Control)button32).Size = size;
		((Control)Button9).TabIndex = 0;
		((ButtonBase)Button9).Text = "Traitement d'images";
		((ButtonBase)Button9).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button9).UseVisualStyleBackColor = true;
		((Control)Panel3).BackColor = Color.White;
		((Control)Panel3).Controls.Add((Control)(object)Label3);
		((Control)Panel3).Controls.Add((Control)(object)Combo_PRINTER);
		((Control)Panel3).Controls.Add((Control)(object)Label1);
		((Control)Panel3).Controls.Add((Control)(object)Combo_PRINTER_DUPLICATA);
		((Control)Panel3).Controls.Add((Control)(object)Button1);
		((Control)Panel3).Controls.Add((Control)(object)Button15);
		((Control)Panel3).Controls.Add((Control)(object)Label37);
		((Control)Panel3).Controls.Add((Control)(object)Label24);
		((Control)Panel3).Controls.Add((Control)(object)PictureBox6);
		Panel panel3 = Panel3;
		location = new Point(195, 26);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(541, 508);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 1094;
		((Control)PictureBox6).Cursor = Cursors.Hand;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox3 = PictureBox6;
		location = new Point(0, 0);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox4 = PictureBox6;
		size = new Size(32, 32);
		((Control)pictureBox4).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 1110;
		PictureBox6.TabStop = false;
		((Control)Panel5).BackColor = Color.White;
		((Control)Panel5).Controls.Add((Control)(object)Button19);
		((Control)Panel5).Controls.Add((Control)(object)Label19);
		((Control)Panel5).Controls.Add((Control)(object)Button18);
		((Control)Panel5).Controls.Add((Control)(object)Label20);
		((Control)Panel5).Controls.Add((Control)(object)Label17);
		((Control)Panel5).Controls.Add((Control)(object)Label18);
		((Control)Panel5).Controls.Add((Control)(object)Button17);
		((Control)Panel5).Controls.Add((Control)(object)ListBox1);
		((Control)Panel5).Controls.Add((Control)(object)Text_COMPOSITION);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox9);
		Panel panel5 = Panel5;
		location = new Point(195, 26);
		((Control)panel5).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel6 = Panel5;
		size = new Size(541, 508);
		((Control)panel6).Size = size;
		((Control)Panel5).TabIndex = 1096;
		((ButtonBase)Button19).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button19).Cursor = Cursors.Hand;
		((ButtonBase)Button19).FlatStyle = (FlatStyle)0;
		((Control)Button19).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button19).ForeColor = Color.White;
		Button button33 = Button19;
		location = new Point(398, 359);
		((Control)button33).Location = location;
		Button button34 = Button19;
		margin = new Padding(0);
		((Control)button34).Margin = margin;
		((Control)Button19).Name = "Button19";
		Button button35 = Button19;
		size = new Size(139, 27);
		((Control)button35).Size = size;
		((Control)Button19).TabIndex = 1130;
		((ButtonBase)Button19).Text = "Valider";
		((ButtonBase)Button19).UseVisualStyleBackColor = false;
		((Control)Label19).BackColor = Color.WhiteSmoke;
		((Control)Label19).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label19).ForeColor = Color.FromArgb(64, 64, 64);
		Label label31 = Label19;
		location = new Point(3, 359);
		((Control)label31).Location = location;
		((Control)Label19).Name = "Label19";
		Label label32 = Label19;
		size = new Size(386, 27);
		((Control)label32).Size = size;
		((Control)Label19).TabIndex = 1129;
		Label19.Text = "Écraser l'ancien et Remplacer";
		Label19.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button18).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button18).Cursor = Cursors.Hand;
		((ButtonBase)Button18).FlatStyle = (FlatStyle)0;
		((Control)Button18).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button18).ForeColor = Color.White;
		Button button36 = Button18;
		location = new Point(398, 313);
		((Control)button36).Location = location;
		Button button37 = Button18;
		margin = new Padding(0);
		((Control)button37).Margin = margin;
		((Control)Button18).Name = "Button18";
		Button button38 = Button18;
		size = new Size(139, 27);
		((Control)button38).Size = size;
		((Control)Button18).TabIndex = 1128;
		((ButtonBase)Button18).Text = "Valider";
		((ButtonBase)Button18).UseVisualStyleBackColor = false;
		((Control)Label20).BackColor = Color.WhiteSmoke;
		((Control)Label20).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label20).ForeColor = Color.FromArgb(64, 64, 64);
		Label label33 = Label20;
		location = new Point(3, 313);
		((Control)label33).Location = location;
		((Control)Label20).Name = "Label20";
		Label label34 = Label20;
		size = new Size(386, 27);
		((Control)label34).Size = size;
		((Control)Label20).TabIndex = 1125;
		Label20.Text = "Ajouter à l'ancien";
		Label20.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = SystemColors.Control;
		((Control)Label17).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label17).ForeColor = Color.Black;
		Label17.ImeMode = (ImeMode)0;
		Label label35 = Label17;
		location = new Point(253, 36);
		((Control)label35).Location = location;
		((Control)Label17).Name = "Label17";
		Label label36 = Label17;
		size = new Size(284, 26);
		((Control)label36).Size = size;
		((Control)Label17).TabIndex = 1115;
		Label17.Text = "Vos Pages Composition";
		Label17.TextAlign = (ContentAlignment)16;
		((Control)Label18).BackColor = SystemColors.Control;
		((Control)Label18).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.Black;
		Label18.ImeMode = (ImeMode)0;
		Label label37 = Label18;
		location = new Point(3, 38);
		((Control)label37).Location = location;
		((Control)Label18).Name = "Label18";
		Label label38 = Label18;
		size = new Size(174, 26);
		((Control)label38).Size = size;
		((Control)Label18).TabIndex = 1112;
		Label18.Text = "Les Pages";
		Label18.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button17).Image = (Image)componentResourceManager.GetObject("Button17.Image");
		((ButtonBase)Button17).ImeMode = (ImeMode)0;
		Button button39 = Button17;
		location = new Point(183, 158);
		((Control)button39).Location = location;
		((Control)Button17).Name = "Button17";
		Button button40 = Button17;
		size = new Size(64, 43);
		((Control)button40).Size = size;
		((Control)Button17).TabIndex = 1114;
		((ButtonBase)Button17).UseVisualStyleBackColor = true;
		ListBox1.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox1.ItemHeight = 20;
		ListBox listBox = ListBox1;
		location = new Point(3, 70);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(174, 204);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 1113;
		((TextBoxBase)Text_COMPOSITION).BackColor = Color.White;
		((TextBoxBase)Text_COMPOSITION).BorderStyle = (BorderStyle)1;
		((Control)Text_COMPOSITION).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		TextBox text_COMPOSITION = Text_COMPOSITION;
		location = new Point(253, 68);
		((Control)text_COMPOSITION).Location = location;
		Text_COMPOSITION.Multiline = true;
		((Control)Text_COMPOSITION).Name = "Text_COMPOSITION";
		Text_COMPOSITION.ScrollBars = (ScrollBars)3;
		TextBox text_COMPOSITION2 = Text_COMPOSITION;
		size = new Size(284, 233);
		((Control)text_COMPOSITION2).Size = size;
		((Control)Text_COMPOSITION).TabIndex = 1111;
		((Control)PictureBox9).Cursor = Cursors.Hand;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox5 = PictureBox9;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox6 = PictureBox9;
		size = new Size(32, 32);
		((Control)pictureBox6).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 1110;
		PictureBox9.TabStop = false;
		((Control)Panel2).BackColor = Color.White;
		((Control)Panel2).Controls.Add((Control)(object)Check_png);
		((Control)Panel2).Controls.Add((Control)(object)Button_FIND);
		((Control)Panel2).Controls.Add((Control)(object)Panel_COULEUR);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE12);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE11);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE10);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE9);
		((Control)Panel2).Controls.Add((Control)(object)Button13);
		((Control)Panel2).Controls.Add((Control)(object)Label11);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel2).Controls.Add((Control)(object)Label6);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE8);
		((Control)Panel2).Controls.Add((Control)(object)Button2);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE7);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE6);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE5);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE1);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE4);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE2);
		((Control)Panel2).Controls.Add((Control)(object)Picture_GOOGLE3);
		((Control)Panel2).Controls.Add((Control)(object)Picture_IMAGE);
		((Control)Panel2).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel2).Controls.Add((Control)(object)Text_LIEN_PICTURE);
		((Control)Panel2).Controls.Add((Control)(object)Text_ID);
		((Control)Panel2).Controls.Add((Control)(object)Text_ARTICLE);
		Panel panel7 = Panel2;
		location = new Point(195, 26);
		((Control)panel7).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel8 = Panel2;
		size = new Size(541, 508);
		((Control)panel8).Size = size;
		((Control)Panel2).TabIndex = 1094;
		((Control)Button_FIND).Cursor = Cursors.Hand;
		((ButtonBase)Button_FIND).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_FIND).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button_FIND).Image = (Image)componentResourceManager.GetObject("Button_FIND.Image");
		Button button_FIND = Button_FIND;
		location = new Point(373, 90);
		((Control)button_FIND).Location = location;
		((Control)Button_FIND).Name = "Button_FIND";
		Button button_FIND2 = Button_FIND;
		size = new Size(20, 22);
		((Control)button_FIND2).Size = size;
		((Control)Button_FIND).TabIndex = 1119;
		((ButtonBase)Button_FIND).UseVisualStyleBackColor = true;
		Panel_COULEUR.BorderStyle = (BorderStyle)1;
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_23);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_22);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_21);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_20);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_19);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_18);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_17);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_15);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_12);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_16);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_11);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_6);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_10);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_13);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_5);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_1);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_8);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_9);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_7);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_4);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_3);
		((Control)Panel_COULEUR).Controls.Add((Control)(object)Picture_COLOR_2);
		Panel panel_COULEUR = Panel_COULEUR;
		location = new Point(6, 453);
		((Control)panel_COULEUR).Location = location;
		((Control)Panel_COULEUR).Name = "Panel_COULEUR";
		Panel panel_COULEUR2 = Panel_COULEUR;
		size = new Size(526, 71);
		((Control)panel_COULEUR2).Size = size;
		((Control)Panel_COULEUR).TabIndex = 1117;
		((Control)Picture_COLOR_23).BackColor = Color.Black;
		PictureBox picture_COLOR_ = Picture_COLOR_23;
		location = new Point(379, 31);
		((Control)picture_COLOR_).Location = location;
		((Control)Picture_COLOR_23).Name = "Picture_COLOR_23";
		PictureBox picture_COLOR_2 = Picture_COLOR_23;
		size = new Size(47, 22);
		((Control)picture_COLOR_2).Size = size;
		Picture_COLOR_23.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_23.TabIndex = 778;
		Picture_COLOR_23.TabStop = false;
		((Control)Picture_COLOR_22).BackColor = Color.LightGray;
		PictureBox picture_COLOR_3 = Picture_COLOR_22;
		location = new Point(332, 31);
		((Control)picture_COLOR_3).Location = location;
		((Control)Picture_COLOR_22).Name = "Picture_COLOR_22";
		PictureBox picture_COLOR_4 = Picture_COLOR_22;
		size = new Size(47, 22);
		((Control)picture_COLOR_4).Size = size;
		Picture_COLOR_22.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_22.TabIndex = 777;
		Picture_COLOR_22.TabStop = false;
		((Control)Picture_COLOR_21).BackColor = Color.Crimson;
		PictureBox picture_COLOR_5 = Picture_COLOR_21;
		location = new Point(285, 31);
		((Control)picture_COLOR_5).Location = location;
		((Control)Picture_COLOR_21).Name = "Picture_COLOR_21";
		PictureBox picture_COLOR_6 = Picture_COLOR_21;
		size = new Size(47, 22);
		((Control)picture_COLOR_6).Size = size;
		Picture_COLOR_21.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_21.TabIndex = 776;
		Picture_COLOR_21.TabStop = false;
		((Control)Picture_COLOR_20).BackColor = Color.MediumVioletRed;
		PictureBox picture_COLOR_7 = Picture_COLOR_20;
		location = new Point(50, 31);
		((Control)picture_COLOR_7).Location = location;
		((Control)Picture_COLOR_20).Name = "Picture_COLOR_20";
		PictureBox picture_COLOR_8 = Picture_COLOR_20;
		size = new Size(47, 22);
		((Control)picture_COLOR_8).Size = size;
		Picture_COLOR_20.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_20.TabIndex = 775;
		Picture_COLOR_20.TabStop = false;
		((Control)Picture_COLOR_19).BackColor = Color.DarkTurquoise;
		PictureBox picture_COLOR_9 = Picture_COLOR_19;
		location = new Point(3, 31);
		((Control)picture_COLOR_9).Location = location;
		((Control)Picture_COLOR_19).Name = "Picture_COLOR_19";
		PictureBox picture_COLOR_10 = Picture_COLOR_19;
		size = new Size(47, 22);
		((Control)picture_COLOR_10).Size = size;
		Picture_COLOR_19.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_19.TabIndex = 774;
		Picture_COLOR_19.TabStop = false;
		((Control)Picture_COLOR_18).BackColor = Color.Aquamarine;
		PictureBox picture_COLOR_11 = Picture_COLOR_18;
		location = new Point(238, 3);
		((Control)picture_COLOR_11).Location = location;
		((Control)Picture_COLOR_18).Name = "Picture_COLOR_18";
		PictureBox picture_COLOR_12 = Picture_COLOR_18;
		size = new Size(47, 22);
		((Control)picture_COLOR_12).Size = size;
		Picture_COLOR_18.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_18.TabIndex = 773;
		Picture_COLOR_18.TabStop = false;
		((Control)Picture_COLOR_17).BackColor = Color.MediumTurquoise;
		PictureBox picture_COLOR_13 = Picture_COLOR_17;
		location = new Point(191, 3);
		((Control)picture_COLOR_13).Location = location;
		((Control)Picture_COLOR_17).Name = "Picture_COLOR_17";
		PictureBox picture_COLOR_14 = Picture_COLOR_17;
		size = new Size(47, 22);
		((Control)picture_COLOR_14).Size = size;
		Picture_COLOR_17.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_17.TabIndex = 772;
		Picture_COLOR_17.TabStop = false;
		((Control)Picture_COLOR_15).BackColor = Color.Chartreuse;
		PictureBox picture_COLOR_15 = Picture_COLOR_15;
		location = new Point(426, 31);
		((Control)picture_COLOR_15).Location = location;
		((Control)Picture_COLOR_15).Name = "Picture_COLOR_15";
		PictureBox picture_COLOR_16 = Picture_COLOR_15;
		size = new Size(47, 22);
		((Control)picture_COLOR_16).Size = size;
		Picture_COLOR_15.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_15.TabIndex = 770;
		Picture_COLOR_15.TabStop = false;
		((Control)Picture_COLOR_12).BackColor = Color.Orange;
		PictureBox picture_COLOR_17 = Picture_COLOR_12;
		location = new Point(238, 31);
		((Control)picture_COLOR_17).Location = location;
		((Control)Picture_COLOR_12).Name = "Picture_COLOR_12";
		PictureBox picture_COLOR_18 = Picture_COLOR_12;
		size = new Size(47, 22);
		((Control)picture_COLOR_18).Size = size;
		Picture_COLOR_12.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_12.TabIndex = 767;
		Picture_COLOR_12.TabStop = false;
		((Control)Picture_COLOR_16).BackColor = Color.MediumOrchid;
		PictureBox picture_COLOR_19 = Picture_COLOR_16;
		location = new Point(473, 3);
		((Control)picture_COLOR_19).Location = location;
		((Control)Picture_COLOR_16).Name = "Picture_COLOR_16";
		PictureBox picture_COLOR_20 = Picture_COLOR_16;
		size = new Size(47, 22);
		((Control)picture_COLOR_20).Size = size;
		Picture_COLOR_16.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_16.TabIndex = 771;
		Picture_COLOR_16.TabStop = false;
		((Control)Picture_COLOR_11).BackColor = Color.Fuchsia;
		PictureBox picture_COLOR_21 = Picture_COLOR_11;
		location = new Point(191, 31);
		((Control)picture_COLOR_21).Location = location;
		((Control)Picture_COLOR_11).Name = "Picture_COLOR_11";
		PictureBox picture_COLOR_22 = Picture_COLOR_11;
		size = new Size(47, 22);
		((Control)picture_COLOR_22).Size = size;
		Picture_COLOR_11.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_11.TabIndex = 766;
		Picture_COLOR_11.TabStop = false;
		((Control)Picture_COLOR_6).BackColor = Color.DeepPink;
		PictureBox picture_COLOR_23 = Picture_COLOR_6;
		location = new Point(332, 3);
		((Control)picture_COLOR_23).Location = location;
		((Control)Picture_COLOR_6).Name = "Picture_COLOR_6";
		PictureBox picture_COLOR_24 = Picture_COLOR_6;
		size = new Size(47, 22);
		((Control)picture_COLOR_24).Size = size;
		Picture_COLOR_6.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_6.TabIndex = 765;
		Picture_COLOR_6.TabStop = false;
		((Control)Picture_COLOR_10).BackColor = Color.FromArgb(52, 73, 94);
		PictureBox picture_COLOR_25 = Picture_COLOR_10;
		location = new Point(144, 31);
		((Control)picture_COLOR_25).Location = location;
		((Control)Picture_COLOR_10).Name = "Picture_COLOR_10";
		PictureBox picture_COLOR_26 = Picture_COLOR_10;
		size = new Size(47, 22);
		((Control)picture_COLOR_26).Size = size;
		Picture_COLOR_10.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_10.TabIndex = 764;
		Picture_COLOR_10.TabStop = false;
		((Control)Picture_COLOR_13).BackColor = Color.Yellow;
		PictureBox picture_COLOR_27 = Picture_COLOR_13;
		location = new Point(473, 31);
		((Control)picture_COLOR_27).Location = location;
		((Control)Picture_COLOR_13).Name = "Picture_COLOR_13";
		PictureBox picture_COLOR_28 = Picture_COLOR_13;
		size = new Size(47, 22);
		((Control)picture_COLOR_28).Size = size;
		Picture_COLOR_13.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_13.TabIndex = 768;
		Picture_COLOR_13.TabStop = false;
		((Control)Picture_COLOR_5).BackColor = Color.FromArgb(149, 165, 166);
		PictureBox picture_COLOR_29 = Picture_COLOR_5;
		location = new Point(285, 3);
		((Control)picture_COLOR_29).Location = location;
		((Control)Picture_COLOR_5).Name = "Picture_COLOR_5";
		PictureBox picture_COLOR_30 = Picture_COLOR_5;
		size = new Size(47, 22);
		((Control)picture_COLOR_30).Size = size;
		Picture_COLOR_5.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_5.TabIndex = 763;
		Picture_COLOR_5.TabStop = false;
		((Control)Picture_COLOR_1).BackColor = Color.White;
		PictureBox picture_COLOR_31 = Picture_COLOR_1;
		location = new Point(3, 3);
		((Control)picture_COLOR_31).Location = location;
		((Control)Picture_COLOR_1).Name = "Picture_COLOR_1";
		PictureBox picture_COLOR_32 = Picture_COLOR_1;
		size = new Size(47, 22);
		((Control)picture_COLOR_32).Size = size;
		Picture_COLOR_1.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_1.TabIndex = 762;
		Picture_COLOR_1.TabStop = false;
		((Control)Picture_COLOR_8).BackColor = Color.Red;
		PictureBox picture_COLOR_33 = Picture_COLOR_8;
		location = new Point(426, 3);
		((Control)picture_COLOR_33).Location = location;
		((Control)Picture_COLOR_8).Name = "Picture_COLOR_8";
		PictureBox picture_COLOR_34 = Picture_COLOR_8;
		size = new Size(47, 22);
		((Control)picture_COLOR_34).Size = size;
		Picture_COLOR_8.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_8.TabIndex = 760;
		Picture_COLOR_8.TabStop = false;
		((Control)Picture_COLOR_9).BackColor = Color.Tomato;
		PictureBox picture_COLOR_35 = Picture_COLOR_9;
		location = new Point(97, 31);
		((Control)picture_COLOR_35).Location = location;
		((Control)Picture_COLOR_9).Name = "Picture_COLOR_9";
		PictureBox picture_COLOR_36 = Picture_COLOR_9;
		size = new Size(47, 22);
		((Control)picture_COLOR_36).Size = size;
		Picture_COLOR_9.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_9.TabIndex = 759;
		Picture_COLOR_9.TabStop = false;
		((Control)Picture_COLOR_7).BackColor = Color.Gold;
		PictureBox picture_COLOR_37 = Picture_COLOR_7;
		location = new Point(379, 3);
		((Control)picture_COLOR_37).Location = location;
		((Control)Picture_COLOR_7).Name = "Picture_COLOR_7";
		PictureBox picture_COLOR_38 = Picture_COLOR_7;
		size = new Size(47, 22);
		((Control)picture_COLOR_38).Size = size;
		Picture_COLOR_7.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_7.TabIndex = 758;
		Picture_COLOR_7.TabStop = false;
		((Control)Picture_COLOR_4).BackColor = Color.DodgerBlue;
		PictureBox picture_COLOR_39 = Picture_COLOR_4;
		location = new Point(144, 3);
		((Control)picture_COLOR_39).Location = location;
		((Control)Picture_COLOR_4).Name = "Picture_COLOR_4";
		PictureBox picture_COLOR_40 = Picture_COLOR_4;
		size = new Size(47, 22);
		((Control)picture_COLOR_40).Size = size;
		Picture_COLOR_4.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_4.TabIndex = 757;
		Picture_COLOR_4.TabStop = false;
		((Control)Picture_COLOR_3).BackColor = Color.FromArgb(230, 126, 34);
		PictureBox picture_COLOR_41 = Picture_COLOR_3;
		location = new Point(97, 3);
		((Control)picture_COLOR_41).Location = location;
		((Control)Picture_COLOR_3).Name = "Picture_COLOR_3";
		PictureBox picture_COLOR_42 = Picture_COLOR_3;
		size = new Size(47, 22);
		((Control)picture_COLOR_42).Size = size;
		Picture_COLOR_3.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_3.TabIndex = 756;
		Picture_COLOR_3.TabStop = false;
		((Control)Picture_COLOR_2).BackColor = Color.FromArgb(46, 204, 113);
		PictureBox picture_COLOR_43 = Picture_COLOR_2;
		location = new Point(50, 3);
		((Control)picture_COLOR_43).Location = location;
		((Control)Picture_COLOR_2).Name = "Picture_COLOR_2";
		PictureBox picture_COLOR_44 = Picture_COLOR_2;
		size = new Size(47, 22);
		((Control)picture_COLOR_44).Size = size;
		Picture_COLOR_2.SizeMode = (PictureBoxSizeMode)1;
		Picture_COLOR_2.TabIndex = 755;
		Picture_COLOR_2.TabStop = false;
		Picture_GOOGLE12.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE12).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE17 = Picture_GOOGLE12;
		location = new Point(405, 367);
		((Control)picture_GOOGLE17).Location = location;
		((Control)Picture_GOOGLE12).Name = "Picture_GOOGLE12";
		PictureBox picture_GOOGLE18 = Picture_GOOGLE12;
		size = new Size(127, 80);
		((Control)picture_GOOGLE18).Size = size;
		Picture_GOOGLE12.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE12.TabIndex = 1116;
		Picture_GOOGLE12.TabStop = false;
		Picture_GOOGLE11.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE11).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE19 = Picture_GOOGLE11;
		location = new Point(272, 367);
		((Control)picture_GOOGLE19).Location = location;
		((Control)Picture_GOOGLE11).Name = "Picture_GOOGLE11";
		PictureBox picture_GOOGLE20 = Picture_GOOGLE11;
		size = new Size(127, 80);
		((Control)picture_GOOGLE20).Size = size;
		Picture_GOOGLE11.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE11.TabIndex = 1115;
		Picture_GOOGLE11.TabStop = false;
		Picture_GOOGLE10.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE10).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE21 = Picture_GOOGLE10;
		location = new Point(139, 367);
		((Control)picture_GOOGLE21).Location = location;
		((Control)Picture_GOOGLE10).Name = "Picture_GOOGLE10";
		PictureBox picture_GOOGLE22 = Picture_GOOGLE10;
		size = new Size(127, 80);
		((Control)picture_GOOGLE22).Size = size;
		Picture_GOOGLE10.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE10.TabIndex = 1114;
		Picture_GOOGLE10.TabStop = false;
		Picture_GOOGLE9.BorderStyle = (BorderStyle)1;
		((Control)Picture_GOOGLE9).Cursor = Cursors.Hand;
		PictureBox picture_GOOGLE23 = Picture_GOOGLE9;
		location = new Point(6, 367);
		((Control)picture_GOOGLE23).Location = location;
		((Control)Picture_GOOGLE9).Name = "Picture_GOOGLE9";
		PictureBox picture_GOOGLE24 = Picture_GOOGLE9;
		size = new Size(127, 80);
		((Control)picture_GOOGLE24).Size = size;
		Picture_GOOGLE9.SizeMode = (PictureBoxSizeMode)1;
		Picture_GOOGLE9.TabIndex = 1113;
		Picture_GOOGLE9.TabStop = false;
		((ButtonBase)Button13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button13).Cursor = Cursors.Hand;
		((ButtonBase)Button13).FlatStyle = (FlatStyle)0;
		((Control)Button13).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button13).ForeColor = Color.White;
		Button button41 = Button13;
		location = new Point(389, 47);
		((Control)button41).Location = location;
		Button button42 = Button13;
		margin = new Padding(0);
		((Control)button42).Margin = margin;
		((Control)Button13).Name = "Button13";
		Button button43 = Button13;
		size = new Size(140, 27);
		((Control)button43).Size = size;
		((Control)Button13).TabIndex = 1111;
		((ButtonBase)Button13).Text = "Valider";
		((ButtonBase)Button13).UseVisualStyleBackColor = false;
		((Control)Label11).BackColor = Color.WhiteSmoke;
		((Control)Label11).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.FromArgb(64, 64, 64);
		Label label39 = Label11;
		location = new Point(41, 50);
		((Control)label39).Location = location;
		((Control)Label11).Name = "Label11";
		Label label40 = Label11;
		size = new Size(236, 27);
		((Control)label40).Size = size;
		((Control)Label11).TabIndex = 1110;
		Label11.Text = "Détecter les images automatique";
		Label11.TextAlign = (ContentAlignment)16;
		((Control)PictureBox5).Cursor = Cursors.Hand;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox7 = PictureBox5;
		location = new Point(0, 0);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox8 = PictureBox5;
		size = new Size(32, 32);
		((Control)pictureBox8).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 1109;
		PictureBox5.TabStop = false;
		((Control)PictureBox4).Cursor = Cursors.Hand;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox9 = PictureBox4;
		location = new Point(6, 127);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox10 = PictureBox4;
		size = new Size(40, 40);
		((Control)pictureBox10).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)4;
		PictureBox4.TabIndex = 1108;
		PictureBox4.TabStop = false;
		((Control)PictureBox3).Cursor = Cursors.Hand;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox11 = PictureBox3;
		location = new Point(492, 127);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox12 = PictureBox3;
		size = new Size(40, 40);
		((Control)pictureBox12).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 1107;
		PictureBox3.TabStop = false;
		((Control)Picture_IMAGE).BackColor = Color.Transparent;
		Picture_IMAGE.BorderStyle = (BorderStyle)1;
		PictureBox picture_IMAGE = Picture_IMAGE;
		location = new Point(209, 117);
		((Control)picture_IMAGE).Location = location;
		((Control)Picture_IMAGE).Name = "Picture_IMAGE";
		PictureBox picture_IMAGE2 = Picture_IMAGE;
		size = new Size(127, 80);
		((Control)picture_IMAGE2).Size = size;
		Picture_IMAGE.SizeMode = (PictureBoxSizeMode)1;
		Picture_IMAGE.TabIndex = 1101;
		Picture_IMAGE.TabStop = false;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3
		});
		DataGridView dataGridView = DataGridView1;
		location = new Point(219, 121);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.ReadOnly = true;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(112, 52);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1112;
		((DataGridViewColumn)Column1).HeaderText = "Column1";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).ReadOnly = true;
		((DataGridViewColumn)Column2).HeaderText = "Column2";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Column3";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewColumn)Column3).ReadOnly = true;
		((TextBoxBase)Text_LIEN_PICTURE).BackColor = Color.FromArgb(249, 249, 249);
		((TextBoxBase)Text_LIEN_PICTURE).BorderStyle = (BorderStyle)0;
		((Control)Text_LIEN_PICTURE).Font = new Font("Tahoma", 6f);
		TextBox text_LIEN_PICTURE = Text_LIEN_PICTURE;
		location = new Point(246, 98);
		((Control)text_LIEN_PICTURE).Location = location;
		((Control)Text_LIEN_PICTURE).Name = "Text_LIEN_PICTURE";
		TextBox text_LIEN_PICTURE2 = Text_LIEN_PICTURE;
		size = new Size(121, 10);
		((Control)text_LIEN_PICTURE2).Size = size;
		((Control)Text_LIEN_PICTURE).TabIndex = 1103;
		Text_LIEN_PICTURE.Text = "0.Png";
		((Control)Text_LIEN_PICTURE).Visible = false;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(272, 86);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(33, 29);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 1105;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((TextBoxBase)Text_ARTICLE).BackColor = Color.FromArgb(249, 249, 249);
		((Control)Text_ARTICLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ARTICLE = Text_ARTICLE;
		location = new Point(139, 89);
		((Control)text_ARTICLE).Location = location;
		((Control)Text_ARTICLE).Name = "Text_ARTICLE";
		TextBox text_ARTICLE2 = Text_ARTICLE;
		size = new Size(260, 29);
		((Control)text_ARTICLE2).Size = size;
		((Control)Text_ARTICLE).TabIndex = 1118;
		((Control)Panel4).BackColor = Color.White;
		((Control)Panel4).Controls.Add((Control)(object)Label21);
		((Control)Panel4).Controls.Add((Control)(object)Button20);
		((Control)Panel4).Controls.Add((Control)(object)Combo_BALANCE);
		((Control)Panel4).Controls.Add((Control)(object)Label22);
		((Control)Panel4).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel4).Controls.Add((Control)(object)Button14);
		((Control)Panel4).Controls.Add((Control)(object)Label15);
		((Control)Panel4).Controls.Add((Control)(object)Combo_PROMOTION);
		((Control)Panel4).Controls.Add((Control)(object)Label16);
		((Control)Panel4).Controls.Add((Control)(object)Button8);
		((Control)Panel4).Controls.Add((Control)(object)Label13);
		((Control)Panel4).Controls.Add((Control)(object)Label14);
		((Control)Panel4).Controls.Add((Control)(object)Button12);
		((Control)Panel4).Controls.Add((Control)(object)Label10);
		((Control)Panel4).Controls.Add((Control)(object)Combo_TYPE);
		((Control)Panel4).Controls.Add((Control)(object)Label12);
		((Control)Panel4).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel4).Controls.Add((Control)(object)Button7);
		((Control)Panel4).Controls.Add((Control)(object)Label7);
		((Control)Panel4).Controls.Add((Control)(object)Label5);
		((Control)Panel4).Controls.Add((Control)(object)Label9);
		((Control)Panel4).Controls.Add((Control)(object)Combo_TAUX_TVA);
		((Control)Panel4).Controls.Add((Control)(object)Label32);
		((Control)Panel4).Controls.Add((Control)(object)Label4);
		((Control)Panel4).Controls.Add((Control)(object)Combo_FAMILLE);
		((Control)Panel4).Controls.Add((Control)(object)Button5);
		((Control)Panel4).Controls.Add((Control)(object)Combo_MODE_STOCK);
		((Control)Panel4).Controls.Add((Control)(object)Button4);
		((Control)Panel4).Controls.Add((Control)(object)Button6);
		((Control)Panel4).Controls.Add((Control)(object)Button3);
		((Control)Panel4).Controls.Add((Control)(object)Combo_FENETRE_PESAGE);
		((Control)Panel4).Controls.Add((Control)(object)Label8);
		((Control)Panel4).Controls.Add((Control)(object)Combo_UNITE);
		((Control)Panel4).Controls.Add((Control)(object)Label46);
		((Control)Panel4).Controls.Add((Control)(object)Label2);
		((Control)Panel4).Controls.Add((Control)(object)Label28);
		((Control)Panel4).Controls.Add((Control)(object)Label30);
		Panel panel9 = Panel4;
		location = new Point(195, 26);
		((Control)panel9).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel10 = Panel4;
		size = new Size(541, 508);
		((Control)panel10).Size = size;
		((Control)Panel4).TabIndex = 1095;
		((Control)Label21).BackColor = Color.WhiteSmoke;
		((Control)Label21).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label21).ForeColor = Color.FromArgb(64, 64, 64);
		Label label41 = Label21;
		location = new Point(190, 210);
		((Control)label41).Location = location;
		((Control)Label21).Name = "Label21";
		Label label42 = Label21;
		size = new Size(92, 27);
		((Control)label42).Size = size;
		((Control)Label21).TabIndex = 1129;
		Label21.Text = "Changer au";
		Label21.TextAlign = (ContentAlignment)64;
		((ButtonBase)Button20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button20).Cursor = Cursors.Hand;
		((ButtonBase)Button20).FlatStyle = (FlatStyle)0;
		((Control)Button20).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button20).ForeColor = Color.White;
		Button button44 = Button20;
		location = new Point(394, 210);
		((Control)button44).Location = location;
		Button button45 = Button20;
		margin = new Padding(0);
		((Control)button45).Margin = margin;
		((Control)Button20).Name = "Button20";
		Button button46 = Button20;
		size = new Size(139, 27);
		((Control)button46).Size = size;
		((Control)Button20).TabIndex = 1128;
		((ButtonBase)Button20).Text = "Valider";
		((ButtonBase)Button20).UseVisualStyleBackColor = false;
		((Control)Combo_BALANCE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_BALANCE).FormattingEnabled = true;
		Combo_BALANCE.Items.AddRange(new object[2] { "", "OUI" });
		ComboBox combo_BALANCE = Combo_BALANCE;
		location = new Point(288, 210);
		((Control)combo_BALANCE).Location = location;
		((Control)Combo_BALANCE).Name = "Combo_BALANCE";
		ComboBox combo_BALANCE2 = Combo_BALANCE;
		size = new Size(103, 29);
		((Control)combo_BALANCE2).Size = size;
		((Control)Combo_BALANCE).TabIndex = 1127;
		((Control)Label22).BackColor = Color.WhiteSmoke;
		((Control)Label22).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label22).ForeColor = Color.FromArgb(64, 64, 64);
		Label label43 = Label22;
		location = new Point(7, 210);
		((Control)label43).Location = location;
		((Control)Label22).Name = "Label22";
		Label label44 = Label22;
		size = new Size(274, 27);
		((Control)label44).Size = size;
		((Control)Label22).TabIndex = 1126;
		Label22.Text = "Balance";
		Label22.TextAlign = (ContentAlignment)16;
		((Control)PictureBox8).BackColor = Color.Transparent;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox8.ImeMode = (ImeMode)0;
		PictureBox pictureBox13 = PictureBox8;
		location = new Point(447, 436);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox14 = PictureBox8;
		size = new Size(31, 23);
		((Control)pictureBox14).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)4;
		PictureBox8.TabIndex = 1125;
		PictureBox8.TabStop = false;
		((ButtonBase)Button14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button14).Cursor = Cursors.Hand;
		((ButtonBase)Button14).FlatStyle = (FlatStyle)0;
		((Control)Button14).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button14).ForeColor = Color.White;
		Button button47 = Button14;
		location = new Point(394, 340);
		((Control)button47).Location = location;
		Button button48 = Button14;
		margin = new Padding(0);
		((Control)button48).Margin = margin;
		((Control)Button14).Name = "Button14";
		Button button49 = Button14;
		size = new Size(139, 27);
		((Control)button49).Size = size;
		((Control)Button14).TabIndex = 1124;
		((ButtonBase)Button14).Text = "Valider";
		((ButtonBase)Button14).UseVisualStyleBackColor = false;
		((Control)Label15).BackColor = Color.WhiteSmoke;
		((Control)Label15).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label15).ForeColor = Color.FromArgb(64, 64, 64);
		Label label45 = Label15;
		location = new Point(190, 340);
		((Control)label45).Location = location;
		((Control)Label15).Name = "Label15";
		Label label46 = Label15;
		size = new Size(92, 27);
		((Control)label46).Size = size;
		((Control)Label15).TabIndex = 1123;
		Label15.Text = "Changer au";
		Label15.TextAlign = (ContentAlignment)64;
		((Control)Combo_PROMOTION).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_PROMOTION).FormattingEnabled = true;
		Combo_PROMOTION.Items.AddRange(new object[10] { "0", "5", "10", "20", "30", "50", "70", "80", "90", "100" });
		ComboBox combo_PROMOTION = Combo_PROMOTION;
		location = new Point(288, 340);
		((Control)combo_PROMOTION).Location = location;
		((Control)Combo_PROMOTION).Name = "Combo_PROMOTION";
		ComboBox combo_PROMOTION2 = Combo_PROMOTION;
		size = new Size(103, 29);
		((Control)combo_PROMOTION2).Size = size;
		((Control)Combo_PROMOTION).TabIndex = 1122;
		((Control)Label16).BackColor = Color.WhiteSmoke;
		((Control)Label16).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label16).ForeColor = Color.FromArgb(64, 64, 64);
		Label label47 = Label16;
		location = new Point(7, 340);
		((Control)label47).Location = location;
		((Control)Label16).Name = "Label16";
		Label label48 = Label16;
		size = new Size(274, 27);
		((Control)label48).Size = size;
		((Control)Label16).TabIndex = 1121;
		Label16.Text = "Promotion";
		Label16.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button8).BackColor = Color.Red;
		((Control)Button8).Cursor = Cursors.Hand;
		((ButtonBase)Button8).FlatStyle = (FlatStyle)0;
		((Control)Button8).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button8).ForeColor = Color.White;
		Button button50 = Button8;
		location = new Point(394, 460);
		((Control)button50).Location = location;
		Button button51 = Button8;
		margin = new Padding(0);
		((Control)button51).Margin = margin;
		((Control)Button8).Name = "Button8";
		Button button52 = Button8;
		size = new Size(139, 27);
		((Control)button52).Size = size;
		((Control)Button8).TabIndex = 1118;
		((ButtonBase)Button8).Text = "Valider";
		((ButtonBase)Button8).UseVisualStyleBackColor = false;
		((Control)Label13).BackColor = Color.WhiteSmoke;
		((Control)Label13).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label13).ForeColor = Color.FromArgb(64, 64, 64);
		Label label49 = Label13;
		location = new Point(190, 460);
		((Control)label49).Location = location;
		((Control)Label13).Name = "Label13";
		Label label50 = Label13;
		size = new Size(92, 27);
		((Control)label50).Size = size;
		((Control)Label13).TabIndex = 1117;
		Label13.Text = "Supprimer";
		Label13.TextAlign = (ContentAlignment)64;
		((Control)Label14).BackColor = Color.WhiteSmoke;
		((Control)Label14).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label14).ForeColor = Color.FromArgb(64, 64, 64);
		Label label51 = Label14;
		location = new Point(7, 460);
		((Control)label51).Location = location;
		((Control)Label14).Name = "Label14";
		Label label52 = Label14;
		size = new Size(274, 27);
		((Control)label52).Size = size;
		((Control)Label14).TabIndex = 1115;
		Label14.Text = "Famille";
		Label14.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button12).Cursor = Cursors.Hand;
		((ButtonBase)Button12).FlatStyle = (FlatStyle)0;
		((Control)Button12).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button12).ForeColor = Color.White;
		Button button53 = Button12;
		location = new Point(394, 297);
		((Control)button53).Location = location;
		Button button54 = Button12;
		margin = new Padding(0);
		((Control)button54).Margin = margin;
		((Control)Button12).Name = "Button12";
		Button button55 = Button12;
		size = new Size(139, 27);
		((Control)button55).Size = size;
		((Control)Button12).TabIndex = 1114;
		((ButtonBase)Button12).Text = "Valider";
		((ButtonBase)Button12).UseVisualStyleBackColor = false;
		((Control)Label10).BackColor = Color.WhiteSmoke;
		((Control)Label10).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.FromArgb(64, 64, 64);
		Label label53 = Label10;
		location = new Point(190, 297);
		((Control)label53).Location = location;
		((Control)Label10).Name = "Label10";
		Label label54 = Label10;
		size = new Size(92, 27);
		((Control)label54).Size = size;
		((Control)Label10).TabIndex = 1113;
		Label10.Text = "Changer au";
		Label10.TextAlign = (ContentAlignment)64;
		((Control)Combo_TYPE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)Combo_TYPE).FormattingEnabled = true;
		Combo_TYPE.Items.AddRange(new object[2] { "ARTICLE", "COMPOSITION" });
		ComboBox combo_TYPE = Combo_TYPE;
		location = new Point(288, 297);
		((Control)combo_TYPE).Location = location;
		((Control)Combo_TYPE).Name = "Combo_TYPE";
		ComboBox combo_TYPE2 = Combo_TYPE;
		size = new Size(103, 29);
		((Control)combo_TYPE2).Size = size;
		((Control)Combo_TYPE).TabIndex = 1112;
		((Control)Label12).BackColor = Color.WhiteSmoke;
		((Control)Label12).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.FromArgb(64, 64, 64);
		Label label55 = Label12;
		location = new Point(7, 297);
		((Control)label55).Location = location;
		((Control)Label12).Name = "Label12";
		Label label56 = Label12;
		size = new Size(274, 27);
		((Control)label56).Size = size;
		((Control)Label12).TabIndex = 1111;
		Label12.Text = "Type";
		Label12.TextAlign = (ContentAlignment)16;
		((Control)PictureBox7).Cursor = Cursors.Hand;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox15 = PictureBox7;
		location = new Point(0, 0);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox16 = PictureBox7;
		size = new Size(32, 32);
		((Control)pictureBox16).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 1110;
		PictureBox7.TabStop = false;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox17 = PictureBox10;
		location = new Point(-29, 10);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox18 = PictureBox10;
		size = new Size(203, 531);
		((Control)pictureBox18).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)4;
		PictureBox10.TabIndex = 1095;
		PictureBox10.TabStop = false;
		((ButtonBase)Check_png).AutoSize = true;
		Check_png.Checked = true;
		Check_png.CheckState = (CheckState)1;
		CheckBox check_png = Check_png;
		location = new Point(405, 94);
		((Control)check_png).Location = location;
		((Control)Check_png).Name = "Check_png";
		CheckBox check_png2 = Check_png;
		size = new Size(44, 17);
		((Control)check_png2).Size = size;
		((Control)Check_png).TabIndex = 1122;
		((ButtonBase)Check_png).Text = "png";
		((ButtonBase)Check_png).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(933, 557);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox10);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_ROBOT";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "ROBOT";
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)Picture_GOOGLE8).EndInit();
		((ISupportInitialize)Picture_GOOGLE7).EndInit();
		((ISupportInitialize)Picture_GOOGLE6).EndInit();
		((ISupportInitialize)Picture_GOOGLE5).EndInit();
		((ISupportInitialize)Picture_GOOGLE4).EndInit();
		((ISupportInitialize)Picture_GOOGLE3).EndInit();
		((ISupportInitialize)Picture_GOOGLE2).EndInit();
		((ISupportInitialize)Picture_GOOGLE1).EndInit();
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)Panel_INFO).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)PictureBox9).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel_COULEUR).ResumeLayout(false);
		((ISupportInitialize)Picture_COLOR_23).EndInit();
		((ISupportInitialize)Picture_COLOR_22).EndInit();
		((ISupportInitialize)Picture_COLOR_21).EndInit();
		((ISupportInitialize)Picture_COLOR_20).EndInit();
		((ISupportInitialize)Picture_COLOR_19).EndInit();
		((ISupportInitialize)Picture_COLOR_18).EndInit();
		((ISupportInitialize)Picture_COLOR_17).EndInit();
		((ISupportInitialize)Picture_COLOR_15).EndInit();
		((ISupportInitialize)Picture_COLOR_12).EndInit();
		((ISupportInitialize)Picture_COLOR_16).EndInit();
		((ISupportInitialize)Picture_COLOR_11).EndInit();
		((ISupportInitialize)Picture_COLOR_6).EndInit();
		((ISupportInitialize)Picture_COLOR_10).EndInit();
		((ISupportInitialize)Picture_COLOR_13).EndInit();
		((ISupportInitialize)Picture_COLOR_5).EndInit();
		((ISupportInitialize)Picture_COLOR_1).EndInit();
		((ISupportInitialize)Picture_COLOR_8).EndInit();
		((ISupportInitialize)Picture_COLOR_9).EndInit();
		((ISupportInitialize)Picture_COLOR_7).EndInit();
		((ISupportInitialize)Picture_COLOR_4).EndInit();
		((ISupportInitialize)Picture_COLOR_3).EndInit();
		((ISupportInitialize)Picture_COLOR_2).EndInit();
		((ISupportInitialize)Picture_GOOGLE12).EndInit();
		((ISupportInitialize)Picture_GOOGLE11).EndInit();
		((ISupportInitialize)Picture_GOOGLE10).EndInit();
		((ISupportInitialize)Picture_GOOGLE9).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)Picture_IMAGE).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_ROBOT_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void FormDialog_ROBOT_Load(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select FAMILLE from TABLE_FAMILLES  order by Ordre,Famille asc", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).Clear();
		Combo_FAMILLE.Items.Clear();
		checked
		{
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
				((System.Windows.Forms.CheckedListBox.ObjectCollection)CheckedListBox1.Items).Add((object)dataTable.Rows[num2]["Famille"].ToString());
				Combo_FAMILLE.Items.Add((object)dataTable.Rows[num2]["Famille"].ToString());
				num2++;
			}
			((ListBox)CheckedListBox1).SelectedIndex = 0;
			((Control)Panel1).BringToFront();
		}
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			Random random = new Random();
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     Printer = '" + Combo_PRINTER.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		checked
		{
			foreach (object checkedItem in CheckedListBox1.CheckedItems)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter(" select  CODE  from TABLE_ARTICLES         WHERE  Famille   =  '" + objectValue.ToString() + "'  ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MySqlCommand val2 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				Random random = new Random();
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
					val2.CommandText = "Update TABLE_ARTICLES      SET     Images = '" + Conversions.ToString(random.Next(1, 21)) + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'    and  CODE   =  '" + dataTable.Rows[num2]["CODE"].ToString() + "' ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					val2.ExecuteNonQuery();
					num2++;
				}
				Module1.cn_SQL.Close();
			}
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			Random random = new Random();
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     Printer_DUPLICATA = '" + Combo_PRINTER_DUPLICATA.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     MODE_STOCK = '" + Combo_MODE_STOCK.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     UNITE = '" + Combo_UNITE.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     FENETRE_PESAGE = '" + Combo_FENETRE_PESAGE.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     TAUX_TVA = '" + Combo_TAUX_TVA.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     FAMILLE = '" + Combo_FAMILLE.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		((Control)Panel2).BringToFront();
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		((Control)Panel3).BringToFront();
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		((Control)Panel4).BringToFront();
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		((Control)Panel1).BringToFront();
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		((Control)Panel1).BringToFront();
	}

	private void PictureBox7_Click(object sender, EventArgs e)
	{
		((Control)Panel1).BringToFront();
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     TYPE = '" + Combo_TYPE.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
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
				DataGridView1.Rows.Clear();
				Text_ID.Text = "";
				Text_ARTICLE.Text = "";
				Text_LIEN_PICTURE.Text = "0.png";
				Picture_IMAGE.ImageLocation = Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text;
				foreach (object checkedItem in CheckedListBox1.CheckedItems)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter(" select  ID,ARTICLE,Images  from TABLE_ARTICLES         WHERE  Famille   =  '" + objectValue.ToString() + "'  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
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
						DataGridView1.Rows.Add(new object[3]
						{
							dataTable.Rows[num2]["ID"].ToString(),
							dataTable.Rows[num2]["ARTICLE"].ToString(),
							dataTable.Rows[num2]["Images"].ToString()
						});
						num2++;
					}
				}
				Button_FIND.PerformClick();
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

	private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		Text_ID.Text = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value);
		Text_ARTICLE.Text = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[1].Value);
		Text_LIEN_PICTURE.Text = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[2].Value);
		Picture_IMAGE.ImageLocation = Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text;
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
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
				if (((DataGridViewBand)DataGridView1.CurrentRow).Index != DataGridView1.Rows.Count - 1)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index + 1].Cells[0];
				}
				Button_FIND.PerformClick();
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

	private void PictureBox4_Click(object sender, EventArgs e)
	{
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
				if (((DataGridViewBand)DataGridView1.CurrentRow).Index != 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index - 1].Cells[0];
				}
				Button_FIND.PerformClick();
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

	private void Picture_GOOGLE_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		try
		{
			Picture_IMAGE.Image = (Image)NewLateBinding.LateGet(sender, null, "Image", new object[0], null, null, null);
			Bitmap val = new Bitmap(((Control)Picture_IMAGE).Size.Width, ((Control)Picture_IMAGE).Size.Height);
			PictureBox picture_IMAGE = Picture_IMAGE;
			Rectangle rectangle = new Rectangle(0, 0, ((Control)Picture_IMAGE).Width, ((Control)Picture_IMAGE).Height);
			((Control)picture_IMAGE).DrawToBitmap(val, rectangle);
			Picture_IMAGE.Image = (Image)(object)val;
			Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
			Picture_IMAGE.Image.Save(Module1._CHEMIN_FOLDER + "\\bd\\images\\" + Text_LIEN_PICTURE.Text, ImageFormat.Png);
			MySqlCommand val2 = new MySqlCommand();
			val2.CommandText = "Update TABLE_ARTICLES      SET     Images = '" + Text_LIEN_PICTURE.Text + "'        WHERE  ID   =  " + Text_ID.Text + "     ";
			val2.Connection = Module1.cn_SQL;
			val2.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val2.ExecuteNonQuery();
			Module1.cn_SQL.Close();
			PictureBox3_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Button_FIND_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (Check_png.Checked)
			{
				text = " + png";
			}
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			string requestUriString = "https://www.bing.com/images/search?q=" + Uri.EscapeDataString(Text_ARTICLE.Text + text);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
			httpWebRequest.Timeout = 8000;
			httpWebRequest.ReadWriteTimeout = 8000;
			string input = "";
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				input = streamReader.ReadToEnd();
			}
			List<string> list = new List<string>();
			string pattern = "href=\"(https://[^\"]+?\\.(?:jpg|jpeg|png|gif|webp)[^\"]*?)\"";
			Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
			while ((match.Success && list.Count < 12) ? true : false)
			{
				list.Add(match.Groups[1].Value);
				match = match.NextMatch();
			}
			if (list.Count < 12)
			{
				Interaction.MsgBox("Seulement " + Conversions.ToString(list.Count) + " images trouvées.");
				return;
			}
			Picture_GOOGLE1.LoadAsync(list[0]);
			Picture_GOOGLE2.LoadAsync(list[1]);
			Picture_GOOGLE3.LoadAsync(list[2]);
			Picture_GOOGLE4.LoadAsync(list[3]);
			Picture_GOOGLE5.LoadAsync(list[4]);
			Picture_GOOGLE6.LoadAsync(list[5]);
			Picture_GOOGLE7.LoadAsync(list[6]);
			Picture_GOOGLE8.LoadAsync(list[7]);
			Picture_GOOGLE9.LoadAsync(list[8]);
			Picture_GOOGLE10.LoadAsync(list[9]);
			Picture_GOOGLE11.LoadAsync(list[10]);
			Picture_GOOGLE12.LoadAsync(list[11]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.ToString() + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			ProjectData.ClearProjectError();
		}
	}

	private void Text_LIEN_PICTURE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_ARTICLE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_ARTICLE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Button_FIND_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Attention, Tous les changements seront effectués sur votre responsabilité.\r\nVoulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1 || (int)MessageBox.Show("Voulez-vous vraiment Supprimer ces Familles avec leurs Articles ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Delete  from TABLE_ARTICLES           WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
			val.CommandText = "Delete  from TABLE_FAMILLES           WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Combo_PROMOTION.Text, "", TextCompare: false) == 0 || decimal.Compare(Conversions.ToDecimal(Combo_PROMOTION.Text), 100m) > 0)
		{
			MessageBox.Show("Veuillez remplir le champ -PROMOTION- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
			{
				return;
			}
			foreach (object checkedItem in CheckedListBox1.CheckedItems)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
				MySqlCommand val = new MySqlCommand();
				val.CommandText = "Update TABLE_ARTICLES      SET     PROMOTION = '" + Combo_PROMOTION.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.ExecuteNonQuery();
				Module1.cn_SQL.Close();
			}
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void Button_M_SHIFTS_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_IMPORTER_ARTICLES).ShowDialog();
	}

	private void PictureBox9_Click(object sender, EventArgs e)
	{
		((Control)Panel1).BringToFront();
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((Control)Panel5).BringToFront();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select  DISTINCT   Famille    from    TABLE_FAMILLES  Where TYPE = 'PAGE'   ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ListBox1.Items.Clear();
		checked
		{
			int num = dataTable.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					ListBox1.Items.Add((object)dataTable.Rows[num2]["Famille"].ToString());
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		int selectionStart = ((TextBoxBase)Text_COMPOSITION).SelectionStart;
		Text_COMPOSITION.Text = Text_COMPOSITION.Text.Insert(selectionStart, ListBox1.Text + ";");
		((TextBoxBase)Text_COMPOSITION).SelectionStart = Text_COMPOSITION.Text.Length;
		((Control)Text_COMPOSITION).Focus();
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     COMPOSITIONS = '" + Text_COMPOSITION.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     COMPOSITIONS = COMPOSITIONS & '" + Text_COMPOSITION.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous vraiment Valider ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		foreach (object checkedItem in CheckedListBox1.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			MySqlCommand val = new MySqlCommand();
			val.CommandText = "Update TABLE_ARTICLES      SET     Balance = '" + Combo_BALANCE.Text + "'        WHERE  Famille   =  '" + objectValue.ToString() + "'     ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
		}
		MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}

	private void Picture_COLOR_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Picture_IMAGE.Image = null;
		((Control)Picture_IMAGE).BackColor = Color.White;
		PictureBox picture_IMAGE = Picture_IMAGE;
		object obj = NewLateBinding.LateGet(sender, null, "BackColor", new object[0], null, null, null);
		Color color = default;
		((Control)picture_IMAGE).BackColor = ((obj != null) ? ((Color)obj) : color);
		Bitmap val = new Bitmap(((Control)Picture_IMAGE).Size.Width, ((Control)Picture_IMAGE).Size.Height);
		PictureBox picture_IMAGE2 = Picture_IMAGE;
		Rectangle rectangle = new Rectangle(0, 0, ((Control)Picture_IMAGE).Width, ((Control)Picture_IMAGE).Height);
		((Control)picture_IMAGE2).DrawToBitmap(val, rectangle);
		Picture_IMAGE.Image = (Image)(object)val;
		Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
	}
}
