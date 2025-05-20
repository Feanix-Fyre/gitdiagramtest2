using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle>
{
	internal ulong jobGroup;

	internal int version;

	public bool IsCompleted => false;

	public void Complete()
	{
	}

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
	public static void ScheduleBatchedJobs()
	{
	}

	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
	{
	}

	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
	{
		return false;
	}

	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
	{
		return default(JobHandle);
	}

	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs)
	{
		return default(JobHandle);
	}

	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs)
	{
		return default(JobHandle);
	}

	[NativeMethod(IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
	{
		return default(JobHandle);
	}

	[NativeMethod(IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
	internal unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
	{
		return default(JobHandle);
	}

	public bool Equals(JobHandle other)
	{
		return false;
	}

	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
	{
		ret = default(JobHandle);
	}

	private unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
	{
		ret = default(JobHandle);
	}
}
