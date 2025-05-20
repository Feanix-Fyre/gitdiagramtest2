using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class DepthOnlyPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle cameraDepthTexture;

		internal RenderingData renderingData;

		internal ShaderTagId shaderTagId;

		internal FilteringSettings filteringSettings;
	}

	private static readonly ShaderTagId k_ShaderTagId;

	private GraphicsFormat depthStencilFormat;

	private PassData m_PassData;

	private FilteringSettings m_FilteringSettings;

	private RTHandle destination { get; set; }

	internal ShaderTagId shaderTagId { get; set; }

	public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
	{
	}

	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void Render(RenderGraph renderGraph, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
	{
		cameraDepthTexture = default(TextureHandle);
	}
}
