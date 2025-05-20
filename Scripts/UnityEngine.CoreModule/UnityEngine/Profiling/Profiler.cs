using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
public sealed class Profiler
{
	[NativeConditional("ENABLE_PROFILER")]
	public static void EndThreadProfiling()
	{
	}

	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = true)]
	public static long GetRuntimeMemorySizeLong([NotNull("ArgumentNullException")] Object o)
	{
		return 0L;
	}
}
