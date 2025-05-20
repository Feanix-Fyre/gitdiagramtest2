using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Jobs;

public static class IJobParallelForDeferExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct JobParallelForDeferProducer<T> where T : struct, IJobParallelForDefer
	{
		public delegate void ExecuteJobFunction(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly SharedStatic<IntPtr> jobReflectionData;

		[Preserve]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobParallelForDefer
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReflectionDataCorrect(IntPtr reflectionData)
	{
	}

	public static JobHandle Schedule<T, U>(this T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer where U : struct
	{
		return default(JobHandle);
	}

	public static JobHandle ScheduleByRef<T, U>(this ref T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer where U : struct
	{
		return default(JobHandle);
	}

	public unsafe static JobHandle Schedule<T>(this T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer
	{
		return default(JobHandle);
	}

	public unsafe static JobHandle ScheduleByRef<T>(this ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer
	{
		return default(JobHandle);
	}

	private unsafe static JobHandle ScheduleInternal<T>(ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn) where T : struct, IJobParallelForDefer
	{
		return default(JobHandle);
	}
}
