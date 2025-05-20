namespace UnityEngine.Rendering.Universal;

internal class UpscalePass : ScriptableRenderPass
{
	private static readonly ProfilingSampler m_ProfilingScope;

	private RTHandle m_Source;

	private RTHandle m_UpscaleHandle;

	private static Material m_BlitMaterial;

	public UpscalePass(RenderPassEvent evt, Material blitMaterial)
	{
	}

	public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, ref RenderingData renderingData, out RTHandle upscaleHandle)
	{
		upscaleHandle = null;
	}

	public void Dispose()
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
