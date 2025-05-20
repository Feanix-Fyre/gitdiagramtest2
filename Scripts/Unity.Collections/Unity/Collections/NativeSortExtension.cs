using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[BurstCompatible]
public static class NativeSortExtension
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct DefaultComparer<T> : IComparer<T> where T : IComparable<T>
	{
		public int Compare(T x, T y)
		{
			return 0;
		}
	}

	[BurstCompile]
	private struct SegmentSort<T, U> : IJobParallelFor where T : struct where U : IComparer<T>
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Data;

		public U Comp;

		public int Length;

		public int SegmentWidth;

		public void Execute(int index)
		{
		}
	}

	[BurstCompile]
	private struct SegmentSortMerge<T, U> : IJob where T : struct where U : IComparer<T>
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Data;

		public U Comp;

		public int Length;

		public int SegmentWidth;

		public void Execute()
		{
		}
	}

	private const int k_IntrosortSizeThreshold = 16;

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static void Sort<T>(T* array, int length) where T : unmanaged, IComparable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static void Sort<T, U>(T* array, int length, U comp) where T : unmanaged where U : IComparer<T>
	{
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(T*, int).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public unsafe static JobHandle Sort<T>(T* array, int length, JobHandle inputDeps) where T : unmanaged, IComparable<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static SortJob<T, DefaultComparer<T>> SortJob<T>(T* array, int length) where T : unmanaged, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(T*, int, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public unsafe static JobHandle Sort<T, U>(T* array, int length, U comp, JobHandle inputDeps) where T : unmanaged where U : IComparer<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static SortJob<T, U> SortJob<T, U>(T* array, int length, U comp) where T : unmanaged where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static int BinarySearch<T>(T* ptr, int length, T value) where T : unmanaged, IComparable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public unsafe static int BinarySearch<T, U>(T* ptr, int length, T value, U comp) where T : unmanaged where U : IComparer<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static void Sort<T>(this NativeArray<T> array) where T : struct, IComparable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static void Sort<T, U>(this NativeArray<T> array, U comp) where T : struct where U : IComparer<T>
	{
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeArray<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T>(this NativeArray<T> array, JobHandle inputDeps) where T : struct, IComparable<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeArray<T> array) where T : struct, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeArray<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T, U>(this NativeArray<T> array, U comp, JobHandle inputDeps) where T : struct where U : IComparer<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static SortJob<T, U> SortJob<T, U>(this NativeArray<T> array, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this NativeArray<T> array, T value) where T : struct, IComparable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this NativeArray<T> array, T value, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static void Sort<T>(this NativeList<T> list) where T : struct, IComparable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static void Sort<T, U>(this NativeList<T> list, U comp) where T : struct where U : IComparer<T>
	{
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeList<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T>(this NativeList<T> array, JobHandle inputDeps) where T : struct, IComparable<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeList<T> list) where T : struct, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeList<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T, U>(this NativeList<T> list, U comp, JobHandle inputDeps) where T : struct where U : IComparer<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static SortJob<T, U> SortJob<T, U>(this NativeList<T> list, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this NativeList<T> list, T value) where T : struct, IComparable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this NativeList<T> list, T value, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static void Sort<T>(this UnsafeList<T> list) where T : struct, IComparable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static void Sort<T, U>(this UnsafeList<T> list, U comp) where T : struct where U : IComparer<T>
	{
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T>(this UnsafeList<T> list, JobHandle inputDeps) where T : struct, IComparable<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public static SortJob<T, DefaultComparer<T>> SortJob<T>(this UnsafeList<T> list) where T : struct, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T, U>(this UnsafeList<T> list, U comp, JobHandle inputDeps) where T : struct where U : IComparer<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static SortJob<T, U> SortJob<T, U>(this UnsafeList<T> list, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this UnsafeList<T> list, T value) where T : struct, IComparable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this UnsafeList<T> list, T value, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static void Sort<T>(this NativeSlice<T> slice) where T : struct, IComparable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static void Sort<T, U>(this NativeSlice<T> slice, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Obsolete("Instead call SortJob(this NativeSlice<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	[NotBurstCompatible]
	public static JobHandle Sort<T>(this NativeSlice<T> slice, JobHandle inputDeps) where T : struct, IComparable<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
	public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeSlice<T> slice) where T : struct, IComparable<T>
	{
		return default(SortJob<T, DefaultComparer<T>>);
	}

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeSlice<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", false)]
	public static JobHandle Sort<T, U>(this NativeSlice<T> slice, U comp, JobHandle inputDeps) where T : struct where U : IComparer<T>
	{
		return default(JobHandle);
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static SortJob<T, U> SortJob<T, U>(this NativeSlice<T> slice, U comp) where T : struct where U : IComparer<T>
	{
		return default(SortJob<T, U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int BinarySearch<T>(this NativeSlice<T> slice, T value) where T : struct, IComparable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	public static int BinarySearch<T, U>(this NativeSlice<T> slice, T value, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(DefaultComparer<int>)
	})]
	internal unsafe static void IntroSort<T, U>(void* array, int length, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void IntroSort<T, U>(void* array, int lo, int hi, int depth, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static int Partition<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	private unsafe static void HeapSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void Heapify<T, U>(void* array, int i, int n, int lo, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void Swap<T>(void* array, int lhs, int rhs) where T : struct
	{
	}

	private unsafe static void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void IntroSortStruct<T, U>(void* array, int length, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void IntroSortStruct<T, U>(void* array, int lo, int hi, int depth, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void InsertionSortStruct<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static int PartitionStruct<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
		return 0;
	}

	private unsafe static void HeapSortStruct<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void HeapifyStruct<T, U>(void* array, int i, int n, int lo, U comp) where T : struct where U : IComparer<T>
	{
	}

	private unsafe static void SwapStruct<T>(void* array, int lhs, int rhs) where T : struct
	{
	}

	private unsafe static void SwapIfGreaterWithItemsStruct<T, U>(void* array, int lhs, int rhs, U comp) where T : struct where U : IComparer<T>
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckStrideMatchesSize<T>(int stride) where T : struct
	{
	}
}
