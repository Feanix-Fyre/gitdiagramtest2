using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs;

public static class IJobForExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ForJobStruct<T> where T : struct, IJobFor
	{
		public delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData;

		[BurstDiscard]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobFor
	{
	}

	private static IntPtr GetReflectionData<T>() where T : struct, IJobFor
	{
		return (IntPtr)0;
	}

	public static JobHandle ScheduleParallel<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : struct, IJobFor
	{
		return default(JobHandle);
	}
}
