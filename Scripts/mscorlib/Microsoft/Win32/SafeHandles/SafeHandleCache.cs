using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles;

internal static class SafeHandleCache<T> where T : SafeHandle
{
	private static T s_invalidHandle;

	internal static bool IsCachedInvalidHandle(SafeHandle handle)
	{
		return false;
	}
}
