using System.Runtime.CompilerServices;

namespace System;

internal static class LocalAppContextSwitches
{
	private static int s_allowArbitraryTypeInstantiation;

	public static bool AllowArbitraryTypeInstantiation
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}
}
