namespace System.Runtime.CompilerServices;

internal static class JitHelpers
{
	internal static T UnsafeCast<T>(object o) where T : class
	{
		return null;
	}

	internal static int UnsafeEnumCast<T>(T val) where T : struct
	{
		return 0;
	}

	internal static long UnsafeEnumCastLong<T>(T val) where T : struct
	{
		return 0L;
	}
}
