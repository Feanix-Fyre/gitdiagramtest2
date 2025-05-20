using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class DrawSkyboxPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle color;

		internal TextureHandle depth;

		internal RenderingData renderingData;

		internal DrawSkyboxPass pass;
	}

	public bool m_IsActiveTargetBackBuffer;

	public DrawSkyboxPass(RenderPassEvent evt)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, CameraData cameraData)
	{
		return default(RendererList);
	}

	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
	{
	}
}
