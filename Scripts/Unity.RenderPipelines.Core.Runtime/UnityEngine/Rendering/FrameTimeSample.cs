namespace UnityEngine.Rendering;

internal struct FrameTimeSample
{
	internal float FramesPerSecond;

	internal float FullFrameTime;

	internal float MainThreadCPUFrameTime;

	internal float MainThreadCPUPresentWaitTime;

	internal float RenderThreadCPUFrameTime;

	internal float GPUFrameTime;

	internal FrameTimeSample(float initValue)
	{
		FramesPerSecond = 0f;
		FullFrameTime = 0f;
		MainThreadCPUFrameTime = 0f;
		MainThreadCPUPresentWaitTime = 0f;
		RenderThreadCPUFrameTime = 0f;
		GPUFrameTime = 0f;
	}
}
