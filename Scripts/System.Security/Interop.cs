using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class Interop
{
	internal class Kernel32
	{
		[PreserveSig]
		private static extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, [Out] StringBuilder lpBuffer, int nSize, IntPtr[] arguments);

		internal static string GetMessage(int errorCode)
		{
			return null;
		}

		internal static string GetMessage(IntPtr moduleHandle, int errorCode)
		{
			return null;
		}

		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, StringBuilder sb, out string errorMsg)
		{
			errorMsg = null;
			return false;
		}
	}

	internal class Crypt32
	{
		[Flags]
		internal enum CryptProtectDataFlags
		{
			CRYPTPROTECT_UI_FORBIDDEN = 1,
			CRYPTPROTECT_LOCAL_MACHINE = 4,
			CRYPTPROTECT_CRED_SYNC = 8,
			CRYPTPROTECT_AUDIT = 0x10,
			CRYPTPROTECT_NO_RECOVERY = 0x20,
			CRYPTPROTECT_VERIFY_PROTECTION = 0x40
		}

		internal struct DATA_BLOB
		{
			internal uint cbData;

			internal IntPtr pbData;

			internal DATA_BLOB(IntPtr handle, uint size)
			{
				cbData = 0u;
				pbData = (IntPtr)0;
			}
		}

		[PreserveSig]
		internal static extern bool CryptProtectData([In] ref DATA_BLOB pDataIn, [In] string szDataDescr, [In] ref DATA_BLOB pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In] CryptProtectDataFlags dwFlags, out DATA_BLOB pDataOut);

		[PreserveSig]
		internal static extern bool CryptUnprotectData([In] ref DATA_BLOB pDataIn, [In] IntPtr ppszDataDescr, [In] ref DATA_BLOB pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In] CryptProtectDataFlags dwFlags, out DATA_BLOB pDataOut);
	}
}
