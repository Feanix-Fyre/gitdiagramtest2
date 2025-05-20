using System;
using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	private UnsafeParallelHashMap<TKey, TValue> m_Target;

	public List<Pair<TKey, TValue>> Items => null;

	public UnsafeParallelHashMapDebuggerTypeProxy(UnsafeParallelHashMap<TKey, TValue> target)
	{
	}
}
