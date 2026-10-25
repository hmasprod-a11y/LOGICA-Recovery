using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
public class Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Text_ID_FOURNISSEUR")]
	private TextBox _Text_ID_FOURNISSEUR;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Text_FOURNISSEUR")]
	private TextBox _Text_FOURNISSEUR;

	[AccessedThroughProperty("Text_VALEUR_ANCIENNE")]
	private TextBox _Text_VALEUR_ANCIENNE;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Text_VALEUR_NOUVELLE")]
	private TextBox _Text_VALEUR_NOUVELLE;

	internal virtual Button Button_CLOSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLOSE_Click;
			if (_Button_CLOSE != null)
			{
				((Control)_Button_CLOSE).Click -= eventHandler;
			}
			_Button_CLOSE = value;
			if (_Button_CLOSE != null)
			{
				((Control)_Button_CLOSE).Click += eventHandler;
			}
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

	internal virtual TextBox Text_ID_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_FOURNISSEUR = value;
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

	internal virtual TextBox Text_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_FOURNISSEUR = value;
		}
	}

	internal virtual TextBox Text_VALEUR_ANCIENNE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_VALEUR_ANCIENNE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_VALEUR_ANCIENNE = value;
		}
	}

	internal virtual Label Label36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label36 = value;
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

	internal virtual TextBox Text_VALEUR_NOUVELLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_VALEUR_NOUVELLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_VALEUR_NOUVELLE_KeyPress;
			EventHandler eventHandler = Text_VALEUR_NOUVELLE_TextChanged;
			if (_Text_VALEUR_NOUVELLE != null)
			{
				((Control)_Text_VALEUR_NOUVELLE).KeyPress -= val;
				((Control)_Text_VALEUR_NOUVELLE).TextChanged -= eventHandler;
			}
			_Text_VALEUR_NOUVELLE = value;
			if (_Text_VALEUR_NOUVELLE != null)
			{
				((Control)_Text_VALEUR_NOUVELLE).KeyPress += val;
				((Control)_Text_VALEUR_NOUVELLE).TextChanged += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL()
	{
		((Form)this).Shown += FormDialog_modif_Shown;
		((Form)this).Load += FormDialog_MODIFICATION_Load;
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL));
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Text_ID_FOURNISSEUR = new TextBox();
		Label11 = new Label();
		Label8 = new Label();
		Text_FOURNISSEUR = new TextBox();
		Text_VALEUR_ANCIENNE = new TextBox();
		Label36 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Text_VALEUR_NOUVELLE = new TextBox();
		((Control)this).SuspendLayout();
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		Point location = new Point(15, 162);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		Padding margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		Size size = new Size(155, 54);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 1075;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(205, 162);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(155, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1074;
		((ButtonBase)Button_SAVE).Text = "Ok";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_ID_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_ID_FOURNISSEUR).Enabled = false;
		((Control)Text_ID_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID_FOURNISSEUR = Text_ID_FOURNISSEUR;
		location = new Point(143, 9);
		((Control)text_ID_FOURNISSEUR).Location = location;
		((Control)Text_ID_FOURNISSEUR).Name = "Text_ID_FOURNISSEUR";
		TextBox text_ID_FOURNISSEUR2 = Text_ID_FOURNISSEUR;
		size = new Size(217, 29);
		((Control)text_ID_FOURNISSEUR2).Size = size;
		((Control)Text_ID_FOURNISSEUR).TabIndex = 1076;
		((Control)Label11).BackColor = SystemColors.Control;
		((Control)Label11).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.Black;
		Label11.ImeMode = (ImeMode)0;
		Label label = Label11;
		location = new Point(12, 9);
		((Control)label).Location = location;
		((Control)Label11).Name = "Label11";
		Label label2 = Label11;
		size = new Size(126, 26);
		((Control)label2).Size = size;
		((Control)Label11).TabIndex = 1077;
		Label11.Text = "ID Fournisseur";
		Label11.TextAlign = (ContentAlignment)16;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label3 = Label8;
		location = new Point(12, 41);
		((Control)label3).Location = location;
		((Control)Label8).Name = "Label8";
		Label label4 = Label8;
		size = new Size(126, 26);
		((Control)label4).Size = size;
		((Control)Label8).TabIndex = 1079;
		Label8.Text = "Fournisseur";
		Label8.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_FOURNISSEUR).Enabled = false;
		((Control)Text_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_FOURNISSEUR = Text_FOURNISSEUR;
		location = new Point(143, 41);
		((Control)text_FOURNISSEUR).Location = location;
		((Control)Text_FOURNISSEUR).Name = "Text_FOURNISSEUR";
		TextBox text_FOURNISSEUR2 = Text_FOURNISSEUR;
		size = new Size(217, 29);
		((Control)text_FOURNISSEUR2).Size = size;
		((Control)Text_FOURNISSEUR).TabIndex = 1078;
		((TextBoxBase)Text_VALEUR_ANCIENNE).BackColor = Color.White;
		((Control)Text_VALEUR_ANCIENNE).Enabled = false;
		((Control)Text_VALEUR_ANCIENNE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_VALEUR_ANCIENNE = Text_VALEUR_ANCIENNE;
		location = new Point(143, 73);
		((Control)text_VALEUR_ANCIENNE).Location = location;
		((Control)Text_VALEUR_ANCIENNE).Name = "Text_VALEUR_ANCIENNE";
		TextBox text_VALEUR_ANCIENNE2 = Text_VALEUR_ANCIENNE;
		size = new Size(217, 29);
		((Control)text_VALEUR_ANCIENNE2).Size = size;
		((Control)Text_VALEUR_ANCIENNE).TabIndex = 1081;
		((Control)Label36).BackColor = Color.WhiteSmoke;
		((Control)Label36).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label36).ForeColor = Color.Black;
		Label label5 = Label36;
		location = new Point(12, 73);
		((Control)label5).Location = location;
		((Control)Label36).Name = "Label36";
		Label label6 = Label36;
		size = new Size(126, 26);
		((Control)label6).Size = size;
		((Control)Label36).TabIndex = 1080;
		Label36.Text = "Ancienne valeur";
		Label36.TextAlign = (ContentAlignment)16;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label7 = Label1;
		location = new Point(320, 77);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(39, 24);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 1082;
		Label1.Text = "DH";
		((Control)Label2).BackColor = Color.WhiteSmoke;
		((Control)Label2).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label9 = Label2;
		location = new Point(12, 106);
		((Control)label9).Location = location;
		((Control)Label2).Name = "Label2";
		Label label10 = Label2;
		size = new Size(126, 26);
		((Control)label10).Size = size;
		((Control)Label2).TabIndex = 1083;
		Label2.Text = "Nouvelle valeur";
		Label2.TextAlign = (ContentAlignment)16;
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label label11 = Label3;
		location = new Point(320, 110);
		((Control)label11).Location = location;
		((Control)Label3).Name = "Label3";
		Label label12 = Label3;
		size = new Size(39, 24);
		((Control)label12).Size = size;
		((Control)Label3).TabIndex = 1085;
		Label3.Text = "DH";
		((TextBoxBase)Text_VALEUR_NOUVELLE).BackColor = Color.White;
		((Control)Text_VALEUR_NOUVELLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_VALEUR_NOUVELLE = Text_VALEUR_NOUVELLE;
		location = new Point(143, 106);
		((Control)text_VALEUR_NOUVELLE).Location = location;
		((Control)Text_VALEUR_NOUVELLE).Name = "Text_VALEUR_NOUVELLE";
		TextBox text_VALEUR_NOUVELLE2 = Text_VALEUR_NOUVELLE;
		size = new Size(217, 29);
		((Control)text_VALEUR_NOUVELLE2).Size = size;
		((Control)Text_VALEUR_NOUVELLE).TabIndex = 1084;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(372, 226);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Text_VALEUR_NOUVELLE);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Text_VALEUR_ANCIENNE);
		((Control)this).Controls.Add((Control)(object)Label36);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Text_FOURNISSEUR);
		((Control)this).Controls.Add((Control)(object)Text_ID_FOURNISSEUR);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Button_CLOSE);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "MODIFICATION";
		((Form)this).TopMost = true;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void FormDialog_modif_Shown(object sender, EventArgs e)
	{
	}

	private void Text_VALEUR_NOUVELLE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_VALEUR_NOUVELLE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void FormDialog_MODIFICATION_Load(object sender, EventArgs e)
	{
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_VALEUR_NOUVELLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -VALEUR_NOUVELLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					val.CommandText = "INSERT  INTO   TABLE_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL               (Dates, HEURE, UTILISATEUR , ID_FOURNISSEUR , FOURNISSEUR ,VALEUR_ANCIENNE, VALEUR_NOUVELLE )         values           ('" + Conversions.ToString(Conversions.ToDate(DateTime.Now.ToString("dd/MM/yyy"))) + "' ,'" + Conversions.ToString(Conversions.ToDate(DateTime.Now.ToString("HH:mm:ss"))) + "' ,'" + Module1._USERNAME + "'  ,'" + Text_ID_FOURNISSEUR.Text + "'   ,'" + Text_FOURNISSEUR.Text + "' ,'" + Text_VALEUR_ANCIENNE.Text + "' ,'" + Text_VALEUR_NOUVELLE.Text + "'      )        ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE     TABLE_FOURNISSEURS    SET    CREDIT_INITIAL =   " + Conversions.ToString(Conversion.Val(Text_VALEUR_NOUVELLE.Text)) + "     WHERE    ID_FOURNISSEUR  = '" + Text_ID_FOURNISSEUR.Text + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val2.Commit();
					Module1.cn_SQL.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					val2.Rollback();
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				MyProject.Forms.Form_6_FOURNISSEURS.Picture_REFRESH_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Form)this).Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
