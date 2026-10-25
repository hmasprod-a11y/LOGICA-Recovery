using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LOGICA;

public class RawPrinterHelper
{
	[StructLayout(LayoutKind.Sequential)]
	public class DOCINFOA
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string pDocName;

		[MarshalAs(UnmanagedType.LPStr)]
		public string pOutputFile;

		[MarshalAs(UnmanagedType.LPStr)]
		public string pDataType;

		[DebuggerNonUserCode]
		public DOCINFOA()
		{
		}
	}

	private IntPtr hPrinter;

	private DOCINFOA di;

	private bool PrinterOpen;

	public bool PrinterIsOpen => PrinterOpen;

	public RawPrinterHelper()
	{
		ref IntPtr reference = ref hPrinter;
		reference = new IntPtr(0);
		di = new DOCINFOA();
		PrinterOpen = false;
	}

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "OpenPrinterA", ExactSpelling = true, SetLastError = true)]
	public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, ref IntPtr hPrinter, IntPtr pd);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	public static extern bool ClosePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "StartDocPrinterA", ExactSpelling = true, SetLastError = true)]
	public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In][MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndDocPrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	public static extern bool StartPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, ref int dwWritten);

	public bool OpenPrint(string szPrinterName)
	{
		if (!PrinterOpen)
		{
			di.pDocName = ".NET RAW Document";
			di.pDataType = "RAW";
			if (OpenPrinter(szPrinterName.Normalize(), ref hPrinter, IntPtr.Zero) && StartDocPrinter(hPrinter, 1, di) && StartPagePrinter(hPrinter))
			{
				PrinterOpen = true;
			}
		}
		return PrinterOpen;
	}

	public void ClosePrint()
	{
		if (PrinterOpen)
		{
			EndPagePrinter(hPrinter);
			EndDocPrinter(hPrinter);
			ClosePrinter(hPrinter);
			PrinterOpen = false;
		}
	}

	public bool SendStringToPrinter(string szPrinterName, string szString)
	{
		bool result;
		if (PrinterOpen)
		{
			int dwWritten = 0;
			int length = szString.Length;
			IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(szString);
			result = WritePrinter(hPrinter, intPtr, length, ref dwWritten);
			Marshal.FreeCoTaskMem(intPtr);
		}
		else
		{
			result = false;
		}
		return result;
	}
}
