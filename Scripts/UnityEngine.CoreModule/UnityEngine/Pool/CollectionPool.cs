using System.Collections.Generic;

namespace UnityEngine.Pool;

public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
{
	internal static readonly ObjectPool<TCollection> s_Pool;

	public static TCollection Get()
	{
		return null;
	}

	public static PooledObject<TCollection> Get(out TCollection value)
	{
		value = null;
		return default(PooledObject<TCollection>);
	}

	public static void Release(TCollection toRelease)
	{
	}
}
