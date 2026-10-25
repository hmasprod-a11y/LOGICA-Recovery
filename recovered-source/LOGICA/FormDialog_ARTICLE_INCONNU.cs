using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ARTICLE_INCONNU : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT1_Click;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT1 = value;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click += eventHandler;
			}
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

	[DebuggerNonUserCode]
	public FormDialog_ARTICLE_INCONNU()
	{
		((Form)this).Load += FormDialog_ARTICLE_INCONNU_Load;
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ARTICLE_INCONNU));
		Label18 = new Label();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		((Control)this).SuspendLayout();
		Label18.AutoSize = true;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 35.75f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.White;
		Label label = Label18;
		Point location = new Point(215, 124);
		((Control)label).Location = location;
		((Control)Label18).Name = "Label18";
		Label label2 = Label18;
		Size size = new Size(370, 56);
		((Control)label2).Size = size;
		((Control)Label18).TabIndex = 690;
		Label18.Text = "Article inconnu";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Tahoma", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_CLAVIER_NOSELECT1).Image = (Image)componentResourceManager.GetObject("Button_CLAVIER_NOSELECT1.Image");
		((ButtonBase)Button_CLAVIER_NOSELECT1).ImageAlign = (ContentAlignment)64;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT1;
		location = new Point(196, 286);
		((Control)button_CLAVIER_NOSELECT).Location = location;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = Button_CLAVIER_NOSELECT1;
		size = new Size(408, 125);
		((Control)button_CLAVIER_NOSELECT2).Size = size;
		((Control)Button_CLAVIER_NOSELECT1).TabIndex = 1;
		((ButtonBase)Button_CLAVIER_NOSELECT1).Text = "Fermer";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.Red;
		size = new Size(800, 423);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label18);
		((Control)this).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "FormDialog_ARTICLE_INCONNU";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Form1";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void FormDialog_ARTICLE_INCONNU_Load(object sender, EventArgs e)
	{
		SystemSounds.Asterisk.Play();
	}
}
