using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class Report_DEVIS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ReportViewer1")]
	private ReportViewer _ReportViewer1;

	internal virtual ReportViewer ReportViewer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReportViewer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReportViewer1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_DEVIS()
	{
		((Form)this).Load += Report_A4_PORTRAIT_Load;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		ReportViewer1 = new ReportViewer();
		((Control)this).SuspendLayout();
		((Control)ReportViewer1).Dock = (DockStyle)5;
		ReportViewer1.LocalReport.ReportEmbeddedResource = "LOGICA.Report_4_DEVIS.rdlc";
		ReportViewer reportViewer = ReportViewer1;
		Point location = new Point(0, 0);
		((Control)reportViewer).Location = location;
		((Control)ReportViewer1).Name = "ReportViewer1";
		ReportViewer reportViewer2 = ReportViewer1;
		Size size = new Size(321, 366);
		((Control)reportViewer2).Size = size;
		((Control)ReportViewer1).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(321, 366);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)ReportViewer1);
		((Control)this).Name = "Report_DEVIS";
		((Form)this).ShowIcon = false;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	private void Report_A4_PORTRAIT_Load(object sender, EventArgs e)
	{
	}
}
