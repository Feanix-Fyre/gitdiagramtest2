using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Jobs;

public static class JobParallelIndexListExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct JobParallelForFilterProducer<T> where T : struct, IJobParallelForFilter
	{
		public struct JobWrapper
		{
			[NativeDisableParallelForRestriction]
			public NativeList<int> outputIndices;

			public int appendCount;

			public T JobData;
		}

		public delegate void ExecuteJobFunction(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly SharedStatic<IntPtr> jobReflectionData;

		[Preserve]
		public static void Initialize()
		{
		}

		public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}

		public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData)
		{
		}

		public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobParallelForFilter
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReflectionDataCorrect(IntPtr reflectionData)
	{
	}

	public static JobHandle ScheduleAppend<T>(this T jobData, NativeList<int> indices, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForFilter
	{
		return default(JobHandle);
	}

	public static JobHandle ScheduleFilter<T>(this T jobData, NativeList<int> indices, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForFilter
	{
		return default(JobHandle);
	}

	public static void RunAppend<T>(this T jobData, NativeList<int> indices, int arrayLength) where T : struct, IJobParallelForFilter
	{
	}

	public static void RunFilter<T>(this T jobData, NativeList<int> indices) where T : struct, IJobParallelForFilter
	{
	}
}
