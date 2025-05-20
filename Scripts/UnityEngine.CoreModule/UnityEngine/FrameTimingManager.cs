using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("GetUncheckedRealGfxDevice().GetFrameTimingManager()", StaticAccessorType.Dot)]
public static class FrameTimingManager
{
	public static void CaptureFrameTimings()
	{
	}

	public static uint GetLatestTimings(uint numFrames, [Unmarshalled] FrameTiming[] timings)
	{
		return 0u;
	}
}
