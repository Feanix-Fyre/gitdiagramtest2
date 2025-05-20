using System;
using System.Collections.Generic;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

public static class UnsafeListExtension
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal static ref UnsafeList ListData<T>(this ref UnsafeList<T> from) where T : struct
	{
		throw null;
	}

	public static void Sort<T>(this UnsafeList list) where T : struct, IComparable<T>
	{
	}

	public static void Sort<T, U>(this UnsafeList list, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Obsolete("Instead call SortJob(this UnsafeList).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	[NotBurstCompatible]
	public static JobHandle Sort<T>(this UnsafeList container, JobHandle inputDeps) where T : struct, IComparable<T>
	{
		return default(JobHandle);
	}

	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(this UnsafeList list) where T : struct, IComparable<T>
	{
		return default(SortJob<T, NativeSortExtension.DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T, U>(this UnsafeList container, U comp, JobHandle inputDeps) where T : struct where U : IComparer<T>
	{
		return default(JobHandle);
	}

	public static SortJob<T, U> SortJob<T, U>(this UnsafeList list, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	public static int BinarySearch<T>(this UnsafeList container, T value) where T : struct, IComparable<T>
	{
		return 0;
	}

	public static int BinarySearch<T, U>(this UnsafeList container, T value, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}
}
