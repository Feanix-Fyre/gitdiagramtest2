using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Jobs;

public static class IJobBurstSchedulableExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct JobBurstSchedulableProducer<T> where T : struct, IJobBurstSchedulable
	{
		internal delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly SharedStatic<IntPtr> jobReflectionData;

		[Preserve]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJobBurstSchedulable
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReflectionDataCorrect(IntPtr reflectionData)
	{
	}

	public static JobHandle Schedule<T>(this T jobData, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobBurstSchedulable
	{
		return default(JobHandle);
	}

	public static void Run<T>(this T jobData) where T : struct, IJobBurstSchedulable
	{
	}
}
