using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

internal class GBufferPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle[] gbuffer;

		internal TextureHandle depth;

		internal RenderingData renderingData;

		internal DeferredLights deferredLights;

		internal FilteringSettings filteringSettings;

		internal DrawingSettings drawingSettings;
	}

	private static readonly int s_CameraNormalsTextureID;

	private static ShaderTagId s_ShaderTagLit;

	private static ShaderTagId s_ShaderTagSimpleLit;

	private static ShaderTagId s_ShaderTagUnlit;

	private static ShaderTagId s_ShaderTagComplexLit;

	private static ShaderTagId s_ShaderTagUniversalGBuffer;

	private static ShaderTagId s_ShaderTagUniversalMaterialType;

	private ProfilingSampler m_ProfilingSampler;

	private DeferredLights m_DeferredLights;

	private static ShaderTagId[] s_ShaderTagValues;

	private static RenderStateBlock[] s_RenderStateBlocks;

	private FilteringSettings m_FilteringSettings;

	private RenderStateBlock m_RenderStateBlock;

	private PassData m_PassData;

	public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights)
	{
	}

	public void Dispose()
	{
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool useRenderGraph = false)
	{
	}

	internal void Render(RenderGraph renderGraph, TextureHandle cameraColor, TextureHandle cameraDepth, ref RenderingData renderingData, ref UniversalRenderer.RenderGraphFrameResources frameResources)
	{
	}
}
