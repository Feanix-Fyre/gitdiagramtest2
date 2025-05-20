using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class DrawObjectsPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle m_Albedo;

		internal TextureHandle m_Depth;

		internal RenderingData m_RenderingData;

		internal bool m_IsOpaque;

		internal RenderStateBlock m_RenderStateBlock;

		internal FilteringSettings m_FilteringSettings;

		internal List<ShaderTagId> m_ShaderTagIdList;

		internal ProfilingSampler m_ProfilingSampler;

		internal bool m_ShouldTransparentsReceiveShadows;

		internal bool m_IsActiveTargetBackBuffer;

		internal DrawObjectsPass pass;
	}

	private FilteringSettings m_FilteringSettings;

	private RenderStateBlock m_RenderStateBlock;

	private List<ShaderTagId> m_ShaderTagIdList;

	private string m_ProfilerTag;

	private ProfilingSampler m_ProfilingSampler;

	private bool m_IsOpaque;

	public bool m_IsActiveTargetBackBuffer;

	public bool m_ShouldTransparentsReceiveShadows;

	private PassData m_PassData;

	private bool m_UseDepthPriming;

	private static readonly int s_DrawObjectPassDataPropID;

	public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
	{
	}

	public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
	{
	}

	internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void CameraSetup(CommandBuffer cmd, PassData data, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool yFlip)
	{
	}

	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, ref RenderingData renderingData)
	{
	}

	protected virtual void OnExecute(CommandBuffer cmd)
	{
	}
}
