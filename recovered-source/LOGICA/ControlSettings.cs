using System.Diagnostics;

namespace LOGICA;

public class ControlSettings
{
	public string FormName
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string ControlName
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string ControlValue
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[DebuggerNonUserCode]
	public ControlSettings()
	{
	}
}
