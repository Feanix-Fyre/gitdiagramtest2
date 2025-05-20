using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
public static class UISystemProfilerApi
{
	public enum SampleType
	{
		Layout = 0,
		Render = 1
	}

	public static void BeginSample(SampleType type)
	{
	}

	public static void EndSample(SampleType type)
	{
	}

	public static void AddMarker(string name, Object obj)
	{
	}
}
