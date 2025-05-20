using System;

namespace Newtonsoft.Json.Utilities;

internal readonly struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> where T1 : notnull where T2 : notnull
{
	public readonly T1 Value1;

	public readonly T2 Value2;

	public StructMultiKey(T1 v1, T2 v2)
	{
		Value1 = default(T1);
		Value2 = default(T2);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object? obj)
	{
		return false;
	}

	public bool Equals(StructMultiKey<T1, T2> other)
	{
		return false;
	}
}
