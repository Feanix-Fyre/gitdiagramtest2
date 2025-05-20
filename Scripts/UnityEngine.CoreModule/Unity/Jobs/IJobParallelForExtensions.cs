using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs;

public static class IJobParallelForExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ParallelForJobStruct<T> where T : struct, IJobParallelFor
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

	private static IntPtr GetReflectionData<T>() where T : struct, IJobParallelFor
	{
		return (IntPtr)0;
	}

	public static JobHandle Schedule<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelFor
	{
		return default(JobHandle);
	}
}
