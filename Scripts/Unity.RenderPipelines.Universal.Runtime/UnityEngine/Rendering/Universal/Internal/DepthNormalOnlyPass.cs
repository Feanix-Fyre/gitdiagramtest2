using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class DepthNormalOnlyPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle cameraDepthTexture;

		internal TextureHandle cameraNormalsTexture;

		internal RenderingData renderingData;

		internal List<ShaderTagId> shaderTagIds;

		internal FilteringSettings filteringSettings;

		internal bool enableRenderingLayers;
	}

	private FilteringSettings m_FilteringSettings;

	private PassData m_PassData;

	private static readonly List<ShaderTagId> k_DepthNormals;

	private static readonly RTHandle[] k_ColorAttachment1;

	private static readonly RTHandle[] k_ColorAttachment2;

	internal List<ShaderTagId> shaderTagIds { get; set; }

	private RTHandle depthHandle { get; set; }

	private RTHandle normalHandle { get; set; }

	private RTHandle renderingLayersHandle { get; set; }

	internal bool enableRenderingLayers { get; set; }

	public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
	{
	}

	public static GraphicsFormat GetGraphicsFormat()
	{
		return default(GraphicsFormat);
	}

	public void Setup(RTHandle depthHandle, RTHandle normalHandle)
	{
	}

	public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle)
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

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}

	internal void Render(RenderGraph renderGraph, out TextureHandle cameraNormalsTexture, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
	{
		cameraNormalsTexture = default(TextureHandle);
		cameraDepthTexture = default(TextureHandle);
	}
}
