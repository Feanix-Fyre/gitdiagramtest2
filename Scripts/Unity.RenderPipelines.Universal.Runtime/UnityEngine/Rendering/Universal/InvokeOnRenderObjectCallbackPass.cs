using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

internal class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle colorTarget;

		internal TextureHandle depthTarget;
	}

	public InvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
	{
	}
}
