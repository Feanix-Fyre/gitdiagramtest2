using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class LightMeterMonitor : Monitor
{
	public int width;

	public int height;

	public bool showCurves;

	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	internal override void Render(PostProcessRenderContext context)
	{
	}
}
