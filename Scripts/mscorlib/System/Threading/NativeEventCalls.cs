using Microsoft.Win32.SafeHandles;

namespace System.Threading;

internal static class NativeEventCalls
{
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
	{
		errorCode = default(int);
		return (IntPtr)0;
	}

	private unsafe static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode)
	{
		errorCode = default(int);
		return (IntPtr)0;
	}

	public static bool SetEvent(SafeWaitHandle handle)
	{
		return false;
	}

	private static bool SetEvent_internal(IntPtr handle)
	{
		return false;
	}

	public static bool ResetEvent(SafeWaitHandle handle)
	{
		return false;
	}

	private static bool ResetEvent_internal(IntPtr handle)
	{
		return false;
	}

	public static void CloseEvent_internal(IntPtr handle)
	{
	}
}
