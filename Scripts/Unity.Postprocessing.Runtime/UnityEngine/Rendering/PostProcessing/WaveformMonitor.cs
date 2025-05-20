using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class WaveformMonitor : Monitor
{
	public float exposure;

	public int height;

	private ComputeBuffer m_Data;

	private const int k_ThreadGroupSize = 256;

	private const int k_ThreadGroupSizeX = 16;

	private const int k_ThreadGroupSizeY = 16;

	internal override void OnDisable()
	{
	}

	internal override bool NeedsHalfRes()
	{
		return false;
	}

	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	internal override void Render(PostProcessRenderContext context)
	{
	}
}
