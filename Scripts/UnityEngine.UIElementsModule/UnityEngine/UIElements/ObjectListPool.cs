using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class ObjectListPool<T>
{
	private static ObjectPool<List<T>> pool;

	public static List<T> Get()
	{
		return null;
	}

	public static void Release(List<T> elements)
	{
	}
}
