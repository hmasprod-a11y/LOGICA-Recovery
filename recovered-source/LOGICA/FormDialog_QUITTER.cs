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
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_QUITTER : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel_remise")]
	private Panel _Panel_remise;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	internal virtual Panel Panel_remise
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_remise;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_remise = value;
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

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
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

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
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

	[DebuggerNonUserCode]
	public FormDialog_QUITTER()
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
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_QUITTER));
		Panel_remise = new Panel();
		Button2 = new Button();
		Button5 = new Button();
		Button4 = new Button();
		Button3 = new Button();
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		Label4 = new Label();
		ProgressBar1 = new ProgressBar();
		PictureBox2 = new PictureBox();
		((Control)Panel_remise).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_remise).BackColor = Color.FromArgb(249, 249, 249);
		Panel_remise.BorderStyle = (BorderStyle)1;
		((Control)Panel_remise).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel_remise).Controls.Add((Control)(object)Button2);
		((Control)Panel_remise).Controls.Add((Control)(object)Button5);
		((Control)Panel_remise).Controls.Add((Control)(object)Button4);
		((Control)Panel_remise).Controls.Add((Control)(object)Button3);
		((Control)Panel_remise).Controls.Add((Control)(object)Button1);
		((Control)Panel_remise).Controls.Add((Control)(object)CheckBox1);
		((Control)Panel_remise).Controls.Add((Control)(object)Label4);
		Panel panel_remise = Panel_remise;
		Point location = new Point(1, 0);
		((Control)panel_remise).Location = location;
		((Control)Panel_remise).Name = "Panel_remise";
		Panel panel_remise2 = Panel_remise;
		Size size = new Size(379, 389);
		((Control)panel_remise2).Size = size;
		((Control)Panel_remise).TabIndex = 2;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button2).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button = Button2;
		location = new Point(91, 336);
		((Control)button).Location = location;
		Button button2 = Button2;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button3 = Button2;
		size = new Size(84, 37);
		((Control)button3).Size = size;
		((Control)Button2).TabIndex = 704;
		((ButtonBase)Button2).Text = "Restore";
		((ButtonBase)Button2).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button2).UseCompatibleTextRendering = true;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button2).Visible = false;
		((ButtonBase)Button5).BackColor = Color.FromArgb(255, 192, 192);
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).FlatStyle = (FlatStyle)0;
		((Control)Button5).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button5).ForeColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		((ButtonBase)Button5).ImageAlign = (ContentAlignment)64;
		Button button4 = Button5;
		location = new Point(79, 203);
		((Control)button4).Location = location;
		Button button5 = Button5;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button5).Name = "Button5";
		Button button6 = Button5;
		size = new Size(219, 66);
		((Control)button6).Size = size;
		((Control)Button5).TabIndex = 703;
		((ButtonBase)Button5).Text = "       Arrêter";
		((ButtonBase)Button5).TextAlign = (ContentAlignment)16;
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		((Control)Button4).Cursor = Cursors.Hand;
		((ButtonBase)Button4).FlatStyle = (FlatStyle)0;
		((Control)Button4).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button4).ForeColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button4).Image = (Image)componentResourceManager.GetObject("Button4.Image");
		((ButtonBase)Button4).ImageAlign = (ContentAlignment)64;
		Button button7 = Button4;
		location = new Point(79, 122);
		((Control)button7).Location = location;
		Button button8 = Button4;
		margin = new Padding(0);
		((Control)button8).Margin = margin;
		((Control)Button4).Name = "Button4";
		Button button9 = Button4;
		size = new Size(219, 66);
		((Control)button9).Size = size;
		((Control)Button4).TabIndex = 702;
		((ButtonBase)Button4).Text = "       Quitter";
		((ButtonBase)Button4).TextAlign = (ContentAlignment)16;
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button3).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button10 = Button3;
		location = new Point(7, 336);
		((Control)button10).Location = location;
		Button button11 = Button3;
		margin = new Padding(0);
		((Control)button11).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button12 = Button3;
		size = new Size(84, 37);
		((Control)button12).Size = size;
		((Control)Button3).TabIndex = 699;
		((ButtonBase)Button3).Text = "Backup ";
		((ButtonBase)Button3).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button3).UseCompatibleTextRendering = true;
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Button1).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button13 = Button1;
		location = new Point(217, 336);
		((Control)button13).Location = location;
		Button button14 = Button1;
		margin = new Padding(0);
		((Control)button14).Margin = margin;
		((Control)Button1).Name = "Button1";
		Button button15 = Button1;
		size = new Size(152, 37);
		((Control)button15).Size = size;
		((Control)Button1).TabIndex = 696;
		((ButtonBase)Button1).Text = "Fermer       ";
		((ButtonBase)Button1).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((ButtonBase)CheckBox1).AutoSize = true;
		CheckBox1.Checked = true;
		CheckBox1.CheckState = (CheckState)1;
		CheckBox checkBox = CheckBox1;
		location = new Point(79, 272);
		((Control)checkBox).Location = location;
		((Control)CheckBox1).Name = "CheckBox1";
		CheckBox checkBox2 = CheckBox1;
		size = new Size(168, 17);
		((Control)checkBox2).Size = size;
		((Control)CheckBox1).TabIndex = 695;
		((ButtonBase)CheckBox1).Text = "Backup interne à la fermeture";
		((ButtonBase)CheckBox1).UseVisualStyleBackColor = true;
		((Control)Label4).BackColor = Color.FromArgb(22, 106, 238);
		Label label = Label4;
		location = new Point(-3, 0);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(416, 12);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 0;
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 383);
		((Control)progressBar).Location = location;
		ProgressBar1.MarqueeAnimationSpeed = 1;
		((Control)ProgressBar1).Name = "ProgressBar1";
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(379, 17);
		((Control)progressBar2).Size = size;
		ProgressBar1.Style = (ProgressBarStyle)1;
		((Control)ProgressBar1).TabIndex = 698;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(79, 15);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(219, 104);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2.TabIndex = 705;
		PictureBox2.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(380, 401);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Panel_remise);
		((Control)this).Controls.Add((Control)(object)ProgressBar1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_QUITTER";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Quitter LÓGICA";
		((Control)Panel_remise).ResumeLayout(false);
		((Control)Panel_remise).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public string CreateBackupAt(string destination)
	{
		return DatabaseBackup.CreateToFile(Module1.DatabaseConnectionStringForMaintenance(), destination,
			DatabaseBackup.FindServerBin(Application.StartupPath));
	}

	public void BackupBeforeShutdown(Action shutdown) { BackupBeforeExit(shutdown); }

	public void BackupBeforeExit(Action shutdown)
	{
		if (shutdown == null) throw new ArgumentNullException("shutdown");
		if (CheckBox1.Checked)
		{
			string root = Module1._CHEMIN_FOLDER;
			if (string.IsNullOrWhiteSpace(root) || !Path.IsPathRooted(root)) root = Application.StartupPath;
			DatabaseBackup.Create(Module1.DatabaseConnectionStringForMaintenance(), Path.Combine(root, "bd", "backup"),
				DatabaseBackup.FindServerBin(Application.StartupPath));
		}
		shutdown();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		try
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.Filter = "Sauvegarde MySQL (*.sql)|*.sql";
				dialog.DefaultExt = "sql";
				dialog.FileName = "Backup_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".sql";
				if (dialog.ShowDialog() != DialogResult.OK) return;
				string file = CreateBackupAt(dialog.FileName);
				MessageBox.Show("Sauvegarde MySQL vérifiée : " + file, "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		catch (Exception error) { MessageBox.Show("Sauvegarde annulée : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		var control = sender as Control;
		try
		{
			if (control != null) control.Enabled = false;
			ProgressBar1.Style = ProgressBarStyle.Marquee;
			BackupBeforeShutdown(() => Interaction.Shell("shutdown -s -t 1"));
		}
		catch (Exception error)
		{
			MessageBox.Show("Arrêt annulé : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			if (control != null) control.Enabled = true;
			ProgressBar1.Style = ProgressBarStyle.Continuous;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button4_Click(object sender, EventArgs e)
	{
		try { BackupBeforeExit(() => ProjectData.EndApp()); }
		catch (Exception error) { MessageBox.Show("Fermeture annulée : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = "bd (sni)|*.sni";
			if ((int)((CommonDialog)val).ShowDialog() == 1 && Operators.CompareString(((FileDialog)val).FileName, "", TextCompare: false) != 0)
			{
				if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(Module1._CHEMIN_FOLDER + "\\bd\\config\\configue.sni"))
				{
					((ServerComputer)MyProject.Computer).FileSystem.RenameFile(Module1._CHEMIN_FOLDER + "\\bd\\config\\configue.sni", "configue_old_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss") + ".sni");
				}
				((ServerComputer)MyProject.Computer).FileSystem.CopyFile(((FileDialog)val).FileName, Module1._CHEMIN_FOLDER + "\\bd\\config\\configue.sni", true);
				MessageBox.Show("importation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
}

