using System;
using System.Collections.Generic;

namespace Unity.Collections;

internal sealed class NativeHashSetDebuggerTypeProxy<T> where T : struct, IEquatable<T>
{
	private NativeParallelHashSet<T> Data;

	public List<T> Items => null;

	public NativeHashSetDebuggerTypeProxy(NativeParallelHashSet<T> data)
	{
	}
}
