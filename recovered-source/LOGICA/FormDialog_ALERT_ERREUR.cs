using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ALERT_ERREUR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

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
			EventHandler eventHandler = TextBox1_TextChanged;
			EventHandler eventHandler2 = TextBox1_DoubleClick;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).TextChanged -= eventHandler;
				((Control)_TextBox1).DoubleClick -= eventHandler2;
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).TextChanged += eventHandler;
				((Control)_TextBox1).DoubleClick += eventHandler2;
			}
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).Click -= eventHandler;
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).Click -= eventHandler;
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_ALERT_ERREUR()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_ERREUR_Load;
		((Form)this).Shown += FormDialog_ERREUR_Shown;
		((Control)this).KeyDown += me_KeyDown;
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
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ALERT_ERREUR));
		Label18 = new Label();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label1 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		Label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.Black;
		Label label = Label18;
		Point location = new Point(12, 39);
		((Control)label).Location = location;
		((Control)Label18).Name = "Label18";
		Label label2 = Label18;
		Size size = new Size(452, 74);
		((Control)label2).Size = size;
		((Control)Label18).TabIndex = 690;
		((Control)Label18).Tag = "ZEDZE";
		((Control)Label_BOTTOM).BackColor = Color.Red;
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(6, 410);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(892, 6);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 859;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.Red;
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 0);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(6, 416);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 858;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.Red;
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(898, 0);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(6, 416);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 857;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label1).BackColor = Color.Red;
		((Control)Label1).Cursor = Cursors.Hand;
		((Control)Label1).Dock = (DockStyle)1;
		((Control)Label1).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label3 = Label1;
		location = new Point(6, 0);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(892, 29);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.TextAlign = (ContentAlignment)16;
		TextBox textBox = TextBox1;
		location = new Point(12, 32);
		((Control)textBox).Location = location;
		TextBox1.Multiline = true;
		((Control)TextBox1).Name = "TextBox1";
		((TextBoxBase)TextBox1).ReadOnly = true;
		TextBox1.ScrollBars = (ScrollBars)2;
		TextBox textBox2 = TextBox1;
		size = new Size(880, 372);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 861;
		((Control)Label2).BackColor = Color.Red;
		((Control)Label2).Cursor = Cursors.Hand;
		((Control)Label2).Font = new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label5 = Label2;
		location = new Point(843, 0);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(61, 29);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 1;
		Label2.Text = "X";
		Label2.TextAlign = (ContentAlignment)64;
		((Control)Label3).BackColor = Color.Red;
		((Control)Label3).Cursor = Cursors.Hand;
		((Control)Label3).Font = new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label3.Image = (Image)componentResourceManager.GetObject("Label3.Image");
		Label3.ImageAlign = (ContentAlignment)16;
		Label label7 = Label3;
		location = new Point(4, 0);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(61, 29);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 862;
		Label3.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(904, 416);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label18);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "FormDialog_ALERT_ERREUR";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Form1";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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

	private void FormDialog_ERREUR_Load(object sender, EventArgs e)
	{
		TextBox1.Text = "";
	}

	private void FormDialog_ERREUR_Shown(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).SelectionStart = ((TextBoxBase)TextBox1).TextLength;
		((TextBoxBase)TextBox1).ScrollToCaret();
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void TextBox1_DoubleClick(object sender, EventArgs e)
	{
		TextBox1.Text = "";
		TextBox1.Text = File.ReadAllText(Application.StartupPath + "\\log_erreur.sni");
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Voulez-vous vraiment Vider le LOG ??", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
		{
			File.WriteAllText(Application.StartupPath + "\\log_erreur.sni", "");
			((Form)this).Close();
		}
	}
}
