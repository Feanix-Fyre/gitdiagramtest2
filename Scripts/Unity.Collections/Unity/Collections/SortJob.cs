using System;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(NativeSortExtension.DefaultComparer<int>)
})]
public struct SortJob<T, U> where T : struct where U : IComparer<T>
{
	[BurstCompile]
	private struct SegmentSort : IJobParallelFor
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
	private struct SegmentSortMerge : IJob
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

	public unsafe T* Data;

	public U Comp;

	public int Length;

	[NotBurstCompatible]
	public JobHandle Schedule(JobHandle inputDeps = default(JobHandle))
	{
		return default(JobHandle);
	}
}
