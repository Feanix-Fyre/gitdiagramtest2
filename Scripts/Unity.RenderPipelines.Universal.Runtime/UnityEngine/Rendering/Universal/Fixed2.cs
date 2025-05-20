using System.Diagnostics;

namespace UnityEngine.Rendering.Universal;

internal struct Fixed2<T> where T : struct
{
	public T item1;

	public T item2;

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public Fixed2(T item1)
	{
		this.item1 = default(T);
		item2 = default(T);
	}

	public Fixed2(T item1, T item2)
	{
		this.item1 = default(T);
		this.item2 = default(T);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckRange(int index)
	{
	}
}
