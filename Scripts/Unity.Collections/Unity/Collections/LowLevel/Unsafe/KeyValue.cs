using System;
using System.Diagnostics;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
[DebuggerDisplay("Key = {Key}, Value = {Value}")]
public struct KeyValue<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	internal int m_Index;

	internal int m_Next;

	public static KeyValue<TKey, TValue> Null => default(KeyValue<TKey, TValue>);

	public TKey Key => default(TKey);

	public ref TValue Value
	{
		get
		{
			throw null;
		}
	}

	public bool GetKeyValue(out TKey key, out TValue value)
	{
		key = default(TKey);
		value = default(TValue);
		return false;
	}
}
