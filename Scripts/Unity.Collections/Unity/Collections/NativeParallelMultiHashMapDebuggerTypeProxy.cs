using System;
using System.Collections.Generic;

namespace Unity.Collections;

internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
{
	private NativeParallelMultiHashMap<TKey, TValue> m_Target;

	public List<ListPair<TKey, List<TValue>>> Items => null;

	public NativeParallelMultiHashMapDebuggerTypeProxy(NativeParallelMultiHashMap<TKey, TValue> target)
	{
	}
}
