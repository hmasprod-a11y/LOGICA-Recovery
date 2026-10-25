using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[DesignerGenerated]
public class Report_BC : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ReportViewer1")]
	private ReportViewer _ReportViewer1;

	[AccessedThroughProperty("DataTable_BRBindingSource")]
	private BindingSource _DataTable_BRBindingSource;

	[AccessedThroughProperty("Report_0_DATASET")]
	private Report_0_DATASET _Report_0_DATASET;

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

	internal virtual BindingSource DataTable_BRBindingSource
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataTable_BRBindingSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataTable_BRBindingSource = value;
		}
	}

	internal virtual Report_0_DATASET Report_0_DATASET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Report_0_DATASET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Report_0_DATASET = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_BC()
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		DataTable_BRBindingSource = new BindingSource(components);
		Report_0_DATASET = new Report_0_DATASET();
		ReportViewer1 = new ReportViewer();
		((ISupportInitialize)DataTable_BRBindingSource).BeginInit();
		((ISupportInitialize)Report_0_DATASET).BeginInit();
		((Control)this).SuspendLayout();
		DataTable_BRBindingSource.DataMember = "DataTable_BR";
		DataTable_BRBindingSource.DataSource = Report_0_DATASET;
		Report_0_DATASET.DataSetName = "Report_0_DATASET";
		Report_0_DATASET.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)ReportViewer1).Dock = (DockStyle)5;
		val.Name = "DataSet1";
		val.Value = DataTable_BRBindingSource;
		((Collection<ReportDataSource>)(object)ReportViewer1.LocalReport.DataSources).Add(val);
		ReportViewer1.LocalReport.ReportEmbeddedResource = "LOGICA.Report_1_BC.rdlc";
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
		((Control)this).Name = "Report_BC";
		((Form)this).ShowIcon = false;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)DataTable_BRBindingSource).EndInit();
		((ISupportInitialize)Report_0_DATASET).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Report_A4_PORTRAIT_Load(object sender, EventArgs e)
	{
	}
}
