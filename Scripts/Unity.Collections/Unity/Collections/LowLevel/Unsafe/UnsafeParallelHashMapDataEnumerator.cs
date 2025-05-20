using System;

namespace Unity.Collections.LowLevel.Unsafe;

internal struct UnsafeParallelHashMapDataEnumerator
{
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	internal int m_Index;

	internal int m_BucketIndex;

	internal int m_NextIndex;

	internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data)
	{
		m_Buffer = null;
		m_Index = 0;
		m_BucketIndex = 0;
		m_NextIndex = 0;
	}

	internal bool MoveNext()
	{
		return false;
	}

	internal void Reset()
	{
	}

	internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>() where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(KeyValue<TKey, TValue>);
	}

	internal TKey GetCurrentKey<TKey>() where TKey : struct, IEquatable<TKey>
	{
		return default(TKey);
	}
}
