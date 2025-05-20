using System;
using System.Diagnostics;
using Unity.Burst;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling;

[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
[DebuggerDisplay("Count = {Count}")]
[UsedByNativeCode]
[DebuggerTypeProxy(typeof(ProfilerRecorderDebugView))]
public struct ProfilerRecorder : IDisposable
{
	internal enum ControlOptions
	{
		Start = 0,
		Stop = 1,
		Reset = 2,
		Release = 4,
		SetFilterToCurrentThread = 5,
		SetToCollectFromAllThreads = 6
	}

	internal enum CountOptions
	{
		Count = 0,
		MaxCount = 1
	}

	internal ulong handle;

	internal const ProfilerRecorderOptions SharedRecorder = (ProfilerRecorderOptions)128;

	public bool Valid => false;

	public long LastValue => 0L;

	public int Count => 0;

	public bool IsRunning => false;

	public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default)
	{
		handle = 0uL;
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public ProfilerRecorderSample GetSample(int index)
	{
		return default(ProfilerRecorderSample);
	}

	[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options)
	{
		return default(ProfilerRecorder);
	}

	[NativeMethod(IsThreadSafe = true)]
	private static void Control(ProfilerRecorder handle, ControlOptions options)
	{
	}

	[NativeMethod(IsThreadSafe = true)]
	private static long GetLastValue(ProfilerRecorder handle)
	{
		return 0L;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static int GetCount(ProfilerRecorder handle, CountOptions countOptions)
	{
		return 0;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static bool GetValid(ProfilerRecorder handle)
	{
		return false;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static bool GetRunning(ProfilerRecorder handle)
	{
		return false;
	}

	[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
	private static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index)
	{
		return default(ProfilerRecorderSample);
	}

	public void Dispose()
	{
	}

	[BurstDiscard]
	private void CheckInitializedAndThrow()
	{
	}

	private static void Create_Injected(ref ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret)
	{
		ret = default(ProfilerRecorder);
	}

	private static void Control_Injected(ref ProfilerRecorder handle, ControlOptions options)
	{
	}

	private static long GetLastValue_Injected(ref ProfilerRecorder handle)
	{
		return 0L;
	}

	private static int GetCount_Injected(ref ProfilerRecorder handle, CountOptions countOptions)
	{
		return 0;
	}

	private static bool GetValid_Injected(ref ProfilerRecorder handle)
	{
		return false;
	}

	private static bool GetRunning_Injected(ref ProfilerRecorder handle)
	{
		return false;
	}

	private static void GetSampleInternal_Injected(ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret)
	{
		ret = default(ProfilerRecorderSample);
	}
}
