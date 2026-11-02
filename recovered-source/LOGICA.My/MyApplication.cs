using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace LOGICA.My;

[GeneratedCode("MyTemplate", "14.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	internal static void Main(string[] Args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		// In the isolated portable package, a direct EXE launch must use the same
		// authenticated MariaDB setup as Start-LOGICA.cmd. Do not expose or
		// duplicate the per-user DPAPI-protected database credentials.
		if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")))
		{
			string launcher = System.IO.Path.Combine(Application.StartupPath, "Launch-LOGICA.ps1");
			if (System.IO.File.Exists(launcher))
			{
				try
				{
					var start = new ProcessStartInfo("powershell.exe",
						"-NoLogo -NoProfile -ExecutionPolicy Bypass -File \\"" + launcher + "\\"")
					{
						WorkingDirectory = Application.StartupPath,
						UseShellExecute = false
					};
					Process.Start(start);
					return; // Launcher will run LOGICA.exe with verified DB connection.
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to start the local MariaDB launcher: " + ex.Message,
						"Hanouty POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(Args);
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		__ENCAddToList(this);
		base.IsSingleInstance = true;
		base.EnableVisualStyles = true;
		((WindowsFormsApplicationBase)this).SaveMySettingsOnExit = true;
		base.ShutdownStyle = (ShutdownMode)0;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = (Form)(object)MyProject.Forms.Form_0_TEMPLATE;
	}
}
