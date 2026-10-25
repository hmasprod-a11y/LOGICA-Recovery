using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("74C09E02-F828-11D2-A74B-00A0C905F36E")]
public interface IWMPControls
{
	void _VtblGap1_1();

	[DispId(51)]
	void play();

	[DispId(52)]
	void stop();
}
