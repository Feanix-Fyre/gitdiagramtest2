using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

internal class DeferredPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle color;

		internal TextureHandle depth;

		internal RenderingData renderingData;

		internal DeferredLights deferredLights;
	}

	private DeferredLights m_DeferredLights;

	public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
	{
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void Render(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer, ref RenderingData renderingData)
	{
	}

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
