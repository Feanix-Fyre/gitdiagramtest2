using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class StyleCache
{
	private static Dictionary<long, ComputedStyle> s_ComputedStyleCache;

	private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache;

	private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache;

	public static bool TryGetValue(long hash, out ComputedStyle data)
	{
		data = default(ComputedStyle);
		return false;
	}

	public static void SetValue(long hash, ref ComputedStyle data)
	{
	}

	public static bool TryGetValue(int hash, out StyleVariableContext data)
	{
		data = null;
		return false;
	}

	public static void SetValue(int hash, StyleVariableContext data)
	{
	}

	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data)
	{
		data = null;
		return false;
	}

	public static void SetValue(int hash, ComputedTransitionProperty[] data)
	{
	}
}
