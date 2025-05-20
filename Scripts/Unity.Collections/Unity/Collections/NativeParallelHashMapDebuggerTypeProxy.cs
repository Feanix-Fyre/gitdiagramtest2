using System;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

internal sealed class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	private UnsafeParallelHashMap<TKey, TValue> m_Target;

	public List<Pair<TKey, TValue>> Items => null;

	public NativeParallelHashMapDebuggerTypeProxy(NativeParallelHashMap<TKey, TValue> target)
	{
	}
}
