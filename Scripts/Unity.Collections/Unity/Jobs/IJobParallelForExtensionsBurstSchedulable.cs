using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Jobs;

public static class IJobParallelForExtensionsBurstSchedulable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct JobParallelForBurstSchedulableProducer<T> where T : struct, IJobParallelForBurstSchedulable
	{
		internal delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly SharedStatic<IntPtr> jobReflectionData;

		[Preserve]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobParallelForBurstSchedulable
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReflectionDataCorrect(IntPtr reflectionData)
	{
	}

	public static JobHandle Schedule<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBurstSchedulable
	{
		return default(JobHandle);
	}

	public static void Run<T>(this T jobData, int arrayLength) where T : struct, IJobParallelForBurstSchedulable
	{
	}
}
