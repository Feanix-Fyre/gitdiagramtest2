using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Jobs;

public static class IJobParallelForTransformExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct TransformParallelForLoopStruct<T> where T : struct, IJobParallelForTransform
	{
		private struct TransformJobData
		{
			public IntPtr TransformAccessArray;

			public int IsReadOnly;
		}

		public delegate void ExecuteJobFunction(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData;

		[BurstDiscard]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobParallelForTransform
	{
	}

	private static IntPtr GetReflectionData<T>() where T : struct, IJobParallelForTransform
	{
		return (IntPtr)0;
	}

	public static JobHandle Schedule<T>(this T jobData, TransformAccessArray transforms, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForTransform
	{
		return default(JobHandle);
	}
}
