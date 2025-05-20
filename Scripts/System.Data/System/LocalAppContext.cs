using System.Runtime.CompilerServices;

namespace System;

internal class LocalAppContext
{
	private static bool s_isDisableCachingInitialized;

	private static bool s_disableCaching;

	private static object s_syncObject;

	private static bool DisableCaching => false;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue)
	{
		return false;
	}

	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue)
	{
		return false;
	}
}
