using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LOGICA;

public class RawPrinterHelperr
{
	public struct DOCINFOA
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string pDocName;

		[MarshalAs(UnmanagedType.LPStr)]
		public string pOutputFile;

		[MarshalAs(UnmanagedType.LPStr)]
		public string pDataType;
	}

	[DebuggerNonUserCode]
	public RawPrinterHelperr()
	{
	}

	[DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true)]
	public static extern bool OpenPrinter(string szPrinter, ref IntPtr hPrinter, IntPtr pd);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool StartDocPrinter(IntPtr hPrinter, int Level, ref DOCINFOA di);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool StartPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, ref int dwWritten);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool EndPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool EndDocPrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", SetLastError = true)]
	public static extern bool ClosePrinter(IntPtr hPrinter);

	public static bool SendStringToPrinter(string printerName, string command)
	{
		int length = command.Length;
		IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(command);
		bool result = SendBytesToPrinter(printerName, intPtr, length);
		Marshal.FreeCoTaskMem(intPtr);
		return result;
	}

	public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
	{
		IntPtr hPrinter = IntPtr.Zero;
		DOCINFOA di = default;
		int dwWritten = 0;
		bool result = false;
		di.pDocName = "OpenDrawer";
		di.pDataType = "RAW";
		if (OpenPrinter(szPrinterName.Normalize(), ref hPrinter, IntPtr.Zero))
		{
			if (StartDocPrinter(hPrinter, 1, ref di))
			{
				if (StartPagePrinter(hPrinter))
				{
					result = WritePrinter(hPrinter, pBytes, dwCount, ref dwWritten);
					EndPagePrinter(hPrinter);
				}
				EndDocPrinter(hPrinter);
			}
			ClosePrinter(hPrinter);
		}
		return result;
	}
}
