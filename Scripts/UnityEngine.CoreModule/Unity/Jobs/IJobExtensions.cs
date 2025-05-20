using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs;

public static class IJobExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct JobStruct<T> where T : struct, IJob
	{
		internal delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData;

		[BurstDiscard]
		internal static void Initialize()
		{
		}

		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	public static void EarlyJobInit<T>() where T : struct, IJob
	{
	}

	private static IntPtr GetReflectionData<T>() where T : struct, IJob
	{
		return (IntPtr)0;
	}

	public static JobHandle Schedule<T>(this T jobData, JobHandle dependsOn = default(JobHandle)) where T : struct, IJob
	{
		return default(JobHandle);
	}
}
