using System.Runtime.InteropServices;

namespace Unity.Collections.LowLevel.Unsafe;

internal static class BurstRuntime
{
	[StructLayout((LayoutKind)0, Size = 1)]
	private struct HashCode64<T>
	{
		public static readonly long Value;
	}

	public static long GetHashCode64<T>()
	{
		return 0L;
	}

	internal static long HashStringWithFNV1A64(string text)
	{
		return 0L;
	}
}
