using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.InputSystem.Utilities;

internal static class ArrayHelpers
{
	public static int LengthSafe<TValue>(this TValue[] array)
	{
		return 0;
	}

	public static void Clear<TValue>(this TValue[] array)
	{
	}

	public static void Clear<TValue>(this TValue[] array, int count)
	{
	}

	public static void Clear<TValue>(this TValue[] array, ref int count)
	{
	}

	public static void EnsureCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10)
	{
	}

	public static void DuplicateWithCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10)
	{
	}

	public static bool Contains<TValue>(TValue[] array, TValue value)
	{
		return false;
	}

	public static bool ContainsReference<TValue>(this TValue[] array, TValue value) where TValue : class
	{
		return false;
	}

	public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int count, TSecond value) where TFirst : TSecond where TSecond : class
	{
		return false;
	}

	public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int startIndex, int count, TSecond value) where TFirst : TSecond where TSecond : class
	{
		return false;
	}

	public static bool HaveDuplicateReferences<TFirst>(this TFirst[] first, int index, int count)
	{
		return false;
	}

	public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = int.MaxValue)
	{
		return false;
	}

	public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0, int count = -1)
	{
		return 0;
	}

	public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate)
	{
		return 0;
	}

	public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate, int startIndex = 0, int count = -1)
	{
		return 0;
	}

	public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int count = -1) where TFirst : TSecond where TSecond : class
	{
		return 0;
	}

	public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int startIndex, int count) where TFirst : TSecond where TSecond : class
	{
		return 0;
	}

	public static int IndexOfValue<TValue>(this TValue[] array, TValue value, int startIndex = 0, int count = -1) where TValue : struct, IEquatable<TValue>
	{
		return 0;
	}

	public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Allocator allocator) where TValue : struct
	{
	}

	public static int Append<TValue>(ref TValue[] array, TValue value)
	{
		return 0;
	}

	public static int Append<TValue>(ref TValue[] array, IEnumerable<TValue> values)
	{
		return 0;
	}

	public static int AppendToImmutable<TValue>(ref TValue[] array, TValue[] values)
	{
		return 0;
	}

	public static int AppendWithCapacity<TValue>(ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10)
	{
		return 0;
	}

	public static int AppendListWithCapacity<TValue, TValues>(ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10) where TValues : IReadOnlyList<TValue>
	{
		return 0;
	}

	public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : struct
	{
		return 0;
	}

	public static void InsertAt<TValue>(ref TValue[] array, int index, TValue value)
	{
	}

	public static void InsertAtWithCapacity<TValue>(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10)
	{
	}

	public static void PutAtIfNotSet<TValue>(ref TValue[] array, int index, Func<TValue> valueFn)
	{
	}

	public static int GrowBy<TValue>(ref TValue[] array, int count)
	{
		return 0;
	}

	public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Allocator allocator = Allocator.Persistent) where TValue : struct
	{
		return 0;
	}

	public static int GrowWithCapacity<TValue>(ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10)
	{
		return 0;
	}

	public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : struct
	{
		return 0;
	}

	public static TValue[] Join<TValue>(TValue value, params TValue[] values)
	{
		return null;
	}

	public static TValue[] Merge<TValue>(TValue[] first, TValue[] second) where TValue : IEquatable<TValue>
	{
		return null;
	}

	public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer)
	{
		return null;
	}

	public static void EraseAt<TValue>(ref TValue[] array, int index)
	{
	}

	public static void EraseAtWithCapacity<TValue>(this TValue[] array, ref int count, int index)
	{
	}

	public static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index) where TValue : struct
	{
	}

	public static bool Erase<TValue>(ref TValue[] array, TValue value)
	{
		return false;
	}

	public static void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index)
	{
	}

	public static TValue[] Copy<TValue>(TValue[] array)
	{
		return null;
	}

	public static TValue[] Clone<TValue>(TValue[] array) where TValue : ICloneable
	{
		return null;
	}

	public static TNew[] Select<TOld, TNew>(TOld[] array, Func<TOld, TNew> converter)
	{
		return null;
	}

	private static void Swap<TValue>(ref TValue first, ref TValue second)
	{
	}

	public static void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count)
	{
	}

	public static void EraseSliceWithCapacity<TValue>(ref TValue[] array, ref int length, int index, int count)
	{
	}

	public static void SwapElements<TValue>(this TValue[] array, int index1, int index2)
	{
	}

	public static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2) where TValue : struct
	{
	}
}
