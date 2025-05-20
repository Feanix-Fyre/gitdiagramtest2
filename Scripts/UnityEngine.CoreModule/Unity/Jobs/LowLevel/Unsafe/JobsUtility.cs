using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[NativeHeader("Runtime/Jobs/JobSystem.h")]
public static class JobsUtility
{
	public struct JobScheduleParameters
	{
		public JobHandle Dependency;

		public int ScheduleMode;

		public IntPtr ReflectionData;

		public IntPtr JobDataPtr;

		public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
		{
			Dependency = default(JobHandle);
			ScheduleMode = 0;
			ReflectionData = (IntPtr)0;
			JobDataPtr = (IntPtr)0;
		}
	}

	internal delegate void PanicFunction_();

	internal static PanicFunction_ PanicFunction;

	public static bool IsExecutingJob
	{
		[NativeMethod(IsFreeFunction = true, IsThreadSafe = true)]
		get
		{
			return false;
		}
	}

	public static bool JobCompilerEnabled
	{
		[FreeFunction]
		set
		{
		}
	}

	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
	{
		beginIndex = default(int);
		endIndex = default(int);
	}

	[NativeMethod(IsFreeFunction = true, IsThreadSafe = true)]
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
	{
		beginIndex = default(int);
		endIndex = default(int);
		return false;
	}

	[FreeFunction("ScheduleManagedJob", ThrowsException = true, IsThreadSafe = true)]
	public static JobHandle Schedule(ref JobScheduleParameters parameters)
	{
		return default(JobHandle);
	}

	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = true, IsThreadSafe = true)]
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
	{
		return default(JobHandle);
	}

	[FreeFunction("ScheduleManagedJobParallelForDeferArraySize", ThrowsException = true, IsThreadSafe = true)]
	public unsafe static JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle)
	{
		return default(JobHandle);
	}

	[FreeFunction("ScheduleManagedJobParallelForTransform", ThrowsException = true)]
	public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray)
	{
		return default(JobHandle);
	}

	[FreeFunction(ThrowsException = true, IsThreadSafe = true)]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0)
	{
		return (IntPtr)0;
	}

	[RequiredByNativeCode]
	private static void InvokePanicFunction()
	{
	}

	private static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret)
	{
		ret = default(JobHandle);
	}

	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
	{
		ret = default(JobHandle);
	}

	private unsafe static void ScheduleParallelForDeferArraySize_Injected(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret)
	{
		ret = default(JobHandle);
	}

	private static void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret)
	{
		ret = default(JobHandle);
	}
}
