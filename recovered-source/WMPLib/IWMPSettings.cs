using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[Guid("9104D1AB-80C9-4FED-ABF0-2E6417A6DF14")]
[TypeIdentifier]
[CompilerGenerated]
public interface IWMPSettings
{
	void _VtblGap1_1();

	[DispId(101)]
	bool autoStart
	{
		[DispId(101)]
		get;
		[DispId(101)]
		[param: In]
		set;
	}

	void _VtblGap2_17();

	[DispId(111)]
	void setMode([In][MarshalAs(UnmanagedType.BStr)] string bstrMode, [In] bool varfMode);
}
