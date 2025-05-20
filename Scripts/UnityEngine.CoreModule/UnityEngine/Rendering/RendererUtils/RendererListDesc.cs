namespace UnityEngine.Rendering.RendererUtils;

public struct RendererListDesc
{
	public SortingCriteria sortingCriteria;

	public PerObjectData rendererConfiguration;

	public RenderQueueRange renderQueueRange;

	public RenderStateBlock? stateBlock;

	public Shader overrideShader;

	public Material overrideMaterial;

	public bool excludeObjectMotionVectors;

	public int layerMask;

	public uint renderingLayerMask;

	public int overrideMaterialPassIndex;

	public int overrideShaderPassIndex;

	private static readonly ShaderTagId s_EmptyName;

	internal CullingResults cullingResult { get; }

	internal Camera camera { get; }

	internal ShaderTagId passName { get; }

	internal ShaderTagId[] passNames { get; }

	public bool IsValid()
	{
		return false;
	}

	public static RendererListParams ConvertToParameters(in RendererListDesc desc)
	{
		return default(RendererListParams);
	}
}
