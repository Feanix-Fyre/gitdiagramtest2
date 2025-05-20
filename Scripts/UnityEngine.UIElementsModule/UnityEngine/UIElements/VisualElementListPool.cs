using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class VisualElementListPool
{
	private static ObjectPool<List<VisualElement>> pool;

	public static List<VisualElement> Copy(List<VisualElement> elements)
	{
		return null;
	}

	public static List<VisualElement> Get(int initialCapacity = 0)
	{
		return null;
	}

	public static void Release(List<VisualElement> elements)
	{
	}
}
