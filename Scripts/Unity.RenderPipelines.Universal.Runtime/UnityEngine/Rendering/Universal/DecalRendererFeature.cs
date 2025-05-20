using System.Diagnostics;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Decal")]
[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
internal class DecalRendererFeature : ScriptableRendererFeature
{
	[SerializeField]
	private DecalSettings m_Settings;

	[HideInInspector]
	[Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
	[SerializeField]
	private Shader m_CopyDepthPS;

	[SerializeField]
	[HideInInspector]
	[Reload("Runtime/Decal/DBuffer/DBufferClear.shader", ReloadAttribute.Package.Root)]
	private Shader m_DBufferClear;

	private DecalTechnique m_Technique;

	private DBufferSettings m_DBufferSettings;

	private DecalScreenSpaceSettings m_ScreenSpaceSettings;

	private bool m_RecreateSystems;

	private CopyDepthPass m_CopyDepthPass;

	private DecalPreviewPass m_DecalPreviewPass;

	private Material m_CopyDepthMaterial;

	private DecalEntityManager m_DecalEntityManager;

	private DecalUpdateCachedSystem m_DecalUpdateCachedSystem;

	private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;

	private DecalUpdateCulledSystem m_DecalUpdateCulledSystem;

	private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;

	private DecalDrawErrorSystem m_DrawErrorSystem;

	private DBufferRenderPass m_DBufferRenderPass;

	private DecalForwardEmissivePass m_ForwardEmissivePass;

	private DecalDrawDBufferSystem m_DecalDrawDBufferSystem;

	private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;

	private Material m_DBufferClearMaterial;

	private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;

	private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;

	private DecalSkipCulledSystem m_DecalSkipCulledSystem;

	private DecalGBufferRenderPass m_GBufferRenderPass;

	private DecalDrawGBufferSystem m_DrawGBufferSystem;

	private DeferredLights m_DeferredLights;

	private static SharedDecalEntityManager sharedDecalEntityManager { get; }

	internal ref DecalSettings settings
	{
		get
		{
			throw null;
		}
	}

	internal bool intermediateRendering => false;

	internal bool requiresDecalLayers => false;

	internal static bool isGLDevice => false;

	public override void Create()
	{
	}

	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		atEvent = default(RenderingLayerUtils.Event);
		maskSize = default(RenderingLayerUtils.MaskSize);
		return false;
	}

	internal DBufferSettings GetDBufferSettings()
	{
		return null;
	}

	internal DecalScreenSpaceSettings GetScreenSpaceSettings()
	{
		return null;
	}

	internal DecalTechnique GetTechnique(ScriptableRendererData renderer)
	{
		return default(DecalTechnique);
	}

	internal DecalTechnique GetTechnique(ScriptableRenderer renderer)
	{
		return default(DecalTechnique);
	}

	internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true)
	{
		return default(DecalTechnique);
	}

	private bool IsAutomaticDBuffer()
	{
		return false;
	}

	private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
	{
		return false;
	}

	public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	internal override bool SupportsNativeRenderPass()
	{
		return false;
	}

	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	[Conditional("ADAPTIVE_PERFORMANCE_4_0_0_OR_NEWER")]
	private void ChangeAdaptivePerformanceDrawDistances()
	{
	}
}
