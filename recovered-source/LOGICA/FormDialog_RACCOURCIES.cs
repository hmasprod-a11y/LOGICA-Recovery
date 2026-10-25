using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_RACCOURCIES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

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

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox2 = value;
		}
	}

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

	[DebuggerNonUserCode]
	public FormDialog_RACCOURCIES()
	{
		((Form)this).Load += FormDialog_INTERFACES_Load;
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
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Obj, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_RACCOURCIES));
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button7 = new Button();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		Label4 = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Button20 = new Button();
		((Control)this).SuspendLayout();
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		Point location = new Point(4, 444);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		Size size = new Size(513, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 1040;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 10);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 438);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 1039;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(517, 10);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 438);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 1038;
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
		size = new Size(521, 10);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 1037;
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button7).Image = (Image)componentResourceManager.GetObject("Button7.Image");
		((ButtonBase)Button7).ImeMode = (ImeMode)0;
		Button button = Button7;
		location = new Point(206, 159);
		((Control)button).Location = location;
		((Control)Button7).Name = "Button7";
		Button button2 = Button7;
		size = new Size(64, 43);
		((Control)button2).Size = size;
		((Control)Button7).TabIndex = 1047;
		((ButtonBase)Button7).UseVisualStyleBackColor = true;
		ListBox1.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox1.ItemHeight = 18;
		ListBox1.Items.AddRange(new object[17]
		{
			"DUPLICATA", "REMISE", "MODIF_PRIX", "MODIF_QTE", "PRIX", "DIVERS", "FLASH", "TIROIR", "LOCK", "COMMENTAIRE",
			"RAPPORT", "DEPENSES", "CLOTURE", "ATTENTE", "LISTE_ATTENTE", "RECHERCHE", "CALCULATRICE"
		});
		ListBox listBox = ListBox1;
		location = new Point(15, 50);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(174, 328);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 1046;
		ListBox2.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		((ListControl)ListBox2).FormattingEnabled = true;
		ListBox2.ItemHeight = 18;
		ListBox listBox3 = ListBox2;
		location = new Point(318, 126);
		((Control)listBox3).Location = location;
		((Control)ListBox2).Name = "ListBox2";
		ListBox listBox4 = ListBox2;
		size = new Size(191, 148);
		((Control)listBox4).Size = size;
		((Control)ListBox2).TabIndex = 1067;
		((Control)Label4).BackColor = Color.Violet;
		((Control)Label4).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label4.ImeMode = (ImeMode)0;
		Label label = Label4;
		location = new Point(12, 19);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(497, 26);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 1066;
		Label4.Text = "Les Raccourcies";
		Label4.TextAlign = (ContentAlignment)32;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Segoe UI", 14.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_CLOSE).ImeMode = (ImeMode)0;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(15, 390);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		Padding margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(174, 45);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 1068;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Segoe UI", 14.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button_SAVE).ImeMode = (ImeMode)0;
		Button button_SAVE = Button_SAVE;
		location = new Point(335, 390);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(174, 45);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1069;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)Button20).Cursor = Cursors.Hand;
		((Control)Button20).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button20).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button20).Image = (Image)componentResourceManager.GetObject("Button20.Image");
		((ButtonBase)Button20).ImageAlign = (ContentAlignment)16;
		Button button3 = Button20;
		location = new Point(479, 277);
		((Control)button3).Location = location;
		Button button4 = Button20;
		margin = new Padding(0);
		((Control)button4).Margin = margin;
		((Control)Button20).Name = "Button20";
		Button button5 = Button20;
		size = new Size(30, 25);
		((Control)button5).Size = size;
		((Control)Button20).TabIndex = 1070;
		((ButtonBase)Button20).UseCompatibleTextRendering = true;
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(521, 448);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button20);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Control)this).Controls.Add((Control)(object)Button_CLOSE);
		((Control)this).Controls.Add((Control)(object)ListBox2);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Button7);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)ListBox1);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_RACCOURCIES";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).ResumeLayout(false);
	}

	private void FormDialog_INTERFACES_Load(object sender, EventArgs e)
	{
		try
		{
			string[] array = File.ReadAllLines(Application.StartupPath + "/raccourcies.sni");
			ListBox2.Items.Clear();
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					ListBox2.Items.Add((object)text);
				}
			}
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

	private void Button_VALIDER_Click(object sender, EventArgs e)
	{
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		ListBox2.Items.Add((object)ListBox1.Text);
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		checked
		{
			int num = ListBox2.Items.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = text + "\r\n" + ListBox2.Items[num2].ToString();
				num2++;
			}
			File.WriteAllText(Application.StartupPath + "\\raccourcies.sni", text);
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			((Form)this).Close();
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		try
		{
			ListBox2.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox2.SelectedItem));
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

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
