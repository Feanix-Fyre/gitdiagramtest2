using System;
using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeHashSetDebuggerTypeProxy<T> where T : struct, IEquatable<T>
{
	private UnsafeParallelHashSet<T> Data;

	public List<T> Items => null;

	public UnsafeHashSetDebuggerTypeProxy(UnsafeParallelHashSet<T> data)
	{
	}
}
