using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D
{
	private static readonly int k_HDREmulationScaleID;

	private static readonly int k_InverseHDREmulationScaleID;

	private static readonly int k_UseSceneLightingID;

	private static readonly int k_RendererColorID;

	private static readonly int[] k_ShapeLightTextureIDs;

	private static readonly ShaderTagId k_CombinedRenderingPassName;

	private static readonly ShaderTagId k_NormalsRenderingPassName;

	private static readonly ShaderTagId k_LegacyPassName;

	private static readonly List<ShaderTagId> k_ShaderTags;

	private static readonly ProfilingSampler m_ProfilingDrawLights;

	private static readonly ProfilingSampler m_ProfilingDrawLightTextures;

	private static readonly ProfilingSampler m_ProfilingDrawRenderers;

	private static readonly ProfilingSampler m_ProfilingDrawLayerBatch;

	private static readonly ProfilingSampler m_ProfilingSamplerUnlit;

	private Material m_BlitMaterial;

	private Material m_SamplingMaterial;

	private readonly Renderer2DData m_Renderer2DData;

	private bool m_NeedsDepth;

	private short m_CameraSortingLayerBoundsIndex;

	Renderer2DData IRenderPass2D.rendererData => null;

	public Render2DLightingPass(Renderer2DData rendererData, Material blitMaterial, Material samplingMaterial)
	{
	}

	internal void Setup(bool useDepth)
	{
	}

	private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings)
	{
	}

	private void CopyCameraSortingLayerRenderTexture(ScriptableRenderContext context, RenderingData renderingData, RenderBufferStoreAction mainTargetStoreAction)
	{
	}

	private short GetCameraSortingLayerBoundsIndex()
	{
		return 0;
	}

	private void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, LayerBatch[] layerBatches, out int resolveDuringBatch, out bool resolveIsAfterCopy)
	{
		resolveDuringBatch = default(int);
		resolveIsAfterCopy = default(bool);
	}

	private void Render(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref FilteringSettings filterSettings, DrawingSettings drawSettings)
	{
	}

	private int DrawLayerBatches(LayerBatch[] layerBatches, int batchCount, int startIndex, CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData, ref FilteringSettings filterSettings, ref DrawingSettings normalsDrawSettings, ref DrawingSettings drawSettings, ref RenderTextureDescriptor desc)
	{
		return 0;
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
