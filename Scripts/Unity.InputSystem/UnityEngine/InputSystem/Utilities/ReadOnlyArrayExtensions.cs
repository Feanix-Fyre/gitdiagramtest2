using System;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

public static class ReadOnlyArrayExtensions
{
	public static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : IComparable<TValue>
	{
		return false;
	}

	public static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
	{
		return false;
	}

	public static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
	{
		return 0;
	}

	internal static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = int.MaxValue)
	{
		return false;
	}
}
