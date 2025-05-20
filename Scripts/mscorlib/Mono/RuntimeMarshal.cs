using System;

namespace Mono;

internal static class RuntimeMarshal
{
	internal static string PtrToUtf8String(IntPtr ptr)
	{
		return null;
	}

	internal static SafeStringMarshal MarshalString(string str)
	{
		return default(SafeStringMarshal);
	}

	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr)
	{
		out_ptr = default(IntPtr);
		return 0;
	}

	internal static byte[] DecodeBlobArray(IntPtr ptr)
	{
		return null;
	}

	internal static int AsciHexDigitValue(int c)
	{
		return 0;
	}

	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct)
	{
	}
}
