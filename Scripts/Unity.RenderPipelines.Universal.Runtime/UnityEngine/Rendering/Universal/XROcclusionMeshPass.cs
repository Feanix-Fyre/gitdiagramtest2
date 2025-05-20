using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class XROcclusionMeshPass : ScriptableRenderPass
{
	private class PassData
	{
		internal RenderingData renderingData;

		internal TextureHandle cameraColorAttachment;

		internal TextureHandle cameraDepthAttachment;

		internal bool isActiveTargetBackBuffer;
	}

	private PassData m_PassData;

	public bool m_IsActiveTargetBackBuffer;

	public XROcclusionMeshPass(RenderPassEvent evt)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData data)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void Render(RenderGraph renderGraph, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment, ref RenderingData renderingData)
	{
	}
}
