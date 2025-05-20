using System;

namespace Newtonsoft.Json.Utilities;

public static class AotHelper
{
	private static bool s_alwaysFalse;

	public static void Ensure(Action action)
	{
	}

	public static void EnsureType<T>() where T : new()
	{
	}

	public static void EnsureList<T>()
	{
	}

	public static void EnsureDictionary<TKey, TValue>()
	{
	}

	public static bool IsFalse()
	{
		return false;
	}
}
